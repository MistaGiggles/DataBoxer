using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;

namespace DataBoxer
{
    class BoxCommunicator
    {
        SerialPort port;

        bool connected;

        public BoxCommunicator()
        {
            connected = false;
        }

        public static string[] getPorts()
        {
            string[] result = System.IO.Ports.SerialPort.GetPortNames();
            if(result.Length==0)
            {
                return new string[] {"HELLO"};
            }
            return result;
        }

        public Boolean setPort(string name)
        {
            port = new SerialPort(name, 9600, System.IO.Ports.Parity.None, 8, System.IO.Ports.StopBits.One);
            return true;
        }

        public void connect()
        {
            port.RtsEnable = true;
            port.DtrEnable = true;
            port.ReadTimeout = 1000;
            port.WriteTimeout = 1000;
            port.Open();
            connected = true;
        }

        public void send(byte[] data)
        {
            port.Write(data, 0, data.Length);
        }

        public bool isConnected()
        {
            return connected;
        }

        public byte[] requestData(int b)
        {
            send(WTCodes.fetch(b));
            System.Threading.Thread.Sleep(200);
            byte[] result = receive();
            if (result.Length == 1 && result[0] == 4)
            {
                return null;
            }
            send(WTCodes.confirm(b));
            return result;
        }

        public bool reloadData(int b)
        {
            send(WTCodes.reload(b));
            System.Threading.Thread.Sleep(200);
            byte[] response = receive();
            if (WTCodes.matches(WTCodes.confirm(b), response)) 
            {
                return true;
            }
            return false;
            
        }

        public byte[] receive()
        {
            byte[] response = new byte[port.BytesToRead];
            port.Read(response, 0, port.BytesToRead);
            return response;
        }

        public void disconnect()
        {
            port.Close();
            connected = false;
        }

        

    }
}
