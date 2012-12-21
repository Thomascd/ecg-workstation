using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace ECGWorkStation
{
    class SmsClass
    {
        SerialPort serialPort;

        public SmsClass(string comPort)
        {
            this.serialPort = new SerialPort();
            this.serialPort.PortName = comPort;
            this.serialPort.BaudRate = 115200;  // Nokia 6300; Old 19200;
            this.serialPort.Parity = Parity.None;
            this.serialPort.DataBits = 8;
            this.serialPort.StopBits = StopBits.One;
            this.serialPort.Handshake = Handshake.RequestToSend;
            this.serialPort.DtrEnable = true;
            this.serialPort.RtsEnable = true;
            this.serialPort.NewLine = System.Environment.NewLine;
            this.serialPort.WriteTimeout = 30;
        }

        public bool sendSms(string cellNo, string sms)
        {
            string messages = null;
            messages = sms;
            if (this.serialPort.IsOpen == true)
            {
                try
                {
                    this.serialPort.WriteLine("AT" + (char)(13));
                    Thread.Sleep(4);
                    this.serialPort.WriteLine("AT+CMGF=1" + (char)(13));
                    Thread.Sleep(5);
                    this.serialPort.WriteLine("AT+CMGS=\"" + cellNo + "\"");
                    Thread.Sleep(10);
                    this.serialPort.WriteLine(">" + messages + (char)(26));
                }
                catch (Exception e)
                {
                    this.Closes();
                  //  MessageBox.Show("problem with send fucntion");
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Opens()
        {
            if (this.serialPort.IsOpen == false)
            {
                this.serialPort.Open();
            }
        }

        public void Closes()
        {
            if (this.serialPort.IsOpen == true)
            {
                this.serialPort.Close();
            }
        }
    }
}
