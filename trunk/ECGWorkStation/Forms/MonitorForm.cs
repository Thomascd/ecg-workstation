using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECGWorkStation.WebService;

enum state { Wait, History, Realtime, Record, ViewNotice }

namespace ECGWorkStation
{
    partial class MonitorForm : Form
    {
        ECGData[] Data          = new ECGData[12];
        ECGData[] SimulatorData = new ECGData[12];        
        bool[]    Flag          = new bool   [12];

        Graph[]   Graph         = new Graph  [12];

        QRSDetect QRSDetecter;
        Thread    QRSThread;
        Thread SimulatorThread;

        state StateValue = state.Wait;
        
        Patient   Patient;
        //Record  Record;
        
        USBDriver.ECG        ECGChiner = new USBDriver.ECG();
        SettingForm          Setting   = new SettingForm();
        SimulatorControlForm SimulatorControler = new SimulatorControlForm();
        InputDevice          InputDevice;

        UDPSendingProcess UDPSender;

        public bool Updated = false;

        #region Open Form

        public MonitorForm()
        {
            InitializeComponent();
            InitializeScreen();
            InitializeData();
            InitializeComponents();

            Patient = new Patient();
            Patient.ID = "P20120001";
            Patient.Name = "Simulator Patient";

            state = state.Wait;
        }

        public MonitorForm(Patient Patient)
        {
            this.Patient = Patient;

            InitializeComponent();            
            InitializeScreen(Patient);
            InitializeData();
            InitializeComponents();

            state = state.Wait;
        }

        public MonitorForm(Patient Patient, Record Record)
        {        
            this.Patient = Patient;
            //this.Record  = Record;

            InitializeComponent();
            InitializeData(Record);
            InitializeComponents();
            InitializeScreen(Patient, Record);

            state = state.History;
        }

        private void InitializeComponents()
        {
            // set full screen window
            this.Left = 0;
            this.Top = 0;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            int Height  = Screen.PrimaryScreen.Bounds.Height;
            int Width   = Screen.PrimaryScreen.Bounds.Width;

            int PanelHeight = (Screen.PrimaryScreen.Bounds.Height - 265) / 3;    // Graphics panels height
            int PanelWidth  = (Screen.PrimaryScreen.Bounds.Width  - 15 ) / 4;    // Graphics panels width
            Size Size = new Size(PanelWidth, PanelHeight);
                          
            Graph[0]  = new Graph(Size, Data[0],  "I"  );
            Graph[1]  = new Graph(Size, Data[1],  "II" );
            Graph[2]  = new Graph(Size, Data[2],  "III");
            Graph[3]  = new Graph(Size, Data[3],  "aVL");
            Graph[4]  = new Graph(Size, Data[4],  "aVR");
            Graph[5]  = new Graph(Size, Data[5],  "aVF");
            Graph[6]  = new Graph(Size, Data[6],  "V1" );
            Graph[7]  = new Graph(Size, Data[7],  "V2" );
            Graph[8]  = new Graph(Size, Data[8],  "V3" );
            Graph[9]  = new Graph(Size, Data[9],  "V4" );
            Graph[10] = new Graph(Size, Data[10], "V4" );
            Graph[11] = new Graph(Size, Data[11], "V6" );

            foreach (Graph _graph in Graph) this.Controls.Add(_graph);           

            // init graph
            Graph[0].Left = Graph[1].Left = Graph[2].Left = 0;
            Graph[3].Left = Graph[4].Left = Graph[5].Left = 5 + PanelWidth;
            Graph[6].Left = Graph[7].Left = Graph[8].Left = 10 + PanelWidth * 2;
            Graph[9].Left = Graph[10].Left = Graph[11].Left = 15 + PanelWidth * 3;

            Graph[0].Top = Graph[3].Top = Graph[6].Top = Graph[9].Top = 255;
            Graph[1].Top = Graph[4].Top = Graph[7].Top = Graph[10].Top = 260 + PanelHeight;
            Graph[2].Top = Graph[5].Top = Graph[8].Top = Graph[11].Top = 265 + PanelHeight * 2;

            // Init Simulator control event handle
            SimulatorControler.SimulatorEvent += this.MakeEven;
            SimulatorControler.SimulatorStart += this.StartSimulator;
            SimulatorControler.SimulatorStop += this.StopSimulator;


            // ************************************* get new QRS Detect

            QRSDetecter = new QRSDetect(Data[0]);

            // ------------------------------------- UDP
            UDPSender = new UDPSendingProcess(this.Patient.ID, this.Data);
        }

