//*******************************************
//*******************************************
// Programmer: Deep Parmar
// Course: INEW 2332-7G1 (Final Project)
// Program Description: This class contains SQL connections. Which can be used to INSERT/UPDATE/DELETE, and select
//*******************************************
// Class Purpose:
/*      Handles connections, INSERT/UPDATE/DELETE, and SELECT
 *      
 *      - Schema names must be a class level constant.
 *      - No query strings will be passed to the clsSQL.cs
 *      - Efficient code that uses a minimal amount of methods/functions for
 *        connecting to the database. Connection strings exist
 *        in only one location (global variable or constant).
 *      - Efficient code that uses a minimal amount of methods/functions for
 *        handling data manipulation. Appropriate methods for each of the DML statements.
 *      - Efficient code that uses a minimal amount of methods/functions for 
 *        querying the database. Methods usage can include populating application controls.
 *      - Efficient code that uses a minimal amount of methods/functions for handling SQL
 *      - Exceptions. SQL specific exception handling is better than generic handling.
 *      - All SQL related strings (connections strings, query strings, etc) contained inside of the class. Pass parameters or references and use overloading
 */
//*******************************************
//*******************************************

// To See the 'ToDo' tags, go to the 'View' Menu and then select 'Task List'
// You can then double click on a 'ToDo' to go to that specific one in the list

