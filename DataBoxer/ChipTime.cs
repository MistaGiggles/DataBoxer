using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataBoxer
{
    class ChipTime
    {
        string chip;
        string time;
        char box;
        int mat;

        public string getID()
        {
            return chip;
        }
        public ChipTime(string _c, string _t, char _b, int _m)
        {
            chip = _c;
            time = _t;
            box = _b;
            mat = _m;
        }

        public ChipTime(byte[] _c, byte[] _t, char _b, int _m)
        {
            chip = toChip(_c);
            time = toTime(_t);
            box = _b;
            mat = _m;
        }

        public string generateComm()
        {
            string output = System.String.Format("\"{0}{1}????{2}{3}\"", box, mat, time, chip);
            return output;
        }

        public string toTime(byte[] t)
        {
            string result = "";
            if (t[0].ToString().Length == 1) { result += "0"; }
            result += t[0].ToString();
            result += ":";
            if (t[1].ToString().Length == 1) { result += "0"; }
            result += t[1].ToString();
            result += ":";
            if (t[2].ToString().Length == 1) { result += "0"; }
            result += t[2].ToString();
            result += "."; 
            result += t[3].ToString();
            return result;
        }

        public string toChip(byte[] c)
        {
            string result = "";
            for (int i = 0; i < c.Length; i++)
            {
                if (i == 2) { result += " "; }
                result += String.Format("{0:X2}", c[i]);
            }
            return result;
        }
    }
}
