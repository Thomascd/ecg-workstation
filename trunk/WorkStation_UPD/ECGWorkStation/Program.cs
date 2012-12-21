using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Security.Permissions;
using System.Threading;


namespace ECGWorkStation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[assembly: SecurityPermission(SecurityAction.RequestMinimum, ControlThread = true)]
        [STAThread]
        static void Main()
        {
            //Thread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ".";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PatientListForm());
    //        Application.Run(new MonitorForm());

            //Application.Run(new GetAllUserForm());
        }
    }
}
