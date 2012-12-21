namespace ECGWorkStation
{
    partial class MonitorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.QRS = new System.Windows.Forms.Label();
            this.RS = new System.Windows.Forms.Label();
            this.QR = new System.Windows.Forms.Label();
            this.R = new System.Windows.Forms.Label();
            this.QRS_label = new System.Windows.Forms.Label();
            this.RS_label = new System.Windows.Forms.Label();
            this.QR_label = new System.Windows.Forms.Label();
            this.R_label = new System.Windows.Forms.Label();
            this.HR_label = new System.Windows.Forms.Label();
            this.HR = new System.Windows.Forms.Label();
            this.RoomRate_label = new System.Windows.Forms.Label();
            this.RoomRate = new System.Windows.Forms.TrackBar();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.AccuracyLabel = new System.Windows.Forms.Label();
            this.AccuraceRate = new System.Windows.Forms.TrackBar();
            this.RecordTimer = new System.Windows.Forms.Timer(this.components);
            this.DataReciveTimer = new System.Windows.Forms.Timer(this.components);
            this.PatientNameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RecordLeghtLabel = new System.Windows.Forms.Label();
            this.RecordInfoLable = new System.Windows.Forms.Label();
            this.AvatarBox = new System.Windows.Forms.PictureBox();
            this.RecordTimeLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.LockScreenButton = new System.Windows.Forms.Button();
            this.SettingButton = new System.Windows.Forms.Button();
            this.StartRecordButton = new System.Windows.Forms.Button();
            this.DiagnoseButton = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.CloseButton = new System.Windows.Forms.Button();
            this.NoticeBackgroundPanel = new System.Windows.Forms.Panel();
            this.NoticePanel = new System.Windows.Forms.Panel();
            this.ExitNoticeViewButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RoomRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccuraceRate)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarBox)).BeginInit();
            this.panel4.SuspendLayout();
            this.NoticeBackgroundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // QRS
            // 
            this.QRS.AutoSize = true;
            this.QRS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QRS.Location = new System.Drawing.Point(127, 93);
            this.QRS.Name = "QRS";
            this.QRS.Size = new System.Drawing.Size(18, 17);
            this.QRS.TabIndex = 76;
            this.QRS.Text = "--";
            // 
            // RS
            // 
            this.RS.AutoSize = true;
            this.RS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RS.Location = new System.Drawing.Point(127, 73);
            this.RS.Name = "RS";
            this.RS.Size = new System.Drawing.Size(18, 17);
            this.RS.TabIndex = 74;
            this.RS.Text = "--";
            // 
            // QR
            // 
            this.QR.AutoSize = true;
            this.QR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QR.Location = new System.Drawing.Point(127, 52);
            this.QR.Name = "QR";
            this.QR.Size = new System.Drawing.Size(18, 17);
            this.QR.TabIndex = 73;
            this.QR.Text = "--";
            // 
            // R
            // 
            this.R.AutoSize = true;
            this.R.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R.Location = new System.Drawing.Point(127, 32);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(18, 17);
            this.R.TabIndex = 72;
            this.R.Text = "--";
            // 
            // QRS_label
            // 
            this.QRS_label.AutoSize = true;
            this.QRS_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QRS_label.Location = new System.Drawing.Point(61, 93);
            this.QRS_label.Name = "QRS_label";
            this.QRS_label.Size = new System.Drawing.Size(38, 17);
            this.QRS_label.TabIndex = 70;
            this.QRS_label.Text = "QRS";
            // 
            // RS_label
            // 
            this.RS_label.AutoSize = true;
            this.RS_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RS_label.Location = new System.Drawing.Point(73, 73);
            this.RS_label.Name = "RS_label";
            this.RS_label.Size = new System.Drawing.Size(27, 17);
            this.RS_label.TabIndex = 68;
            this.RS_label.Text = "RS";
            // 
            // QR_label
            // 
            this.QR_label.AutoSize = true;
            this.QR_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QR_label.Location = new System.Drawing.Point(72, 52);
            this.QR_label.Name = "QR_label";
            this.QR_label.Size = new System.Drawing.Size(29, 17);
            this.QR_label.TabIndex = 67;
            this.QR_label.Text = "QR";
            // 
            // R_label
            // 
            this.R_label.AutoSize = true;
            this.R_label.BackColor = System.Drawing.Color.Transparent;
            this.R_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_label.Location = new System.Drawing.Point(84, 33);
            this.R_label.Name = "R_label";
            this.R_label.Size = new System.Drawing.Size(18, 17);
            this.R_label.TabIndex = 66;
            this.R_label.Text = "R";
            // 
            // HR_label
            // 
            this.HR_label.AutoSize = true;
            this.HR_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HR_label.Location = new System.Drawing.Point(67, 6);
            this.HR_label.Name = "HR_label";
            this.HR_label.Size = new System.Drawing.Size(35, 20);
            this.HR_label.TabIndex = 65;
            this.HR_label.Text = "HR";
            // 
            // HR
            // 
            this.HR.AutoSize = true;
            this.HR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HR.Location = new System.Drawing.Point(125, 6);
            this.HR.Name = "HR";
            this.HR.Size = new System.Drawing.Size(21, 20);
            this.HR.TabIndex = 71;
            this.HR.Text = "--";
            // 
            // RoomRate_label
            // 
            this.RoomRate_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RoomRate_label.AutoSize = true;
            this.RoomRate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomRate_label.Location = new System.Drawing.Point(182, 10);
            this.RoomRate_label.Name = "RoomRate_label";
            this.RoomRate_label.Size = new System.Drawing.Size(80, 20);
            this.RoomRate_label.TabIndex = 83;
            this.RoomRate_label.Text = "Room: 1 x";
            // 
            // RoomRate
            // 
            this.RoomRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RoomRate.BackColor = System.Drawing.Color.DarkGray;
            this.RoomRate.LargeChange = 1;
            this.RoomRate.Location = new System.Drawing.Point(6, 10);
            this.RoomRate.Maximum = 20;
            this.RoomRate.Minimum = 1;
            this.RoomRate.Name = "RoomRate";
            this.RoomRate.Size = new System.Drawing.Size(169, 45);
            this.RoomRate.TabIndex = 82;
            this.RoomRate.Value = 10;
            this.RoomRate.Scroll += new System.EventHandler(this.RoomRate_Scroll);
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 115200;
            this.serialPort.ReadBufferSize = 5000;
            this.serialPort.RtsEnable = true;
            this.serialPort.WriteBufferSize = 5000;
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.DataReceive);
            // 
            // AccuracyLabel
            // 
            this.AccuracyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AccuracyLabel.AutoSize = true;
            this.AccuracyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccuracyLabel.Location = new System.Drawing.Point(182, 59);
            this.AccuracyLabel.Name = "AccuracyLabel";
            this.AccuracyLabel.Size = new System.Drawing.Size(118, 20);
            this.AccuracyLabel.TabIndex = 85;
            this.AccuracyLabel.Text = "Accuracy: 75 %";
            // 
            // AccuraceRate
            // 
            this.AccuraceRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AccuraceRate.Location = new System.Drawing.Point(6, 59);
            this.AccuraceRate.Maximum = 100;
            this.AccuraceRate.Minimum = 50;
            this.AccuraceRate.Name = "AccuraceRate";
            this.AccuraceRate.Size = new System.Drawing.Size(169, 45);
            this.AccuraceRate.TabIndex = 84;
            this.AccuraceRate.Value = 74;
            this.AccuraceRate.ValueChanged += new System.EventHandler(this.AccuraceRate_Scroll);
            // 
            // RecordTimer
            // 
            this.RecordTimer.Interval = 1000;
            this.RecordTimer.Tick += new System.EventHandler(this.TimerTick);
            // 
            // DataReciveTimer
            // 
            this.DataReciveTimer.Interval = 2;
            this.DataReciveTimer.Tick += new System.EventHandler(this.DataReciving);
            // 
            // PatientNameLabel
            // 
            this.PatientNameLabel.AutoSize = true;
            this.PatientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientNameLabel.Location = new System.Drawing.Point(137, 10);
            this.PatientNameLabel.Name = "PatientNameLabel";
            this.PatientNameLabel.Size = new System.Drawing.Size(157, 26);
            this.PatientNameLabel.TabIndex = 89;
            this.PatientNameLabel.Text = "Patient Name";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.RoomRate);
            this.panel1.Controls.Add(this.AccuracyLabel);
            this.panel1.Controls.Add(this.RoomRate_label);
            this.panel1.Controls.Add(this.AccuraceRate);
            this.panel1.Location = new System.Drawing.Point(1231, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 120);
            this.panel1.TabIndex = 92;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.HR_label);
            this.panel2.Controls.Add(this.R_label);
            this.panel2.Controls.Add(this.QRS);
            this.panel2.Controls.Add(this.QR_label);
            this.panel2.Controls.Add(this.RS_label);
            this.panel2.Controls.Add(this.RS);
            this.panel2.Controls.Add(this.QRS_label);
            this.panel2.Controls.Add(this.HR);
            this.panel2.Controls.Add(this.QR);
            this.panel2.Controls.Add(this.R);
            this.panel2.Location = new System.Drawing.Point(672, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 120);
            this.panel2.TabIndex = 93;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(168, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 96;
            this.label5.Text = "BMP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(168, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 17);
            this.label4.TabIndex = 95;
            this.label4.Text = "ms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(168, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 17);
            this.label3.TabIndex = 94;
            this.label3.Text = "ms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 17);
            this.label2.TabIndex = 93;
            this.label2.Text = "ms";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 92;
            this.label1.Text = "mV";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ECGWorkStation.Properties.Resources._1346395068_heart;
            this.pictureBox1.Location = new System.Drawing.Point(12, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 34);
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.RecordLeghtLabel);
            this.panel3.Controls.Add(this.RecordInfoLable);
            this.panel3.Controls.Add(this.AvatarBox);
            this.panel3.Controls.Add(this.PatientNameLabel);
            this.panel3.Location = new System.Drawing.Point(10, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(656, 120);
            this.panel3.TabIndex = 94;
            // 
            // RecordLeghtLabel
            // 
            this.RecordLeghtLabel.AutoSize = true;
            this.RecordLeghtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordLeghtLabel.Location = new System.Drawing.Point(139, 78);
            this.RecordLeghtLabel.Name = "RecordLeghtLabel";
            this.RecordLeghtLabel.Size = new System.Drawing.Size(106, 20);
            this.RecordLeghtLabel.TabIndex = 92;
            this.RecordLeghtLabel.Text = "Record Leght";
            // 
            // RecordInfoLable
            // 
            this.RecordInfoLable.AutoSize = true;
            this.RecordInfoLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordInfoLable.Location = new System.Drawing.Point(139, 48);
            this.RecordInfoLable.Name = "RecordInfoLable";
            this.RecordInfoLable.Size = new System.Drawing.Size(100, 20);
            this.RecordInfoLable.TabIndex = 91;
            this.RecordInfoLable.Text = "Record Date";
            // 
            // AvatarBox
            // 
            this.AvatarBox.Image = global::ECGWorkStation.Properties.Resources.business_man_blue__2_;
            this.AvatarBox.Location = new System.Drawing.Point(0, 0);
            this.AvatarBox.Name = "AvatarBox";
            this.AvatarBox.Size = new System.Drawing.Size(120, 120);
            this.AvatarBox.TabIndex = 90;
            this.AvatarBox.TabStop = false;
            // 
            // RecordTimeLabel
            // 
            this.RecordTimeLabel.AutoSize = true;
            this.RecordTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.RecordTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordTimeLabel.Location = new System.Drawing.Point(17, 75);
            this.RecordTimeLabel.Name = "RecordTimeLabel";
            this.RecordTimeLabel.Size = new System.Drawing.Size(67, 20);
            this.RecordTimeLabel.TabIndex = 98;
            this.RecordTimeLabel.Text = " -- : -- : --";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.LockScreenButton);
            this.panel4.Controls.Add(this.SettingButton);
            this.panel4.Controls.Add(this.StartRecordButton);
            this.panel4.Controls.Add(this.RecordTimeLabel);
            this.panel4.Controls.Add(this.DiagnoseButton);
            this.panel4.Location = new System.Drawing.Point(928, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(297, 120);
            this.panel4.TabIndex = 102;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::ECGWorkStation.Properties.Resources._1346395088_spechbubble_sq_line;
            this.button2.Location = new System.Drawing.Point(103, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 55);
            this.button2.TabIndex = 102;
            this.toolTip.SetToolTip(this.button2, "View Comment");
            this.button2.UseVisualStyleBackColor = true;
            // 
            // LockScreenButton
            // 
            this.LockScreenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LockScreenButton.Image = global::ECGWorkStation.Properties.Resources._1346395012_monotone_computer_screen_monitor_tv;
            this.LockScreenButton.Location = new System.Drawing.Point(199, 3);
            this.LockScreenButton.Name = "LockScreenButton";
            this.LockScreenButton.Size = new System.Drawing.Size(90, 55);
            this.LockScreenButton.TabIndex = 100;
            this.LockScreenButton.Tag = "Screen Lock";
            this.LockScreenButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this.LockScreenButton, "Lock Screen");
            this.LockScreenButton.UseVisualStyleBackColor = true;
            this.LockScreenButton.Click += new System.EventHandler(this.LockScreenButton_Click);
            // 
            // SettingButton
            // 
            this.SettingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingButton.Image = global::ECGWorkStation.Properties.Resources._1346394879_Gear;
            this.SettingButton.Location = new System.Drawing.Point(199, 60);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Size = new System.Drawing.Size(90, 55);
            this.SettingButton.TabIndex = 101;
            this.SettingButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this.SettingButton, "Setting");
            this.SettingButton.UseVisualStyleBackColor = true;
            this.SettingButton.Click += new System.EventHandler(this.SettingButton_Click);
            // 
            // StartRecordButton
            // 
            this.StartRecordButton.Image = global::ECGWorkStation.Properties.Resources._1346394869_Media_WMP;
            this.StartRecordButton.Location = new System.Drawing.Point(7, 3);
            this.StartRecordButton.Name = "StartRecordButton";
            this.StartRecordButton.Size = new System.Drawing.Size(90, 55);
            this.StartRecordButton.TabIndex = 97;
            this.toolTip.SetToolTip(this.StartRecordButton, "Record");
            this.StartRecordButton.UseVisualStyleBackColor = true;
            this.StartRecordButton.Click += new System.EventHandler(this.Record);
            // 
            // DiagnoseButton
            // 
            this.DiagnoseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiagnoseButton.Image = global::ECGWorkStation.Properties.Resources._1346394930_Tasks;
            this.DiagnoseButton.Location = new System.Drawing.Point(103, 3);
            this.DiagnoseButton.Name = "DiagnoseButton";
            this.DiagnoseButton.Size = new System.Drawing.Size(90, 55);
            this.DiagnoseButton.TabIndex = 68;
            this.toolTip.SetToolTip(this.DiagnoseButton, "Auto Diagnose");
            this.DiagnoseButton.UseVisualStyleBackColor = true;
            this.DiagnoseButton.Click += new System.EventHandler(this.DiagnoseButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackgroundImage = global::ECGWorkStation.Properties.Resources.Delete_icon_32px;
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CloseButton.Location = new System.Drawing.Point(1547, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(45, 45);
            this.CloseButton.TabIndex = 103;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // NoticeBackgroundPanel
            // 
            this.NoticeBackgroundPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoticeBackgroundPanel.AutoScroll = true;
            this.NoticeBackgroundPanel.Controls.Add(this.NoticePanel);
            this.NoticeBackgroundPanel.Location = new System.Drawing.Point(275, 140);
            this.NoticeBackgroundPanel.Name = "NoticeBackgroundPanel";
            this.NoticeBackgroundPanel.Size = new System.Drawing.Size(1317, 100);
            this.NoticeBackgroundPanel.TabIndex = 104;
            // 
            // NoticePanel
            // 
            this.NoticePanel.Location = new System.Drawing.Point(0, 0);
            this.NoticePanel.Name = "NoticePanel";
            this.NoticePanel.Size = new System.Drawing.Size(1250, 75);
            this.NoticePanel.TabIndex = 0;
            // 
            // ExitNoticeViewButton
            // 
            this.ExitNoticeViewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitNoticeViewButton.Image = global::ECGWorkStation.Properties.Resources._1346394929_Tasks;
            this.ExitNoticeViewButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExitNoticeViewButton.Location = new System.Drawing.Point(10, 140);
            this.ExitNoticeViewButton.Name = "ExitNoticeViewButton";
            this.ExitNoticeViewButton.Size = new System.Drawing.Size(259, 100);
            this.ExitNoticeViewButton.TabIndex = 105;
            this.ExitNoticeViewButton.Text = "View Real Time";
            this.ExitNoticeViewButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitNoticeViewButton.UseVisualStyleBackColor = true;
            this.ExitNoticeViewButton.Click += new System.EventHandler(this.ExitNoticeViewButton_Click);
            // 
            // MonitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.ExitNoticeViewButton);
            this.Controls.Add(this.NoticeBackgroundPanel);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MonitorForm";
            this.Text = "Main Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClose);
            ((System.ComponentModel.ISupportInitialize)(this.RoomRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccuraceRate)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarBox)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.NoticeBackgroundPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label QRS;
        public System.Windows.Forms.Label RS;
        public System.Windows.Forms.Label QR;
        public System.Windows.Forms.Label R;
        public System.Windows.Forms.Label HR;
        private System.Windows.Forms.Label QRS_label;
        private System.Windows.Forms.Label RS_label;
        private System.Windows.Forms.Label QR_label;
        private System.Windows.Forms.Label R_label;
        private System.Windows.Forms.Label HR_label;
        private System.Windows.Forms.Button DiagnoseButton;
        private System.Windows.Forms.Label RoomRate_label;
        private System.Windows.Forms.TrackBar RoomRate;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Label AccuracyLabel;
        private System.Windows.Forms.TrackBar AccuraceRate;
        private System.Windows.Forms.Timer RecordTimer;
        private System.Windows.Forms.Timer DataReciveTimer;
        private System.Windows.Forms.Label PatientNameLabel;
        private System.Windows.Forms.PictureBox AvatarBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button StartRecordButton;
        private System.Windows.Forms.Label RecordTimeLabel;
        private System.Windows.Forms.Button LockScreenButton;
        private System.Windows.Forms.Button SettingButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label RecordInfoLable;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label RecordLeghtLabel;
        private System.Windows.Forms.Panel NoticeBackgroundPanel;
        private System.Windows.Forms.Panel NoticePanel;
        private System.Windows.Forms.Button ExitNoticeViewButton;
    }
}

