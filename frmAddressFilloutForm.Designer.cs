namespace FinalProject
{
    partial class frmAddressFilloutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddressFilloutForm));
            this.stsStatus = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbxAddress3 = new System.Windows.Forms.TextBox();
            this.lblAddress3 = new System.Windows.Forms.Label();
            this.tbxAddress2 = new System.Windows.Forms.TextBox();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.btnContinueToCheckout = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxState = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblZipState = new System.Windows.Forms.Label();
            this.tbxZIP = new System.Windows.Forms.TextBox();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.stsStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // stsStatus
            // 
            this.stsStatus.AutoSize = false;
            this.stsStatus.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stsStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.stsStatus.Location = new System.Drawing.Point(0, 540);
            this.stsStatus.Name = "stsStatus";
            this.stsStatus.Size = new System.Drawing.Size(487, 34);
            this.stsStatus.SizingGrip = false;
            this.stsStatus.TabIndex = 0;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(247, 29);
            this.toolStripStatusLabel1.Text = "Required fields are marked as  *";
            // 
            // tbxAddress3
            // 
            this.tbxAddress3.Location = new System.Drawing.Point(192, 266);
            this.tbxAddress3.MaxLength = 30;
            this.tbxAddress3.Multiline = true;
            this.tbxAddress3.Name = "tbxAddress3";
            this.tbxAddress3.Size = new System.Drawing.Size(249, 71);
            this.tbxAddress3.TabIndex = 2;
            // 
            // lblAddress3
            // 
            this.lblAddress3.AutoSize = true;
            this.lblAddress3.Location = new System.Drawing.Point(45, 269);
            this.lblAddress3.Name = "lblAddress3";
            this.lblAddress3.Size = new System.Drawing.Size(114, 23);
            this.lblAddress3.TabIndex = 81;
            this.lblAddress3.Text = "Address 3:";
            // 
            // tbxAddress2
            // 
            this.tbxAddress2.Location = new System.Drawing.Point(192, 180);
            this.tbxAddress2.MaxLength = 30;
            this.tbxAddress2.Multiline = true;
            this.tbxAddress2.Name = "tbxAddress2";
            this.tbxAddress2.Size = new System.Drawing.Size(249, 71);
            this.tbxAddress2.TabIndex = 1;
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Location = new System.Drawing.Point(45, 183);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(114, 23);
            this.lblAddress2.TabIndex = 80;
            this.lblAddress2.Text = "Address 2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(164, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 23);
            this.label2.TabIndex = 79;
            this.label2.Text = "*";
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(192, 94);
            this.tbxAddress.MaxLength = 30;
            this.tbxAddress.Multiline = true;
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(249, 71);
            this.tbxAddress.TabIndex = 0;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(45, 97);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(95, 23);
            this.lblAddress.TabIndex = 78;
            this.lblAddress.Text = "Address:";
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblMainTitle.Location = new System.Drawing.Point(83, 28);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(321, 38);
            this.lblMainTitle.TabIndex = 74;
            this.lblMainTitle.Text = "Delivery Address";
            // 
            // btnContinueToCheckout
            // 
            this.btnContinueToCheckout.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnContinueToCheckout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinueToCheckout.ForeColor = System.Drawing.Color.White;
            this.btnContinueToCheckout.Location = new System.Drawing.Point(113, 470);
            this.btnContinueToCheckout.Name = "btnContinueToCheckout";
            this.btnContinueToCheckout.Size = new System.Drawing.Size(260, 40);
            this.btnContinueToCheckout.TabIndex = 6;
            this.btnContinueToCheckout.Text = "Continue to checkout";
            this.btnContinueToCheckout.UseVisualStyleBackColor = false;
            this.btnContinueToCheckout.Click += new System.EventHandler(this.btnContinueToCheckout_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(351, 411);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 23);
            this.label9.TabIndex = 90;
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
            this.cbxState.Location = new System.Drawing.Point(379, 406);
            this.cbxState.MaxLength = 2;
            this.cbxState.Name = "cbxState";
            this.cbxState.Size = new System.Drawing.Size(60, 31);
            this.cbxState.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(164, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 23);
            this.label4.TabIndex = 89;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(164, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 23);
            this.label5.TabIndex = 88;
            this.label5.Text = "*";
            // 
            // lblZipState
            // 
            this.lblZipState.AutoSize = true;
            this.lblZipState.Location = new System.Drawing.Point(45, 407);
            this.lblZipState.Name = "lblZipState";
            this.lblZipState.Size = new System.Drawing.Size(113, 23);
            this.lblZipState.TabIndex = 87;
            this.lblZipState.Text = "Zip, State:";
            // 
            // tbxZIP
            // 
            this.tbxZIP.Location = new System.Drawing.Point(192, 406);
            this.tbxZIP.MaxLength = 10;
            this.tbxZIP.Name = "tbxZIP";
            this.tbxZIP.ShortcutsEnabled = false;
            this.tbxZIP.Size = new System.Drawing.Size(129, 30);
            this.tbxZIP.TabIndex = 4;
            // 
            // tbxCity
            // 
            this.tbxCity.Location = new System.Drawing.Point(192, 363);
            this.tbxCity.MaxLength = 30;
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.ShortcutsEnabled = false;
            this.tbxCity.Size = new System.Drawing.Size(249, 30);
            this.tbxCity.TabIndex = 3;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(45, 366);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(56, 23);
            this.lblCity.TabIndex = 86;
            this.lblCity.Text = "City:";
            // 
            // frmAddressFilloutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 574);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbxState);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblZipState);
            this.Controls.Add(this.tbxZIP);
            this.Controls.Add(this.tbxCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.btnContinueToCheckout);
            this.Controls.Add(this.tbxAddress3);
            this.Controls.Add(this.lblAddress3);
            this.Controls.Add(this.tbxAddress2);
            this.Controls.Add(this.lblAddress2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblMainTitle);
            this.Controls.Add(this.stsStatus);
            this.Font = new System.Drawing.Font("Verdana", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "frmAddressFilloutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delivery Address";
            this.stsStatus.ResumeLayout(false);
            this.stsStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip stsStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TextBox tbxAddress3;
        private System.Windows.Forms.Label lblAddress3;
        private System.Windows.Forms.TextBox tbxAddress2;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Button btnContinueToCheckout;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxState;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblZipState;
        private System.Windows.Forms.TextBox tbxZIP;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.Label lblCity;
    }
}