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
        bool vlogin, vmail;
        // publicMethods object
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
                using (OleDbConnection connection = new OleDbConnection(pm.getConnString()))
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
                        addressTextBox.Text = reader["Address"].ToString();
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

        private void saveButton_Click(object sender, EventArgs e)
        {
            vlogin = pm.isLoggedIn(currentUser);
            if (vlogin)
            {
                string uname = usernameTextBox.Text;
                string pwd = passwordTextBox.Text;
                string email = emailTextBox.Text;
                string phone = phoneTextBox.Text;
                string address = addressTextBox.Text;
                vmail = pm.IsValidEmail(email);
                if (!vmail)
                {
                    MessageBox.Show("enter a valid email");
                }
                else if (uname == "" || pwd == "")
                {
                    MessageBox.Show("fill in required fields");
                }
                else
                {
                    string updateQuery = "UPDATE users SET Username='" + uname + "', [Password]='" + pwd + "', Email='" + email + "', Phone='"+phone+"', Address='"+address+"' WHERE Username='" + currentUser + "'";
                    pm.connectionOpen(updateQuery);
                    MessageBox.Show("...profile updated...");
                    pm.connectionClose();
                    currentUser = uname;
                }
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
            // Check if user has logged in.
            vlogin = pm.isLoggedIn(currentUser);
            if (vlogin)
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
                            string updateQuery = "UPDATE users SET Avatar='" + imgNewPath + "' WHERE Username='" + currentUser + "'";
                            pm.connectionOpen(updateQuery);
                            MessageBox.Show("...photo updated...");
                            pm.connectionClose();
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
            vlogin = pm.isLoggedIn(currentUser);
            if (vlogin)
            {
                // Update Query, connection open.
                string updateQuery = "UPDATE users SET Avatar='' WHERE Username='" + currentUser + "'";
                OleDbConnection connection = new OleDbConnection(pm.getConnString());
                pm.connectionOpen(updateQuery);
                MessageBox.Show("photo removed");
                pm.connectionClose();
                avatarPictureBox.Image = avatarPictureBox.InitialImage;
            }
        }
        #endregion
    }
}
