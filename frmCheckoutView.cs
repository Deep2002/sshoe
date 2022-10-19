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
    public partial class frmCheckoutView : Form
    {
        public frmCheckoutView()
        {
            InitializeComponent();
        }

        private void frmCheckoutView_Load(object sender, EventArgs e)
        {
            // load address
            lblAddress.Text = $"{ clsPublicData.currentUser.strAddress1 }..\n{clsPublicData.currentUser.strCity}, { clsPublicData.currentUser.strState } { clsPublicData.currentUser.strZip }";

            // load in cart items to list view
            int columnIndex = 0, rowIndex = 0;
            foreach (var item in clsPublicData.currentUserCart.lstUserCart)
            {

                dgvItemsDetails.Rows.Add();

                dgvItemsDetails[columnIndex, rowIndex].Value = item.inventory.strName;
                columnIndex++;
                dgvItemsDetails[columnIndex, rowIndex].Value = "$" + item.inventory.decCost;
                columnIndex++;
                dgvItemsDetails[columnIndex, rowIndex].Value = item.quantity;
                columnIndex++;
                dgvItemsDetails[columnIndex, rowIndex].Value = "$" + item.inventory.decCost * item.quantity;

                columnIndex = 0;
                rowIndex++;
            }

            // Uncomment these to display numbers in left corner
            //dgvItemsDetails.Columns["ItemPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dgvItemsDetails.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dgvItemsDetails.Columns["TotalPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            // Add Calculations/totals
            lblSubTotalValue.Text = "$" + clsPublicData.currentUserCart.Subtotal.ToString("0.00");
            lblTaxValue.Text = "$" + clsPublicData.currentUserCart.Tax.ToString("0.00");
            lblTotalValue.Text = "$" + clsPublicData.currentUserCart.Total.ToString("0.00");

            if (clsPublicData.currentUserCart.Discount > 0)
            {

                if (clsPublicData.discount.DicountPercentage != "")
                    lblDiscount.Text = $"Discount ({Convert.ToDecimal(clsPublicData.discount.DicountPercentage) * 100}%):";
                else
                    lblDiscount.Text = $"Discount $({clsPublicData.discount.DicountAmount}):";

                lblDiscountValue.Text = "-" + clsPublicData.currentUserCart.Discount.ToString("0.00");
                lblDiscountedTotalValue.Text = "$" + clsPublicData.currentUserCart.DiscountedTotal.ToString("0.00");
            }
        }

        private void btnContinueToCheckout_Click(object sender, EventArgs e)
        {
            // Check if user have selected right address
            if (rdoUseAboveAddress.Checked || rdoUseDiffrentAddress.Checked)
            {
                if (rdoUseAboveAddress.Checked)
                {
                    new frmPaymentInfo().ShowDialog();
                    //this.Close();
                }
                else
                {
                    new frmAddressFilloutForm().ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Please select address from bottom left corner.", "Select Address", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnApplyCoupon_Click(object sender, EventArgs e)
        {
            // check if coupon is valid
            if (clsSQL.GetDiscountCode(tbxCoupon.Text))
            {
                // check for expiration date
                if (Convert.ToDateTime(clsPublicData.discount.ExpirationDate) < DateTime.Now)
                {
                    lblCouponInfo.Text = "Coupon no longer valid.";
                    lblCouponInfo.ForeColor = Color.Red;
                    return;
                }

                //  if so, give user a discount
                // check if we have dollar amount or percentage
                if (clsPublicData.discount.DicountAmount != "")
                {
                    clsPublicData.currentUserCart.Discount = Convert.ToDecimal(clsPublicData.discount.DicountAmount);
                    lblDiscount.Text = $"Discount $({clsPublicData.discount.DicountAmount}):";
                }
                else
                {
                    clsPublicData.currentUserCart.Discount = clsPublicData.currentUserCart.Subtotal * Convert.ToDecimal(clsPublicData.discount.DicountPercentage);
                    lblDiscount.Text = $"Discount ({Convert.ToDecimal(clsPublicData.discount.DicountPercentage) * 100}%):";
                }

                // add rest of the amounts
                clsPublicData.currentUserCart.DiscountedTotal = clsPublicData.currentUserCart.Subtotal - clsPublicData.currentUserCart.Discount;
                clsPublicData.currentUserCart.Tax = clsPublicData.currentUserCart.DiscountedTotal * (decimal)0.0825;
                clsPublicData.currentUserCart.Total = clsPublicData.currentUserCart.Tax + clsPublicData.currentUserCart.DiscountedTotal;

                // update it on the screen
                lblDiscountValue.Text = "-" + clsPublicData.currentUserCart.Discount.ToString("0.00");
                lblDiscountedTotalValue.Text = "$" + clsPublicData.currentUserCart.DiscountedTotal.ToString("0.00");
                lblTaxValue.Text = "$" + clsPublicData.currentUserCart.Tax.ToString("0.00");
                lblTotalValue.Text = "$" + clsPublicData.currentUserCart.Total.ToString("0.00");
                
                lblCouponInfo.Text = $"Coupon Applied: {clsPublicData.discount.DicountCode}";
                lblCouponInfo.ForeColor = Color.DarkGreen;
            }
            else
            {
                lblCouponInfo.Text = "Invalid Coupon.";
                lblCouponInfo.ForeColor = Color.Red;
            }
        }
    }
}
