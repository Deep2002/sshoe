namespace FinalProject.ManagerViewForms
{
    partial class frmNotifications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotifications));
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityLeft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RestockThreshold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditQuantity = new System.Windows.Forms.Button();
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.mnuMenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.mnuMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(531, 57);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(363, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "List of low on quantity Items";
            // 
            // dgvItems
            // 
            this.dgvItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.QuantityLeft,
            this.ID,
            this.RestockThreshold});
            this.dgvItems.Location = new System.Drawing.Point(28, 134);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowTemplate.Height = 24;
            this.dgvItems.Size = new System.Drawing.Size(1368, 512);
            this.dgvItems.TabIndex = 1;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // QuantityLeft
            // 
            this.QuantityLeft.HeaderText = "Quantity Left";
            this.QuantityLeft.Name = "QuantityLeft";
            this.QuantityLeft.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "Item ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // RestockThreshold
            // 
            this.RestockThreshold.HeaderText = "Restock Threshold";
            this.RestockThreshold.Name = "RestockThreshold";
            this.RestockThreshold.ReadOnly = true;
            // 
            // btnEditQuantity
            // 
            this.btnEditQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditQuantity.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditQuantity.FlatAppearance.BorderSize = 0;
            this.btnEditQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditQuantity.ForeColor = System.Drawing.Color.White;
            this.btnEditQuantity.Location = new System.Drawing.Point(561, 687);
            this.btnEditQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditQuantity.Name = "btnEditQuantity";
            this.btnEditQuantity.Size = new System.Drawing.Size(302, 64);
            this.btnEditQuantity.TabIndex = 20;
            this.btnEditQuantity.Text = "Edit &Quantity";
            this.btnEditQuantity.UseVisualStyleBackColor = false;
            this.btnEditQuantity.Click += new System.EventHandler(this.btnEditQuantity_Click);
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
            // frmNotifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 781);
            this.Controls.Add(this.mnuMenu);
            this.Controls.Add(this.btnEditQuantity);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Trebuchet MS", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmNotifications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notifications";
            this.Load += new System.EventHandler(this.frmNotifications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityLeft;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RestockThreshold;
        private System.Windows.Forms.Button btnEditQuantity;
        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuMenuHelp;
    }
}