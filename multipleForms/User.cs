using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multipleForms
{
    class User
    {
        #region variables
        private string userName, userEmail, userPassword, userAddress, userImage, userID, userPhone, userAltPhone;
        publicMethods pm = new publicMethods();
        #endregion

        #region constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        public User()
        {

        }
        /// <summary>
        /// Custom constructor
        /// </summary>
        /// <param name="uname">String passed from main form</param>
        public User(string uname)
        {
            string selectQuery = "SELECT * FROM Users WHERE userName='" + uname + "'";
            using (OleDbConnection connection = new OleDbConnection(pm.getConnString()))
            {
                OleDbCommand command = new OleDbCommand(selectQuery, connection);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();
                // For each attribute set the variables.
                while (reader.Read())
                {
                    userName = reader["userName"].ToString();
                    userEmail = reader["userEmail"].ToString();
                    userPassword = reader["userPassword"].ToString();
                    userAddress = reader["userAdress"].ToString();
                    userImage = reader["userImage"].ToString();
                    userID = reader["userID"].ToString();
                    userPhone = reader["userPhone"].ToString();
                    userAltPhone = reader["userAltPhone"].ToString();
                }
                // Close reading.
                reader.Close();
            }
            
        }
        #endregion

        #region getters
        public string getUserName()
        {
            return userName.ToString();
        }
        public string getUserEmail()
        {
            return userEmail.ToString();
        }
        public string getUserPassword()
        {
            return userPassword.ToString();
        }
        public string getUserImage()
        {
            return userImage.ToString();
        }
        public string getUserID()
        {
            return userID.ToString();
        }
        public string getUserPhone()
        {
            return userPhone.ToString();
        }
        public string getUserAltPhone()
        {
            return userAltPhone.ToString();
        }
        public string getUserAddress()
        {
            return userAddress.ToString();
        }
        #endregion

    }
}
