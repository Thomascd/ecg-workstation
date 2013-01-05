using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ECGWorkStation
{
    partial class ViewNoticeForm : Form
    {
        public ViewNoticeForm()
        {
            InitializeComponent();
        }

        public ViewNoticeForm(NoticeLabel Notice)
        {
            InitializeComponent();
        }
    }
}