        private void InitializeScreen(Patient Patient, Record Record)
        {
            InitializeScreen(Patient);

            // set record info
            RecordInfoLable.Text = "Record: " + Record.Date.ToShortDateString() + " " + Record.Date.ToShortTimeString();
            RecordLeghtLabel.Text = ""; // Record.Leght + "ms";

            // draw graph
            for (int i = 0; i < 12; i++) Graph[i].ResetPanel();            
        }

        private void InitializeScreen(Patient Patient)
        {           
            // set patient info
            AvatarBox.Image       = Patient.Avatar;
            PatientNameLabel.Text = Patient.Name;

            // clear Record Data Lable text
            RecordInfoLable.Text  = "";
            RecordLeghtLabel.Text = "";
        }

        private void InitializeScreen()
        {
            // set patient info
            AvatarBox.Enabled = false;
            PatientNameLabel.Enabled = false;

            // clear Record Data Lable text
            RecordInfoLable.Text = "";
            RecordLeghtLabel.Text = "";
        }

        private void InitializeData(Record Record)
        // get data from history record
        {
            // ************************************** get data from record
            InitializeData();
            GetDataFromString(Data, Record.Data);
        }

        private void InitializeData()
        // get new Data
        {
            // ************************************* get new Data
            for (int i = 0; i < 12; i++) Data[i]          = new ECGData();
            for (int i = 0; i < 12; i++) SimulatorData[i] = new ECGData();
        }

        #endregion

        #region Close Form

        private void Close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormClose(object sender, FormClosingEventArgs e)
        {
            foreach (Graph _graph in Graph) _graph.Close();
            if (QRSThread != null) QRSThread.Abort();
            if (SimulatorThread != null) SimulatorThread.Abort();        

            SimulatorControler.Close();

            foreach (Graph _graph in Graph) _graph.Close();
        }

        #endregion

        #region Data receive
    
        // ======================== real time data recive form usb post

        private double tempTime = 0;
        private void DataReciving(object sender, EventArgs e)
        // real time data recive from USB post / simulator
        {
            if (InputDevice == InputDevice.SIMULATOR)
            {
                int id = Data[0].Count % SimulatorData[0].Count;
                for (int i = 0; i < 12; i++)
                    if (Flag[i])
                    {                        
                        Data[i].LastTime = Data[i].LastTime + SimulatorControler.Cycle;
                        Data[i].LastSign = SimulatorData[i].Sign[id];
                    }                
            }
        }

        // ======================== read data from file

        private bool GetDataFromString(ECGData[] Data, string input)
        {
            try
            {
              //  input = input.Trim();
                input = input.Replace("\\t", "\t");

                // slit              
                string[] source = input.Split('\t');

                // flag
                int i;
                for (i = 0; i < 12; i++) Flag[i] = (source[i].Trim() == "1");                

                // data
                int count = source.Count() - 13;
                for (; i + 13 <= count; i += 13)
                {
                    // time. format 0:00.000
                    string temp = source[i].Trim();
                    int minute = int.Parse(temp.Substring(0, temp.IndexOf(":"))); temp = temp.Substring(temp.IndexOf(":") + 1);
                    int second = int.Parse(temp.Substring(0, temp.IndexOf("."))); temp = temp.Substring(temp.IndexOf(".") + 1);
                    //MessageBox.Show("Time = " + minute + " : " + second + " . " + temp);
                    foreach (ECGData data in Data) data.LastTime = (minute * 60 + second) * 1000 + int.Parse(temp);

                    // sign
                    for (int j = 0; j < 12; j++)                    
                        if (Flag[j]) Data[j].LastSign = float.Parse(source[i + j + 1].Trim());                    
                }

                return true;
            }
            catch 
            {
                MessageBox.Show("record data error");
                return false;
            }
        }

        private bool ReadInputFile(ECGData[] Data, string FileName)
        {
            try
            {
                StreamReader InputFile = new StreamReader(FileName);
                return GetDataFromString(Data, InputFile.ReadToEnd());
            }
            catch
            {
                return false;
            }
        }


