
namespace FinalProject
{
    partial class frmLogon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogon));
            this.lblTitle = new System.Windows.Forms.Label();
            this.mnuMenuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMenuViewHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.lblForgotPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.cbxHidePassword = new System.Windows.Forms.CheckBox();
            this.stsStatus = new System.Windows.Forms.StatusStrip();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnContinueWithoutLogin = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.mnuMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTitle.Location = new System.Drawing.Point(435, 67);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(115, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Login";
            // 
            // mnuMenuStrip
            // 
            this.mnuMenuStrip.BackColor = System.Drawing.Color.White;
            this.mnuMenuStrip.Font = new System.Drawing.Font("Verdana", 12F);
            this.mnuMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuHelp});
            this.mnuMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuMenuStrip.Name = "mnuMenuStrip";
            this.mnuMenuStrip.Size = new System.Drawing.Size(984, 26);
            this.mnuMenuStrip.TabIndex = 0;
            this.mnuMenuStrip.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMenuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(49, 22);
            this.mnuFile.Text = "&File";
            // 
            // mnuMenuExit
            // 
            this.mnuMenuExit.Name = "mnuMenuExit";
            this.mnuMenuExit.Size = new System.Drawing.Size(107, 22);
            this.mnuMenuExit.Text = "E&xit";
            this.mnuMenuExit.Click += new System.EventHandler(this.mnuMenuExit_Click);
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
            this.mnuMenuViewHelp.Name = "mnuMenuViewHelp";
            this.mnuMenuViewHelp.Size = new System.Drawing.Size(180, 22);
            this.mnuMenuViewHelp.Text = "&View Help";
            this.mnuMenuViewHelp.Click += new System.EventHandler(this.mnuMenuViewHelp_Click);
            // 
            // mnuMenuAbout
            // 
            this.mnuMenuAbout.Name = "mnuMenuAbout";
            this.mnuMenuAbout.Size = new System.Drawing.Size(180, 22);
            this.mnuMenuAbout.Text = "&About";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(249, 134);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(114, 23);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password:";
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(369, 131);
            this.tbxUsername.MaxLength = 20;
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.ShortcutsEnabled = false;
            this.tbxUsername.Size = new System.Drawing.Size(247, 30);
            this.tbxUsername.TabIndex = 1;
            this.tbxUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxUsername_KeyDown);
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(369, 175);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '●';
            this.tbxPassword.ShortcutsEnabled = false;
            this.tbxPassword.Size = new System.Drawing.Size(247, 30);
            this.tbxPassword.TabIndex = 2;
            this.tbxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxPassword_KeyDown);
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.AutoSize = true;
            this.lblForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForgotPassword.ForeColor = System.Drawing.Color.Blue;
            this.lblForgotPassword.Location = new System.Drawing.Point(408, 225);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(169, 23);
            this.lblForgotPassword.TabIndex = 4;
            this.lblForgotPassword.Text = "Forgot &Password";
            this.lblForgotPassword.Click += new System.EventHandler(this.lblForgotPassword_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(351, 261);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(282, 43);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "&Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // cbxHidePassword
            // 
            this.cbxHidePassword.AutoSize = true;
            this.cbxHidePassword.Checked = true;
            this.cbxHidePassword.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxHidePassword.Location = new System.Drawing.Point(631, 178);
            this.cbxHidePassword.Name = "cbxHidePassword";
            this.cbxHidePassword.Size = new System.Drawing.Size(169, 27);
            this.cbxHidePassword.TabIndex = 3;
            this.cbxHidePassword.Text = "Hide Password";
            this.cbxHidePassword.UseVisualStyleBackColor = true;
            this.cbxHidePassword.CheckedChanged += new System.EventHandler(this.cbxHidePassword_CheckedChanged);
            // 
            // stsStatus
            // 
            this.stsStatus.AutoSize = false;
            this.stsStatus.Font = new System.Drawing.Font("Verdana", 14F);
            this.stsStatus.Location = new System.Drawing.Point(0, 427);
            this.stsStatus.Name = "stsStatus";
            this.stsStatus.Size = new System.Drawing.Size(984, 47);
            this.stsStatus.SizingGrip = false;
            this.stsStatus.TabIndex = 10;
            this.stsStatus.Text = "statusStrip1";
            // 
            // toolTip
            // 
            this.toolTip.IsBalloon = true;
            // 
            // btnContinueWithoutLogin
            // 
            this.btnContinueWithoutLogin.BackColor = System.Drawing.SystemColors.Control;
            this.btnContinueWithoutLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinueWithoutLogin.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnContinueWithoutLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnContinueWithoutLogin.Location = new System.Drawing.Point(351, 369);
            this.btnContinueWithoutLogin.Name = "btnContinueWithoutLogin";
            this.btnContinueWithoutLogin.Size = new System.Drawing.Size(282, 43);
            this.btnContinueWithoutLogin.TabIndex = 11;
            this.btnContinueWithoutLogin.Text = "&Continue without account";
            this.btnContinueWithoutLogin.UseVisualStyleBackColor = false;
            this.btnContinueWithoutLogin.Click += new System.EventHandler(this.btnContinueWithoutLogin_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.SystemColors.Control;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSignUp.Location = new System.Drawing.Point(351, 315);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(282, 43);
            this.btnSignUp.TabIndex = 12;
            this.btnSignUp.Text = "&Signup";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // frmLogon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 474);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnContinueWithoutLogin);
            this.Controls.Add(this.stsStatus);
            this.Controls.Add(this.cbxHidePassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblForgotPassword);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.mnuMenuStrip);
            this.Font = new System.Drawing.Font("Verdana", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "frmLogon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logon View";
            this.Load += new System.EventHandler(this.frmLogon_Load);
            this.mnuMenuStrip.ResumeLayout(false);
            this.mnuMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.MenuStrip mnuMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuMenuViewHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuMenuAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuMenuExit;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label lblForgotPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox cbxHidePassword;
        private System.Windows.Forms.StatusStrip stsStatus;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnContinueWithoutLogin;
        private System.Windows.Forms.Button btnSignUp;
    }
}