using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ECGWorkStation
{
    partial class PatientListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientListForm));
            this.CloseButton = new System.Windows.Forms.Button();
            this.BackgroundPanel = new System.Windows.Forms.Panel();
            this.PatientListPanel = new System.Windows.Forms.Panel();
            this.AvartarBox = new System.Windows.Forms.PictureBox();
            this.DoctorNameLabel = new System.Windows.Forms.Label();
            this.AllPatientButton = new System.Windows.Forms.RadioButton();
            this.MyPatientButton = new System.Windows.Forms.RadioButton();
            this.BackgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvartarBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(1539, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(45, 45);
            this.CloseButton.TabIndex = 8;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.Close);
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackgroundPanel.AutoScroll = true;
            this.BackgroundPanel.Controls.Add(this.PatientListPanel);
            this.BackgroundPanel.Location = new System.Drawing.Point(0, 185);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(1600, 715);
            this.BackgroundPanel.TabIndex = 9;
            // 
            // PatientListPanel
            // 
            this.PatientListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PatientListPanel.Location = new System.Drawing.Point(0, 0);
            this.PatientListPanel.Name = "PatientListPanel";
            this.PatientListPanel.Size = new System.Drawing.Size(1600, 690);
            this.PatientListPanel.TabIndex = 0;
            // 
            // AvartarBox
            // 
            this.AvartarBox.Image = global::ECGWorkStation.Properties.Resources.doctor_icon;
            this.AvartarBox.Location = new System.Drawing.Point(120, 24);
            this.AvartarBox.Name = "AvartarBox";
            this.AvartarBox.Size = new System.Drawing.Size(120, 120);
            this.AvartarBox.TabIndex = 10;
            this.AvartarBox.TabStop = false;
            // 
            // DoctorNameLabel
            // 
            this.DoctorNameLabel.AutoSize = true;
            this.DoctorNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorNameLabel.Location = new System.Drawing.Point(279, 24);
            this.DoctorNameLabel.Name = "DoctorNameLabel";
            this.DoctorNameLabel.Size = new System.Drawing.Size(90, 29);
            this.DoctorNameLabel.TabIndex = 11;
            this.DoctorNameLabel.Text = "Doctor";
            // 
            // AllPatientButton
            // 
            this.AllPatientButton.AutoSize = true;
            this.AllPatientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllPatientButton.Location = new System.Drawing.Point(1446, 146);
            this.AllPatientButton.Name = "AllPatientButton";
            this.AllPatientButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AllPatientButton.Size = new System.Drawing.Size(138, 33);
            this.AllPatientButton.TabIndex = 12;
            this.AllPatientButton.Text = "All Patient";
            this.AllPatientButton.UseVisualStyleBackColor = true;
            // 
            // MyPatientButton
            // 
            this.MyPatientButton.AutoSize = true;
            this.MyPatientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyPatientButton.Location = new System.Drawing.Point(1446, 107);
            this.MyPatientButton.Name = "MyPatientButton";
            this.MyPatientButton.Size = new System.Drawing.Size(142, 33);
            this.MyPatientButton.TabIndex = 7;
            this.MyPatientButton.Text = "My Patient";
            this.MyPatientButton.UseVisualStyleBackColor = true;
            this.MyPatientButton.CheckedChanged += new System.EventHandler(this.LoadPatientList);
            // 
            // PatientListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.MyPatientButton);
            this.Controls.Add(this.AllPatientButton);
            this.Controls.Add(this.DoctorNameLabel);
            this.Controls.Add(this.AvartarBox);
            this.Controls.Add(this.BackgroundPanel);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PatientListForm";
            this.Text = "ManagerForm";
            this.Load += new System.EventHandler(this.Login);
            this.BackgroundPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AvartarBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel BackgroundPanel;
        private System.Windows.Forms.Panel PatientListPanel;
        private System.Windows.Forms.PictureBox AvartarBox;
        private System.Windows.Forms.Label DoctorNameLabel;
        private System.Windows.Forms.RadioButton AllPatientButton;
        private System.Windows.Forms.RadioButton MyPatientButton;
    }
}