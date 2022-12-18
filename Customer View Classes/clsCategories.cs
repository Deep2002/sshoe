using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Customer_View_Classes
{
    public class clsCategories
    {
        public int intID { get; set; }
        public string strName { get; set; }
        public string strDescription { get; set; }


        public clsCategories(int intID, string strName)
        {
            this.intID = intID;
            this.strName = strName;
        }
    }
}
