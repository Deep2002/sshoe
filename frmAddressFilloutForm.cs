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
    public partial class frmAddressFilloutForm : Form
    {
        public frmAddressFilloutForm()
        {
            InitializeComponent();
        }

        private void btnContinueToCheckout_Click(object sender, EventArgs e)
        {
            #region check everything field correctly
            if (!clsValidation.ValidateAddress(tbxAddress.Text))
            {
                MessageBox.Show("Invalid Address, please type valid address.", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxAddress.Focus();
                return;
            }
            if (tbxAddress2.Text != "" && !clsValidation.ValidateAddress(tbxAddress2.Text))
            {
                MessageBox.Show("Invalid Address 2, please type valid address.", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxAddress2.Focus();
                return;
            }            
            if (tbxAddress3.Text != "" && !clsValidation.ValidateAddress(tbxAddress3.Text))
            {
                MessageBox.Show("Invalid Address 3, please type valid address.", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxAddress3.Focus();
                return;
            }
            if(tbxCity.Text.Length == 0)
            {
                MessageBox.Show("Invalid City, please type valid City.", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxCity.Focus();
                return;
            }
            if(!clsValidation.ValidateZipcode(tbxZIP.Text))
            {
                MessageBox.Show("Invalid ZIP code, please type valid ZIP code.", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxZIP.Focus();
                return;
            }
            if(!cbxState.Items.Contains(cbxState.Text))
            {
                MessageBox.Show("Invalid State, please type valid State.", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbxState.Focus();
                return;
            }
            #endregion

            // If everything is field properly
            // set this address
            clsPublicData.currentUser.strAddress1 = tbxAddress.Text;
            clsPublicData.currentUser.strAddress2 = tbxAddress2.Text;
            clsPublicData.currentUser.strAddress3 = tbxAddress3.Text;
            clsPublicData.currentUser.strCity = tbxCity.Text;
            clsPublicData.currentUser.strState = cbxState.Text;
            clsPublicData.currentUser.strZip = tbxZIP.Text;

            // Show payment information
            new frmPaymentInfo().Show();
            this.Close();
        }
    }
}
