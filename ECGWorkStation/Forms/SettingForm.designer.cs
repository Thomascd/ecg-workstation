namespace ECGWorkStation
{
    partial class SettingForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SimulatorButton = new System.Windows.Forms.RadioButton();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.ChooseFileButton = new System.Windows.Forms.Button();
            this.FileButton = new System.Windows.Forms.RadioButton();
            this.PortName1 = new System.Windows.Forms.ComboBox();
            this.USBButton = new System.Windows.Forms.RadioButton();
            this.COMButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SMScheckBox = new System.Windows.Forms.CheckBox();
            this.PortName2 = new System.Windows.Forms.ComboBox();
            this.comPortLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.SimulatorButton);
            this.groupBox1.Controls.Add(this.FileNameLabel);
            this.groupBox1.Controls.Add(this.ChooseFileButton);
            this.groupBox1.Controls.Add(this.FileButton);
            this.groupBox1.Controls.Add(this.PortName1);
            this.groupBox1.Controls.Add(this.USBButton);
            this.groupBox1.Controls.Add(this.COMButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 156);
            this.groupBox1.TabIndex = 106;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input device";
            // 
            // SimulatorButton
            // 
            this.SimulatorButton.AutoSize = true;
            this.SimulatorButton.Location = new System.Drawing.Point(6, 124);
            this.SimulatorButton.Name = "SimulatorButton";
            this.SimulatorButton.Size = new System.Drawing.Size(94, 24);
            this.SimulatorButton.TabIndex = 57;
            this.SimulatorButton.Text = "Simulator";
            this.SimulatorButton.UseVisualStyleBackColor = true;
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Location = new System.Drawing.Point(278, 96);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(0, 20);
            this.FileNameLabel.TabIndex = 56;
            // 
            // ChooseFileButton
            // 
            this.ChooseFileButton.Location = new System.Drawing.Point(131, 92);
            this.ChooseFileButton.Name = "ChooseFileButton";
            this.ChooseFileButton.Size = new System.Drawing.Size(119, 29);
            this.ChooseFileButton.TabIndex = 55;
            this.ChooseFileButton.Text = "Choose File";
            this.ChooseFileButton.UseVisualStyleBackColor = true;
            this.ChooseFileButton.Click += new System.EventHandler(this.ChooseFile);
            // 
            // FileButton
            // 
            this.FileButton.AutoSize = true;
            this.FileButton.Location = new System.Drawing.Point(6, 94);
            this.FileButton.Name = "FileButton";
            this.FileButton.Size = new System.Drawing.Size(52, 24);
            this.FileButton.TabIndex = 54;
            this.FileButton.Text = "File";
            this.FileButton.UseVisualStyleBackColor = true;
            this.FileButton.CheckedChanged += new System.EventHandler(this.ChangeInputDevice);
            // 
            // PortName1
            // 
            this.PortName1.FormattingEnabled = true;
            this.PortName1.Location = new System.Drawing.Point(131, 33);
            this.PortName1.Name = "PortName1";
            this.PortName1.Size = new System.Drawing.Size(119, 28);
            this.PortName1.TabIndex = 53;
            // 
            // USBButton
            // 
            this.USBButton.AutoSize = true;
            this.USBButton.Checked = true;
            this.USBButton.Location = new System.Drawing.Point(6, 64);
            this.USBButton.Name = "USBButton";
            this.USBButton.Size = new System.Drawing.Size(93, 24);
            this.USBButton.TabIndex = 1;
            this.USBButton.TabStop = true;
            this.USBButton.Text = "USB port";
            this.USBButton.UseVisualStyleBackColor = true;
            this.USBButton.CheckedChanged += new System.EventHandler(this.ChangeInputDevice);
            // 
            // COMButton
            // 
            this.COMButton.AutoSize = true;
            this.COMButton.Location = new System.Drawing.Point(6, 34);
            this.COMButton.Name = "COMButton";
            this.COMButton.Size = new System.Drawing.Size(95, 24);
            this.COMButton.TabIndex = 0;
            this.COMButton.Text = "COM port";
            this.COMButton.UseVisualStyleBackColor = true;
            this.COMButton.CheckedChanged += new System.EventHandler(this.ChangeInputDevice);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.IDTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(524, 107);
            this.groupBox2.TabIndex = 107;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connect Config";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Set";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SetID);
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(131, 32);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(234, 26);
            this.IDTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Address";
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Image = global::ECGWorkStation.Properties.Resources.Delete_icon_24px;
            this.CancelButton.Location = new System.Drawing.Point(276, 413);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(45, 45);
            this.CancelButton.TabIndex = 105;
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // AcceptButton
            // 
            this.AcceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AcceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AcceptButton.Image = global::ECGWorkStation.Properties.Resources.Accept_icon_32_px;
            this.AcceptButton.Location = new System.Drawing.Point(225, 413);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(45, 45);
            this.AcceptButton.TabIndex = 104;
            this.AcceptButton.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SMScheckBox);
            this.groupBox3.Controls.Add(this.PortName2);
            this.groupBox3.Controls.Add(this.comPortLabel);
            this.groupBox3.Location = new System.Drawing.Point(12, 287);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(524, 113);
            this.groupBox3.TabIndex = 108;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SMS Setting";
            // 
            // SMScheckBox
            // 
            this.SMScheckBox.AutoSize = true;
            this.SMScheckBox.Location = new System.Drawing.Point(11, 25);
            this.SMScheckBox.Name = "SMScheckBox";
            this.SMScheckBox.Size = new System.Drawing.Size(78, 24);
            this.SMScheckBox.TabIndex = 6;
            this.SMScheckBox.Text = "Enabel";
            this.SMScheckBox.UseVisualStyleBackColor = true;
            // 
            // PortName2
            // 
            this.PortName2.FormattingEnabled = true;
            this.PortName2.Location = new System.Drawing.Point(127, 59);
            this.PortName2.Name = "PortName2";
            this.PortName2.Size = new System.Drawing.Size(121, 28);
            this.PortName2.TabIndex = 5;
            // 
            // comPortLabel
            // 
            this.comPortLabel.AutoSize = true;
            this.comPortLabel.Location = new System.Drawing.Point(7, 62);
            this.comPortLabel.Name = "comPortLabel";
            this.comPortLabel.Size = new System.Drawing.Size(78, 20);
            this.comPortLabel.TabIndex = 4;
            this.comPortLabel.Text = "COM Port";
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(548, 470);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AcceptButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SettingForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton USBButton;
        private System.Windows.Forms.RadioButton COMButton;
        private System.Windows.Forms.ComboBox PortName1;
        private System.Windows.Forms.RadioButton FileButton;
        private System.Windows.Forms.Button ChooseFileButton;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.RadioButton SimulatorButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox SMScheckBox;
        private System.Windows.Forms.ComboBox PortName2;
        private System.Windows.Forms.Label comPortLabel;

    }
}