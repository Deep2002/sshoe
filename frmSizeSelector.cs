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
    public partial class frmSizeSelector : Form
    {
        private clsInventory _selectedInventoryItem;

        public frmSizeSelector()
        {
            InitializeComponent();
        }

        public frmSizeSelector(clsInventory inventory)
        {
            InitializeComponent();
            this._selectedInventoryItem = inventory;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // check if selected size is valid
            bool isExist = cbxSize.Items.Cast<clsShoeSize>().Any(x => x.strSize == cbxSize.Text);

            if (isExist)
            {
                // Get the selected size by the user
                clsShoeSize selectedSize = new clsShoeSize();
                selectedSize = _selectedInventoryItem.lstSizes.Find(x => x.strSize.Equals(cbxSize.Text));

                // Add Selected Inventory to the list
                Customer_View_Classes.clsPublicData.currentUserCart.AddNewItem(_selectedInventoryItem, selectedSize, 1);
            }
            this.Close();
        }

        private void frmSizeSelector_Load(object sender, EventArgs e)
        {
            // show name
            lblItemName.Text = _selectedInventoryItem.strName;
            // show available sizes
            cbxSize.DataSource = _selectedInventoryItem.lstSizes;
            cbxSize.SelectedIndex = 0;
            cbxSize.DisplayMember = "strSize";

        }
    }
}
