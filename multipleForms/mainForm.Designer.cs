namespace multipleForms
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.welcomeMsgLabel = new System.Windows.Forms.Label();
            this.exitPictureBox = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.userTabControl = new System.Windows.Forms.TabControl();
            this.accountTab = new System.Windows.Forms.TabPage();
            this.saveButton = new System.Windows.Forms.Button();
            this.avatarRemoveButton = new System.Windows.Forms.Button();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.avatarUploadButton = new System.Windows.Forms.Button();
            this.avatarPictureBox = new System.Windows.Forms.PictureBox();
            this.adsTab = new System.Windows.Forms.TabPage();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.showpasswordCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).BeginInit();
            this.bottomPanel.SuspendLayout();
            this.userTabControl.SuspendLayout();
            this.accountTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeMsgLabel
            // 
            this.welcomeMsgLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeMsgLabel.ForeColor = System.Drawing.Color.Blue;
            this.welcomeMsgLabel.Location = new System.Drawing.Point(3, 3);
            this.welcomeMsgLabel.Name = "welcomeMsgLabel";
            this.welcomeMsgLabel.Size = new System.Drawing.Size(189, 35);
            this.welcomeMsgLabel.TabIndex = 0;
            this.welcomeMsgLabel.Text = "Welcome ";
            // 
            // exitPictureBox
            // 
            this.exitPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("exitPictureBox.Image")));
            this.exitPictureBox.Location = new System.Drawing.Point(734, 11);
            this.exitPictureBox.Name = "exitPictureBox";
            this.exitPictureBox.Size = new System.Drawing.Size(37, 35);
            this.exitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitPictureBox.TabIndex = 7;
            this.exitPictureBox.TabStop = false;
            this.exitPictureBox.Click += new System.EventHandler(this.exitPictureBox_Click);
            // 
            // backButton
            // 
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(573, 3);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(146, 45);
            this.backButton.TabIndex = 14;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.exitPictureBox);
            this.bottomPanel.Controls.Add(this.backButton);
            this.bottomPanel.Controls.Add(this.welcomeMsgLabel);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bottomPanel.Location = new System.Drawing.Point(0, 0);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(782, 93);
            this.bottomPanel.TabIndex = 16;
            this.bottomPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // userTabControl
            // 
            this.userTabControl.Controls.Add(this.accountTab);
            this.userTabControl.Controls.Add(this.adsTab);
            this.userTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userTabControl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTabControl.Location = new System.Drawing.Point(0, 93);
            this.userTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.userTabControl.Name = "userTabControl";
            this.userTabControl.Padding = new System.Drawing.Point(0, 0);
            this.userTabControl.SelectedIndex = 0;
            this.userTabControl.Size = new System.Drawing.Size(782, 467);
            this.userTabControl.TabIndex = 17;
            // 
            // accountTab
            // 
            this.accountTab.Controls.Add(this.showpasswordCheckBox);
            this.accountTab.Controls.Add(this.saveButton);
            this.accountTab.Controls.Add(this.avatarRemoveButton);
            this.accountTab.Controls.Add(this.addressLabel);
            this.accountTab.Controls.Add(this.addressTextBox);
            this.accountTab.Controls.Add(this.phoneLabel);
            this.accountTab.Controls.Add(this.phoneTextBox);
            this.accountTab.Controls.Add(this.emailLabel);
            this.accountTab.Controls.Add(this.emailTextBox);
            this.accountTab.Controls.Add(this.passwordLabel);
            this.accountTab.Controls.Add(this.passwordTextBox);
            this.accountTab.Controls.Add(this.usernameLabel);
            this.accountTab.Controls.Add(this.usernameTextBox);
            this.accountTab.Controls.Add(this.avatarUploadButton);
            this.accountTab.Controls.Add(this.avatarPictureBox);
            this.accountTab.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountTab.Location = new System.Drawing.Point(4, 32);
            this.accountTab.Margin = new System.Windows.Forms.Padding(0);
            this.accountTab.Name = "accountTab";
            this.accountTab.Padding = new System.Windows.Forms.Padding(3);
            this.accountTab.Size = new System.Drawing.Size(774, 431);
            this.accountTab.TabIndex = 0;
            this.accountTab.Text = "Account Management";
            this.accountTab.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(476, 223);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(149, 45);
            this.saveButton.TabIndex = 27;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // avatarRemoveButton
            // 
            this.avatarRemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.avatarRemoveButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avatarRemoveButton.Location = new System.Drawing.Point(5, 223);
            this.avatarRemoveButton.Name = "avatarRemoveButton";
            this.avatarRemoveButton.Size = new System.Drawing.Size(149, 45);
            this.avatarRemoveButton.TabIndex = 26;
            this.avatarRemoveButton.Text = "Remove";
            this.avatarRemoveButton.UseVisualStyleBackColor = true;
            this.avatarRemoveButton.Click += new System.EventHandler(this.avatarRemoveButton_Click);
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(223, 187);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(84, 26);
            this.addressLabel.TabIndex = 25;
            this.addressLabel.Text = "Address";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.Location = new System.Drawing.Point(334, 183);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(291, 29);
            this.addressTextBox.TabIndex = 24;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(223, 147);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(62, 26);
            this.phoneLabel.TabIndex = 23;
            this.phoneLabel.Text = "Phone";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.Location = new System.Drawing.Point(334, 143);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(291, 29);
            this.phoneTextBox.TabIndex = 22;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(223, 107);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(58, 26);
            this.emailLabel.TabIndex = 21;
            this.emailLabel.Text = "Email";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(334, 103);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(291, 29);
            this.emailTextBox.TabIndex = 20;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(223, 67);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(94, 26);
            this.passwordLabel.TabIndex = 19;
            this.passwordLabel.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(334, 63);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(291, 29);
            this.passwordTextBox.TabIndex = 18;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(223, 27);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(99, 26);
            this.usernameLabel.TabIndex = 17;
            this.usernameLabel.Text = "Username";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(334, 23);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(291, 29);
            this.usernameTextBox.TabIndex = 16;
            // 
            // avatarUploadButton
            // 
            this.avatarUploadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.avatarUploadButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avatarUploadButton.Location = new System.Drawing.Point(4, 172);
            this.avatarUploadButton.Name = "avatarUploadButton";
            this.avatarUploadButton.Size = new System.Drawing.Size(149, 45);
            this.avatarUploadButton.TabIndex = 15;
            this.avatarUploadButton.Text = "Change";
            this.avatarUploadButton.UseVisualStyleBackColor = true;
            this.avatarUploadButton.Click += new System.EventHandler(this.avatarUploadButton_Click);
            // 
            // avatarPictureBox
            // 
            this.avatarPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("avatarPictureBox.Image")));
            this.avatarPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("avatarPictureBox.InitialImage")));
            this.avatarPictureBox.Location = new System.Drawing.Point(4, 16);
            this.avatarPictureBox.Name = "avatarPictureBox";
            this.avatarPictureBox.Size = new System.Drawing.Size(150, 150);
            this.avatarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatarPictureBox.TabIndex = 0;
            this.avatarPictureBox.TabStop = false;
            // 
            // adsTab
            // 
            this.adsTab.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adsTab.Location = new System.Drawing.Point(4, 32);
            this.adsTab.Name = "adsTab";
            this.adsTab.Padding = new System.Windows.Forms.Padding(3);
            this.adsTab.Size = new System.Drawing.Size(774, 431);
            this.adsTab.TabIndex = 1;
            this.adsTab.Text = "Ads Management";
            this.adsTab.UseVisualStyleBackColor = true;
            // 
            // mainPanel
            // 
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.userTabControl);
            this.mainPanel.Controls.Add(this.bottomPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(784, 562);
            this.mainPanel.TabIndex = 18;
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // showpasswordCheckBox
            // 
            this.showpasswordCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showpasswordCheckBox.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showpasswordCheckBox.Location = new System.Drawing.Point(645, 63);
            this.showpasswordCheckBox.Name = "showpasswordCheckBox";
            this.showpasswordCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.showpasswordCheckBox.Size = new System.Drawing.Size(70, 29);
            this.showpasswordCheckBox.TabIndex = 28;
            this.showpasswordCheckBox.Text = "show";
            this.showpasswordCheckBox.UseVisualStyleBackColor = true;
            this.showpasswordCheckBox.CheckedChanged += new System.EventHandler(this.showpasswordCheckBox_CheckedChanged);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3L2X - main";
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.userTabControl.ResumeLayout(false);
            this.accountTab.ResumeLayout(false);
            this.accountTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.PictureBox exitPictureBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label welcomeMsgLabel;
        private System.Windows.Forms.TabControl userTabControl;
        private System.Windows.Forms.TabPage accountTab;
        private System.Windows.Forms.TabPage adsTab;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Button avatarUploadButton;
        private System.Windows.Forms.PictureBox avatarPictureBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button avatarRemoveButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.CheckBox showpasswordCheckBox;
    }
}