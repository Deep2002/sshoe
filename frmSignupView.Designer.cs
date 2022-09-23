
namespace FinalProject
{
    partial class frmSignupView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSignupView));
            this.lblTitle = new System.Windows.Forms.Label();
            this.mnuMenuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMenuViewHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.tbxConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.tbxZIP = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblZIP = new System.Windows.Forms.Label();
            this.cbxState = new System.Windows.Forms.ComboBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblNote = new System.Windows.Forms.Label();
            this.stsStatus = new System.Windows.Forms.StatusStrip();
            this.lblGoToLogin = new System.Windows.Forms.Label();
            this.lblOr = new System.Windows.Forms.Label();
            this.cbxHidePassword = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lblRequired = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.mnuMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTitle.Location = new System.Drawing.Point(422, 44);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(141, 38);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Signup";
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
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(700, 111);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '●';
            this.tbxPassword.ShortcutsEnabled = false;
            this.tbxPassword.Size = new System.Drawing.Size(247, 30);
            this.tbxPassword.TabIndex = 8;
            this.tbxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPassword_KeyPress);
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(236, 187);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.ShortcutsEnabled = false;
            this.tbxUsername.Size = new System.Drawing.Size(247, 30);
            this.tbxUsername.TabIndex = 3;
            this.tbxUsername.TextChanged += new System.EventHandler(this.tbxUsername_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(502, 111);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(109, 23);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(38, 189);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(114, 23);
            this.lblUserName.TabIndex = 6;
            this.lblUserName.Text = "Username:";
            // 
            // tbxConfirmPassword
            // 
            this.tbxConfirmPassword.Location = new System.Drawing.Point(700, 149);
            this.tbxConfirmPassword.Name = "tbxConfirmPassword";
            this.tbxConfirmPassword.PasswordChar = '●';
            this.tbxConfirmPassword.ShortcutsEnabled = false;
            this.tbxConfirmPassword.Size = new System.Drawing.Size(247, 30);
            this.tbxConfirmPassword.TabIndex = 9;
            this.tbxConfirmPassword.TextChanged += new System.EventHandler(this.tbxConfirmPassword_TextChanged);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(502, 150);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(192, 23);
            this.lblConfirmPassword.TabIndex = 9;
            this.lblConfirmPassword.Text = "Confirm Password:";
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(236, 111);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.ShortcutsEnabled = false;
            this.tbxFirstName.Size = new System.Drawing.Size(247, 30);
            this.tbxFirstName.TabIndex = 1;
            this.tbxFirstName.TextChanged += new System.EventHandler(this.tbxFirstName_TextChanged);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(38, 111);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(122, 23);
            this.lblFirstName.TabIndex = 11;
            this.lblFirstName.Text = "First Name:";
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(236, 225);
            this.tbxAddress.Multiline = true;
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.ShortcutsEnabled = false;
            this.tbxAddress.Size = new System.Drawing.Size(247, 80);
            this.tbxAddress.TabIndex = 4;
            this.tbxAddress.TextChanged += new System.EventHandler(this.tbxAddress_TextChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(38, 228);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(95, 23);
            this.lblAddress.TabIndex = 15;
            this.lblAddress.Text = "Address:";
            // 
            // tbxCity
            // 
            this.tbxCity.Location = new System.Drawing.Point(236, 313);
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.ShortcutsEnabled = false;
            this.tbxCity.Size = new System.Drawing.Size(247, 30);
            this.tbxCity.TabIndex = 5;
            this.tbxCity.TextChanged += new System.EventHandler(this.tbxCity_TextChanged);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(38, 316);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(56, 23);
            this.lblCity.TabIndex = 13;
            this.lblCity.Text = "City:";
            // 
            // tbxZIP
            // 
            this.tbxZIP.Location = new System.Drawing.Point(236, 351);
            this.tbxZIP.MaxLength = 5;
            this.tbxZIP.Name = "tbxZIP";
            this.tbxZIP.ShortcutsEnabled = false;
            this.tbxZIP.Size = new System.Drawing.Size(97, 30);
            this.tbxZIP.TabIndex = 6;
            this.tbxZIP.TextChanged += new System.EventHandler(this.tbxZIP_TextChanged);
            this.tbxZIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxZIP_KeyPress);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(339, 355);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(68, 23);
            this.lblState.TabIndex = 19;
            this.lblState.Text = "State:";
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(236, 149);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.ShortcutsEnabled = false;
            this.tbxLastName.Size = new System.Drawing.Size(247, 30);
            this.tbxLastName.TabIndex = 2;
            this.tbxLastName.TextChanged += new System.EventHandler(this.tbxLastName_TextChanged);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(38, 150);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(119, 23);
            this.lblLastName.TabIndex = 17;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblZIP
            // 
            this.lblZIP.AutoSize = true;
            this.lblZIP.Location = new System.Drawing.Point(38, 355);
            this.lblZIP.Name = "lblZIP";
            this.lblZIP.Size = new System.Drawing.Size(51, 23);
            this.lblZIP.TabIndex = 20;
            this.lblZIP.Text = "ZIP:";
            // 
            // cbxState
            // 
            this.cbxState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxState.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxState.FormattingEnabled = true;
            this.cbxState.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.cbxState.Location = new System.Drawing.Point(423, 351);
            this.cbxState.MaxLength = 2;
            this.cbxState.Name = "cbxState";
            this.cbxState.Size = new System.Drawing.Size(60, 31);
            this.cbxState.TabIndex = 7;
            this.cbxState.TextChanged += new System.EventHandler(this.cbxState_TextChanged);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNext.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(700, 218);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(247, 43);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "&Next ";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblNote
            // 
            this.lblNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.lblNote.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNote.Location = new System.Drawing.Point(502, 275);
            this.lblNote.Name = "lblNote";
            this.lblNote.Padding = new System.Windows.Forms.Padding(5);
            this.lblNote.Size = new System.Drawing.Size(441, 107);
            this.lblNote.TabIndex = 23;
            this.lblNote.Text = "Note: It is important that all information is filed appropriately. Please press n" +
    "ext once you are satisfied. If something is wrong, you will find it in the botto" +
    "m status bar.";
            // 
            // stsStatus
            // 
            this.stsStatus.Font = new System.Drawing.Font("Verdana", 11F);
            this.stsStatus.Location = new System.Drawing.Point(0, 439);
            this.stsStatus.Name = "stsStatus";
            this.stsStatus.Size = new System.Drawing.Size(984, 22);
            this.stsStatus.TabIndex = 24;
            this.stsStatus.Text = "statusStrip1";
            // 
            // lblGoToLogin
            // 
            this.lblGoToLogin.AutoSize = true;
            this.lblGoToLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGoToLogin.ForeColor = System.Drawing.Color.SlateGray;
            this.lblGoToLogin.Location = new System.Drawing.Point(502, 228);
            this.lblGoToLogin.Name = "lblGoToLogin";
            this.lblGoToLogin.Size = new System.Drawing.Size(123, 23);
            this.lblGoToLogin.TabIndex = 25;
            this.lblGoToLogin.Text = "&Go to Login";
            this.lblGoToLogin.Click += new System.EventHandler(this.lblGoToLogin_Click);
            // 
            // lblOr
            // 
            this.lblOr.AutoSize = true;
            this.lblOr.Location = new System.Drawing.Point(642, 228);
            this.lblOr.Name = "lblOr";
            this.lblOr.Size = new System.Drawing.Size(30, 23);
            this.lblOr.TabIndex = 26;
            this.lblOr.Text = "or";
            // 
            // cbxHidePassword
            // 
            this.cbxHidePassword.AutoSize = true;
            this.cbxHidePassword.Checked = true;
            this.cbxHidePassword.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxHidePassword.Location = new System.Drawing.Point(737, 185);
            this.cbxHidePassword.Name = "cbxHidePassword";
            this.cbxHidePassword.Size = new System.Drawing.Size(169, 27);
            this.cbxHidePassword.TabIndex = 27;
            this.cbxHidePassword.Text = "Hide Password";
            this.cbxHidePassword.UseVisualStyleBackColor = true;
            this.cbxHidePassword.CheckedChanged += new System.EventHandler(this.cbxHidePassword_CheckedChanged);
            // 
            // toolTip
            // 
            this.toolTip.IsBalloon = true;
            // 
            // lblRequired
            // 
            this.lblRequired.AutoSize = true;
            this.lblRequired.ForeColor = System.Drawing.Color.Red;
            this.lblRequired.Location = new System.Drawing.Point(208, 118);
            this.lblRequired.Name = "lblRequired";
            this.lblRequired.Size = new System.Drawing.Size(22, 23);
            this.lblRequired.TabIndex = 28;
            this.lblRequired.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(208, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(208, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 23);
            this.label2.TabIndex = 31;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(208, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(208, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 23);
            this.label4.TabIndex = 33;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(208, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 23);
            this.label5.TabIndex = 32;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(950, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 23);
            this.label6.TabIndex = 35;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(950, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 23);
            this.label7.TabIndex = 34;
            this.label7.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(401, 354);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 23);
            this.label9.TabIndex = 36;
            this.label9.Text = "*";
            // 
            // frmSignupView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRequired);
            this.Controls.Add(this.cbxHidePassword);
            this.Controls.Add(this.lblOr);
            this.Controls.Add(this.lblGoToLogin);
            this.Controls.Add(this.stsStatus);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.cbxState);
            this.Controls.Add(this.lblZIP);
            this.Controls.Add(this.tbxZIP);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.tbxCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.tbxFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.tbxConfirmPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.mnuMenuStrip);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Verdana", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "frmSignupView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signup View";
            this.TopMost = true;
            this.mnuMenuStrip.ResumeLayout(false);
            this.mnuMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.MenuStrip mnuMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuMenuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuMenuViewHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuMenuAbout;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox tbxConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox tbxZIP;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblZIP;
        private System.Windows.Forms.ComboBox cbxState;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.StatusStrip stsStatus;
        private System.Windows.Forms.Label lblGoToLogin;
        private System.Windows.Forms.Label lblOr;
        private System.Windows.Forms.CheckBox cbxHidePassword;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label lblRequired;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
    }
}