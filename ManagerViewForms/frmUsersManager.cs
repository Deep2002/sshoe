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

namespace FinalProject.ManagerViewForms
{
    public partial class frmUserManager : Form
    {
        public FORM_TYPES currentFormType;

        public List<Person> usersList;

        public frmUserManager(FORM_TYPES frmType = FORM_TYPES.NORMAL)
        {
            InitializeComponent();
            currentFormType = frmType;
        }

        private void frmUsersManager_Load(object sender, EventArgs e)
        {
            // Display all customers

            switch (currentFormType)
            {
                case FORM_TYPES.NORMAL:
                    btnSelectThisAsCustomer.Visible = false;
                    btnAddNewUser.Visible = true;
                    btnShowCustomers.Visible = true;
                    btnShowEmployees.Visible = true;
                    btnUpdateUserInfo.Visible = true;
                    break;
                case FORM_TYPES.POINT_OF_SALES:
                    btnSelectThisAsCustomer.Visible = true;
                    btnAddNewUser.Visible = false;
                    btnShowCustomers.Visible = false;
                    btnShowEmployees.Visible = false;
                    btnUpdateUserInfo.Visible = false;
                    break;
            }

            loadDataOnForm();
        }

        private void loadDataOnForm()
        {
            // Display all customers
            usersList = new List<Person>();
            clsSQL.LoadAllCustomers(usersList);

            dgvUsers.Rows.Clear();
            // Show all customer into the data grid view
            foreach (Person person in usersList)
            {
                if (person.strPosition == "Customer")
                    dgvUsers.Rows.Add(person.strLastName + " " + person.strFirstName, person.strEmail, person.strPrimaryPhone, person.strPersonID);

            }
        }

        private void btnShowCustomers_Click(object sender, EventArgs e)
        {
            dgvUsers.Rows.Clear();
            // Show all customer into the data grid view
            foreach (Person person in usersList)
            {
                if (person.strPosition == "Customer")
                    dgvUsers.Rows.Add(person.strLastName + " " + person.strFirstName, person.strEmail, person.strPrimaryPhone, person.strPersonID);

            }
            lblInfo.Text = "Displaying Customers:";
        }

        private void btnShowEmployees_Click(object sender, EventArgs e)
        {
            dgvUsers.Rows.Clear();
            // Show all customer into the data grid view
            foreach (Person person in usersList)
            {
                if (person.strPosition == "Employee")
                    dgvUsers.Rows.Add(person.strLastName + " " + person.strFirstName, person.strEmail, person.strPrimaryPhone, person.strPersonID);

            }
            lblInfo.Text = "Displaying Employees:";
        }


        private void tbxSearchBar_TextChanged(object sender, EventArgs e)
        {
            if (tbxSearchBar.Text == "Name, ID, Email, Phone...") return;

            // search by user name or its name email phone or id
            string str = tbxSearchBar.Text.ToLower();
            // Open form with selected user informations
            dgvUsers.Rows.Clear();
            foreach (Person person in usersList.Where(x => x.strFirstName.ToLower().Contains(str) || x.strLastName.ToLower().Contains(str) || x.strEmail.ToLower().Contains(str) || x.strPrimaryPhone.ToLower().Contains(str) || x.strPersonID.ToLower().Contains(str)))
            {
                dgvUsers.Rows.Add(person.strLastName + " " + person.strFirstName, person.strEmail, person.strPrimaryPhone, person.strPersonID);
            }

            lblInfo.Text = "Displaying all:";
        }

        private void tbxSearchBar_MouseClick(object sender, MouseEventArgs e)
        {
            tbxSearchBar.SelectAll();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            // open form where user can create new user
            frmSignupView frmSignupView = new frmSignupView();
            this.Hide();
            frmSignupView.ShowDialog();
            this.Show();

            // reload all data on the form
            loadDataOnForm();
        }

        private void btnUpdateUserInfo_Click(object sender, EventArgs e)
        {
            try { 
                new frmUpdateUserInfo(usersList.Find(x => x.strPersonID == dgvUsers.SelectedCells[3].Value.ToString())).ShowDialog();
                loadDataOnForm();
            } catch {
                MessageBox.Show("Please select a user from the grid view above to see full information!", "Selection cannot be found.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tbxSearchBar_Enter(object sender, EventArgs e)
        {
            if(tbxSearchBar.Text == "Name, ID, Email, Phone...")
            {
                tbxSearchBar.Text = "";
            }
        }

        private void tbxSearchBar_Leave(object sender, EventArgs e)
        {
            if (tbxSearchBar.Text == "")
            {
                tbxSearchBar.Text = "Name, ID, Email, Phone...";
            }
        }

        private void btnSelectThisAsCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                clsPublicData.currentUser =  usersList.Find(x => x.strPersonID == dgvUsers.SelectedCells[3].Value.ToString());
            }
            catch
            {
                MessageBox.Show("Please select a user from the grid view above.", "Selection cannot be found.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }
    }
}
