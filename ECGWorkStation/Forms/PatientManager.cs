using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECGWorkStation
{
    partial class PatientManager : Form
    {
        private Doctor  Doctor;
        private Patient Patient;
        
        private bool    Editable = false;
        public  bool    Updated  = false;

        #region init form

        public PatientManager()
        {
            InitializeComponent();
            InitializeFullScreen();
        }

        public PatientManager(Patient Patient)
        {
            InitializeComponent();
            InitializeFullScreen();
            this.Patient = Patient;

            LoadRecord();

            // patient info
            AvatarBox.Image   = Patient.Avatar;
            NameBox.Text      = Patient.Name;
            DoctorBox.Text    = Patient.ID;
            SexBox.Text       = Patient.Sex.ToString();
            BirthdayBox.Value = Patient.Birthday;
            WeightBox.Value   = (int) Patient.Weight;
            JobBox.Text       = Patient.Job;
            AddressBox.Text   = Patient.Address;
        }

        public PatientManager(Doctor Doctor, Patient Patient)
        {
            InitializeComponent();
            InitializeFullScreen();

            this.Doctor  = Doctor;
            this.Patient = Patient;

            LoadRecord();

            // patient info
            AvatarBox.Image     = Patient.Avatar;
            NameBox.Text        = Patient.Name;
            DoctorBox.Text          = Patient.ID;
            SexBox.Text         = Patient.Sex.ToString();
            BirthdayBox.Value   = Patient.Birthday;
            WeightBox.Value     = (int)Patient.Weight;
            JobBox.Text         = Patient.Job;
            AddressBox.Text     = Patient.Address;

            // editable
            //EditButton.Enabled = Doctor.ID == Patient.DoctorID;
        }

        void InitializeFullScreen()
        {
            this.Bounds = Screen.PrimaryScreen.Bounds;
            Height = Screen.PrimaryScreen.Bounds.Height;
            Width = Screen.PrimaryScreen.Bounds.Width;
            RecordListPanel.Height = Screen.PrimaryScreen.Bounds.Height - 170;
        }

        private void Back(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region edit patient infomation

        private void EditChanger(object sender, EventArgs e)
        {
            Editable = true;

            EditButton.Enabled   = false;
            AcceptButton.Enabled = true;
            CancelButton.Enabled = true;

            SexBox.Enabled          = true;
            BirthdayBox.Enabled     = true;
            WeightBox.Enabled       = true;
            NameBox.ReadOnly        = false;
            NameBox.BorderStyle     = BorderStyle.FixedSingle;
            NameBox.BackColor       = Color.White;
            JobBox.ReadOnly         = false;
            JobBox.BorderStyle      = BorderStyle.FixedSingle;
            JobBox.BackColor        = Color.White;
            AddressBox.ReadOnly     = false;
            AddressBox.BorderStyle  = BorderStyle.FixedSingle;
            AddressBox.BackColor    = Color.White;

            PatientInfoBox.BackColor = Color.PanelSelect;
        }

        private void AcceptEdit(object sender, EventArgs e)
        {
            // changer model
            Editable = false;

            EditButton.Enabled   = true;
            AcceptButton.Enabled = false;
            CancelButton.Enabled = false;

            SexBox.Enabled          = false;
            BirthdayBox.Enabled     = false;
            WeightBox.Enabled       = false;
            NameBox.ReadOnly        = true;
            NameBox.BorderStyle     = BorderStyle.None;
            NameBox.BackColor       = System.Drawing.SystemColors.Control;
            JobBox.ReadOnly         = true;
            JobBox.BorderStyle      = BorderStyle.None;
            JobBox.BackColor        = System.Drawing.SystemColors.Control;
            AddressBox.ReadOnly     = true;
            AddressBox.BorderStyle  = BorderStyle.None;
            AddressBox.BackColor    = System.Drawing.SystemColors.Control;

            PatientInfoBox.BackColor = Color.Panel;

            // update value
            Patient.Update(
                AvatarBox.Image, 
                NameBox.Text, 
                BirthdayBox.Value, 
                SexBox.Text, 
                (int)WeightBox.Value, 
                JobBox.Text, 
                AddressBox.Text);            

            // regiter update
            Updated = true;
        }

        private void CancelEdit(object sender, EventArgs e)
        {
            // changer type
            Editable = false;

            EditButton.Enabled   = true;
            AcceptButton.Enabled = false;
            CancelButton.Enabled = false;

            SexBox.Enabled          = false;
            BirthdayBox.Enabled     = false;
            WeightBox.Enabled       = false;
            NameBox.ReadOnly        = true;
            NameBox.BorderStyle     = BorderStyle.None;
            NameBox.BackColor       = System.Drawing.SystemColors.Control;
            JobBox.ReadOnly         = true;
            JobBox.BorderStyle      = BorderStyle.None;
            JobBox.BackColor        = System.Drawing.SystemColors.Control;
            AddressBox.ReadOnly     = true;
            AddressBox.BorderStyle  = BorderStyle.None;
            AddressBox.BackColor    = System.Drawing.SystemColors.Control;

            PatientInfoBox.BackColor = Color.PanelSelect;

            // restore value
            AvatarBox.Image   = Patient.Avatar;
            NameBox.Text      = Patient.Name;
            DoctorBox.Text    = Patient.DoctorName;
            SexBox.Text       = Patient.Sex.ToString();
            BirthdayBox.Value = Patient.Birthday;
            WeightBox.Value   = (int)Patient.Weight;
        }

        private void ChangerAvatar(object sender, EventArgs e)
        {
            if (Editable)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Images (*.BMP;*.JPG;*.GIF;*.PNG;*.ICO)|*.BMP;*.JPG;*.GIF;*.PNG;*.ICO|All files (*.*)|*.*";
                ofd.Title  = "Select avatar";

                if (ofd.ShowDialog() == DialogResult.OK)
                    try
                    {
                        this.AvatarBox.Image = Image.FromFile(ofd.FileName);
                    }
                    catch
                    {                        
                        MessageBox.Show("This file is not support");
                    }
            }
        }

        #endregion

        #region Record

        private void LoadRecord()
        // load record list
        {
            Patient.LoadRecord();

            if (Patient.Records != null)
            {
                int count = Patient.Records.Count();
                for (int i = 0; i < count; i++)
                {
                    // set location for new Patient Label
                    // Patient size = (310 x 150)
                    // first column space = 120
                    // 4 patient label / column
                    Point Point = new Point(0, i * 160);

                    // set size of Patient List Panel
                    // defaul with = 1366
                    if (Point.Y + 150 > (Height - 170)) RecordListPanel.Height = Point.Y + 180;

                    // add new Patient Lable to Patients List Panel

                    //RecordListPanel.Controls.Add(new RecordLabel(Patient, i, Point)); 

                    RecordLabel NewLabel = new RecordLabel(Doctor, Patient, i, Point);
                    NewLabel.Width = Width - 780;
                    RecordListPanel.Controls.Add(NewLabel);
                }
            }
        }

        private void reLoadRecord()
        // clear record list and reload new record for update
        {
            RecordListPanel.Controls.Clear();
            Patient.reLoadRecord();
            this.LoadRecord();
        }

        private void updateRecord()
        {
            RecordListPanel.Controls.Clear();
            this.LoadRecord();
        }

        #endregion

        #region call ECG viewer

        private void ViewECG(object sender, EventArgs e)
        {
            MonitorForm ViewECG = new MonitorForm(Patient);
            ViewECG.ShowDialog();
            
            if (ViewECG.Updated) updateRecord();
        }

        #endregion


    }
}
