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

namespace FinalProject.ManagerViewForms
{
    public partial class frmInvetoryManager : Form
    {
        public List<clsInventory> inventoryList = new List<clsInventory>();
        public List<clsBrand> brandList = new List<clsBrand>();
        public List<clsCategories> categoryList = new List<clsCategories>();

        public frmInvetoryManager()
        {
            InitializeComponent();
        }

        private void frmInventoryPanel_Load(object sender, EventArgs e)
        {
            // load inventory & it's sizes, gender, category, brand, etc.
            clsSQL.LoadInventory(inventoryList);
            clsSQL.LoadSizes(inventoryList);
            clsSQL.LoadGenders(inventoryList);
            clsSQL.LoadCategories(inventoryList);
            clsSQL.LoadBrands(inventoryList);


            // show inventory items on the list box
            lbxItems.DataSource = inventoryList.ToList();
            lbxItems.DisplayMember = "strName";
            lbxItems.ValueMember = "intID";
            lbxItems.SelectedIndex = 0;

            // get & show all brands
            clsSQL.LoadAllBrands(brandList);
            cbxBrand.DataSource = brandList.ToList();
            cbxBrand.DisplayMember = "name";
            cbxBrand.ValueMember = "id";
            cbxBrand.Text = "Brand";

            // get & show all categories
            clsSQL.LoadAllCategories(categoryList);
            cbxCategory.DataSource = categoryList.ToList();
            cbxCategory.DisplayMember = "strName";
            cbxCategory.ValueMember = "intID";
            cbxCategory.Text = "Category";

        }

        private void lbxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(lbxItems.SelectedValue.ToString());
            if (lbxItems.SelectedValue == null) return;
            try
            {

                // Show selected items information
                clsInventory selectedItem = inventoryList.Find(x => x.intID == Convert.ToInt32(lbxItems.SelectedValue.ToString()));


                tbxName.Text = selectedItem.strName;    
                tbxDesc.Text = selectedItem.strDescription;    
                tbxRetailPrice.Text = selectedItem.decReatailPrice.ToString();    
                tbxCost.Text = selectedItem.decCost.ToString();    
                tbxRestockThreshold.Text = selectedItem.intRestockThreashold.ToString();    
                cbxGender.Text = selectedItem.strGender;    
                cbxCategory.Text = selectedItem.strCategory;    
                cbxBrand.Text = selectedItem.strBrand;

                // display sizes
                dgvSizes.DataSource = selectedItem.lstSizes.ToList();
                dgvSizes.Columns[0].HeaderText = "Size";
                dgvSizes.Columns[1].HeaderText = "Qt";

                tbxTotalQuantity.Text = selectedItem.intQuantity.ToString();

                using (MemoryStream ms = new MemoryStream(selectedItem.byteImage))
                    pbxImage.Image = Image.FromStream(ms);
            }
            catch (Exception) { }
        }

        private void tbxSearchBar_TextChanged(object sender, EventArgs e)
        {
            if (tbxSearchBar.Text != null && tbxSearchBar.Text != "Search...")
            {
                List<clsInventory> tempList = new List<clsInventory>();

                tempList = inventoryList.Where(x => x.strName.ToLower().Contains(tbxSearchBar.Text.ToLower()) || x.strBrand.ToLower().Contains(tbxSearchBar.Text.ToLower()) || x.strDescription.ToLower().Contains(tbxSearchBar.Text.ToLower())).ToList();

                lbxItems.DataSource = null;
                lbxItems.DataSource = tempList.ToList();
                lbxItems.DisplayMember = "strName";
                lbxItems.ValueMember = "intID";
            }
        }

        #region On text box click, select all text
        private void tbxSearchBar_MouseClick(object sender, MouseEventArgs e)
        {
            tbxSearchBar.SelectAll();
        }

        private void tbxName_MouseClick(object sender, MouseEventArgs e)
        {
            tbxName.SelectAll();
        }

        private void tbxDesc_MouseClick(object sender, MouseEventArgs e)
        {
            tbxDesc.SelectAll();

        }

        private void tbxRetailPrice_MouseClick(object sender, MouseEventArgs e)
        {
            tbxRetailPrice.SelectAll();

        }

        private void tbxCost_MouseClick(object sender, MouseEventArgs e)
        {
            tbxCost.SelectAll();

        }
        #endregion

        private void btnClearAllField_Click(object sender, EventArgs e)
        {
            // set everything back to normal
            tbxName.Text = "Name";
            tbxDesc.Text = "Description";
            tbxRetailPrice.Text = "0.00";
            tbxCost.Text = "0.00";
            tbxRestockThreshold.Text = "0";
            cbxGender.Text = "Gender";
            cbxCategory.Text = "Category";
            cbxBrand.Text = "Brand";
            tbxTotalQuantity.Text = "0";
            cbxSize.Text = "Size";
            tbxQuantity.Text = "Quantity";

            dgvSizes.DataSource = null;
            pbxImage.Image = null;

        }

        private void btnUpdateImage_Click(object sender, EventArgs e)
        {
            fileChooser.ShowDialog();
        }
    }
}
