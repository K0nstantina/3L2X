namespace AdministratorPanel
{
    partial class AdminForm
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AdsPage = new System.Windows.Forms.TabPage();
            this.UsersPage = new System.Windows.Forms.TabPage();
            this.dataPage = new System.Windows.Forms.TabPage();
            this.profilePage = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1266, 120);
            this.topPanel.TabIndex = 0;
            // 
            // leftPanel
            // 
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 120);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(220, 523);
            this.leftPanel.TabIndex = 1;
            // 
            // rightPanel
            // 
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(1046, 120);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(220, 523);
            this.rightPanel.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AdsPage);
            this.tabControl1.Controls.Add(this.UsersPage);
            this.tabControl1.Controls.Add(this.dataPage);
            this.tabControl1.Controls.Add(this.profilePage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(220, 120);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(826, 523);
            this.tabControl1.TabIndex = 3;
            // 
            // AdsPage
            // 
            this.AdsPage.Location = new System.Drawing.Point(4, 22);
            this.AdsPage.Name = "AdsPage";
            this.AdsPage.Padding = new System.Windows.Forms.Padding(3);
            this.AdsPage.Size = new System.Drawing.Size(818, 497);
            this.AdsPage.TabIndex = 0;
            this.AdsPage.Text = "Αγγελίες";
            this.AdsPage.UseVisualStyleBackColor = true;
            // 
            // UsersPage
            // 
            this.UsersPage.Location = new System.Drawing.Point(4, 22);
            this.UsersPage.Name = "UsersPage";
            this.UsersPage.Padding = new System.Windows.Forms.Padding(3);
            this.UsersPage.Size = new System.Drawing.Size(818, 497);
            this.UsersPage.TabIndex = 1;
            this.UsersPage.Text = "Χρήστες";
            this.UsersPage.UseVisualStyleBackColor = true;
            // 
            // dataPage
            // 
            this.dataPage.Location = new System.Drawing.Point(4, 22);
            this.dataPage.Name = "dataPage";
            this.dataPage.Padding = new System.Windows.Forms.Padding(3);
            this.dataPage.Size = new System.Drawing.Size(818, 497);
            this.dataPage.TabIndex = 2;
            this.dataPage.Text = "Στατιστικά και Αναλύσεις";
            this.dataPage.UseVisualStyleBackColor = true;
            // 
            // profilePage
            // 
            this.profilePage.Location = new System.Drawing.Point(4, 22);
            this.profilePage.Name = "profilePage";
            this.profilePage.Size = new System.Drawing.Size(818, 497);
            this.profilePage.TabIndex = 3;
            this.profilePage.Text = "Προφίλ";
            this.profilePage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 643);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.topPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AdsPage;
        private System.Windows.Forms.TabPage UsersPage;
        private System.Windows.Forms.TabPage dataPage;
        private System.Windows.Forms.TabPage profilePage;
    }
}

