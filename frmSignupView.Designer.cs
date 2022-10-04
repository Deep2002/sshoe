
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
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.mnuMenuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMenuGoBack = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblNote = new System.Windows.Forms.Label();
            this.stsStatus = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblGoToLogin = new System.Windows.Forms.Label();
            this.lblOr = new System.Windows.Forms.Label();
            this.cbxHidePassword = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lblRequired = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbxMiddleName = new System.Windows.Forms.TextBox();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.cbxTitle = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbxPrimaryPhone = new System.Windows.Forms.TextBox();
            this.lblPrimaryPhone = new System.Windows.Forms.Label();
            this.tbxSecondaryPhone = new System.Windows.Forms.TextBox();
            this.lblSecondaryPhone = new System.Windows.Forms.Label();
            this.lblSuffix = new System.Windows.Forms.Label();
            this.tbxAddress3 = new System.Windows.Forms.TextBox();
            this.lblAddress3 = new System.Windows.Forms.Label();
            this.tbxAddress2 = new System.Windows.Forms.TextBox();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblZipState = new System.Windows.Forms.Label();
            this.tbxZIP = new System.Windows.Forms.TextBox();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.tbxSuffix = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxState = new System.Windows.Forms.ComboBox();
            this.mnuMenuStrip.SuspendLayout();
            this.stsStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblMainTitle.Location = new System.Drawing.Point(465, 44);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(141, 38);
            this.lblMainTitle.TabIndex = 1;
            this.lblMainTitle.Text = "Signup";
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
            this.mnuMenuStrip.Size = new System.Drawing.Size(1071, 26);
            this.mnuMenuStrip.TabIndex = 0;
            this.mnuMenuStrip.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMenuGoBack});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(49, 22);
            this.mnuFile.Text = "&File";
            // 
            // mnuMenuGoBack
            // 
            this.mnuMenuGoBack.Name = "mnuMenuGoBack";
            this.mnuMenuGoBack.Size = new System.Drawing.Size(180, 22);
            this.mnuMenuGoBack.Text = "Go &Back";
            this.mnuMenuGoBack.Click += new System.EventHandler(this.mnuMenuGoBack_Click);
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
            this.tbxPassword.Location = new System.Drawing.Point(757, 437);
            this.tbxPassword.MaxLength = 20;
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '●';
            this.tbxPassword.ShortcutsEnabled = false;
            this.tbxPassword.Size = new System.Drawing.Size(249, 30);
            this.tbxPassword.TabIndex = 15;
            this.tbxPassword.TextChanged += new System.EventHandler(this.tbxPassword_TextChanged);
            this.tbxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPassword_KeyPress);
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(263, 317);
            this.tbxUsername.MaxLength = 20;
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.ShortcutsEnabled = false;
            this.tbxUsername.Size = new System.Drawing.Size(247, 30);
            this.tbxUsername.TabIndex = 5;
            this.tbxUsername.TextChanged += new System.EventHandler(this.tbxUsername_TextChanged);
            this.tbxUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxUsername_KeyPress);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(536, 440);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(109, 23);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(65, 321);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(114, 23);
            this.lblUserName.TabIndex = 6;
            this.lblUserName.Text = "Username:";
            // 
            // tbxConfirmPassword
            // 
            this.tbxConfirmPassword.Location = new System.Drawing.Point(757, 473);
            this.tbxConfirmPassword.MaxLength = 20;
            this.tbxConfirmPassword.Name = "tbxConfirmPassword";
            this.tbxConfirmPassword.PasswordChar = '●';
            this.tbxConfirmPassword.ShortcutsEnabled = false;
            this.tbxConfirmPassword.Size = new System.Drawing.Size(249, 30);
            this.tbxConfirmPassword.TabIndex = 16;
            this.tbxConfirmPassword.TextChanged += new System.EventHandler(this.tbxConfirmPassword_TextChanged);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(536, 481);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(192, 23);
            this.lblConfirmPassword.TabIndex = 9;
            this.lblConfirmPassword.Text = "Confirm Password:";
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(263, 111);
            this.tbxFirstName.MaxLength = 20;
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.ShortcutsEnabled = false;
            this.tbxFirstName.Size = new System.Drawing.Size(247, 30);
            this.tbxFirstName.TabIndex = 0;
            this.tbxFirstName.TextChanged += new System.EventHandler(this.tbxFirstName_TextChanged);
            this.tbxFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxFirstName_KeyPress);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(65, 111);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(122, 23);
            this.lblFirstName.TabIndex = 11;
            this.lblFirstName.Text = "First Name:";
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(263, 152);
            this.tbxLastName.MaxLength = 20;
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.ShortcutsEnabled = false;
            this.tbxLastName.Size = new System.Drawing.Size(247, 30);
            this.tbxLastName.TabIndex = 1;
            this.tbxLastName.TextChanged += new System.EventHandler(this.tbxLastName_TextChanged);
            this.tbxLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxLastName_KeyPress);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(65, 153);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(119, 23);
            this.lblLastName.TabIndex = 17;
            this.lblLastName.Text = "Last Name:";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNext.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(757, 566);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(247, 43);
            this.btnNext.TabIndex = 17;
            this.btnNext.Text = "&Next ";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblNote
            // 
            this.lblNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.lblNote.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNote.Location = new System.Drawing.Point(65, 502);
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
            this.stsStatus.AutoSize = false;
            this.stsStatus.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stsStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.stsStatus.Location = new System.Drawing.Point(0, 637);
            this.stsStatus.Name = "stsStatus";
            this.stsStatus.Size = new System.Drawing.Size(1071, 37);
            this.stsStatus.SizingGrip = false;
            this.stsStatus.TabIndex = 24;
            this.stsStatus.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(141, 32);
            this.toolStripStatusLabel1.Text = "* Required Field";
            // 
            // lblGoToLogin
            // 
            this.lblGoToLogin.AutoSize = true;
            this.lblGoToLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGoToLogin.ForeColor = System.Drawing.Color.SlateGray;
            this.lblGoToLogin.Location = new System.Drawing.Point(536, 576);
            this.lblGoToLogin.Name = "lblGoToLogin";
            this.lblGoToLogin.Size = new System.Drawing.Size(123, 23);
            this.lblGoToLogin.TabIndex = 25;
            this.lblGoToLogin.Text = "&Go to Login";
            this.lblGoToLogin.Click += new System.EventHandler(this.lblGoToLogin_Click);
            // 
            // lblOr
            // 
            this.lblOr.AutoSize = true;
            this.lblOr.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOr.Location = new System.Drawing.Point(686, 576);
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
            this.cbxHidePassword.Location = new System.Drawing.Point(795, 513);
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
            this.lblRequired.Location = new System.Drawing.Point(235, 118);
            this.lblRequired.Name = "lblRequired";
            this.lblRequired.Size = new System.Drawing.Size(22, 23);
            this.lblRequired.TabIndex = 28;
            this.lblRequired.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(235, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(235, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(729, 479);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 23);
            this.label6.TabIndex = 35;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(729, 440);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 23);
            this.label7.TabIndex = 34;
            this.label7.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(235, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 23);
            this.label10.TabIndex = 41;
            this.label10.Text = "*";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(65, 237);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(61, 23);
            this.lblTitle.TabIndex = 40;
            this.lblTitle.Text = "Title:";
            // 
            // tbxMiddleName
            // 
            this.tbxMiddleName.Location = new System.Drawing.Point(263, 193);
            this.tbxMiddleName.MaxLength = 20;
            this.tbxMiddleName.Name = "tbxMiddleName";
            this.tbxMiddleName.ShortcutsEnabled = false;
            this.tbxMiddleName.Size = new System.Drawing.Size(247, 30);
            this.tbxMiddleName.TabIndex = 2;
            this.tbxMiddleName.TextChanged += new System.EventHandler(this.tbxMiddleName_TextChanged);
            this.tbxMiddleName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxMiddleName_KeyPress);
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(65, 195);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(143, 23);
            this.lblMiddleName.TabIndex = 39;
            this.lblMiddleName.Text = "Middle Name:";
            // 
            // cbxTitle
            // 
            this.cbxTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxTitle.FormattingEnabled = true;
            this.cbxTitle.Items.AddRange(new object[] {
            "Dr.",
            "Mr.",
            "Ms.",
            "Mrs.",
            "Mr.",
            "PFC",
            "LT.",
            "Gen.",
            "Adm.",
            "1stLt.",
            "Other"});
            this.cbxTitle.Location = new System.Drawing.Point(263, 234);
            this.cbxTitle.MaxLength = 2;
            this.cbxTitle.Name = "cbxTitle";
            this.cbxTitle.Size = new System.Drawing.Size(247, 31);
            this.cbxTitle.TabIndex = 3;
            this.cbxTitle.Text = "Select";
            this.cbxTitle.TextChanged += new System.EventHandler(this.cbxTitle_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(235, 364);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 23);
            this.label13.TabIndex = 46;
            this.label13.Text = "*";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(263, 358);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(247, 30);
            this.tbxEmail.TabIndex = 6;
            this.tbxEmail.TextChanged += new System.EventHandler(this.tbxEmail_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(65, 363);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(72, 23);
            this.lblEmail.TabIndex = 45;
            this.lblEmail.Text = "Email:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(235, 405);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 23);
            this.label15.TabIndex = 49;
            this.label15.Text = "*";
            // 
            // tbxPrimaryPhone
            // 
            this.tbxPrimaryPhone.Location = new System.Drawing.Point(263, 399);
            this.tbxPrimaryPhone.MaxLength = 12;
            this.tbxPrimaryPhone.Name = "tbxPrimaryPhone";
            this.tbxPrimaryPhone.ShortcutsEnabled = false;
            this.tbxPrimaryPhone.Size = new System.Drawing.Size(247, 30);
            this.tbxPrimaryPhone.TabIndex = 7;
            this.tbxPrimaryPhone.TextChanged += new System.EventHandler(this.tbxPrimaryPhone_TextChanged);
            // 
            // lblPrimaryPhone
            // 
            this.lblPrimaryPhone.AutoSize = true;
            this.lblPrimaryPhone.Location = new System.Drawing.Point(65, 405);
            this.lblPrimaryPhone.Name = "lblPrimaryPhone";
            this.lblPrimaryPhone.Size = new System.Drawing.Size(157, 23);
            this.lblPrimaryPhone.TabIndex = 48;
            this.lblPrimaryPhone.Text = "Primary Phone:";
            // 
            // tbxSecondaryPhone
            // 
            this.tbxSecondaryPhone.Location = new System.Drawing.Point(263, 440);
            this.tbxSecondaryPhone.MaxLength = 12;
            this.tbxSecondaryPhone.Name = "tbxSecondaryPhone";
            this.tbxSecondaryPhone.ShortcutsEnabled = false;
            this.tbxSecondaryPhone.Size = new System.Drawing.Size(247, 30);
            this.tbxSecondaryPhone.TabIndex = 8;
            this.tbxSecondaryPhone.TextChanged += new System.EventHandler(this.tbxSecondaryPhone_TextChanged);
            // 
            // lblSecondaryPhone
            // 
            this.lblSecondaryPhone.AutoSize = true;
            this.lblSecondaryPhone.Location = new System.Drawing.Point(65, 447);
            this.lblSecondaryPhone.Name = "lblSecondaryPhone";
            this.lblSecondaryPhone.Size = new System.Drawing.Size(184, 23);
            this.lblSecondaryPhone.TabIndex = 51;
            this.lblSecondaryPhone.Text = "Secondary Phone:";
            // 
            // lblSuffix
            // 
            this.lblSuffix.AutoSize = true;
            this.lblSuffix.Location = new System.Drawing.Point(65, 279);
            this.lblSuffix.Name = "lblSuffix";
            this.lblSuffix.Size = new System.Drawing.Size(75, 23);
            this.lblSuffix.TabIndex = 53;
            this.lblSuffix.Text = "Suffix:";
            // 
            // tbxAddress3
            // 
            this.tbxAddress3.Location = new System.Drawing.Point(757, 275);
            this.tbxAddress3.MaxLength = 30;
            this.tbxAddress3.Multiline = true;
            this.tbxAddress3.Name = "tbxAddress3";
            this.tbxAddress3.Size = new System.Drawing.Size(249, 71);
            this.tbxAddress3.TabIndex = 11;
            this.tbxAddress3.TextChanged += new System.EventHandler(this.tbxAddress3_TextChanged);
            // 
            // lblAddress3
            // 
            this.lblAddress3.AutoSize = true;
            this.lblAddress3.Location = new System.Drawing.Point(536, 283);
            this.lblAddress3.Name = "lblAddress3";
            this.lblAddress3.Size = new System.Drawing.Size(114, 23);
            this.lblAddress3.TabIndex = 73;
            this.lblAddress3.Text = "Address 3:";
            // 
            // tbxAddress2
            // 
            this.tbxAddress2.Location = new System.Drawing.Point(757, 193);
            this.tbxAddress2.MaxLength = 30;
            this.tbxAddress2.Multiline = true;
            this.tbxAddress2.Name = "tbxAddress2";
            this.tbxAddress2.Size = new System.Drawing.Size(249, 71);
            this.tbxAddress2.TabIndex = 10;
            this.tbxAddress2.TextChanged += new System.EventHandler(this.tbxAddress2_TextChanged);
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Location = new System.Drawing.Point(536, 200);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(114, 23);
            this.lblAddress2.TabIndex = 71;
            this.lblAddress2.Text = "Address 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(729, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 23);
            this.label4.TabIndex = 69;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(729, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 23);
            this.label5.TabIndex = 68;
            this.label5.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(731, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 23);
            this.label2.TabIndex = 67;
            this.label2.Text = "*";
            // 
            // lblZipState
            // 
            this.lblZipState.AutoSize = true;
            this.lblZipState.Location = new System.Drawing.Point(536, 399);
            this.lblZipState.Name = "lblZipState";
            this.lblZipState.Size = new System.Drawing.Size(113, 23);
            this.lblZipState.TabIndex = 66;
            this.lblZipState.Text = "Zip, State:";
            // 
            // tbxZIP
            // 
            this.tbxZIP.Location = new System.Drawing.Point(757, 394);
            this.tbxZIP.MaxLength = 10;
            this.tbxZIP.Name = "tbxZIP";
            this.tbxZIP.ShortcutsEnabled = false;
            this.tbxZIP.Size = new System.Drawing.Size(129, 30);
            this.tbxZIP.TabIndex = 13;
            this.tbxZIP.TextChanged += new System.EventHandler(this.tbxZIP_TextChanged_1);
            this.tbxZIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxZIP_KeyPress_1);
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(757, 111);
            this.tbxAddress.MaxLength = 30;
            this.tbxAddress.Multiline = true;
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(249, 71);
            this.tbxAddress.TabIndex = 9;
            this.tbxAddress.TextChanged += new System.EventHandler(this.tbxAddress_TextChanged_1);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(536, 111);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(95, 23);
            this.lblAddress.TabIndex = 64;
            this.lblAddress.Text = "Address:";
            // 
            // tbxCity
            // 
            this.tbxCity.Location = new System.Drawing.Point(757, 351);
            this.tbxCity.MaxLength = 30;
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.ShortcutsEnabled = false;
            this.tbxCity.Size = new System.Drawing.Size(249, 30);
            this.tbxCity.TabIndex = 12;
            this.tbxCity.TextChanged += new System.EventHandler(this.tbxCity_TextChanged);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(536, 358);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(56, 23);
            this.lblCity.TabIndex = 63;
            this.lblCity.Text = "City:";
            // 
            // tbxSuffix
            // 
            this.tbxSuffix.Location = new System.Drawing.Point(263, 276);
            this.tbxSuffix.MaxLength = 20;
            this.tbxSuffix.Name = "tbxSuffix";
            this.tbxSuffix.ShortcutsEnabled = false;
            this.tbxSuffix.Size = new System.Drawing.Size(247, 30);
            this.tbxSuffix.TabIndex = 4;
            this.tbxSuffix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSuffix_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(916, 399);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 23);
            this.label9.TabIndex = 76;
            this.label9.Text = "*";
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
            this.cbxState.Location = new System.Drawing.Point(944, 394);
            this.cbxState.MaxLength = 2;
            this.cbxState.Name = "cbxState";
            this.cbxState.Size = new System.Drawing.Size(60, 31);
            this.cbxState.TabIndex = 14;
            this.cbxState.TextChanged += new System.EventHandler(this.cbxState_TextChanged);
            // 
            // frmSignupView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 674);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbxState);
            this.Controls.Add(this.tbxSuffix);
            this.Controls.Add(this.tbxAddress3);
            this.Controls.Add(this.lblAddress3);
            this.Controls.Add(this.tbxAddress2);
            this.Controls.Add(this.lblAddress2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblZipState);
            this.Controls.Add(this.tbxZIP);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.tbxCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblSuffix);
            this.Controls.Add(this.tbxSecondaryPhone);
            this.Controls.Add(this.lblSecondaryPhone);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tbxPrimaryPhone);
            this.Controls.Add(this.lblPrimaryPhone);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.cbxTitle);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tbxMiddleName);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRequired);
            this.Controls.Add(this.cbxHidePassword);
            this.Controls.Add(this.lblOr);
            this.Controls.Add(this.lblGoToLogin);
            this.Controls.Add(this.stsStatus);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.tbxFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.tbxConfirmPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.mnuMenuStrip);
            this.Controls.Add(this.lblMainTitle);
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
            this.stsStatus.ResumeLayout(false);
            this.stsStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.MenuStrip mnuMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuMenuGoBack;
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
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.StatusStrip stsStatus;
        private System.Windows.Forms.Label lblGoToLogin;
        private System.Windows.Forms.Label lblOr;
        private System.Windows.Forms.CheckBox cbxHidePassword;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label lblRequired;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbxMiddleName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.ComboBox cbxTitle;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbxPrimaryPhone;
        private System.Windows.Forms.Label lblPrimaryPhone;
        private System.Windows.Forms.TextBox tbxSecondaryPhone;
        private System.Windows.Forms.Label lblSecondaryPhone;
        private System.Windows.Forms.Label lblSuffix;
        private System.Windows.Forms.TextBox tbxAddress3;
        private System.Windows.Forms.Label lblAddress3;
        private System.Windows.Forms.TextBox tbxAddress2;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblZipState;
        private System.Windows.Forms.TextBox tbxZIP;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox tbxSuffix;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxState;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}