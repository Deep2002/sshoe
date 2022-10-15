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
    public partial class frmTempAddInventoryForm : Form
    {
        public frmTempAddInventoryForm()
        {
            InitializeComponent();
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            tbxImgLocation.Text = fileDialog.FileName;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clsSQL.AddInventory(tbxName.Text, tbxDescription.Text, tbxCategoryID.Text, tbxretailPrice.Text, tbxcost.Text, tbxquantity.Text, tbxrestockThreshold.Text, tbxImgLocation.Text);
            tbxName.Text = "Name";
            tbxDescription.Text = "Description";
            tbxCategoryID.Text = "CategoryID";
            tbxretailPrice.Text = "Retail Price";
            tbxcost.Text = "Cost";
            tbxquantity.Text = "Quantity";
            tbxImgLocation.Text = "";
        }
    }
}
