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
using static System.Windows.Forms.AxHost;

namespace FinalProject.ManagerViewForms
{
    public partial class frmSalesReportsDateSelector : Form
    {
        List<clsOrder> ordersList = new List<clsOrder>();

        public frmSalesReportsDateSelector()
        {
            InitializeComponent();

            // load all orders
            clsSQL.LoadOrder(ordersList);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDaily_Click(object sender, EventArgs e)
        {
            // ask user if they want to show reports for selected start date
            if (MessageBox.Show($"Do you want to see report for the day {dtpStartDate.Value.Date.ToString("MM/dd/yyyy")}?\n\nIf not please select from starting date.", "Creating Reports..", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // get only orders by selected date
                StringBuilder htmlReport = InsertIntoHTML(ordersList.FindAll(x => Convert.ToDateTime(x.orderDate).ToString("d") == dtpStartDate.Value.ToString("d")), dtpStartDate.Value.ToString("d"), dtpStartDate.Value.ToString("d"));
                PrintReport(htmlReport);
            }
        }

        private void btnWeekly_Click(object sender, EventArgs e)
        {
            // ask user if they want to show reports for selected start date
            if (MessageBox.Show($"Do you want to see report for week of {dtpStartDate.Value.ToString("D")}?\n\nIf not please select from starting date.", "Creating Reports..", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                DateTime stDate = DateTime.Now, endDate = DateTime.Now;

                stDate = SetStartAndEndWeekDate(dtpStartDate.Value.Date)[0,0];
                endDate = SetStartAndEndWeekDate(dtpStartDate.Value.Date)[0,1];

                // get only orders by selected date
                StringBuilder htmlReport = InsertIntoHTML(ordersList.FindAll(x => Convert.ToDateTime(x.orderDate) >= stDate && Convert.ToDateTime(x.orderDate) <= endDate), stDate.ToString("d"), endDate.ToString("d"), "normal");
                PrintReport(htmlReport);
            }
        }

        private void btnMonthly_Click(object sender, EventArgs e)
        {
            // ask user if they want to show reports for selected start date
            if (MessageBox.Show($"Do you want to see report for month {dtpStartDate.Value.ToString("M/yy")}?\n\nIf not please select from starting date.", "Creating Reports..", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // get only orders by selected date
                StringBuilder htmlReport = InsertIntoHTML(ordersList.FindAll(x => Convert.ToDateTime(x.orderDate).ToString("MM-yyyy") == dtpStartDate.Value.ToString("MM-yyyy")), dtpStartDate.Value.ToString("MMMM, yyyy"), dtpStartDate.Value.ToString("d"), "month");
                PrintReport(htmlReport);
            }
        }

        /// <summary>
        /// Function that return selected date week's start date (Sunday) and end date (Saturday)
        /// </summary>
        /// <param name="selectedDate"></param>
        /// <returns></returns>
        static DateTime[,] SetStartAndEndWeekDate(DateTime selectedDate)
        {

            DateTime startDate = DateTime.Now, endDate = DateTime.Now;

            string[,] days = new string[,]
            {
                { "Sunday", "1" },
                { "Monday", "2" },
                { "Tuesday", "3" },
                { "Wednesday", "4" },
                { "Thursday", "5"},
                { "Friday", "6" },
                { "Saturday", "7" }
            };

            string selectedDay = selectedDate.ToString("dddd");
            
            for (int i = 0; i < days.Length; i++)
            {
                if (days[i, 0] == selectedDay)
                {
                    int stDiff = Convert.ToInt32(days[i, 1]) - 1;
                    int endDiff = 7 - Convert.ToInt32(days[i, 1]);

                    startDate = selectedDate.AddDays(-stDiff);
                    endDate = selectedDate.AddDays(endDiff);

                    return new DateTime[,] { { startDate, endDate } };
                }
            }

            return new DateTime[,] { { startDate, endDate } };
        }

        /// <summary>
        /// Method to dynamically generate html reports
        /// </summary>
        /// <param name="orders"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        private StringBuilder InsertIntoHTML(List<clsOrder> orders, string startDate, string endDate, string dateType="normal")
        {

            StringBuilder strBuilder = new StringBuilder();
            StringBuilder strContent = new StringBuilder();

            string todayDate = DateTime.Now.ToString();

            double totalSales = 0;
            foreach (clsOrder order in orders)
            {
                strContent.AppendLine("<tr>");
                strContent.AppendLine($"<td>{order.orderID}</td>");
                strContent.AppendLine($"<td>{order.totalQantity}</td>");
                strContent.AppendLine($"<td>{Convert.ToDateTime(order.orderDate).ToString("d")}</td>");
                strContent.AppendLine($"<td>${Convert.ToDouble(order.orderTotal).ToString("0.00")}</td>");
                strContent.AppendLine("</tr>");

                totalSales += Convert.ToDouble(order.orderTotal);
            }


            strBuilder.AppendLine("<!DOCTYPE html>");
            strBuilder.AppendLine("<html lang=\"en\">");
            strBuilder.AppendLine("<head>");
            strBuilder.AppendLine("<meta charset=\"UTF-8\">");
            strBuilder.AppendLine("<meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">");
            strBuilder.AppendLine("<meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">");
            strBuilder.AppendLine("<link rel=\"stylesheet\" href=\"https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/css/bootstrap.min.css\" integrity=\"sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm\" crossorigin=\"anonymous\">");
            strBuilder.AppendLine("<title>Sales Report</title>");
            strBuilder.AppendLine("</head>");
            strBuilder.AppendLine("<body>");
            strBuilder.AppendLine("<div style=\"text-align: center; padding-top: 40px\">");
            strBuilder.AppendLine("<br />");
            strBuilder.AppendLine("<h1>Sales Report</h1>");
            strBuilder.AppendLine("<br />");
            strBuilder.AppendLine("<hr />");
            strBuilder.AppendLine($"<h2 style=\"color: green\">${totalSales.ToString("0.00")}</h2>");
            strBuilder.AppendLine($"<h4 style=\"color: rgb(62, 62, 62)\">Total Revenue</h4>");
            strBuilder.AppendLine("<hr />");

            if (dateType == "normal")
                strBuilder.AppendLine($"<p style=\"color: gray\">Starting date: {startDate} &nbsp; &nbsp; &nbsp; End date: {endDate} &nbsp; &nbsp; &nbsp; Report created on: {todayDate}</p>");
            else if (dateType == "month")
                strBuilder.AppendLine($"<p style=\"color: gray\">Month: {startDate} &nbsp; &nbsp; &nbsp; Report created on: {todayDate}</p>");
            
            strBuilder.AppendLine("</div>");


            strBuilder.AppendLine("<table style=\"max-width: 1200px; margin-left: auto; margin-right: auto\" class=\"table table-dark table-striped table-hover\">");
            strBuilder.AppendLine("<thead>");
            strBuilder.AppendLine("<tr>");
            strBuilder.AppendLine("<th scope=\"col\">Order ID #</th>");
            strBuilder.AppendLine("<th scope=\"col\">Total Items</th>");
            strBuilder.AppendLine("<th scope=\"col\">Order Date</th>");
            strBuilder.AppendLine("<th scope=\"col\">Order total</th>");
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
                using (StreamWriter writer = new StreamWriter(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + $"\\{today.ToString("MM-dd-yyyy hh-mm-tt")} - Sales Report.html"))
                {
                    writer.WriteLine(html);
                }
                System.Diagnostics.Process.Start(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + $"\\{today.ToString("MM-dd-yyyy hh-mm-tt")} - Sales Report.html"); //Open the report in the default web browser
            }
            catch (Exception ex)
            {
                MessageBox.Show("You currently do not have write permissions for this feature.\n\n" + ex.Message,
                    "Error with System Permissions", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelectedDate_Click(object sender, EventArgs e)
        {
            StringBuilder htmlReport = InsertIntoHTML(ordersList.FindAll(x => Convert.ToDateTime(x.orderDate) >= dtpStartDate.Value && Convert.ToDateTime(x.orderDate) <= dtpEndDate.Value), dtpStartDate.Value.ToString("d"), dtpEndDate.Value.ToString("d"), "normal");
            PrintReport(htmlReport);
        }

        private void mnuMenuHelp_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\Resources\HelpFile\help_file.html");
            System.Diagnostics.Process.Start(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\Resources\HelpFile\managerHelpFiles\help_file.html");

        }
    }
}
