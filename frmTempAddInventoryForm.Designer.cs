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
            this.SuspendLayout();
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(95, 32);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(311, 31);
            this.tbxName.TabIndex = 0;
            this.tbxName.Text = "Name";
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(95, 69);
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(311, 89);
            this.tbxDescription.TabIndex = 1;
            this.tbxDescription.Text = "Description";
            // 
            // tbxretailPrice
            // 
            this.tbxretailPrice.Location = new System.Drawing.Point(95, 213);
            this.tbxretailPrice.Name = "tbxretailPrice";
            this.tbxretailPrice.Size = new System.Drawing.Size(311, 31);
            this.tbxretailPrice.TabIndex = 3;
            this.tbxretailPrice.Text = "Retail Price";
            // 
            // tbxCategoryID
            // 
            this.tbxCategoryID.Location = new System.Drawing.Point(95, 170);
            this.tbxCategoryID.Name = "tbxCategoryID";
            this.tbxCategoryID.Size = new System.Drawing.Size(311, 31);
            this.tbxCategoryID.TabIndex = 2;
            this.tbxCategoryID.Text = "CategoryID";
            // 
            // tbxrestockThreshold
            // 
            this.tbxrestockThreshold.Location = new System.Drawing.Point(95, 342);
            this.tbxrestockThreshold.Name = "tbxrestockThreshold";
            this.tbxrestockThreshold.Size = new System.Drawing.Size(311, 31);
            this.tbxrestockThreshold.TabIndex = 6;
            this.tbxrestockThreshold.Text = "Restock Threshold";
            // 
            // tbxquantity
            // 
            this.tbxquantity.Location = new System.Drawing.Point(95, 299);
            this.tbxquantity.Name = "tbxquantity";
            this.tbxquantity.Size = new System.Drawing.Size(311, 31);
            this.tbxquantity.TabIndex = 5;
            this.tbxquantity.Text = "Quantity";
            // 
            // tbxcost
            // 
            this.tbxcost.Location = new System.Drawing.Point(95, 256);
            this.tbxcost.Name = "tbxcost";
            this.tbxcost.Size = new System.Drawing.Size(311, 31);
            this.tbxcost.TabIndex = 4;
            this.tbxcost.Text = "Cost";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(139, 508);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(223, 66);
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
            this.btnAddImage.Location = new System.Drawing.Point(139, 452);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(223, 50);
            this.btnAddImage.TabIndex = 7;
            this.btnAddImage.Text = "Add Image";
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // tbxImgLocation
            // 
            this.tbxImgLocation.Location = new System.Drawing.Point(95, 389);
            this.tbxImgLocation.Name = "tbxImgLocation";
            this.tbxImgLocation.Size = new System.Drawing.Size(311, 31);
            this.tbxImgLocation.TabIndex = 9;
            this.tbxImgLocation.Text = "Image Location";
            // 
            // frmTempAddInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 592);
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
    }
}