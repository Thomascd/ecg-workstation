namespace ECGWorkStation
{
    partial class RecordLabel
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
            this.Label = new System.Windows.Forms.Label();
            this.subLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Location = new System.Drawing.Point(30, 30);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(140, 24);
            this.Label.TabIndex = 8;
            this.Label.Text = "-- / -- /--  -- : --";
            this.Label.Click += new System.EventHandler(this.ViewRecord);
            this.Label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down);
            this.Label.MouseHover += new System.EventHandler(this.Mouse_Hover);
            // 
            // subLabel
            // 
            this.subLabel.AutoSize = true;
            this.subLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subLabel.Location = new System.Drawing.Point(60, 70);
            this.subLabel.Name = "subLabel";
            this.subLabel.Size = new System.Drawing.Size(18, 13);
            this.subLabel.TabIndex = 12;
            this.subLabel.Text = "ID";
            this.subLabel.Click += new System.EventHandler(this.ViewRecord);
            this.subLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down);
            this.subLabel.MouseHover += new System.EventHandler(this.Mouse_Hover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::ECGWorkStation.Properties.Resources._1346394929_Tasks;
            this.pictureBox1.Location = new System.Drawing.Point(504, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 127);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.ViewRecord);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down);
            this.pictureBox1.MouseHover += new System.EventHandler(this.Mouse_Hover);
            // 
            // RecordLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.subLabel);
            this.Controls.Add(this.Label);
            this.DoubleBuffered = true;
            this.Name = "RecordLabel";
            this.Size = new System.Drawing.Size(655, 150);
            this.Click += new System.EventHandler(this.ViewRecord);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down);
            this.MouseLeave += new System.EventHandler(this.Mouse_Leave);
            this.MouseHover += new System.EventHandler(this.Mouse_Hover);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label Label;
        public System.Windows.Forms.Label subLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
