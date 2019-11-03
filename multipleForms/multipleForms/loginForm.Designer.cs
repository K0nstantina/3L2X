namespace multipleForms
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.signinPanel = new System.Windows.Forms.Panel();
            this.exitPictureBox = new System.Windows.Forms.PictureBox();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.dologinButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.signinPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // signinPanel
            // 
            this.signinPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.signinPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signinPanel.Controls.Add(this.backButton);
            this.signinPanel.Controls.Add(this.dologinButton);
            this.signinPanel.Controls.Add(this.passwordLabel);
            this.signinPanel.Controls.Add(this.usernameLabel);
            this.signinPanel.Controls.Add(this.passwordText);
            this.signinPanel.Controls.Add(this.usernameText);
            this.signinPanel.Controls.Add(this.exitPictureBox);
            this.signinPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signinPanel.Location = new System.Drawing.Point(0, 0);
            this.signinPanel.Name = "signinPanel";
            this.signinPanel.Size = new System.Drawing.Size(360, 360);
            this.signinPanel.TabIndex = 0;
            this.signinPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // exitPictureBox
            // 
            this.exitPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("exitPictureBox.Image")));
            this.exitPictureBox.Location = new System.Drawing.Point(311, 12);
            this.exitPictureBox.Name = "exitPictureBox";
            this.exitPictureBox.Size = new System.Drawing.Size(37, 35);
            this.exitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitPictureBox.TabIndex = 7;
            this.exitPictureBox.TabStop = false;
            this.exitPictureBox.Click += new System.EventHandler(this.exitPictureBox_Click);
            // 
            // usernameText
            // 
            this.usernameText.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameText.Location = new System.Drawing.Point(12, 92);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(336, 34);
            this.usernameText.TabIndex = 8;
            // 
            // usernameLabel
            // 
            this.usernameLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.Blue;
            this.usernameLabel.Location = new System.Drawing.Point(12, 50);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(336, 39);
            this.usernameLabel.TabIndex = 10;
            this.usernameLabel.Text = "Username";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.usernameLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // passwordLabel
            // 
            this.passwordLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.Blue;
            this.passwordLabel.Location = new System.Drawing.Point(12, 129);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(336, 39);
            this.passwordLabel.TabIndex = 11;
            this.passwordLabel.Text = "Password";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.passwordLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // passwordText
            // 
            this.passwordText.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordText.Location = new System.Drawing.Point(12, 171);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '*';
            this.passwordText.Size = new System.Drawing.Size(336, 34);
            this.passwordText.TabIndex = 9;
            // 
            // dologinButton
            // 
            this.dologinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dologinButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dologinButton.Location = new System.Drawing.Point(102, 223);
            this.dologinButton.Name = "dologinButton";
            this.dologinButton.Size = new System.Drawing.Size(146, 45);
            this.dologinButton.TabIndex = 12;
            this.dologinButton.Text = "Login";
            this.dologinButton.UseVisualStyleBackColor = true;
            this.dologinButton.Click += new System.EventHandler(this.dologinButton_Click);
            // 
            // backButton
            // 
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(102, 286);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(146, 45);
            this.backButton.TabIndex = 13;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // signinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 360);
            this.Controls.Add(this.signinPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "signinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3L2X";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.signinPanel.ResumeLayout(false);
            this.signinPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel signinPanel;
        private System.Windows.Forms.PictureBox exitPictureBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.Button dologinButton;
        private System.Windows.Forms.Button backButton;
    }
}