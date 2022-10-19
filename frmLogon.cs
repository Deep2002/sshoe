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
    public partial class frmLogon : Form
    {

        // this is current customer who logged in
        // this will be useful when updating password
        public static string strUserName;

        public frmLogon()
        {
            InitializeComponent();
            #region Setting up toolTips
            toolTip.SetToolTip(tbxUsername, "Please type your User Name here.");
            toolTip.SetToolTip(tbxPassword, "Please type your Password here.");
            toolTip.SetToolTip(lblForgotPassword, "If you forgot your password and want to reset it, click on forgot password.");
            toolTip.SetToolTip(lblSignup, "If you do not have an account with us, click here to sign up.");
            toolTip.SetToolTip(btnLogin, "Click this button to login to the store.");
            toolTip.SetToolTip(cbxHidePassword, "Select or Deselect this box to show or hide your password.");
            #endregion

            // open database connection
            clsSQL.OpenDbConnection();
        }

        /// <summary>
        /// This will display Sign-up form and hide this.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblSignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmSignupView().ShowDialog();
            this.Show();
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


        /// <summary>
        /// This function will validate and let current user log in.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Flag to check if something went wrong &
            // Message to display it
            //
            bool isValid = true;
            string strErrorMessage = "";
            //
            // If user-name is invalid
            //
            if (!clsValidation.ValidateUsername(tbxUsername.Text))
            {
                strErrorMessage = "Your username must be 8 char long and should not contain any of the followings: !#$%^&*_-+/():;,<>{}|\\~`=\'  1-9";
                // set focus on user-name text box and change background color
                tbxUsername.Focus();
                tbxUsername.SelectAll();
                tbxUsername.BackColor = Color.Red;
                isValid = false;
            }
            //
            // if password is invalid
            //
            else if (!clsValidation.ValidatePassword(tbxPassword.Text))
            {
                strErrorMessage = "Your password cannot be empty and should not contain any of the followings: +=-~`\'/<>{}[]|.,";
                // set focus on user-name text box and change background color
                tbxPassword.Focus();
                tbxPassword.SelectAll();
                tbxPassword.BackColor = Color.Red;
                isValid = false;
            }
            //
            // if somethings not right
            //
            if (!isValid)
            {
                // update status bar
                stsStatus.Items.Clear();
                ToolStripStatusLabel lblStatusLabel = new ToolStripStatusLabel();
                lblStatusLabel.Text = strErrorMessage;
                lblStatusLabel.ForeColor = Color.Red;
                lblStatusLabel.Font = new System.Drawing.Font("Verdana", 10F);
                // add label to status bar
                stsStatus.Items.Add(lblStatusLabel);
                stsStatus.Update();
            }
            else
            {
                // if username and password is valid
                // pass it to the query
                if (clsSQL.SearchCurrentUser(tbxUsername.Text, tbxPassword.Text))
                {
                    stsStatus.Items.Clear();
                    this.Hide();
                    new frmCustomerView().ShowDialog();
                    this.Show();
                }
                else
                {
                    // if user not found in search
                    MessageBox.Show("Provided UserName or Password is invalid, Please Try again.", "Validation Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tbxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            tbxUsername.BackColor = Color.White;
        }

        private void tbxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            tbxPassword.BackColor = Color.White;
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            // check if user has entered username
            if (tbxUsername.Text.Equals(""))
            {
                tbxUsername.BackColor = Color.Red;
                clsUpdateControls.UpdateStatusBar(stsStatus, "Please enter your username to continue with forgot password.", Color.Red);
            }
            else
            {
                if(MessageBox.Show("Do you want to reset password for username: " +
                    tbxUsername.Text +
                    "?", "Forget password", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    // check if user exist in db
                    if (clsSQL.SearchCurrentUser(tbxUsername.Text))
                    {
                        strUserName = tbxUsername.Text;
                        // if exist, than send them to verify thier security questions
                        frmQuestionsWindow frmQuestions = new frmQuestionsWindow(FORM_TYPE.RESET_PASSWORD);
                        this.Hide();
                        frmQuestions.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Entered username does not exist.", "Forget password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void cbxHidePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (tbxPassword.PasswordChar == '●')
            {
                tbxPassword.PasswordChar = '\0';
            }
            else
            {
                tbxPassword.PasswordChar = '●';
            }
        }

        private void btnContinueWithoutLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmCustomerView().ShowDialog();
            this.Show();
        }
    }
}
