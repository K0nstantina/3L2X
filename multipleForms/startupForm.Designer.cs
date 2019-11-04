namespace multipleForms
{
    partial class startupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(startupForm));
            this.startUpPanel = new System.Windows.Forms.Panel();
            this.exitPictureBox = new System.Windows.Forms.PictureBox();
            this.signupButton = new System.Windows.Forms.Button();
            this.orLabel = new System.Windows.Forms.Label();
            this.noaccountLabel = new System.Windows.Forms.Label();
            this.continueButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.startUpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // startUpPanel
            // 
            this.startUpPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.startUpPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.startUpPanel.Controls.Add(this.exitPictureBox);
            this.startUpPanel.Controls.Add(this.signupButton);
            this.startUpPanel.Controls.Add(this.orLabel);
            this.startUpPanel.Controls.Add(this.noaccountLabel);
            this.startUpPanel.Controls.Add(this.continueButton);
            this.startUpPanel.Controls.Add(this.welcomeLabel);
            this.startUpPanel.Controls.Add(this.loginButton);
            this.startUpPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startUpPanel.Location = new System.Drawing.Point(0, 0);
            this.startUpPanel.Margin = new System.Windows.Forms.Padding(0);
            this.startUpPanel.Name = "startUpPanel";
            this.startUpPanel.Size = new System.Drawing.Size(360, 360);
            this.startUpPanel.TabIndex = 0;
            this.startUpPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // exitPictureBox
            // 
            this.exitPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("exitPictureBox.Image")));
            this.exitPictureBox.Location = new System.Drawing.Point(311, 12);
            this.exitPictureBox.Name = "exitPictureBox";
            this.exitPictureBox.Size = new System.Drawing.Size(37, 35);
            this.exitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitPictureBox.TabIndex = 6;
            this.exitPictureBox.TabStop = false;
            this.exitPictureBox.Click += new System.EventHandler(this.exitPictureBox_Click);
            // 
            // signupButton
            // 
            this.signupButton.FlatAppearance.BorderSize = 0;
            this.signupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupButton.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupButton.ForeColor = System.Drawing.Color.Blue;
            this.signupButton.Location = new System.Drawing.Point(229, 299);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(97, 36);
            this.signupButton.TabIndex = 5;
            this.signupButton.Text = "Sign Up";
            this.signupButton.UseVisualStyleBackColor = true;
            // 
            // orLabel
            // 
            this.orLabel.Font = new System.Drawing.Font("Comic Sans MS", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orLabel.ForeColor = System.Drawing.Color.Blue;
            this.orLabel.Location = new System.Drawing.Point(130, 140);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(100, 61);
            this.orLabel.TabIndex = 4;
            this.orLabel.Text = "OR";
            this.orLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.orLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // noaccountLabel
            // 
            this.noaccountLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noaccountLabel.ForeColor = System.Drawing.Color.Black;
            this.noaccountLabel.Location = new System.Drawing.Point(31, 299);
            this.noaccountLabel.Name = "noaccountLabel";
            this.noaccountLabel.Size = new System.Drawing.Size(208, 37);
            this.noaccountLabel.TabIndex = 3;
            this.noaccountLabel.Text = "don\'t have an account?";
            this.noaccountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.noaccountLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // continueButton
            // 
            this.continueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.continueButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueButton.Location = new System.Drawing.Point(68, 204);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(224, 55);
            this.continueButton.TabIndex = 2;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Font = new System.Drawing.Font("Comic Sans MS", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.Blue;
            this.welcomeLabel.Location = new System.Drawing.Point(68, 9);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(224, 61);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.Text = "WELCOME";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.welcomeLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // loginButton
            // 
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(68, 82);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(224, 55);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // startupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 360);
            this.Controls.Add(this.startUpPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "startupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3L2X";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.startUpPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel startUpPanel;
        private System.Windows.Forms.Button signupButton;
        private System.Windows.Forms.Label orLabel;
        private System.Windows.Forms.Label noaccountLabel;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.PictureBox exitPictureBox;
    }
}

