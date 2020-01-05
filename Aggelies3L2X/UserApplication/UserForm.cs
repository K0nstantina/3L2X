using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace UserApplication
{
    public partial class UserForm : Form
    {
        #region Variables
        List<Panel> panels = new List<Panel>();
        List<DisplayAds> recentAdsList = new List<DisplayAds>();
        DataRowView view;
        BindingSource bs = new BindingSource();
        int userid;
        private string imgName, imgNewPath, imagesLocation, userImagesLocation;
        #endregion

        #region Constructors
        public UserForm()
        {

        }
        public UserForm(int userID)
        {
            InitializeComponent();
            // Add controls to list.
            controlsList();
            userid = userID;
            // Initialize profile fields (profile panel) and recentAds (home panel).
            updateFields();
            recentAds();
            initializeView();
            // Add WPF control to host and set the event handlers.
            var userMenu = new aggeliesWpfLab.UserMenuIcons();
            elementHost1.Child = userMenu;
            elementHost1.Select();
            userMenu.homeButton.Click += HomeButton_Click;
            userMenu.settingsButton.Click += SettingBut_Click;
            userMenu.adsButton.Click += AdsBut_Click;
            userMenu.categoriesButton.Click += CatBut_Click;
            userMenu.profileButton.Click += ProfileBut_Click;
            userMenu.logoutButton.Click += LogoutBut_Click;
        }
        #endregion

        #region Navigation
        private void HomeButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            panels[0].BringToFront();
            recentAds();
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
            initializeView();
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
        #endregion

        #region Private Methods

        #region Homepage Panel Methods
        /// <summary>
        /// Populates the custom RecentAds.cs control with recently added ads.
        /// </summary>
        private void recentAds()
        {
            bs.DataSource = adsTableTableAdapter.GetRecentAds();
            recentAdsListBox.DataSource = bs;

            for (int i = 0; i < recentAdsList.Count; i++)
            {
                view = recentAdsListBox.Items[i] as DataRowView;
                recentAdsList[i].titleTextBox.Text = view["adTitle"].ToString();
                recentAdsList[i].descTextBox.Text = view["adDesc"].ToString();
                recentAdsList[i].mediaPictureBox.ImageLocation = imagesLocation + view["media"].ToString();
            }
        }
        #endregion

        #region Categories Panel Methods

        private void initializeView()
        {
            mainCategoriesComboBox.DataSource = this.adCategoryTableAdapter1.GetDTMainCategories();
            mainCategoriesComboBox.DisplayMember = "catTitle";
            mainCategoriesComboBox.ValueMember = "catID";
            mainCategoriesComboBox.SelectedIndex = 0;
        }


        /// <summary>
        /// Event Handler for selected index in mainCategoriesComboBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainCategoriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            childCategoriesComboBox.Enabled = true;
            view = mainCategoriesComboBox.SelectedItem as DataRowView;
            categoriesLabel.Text = view["catTitle"].ToString();

            childCategoriesComboBox.DataSource = this.adCategoryTableAdapter1.GetDTChildCategories(Int32.Parse(view["catID"].ToString()));
            childCategoriesComboBox.DisplayMember = "catTitle";
            childCategoriesComboBox.ValueMember = "catID";            
            childCategoriesComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Event Handler for selected index in childCategoriesComboBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void childCategoriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            gChildComboBox.Visible = false;
            view = childCategoriesComboBox.SelectedItem as DataRowView;
            int catID = Int32.Parse(view["catID"].ToString());
            if (catID==23 || catID==25)
            {
                gChildComboBox.Visible = true;
                gChildComboBox.DataSource = this.adCategoryTableAdapter1.GetDTChildCategories(catID);
                gChildComboBox.DisplayMember = "catTitle";
                gChildComboBox.ValueMember = "catID";
                gChildComboBox.SelectedIndex = 0;
            }
            else
            {
                updateCategoriesListBox(childCategoriesComboBox);
            }
        }

        /// <summary>
        /// Event handler for selected index in residenceComboBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gChildComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateCategoriesListBox(gChildComboBox);
        }

        /// <summary>
        /// Event Handler for selected index in categoriesListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void categoriesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoriesListBox.DataSource!=null)
            {
                view = categoriesListBox.SelectedItem as DataRowView;
                displayAd.titleTextBox.Text = view["adTitle"].ToString();
                displayAd.descTextBox.Text = view["adDesc"].ToString();
                displayAd.mediaPictureBox.ImageLocation = imagesLocation + view["media"].ToString();
            }

        }

        /// <summary>
        /// Updates the displayed ad.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateCategoriesListBox(ComboBox cb)
        {
            displayAd.Visible = true;
            view = cb.SelectedItem as DataRowView;
            int category = Int32.Parse(view["catID"].ToString());
            // Filter ads by category ID.
            bs.DataSource = adsTableTableAdapter.GetDTFilterAds(category);
            categoriesListBox.DataSource = bs;
            categoriesListBox.DisplayMember = "adTitle";
            categoriesListBox.ValueMember = "adID";

            view = categoriesListBox.SelectedItem as DataRowView;
            displayAd.titleTextBox.Text = view["adTitle"].ToString();
            displayAd.descTextBox.Text = view["adDesc"].ToString();
            displayAd.mediaPictureBox.ImageLocation = imagesLocation + view["media"].ToString();
        }

        #endregion

        #region ADS Panel Methods
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
                updateTitleDesc();
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
                updateTitleDesc();
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
                        // Get file name.
                        imgName = System.IO.Path.GetFileName(imgDialog.FileName);
                        // Set the new local path
                        imgNewPath = imagesLocation + imgName;
                        // Copy file to images folder and update avatarPictureBox.
                        System.IO.File.Copy(imgDialog.FileName, imagesLocation + imgName);
                        // Get current adID.
                        view = adsListBox.SelectedItem as DataRowView;
                        int adID = Int32.Parse(view["adID"].ToString());
                        // Update the image path in database.
                        this.adsTableTableAdapter.UpdateImageQuery(imgName, adID);
                        // Set adsPicturebox new image.
                        adsPictureBox.ImageLocation = imgNewPath;
                        // Update DataRowView dynamicaly.
                        view.BeginEdit();
                        view["media"] = imgName;
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

                string img = view["media"].ToString();
                adsPictureBox.ImageLocation = imagesLocation + img;

                titleTextBox.Text = view["adTitle"].ToString(); ;
                descriptionRichTextBox.Text = view["adDesc"].ToString();
                creationDateTextBox.Text = view["creationDate"].ToString();
                expirationDateTextBox.Text = view["expirationDate"].ToString();
                priceTextBox.Text = view["price"].ToString();

                if (view["published"].ToString() == "True")
                {
                    publishedTextBox.Text = "Published";
                }
                else
                {
                    publishedTextBox.Text = "Not yet published";
                }
            }
            catch (Exception x)
            {
                //MessageBox.Show(x.ToString());
            }
        }
        /// <summary>
        /// Updates the tilte and description in database.
        /// </summary>
        private void updateTitleDesc()
        {
            try
            {
                view = adsListBox.SelectedItem as DataRowView;
                int adID = Int32.Parse(view["adID"].ToString());
                this.adsTableTableAdapter.UpdateTitleDescQuery(titleTextBox.Text, descriptionRichTextBox.Text, adID);
                updateFields();
            }
            catch (Exception)
            {
                MessageBox.Show("not updated");
            }
        }

        /// <summary>
        /// Update the price to database
        /// </summary>
        /// <param name="sender">savePriceButton</param>
        /// <param name="e">Click</param>
        private void savePriceButton_Click(object sender, EventArgs e)
        {
            int price;
            bool result = Int32.TryParse(priceTextBox.Text, out price);
            if (result)
            {
                // Get current adID.
                view = adsListBox.SelectedItem as DataRowView;
                int adID = Int32.Parse(view["adID"].ToString());
                adsTableTableAdapter.UpdatePriceQuery(price, adID);
                updateFields();
            }
            else
            {
                MessageBox.Show("nope");
            }
        }
        #endregion

        #region Profile Panel Methods
        /// <summary>
        /// Event Handler for avatarUploadButton. Sets the user image in database.
        /// </summary>
        /// <param name="sender">avatarUploadButton</param>
        /// <param name="e">Click</param>
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
                        imgName = System.IO.Path.GetFileName(imgDialog.FileName);
                        // Set the new local path
                        imgNewPath = userImagesLocation + imgName;
                        // Copy file to images folder and update avatarPictureBox.
                        System.IO.File.Copy(imgDialog.FileName, imgNewPath);
                        // Update the image path in database.
                        this.usersTableAdapter1.UpdateUserImageQuery(imgName, userid);
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

        /// <summary>
        /// Event Handler for avatarRemoveButton. Deletes the database entry.
        /// </summary>
        /// <param name="sender">avatarRemoveButton</param>
        /// <param name="e">Click</param>
        private void avatarRemoveButton_Click(object sender, EventArgs e)
        {
            // Update the image path in database.
            this.usersTableAdapter1.UpdateUserImageQuery("", userid);
            avatarPictureBox.Image = UserApplication.Properties.Resources.userAvatar;
        }

        /// <summary>
        /// Event Handler for showpasswordCheckBox. Shows/hides the password in uPasswordTextBox.
        /// </summary>
        /// <param name="sender">showpasswordCheckBox</param>
        /// <param name="e">Click</param>
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

        /// <summary>
        /// Event Handler for saveButton. Checks and saves the user info to database. 
        /// </summary>
        /// <param name="sender">saveButton</param>
        /// <param name="e">Click</param>
        private void saveButton_Click(object sender, EventArgs e)
        {
            string uname, fname, lname, umail, upass;
            uname = uNameTextBox.Text;
            fname = fNameTextBox.Text;
            lname = lNameTextBox.Text;
            umail = uEmailTextBox.Text;
            upass = uPasswordTextBox.Text;

            if (uname != "" && fname != "" && lname != "" && umail != "" && upass != "")
            {
                try
                {
                    usersTableAdapter1.UpdateUserInfoQuery(fname, lname, uname, upass, umail, userid);
                    MessageBox.Show("Info Updated!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Info WAS NOT Updated");
                }
            }
        }
        #endregion

        #region Settings Panel Methods
        /// <summary>
        /// Event Handler for defaultRadioButton click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void defaultRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (defaultRadioButton.Checked)
            {
                topPanel.BackColor = SystemColors.ActiveBorder;
                footerPanel.BackColor = SystemColors.ActiveBorder;
                rightPanel.BackColor = SystemColors.ActiveBorder;
                fullBlueRadioButton.Checked = false;
                orangeRadioButton.Checked = false;
            }
        }
        /// <summary>
        /// Event Handler for fullBlueRadioButton click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fullBlueRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (fullBlueRadioButton.Checked)
            {
                topPanel.BackColor = SystemColors.ActiveCaption;
                footerPanel.BackColor = SystemColors.ActiveCaption;
                rightPanel.BackColor = SystemColors.ActiveCaption;
                defaultRadioButton.Checked = false;
                orangeRadioButton.Checked = false;
            }
        }
        /// <summary>
        /// Event Handler for orangeRadioButton click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void orangeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (orangeRadioButton.Checked)
            {
                topPanel.BackColor = Color.DarkOrange;
                footerPanel.BackColor = Color.DarkOrange;
                rightPanel.BackColor = Color.DarkOrange;
                defaultRadioButton.Checked = false;
                fullBlueRadioButton.Checked = false;
            }
        }
        /// <summary>
        /// Event Handler for normalRadioButton click. Call to fontFormating(Font font).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void normalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Font normalFont = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            fontFormating(normalFont);
        }
        /// <summary>
        /// Event Handler for largeRadioButton click. Call to fontFormating(Font font).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void largeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Font largeFont = new Font("Microsoft Sans Serif", 16, FontStyle.Regular);
            fontFormating(largeFont);
        }
        /// <summary>
        /// Gets all application controls as stack.
        /// </summary>
        /// <param name="aControl"></param>
        /// <returns></returns>
        public static IEnumerable<Control> GetAllControls(Control aControl)
        {
            Stack<Control> stack = new Stack<Control>();
            stack.Push(aControl);
            while (stack.Any())
            {
                var nextControl = stack.Pop();
                foreach (Control childControl in nextControl.Controls)
                {
                    stack.Push(childControl);
                }
                yield return nextControl;
            }
        }
        /// <summary>
        /// Updates the application fonts based on user selection.
        /// </summary>
        /// <param name="font"></param>
        public void fontFormating(Font font)
        {
            // Labels.
            foreach (Control theControl in (GetAllControls(this).OfType<Label>()))
            {
                theControl.Font = font;
            }
            // TextBox.
            foreach (Control theControl in (GetAllControls(this).OfType<TextBox>()))
            {
                if (theControl.Name != "titleTextBox")
                {
                    theControl.Font = font;
                }
            }
            // RichTextBox.
            foreach (Control theControl in (GetAllControls(this).OfType<RichTextBox>()))
            {
                theControl.Font = font;
            }
            // ListBox.
            foreach (Control theControl in (GetAllControls(this).OfType<ListBox>()))
            {
                theControl.Font = font;
            }
            // Button.
            foreach (Control theControl in (GetAllControls(this).OfType<Button>()))
            {
                theControl.Font = font;
            }
            // RadioButton.
            foreach (Control theControl in (GetAllControls(this).OfType<RadioButton>()))
            {
                theControl.Font = font;
            }
        }
        #endregion

        #region General Methods
        /// <summary>
        /// Form Load.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            adsListBox_SelectedIndexChanged(adsListBox, e);
            categoriesListBox_SelectedIndexChanged(categoriesListBox,e);
            updateFields();
        }

        /// <summary>
        /// Appication exit.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Populates the panel and control lists.
        /// </summary>
        private void controlsList()
        {
            panels.Add(homePanel); 
            panels.Add(settingsPanel); 
            panels.Add(adsPanel);
            panels.Add(categoriesPanel);
            panels.Add(profilePanel);

            panels[0].BringToFront();

            recentAdsList.Add(recentAds1);
            recentAdsList.Add(recentAds2);
            recentAdsList.Add(recentAds3);
        }

        /// <summary>
        /// Updates the profile panel with current user info.
        /// </summary>
        private void updateFields()
        {
            // Find current users Ads
            this.adsTableTableAdapter.AdsPerUser(this.aggeliesDBDataSet.AdsTable, userid);
            // Set images and userImages location.
            string str = AppDomain.CurrentDomain.BaseDirectory;
            str = str.Remove(str.Length - 16);
            str += @"UserApplication\Resources\images\";
            imagesLocation = str;
            str = AppDomain.CurrentDomain.BaseDirectory;
            str = str.Remove(str.Length - 16);
            str += @"UserApplication\Resources\userImages\";
            userImagesLocation = str;
            // Set the avatarPictureBox image location.
            try
            {
                avatarPictureBox.ImageLocation = userImagesLocation + usersTableAdapter1.SelectUserImageQuery(userid).ToString();
            }
            catch (Exception) { }
            // Set textboxes according to user info.
            uNameTextBox.Text = usersTableAdapter1.SelectUsernameQuery(userid).ToString();
            fNameTextBox.Text = usersTableAdapter1.SelectFirstNameQuery(userid).ToString();
            lNameTextBox.Text = usersTableAdapter1.SelectLastNameQuery(userid).ToString();
            uEmailTextBox.Text = usersTableAdapter1.SelectUserEmailQuery(userid).ToString();
            uPasswordTextBox.Text = usersTableAdapter1.SelectUserPasswordQuery(userid).ToString();
        }
        #endregion

        #endregion
    }
}
