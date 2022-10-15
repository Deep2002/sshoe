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
            this.tbxAddress3 = new System.Windows.Forms.TextBox();
            this.lblAddress3 = new System.Windows.Forms.Label();
            this.tbxAddress2 = new System.Windows.Forms.TextBox();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.stsStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // stsStatus
            // 
            this.stsStatus.AutoSize = false;
            this.stsStatus.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stsStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.stsStatus.Location = new System.Drawing.Point(0, 463);
            this.stsStatus.Name = "stsStatus";
            this.stsStatus.Size = new System.Drawing.Size(626, 34);
            this.stsStatus.SizingGrip = false;
            this.stsStatus.TabIndex = 0;
            // 
            // tbxAddress3
            // 
            this.tbxAddress3.Location = new System.Drawing.Point(264, 265);
            this.tbxAddress3.MaxLength = 30;
            this.tbxAddress3.Multiline = true;
            this.tbxAddress3.Name = "tbxAddress3";
            this.tbxAddress3.Size = new System.Drawing.Size(249, 71);
            this.tbxAddress3.TabIndex = 77;
            // 
            // lblAddress3
            // 
            this.lblAddress3.AutoSize = true;
            this.lblAddress3.Location = new System.Drawing.Point(113, 268);
            this.lblAddress3.Name = "lblAddress3";
            this.lblAddress3.Size = new System.Drawing.Size(114, 23);
            this.lblAddress3.TabIndex = 81;
            this.lblAddress3.Text = "Address 3:";
            // 
            // tbxAddress2
            // 
            this.tbxAddress2.Location = new System.Drawing.Point(264, 179);
            this.tbxAddress2.MaxLength = 30;
            this.tbxAddress2.Multiline = true;
            this.tbxAddress2.Name = "tbxAddress2";
            this.tbxAddress2.Size = new System.Drawing.Size(249, 71);
            this.tbxAddress2.TabIndex = 76;
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Location = new System.Drawing.Point(113, 182);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(114, 23);
            this.lblAddress2.TabIndex = 80;
            this.lblAddress2.Text = "Address 2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(236, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 23);
            this.label2.TabIndex = 79;
            this.label2.Text = "*";
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(264, 93);
            this.tbxAddress.MaxLength = 30;
            this.tbxAddress.Multiline = true;
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(249, 71);
            this.tbxAddress.TabIndex = 75;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(113, 96);
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
            this.lblMainTitle.Location = new System.Drawing.Point(153, 28);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(321, 38);
            this.lblMainTitle.TabIndex = 74;
            this.lblMainTitle.Text = "Delivery Address";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(247, 29);
            this.toolStripStatusLabel1.Text = "Required fields are marked as  *";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(183, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 40);
            this.button1.TabIndex = 82;
            this.button1.Text = "Continue to checkout";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmAddressFilloutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 497);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
    }
}