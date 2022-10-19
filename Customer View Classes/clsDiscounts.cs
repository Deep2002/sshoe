using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Customer_View_Classes
{
    public class clsDiscounts
    {
        public string DicountID { get; set; }
        public string DicountCode { get; set; }
        public string ExpirationDate { get; set; }
        public string InventoryID { get; set; }
        public int DicountType { get; set; }

        public string DicountAmount { get; set; }
        public string DicountPercentage { get; set; }
    }
}
