namespace UserApplication
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.topPanel = new System.Windows.Forms.Panel();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.userMenuIcons2 = new aggeliesWpfLab.UserMenuIcons();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.homePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.page6Panel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.profilePanel = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.lNameLabel = new System.Windows.Forms.Label();
            this.lNameTextBox = new System.Windows.Forms.TextBox();
            this.showpasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.avatarRemoveButton = new System.Windows.Forms.Button();
            this.fNameLabel = new System.Windows.Forms.Label();
            this.fNameTextBox = new System.Windows.Forms.TextBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aggeliesDBDataSet = new UserApplication.AggeliesDBDataSet();
            this.uEmailLabel = new System.Windows.Forms.Label();
            this.uEmailTextBox = new System.Windows.Forms.TextBox();
            this.uPasswordLabel = new System.Windows.Forms.Label();
            this.uPasswordTextBox = new System.Windows.Forms.TextBox();
            this.uNameLabel = new System.Windows.Forms.Label();
            this.uNameTextBox = new System.Windows.Forms.TextBox();
            this.avatarUploadButton = new System.Windows.Forms.Button();
            this.avatarPictureBox = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.page4Panel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.adsPanel = new System.Windows.Forms.Panel();
            this.editPicturePictureBox = new System.Windows.Forms.PictureBox();
            this.adsListPanel = new System.Windows.Forms.Panel();
            this.adsListBox = new System.Windows.Forms.ListBox();
            this.adsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infoLabel = new System.Windows.Forms.Label();
            this.editDescriptionPictureBox = new System.Windows.Forms.PictureBox();
            this.editTitlePictureBox = new System.Windows.Forms.PictureBox();
            this.recentAdPanel = new System.Windows.Forms.Panel();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.adsPictureBox = new System.Windows.Forms.PictureBox();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.adsTableTableAdapter = new UserApplication.AggeliesDBDataSetTableAdapters.AdsTableTableAdapter();
            this.usersTableAdapter1 = new UserApplication.AggeliesDBDataSetTableAdapters.UsersTableAdapter();
            this.rightPanel.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.homePanel.SuspendLayout();
            this.page6Panel.SuspendLayout();
            this.profilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aggeliesDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).BeginInit();
            this.page4Panel.SuspendLayout();
            this.adsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editPicturePictureBox)).BeginInit();
            this.adsListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editDescriptionPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editTitlePictureBox)).BeginInit();
            this.recentAdPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adsPictureBox)).BeginInit();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1062, 108);
            this.topPanel.TabIndex = 0;
            // 
            // footerPanel
            // 
            this.footerPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(0, 590);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(1062, 100);
            this.footerPanel.TabIndex = 1;
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rightPanel.Controls.Add(this.elementHost1);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(1062, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(160, 690);
            this.rightPanel.TabIndex = 2;
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(0, 101);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(160, 489);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.userMenuIcons2;
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.label2);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsPanel.Location = new System.Drawing.Point(0, 0);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(1062, 482);
            this.settingsPanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 72);
            this.label2.TabIndex = 1;
            this.label2.Text = "settings";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // homePanel
            // 
            this.homePanel.Controls.Add(this.label1);
            this.homePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homePanel.Location = new System.Drawing.Point(0, 0);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(1062, 482);
            this.homePanel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "homepage";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // page6Panel
            // 
            this.page6Panel.Controls.Add(this.label6);
            this.page6Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page6Panel.Location = new System.Drawing.Point(0, 0);
            this.page6Panel.Name = "page6Panel";
            this.page6Panel.Size = new System.Drawing.Size(1062, 482);
            this.page6Panel.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 72);
            this.label6.TabIndex = 1;
            this.label6.Text = "page 6";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profilePanel
            // 
            this.profilePanel.Controls.Add(this.saveButton);
            this.profilePanel.Controls.Add(this.lNameLabel);
            this.profilePanel.Controls.Add(this.lNameTextBox);
            this.profilePanel.Controls.Add(this.showpasswordCheckBox);
            this.profilePanel.Controls.Add(this.avatarRemoveButton);
            this.profilePanel.Controls.Add(this.fNameLabel);
            this.profilePanel.Controls.Add(this.fNameTextBox);
            this.profilePanel.Controls.Add(this.uEmailLabel);
            this.profilePanel.Controls.Add(this.uEmailTextBox);
            this.profilePanel.Controls.Add(this.uPasswordLabel);
            this.profilePanel.Controls.Add(this.uPasswordTextBox);
            this.profilePanel.Controls.Add(this.uNameLabel);
            this.profilePanel.Controls.Add(this.uNameTextBox);
            this.profilePanel.Controls.Add(this.avatarUploadButton);
            this.profilePanel.Controls.Add(this.avatarPictureBox);
            this.profilePanel.Controls.Add(this.label5);
            this.profilePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profilePanel.Location = new System.Drawing.Point(0, 0);
            this.profilePanel.Name = "profilePanel";
            this.profilePanel.Size = new System.Drawing.Size(1062, 482);
            this.profilePanel.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(623, 298);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(149, 45);
            this.saveButton.TabIndex = 63;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // lNameLabel
            // 
            this.lNameLabel.AutoSize = true;
            this.lNameLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameLabel.Location = new System.Drawing.Point(370, 132);
            this.lNameLabel.Name = "lNameLabel";
            this.lNameLabel.Size = new System.Drawing.Size(105, 26);
            this.lNameLabel.TabIndex = 62;
            this.lNameLabel.Text = "Last Name";
            // 
            // lNameTextBox
            // 
            this.lNameTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameTextBox.Location = new System.Drawing.Point(481, 128);
            this.lNameTextBox.Name = "lNameTextBox";
            this.lNameTextBox.Size = new System.Drawing.Size(291, 29);
            this.lNameTextBox.TabIndex = 61;
            // 
            // showpasswordCheckBox
            // 
            this.showpasswordCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showpasswordCheckBox.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showpasswordCheckBox.Location = new System.Drawing.Point(778, 206);
            this.showpasswordCheckBox.Name = "showpasswordCheckBox";
            this.showpasswordCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.showpasswordCheckBox.Size = new System.Drawing.Size(70, 29);
            this.showpasswordCheckBox.TabIndex = 60;
            this.showpasswordCheckBox.Text = "show";
            this.showpasswordCheckBox.UseVisualStyleBackColor = true;
            this.showpasswordCheckBox.CheckedChanged += new System.EventHandler(this.showpasswordCheckBox_CheckedChanged);
            // 
            // avatarRemoveButton
            // 
            this.avatarRemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.avatarRemoveButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avatarRemoveButton.Location = new System.Drawing.Point(149, 298);
            this.avatarRemoveButton.Name = "avatarRemoveButton";
            this.avatarRemoveButton.Size = new System.Drawing.Size(149, 45);
            this.avatarRemoveButton.TabIndex = 59;
            this.avatarRemoveButton.Text = "Remove";
            this.avatarRemoveButton.UseVisualStyleBackColor = true;
            this.avatarRemoveButton.Click += new System.EventHandler(this.avatarRemoveButton_Click);
            // 
            // fNameLabel
            // 
            this.fNameLabel.AutoSize = true;
            this.fNameLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameLabel.Location = new System.Drawing.Point(370, 95);
            this.fNameLabel.Name = "fNameLabel";
            this.fNameLabel.Size = new System.Drawing.Size(110, 26);
            this.fNameLabel.TabIndex = 56;
            this.fNameLabel.Text = "First Name";
            // 
            // fNameTextBox
            // 
            this.fNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "fName", true));
            this.fNameTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameTextBox.Location = new System.Drawing.Point(481, 91);
            this.fNameTextBox.Name = "fNameTextBox";
            this.fNameTextBox.Size = new System.Drawing.Size(291, 29);
            this.fNameTextBox.TabIndex = 55;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.aggeliesDBDataSet;
            // 
            // aggeliesDBDataSet
            // 
            this.aggeliesDBDataSet.DataSetName = "AggeliesDBDataSet";
            this.aggeliesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uEmailLabel
            // 
            this.uEmailLabel.AutoSize = true;
            this.uEmailLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uEmailLabel.Location = new System.Drawing.Point(370, 250);
            this.uEmailLabel.Name = "uEmailLabel";
            this.uEmailLabel.Size = new System.Drawing.Size(58, 26);
            this.uEmailLabel.TabIndex = 54;
            this.uEmailLabel.Text = "Email";
            // 
            // uEmailTextBox
            // 
            this.uEmailTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uEmailTextBox.Location = new System.Drawing.Point(481, 246);
            this.uEmailTextBox.Name = "uEmailTextBox";
            this.uEmailTextBox.Size = new System.Drawing.Size(291, 29);
            this.uEmailTextBox.TabIndex = 53;
            // 
            // uPasswordLabel
            // 
            this.uPasswordLabel.AutoSize = true;
            this.uPasswordLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uPasswordLabel.Location = new System.Drawing.Point(370, 210);
            this.uPasswordLabel.Name = "uPasswordLabel";
            this.uPasswordLabel.Size = new System.Drawing.Size(94, 26);
            this.uPasswordLabel.TabIndex = 52;
            this.uPasswordLabel.Text = "Password";
            // 
            // uPasswordTextBox
            // 
            this.uPasswordTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uPasswordTextBox.Location = new System.Drawing.Point(481, 206);
            this.uPasswordTextBox.Name = "uPasswordTextBox";
            this.uPasswordTextBox.PasswordChar = '*';
            this.uPasswordTextBox.Size = new System.Drawing.Size(291, 29);
            this.uPasswordTextBox.TabIndex = 51;
            // 
            // uNameLabel
            // 
            this.uNameLabel.AutoSize = true;
            this.uNameLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uNameLabel.Location = new System.Drawing.Point(370, 170);
            this.uNameLabel.Name = "uNameLabel";
            this.uNameLabel.Size = new System.Drawing.Size(99, 26);
            this.uNameLabel.TabIndex = 50;
            this.uNameLabel.Text = "Username";
            // 
            // uNameTextBox
            // 
            this.uNameTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uNameTextBox.Location = new System.Drawing.Point(481, 166);
            this.uNameTextBox.Name = "uNameTextBox";
            this.uNameTextBox.Size = new System.Drawing.Size(291, 29);
            this.uNameTextBox.TabIndex = 49;
            // 
            // avatarUploadButton
            // 
            this.avatarUploadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.avatarUploadButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avatarUploadButton.Location = new System.Drawing.Point(148, 247);
            this.avatarUploadButton.Name = "avatarUploadButton";
            this.avatarUploadButton.Size = new System.Drawing.Size(149, 45);
            this.avatarUploadButton.TabIndex = 48;
            this.avatarUploadButton.Text = "Change";
            this.avatarUploadButton.UseVisualStyleBackColor = true;
            this.avatarUploadButton.Click += new System.EventHandler(this.avatarUploadButton_Click);
            // 
            // avatarPictureBox
            // 
            this.avatarPictureBox.Image = global::UserApplication.Properties.Resources.userAvatar;
            this.avatarPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("avatarPictureBox.InitialImage")));
            this.avatarPictureBox.Location = new System.Drawing.Point(148, 91);
            this.avatarPictureBox.Name = "avatarPictureBox";
            this.avatarPictureBox.Size = new System.Drawing.Size(150, 150);
            this.avatarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatarPictureBox.TabIndex = 47;
            this.avatarPictureBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 72);
            this.label5.TabIndex = 1;
            this.label5.Text = "profile";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // page4Panel
            // 
            this.page4Panel.Controls.Add(this.label4);
            this.page4Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page4Panel.Location = new System.Drawing.Point(0, 0);
            this.page4Panel.Name = "page4Panel";
            this.page4Panel.Size = new System.Drawing.Size(1062, 482);
            this.page4Panel.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 72);
            this.label4.TabIndex = 1;
            this.label4.Text = "page 4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adsPanel
            // 
            this.adsPanel.Controls.Add(this.editPicturePictureBox);
            this.adsPanel.Controls.Add(this.adsListPanel);
            this.adsPanel.Controls.Add(this.editDescriptionPictureBox);
            this.adsPanel.Controls.Add(this.editTitlePictureBox);
            this.adsPanel.Controls.Add(this.recentAdPanel);
            this.adsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adsPanel.Location = new System.Drawing.Point(0, 0);
            this.adsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.adsPanel.Name = "adsPanel";
            this.adsPanel.Size = new System.Drawing.Size(1062, 482);
            this.adsPanel.TabIndex = 2;
            // 
            // editPicturePictureBox
            // 
            this.editPicturePictureBox.Image = global::UserApplication.Properties.Resources.edit1;
            this.editPicturePictureBox.Location = new System.Drawing.Point(286, 36);
            this.editPicturePictureBox.Name = "editPicturePictureBox";
            this.editPicturePictureBox.Size = new System.Drawing.Size(30, 30);
            this.editPicturePictureBox.TabIndex = 6;
            this.editPicturePictureBox.TabStop = false;
            this.editPicturePictureBox.Click += new System.EventHandler(this.editPicturePictureBox_Click);
            // 
            // adsListPanel
            // 
            this.adsListPanel.Controls.Add(this.adsListBox);
            this.adsListPanel.Controls.Add(this.infoLabel);
            this.adsListPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.adsListPanel.Location = new System.Drawing.Point(862, 0);
            this.adsListPanel.Margin = new System.Windows.Forms.Padding(0);
            this.adsListPanel.Name = "adsListPanel";
            this.adsListPanel.Size = new System.Drawing.Size(200, 482);
            this.adsListPanel.TabIndex = 5;
            // 
            // adsListBox
            // 
            this.adsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.adsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adsListBox.DataSource = this.adsTableBindingSource;
            this.adsListBox.DisplayMember = "adTitle";
            this.adsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adsListBox.FormattingEnabled = true;
            this.adsListBox.ItemHeight = 20;
            this.adsListBox.Location = new System.Drawing.Point(0, 42);
            this.adsListBox.Margin = new System.Windows.Forms.Padding(0);
            this.adsListBox.Name = "adsListBox";
            this.adsListBox.Size = new System.Drawing.Size(200, 440);
            this.adsListBox.TabIndex = 3;
            this.adsListBox.ValueMember = "adID";
            this.adsListBox.SelectedIndexChanged += new System.EventHandler(this.adsListBox_SelectedIndexChanged);
            // 
            // adsTableBindingSource
            // 
            this.adsTableBindingSource.DataMember = "AdsTable";
            this.adsTableBindingSource.DataSource = this.aggeliesDBDataSet;
            // 
            // infoLabel
            // 
            this.infoLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(0, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(200, 41);
            this.infoLabel.TabIndex = 2;
            this.infoLabel.Text = "My Ads";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editDescriptionPictureBox
            // 
            this.editDescriptionPictureBox.Image = global::UserApplication.Properties.Resources.edit1;
            this.editDescriptionPictureBox.Location = new System.Drawing.Point(286, 284);
            this.editDescriptionPictureBox.Name = "editDescriptionPictureBox";
            this.editDescriptionPictureBox.Size = new System.Drawing.Size(30, 30);
            this.editDescriptionPictureBox.TabIndex = 4;
            this.editDescriptionPictureBox.TabStop = false;
            this.editDescriptionPictureBox.Click += new System.EventHandler(this.descriptionEditPictureBox_Click);
            // 
            // editTitlePictureBox
            // 
            this.editTitlePictureBox.Image = global::UserApplication.Properties.Resources.edit1;
            this.editTitlePictureBox.Location = new System.Drawing.Point(286, 0);
            this.editTitlePictureBox.Name = "editTitlePictureBox";
            this.editTitlePictureBox.Size = new System.Drawing.Size(30, 30);
            this.editTitlePictureBox.TabIndex = 3;
            this.editTitlePictureBox.TabStop = false;
            this.editTitlePictureBox.Click += new System.EventHandler(this.titleEditPictureBox_Click);
            // 
            // recentAdPanel
            // 
            this.recentAdPanel.Controls.Add(this.titleTextBox);
            this.recentAdPanel.Controls.Add(this.descriptionRichTextBox);
            this.recentAdPanel.Controls.Add(this.adsPictureBox);
            this.recentAdPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.recentAdPanel.Location = new System.Drawing.Point(0, 0);
            this.recentAdPanel.Name = "recentAdPanel";
            this.recentAdPanel.Size = new System.Drawing.Size(278, 482);
            this.recentAdPanel.TabIndex = 2;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleTextBox.Enabled = false;
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.Location = new System.Drawing.Point(0, 0);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(278, 29);
            this.titleTextBox.TabIndex = 5;
            this.titleTextBox.Text = "TITLE";
            this.titleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.descriptionRichTextBox.Enabled = false;
            this.descriptionRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionRichTextBox.Location = new System.Drawing.Point(0, 282);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.descriptionRichTextBox.Size = new System.Drawing.Size(278, 200);
            this.descriptionRichTextBox.TabIndex = 4;
            this.descriptionRichTextBox.Text = "Το ακίνητο βρίσκεται στην Αθήνα και μπλα μπλα μπλα....................\n.........." +
    ".....................\n................................\n........................." +
    "........";
            // 
            // adsPictureBox
            // 
            this.adsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("adsPictureBox.Image")));
            this.adsPictureBox.Location = new System.Drawing.Point(0, 30);
            this.adsPictureBox.Name = "adsPictureBox";
            this.adsPictureBox.Size = new System.Drawing.Size(278, 246);
            this.adsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.adsPictureBox.TabIndex = 3;
            this.adsPictureBox.TabStop = false;
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.profilePanel);
            this.contentPanel.Controls.Add(this.page6Panel);
            this.contentPanel.Controls.Add(this.homePanel);
            this.contentPanel.Controls.Add(this.settingsPanel);
            this.contentPanel.Controls.Add(this.adsPanel);
            this.contentPanel.Controls.Add(this.page4Panel);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 108);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1062, 482);
            this.contentPanel.TabIndex = 5;
            // 
            // adsTableTableAdapter
            // 
            this.adsTableTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 690);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.rightPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.rightPanel.ResumeLayout(false);
            this.settingsPanel.ResumeLayout(false);
            this.homePanel.ResumeLayout(false);
            this.page6Panel.ResumeLayout(false);
            this.profilePanel.ResumeLayout(false);
            this.profilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aggeliesDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).EndInit();
            this.page4Panel.ResumeLayout(false);
            this.adsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editPicturePictureBox)).EndInit();
            this.adsListPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editDescriptionPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editTitlePictureBox)).EndInit();
            this.recentAdPanel.ResumeLayout(false);
            this.recentAdPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adsPictureBox)).EndInit();
            this.contentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel page6Panel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel profilePanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel page4Panel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel adsPanel;
        private System.Windows.Forms.Panel adsListPanel;
        private System.Windows.Forms.ListBox adsListBox;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.PictureBox editDescriptionPictureBox;
        private System.Windows.Forms.PictureBox editTitlePictureBox;
        private System.Windows.Forms.Panel recentAdPanel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.PictureBox adsPictureBox;
        private System.Windows.Forms.Panel contentPanel;
        private UserApplication.AggeliesDBDataSet aggeliesDBDataSet;
        private System.Windows.Forms.BindingSource adsTableBindingSource;
        private UserApplication.AggeliesDBDataSetTableAdapters.AdsTableTableAdapter adsTableTableAdapter;
        private System.Windows.Forms.PictureBox editPicturePictureBox;
        private System.Windows.Forms.CheckBox showpasswordCheckBox;
        private System.Windows.Forms.Button avatarRemoveButton;
        private System.Windows.Forms.Label fNameLabel;
        private System.Windows.Forms.TextBox fNameTextBox;
        private System.Windows.Forms.Label uEmailLabel;
        private System.Windows.Forms.TextBox uEmailTextBox;
        private System.Windows.Forms.Label uPasswordLabel;
        private System.Windows.Forms.TextBox uPasswordTextBox;
        private System.Windows.Forms.Label uNameLabel;
        private System.Windows.Forms.TextBox uNameTextBox;
        private System.Windows.Forms.Button avatarUploadButton;
        private System.Windows.Forms.PictureBox avatarPictureBox;
        private AggeliesDBDataSetTableAdapters.UsersTableAdapter usersTableAdapter1;
        private System.Windows.Forms.Label lNameLabel;
        private System.Windows.Forms.TextBox lNameTextBox;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private aggeliesWpfLab.UserMenuIcons userMenuIcons1;
        private System.Windows.Forms.Button saveButton;
        private aggeliesWpfLab.UserMenuIcons userMenuIcons2;
    }
}

