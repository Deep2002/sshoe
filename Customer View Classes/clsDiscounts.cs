using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Customer_View_Classes
{
    public class clsDiscounts
    {
        public string DiscountID { get; set; }
        public string DiscountCode { get; set; }
        public string Description { get; set; }
        public string StartDate { get; set; }
        public string ExpirationDate { get; set; }
        public string InventoryID { get; set; }
        public int DiscountType { get; set; } // 1 = percentage AND 0 = Dollar amount

        public string DiscountAmount { get; set; }
        public string DiscountPercentage { get; set; }
        public string DiscountLevel { get; internal set; }
    }
}
