using FinalProject.Customer_View_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.ManagerViewForms
{
    public partial class frmInventoryReportsSelector : Form
    {
        public frmInventoryReportsSelector()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnForSaleItems_Click(object sender, EventArgs e)
        {
            StringBuilder htmlReport = InsertIntoHTML(clsPublicData.lstInventory.FindAll(x => x.intDicontinued == 0));
            PrintReport(htmlReport);
        }

        private void btnRestockItem_Click(object sender, EventArgs e)
        {
            StringBuilder htmlReport = InsertIntoHTML(clsPublicData.lstInventory.FindAll(x => x.intQuantity <= x.intRestockThreashold));
            PrintReport(htmlReport);
        }

        private void btnAllItems_Click(object sender, EventArgs e)
        {
            StringBuilder htmlReport = InsertIntoHTML(clsPublicData.lstInventory);
            PrintReport(htmlReport);
        }

        /// <summary>
        /// Create and insert inventory data in HTML report
        /// </summary>
        /// <param name="inventoryList"></param>
        /// <returns>String Builder -- (HTML Report)</returns>
        private StringBuilder InsertIntoHTML(List<clsInventory> inventoryList)
        {

            StringBuilder strBuilder = new StringBuilder();
            StringBuilder strContent = new StringBuilder();

            string todayDate = DateTime.Now.ToString();

            /// Inventory Information
            ///
            foreach (clsInventory item in inventoryList)
            {
                strContent.AppendLine("<tr>");
                strContent.AppendLine($"<td>{item.intID}</td>");
                strContent.AppendLine($"<td>{item.strName}</td>");
                strContent.AppendLine($"<td>${item.decReatailPrice.ToString("0.00")}</td>");
                strContent.AppendLine($"<td>${item.decCost.ToString("0.00")}</td>");
                strContent.AppendLine($"<td>{item.intQuantity}</td>");
                strContent.AppendLine($"<td>{item.intRestockThreashold}</td>");
                strContent.AppendLine("</tr>");
            }


            strBuilder.AppendLine("<!DOCTYPE html>");
            strBuilder.AppendLine("<html lang=\"en\">");
            strBuilder.AppendLine("<head>");
            strBuilder.AppendLine("<meta charset=\"UTF-8\">");
            strBuilder.AppendLine("<meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">");
            strBuilder.AppendLine("<meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">");
            strBuilder.AppendLine("<link rel=\"stylesheet\" href=\"https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/css/bootstrap.min.css\" integrity=\"sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm\" crossorigin=\"anonymous\">");
            strBuilder.AppendLine("<title>Inventory Report</title>");
            strBuilder.AppendLine("</head>");
            strBuilder.AppendLine("<body>");
            strBuilder.AppendLine("<div style=\"text-align: center; padding-top: 40px\">");
            strBuilder.AppendLine("<br />");
            strBuilder.AppendLine("<h1>Inventory Report</h1>");
            strBuilder.AppendLine("<br />");
            strBuilder.AppendLine("<hr />");

            strBuilder.AppendLine($"<p style=\"color: gray\">Report created on: {todayDate}</p>");

            strBuilder.AppendLine("</div>");


            strBuilder.AppendLine("<table style=\"max-width: 1200px; margin-left: auto; margin-right: auto\" class=\"table table-dark table-striped table-hover\">");
            strBuilder.AppendLine("<thead>");
            strBuilder.AppendLine("<tr>");
            strBuilder.AppendLine("<th scope=\"col\">Item ID #</th>");
            strBuilder.AppendLine("<th scope=\"col\">Name</th>");
            strBuilder.AppendLine("<th scope=\"col\">Retail Price</th>");
            strBuilder.AppendLine("<th scope=\"col\">Cost</th>");
            strBuilder.AppendLine("<th scope=\"col\">Quantity</th>");
            strBuilder.AppendLine("<th scope=\"col\">Restock Threshold</th>");
            strBuilder.AppendLine("</tr>");
            strBuilder.AppendLine("</thead>");
            strBuilder.AppendLine("<tbody>");

            // Here insert all information
            strBuilder.AppendLine(strContent.ToString());
            // Content finish

            strBuilder.AppendLine("</tbody>");
            strBuilder.AppendLine("</table>");
            strBuilder.AppendLine("</body>");
            string strImagePath = Assembly.GetExecutingAssembly().CodeBase.Replace("bin/Debug/FinalProject.exe", "Resources/sshoeLogo.ico");
            strBuilder.AppendLine($"<div style=\"margin-left: auto; margin-right: auto; margin-top: 2rem; text-align: center;\"><img style = \"width: 50px; height: 50px;\" src=\"{strImagePath}\" alt=\"sshoe logo\"></div>");
            strBuilder.AppendLine("<footer><h6 style=\"text-align: center\">Sshoe reports</h6></footer>");
            strBuilder.AppendLine("</html>");
            return strBuilder;
        }

        private void PrintReport(StringBuilder html)
        {
            // Write (and overwrite) to the hard drive using the same filename of "Report.html"
            DateTime today = DateTime.Now;

            try
            {
                using (StreamWriter writer = new StreamWriter(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + $"\\{today.ToString("MM-dd-yyyy hh-mm-tt")} - Inventory Report.html"))
                {
                    writer.WriteLine(html);
                }
                System.Diagnostics.Process.Start(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + $"\\{today.ToString("MM-dd-yyyy hh-mm-tt")} - Inventory Report.html"); //Open the report in the default web browser
            }
            catch (Exception ex)
            {
                MessageBox.Show("You currently do not have write permissions for this feature.\n\n" + ex.Message,
                    "Error with System Permissions", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmInventoryReportsSelector_Load(object sender, EventArgs e)
        {
            // check if inventory already loaded
            if (clsPublicData.lstInventory == null || clsPublicData.lstInventory.Count <= 0)
            {
                // if so, load inventory
                Application.UseWaitCursor = true;
                clsSQL.LoadInventory(clsPublicData.lstInventory);
                Application.UseWaitCursor = false;
            }
        }
    }
}
