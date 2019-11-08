using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multipleForms
{
    public class publicMethods
    {
        #region variables
        // Connection String and publicMethod object
        static string connectionString = Properties.Settings.Default.aggeliesConnectionString;
        OleDbConnection connection = new OleDbConnection(connectionString);
        OleDbCommand command;
        #endregion

        #region public methods

        /// <summary>
        /// Get the connection String
        /// </summary>
        /// <returns>connectionString</returns>
        public string getConnString()
        {
            return connectionString;
        }

        /// <summary>
        /// Exits the application.
        /// </summary>
        /// <param name="sender">pictureBox</param>
        /// <param name="e">Click</param>
        public void exitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Closes current form and opens the startup form.
        /// </summary>
        /// <param name="sender">backButton</param>
        /// <param name="e">Click</param>
        public void startupForm_Click(object sender, EventArgs e)
        {
            //Get current open form and close it.
            var s = Application.OpenForms[Application.OpenForms.Count - 1];
            s.Hide();
            startupForm startform = new startupForm();
            startform.Show();
        }

        /// <summary>
        /// Check the email provided by user.
        /// </summary>
        /// <param name="email">User string</param>
        /// <returns>boolean</returns>
        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Opens the database connection 
        /// Execute nonQuery command
        /// </summary>
        /// <param name="query">String</param>
        public void connectionOpen(string query)
        {
            command = new OleDbCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Closes the current connection to database
        /// </summary>
        public void connectionClose()
        {
            connection.Close();
        }
        /// <summary>
        /// Show/hide the text in passwordText textBox
        /// </summary>
        /// <param name="sender">showpasswordCheckBox</param>
        /// <param name="e">Checked</param>
        public void showPassword(object sender, EventArgs e, CheckBox cb, TextBox tb)
        {
            if (cb.Checked)
            {
                tb.PasswordChar = '\0';
                cb.Text = "hide";
            }
            else
            {
                tb.PasswordChar = '*';
                cb.Text = "show";
            }
        }
        /// <summary>
        /// Check if user is logged in
        /// </summary>
        /// <param name="user">userName</param>
        /// <returns>boolean</returns>
        public Boolean isLoggedIn(string user)
        {
            if (user == "")
            {
                MessageBox.Show("Need to login or signup first!");
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion
    }
}
