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

namespace multipleForms
{
    public partial class signupForm : Form
    {
        #region variables
        // Connection String and publicMethod object
        string connectionString = Properties.Settings.Default.aggeliesConnectionString;
        bool vmail;
        publicMethods pm = new publicMethods();
        #endregion

        #region Constructors
        /// <summary>
        /// Default Constructor
        /// </summary>
        public signupForm()
        {
            InitializeComponent();
        }
        #endregion

        #region window move
        /// <summary>
        /// Code snippet for moving the window on mouse click & drag event
        /// </summary>
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        /// <summary>
        /// Method used for action "MouseMove()"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        #region private methods
        /// <summary>
        /// Call to method exitApp_Click in publicMethods class to exit the application
        /// </summary>
        /// <param name="sender">exitpictureBox</param>
        /// <param name="e">Click</param>
        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            pm.exitApp_Click(sender, e);
        }
        /// <summary>
        /// Call to method startupForm_Click in publicMethods class to go back to startup form
        /// </summary>
        /// <param name="sender">backButton</param>
        /// <param name="e">Click</param>
        private void backButton_Click(object sender, EventArgs e)
        {
            pm.startupForm_Click(sender, e);
        }
        /// <summary>
        /// Check user input and insert into users table.
        /// </summary>
        /// <param name="sender">dosignupButton</param>
        /// <param name="e">Click</param>
        private void dosignupButton_Click(object sender, EventArgs e)
        {
            // Get user input.
            string uname = usernameTextBox.Text;
            string pwd = passwordTextBox.Text;
            string email = emailTextBox.Text;
            string phone = phoneTextBox.Text;
            // Remove whitespaces at start and end of string.
            uname.Trim();
            // Check if email is in valid format.
            vmail = pm.IsValidEmail(email);
            if (!vmail)
            {
                MessageBox.Show("invalid mail format");
            }
            else
            {
                // Setup Query.
                string insertQuery = "INSERT INTO users (Username, [Password], Email, Phone) VALUES ('" + uname + "','" + pwd + "','" + email + "','" + phone + "')";
                pm.connectionOpen(insertQuery);
                MessageBox.Show("user inserted - test to login");
                pm.connectionClose();
                // Switch to startupForm
                pm.startupForm_Click(sender, e);
            }
        }
        /// <summary>
        /// Show/hide the password text.
        /// </summary>
        /// <param name="sender">showpasswordCheckBox</param>
        /// <param name="e">CheckedChanged</param>
        private void showpasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            pm.showPassword(sender, e, showpasswordCheckBox, passwordTextBox);
        }
        #endregion


    }
}
