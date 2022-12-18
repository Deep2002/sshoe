namespace FinalProject
{
    partial class frmCheckoutView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckoutView));
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvItemsDetails = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblDiscountValue = new System.Windows.Forms.Label();
            this.lblTaxValue = new System.Windows.Forms.Label();
            this.lblSubTotalValue = new System.Windows.Forms.Label();
            this.pnlPaymentBreakdownDisplay = new System.Windows.Forms.Panel();
            this.lblDiscountedTotalValue = new System.Windows.Forms.Label();
            this.lblDiscountedTotal = new System.Windows.Forms.Label();
            this.lblCoupon = new System.Windows.Forms.Label();
            this.tbxCoupon = new System.Windows.Forms.TextBox();
            this.btnApplyCoupon = new System.Windows.Forms.Button();
            this.btnContinueToCheckout = new System.Windows.Forms.Button();
            this.rdoUseAboveAddress = new System.Windows.Forms.RadioButton();
            this.rdoUseDiffrentAddress = new System.Windows.Forms.RadioButton();
            this.lblAddress = new System.Windows.Forms.Label();
            this.pnlAddressChoice = new System.Windows.Forms.Panel();
            this.lblRequiredStar = new System.Windows.Forms.Label();
            this.lblAddressInfo = new System.Windows.Forms.Label();
            this.lblCouponInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsDetails)).BeginInit();
            this.pnlPaymentBreakdownDisplay.SuspendLayout();
            this.pnlAddressChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTitle.Location = new System.Drawing.Point(547, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(184, 38);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Checkout";
            // 
            // dgvItemsDetails
            // 
            this.dgvItemsDetails.AllowUserToAddRows = false;
            this.dgvItemsDetails.AllowUserToDeleteRows = false;
            this.dgvItemsDetails.AllowUserToOrderColumns = true;
            this.dgvItemsDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItemsDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItemsDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemsDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.ItemPrice,
            this.Quantity,
            this.TotalPrice});
            this.dgvItemsDetails.Location = new System.Drawing.Point(42, 94);
            this.dgvItemsDetails.Name = "dgvItemsDetails";
            this.dgvItemsDetails.ReadOnly = true;
            this.dgvItemsDetails.Size = new System.Drawing.Size(1194, 348);
            this.dgvItemsDetails.TabIndex = 2;
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            // 
            // ItemPrice
            // 
            this.ItemPrice.HeaderText = "Item Price";
            this.ItemPrice.Name = "ItemPrice";
            this.ItemPrice.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "Total Price";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.BackColor = System.Drawing.Color.White;
            this.lblSubtotal.Location = new System.Drawing.Point(13, 11);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(99, 23);
            this.lblSubtotal.TabIndex = 3;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.BackColor = System.Drawing.Color.White;
            this.lblTax.Location = new System.Drawing.Point(13, 98);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(139, 23);
            this.lblTax.TabIndex = 4;
            this.lblTax.Text = "Tax (8.25%):";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.BackColor = System.Drawing.Color.White;
            this.lblDiscount.Location = new System.Drawing.Point(13, 40);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(103, 23);
            this.lblDiscount.TabIndex = 5;
            this.lblDiscount.Text = "Discount:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTotal.Location = new System.Drawing.Point(13, 127);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(65, 23);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total:";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.BackColor = System.Drawing.Color.White;
            this.lblTotalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTotalValue.Location = new System.Drawing.Point(297, 124);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(130, 23);
            this.lblTotalValue.TabIndex = 10;
            this.lblTotalValue.Text = "$0.00";
            this.lblTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDiscountValue
            // 
            this.lblDiscountValue.BackColor = System.Drawing.Color.White;
            this.lblDiscountValue.ForeColor = System.Drawing.Color.Green;
            this.lblDiscountValue.Location = new System.Drawing.Point(297, 37);
            this.lblDiscountValue.Name = "lblDiscountValue";
            this.lblDiscountValue.Size = new System.Drawing.Size(130, 23);
            this.lblDiscountValue.TabIndex = 9;
            this.lblDiscountValue.Text = "-0.00";
            this.lblDiscountValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTaxValue
            // 
            this.lblTaxValue.BackColor = System.Drawing.Color.White;
            this.lblTaxValue.Location = new System.Drawing.Point(297, 95);
            this.lblTaxValue.Name = "lblTaxValue";
            this.lblTaxValue.Size = new System.Drawing.Size(130, 23);
            this.lblTaxValue.TabIndex = 8;
            this.lblTaxValue.Text = "$0.00";
            this.lblTaxValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubTotalValue
            // 
            this.lblSubTotalValue.BackColor = System.Drawing.Color.White;
            this.lblSubTotalValue.Location = new System.Drawing.Point(297, 8);
            this.lblSubTotalValue.Name = "lblSubTotalValue";
            this.lblSubTotalValue.Size = new System.Drawing.Size(130, 23);
            this.lblSubTotalValue.TabIndex = 7;
            this.lblSubTotalValue.Text = "$0.00";
            this.lblSubTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlPaymentBreakdownDisplay
            // 
            this.pnlPaymentBreakdownDisplay.BackColor = System.Drawing.Color.White;
            this.pnlPaymentBreakdownDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPaymentBreakdownDisplay.Controls.Add(this.lblDiscountedTotalValue);
            this.pnlPaymentBreakdownDisplay.Controls.Add(this.lblSubTotalValue);
            this.pnlPaymentBreakdownDisplay.Controls.Add(this.lblDiscountedTotal);
            this.pnlPaymentBreakdownDisplay.Controls.Add(this.lblSubtotal);
            this.pnlPaymentBreakdownDisplay.Controls.Add(this.lblTotal);
            this.pnlPaymentBreakdownDisplay.Controls.Add(this.lblDiscountValue);
            this.pnlPaymentBreakdownDisplay.Controls.Add(this.lblTotalValue);
            this.pnlPaymentBreakdownDisplay.Controls.Add(this.lblTaxValue);
            this.pnlPaymentBreakdownDisplay.Controls.Add(this.lblDiscount);
            this.pnlPaymentBreakdownDisplay.Controls.Add(this.lblTax);
            this.pnlPaymentBreakdownDisplay.Location = new System.Drawing.Point(778, 460);
            this.pnlPaymentBreakdownDisplay.Name = "pnlPaymentBreakdownDisplay";
            this.pnlPaymentBreakdownDisplay.Size = new System.Drawing.Size(458, 160);
            this.pnlPaymentBreakdownDisplay.TabIndex = 11;
            // 
            // lblDiscountedTotalValue
            // 
            this.lblDiscountedTotalValue.BackColor = System.Drawing.Color.White;
            this.lblDiscountedTotalValue.Location = new System.Drawing.Point(297, 66);
            this.lblDiscountedTotalValue.Name = "lblDiscountedTotalValue";
            this.lblDiscountedTotalValue.Size = new System.Drawing.Size(130, 23);
            this.lblDiscountedTotalValue.TabIndex = 12;
            this.lblDiscountedTotalValue.Text = "$0.00";
            this.lblDiscountedTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDiscountedTotal
            // 
            this.lblDiscountedTotal.AutoSize = true;
            this.lblDiscountedTotal.BackColor = System.Drawing.Color.White;
            this.lblDiscountedTotal.Location = new System.Drawing.Point(13, 69);
            this.lblDiscountedTotal.Name = "lblDiscountedTotal";
            this.lblDiscountedTotal.Size = new System.Drawing.Size(179, 23);
            this.lblDiscountedTotal.TabIndex = 11;
            this.lblDiscountedTotal.Text = "Discounted Total:";
            // 
            // lblCoupon
            // 
            this.lblCoupon.AutoSize = true;
            this.lblCoupon.BackColor = System.Drawing.SystemColors.Control;
            this.lblCoupon.Location = new System.Drawing.Point(444, 473);
            this.lblCoupon.Name = "lblCoupon";
            this.lblCoupon.Size = new System.Drawing.Size(92, 23);
            this.lblCoupon.TabIndex = 12;
            this.lblCoupon.Text = "Coupon:";
            // 
            // tbxCoupon
            // 
            this.tbxCoupon.Location = new System.Drawing.Point(542, 470);
            this.tbxCoupon.Name = "tbxCoupon";
            this.tbxCoupon.Size = new System.Drawing.Size(166, 30);
            this.tbxCoupon.TabIndex = 13;
            // 
            // btnApplyCoupon
            // 
            this.btnApplyCoupon.BackColor = System.Drawing.SystemColors.Control;
            this.btnApplyCoupon.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnApplyCoupon.ForeColor = System.Drawing.Color.Black;
            this.btnApplyCoupon.Location = new System.Drawing.Point(448, 531);
            this.btnApplyCoupon.Name = "btnApplyCoupon";
            this.btnApplyCoupon.Size = new System.Drawing.Size(260, 40);
            this.btnApplyCoupon.TabIndex = 14;
            this.btnApplyCoupon.Text = "Apply";
            this.btnApplyCoupon.UseVisualStyleBackColor = false;
            this.btnApplyCoupon.Click += new System.EventHandler(this.btnApplyCoupon_Click);
            // 
            // btnContinueToCheckout
            // 
            this.btnContinueToCheckout.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnContinueToCheckout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinueToCheckout.ForeColor = System.Drawing.Color.White;
            this.btnContinueToCheckout.Location = new System.Drawing.Point(448, 574);
            this.btnContinueToCheckout.Name = "btnContinueToCheckout";
            this.btnContinueToCheckout.Size = new System.Drawing.Size(260, 40);
            this.btnContinueToCheckout.TabIndex = 15;
            this.btnContinueToCheckout.Text = "Continue to checkout";
            this.btnContinueToCheckout.UseVisualStyleBackColor = false;
            this.btnContinueToCheckout.Click += new System.EventHandler(this.btnContinueToCheckout_Click);
            // 
            // rdoUseAboveAddress
            // 
            this.rdoUseAboveAddress.AutoSize = true;
            this.rdoUseAboveAddress.Checked = true;
            this.rdoUseAboveAddress.Location = new System.Drawing.Point(14, 100);
            this.rdoUseAboveAddress.Name = "rdoUseAboveAddress";
            this.rdoUseAboveAddress.Size = new System.Drawing.Size(217, 27);
            this.rdoUseAboveAddress.TabIndex = 17;
            this.rdoUseAboveAddress.TabStop = true;
            this.rdoUseAboveAddress.Text = "Use above Address.";
            this.rdoUseAboveAddress.UseVisualStyleBackColor = true;
            // 
            // rdoUseDiffrentAddress
            // 
            this.rdoUseDiffrentAddress.AutoSize = true;
            this.rdoUseDiffrentAddress.Location = new System.Drawing.Point(14, 126);
            this.rdoUseDiffrentAddress.Name = "rdoUseDiffrentAddress";
            this.rdoUseDiffrentAddress.Size = new System.Drawing.Size(241, 27);
            this.rdoUseDiffrentAddress.TabIndex = 18;
            this.rdoUseDiffrentAddress.Text = "Use different Address.\r\n";
            this.rdoUseDiffrentAddress.UseVisualStyleBackColor = true;
            // 
            // lblAddress
            // 
            this.lblAddress.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblAddress.Location = new System.Drawing.Point(14, 45);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(317, 52);
            this.lblAddress.TabIndex = 19;
            this.lblAddress.Text = "4200 S-IH 35 Fontage Rd,\r\nAustin, TX 78745";
            // 
            // pnlAddressChoice
            // 
            this.pnlAddressChoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddressChoice.Controls.Add(this.lblRequiredStar);
            this.pnlAddressChoice.Controls.Add(this.lblAddressInfo);
            this.pnlAddressChoice.Controls.Add(this.lblAddress);
            this.pnlAddressChoice.Controls.Add(this.rdoUseDiffrentAddress);
            this.pnlAddressChoice.Controls.Add(this.rdoUseAboveAddress);
            this.pnlAddressChoice.Location = new System.Drawing.Point(42, 460);
            this.pnlAddressChoice.Name = "pnlAddressChoice";
            this.pnlAddressChoice.Size = new System.Drawing.Size(350, 160);
            this.pnlAddressChoice.TabIndex = 20;
            // 
            // lblRequiredStar
            // 
            this.lblRequiredStar.AutoSize = true;
            this.lblRequiredStar.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredStar.Location = new System.Drawing.Point(323, 3);
            this.lblRequiredStar.Name = "lblRequiredStar";
            this.lblRequiredStar.Size = new System.Drawing.Size(22, 23);
            this.lblRequiredStar.TabIndex = 22;
            this.lblRequiredStar.Text = "*";
            this.lblRequiredStar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAddressInfo
            // 
            this.lblAddressInfo.Font = new System.Drawing.Font("Verdana", 14F);
            this.lblAddressInfo.ForeColor = System.Drawing.Color.Black;
            this.lblAddressInfo.Location = new System.Drawing.Point(14, 3);
            this.lblAddressInfo.Name = "lblAddressInfo";
            this.lblAddressInfo.Size = new System.Drawing.Size(215, 23);
            this.lblAddressInfo.TabIndex = 20;
            this.lblAddressInfo.Text = "Address Information";
            // 
            // lblCouponInfo
            // 
            this.lblCouponInfo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCouponInfo.ForeColor = System.Drawing.Color.Red;
            this.lblCouponInfo.Location = new System.Drawing.Point(448, 505);
            this.lblCouponInfo.Name = "lblCouponInfo";
            this.lblCouponInfo.Size = new System.Drawing.Size(260, 20);
            this.lblCouponInfo.TabIndex = 21;
            this.lblCouponInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmCheckoutView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 642);
            this.Controls.Add(this.lblCouponInfo);
            this.Controls.Add(this.btnContinueToCheckout);
            this.Controls.Add(this.btnApplyCoupon);
            this.Controls.Add(this.tbxCoupon);
            this.Controls.Add(this.lblCoupon);
            this.Controls.Add(this.dgvItemsDetails);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlPaymentBreakdownDisplay);
            this.Controls.Add(this.pnlAddressChoice);
            this.Font = new System.Drawing.Font("Verdana", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.MaximizeBox = false;
            this.Name = "frmCheckoutView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checkout";
            this.Load += new System.EventHandler(this.frmCheckoutView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsDetails)).EndInit();
            this.pnlPaymentBreakdownDisplay.ResumeLayout(false);
            this.pnlPaymentBreakdownDisplay.PerformLayout();
            this.pnlAddressChoice.ResumeLayout(false);
            this.pnlAddressChoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvItemsDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblDiscountValue;
        private System.Windows.Forms.Label lblTaxValue;
        private System.Windows.Forms.Label lblSubTotalValue;
        private System.Windows.Forms.Panel pnlPaymentBreakdownDisplay;
        private System.Windows.Forms.Label lblCoupon;
        private System.Windows.Forms.TextBox tbxCoupon;
        private System.Windows.Forms.Button btnApplyCoupon;
        private System.Windows.Forms.Button btnContinueToCheckout;
        private System.Windows.Forms.RadioButton rdoUseAboveAddress;
        private System.Windows.Forms.RadioButton rdoUseDiffrentAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Panel pnlAddressChoice;
        private System.Windows.Forms.Label lblRequiredStar;
        private System.Windows.Forms.Label lblAddressInfo;
        private System.Windows.Forms.Label lblDiscountedTotalValue;
        private System.Windows.Forms.Label lblDiscountedTotal;
        private System.Windows.Forms.Label lblCouponInfo;
    }
}