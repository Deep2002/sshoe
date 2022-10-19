using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class frmPaymentInfo : Form
    {
        public frmPaymentInfo()
        {
            InitializeComponent();
        }

        private void btnContinueToCheckout_Click(object sender, EventArgs e)
        {
            #region Check if card information is field properly

            Regex regexCard = new Regex("^(?:4[0-9]{12}(?:[0-9]{3})?|[25][1-7][0-9]{14}|6(?:011|5[0-9][0-9])[0-9]{12}|3[47][0-9]{13}|3(?:0[0-5]|[68][0-9])[0-9]{11}|(?:2131|1800|35\\d{3})\\d{11})$");
            Regex regexExpirationDate = new Regex("/^(0[1-9]|1[0-2])\\/?([0-9]{4}|[0-9]{2})$/;");

            if (!regexCard.IsMatch(tbxCardNumber.Text))
            {
                MessageBox.Show("Invalid Card Number, please type valid Card Number.", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxCardNumber.Focus();
                return;
            }
            if (dtpExpirationDate.Value < DateTime.Now)
            {
                MessageBox.Show("Invalid Expiration Date, please type valid Card Number.", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpExpirationDate.Focus();
                return;
            }
            if (tbxCVV.Text.Length < 3)
            {
                MessageBox.Show("Invalid CVV, please type valid CVV.", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxCVV.Focus();
                return;
            }
            foreach (char c in tbxCVV.Text)
            {
                if (char.IsLetter(c))
                {
                    MessageBox.Show("Invalid CVV, please type valid CVV.", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbxCVV.Focus();
                    return;
                }
            }
            #endregion

            // If everything went right show receipt and add order to the database
            if (clsSQL.PlaceOrder(tbxCardNumber.Text, dtpExpirationDate.Text, tbxCVV.Text))
            {
                MessageBox.Show("Order has been placed.");
            }
        }

        private void tbxCVV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
