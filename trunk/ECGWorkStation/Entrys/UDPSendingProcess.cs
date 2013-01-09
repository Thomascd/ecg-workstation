using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ECGWorkStation
{
    class UDPSendingProcess
    {
        static int serverTCPPort = 5001;
        static int serverUDPPort = 5002;
        String patientIDDemo = "P20120001";

        private string serverIPString;
        static IPAddress serverAddress;
        static IPEndPoint serverEndPoint;
        static IPEndPoint serverDataEndPoint;
        static IPEndPoint clientEndPoint;

        private UdpClient clientUDPSocket;
        private TcpClient clientTCPSocket;

        //Dữ liệu để trao đổi với server
        string readySendMsg;
        string stopSendMsg;
        string serverMsgString;

        Thread threadListenMessage;
        Thread sendThread;

        ECGData[] ECGDataArray;
        String patientID;
        ECGData[] subDataToSend;
        int lastCount = 0;
        bool isAvailableToSend = false;
        int countToDead = 0;

        public UDPSendingProcess(string patientID, ECGData[] ECGDataArray)
        {
            patientID = "P20120001";
            serverIPString = "";
            readySendMsg = "ReadySend|" + patientID;
            stopSendMsg = "StopSend|" + patientID;

            this.ECGDataArray = ECGDataArray;
            this.patientID = patientID;
            subDataToSend = new ECGData[12];
        }

        public string IPs
        {
            get
            {
                return serverIPString;
            }
            set
            {
                serverIPString = value;
                serverAddress = IPAddress.Parse(serverIPString);
                serverDataEndPoint = new IPEndPoint(serverAddress, serverUDPPort); //Truyền dữ liệu qua cổng 5003 của server
                clientEndPoint = new IPEndPoint(IPAddress.Any, 5012); //Mở cổng 5012 để giao tiếp với server
                clientUDPSocket = new UdpClient(clientEndPoint);
            }
        }

        public void readySend(Boolean[] Flag)
        {
            ///////////////////////////////////////////////////
            //Danh dau cac dao trinh co du lieu
            /*StringBuilder sb = new StringBuilder();
            int leadHaveData = 0;
            for (int i = 0; i < 12; i++)
            {
                if (subDataToSend[i] == null)
                {
                    sb.Append("0#");
                }
                else
                {
                    leadHaveData = i;
                    sb.Append("1#");
                }
            }
            string leadMark = sb.ToString();*/
            ///////////////////////////////////////////////////
            string leadMark = "1#1#1#1#1#1#1#1#1#1#1#1#";
            try
            {
                clientTCPSocket = new TcpClient(serverIPString, serverTCPPort);
                writeToStream(clientTCPSocket.GetStream(), readySendMsg + "|" + leadMark);

                //Nghe phan hoi tu server
                string serverMsg = readFromStream(clientTCPSocket.GetStream());
                handleServerMsg(serverMsg);
                clientTCPSocket.Close();
            }
            catch (Exception e)
            {
                //Exeption khong ket noi duoc server
                throw e;
            }
        }

        public void stopSend()
        {
            //Gui goi tin den server thong bao la ket thuc phien gui du lieu
            try
            {
                clientTCPSocket = new TcpClient(serverIPString, serverTCPPort);
                writeToStream(clientTCPSocket.GetStream(), stopSendMsg);
                clientTCPSocket.Close();
            }
            catch (Exception e)
            {
                throw e;
            }

            //Suspend luồng gửi dữ liệu
            if (sendThread != null)
                sendThread.Suspend();
        }

        private void handleServerMsg(string message)
        {
            switch (message)
            {
                case "OK":
                    isAvailableToSend = true;
                    //Khi bắt đầu gửi thì lấy 20 tín hiệu gần nhất (cuối cùng)
                    this.lastCount = ECGDataArray[0].Count - 10;
                    if (lastCount < 0)
                    {
                        lastCount = 0;
                    }
                    sendThread = new Thread(new ThreadStart(send));
                    sendThread.Start();
                    break;
            }
        }

        private void send()
        {
            string s = "RequestData|P20120001|a";
            byte[] bytes = System.Text.Encoding.ASCII.GetBytes(s);
            clientUDPSocket.Send(bytes, bytes.Length, serverDataEndPoint);
            while (isAvailableToSend)
            {
                int count = ECGDataArray[0].Count;
                int numberOfAvailableLead = 0;

                if (lastCount == count)
                {
                    //countToDead++;
                    //if (countToDead == 3)
                    //{
                    //    isAvailableToSend = false;
                    //    break;
                    //}
                    Thread.Sleep(20);
                    continue;
                }

                for (int i = 0; i < 12; i++)
                {
                    if (ECGDataArray[i] == null)
                    {
                        subDataToSend[i] = null;
                    }
                    else
                    {
                        subDataToSend[i] = ECGDataArray[i].LastSubData(count - lastCount);
                        numberOfAvailableLead++;
                    }
                }
                lastCount = count;

                int leadHaveData = 0;
                int length = subDataToSend[leadHaveData].Count;
                long timeCount = (long)subDataToSend[leadHaveData].Time[0];

                byte[] data = new byte[length * 4 * numberOfAvailableLead];

                //Chuyển đổi dữ liệu sang kiểu String
                int k = 0;
                for (int i = 0; i < length; i++)
                {
                    for (int j = 0; j < 12; j++)
                    {
                        if (subDataToSend[j] != null)
                        {
                            float f = (float)subDataToSend[j].Sign[i];
                            byte[] fByte = BitConverter.GetBytes(f);
                            Buffer.BlockCopy(fByte, 0, data, k * 4, 4);
                            k++;
                        }
                        else
                        {

                        }
                    }
                }

                byte[] pIDBytes = System.Text.Encoding.ASCII.GetBytes("P20120001" + "|");
                byte[] timeBytes = BitConverter.GetBytes(timeCount);
                byte[] sendBytes = new byte[timeBytes.Length + pIDBytes.Length + data.Length];
                Buffer.BlockCopy(pIDBytes, 0, sendBytes, 0, pIDBytes.Length);
                Buffer.BlockCopy(timeBytes, 0, sendBytes, pIDBytes.Length, timeBytes.Length);
                Buffer.BlockCopy(data, 0, sendBytes, pIDBytes.Length + timeBytes.Length, data.Length);

                //Gửi dữ liệu cho server
                clientUDPSocket.Send(sendBytes, sendBytes.Length, serverDataEndPoint);
                Thread.Sleep(20);
            }
        }

        public string readFromStream(NetworkStream stream)
        {
            byte[] bytes = new byte[256];
            int i = stream.Read(bytes, 0, bytes.Length);
            string s = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
            return s;
        }

        public void writeToStream(NetworkStream stream, String message)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(message);
            stream.Write(bytes, 0, bytes.Length);
        }

        public Thread SendThread
        {
            get { return sendThread; }
        }
    }

}
