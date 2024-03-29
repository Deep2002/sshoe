﻿namespace FinalProject.ManagerViewForms
{
    partial class frmInvetoryManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvetoryManager));
            this.tbxSearchBar = new System.Windows.Forms.TextBox();
            this.btnDeleteSize = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblSearchTem = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.btnAddSize = new System.Windows.Forms.Button();
            this.tbxDesc = new System.Windows.Forms.TextBox();
            this.tbxTotalQuantity = new System.Windows.Forms.TextBox();
            this.btnAddNewItem = new System.Windows.Forms.Button();
            this.tbxRetailPrice = new System.Windows.Forms.TextBox();
            this.btnUpdateItem = new System.Windows.Forms.Button();
            this.tbxCost = new System.Windows.Forms.TextBox();
            this.btnUpdateImage = new System.Windows.Forms.Button();
            this.tbxRestockThreshold = new System.Windows.Forms.TextBox();
            this.pbxImage = new System.Windows.Forms.PictureBox();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.cbxBrand = new System.Windows.Forms.ComboBox();
            this.tbxQuantity = new System.Windows.Forms.TextBox();
            this.cbxSize = new System.Windows.Forms.ComboBox();
            this.lbxItems = new System.Windows.Forms.ListBox();
            this.dgvSizes = new System.Windows.Forms.DataGridView();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClearAllField = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.fileChooser = new System.Windows.Forms.OpenFileDialog();
            this.tbxImgLocation = new System.Windows.Forms.TextBox();
            this.cbxDiscountinued = new System.Windows.Forms.CheckBox();
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.mnuMenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSizes)).BeginInit();
            this.mnuMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxSearchBar
            // 
            this.tbxSearchBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbxSearchBar.ForeColor = System.Drawing.Color.Black;
            this.tbxSearchBar.Location = new System.Drawing.Point(386, 93);
            this.tbxSearchBar.Margin = new System.Windows.Forms.Padding(2);
            this.tbxSearchBar.Name = "tbxSearchBar";
            this.tbxSearchBar.Size = new System.Drawing.Size(677, 29);
            this.tbxSearchBar.TabIndex = 0;
            this.tbxSearchBar.Text = "Search...";
            this.tbxSearchBar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbxSearchBar_MouseClick);
            this.tbxSearchBar.TextChanged += new System.EventHandler(this.tbxSearchBar_TextChanged);
            // 
            // btnDeleteSize
            // 
            this.btnDeleteSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteSize.FlatAppearance.BorderSize = 0;
            this.btnDeleteSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSize.Font = new System.Drawing.Font("Trebuchet MS", 14F);
            this.btnDeleteSize.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteSize.Location = new System.Drawing.Point(792, 674);
            this.btnDeleteSize.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteSize.Name = "btnDeleteSize";
            this.btnDeleteSize.Size = new System.Drawing.Size(256, 38);
            this.btnDeleteSize.TabIndex = 18;
            this.btnDeleteSize.Text = "&Delete Selected Size";
            this.btnDeleteSize.UseVisualStyleBackColor = false;
            this.btnDeleteSize.Click += new System.EventHandler(this.btnDeleteSize_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(793, 476);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(139, 24);
            this.lblQuantity.TabIndex = 49;
            this.lblQuantity.Text = "Total Quantity:";
            // 
            // lblSearchTem
            // 
            this.lblSearchTem.AutoSize = true;
            this.lblSearchTem.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchTem.Location = new System.Drawing.Point(42, 159);
            this.lblSearchTem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchTem.Name = "lblSearchTem";
            this.lblSearchTem.Size = new System.Drawing.Size(231, 29);
            this.lblSearchTem.TabIndex = 27;
            this.lblSearchTem.Text = "Select list of items:\r\n";
            // 
            // tbxName
            // 
            this.tbxName.ForeColor = System.Drawing.Color.DimGray;
            this.tbxName.Location = new System.Drawing.Point(437, 236);
            this.tbxName.Margin = new System.Windows.Forms.Padding(2);
            this.tbxName.MaxLength = 100;
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(290, 29);
            this.tbxName.TabIndex = 1;
            // 
            // btnAddSize
            // 
            this.btnAddSize.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddSize.FlatAppearance.BorderSize = 0;
            this.btnAddSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSize.Font = new System.Drawing.Font("Trebuchet MS", 14F);
            this.btnAddSize.ForeColor = System.Drawing.Color.White;
            this.btnAddSize.Location = new System.Drawing.Point(792, 625);
            this.btnAddSize.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddSize.Name = "btnAddSize";
            this.btnAddSize.Size = new System.Drawing.Size(255, 36);
            this.btnAddSize.TabIndex = 14;
            this.btnAddSize.Text = "Add &Size";
            this.btnAddSize.UseVisualStyleBackColor = false;
            this.btnAddSize.Click += new System.EventHandler(this.btnAddSize_Click);
            // 
            // tbxDesc
            // 
            this.tbxDesc.ForeColor = System.Drawing.Color.DimGray;
            this.tbxDesc.Location = new System.Drawing.Point(437, 306);
            this.tbxDesc.Margin = new System.Windows.Forms.Padding(2);
            this.tbxDesc.Multiline = true;
            this.tbxDesc.Name = "tbxDesc";
            this.tbxDesc.Size = new System.Drawing.Size(290, 100);
            this.tbxDesc.TabIndex = 2;
            // 
            // tbxTotalQuantity
            // 
            this.tbxTotalQuantity.ForeColor = System.Drawing.Color.DimGray;
            this.tbxTotalQuantity.Location = new System.Drawing.Point(940, 473);
            this.tbxTotalQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.tbxTotalQuantity.Name = "tbxTotalQuantity";
            this.tbxTotalQuantity.ReadOnly = true;
            this.tbxTotalQuantity.Size = new System.Drawing.Size(107, 29);
            this.tbxTotalQuantity.TabIndex = 10;
            this.tbxTotalQuantity.Text = "0";
            // 
            // btnAddNewItem
            // 
            this.btnAddNewItem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddNewItem.FlatAppearance.BorderSize = 0;
            this.btnAddNewItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewItem.ForeColor = System.Drawing.Color.White;
            this.btnAddNewItem.Location = new System.Drawing.Point(1122, 236);
            this.btnAddNewItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewItem.Name = "btnAddNewItem";
            this.btnAddNewItem.Size = new System.Drawing.Size(261, 40);
            this.btnAddNewItem.TabIndex = 15;
            this.btnAddNewItem.Text = "Add &new Item";
            this.btnAddNewItem.UseVisualStyleBackColor = false;
            this.btnAddNewItem.Click += new System.EventHandler(this.btnAddNewItem_Click);
            // 
            // tbxRetailPrice
            // 
            this.tbxRetailPrice.ForeColor = System.Drawing.Color.DimGray;
            this.tbxRetailPrice.Location = new System.Drawing.Point(437, 448);
            this.tbxRetailPrice.Margin = new System.Windows.Forms.Padding(2);
            this.tbxRetailPrice.Name = "tbxRetailPrice";
            this.tbxRetailPrice.Size = new System.Drawing.Size(127, 29);
            this.tbxRetailPrice.TabIndex = 3;
            // 
            // btnUpdateItem
            // 
            this.btnUpdateItem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdateItem.FlatAppearance.BorderSize = 0;
            this.btnUpdateItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateItem.ForeColor = System.Drawing.Color.White;
            this.btnUpdateItem.Location = new System.Drawing.Point(1122, 294);
            this.btnUpdateItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateItem.Name = "btnUpdateItem";
            this.btnUpdateItem.Size = new System.Drawing.Size(261, 40);
            this.btnUpdateItem.TabIndex = 13;
            this.btnUpdateItem.Text = "&Update Selected Item";
            this.btnUpdateItem.UseVisualStyleBackColor = false;
            this.btnUpdateItem.Click += new System.EventHandler(this.btnUpdateItem_Click);
            // 
            // tbxCost
            // 
            this.tbxCost.ForeColor = System.Drawing.Color.DimGray;
            this.tbxCost.Location = new System.Drawing.Point(602, 448);
            this.tbxCost.Margin = new System.Windows.Forms.Padding(2);
            this.tbxCost.Name = "tbxCost";
            this.tbxCost.Size = new System.Drawing.Size(125, 29);
            this.tbxCost.TabIndex = 4;
            // 
            // btnUpdateImage
            // 
            this.btnUpdateImage.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdateImage.FlatAppearance.BorderSize = 0;
            this.btnUpdateImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateImage.ForeColor = System.Drawing.Color.White;
            this.btnUpdateImage.Location = new System.Drawing.Point(1122, 723);
            this.btnUpdateImage.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateImage.Name = "btnUpdateImage";
            this.btnUpdateImage.Size = new System.Drawing.Size(261, 40);
            this.btnUpdateImage.TabIndex = 16;
            this.btnUpdateImage.Text = "Upload &Image";
            this.btnUpdateImage.UseVisualStyleBackColor = false;
            this.btnUpdateImage.Click += new System.EventHandler(this.btnUpdateImage_Click);
            // 
            // tbxRestockThreshold
            // 
            this.tbxRestockThreshold.ForeColor = System.Drawing.Color.DimGray;
            this.tbxRestockThreshold.Location = new System.Drawing.Point(437, 522);
            this.tbxRestockThreshold.Margin = new System.Windows.Forms.Padding(2);
            this.tbxRestockThreshold.Name = "tbxRestockThreshold";
            this.tbxRestockThreshold.Size = new System.Drawing.Size(290, 29);
            this.tbxRestockThreshold.TabIndex = 5;
            this.tbxRestockThreshold.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxRestockThreshold_KeyPress);
            // 
            // pbxImage
            // 
            this.pbxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxImage.Location = new System.Drawing.Point(1122, 422);
            this.pbxImage.Margin = new System.Windows.Forms.Padding(2);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(261, 232);
            this.pbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImage.TabIndex = 41;
            this.pbxImage.TabStop = false;
            // 
            // cbxGender
            // 
            this.cbxGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxGender.DisplayMember = "1";
            this.cbxGender.ForeColor = System.Drawing.Color.DimGray;
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Location = new System.Drawing.Point(437, 588);
            this.cbxGender.Margin = new System.Windows.Forms.Padding(2);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(290, 32);
            this.cbxGender.TabIndex = 6;
            // 
            // cbxCategory
            // 
            this.cbxCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxCategory.ForeColor = System.Drawing.Color.DimGray;
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(437, 657);
            this.cbxCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(290, 32);
            this.cbxCategory.TabIndex = 7;
            // 
            // cbxBrand
            // 
            this.cbxBrand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxBrand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxBrand.ForeColor = System.Drawing.Color.DimGray;
            this.cbxBrand.FormattingEnabled = true;
            this.cbxBrand.Location = new System.Drawing.Point(437, 731);
            this.cbxBrand.Margin = new System.Windows.Forms.Padding(2);
            this.cbxBrand.Name = "cbxBrand";
            this.cbxBrand.Size = new System.Drawing.Size(290, 32);
            this.cbxBrand.TabIndex = 8;
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.ForeColor = System.Drawing.Color.DimGray;
            this.tbxQuantity.Location = new System.Drawing.Point(940, 574);
            this.tbxQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.Size = new System.Drawing.Size(108, 29);
            this.tbxQuantity.TabIndex = 12;
            this.tbxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxQuantity_KeyPress);
            // 
            // cbxSize
            // 
            this.cbxSize.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxSize.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxSize.ForeColor = System.Drawing.Color.DimGray;
            this.cbxSize.FormattingEnabled = true;
            this.cbxSize.Items.AddRange(new object[] {
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
            this.cbxSize.Location = new System.Drawing.Point(940, 526);
            this.cbxSize.Margin = new System.Windows.Forms.Padding(2);
            this.cbxSize.Name = "cbxSize";
            this.cbxSize.Size = new System.Drawing.Size(108, 32);
            this.cbxSize.TabIndex = 11;
            this.cbxSize.Text = "Size";
            // 
            // lbxItems
            // 
            this.lbxItems.FormattingEnabled = true;
            this.lbxItems.ItemHeight = 24;
            this.lbxItems.Location = new System.Drawing.Point(42, 210);
            this.lbxItems.Name = "lbxItems";
            this.lbxItems.ScrollAlwaysVisible = true;
            this.lbxItems.Size = new System.Drawing.Size(339, 556);
            this.lbxItems.TabIndex = 0;
            this.lbxItems.SelectedIndexChanged += new System.EventHandler(this.lbxItems_SelectedIndexChanged);
            // 
            // dgvSizes
            // 
            this.dgvSizes.AllowUserToAddRows = false;
            this.dgvSizes.AllowUserToDeleteRows = false;
            this.dgvSizes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSizes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSizes.BackgroundColor = System.Drawing.Color.White;
            this.dgvSizes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSizes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Size,
            this.Qt});
            this.dgvSizes.Location = new System.Drawing.Point(792, 237);
            this.dgvSizes.Name = "dgvSizes";
            this.dgvSizes.ReadOnly = true;
            this.dgvSizes.Size = new System.Drawing.Size(255, 222);
            this.dgvSizes.TabIndex = 9;
            // 
            // Size
            // 
            this.Size.HeaderText = "Size";
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            // 
            // Qt
            // 
            this.Qt.HeaderText = "Qt";
            this.Qt.Name = "Qt";
            this.Qt.ReadOnly = true;
            // 
            // btnClearAllField
            // 
            this.btnClearAllField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnClearAllField.FlatAppearance.BorderSize = 0;
            this.btnClearAllField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAllField.Location = new System.Drawing.Point(1122, 352);
            this.btnClearAllField.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearAllField.Name = "btnClearAllField";
            this.btnClearAllField.Size = new System.Drawing.Size(261, 40);
            this.btnClearAllField.TabIndex = 19;
            this.btnClearAllField.Text = "&Clear All Fields";
            this.btnClearAllField.UseVisualStyleBackColor = false;
            this.btnClearAllField.Click += new System.EventHandler(this.btnClearAllField_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(437, 210);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 24);
            this.label6.TabIndex = 64;
            this.label6.Text = "Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(437, 280);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 24);
            this.label7.TabIndex = 65;
            this.label7.Text = "Description:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(437, 422);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 24);
            this.label8.TabIndex = 66;
            this.label8.Text = "Retail Price:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(598, 422);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 24);
            this.label9.TabIndex = 67;
            this.label9.Text = "Cost:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(437, 496);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 24);
            this.label10.TabIndex = 68;
            this.label10.Text = "Restock Threshold:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(437, 562);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 24);
            this.label11.TabIndex = 69;
            this.label11.Text = "Select Gender:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(437, 631);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(151, 24);
            this.label12.TabIndex = 70;
            this.label12.Text = "Select Category:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(437, 705);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 24);
            this.label13.TabIndex = 71;
            this.label13.Text = "Select Brand:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(793, 529);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 24);
            this.label1.TabIndex = 72;
            this.label1.Text = "Size:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(793, 574);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 73;
            this.label2.Text = "Quantity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(792, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 29);
            this.label3.TabIndex = 74;
            this.label3.Text = "Sizes Information:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(433, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 29);
            this.label4.TabIndex = 75;
            this.label4.Text = "Item Infromation:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1118, 159);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 29);
            this.label5.TabIndex = 76;
            this.label5.Text = "Actions:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(792, 210);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(140, 24);
            this.label14.TabIndex = 77;
            this.label14.Text = "Available sizes:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Trebuchet MS", 19F);
            this.lblTitle.Location = new System.Drawing.Point(614, 48);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(220, 33);
            this.lblTitle.TabIndex = 78;
            this.lblTitle.Text = "Manage Inventory";
            // 
            // fileChooser
            // 
            this.fileChooser.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            // 
            // tbxImgLocation
            // 
            this.tbxImgLocation.ForeColor = System.Drawing.Color.DimGray;
            this.tbxImgLocation.Location = new System.Drawing.Point(1122, 678);
            this.tbxImgLocation.Margin = new System.Windows.Forms.Padding(2);
            this.tbxImgLocation.MaxLength = 100;
            this.tbxImgLocation.Name = "tbxImgLocation";
            this.tbxImgLocation.ReadOnly = true;
            this.tbxImgLocation.Size = new System.Drawing.Size(261, 29);
            this.tbxImgLocation.TabIndex = 79;
            this.tbxImgLocation.Text = "Image Location...";
            // 
            // cbxDiscountinued
            // 
            this.cbxDiscountinued.AutoSize = true;
            this.cbxDiscountinued.Location = new System.Drawing.Point(792, 738);
            this.cbxDiscountinued.Name = "cbxDiscountinued";
            this.cbxDiscountinued.Size = new System.Drawing.Size(192, 28);
            this.cbxDiscountinued.TabIndex = 80;
            this.cbxDiscountinued.Text = "Item Discountinued";
            this.cbxDiscountinued.UseVisualStyleBackColor = true;
            // 
            // mnuMenu
            // 
            this.mnuMenu.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMenuHelp});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mnuMenu.Size = new System.Drawing.Size(1424, 31);
            this.mnuMenu.TabIndex = 94;
            this.mnuMenu.Text = "menuStrip1";
            // 
            // mnuMenuHelp
            // 
            this.mnuMenuHelp.Name = "mnuMenuHelp";
            this.mnuMenuHelp.Size = new System.Drawing.Size(65, 27);
            this.mnuMenuHelp.Text = "&Help";
            this.mnuMenuHelp.Click += new System.EventHandler(this.mnuMenuHelp_Click);
            // 
            // frmInvetoryManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1424, 781);
            this.Controls.Add(this.mnuMenu);
            this.Controls.Add(this.cbxDiscountinued);
            this.Controls.Add(this.tbxImgLocation);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnClearAllField);
            this.Controls.Add(this.dgvSizes);
            this.Controls.Add(this.lbxItems);
            this.Controls.Add(this.cbxSize);
            this.Controls.Add(this.tbxQuantity);
            this.Controls.Add(this.tbxSearchBar);
            this.Controls.Add(this.btnDeleteSize);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblSearchTem);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.btnAddSize);
            this.Controls.Add(this.tbxDesc);
            this.Controls.Add(this.tbxTotalQuantity);
            this.Controls.Add(this.btnAddNewItem);
            this.Controls.Add(this.tbxRetailPrice);
            this.Controls.Add(this.btnUpdateItem);
            this.Controls.Add(this.tbxCost);
            this.Controls.Add(this.btnUpdateImage);
            this.Controls.Add(this.tbxRestockThreshold);
            this.Controls.Add(this.pbxImage);
            this.Controls.Add(this.cbxGender);
            this.Controls.Add(this.cbxCategory);
            this.Controls.Add(this.cbxBrand);
            this.Font = new System.Drawing.Font("Trebuchet MS", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "frmInvetoryManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Manager";
            this.Load += new System.EventHandler(this.frmInventoryPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSizes)).EndInit();
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxSearchBar;
        private System.Windows.Forms.Button btnDeleteSize;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblSearchTem;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Button btnAddSize;
        private System.Windows.Forms.TextBox tbxDesc;
        private System.Windows.Forms.TextBox tbxTotalQuantity;
        private System.Windows.Forms.Button btnAddNewItem;
        private System.Windows.Forms.TextBox tbxRetailPrice;
        private System.Windows.Forms.Button btnUpdateItem;
        private System.Windows.Forms.TextBox tbxCost;
        private System.Windows.Forms.Button btnUpdateImage;
        private System.Windows.Forms.TextBox tbxRestockThreshold;
        private System.Windows.Forms.PictureBox pbxImage;
        private System.Windows.Forms.ComboBox cbxGender;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.ComboBox cbxBrand;
        private System.Windows.Forms.TextBox tbxQuantity;
        private System.Windows.Forms.ComboBox cbxSize;
        private System.Windows.Forms.ListBox lbxItems;
        private System.Windows.Forms.DataGridView dgvSizes;
        private System.Windows.Forms.Button btnClearAllField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.OpenFileDialog fileChooser;
        private System.Windows.Forms.TextBox tbxImgLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qt;
        private System.Windows.Forms.CheckBox cbxDiscountinued;
        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuMenuHelp;
    }
}