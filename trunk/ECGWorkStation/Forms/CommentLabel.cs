using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECGWorkStation
{
    partial class CommentLabel : UserControl
    {
        public Doctor  Doctor;
        public Comment Comment;
        private int    Index;

        public event EventHandler<CommentEventArgs> Select;

        #region init form

        public CommentLabel(Doctor Doctor, Comment Comment, int Index, Point Point)
        {
            InitializeComponent();
            this.Location = Point;

            this.Index = Index;            

            // data
            this.Doctor  = Doctor;
            this.Comment = Comment;

            this.DoctorNameLabel.Text     = Comment.DoctorName;
            this.DateLabel.Text           = Comment.DateTime.ToShortDateString() + " " + Comment.DateTime.ToShortTimeString();
            this.CommentPreviewLabel.Text = Comment.Data.Length > 60 ? 
                Comment.Data.Substring(0, 57).Replace("\n", " ") + "..." : 
                Comment.Data.Replace("\n", " ");
            // Comment Preview label leght = 60
        }

        #endregion

        #region color

        private void Mouse_Hover(object sender, EventArgs e)
        {
            if (!Selected) this.BackColor = Color.PanelHover;
        }

        private void Mouse_Down(object sender, MouseEventArgs e)
        {
            if(!Selected) this.BackColor = Color.PanelSelect;
        }

        private void Mouse_Leave(object sender, EventArgs e)
        {
            if (!Selected) this.BackColor = Color.Panel;
        }

        private bool SelectedValue = false;

        public bool Selected
        {
            get
            {
                return SelectedValue;
            }
            set
            {
                SelectedValue = value;
                if(value)
                {
                    this.BackColor = Color.PanelSelect;
                }
                else
                {
                    this.BackColor = Color.Panel;
                }
            }
        }

        #endregion

        public void MouseClick(object sender, EventArgs e)
        {
            if (!Selected)
            {
                // change color
                Selected = true;
                this.BackColor = Color.PanelSelect;

                // call select handle
                CommentEventArgs args = new CommentEventArgs();
                args.Index = Index;

                Select(this, args);
            }
        }
    }
}
