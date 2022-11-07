using FinalProject.Customer_View_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class frmItemDoesNotExistsErorr : Form
    {
        private clsItem item;

        public frmItemDoesNotExistsErorr()
        {
            
        }

        public frmItemDoesNotExistsErorr(clsItem item)
        {
            this.item = item;
            InitializeComponent();
        }

        private void frmItemDoesNotExistsErorr_Load(object sender, EventArgs e)
        {
            using (MemoryStream ms = new MemoryStream(item.inventory.byteImage))
                pbxImage.Image = Image.FromStream(ms);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
