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
        /// Call to method exitApp_Click in publicMethods class for exiting the application
        /// </summary>
        /// <param name="sender">exitpictureBox</param>
        /// <param name="e">Click</param>
        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            publicMethods pm = new publicMethods();
            pm.exitApp_Click(sender, e);
        }
        /// <summary>
        /// Call to method startupForm_Click in publicMethods class to go back to startup form
        /// </summary>
        /// <param name="sender">backButton</param>
        /// <param name="e">Click</param>
        private void backButton_Click(object sender, EventArgs e)
        {
            publicMethods pm = new publicMethods();
            pm.startupForm_Click(sender, e);
        }
        /// <summary>
        /// Admin login check. Switch to mainForm with "admin" argument (admin login)
        /// </summary>
        /// <param name="sender">dologinButton</param>
        /// <param name="e">Click</param>
        private void dologinButton_Click(object sender, EventArgs e)
        {
            //Get user input
            string uname = usernameText.Text;
            string pwd = passwordText.Text;
            string connectionString = Properties.Settings.Default.aggeliesConnectionString;
            string unameQuery = "SELECT Username, Password FROM users WHERE Username='"+uname+"' AND Password='"+pwd+"'";
            OleDbDataReader reader;

            OleDbConnection connection = new OleDbConnection(connectionString);
            OleDbCommand command = new OleDbCommand(unameQuery, connection);
            connection.Open();

            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                mainForm mform = new mainForm(uname);
                mform.Show();
            }
            else
            {
                MessageBox.Show("nope");
            }

            /*if (uname == "" || pwd == "")
            {
                MessageBox.Show("Fill in both fields!");
            }
            else
            {
                try
                {
                    OleDbConnection connection = new OleDbConnection(connectionString);
                    OleDbCommand command = new OleDbCommand(unameQuery, connection);
                    connection.Open();
                    command.ExecuteReader();
                    
                    if (set.Tables[0].Rows.Count > 0)
                    {
                        MessageBox.Show(set.Tables[0].Rows.Count.ToString());
                    }
                    else
                    {
                        MessageBox.Show("no such user");
                    }
                    
                }
                catch
                {


                }
            }
            
            //Check uname and pwd -------------------------------------------------------------------
            if (uname != "admin" && pwd != "123" || uname != "test" && pwd != "123")
            {
                //Login failure
                MessageBox.Show("no such user. try admin 123 or go back and click continue");
            }
            
            else
            {
                //Login success
                this.Close();
                //Create the main form
                mainForm mform;
                switch (uname) {
                    case "admin":
                        mform = new mainForm("admin");
                        mform.Show();
                        break;
                    case "test":
                        mform = new mainForm("test");
                        mform.Show();
                        break;
                }
            }*/
        }

        #endregion

    }
}
