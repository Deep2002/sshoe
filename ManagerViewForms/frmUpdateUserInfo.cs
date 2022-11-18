using FinalProject.Customer_View_Classes;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProject.ManagerViewForms
{
    public partial class frmUpdateUserInfo : Form
    {
        public Person selectedPerson;

        public frmUpdateUserInfo(Person selectedPerson)
        {
            InitializeComponent();
            this.selectedPerson = selectedPerson;
        }

        private void frmUpdateUserInfo_Load(object sender, EventArgs e)
        {
            // display all information about selected person
            if (selectedPerson != null)
            {
                cbxUserType.Text = selectedPerson.strPosition;
                tbxFirstName.Text = selectedPerson.strFirstName;
                tbxLastName.Text = selectedPerson.strLastName;
                tbxMiddleName.Text = selectedPerson.strMiddleName;
                cbxTitle.Text = selectedPerson.strTitle;
                tbxSuffix.Text = selectedPerson.strSuffix;
                tbxUsername.Text = selectedPerson.strUsername;
                tbxEmail.Text = selectedPerson.strEmail;
                tbxPrimaryPhone.Text = selectedPerson.strPrimaryPhone;
                tbxSecondaryPhone.Text = selectedPerson.strSecondaryPhone;
                tbxAddress.Text = selectedPerson.strAddress1;
                tbxAddress2.Text = selectedPerson.strAddress2;
                tbxAddress3.Text = selectedPerson.strAddress3;
                tbxCity.Text = selectedPerson.strCity;
                cbxState.Text = selectedPerson.strState;
                tbxZIP.Text = selectedPerson.strZip;
                tbxPassword.Text = selectedPerson.strPassword;
            }
        }


        private void cbxHidePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (tbxPassword.PasswordChar == '●')
                tbxPassword.PasswordChar = '\0';
            else
                tbxPassword.PasswordChar = '●';

        }

        private bool validateData()
        {
            if (!cbxUserType.Items.Contains(cbxUserType.Text))
            {
                MessageBox.Show("Invalid User Type!, Please select one from drop-down.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbxUserType.Focus();
                return false;
            }
            if (!clsValidation.ValidateName(tbxFirstName.Text)) {
                MessageBox.Show("Invalid First Name!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxUsername.Focus();
                return false;
            }

            if (!clsValidation.ValidateName(tbxLastName.Text))
            {
                MessageBox.Show("Invalid Last Name!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxLastName.Focus();
                return false;
            }
            if (!string.IsNullOrEmpty(tbxMiddleName.Text) && !clsValidation.ValidateName(tbxMiddleName.Text))
            {
                MessageBox.Show("Invalid Middle Name!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxMiddleName.Focus();
                return false;
            }
            if (!cbxTitle.Items.Contains(cbxTitle.Text))
            {
                MessageBox.Show("Invalid Title!, Please select one from drop-down.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbxTitle.Focus();
                return false;
            }
            if (!clsValidation.ValidateUsername(tbxUsername.Text))
            {
                MessageBox.Show("Invalid User Name!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxUsername.Focus();
                return false;
            }
            if (!clsValidation.ValidateEmail(tbxEmail.Text))
            {
                MessageBox.Show("Invalid Email!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxEmail.Focus();
                return false;
            }
            if (!clsValidation.ValidatePhone(tbxPrimaryPhone.Text))
            {
                MessageBox.Show("Invalid Primary Phone!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxPrimaryPhone.Focus();
                return false;
            }
            if (!string.IsNullOrEmpty(tbxSecondaryPhone.Text) && !clsValidation.ValidatePhone(tbxSecondaryPhone.Text))
            {
                MessageBox.Show("Invalid Secondary Phone!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxSecondaryPhone.Focus();
                return false;
            }
            if (!clsValidation.ValidateAddress(tbxAddress.Text))
            {
                MessageBox.Show("Invalid Address 1!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxAddress.Focus();
                return false;
            }
            if (!string.IsNullOrEmpty(tbxAddress2.Text) && !clsValidation.ValidateAddress(tbxAddress2.Text))
            {
                MessageBox.Show("Invalid Address 2!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxAddress2.Focus();
                return false;
            }
            if (!string.IsNullOrEmpty(tbxAddress3.Text) && !clsValidation.ValidateAddress(tbxAddress3.Text))
            {
                MessageBox.Show("Invalid Address 3!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxAddress3.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(tbxCity.Text))
            {
                MessageBox.Show("Invalid City!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxCity.Focus();
                return false;
            }
            if (!clsValidation.ValidateZipcode(tbxZIP.Text))
            {
                MessageBox.Show("Invalid ZIP!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxZIP.Focus();
                return false;
            }
            if (!cbxState.Items.Contains(cbxState.Text))
            {
                MessageBox.Show("Invalid State!, Please select one from drop-down.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbxState.Focus();
                return false;
            }
            if (!clsValidation.ValidatePassword(tbxPassword.Text))
            {
                MessageBox.Show("Invalid Password!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxPassword.Focus();
                return false;
            }

            // if everything is good
            // return true
            return true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Method to validate all items before proceeding to the update
            //MessageBox.Show(tbxPassword.Text);
            if (validateData())
            {
                //if so, proceed to updating
                clsSQL.updatePerson(selectedPerson.strPersonID, tbxFirstName.Text, tbxLastName.Text, tbxMiddleName.Text, cbxTitle.Text,
                    tbxSuffix.Text, tbxUsername.Text, tbxEmail.Text, tbxPrimaryPhone.Text, tbxSecondaryPhone.Text, tbxAddress.Text, tbxAddress2.Text,
                    tbxAddress3.Text, tbxCity.Text, cbxState.Text, tbxZIP.Text, tbxPassword.Text, cbxUserType.Text == "Customer" ? "1001" : "1000");
            }
        }

        private void tbxPrimaryPhone_KeyDown(object sender, KeyEventArgs e)
        {
        }
    }
}
