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

using FinalProject.Customer_View_Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
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
                MessageBox.Show("Please close your application wait for few minutes then restart the application.\n\nSee Error:\n" + ex.Message, "Unable to connect!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string strQuery = "SELECT p.PersonID, p.NameFirst, p.NameLast, " +
                    "p.Address1, p.Address2, p.Address3, p.City, p.State, p.Zipcode, p.Email, p.PhonePrimary, p.PositionID" +
                    " FROM Person as p " +
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
                    clsPublicData.currentUser = new Person();
                    Person temp = clsPublicData.currentUser;

                    // parse info
                    temp.strPersonID = dtUserTable.Rows[0]["PersonID"].ToString();
                    temp.strFirstName = dtUserTable.Rows[0]["NameFirst"].ToString();
                    temp.strLastName = dtUserTable.Rows[0]["NameLast"].ToString();
                    temp.strAddress1 = dtUserTable.Rows[0]["Address1"].ToString();
                    temp.strAddress2 = dtUserTable.Rows[0]["Address2"].ToString();
                    temp.strAddress3 = dtUserTable.Rows[0]["Address3"].ToString();
                    temp.strCity = dtUserTable.Rows[0]["City"].ToString();
                    temp.strState = dtUserTable.Rows[0]["State"].ToString();
                    temp.strZip = dtUserTable.Rows[0]["ZipCode"].ToString();
                    temp.strEmail = dtUserTable.Rows[0]["Email"].ToString();
                    temp.strPrimaryPhone = dtUserTable.Rows[0]["PhonePrimary"].ToString();
                    temp.strPositionID = dtUserTable.Rows[0]["PositionID"].ToString();

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
                    clsPublicData.currentUser = new Person();
                    Person temp = clsPublicData.currentUser;

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


        public static void LoadCategories(List<clsInventory> lstInventory)
        {
            try
            {
                // setting up query to run
                string strQuery = "SELECT * FROM Categories;";

                // establish command and data adapter
                SqlCommand cmd = new SqlCommand(strQuery, connection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                // create and fill in the data table
                DataTable dtCategoriesTable = new DataTable();
                sqlDataAdapter.SelectCommand = cmd;
                sqlDataAdapter.Fill(dtCategoriesTable);

                // dispose unnecessary data
                cmd.Dispose();
                sqlDataAdapter.Dispose();

                // check if DB return any row

                foreach (DataRow row in dtCategoriesTable.Rows)
                {

                    foreach (clsInventory item in lstInventory.Where(x => x.intCategoryID == Convert.ToInt32(row["CategoryID"])))
                    {
                        item.strCategory = row["CategoryName"].ToString();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static void LoadAllCategories(List<clsCategories> lstCategories)
        {
            try
            {
                // setting up query to run
                string strQuery = "SELECT * FROM Categories;";

                // establish command and data adapter
                SqlCommand cmd = new SqlCommand(strQuery, connection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                // create and fill in the data table
                DataTable dtCategoriesTable = new DataTable();
                sqlDataAdapter.SelectCommand = cmd;
                sqlDataAdapter.Fill(dtCategoriesTable);

                // dispose unnecessary data
                cmd.Dispose();
                sqlDataAdapter.Dispose();

                // check if DB return any row

                foreach (DataRow row in dtCategoriesTable.Rows)
                {
                    clsCategories category = new clsCategories(Convert.ToInt32(row["categoryID"]), row["categoryName"].ToString());

                    lstCategories.Add(category);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static void LoadInventory(List<clsInventory> lstInventory)
        {
            try
            {
                // setting up query to run
                string strQuery = "SELECT * FROM Inventory ORDER BY ItemName;";

                // establish command and data adapter
                SqlCommand cmd = new SqlCommand(strQuery, connection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                // create and fill in the data table
                DataTable dtInventoryTable = new DataTable();
                sqlDataAdapter.SelectCommand = cmd;
                sqlDataAdapter.Fill(dtInventoryTable);

                // dispose unnecessary data
                cmd.Dispose();
                sqlDataAdapter.Dispose();

                // check if DB return any row

                foreach (DataRow row in dtInventoryTable.Rows)
                {
                    clsInventory inventory = new clsInventory();

                    inventory.intID = Convert.ToInt32(row["InventoryID"]);
                    inventory.strName = Convert.ToString(row["ItemName"]);
                    inventory.strDescription = Convert.ToString(row["ItemDescription"]);
                    inventory.decReatailPrice = Convert.ToDecimal(row["RetailPrice"]);
                    inventory.decCost = Convert.ToDecimal(row["Cost"]);
                    inventory.intQuantity = Convert.ToInt32(row["Quantity"]);
                    inventory.intGenderID = Convert.ToInt32(row["GenderID"]);
                    inventory.intBrandID = Convert.ToInt32(row["BrandID"]);
                    inventory.intCategoryID = Convert.ToInt32(row["CategoryID"]);
                    inventory.intRestockThreashold = Convert.ToInt32(row["RestockThreshold"]);
                    inventory.byteImage = (byte[])row["ItemImage"];

                    // Finally add it to list
                    lstInventory.Add(inventory);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static string AddInventory(string name, string description, string categoryID, string reatilPrice, string cost, string quantity, string threshold, string imageLocation, string genderID, string brandID)
        {
            try
            {
                byte[] image = File.ReadAllBytes(imageLocation);

                string strQuery = "INSERT INTO Inventory " +
                    "(ItemName, ItemDescription, CategoryID, RetailPrice, Cost, Quantity, RestockThreshold, GenderID, ItemImage, BrandID, Discontinued) " +
                    "OUTPUT INSERTED.InventoryID " +
                    "VALUES " +
                    "(@ItemName, @ItemDescription, @CategoryID, @RetailPrice, @Cost, @Quantity, @RestockThreshold, @GenderID, @ItemImage, @BrandID, 0)";

                SqlCommand cmd = new SqlCommand(strQuery, connection);
                cmd.Parameters.AddWithValue("@ItemName", name);
                cmd.Parameters.AddWithValue("@ItemDescription", description);
                cmd.Parameters.AddWithValue("@CategoryID", Convert.ToInt32(categoryID));
                cmd.Parameters.AddWithValue("@RetailPrice", Convert.ToDecimal(reatilPrice));
                cmd.Parameters.AddWithValue("@Cost", Convert.ToDecimal(cost));
                cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(quantity));
                cmd.Parameters.AddWithValue("@RestockThreshold", Convert.ToInt32(threshold));
                cmd.Parameters.AddWithValue("@GenderID", genderID);
                cmd.Parameters.AddWithValue("@BrandID", brandID);
                SqlParameter sqlParams = cmd.Parameters.AddWithValue("@ItemImage", image);
                sqlParams.DbType = DbType.Binary;

                int id = (Int32)cmd.ExecuteScalar();

                if (id > 0)
                {
                    return id.ToString();
                }
                else
                {
                    return "false";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "false";
            }

        }

        public static void LoadSizes(List<clsInventory> lstInventory)
        {
            try
            {
                // setting up query to run
                string strQuery = "SELECT * FROM ShoeSize;";

                // establish command and data adapter
                SqlCommand cmd = new SqlCommand(strQuery, connection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                // create and fill in the data table
                DataTable dtShoeSizeTable = new DataTable();
                sqlDataAdapter.SelectCommand = cmd;
                sqlDataAdapter.Fill(dtShoeSizeTable);

                // dispose unnecessary data
                cmd.Dispose();
                sqlDataAdapter.Dispose();

                foreach (var item in lstInventory)
                {
                    item.lstSizes = new List<clsShoeSize>();
                }

                foreach (DataRow row in dtShoeSizeTable.Rows)
                {
                    // Add shoe size to the item
                    if (Convert.ToInt32(row["Quantity"]) > 0)
                    {
                        lstInventory.Find(x => x.intID == Convert.ToInt32(row["ItemID"])).lstSizes.Add(new clsShoeSize(row["Size"].ToString(), Convert.ToInt32(row["Quantity"])));
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static bool GetDiscountCode(string strCuponCode)
        {

            try
            {
                // setting up query to run
                string strQuery = "SELECT * FROM Discounts WHERE DiscountCode = @DiscountCode;";

                // establish command and data adapter
                SqlCommand cmd = new SqlCommand(strQuery, connection);

                cmd.Parameters.AddWithValue("@DiscountCode", strCuponCode);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                // create and fill in the data table
                DataTable dtDiscountTable = new DataTable();
                sqlDataAdapter.SelectCommand = cmd;
                sqlDataAdapter.Fill(dtDiscountTable);

                // dispose unnecessary data
                cmd.Dispose();
                sqlDataAdapter.Dispose();

                // check if DB return any row

                if (dtDiscountTable.Rows.Count >= 1)
                {
                    clsPublicData.discount.DiscountID = dtDiscountTable.Rows[0]["DiscountID"].ToString();
                    clsPublicData.discount.DiscountCode = dtDiscountTable.Rows[0]["DiscountCode"].ToString();
                    clsPublicData.discount.DiscountAmount = dtDiscountTable.Rows[0]["DiscountDollarAmount"].ToString();
                    clsPublicData.discount.DiscountPercentage = dtDiscountTable.Rows[0]["DiscountPercentage"].ToString();
                    clsPublicData.discount.InventoryID = dtDiscountTable.Rows[0]["InventoryID"].ToString();
                    clsPublicData.discount.ExpirationDate = dtDiscountTable.Rows[0]["ExpirationDate"].ToString();
                    clsPublicData.discount.DiscountType = Convert.ToInt32(dtDiscountTable.Rows[0]["DiscountType"].ToString());

                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reviving discounts see error below:\n\n" + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }

            return true;
        }

        public static bool PlaceOrder(string strCardNumber, string ExpDate, string strCCV)
        {

            try
            {
                #region Creating new Order
                string strQuery = "INSERT INTO Orders (PersonID, OrderDate, CC_Number, ExpDate, CCV, Time";

                #region Append discount id if exists
                if (!string.IsNullOrEmpty(clsPublicData.discount.DiscountID))
                    strQuery += ", DiscountID";

                strQuery += ") VALUES (@PersonID, @OrderDate, @CC_Number, @ExpDate, @CCV, @Time";

                if (!string.IsNullOrEmpty(clsPublicData.discount.DiscountID))
                    strQuery += ", @DiscountID";
                strQuery += ");";
                #endregion

                // establish command and data adapter
                SqlCommand cmd = new SqlCommand(strQuery, connection);

                if (!string.IsNullOrEmpty(clsPublicData.discount.DiscountID))
                    cmd.Parameters.AddWithValue("@DiscountID", clsPublicData.discount.DiscountID);

                string orderDate = DateTime.Now.ToString("g");
                string orderTime = DateTime.Now.ToString("T");

                cmd.Parameters.AddWithValue("@PersonID", clsPublicData.currentUser.strPersonID);
                cmd.Parameters.AddWithValue("@OrderDate", orderDate);
                cmd.Parameters.AddWithValue("@Time", orderTime);
                cmd.Parameters.AddWithValue("@CC_Number", strCardNumber);
                cmd.Parameters.AddWithValue("@ExpDate", ExpDate);
                cmd.Parameters.AddWithValue("@CCV", strCCV);
                #endregion

                string orderID;

                if (cmd.ExecuteNonQuery() == 1)
                {
                    #region Getting created order ID
                    strQuery = "SELECT OrderID From Orders WHERE PersonID = CONVERT(int, @PersonID) " +
                        "AND OrderDate = @OrderDate " +
                        "AND CC_Number = @CC_Number " +
                        "AND CCV = @CCV " +
                        "AND Time = @Time;";

                    cmd = new SqlCommand(strQuery, connection);

                    cmd.Parameters.AddWithValue("@PersonID", Convert.ToInt32(clsPublicData.currentUser.strPersonID));
                    cmd.Parameters.AddWithValue("@OrderDate", orderDate);
                    cmd.Parameters.AddWithValue("@CC_Number", strCardNumber);
                    cmd.Parameters.AddWithValue("@CCV", strCCV);
                    cmd.Parameters.AddWithValue("@Time", orderTime);

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                    // create and fill in the data table
                    DataTable dtOrderTable = new DataTable();
                    sqlDataAdapter.SelectCommand = cmd;
                    sqlDataAdapter.Fill(dtOrderTable);

                    // dispose unnecessary data
                    cmd.Dispose();
                    sqlDataAdapter.Dispose();

                    if (dtOrderTable.Rows.Count >= 1)
                    {
                        orderID = dtOrderTable.Rows[0]["OrderID"].ToString();
                        clsPublicData.currentUserCart.orderID = Convert.ToInt32(orderID);
                    }
                    else
                    {
                        return false;
                    }

                    #endregion

                    #region Adding order Details

                    // get that order id
                    strQuery = "INSERT INTO OrderDetails (OrderID, InventoryID, Quantity ";

                    #region Append discount id if exists
                    if (!string.IsNullOrEmpty(clsPublicData.discount.DiscountID))
                        strQuery += ", DiscountID";

                    strQuery += ") VALUES (@OrderID, @InventoryID, @Quantity";

                    if (!string.IsNullOrEmpty(clsPublicData.discount.DiscountID))
                        strQuery += ", @DiscountID";
                    strQuery += ");";
                    #endregion

                    foreach (var item in clsPublicData.currentUserCart.lstUserCart)
                    {
                        // here add every items to the new order details 1 by 1
                        cmd = new SqlCommand(strQuery, connection);

                        cmd.Parameters.AddWithValue("@OrderID", orderID);
                        cmd.Parameters.AddWithValue("@InventoryID", item.inventory.intID);
                        cmd.Parameters.AddWithValue("@Quantity", item.quantity);

                        if (!string.IsNullOrEmpty(clsPublicData.discount.DiscountID))
                            cmd.Parameters.AddWithValue("@DiscountID", clsPublicData.discount.DiscountID);

                        // run the query
                        cmd.ExecuteNonQuery();
                    }

                    #endregion

                    #region Delete product from inventory.

                    foreach (var item in clsPublicData.currentUserCart.lstUserCart)
                    {
                        strQuery = "UPDATE ShoeSize SET Quantity = (Quantity - @Quantity) " +
                            "WHERE ItemID = @InventoryID AND Size = @Size";

                        cmd = new SqlCommand(strQuery, connection);
                        cmd.Parameters.AddWithValue("@Quantity", item.quantity);
                        cmd.Parameters.AddWithValue("@InventoryID", item.inventory.intID);
                        cmd.Parameters.AddWithValue("@Size", item.size.strSize);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();

                        strQuery = "UPDATE Inventory SET Quantity = (SELECT SUM(s.Quantity) FROM ShoeSize as s WHERE ItemID = @ItemID) " +
                            "WHERE InventoryID = @InventoryID;";

                        cmd = new SqlCommand(strQuery, connection);
                        cmd.Parameters.AddWithValue("@ItemID", item.inventory.intID);
                        cmd.Parameters.AddWithValue("@InventoryID", item.inventory.intID);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                    }


                    #endregion

                }
                else
                {
                    MessageBox.Show("Error occurred while creating your order! Please try again later.", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error receiving Placing an order see error below:\n\n" + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public static void LoadGenders(List<clsInventory> lstInventory)
        {
            try
            {
                // setting up query to run
                string strQuery = "SELECT * FROM Genders;";

                // establish command and data adapter
                SqlCommand cmd = new SqlCommand(strQuery, connection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                // create and fill in the data table
                DataTable dtGendersTable = new DataTable();
                sqlDataAdapter.SelectCommand = cmd;
                sqlDataAdapter.Fill(dtGendersTable);

                // dispose unnecessary data
                cmd.Dispose();
                sqlDataAdapter.Dispose();

                // check if DB return any row

                foreach (DataRow row in dtGendersTable.Rows)
                {

                    foreach (clsInventory v in lstInventory.Where(x => x.intGenderID == Convert.ToInt32(row["GenderID"])))
                    {
                        v.strGender = row["Gender"].ToString();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static void LoadBrands(List<clsInventory> lstInventory)
        {
            try
            {
                // setting up query to run
                string strQuery = "SELECT * FROM Brands;";

                // establish command and data adapter
                SqlCommand cmd = new SqlCommand(strQuery, connection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                // create and fill in the data table
                DataTable dtBrandsTable = new DataTable();
                sqlDataAdapter.SelectCommand = cmd;
                sqlDataAdapter.Fill(dtBrandsTable);

                // dispose unnecessary data
                cmd.Dispose();
                sqlDataAdapter.Dispose();

                // check if DB return any row

                foreach (DataRow row in dtBrandsTable.Rows)
                {

                    foreach (clsInventory v in lstInventory.Where(x => x.intBrandID == Convert.ToInt32(row["BrandID"])))
                    {
                        v.strBrand = row["BrandName"].ToString();
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static void LoadAllBrands(List<clsBrand> lstBrandList)
        {
            try
            {
                // setting up query to run
                string strQuery = "SELECT * FROM Brands;";

                // establish command and data adapter
                SqlCommand cmd = new SqlCommand(strQuery, connection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                // create and fill in the data table
                DataTable dtBrandsTable = new DataTable();
                sqlDataAdapter.SelectCommand = cmd;
                sqlDataAdapter.Fill(dtBrandsTable);

                // dispose unnecessary data
                cmd.Dispose();
                sqlDataAdapter.Dispose();

                // check if DB return any row

                foreach (DataRow row in dtBrandsTable.Rows)
                {
                    clsBrand brand = new clsBrand();
                    brand.id = Convert.ToInt32(row["brandId"]);
                    brand.name = row["brandName"].ToString();
                    lstBrandList.Add(brand);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        internal static void AddShoeSize(string size, string quantity, string itemID)
        {
            try
            {
                string strQuery = "INSERT INTO ShoeSize (Size, Quantity, ItemID) " +
                    "VALUES (@Size, @Quantity, @ItemID)";

                SqlCommand cmd = new SqlCommand(strQuery, connection);

                cmd.Parameters.AddWithValue("@Size", size);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@ItemID", itemID);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to add Shoes all sizes. Please try again in few minutes.\n\nSee Error Below:\n" + ex.Message, "SQL ERROR - Adding Sizes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        internal static bool DeleteShoeSize(string size, string itemID)
        {
            try
            {
                string strQuery = "DELETE FROM ShoeSize WHERE Size = @Size AND ItemID = @ItemID; " +
                    "UPDATE Inventory SET Quantity = (SELECT COUNT(s.Quantity) FROM ShoeSize AS s WHERE ItemID = InventoryID) WHERE InventoryID = @ItemID;";

                SqlCommand cmd = new SqlCommand(strQuery, connection);

                cmd.Parameters.AddWithValue("@Size", size);
                cmd.Parameters.AddWithValue("@ItemID", Convert.ToInt32(itemID));

                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Delete Shoes. Please try again in few minutes.\n\nSee Error Below:\n" + ex.Message, "SQL ERROR - Deleting Sizes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        internal static bool UpdateInventory(string name, string desc, string reatilPrice, string cost, string quantity, string restockThreshold,
            string genderID, string categoryID, string brandID, string itemID, string imageLocation = "none")
        {
            string query = "UPDATE Inventory SET itemName = @name, " +
                "ItemDescription = @desc, " +
                "RetailPrice = @retailPrice, " +
                "Cost = @cost, " +
                "Quantity = @quantity, " +
                "RestockThreshold = @restockthreshold, " +
                "GenderID = @genderID, " +
                "BrandID = @brandID, " +
                "CategoryID = @categoryID ";

            if (imageLocation != "none")
            {
                query += ", ItemImage = @img ";
            }

            query += "WHERE InventoryID = @itemID;";

            throw new NotImplementedException();
        }

        /// <summary>
        /// Method to load all customers into the given list.
        /// </summary>
        /// <param name="usersList"></param>
        /// <exception cref="NotImplementedException"></exception>
        internal static void LoadAllCustomers(List<Person> usersList)
        {
            try
            {
                // setting up query to run
                string strQuery = "SELECT * FROM Person as p JOIN Logon AS l ON l.PersonID = p.PersonID;";

                // establish command and data adapter
                SqlCommand cmd = new SqlCommand(strQuery, connection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                // create and fill in the data table
                DataTable dtCustomersTable = new DataTable();
                sqlDataAdapter.SelectCommand = cmd;
                sqlDataAdapter.Fill(dtCustomersTable);

                // dispose unnecessary data
                cmd.Dispose();
                sqlDataAdapter.Dispose();

                // check if DB return any row

                foreach (DataRow row in dtCustomersTable.Rows)
                {
                    Person person = new Person();

                    person.strPersonID = row["PersonID"].ToString();
                    person.strFirstName = row["NameFirst"].ToString();
                    person.strLastName = row["NameLast"].ToString();
                    person.strMiddleName = row["NameMiddle"].ToString();
                    person.strSuffix = row["Suffix"].ToString();
                    person.strTitle = row["Title"].ToString();
                    person.strAddress1 = row["Address1"].ToString();
                    person.strAddress2 = row["Address2"].ToString();
                    person.strAddress3 = row["Address3"].ToString();
                    person.strCity = row["City"].ToString();
                    person.strState = row["State"].ToString();
                    person.strZip = row["Zipcode"].ToString();
                    person.strEmail = row["Email"].ToString();
                    person.strPrimaryPhone = row["PhonePrimary"].ToString();
                    person.strSecondaryPhone = row["PhoneSecondary"].ToString();
                    person.strPositionID = row["PositionID"].ToString();
                    person.strUsername = row["LogonName"].ToString();
                    person.strPassword = row["Password"].ToString();

                    if (person.strPositionID == "1000")
                    {
                        person.strPosition = "Employee";
                    } else
                    {
                        person.strPosition = "Customer";
                    }

                    usersList.Add(person);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        internal static void updatePerson(string userID, string fName, string lName, string mName,
            string title, string suffix, string username,
            string email,string primaryPhone, string secondaryPhone,
            string address1, string address2, string address3,
            string city, string state, string zip,
            string password, string positionID)
        {

            // update everything
            string query = "UPDATE Person SET NameFirst = @NameFirst, " +
                "NameLast = @NameLast, " +
                "NameMiddle = @NameMiddle, " +
                "Suffix = @Suffix, " +
                "Title = @Title, " +
                "Address1 = @Address1, " +
                "Address2 = @Address2, " +
                "Address3 = @Address3, " +
                "City = @City, " +
                "State = @State, " +
                "Zipcode = @Zipcode, " +
                "Email = @Email, " +
                "PhonePrimary = @PhonePrimary, " +
                "PhoneSecondary = @PhoneSecondary, " +
                "PositionID = @PositionID " +
                "WHERE PersonID = @PersonID";

            try
            {

                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@NameFirst", fName);
                cmd.Parameters.AddWithValue("@NameLast", lName);
                cmd.Parameters.AddWithValue("@NameMiddle", mName);
                cmd.Parameters.AddWithValue("@Suffix", suffix);
                cmd.Parameters.AddWithValue("@Title", title);
                cmd.Parameters.AddWithValue("@Address1", address1);
                cmd.Parameters.AddWithValue("@Address2", address2);
                cmd.Parameters.AddWithValue("@Address3", address3);
                cmd.Parameters.AddWithValue("@City", city);
                cmd.Parameters.AddWithValue("@State", state);
                cmd.Parameters.AddWithValue("@Zipcode", zip);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@PhonePrimary", primaryPhone);
                cmd.Parameters.AddWithValue("@PhoneSecondary", secondaryPhone);
                cmd.Parameters.AddWithValue("@PositionID", positionID);
                cmd.Parameters.AddWithValue("@PersonID", Convert.ToInt32(userID));

                cmd.ExecuteNonQuery();
         
                // update user password and user name
                query = "UPDATE Logon SET LogonName = @LogonName, Password = @Password WHERE PersonID = @PersonID";

                cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@LogonName", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@PersonID", userID);
                cmd.ExecuteNonQuery();


                // If everything went well, show message of success
                MessageBox.Show("Successfully Updated User Record", "User Information updated.", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to update your record!\n\nSee Error Below:\n" + ex.Message, "SQL ERROR - Updating user", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal static void LoadAllDiscounts(List<clsDiscounts> dicountCodeList)
        {
            try
            {
                // setting up query to run
                string strQuery = "SELECT * FROM Discounts;";

                // establish command and data adapter
                SqlCommand cmd = new SqlCommand(strQuery, connection);


                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                // create and fill in the data table
                DataTable dtDiscountTable = new DataTable();
                sqlDataAdapter.SelectCommand = cmd;
                sqlDataAdapter.Fill(dtDiscountTable);

                // dispose unnecessary data
                cmd.Dispose();
                sqlDataAdapter.Dispose();

                // check if DB return any row
                foreach(DataRow row in dtDiscountTable.Rows)
                {
                    clsDiscounts discount = new clsDiscounts();

                    discount.DiscountID = row["DiscountID"].ToString();
                    discount.DiscountCode = row["DiscountCode"].ToString();
                    discount.Description = row["Description"].ToString();
                    discount.DiscountAmount = row["DiscountDollarAmount"].ToString();
                    discount.DiscountPercentage = row["DiscountPercentage"].ToString();
                    discount.InventoryID = row["InventoryID"].ToString();
                    discount.ExpirationDate = row["ExpirationDate"].ToString();
                    discount.StartDate = row["StartDate"].ToString();
                    discount.DiscountType = Convert.ToInt32(row["DiscountType"].ToString());
                    discount.DiscountLevel = row["DiscountLevel"].ToString();

                    dicountCodeList.Add(discount);
                }

          
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reviving discounts see error below:\n\n" + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        internal static void AddDiscount(clsDiscounts discountCode)
        {


            try
            {
                string query = "INSERT INTO Discounts (DiscountCode, Description, DiscountLevel, DiscountType, StartDate, ExpirationDate, ";
                 
                if (discountCode.DiscountType == 1)
                    query += "DiscountPercentage) ";
                else
                    query += "DiscountDollarAmount) ";

                query += "VALUES (@DiscountCode, @Description, @DiscountLevel, @DiscountType, @StartDate, @ExpirationDate, @Discount);";


                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@DiscountCode", discountCode.DiscountCode);
                cmd.Parameters.AddWithValue("@Description", discountCode.Description);
                cmd.Parameters.AddWithValue("@DiscountLevel", discountCode.DiscountLevel);
                cmd.Parameters.AddWithValue("@DiscountType", discountCode.DiscountType);
                cmd.Parameters.AddWithValue("@StartDate", discountCode.StartDate);
                cmd.Parameters.AddWithValue("@ExpirationDate", discountCode.ExpirationDate);
                
                if (discountCode.DiscountType == 1) // Percentage
                    cmd.Parameters.AddWithValue("@Discount", discountCode.DiscountPercentage);
                else // amount
                    cmd.Parameters.AddWithValue("@Discount", discountCode.DiscountAmount);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Code successfully added!", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding discounts, see error below:\n\n" + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal static void UpdateDiscount(clsDiscounts discountCode)
        {
            try
            {
                string query = "UPDATE Discounts SET DiscountCode = @DiscountCode," +
                " Description = @Description," +
                " DiscountLevel = @DiscountLevel," +
                " DiscountType = @DiscountType," +
                " StartDate = @StartDate," +
                " ExpirationDate = @ExpirationDate, ";

                if (discountCode.DiscountType == 1)
                    query += "DiscountPercentage = @Discount ";
                else
                    query += "DiscountDollarAmount = @Discount ";

                query += "WHERE DiscountID = @DiscountID";


                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@DiscountCode", discountCode.DiscountCode);
                cmd.Parameters.AddWithValue("@Description", discountCode.Description);
                cmd.Parameters.AddWithValue("@DiscountLevel", discountCode.DiscountLevel);
                cmd.Parameters.AddWithValue("@DiscountType", discountCode.DiscountType);
                cmd.Parameters.AddWithValue("@StartDate", discountCode.StartDate);
                cmd.Parameters.AddWithValue("@ExpirationDate", discountCode.ExpirationDate);
                cmd.Parameters.AddWithValue("@DiscountID", discountCode.DiscountID);

                if (discountCode.DiscountType == 1) // Percentage
                    cmd.Parameters.AddWithValue("@Discount", discountCode.DiscountPercentage);
                else // amount
                    cmd.Parameters.AddWithValue("@Discount", discountCode.DiscountAmount);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Code successfully Updated!", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding discounts, see error below:\n\n" + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

