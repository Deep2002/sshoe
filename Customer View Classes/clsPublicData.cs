using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Customer_View_Classes
{
    internal class clsPublicData
    {
        /// <summary>
        /// All of these data can be used thorough this application.
        /// </summary>
        public static Person currentUser = null;
        public static List<clsInventory> lstInventory = new List<clsInventory>();
        public static List<clsCategories> lstCategory = new List<clsCategories>();
        public static List<Button> lstActiveCategoryTags = new List<Button>();
        public static clsUserCart currentUserCart = new clsUserCart();
        public static clsDiscounts discount = new clsDiscounts();
    }
}
