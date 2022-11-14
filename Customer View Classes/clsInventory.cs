using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Customer_View_Classes
{
    public class clsInventory
    {
        #region Inventory variables
        public int intID { get; set; }
        public string strName { get; set; }
        public string strDescription { get; set; }
        public decimal decReatailPrice { get; set; }
        public decimal decCost { get; set; }
        public int intQuantity { get; set; }
        public int intRestockThreashold { get; set; }
        public int intGenderID { get; set; }
        public int intBrandID { get; set; }
        public int intCategoryID { get; set; }
        public int intDicontinued { get; set; }
        public byte[] byteImage { get; set; }
        public string strGender { get; set; }
        public string strBrand { get; set; }
        public string strCategory { get; set; }

        public List<clsShoeSize> lstSizes = new List<clsShoeSize>();
        #endregion
    }

    public class clsShoeSize
    {
        public string strSize { get; set; }
        public int intQuantity { get; set; }

        public clsShoeSize(string strSize, int intQuantity)
        {
            this.strSize = strSize;
            this.intQuantity = intQuantity;
        }

        public clsShoeSize()
        {
        }
    }
}
