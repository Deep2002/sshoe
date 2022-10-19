using FinalProject.Customer_View_Classes;
using FinalProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
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
            if (clsPublicData.currentUser != null)
            {
                // check if cart is not empty
                if (clsPublicData.currentUserCart.lstUserCart.Count <= 0)
                {
                    MessageBox.Show("Your Cart appears empty. Please add something to the cart first.", "Empty cart",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    new frmCheckoutView().Show();
                }
            }
            else
            {
                
            }
        }

        private void frmCustomerView_Load(object sender, EventArgs e)
        {

            if (clsPublicData.currentUser != null)
                // Display user name
                lblUserFirstName.Text = $"Welcome Back, {clsPublicData.currentUser.strFirstName}";
            else
                lblUserFirstName.Text = $"Anonymous user";

            // load categories into the list
            clsSQL.LoadCategories(clsPublicData.lstCategory);

            // once categories loaded 
            // now load all onto the form
            string strDefalutSelectedButtonText = "Top selling";
            foreach (var category in clsPublicData.lstCategory)
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
                    }
                    else
                    {
                        // set button to active state
                        btnTag.BackColor = Color.DodgerBlue;
                        btnTag.ForeColor = Color.White;
                        //
                        clsPublicData.lstActiveCategoryTags.Add(btnTag);
                    }

                });

                // Adding it to the categories flow layout panel
                //flpCategoryTags.Controls.Add(btnTag);
            }

            // load Inventory
            clsSQL.LoadInventory(clsPublicData.lstInventory);

            // load sizes
            clsSQL.LoadSizes(clsPublicData.lstInventory);


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
                lblItemPrice.Text = $"Price: ${inventory.decCost}";
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


                #region When user clicks the buttons
                itemImage.Click += new EventHandler(delegate (object o, EventArgs a)
                {
                    new frmItemDetailedInfo(inventory).ShowDialog();
                    updateCartArea();
                });
                //
                //
                itemAddToCartButton.Click += new EventHandler(delegate (object o, EventArgs a)
                {
                    // check if sold out
                    if (inventory.lstSizes.Count > 0)
                    {
                        new frmSizeSelector(inventory).ShowDialog();
                        updateCartArea();
                    }
                    else
                    {
                        MessageBox.Show("Unfortunately this shoe is sold out. Please checkout other Inventory.", inventory.strName,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                });
                #endregion

                informationPanel.Controls.Add(itemAddToCartButton);
                itemCard.Controls.Add(itemImage);
                itemCard.Controls.Add(informationPanel);

                // add that item to the panel
                flpItemsView.Controls.Add(itemCard);
            }
        }

        public void updateCartArea()
        {
            flpInCartItems.Controls.Clear();

            foreach (var item in clsPublicData.currentUserCart.lstUserCart)
            {
                // create a card to display
                Panel itemCard = new Panel();
                itemCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                itemCard.Location = new System.Drawing.Point(13, 13);
                itemCard.Size = new System.Drawing.Size(213, 279);

                #region Card Designing and adding value dynamically

                // create image
                PictureBox itemImage = new PictureBox();
                using (MemoryStream ms = new MemoryStream(item.inventory.byteImage))
                    itemImage.Image = Image.FromStream(ms);
                itemImage.Dock = System.Windows.Forms.DockStyle.Top;
                itemImage.Location = new System.Drawing.Point(0, 0);
                itemImage.Size = new System.Drawing.Size(211, 148);
                itemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

                // create price label
                Label lblTotalPrice = new Label();
                lblTotalPrice.Text = $"${(item.inventory.decCost * item.quantity)}";
                lblTotalPrice.BackColor = System.Drawing.Color.Transparent;
                lblTotalPrice.Font = new System.Drawing.Font("Verdana", 12F);
                lblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
                lblTotalPrice.Location = new System.Drawing.Point(7, 160);
                lblTotalPrice.Margin = new System.Windows.Forms.Padding(5);
                lblTotalPrice.Size = new System.Drawing.Size(198, 23);
                lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                // create name label
                Label lblItemName = new Label();
                lblItemName.Text = item.inventory.strName;
                lblItemName.AutoEllipsis = true;
                lblItemName.Font = new System.Drawing.Font("Verdana", 12F);
                lblItemName.ForeColor = System.Drawing.Color.Green;
                lblItemName.Location = new System.Drawing.Point(18, 181);
                lblItemName.Margin = new System.Windows.Forms.Padding(5);
                lblItemName.Size = new System.Drawing.Size(176, 27);
                lblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                // create label size
                Label sizeLabel = new Label();
                sizeLabel.Font = new System.Drawing.Font("Verdana", 12F);
                sizeLabel.ForeColor = System.Drawing.Color.Gray;
                sizeLabel.Location = new System.Drawing.Point(14, 201);
                sizeLabel.Margin = new System.Windows.Forms.Padding(5);
                sizeLabel.Size = new System.Drawing.Size(176, 27);
                sizeLabel.Text = "Size: " + item.size.strSize;
                sizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                // create a quantity Label
                Label lblQt = new Label();
                lblQt.Font = new System.Drawing.Font("Verdana", 11F);
                lblQt.Location = new System.Drawing.Point(14, 242);
                lblQt.Size = new System.Drawing.Size(78, 18);
                lblQt.Text = "Quantity:";

                // create a quantity counter
                NumericUpDown quantityNumericUpDown = new NumericUpDown();
                quantityNumericUpDown.Value = item.quantity;
                quantityNumericUpDown.Location = new System.Drawing.Point(97, 236);
                quantityNumericUpDown.Maximum = new decimal(new int[] { item.size.intQuantity, 0, 0, 0 });
                quantityNumericUpDown.Minimum = 1;
                quantityNumericUpDown.Size = new Size(60, 30);

                // create delete button/Picture box
                PictureBox deleteButton = new PictureBox();
                deleteButton.Image = global::FinalProject.Properties.Resources.removeIconLarge;
                deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
                deleteButton.Location = new System.Drawing.Point(164, 236);
                deleteButton.Size = new System.Drawing.Size(30, 30);
                deleteButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

                #endregion


                // Delete button click
                deleteButton.Click += new EventHandler(delegate (object o, EventArgs a)
                {
                    clsPublicData.currentUserCart.DeleteItem(item);
                    updateCartArea();
                });
                // Quantity Changes
                quantityNumericUpDown.ValueChanged += new EventHandler(delegate (object o, EventArgs e)
                {
                    clsPublicData.currentUserCart.ChangeQuantity(item, quantityNumericUpDown.Value);
                    updateCartArea();
                });

                itemCard.Controls.Add(itemImage);
                itemCard.Controls.Add(lblItemName);
                itemCard.Controls.Add(sizeLabel);
                itemCard.Controls.Add(quantityNumericUpDown);
                itemCard.Controls.Add(lblTotalPrice);
                itemCard.Controls.Add(deleteButton);
                itemCard.Controls.Add(lblQt);

                flpInCartItems.Controls.Add(itemCard);
            }
            // Display subtotal and total items
            lblSubtotalPrice.Text = "$" + clsPublicData.currentUserCart.Subtotal.ToString();
            lblTotalItems.Text = "Total items: " + clsPublicData.currentUserCart.TotalItems.ToString();

        }

        private void logotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsPublicData.currentUser = null;
            clsPublicData.currentUserCart = new clsUserCart();
            this.Close();
        }
    }
}
