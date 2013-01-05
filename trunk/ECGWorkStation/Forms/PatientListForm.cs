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
    public partial class PatientListForm : Form
    {
        private Doctor Doctor;

        #region Init From

        public PatientListForm()
        {
            InitializeComponent();
            InitializeFullScreen();
            this.BackColor = Color.PanelBackground;
        }

        private void InitializeFullScreen()
        {
            this.Bounds = Screen.PrimaryScreen.Bounds;
            int Height  = Screen.PrimaryScreen.Bounds.Height;
            int Width   = Screen.PrimaryScreen.Bounds.Width;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(Width - 55, 12);
            this.CloseButton.Size = new System.Drawing.Size(45, 45);
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.Location = new System.Drawing.Point(0, 185);
            this.BackgroundPanel.Size = new System.Drawing.Size(Width, Height - 185);
            // 
            // PatientListPanel
            // 
            this.PatientListPanel.Location = new System.Drawing.Point(0, 0);
            this.PatientListPanel.Size = new System.Drawing.Size(Width, Height - 210);
            // 
            // AvartarBox
            // 
            this.AvartarBox.Image = global::ECGWorkStation.Properties.Resources.doctor_icon;
            this.AvartarBox.Location = new System.Drawing.Point(120, 25);
            this.AvartarBox.Size = new System.Drawing.Size(120, 120);
            // 
            // DoctorNameLabel
            // 
            this.DoctorNameLabel.Location = new System.Drawing.Point(270, 25);
            // 
            // AllPatientButton
            // 
            this.AllPatientButton.Location = new System.Drawing.Point(Width - 155, 145);
            // 
            // MyPatientButton
            // 
            this.MyPatientButton.Location = new System.Drawing.Point(Width - 155, 105);
        }

        private void Login(object sender, EventArgs e)
        // run when Load
        {
            LoginForm LoginForm = new LoginForm();

            if (LoginForm.ShowDialog() == DialogResult.OK)
            {
                this.Doctor = LoginForm.Doctor;
                DoctorNameLabel.Text = Doctor.Name;

                MyPatientButton.Checked = true;
                //AllPatientButton.Checked = true;
            }
            else
            {
                Close();
            }
        }

        private void Close(object sender, EventArgs e)
        // close form
        {
            this.Close();
        }

        #endregion

        #region Patient

        private void LoadPatientList(object sender, EventArgs e)
        {
            if      (MyPatientButton.Checked)  LoadMyPatientList();
            else if (AllPatientButton.Checked) LoadAllPatientList();
        }

        private void LoadMyPatientList()
        // load Patient List from server by doctor ID
        {
            // clear screen            
            PatientListPanel.Controls.Clear();

            // load new label
            Doctor.LoadPatient();
            if (Doctor.Patients != null)
            {
                int count = Doctor.Patients.Count();

                // show patients list
                for (int i = 0; i < count; i++)
                {
                    // set location for new Patient Label
                    // Patient size = (310 x 150)
                    // first column space = 120
                    // patient label / column
                    int col = (int)(i / ((Height - 200) / 160));
                    int row = (int)(i % ((Height - 200) / 160));

                    Point Point = new Point(col * 320 + 120 + (int)(col / 2) * 60, row * 160);
                    
                    // set size of Patient List Panel
                    // defaul with = 1366
                    if (Point.X + 430 > Width) PatientListPanel.Width = Point.X + 430;                    

                    // add new Patient Lable to Patients List Panel
                    PatientListPanel.Controls.Add(new PatientLabel(Doctor, Doctor.Patients[i], Point));                                       
                }
            }
        }

        private void LoadAllPatientList()
        // load all Patient List from server
        {
            // clear screen
            PatientListPanel.Controls.Clear();

            // load new label

            Patient[] AllPatients = Doctor.LoadAllPatient();

            if (AllPatients != null)
            {
                int count = AllPatients.Count();

                // show patients list
                for (int i = 0; i < count; i++)
                {                  
                    // set location for new Patient Label
                    // Patient size = (310 x 150)
                    // first column space = 120
                    // 4 patient label / column
                    int col = (int)(i / ((Height - 200) / 160));
                    int row = (int)(i % ((Height - 200) / 160));

                    Point Point = new Point(col * 320 + 120 + (int)(col / 2) * 60, row * 160);


                    // set size of Patient List Panel
                    // defaul with = 1366
                    if (Point.X + 430 > Width) PatientListPanel.Width = Point.X + 430;   

                    // add new Patient Lable to Patients List Panel
                    PatientListPanel.Controls.Add(new PatientLabel(Doctor, AllPatients[i], Point));
                }
            }
        }

        #endregion
    }
}
