using FinalProject.Customer_View_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class frmSignupView : Form
    {
        public frmSignupView()
        {
            InitializeComponent();
            #region Set tool tips
            toolTip.SetToolTip(tbxPassword, "Please type your Password here.");
            toolTip.SetToolTip(tbxConfirmPassword, "Please type your same Password here to confirm.");
            toolTip.SetToolTip(tbxUsername, "Please type your User Name here.");
            toolTip.SetToolTip(tbxFirstName, "Please type your First Name here.");
            toolTip.SetToolTip(tbxLastName, "Please type your Last Name here.");
            toolTip.SetToolTip(tbxAddress, "Please type your Street Address here.");
            toolTip.SetToolTip(tbxCity, "Please type your City here.");
            toolTip.SetToolTip(cbxState, "Please type your State here. For e.g.(TX)");
            toolTip.SetToolTip(tbxZIP, "Please type your Zip Code here.");
            toolTip.SetToolTip(lblGoToLogin, "Click here to go back to login form.");
            toolTip.SetToolTip(btnNext, "Click here to go to the next step.");
            toolTip.SetToolTip(cbxHidePassword, "Select or Deselect this box to show or hide your password.");
            #endregion
        }

        /// <summary>
        /// This will ask user to close form then close it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblGoToLogin_Click(object sender, EventArgs e)
        {
            // Check if user want to go back.
            if (MessageBox.Show("Do you really want to go back?\nYou will lose your information!", "Going back..", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        /// <summary>
        /// Closes the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuMenuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IsTextBoxNull(TextBox tbxTextBox)
        {
            if (string.IsNullOrEmpty(tbxTextBox.Text))
            {
                tbxTextBox.BackColor = Color.Red;
                clsUpdateControls.UpdateStatusBar(stsStatus, "Make sure you fill out the required field.", Color.Red);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            #region Check if text boxes is are empty and setting its back color to red
            IsTextBoxNull(tbxFirstName);
            IsTextBoxNull(tbxLastName);
            IsTextBoxNull(tbxUsername);
            IsTextBoxNull(tbxEmail);
            IsTextBoxNull(tbxPrimaryPhone);
            IsTextBoxNull(tbxAddress);
            IsTextBoxNull(tbxCity);
            IsTextBoxNull(tbxZIP);
            IsTextBoxNull(tbxPassword);
            IsTextBoxNull(tbxConfirmPassword);
            #endregion

            // check if title and state empty
            if (!cbxTitle.Items.Contains(cbxTitle.Text))
            {
                cbxTitle.BackColor = Color.Red;
            }

            if (!cbxState.Items.Contains(cbxState.Text))
            {
                cbxState.BackColor = Color.Red;
            }

            // Check if user already exists
            if (clsSQL.SearchCurrentUser(tbxUsername.Text))
            {
                clsPublicData.currentUser = null;

                // if already exists
                tbxUsername.BackColor = Color.Red;
                tbxUsername.Focus();
                clsUpdateControls.UpdateStatusBar(stsStatus, "Unfortunately this username is already taken, please try something different.", Color.Red);
                return;
            }

            //// check if everything is valid
            // Check All textboxes color
            Color redColor = Color.Red;
            if( tbxFirstName.BackColor != redColor && 
                tbxLastName.BackColor != redColor &&
                tbxMiddleName.BackColor != redColor &&
                cbxTitle.BackColor != redColor &&
                tbxSuffix.BackColor != redColor &&
                tbxUsername.BackColor != redColor &&
                tbxEmail.BackColor != redColor &&
                tbxPrimaryPhone.BackColor != redColor &&
                tbxSecondaryPhone.BackColor != redColor &&
                tbxAddress.BackColor != redColor &&
                tbxAddress2.BackColor != redColor &&
                tbxAddress3.BackColor != redColor &&
                tbxCity.BackColor != redColor &&
                tbxZIP.BackColor != redColor &&
                cbxState.BackColor != redColor &&
                tbxPassword.BackColor != redColor &&
                tbxConfirmPassword.BackColor != redColor)
            {
                // set current user as this (Who is signing-up)
                clsPublicData.currentUser = new Person();
                // set information
                // user info
                clsPublicData.currentUser.strFirstName = tbxFirstName.Text;
                clsPublicData.currentUser.strLastName = tbxLastName.Text;
                clsPublicData.currentUser.strMiddleName = tbxMiddleName.Text;
                clsPublicData.currentUser.strTitle = cbxTitle.Text;
                clsPublicData.currentUser.strSuffix = tbxSuffix.Text;
                // logon info
                clsPublicData.currentUser.strUsername = tbxUsername.Text;
                clsPublicData.currentUser.strPrimaryPhone = tbxPrimaryPhone.Text;
                clsPublicData.currentUser.strSecondaryPhone = tbxSecondaryPhone.Text;
                clsPublicData.currentUser.strEmail = tbxEmail.Text;
                clsPublicData.currentUser.strPassword = tbxPassword.Text;
                // Address info
                clsPublicData.currentUser.strAddress1 = tbxAddress.Text;
                clsPublicData.currentUser.strAddress2 = tbxAddress2.Text;
                clsPublicData.currentUser.strAddress3 = tbxAddress3.Text;
                clsPublicData.currentUser.strCity = tbxCity.Text;
                clsPublicData.currentUser.strState = cbxState.Text;
                clsPublicData.currentUser.strZip = tbxZIP.Text;

                // show questions form
                this.Hide();
                new frmQuestionsWindow(FORM_TYPE.CREATE_NEW_USER).ShowDialog();
                this.Close();
            }

        }

        #region Text Change Methods

        private void tbxFirstName_TextChanged(object sender, EventArgs e)
        {
            if (!clsValidation.ValidateName(tbxFirstName.Text))
            {
                tbxFirstName.BackColor = Color.Red;
                clsUpdateControls.UpdateStatusBar(stsStatus, "Invalid First Name", Color.Red);
            }
            else
            {
                tbxFirstName.BackColor = Color.White;
                clsUpdateControls.UpdateStatusBar(stsStatus, "", Color.Red);
            }
        }

        private void tbxLastName_TextChanged(object sender, EventArgs e)
        {
            if (!clsValidation.ValidateName(tbxLastName.Text))
            {
                tbxLastName.BackColor = Color.Red;
                clsUpdateControls.UpdateStatusBar(stsStatus, "Invalid Last Name", Color.Red);
            }
            else
            {
                tbxLastName.BackColor = Color.White;
                clsUpdateControls.UpdateStatusBar(stsStatus, "", Color.Red);
            }
        }

        private void tbxUsername_TextChanged(object sender, EventArgs e)
        {
            if (clsValidation.ValidateUsername(tbxUsername.Text))
            {
                tbxUsername.BackColor = Color.Green;
                stsStatus.Items.Clear();
            }
            else
            {
                tbxUsername.BackColor = Color.Red;
                clsUpdateControls.UpdateStatusBar(stsStatus, "Invalid Username", Color.Red);
            }
        }

        private void tbxConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (tbxPassword.Text == tbxConfirmPassword.Text && !String.IsNullOrEmpty(tbxConfirmPassword.Text)
                && tbxPassword.BackColor == Color.Green)
            {
                tbxConfirmPassword.BackColor = Color.Green;

                // update status 
                clsUpdateControls.UpdateStatusBar(stsStatus, "✔️ Entered password is valid.", Color.Green);
            }
            else
            {
                tbxConfirmPassword.BackColor = Color.Red;

                // update status bar
                clsUpdateControls.UpdateStatusBar(stsStatus, "Please re-enter your password in confirm password to continue.", Color.Red);
            }
        }

        private void tbxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keysNotAllowed = "\'\\+=-_{}[]/?,.<>~`||";
            if (char.IsDigit(e.KeyChar) && string.IsNullOrEmpty(tbxPassword.Text) || keysNotAllowed.Contains(e.KeyChar))
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

        private void cbxHidePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (tbxPassword.PasswordChar == '●')
            {
                tbxPassword.PasswordChar = '\0';
                tbxConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                tbxPassword.PasswordChar = '●';
                tbxConfirmPassword.PasswordChar = '●';
            }
        }

        private void tbxZIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbxMiddleName_TextChanged(object sender, EventArgs e)
        {
            if (!clsValidation.ValidateName(tbxMiddleName.Text) && tbxMiddleName.Text != "")
            {
                tbxMiddleName.BackColor = Color.Red;
                clsUpdateControls.UpdateStatusBar(stsStatus, "Invalid Middle Name", Color.Red);
            }
            else
            {
                tbxMiddleName.BackColor = Color.White;
                clsUpdateControls.UpdateStatusBar(stsStatus, "", Color.Red);
            }
        }

        private void HandleFirstSpaceKey(KeyPressEventArgs e, TextBox tbxToBeHandle)
        {
            if (e.KeyChar.ToString() == " " && tbxToBeHandle.Text == "")
            {
                e.Handled = true;
            }
        }

        private void tbxFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleFirstSpaceKey(e, tbxFirstName);
        }

        private void tbxLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleFirstSpaceKey(e, tbxLastName);
        }

        private void tbxMiddleName_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleFirstSpaceKey(e, tbxMiddleName);
        }

        private void tbxSuffix_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleFirstSpaceKey(e, tbxSuffix);
        }

        private void cbxTitle_TextChanged(object sender, EventArgs e)
        {
            // check if title is correctly entered
            if (!cbxTitle.Items.Contains(cbxTitle.Text))
            {
                cbxTitle.BackColor = Color.Red;
                clsUpdateControls.UpdateStatusBar(stsStatus, "Title is invalid", Color.Red);
            }
            else
            {
                cbxTitle.BackColor = Color.White;
                clsUpdateControls.UpdateStatusBar(stsStatus, "", Color.Red);
            }
        }

        private void tbxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && tbxUsername.Text == "")
            {
                e.Handled = true;
            }
        }

        private void tbxEmail_TextChanged(object sender, EventArgs e)
        {
            if (!clsValidation.ValidateEmail(tbxEmail.Text))
            {
                clsUpdateControls.UpdateStatusBar(stsStatus, "Invalid Email", Color.Red);
                tbxEmail.BackColor = Color.Red;
            }
            else
            {
                stsStatus.Items.Clear();
                tbxEmail.BackColor = Color.White;
            }
        }

        private void tbxPrimaryPhone_TextChanged(object sender, EventArgs e)
        {
            if (clsValidation.ValidatePhone(tbxPrimaryPhone.Text))
            {
                tbxPrimaryPhone.BackColor = Color.White;
            }
            else
            {
                tbxPrimaryPhone.BackColor = Color.Red;
                clsUpdateControls.UpdateStatusBar(stsStatus, "Phone number is Invalid, try Entering 555-555-5555", Color.Red);
            }
        }

        private void tbxSecondaryPhone_TextChanged(object sender, EventArgs e)
        {
            if (clsValidation.ValidatePhone(tbxSecondaryPhone.Text) || tbxSecondaryPhone.Text == "")
            {
                tbxSecondaryPhone.BackColor = Color.White;
                stsStatus.Items.Clear();
            }
            else
            {
                tbxSecondaryPhone.BackColor = Color.Red;
                clsUpdateControls.UpdateStatusBar(stsStatus, "Phone number is Invalid, try Entering 555-555-5555", Color.Red);
            }
        }

        private void tbxAddress_TextChanged_1(object sender, EventArgs e)
        {
            if (clsValidation.ValidateAddress(tbxAddress.Text))
            {
                tbxAddress.BackColor = Color.White;
                stsStatus.Items.Clear();
            }
            else
            {
                tbxAddress.BackColor = Color.Red;
                clsUpdateControls.UpdateStatusBar(stsStatus, "Address is Invalid", Color.Red);
            }
        }

        private void tbxAddress2_TextChanged(object sender, EventArgs e)
        {
            if (clsValidation.ValidateAddress(tbxAddress2.Text) || tbxAddress2.Text == "")
            {
                tbxAddress2.BackColor = Color.White;
                stsStatus.Items.Clear();
            }
            else
            {
                tbxAddress2.BackColor = Color.Red;
                clsUpdateControls.UpdateStatusBar(stsStatus, "Address 2 is Invalid, for Apartments enter e.g. (APT#1)", Color.Red);
            }
        }

        private void tbxAddress3_TextChanged(object sender, EventArgs e)
        {
            if (clsValidation.ValidateAddress(tbxAddress3.Text) || tbxAddress3.Text == "")
            {
                tbxAddress3.BackColor = Color.White;
                stsStatus.Items.Clear();
            }
            else
            {
                tbxAddress3.BackColor = Color.Red;
                clsUpdateControls.UpdateStatusBar(stsStatus, "Address 3 is Invalid, for Apartments enter e.g. (APT#1)", Color.Red);
            }

        }

        private void tbxPassword_TextChanged(object sender, EventArgs e)
        {
            if (!clsValidation.ValidatePassword(tbxPassword.Text))
            {
                tbxPassword.BackColor = Color.Red;

                // show error
                clsUpdateControls.UpdateStatusBar(stsStatus, "Passwords must be between 8 and 20 characters in length. Should Contain uppercase, lowercase, number, and special character.", Color.Red);
            }
            else
            {
                tbxPassword.BackColor = Color.Green;
                tbxConfirmPassword.BackColor = Color.Red;
                // update status bar
                clsUpdateControls.UpdateStatusBar(stsStatus, "Please re-enter your password in confirm password to continue.", Color.Red);
            }
        }

        private void tbxZIP_TextChanged_1(object sender, EventArgs e)
        {
            if (clsValidation.ValidateZipcode(tbxZIP.Text))
            {
                tbxZIP.BackColor = Color.White;
                stsStatus.Items.Clear();
            } else
            {
                tbxZIP.BackColor = Color.Red;
                clsUpdateControls.UpdateStatusBar(stsStatus, "Invalid Zip code", Color.Red);
            }
        }

        private void tbxZIP_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != '-' && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        #endregion

        private void tbxCity_TextChanged(object sender, EventArgs e)
        {
            if (tbxCity.Text.Length < 2)
            {
                tbxCity.BackColor = Color.Red;
            }
            else
            {
                tbxCity.BackColor = Color.White;
            }
        }

        private void cbxState_TextChanged(object sender, EventArgs e)
        {
            if (!cbxState.Items.Contains(cbxState.Text))
            {
                cbxState.BackColor = Color.Red;
            }
            else { 
                cbxState.BackColor = Color.White;
            }
        }

        private void mnuMenuGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuMenuViewHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\Resources\HelpFile\help_file.html");

        }
    }
}
