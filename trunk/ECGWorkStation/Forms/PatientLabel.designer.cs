namespace ECGWorkStation
{
    partial class PatientLabel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SexLabel = new System.Windows.Forms.Label();
            this.BirthdayLabel = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.AvatarBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.Location = new System.Drawing.Point(151, 78);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(13, 13);
            this.AddressLabel.TabIndex = 10;
            this.AddressLabel.Text = "--";
            this.AddressLabel.Click += new System.EventHandler(this.Select);
            this.AddressLabel.MouseHover += new System.EventHandler(this.Mouse_Hover);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(3, 3);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(65, 24);
            this.NameLabel.TabIndex = 7;
            this.NameLabel.Text = "Name";
            this.NameLabel.Click += new System.EventHandler(this.Select);
            this.NameLabel.MouseLeave += new System.EventHandler(this.Mouse_Leave);
            this.NameLabel.MouseHover += new System.EventHandler(this.Mouse_Hover);
            // 
            // SexLabel
            // 
            this.SexLabel.AutoSize = true;
            this.SexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SexLabel.Location = new System.Drawing.Point(151, 33);
            this.SexLabel.Name = "SexLabel";
            this.SexLabel.Size = new System.Drawing.Size(25, 13);
            this.SexLabel.TabIndex = 9;
            this.SexLabel.Text = "Sex";
            this.SexLabel.Click += new System.EventHandler(this.Select);
            this.SexLabel.MouseHover += new System.EventHandler(this.Mouse_Hover);
            // 
            // BirthdayLabel
            // 
            this.BirthdayLabel.AutoSize = true;
            this.BirthdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthdayLabel.Location = new System.Drawing.Point(151, 56);
            this.BirthdayLabel.Name = "BirthdayLabel";
            this.BirthdayLabel.Size = new System.Drawing.Size(35, 13);
            this.BirthdayLabel.TabIndex = 8;
            this.BirthdayLabel.Text = "--/--/--";
            this.BirthdayLabel.Click += new System.EventHandler(this.Select);
            this.BirthdayLabel.MouseHover += new System.EventHandler(this.Mouse_Hover);
            // 
            // AvatarBox
            // 
            this.AvatarBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AvatarBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AvatarBox.ErrorImage = global::ECGWorkStation.Properties.Resources._1346378772_People_MSN;
            this.AvatarBox.Image = global::ECGWorkStation.Properties.Resources._1346378772_People_MSN1;
            this.AvatarBox.InitialImage = global::ECGWorkStation.Properties.Resources._1346378772_People_MSN;
            this.AvatarBox.Location = new System.Drawing.Point(3, 30);
            this.AvatarBox.Name = "AvatarBox";
            this.AvatarBox.Size = new System.Drawing.Size(125, 115);
            this.AvatarBox.TabIndex = 6;
            this.AvatarBox.TabStop = false;
            this.AvatarBox.Click += new System.EventHandler(this.Select);
            this.AvatarBox.MouseLeave += new System.EventHandler(this.Mouse_Leave);
            this.AvatarBox.MouseHover += new System.EventHandler(this.Mouse_Hover);
            // 
            // PatientLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.AvatarBox);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.SexLabel);
            this.Controls.Add(this.BirthdayLabel);
            this.Name = "PatientLabel";
            this.Size = new System.Drawing.Size(310, 150);
            this.Click += new System.EventHandler(this.Select);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down);
            this.MouseLeave += new System.EventHandler(this.Mouse_Leave);
            this.MouseHover += new System.EventHandler(this.Mouse_Hover);
            ((System.ComponentModel.ISupportInitialize)(this.AvatarBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox AvatarBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SexLabel;
        private System.Windows.Forms.Label BirthdayLabel;
        private System.Windows.Forms.ToolTip toolTip;


    }
}
