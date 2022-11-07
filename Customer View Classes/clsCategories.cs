using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Customer_View_Classes
{
    public class clsCategories
    {
        public int intID;
        public string strName;
        public string strDescription;

        public clsCategories(int intID, string strName, string strDescription)
        {
            this.intID = intID;
            this.strName = strName;
            this.strDescription = strDescription;
        }
    }
}
