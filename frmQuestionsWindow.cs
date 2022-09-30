using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FinalProject
{
    // this can be used to display apropriate form
    // 
    public enum FORM_TYPE { RESET_PASSWORD, CREATE_NEW_USER }

    public partial class frmQuestionsWindow : Form
    {
        public FORM_TYPE formType;
        public List<string> questionList;

        public frmQuestionsWindow(FORM_TYPE formType)
        {
            // set form type
            this.formType = formType;

            InitializeComponent();
        }

        private void frmQuestionsWindow_Load(object sender, EventArgs e)
        {
            // check which form to display
            if (formType == FORM_TYPE.RESET_PASSWORD)
            {
                // disable sequrity question 
                cbxFirstQuestion.Enabled = false;
                cbxSecondQuestion.Enabled = false;
                cbxThirdQuestion.Enabled = false;

                // Show Information message
                MessageBox.Show("You will be asked 3 Security Questions, please enter all three answer correctly to change your password.",
                    "Security Questions", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // display sicurity question
                cbxFirstQuestion.Text = frmLogon.currentUser.strFirstQuestion;
                cbxSecondQuestion.Text = frmLogon.currentUser.strSecondQuestion;
                cbxThirdQuestion.Text = frmLogon.currentUser.strThirdQuestion;

                // display done continue button
                btnContinue.Visible = true;
            }
            else
            {
                clsSQL.OpenDbConnection();
                questionList = clsSQL.GetSecurityQuestion();

                string strSetID;
                string strQuestion;


                // loop throuh each question
                foreach (string s in questionList)
                {
                    strSetID = s.Split(':')[1];
                    strQuestion = s.Split(':')[2];

                    if (strSetID == "1")
                    {
                        cbxFirstQuestion.Items.Add(strQuestion);

                    }
                    else if (strSetID == "2")
                    {
                        cbxSecondQuestion.Items.Add(strQuestion);
                    }
                    else
                    {
                        cbxThirdQuestion.Items.Add(strQuestion);
                    }
                }


                btnDone.Visible = true;
            }
        }

        private void tbxFirstAnswer_Click(object sender, EventArgs e)
        {
            tbxFirstAnswer.SelectAll();
        }

        private void tbxSecondAnswer_Click(object sender, EventArgs e)
        {
            tbxSecondAnswer.SelectAll();
        }

        private void tbxThirdAnswer_Click(object sender, EventArgs e)
        {
            tbxThirdAnswer.SelectAll();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            // check if all answers are filed
            if ("Type..".Equals(tbxFirstAnswer.Text) || "Type..".Equals(tbxSecondAnswer.Text) || "Type..".Equals(tbxThirdAnswer.Text))
            {
                clsUpdateControls.UpdateStatusBar(stsStatus, "Please enter all questions answers to continue.", Color.Red);
                return;
            }
            if (tbxFirstAnswer.Text.ToLower() == frmLogon.currentUser.strFirstAnswer.ToLower() &&
                tbxSecondAnswer.Text.ToLower() == frmLogon.currentUser.strSecondAnswer.ToLower() &&
                tbxThirdAnswer.Text.ToLower() == frmLogon.currentUser.strThirdAnswer.ToLower())
            {
                new frmCreateNewPassword().ShowDialog();
                this.Close();
            }
            else
            {
                clsUpdateControls.UpdateStatusBar(stsStatus,
                    "Please check that all answers are correct before continuing. '❌' Shows that, this answer you have entred is wrong. ", Color.Red);
            }
        }

        private void tbxFirstAnswer_TextChanged(object sender, EventArgs e)
        {
            if (formType == FORM_TYPE.CREATE_NEW_USER) return;
            if (tbxFirstAnswer.Text.ToLower() == frmLogon.currentUser.strFirstAnswer.ToLower())
            {
                lblFirstRight.Visible = true;
                lblFirstWrong.Visible = false;
            }
            else
            {
                lblFirstRight.Visible = false;
                lblFirstWrong.Visible = true;
            }
        }

        private void tbxSecondAnswer_TextChanged(object sender, EventArgs e)
        {
            if (formType == FORM_TYPE.CREATE_NEW_USER) return;
            if (tbxSecondAnswer.Text.ToLower() == frmLogon.currentUser.strSecondAnswer.ToLower())
            {
                lblSecondRight.Visible = true;
                lblSecondWrong.Visible = false;
            }
            else
            {
                lblSecondRight.Visible = false;
                lblSecondWrong.Visible = true;
            }
        }

        private void tbxThirdAnswer_TextChanged(object sender, EventArgs e)
        {
            if (formType == FORM_TYPE.CREATE_NEW_USER) return;
            if (tbxThirdAnswer.Text.ToLower() == frmLogon.currentUser.strThirdAnswer.ToLower())
            {
                lblThirdRight.Visible = true;
                lblThirdWrong.Visible = false;
            }
            else
            {
                lblThirdRight.Visible = false;
                lblThirdWrong.Visible = true;
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            // Validate question
            if(!ValidateCbxQuestion(cbxFirstQuestion))
            {
                cbxFirstQuestion.Focus();
                clsUpdateControls.UpdateStatusBar(stsStatus, "Please select first question from the list.", Color.Red);
                return;
            }
            if(!ValidateCbxQuestion(cbxSecondQuestion))
            {
                cbxSecondQuestion.Focus();
                clsUpdateControls.UpdateStatusBar(stsStatus, "Please select Second question from the list.", Color.Red);
                return;
            }
            if(!ValidateCbxQuestion(cbxThirdQuestion))
            {
                cbxThirdQuestion.Focus();
                clsUpdateControls.UpdateStatusBar(stsStatus, "Please select Third question from the list.", Color.Red);
                return;
            }
            // check if answers are not empty
            if (string.IsNullOrEmpty(tbxFirstAnswer.Text) || string.IsNullOrEmpty(tbxSecondAnswer.Text) || string.IsNullOrEmpty(tbxThirdAnswer.Text) ||
               "Type..".Equals(tbxFirstAnswer.Text) || "Type..".Equals(tbxSecondAnswer.Text) || "Type..".Equals(tbxThirdAnswer.Text)
                )
            {
                clsUpdateControls.UpdateStatusBar(stsStatus, "Please make sure that all answers are correctly filed.", Color.Red);
                return;
            }

            // if everything looks/validate successfull
            // create a user
            string strFirstName = frmLogon.currentUser.strFirstName;
            string strLastName = frmLogon.currentUser.strLastName;
            string strUsername = frmLogon.currentUser.strUsername;
            string strMiddleName = frmLogon.currentUser.strMiddleName;
            string strTitle = frmLogon.currentUser.strTitle;
            string strSuffix = frmLogon.currentUser.strSuffix;

            string strAddress = frmLogon.currentUser.strAddress1;
            string strAddress2 = frmLogon.currentUser.strAddress2;
            string strAddress3 = frmLogon.currentUser.strAddress3;
            string strCity = frmLogon.currentUser.strCity;
            string strState = frmLogon.currentUser.strState;
            string strZIP = frmLogon.currentUser.strZip;

            string strPrimaryPhone = frmLogon.currentUser.strPrimaryPhone;
            string strSecondaryPhone = frmLogon.currentUser.strSecondaryPhone;
            string strEmail = frmLogon.currentUser.strEmail;
            string strPassword = frmLogon.currentUser.strPassword;

            // questions
            string strFirstQuestionID = "";
            string strSecondQuestionID = "";
            string strThirdQuestionID = "";
            string strTemp = "";

            // get questions & answers
            foreach(var item in questionList)
            {
                // check and get first question id
                strTemp = item.Split(':')[2];
                if (strTemp == cbxFirstQuestion.Text)
                {
                    strFirstQuestionID = item.Split(':')[0];
                }
                // check and get second question id
                strTemp = item.Split(':')[2];
                if(strTemp == cbxSecondQuestion.Text)
                {
                    strSecondQuestionID = item.Split(':')[0];
                }
                // check and get third question id
                strTemp = item.Split(':')[2];
                if(strTemp == cbxThirdQuestion.Text)
                {
                    strThirdQuestionID = item.Split(':')[0];
                }
            }

            // Answers
            string strFirstAnswer = tbxFirstAnswer.Text;
            string strSecondAnswer = tbxSecondAnswer.Text;
            string strThirdAnswer = tbxThirdAnswer.Text;

            // pass infomration to create a user
            if(clsSQL.CreateNewUser(strFirstName, strLastName, strUsername, strAddress, strCity,
                strState, strZIP, strPassword, strFirstQuestionID, strFirstAnswer,
                strSecondQuestionID, strSecondAnswer, strThirdQuestionID, strThirdAnswer, strMiddleName, strTitle, strSuffix, strAddress2, strAddress3, strPrimaryPhone, strSecondaryPhone, strEmail))
            {
                MessageBox.Show("Account for user " + strFirstName + " successfully created.\nYou can now login with your username and password.",
                    "All steps are completed.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            } else
            {
                MessageBox.Show(":( Unfortunatly we are unable to create your account. please try again later. ",
                        "All steps are completed.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            // delete current user information from application.
            // (It is still in the database)
            frmLogon.currentUser = null;
        }

        private bool ValidateCbxQuestion(ComboBox cbxQuestionBox)
        {
            foreach (string item in cbxQuestionBox.Items)
            {
                if(cbxQuestionBox.Text == item)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
