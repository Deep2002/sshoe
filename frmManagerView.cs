using FinalProject.ManagerViewForms;
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
    public partial class frmManagerView : Form
    {
        public static Button currentActiveButton = null;

        public frmManagerView()
        {
            InitializeComponent();
        }

        #region Button Hover animations
        public void OnHowerButtonAnimate(Button btn)
        {
            if (btn.BackColor == Color.DodgerBlue)
                btn.BackColor = Color.Blue;
            else
                btn.BackColor = Color.DodgerBlue;
        }

        private void btnInventory_MouseEnter(object sender, EventArgs e)
        {
            OnHowerButtonAnimate(btnInventory);
        }

        private void btnInventory_MouseLeave(object sender, EventArgs e)
        {
            OnHowerButtonAnimate(btnInventory);
        }

        private void btnReports_MouseEnter(object sender, EventArgs e)
        {
            OnHowerButtonAnimate(btnReports);
        }

        private void btnReports_MouseLeave(object sender, EventArgs e)
        {
            OnHowerButtonAnimate(btnReports);
        }

        private void btnDiscounts_MouseEnter(object sender, EventArgs e)
        {
            OnHowerButtonAnimate(btnDiscounts);
        }

        private void btnDiscounts_MouseLeave(object sender, EventArgs e)
        {
            OnHowerButtonAnimate(btnDiscounts);
        }

        private void btnUsers_MouseEnter(object sender, EventArgs e)
        {
            OnHowerButtonAnimate(btnUsers);
        }

        private void btnUsers_MouseLeave(object sender, EventArgs e)
        {
            OnHowerButtonAnimate(btnUsers);
        }

        private void btnPos_MouseEnter(object sender, EventArgs e)
        {
            OnHowerButtonAnimate(btnPos);
        }

        private void btnPos_MouseLeave(object sender, EventArgs e)
        {
            OnHowerButtonAnimate(btnPos);
        }

        private void btnNotifications_MouseEnter(object sender, EventArgs e)
        {
            OnHowerButtonAnimate(btnNotifications);
        }

        private void btnNotifications_MouseLeave(object sender, EventArgs e)
        {
            OnHowerButtonAnimate(btnNotifications);
        }
        #endregion

        private void frmManagerView_Load(object sender, EventArgs e)
        {
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmInvetoryManager().ShowDialog();
            this.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {

        }
    }

}
