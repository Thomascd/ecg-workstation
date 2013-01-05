namespace ECGWorkStation
{
    partial class RecordManager
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ViewECGBox = new System.Windows.Forms.Button();
            this.TreatDoctorNameLabel = new System.Windows.Forms.Label();
            this.RecordLeghtLabel = new System.Windows.Forms.Label();
            this.CommentsNumerLabel = new System.Windows.Forms.Label();
            this.DateTimeLabel = new System.Windows.Forms.Label();
            this.AvatarBox = new System.Windows.Forms.PictureBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.PatientNameLabel = new System.Windows.Forms.Label();
            this.CommentListBox = new System.Windows.Forms.Panel();
            this.CommentBox = new System.Windows.Forms.RichTextBox();
            this.CommentListBoxBackground = new System.Windows.Forms.Panel();
            this.EditButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.AddButton = new System.Windows.Forms.Button();
            this.CommentDoctorNameLabel = new System.Windows.Forms.Label();
            this.CommentDateLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarBox)).BeginInit();
            this.CommentListBoxBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.ViewECGBox);
            this.panel1.Controls.Add(this.TreatDoctorNameLabel);
            this.panel1.Controls.Add(this.RecordLeghtLabel);
            this.panel1.Controls.Add(this.CommentsNumerLabel);
            this.panel1.Controls.Add(this.DateTimeLabel);
            this.panel1.Controls.Add(this.AvatarBox);
            this.panel1.Controls.Add(this.BackButton);
            this.panel1.Controls.Add(this.PatientNameLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 900);
            this.panel1.TabIndex = 19;
            // 
            // ViewECGBox
            // 
            this.ViewECGBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ViewECGBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewECGBox.Image = global::ECGWorkStation.Properties.Resources._1346394929_Tasks;
            this.ViewECGBox.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ViewECGBox.Location = new System.Drawing.Point(20, 730);
            this.ViewECGBox.Name = "ViewECGBox";
            this.ViewECGBox.Size = new System.Drawing.Size(362, 150);
            this.ViewECGBox.TabIndex = 38;
            this.ViewECGBox.Text = "  View Record";
            this.ViewECGBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ViewECGBox.UseVisualStyleBackColor = true;
            this.ViewECGBox.Click += new System.EventHandler(this.ViewRecord);
            // 
            // TreatDoctorNameLabel
            // 
            this.TreatDoctorNameLabel.AutoSize = true;
            this.TreatDoctorNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TreatDoctorNameLabel.Location = new System.Drawing.Point(78, 300);
            this.TreatDoctorNameLabel.Name = "TreatDoctorNameLabel";
            this.TreatDoctorNameLabel.Size = new System.Drawing.Size(103, 20);
            this.TreatDoctorNameLabel.TabIndex = 26;
            this.TreatDoctorNameLabel.Text = "Doctor Name";
            // 
            // RecordLeghtLabel
            // 
            this.RecordLeghtLabel.AutoSize = true;
            this.RecordLeghtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordLeghtLabel.Location = new System.Drawing.Point(78, 362);
            this.RecordLeghtLabel.Name = "RecordLeghtLabel";
            this.RecordLeghtLabel.Size = new System.Drawing.Size(106, 20);
            this.RecordLeghtLabel.TabIndex = 24;
            this.RecordLeghtLabel.Text = "Record Leght";
            // 
            // CommentsNumerLabel
            // 
            this.CommentsNumerLabel.AutoSize = true;
            this.CommentsNumerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommentsNumerLabel.Location = new System.Drawing.Point(78, 331);
            this.CommentsNumerLabel.Name = "CommentsNumerLabel";
            this.CommentsNumerLabel.Size = new System.Drawing.Size(144, 20);
            this.CommentsNumerLabel.TabIndex = 23;
            this.CommentsNumerLabel.Text = "Comments number";
            // 
            // DateTimeLabel
            // 
            this.DateTimeLabel.AutoSize = true;
            this.DateTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimeLabel.Location = new System.Drawing.Point(35, 89);
            this.DateTimeLabel.Name = "DateTimeLabel";
            this.DateTimeLabel.Size = new System.Drawing.Size(292, 44);
            this.DateTimeLabel.TabIndex = 21;
            this.DateTimeLabel.Text = "DateTimeLable";
            // 
            // AvatarBox
            // 
            this.AvatarBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AvatarBox.Location = new System.Drawing.Point(43, 157);
            this.AvatarBox.Name = "AvatarBox";
            this.AvatarBox.Size = new System.Drawing.Size(120, 120);
            this.AvatarBox.TabIndex = 20;
            this.AvatarBox.TabStop = false;
            // 
            // BackButton
            // 
            this.BackButton.Image = global::ECGWorkStation.Properties.Resources._1346394982_arrow_left_2_2;
            this.BackButton.Location = new System.Drawing.Point(10, 10);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(45, 45);
            this.BackButton.TabIndex = 17;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.Close);
            // 
            // PatientNameLabel
            // 
            this.PatientNameLabel.AutoSize = true;
            this.PatientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientNameLabel.Location = new System.Drawing.Point(195, 235);
            this.PatientNameLabel.Name = "PatientNameLabel";
            this.PatientNameLabel.Size = new System.Drawing.Size(117, 20);
            this.PatientNameLabel.TabIndex = 19;
            this.PatientNameLabel.Text = "Patient Name";
            // 
            // CommentListBox
            // 
            this.CommentListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CommentListBox.AutoSize = true;
            this.CommentListBox.Location = new System.Drawing.Point(0, 0);
            this.CommentListBox.Name = "CommentListBox";
            this.CommentListBox.Size = new System.Drawing.Size(440, 900);
            this.CommentListBox.TabIndex = 0;
            // 
            // CommentBox
            // 
            this.CommentBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommentBox.BackColor = System.Drawing.Color.White;
            this.CommentBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CommentBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.CommentBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommentBox.Location = new System.Drawing.Point(884, 105);
            this.CommentBox.Name = "CommentBox";
            this.CommentBox.ReadOnly = true;
            this.CommentBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.CommentBox.Size = new System.Drawing.Size(710, 792);
            this.CommentBox.TabIndex = 31;
            this.CommentBox.Text = "";
            // 
            // CommentListBoxBackground
            // 
            this.CommentListBoxBackground.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CommentListBoxBackground.AutoScroll = true;
            this.CommentListBoxBackground.BackColor = System.Drawing.SystemColors.Control;
            this.CommentListBoxBackground.Controls.Add(this.CommentListBox);
            this.CommentListBoxBackground.Location = new System.Drawing.Point(400, 0);
            this.CommentListBoxBackground.Name = "CommentListBoxBackground";
            this.CommentListBoxBackground.Size = new System.Drawing.Size(460, 900);
            this.CommentListBoxBackground.TabIndex = 20;
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditButton.BackColor = System.Drawing.SystemColors.Control;
            this.EditButton.Enabled = false;
            this.EditButton.Image = global::ECGWorkStation.Properties.Resources.Edit_icon_32px;
            this.EditButton.Location = new System.Drawing.Point(1414, 10);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(45, 45);
            this.EditButton.TabIndex = 28;
            this.ToolTip.SetToolTip(this.EditButton, "Edit");
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.Edit);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Enabled = false;
            this.CancelButton.Image = global::ECGWorkStation.Properties.Resources.Delete_icon_32px;
            this.CancelButton.Location = new System.Drawing.Point(1543, 10);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(45, 45);
            this.CancelButton.TabIndex = 30;
            this.ToolTip.SetToolTip(this.CancelButton, "Cancel");
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.Cancel);
            // 
            // AcceptButton
            // 
            this.AcceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AcceptButton.Enabled = false;
            this.AcceptButton.Image = global::ECGWorkStation.Properties.Resources.Accept_icon_32_px;
            this.AcceptButton.Location = new System.Drawing.Point(1478, 10);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(45, 45);
            this.AcceptButton.TabIndex = 29;
            this.ToolTip.SetToolTip(this.AcceptButton, "Accept");
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.Accept);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.BackColor = System.Drawing.SystemColors.Control;
            this.AddButton.Image = global::ECGWorkStation.Properties.Resources.File_edit_icon;
            this.AddButton.Location = new System.Drawing.Point(1348, 10);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(45, 45);
            this.AddButton.TabIndex = 29;
            this.ToolTip.SetToolTip(this.AddButton, "Comment");
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddComment);
            // 
            // CommentDoctorNameLabel
            // 
            this.CommentDoctorNameLabel.AutoSize = true;
            this.CommentDoctorNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommentDoctorNameLabel.Location = new System.Drawing.Point(899, 10);
            this.CommentDoctorNameLabel.Name = "CommentDoctorNameLabel";
            this.CommentDoctorNameLabel.Size = new System.Drawing.Size(114, 20);
            this.CommentDoctorNameLabel.TabIndex = 33;
            this.CommentDoctorNameLabel.Text = "Doctor Name";
            // 
            // CommentDateLabel
            // 
            this.CommentDateLabel.AutoSize = true;
            this.CommentDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommentDateLabel.Location = new System.Drawing.Point(899, 37);
            this.CommentDateLabel.Name = "CommentDateLabel";
            this.CommentDateLabel.Size = new System.Drawing.Size(47, 20);
            this.CommentDateLabel.TabIndex = 36;
            this.CommentDateLabel.Text = "detail";
            // 
            // RecordManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.CommentDateLabel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CommentDoctorNameLabel);
            this.Controls.Add(this.CommentBox);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.CommentListBoxBackground);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecordManager";
            this.ShowInTaskbar = false;
            this.Text = "RecordManager";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarBox)).EndInit();
            this.CommentListBoxBackground.ResumeLayout(false);
            this.CommentListBoxBackground.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TreatDoctorNameLabel;
        private System.Windows.Forms.Label RecordLeghtLabel;
        private System.Windows.Forms.Label CommentsNumerLabel;
        private System.Windows.Forms.Label DateTimeLabel;
        private System.Windows.Forms.PictureBox AvatarBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label PatientNameLabel;
        private System.Windows.Forms.RichTextBox CommentBox;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Panel CommentListBox;
        private System.Windows.Forms.Panel CommentListBoxBackground;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.Label CommentDoctorNameLabel;
        private System.Windows.Forms.Label CommentDateLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ViewECGBox;

    }
}