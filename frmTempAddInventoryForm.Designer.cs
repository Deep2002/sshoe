namespace FinalProject
{
    partial class frmTempAddInventoryForm
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
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.tbxretailPrice = new System.Windows.Forms.TextBox();
            this.tbxCategoryID = new System.Windows.Forms.TextBox();
            this.tbxrestockThreshold = new System.Windows.Forms.TextBox();
            this.tbxquantity = new System.Windows.Forms.TextBox();
            this.tbxcost = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.tbxImgLocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxGenderID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(139, 31);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(311, 31);
            this.tbxName.TabIndex = 0;
            this.tbxName.Text = "Name";
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(139, 68);
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(311, 89);
            this.tbxDescription.TabIndex = 1;
            this.tbxDescription.Text = "Nike Basketball";
            // 
            // tbxretailPrice
            // 
            this.tbxretailPrice.Location = new System.Drawing.Point(139, 212);
            this.tbxretailPrice.Name = "tbxretailPrice";
            this.tbxretailPrice.Size = new System.Drawing.Size(311, 31);
            this.tbxretailPrice.TabIndex = 3;
            this.tbxretailPrice.Text = "59.99";
            // 
            // tbxCategoryID
            // 
            this.tbxCategoryID.Location = new System.Drawing.Point(139, 169);
            this.tbxCategoryID.Name = "tbxCategoryID";
            this.tbxCategoryID.Size = new System.Drawing.Size(311, 31);
            this.tbxCategoryID.TabIndex = 2;
            this.tbxCategoryID.Text = "134";
            // 
            // tbxrestockThreshold
            // 
            this.tbxrestockThreshold.Location = new System.Drawing.Point(139, 341);
            this.tbxrestockThreshold.Name = "tbxrestockThreshold";
            this.tbxrestockThreshold.Size = new System.Drawing.Size(311, 31);
            this.tbxrestockThreshold.TabIndex = 6;
            this.tbxrestockThreshold.Text = "1";
            // 
            // tbxquantity
            // 
            this.tbxquantity.Location = new System.Drawing.Point(139, 298);
            this.tbxquantity.Name = "tbxquantity";
            this.tbxquantity.Size = new System.Drawing.Size(311, 31);
            this.tbxquantity.TabIndex = 5;
            this.tbxquantity.Text = "20";
            // 
            // tbxcost
            // 
            this.tbxcost.Location = new System.Drawing.Point(139, 255);
            this.tbxcost.Name = "tbxcost";
            this.tbxcost.Size = new System.Drawing.Size(311, 31);
            this.tbxcost.TabIndex = 4;
            this.tbxcost.Text = "Cost";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(139, 538);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(223, 50);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add This Item";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "openFileDialog1";
            // 
            // btnAddImage
            // 
            this.btnAddImage.Location = new System.Drawing.Point(139, 482);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(223, 50);
            this.btnAddImage.TabIndex = 7;
            this.btnAddImage.Text = "Add Image";
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // tbxImgLocation
            // 
            this.tbxImgLocation.Location = new System.Drawing.Point(139, 436);
            this.tbxImgLocation.Name = "tbxImgLocation";
            this.tbxImgLocation.ReadOnly = true;
            this.tbxImgLocation.Size = new System.Drawing.Size(311, 31);
            this.tbxImgLocation.TabIndex = 9;
            this.tbxImgLocation.Text = "Img...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Men 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Restock:";
            // 
            // tbxGenderID
            // 
            this.tbxGenderID.Location = new System.Drawing.Point(139, 389);
            this.tbxGenderID.Name = "tbxGenderID";
            this.tbxGenderID.Size = new System.Drawing.Size(311, 31);
            this.tbxGenderID.TabIndex = 10;
            this.tbxGenderID.Text = "1";
            // 
            // frmTempAddInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 666);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxGenderID);
            this.Controls.Add(this.tbxImgLocation);
            this.Controls.Add(this.btnAddImage);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbxrestockThreshold);
            this.Controls.Add(this.tbxquantity);
            this.Controls.Add(this.tbxcost);
            this.Controls.Add(this.tbxretailPrice);
            this.Controls.Add(this.tbxCategoryID);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.tbxName);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmTempAddInventoryForm";
            this.Text = "frmTempAddInventoryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.TextBox tbxretailPrice;
        private System.Windows.Forms.TextBox tbxCategoryID;
        private System.Windows.Forms.TextBox tbxrestockThreshold;
        private System.Windows.Forms.TextBox tbxquantity;
        private System.Windows.Forms.TextBox tbxcost;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.TextBox tbxImgLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxGenderID;
    }
}