//ToDo: ------------ clsSQL - Remove Form ToDo List, once completed (Listed Below) ------------
//ToDo: clsSQL - Write to DataTable: Create a validation method
//ToDo: clsSQL - Update DataTable values: Create a validation method
//ToDo: clsSQL - Read from DataTable: Create a validation method
//ToDo: clsSQL - Handle Errors: Create a validation method
//ToDo: ------------ clsSQL - Remove Form ToDo List, once completed (Listed Above) ------------

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FinalProject
{
    internal class clsSQL
    {
        // database login credentials
        const string _STR_CONNECTION = "Server=3.130.26.194;Database=inew2332fa22;User Id=ParmarDFa2332;password=Dp2002@Lions";
        static SqlConnection connection;

        /// <summary>
        /// This will open MS SQL connection.
        /// </summary>
        public static void OpenDbConnection()
        {
            try
            {
                // try to open  database connection
                connection = new SqlConnection(_STR_CONNECTION);
                connection.Open();
            }
            catch (Exception ex)
            {
                /// show error
                MessageBox.Show(ex.Message, "Unable to connect!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// This will close MS SQL connection.
        /// </summary>
        public static void CloseDbConnection()
        {
            if (connection != null) // if connection exist
                try
                {
                    // try to close DB connection
                    connection.Close();
                }
                catch (Exception ex)
                {
                    // set connection to null, so it cannot be used.
                    connection = null;
                    MessageBox.Show(ex.Message, "Unable to disconnect!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        /// <summary>
        /// This will look for current user, if exists it will set current users information.
        /// </summary>
        /// <param name="strUsername"></param>
        /// <param name="strPassword"></param>
        /// <returns></returns>
        public static bool SearchCurrentUser(string strUsername, string strPassword)
        {
            try
            {

                // setting up query to run
                string strQuery = "SELECT p.PersonID, p.NameFirst, p.NameLast FROM Person as p " +
                            "JOIN Logon AS l ON " +
                            "l.PersonID = p.PersonID " +
                            "WHERE LogonName = @0 " +
                            "AND Password = @1 COLLATE SQL_Latin1_General_CP1_CS_AS;";

                // establish command and data adapter
                SqlCommand cmd = new SqlCommand(strQuery, connection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                // add values
                cmd.Parameters.AddWithValue("@0", strUsername);
                cmd.Parameters.AddWithValue("@1", strPassword);
                // create and fill in the data table
                DataTable dtUserTable = new DataTable();
                sqlDataAdapter.SelectCommand = cmd;
                sqlDataAdapter.Fill(dtUserTable);

                // dispose unnecessary data
                cmd.Dispose();
                sqlDataAdapter.Dispose();

                // check if DB return any row
                if (dtUserTable.Rows.Count != 0)
                {
                    // If so, user is found and add it information to the currentUser.
                    frmLogon.currentUser = new Person();
                    Person temp = frmLogon.currentUser;

                    // parse info
                    temp.strPersonID = dtUserTable.Rows[0]["PersonID"].ToString();
                    temp.strFirstName = dtUserTable.Rows[0]["NameFirst"].ToString();
                    temp.strLastName = dtUserTable.Rows[0]["NameLast"].ToString();

                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {

                // Show error
                MessageBox.Show(ex.Message, "Something went wrong..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        /// <summary>
        /// This will check if user exist with this user name &
        /// set current user with sequrity question
        /// </summary>
        /// <param name="strUsername"></param>
        /// <returns></returns>
        public static bool SearchCurrentUser(string strUsername)
        {
            try
            {
                #region Sql Queries
                // setting up query to run
                string strQuery1 = "SELECT q.QuestionPrompt, l.FirstChallengeAnswer FROM Logon as l " +
                    "JOIN SecurityQuestions as q " +
                    "ON l.FirstChallengeQuestion = q.QuestionID " +
                    "WHERE l.LogonName = @0;";

                string strQuery2 = "SELECT q.QuestionPrompt, l.SecondChallengeAnswer FROM Logon as l " +
                    "JOIN SecurityQuestions as q " +
                    "ON l.SecondChallengeQuestion = q.QuestionID " +
                    "WHERE l.LogonName = @0;";

                string strQuery3 = "SELECT q.QuestionPrompt, l.ThirdChallengeAnswer FROM Logon as l " +
                    "JOIN SecurityQuestions as q " +
                    "ON l.ThirdChallengeQuestion = q.QuestionID " +
                    "WHERE l.LogonName = @0;";
                #endregion
                // establish command and data adapter
                SqlCommand cmd = new SqlCommand(strQuery1, connection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                // add values
                cmd.Parameters.AddWithValue("@0", strUsername);

                // create and fill in the data table
                DataTable dtUserTable = new DataTable();
                sqlDataAdapter.SelectCommand = cmd;
                sqlDataAdapter.Fill(dtUserTable);

                // dispose unnecessary data
                cmd.Dispose();
                sqlDataAdapter.Dispose();

                // check if DB return any row
                if (dtUserTable.Rows.Count != 0)
                {
                    // If so, user is found and add it information to the currentUser.
                    frmLogon.currentUser = new Person();
                    Person temp = frmLogon.currentUser;

                    // parse info
                    temp.strFirstQuestion = dtUserTable.Rows[0]["QuestionPrompt"].ToString();
                    temp.strFirstAnswer = dtUserTable.Rows[0]["FirstChallengeAnswer"].ToString();
                    dtUserTable.Clear();

                    // get second question
                    cmd = new SqlCommand(strQuery2, connection);
                    cmd.Parameters.AddWithValue("@0", strUsername);
                    sqlDataAdapter.SelectCommand = cmd;
                    sqlDataAdapter.Fill(dtUserTable);

                    temp.strSecondQuestion = dtUserTable.Rows[0]["QuestionPrompt"].ToString();
                    temp.strSecondAnswer = dtUserTable.Rows[0]["SecondChallengeAnswer"].ToString();
                    dtUserTable.Clear();

                    // get third question
                    cmd = new SqlCommand(strQuery3, connection);
                    cmd.Parameters.AddWithValue("@0", strUsername);
                    sqlDataAdapter.SelectCommand = cmd;
                    sqlDataAdapter.Fill(dtUserTable);

                    temp.strThirdQuestion = dtUserTable.Rows[0]["QuestionPrompt"].ToString();
                    temp.strThirdAnswer = dtUserTable.Rows[0]["ThirdChallengeAnswer"].ToString();
                    dtUserTable.Clear();

                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {

                // Show error
                MessageBox.Show(ex.Message, "Something went wrong..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        /// <summary>
        /// This will update password of current user
        /// </summary>
        /// <param name="password"></param>
        /// <param name="username"></param>
        /// <returns></returns>
        public static bool UpdatePassword(string password, string username)
        {
            try
            {
                string strQuery = "UPDATE ParmarD22Fa2332.Logon SET Password = @0 " +
                    "WHERE LogonName = @1";


                SqlCommand cmd = new SqlCommand(strQuery, connection);
                cmd.Parameters.AddWithValue("@0", password);
                cmd.Parameters.AddWithValue("@1", username);

                cmd.ExecuteNonQuery();
                cmd.Dispose();

                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public static List<string> GetSecurityQuestion()
        {
            List<string> list = new List<string>();

            try
            {
                string strQuery = "SELECT * FROM SecurityQuestions";

                // establish command and data adapter
                SqlCommand cmd = new SqlCommand(strQuery, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(reader.GetInt32(0).ToString() + ":" + reader.GetInt32(1) + ":" + reader.GetString(2));
                }


                cmd.Dispose();
                return list;

            }
            catch (Exception)
            {
                return list;
            }

        }

        /// <summary>
        /// This method will create new user
        /// </summary>
        /// <param name="strFirstName"></param>
        /// <param name="strLastName"></param>
        /// <param name="strUsername"></param>
        /// <param name="strAddress"></param>
        /// <param name="strCity"></param>
        /// <param name="strState"></param>
        /// <param name="strZIP"></param>
        /// <param name="strPassword"></param>
        /// <param name="strFirstQuestionID"></param>
        /// <param name="strFirstAnswer"></param>
        /// <param name="strSecondQuestionID"></param>
        /// <param name="strSecondAnswer"></param>
        /// <param name="strThirdQuestionID"></param>
        /// <param name="strThirdAnswer"></param>
        /// <returns></returns>
        public static bool CreateNewUser(string strFirstName, string strLastName, string strUsername,
            string strAddress, string strCity, string strState, string strZIP, string strPassword,
            string strFirstQuestionID, string strFirstAnswer, string strSecondQuestionID,
            string strSecondAnswer, string strThirdQuestionID, string strThirdAnswer,
            string strMiddleName, string strTitle, string strSuffix, string strAddress2, string strAddress3,
            string strPrimaryPhone, string strSecondaryPhone, string strEmail)
        {
            try
            {
                // create Person
                string strQuery = "SET ANSI_WARNINGS OFF;" +
                    " INSERT INTO ParmarD22Fa2332.Person " +
                    "(NameFirst, NameLast, Address1, City, Zipcode, State, PositionID, Title, Email, PhonePrimary";

                #region Append fields if provided by user
                if (strMiddleName != "")
                    strQuery += ", NameMiddle";

                if (strAddress2 != "")
                    strQuery += ", Address2";

                if (strAddress3 != "")
                    strQuery += ", Address3";

                if (strSecondaryPhone != "")
                    strQuery += ", PhoneSecondary";

                if (strSuffix != "")
                    strQuery += ", Suffix";

                strQuery += ") VALUES " + "(@NameFirst, @NameLast, @Address1, @City, @Zipcode, @State, @PositionID, @Title, @Email, @PhonePrimary";

                if (strMiddleName != "")
                    strQuery += ", @NameMiddle";

                if (strAddress2 != "")
                    strQuery += ", @Address2";

                if (strAddress3 != "")
                    strQuery += ", @Address3";

                if (strSecondaryPhone != "")
                    strQuery += ", @PhoneSecondary";

                if (strSuffix != "")
                    strQuery += ", @Suffix";
                
                strQuery += ");" +
                    "SET ANSI_WARNINGS ON;";

                #endregion


                SqlCommand cmd = new SqlCommand(strQuery, connection);
                cmd.Parameters.AddWithValue("@NameFirst", strFirstName);
                cmd.Parameters.AddWithValue("@NameLast", strLastName);
                cmd.Parameters.AddWithValue("@Address1", strAddress);
                cmd.Parameters.AddWithValue("@City", strCity);
                cmd.Parameters.AddWithValue("@Zipcode", strZIP);
                cmd.Parameters.AddWithValue("@State", strState);
                cmd.Parameters.AddWithValue("@PositionID", 1001); // Customer
                cmd.Parameters.AddWithValue("@Title", strTitle);
                cmd.Parameters.AddWithValue("@Email", strEmail);
                cmd.Parameters.AddWithValue("@PhonePrimary", strPrimaryPhone);

                if (!strMiddleName.Equals(""))
                    cmd.Parameters.AddWithValue("@NameMiddle", strMiddleName);
                if (!strAddress2.Equals(""))
                    cmd.Parameters.AddWithValue("@Address2", strAddress2);
                if (!strAddress3.Equals(""))
                    cmd.Parameters.AddWithValue("@Address3", strAddress3);
                if (!strSecondaryPhone.Equals(""))
                    cmd.Parameters.AddWithValue("@PhoneSecondary", strSecondaryPhone);
                if (!strSuffix.Equals(""))
                    cmd.Parameters.AddWithValue("@Suffix", strSuffix);
                

                cmd.ExecuteNonQuery();
                cmd.Dispose();

                // create logon
                strQuery = "INSERT INTO ParmarD22Fa2332.Logon " +
                    "(PersonID, LogonName, Password, FirstChallengeQuestion, FirstChallengeAnswer, SecondChallengeQuestion, SecondChallengeAnswer, ThirdChallengeQuestion, ThirdChallengeAnswer, PositionTitle) VALUES " +
                    "((Select PersonID FROM ParmarD22Fa2332.Person WHERE NameFirst = @FirstName AND NameLast = @LastName AND Address1 = @Address), @LogonName, @Password, @0, @1, @2, @3, @4, @5, @Title)";

                cmd = new SqlCommand(strQuery, connection);
                cmd.Parameters.AddWithValue("@LogonName", strUsername);
                cmd.Parameters.AddWithValue("@Password", strPassword);
                cmd.Parameters.AddWithValue("@FirstName", strFirstName);
                cmd.Parameters.AddWithValue("@LastName", strLastName);
                cmd.Parameters.AddWithValue("@Address", strAddress);
                cmd.Parameters.AddWithValue("@0", Int32.Parse(strFirstQuestionID));
                cmd.Parameters.AddWithValue("@1", strFirstAnswer);
                cmd.Parameters.AddWithValue("@2", Int32.Parse(strSecondQuestionID));
                cmd.Parameters.AddWithValue("@3", strSecondAnswer);
                cmd.Parameters.AddWithValue("@4", Int32.Parse(strThirdQuestionID));
                cmd.Parameters.AddWithValue("@5", strThirdAnswer);
                cmd.Parameters.AddWithValue("@Title", "Customer");
                cmd.ExecuteNonQuery();

                cmd.Dispose();

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
