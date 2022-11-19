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
    public partial class frmDiscountsManager : Form
    {

        public List<clsDiscounts> discountCodeList = new List<clsDiscounts>();

        public frmDiscountsManager()
        {
            InitializeComponent();
        }

        private void frmDiscountsManager_Load(object sender, EventArgs e)
        {
            // load All discounts code and display it
            clsSQL.LoadAllDiscounts(discountCodeList);
            loadDiscountsInDgv();
        }

        private void loadDiscountsInDgv()
        {
            dgvDiscounts.Rows.Clear();
            foreach (clsDiscounts discount in discountCodeList)
            {
                dgvDiscounts.Rows.Add(discount.DiscountCode, discount.StartDate, discount.ExpirationDate, discount.DiscountPercentage, discount.DiscountAmount, discount.DiscountID);
            }
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            // validate info
            if (validateInfo())
            {
                if (discountCodeList.FindAll(x => x.DiscountCode.ToLower() == tbxCode.Text.ToLower()).Count >= 1)
                {
                    MessageBox.Show($"Coupon Code '{tbxCode.Text}' already exists. Please use different code.", "Invalid Coupon Code", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbxCode.Focus();
                    tbxCode.SelectAll();
                    return;
                }
                else
                {
                   
                    clsDiscounts discountCode = new clsDiscounts();

                    discountCode.DiscountCode = tbxCode.Text;
                    discountCode.Description = tbxDesc.Text;
                    discountCode.DiscountLevel = tbxDiscountLevel.Text;
                    discountCode.DiscountType = cbxDiscountType.Text == "Percentage" ? 1 : 0;
                    discountCode.StartDate = dtpStartDate.Value.Date.ToString();
                    discountCode.ExpirationDate = dtpExpDate.Value.Date.ToString();

                    if (discountCode.DiscountType == 1)
                    {
                        discountCode.DiscountPercentage = (Convert.ToDecimal(tbxPercentageORAmount.Text) / 100).ToString();
                        discountCode.DiscountAmount = "";
                    }
                    else
                    {
                        discountCode.DiscountAmount = tbxPercentageORAmount.Text;
                        discountCode.DiscountPercentage = "";
                    }

                    clsSQL.AddDiscount(discountCode);

                    // reload codes
                    // load All discounts code and display it
                    discountCodeList.Clear();
                    clsSQL.LoadAllDiscounts(discountCodeList);
                    loadDiscountsInDgv();
                }
            }
            // Check if code already exists
        }

        private bool validateInfo()
        {
            // if something not correct display error
            if (tbxCode.Text == "")
            {
                MessageBox.Show("Please enter code.", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (tbxDesc.Text == "")
            {
                MessageBox.Show("Please enter Description.", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (tbxDiscountLevel.Text == "")
            {
                MessageBox.Show("Please enter Discount Level.", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            foreach (char c in tbxDiscountLevel.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Discount Level Must be digit.", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            if (!cbxDiscountType.Items.Contains(cbxDiscountType.Text))
            {
                MessageBox.Show("Please select Discount Type from drop-down.", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (tbxPercentageORAmount.Text == "")
            {
                MessageBox.Show("Please enter Percentage.", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            foreach (char c in tbxPercentageORAmount.Text)
            {
                if (!char.IsDigit(c) && c != '.')
                {
                    MessageBox.Show("Percentage Must be digit.", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            if (dtpExpDate.Value.Date <= dtpStartDate.Value.Date)
            {
                MessageBox.Show("Exp Date Must be after starting date.", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!validateInfo()) return;

            try
            {

                clsDiscounts discountCode = discountCodeList.Find(x => x.DiscountID == dgvDiscounts.SelectedCells[5].Value.ToString());

                discountCode.DiscountCode = tbxCode.Text;
                discountCode.Description = tbxDesc.Text;
                discountCode.DiscountLevel = tbxDiscountLevel.Text;
                discountCode.DiscountType = cbxDiscountType.Text == "Percentage" ? 1 : 0;
                discountCode.StartDate = dtpStartDate.Value.Date.ToString();
                discountCode.ExpirationDate = dtpExpDate.Value.Date.ToString();

                if (discountCode.DiscountType == 1)
                {
                    discountCode.DiscountPercentage = (Convert.ToDecimal(tbxPercentageORAmount.Text) / 100).ToString();
                    discountCode.DiscountAmount = "";
                }
                else
                {
                    discountCode.DiscountAmount = tbxPercentageORAmount.Text;
                    discountCode.DiscountPercentage = "";
                }

                clsSQL.UpdateDiscount(discountCode);

                // reload codes
                // load All discounts code and display it
                discountCodeList.Clear();
                clsSQL.LoadAllDiscounts(discountCodeList);
                loadDiscountsInDgv();

            } catch  (Exception)
            {
                MessageBox.Show("Please select discount from list above to update!", "Item not selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }


        private void dgvDiscounts_SelectionChanged(object sender, EventArgs e)
        {
            // Display selected item information
            try
            {
                if (dgvDiscounts.SelectedCells[5].Value == null) return;
                clsDiscounts discount = discountCodeList.Find(x => x.DiscountID == dgvDiscounts.SelectedCells[5].Value.ToString());

                tbxCode.Text = discount.DiscountCode;
                tbxDesc.Text = discount.Description;
                tbxDiscountLevel.Text = discount.DiscountLevel;
                dtpStartDate.Text = discount.StartDate;
                dtpExpDate.Text = discount.ExpirationDate;

                if (discount.DiscountType == 1)
                {
                    cbxDiscountType.Text = "Percentage";
                    lblPercentageORAmount.Text = "Percentage";
                    tbxPercentageORAmount.Text = discount.DiscountPercentage;
                } else
                {
                    cbxDiscountType.Text = "Dollar Amount";
                    lblPercentageORAmount.Text = "Amount";
                    tbxPercentageORAmount.Text = discount.DiscountAmount;
                }

            } catch { }
        }

        private void cbxDiscountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxDiscountType.SelectedIndex == 0)
            {
                lblPercentageORAmount.Text = "Amount";
            } else if (cbxDiscountType.SelectedIndex == 1)
            {
                lblPercentageORAmount.Text = "Percentage";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxCode.Text = "";
            tbxDesc.Text = "";
            tbxDiscountLevel.Text = "";
            cbxDiscountType.Text = "";
            dtpStartDate.Text = "";
            dtpExpDate.Text = "";
        }
    }
}
