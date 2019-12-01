namespace Login
{
    partial class LoginForm
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
            this.userFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userFormButton
            // 
            this.userFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userFormButton.Location = new System.Drawing.Point(335, 41);
            this.userFormButton.Name = "userFormButton";
            this.userFormButton.Size = new System.Drawing.Size(128, 61);
            this.userFormButton.TabIndex = 0;
            this.userFormButton.Text = "to UserForm";
            this.userFormButton.UseVisualStyleBackColor = true;
            this.userFormButton.Click += new System.EventHandler(this.userFormButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userFormButton);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button userFormButton;
    }
}

