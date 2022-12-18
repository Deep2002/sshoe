using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.ManagerViewForms
{
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            new frmSalesReportsDateSelector().ShowDialog();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            new frmInventoryReportsSelector().ShowDialog();
        }

        private void mnuMenuHelp_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\Resources\HelpFile\help_file.html");
            System.Diagnostics.Process.Start(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\Resources\HelpFile\managerHelpFiles\help_file.html");

        }
    }
}
