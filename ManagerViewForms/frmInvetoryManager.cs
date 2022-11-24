using FinalProject.Customer_View_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
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

        /// <summary>
        ///  Keep track of what is deleted and what not.
        /// </summary>
        public List<clsShoeSize> newAddedSizesList = new List<clsShoeSize>();
        public List<clsShoeSize> updatedSizesList = new List<clsShoeSize>();
        public List<clsShoeSize> deletedSizesList = new List<clsShoeSize>();

        public frmInvetoryManager()
        {
            InitializeComponent();
        }

        private void frmInventoryPanel_Load(object sender, EventArgs e)
        {
            LoadAndDisplayItemsOnScreen();

            // get & show all brands
            clsSQL.LoadAllBrands(brandList);
            cbxBrand.DataSource = brandList.ToList();
            cbxBrand.DisplayMember = "name";
            cbxBrand.ValueMember = "id";
            cbxBrand.Text = "Brand";
            cbxBrand.SelectedIndex = 0;


            // get & show all categories
            clsSQL.LoadAllCategories(categoryList);
            cbxCategory.DataSource = categoryList.ToList();
            cbxCategory.DisplayMember = "strName";
            cbxCategory.ValueMember = "intID";
            cbxCategory.Text = "Category";
            cbxCategory.SelectedIndex = 0;


            // Insert Genders
            List<clsGender> genderList = new List<clsGender>
            {
                new clsGender(1, "Men"),
                new clsGender(2, "Women"),
                new clsGender(3, "Unisex"),
                new clsGender(4, "Girls"),
                new clsGender(5, "Boys"),
            };

            cbxGender.DataSource = genderList.ToList();
            cbxGender.DisplayMember = "gender";
            cbxGender.ValueMember = "id";
            cbxGender.SelectedIndex = 0;

            lbxItems.SelectedIndex = -1;
            fileChooser = new OpenFileDialog();
            fileChooser.FileName = null;
        }

        private void LoadAndDisplayItemsOnScreen()
        {
            // load inventory & it's sizes, gender, category, brand, etc.\
            inventoryList.Clear();
            clsSQL.LoadInventory(inventoryList);
            clsSQL.LoadSizes(inventoryList);
            clsSQL.LoadGenders(inventoryList);
            clsSQL.LoadCategories(inventoryList);
            clsSQL.LoadBrands(inventoryList);

            // every time load inventory copy it to the public inventory list
            // so all forms gets updated info
            clsPublicData.lstInventory = inventoryList;

            // show inventory items on the list box
            //lbxItems.Items.Clear();
            lbxItems.DataSource = inventoryList.ToList();
            lbxItems.DisplayMember = "strName";
            lbxItems.ValueMember = "intID";
            lbxItems.SelectedIndex = 0;
        }

        private void lbxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(lbxItems.SelectedValue.ToString());
            if (lbxItems.SelectedValue == null) return;
            try
            {
                clearEverything();
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
                cbxDiscountinued.Checked = selectedItem.intDicontinued == 1 ? true : false;

                // display sizes 
                //dgvSizes.DataSource = selectedItem.lstSizes.ToList();
                dgvSizes.Rows.Clear();
                foreach (clsShoeSize size in selectedItem.lstSizes)
                {
                    dgvSizes.Rows.Add(size.strSize, size.intQuantity);
                }

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
            clearEverything();
        }

        public void clearEverything()
        {
            // set everything back to normal
            tbxName.Text = "";
            tbxDesc.Text = "";
            tbxRetailPrice.Text = "";
            tbxCost.Text = "";
            tbxRestockThreshold.Text = "";
            cbxGender.Text = "";
            cbxCategory.Text = "";
            cbxBrand.Text = "";
            tbxTotalQuantity.Text = "0";
            cbxSize.Text = "Size";
            tbxQuantity.Text = "";
            tbxImgLocation.Text = "Image Location...";

            dgvSizes.DataSource = null;
            dgvSizes.Rows.Clear();
            pbxImage.Image = null;
            fileChooser.FileName = null;

            newAddedSizesList = new List<clsShoeSize>();
            deletedSizesList = new List<clsShoeSize>();
            updatedSizesList = new List<clsShoeSize>();

        }

        private void btnUpdateImage_Click(object sender, EventArgs e)
        {
            fileChooser = new OpenFileDialog();

            if (fileChooser.ShowDialog() == DialogResult.OK)
            {
                pbxImage.Image = new Bitmap(fileChooser.FileName);
                tbxImgLocation.Text = fileChooser.FileName;
            }
        }

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            // check all fields before proceeding
            if (!AllFieldsAreValid()) return;


            string itemID = clsSQL.AddInventory(tbxName.Text, tbxDesc.Text, cbxCategory.SelectedValue.ToString(), tbxRetailPrice.Text, tbxCost.Text, tbxTotalQuantity.Text, tbxRestockThreshold.Text, fileChooser.FileName, cbxGender.SelectedValue.ToString(), cbxBrand.SelectedValue.ToString(), cbxDiscountinued.Checked ? 1 : 0);

            if (itemID != "false")
            {
                // if item added successfully
                // add shoe size if exists
                if (dgvSizes.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvSizes.Rows)
                    {

                        clsSQL.AddShoeSize(row.Cells["Size"].Value.ToString(), row.Cells["Qt"].Value.ToString(), itemID);
                    }
                }

                MessageBox.Show("Item Successfully Added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // load inventory to get new items and its shoe sizes
                LoadAndDisplayItemsOnScreen();

                lbxItems.DataSource = inventoryList.ToList();
                lbxItems.DisplayMember = "strName";
                lbxItems.ValueMember = "intID";
                lbxItems.SelectedIndex = 0;

                clearEverything();
            }

        }

        private bool AllFieldsAreValid(bool checkForImage = true)
        {
            if (string.IsNullOrEmpty(tbxName.Text))
            {
                MessageBox.Show("Name Cannot be Empty, Please enter the name before trying again.",
                    "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxName.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tbxDesc.Text))
            {
                MessageBox.Show("Description Cannot be Empty, Please enter the something before trying again.",
                    "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxDesc.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tbxRetailPrice.Text))
            {
                MessageBox.Show("Retail Price Cannot be Empty, Please enter the retail price before trying again.",
                    "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxRetailPrice.Focus();
                return false;
            }
            foreach (char c in tbxRetailPrice.Text)
            {
                if (char.IsLetter(c))
                {
                    MessageBox.Show("Retail Price Invalid, Please enter the retail price before trying again.",
                 "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbxRetailPrice.Focus();
                    return false;
                }
            }
            if (string.IsNullOrEmpty(tbxCost.Text))
            {
                MessageBox.Show("Cost Cannot be Empty, Please enter the Cost before trying again.",
                    "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxCost.Focus();
                return false;
            }
            foreach (char c in tbxCost.Text)
            {
                if (char.IsLetter(c))
                {
                    MessageBox.Show("Cost Invalid, Please enter the Cost before trying again.",
                 "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbxCost.Focus();
                    return false;
                }
            }
            if (string.IsNullOrEmpty(tbxRestockThreshold.Text))
            {
                MessageBox.Show("Name Restock Value cannot be Empty, Please enter the restock value before trying again.",
                    "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxRestockThreshold.Focus();
                return false;
            }
            foreach (char c in tbxRestockThreshold.Text)
            {
                if (char.IsLetter(c))
                {
                    MessageBox.Show("Restock Threshold is Invalid, Please enter the Restock Threshold is before trying again.",
                 "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbxRestockThreshold.Focus();
                    return false;
                }
            }
            if (!cbxGender.Items.Cast<clsGender>().Any(x => x.gender == cbxGender.Text))
            {
                MessageBox.Show("Selected Gender Is Invalid!",
                    "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxGender.Focus();
                return false;
            }
            if (!cbxCategory.Items.Cast<clsCategories>().Any(x => x.strName == cbxCategory.Text))
            {
                MessageBox.Show("Selected Category Is Invalid!",
                    "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxCategory.Focus();
                return false;
            }
            if (!cbxBrand.Items.Cast<clsBrand>().Any(x => x.name == cbxBrand.Text))
            {
                MessageBox.Show("Selected Brand Is Invalid!",
                    "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxBrand.Focus();
                return false;
            }
            if (checkForImage == true && string.IsNullOrEmpty(fileChooser.FileName))
            {
                MessageBox.Show("Please upload image to continue.",
                    "Image not found!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }


            return true;
        }

        private void btnAddSize_Click(object sender, EventArgs e)
        {
            /// Add Size To The data grid view


            if (cbxSize.Items.Contains(cbxSize.Text))
            {
                if (string.IsNullOrEmpty(tbxQuantity.Text) || tbxQuantity.Text == "0" || tbxQuantity.Text == "0.00")
                {
                    MessageBox.Show("Invalid Quantity. Please enter valid Quantity", "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                foreach (char c in tbxQuantity.Text)
                {
                    if (char.IsLetter(c))
                    {
                        MessageBox.Show("Invalid Quantity. Please enter valid Quantity", "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbxQuantity.Focus();
                        return;
                    }
                }

                bool sizeExists = false;
                foreach (DataGridViewRow row in dgvSizes.Rows)
                {
                    // Check if size user trying to add is already exists
                    if (Convert.ToDouble(row.Cells["Size"].Value.ToString()) == Convert.ToDouble(cbxSize.Text))
                    {
                        if (MessageBox.Show($"Size {cbxSize.Text} already exists. Would you like to update quantity from {row.Cells["Qt"].Value} to {tbxQuantity.Text}?"
                            , "Size Already Exists!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            row.Cells["Qt"].Value = tbxQuantity.Text;
                        }
                        sizeExists = true;
                    }
                }

                if (!sizeExists)
                {
                    dgvSizes.Rows.Add(cbxSize.Text, tbxQuantity.Text);

                    // Keep track of what is added
                    // remove if size already exists.
                    clsShoeSize temp = newAddedSizesList.Find(x => x.strSize == cbxSize.Text);

                    if (temp != null)
                    {
                        newAddedSizesList.Remove(temp);
                    }

                    //  just add back new shoe size.
                    newAddedSizesList.Add(new clsShoeSize(cbxSize.Text, Convert.ToInt32(tbxQuantity.Text)));

                }
                else
                {
                    // if user want to update it instead.
                    // add that product to update list  to keep track
                    // remove if size already exists.
                    clsShoeSize temp = updatedSizesList.Find(x => x.strSize == cbxSize.Text);

                    if (temp != null)
                    {
                        updatedSizesList.Remove(temp);
                    }

                    updatedSizesList.Add(new clsShoeSize(cbxSize.Text, Convert.ToInt32(tbxQuantity.Text)));
                }

                // update quantity
                tbxTotalQuantity.Text = "0";
                foreach (DataGridViewRow row in dgvSizes.Rows)
                {
                    tbxTotalQuantity.Text = (Convert.ToInt32(tbxTotalQuantity.Text) + Convert.ToInt32(row.Cells["Qt"].Value)).ToString();
                }
            }
            else
            {
                MessageBox.Show("Invalid Size. Please enter valid Size to continue.", "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbxSize.Focus();
            }
        }

        private void btnDeleteSize_Click(object sender, EventArgs e)
        {
            // Ask if user really want to delete that
            if (dgvSizes.Rows.Count <= 0) return;
            if (MessageBox.Show("Do you really want to delete this size?", "Deleting..",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // if so, delete selected size
                // delete from data grid view only

                tbxTotalQuantity.Text = "0";
                foreach (DataGridViewRow row in dgvSizes.Rows)
                {
                    if (row.Cells["Size"].Value.ToString() == dgvSizes.SelectedCells[0].Value.ToString())
                    {
                        // remove size if already exists
                        clsShoeSize temp = deletedSizesList.Find(x => x.strSize == row.Cells["Size"].Value.ToString());

                        if (temp != null)
                        {
                            deletedSizesList.Remove(temp);
                        }

                        // Add that size to deleted list to keep track of that
                        deletedSizesList.Add(new clsShoeSize(row.Cells["Size"].Value.ToString(), Convert.ToInt32(row.Cells[1].Value.ToString())));

                        dgvSizes.Rows.Remove(row);
                    }

                    // count total quantity
                    tbxTotalQuantity.Text = (Convert.ToInt32(row.Cells[1].Value.ToString()) + Convert.ToInt32(tbxTotalQuantity.Text)).ToString();
                }

                //// update total quantity text box

                //if (clsSQL.DeleteShoeSize(dgvSizes.SelectedCells[0].Value.ToString(), lbxItems.SelectedValue.ToString()))
                //{

                //    MessageBox.Show("Size Deleted", "Record Deleted..", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //    // update shoe sizes by re getting shoes sizes
                //    clsSQL.LoadSizes(inventoryList);

                //    // update list of shoes size / DataGridView
                //    clsInventory selectedItem = inventoryList.Find(x => x.intID == Convert.ToInt32(lbxItems.SelectedValue.ToString()));
                //    dgvSizes.Rows.Clear();
                //    // Show available sizes
                //    foreach (clsShoeSize size in selectedItem.lstSizes)
                //    {
                //        dgvSizes.Rows.Add(size.strSize, size.intQuantity);
                //        selectedItem.intQuantity += size.intQuantity;
                //    }
                //    // update total quantity
                //    tbxTotalQuantity.Text = selectedItem.intQuantity.ToString();
                //} else
                //{
                //    MessageBox.Show("Unable to Delete", "Record Delete..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
            }
        }


        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            // This will update all item information  

            // if entered info is invalid return
            if (!AllFieldsAreValid(false)) return;

            // check if everything is valid before moving on
            if (MessageBox.Show("Do you like to update information about selected item?", "Updating..", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                string itemID = lbxItems.SelectedValue.ToString();
                // update
                clsSQL.UpdateInventory(tbxName.Text, tbxDesc.Text, tbxRetailPrice.Text, tbxCost.Text, tbxTotalQuantity.Text, tbxRestockThreshold.Text, cbxGender.SelectedValue.ToString(), cbxCategory.SelectedValue.ToString(), cbxBrand.SelectedValue.ToString(), itemID, fileChooser.FileName, cbxDiscountinued.Checked ? 1 : 0);

                // add shoes sizes
                foreach (clsShoeSize size in newAddedSizesList)
                {
                    clsSQL.AddShoeSize(size.strSize, size.intQuantity.ToString(), itemID);
                }
                // delete shoes sizes
                foreach (clsShoeSize size in deletedSizesList)
                {
                    clsSQL.DeleteShoeSize(size.strSize, itemID);
                }
                // update shoes sizes
                foreach (clsShoeSize size in updatedSizesList)
                {
                    clsSQL.UpdateShoeSize(size.strSize, size.intQuantity.ToString(), itemID);
                }

                MessageBox.Show("Successfully Updated!", "Item Updated.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // After Update, Load Everything again.
                LoadAndDisplayItemsOnScreen();
                clearEverything();
            }
        }

        private void mnuMenuHelp_Click(object sender, EventArgs e)
        {

            //System.Diagnostics.Process.Start(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\Resources\HelpFile\help_file.html");
            System.Diagnostics.Process.Start(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\Resources\HelpFile\managerHelpFiles\help_file.html");

        }

        private void tbxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || char.IsLetter(e.KeyChar)) e.Handled = true;
        }

        private void tbxRestockThreshold_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || char.IsLetter(e.KeyChar)) e.Handled = true;

        }
    }
}