        // ======================== read data form com port
        private Boolean isSignal = false;
        private void DataReceive(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        // real time data receive from COM post
        {            
            if (StateValue == state.Realtime)
            {
                //try
                //{
                //    string s = serialPort.ReadLine();
                //    s = s.Substring(0, s.Length - 2);

                //    float temp = float.Parse(s);

                //    if (isSignal)
                //    {
                //        isSignal = false;
                //        foreach (ECGData d in Data) d.LastSign = temp;
                //    }
                //    else // is time
                //    {
                //        isSignal = true;
                //        if (Data[0].Count == 0)
                //        {
                //            foreach (ECGData d in Data) d.LastTime = 0;
                //        }
                //        else
                //        {
                //            long LastTime = Data[0].LastTime + 4;
                //            foreach (ECGData d in Data) d.LastTime = LastTime;
                //        }
                //    }
                //}
                //catch
                //{
                //    MessageBox.Show("Data reciver error");
                //}
            }
        }

        #endregion

        #region QRSDetect

        // InvokeRequired required compares the thread ID of the 
        // calling thread to the thread ID of the creating thread. 
        // If these threads are different, it returns true. 
        delegate void SetTextCallback(Label label, int value);

        private void SetText(Label label, int value)
        {
            if (label.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { label, value });
            }
            else label.Text = value.ToString();           
        }

        void QRSDetectRealTime()
        {
            int LastCount = 0;
            while (true)
            {
                int Count = Data[0].Count;
                bool Detected = QRSDetecter.FindQRS(Data[0].LastSubData(Count - LastCount));

                if (Detected)
                {
                    LastCount = Count;                                       

                    SetText(R,   QRSDetecter.R);
                    SetText(HR,  QRSDetecter.HR);
                    SetText(QR,  QRSDetecter.QR);
                    SetText(RS,  QRSDetecter.RS);
                    SetText(QRS, QRSDetecter.QRS);
                }
                else Thread.Sleep(100);
            }                  
        }

        void QRSDetect()
        {
            QRSDetecter.FindQRS(Data[0]);

            R.Text   = "" + QRSDetecter.R;
            HR.Text  = "" + QRSDetecter.HR;
            QR.Text  = "" + QRSDetecter.QR;
            RS.Text  = "" + QRSDetecter.RS;
            QRS.Text = "" + QRSDetecter.QRS;
        }

        #endregion

        #region graphics setting

        private void RoomRate_Scroll(object sender, EventArgs e)
        // room rate change
        {
            RoomRate_label.Text = "Room: " + RoomRate.Value * 0.1 + "x";
            foreach (Graph _graph in Graph) _graph.RoomRate = RoomRate.Value * 0.1;
        }

        private void AccuraceRate_Scroll(object sender, EventArgs e)
        // accurace rate change 
        {
            AccuracyLabel.Text = "Accuracy: " + AccuraceRate.Value + "%";
        }

        #endregion

        #region Record

        int StartRecordPoint = 0;
        DateTime RecordTime;

        private void TimerTick(object sender, EventArgs e)
        {
            RecordTime = RecordTime.AddSeconds(1);
            RecordTimeLabel.Text = RecordTime.Hour + " : " + RecordTime.Minute + " : " + RecordTime.Second;
        }

        private void Record(object sender, EventArgs e)
        {
            if (state == state.Realtime)
            {
                StartRecordPoint = Data[0].Count;
                state = state.Record;

                RecordTime = new DateTime(2012, 1, 1, 0, 0, 0);
                RecordTimer.Enabled = true;

                this.StartRecordButton.Image = global::ECGWorkStation.Properties.Resources.square_black;
            }
            else if (state == state.Record)
            {
                // changer state
                RecordTimer.Stop();
                RecordTimer.Enabled = false;

                this.StartRecordButton.Image = global::ECGWorkStation.Properties.Resources._1346394869_Media_WMP;
                state = state.Realtime;
                
                // create record data

                StringBuilder temp = new StringBuilder();
                temp.Append("1\t1\t1\t1\t1\t1\t1\t1\t1\t1\t1\t1\t");

                int StopRecordPoint = Data[0].Count;
                int Cycle = (int)(Data[0].Time[1] - Data[0].Time[0]);
                int hh = 0;
                int mm = 0;
                int ss = 0;
                int ff = 0;                

                for (int i = StartRecordPoint; i < StopRecordPoint; i++)
                {
                    temp.Append(
                        "   " +
                        (hh == 0 ? "   " : hh.ToString("00:")) +
                        (mm > 9 ? mm.ToString("00") : " " + mm.ToString("0"))  + ":" +
                        ss.ToString("00")  + "." +
                        ff.ToString("000") + "\t");
                    
                    ff += Cycle;
                    if (ff >= 1000)
                    {
                        ff = 0;
                        ss += 1;
                        if (ss >= 60)
                        {
                            ss = 0;
                            mm += 1;
                            if (mm >= 60)
                            {
                                mm = 0;
                                hh += 1;
                            }
                        }
                    }

                    foreach (ECGData _data in Data)
                    {                        
                        if (_data.Sign[i] >= 0) temp.Append(" ");
                        if (Math.Abs(_data.Sign[i]) < 10) temp.Append(" ");
                        temp.Append(_data.Sign[i].ToString("0.000\t"));
                    }
                }

                // Add new Record

                WebService.ECGServiceClient WS = new WebService.ECGServiceClient();
                string recordID = WS.generateRecordID(Patient.ID);

                StreamWriter file = new StreamWriter(recordID + ".txt");
                file.Write(temp.ToString());
                file.Flush();
                file.Close();                               

                Record newRecord = new Record(Patient, DateTime.Now, recordID, this.Flag, temp.ToString());
                Patient.AddRecord(newRecord);

                this.Updated = true;

                // uploadfile to server

                UploadFile(recordID + ".txt", newRecord);
            }
        }

