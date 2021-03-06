﻿namespace UserApplication
{
    partial class DisplayAds
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mediaPictureBox = new System.Windows.Forms.PictureBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.descTextBox = new System.Windows.Forms.TextBox();
            this.DisplayAdsPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPictureBox)).BeginInit();
            this.DisplayAdsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mediaPictureBox
            // 
            this.mediaPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.mediaPictureBox.Location = new System.Drawing.Point(0, 0);
            this.mediaPictureBox.MaximumSize = new System.Drawing.Size(500, 250);
            this.mediaPictureBox.Name = "mediaPictureBox";
            this.mediaPictureBox.Size = new System.Drawing.Size(300, 100);
            this.mediaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mediaPictureBox.TabIndex = 0;
            this.mediaPictureBox.TabStop = false;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.titleTextBox.Location = new System.Drawing.Point(3, 106);
            this.titleTextBox.Multiline = true;
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.ReadOnly = true;
            this.titleTextBox.Size = new System.Drawing.Size(294, 50);
            this.titleTextBox.TabIndex = 1;
            this.titleTextBox.Text = "title";
            // 
            // descTextBox
            // 
            this.descTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.descTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.descTextBox.Location = new System.Drawing.Point(0, 175);
            this.descTextBox.Multiline = true;
            this.descTextBox.Name = "descTextBox";
            this.descTextBox.ReadOnly = true;
            this.descTextBox.Size = new System.Drawing.Size(300, 125);
            this.descTextBox.TabIndex = 2;
            // 
            // DisplayAdsPanel
            // 
            this.DisplayAdsPanel.Controls.Add(this.descTextBox);
            this.DisplayAdsPanel.Controls.Add(this.titleTextBox);
            this.DisplayAdsPanel.Controls.Add(this.mediaPictureBox);
            this.DisplayAdsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayAdsPanel.Location = new System.Drawing.Point(0, 0);
            this.DisplayAdsPanel.Name = "DisplayAdsPanel";
            this.DisplayAdsPanel.Size = new System.Drawing.Size(300, 300);
            this.DisplayAdsPanel.TabIndex = 3;
            // 
            // DisplayAds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DisplayAdsPanel);
            this.Name = "DisplayAds";
            this.Size = new System.Drawing.Size(300, 300);
            ((System.ComponentModel.ISupportInitialize)(this.mediaPictureBox)).EndInit();
            this.DisplayAdsPanel.ResumeLayout(false);
            this.DisplayAdsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox mediaPictureBox;
        public System.Windows.Forms.TextBox titleTextBox;
        public System.Windows.Forms.TextBox descTextBox;
        public System.Windows.Forms.Panel DisplayAdsPanel;
    }
}
