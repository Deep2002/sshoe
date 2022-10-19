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
        public int intID;
        public string strName;
        public string strDescription;
        public int intCategoryID;
        public decimal decReatailPrice;
        public decimal decCost;
        public int intQuantity;
        public int intRestockThreashold;
        public int intDicontinued; // true or false as 0 or 1
        public byte[] byteImage; // var binary image to byte image
        public List<clsShoeSize> lstSizes = new List<clsShoeSize>();
        #endregion

        #region Other Variables
        // this will be really helpful.
        // We do not have to go through array every time.
        // And locate the item through this position.
        public int intPositionInArray;
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
