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
        #region variables
        // Path to images folder in the application.
        private string imagesLocation = @"C:\Users\TEO\Source\examples\multipleForms\multipleForms\images\";
        private string currentUser, imgPath, imgName, imgNewPath;
        // Connection String and publicMethod object
        string connectionString = Properties.Settings.Default.aggeliesConnectionString;
        publicMethods pm = new publicMethods();
        #endregion

        #region constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public mainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Custom constructor.
        /// </summary>
        /// <param name="user">String</param>
        public mainForm(String user)
        {
            // Guest session (startupForm continueButton).
            if (user == "")
            {
                currentUser = "";
                InitializeComponent();
                // Set welcome text.
                welcomeMsgLabel.Text += "Guest";
            }
            else
            {
                // User session (loginForm dologinButton).
                currentUser = user;
                InitializeComponent();
                // Set welcome text.
                welcomeMsgLabel.Text += currentUser;
                // Start the connection to get users attributes.
                string uname = "SELECT * FROM users WHERE Username='" + currentUser + "'";
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    OleDbCommand command = new OleDbCommand(uname, connection);
                    connection.Open();
                    OleDbDataReader reader = command.ExecuteReader();
                    // For each attribute update the fields.
                    while (reader.Read())
                    {
                        usernameTextBox.Text = reader["Username"].ToString();
                        passwordTextBox.Text = reader["Password"].ToString();
                        emailTextBox.Text = reader["Email"].ToString();
                        phoneTextBox.Text = reader["Phone"].ToString();
                        // If avatar path exists set the image in avataPictureBox
                        if (reader["Avatar"] != DBNull.Value)
                        {
                            avatarPictureBox.ImageLocation = reader["Avatar"].ToString();
                        }
                    }
                    // Close reading.
                    reader.Close();
                }
            }
        }
        #endregion

        #region window move
        /// <summary>
        /// Code snippet for moving the window on mouse click & drag event.
        /// </summary>
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        /// <summary>
        /// Method used for action "MouseMove()".
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
        /// Changes the user avatar and copies the image to the application path.
        /// Updates the path to users table.
        /// </summary>
        /// <param name="sender">avatarUploadButton</param>
        /// <param name="e">Click</param>
        private void avatarUploadButton_Click(object sender, EventArgs e)
        {
            // Check if user has logged in
            if (currentUser == "")
            {
                MessageBox.Show("Need to login or signup first!");
            }
            else
            {
                try
                {
                    // Open file dialog and set directory and file filters.
                    OpenFileDialog imgDialog = new OpenFileDialog();
                    imgDialog.InitialDirectory = "C:\\";
                    imgDialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png) |*.png| All files(*.*)|*.*";
                    // OK button clicked (file selected).
                    if (imgDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        // If file exists (no error in filename).
                        if (imgDialog.CheckFileExists)
                        {
                            // Get file path and name.
                            imgPath = imgDialog.FileName;
                            imgName = System.IO.Path.GetFileName(imgDialog.FileName);
                            // Set the new local path
                            imgNewPath = imagesLocation + imgName;
                            // Copy file to images folder and update avatarPictureBox.
                            System.IO.File.Copy(imgDialog.FileName, imagesLocation + imgName);
                            avatarPictureBox.ImageLocation = imgNewPath;
                            // Database entry.
                            string connectionString = Properties.Settings.Default.aggeliesConnectionString;
                            string updateQuery = "UPDATE users SET Avatar='" + imgNewPath + "' WHERE Username='" + currentUser + "'";

                            OleDbConnection connection = new OleDbConnection(connectionString);
                            OleDbCommand command = new OleDbCommand(updateQuery, connection);

                            connection.Open();
                            command.ExecuteNonQuery();
                            MessageBox.Show("photo updated");
                            connection.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An Error Occured" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// Removes the image path from database and resets avatarPictureBox image to default.
        /// </summary>
        /// <param name="sender">avatarRemoveButton</param>
        /// <param name="e">Click</param>
        private void avatarRemoveButton_Click(object sender, EventArgs e)
        {
            // Check if user has logged in
            if (currentUser == "")
            {
                MessageBox.Show("Need to login or signup first!");
            }
            else
            {
                // Update Query, connection open.
                string updateQuery = "UPDATE users SET Avatar='' WHERE Username='" + currentUser + "'";
                OleDbConnection connection = new OleDbConnection(connectionString);
                OleDbCommand command = new OleDbCommand(updateQuery, connection);
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("photo removed");
                connection.Close();
                avatarPictureBox.Image = avatarPictureBox.InitialImage;
            }
        }
        #endregion
    }
}
