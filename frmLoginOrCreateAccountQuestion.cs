using FinalProject.Customer_View_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class frmLoginOrCreateAccountQuestion : Form
    {
        public frmLoginOrCreateAccountQuestion()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            new frmLogon(LOGON_FORM_STATE.POP_UP).ShowDialog();
            if (clsPublicData.currentUser != null)
                this.Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            new frmSignupView().ShowDialog();
        }
    }
}
