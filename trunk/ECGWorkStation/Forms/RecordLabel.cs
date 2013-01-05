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
    partial class RecordLabel : UserControl
    {
        private Doctor  Doctor;
        private Record  Record;
        private Patient Patient;

        #region init

        public RecordLabel()
        {
            InitializeComponent();
        }

        public RecordLabel(Doctor Doctor, Patient Patient, Record Record, Point Point)
        {
            InitializeComponent();
            this.Location = Point;

            this.Doctor   = Doctor;
            this.Record   = Record;
            this.Patient  = Patient;

            // load record info
            Label.Text = Record.Date.ToString("h : m  d / M / yyyy");
            subLabel.Text   = Record.ID;
        }

        public RecordLabel(Doctor Doctor, Patient Patient, int RecordIndex, Point Point)
        {
            InitializeComponent();
            this.Location = Point;

            this.Doctor   = Doctor;
            this.Patient  = Patient;
            this.Record   = Patient.Records[RecordIndex];

            // load record info
            Label.Text = Record.Date.ToString("h : m  d / M / yyyy");
            subLabel.Text   = Record.ID;
        }

        #endregion

        #region changer color

        private void Mouse_Down(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.PanelSelect;
        }

        private void Mouse_Hover(object sender, EventArgs e)
        {
            this.BackColor = Color.PanelHover;
        }

        private void Mouse_Leave(object sender, EventArgs e)
        {
            this.BackColor = Color.Panel;
        }

        #endregion

        private void ViewRecord(object sender, EventArgs e)
        {
            RecordManager RecordManager = new RecordManager(this.Doctor, this.Patient, this.Record);
            RecordManager.Show();
        }
    }
}
