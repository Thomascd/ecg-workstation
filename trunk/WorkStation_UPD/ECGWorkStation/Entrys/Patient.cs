using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECGWorkStation
{
    enum Sex {Male, Female};

    class Patient
    {
        public string   ID;
        public string   Name;
        public DateTime Birthday;
        public Sex      Sex;
        public float    Weight;
        public string   Job;
        public string   Address;
        public Image    Avatar;
        public List<Record> Records;
        public string   DoctorName;
        public string   DoctorID;
        public string   Bed;
        public string   Room;

        private WebService.ECGServiceClient Service = new WebService.ECGServiceClient();

        public Patient()
        {
        }

        public Patient(WebService.Patient _patient)
        {
            this.Birthday = _patient.dateOfBirth;
            this.ID       = _patient.patientID;
            this.Name     = _patient.patientName;
            this.Sex      = _patient.sex ? Sex.Male : Sex.Female;
            this.Weight   = _patient.weight;
            this.Job      = "";
            this.Address  = "";
            this.Avatar   = global::ECGWorkStation.Properties.Resources._1346378772_People_MSN1;
            this.Records  = new List<Record>();
        }

        public void LoadRecord()
        {
            if (Records.Count == 0) reLoadRecord();
        }

        public void reLoadRecord()
        {            
            WebService.HistoryRecord[] _records = Service.getAllRecordByPID(this.ID);
            if (_records != null)
            {
                int count = _records.Count();
                for (int i = 0; i < count; i++) Records.Add(new Record(_records[i]));                
            }
        }

        public void AddRecord(Record newRecord)
        {
            this.Records.Add(newRecord);
        }

        public void Update(Image _image, string _name, DateTime _birthday, string _sex, int _weight, string _job, string _address)
        {
            this.Avatar     = _image;
            this.Name       = _name;
            this.Birthday   = _birthday;
            this.Sex        = _sex == "Male" ? Sex.Male : Sex.Female;
            this.Weight     = (float) _weight;
            this.Job        = _job;
            this.Address    = _address;

            Service.editPatient(
                this.ID,
                this.Name,
                this.Birthday,
                this.Sex == Sex.Male,
                this.Weight,
                this.Job,
                this.Address);
        }
    }
}
