namespace multipleForms
{
    partial class signupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signupForm));
            this.signupPanel = new System.Windows.Forms.Panel();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.exitPictureBox = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            this.dosignupButton = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.TextBox();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.showpasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.signupPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // signupPanel
            // 
            this.signupPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.signupPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signupPanel.Controls.Add(this.showpasswordCheckBox);
            this.signupPanel.Controls.Add(this.phoneLabel);
            this.signupPanel.Controls.Add(this.emailLabel);
            this.signupPanel.Controls.Add(this.emailText);
            this.signupPanel.Controls.Add(this.phoneText);
            this.signupPanel.Controls.Add(this.backButton);
            this.signupPanel.Controls.Add(this.exitPictureBox);
            this.signupPanel.Controls.Add(this.dosignupButton);
            this.signupPanel.Controls.Add(this.welcomeLabel);
            this.signupPanel.Controls.Add(this.passwordLabel);
            this.signupPanel.Controls.Add(this.usernameLabel);
            this.signupPanel.Controls.Add(this.usernameText);
            this.signupPanel.Controls.Add(this.passwordText);
            this.signupPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signupPanel.Location = new System.Drawing.Point(0, 0);
            this.signupPanel.Name = "signupPanel";
            this.signupPanel.Size = new System.Drawing.Size(344, 522);
            this.signupPanel.TabIndex = 0;
            this.signupPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Font = new System.Drawing.Font("Comic Sans MS", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.Blue;
            this.welcomeLabel.Location = new System.Drawing.Point(56, 12);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(224, 61);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "SIGNUP";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.welcomeLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // exitPictureBox
            // 
            this.exitPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("exitPictureBox.Image")));
            this.exitPictureBox.Location = new System.Drawing.Point(295, 12);
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
            this.backButton.Location = new System.Drawing.Point(98, 465);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(146, 45);
            this.backButton.TabIndex = 19;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // dosignupButton
            // 
            this.dosignupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dosignupButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dosignupButton.Location = new System.Drawing.Point(98, 414);
            this.dosignupButton.Name = "dosignupButton";
            this.dosignupButton.Size = new System.Drawing.Size(146, 45);
            this.dosignupButton.TabIndex = 18;
            this.dosignupButton.Text = "Signup";
            this.dosignupButton.UseVisualStyleBackColor = true;
            this.dosignupButton.Click += new System.EventHandler(this.dosignupButton_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.Blue;
            this.passwordLabel.Location = new System.Drawing.Point(3, 152);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(336, 39);
            this.passwordLabel.TabIndex = 17;
            this.passwordLabel.Text = "Password";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.passwordLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // usernameLabel
            // 
            this.usernameLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.Blue;
            this.usernameLabel.Location = new System.Drawing.Point(3, 73);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(336, 39);
            this.usernameLabel.TabIndex = 16;
            this.usernameLabel.Text = "Username";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.usernameLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // passwordText
            // 
            this.passwordText.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordText.Location = new System.Drawing.Point(5, 194);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '*';
            this.passwordText.Size = new System.Drawing.Size(256, 34);
            this.passwordText.TabIndex = 15;
            this.passwordText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // usernameText
            // 
            this.usernameText.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameText.Location = new System.Drawing.Point(5, 115);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(334, 34);
            this.usernameText.TabIndex = 14;
            this.usernameText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // phoneLabel
            // 
            this.phoneLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.ForeColor = System.Drawing.Color.Blue;
            this.phoneLabel.Location = new System.Drawing.Point(5, 310);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(336, 39);
            this.phoneLabel.TabIndex = 23;
            this.phoneLabel.Text = "Phone";
            this.phoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.phoneLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // emailLabel
            // 
            this.emailLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.Blue;
            this.emailLabel.Location = new System.Drawing.Point(5, 231);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(336, 39);
            this.emailLabel.TabIndex = 22;
            this.emailLabel.Text = "Email";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.emailLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // emailText
            // 
            this.emailText.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailText.Location = new System.Drawing.Point(5, 273);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(336, 34);
            this.emailText.TabIndex = 20;
            this.emailText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // phoneText
            // 
            this.phoneText.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneText.Location = new System.Drawing.Point(5, 352);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(336, 34);
            this.phoneText.TabIndex = 21;
            this.phoneText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // showpasswordCheckBox
            // 
            this.showpasswordCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showpasswordCheckBox.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showpasswordCheckBox.Location = new System.Drawing.Point(267, 194);
            this.showpasswordCheckBox.Name = "showpasswordCheckBox";
            this.showpasswordCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.showpasswordCheckBox.Size = new System.Drawing.Size(70, 34);
            this.showpasswordCheckBox.TabIndex = 24;
            this.showpasswordCheckBox.Text = "show";
            this.showpasswordCheckBox.UseVisualStyleBackColor = true;
            this.showpasswordCheckBox.CheckedChanged += new System.EventHandler(this.showpasswordCheckBox_CheckedChanged);
            // 
            // signupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 522);
            this.Controls.Add(this.signupPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "signupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3L2X - Signup";
            this.signupPanel.ResumeLayout(false);
            this.signupPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel signupPanel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.PictureBox exitPictureBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button dosignupButton;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.CheckBox showpasswordCheckBox;
    }
}