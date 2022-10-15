using FinalProject.Customer_View_Classes;
using FinalProject.Properties;
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
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace FinalProject
{
    public partial class frmCustomerView : Form
    {
        public frmCustomerView()
        {
            InitializeComponent();
        }

        private void pbxImage_Click(object sender, EventArgs e)
        {
            new frmItemDetailedInfo().Show();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            new frmCheckoutView().Show();
        }

        private void frmCustomerView_Load(object sender, EventArgs e) 
        {
            // load categories into the list
            clsSQL.LoadCategories(clsPublicData.lstCategory);

            // once categories loaded 
            // now load all onto the form
            string strDefalutSelectedButtonText = "Top selling";
            foreach(var category in clsPublicData.lstCategory)
            {
                #region Button Styling and naming
                Button btnTag = new Button();
                btnTag.Text = category.strName;
                btnTag.Name = category.intID.ToString();
                if (btnTag.Text == strDefalutSelectedButtonText)
                {
                    btnTag.BackColor = Color.DodgerBlue;
                    btnTag.ForeColor = Color.White;
                    clsPublicData.lstActiveCategoryTags.Add(btnTag);
                }
                else
                {
                    btnTag.BackColor = Color.White;
                }
                btnTag.Font = new Font("Verdana", 12F);
                btnTag.Location = new Point(10, 18);
                btnTag.Margin = new Padding(10, 3, 10, 3);
                btnTag.RightToLeft = RightToLeft.Yes;
                btnTag.MinimumSize = new Size(100, 28);
                btnTag.AutoSize = true;
                btnTag.Height = 28;
                btnTag.UseVisualStyleBackColor = false;
                #endregion

                // Add Some functionality
                btnTag.Click += new EventHandler(delegate (Object o, EventArgs a)
                {
                    if (btnTag.BackColor == Color.DodgerBlue)
                    {
                        // set button to inactive state
                        btnTag.BackColor = Color.White;
                        btnTag.ForeColor = Color.Black;
                        //
                        clsPublicData.lstActiveCategoryTags.Remove(btnTag);
                    } else
                    {
                        // set button to active state
                        btnTag.BackColor = Color.DodgerBlue;
                        btnTag.ForeColor = Color.White;
                        //
                        clsPublicData.lstActiveCategoryTags.Add(btnTag);
                    }

                });

                // Adding it to the categories flow layout panel
                flpCategoryTags.Controls.Add(btnTag);
            }

            // load Inventory
            clsSQL.LoadInventory(clsPublicData.lstInventory);

            // load sizes
            clsSQL.LoadSizes(clsPublicData.lstInventory);
        
            //
            // Display Items onto the form
            foreach (clsInventory inventory in clsPublicData.lstInventory)
            {
                // creating item card 
                Panel itemCard = new Panel();
                itemCard.BackColor = Color.White;
                itemCard.BorderStyle = BorderStyle.FixedSingle;
                itemCard.Location = new Point(20, 20);
                itemCard.Margin = new Padding(10);
                itemCard.Size = new Size(201, 296);

                // create image
                PictureBox itemImage = new PictureBox();
                using (MemoryStream ms = new MemoryStream(inventory.byteImage))
                itemImage.Image = Image.FromStream(ms);
                itemImage.Cursor = Cursors.Hand;
                itemImage.Dock = DockStyle.Top;
                itemImage.Location = new Point(0, 0);
                itemImage.MinimumSize = new Size(200, 100);
                itemImage.Size = new Size(200, 150);
                itemImage.SizeMode = PictureBoxSizeMode.Zoom;
                

                // create Information panel
                Panel informationPanel = new Panel();
                informationPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
                informationPanel.Location = new System.Drawing.Point(0, 153);
                informationPanel.Padding = new System.Windows.Forms.Padding(5);
                informationPanel.Size = new System.Drawing.Size(199, 141);

                // create name and price label
                Label lblItemName = new Label();
                Label lblItemPrice = new Label();

                #region Name Label Style
                lblItemName.Dock = System.Windows.Forms.DockStyle.Top;
                lblItemName.Font = new System.Drawing.Font("Verdana", 12F);
                lblItemName.Location = new System.Drawing.Point(5, 5);
                lblItemName.Margin = new System.Windows.Forms.Padding(5);
                lblItemName.Size = new System.Drawing.Size(189, 73);
                lblItemName.Text = inventory.strName;
                lblItemName.AutoEllipsis = true;
                #endregion
                #region Price Label style
                lblItemPrice.BackColor = System.Drawing.Color.Transparent;
                lblItemPrice.Font = new System.Drawing.Font("Verdana", 12F);
                lblItemPrice.ForeColor = System.Drawing.Color.DarkGreen;
                lblItemPrice.Location = new System.Drawing.Point(5, 78);
                lblItemPrice.Margin = new System.Windows.Forms.Padding(5);
                lblItemPrice.Name = "lblPrice";
                lblItemPrice.Size = new System.Drawing.Size(189, 23);
                lblItemPrice.Text = $"Price: ${ inventory.decCost }";
                lblItemPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                #endregion

                informationPanel.Controls.Add(lblItemName);
                // Add it to the information panel
                informationPanel.Controls.Add(lblItemPrice);

                // create add to cart button then add that as well
                Button itemAddToCartButton = new Button();
                #region Button styling
                itemAddToCartButton.BackColor = System.Drawing.Color.DodgerBlue;
                itemAddToCartButton.Cursor = System.Windows.Forms.Cursors.Hand;
                itemAddToCartButton.Font = new System.Drawing.Font("Verdana", 12F);
                itemAddToCartButton.ForeColor = System.Drawing.Color.White;
                itemAddToCartButton.Location = new System.Drawing.Point(28, 109);
                itemAddToCartButton.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
                itemAddToCartButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                itemAddToCartButton.Size = new System.Drawing.Size(141, 28);
                itemAddToCartButton.Text = "Add to cart";
                #endregion


                #region When user clicks the image
                itemImage.Click += new EventHandler(delegate (object o, EventArgs a)
                {
                   new frmItemDetailedInfo(inventory).ShowDialog();
                });
                #endregion

                informationPanel.Controls.Add(itemAddToCartButton);
                itemCard.Controls.Add(itemImage);
                itemCard.Controls.Add(informationPanel);

                // add that item to the panel
                flpItemsView.Controls.Add(itemCard);
            }
        }
    }
}
