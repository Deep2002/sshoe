namespace FinalProject
{
    partial class frmQuestionsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuestionsWindow));
            this.lblTitle = new System.Windows.Forms.Label();
            this.mnuMenuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMenuViewHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxFirstQuestion = new System.Windows.Forms.ComboBox();
            this.tbxFirstAnswer = new System.Windows.Forms.TextBox();
            this.tbxSecondAnswer = new System.Windows.Forms.TextBox();
            this.cbxSecondQuestion = new System.Windows.Forms.ComboBox();
            this.tbxThirdAnswer = new System.Windows.Forms.TextBox();
            this.cbxThirdQuestion = new System.Windows.Forms.ComboBox();
            this.lblRequired = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.stsStatus = new System.Windows.Forms.StatusStrip();
            this.lblFirstWrong = new System.Windows.Forms.Label();
            this.lblFirstRight = new System.Windows.Forms.Label();
            this.lblThirdRight = new System.Windows.Forms.Label();
            this.lblThirdWrong = new System.Windows.Forms.Label();
            this.lblSecondRight = new System.Windows.Forms.Label();
            this.lblSecondWrong = new System.Windows.Forms.Label();
            this.mnuMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitle.Location = new System.Drawing.Point(301, 50);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(357, 38);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Security Questions";
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
            this.mnuMenuStrip.TabIndex = 3;
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
            // cbxFirstQuestion
            // 
            this.cbxFirstQuestion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxFirstQuestion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxFirstQuestion.FormattingEnabled = true;
            this.cbxFirstQuestion.Location = new System.Drawing.Point(202, 115);
            this.cbxFirstQuestion.Name = "cbxFirstQuestion";
            this.cbxFirstQuestion.Size = new System.Drawing.Size(554, 31);
            this.cbxFirstQuestion.TabIndex = 0;
            this.cbxFirstQuestion.Text = "Select your First security question.";
            // 
            // tbxFirstAnswer
            // 
            this.tbxFirstAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tbxFirstAnswer.ForeColor = System.Drawing.Color.Black;
            this.tbxFirstAnswer.Location = new System.Drawing.Point(202, 152);
            this.tbxFirstAnswer.Name = "tbxFirstAnswer";
            this.tbxFirstAnswer.Size = new System.Drawing.Size(554, 30);
            this.tbxFirstAnswer.TabIndex = 4;
            this.tbxFirstAnswer.Text = "Type..";
            this.tbxFirstAnswer.Click += new System.EventHandler(this.tbxFirstAnswer_Click);
            this.tbxFirstAnswer.TextChanged += new System.EventHandler(this.tbxFirstAnswer_TextChanged);
            // 
            // tbxSecondAnswer
            // 
            this.tbxSecondAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tbxSecondAnswer.ForeColor = System.Drawing.Color.Black;
            this.tbxSecondAnswer.Location = new System.Drawing.Point(202, 241);
            this.tbxSecondAnswer.Name = "tbxSecondAnswer";
            this.tbxSecondAnswer.Size = new System.Drawing.Size(554, 30);
            this.tbxSecondAnswer.TabIndex = 6;
            this.tbxSecondAnswer.Text = "Type..";
            this.tbxSecondAnswer.Click += new System.EventHandler(this.tbxSecondAnswer_Click);
            this.tbxSecondAnswer.TextChanged += new System.EventHandler(this.tbxSecondAnswer_TextChanged);
            // 
            // cbxSecondQuestion
            // 
            this.cbxSecondQuestion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxSecondQuestion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxSecondQuestion.FormattingEnabled = true;
            this.cbxSecondQuestion.Location = new System.Drawing.Point(202, 204);
            this.cbxSecondQuestion.Name = "cbxSecondQuestion";
            this.cbxSecondQuestion.Size = new System.Drawing.Size(554, 31);
            this.cbxSecondQuestion.TabIndex = 5;
            this.cbxSecondQuestion.Text = "Select your Second security question.";
            // 
            // tbxThirdAnswer
            // 
            this.tbxThirdAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tbxThirdAnswer.ForeColor = System.Drawing.Color.Black;
            this.tbxThirdAnswer.Location = new System.Drawing.Point(202, 330);
            this.tbxThirdAnswer.Name = "tbxThirdAnswer";
            this.tbxThirdAnswer.Size = new System.Drawing.Size(554, 30);
            this.tbxThirdAnswer.TabIndex = 8;
            this.tbxThirdAnswer.Text = "Type..";
            this.tbxThirdAnswer.Click += new System.EventHandler(this.tbxThirdAnswer_Click);
            this.tbxThirdAnswer.TextChanged += new System.EventHandler(this.tbxThirdAnswer_TextChanged);
            // 
            // cbxThirdQuestion
            // 
            this.cbxThirdQuestion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxThirdQuestion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxThirdQuestion.FormattingEnabled = true;
            this.cbxThirdQuestion.Location = new System.Drawing.Point(202, 293);
            this.cbxThirdQuestion.Name = "cbxThirdQuestion";
            this.cbxThirdQuestion.Size = new System.Drawing.Size(554, 31);
            this.cbxThirdQuestion.TabIndex = 7;
            this.cbxThirdQuestion.Text = "Select your Third security question.";
            // 
            // lblRequired
            // 
            this.lblRequired.AutoSize = true;
            this.lblRequired.ForeColor = System.Drawing.Color.Red;
            this.lblRequired.Location = new System.Drawing.Point(762, 118);
            this.lblRequired.Name = "lblRequired";
            this.lblRequired.Size = new System.Drawing.Size(22, 23);
            this.lblRequired.TabIndex = 9;
            this.lblRequired.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(762, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(762, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "*";
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnContinue.ForeColor = System.Drawing.Color.White;
            this.btnContinue.Location = new System.Drawing.Point(398, 381);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(142, 36);
            this.btnContinue.TabIndex = 13;
            this.btnContinue.Text = "&Continue";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Visible = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.Location = new System.Drawing.Point(398, 381);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(142, 36);
            this.btnDone.TabIndex = 14;
            this.btnDone.Text = "&Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Visible = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // stsStatus
            // 
            this.stsStatus.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stsStatus.Location = new System.Drawing.Point(0, 439);
            this.stsStatus.Name = "stsStatus";
            this.stsStatus.Size = new System.Drawing.Size(984, 22);
            this.stsStatus.TabIndex = 26;
            this.stsStatus.Text = "statusStrip1";
            // 
            // lblFirstWrong
            // 
            this.lblFirstWrong.AutoSize = true;
            this.lblFirstWrong.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstWrong.ForeColor = System.Drawing.Color.Red;
            this.lblFirstWrong.Location = new System.Drawing.Point(762, 155);
            this.lblFirstWrong.Name = "lblFirstWrong";
            this.lblFirstWrong.Size = new System.Drawing.Size(33, 23);
            this.lblFirstWrong.TabIndex = 29;
            this.lblFirstWrong.Text = "❌";
            this.lblFirstWrong.Visible = false;
            // 
            // lblFirstRight
            // 
            this.lblFirstRight.AutoSize = true;
            this.lblFirstRight.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstRight.ForeColor = System.Drawing.Color.Green;
            this.lblFirstRight.Location = new System.Drawing.Point(762, 155);
            this.lblFirstRight.Name = "lblFirstRight";
            this.lblFirstRight.Size = new System.Drawing.Size(33, 23);
            this.lblFirstRight.TabIndex = 30;
            this.lblFirstRight.Text = "✔️";
            this.lblFirstRight.Visible = false;
            // 
            // lblThirdRight
            // 
            this.lblThirdRight.AutoSize = true;
            this.lblThirdRight.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThirdRight.ForeColor = System.Drawing.Color.Green;
            this.lblThirdRight.Location = new System.Drawing.Point(762, 333);
            this.lblThirdRight.Name = "lblThirdRight";
            this.lblThirdRight.Size = new System.Drawing.Size(33, 23);
            this.lblThirdRight.TabIndex = 32;
            this.lblThirdRight.Text = "✔️";
            this.lblThirdRight.Visible = false;
            // 
            // lblThirdWrong
            // 
            this.lblThirdWrong.AutoSize = true;
            this.lblThirdWrong.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThirdWrong.ForeColor = System.Drawing.Color.Red;
            this.lblThirdWrong.Location = new System.Drawing.Point(762, 333);
            this.lblThirdWrong.Name = "lblThirdWrong";
            this.lblThirdWrong.Size = new System.Drawing.Size(33, 23);
            this.lblThirdWrong.TabIndex = 31;
            this.lblThirdWrong.Text = "❌";
            this.lblThirdWrong.Visible = false;
            // 
            // lblSecondRight
            // 
            this.lblSecondRight.AutoSize = true;
            this.lblSecondRight.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondRight.ForeColor = System.Drawing.Color.Green;
            this.lblSecondRight.Location = new System.Drawing.Point(762, 244);
            this.lblSecondRight.Name = "lblSecondRight";
            this.lblSecondRight.Size = new System.Drawing.Size(33, 23);
            this.lblSecondRight.TabIndex = 34;
            this.lblSecondRight.Text = "✔️";
            this.lblSecondRight.Visible = false;
            // 
            // lblSecondWrong
            // 
            this.lblSecondWrong.AutoSize = true;
            this.lblSecondWrong.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondWrong.ForeColor = System.Drawing.Color.Red;
            this.lblSecondWrong.Location = new System.Drawing.Point(762, 244);
            this.lblSecondWrong.Name = "lblSecondWrong";
            this.lblSecondWrong.Size = new System.Drawing.Size(33, 23);
            this.lblSecondWrong.TabIndex = 33;
            this.lblSecondWrong.Text = "❌";
            this.lblSecondWrong.Visible = false;
            // 
            // frmQuestionsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.lblSecondRight);
            this.Controls.Add(this.lblSecondWrong);
            this.Controls.Add(this.lblThirdRight);
            this.Controls.Add(this.lblThirdWrong);
            this.Controls.Add(this.lblFirstRight);
            this.Controls.Add(this.lblFirstWrong);
            this.Controls.Add(this.stsStatus);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRequired);
            this.Controls.Add(this.tbxThirdAnswer);
            this.Controls.Add(this.cbxThirdQuestion);
            this.Controls.Add(this.tbxSecondAnswer);
            this.Controls.Add(this.cbxSecondQuestion);
            this.Controls.Add(this.tbxFirstAnswer);
            this.Controls.Add(this.mnuMenuStrip);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cbxFirstQuestion);
            this.Font = new System.Drawing.Font("Verdana", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "frmQuestionsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Questions form";
            this.Load += new System.EventHandler(this.frmQuestionsWindow_Load);
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
        private System.Windows.Forms.ComboBox cbxFirstQuestion;
        private System.Windows.Forms.TextBox tbxFirstAnswer;
        private System.Windows.Forms.TextBox tbxSecondAnswer;
        private System.Windows.Forms.ComboBox cbxSecondQuestion;
        private System.Windows.Forms.TextBox tbxThirdAnswer;
        private System.Windows.Forms.ComboBox cbxThirdQuestion;
        private System.Windows.Forms.Label lblRequired;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.StatusStrip stsStatus;
        private System.Windows.Forms.Label lblFirstWrong;
        private System.Windows.Forms.Label lblFirstRight;
        private System.Windows.Forms.Label lblThirdRight;
        private System.Windows.Forms.Label lblThirdWrong;
        private System.Windows.Forms.Label lblSecondRight;
        private System.Windows.Forms.Label lblSecondWrong;
    }
}