namespace FinalProject
{
    partial class frmItemDetailedInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemDetailedInfo));
            this.pbxItemImage = new System.Windows.Forms.PictureBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.btnAddToCartNow = new System.Windows.Forms.Button();
            this.nudQuantityCounter = new System.Windows.Forms.NumericUpDown();
            this.lblSelectQuantity = new System.Windows.Forms.Label();
            this.lblProductLeft = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxSize = new System.Windows.Forms.ComboBox();
            this.pnlScrollableDetailsArea = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbxItemImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantityCounter)).BeginInit();
            this.pnlScrollableDetailsArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxItemImage
            // 
            this.pbxItemImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxItemImage.Image = global::FinalProject.Properties.Resources.sampleShoe;
            this.pbxItemImage.Location = new System.Drawing.Point(12, 12);
            this.pbxItemImage.Name = "pbxItemImage";
            this.pbxItemImage.Size = new System.Drawing.Size(350, 350);
            this.pbxItemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxItemImage.TabIndex = 0;
            this.pbxItemImage.TabStop = false;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoEllipsis = true;
            this.lblItemName.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(382, 12);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(325, 87);
            this.lblItemName.TabIndex = 1;
            this.lblItemName.Text = "Nike Mens Air Jordan 1 Mid Sneaker, Adult ";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDescription.Location = new System.Drawing.Point(-2, 0);
            this.lblDescription.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(299, 299);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = resources.GetString("lblDescription.Text");
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.ForeColor = System.Drawing.Color.Green;
            this.lblPrice.Location = new System.Drawing.Point(382, 274);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(151, 23);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price: $119.99";
            // 
            // lblNote
            // 
            this.lblNote.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblNote.ForeColor = System.Drawing.Color.DimGray;
            this.lblNote.Location = new System.Drawing.Point(382, 328);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(307, 52);
            this.lblNote.TabIndex = 4;
            this.lblNote.Text = "Only few left. Don\'t be late, add to cart now!\r\n";
            // 
            // btnAddToCartNow
            // 
            this.btnAddToCartNow.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddToCartNow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToCartNow.ForeColor = System.Drawing.Color.White;
            this.btnAddToCartNow.Location = new System.Drawing.Point(12, 377);
            this.btnAddToCartNow.Name = "btnAddToCartNow";
            this.btnAddToCartNow.Size = new System.Drawing.Size(350, 32);
            this.btnAddToCartNow.TabIndex = 5;
            this.btnAddToCartNow.Text = "Add to cart now";
            this.btnAddToCartNow.UseVisualStyleBackColor = false;
            // 
            // nudQuantityCounter
            // 
            this.nudQuantityCounter.Location = new System.Drawing.Point(656, 380);
            this.nudQuantityCounter.Name = "nudQuantityCounter";
            this.nudQuantityCounter.Size = new System.Drawing.Size(50, 30);
            this.nudQuantityCounter.TabIndex = 6;
            this.nudQuantityCounter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSelectQuantity
            // 
            this.lblSelectQuantity.AutoSize = true;
            this.lblSelectQuantity.ForeColor = System.Drawing.Color.Black;
            this.lblSelectQuantity.Location = new System.Drawing.Point(550, 382);
            this.lblSelectQuantity.Name = "lblSelectQuantity";
            this.lblSelectQuantity.Size = new System.Drawing.Size(100, 23);
            this.lblSelectQuantity.TabIndex = 7;
            this.lblSelectQuantity.Text = "Quantity:";
            // 
            // lblProductLeft
            // 
            this.lblProductLeft.AutoSize = true;
            this.lblProductLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblProductLeft.Location = new System.Drawing.Point(382, 297);
            this.lblProductLeft.Name = "lblProductLeft";
            this.lblProductLeft.Size = new System.Drawing.Size(219, 23);
            this.lblProductLeft.TabIndex = 8;
            this.lblProductLeft.Text = "Total product Left: 10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(381, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Size:";
            // 
            // cbxSize
            // 
            this.cbxSize.FormattingEnabled = true;
            this.cbxSize.Location = new System.Drawing.Point(446, 379);
            this.cbxSize.Name = "cbxSize";
            this.cbxSize.Size = new System.Drawing.Size(87, 31);
            this.cbxSize.TabIndex = 11;
            this.cbxSize.Text = "N/A";
            this.cbxSize.SelectedIndexChanged += new System.EventHandler(this.cbxSize_SelectedIndexChanged);
            // 
            // pnlScrollableDetailsArea
            // 
            this.pnlScrollableDetailsArea.AutoScroll = true;
            this.pnlScrollableDetailsArea.Controls.Add(this.lblDescription);
            this.pnlScrollableDetailsArea.Location = new System.Drawing.Point(385, 102);
            this.pnlScrollableDetailsArea.Name = "pnlScrollableDetailsArea";
            this.pnlScrollableDetailsArea.Size = new System.Drawing.Size(321, 159);
            this.pnlScrollableDetailsArea.TabIndex = 12;
            // 
            // frmItemDetailedInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(718, 423);
            this.Controls.Add(this.cbxSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProductLeft);
            this.Controls.Add(this.lblSelectQuantity);
            this.Controls.Add(this.nudQuantityCounter);
            this.Controls.Add(this.btnAddToCartNow);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.pbxItemImage);
            this.Controls.Add(this.pnlScrollableDetailsArea);
            this.Font = new System.Drawing.Font("Verdana", 14F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.MaximizeBox = false;
            this.Name = "frmItemDetailedInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nike Mens Air Jordan 1...";
            this.Load += new System.EventHandler(this.frmItemDetailedInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxItemImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantityCounter)).EndInit();
            this.pnlScrollableDetailsArea.ResumeLayout(false);
            this.pnlScrollableDetailsArea.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxItemImage;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Button btnAddToCartNow;
        private System.Windows.Forms.NumericUpDown nudQuantityCounter;
        private System.Windows.Forms.Label lblSelectQuantity;
        private System.Windows.Forms.Label lblProductLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxSize;
        private System.Windows.Forms.Panel pnlScrollableDetailsArea;
    }
}