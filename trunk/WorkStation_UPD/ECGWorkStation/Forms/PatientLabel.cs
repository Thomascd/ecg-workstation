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
    partial class PatientLabel : UserControl
    {
        private Doctor  Doctor;
        private Patient Patient;

        public PatientLabel(Doctor Doctor, Patient Patient, Point Point)
        {
            InitializeComponent();
            this.Location = Point;

            this.Patient = Patient;
            this.Doctor  = Doctor;

            if (Doctor.ID == Patient.DoctorID)
            {
                // color default
                this.BackColor = Color.Panel;

                // set tooltip                
                this.toolTip.SetToolTip(this, "My Patient");
            }
            else
            {
                // set color - Color.panel2 - not isdiretpatient
                this.BackColor = Color.Panel2;
                this.AddressLabel.ForeColor = Color.Black;

                // set tooltip
                this.toolTip.SetToolTip(this, Patient.DoctorName + "'s Patient");
            }

            AvatarBox.Image    = Patient.Avatar;
            NameLabel.Text     = Patient.Name;
            //IDLabel.Text       = Patient.ID;
            SexLabel.Text      = Patient.Sex.ToString();
            BirthdayLabel.Text = Patient.Birthday.ToShortDateString();
            AddressLabel.Text  = Patient.Address;
        }

        private void Select(object sender, EventArgs e)
        {
            // call Patient manager
            PatientManager PatientManager = new PatientManager(Doctor, Patient);
            PatientManager.ShowDialog();

            if (PatientManager.Updated)
            // update Patient info
            {
                AvatarBox.Image    = Patient.Avatar;
                NameLabel.Text     = Patient.Name;
                SexLabel.Text      = Patient.Sex.ToString();
                BirthdayLabel.Text = Patient.Birthday.ToShortDateString();
                AddressLabel.Text  = Patient.Address;
            }
        }

        private void Mouse_Hover(object sender, EventArgs e)
        {
            // set color
            this.BackColor   = Color.PanelHover;
            this.BorderStyle = BorderStyle.FixedSingle;
        }

        private void Mouse_Leave(object sender, EventArgs e)
        {
            // set color
            if (Doctor.ID == Patient.DoctorID)
            {
                this.BackColor = Color.Panel;
            }
            else
            {
                this.BackColor = Color.Panel2;
            }
            
            this.BorderStyle = BorderStyle.None;
        }

        private void Mouse_Down(object sender, MouseEventArgs e)
        {
            // set color
            this.BackColor = Color.PanelSelect;
        }
    }
}
