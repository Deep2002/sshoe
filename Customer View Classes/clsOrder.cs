using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Customer_View_Classes
{
    internal class clsOrder
    {
        public string orderID { get; set; }
        public string totalQantity { get; set; }
        public string orderDate { get; set; }
        public string orderTotal { get; set; }

        public clsOrder(string orderID, string totalQantity, string orderDate, string orderTotal)
        {
            this.orderID = orderID;
            this.totalQantity = totalQantity;
            this.orderDate = orderDate;
            this.orderTotal = orderTotal;
        }

        public clsOrder()
        {
        }
    }
}
