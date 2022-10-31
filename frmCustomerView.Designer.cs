namespace FinalProject
{
    partial class frmCustomerView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerView));
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.lblUserFirstName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLookingForSomething = new System.Windows.Forms.Label();
            this.tbxSearchBar = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlMainView = new System.Windows.Forms.Panel();
            this.flpItemsView = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlCart = new System.Windows.Forms.Panel();
            this.flpInCartItems = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSubtotal = new System.Windows.Forms.Panel();
            this.btnBuy = new System.Windows.Forms.Button();
            this.lblTotalItems = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblSubtotalPrice = new System.Windows.Forms.Label();
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlCategory = new System.Windows.Forms.Panel();
            this.pnlSelectedCategoryInformation = new System.Windows.Forms.Panel();
            this.pnlCategories = new System.Windows.Forms.Panel();
            this.btnHideShowFilter = new System.Windows.Forms.Button();
            this.lblShowAll = new System.Windows.Forms.Label();
            this.lblBrands = new System.Windows.Forms.Label();
            this.lblKids = new System.Windows.Forms.Label();
            this.lblWomen = new System.Windows.Forms.Label();
            this.lblMen = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.pnlFilterPanel = new System.Windows.Forms.Panel();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.lblSizeSelectorInfo = new System.Windows.Forms.Label();
            this.cbxPriceSelector = new System.Windows.Forms.ComboBox();
            this.lblFilterAppliedOrNot = new System.Windows.Forms.Label();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.cbxSizeSelector = new System.Windows.Forms.ComboBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblPrceSelectorInfo = new System.Windows.Forms.Label();
            this.lblPriceRange = new System.Windows.Forms.Label();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlMainView.SuspendLayout();
            this.pnlCart.SuspendLayout();
            this.pnlSubtotal.SuspendLayout();
            this.mnuMenu.SuspendLayout();
            this.pnlCategory.SuspendLayout();
            this.pnlCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.pnlFilterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pnlSearch.Controls.Add(this.lblUserFirstName);
            this.pnlSearch.Controls.Add(this.pictureBox1);
            this.pnlSearch.Controls.Add(this.lblLookingForSomething);
            this.pnlSearch.Controls.Add(this.tbxSearchBar);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 31);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1635, 66);
            this.pnlSearch.TabIndex = 0;
            // 
            // lblUserFirstName
            // 
            this.lblUserFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserFirstName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUserFirstName.Font = new System.Drawing.Font("Verdana", 11F);
            this.lblUserFirstName.ForeColor = System.Drawing.Color.Maroon;
            this.lblUserFirstName.Location = new System.Drawing.Point(1324, 18);
            this.lblUserFirstName.Name = "lblUserFirstName";
            this.lblUserFirstName.Size = new System.Drawing.Size(248, 33);
            this.lblUserFirstName.TabIndex = 3;
            this.lblUserFirstName.Text = "Welcome back, Deep";
            this.lblUserFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::FinalProject.Properties.Resources.userProfileDefault;
            this.pictureBox1.Location = new System.Drawing.Point(1578, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblLookingForSomething
            // 
            this.lblLookingForSomething.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLookingForSomething.AutoSize = true;
            this.lblLookingForSomething.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Italic);
            this.lblLookingForSomething.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLookingForSomething.Location = new System.Drawing.Point(285, 21);
            this.lblLookingForSomething.Name = "lblLookingForSomething";
            this.lblLookingForSomething.Size = new System.Drawing.Size(312, 23);
            this.lblLookingForSomething.TabIndex = 1;
            this.lblLookingForSomething.Text = "Looking for something specific?";
            // 
            // tbxSearchBar
            // 
            this.tbxSearchBar.AllowDrop = true;
            this.tbxSearchBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxSearchBar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbxSearchBar.Location = new System.Drawing.Point(603, 18);
            this.tbxSearchBar.MaximumSize = new System.Drawing.Size(450, 30);
            this.tbxSearchBar.Name = "tbxSearchBar";
            this.tbxSearchBar.Size = new System.Drawing.Size(450, 30);
            this.tbxSearchBar.TabIndex = 0;
            this.tbxSearchBar.Text = "Search Products..";
            this.tbxSearchBar.TextChanged += new System.EventHandler(this.tbxSearchBar_TextChanged);
            this.tbxSearchBar.Enter += new System.EventHandler(this.tbxSearchBar_Enter);
            this.tbxSearchBar.Leave += new System.EventHandler(this.tbxSearchBar_Leave);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pnlMainView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnlCart);
            this.splitContainer1.Size = new System.Drawing.Size(1405, 681);
            this.splitContainer1.SplitterDistance = 1121;
            this.splitContainer1.TabIndex = 2;
            // 
            // pnlMainView
            // 
            this.pnlMainView.Controls.Add(this.flpItemsView);
            this.pnlMainView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainView.Location = new System.Drawing.Point(0, 0);
            this.pnlMainView.Name = "pnlMainView";
            this.pnlMainView.Size = new System.Drawing.Size(1121, 681);
            this.pnlMainView.TabIndex = 0;
            // 
            // flpItemsView
            // 
            this.flpItemsView.AutoScroll = true;
            this.flpItemsView.BackColor = System.Drawing.SystemColors.Control;
            this.flpItemsView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpItemsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpItemsView.Location = new System.Drawing.Point(0, 0);
            this.flpItemsView.Margin = new System.Windows.Forms.Padding(0);
            this.flpItemsView.Name = "flpItemsView";
            this.flpItemsView.Padding = new System.Windows.Forms.Padding(10);
            this.flpItemsView.Size = new System.Drawing.Size(1121, 681);
            this.flpItemsView.TabIndex = 0;
            // 
            // pnlCart
            // 
            this.pnlCart.Controls.Add(this.flpInCartItems);
            this.pnlCart.Controls.Add(this.pnlSubtotal);
            this.pnlCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCart.Location = new System.Drawing.Point(0, 0);
            this.pnlCart.Name = "pnlCart";
            this.pnlCart.Size = new System.Drawing.Size(280, 681);
            this.pnlCart.TabIndex = 0;
            // 
            // flpInCartItems
            // 
            this.flpInCartItems.AutoScroll = true;
            this.flpInCartItems.BackColor = System.Drawing.Color.White;
            this.flpInCartItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpInCartItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpInCartItems.Location = new System.Drawing.Point(0, 0);
            this.flpInCartItems.Name = "flpInCartItems";
            this.flpInCartItems.Padding = new System.Windows.Forms.Padding(10, 10, 10, 20);
            this.flpInCartItems.Size = new System.Drawing.Size(280, 546);
            this.flpInCartItems.TabIndex = 1;
            // 
            // pnlSubtotal
            // 
            this.pnlSubtotal.BackColor = System.Drawing.Color.White;
            this.pnlSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSubtotal.Controls.Add(this.btnBuy);
            this.pnlSubtotal.Controls.Add(this.lblTotalItems);
            this.pnlSubtotal.Controls.Add(this.lblSubtotal);
            this.pnlSubtotal.Controls.Add(this.lblSubtotalPrice);
            this.pnlSubtotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSubtotal.Location = new System.Drawing.Point(0, 546);
            this.pnlSubtotal.Name = "pnlSubtotal";
            this.pnlSubtotal.Size = new System.Drawing.Size(280, 135);
            this.pnlSubtotal.TabIndex = 0;
            // 
            // btnBuy
            // 
            this.btnBuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuy.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuy.Font = new System.Drawing.Font("Verdana", 13F);
            this.btnBuy.ForeColor = System.Drawing.Color.White;
            this.btnBuy.Location = new System.Drawing.Point(69, 86);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(140, 36);
            this.btnBuy.TabIndex = 3;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // lblTotalItems
            // 
            this.lblTotalItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalItems.AutoSize = true;
            this.lblTotalItems.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalItems.Location = new System.Drawing.Point(84, 60);
            this.lblTotalItems.Name = "lblTotalItems";
            this.lblTotalItems.Size = new System.Drawing.Size(111, 18);
            this.lblTotalItems.TabIndex = 2;
            this.lblTotalItems.Text = "Total items: 0";
            this.lblTotalItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblSubtotal.Location = new System.Drawing.Point(94, 34);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(90, 23);
            this.lblSubtotal.TabIndex = 1;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // lblSubtotalPrice
            // 
            this.lblSubtotalPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSubtotalPrice.ForeColor = System.Drawing.Color.Green;
            this.lblSubtotalPrice.Location = new System.Drawing.Point(48, 11);
            this.lblSubtotalPrice.Name = "lblSubtotalPrice";
            this.lblSubtotalPrice.Size = new System.Drawing.Size(183, 23);
            this.lblSubtotalPrice.TabIndex = 0;
            this.lblSubtotalPrice.Text = "$0.00";
            this.lblSubtotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mnuMenu
            // 
            this.mnuMenu.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(1635, 31);
            this.mnuMenu.TabIndex = 3;
            this.mnuMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(56, 27);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(146, 28);
            this.logoutToolStripMenuItem.Text = "&Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 28);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(78, 27);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(123, 28);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // pnlCategory
            // 
            this.pnlCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlCategory.Controls.Add(this.pnlSelectedCategoryInformation);
            this.pnlCategory.Controls.Add(this.pnlCategories);
            this.pnlCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCategory.Location = new System.Drawing.Point(0, 97);
            this.pnlCategory.Name = "pnlCategory";
            this.pnlCategory.Size = new System.Drawing.Size(1635, 70);
            this.pnlCategory.TabIndex = 1;
            // 
            // pnlSelectedCategoryInformation
            // 
            this.pnlSelectedCategoryInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSelectedCategoryInformation.Font = new System.Drawing.Font("Trebuchet MS", 14F);
            this.pnlSelectedCategoryInformation.ForeColor = System.Drawing.Color.White;
            this.pnlSelectedCategoryInformation.Location = new System.Drawing.Point(0, 70);
            this.pnlSelectedCategoryInformation.Name = "pnlSelectedCategoryInformation";
            this.pnlSelectedCategoryInformation.Size = new System.Drawing.Size(1635, 0);
            this.pnlSelectedCategoryInformation.TabIndex = 6;
            // 
            // pnlCategories
            // 
            this.pnlCategories.Controls.Add(this.btnHideShowFilter);
            this.pnlCategories.Controls.Add(this.lblShowAll);
            this.pnlCategories.Controls.Add(this.lblBrands);
            this.pnlCategories.Controls.Add(this.lblKids);
            this.pnlCategories.Controls.Add(this.lblWomen);
            this.pnlCategories.Controls.Add(this.lblMen);
            this.pnlCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCategories.Location = new System.Drawing.Point(0, 0);
            this.pnlCategories.Name = "pnlCategories";
            this.pnlCategories.Size = new System.Drawing.Size(1635, 70);
            this.pnlCategories.TabIndex = 5;
            // 
            // btnHideShowFilter
            // 
            this.btnHideShowFilter.BackColor = System.Drawing.Color.Transparent;
            this.btnHideShowFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHideShowFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHideShowFilter.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHideShowFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnHideShowFilter.Location = new System.Drawing.Point(16, 25);
            this.btnHideShowFilter.Name = "btnHideShowFilter";
            this.btnHideShowFilter.Size = new System.Drawing.Size(173, 27);
            this.btnHideShowFilter.TabIndex = 13;
            this.btnHideShowFilter.Text = "Hide Filter";
            this.btnHideShowFilter.UseVisualStyleBackColor = false;
            this.btnHideShowFilter.Click += new System.EventHandler(this.btnHideShowFilter_Click);
            // 
            // lblShowAll
            // 
            this.lblShowAll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblShowAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblShowAll.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowAll.ForeColor = System.Drawing.Color.White;
            this.lblShowAll.Location = new System.Drawing.Point(461, 1);
            this.lblShowAll.Name = "lblShowAll";
            this.lblShowAll.Padding = new System.Windows.Forms.Padding(10);
            this.lblShowAll.Size = new System.Drawing.Size(129, 69);
            this.lblShowAll.TabIndex = 11;
            this.lblShowAll.Text = "Show All";
            this.lblShowAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblShowAll.Click += new System.EventHandler(this.lblShowAll_Click);
            // 
            // lblBrands
            // 
            this.lblBrands.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBrands.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBrands.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrands.ForeColor = System.Drawing.Color.White;
            this.lblBrands.Location = new System.Drawing.Point(1016, 0);
            this.lblBrands.Name = "lblBrands";
            this.lblBrands.Padding = new System.Windows.Forms.Padding(10);
            this.lblBrands.Size = new System.Drawing.Size(158, 69);
            this.lblBrands.TabIndex = 10;
            this.lblBrands.Text = "Brands";
            this.lblBrands.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBrands.Click += new System.EventHandler(this.lblBrands_Click);
            // 
            // lblKids
            // 
            this.lblKids.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblKids.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblKids.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKids.ForeColor = System.Drawing.Color.White;
            this.lblKids.Location = new System.Drawing.Point(886, 0);
            this.lblKids.Name = "lblKids";
            this.lblKids.Padding = new System.Windows.Forms.Padding(10);
            this.lblKids.Size = new System.Drawing.Size(129, 69);
            this.lblKids.TabIndex = 7;
            this.lblKids.Text = "Kids";
            this.lblKids.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblKids.Click += new System.EventHandler(this.lblKids_Click);
            // 
            // lblWomen
            // 
            this.lblWomen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblWomen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblWomen.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWomen.ForeColor = System.Drawing.Color.White;
            this.lblWomen.Location = new System.Drawing.Point(721, 0);
            this.lblWomen.Name = "lblWomen";
            this.lblWomen.Padding = new System.Windows.Forms.Padding(10);
            this.lblWomen.Size = new System.Drawing.Size(164, 69);
            this.lblWomen.TabIndex = 6;
            this.lblWomen.Text = "Women";
            this.lblWomen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWomen.Click += new System.EventHandler(this.lblWomen_Click);
            // 
            // lblMen
            // 
            this.lblMen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMen.BackColor = System.Drawing.Color.Transparent;
            this.lblMen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMen.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMen.ForeColor = System.Drawing.Color.White;
            this.lblMen.Location = new System.Drawing.Point(591, 0);
            this.lblMen.Name = "lblMen";
            this.lblMen.Padding = new System.Windows.Forms.Padding(10);
            this.lblMen.Size = new System.Drawing.Size(129, 69);
            this.lblMen.TabIndex = 5;
            this.lblMen.Text = "Men";
            this.lblMen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMen.Click += new System.EventHandler(this.lblMen_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 167);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.pnlFilterPanel);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Size = new System.Drawing.Size(1635, 681);
            this.splitContainer2.SplitterDistance = 226;
            this.splitContainer2.TabIndex = 4;
            // 
            // pnlFilterPanel
            // 
            this.pnlFilterPanel.BackColor = System.Drawing.SystemColors.Control;
            this.pnlFilterPanel.Controls.Add(this.btnClearFilter);
            this.pnlFilterPanel.Controls.Add(this.lblSizeSelectorInfo);
            this.pnlFilterPanel.Controls.Add(this.cbxPriceSelector);
            this.pnlFilterPanel.Controls.Add(this.lblFilterAppliedOrNot);
            this.pnlFilterPanel.Controls.Add(this.btnApplyFilter);
            this.pnlFilterPanel.Controls.Add(this.cbxSizeSelector);
            this.pnlFilterPanel.Controls.Add(this.lblSize);
            this.pnlFilterPanel.Controls.Add(this.lblPrceSelectorInfo);
            this.pnlFilterPanel.Controls.Add(this.lblPriceRange);
            this.pnlFilterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilterPanel.Location = new System.Drawing.Point(0, 0);
            this.pnlFilterPanel.Name = "pnlFilterPanel";
            this.pnlFilterPanel.Size = new System.Drawing.Size(226, 681);
            this.pnlFilterPanel.TabIndex = 0;
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.BackColor = System.Drawing.Color.Transparent;
            this.btnClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFilter.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFilter.ForeColor = System.Drawing.Color.Black;
            this.btnClearFilter.Location = new System.Drawing.Point(16, 452);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(169, 33);
            this.btnClearFilter.TabIndex = 18;
            this.btnClearFilter.Text = "&Clear filter";
            this.btnClearFilter.UseVisualStyleBackColor = false;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // lblSizeSelectorInfo
            // 
            this.lblSizeSelectorInfo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSizeSelectorInfo.Location = new System.Drawing.Point(16, 324);
            this.lblSizeSelectorInfo.Name = "lblSizeSelectorInfo";
            this.lblSizeSelectorInfo.Size = new System.Drawing.Size(169, 70);
            this.lblSizeSelectorInfo.TabIndex = 17;
            this.lblSizeSelectorInfo.Text = "Select shoe size from above to show only shoes that fits you.";
            // 
            // cbxPriceSelector
            // 
            this.cbxPriceSelector.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxPriceSelector.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxPriceSelector.FormattingEnabled = true;
            this.cbxPriceSelector.Items.AddRange(new object[] {
            "$50 - $100",
            "$100 - $200",
            "$200 - $300",
            "$300 - Above"});
            this.cbxPriceSelector.Location = new System.Drawing.Point(16, 83);
            this.cbxPriceSelector.Name = "cbxPriceSelector";
            this.cbxPriceSelector.Size = new System.Drawing.Size(165, 31);
            this.cbxPriceSelector.TabIndex = 16;
            this.cbxPriceSelector.Text = "Select Price";
            this.cbxPriceSelector.Leave += new System.EventHandler(this.cbxPriceSelector_Leave);
            // 
            // lblFilterAppliedOrNot
            // 
            this.lblFilterAppliedOrNot.AutoSize = true;
            this.lblFilterAppliedOrNot.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterAppliedOrNot.ForeColor = System.Drawing.Color.Green;
            this.lblFilterAppliedOrNot.Location = new System.Drawing.Point(16, 394);
            this.lblFilterAppliedOrNot.Name = "lblFilterAppliedOrNot";
            this.lblFilterAppliedOrNot.Size = new System.Drawing.Size(97, 16);
            this.lblFilterAppliedOrNot.TabIndex = 15;
            this.lblFilterAppliedOrNot.Text = "Filter Applied!";
            this.lblFilterAppliedOrNot.Visible = false;
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnApplyFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyFilter.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyFilter.ForeColor = System.Drawing.Color.White;
            this.btnApplyFilter.Location = new System.Drawing.Point(16, 413);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(169, 33);
            this.btnApplyFilter.TabIndex = 14;
            this.btnApplyFilter.Text = "&Apply Filter";
            this.btnApplyFilter.UseVisualStyleBackColor = false;
            this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);
            // 
            // cbxSizeSelector
            // 
            this.cbxSizeSelector.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbxSizeSelector.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxSizeSelector.FormattingEnabled = true;
            this.cbxSizeSelector.Items.AddRange(new object[] {
            "4",
            "4.5",
            "5",
            "5.5",
            "6",
            "6.5",
            "7",
            "7.5",
            "8",
            "8.5",
            "9",
            "9.5",
            "10",
            "10.5",
            "11",
            "11.5",
            "12",
            "12.5",
            "13",
            "13.5",
            "14",
            "14.5",
            "15",
            "15.5",
            "16"});
            this.cbxSizeSelector.Location = new System.Drawing.Point(16, 274);
            this.cbxSizeSelector.Name = "cbxSizeSelector";
            this.cbxSizeSelector.Size = new System.Drawing.Size(169, 31);
            this.cbxSizeSelector.TabIndex = 6;
            this.cbxSizeSelector.Text = "Size";
            this.cbxSizeSelector.Leave += new System.EventHandler(this.cbxSizeSelector_Leave);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(16, 236);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(59, 23);
            this.lblSize.TabIndex = 5;
            this.lblSize.Text = "Size:";
            // 
            // lblPrceSelectorInfo
            // 
            this.lblPrceSelectorInfo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrceSelectorInfo.Location = new System.Drawing.Point(16, 128);
            this.lblPrceSelectorInfo.Name = "lblPrceSelectorInfo";
            this.lblPrceSelectorInfo.Size = new System.Drawing.Size(169, 70);
            this.lblPrceSelectorInfo.TabIndex = 2;
            this.lblPrceSelectorInfo.Text = "Select price range from above to show shoes within selected price range.";
            // 
            // lblPriceRange
            // 
            this.lblPriceRange.AutoSize = true;
            this.lblPriceRange.Location = new System.Drawing.Point(16, 45);
            this.lblPriceRange.Name = "lblPriceRange";
            this.lblPriceRange.Size = new System.Drawing.Size(131, 23);
            this.lblPriceRange.TabIndex = 0;
            this.lblPriceRange.Text = "Price Range:";
            // 
            // frmCustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1635, 848);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.pnlCategory);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.mnuMenu);
            this.Font = new System.Drawing.Font("Verdana", 14F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMenu;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmCustomerView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCustomerView_FormClosing);
            this.Load += new System.EventHandler(this.frmCustomerView_Load);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlMainView.ResumeLayout(false);
            this.pnlCart.ResumeLayout(false);
            this.pnlSubtotal.ResumeLayout(false);
            this.pnlSubtotal.PerformLayout();
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.pnlCategory.ResumeLayout(false);
            this.pnlCategories.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.pnlFilterPanel.ResumeLayout(false);
            this.pnlFilterPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblLookingForSomething;
        private System.Windows.Forms.TextBox tbxSearchBar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pnlMainView;
        private System.Windows.Forms.Panel pnlCart;
        private System.Windows.Forms.FlowLayoutPanel flpItemsView;
        private System.Windows.Forms.Panel pnlSubtotal;
        private System.Windows.Forms.Label lblTotalItems;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblSubtotalPrice;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.FlowLayoutPanel flpInCartItems;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUserFirstName;
        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel pnlCategory;
        private System.Windows.Forms.Label lblKids;
        private System.Windows.Forms.Label lblWomen;
        private System.Windows.Forms.Label lblMen;
        private System.Windows.Forms.Label lblBrands;
        private System.Windows.Forms.Panel pnlSelectedCategoryInformation;
        private System.Windows.Forms.Panel pnlCategories;
        private System.Windows.Forms.Label lblShowAll;
        private System.Windows.Forms.Button btnHideShowFilter;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel pnlFilterPanel;
        private System.Windows.Forms.Label lblPriceRange;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblPrceSelectorInfo;
        private System.Windows.Forms.ComboBox cbxSizeSelector;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.Label lblFilterAppliedOrNot;
        private System.Windows.Forms.Label lblSizeSelectorInfo;
        private System.Windows.Forms.ComboBox cbxPriceSelector;
        private System.Windows.Forms.Button btnClearFilter;
    }
}