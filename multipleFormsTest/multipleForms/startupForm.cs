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
    public partial class startupForm : Form
    {
        #region variables
        // Connection String and publicMethod object
        string connectionString = Properties.Settings.Default.aggeliesConnectionString;
        publicMethods pm = new publicMethods();
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        public startupForm()
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
        /// Open the signin form
        /// </summary>
        /// <param name="sender">loginButton</param>
        /// <param name="e">Click</param>
        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm linForm = new loginForm();
            linForm.Show();
        }
        /// <summary>
        /// Switch to mainForm with "" argument (Guest)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void continueButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm mForm = new mainForm("");
            mForm.Show();
        }
        /// <summary>
        /// Open the signup form
        /// </summary>
        /// <param name="sender">signupButton</param>
        /// <param name="e">Click</param>
        private void signupButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            signupForm sinForm = new signupForm();
            sinForm.Show();
        }
        #endregion

    }
}
