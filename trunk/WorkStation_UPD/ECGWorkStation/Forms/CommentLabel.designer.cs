namespace ECGWorkStation
{
    partial class CommentLabel
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
            this.DoctorNameLabel = new System.Windows.Forms.Label();
            this.CommentPreviewLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DoctorNameLabel
            // 
            this.DoctorNameLabel.AutoSize = true;
            this.DoctorNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorNameLabel.Location = new System.Drawing.Point(10, 10);
            this.DoctorNameLabel.Name = "DoctorNameLabel";
            this.DoctorNameLabel.Size = new System.Drawing.Size(166, 29);
            this.DoctorNameLabel.TabIndex = 0;
            this.DoctorNameLabel.Text = "Doctor Name";
            this.DoctorNameLabel.Click += new System.EventHandler(this.MouseClick);
            this.DoctorNameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down);
            this.DoctorNameLabel.MouseHover += new System.EventHandler(this.Mouse_Hover);
            // 
            // CommentPreviewLabel
            // 
            this.CommentPreviewLabel.AutoSize = true;
            this.CommentPreviewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommentPreviewLabel.Location = new System.Drawing.Point(14, 65);
            this.CommentPreviewLabel.Name = "CommentPreviewLabel";
            this.CommentPreviewLabel.Size = new System.Drawing.Size(142, 17);
            this.CommentPreviewLabel.TabIndex = 1;
            this.CommentPreviewLabel.Text = "Comments preview ...";
            this.CommentPreviewLabel.Click += new System.EventHandler(this.MouseClick);
            this.CommentPreviewLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down);
            this.CommentPreviewLabel.MouseHover += new System.EventHandler(this.Mouse_Hover);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(14, 42);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(82, 17);
            this.DateLabel.TabIndex = 2;
            this.DateLabel.Text = "Date Time";
            this.DateLabel.Click += new System.EventHandler(this.MouseClick);
            this.DateLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down);
            this.DateLabel.MouseHover += new System.EventHandler(this.Mouse_Hover);
            // 
            // CommentLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.CommentPreviewLabel);
            this.Controls.Add(this.DoctorNameLabel);
            this.Name = "CommentLabel";
            this.Size = new System.Drawing.Size(430, 100);
            this.Click += new System.EventHandler(this.MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down);
            this.MouseLeave += new System.EventHandler(this.Mouse_Leave);
            this.MouseHover += new System.EventHandler(this.Mouse_Hover);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DoctorNameLabel;
        private System.Windows.Forms.Label CommentPreviewLabel;
        private System.Windows.Forms.Label DateLabel;
    }
}
