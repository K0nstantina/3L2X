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


namespace UserApplication
{
    public partial class UserForm : Form
    {
        #region Variables
        List<Panel> panels = new List<Panel>();
        List<Button> buttons = new List<Button>();
        DataRowView view;
        int userid;
        private string imgPath, imgName, imgNewPath;
        private string imagesLocation = @"C:\Users\TEO\Documents\GitHub\3L2X\Aggelies3L2X\userDesign\Resources\images\";
        private string userImagesLocation = @"C:\Users\TEO\Documents\GitHub\3L2X\Aggelies3L2X\userDesign\Resources\userImages\";
        #endregion

        #region Constructor
        public UserForm()
        {

        }
        public UserForm(int userID)
        {
            InitializeComponent();
            controlsList();
            userid = userID;
            //var userMenu = new aggeliesWpfLab.UserMenu();
            //elementHost1.Child = userMenu;
            //userMenu.HomeBut.Click += HomeBut_Click;
            //userMenu.settingBut.Click += SettingBut_Click;
            //userMenu.adsBut.Click += AdsBut_Click;
            //userMenu.catBut.Click += CatBut_Click;
            //userMenu.profileBut.Click += ProfileBut_Click;
            //userMenu.logoutBut.Click += LogoutBut_Click;
            //label5.Text = userid.ToString();
            //userMenu1.logoutBut += logoutBut_Click;
            updateFields();
        }
        #endregion

        #region Navigation
        private void HomeBut_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            panels[0].BringToFront();
        }
        private void SettingBut_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            panels[1].BringToFront();
        }
        private void AdsBut_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            panels[2].BringToFront();
        }
        private void CatBut_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            panels[3].BringToFront();
        }
        private void ProfileBut_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            panels[4].BringToFront();
        }
        private void LogoutBut_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.Close();
            // This line stops debugger and starts the app - Temporary Solution.
            System.Diagnostics.Process.Start(Application.StartupPath.ToString() + @"\Login.exe");
        }

        /// <summary>
        /// Populates the panel and control lists
        /// </summary>
        private void controlsList()
        {
            panels.Add(homePanel); //0
            panels.Add(settingsPanel); //1
            panels.Add(adsPanel); //2
            panels.Add(page4Panel);
            panels.Add(profilePanel);
            panels.Add(page6Panel);

            panels[0].BringToFront();
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Form Load.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aggeliesDBDataSet.AdsTable' table. You can move, or remove it, as needed.
            adsListBox_SelectedIndexChanged(adsListBox, e);
        }

        /// <summary>
        /// Enables editing the titleTextBox.
        /// Changes editTitlePictureBox image accordingly.
        /// </summary>
        /// <param name="sender">editTitlePictureBox</param>
        /// <param name="e">Click</param>
        private void titleEditPictureBox_Click(object sender, EventArgs e)
        {
            if (titleTextBox.Enabled == false)
            {
                titleTextBox.Enabled = true;
                editTitlePictureBox.Image = UserApplication.Properties.Resources.save1;
            }
            else
            {
                titleTextBox.Enabled = false;
                editTitlePictureBox.Image = UserApplication.Properties.Resources.edit1;
                try 
                {
                    view = adsListBox.SelectedItem as DataRowView;
                    int adID = Int32.Parse(view["adID"].ToString());
                    this.adsTableTableAdapter.UpdateTitleDescQuery(titleTextBox.Text, descriptionRichTextBox.Text, adID);
                }
                catch (Exception)
                {
                    MessageBox.Show("not updated");
                }
            }
        }

        /// <summary>
        /// Enables editing the descriptionRichTextBox.
        /// Changes editDescriptionPictureBox image accordingly.
        /// </summary>
        /// <param name="sender">editTitlePictureBox</param>
        /// <param name="e">Click</param>
        private void descriptionEditPictureBox_Click(object sender, EventArgs e)
        {
            if (descriptionRichTextBox.Enabled == false)
            {
                descriptionRichTextBox.Enabled = true;
                editDescriptionPictureBox.Image = UserApplication.Properties.Resources.save1;
            }
            else
            {
                descriptionRichTextBox.Enabled = false;
                editDescriptionPictureBox.Image = UserApplication.Properties.Resources.edit1;
            }
        }

        /// <summary>
        /// Changes the image path in database per adID.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editPicturePictureBox_Click(object sender, EventArgs e)
        {
            try
            {
                // Open file dialog and set directory and file filters.
                OpenFileDialog imgDialog = new OpenFileDialog();
                //imgDialog.InitialDirectory = "C:\\";
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
                        // Get current adID.
                        view = adsListBox.SelectedItem as DataRowView;
                        int adID = Int32.Parse(view["adID"].ToString());
                        // Update the image path in database.
                        this.adsTableTableAdapter.UpdateImageQuery(imgNewPath, adID);
                        // Set adsPicturebox new image.
                        adsPictureBox.ImageLocation = imgNewPath;
                        // Update DataRowView dynamicaly.
                        view.BeginEdit();
                        view["media"] = imgNewPath;
                        view.EndEdit();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occured" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Event handler for selected index in adsListBox.
        /// Updates the title and description text in controls.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void adsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                adsListBox.Refresh();
                view = adsListBox.SelectedItem as DataRowView;
                string title = view["adTitle"].ToString();
                string desc = view["adDesc"].ToString();
                String img = view["media"].ToString();

                titleTextBox.Text = title;
                descriptionRichTextBox.Text = desc;
                adsPictureBox.ImageLocation = img;
            }
            catch (Exception x)
            {
                //MessageBox.Show(x.ToString());
            }
        }

        private void avatarUploadButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Open file dialog and set directory and file filters.
                OpenFileDialog imgDialog = new OpenFileDialog();
                //imgDialog.InitialDirectory = "C:\\";
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
                        imgNewPath = userImagesLocation + imgName;
                        // Copy file to images folder and update avatarPictureBox.
                        System.IO.File.Copy(imgDialog.FileName, imgNewPath);
                        // Update the image path in database.
                        this.usersTableAdapter1.UpdateUserImageQuery(imgNewPath, userid);
                        // Set avatarPictureBox new image.
                        avatarPictureBox.ImageLocation = imgNewPath;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occured" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void avatarRemoveButton_Click(object sender, EventArgs e)
        {
            // Update the image path in database.
            this.usersTableAdapter1.UpdateUserImageQuery("", userid);
            avatarPictureBox.Image = UserApplication.Properties.Resources.userAvatar;
        }

        private void showpasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showpasswordCheckBox.Checked)
            {
                uPasswordTextBox.PasswordChar = '\0';
                showpasswordCheckBox.Text = "hide";
            }
            else
            {
                uPasswordTextBox.PasswordChar = '*';
                showpasswordCheckBox.Text = "show";
            }
        }

        private void updateFields()
        {
            this.adsTableTableAdapter.AdsPerUser(this.aggeliesDBDataSet.AdsTable, userid);
            try
            {
                avatarPictureBox.ImageLocation = usersTableAdapter1.SelectUserImageQuery(userid).ToString();
            }
            catch (Exception) {}
            uNameTextBox.Text = usersTableAdapter1.SelectUsernameQuery(userid).ToString();
            fNameTextBox.Text = usersTableAdapter1.SelectFirstNameQuery(userid).ToString();
            lNameTextBox.Text = usersTableAdapter1.SelectLastNameQuery(userid).ToString();
            uEmailTextBox.Text = usersTableAdapter1.SelectUserEmailQuery(userid).ToString();
            uPasswordTextBox.Text = usersTableAdapter1.SelectUserPasswordQuery(userid).ToString();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion

    }
}
