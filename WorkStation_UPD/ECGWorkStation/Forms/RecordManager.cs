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
    partial class RecordManager : Form
    {
        Doctor  Doctor;
        Patient Patient;
        Record  Record;

        private int MyCommentIndex = -1;

        #region Initialize Form

        public RecordManager(Doctor Doctor, Patient Patient, Record Record)
        {
            InitializeComponent();
            this.Bounds = Screen.PrimaryScreen.Bounds;

            this.Doctor  = Doctor;
            this.Patient = Patient;
            this.Record  = Record;

            LoadComment();

            DateTimeLabel.Text          = Record.Date.ToString("d/M/yyyy - h:m");
            AvatarBox.Image             = Patient.Avatar;
            PatientNameLabel.Text       = Patient.Name;
            TreatDoctorNameLabel.Text   = "Doctor: " + Record.DoctorName;
            CommentsNumerLabel.Text     = Record.Comment == null ? "No Comment" : Record.Comment.Count().ToString() + " Comments";
            RecordLeghtLabel.Text       = "Record Time: " + Record.Leght.Hour + " : " + Record.Leght.Minute + " : " + Record.Leght.Second;
        }

        #endregion

        #region Load Comment

        private void LoadComment()
        {
            Record.LoadComment();

            if (Record.Comment.Count > 0)
            {
                int count = Record.Comment.Count();
                for (int i = 0; i < count; i++)
                {
                    Point Point = new Point(10, i * 110);
                    if (Point.Y > CommentListBox.Height) CommentListBox.Height = Point.Y + 100;

                    CommentLabel newCommentLabel = new CommentLabel(Doctor, Record.Comment[i], i, Point);
                    //newCommentLabel.Select += new System.EventHandler(this.Select);
                    newCommentLabel.Select += this.Select;

                    this.CommentListBox.Controls.Add( newCommentLabel);

                    // default select first comment
                    if (i == 0) newCommentLabel.MouseClick(null, null);
                }


                // find My comment
                for (int i = 0; i < count && MyCommentIndex == -1; i++)
                    if (Record.Comment[i].DoctorID == Doctor.ID) MyCommentIndex = i;

                AddButton.Enabled = MyCommentIndex == -1;
            }
        }

        private void Select(object sender, CommentEventArgs e)
        {
            CommentDoctorNameLabel.Text = Record.Comment[e.Index].DoctorName;
            CommentDateLabel.Text = 
                Record.Comment[e.Index].DateTime.ToShortDateString() + " " + 
                Record.Comment[e.Index].DateTime.ToShortTimeString();                 
            CommentBox.Text = Record.Comment[e.Index].Data;

            EditButton.Enabled = Record.Comment[e.Index].DoctorID == Doctor.ID;

            if (LastSelectLabel != null) LastSelectLabel.Selected = false;
            LastSelectLabel = (CommentLabel) sender;
        }

        #endregion

        #region Edit

        private CommentLabel LastSelectLabel;

        private void AddComment(object sender, EventArgs e)
        {
            // init new comment
            CommentDoctorNameLabel.Text = Doctor.Name;
            CommentDateLabel.Text = "New Comment";

            CommentBox.Text = "";

            // edit new comment
            Edit(null, null);
        }

        private void Edit(object sender, EventArgs e)
        {
            AddButton.Enabled = false;
            EditButton.Enabled = false;
            AcceptButton.Enabled = true;
            CancelButton.Enabled = true;

            CommentBox.ReadOnly = false;
            CommentBox.Cursor = Cursors.IBeam;
            CommentBox.Select();
        }

        private void Accept(object sender, EventArgs e)
        {            
            EditButton.Enabled = true;
            AcceptButton.Enabled = false;
            CancelButton.Enabled = false;
            CommentBox.ReadOnly = true;
            CommentBox.Cursor = Cursors.Default;

            if (MyCommentIndex == -1)
            // add new comment
            {
                // add comment to record
                MyCommentIndex = Record.AddComment(Doctor, CommentBox.Text);

                // add comment label to CommentLabelList
                Point Point = new Point(10, MyCommentIndex * 110);
                if (Point.Y > CommentListBox.Height) CommentListBox.Height = Point.Y + 100;

                CommentLabel newCommentLabel = new CommentLabel(Doctor, Record.Comment[MyCommentIndex], MyCommentIndex, Point);                
                newCommentLabel.Select += this.Select;

                this.CommentListBox.Controls.Add(newCommentLabel);

                // select new comment label
                newCommentLabel.MouseClick(null, null);
            }
            else
            // edit comment
            {
                Record.EditComment(Doctor, CommentBox.Text);
            }
        }

        private void Cancel(object sender, EventArgs e)
        {
            EditButton.Enabled = true;
            AcceptButton.Enabled = false;
            CancelButton.Enabled = false;
            CommentBox.ReadOnly = true;
            CommentBox.Cursor = Cursors.Default;

            // reselect last label selected
            LastSelectLabel.MouseClick(null, null);
                      
        }

        #endregion

        private void ViewRecord(object sender, EventArgs e)
        // view Record in monitor form
        {
            MonitorForm ViewRecordForm = new MonitorForm(Patient, Record);
            ViewRecordForm.Show();
        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class CommentEventArgs : EventArgs
    {
        public int Index { get; set; }
    }
}
