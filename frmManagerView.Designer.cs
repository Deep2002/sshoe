namespace FinalProject
{
    partial class frmManagerView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManagerView));
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMenuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlInfoBar = new System.Windows.Forms.Panel();
            this.pbxUserPorfile = new System.Windows.Forms.PictureBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnDiscounts = new System.Windows.Forms.Button();
            this.btnNotifications = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnPos = new System.Windows.Forms.Button();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlNavigationView = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.mnuMenu.SuspendLayout();
            this.pnlInfoBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUserPorfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            this.pnlNavigationView.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMenu
            // 
            this.mnuMenu.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuAbout});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mnuMenu.Size = new System.Drawing.Size(1232, 31);
            this.mnuMenu.TabIndex = 4;
            this.mnuMenu.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMenuLogout,
            this.mnuMenuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(56, 27);
            this.mnuFile.Text = "&File";
            // 
            // mnuMenuLogout
            // 
            this.mnuMenuLogout.Name = "mnuMenuLogout";
            this.mnuMenuLogout.Size = new System.Drawing.Size(146, 28);
            this.mnuMenuLogout.Text = "&Logout";
            // 
            // mnuMenuExit
            // 
            this.mnuMenuExit.Name = "mnuMenuExit";
            this.mnuMenuExit.Size = new System.Drawing.Size(146, 28);
            this.mnuMenuExit.Text = "E&xit";
            // 
            // mnuAbout
            // 
            this.mnuAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMenuHelp});
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mnuAbout.Size = new System.Drawing.Size(78, 27);
            this.mnuAbout.Text = "&About";
            // 
            // mnuMenuHelp
            // 
            this.mnuMenuHelp.Name = "mnuMenuHelp";
            this.mnuMenuHelp.Size = new System.Drawing.Size(123, 28);
            this.mnuMenuHelp.Text = "&Help";
            // 
            // pnlInfoBar
            // 
            this.pnlInfoBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlInfoBar.Controls.Add(this.pbxUserPorfile);
            this.pnlInfoBar.Controls.Add(this.lblUserName);
            this.pnlInfoBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfoBar.ForeColor = System.Drawing.Color.White;
            this.pnlInfoBar.Location = new System.Drawing.Point(0, 31);
            this.pnlInfoBar.Margin = new System.Windows.Forms.Padding(2);
            this.pnlInfoBar.Name = "pnlInfoBar";
            this.pnlInfoBar.Size = new System.Drawing.Size(1232, 44);
            this.pnlInfoBar.TabIndex = 5;
            // 
            // pbxUserPorfile
            // 
            this.pbxUserPorfile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pbxUserPorfile.BackColor = System.Drawing.Color.White;
            this.pbxUserPorfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxUserPorfile.Image = global::FinalProject.Properties.Resources.userProfileDefault;
            this.pbxUserPorfile.Location = new System.Drawing.Point(1190, 7);
            this.pbxUserPorfile.Margin = new System.Windows.Forms.Padding(2);
            this.pbxUserPorfile.Name = "pbxUserPorfile";
            this.pbxUserPorfile.Size = new System.Drawing.Size(31, 31);
            this.pbxUserPorfile.TabIndex = 6;
            this.pbxUserPorfile.TabStop = false;
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUserName.ForeColor = System.Drawing.Color.Lime;
            this.lblUserName.Location = new System.Drawing.Point(819, 10);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(366, 25);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Current Employee: Name";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Image = global::FinalProject.Properties.Resources.profileWhite;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(808, 258);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(15, 17, 15, 17);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.btnUsers.Size = new System.Drawing.Size(279, 129);
            this.btnUsers.TabIndex = 3;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            this.btnUsers.MouseEnter += new System.EventHandler(this.btnUsers_MouseEnter);
            this.btnUsers.MouseLeave += new System.EventHandler(this.btnUsers_MouseLeave);
            // 
            // btnDiscounts
            // 
            this.btnDiscounts.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDiscounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscounts.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscounts.ForeColor = System.Drawing.Color.White;
            this.btnDiscounts.Image = global::FinalProject.Properties.Resources.coupons;
            this.btnDiscounts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiscounts.Location = new System.Drawing.Point(808, 83);
            this.btnDiscounts.Margin = new System.Windows.Forms.Padding(15, 17, 15, 17);
            this.btnDiscounts.Name = "btnDiscounts";
            this.btnDiscounts.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.btnDiscounts.Size = new System.Drawing.Size(279, 129);
            this.btnDiscounts.TabIndex = 2;
            this.btnDiscounts.Text = "Discounts";
            this.btnDiscounts.UseVisualStyleBackColor = false;
            this.btnDiscounts.Click += new System.EventHandler(this.btnDiscounts_Click);
            this.btnDiscounts.MouseEnter += new System.EventHandler(this.btnDiscounts_MouseEnter);
            this.btnDiscounts.MouseLeave += new System.EventHandler(this.btnDiscounts_MouseLeave);
            // 
            // btnNotifications
            // 
            this.btnNotifications.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotifications.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotifications.ForeColor = System.Drawing.Color.White;
            this.btnNotifications.Image = global::FinalProject.Properties.Resources.notificationWhite;
            this.btnNotifications.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotifications.Location = new System.Drawing.Point(145, 258);
            this.btnNotifications.Margin = new System.Windows.Forms.Padding(15, 17, 15, 17);
            this.btnNotifications.Name = "btnNotifications";
            this.btnNotifications.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.btnNotifications.Size = new System.Drawing.Size(279, 129);
            this.btnNotifications.TabIndex = 5;
            this.btnNotifications.Text = "Notifications";
            this.btnNotifications.UseVisualStyleBackColor = false;
            this.btnNotifications.MouseEnter += new System.EventHandler(this.btnNotifications_MouseEnter);
            this.btnNotifications.MouseLeave += new System.EventHandler(this.btnNotifications_MouseLeave);
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.Color.Transparent;
            this.btnInventory.Image = ((System.Drawing.Image)(resources.GetObject("btnInventory.Image")));
            this.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.Location = new System.Drawing.Point(145, 83);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(15, 17, 15, 17);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.btnInventory.Size = new System.Drawing.Size(279, 129);
            this.btnInventory.TabIndex = 0;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            this.btnInventory.MouseEnter += new System.EventHandler(this.btnInventory_MouseEnter);
            this.btnInventory.MouseLeave += new System.EventHandler(this.btnInventory_MouseLeave);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Image = ((System.Drawing.Image)(resources.GetObject("btnReports.Image")));
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(482, 83);
            this.btnReports.Margin = new System.Windows.Forms.Padding(15, 17, 15, 17);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.btnReports.Size = new System.Drawing.Size(279, 129);
            this.btnReports.TabIndex = 1;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.MouseEnter += new System.EventHandler(this.btnReports_MouseEnter);
            this.btnReports.MouseLeave += new System.EventHandler(this.btnReports_MouseLeave);
            // 
            // btnPos
            // 
            this.btnPos.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPos.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPos.ForeColor = System.Drawing.Color.White;
            this.btnPos.Image = global::FinalProject.Properties.Resources.pos;
            this.btnPos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPos.Location = new System.Drawing.Point(482, 258);
            this.btnPos.Margin = new System.Windows.Forms.Padding(15, 17, 15, 17);
            this.btnPos.Name = "btnPos";
            this.btnPos.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.btnPos.Size = new System.Drawing.Size(279, 129);
            this.btnPos.TabIndex = 4;
            this.btnPos.Text = "Point of Sales";
            this.btnPos.UseVisualStyleBackColor = false;
            this.btnPos.Click += new System.EventHandler(this.btnPos_Click);
            this.btnPos.MouseEnter += new System.EventHandler(this.btnPos_MouseEnter);
            this.btnPos.MouseLeave += new System.EventHandler(this.btnPos_MouseLeave);
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            // 
            // pnlNavigationView
            // 
            this.pnlNavigationView.Controls.Add(this.lblTitle);
            this.pnlNavigationView.Controls.Add(this.btnUsers);
            this.pnlNavigationView.Controls.Add(this.btnInventory);
            this.pnlNavigationView.Controls.Add(this.btnDiscounts);
            this.pnlNavigationView.Controls.Add(this.btnPos);
            this.pnlNavigationView.Controls.Add(this.btnNotifications);
            this.pnlNavigationView.Controls.Add(this.btnReports);
            this.pnlNavigationView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNavigationView.Location = new System.Drawing.Point(0, 75);
            this.pnlNavigationView.Name = "pnlNavigationView";
            this.pnlNavigationView.Size = new System.Drawing.Size(1232, 470);
            this.pnlNavigationView.TabIndex = 7;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Trebuchet MS", 19F);
            this.lblTitle.Location = new System.Drawing.Point(316, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(603, 33);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Select button from below to see more information\r\n";
            // 
            // frmManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 545);
            this.Controls.Add(this.pnlNavigationView);
            this.Controls.Add(this.pnlInfoBar);
            this.Controls.Add(this.mnuMenu);
            this.Font = new System.Drawing.Font("Trebuchet MS", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "frmManagerView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager Access";
            this.Load += new System.EventHandler(this.frmManagerView_Load);
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.pnlInfoBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxUserPorfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            this.pnlNavigationView.ResumeLayout(false);
            this.pnlNavigationView.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuMenuLogout;
        private System.Windows.Forms.ToolStripMenuItem mnuMenuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuMenuHelp;
        private System.Windows.Forms.Panel pnlInfoBar;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox pbxUserPorfile;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnPos;
        private System.Windows.Forms.Button btnNotifications;
        private System.Windows.Forms.Button btnDiscounts;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private System.Windows.Forms.Panel pnlNavigationView;
        private System.Windows.Forms.Label lblTitle;
    }
}