using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataBoxer
{
    class WTCodes
    {
        //public static byte[] fetch = HexStringToBytes("0402413105");
        //public static byte[] reload = HexStringToBytes("0241313031210353");
        //public static byte[] confirm = HexStringToBytes("01413106");

        public static byte[] confirm(int b)
        {
            return HexStringToBytes("0141" + (b + 30).ToString() +"06");
        }

        public static byte[] confirmSync(int b)
        {
            return HexStringToBytes("0141" + (b + 30).ToString() + "15");
        }

        public static byte[] reload(int b)
        {
            if (b == 1)
            {
                return HexStringToBytes("040241313031210353");
            }
            string std = "040241" + (30+b).ToString() + "30312103";
            string[] ends = new string[] { "00", "53", "50", "51", "56", "57", "54", "55", "59" };
            return HexStringToBytes(std + ends[b]);
        }

        public static byte[] deletebox(int b)
        {
            string lol = "04 02 41 bb 30 31 30 03 ee";
            string[] ends = new string[] {"00", "42", "41", "40", "47", "46", "45", "44", "4b", "4a", "40", "41" };
            return HexStringToBytes("040241" + (30 + b).ToString() + "30313003" + ends[b]); 
        }

        public static byte[] sync(int b)
        {
            // format (04) 02 31 BOX 34 54 06 ddmmyyhhMMss 03 ?
            string pre = "040241" + (30 + b).ToString() + "31345406";
            string time = DateTime.Now.ToString("ddMMyyHHmmss");
            

            System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
            byte[] newtime = encoding.GetBytes(time);

            byte[] result = HexStringToBytes(pre);
            byte[] rep = new byte[result.Length + newtime.Length + 2];
            result.CopyTo(rep, 0);
            newtime.CopyTo(rep, result.Length);

            byte[] ending = HexStringToBytes("032f");
            ending.CopyTo(rep, rep.Length - 2);
            return rep;
        }

        public static byte[] fetch(int b)
        {
            return HexStringToBytes("040141" + (b + 30).ToString() + "05");
        }

        private const string hexDigits = "0123456789ABCDEF";
        public static byte[] HexStringToBytes(string str)
        {
           // Determine how many bytes there are.     
           byte[] bytes = new byte[str.Length >> 1];
           for (int i = 0; i < str.Length; i += 2)
           {
               int highDigit = hexDigits.IndexOf(Char.ToUpperInvariant(str[i]));
               int lowDigit = hexDigits.IndexOf(Char.ToUpperInvariant(str[i + 1]));
               if (highDigit == -1 || lowDigit == -1)
               {
                   throw new ArgumentException("The string contains an invalid digit.", str[i].ToString());
               }
               bytes[i >> 1] = (byte)((highDigit << 4) | lowDigit);
           }
           return bytes;
        }

        public static bool matches(byte[] a, byte[] b)
        {
            bool ok = false;
            if (a.Length == b.Length)
            {
                ok = true;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] != b[i]) { ok = false; }
                }
            }
            return ok;
        }
    } 
}
