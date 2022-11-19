using FinalProject.ManagerViewForms;
using System;
using System.Windows.Forms;

namespace FinalProject
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            clsSQL.OpenDbConnection(); // open sql connection
            Application.Run(new frmLogon(LOGON_FORM_STATE.NORMAL));
            Application.Run(new frmManagerView());
            clsSQL.CloseDbConnection(); // close sql connection
        }
    }
}