        private void UploadFile(string filename, Record newRecord)
        {
            try
            {
                // get the exact file name from the path
                String strFile = System.IO.Path.GetFileName(filename);

                // get the file information form the selected file
                FileInfo fInfo = new FileInfo(filename);

                RecordUploader.FileUploaderSoapClient srv = new RecordUploader.FileUploaderSoapClient();
                //TestUploader.FileServiceLocal.FileServiceClient fsl = new FileServiceLocal.FileServiceClient();
               

                // get the length of the file to see if it is possible
                // to upload it (with the standard 4 MB limit)
                long numBytes = fInfo.Length;
                double dLen = Convert.ToDouble(fInfo.Length / 1000000);

                // Default limit of 4 MB on web server
                // have to change the web.config to if
                // you want to allow larger uploads
                if (dLen < 4)
                {
                    // set up a file stream and binary reader for the
                    // selected file
                    FileStream fStream = new FileStream(filename, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fStream);

                    // convert the file to a byte array
                    byte[] data = br.ReadBytes((int)numBytes);
                    br.Close();

                    // get new record id
                    WebService.ECGServiceClient WS = new WebService.ECGServiceClient();
                    string recordID = WS.generateRecordID(Patient.ID);

                    // pass the byte array (file) and file name to the web service
                    //string sTmp = srv.UploadFile(data, strFile);                    
                    //string sTmp = srv.UploadECGRecord(data, strFile, recordID, Patient.ID, DateTime.Now);                    
                    string sTmp = srv.UploadECGRecord2(data, strFile, newRecord.ID, newRecord.PatientID, newRecord.Date, newRecord.Data.Count(), newRecord.DoctorID, newRecord.DoctorName, newRecord.HR, newRecord.R, newRecord.QR, newRecord.RS, newRecord.QRS);
                    

                    fStream.Close();
                    fStream.Dispose();

                    // this will always say OK unless an error occurs,
                    // if an error occurs, the service returns the error message
                    // MessageBox.Show("File Upload Status: " + status.ToString(), "File Upload");
                    MessageBox.Show("File Upload Status: " + sTmp.ToString(), "File Upload");
                }
                else
                {
                    // Display message if the file was too large to upload
                    MessageBox.Show("The file selected exceeds the size limit for uploads.", "File Size");
                }
            }
            catch (Exception ex)
            {
                // display an error message to the user
                MessageBox.Show(ex.Message.ToString(), "Upload Error");
            }
        }

        #endregion

        #region State property

        private state state
        {
            get
            {
                return StateValue;
            }
            set
            {
                if (StateValue != value)
                {
                    foreach (Graph _graph in Graph) _graph.Mode = value;

                    switch (value)
                    {
                        case state.History:
                            if (QRSThread != null) QRSThread.Abort();
                            QRSDetect();
                            try
                            {
                                UDPSender.stopSend();
                            }
                            catch
                            {
                                MessageBox.Show("Can't sent stop messenger");
                            }
                            break;

                        case state.Realtime:
                            if (StateValue != state.Record)
                            {
                                QRSThread = new Thread(new ThreadStart(this.QRSDetectRealTime));
                                QRSThread.Start();
                                try
                                {
                                    UDPSender.readySend(this.Flag);
                                }
                                catch
                                {
                                    MessageBox.Show("Can't sent ready messenger");
                                }
                            }
                            break;

                        case state.Record:
                            break;

                        case state.ViewNotice:
                            if (QRSThread != null) QRSThread.Abort();
                            QRSDetect();

                            break;
                    }

                    StateValue = value;
                }
            }
        }

        #endregion

        #region Setting

