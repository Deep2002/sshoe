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

    public partial class frmCreateNewPassword : Form
    {
        public frmCreateNewPassword()
        {
            InitializeComponent();
        }

        private void tbxNewPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keysNotAllowed = "\'\\+=-_{}[]/?,.<>~`||";
            if (char.IsDigit(e.KeyChar) && string.IsNullOrEmpty(tbxNewPassword.Text) || keysNotAllowed.Contains(e.KeyChar))
            {
                e.Handled = true;
                return;
            };

            if (!e.KeyChar.ToString().Equals(" ") || char.IsLetterOrDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }


        private void tbxConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (tbxNewPassword.Text == tbxConfirmPassword.Text && !String.IsNullOrEmpty(tbxConfirmPassword.Text) 
                && lblNewPasswordRightMark.Visible == true)
            {
                lblConfirmPasswordWrongMark.Visible = false;
                lblConfirmPasswordRightMark.Visible = true;

                // update status 
                clsUpdateControls.UpdateStatusBar(stsStatus, "✔️ Entered password is valid.", Color.Green);

            }
            else
            {
                lblConfirmPasswordWrongMark.Visible = true;
                lblConfirmPasswordRightMark.Visible = false;

                // update status bar
                clsUpdateControls.UpdateStatusBar(stsStatus, "Please re-enter your password in confirm password to continue.", Color.Red);
            }
        }

        private void cbxHidePassword_CheckedChanged(object sender, EventArgs e)
        {
            if(tbxNewPassword.PasswordChar == '●')
            {
                tbxNewPassword.PasswordChar = '\0';
                tbxConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                tbxNewPassword.PasswordChar = '●';
                tbxConfirmPassword.PasswordChar = '●';
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {

            if(string.IsNullOrEmpty(tbxNewPassword.Text) || string.IsNullOrEmpty(tbxConfirmPassword.Text))
            {
                clsUpdateControls.UpdateStatusBar(stsStatus, "Please confirm that you have entered both password.", Color.Red);
                return;
            }

            if (!tbxNewPassword.Text.Equals(tbxConfirmPassword.Text))
            {
                clsUpdateControls.UpdateStatusBar(stsStatus, "Password does not match", Color.Red);
                return;
            };

            if(!lblNewPasswordRightMark.Visible || !lblConfirmPasswordRightMark.Visible)
            {
                clsUpdateControls.UpdateStatusBar(stsStatus, "Password requirements does not match.", Color.Red);
                return;
            }

            if(clsSQL.UpdatePassword(tbxNewPassword.Text, frmLogon.strUserName))
            {
                MessageBox.Show("Password has been successfully reseted. Thank you!", "Reset password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void tbxNewPassword_TextChanged(object sender, EventArgs e)
        {

            if (!clsValidation.ValidatePassword(tbxNewPassword.Text))
            {
                lblNewPasswordWrongMark.Visible = true;
                lblNewPasswordRightMark.Visible = false;

                // show error
                clsUpdateControls.UpdateStatusBar(stsStatus, "Password must be 8 characters long and must contain: 1 Uppercase, 1 Lowercase, 1 Number, 1 Special characters ()!@#$%^&*.", Color.Red);

            }
            else
            {
                lblNewPasswordWrongMark.Visible = false;
                lblNewPasswordRightMark.Visible = true;
                lblConfirmPasswordWrongMark.Visible = true;
                lblConfirmPasswordRightMark.Visible = false;
                // update status bar

                clsUpdateControls.UpdateStatusBar(stsStatus, "Please re-enter your password in confirm password to continue.", Color.Red);

            }
        }
    }
}
