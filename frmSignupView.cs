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
    public partial class frmSignupView : Form
    {
        public List<string> listOfState = new List<string> {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"
        };

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
            if (MessageBox.Show("Do you really want to go back?\nYour account will only created when all steps are followed. Click next to complete necessary steps.", "Going back..", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        /// <summary>
        /// Closes the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuMenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IsTextBoxNull(TextBox tbxTextBox)
        {
            if (string.IsNullOrEmpty(tbxTextBox.Text))
            {
                tbxTextBox.BackColor = Color.Red;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            #region Check what is empty and setting its back color to red
            IsTextBoxNull(tbxFirstName);
            IsTextBoxNull(tbxLastName);
            IsTextBoxNull(tbxUsername);
            IsTextBoxNull(tbxAddress);
            IsTextBoxNull(tbxCity);
            IsTextBoxNull(tbxZIP);
            IsTextBoxNull(tbxPassword);
            IsTextBoxNull(tbxConfirmPassword);
            #endregion

            // check if ZIP is valid
            if (!listOfState.Contains(cbxState.Text))
            {
                cbxState.BackColor = Color.Red;
            }
            // Validate if already exists
            if (clsSQL.SearchCurrentUser(tbxUsername.Text))
            {
                // clear that user information
                frmLogon.currentUser = null;

                // if already exists
                tbxUsername.BackColor = Color.Red;
                tbxUsername.Focus();
                clsUpdateControls.UpdateStatusBar(stsStatus, "Unfortunatly this username already exists please try something diffrent.", Color.Red);
                return;
            }
            // check if everything is valid
            Color greenColor = Color.Green;
            if(tbxPassword.BackColor == greenColor && 
                tbxConfirmPassword.BackColor == greenColor &&
                tbxLastName.BackColor == Color.White &&
                tbxFirstName.BackColor == Color.White &&
                tbxUsername.BackColor == greenColor &&
                tbxZIP.BackColor == Color.White &&
                tbxCity.BackColor == Color.White &&
                cbxState.BackColor == Color.White)
            {
                // set current user as this
                frmLogon.currentUser = new Person();
                // set information
                frmLogon.currentUser.FirstName = tbxFirstName.Text;
                frmLogon.currentUser.LastName = tbxLastName.Text;
                frmLogon.currentUser.Username = tbxUsername.Text;
                frmLogon.currentUser.Address1 = tbxAddress.Text;
                frmLogon.currentUser.City = tbxCity.Text;
                frmLogon.currentUser.State = cbxState.Text;
                frmLogon.currentUser.Zip = tbxZIP.Text;
                frmLogon.currentUser.Password = tbxPassword.Text;

                // show questions form
                this.Hide();
                new frmQuestionsWindow(FORM_TYPE.CREATE_NEW_USER).ShowDialog();
                this.Close();
            }


        }

        private void TbxValidation(TextBox tbxTextBox, int intLen = 2)
        {
            if (tbxTextBox.Text.Length < intLen)
            {
                tbxTextBox.BackColor = Color.Red;
            }
            else
            {
                tbxTextBox.BackColor = Color.White;
            }
        }

        private void tbxFirstName_TextChanged(object sender, EventArgs e)
        {
            TbxValidation(tbxFirstName);
        }

        private void tbxLastName_TextChanged(object sender, EventArgs e)
        {
            TbxValidation(tbxLastName);
        }

        private void tbxUsername_TextChanged(object sender, EventArgs e)
        {
            if(clsValidation.ValidateUsername(tbxUsername.Text))
            {
                tbxUsername.BackColor = Color.Green;

            } else
            {
                tbxUsername.BackColor = Color.Red;

            }
        }

        private void tbxAddress_TextChanged(object sender, EventArgs e)
        {
            TbxValidation(tbxAddress, 6);
        }

        private void tbxZIP_TextChanged(object sender, EventArgs e)
        {
            TbxValidation(tbxZIP, 5);
        }

        private void tbxConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (tbxPassword.Text == tbxConfirmPassword.Text && !String.IsNullOrEmpty(tbxConfirmPassword.Text)
                && tbxPassword.BackColor == Color.Green)
            {
                tbxConfirmPassword.BackColor = Color.Green;

                // update status 
                clsUpdateControls.UpdateStatusBar(stsStatus, "✔️ Enterd password is valid.", Color.Green);

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

            if (!clsValidation.ValidatePassword(tbxPassword.Text))
            {
                tbxPassword.BackColor = Color.Red;

                // show error
                clsUpdateControls.UpdateStatusBar(stsStatus, "Password must be 8 characters long and must contain: 1 Uppercase, 1 Lowercase, 1 Number, 1 Special characters ()!@#$%^&*.", Color.Red);

            }
            else
            {
                tbxPassword.BackColor = Color.Green;
                tbxConfirmPassword.BackColor = Color.Red;
                // update status bar
                clsUpdateControls.UpdateStatusBar(stsStatus, "Please re-enter your password in confirm password to continue.", Color.Red);

            }
        }

        private void tbxCity_TextChanged(object sender, EventArgs e)
        {
            TbxValidation(tbxCity, 2);
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

        private void cbxState_TextChanged(object sender, EventArgs e)
        {
            if (!listOfState.Contains(cbxState.Text))
            {
                cbxState.BackColor = Color.Red;
                clsUpdateControls.UpdateStatusBar(stsStatus, "Please enter valid state, then try again.", Color.Red);
            }
            else
            {
                cbxState.BackColor = Color.White;
                clsUpdateControls.UpdateStatusBar(stsStatus, "", Color.Red);
            }

        }

        private void tbxZIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
