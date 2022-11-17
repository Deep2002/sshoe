using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Customer_View_Classes
{
    internal class clsGender
    {
        public int id { get; set; }
        public string gender { get; set; }

        public clsGender(int id, string gender)
        {
            this.id = id;
            this.gender = gender;
        }
    }
}
