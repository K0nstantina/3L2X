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
        // Valid login and valid email
        bool vlogin, vmail;
        // Indexes the userAdds List
        int index = 0;
        User validUser=new User();
        List<Adds> userAdds=new List<Adds>();
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
            // Valid user session
            else
            {
                // Set current user session and create new user.
                currentUser = user;
                validUser = new User(currentUser);
                InitializeComponent();
                // Set welcome text.
                welcomeMsgLabel.Text += currentUser;                    
                // Populate the fields in account management tab.
                usernameTextBox.Text = validUser.getUserName();
                passwordTextBox.Text = validUser.getUserPassword();
                emailTextBox.Text = validUser.getUserEmail();
                phoneTextBox.Text = validUser.getUserPhone();
                altPhoneTextBox.Text = validUser.getUserAltPhone();
                addressTextBox.Text = validUser.getUserAddress();
                avatarPictureBox.ImageLocation = validUser.getUserImage();

                // Get the users ads and make a userAdds List.
                string selectQuery = "SELECT * FROM Ads WHERE adOwner=" + int.Parse(validUser.getUserID());
                using (OleDbConnection connection = new OleDbConnection(pm.getConnString()))
                {
                    OleDbCommand command = new OleDbCommand(selectQuery, connection);
                    connection.Open();
                    OleDbDataReader reader = command.ExecuteReader();
                    // For each attribute set the variables.
                    while (reader.Read())
                    {
                        // Populate adsListBox in Ads Management tab.
                        adsListBox.Items.Add(reader["adTitle"].ToString());
                        // Get ad values.
                        string adID = reader["adID"].ToString();
                        string adCategory = reader["adCategory"].ToString();
                        string adOwner = reader["adOwner"].ToString();
                        string adObj = reader["adObj"].ToString();
                        string adDesc = reader["adDesc"].ToString();
                        string adCreation = reader["adCreation"].ToString();
                        string adModification = reader["adModification"].ToString();
                        string adImages = reader["adImages"].ToString();
                        string adTitle = reader["adTitle"].ToString();
                        // Add the new ad to userAdds List.
                        userAdds.Add(new Adds(adID, adOwner, adCategory, adObj, adDesc, adCreation, adModification, adImages, adTitle));
                    }
                    reader.Close();
                }
                // Check if user lists any ads.
                if (adsListBox.Items.Count > 0)
                {
                    adsListBox.SelectedIndex = 0;
                    index = adsListBox.SelectedIndex;
                    desciptionTextBox.Text = userAdds[index].getAdDesc();
                    categoryComboBox.SelectedValue = userAdds[index].getAdCategory();
                }
                // FOR DEBUGGING....
                for(int i = 0; i < userAdds.Count; i++)
                {
                    textBox1.Text += "category: "+userAdds[i].getAdCategory() + ", title: "+userAdds[i].getAdTitle()+"\n";
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
        /// Inserts user profile changes to the database.
        /// </summary>
        /// <param name="sender">saveButton</param>
        /// <param name="e">Click</param>
        private void saveButton_Click(object sender, EventArgs e)
        {
            vlogin = pm.isLoggedIn(currentUser);
            if (vlogin)
            {
                string uname = usernameTextBox.Text;
                string pwd = passwordTextBox.Text;
                string email = emailTextBox.Text;
                string phone = phoneTextBox.Text;
                string altphone = altPhoneTextBox.Text;
                string address = addressTextBox.Text;
                // Check email format.
                vmail = pm.IsValidEmail(email);
                if (!vmail)
                {
                    MessageBox.Show("enter a valid email");
                }
                // Check if username or password fields are empty.
                else if (uname == "" || pwd == "")
                {
                    MessageBox.Show("fill in required fields");
                }
                // If changes are valid.
                else
                {
                    string updateQuery = "UPDATE users SET userName='" + uname + "', userPassword='" + pwd + "', userEmail='" + email + "', userPhone='"+phone+"',userAltPhone='"+altphone+"', userAdress='"+address+"' WHERE userName='" + currentUser + "'";
                    pm.connectionOpen(updateQuery);
                    MessageBox.Show("...profile updated...");
                    pm.connectionClose();
                    currentUser = uname;
                }
            }
        }
        /// <summary>
        /// Sets descriptioTextBox text and categoryComboBox according to selected ad.
        /// </summary>
        /// <param name="sender">adsListBox</param>
        /// <param name="e">SelectedIndexChanged</param>
        private void adsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = adsListBox.SelectedIndex;
            desciptionTextBox.Text = userAdds[index].getAdDesc()+" "+index+" "+ userAdds[index].getAdCategory();
            categoryComboBox.SelectedValue = userAdds[index].getAdCategory();
        }
        /// <summary>
        /// Auto-Generated code
        /// </summary>
        /// <param name="sender">mainForm</param>
        /// <param name="e">Load</param>
        private void mainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adCategoriesDatabaseDataSet.AdCategories' table. You can move, or remove it, as needed.
            this.adCategoriesTableAdapter.Fill(this.adCategoriesDatabaseDataSet.AdCategories);
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
                            string updateQuery = "UPDATE Users SET userImage='" + imgNewPath + "' WHERE userName='" + currentUser + "'";
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
                string updateQuery = "UPDATE Users SET userImage='' WHERE userName='" + currentUser + "'";
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
