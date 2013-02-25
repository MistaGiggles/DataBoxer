using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;     // DLL support

namespace TestRSAPICS
{
    class rsapi
    {
        [DllImport("rsapi.dll")]
        public static extern bool Open(string addr, int port);
        [DllImport("rsapi.dll")]
        public static extern int login(string userid, string password, string version);
        [DllImport("rsapi.dll")]
        public static extern int getN_bibs(string evt);
        [DllImport("rsapi.dll")]
        public static extern int getN_records();
        [DllImport("rsapi.dll")]
        public static extern int getBibFieldNo();
        [DllImport("rsapi.dll")]
        public static extern int getN_competitors();
        [DllImport("rsapi.dll")]
        public static extern int findBib(string evt, int start, int field, string bib);
        [DllImport("rsapi.dll")]
        public static extern int findFin(string evt, int i);
        [DllImport("rsapi.dll")]
        public static extern bool getBib(string evt, int i, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] bib);
        [DllImport("rsapi.dll")]
        public static extern int getTime(string evt, int i);
        [DllImport("rsapi.dll")]
        public static extern bool getFins(string evt, int i1, int i2, int[] fins, int n);
        [DllImport("rsapi.dll")]
        public static extern int getFin(string evt, int i);
        [DllImport("rsapi.dll")]
        public static extern string getFieldName(int i);
        [DllImport("rsapi.dll")]
        public static extern int getFieldLength(int i);
        [DllImport("rsapi.dll")]
        public static extern bool readRecord([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] rec, int n, int lrecl);
        [DllImport("rsapi.dll")]
        public static extern bool writeRecord([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] rec, int n, int lrecl);
        [DllImport("rsapi.dll")]
        public static extern int getN_times(string evt);
        [DllImport("rsapi.dll")]
        public static extern bool getTimes(string evt, int i1, int i2, int[] buf, int size);
        [DllImport("rsapi.dll")]
        public static extern void Close();       

    }
    class aux {
        public static string fmt(int t)
        {
            int i = t / 100;
            return string.Format("{0:00}:{1:00}:{2:00}.{3:00}", i / 3600, (i%3600) / 60,  i% 60, t%100);
        }
    }
    public class FieldInfo {
	    // Default constructor
        public FieldInfo() { name = ""; data = ""; length = 0; }
	    // Specific constructor
        public FieldInfo(string name, int length, int no)
        {
            this.name = name;
            this.length = length;
            this.no = no;
        }
        // Use this to get information from the server on field i
        public FieldInfo(int i)
        {
	        this.length = rsapi.getFieldLength(i);
            if (this.length > 0)
            {
                this.name = rsapi.getFieldName(i);
                this.no = i;
            }
        }
	    // Copy constructor
	    // FieldInfo(FIptr fptr);
	    //~FieldInfo();
        public void Clear() { data = ""; }
	    public string name;	// Field name, e.g. "Last Name"
	    public string data;	// Data in field, e.g. "Jones"
	    public int length;	// Field length
	    public int no;		// Field number. Field numbers are not used at present
						    // but are there as reference to the field numbers in
						    // the server. Only data fields are in the FieldInfo so
						    // the field numbers are not consecutive.
    };
    // Create a list of FieldInfo
    public class FieldList : List<FieldInfo> {
        public FieldList()
        {
            for (int i = 1; true; i++)
            {
                FieldInfo f = new FieldInfo(i);
                if (f.length <= 0)
                {
                    if (f.length == -2)  // No such field. Done.
                        break;
                    if (f.length == -1)  // Not a data field
                        continue;
                }
                this.Add(f);
            }
        }
        public int recordLength()
        {
            int n = 0;
            foreach (FieldInfo f in this)
                n += f.length;
            n += 2;	// For CR/LF at end
            return n;
        }
        public bool readRec(int i)
        {
	        // Compute record length
            int record_length = this.recordLength();
            byte[] record = new  byte[record_length + 1];
            Boolean ret = rsapi.readRecord(record, i, record_length);
	        if(ret)
		        return ret;
            // Now tear the record apart
            string str = System.Text.ASCIIEncoding.ASCII.GetString(record);
            int j = 0;
            foreach(FieldInfo f in this) {
                f.data = str.Substring(j, f.length);
                j += f.length;
            }
	        return false;
        }
        // Write one record. The data is in the data fields of the FieldList vector.
        bool writeRecord(int i)
        {
            // Compute record length
            int record_length = recordLength();
            // Create temporary buffer to receive data.
            byte[] rec = new byte[record_length + 1];
            //byte[] buffer = System.Text.ASCIIEncoding.ASCII.GetBytes(hello);
            // Move data from FieldList to buffer
            string record = string.Empty;
            foreach(FieldInfo f in this) {
                string tmp = f.data.PadRight(f.length);
                record += tmp;
            }
            byte[] buffer = System.Text.ASCIIEncoding.ASCII.GetBytes(record);
            bool ret = rsapi.writeRecord(buffer, i, record_length);
            return false;
        }
   
        // Clear out data
        public void clear()
        {
            foreach (FieldInfo f in this)
                f.data = "";
        }
        // Stuff data into a field
        // Input: Field name, Data
        public bool putDataInField(string field_name,string data)
        {
            bool ret = true;
	        // Find which field, if any, this is
            foreach(FieldInfo f in this) {
                if(string.Compare(field_name,f.name,true) == 0) {
                    ret = false;
                    f.data = data;
			        break;
                }
            }	    
		    return ret;
        }
        public bool appendRecord()
        {
            int rc = rsapi.getN_records();
            writeRecord(rc);
            // Read number of records to see if it increased
            int rc2 = rsapi.getN_records();
            if (rc2 - rc == 1)
                return false;
            else
                return true;
        }
    }
}