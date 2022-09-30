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
using System.Drawing;
using System.IO.Compression;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FinalProject
{
    internal class clsValidation
    {
        static string strNotAllowedChar = "!@#$%^&*()_+='\"\\||;:,<>?{}[]~`/-.";
        static string strComplexcityChar = "()!@#$%^&*";

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
            if (strUsername.Length < 8 || strUsername.Length > 20) return false;
            try
            {
                if (char.IsDigit(strUsername[0])) return false;
            }
            catch (IndexOutOfRangeException) { }
            // check if any of above value contained by user
            foreach (char c in strUsername)
            {
                if (char.IsWhiteSpace(c)) return false;
                //if (char.IsDigit(c)) return false;
                if (strNotAllowedChar.Contains(c.ToString())) return false;
            }

            return true;
        }

        public static bool ValidatePassword(string strPassword)
        {
            bool blnContianUpper = false;
            bool blnContianLower = false;
            bool blnContianDigit = false;
            bool blnContianSpecialChar = false;
            int intComplexity = 0;

            if (strPassword.Equals("")) return false;
            if (strPassword.Length < 8) return false;

            foreach (char c in strPassword)
            {
                if (char.IsUpper(c)) blnContianLower = true;
                if (char.IsLower(c)) blnContianUpper = true;
                if (char.IsDigit(c)) blnContianDigit = true;
                if (strComplexcityChar.Contains(c.ToString())) blnContianSpecialChar = true;
            }

            if (blnContianDigit) intComplexity++;
            if (blnContianLower) intComplexity++;
            if (blnContianUpper) intComplexity++;
            if (blnContianSpecialChar) intComplexity++;

            if (intComplexity >= 3)
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
            Regex validateEmailRegex = new Regex("(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|\"(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21\\x23-\\x5b\\x5d-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])*\")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\\[(?:(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9]))\\.){3}(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9])|[a-z0-9-]*[a-z0-9]:(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21-\\x5a\\x53-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])+)\\])");
           
            return validateEmailRegex.IsMatch(strEmail); // or false;
        }

        public static bool ValidatePhone(string strPhone)
        {
            Regex validatePhone = new Regex("^(\\+\\d{1,2}\\s)?\\(?\\d{3}\\)?[\\s.-]?\\d{3}[\\s.-]?\\d{4}$");
            return validatePhone.IsMatch(strPhone); // or false;
        }

        // Address 1, Address 2, Address 3
        public static bool ValidateAddress(string strAddress)
        {
            if (strAddress.Length < 2) return false;
            // check if it contains any charchters
            foreach (char c in strAddress)
            {
                if ("!@$%^&*+=~`?/><|\\{}".Contains(c.ToString())) return false;
            }

            return true;
        }
        public static bool ValidateZipcode(string strZip)
        {
            Regex regex = new Regex("^\\d{5}(?:[-\\s]\\d{4})?$");
            return regex.IsMatch(strZip);
        }

        // First, Middle, Last, City Name, etc...
        public static bool ValidateName(string strName)
        {
            
            if (string.IsNullOrEmpty(strName)) return false;

            foreach (char c in strName)
            {
                if (char.IsDigit(c)) return false;
                if ("!@#$%^&*()_+=\'\"\\||;:,<>?{}[]~`/".Contains(c.ToString())) return false;
            }

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
