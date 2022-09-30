namespace FinalProject
{
    partial class frmCreateNewPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateNewPassword));
            this.lblTitle = new System.Windows.Forms.Label();
            this.mnuMenuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMenuViewHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tbxConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.tbxNewPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.cbxHidePassword = new System.Windows.Forms.CheckBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.lblNewPasswordWrongMark = new System.Windows.Forms.Label();
            this.lblConfirmPasswordWrongMark = new System.Windows.Forms.Label();
            this.lblNewPasswordRightMark = new System.Windows.Forms.Label();
            this.lblConfirmPasswordRightMark = new System.Windows.Forms.Label();
            this.stsStatus = new System.Windows.Forms.StatusStrip();
            this.mnuMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitle.Location = new System.Drawing.Point(300, 53);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(408, 38);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Create New Password";
            // 
            // mnuMenuStrip
            // 
            this.mnuMenuStrip.BackColor = System.Drawing.Color.White;
            this.mnuMenuStrip.Font = new System.Drawing.Font("Verdana", 12F);
            this.mnuMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelp});
            this.mnuMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuMenuStrip.Name = "mnuMenuStrip";
            this.mnuMenuStrip.Size = new System.Drawing.Size(984, 26);
            this.mnuMenuStrip.TabIndex = 0;
            this.mnuMenuStrip.Text = "menuStrip1";
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMenuViewHelp,
            this.mnuMenuAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(57, 22);
            this.mnuHelp.Text = "&Help";
            // 
            // mnuMenuViewHelp
            // 
            this.mnuMenuViewHelp.Image = global::FinalProject.Properties.Resources.help1;
            this.mnuMenuViewHelp.Name = "mnuMenuViewHelp";
            this.mnuMenuViewHelp.Size = new System.Drawing.Size(158, 22);
            this.mnuMenuViewHelp.Text = "&View Help";
            // 
            // mnuMenuAbout
            // 
            this.mnuMenuAbout.Name = "mnuMenuAbout";
            this.mnuMenuAbout.Size = new System.Drawing.Size(158, 22);
            this.mnuMenuAbout.Text = "&About";
            // 
            // tbxConfirmPassword
            // 
            this.tbxConfirmPassword.Location = new System.Drawing.Point(471, 194);
            this.tbxConfirmPassword.MaxLength = 20;
            this.tbxConfirmPassword.Name = "tbxConfirmPassword";
            this.tbxConfirmPassword.PasswordChar = '●';
            this.tbxConfirmPassword.ShortcutsEnabled = false;
            this.tbxConfirmPassword.Size = new System.Drawing.Size(247, 30);
            this.tbxConfirmPassword.TabIndex = 2;
            this.tbxConfirmPassword.TextChanged += new System.EventHandler(this.tbxConfirmPassword_TextChanged);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(233, 198);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(192, 23);
            this.lblConfirmPassword.TabIndex = 13;
            this.lblConfirmPassword.Text = "Confirm Password:";
            // 
            // tbxNewPassword
            // 
            this.tbxNewPassword.Location = new System.Drawing.Point(471, 156);
            this.tbxNewPassword.MaxLength = 20;
            this.tbxNewPassword.Name = "tbxNewPassword";
            this.tbxNewPassword.PasswordChar = '●';
            this.tbxNewPassword.ShortcutsEnabled = false;
            this.tbxNewPassword.Size = new System.Drawing.Size(247, 30);
            this.tbxNewPassword.TabIndex = 1;
            this.tbxNewPassword.TextChanged += new System.EventHandler(this.tbxNewPassword_TextChanged);
            this.tbxNewPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNewPassword_KeyPress);
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(233, 159);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(157, 23);
            this.lblNewPassword.TabIndex = 10;
            this.lblNewPassword.Text = "New Password:";
            // 
            // cbxHidePassword
            // 
            this.cbxHidePassword.AutoSize = true;
            this.cbxHidePassword.Checked = true;
            this.cbxHidePassword.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxHidePassword.Location = new System.Drawing.Point(389, 248);
            this.cbxHidePassword.Name = "cbxHidePassword";
            this.cbxHidePassword.Size = new System.Drawing.Size(169, 27);
            this.cbxHidePassword.TabIndex = 3;
            this.cbxHidePassword.Text = "Hide Password";
            this.cbxHidePassword.UseVisualStyleBackColor = true;
            this.cbxHidePassword.CheckedChanged += new System.EventHandler(this.cbxHidePassword_CheckedChanged);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDone.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.Location = new System.Drawing.Point(347, 329);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(247, 43);
            this.btnDone.TabIndex = 4;
            this.btnDone.Text = "&Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // lblNewPasswordWrongMark
            // 
            this.lblNewPasswordWrongMark.AutoSize = true;
            this.lblNewPasswordWrongMark.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPasswordWrongMark.ForeColor = System.Drawing.Color.Red;
            this.lblNewPasswordWrongMark.Location = new System.Drawing.Point(724, 155);
            this.lblNewPasswordWrongMark.Name = "lblNewPasswordWrongMark";
            this.lblNewPasswordWrongMark.Size = new System.Drawing.Size(33, 23);
            this.lblNewPasswordWrongMark.TabIndex = 26;
            this.lblNewPasswordWrongMark.Text = "❌";
            this.lblNewPasswordWrongMark.Visible = false;
            // 
            // lblConfirmPasswordWrongMark
            // 
            this.lblConfirmPasswordWrongMark.AutoSize = true;
            this.lblConfirmPasswordWrongMark.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPasswordWrongMark.ForeColor = System.Drawing.Color.Red;
            this.lblConfirmPasswordWrongMark.Location = new System.Drawing.Point(724, 194);
            this.lblConfirmPasswordWrongMark.Name = "lblConfirmPasswordWrongMark";
            this.lblConfirmPasswordWrongMark.Size = new System.Drawing.Size(33, 23);
            this.lblConfirmPasswordWrongMark.TabIndex = 27;
            this.lblConfirmPasswordWrongMark.Text = "❌";
            this.lblConfirmPasswordWrongMark.Visible = false;
            // 
            // lblNewPasswordRightMark
            // 
            this.lblNewPasswordRightMark.AutoSize = true;
            this.lblNewPasswordRightMark.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPasswordRightMark.ForeColor = System.Drawing.Color.Green;
            this.lblNewPasswordRightMark.Location = new System.Drawing.Point(724, 159);
            this.lblNewPasswordRightMark.Name = "lblNewPasswordRightMark";
            this.lblNewPasswordRightMark.Size = new System.Drawing.Size(33, 23);
            this.lblNewPasswordRightMark.TabIndex = 28;
            this.lblNewPasswordRightMark.Text = "✔️";
            this.lblNewPasswordRightMark.Visible = false;
            // 
            // lblConfirmPasswordRightMark
            // 
            this.lblConfirmPasswordRightMark.AutoSize = true;
            this.lblConfirmPasswordRightMark.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPasswordRightMark.ForeColor = System.Drawing.Color.Green;
            this.lblConfirmPasswordRightMark.Location = new System.Drawing.Point(724, 197);
            this.lblConfirmPasswordRightMark.Name = "lblConfirmPasswordRightMark";
            this.lblConfirmPasswordRightMark.Size = new System.Drawing.Size(33, 23);
            this.lblConfirmPasswordRightMark.TabIndex = 29;
            this.lblConfirmPasswordRightMark.Text = "✔️";
            this.lblConfirmPasswordRightMark.Visible = false;
            // 
            // stsStatus
            // 
            this.stsStatus.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stsStatus.Location = new System.Drawing.Point(0, 439);
            this.stsStatus.Name = "stsStatus";
            this.stsStatus.Size = new System.Drawing.Size(984, 22);
            this.stsStatus.SizingGrip = false;
            this.stsStatus.TabIndex = 25;
            this.stsStatus.Text = "statusStrip1";
            // 
            // frmCreateNewPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.lblConfirmPasswordRightMark);
            this.Controls.Add(this.lblNewPasswordRightMark);
            this.Controls.Add(this.lblConfirmPasswordWrongMark);
            this.Controls.Add(this.lblNewPasswordWrongMark);
            this.Controls.Add(this.stsStatus);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.cbxHidePassword);
            this.Controls.Add(this.tbxConfirmPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.tbxNewPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.mnuMenuStrip);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Verdana", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.MaximizeBox = false;
            this.Name = "frmCreateNewPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Password";
            this.mnuMenuStrip.ResumeLayout(false);
            this.mnuMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.MenuStrip mnuMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuMenuViewHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuMenuAbout;
        private System.Windows.Forms.TextBox tbxConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox tbxNewPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.CheckBox cbxHidePassword;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label lblNewPasswordWrongMark;
        private System.Windows.Forms.Label lblConfirmPasswordWrongMark;
        private System.Windows.Forms.Label lblNewPasswordRightMark;
        private System.Windows.Forms.Label lblConfirmPasswordRightMark;
        private System.Windows.Forms.StatusStrip stsStatus;
    }
}