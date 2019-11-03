using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            //Check uname and pwd
            if (uname != "admin" && pwd != "123")
            {
                //Login failure
                MessageBox.Show("no such user. try admin 123 or go back and click continue");
            }
            else
            {
                //Login success
                this.Close();
                mainForm mform = new mainForm("admin");
                mform.Show();
            }
        }

        #endregion

    }
}
