using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TestRSAPICS;

namespace DataBoxer
{
    public partial class Runscore : Form
    {
        public Runscore()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Boolean r = rsapi.Open("localhost", 33000);
            string event_name = "Finish";
            if (r == true)
            {
                rsapi.login("", "", "7.2.8.26");
                // Get list of field names
                FieldList fieldList = new FieldList();
                int record_length = fieldList.recordLength();
                for (int i = 0; i < 3; i++)
                {
                    FieldInfo f = fieldList[i];
                    Console.WriteLine("no.: {0}, name: {1}, length: {2}", f.no, f.name, f.length);
                }
                Console.WriteLine("Record length: {0}", record_length);
                // Read in record number 2. readrec() breaks the record apart
                // and puts into appropriate fields.
                fieldList.readRec(2);
                for (int i = 0; i < 5; i++)
                {
                    FieldInfo f = fieldList[i];
                    Console.WriteLine("no.: {0}, name: {1}, data: {2}", f.no, f.name, f.data);
                }
                // Write a new record
                // Create data
                List<string> fieldname = new List<string>();
                fieldname.Add("First Name");
                fieldname.Add("Last Name");
                fieldname.Add("Age");
                fieldname.Add("Sex");
                List<string> names = new List<string>();
                names.Add("David");
                names.Add("Smith");
                names.Add("45");
                names.Add("M");
                // Clear out all the datafields
                //fieldList.clear();
                // Stuff in the data for the selected fields
                // If a field name is not found, putDataInField skips it.
                for (int i = 0; i < 4; i++)
                {
                    fieldList.putDataInField(fieldname[i], names[i]);
                }
                fieldList.appendRecord();
                // Pull out names of first 3 finishers
                int n_times = rsapi.getN_times(event_name);
                Console.WriteLine("Number of times {0}", n_times);
                int[] times = new int[3];
                rsapi.getTimes(event_name, 0, 3, times, 3);
                int[] fins = new int[3];
                rsapi.getFins(event_name, 0, 3, fins, 3);
                for (int i = 0; i < 3; i++)
                {
                    fieldList.readRec(fins[i]);
                    Console.WriteLine("{0,5} {1} {2} {3} {4}", i + 1,
                        fieldList[0].data, fieldList[1].data, fieldList[2].data, aux.fmt(times[i]));
                }
                Console.ReadLine();
                rsapi.Close();
            }
        }
    }
}
