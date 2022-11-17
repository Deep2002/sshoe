﻿namespace FinalProject.ManagerViewForms
{
    partial class frmUserManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserManager));
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.tbxSearchBar = new System.Windows.Forms.TextBox();
            this.btnUpdateUserInfo = new System.Windows.Forms.Button();
            this.btnShowCustomers = new System.Windows.Forms.Button();
            this.btnShowEmployees = new System.Windows.Forms.Button();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.Email,
            this.Phone,
            this.ID});
            this.dgvUsers.Location = new System.Drawing.Point(31, 124);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.Size = new System.Drawing.Size(1368, 512);
            this.dgvUsers.TabIndex = 0;
            // 
            // tbxSearchBar
            // 
            this.tbxSearchBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbxSearchBar.ForeColor = System.Drawing.Color.Black;
            this.tbxSearchBar.Location = new System.Drawing.Point(374, 49);
            this.tbxSearchBar.Margin = new System.Windows.Forms.Padding(2);
            this.tbxSearchBar.Name = "tbxSearchBar";
            this.tbxSearchBar.Size = new System.Drawing.Size(677, 29);
            this.tbxSearchBar.TabIndex = 1;
            this.tbxSearchBar.Text = "Search User...";
            this.tbxSearchBar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbxSearchBar_MouseClick);
            this.tbxSearchBar.TextChanged += new System.EventHandler(this.tbxSearchBar_TextChanged);
            // 
            // btnUpdateUserInfo
            // 
            this.btnUpdateUserInfo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdateUserInfo.FlatAppearance.BorderSize = 0;
            this.btnUpdateUserInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUserInfo.ForeColor = System.Drawing.Color.White;
            this.btnUpdateUserInfo.Location = new System.Drawing.Point(741, 667);
            this.btnUpdateUserInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateUserInfo.Name = "btnUpdateUserInfo";
            this.btnUpdateUserInfo.Size = new System.Drawing.Size(302, 83);
            this.btnUpdateUserInfo.TabIndex = 16;
            this.btnUpdateUserInfo.Text = "Update / View Selected User\r\n Infromation";
            this.btnUpdateUserInfo.UseVisualStyleBackColor = false;
            this.btnUpdateUserInfo.Click += new System.EventHandler(this.btnUpdateUserInfo_Click);
            // 
            // btnShowCustomers
            // 
            this.btnShowCustomers.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnShowCustomers.FlatAppearance.BorderSize = 0;
            this.btnShowCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowCustomers.ForeColor = System.Drawing.Color.White;
            this.btnShowCustomers.Location = new System.Drawing.Point(31, 667);
            this.btnShowCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowCustomers.Name = "btnShowCustomers";
            this.btnShowCustomers.Size = new System.Drawing.Size(302, 83);
            this.btnShowCustomers.TabIndex = 17;
            this.btnShowCustomers.Text = "Show Customers";
            this.btnShowCustomers.UseVisualStyleBackColor = false;
            this.btnShowCustomers.Click += new System.EventHandler(this.btnShowCustomers_Click);
            // 
            // btnShowEmployees
            // 
            this.btnShowEmployees.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnShowEmployees.FlatAppearance.BorderSize = 0;
            this.btnShowEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowEmployees.ForeColor = System.Drawing.Color.White;
            this.btnShowEmployees.Location = new System.Drawing.Point(386, 667);
            this.btnShowEmployees.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowEmployees.Name = "btnShowEmployees";
            this.btnShowEmployees.Size = new System.Drawing.Size(302, 83);
            this.btnShowEmployees.TabIndex = 18;
            this.btnShowEmployees.Text = "Show Emoployees";
            this.btnShowEmployees.UseVisualStyleBackColor = false;
            this.btnShowEmployees.Click += new System.EventHandler(this.btnShowEmployees_Click);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddNewUser.FlatAppearance.BorderSize = 0;
            this.btnAddNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewUser.ForeColor = System.Drawing.Color.White;
            this.btnAddNewUser.Location = new System.Drawing.Point(1096, 667);
            this.btnAddNewUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(302, 83);
            this.btnAddNewUser.TabIndex = 19;
            this.btnAddNewUser.Text = "Add New User";
            this.btnAddNewUser.UseVisualStyleBackColor = false;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.Green;
            this.lblInfo.Location = new System.Drawing.Point(27, 85);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(206, 24);
            this.lblInfo.TabIndex = 20;
            this.lblInfo.Text = "Displaying Customers:";
            // 
            // UserName
            // 
            this.UserName.HeaderText = "Name";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // frmUserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 781);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.btnShowEmployees);
            this.Controls.Add(this.btnShowCustomers);
            this.Controls.Add(this.btnUpdateUserInfo);
            this.Controls.Add(this.tbxSearchBar);
            this.Controls.Add(this.dgvUsers);
            this.Font = new System.Drawing.Font("Trebuchet MS", 14F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUserManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users Manager";
            this.Load += new System.EventHandler(this.frmUsersManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.TextBox tbxSearchBar;
        private System.Windows.Forms.Button btnUpdateUserInfo;
        private System.Windows.Forms.Button btnShowCustomers;
        private System.Windows.Forms.Button btnShowEmployees;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}