        private void SettingButton_Click(object sender, EventArgs e)
        {
            if (Setting.ShowDialog() == DialogResult.OK)
            {
                // Serve connect
                //if (UDPSending.IPs != Setting.IDString)
                //{
                //    UDPSending.IPs = Setting.IDString;
                //}

                // input devicce
                if (InputDevice != Setting.InputDevice)
                {
                    InputDevice = Setting.InputDevice;
                    SetupInputDevice();
                }
            }
        }

        private void SetupInputDevice()
        // Changer input device
        {
            if      (InputDevice == InputDevice.COM)
            {
                //UDPSending.stopSend();
            }
            else if (InputDevice == InputDevice.USB)
            {
                //UDPSending.stopSend();
            }
            else if (InputDevice == InputDevice.FILE)
            {
                ReadInputFile(Data, Setting.FileName);
                if (QRSThread != null) QRSThread.Abort();
                state = state.History;
                QRSDetect();
            //    UDPSender.stopSend();
            }
            else if (InputDevice == InputDevice.SIMULATOR)
            {
                if (SimulatorControler.IsDisposed)
                {
                    SimulatorControler = new SimulatorControlForm();

                    SimulatorControler.SimulatorEvent += this.MakeEven;
                    SimulatorControler.SimulatorStart += this.StartSimulator;
                    SimulatorControler.SimulatorStop  += this.StopSimulator;
                }
                SimulatorControler.Show();
                if (QRSThread != null) QRSThread.Abort();

                state = state.Realtime;
            }
        }

        #endregion

        #region View Comment

        private void ViewComment(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Control

        private void DiagnoseButton_Click(object sender, EventArgs e)
        {

        }

        private void LockScreenButton_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Notice

        private void ViewNotice(object sender, EventArgs e)
        {            
            NoticeLabel Notice = (NoticeLabel)sender;
            state = state.ViewNotice;        
        }

        private void ExitNoticeViewButton_Click(object sender, EventArgs e)
        {
            state = state.Realtime;
        }

        int NoticeCount = 0;
        SmsClass sms;
        private void MakeNotice(string NoticeName)
        {
            // Add Notice
            NoticeLabel NewNotice = new NoticeLabel(NoticeName, DateTime.Now, Data[0].Count);
     
            Point point = new Point((NewNotice.Width + 10) * NoticeCount, 0);
            if (point.X > NoticePanel.Width) NoticePanel.Width = NoticePanel.Width + NewNotice.Width + 10;
            
            NewNotice.Location = point;
            NewNotice.ViewNotice += this.ViewNotice;
            
            NoticePanel.Controls.Add(NewNotice);
            NoticeCount++;

            // Send SMS
            if (Setting.SMSPort != null)
            {
                string msg = "Simulator Notice\n" +
                    "Canh bao: " + NoticeName + "\n" +
                    "Ten benh nhan: " + Patient.Name + "\n" +
                    "So phong: " + Patient.Room + "\n" +
                    "Giuong so: " + Patient.Bed + "\n";
                    //"Nhip tim: " + QRSDetecter.HR + "\n";

                try
                {
                    sms = new SmsClass(Setting.SMSPort);
                    sms.Opens();
                    bool ok = sms.sendSms("01252518219", msg);
                    sms.Closes();
                }
                catch
                {
                    MessageBox.Show("Can't sent sms from this com");
                }
            }
            
        }

        #endregion

        #region Simulator

        void StartSimulator(object sender, EventArgs e)
        {
            bool ok = ReadInputFile(SimulatorData, SimulatorControler.FileName);
            if (ok)
            {
                SimulatorThread = new Thread(new ThreadStart(this.SentData));
                SimulatorThread.Start();

                foreach (ECGData _data in Data) _data.Reset();
                state = state.Realtime;
            }
        }

        void SentData()
        {
            int id;
            while (true)
            {
                //id = 0;
                //while (!Flag[id]) id++;
                //id = Data[id].Count % SimulatorData[id].Count;
                id = Data[0].Count % SimulatorData[0].Count;

                for (int i = 0; i < 12; i++)
                    if (Flag[i])
                    {
                        Data[i].LastSign = SimulatorData[i].Sign[id];
                        Data[i].LastTime = Data[i].LastTime + 2;
                    }
                Thread.Sleep(2);
            }
        }

        void StopSimulator(object sender, EventArgs e)
        {
            state = state.Wait;
        }

        void MakeEven(object sender, EventArgs e)
        {
            // Add Notice
            MakeNotice("Simulator Notice");
        }

        #endregion

    }
}
