using FinalProject.Customer_View_Classes;
using FinalProject.ManagerViewForms;
using FinalProject.Properties;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;
using static System.Resources.ResXFileRef;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using Application = System.Windows.Forms.Application;
using Image = System.Drawing.Image;

namespace FinalProject
{
    public enum FORM_TYPES { NORMAL, POINT_OF_SALES, }

    public partial class frmCustomerView : Form
    {
        public FORM_TYPES currentType;

        #region Public Layout panels
        // Create for each menu bar items
        public static FlowLayoutPanel menPanel = CreateFlowLayoutPanelForCategoriesInfromation();
        public static FlowLayoutPanel womenPanel = CreateFlowLayoutPanelForCategoriesInfromation();
        public static FlowLayoutPanel kidsPanel = CreateFlowLayoutPanelForCategoriesInfromation();
        public static FlowLayoutPanel brandsPanel = CreateFlowLayoutPanelForCategoriesInfromation();
        public static FlowLayoutPanel currentSelectedFlowLayoutPannel = menPanel;
        #endregion

        public frmCustomerView(FORM_TYPES frmType = FORM_TYPES.NORMAL)
        {
            InitializeComponent();
            this.currentType = frmType;
        }

        #region Main form functions
        private void frmCustomerView_Load(object sender, EventArgs e)
        {

            if (clsPublicData.currentUser != null)
            {
                if (clsPublicData.currentUser.strPositionID == "1000")
                {
                    clsPublicData.currentManager = clsPublicData.currentUser;
                    currentType = FORM_TYPES.POINT_OF_SALES;
                }
                // Display user name
                lblUserFirstName.Text = $"Welcome Back, {clsPublicData.currentUser.strFirstName}";
            }

            else
            {

                lblUserFirstName.Text = $"Anonymous user";
            }

            if (clsPublicData.lstInventory.Count <= 0)
            {


                // load Inventory
                clsSQL.LoadInventory(clsPublicData.lstInventory);

                // load sizes
                clsSQL.LoadSizes(clsPublicData.lstInventory);

                // load genders
                clsSQL.LoadGenders(clsPublicData.lstInventory);

                // load brands
                clsSQL.LoadBrands(clsPublicData.lstInventory);

                // load categories from database
                clsSQL.LoadCategories(clsPublicData.lstInventory);

                // set this list to currently displaying inventory
                clsPublicData.lstCurrentDisplayingInventory = clsPublicData.lstInventory;
            }

            // load category into menu bar (Not from database)
            loadCategories();
            DisplayAllItemsOnForm(clsPublicData.lstInventory);
        }
        private void frmCustomerView_FormClosing(object sender, FormClosingEventArgs e)
        {
            clsPublicData.currentUserCart = new clsUserCart();
        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsPublicData.currentUserCart = new clsUserCart();
            clsPublicData.currentManager = null;
            this.Close();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Cart area functions
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
                quantityNumericUpDown.Location = new System.Drawing.Point(97, 236);
                quantityNumericUpDown.Maximum = new decimal(new int[] { item.size.intQuantity, 0, 0, 0 });
                quantityNumericUpDown.Minimum = 1;
                quantityNumericUpDown.Size = new Size(60, 30);
                quantityNumericUpDown.Value = item.quantity;

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
        private void btnBuy_Click(object sender, EventArgs e)
        {
            // check if cart is not empty
            if (clsPublicData.currentUserCart.lstUserCart.Count <= 0)
            {
                MessageBox.Show("Your Cart appears empty. Please add something to the cart first.", "Empty cart",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {


                switch (currentType)
                {
                    case FORM_TYPES.NORMAL:
                        if(clsPublicData.currentUser == null)
                            new frmLoginOrCreateAccountQuestion().ShowDialog();
                        // see if they logged in
                        if (clsPublicData.currentUser != null)
                        {
                            lblUserFirstName.Text = $"Welcome Back, {clsPublicData.currentUser.strFirstName}";
                            new frmCheckoutView().ShowDialog();
                            updateCartArea();
                        }
                        break;

                    case FORM_TYPES.POINT_OF_SALES:
                        new frmUserManager(FORM_TYPES.POINT_OF_SALES).ShowDialog();
                        if (clsPublicData.currentUser != null)
                        {
                            MessageBox.Show($"Checking out for {clsPublicData.currentUser.strFirstName} {clsPublicData.currentUser.strLastName}.", "Sshoe",MessageBoxButtons.OK, MessageBoxIcon.Information);
                            new frmCheckoutView().ShowDialog();
                            clsPublicData.currentUser = clsPublicData.currentManager;
                            updateCartArea();
                        }
                        break;
                }
            }
        }
        #endregion

        #region Loading and other functions
        public void DisplayAllItemsOnForm(List<clsInventory> lstInventory, bool applyToCurrentDisplayingList = true)
        {
            if (applyToCurrentDisplayingList) clsPublicData.lstCurrentDisplayingInventory = lstInventory;

            flpItemsView.Controls.Clear();
            // Display Items onto the form
            foreach (clsInventory inventory in lstInventory)
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
        private void loadCategories()
        {

            List<String> lstMenCategoryList = new List<string> {
                "Running",
                "Basketball",
                "Jordan",
                "Training",
                "Soccer",
                "Golf",
                "Tennis",
                "Walking",
                "Baseball",
                "Football",
                "Sandals & Slides",
                "Track and Field",
                "Cross Country",
                "Sustainable Materials",
                "Fashion",
            };
            List<String> lstWomenCategoryList = new List<string> {
                "Sneakers & Athletic",
                "Sandals",
                "Clogs & Mules",
                "Heels",
                "Boots",
                "Slippers",
                "Flats",
                "Loafers",
                "Comfort",
                "Wide",
                "Narrow",
                "Single Shoes"
            };
            List<String> lstKidsCategoryList = new List<string>
            {
                "Girls",
                "Boys",
            };
            List<String> lstBrandsCategoryList = new List<string>
            {
                "Nike",
                "Adidas",
                "Converse",
                "Reebok",
                "Vans",
                "New Balance",
                "Puma",
                "Jordan",
                "On",
                "Frye",
                "Brooks",
                "Sam Edelman",
                "Hunter",
                "Sorel",
                "UGG®",
                "Docle",
                "Lana",
                "Guess",
                "Unknown",
            };

            lstBrandsCategoryList = lstBrandsCategoryList.OrderBy(x => x).ToList();

            foreach (string category in lstMenCategoryList)
            {
                Label label = new Label();
                label.AutoSize = true;
                label.Cursor = Cursors.Hand;
                label.Size = new System.Drawing.Size(63, 24);
                label.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label.Padding = new System.Windows.Forms.Padding(10);
                label.Text = category;

                // make it click
                label.Click += new EventHandler(delegate (object o, EventArgs a)
                {

                    // get only by selected category
                    DisplayAllItemsOnForm(GetByCategory(category, GetByGender("Men")));
                    pnlCategory.Size = new Size(pnlCategory.Size.Width, 70);
                });
                menPanel.Controls.Add(label);
            }

            foreach (string category in lstWomenCategoryList)
            {
                Label label = new Label();
                label.AutoSize = true;
                label.Cursor = Cursors.Hand;
                label.Size = new System.Drawing.Size(63, 24);
                label.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label.Padding = new System.Windows.Forms.Padding(10);
                label.Text = category;

                // make it click
                label.Click += new EventHandler(delegate (object o, EventArgs a)
                {

                    // get only by selected category
                    DisplayAllItemsOnForm(GetByCategory(category, GetByGender("Women")));
                    pnlCategory.Size = new Size(pnlCategory.Size.Width, 70);
                });
                womenPanel.Controls.Add(label);
            }

            foreach (string category in lstKidsCategoryList)
            {
                Label label = new Label();
                label.AutoSize = true;
                label.Cursor = Cursors.Hand;
                label.Size = new System.Drawing.Size(63, 24);
                label.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label.Padding = new System.Windows.Forms.Padding(10);
                label.Text = category;

                // make it click
                kidsPanel.Controls.Add(label);
                label.Click += new EventHandler(delegate (object o, EventArgs a)
                {
                    DisplayAllItemsOnForm(GetByGender(category));
                    pnlCategory.Size = new Size(pnlCategory.Size.Width, 70);
                });
            }

            foreach (string category in lstBrandsCategoryList)
            {
                Label label = new Label();
                label.AutoSize = true;
                label.Cursor = Cursors.Hand;
                label.Size = new System.Drawing.Size(63, 24);
                label.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label.Padding = new System.Windows.Forms.Padding(10);
                label.Text = category;

                // make it click
                label.Click += new EventHandler(delegate (object o, EventArgs a)
                {
                    DisplayAllItemsOnForm(GetByBrands(category));
                    pnlCategory.Size = new Size(pnlCategory.Size.Width, 70);
                });

                brandsPanel.Controls.Add(label);
            }

            pnlSelectedCategoryInformation.Controls.Add(menPanel);
        }
        #endregion

        #region Nav bar labels click functions/ events
        public static FlowLayoutPanel CreateFlowLayoutPanelForCategoriesInfromation()
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            panel.Dock = System.Windows.Forms.DockStyle.Fill;
            panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            panel.Location = new System.Drawing.Point(0, 0);
            panel.Padding = new System.Windows.Forms.Padding(20);
            panel.Size = new System.Drawing.Size(1465, 331);

            return panel;
        }
        private void lblMen_Click(object sender, EventArgs e)
        {
            extendOrShrinkMenuBar(menPanel);
            lblMen.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DisplayAllItemsOnForm(GetByGender("Men"), true);
        }
        private void lblWomen_Click(object sender, EventArgs e)
        {
            extendOrShrinkMenuBar(womenPanel);
            lblWomen.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DisplayAllItemsOnForm(GetByGender("Women"));
        }
        private void lblKids_Click(object sender, EventArgs e)
        {
            extendOrShrinkMenuBar(kidsPanel);
            lblKids.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            List<clsInventory> boysList = GetByGender("Boys");
            List<clsInventory> girlsList = GetByGender("Girls");
            boysList.AddRange(girlsList);
            DisplayAllItemsOnForm(boysList);
        }
        private void lblBrands_Click(object sender, EventArgs e)
        {
            extendOrShrinkMenuBar(brandsPanel);
            lblBrands.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
        private void lblShowAll_Click(object sender, EventArgs e)
        {
            pnlCategory.Size = new Size(pnlCategory.Size.Width, 70);
            DisplayAllItemsOnForm(clsPublicData.lstInventory, true);
            clearNavBarFontsUnderLine();
            lblShowAll.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
        #endregion

        #region Other nav bar functions
        private void clearNavBarFontsUnderLine()
        {
            Font normalFont = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblShowAll.Font = normalFont;
            lblMen.Font = normalFont;
            lblWomen.Font = normalFont;
            lblKids.Font = normalFont;
            lblBrands.Font = normalFont;
        }

        private void extendOrShrinkMenuBar(FlowLayoutPanel pnl)
        {
            if (currentSelectedFlowLayoutPannel == pnl && pnlCategory.Size.Height == 400)
            {
                pnlCategory.Size = new Size(pnlCategory.Size.Width, 70);
                return;
            }
            if (pnlCategory.Size.Height == 70)
            {
                pnlCategory.Size = new Size(pnlCategory.Size.Width, 400);
            }
            pnlSelectedCategoryInformation.Controls.Clear();
            pnlSelectedCategoryInformation.Controls.Add(pnl);
            clearNavBarFontsUnderLine();
            currentSelectedFlowLayoutPannel = pnl;
        }
        #endregion

        #region Functions to filter/get by different things
        public static List<clsInventory> GetByGender(string strGenderName)
        {
            return clsPublicData.lstInventory.FindAll(x => x.strGender == strGenderName).ToList();
        }
        public static List<clsInventory> GetByBrands(string strBrandName)
        {
            return clsPublicData.lstInventory.FindAll(x => x.strBrand == strBrandName).ToList();
        }
        public static List<clsInventory> GetByCategory(string strCategoryName, List<clsInventory> lst)
        {
            return lst.FindAll(x => x.strCategory == strCategoryName).ToList();
        }
        public static List<clsInventory> GetByPrices(decimal minPrice, decimal maxPrice, List<clsInventory> lst)
        {
            return lst.FindAll(x => x.decCost >= minPrice && x.decCost <= maxPrice).OrderBy(x => x.decCost).ToList();
        }
        public static List<clsInventory> GetBySearchString(string searchString, List<clsInventory> lst)
        {
            return lst.Where(x => x.strName.ToLower().Contains(searchString.ToLower()) || x.strBrand.ToLower().Contains(searchString.ToLower()) || x.strDescription.ToLower().Contains(searchString.ToLower())).ToList();
        }
        public static List<clsInventory> GetByMinMaxShoeSize(double selectedSize, List<clsInventory> lst)
        {
            List<clsInventory> tempList = new List<clsInventory>();

            tempList = lst.FindAll(
                    x => x.lstSizes.FindAll(y => Convert.ToDouble(y.strSize) == selectedSize).Count > 0
                ).ToList();

            return tempList;
        }
        #endregion

        #region Filter Panel Buttons Click functions, etc
        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            List<clsInventory> temp = null;

            // check if user have entered correct price range
            if (cbxPriceSelector.Items.Contains(cbxPriceSelector.Text))
            {

                #region Parse selected string to decimal, so that I can pass into function.
                string[] strSplit = cbxPriceSelector.Text.Replace(" ", "").Split('-');
                decimal priceMin, priceMax;

                strSplit[0] = strSplit[0].Remove(0, 1) + ".00";

                priceMin = Convert.ToDecimal(strSplit[0]);
                if (strSplit[1] != "Above")
                {
                    strSplit[1] = strSplit[1].Remove(0, 1) + ".00";
                    priceMax = Convert.ToDecimal(strSplit[1]);
                }
                else
                {
                    priceMax = 10000;
                }
                #endregion

                // get what is currently displaying on to the screen
                // then find all by prices, then set it back
                temp = GetByPrices(priceMin, priceMax, clsPublicData.lstCurrentDisplayingInventory);
            }


            if (cbxSizeSelector.Items.Contains(cbxSizeSelector.Text))
            {
                // by sizes
                if (temp != null)
                    temp = GetByMinMaxShoeSize(Convert.ToDouble(cbxSizeSelector.Text), temp);
                else
                    temp = GetByMinMaxShoeSize(Convert.ToDouble(cbxSizeSelector.Text), clsPublicData.lstCurrentDisplayingInventory);
            }



            // Update user screen
            if (temp != null)
            {
                lblFilterAppliedOrNot.Text = "Filter Applied!";
                lblFilterAppliedOrNot.ForeColor = Color.Green;
                DisplayAllItemsOnForm(temp, false);

            }
            else
            {
                lblFilterAppliedOrNot.Text = "Filter not applied!";
                lblFilterAppliedOrNot.ForeColor = Color.Red;
            }

            lblFilterAppliedOrNot.Visible = true;
        }
        private void cbxPriceSelector_Leave(object sender, EventArgs e)
        {
            if (!cbxPriceSelector.Items.Contains(cbxPriceSelector.Text))
            {
                cbxPriceSelector.Text = "Select Price";
            }
        }
        private void cbxSizeSelector_Leave(object sender, EventArgs e)
        {
            if (!cbxSizeSelector.Items.Contains(cbxSizeSelector.Text))
            {
                cbxSizeSelector.Text = "Select Size";
            }
        }
        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            cbxSizeSelector.Text = "Select Size";
            cbxPriceSelector.Text = "Select Price";
            lblFilterAppliedOrNot.Text = "Filter Cleared!";
            lblFilterAppliedOrNot.ForeColor = Color.DodgerBlue;
            lblFilterAppliedOrNot.Visible = true;

            DisplayAllItemsOnForm(clsPublicData.lstCurrentDisplayingInventory);
        }
        private void btnHideShowFilter_Click(object sender, EventArgs e)
        {

            if (!splitContainer2.Panel1Collapsed)
            {
                splitContainer2.Panel1Collapsed = true;
                btnHideShowFilter.Text = "Show Filter";
            }
            else
            {
                splitContainer2.Panel1Collapsed = false;
                btnHideShowFilter.Text = "Hide Filter";
            }
        }
        #endregion

        #region Search-bar functions
        private void tbxSearchBar_TextChanged(object sender, EventArgs e)
        {
            if (tbxSearchBar.Text != null && tbxSearchBar.Text != "Search Products..")
            {
                DisplayAllItemsOnForm(GetBySearchString(tbxSearchBar.Text, clsPublicData.lstInventory));
            }
        }
        private void tbxSearchBar_Enter(object sender, EventArgs e)
        {
            tbxSearchBar.Text = "";
        }
        private void tbxSearchBar_Leave(object sender, EventArgs e)
        {
            if (tbxSearchBar.Text == "")
            {
                tbxSearchBar.Text = "Search Products..";
            }
        }
        #endregion

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\Resources\HelpFile\help_file.html");
        }
    }
}
