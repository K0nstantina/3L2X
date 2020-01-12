using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace UserApplication
{
    public partial class UserForm : Form
    {
        #region Variables
        List<Panel> panels = new List<Panel>();
        List<DisplayAds> recentAdsList = new List<DisplayAds>();
        ListBox recentAdsListBox = new ListBox();
        DataRowView view;
        BindingSource bs = new BindingSource();
        int userid;
        string connectionString = Properties.Settings.Default.AggeliesDBConnectionString;
        private string imgName, imgNewPath, imagesLocation, userImagesLocation;
        #endregion

        #region Constructors
        public UserForm()
        {
            this.Hide();
            UserApplication.trestingTreeView treeView = new trestingTreeView();
            treeView.Show();

        }
        public UserForm(int userID)
        {
            InitializeComponent();
            
            userid = userID;
            setImagesPath();
            // Add controls to list.
            controlsList();
            // Display recent ads.
            recentAds();
            // Set categories to default filters.
            initializeView();
            setWPFControl(userID);

            if (userid!=9999)
            {
                // Initialize profile fields (profile panel).
                updateFields();
                userAdsDataGrid.CurrentCell = userAdsDataGrid.Rows[0].Cells[0];
            }

        }
        #endregion

        #region Navigation
        private void HomeButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            panels[0].BringToFront();
            
            recentAds();
        }
        private void CatBut_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            initializeView();
            panels[1].BringToFront();
        }
        private void AdsBut_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            signupPrompt(2);
        }
        private void ProfileBut_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            signupPrompt(3);
        }
        private void SettingBut_Click(object sender, System.Windows.RoutedEventArgs e)
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
            this.Controls.Add(recentAdsListBox);
            recentAdsListBox.ValueMember = "adTitle";
            recentAdsListBox.SelectedIndex = 0;

            for (int i = 0; i < recentAdsList.Count; i++)
            {
                view = recentAdsListBox.Items[i] as DataRowView;
                recentAdsList[i].titleTextBox.Text = view["adTitle"].ToString();
                recentAdsList[i].descTextBox.Text = view["adDesc"].ToString();
                recentAdsList[i].mediaPictureBox.ImageLocation = imagesLocation + view["Images"].ToString();
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
                //displayAd.titleTextBox.Text = view["adTitle"].ToString();
                //displayAd.descTextBox.Text = view["adDesc"].ToString();
                //displayAd.mediaPictureBox.ImageLocation = imagesLocation + view["media"].ToString();
            }

        }

        /// <summary>
        /// Updates the displayed ad.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateCategoriesListBox(ComboBox cb)
        {
            //displayAd.Visible = true;
            view = cb.SelectedItem as DataRowView;
            int category = Int32.Parse(view["catID"].ToString());
            // Filter ads by category ID.
            bs.DataSource = adsTableTableAdapter.GetDTFilterAds(category);
            categoriesListBox.DataSource = bs;
            categoriesListBox.DisplayMember = "adTitle";
            categoriesListBox.ValueMember = "adID";

            view = categoriesListBox.SelectedItem as DataRowView;
            //displayAd.titleTextBox.Text = view["adTitle"].ToString();
            //displayAd.descTextBox.Text = view["adDesc"].ToString();
            //displayAd.mediaPictureBox.ImageLocation = imagesLocation + view["media"].ToString();
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
            //if (titleTextBox.Enabled == false)
            //{
            //    titleTextBox.Enabled = true;
            //    editTitlePictureBox.Image = UserApplication.Properties.Resources.save1;
            //}
            //else
            //{
            //    titleTextBox.Enabled = false;
            //    editTitlePictureBox.Image = UserApplication.Properties.Resources.edit1;
            //    updateTitleDesc();
            //}
        }

        /// <summary>
        /// Enables editing the descriptionRichTextBox.
        /// Changes editDescriptionPictureBox image accordingly.
        /// </summary>
        /// <param name="sender">editTitlePictureBox</param>
        /// <param name="e">Click</param>
        private void descriptionEditPictureBox_Click(object sender, EventArgs e)
        {
            //if (descriptionRichTextBox.Enabled == false)
            //{
            //    descriptionRichTextBox.Enabled = true;
            //    editDescriptionPictureBox.Image = UserApplication.Properties.Resources.save1;
            //}
            //else
            //{
            //    descriptionRichTextBox.Enabled = false;
            //    editDescriptionPictureBox.Image = UserApplication.Properties.Resources.edit1;
            //    updateTitleDesc();
            //}
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
                        // view = adsListBox.SelectedItem as DataRowView;
                       // int adID = Int32.Parse();
                        // Update the image path in database.
                      //  this.adsTableTableAdapter.UpdateImageQuery(imgName, adID);
                        // Set adsPicturebox new image.
                        Console.WriteLine(imgNewPath);
                        displayAd1.GetadImage.Source = new BitmapImage(new Uri(imgNewPath));
                       
                        // Update DataRowView dynamicaly.
                        //view.BeginEdit();
                        //view["media"] = imgName;
                        //view.EndEdit();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occured" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Update the price to database
        /// </summary>
        /// <param name="sender">savePriceButton</param>
        /// <param name="e">Click</param>
        private void savePriceButton_Click(object sender, EventArgs e)
        {
            
            //int price;
            //bool result = Int32.TryParse(priceTextBox.Text, out price);
            //if (result)
            //{
            //    // Get current adID.
            //    view = adsListBox.SelectedItem as DataRowView;
            //    int adID = Int32.Parse(view["adID"].ToString());
            //    adsTableTableAdapter.UpdatePriceQuery(price, adID);
            //    updateFields();
            //}
            //else
            //{
            //    MessageBox.Show("nope");
            //}
        }
        /// <summary>
        /// Event Handler fot publishButton Click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void publishButton_Click(object sender, EventArgs e)
        {
           
            //view = adsListBox.SelectedItem as DataRowView;
            //int adid = Int32.Parse(view["adID"].ToString());
            //string publishQuery;
            //// Setup Query.
            //if (view["Published"].ToString() == "True")
            //{
            //    publishQuery = "UPDATE AdsTable SET Published=No WHERE adID=" + adid + "";
            //}
            //else
            //{
            //    publishQuery = "UPDATE AdsTable SET Published=Yes WHERE adID=" + adid + "";
            //}
            //// Open connection.
            //OleDbConnection connection = new OleDbConnection(connectionString);
            //OleDbCommand command = new OleDbCommand(publishQuery, connection);

            //connection.Open();
            //command.ExecuteNonQuery();
            //connection.Close();
            //updateFields();




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
            string uname, fname, lname, umail, upass,  urmail, uage, uphone;
            uname = uNameTextBox.Text;
            fname = fNameTextBox.Text;
            lname = lNameTextBox.Text;
            umail = uEmailTextBox.Text;
            upass = uPasswordTextBox.Text;
            urmail = uREmailTextBox.Text;
            uage = uAgeTextBox.Text;
            uphone = uPhoneTextBox.Text;

            if (uname != "" && fname != "" && lname != "" && umail != "" && upass != "" && urmail != "" && uage!= "" && uphone != "")
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
                topPanel.BackColor = Color.FromArgb(57, 178, 250);
                footerPanel.BackColor = Color.FromArgb(57, 178, 250);
                rightPanel.BackColor = Color.FromArgb(57, 178, 250);
                leftPanel.BackColor = Color.FromArgb(57, 178, 250);
                darkRadioButton.Checked = false;
                orangeRadioButton.Checked = false;
            }
        }
        /// <summary>
        /// Event Handler for darkRadioButton click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void darkRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (darkRadioButton.Checked)
            {
                topPanel.BackColor = SystemColors.ActiveBorder;
                footerPanel.BackColor = SystemColors.ActiveBorder;
                rightPanel.BackColor = SystemColors.ActiveBorder;
                leftPanel.BackColor = SystemColors.ActiveBorder;
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
                leftPanel.BackColor = Color.DarkOrange;
                defaultRadioButton.Checked = false;
                darkRadioButton.Checked = false;
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
            // Combobox.
            foreach (Control theControl in (GetAllControls(this).OfType<ComboBox>()))
            {
                theControl.Font = font;
            }
        }
        #endregion

        #region Signup Panel Methods
        /// <summary>
        /// Event Handler for signupButton Click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void signupSaveButton_Click(object sender, EventArgs e)
        {
            //
            string fName, lName, uName, uPassword, uEmail, uRecoverEmail;
            int uCat, uAge, uPhone;

            fName = signupFNameTextBox.Text;
            lName = signupLNameTextBox.Text;
            uName = signupUNameTextBox.Text;
            uPassword = signupPasswordTextBox.Text;
            uEmail = signupEmailTextBox.Text;
            uRecoverEmail = signupREmailTextBox.Text;
            uCat = 2;
            uAge = Int32.Parse(signupAgeTextBox.Text);
            uPhone = Int32.Parse(signupPhoneTextBox.Text);

            this.usersTableAdapter1.UserSignupQuery(fName,lName,uName,uPassword,uEmail,uCat,uAge,uRecoverEmail,uPhone);
            MessageBox.Show("user created! try login!");
            LogoutBut_Click(sender, new System.Windows.RoutedEventArgs());
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
            setConnectionString();
            // Initialize the lists.
            //adsListBox_SelectedIndexChanged(adsListBox, e);
            categoriesListBox_SelectedIndexChanged(categoriesListBox,e);
           
            this.adsTableTableAdapter.AdsPerUser(this.aggeliesDBDataSet.AdsTable, userid);
            
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
            panels.Add(categoriesPanel); 
            panels.Add(adsPanel);
            panels.Add(profilePanel);
            panels.Add(settingsPanel);
            panels.Add(signupPanel);
            
            panels[0].BringToFront();


        }

        /// <summary>
        /// Updates the profile panel with current user info.
        /// Also updates the users Ads.
        /// </summary>
        private void updateFields()
        {
            //int sIndex = adsListBox.SelectedIndex;
            // Find current users Ads
            this.adsTableTableAdapter.AdsPerUser(this.aggeliesDBDataSet.AdsTable, userid);
            //adsListBox.SelectedIndex = sIndex;
            // Set the avatarPictureBox image location.
            try
            {
                avatarPictureBox.ImageLocation = userImagesLocation + usersTableAdapter1.SelectUserImageQuery(userid).ToString();
            }
            catch (Exception) { }

            // Setup Query, declare reader.
            string unameQuery = "SELECT uName, uPassword, fName, lName, uAge, uPhone, uEmail, uRecoverEmail FROM Users WHERE userID=" + userid + "";
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
                reader.Read();
                uNameTextBox.Text = reader["uName"].ToString();
                fNameTextBox.Text = reader["fName"].ToString();
                lNameTextBox.Text = reader["lName"].ToString();
                uEmailTextBox.Text = reader["uEmail"].ToString();
                uREmailTextBox.Text = reader["uRecoverEmail"].ToString();
                uAgeTextBox.Text = reader["uAge"].ToString();
                uPhoneTextBox.Text = reader["uPhone"].ToString();
                uPasswordTextBox.Text = reader["uPassword"].ToString();
                reader.Close();
            }
            connection.Close();
        }
        /// <summary>
        /// Initialize the images relative path.
        /// </summary>
        private void setImagesPath()
        {
            // Set images and userImages location.
            string str = AppDomain.CurrentDomain.BaseDirectory;
            str = str.Remove(str.Length - 16);
            str += @"UserApplication\Resources\images\";
            imagesLocation = str;
            str = AppDomain.CurrentDomain.BaseDirectory;
            str = str.Remove(str.Length - 16);
            str += @"UserApplication\Resources\userImages\";
            userImagesLocation = str;
        }


        private void myAdsLabel_Click(object sender, EventArgs e)
        {
            signupPrompt(2);
        }

        private void profileLabel_Click(object sender, EventArgs e)
        {
            signupPrompt(3);
        }

        private void goBackImage_Click(object sender, EventArgs e)
        {
            signupPrompt(3);
        }

      



       

     

        private void btn_silver_Click(object sender, EventArgs e)
        {
            this.silver_panel.Visible = true;
            this.silver_panel.BringToFront();
        }

        private void btn_gold_Click(object sender, EventArgs e)
        {
            this.gold_panel.Visible = true;
            this.gold_panel.BringToFront();
        }

        private void gold_btn_goback_Click(object sender, EventArgs e)
        {
            this.upgradeAccount_panel.Visible = true;
            this.upgradeAccount_panel.BringToFront();
        }

        private void silver_btn_goback_Click(object sender, EventArgs e)
        {
            this.upgradeAccount_panel.Visible = true;
            this.upgradeAccount_panel.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.profilePanel.Visible = true;
            this.profilePanel.BringToFront();
        }

        private void userAdsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = userAdsDataGrid.Rows[index];
            displayAd1.GetadTitle.Text = selectedRow.Cells["adTitle"].Value.ToString();
            displayAd1.GetadDesc.Text = selectedRow.Cells["adDesc"].Value.ToString();
         displayAd1.GetadImage.Source = new BitmapImage(new Uri(imagesLocation + selectedRow.Cells["images"].Value.ToString()));


        }

      




        /// <summary>
        /// Initialize the WPF custom control used as navigation menu.
        /// </summary>
        /// <param name="uid"></param>
        private void setWPFControl(int uid)
        {
            // Add WPF control to host and set the event handlers.
            var userMenu = new aggeliesWpfLab.UserMenuIcons();
            elementHost1.Child = userMenu;
            elementHost1.Select();
            userMenu.homeButton.Click += HomeButton_Click;
            userMenu.categoriesButton.Click += CatBut_Click;
            userMenu.logoutButton.Click += LogoutBut_Click;
            userMenu.settingsButton.Click += SettingBut_Click;
            userMenu.profileButton.Click += ProfileBut_Click;
        }
        /// <summary>
        /// Message to prompt user to signup.
        /// </summary>
        /// <param name="panel"></param>
        private void signupPrompt(int panel)
        {
            if (userid != 9999)
            {
                panels[panel].BringToFront();
            }
            else
            {
                if (MessageBox.Show("You need to register ! \nSign up now ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    panels[5].BringToFront();
                }
            }
        }
        private void setConnectionString()
        {
            string DebugDir = Application.StartupPath;
            string BidDir = Directory.GetParent(DebugDir).FullName;
            string ProjectDir = Directory.GetParent(BidDir).FullName;
            string SolutionDir = Directory.GetParent(ProjectDir).FullName;
            string str = SolutionDir + @"\AppData\AggeliesDB.accdb";
            Console.WriteLine(str);
            connectionString = "Provider=Microft.ACE.OLEDB.12.0;Data Source=" + str;
        }
        #endregion

        #endregion
    }
}