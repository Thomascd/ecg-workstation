using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECGWorkStation
{
    class Doctor : WebService.User
    {
        public Image     Avatar;
        public string    ID;
        public string    Name;
        public Patient[] Patients;

        WebService.ECGServiceClient Service = new WebService.ECGServiceClient();

        public Doctor(WebService.User LoginUser)
        {
            this.ID       = LoginUser.realID;
            this.Name     = LoginUser.username;
            this.Patients = null;
        }

        public void LoadPatient()
        {
            if (Patients == null) reLoadPatient();
        }

        public void reLoadPatient()
        {
            WebService.Patient[] _patients = Service.getPatientByResDoctor(this.ID);
            if (_patients != null)
            {
                int count = _patients.Count();

                this.Patients = new Patient[count];
                for (int i = 0; i < count; i++)
                {
                    Patients[i] = new Patient(_patients[i]);
                    Patients[i].DoctorID   = this.ID;
                    Patients[i].DoctorName = this.Name;
                }
            }
        }

        public Patient[] LoadAllPatient()
        {
            Patient[] AllPatient = null;
            WebService.Patient[] _allPatient = Service.getAllPatient();
            if (_allPatient != null)
            {
                int count = _allPatient.Count();
                
                AllPatient = new Patient[count];
                for (int i = 0; i < count; i++) AllPatient[i] = new Patient(_allPatient[i]);
            }

            return AllPatient;
        }
    }
}
