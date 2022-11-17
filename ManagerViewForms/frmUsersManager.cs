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

public List<Person> usersList;

        public frmUserManager()
        {
            InitializeComponent();
        }

        private void frmUsersManager_Load(object sender, EventArgs e)
        {
            // Display all customers
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
            // search by user name or its name email phone or id
            string str = tbxSearchBar.Text.ToLower();
            // Open form with selected user informations
            dgvUsers.Rows.Clear();
            foreach (Person person in usersList.Where(x => x.strFirstName.ToLower().Contains(str) || x.strLastName.ToLower().Contains(str) || x.strEmail.ToLower().Contains(str) || x.strPrimaryPhone.ToLower().Contains(str)))
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
            // open form where uiser can create new user
            frmSignupView frmSignupView = new frmSignupView();
            this.Hide();
            frmSignupView.ShowDialog();
            this.Show();

            // reload all data on the form
            loadDataOnForm();

        }

        private void btnUpdateUserInfo_Click(object sender, EventArgs e)
        {
            /// Method to show more information about selected user
            /// 
        }
    }
}
