namespace ECGWorkStation
{
    partial class PatientManager
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.DoctorBox = new System.Windows.Forms.Label();
            this.SexBox = new System.Windows.Forms.ComboBox();
            this.BirthdayBox = new System.Windows.Forms.DateTimePicker();
            this.WeightBox = new System.Windows.Forms.NumericUpDown();
            this.JobBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.PatientInfoBox = new System.Windows.Forms.Panel();
            this.AvatarBox = new System.Windows.Forms.PictureBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.BackgroundPanel = new System.Windows.Forms.Panel();
            this.RecordListPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WeightBox)).BeginInit();
            this.PatientInfoBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarBox)).BeginInit();
            this.BackgroundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 44);
            this.label1.TabIndex = 15;
            this.label1.Text = "Patient Manager";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(291, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(291, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Sex :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(291, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "Birthday :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(291, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 24);
            this.label8.TabIndex = 22;
            this.label8.Text = "Weight :";
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.SystemColors.Control;
            this.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.Location = new System.Drawing.Point(222, 50);
            this.NameBox.Name = "NameBox";
            this.NameBox.ReadOnly = true;
            this.NameBox.Size = new System.Drawing.Size(232, 28);
            this.NameBox.TabIndex = 24;
            this.NameBox.Text = "Patient Name";
            // 
            // DoctorBox
            // 
            this.DoctorBox.AutoSize = true;
            this.DoctorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorBox.Location = new System.Drawing.Point(386, 116);
            this.DoctorBox.Name = "DoctorBox";
            this.DoctorBox.Size = new System.Drawing.Size(86, 24);
            this.DoctorBox.TabIndex = 17;
            this.DoctorBox.Text = "ID (temp)";
            // 
            // SexBox
            // 
            this.SexBox.BackColor = System.Drawing.SystemColors.Window;
            this.SexBox.Enabled = false;
            this.SexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SexBox.FormattingEnabled = true;
            this.SexBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.SexBox.Location = new System.Drawing.Point(390, 159);
            this.SexBox.Name = "SexBox";
            this.SexBox.Size = new System.Drawing.Size(121, 24);
            this.SexBox.TabIndex = 28;
            // 
            // BirthdayBox
            // 
            this.BirthdayBox.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.BirthdayBox.Enabled = false;
            this.BirthdayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthdayBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthdayBox.Location = new System.Drawing.Point(390, 197);
            this.BirthdayBox.Name = "BirthdayBox";
            this.BirthdayBox.Size = new System.Drawing.Size(121, 23);
            this.BirthdayBox.TabIndex = 29;
            // 
            // WeightBox
            // 
            this.WeightBox.BackColor = System.Drawing.SystemColors.Window;
            this.WeightBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WeightBox.Enabled = false;
            this.WeightBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightBox.Location = new System.Drawing.Point(390, 236);
            this.WeightBox.Name = "WeightBox";
            this.WeightBox.Size = new System.Drawing.Size(121, 23);
            this.WeightBox.TabIndex = 30;
            // 
            // JobBox
            // 
            this.JobBox.BackColor = System.Drawing.SystemColors.Control;
            this.JobBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.JobBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobBox.Location = new System.Drawing.Point(390, 276);
            this.JobBox.Name = "JobBox";
            this.JobBox.ReadOnly = true;
            this.JobBox.Size = new System.Drawing.Size(173, 22);
            this.JobBox.TabIndex = 31;
            this.JobBox.Text = "Job";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(291, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 24);
            this.label3.TabIndex = 32;
            this.label3.Text = "Job :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(291, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 24);
            this.label5.TabIndex = 33;
            this.label5.Text = "Address :";
            // 
            // AddressBox
            // 
            this.AddressBox.BackColor = System.Drawing.SystemColors.Control;
            this.AddressBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddressBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressBox.Location = new System.Drawing.Point(390, 316);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.ReadOnly = true;
            this.AddressBox.Size = new System.Drawing.Size(173, 22);
            this.AddressBox.TabIndex = 34;
            this.AddressBox.Text = "Address";
            // 
            // PatientInfoBox
            // 
            this.PatientInfoBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PatientInfoBox.BackColor = System.Drawing.SystemColors.Control;
            this.PatientInfoBox.Controls.Add(this.AvatarBox);
            this.PatientInfoBox.Controls.Add(this.AddressBox);
            this.PatientInfoBox.Controls.Add(this.label2);
            this.PatientInfoBox.Controls.Add(this.label5);
            this.PatientInfoBox.Controls.Add(this.DoctorBox);
            this.PatientInfoBox.Controls.Add(this.label3);
            this.PatientInfoBox.Controls.Add(this.label4);
            this.PatientInfoBox.Controls.Add(this.JobBox);
            this.PatientInfoBox.Controls.Add(this.label6);
            this.PatientInfoBox.Controls.Add(this.WeightBox);
            this.PatientInfoBox.Controls.Add(this.label8);
            this.PatientInfoBox.Controls.Add(this.BirthdayBox);
            this.PatientInfoBox.Controls.Add(this.NameBox);
            this.PatientInfoBox.Controls.Add(this.SexBox);
            this.PatientInfoBox.Controls.Add(this.EditButton);
            this.PatientInfoBox.Controls.Add(this.CancelButton);
            this.PatientInfoBox.Controls.Add(this.AcceptButton);
            this.PatientInfoBox.Location = new System.Drawing.Point(100, 120);
            this.PatientInfoBox.Name = "PatientInfoBox";
            this.PatientInfoBox.Size = new System.Drawing.Size(580, 562);
            this.PatientInfoBox.TabIndex = 35;
            // 
            // AvatarBox
            // 
            this.AvatarBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AvatarBox.Image = global::ECGWorkStation.Properties.Resources._1346378772_People_MSN1;
            this.AvatarBox.ImageLocation = "";
            this.AvatarBox.Location = new System.Drawing.Point(50, 50);
            this.AvatarBox.Name = "AvatarBox";
            this.AvatarBox.Size = new System.Drawing.Size(130, 140);
            this.AvatarBox.TabIndex = 12;
            this.AvatarBox.TabStop = false;
            this.AvatarBox.Click += new System.EventHandler(this.ChangerAvatar);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EditButton.BackColor = System.Drawing.SystemColors.Control;
            this.EditButton.Image = global::ECGWorkStation.Properties.Resources.Edit_icon_32px;
            this.EditButton.Location = new System.Drawing.Point(182, 497);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(45, 45);
            this.EditButton.TabIndex = 25;
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditChanger);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Enabled = false;
            this.CancelButton.Image = global::ECGWorkStation.Properties.Resources.Delete_icon_32px;
            this.CancelButton.Location = new System.Drawing.Point(312, 497);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(45, 45);
            this.CancelButton.TabIndex = 27;
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelEdit);
            // 
            // AcceptButton
            // 
            this.AcceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AcceptButton.Enabled = false;
            this.AcceptButton.Image = global::ECGWorkStation.Properties.Resources.Accept_icon_32_px;
            this.AcceptButton.Location = new System.Drawing.Point(247, 497);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(45, 45);
            this.AcceptButton.TabIndex = 26;
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptEdit);
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackgroundPanel.AutoScroll = true;
            this.BackgroundPanel.Controls.Add(this.RecordListPanel);
            this.BackgroundPanel.Location = new System.Drawing.Point(750, 120);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(850, 730);
            this.BackgroundPanel.TabIndex = 36;
            // 
            // RecordListPanel
            // 
            this.RecordListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RecordListPanel.Location = new System.Drawing.Point(0, 0);
            this.RecordListPanel.Name = "RecordListPanel";
            this.RecordListPanel.Size = new System.Drawing.Size(818, 730);
            this.RecordListPanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::ECGWorkStation.Properties.Resources._1346394929_Tasks;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(100, 700);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(580, 150);
            this.button1.TabIndex = 37;
            this.button1.Text = "   View ECG Realtime";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ViewECG);
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BackButton.Image = global::ECGWorkStation.Properties.Resources._1346394982_arrow_left_2_2;
            this.BackButton.Location = new System.Drawing.Point(1544, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(44, 39);
            this.BackButton.TabIndex = 14;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.Back);
            // 
            // PatientManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BackgroundPanel);
            this.Controls.Add(this.PatientInfoBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PatientManager";
            this.ShowInTaskbar = false;
            this.Text = "PatientManager";
            ((System.ComponentModel.ISupportInitialize)(this.WeightBox)).EndInit();
            this.PatientInfoBox.ResumeLayout(false);
            this.PatientInfoBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarBox)).EndInit();
            this.BackgroundPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox AvatarBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label DoctorBox;
        private System.Windows.Forms.ComboBox SexBox;
        private System.Windows.Forms.DateTimePicker BirthdayBox;
        private System.Windows.Forms.NumericUpDown WeightBox;
        private System.Windows.Forms.TextBox JobBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.Panel PatientInfoBox;
        private System.Windows.Forms.Panel BackgroundPanel;
        private System.Windows.Forms.Panel RecordListPanel;
        private System.Windows.Forms.Button button1;

    }
}