//*******************************************
//*******************************************
// Programmer: {Your name goes here}
// Course: INEW 2330.{7Z#} (Final Project)
// Program Description: {Program Purpose Goes here}
//*******************************************
// Class Purpose: 
/*    Handles input validation for controls or user input before reaching the server
 *      Validate TextBox input of required fields
 *          - Logon ID
 *          - Password
 *          - Address lines
 *          - City
 *          - State
 *          - Zip Code
 *          - Phone Number
 *          - Date
 *          - etc.
*/

//*******************************************
//*******************************************

// To See the 'ToDo' tags, go to the 'View' Menu and then select 'Task List'
// You can then double click on a 'ToDo' to go to that specific one in the list

//ToDo: ------------ clsValidation: Remove Form ToDo List, once completed (Listed Below) ------------
//ToDo: clsValidation - Logon ID: Create a validation method
//ToDo: clsValidation - Password: Create a validation method
//ToDo: clsValidation - Address lines: Create a validation method
//ToDo: clsValidation - City: Create a validation method
//ToDo: clsValidation - State: Create a validation method
//ToDo: clsValidation - ZipCode: Create a validation method
//ToDo: clsValidation - Date: Create a validation method
//ToDo: clsValidation - Phone Number: Create a validation method
//ToDo: clsValidation - Security Question, Answers: Create a validation method
//ToDo: ------------ clsValidation: Remove Form ToDo List, once completed (Listed Above) ------------

using System;
using System.Windows.Forms;

namespace FinalProject
{
    internal class clsValidation
    {
        #region Private Fields
        private static int _intUsernameMinLength;
        private static int _intUsernameMaxLength;
        private static int _intPasswordMinLength;
        private static int _intPasswordMaxLength;
        private static int _intEmailMaxLength;
        #endregion

        #region Setters
        public static void SetUsernameLength(int intMin, int intMax)
        {
            _intUsernameMinLength = intMin;
            _intUsernameMaxLength = intMax;
        }

        public static void SetPasswordLength(int intMin, int intMax)
        {
            _intPasswordMinLength = intMin;
            _intPasswordMaxLength = intMax;
        }

        public static void SetEmailMaxLength(int intMax)
        {
            _intEmailMaxLength = intMax;
        }
        #endregion

        #region Logon Credentials
        public static bool ValidateUsername(string strUsername)
        {
            // if string is empty
            if (strUsername.Length <= 8 || strUsername.Length >= 20) return false;

            string strNotAllowed = "!#$%^&*_-+/():;,<>{}|\\~`=\'";

            // check if any of above value contained by user
            foreach (char c in strUsername)
            {
                if (char.IsWhiteSpace(c)) return false;
                if (char.IsDigit(c)) return false;
                if (strNotAllowed.Contains(c.ToString())) return false;
            }

            return true;
        }

        public static bool ValidatePassword(string strPassword)
        {
            bool blnContianUpper = false;
            bool blnContianLower = false;
            bool blnContianDigit = false;
            bool blnContianSpecialChar = false;

            string strSpacialKeys = "()!@#$%^&*";


            if (strPassword.Equals("")) return false;

            if (strPassword.Length < 8) return false;

            foreach (char c in strPassword)
            {
                if (char.IsUpper(c)) blnContianLower = true;
                if (char.IsLower(c)) blnContianUpper = true;
                if (char.IsDigit(c)) blnContianDigit = true;
                if (strSpacialKeys.Contains(c.ToString())) blnContianSpecialChar = true;
            }

            if (blnContianUpper && blnContianLower && blnContianDigit && blnContianSpecialChar)
            {
                return true;
            }

            return false;
        }

        public static bool ValidateSecurityAnswers(string strAnswers)
        {

            return true; // or false;
        }
        #endregion

        #region Contact Information
        public static bool ValidateEmail(string strEmail)
        {

            return true; // or false;
        }

        public static bool ValidatePhone(string strPhone)
        {

            return true; // or false;
        }

        // Address 1, Address 2, Address 3
        public static bool ValidateAddress(string strZip)
        {

            return true; // or false;
        }
        public static bool ValidateZipcode(string strZip)
        {

            return true; // or false;
        }

        // First, Middle, Last, City Name, etc...
        public static bool ValidateName(string strName)
        {

            return true; // or false;
        }
        #endregion

        #region Other Validation Methods
        public static bool ValidateDate(string strDate)
        {

            return true; // or false;
        }

        #endregion
    }
}
