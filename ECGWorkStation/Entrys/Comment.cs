using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECGWorkStation
{
    class Comment
    {
        public DateTime DateTime;
        public string   DoctorID;
        public string   DoctorName;
        public string   RecordID;
        public string   Data;

        private WebService.ECGServiceClient Service = new WebService.ECGServiceClient();

        public Comment(WebService.Comment Comment)
        {
            this.DateTime   = Comment.changedDateTime;
            this.DoctorID   = Comment.docID;
            this.DoctorName = Comment.docName;
            this.RecordID   = Comment.recordID;
            this.Data       = Service.getCommentContent(RecordID, DoctorID);
        }

        public Comment(string RecordID, string DoctorID, string DoctorName, DateTime Date, string Data)
        {
            this.RecordID   = RecordID;
            this.DoctorID   = DoctorID;
            this.DoctorName = DoctorName;
            this.DateTime   = Date;
            this.Data       = Data;
        }
    }
}
