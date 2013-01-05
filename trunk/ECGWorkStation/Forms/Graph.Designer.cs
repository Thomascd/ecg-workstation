namespace ECGWorkStation
{
    partial class Graph
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
            this.Panel = new System.Windows.Forms.Panel();
            this.Label = new System.Windows.Forms.Label();
            this.Background = new System.Windows.Forms.Panel();
            this.Background.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Panel.BackColor = System.Drawing.Color.Black;
            this.Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(77, 146);
            this.Panel.TabIndex = 1;
            this.Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.ReDraw);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.BackColor = System.Drawing.Color.Black;
            this.Label.ForeColor = System.Drawing.Color.Red;
            this.Label.Location = new System.Drawing.Point(5, 5);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(10, 13);
            this.Label.TabIndex = 4;
            this.Label.Text = "I";
            // 
            // Background
            // 
            this.Background.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Background.AutoScroll = true;
            this.Background.Controls.Add(this.Panel);
            this.Background.Location = new System.Drawing.Point(0, 0);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(146, 146);
            this.Background.TabIndex = 5;
            // 
            // Graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.Label);
            this.Controls.Add(this.Background);
            this.Name = "Graph";
            this.Size = new System.Drawing.Size(146, 146);
            this.Background.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Panel Background;
    }
}
