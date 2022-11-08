using FinalProject.Customer_View_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FinalProject
{
    public partial class frmPaymentInfo : Form
    {
        public frmPaymentInfo()
        {
            InitializeComponent();
        }

        private void btnContinueToCheckout_Click(object sender, EventArgs e)
        {
            #region Check if card information is field properly


            if (!clsValidation.ValidateCCNumber(tbxCardNumber.Text))
            {
                MessageBox.Show("Invalid Card Number, please type valid Card Number.", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxCardNumber.Focus();
                return;
            }
            if (dtpExpirationDate.Value < DateTime.Now)
            {
                MessageBox.Show("Invalid Expiration Date, please type valid Card Number.", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpExpirationDate.Focus();
                return;
            }
            if (tbxCVV.Text.Length < 3)
            {
                MessageBox.Show("Invalid CVV, please type valid CVV.", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxCVV.Focus();
                return;
            }
            foreach (char c in tbxCVV.Text)
            {
                if (char.IsLetter(c))
                {
                    MessageBox.Show("Invalid CVV, please type valid CVV.", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbxCVV.Focus();
                    return;
                }
            }
            #endregion

            // If everything went right show receipt and add order to the database
            if (clsSQL.PlaceOrder(tbxCardNumber.Text, dtpExpirationDate.Text, tbxCVV.Text))
            {
                // Show HTML 
                ShowHtmlReceipt();
                MessageBox.Show("Thank you for ordering with us :)", "Order Placed.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // clear cart
                clsPublicData.currentUserCart = new clsUserCart();
                this.Close();
            }
            else
            {
                this.Close();
            }
        }

        private void ShowHtmlReceipt()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.AppendLine("<!DOCTYPE html>");
            strBuilder.AppendLine("<html lang=\"en\">");
            strBuilder.AppendLine("<head>");
            strBuilder.AppendLine("<meta charset=\"UTF-8\">");
            strBuilder.AppendLine("<meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">");
            strBuilder.AppendLine("<meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">");
            strBuilder.AppendLine("<link rel=\"stylesheet\" href=\"https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/css/bootstrap.min.css\" integrity=\"sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm\" crossorigin=\"anonymous\">");
            strBuilder.AppendLine("<title>Receipt</title>");
            strBuilder.AppendLine("</head>");
            strBuilder.AppendLine("<body>");
            strBuilder.AppendLine("<table class=\"table\">");
            strBuilder.AppendLine("<thead class=\"thead-dark\">");
            strBuilder.AppendLine("<tr>");
            strBuilder.AppendLine("<th scope=\"col\">#</th>");
            strBuilder.AppendLine("<th scope=\"col\">Item name</th>");
            strBuilder.AppendLine("<th scope=\"col\">Price</th>");
            strBuilder.AppendLine("<th scope=\"col\">Quantity</th>");
            strBuilder.AppendLine("<th scope=\"col\">Total Price</th>");
            strBuilder.AppendLine("</tr>");
            strBuilder.AppendLine("</thead>");
            strBuilder.AppendLine("<tbody>");

            // Go through each items
            int itemCount = 0;
            foreach (var item in clsPublicData.currentUserCart.lstUserCart)
            {

                itemCount++;
                strBuilder.AppendLine("<tr>");
                strBuilder.AppendLine($"<th scope = \"row\" >{clsPublicData.currentUserCart.TotalItems}</th>");
                strBuilder.AppendLine($"<td>{ item.inventory.strName }</td>");
                strBuilder.AppendLine($"<td>${item.inventory.decCost.ToString("0.00")}</td>");
                strBuilder.AppendLine($"<td>{ item.quantity }</td>");
                strBuilder.AppendLine($"<td>${ item.inventory.decCost * item.quantity }</td>");
                strBuilder.AppendLine("</tr>");
            }
            strBuilder.AppendLine("</tbody></table><br>");

            // Show total item, prices, etc..
            strBuilder.AppendLine("<div class=\"w-50 p-3 bg-dark\" style=\" border-style:solid; border-radius: 20px; min-width: 500px; max-width: 500px; display: flex; justify-content: space-between; color: white; margin-left: auto; margin-right: auto; font-size: large; letter-spacing: 0.01ch;\">");
            strBuilder.AppendLine("<div style=\"list-style: none;\">");
            strBuilder.AppendLine("<li style=\"color: orange;\">Name on order:</li>");
            strBuilder.AppendLine("<li style=\"color: rgb(47, 255, 54);\">Order ID#</li>");
            strBuilder.AppendLine("<li>Date</li><br>");
            strBuilder.AppendLine("<li>Total Items:</li>");
            strBuilder.AppendLine("<li>Subtotal:</li>");
            strBuilder.AppendLine("<li>Discount:</li>");
            strBuilder.AppendLine("<li>Discounted Total:</li>");
            strBuilder.AppendLine("<li>Tax (8.25%):</li>");
            strBuilder.AppendLine("<li style=\"color: orange;\">Total:</li>");
            strBuilder.AppendLine("</div>");
            strBuilder.AppendLine("<div style = \"text-align: right; list-style: none;\">");
            strBuilder.AppendLine($"<li style = \"color: orange;\">{clsPublicData.currentUser.strFirstName} {clsPublicData.currentUser.strLastName}</li>");
            strBuilder.AppendLine($"<li style = \"color: rgb(47, 255, 54);\"> {clsPublicData.currentUserCart.orderID } </li>");
            strBuilder.AppendLine($"<li> {DateTime.Now.ToString("d")} </li><br>");
            strBuilder.AppendLine($"<li> {itemCount} </li>");
            strBuilder.AppendLine($"<li> ${clsPublicData.currentUserCart.Subtotal.ToString("0.00")} </li>");
            strBuilder.AppendLine($"<li style=\"color: rgb(47, 255, 54);\"> -{clsPublicData.currentUserCart.Discount.ToString("0.00")} </li>");
            strBuilder.AppendLine($"<li> ${clsPublicData.currentUserCart.DiscountedTotal.ToString("0.00")} </li>");
            strBuilder.AppendLine($"<li> ${clsPublicData.currentUserCart.Tax.ToString("0.00")} </li>");
            strBuilder.AppendLine($"<li style = \"color: orange;\"> ${clsPublicData.currentUserCart.Total.ToString("0.00")} </li>");
            strBuilder.AppendLine("</div>");
            strBuilder.AppendLine("</div>");
            string strImagePath = Assembly.GetExecutingAssembly().CodeBase.Replace("FinalProject.exe", "sshoeLogo.ico");
            strBuilder.AppendLine($"<div style=\"margin-left: auto; margin-right: auto; margin-top: 2rem; text-align: center;\"><img style = \"width: 50px; height: 50px;\" src=\"{strImagePath}\" alt=\"sshoe logo\"><h5>Thank you for shopping with sshoe :)</h5></div>");
            strBuilder.AppendLine("</body>\r\n</html>");

            PrintReport(strBuilder);
        }

        private void PrintReport(StringBuilder html)
        {
            // Write (and overwrite) to the hard drive using the same filename of "Report.html"
            DateTime today = DateTime.Now;

            try
            {
                // A "using" statement will automatically close a file after opening it.
                // It never hurts to include a file.Close() once you are done with a file.
                using (StreamWriter writer = new StreamWriter(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + $"\\{today.ToString("MM-dd-yyyy hh-mm-tt")} - Report.html"))
                {
                    writer.WriteLine(html);
                }
                System.Diagnostics.Process.Start(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + $"\\{today.ToString("MM-dd-yyyy hh-mm-tt")} - Report.html"); //Open the report in the default web browser
            }
            catch (Exception ex)
            {
                MessageBox.Show("You currently do not have write permissions for this feature.\n\n" + ex.Message,
                    "Error with System Permissions", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbxCVV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            } else
            {
                e.Handled = true;
            }
        }
    }
}
