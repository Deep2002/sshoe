namespace FinalProject.ManagerViewForms
{
    partial class frmDiscountsManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiscountsManager));
            this.dgvDiscounts = new System.Windows.Forms.DataGridView();
            this.DiscountCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DicountAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DicountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSearchCode = new System.Windows.Forms.Label();
            this.tbxSearchBar = new System.Windows.Forms.TextBox();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblPercentageORAmount = new System.Windows.Forms.Label();
            this.lblDisocuntType = new System.Windows.Forms.Label();
            this.lblExpDate = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblDiscountLevel = new System.Windows.Forms.Label();
            this.tbxDiscountLevel = new System.Windows.Forms.TextBox();
            this.tbxDesc = new System.Windows.Forms.TextBox();
            this.tbxCode = new System.Windows.Forms.TextBox();
            this.tbxPercentageORAmount = new System.Windows.Forms.TextBox();
            this.cbxDiscountType = new System.Windows.Forms.ComboBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpExpDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscounts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDiscounts
            // 
            this.dgvDiscounts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvDiscounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiscounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiscounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DiscountCode,
            this.StartDate,
            this.EndDate,
            this.DiscountPercentage,
            this.DicountAmount,
            this.DicountID});
            this.dgvDiscounts.Location = new System.Drawing.Point(12, 116);
            this.dgvDiscounts.Name = "dgvDiscounts";
            this.dgvDiscounts.ReadOnly = true;
            this.dgvDiscounts.RowTemplate.Height = 24;
            this.dgvDiscounts.Size = new System.Drawing.Size(1386, 287);
            this.dgvDiscounts.TabIndex = 0;
            this.dgvDiscounts.SelectionChanged += new System.EventHandler(this.dgvDiscounts_SelectionChanged);
            // 
            // DiscountCode
            // 
            this.DiscountCode.HeaderText = "Code";
            this.DiscountCode.Name = "DiscountCode";
            this.DiscountCode.ReadOnly = true;
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "Starting Date";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "Ending Date";
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            // 
            // DiscountPercentage
            // 
            this.DiscountPercentage.HeaderText = "Discount Percentage";
            this.DiscountPercentage.Name = "DiscountPercentage";
            this.DiscountPercentage.ReadOnly = true;
            // 
            // DicountAmount
            // 
            this.DicountAmount.HeaderText = "Dicount Amount";
            this.DicountAmount.Name = "DicountAmount";
            this.DicountAmount.ReadOnly = true;
            // 
            // DicountID
            // 
            this.DicountID.HeaderText = "ID";
            this.DicountID.Name = "DicountID";
            this.DicountID.ReadOnly = true;
            // 
            // lblSearchCode
            // 
            this.lblSearchCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSearchCode.AutoSize = true;
            this.lblSearchCode.Location = new System.Drawing.Point(291, 51);
            this.lblSearchCode.Name = "lblSearchCode";
            this.lblSearchCode.Size = new System.Drawing.Size(121, 24);
            this.lblSearchCode.TabIndex = 23;
            this.lblSearchCode.Text = "Search Code:";
            // 
            // tbxSearchBar
            // 
            this.tbxSearchBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxSearchBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbxSearchBar.ForeColor = System.Drawing.Color.DimGray;
            this.tbxSearchBar.Location = new System.Drawing.Point(417, 48);
            this.tbxSearchBar.Margin = new System.Windows.Forms.Padding(2);
            this.tbxSearchBar.Name = "tbxSearchBar";
            this.tbxSearchBar.Size = new System.Drawing.Size(677, 29);
            this.tbxSearchBar.TabIndex = 0;
            this.tbxSearchBar.Text = "Code, ID, Date, Amount..";
            this.tbxSearchBar.TextChanged += new System.EventHandler(this.tbxSearchBar_TextChanged);
            this.tbxSearchBar.Leave += new System.EventHandler(this.tbxSearchBar_Leave);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddNewUser.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddNewUser.FlatAppearance.BorderSize = 0;
            this.btnAddNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewUser.ForeColor = System.Drawing.Color.White;
            this.btnAddNewUser.Location = new System.Drawing.Point(1074, 423);
            this.btnAddNewUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(324, 58);
            this.btnAddNewUser.TabIndex = 8;
            this.btnAddNewUser.Text = "&Add Discount";
            this.btnAddNewUser.UseVisualStyleBackColor = false;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(1074, 504);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(324, 58);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "&Update ";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblCode
            // 
            this.lblCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(12, 437);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(59, 24);
            this.lblCode.TabIndex = 26;
            this.lblCode.Text = "Code:";
            // 
            // lblDesc
            // 
            this.lblDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(12, 483);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(112, 24);
            this.lblDesc.TabIndex = 27;
            this.lblDesc.Text = "Description:";
            // 
            // lblPercentageORAmount
            // 
            this.lblPercentageORAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPercentageORAmount.AutoSize = true;
            this.lblPercentageORAmount.Location = new System.Drawing.Point(9, 678);
            this.lblPercentageORAmount.Name = "lblPercentageORAmount";
            this.lblPercentageORAmount.Size = new System.Drawing.Size(111, 24);
            this.lblPercentageORAmount.TabIndex = 29;
            this.lblPercentageORAmount.Text = "Percentage:";
            // 
            // lblDisocuntType
            // 
            this.lblDisocuntType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDisocuntType.AutoSize = true;
            this.lblDisocuntType.Location = new System.Drawing.Point(9, 632);
            this.lblDisocuntType.Name = "lblDisocuntType";
            this.lblDisocuntType.Size = new System.Drawing.Size(134, 24);
            this.lblDisocuntType.TabIndex = 28;
            this.lblDisocuntType.Text = "Discount Type:";
            // 
            // lblExpDate
            // 
            this.lblExpDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblExpDate.AutoSize = true;
            this.lblExpDate.Location = new System.Drawing.Point(460, 483);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(94, 24);
            this.lblExpDate.TabIndex = 31;
            this.lblExpDate.Text = "Exp Date:";
            // 
            // lblStart
            // 
            this.lblStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(460, 437);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(106, 24);
            this.lblStart.TabIndex = 30;
            this.lblStart.Text = "Start Date:";
            // 
            // lblDiscountLevel
            // 
            this.lblDiscountLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDiscountLevel.AutoSize = true;
            this.lblDiscountLevel.Location = new System.Drawing.Point(8, 586);
            this.lblDiscountLevel.Name = "lblDiscountLevel";
            this.lblDiscountLevel.Size = new System.Drawing.Size(140, 24);
            this.lblDiscountLevel.TabIndex = 32;
            this.lblDiscountLevel.Text = "Discount Level:";
            // 
            // tbxDiscountLevel
            // 
            this.tbxDiscountLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxDiscountLevel.Location = new System.Drawing.Point(166, 583);
            this.tbxDiscountLevel.Name = "tbxDiscountLevel";
            this.tbxDiscountLevel.Size = new System.Drawing.Size(272, 29);
            this.tbxDiscountLevel.TabIndex = 3;
            // 
            // tbxDesc
            // 
            this.tbxDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxDesc.Location = new System.Drawing.Point(166, 483);
            this.tbxDesc.MaxLength = 50;
            this.tbxDesc.Multiline = true;
            this.tbxDesc.Name = "tbxDesc";
            this.tbxDesc.Size = new System.Drawing.Size(272, 81);
            this.tbxDesc.TabIndex = 2;
            // 
            // tbxCode
            // 
            this.tbxCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxCode.Location = new System.Drawing.Point(166, 437);
            this.tbxCode.MaxLength = 20;
            this.tbxCode.Name = "tbxCode";
            this.tbxCode.Size = new System.Drawing.Size(272, 29);
            this.tbxCode.TabIndex = 1;
            // 
            // tbxPercentageORAmount
            // 
            this.tbxPercentageORAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxPercentageORAmount.Location = new System.Drawing.Point(166, 675);
            this.tbxPercentageORAmount.Name = "tbxPercentageORAmount";
            this.tbxPercentageORAmount.Size = new System.Drawing.Size(272, 29);
            this.tbxPercentageORAmount.TabIndex = 5;
            // 
            // cbxDiscountType
            // 
            this.cbxDiscountType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxDiscountType.FormattingEnabled = true;
            this.cbxDiscountType.Items.AddRange(new object[] {
            "Percentage",
            "Dollar Amount"});
            this.cbxDiscountType.Location = new System.Drawing.Point(166, 629);
            this.cbxDiscountType.Name = "cbxDiscountType";
            this.cbxDiscountType.Size = new System.Drawing.Size(272, 32);
            this.cbxDiscountType.TabIndex = 4;
            this.cbxDiscountType.Text = "Percentage";
            this.cbxDiscountType.SelectedIndexChanged += new System.EventHandler(this.cbxDiscountType_SelectedIndexChanged);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpStartDate.CustomFormat = "MM/dd/yy";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(572, 436);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(123, 29);
            this.dtpStartDate.TabIndex = 6;
            this.dtpStartDate.Value = new System.DateTime(2022, 11, 18, 0, 0, 0, 0);
            // 
            // dtpExpDate
            // 
            this.dtpExpDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpExpDate.CustomFormat = "MM/dd/yy";
            this.dtpExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpDate.Location = new System.Drawing.Point(572, 479);
            this.dtpExpDate.Name = "dtpExpDate";
            this.dtpExpDate.Size = new System.Drawing.Size(123, 29);
            this.dtpExpDate.TabIndex = 7;
            this.dtpExpDate.Value = new System.DateTime(2022, 11, 18, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(569, 517);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 14);
            this.label8.TabIndex = 90;
            this.label8.Text = "Ex. 02/24";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(189, 717);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(249, 14);
            this.label9.TabIndex = 91;
            this.label9.Text = "(Type This 0.00),  NOT $0.00 OR %0.00";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(1074, 586);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(324, 58);
            this.btnClear.TabIndex = 92;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmDiscountsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 781);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpExpDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.cbxDiscountType);
            this.Controls.Add(this.tbxPercentageORAmount);
            this.Controls.Add(this.tbxCode);
            this.Controls.Add(this.tbxDesc);
            this.Controls.Add(this.tbxDiscountLevel);
            this.Controls.Add(this.lblDiscountLevel);
            this.Controls.Add(this.lblExpDate);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblPercentageORAmount);
            this.Controls.Add(this.lblDisocuntType);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.lblSearchCode);
            this.Controls.Add(this.tbxSearchBar);
            this.Controls.Add(this.dgvDiscounts);
            this.Font = new System.Drawing.Font("Trebuchet MS", 14F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1440, 820);
            this.Name = "frmDiscountsManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discounts Manager";
            this.Load += new System.EventHandler(this.frmDiscountsManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDiscounts;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn DicountAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DicountID;
        private System.Windows.Forms.Label lblSearchCode;
        private System.Windows.Forms.TextBox tbxSearchBar;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblPercentageORAmount;
        private System.Windows.Forms.Label lblDisocuntType;
        private System.Windows.Forms.Label lblExpDate;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblDiscountLevel;
        private System.Windows.Forms.TextBox tbxDiscountLevel;
        private System.Windows.Forms.TextBox tbxDesc;
        private System.Windows.Forms.TextBox tbxCode;
        private System.Windows.Forms.TextBox tbxPercentageORAmount;
        private System.Windows.Forms.ComboBox cbxDiscountType;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpExpDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnClear;
    }
}