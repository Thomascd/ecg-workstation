using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECGWorkStation
{
    class Record 
    {
        public string     DoctorName = null;
        public string     DoctorID   = null;
        public DateTime   Date;
        public string     ID        = null;        // record ID
        public bool[]     Flag      = new bool[12];
        public DateTime   Leght;

        private string _data = null;
        public List<Comment> Comment = new List<Comment>(); 

        private WebService.ECGServiceClient Service = new WebService.ECGServiceClient();

        public Record(WebService.HistoryRecord _record)
        {
            this.Date = _record.dateTimeOfRecord;
            this.ID   = _record.recordID;
            this._data = null;
        }

        public Record(string DoctorName, string DoctorID, DateTime Date, string ID, bool[] Flag, string _data)
        {
            this.DoctorID = DoctorID;
            this.DoctorName = DoctorName;
            this.ID = ID;
            this.Date = Date;
            this.Flag = Flag;
            this._data = _data;
        }

        #region Comment

        public void LoadComment()
        {
            if (Comment.Count() == 0) reLoadComment();
        }

        public void reLoadComment()
        {
            WebService.Comment[] _comment = Service.getCommentByRID(this.ID);

            this.Comment.Clear();

            if (_comment != null)
            {
                foreach (WebService.Comment c in _comment)
                    this.Comment.Add(new Comment(c));
            }
            
        }

        public int AddComment(Doctor _doctor, string _data)
        {
            return AddComment(_doctor, DateTime.Now, _data);
        }

        public int AddComment(Doctor _doctor, DateTime _date, string _data)
        {
            Service.addNewComment(this.ID, _doctor.ID, _date, _data);
            this.Comment.Add(new Comment(this.ID, _doctor.ID, _doctor.Name, _date, _data));
            
            return this.Comment.Count() - 1;
        }

        public void EditComment(Doctor _doctor, string _data)
        {
            EditComment(_doctor, DateTime.Now, _data);            
        }

        public void EditComment(Doctor _doctor, DateTime _date, string _data)
        {
            Service.editComment(this.ID, _doctor.ID, _date, _data);
            foreach (Comment c in Comment)
                if (c.DoctorID == _doctor.ID)
                {
                    c.DateTime = _date;
                    c.Data = _data;
                }
        }

        #endregion

        #region Data

        public string Data
        {
            get
            {
                try
                {
                    if (_data == null) _data = Service.loadECGRecord12(this.ID);
                }
                catch
                {
                    MessageBox.Show("Can not Load Data from server");
                    _data = null;
                }
                return _data;
            }
        }

        #endregion
    }
}
