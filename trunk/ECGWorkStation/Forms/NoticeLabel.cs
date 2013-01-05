using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ECGWorkStation
{
    partial class NoticeLabel : UserControl
    {
        public String   NoticeName { get; set; }
        public DateTime NoticeTime { get; set; }
        public double   Offset { get; set; }

        public EventHandler<EventArgs> ViewNotice;

        public NoticeLabel()
        {
            InitializeComponent();
        }

        public NoticeLabel(string Name, DateTime Time, double Offset)
        {
            InitializeComponent();

            this.NoticeName = Name;
            this.NoticeTime = Time;
            this.Offset     = Offset;

            NameLabel.Text = NoticeName;
            TimeLabel.Text = Time.ToLongTimeString();
        }

        private void Select(object sender, EventArgs e)
        {
            ViewNotice(this, null);
        }

        private void Mouse_Hover(object sender, EventArgs e)
        {
            if (!Selected) this.BackColor = Color.PanelHover;
        }

        private void Mouse_Down(object sender, MouseEventArgs e)
        {
            if (!Selected) this.BackColor = Color.PanelSelect;
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
                if (value)
                {
                    this.BackColor = Color.PanelSelect;
                }
                else
                {
                    this.BackColor = Color.Panel;
                }
            }
        }
    }
}
