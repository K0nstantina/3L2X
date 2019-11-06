using System;
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
    public partial class loginForm : Form
    {
        #region variables
        // Connection String and publicMethod object
        string connectionString = Properties.Settings.Default.aggeliesConnectionString;
        publicMethods pm = new publicMethods();
        #endregion

        #region constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        public loginForm()
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
        /// Call to method exitApp_Click in publicMethods class to exit the application.
        /// </summary>
        /// <param name="sender">exitpictureBox</param>
        /// <param name="e">Click</param>
        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            pm.exitApp_Click(sender, e);
        }
        /// <summary>
        /// Call to method startupForm_Click in publicMethods class to go back to startup form.
        /// </summary>
        /// <param name="sender">backButton</param>
        /// <param name="e">Click</param>
        private void backButton_Click(object sender, EventArgs e)
        {
            pm.startupForm_Click(sender, e);
        }
        /// <summary>
        /// User login
        /// </summary>
        /// <param name="sender">dologinButton</param>
        /// <param name="e">Click</param>
        private void dologinButton_Click(object sender, EventArgs e)
        {
            // Get user input.
            string uname = usernameText.Text;
            string pwd = passwordText.Text;
            // Setup Query, declare reader.
            string unameQuery = "SELECT Username, Password FROM users WHERE Username='"+uname+"' AND Password='"+pwd+"'";
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
                this.Close();
                mainForm mform = new mainForm(uname);
                mform.Show();
            }
            // No such user.
            else
            {
                MessageBox.Show("nope");
            }

        }
        private void CheckEnter(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                dologinButton_Click(sender, e);
            }
        }
        #endregion
    }
}
