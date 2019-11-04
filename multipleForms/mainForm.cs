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
    public partial class mainForm : Form
    {
        #region constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        public mainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Custom constructor
        /// </summary>
        /// <param name="user">String</param>
        public mainForm(String user)
        {
            if (user==""){ 
                InitializeComponent();
                welcomeMsgLabel.Text += "Guest";
            }
            else
            {
                InitializeComponent(); 
                welcomeMsgLabel.Text += user;
                string connectionString = Properties.Settings.Default.aggeliesConnectionString;
                string uname = "SELECT * FROM users WHERE Username='"+user+"'";
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    OleDbCommand command = new OleDbCommand(uname, connection);
                    connection.Open();
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        usernameTextBox.Text = reader.GetString(1);
                        passwordTextBox.Text = reader.GetString(2);
                        emailTextBox.Text = reader.GetString(3);
                        phoneTextBox.Text = reader.GetString(4);
                    }
                    // Close reading.
                    reader.Close();
                }
            }
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
        #endregion

        private void avatarUploadButton_Click(object sender, EventArgs e)
        {
            String imgLocation = "";
            try
            {
                OpenFileDialog imgDialog = new OpenFileDialog();
                imgDialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png) |*.png| All files(*.*)|*.*";

                if (imgDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imgLocation = imgDialog.FileName;
                    avatarPictureBox.ImageLocation = imgLocation;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occured"+ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
    }
}
