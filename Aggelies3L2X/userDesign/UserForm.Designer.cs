﻿namespace UserApplication
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
            this.userMenu1 = new aggeliesWpfLab.UserMenu();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.homePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.page6Panel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.page5Panel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.page4Panel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.adsPanel = new System.Windows.Forms.Panel();
            this.editPicturePictureBox = new System.Windows.Forms.PictureBox();
            this.adsListPanel = new System.Windows.Forms.Panel();
            this.adsListBox = new System.Windows.Forms.ListBox();
            this.adsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aggeliesDBDataSet = new UserApplication.AggeliesDBDataSet();
            this.infoLabel = new System.Windows.Forms.Label();
            this.editDescriptionPictureBox = new System.Windows.Forms.PictureBox();
            this.editTitlePictureBox = new System.Windows.Forms.PictureBox();
            this.recentAdPanel = new System.Windows.Forms.Panel();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.adsPictureBox = new System.Windows.Forms.PictureBox();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.adsTableTableAdapter = new UserApplication.AggeliesDBDataSetTableAdapters.AdsTableTableAdapter();
            this.rightPanel.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.homePanel.SuspendLayout();
            this.page6Panel.SuspendLayout();
            this.page5Panel.SuspendLayout();
            this.page4Panel.SuspendLayout();
            this.adsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editPicturePictureBox)).BeginInit();
            this.adsListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aggeliesDBDataSet)).BeginInit();
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
            this.topPanel.Size = new System.Drawing.Size(1006, 100);
            this.topPanel.TabIndex = 0;
            // 
            // footerPanel
            // 
            this.footerPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(0, 534);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(1006, 100);
            this.footerPanel.TabIndex = 1;
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rightPanel.Controls.Add(this.elementHost1);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(1006, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(216, 634);
            this.rightPanel.TabIndex = 2;
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(0, 100);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(216, 294);
            this.elementHost1.TabIndex = 7;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.userMenu1;
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.label2);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsPanel.Location = new System.Drawing.Point(0, 0);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(1006, 434);
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
            this.homePanel.Size = new System.Drawing.Size(1006, 434);
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
            this.page6Panel.Size = new System.Drawing.Size(1006, 434);
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
            // page5Panel
            // 
            this.page5Panel.Controls.Add(this.label5);
            this.page5Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page5Panel.Location = new System.Drawing.Point(0, 0);
            this.page5Panel.Name = "page5Panel";
            this.page5Panel.Size = new System.Drawing.Size(1006, 434);
            this.page5Panel.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 72);
            this.label5.TabIndex = 1;
            this.label5.Text = "page 5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // page4Panel
            // 
            this.page4Panel.Controls.Add(this.label4);
            this.page4Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page4Panel.Location = new System.Drawing.Point(0, 0);
            this.page4Panel.Name = "page4Panel";
            this.page4Panel.Size = new System.Drawing.Size(1006, 434);
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
            this.adsPanel.Size = new System.Drawing.Size(1006, 434);
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
            this.adsListPanel.Location = new System.Drawing.Point(806, 0);
            this.adsListPanel.Margin = new System.Windows.Forms.Padding(0);
            this.adsListPanel.Name = "adsListPanel";
            this.adsListPanel.Size = new System.Drawing.Size(200, 434);
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
            this.adsListBox.Size = new System.Drawing.Size(200, 400);
            this.adsListBox.TabIndex = 3;
            this.adsListBox.ValueMember = "adID";
            this.adsListBox.SelectedIndexChanged += new System.EventHandler(this.adsListBox_SelectedIndexChanged);
            // 
            // adsTableBindingSource
            // 
            this.adsTableBindingSource.DataMember = "AdsTable";
            this.adsTableBindingSource.DataSource = this.aggeliesDBDataSet;
            // 
            // aggeliesDBDataSet
            // 
            this.aggeliesDBDataSet.DataSetName = "AggeliesDBDataSet";
            this.aggeliesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.recentAdPanel.Size = new System.Drawing.Size(278, 434);
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
            this.descriptionRichTextBox.Location = new System.Drawing.Point(0, 276);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.descriptionRichTextBox.Size = new System.Drawing.Size(278, 158);
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
            this.adsPictureBox.Size = new System.Drawing.Size(278, 256);
            this.adsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.adsPictureBox.TabIndex = 3;
            this.adsPictureBox.TabStop = false;
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.adsPanel);
            this.contentPanel.Controls.Add(this.page4Panel);
            this.contentPanel.Controls.Add(this.page5Panel);
            this.contentPanel.Controls.Add(this.page6Panel);
            this.contentPanel.Controls.Add(this.homePanel);
            this.contentPanel.Controls.Add(this.settingsPanel);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 100);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1006, 434);
            this.contentPanel.TabIndex = 5;
            // 
            // adsTableTableAdapter
            // 
            this.adsTableTableAdapter.ClearBeforeFill = true;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 634);
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
            this.page5Panel.ResumeLayout(false);
            this.page4Panel.ResumeLayout(false);
            this.adsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editPicturePictureBox)).EndInit();
            this.adsListPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aggeliesDBDataSet)).EndInit();
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
        private System.Windows.Forms.Panel page5Panel;
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
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private aggeliesWpfLab.UserMenu userMenu1;
    }
}

