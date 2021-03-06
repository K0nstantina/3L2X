﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class LoginForm : Form
    {
        #region Variables
        string connectionString = Properties.Settings.Default.AggeliesDBConnectionString;
        #endregion

        public LoginForm()
        {
            InitializeComponent();
        }

        private void userFormButton_Click(object sender, EventArgs e)
        {
            // Get user input.
            string uname = usernameTextBox.Text;
            string pwd = passwordTextBox.Text;
            // Setup Query, declare reader.
            string unameQuery = "SELECT userID, uName, uPassword FROM Users WHERE uName='" + uname + "' AND uPassword='" + pwd + "'";
            OleDbDataReader reader;
            // Open connection.
            OleDbConnection connection = new OleDbConnection(connectionString);
            OleDbCommand command = new OleDbCommand(unameQuery, connection);
            connection.Open();
            // Execute reader.
            reader = command.ExecuteReader();
            // If user exists.
            if (reader.HasRows)
            {
                reader.Read();
                string uid = reader["userID"].ToString();
                reader.Close();
                connection.Close();
                this.Hide();
                UserApplication.UserForm userForm = new UserApplication.UserForm(int.Parse(uid));
                userForm.Show();    
            }
            // No such user.
            else
            {
                MessageBox.Show("Wrong username/password combination!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CheckEnter(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                userFormButton_Click(sender, e);
            }
        }

        private void guestButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserApplication.UserForm userForm = new UserApplication.UserForm(9999);
            userForm.Show();
        }

        private void createaccountLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            CreateAccountForm createAccount = new CreateAccountForm();
            createAccount.Show();




        }
    }
}
