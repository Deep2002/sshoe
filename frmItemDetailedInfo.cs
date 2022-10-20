using FinalProject.Customer_View_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class frmItemDetailedInfo : Form
    {
        private clsInventory _selectedInventoryItem;

        public frmItemDetailedInfo()
        {
            InitializeComponent();
        }

        public frmItemDetailedInfo(clsInventory selectedInventoryItem)
        {
            InitializeComponent();
            _selectedInventoryItem = selectedInventoryItem;
        }

        private void frmItemDetailedInfo_Load(object sender, EventArgs e)
        {
            // Show selected item information/ details
            if (_selectedInventoryItem.strName.Length <= 20)
            {
                this.Text = _selectedInventoryItem.strName;
            }
            else
            {
                this.Text = _selectedInventoryItem.strName.Substring(0, 20) + "...";
            }

            using (MemoryStream ms = new MemoryStream(_selectedInventoryItem.byteImage))
                pbxItemImage.Image = Image.FromStream(ms);

            lblItemName.Text = _selectedInventoryItem.strName;
            lblDescription.Text = _selectedInventoryItem.strDescription;
            lblPrice.Text = $"Price: ${_selectedInventoryItem.decCost}";
            lblProductLeft.Text = $"Total Product Left: {_selectedInventoryItem.intQuantity}";

            if (_selectedInventoryItem.intQuantity == 0)
            {
                lblNote.Text = "Sold out!";
                lblNote.ForeColor = Color.Red;
                lblNote.Visible = true;
            }
            else if (_selectedInventoryItem.intQuantity <= 10)
            {
                lblNote.Visible = true;
            }
            else
            {
                lblNote.Visible = false;
            }

            // add sizes if exist
            if (_selectedInventoryItem.lstSizes.Count <= 0)
            {
                cbxSize.Text = "N/A";
                cbxSize.Enabled = false;
                nudQuantityCounter.Enabled = false;
                btnAddToCartNow.Enabled = false;
                btnAddToCartNow.BackColor = Color.LightGray;
            }
            else
            {
                cbxSize.DataSource = _selectedInventoryItem.lstSizes;
                cbxSize.SelectedIndex = 0;
                cbxSize.DisplayMember = "strSize";

                nudQuantityCounter.Value = 1;
                nudQuantityCounter.Maximum = _selectedInventoryItem.lstSizes[cbxSize.SelectedIndex].intQuantity;
                nudQuantityCounter.Minimum = 1;
            }
        }

        private void cbxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            nudQuantityCounter.Value = 1;
            nudQuantityCounter.Maximum = _selectedInventoryItem.lstSizes[cbxSize.SelectedIndex].intQuantity;

        }

        private void btnAddToCartNow_Click(object sender, EventArgs e)
        {
            // check if selected size is valid
            bool isExists = cbxSize.Items.Cast<clsShoeSize>().Any(x => x.strSize == cbxSize.Text);
            
            if (isExists)
            {
                // Get the selected size by the user
                clsShoeSize selectedSize = new clsShoeSize();
                selectedSize = _selectedInventoryItem.lstSizes.Find(x => x.strSize.Equals(cbxSize.Text));

                // validate added quantity
                if (nudQuantityCounter.Value > selectedSize.intQuantity || nudQuantityCounter.Value < 0)
                {
                    MessageBox.Show("Please select valid quantity.", "Incorrect Information!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Add Selected Inventory to the list
                Customer_View_Classes.clsPublicData.currentUserCart.AddNewItem(_selectedInventoryItem, selectedSize, Convert.ToInt32(nudQuantityCounter.Value));
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select available/valid shoe size.", "Incorrect Information!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
