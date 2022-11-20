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
    public partial class frmNotifications : Form
    {
        public List<clsInventory> inventoryList = new List<clsInventory>();

        public frmNotifications()
        {
            InitializeComponent();
        }

        private void frmNotifications_Load(object sender, EventArgs e)
        {
            // get all items and display only that is low on quantity
            clsSQL.LoadInventory(inventoryList);
            inventoryList = inventoryList.FindAll(x => x.intRestockThreashold >= x.intQuantity);

            foreach(clsInventory item in inventoryList)
            {
                dgvItems.Rows.Add(item.strName, item.intQuantity, item.intID, item.intRestockThreashold);
            }
        }

        private void btnEditQuantity_Click(object sender, EventArgs e)
        {
            // show inventory manager
            this.Hide();
            new frmInvetoryManager().ShowDialog();
            this.Show();
        }
    }
}
