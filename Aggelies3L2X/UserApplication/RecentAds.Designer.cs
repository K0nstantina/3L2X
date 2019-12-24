namespace UserApplication
{
    partial class RecentAds
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mediaPictureBox
            // 
            this.mediaPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.mediaPictureBox.Location = new System.Drawing.Point(0, 0);
            this.mediaPictureBox.Name = "mediaPictureBox";
            this.mediaPictureBox.Size = new System.Drawing.Size(280, 150);
            this.mediaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mediaPictureBox.TabIndex = 0;
            this.mediaPictureBox.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.titleLabel.Location = new System.Drawing.Point(0, 153);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(280, 31);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "label1";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.descriptionLabel.Location = new System.Drawing.Point(0, 184);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(280, 76);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "desc";
            // 
            // RecentAds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.mediaPictureBox);
            this.Name = "RecentAds";
            this.Size = new System.Drawing.Size(280, 260);
            ((System.ComponentModel.ISupportInitialize)(this.mediaPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox mediaPictureBox;
        public System.Windows.Forms.Label titleLabel;
        public System.Windows.Forms.Label descriptionLabel;
    }
}
