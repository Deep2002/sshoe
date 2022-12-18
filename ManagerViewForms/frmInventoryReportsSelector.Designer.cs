namespace FinalProject.ManagerViewForms
{
    partial class frmInventoryReportsSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventoryReportsSelector));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnForSaleItems = new System.Windows.Forms.Button();
            this.btnRestockItem = new System.Windows.Forms.Button();
            this.btnAllItems = new System.Windows.Forms.Button();
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.mnuMenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Trebuchet MS", 19F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitle.Location = new System.Drawing.Point(228, 54);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(491, 33);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Print Reports by selecting buttons below.";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Trebuchet MS", 18F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(406, 250);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 66);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnForSaleItems
            // 
            this.btnForSaleItems.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnForSaleItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForSaleItems.Font = new System.Drawing.Font("Trebuchet MS", 18F);
            this.btnForSaleItems.ForeColor = System.Drawing.Color.White;
            this.btnForSaleItems.Location = new System.Drawing.Point(12, 142);
            this.btnForSaleItems.Name = "btnForSaleItems";
            this.btnForSaleItems.Size = new System.Drawing.Size(295, 66);
            this.btnForSaleItems.TabIndex = 9;
            this.btnForSaleItems.Text = "Items available for &sale";
            this.btnForSaleItems.UseVisualStyleBackColor = false;
            this.btnForSaleItems.Click += new System.EventHandler(this.btnForSaleItems_Click);
            // 
            // btnRestockItem
            // 
            this.btnRestockItem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRestockItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestockItem.Font = new System.Drawing.Font("Trebuchet MS", 18F);
            this.btnRestockItem.ForeColor = System.Drawing.Color.White;
            this.btnRestockItem.Location = new System.Drawing.Point(326, 142);
            this.btnRestockItem.Name = "btnRestockItem";
            this.btnRestockItem.Size = new System.Drawing.Size(295, 66);
            this.btnRestockItem.TabIndex = 12;
            this.btnRestockItem.Text = "Items needing &Restock";
            this.btnRestockItem.UseVisualStyleBackColor = false;
            this.btnRestockItem.Click += new System.EventHandler(this.btnRestockItem_Click);
            // 
            // btnAllItems
            // 
            this.btnAllItems.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAllItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllItems.Font = new System.Drawing.Font("Trebuchet MS", 18F);
            this.btnAllItems.ForeColor = System.Drawing.Color.White;
            this.btnAllItems.Location = new System.Drawing.Point(640, 142);
            this.btnAllItems.Name = "btnAllItems";
            this.btnAllItems.Size = new System.Drawing.Size(295, 66);
            this.btnAllItems.TabIndex = 13;
            this.btnAllItems.Text = "&All Items";
            this.btnAllItems.UseVisualStyleBackColor = false;
            this.btnAllItems.Click += new System.EventHandler(this.btnAllItems_Click);
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
            this.mnuMenu.Size = new System.Drawing.Size(947, 31);
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
            // frmInventoryReportsSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 351);
            this.Controls.Add(this.mnuMenu);
            this.Controls.Add(this.btnAllItems);
            this.Controls.Add(this.btnRestockItem);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnForSaleItems);
            this.Font = new System.Drawing.Font("Trebuchet MS", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "frmInventoryReportsSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Reports";
            this.Load += new System.EventHandler(this.frmInventoryReportsSelector_Load);
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnForSaleItems;
        private System.Windows.Forms.Button btnRestockItem;
        private System.Windows.Forms.Button btnAllItems;
        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuMenuHelp;
    }
}