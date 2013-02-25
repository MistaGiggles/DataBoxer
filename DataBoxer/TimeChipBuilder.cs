using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataBoxer
{
    class TimeChipBuilder
    {
        public String result;
        int numchips;

        enum State { Start, Time, D1, Chip, D2, Stop };

        State state;
        int progress;

        static string[] startpattern = { "02", "41", "31" };
        static string[] constartpattern = { null, "A", "1" };

        static int start_length = 6;
        static int time_length = 4;
        static int delim1_length = 2;
        static int delim2_length = 3;
        static int chip_length = 10;
        static int stop_length = 2;
        static int info_length = time_length + delim1_length + chip_length + delim2_length;

        public TimeChipBuilder()
        {
            state = State.Start;
            progress = 0;
            numchips = 0;
            result = "";
        }

        public static string[] getChips(byte[] data)
        {
            if (data == null)
            {
                return null;
            }
            int len = data.Length;
            int numchips = (len - (start_length + stop_length)) / (time_length + delim1_length + chip_length + delim2_length);
            string[] result = new string[numchips];
            for (int i = 0; i < numchips; i++)
            {
                byte[] d = new byte[19];
                byte[] t = new byte[4];
                byte[] c = new byte[10];
                for (int j = 0; j < d.Length; j++)
                {
                    d[j] = data[start_length + i * info_length + j];

                }

                for (int j = 0; j < t.Length; j++)
                {
                    t[j] = d[j];
                }

                for (int j = 0; j < c.Length; j++)
                {
                    c[j] = d[j + time_length + delim1_length];
                }
                char box = (char)data[10];
                int mat = data[11];
                ChipTime ct = new ChipTime(c, t, box, mat);
                result[i] = ct.getID();
            }

            return result;

        }

        public static string[] getTimes(byte[] data)
        {
            if (data == null)
            {
                return null;
            }
            int len = data.Length;
            int numchips = (len - (start_length + stop_length)) / (time_length + delim1_length + chip_length + delim2_length);
            string[] result = new string[numchips];
            for (int i = 0; i < numchips; i++)
            {
                byte[] d = new byte[19];
                byte[] t = new byte[4];
                byte[] c = new byte[10];
                for (int j = 0; j < d.Length; j++)
                {
                    d[j] = data[start_length + i * info_length + j];

                }

                for (int j = 0; j < t.Length; j++)
                {
                    t[j] = d[j];
                }

                for (int j = 0; j < c.Length; j++)
                {
                    c[j] = d[j + time_length + delim1_length];
                }
                char box = (char) data[10];
                int mat =  data[11];
                ChipTime ct = new ChipTime(c, t, box, mat);
                result[i] = ct.generateComm();
            }

            return result;
        }

        

        public void nextbyte(byte b)
        {
            string by = b.ToString();
            if (by.Length == 1)
            {
                by = "0" + by;
            }
            string hex = String.Format("{0:X2}", b);
            switch (state)
            {
                case State.Start:
                    if (progress <= 2)
                    {
                        if (startpattern[progress].Equals(hex))
                        {
                            result += constartpattern[progress];
                        }
                    }
                    else if (progress == 3 || progress == 4)
                    {
                        result += "??";
                    }

                    if (progress == 5)
                    {
                        state = State.Time;
                        progress = 0;
                        break;
                    }
                    progress += 1;
                    break;

                case State.Time:
                    
                    if (progress < 2)
                    {
                        result += by;
                        result += ":";
                    }
                    else if (progress == 2)
                    {
                        result += by;
                        result += ".";
                    }
                    if (progress == 3)
                    {
                        result += b.ToString();
                        state = State.D1;
                        progress = 0;
                        break;
                    }

                    progress += 1;
                    break;

                case State.D1:
                    if (progress == 1)
                    {
                        state = State.Chip;
                        progress = 0;
                        break;
                    }
                    progress += 1;
                    break;

                case State.Chip:
                    if (progress == 2)
                    {
                        result += " ";
                    }
                    result += hex;
                    

                    if (progress == 9)
                    {
                        progress = 0;
                        state = State.D2;
                        break;
                    }
                    progress += 1;
                    break;

                case State.D2:
                    if (progress == 2)
                    {
                        progress = 0;
                        state = State.Stop;
                        break;
                    }
                    progress += 1;
                    break;

                case State.Stop:

                    break;
            }

        }
    }
}
