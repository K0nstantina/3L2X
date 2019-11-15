namespace userDesign
{
    partial class MainForm
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
            this.footerPanel = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.page2Button = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.homePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pagePanel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pagePanel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.page3Button = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.homePanel.SuspendLayout();
            this.pagePanel1.SuspendLayout();
            this.pagePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(942, 89);
            this.topPanel.TabIndex = 0;
            // 
            // footerPanel
            // 
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(0, 489);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(942, 99);
            this.footerPanel.TabIndex = 1;
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.page3Button);
            this.leftPanel.Controls.Add(this.page2Button);
            this.leftPanel.Controls.Add(this.homeButton);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 89);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(200, 400);
            this.leftPanel.TabIndex = 2;
            // 
            // page2Button
            // 
            this.page2Button.BackColor = System.Drawing.Color.Snow;
            this.page2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.page2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.page2Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.page2Button.Location = new System.Drawing.Point(0, 40);
            this.page2Button.Name = "page2Button";
            this.page2Button.Size = new System.Drawing.Size(200, 34);
            this.page2Button.TabIndex = 1;
            this.page2Button.Text = "Page 2";
            this.page2Button.UseVisualStyleBackColor = false;
            this.page2Button.Click += new System.EventHandler(this.page2Button_Click);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.Snow;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.homeButton.Location = new System.Drawing.Point(0, 0);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(200, 34);
            this.homeButton.TabIndex = 0;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // homePanel
            // 
            this.homePanel.Controls.Add(this.label1);
            this.homePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homePanel.Location = new System.Drawing.Point(0, 0);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(942, 588);
            this.homePanel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "homepage";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pagePanel1
            // 
            this.pagePanel1.Controls.Add(this.label2);
            this.pagePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pagePanel1.Location = new System.Drawing.Point(0, 0);
            this.pagePanel1.Name = "pagePanel1";
            this.pagePanel1.Size = new System.Drawing.Size(942, 588);
            this.pagePanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(270, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 72);
            this.label2.TabIndex = 1;
            this.label2.Text = "page 2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pagePanel2
            // 
            this.pagePanel2.Controls.Add(this.label4);
            this.pagePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pagePanel2.Location = new System.Drawing.Point(0, 0);
            this.pagePanel2.Name = "pagePanel2";
            this.pagePanel2.Size = new System.Drawing.Size(942, 588);
            this.pagePanel2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(283, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 72);
            this.label4.TabIndex = 2;
            this.label4.Text = "page 3";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // page3Button
            // 
            this.page3Button.BackColor = System.Drawing.Color.Snow;
            this.page3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.page3Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.page3Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.page3Button.Location = new System.Drawing.Point(0, 80);
            this.page3Button.Name = "page3Button";
            this.page3Button.Size = new System.Drawing.Size(200, 34);
            this.page3Button.TabIndex = 2;
            this.page3Button.Text = "Page 3";
            this.page3Button.UseVisualStyleBackColor = false;
            this.page3Button.Click += new System.EventHandler(this.page3Button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 588);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.homePanel);
            this.Controls.Add(this.pagePanel2);
            this.Controls.Add(this.pagePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.leftPanel.ResumeLayout(false);
            this.homePanel.ResumeLayout(false);
            this.pagePanel1.ResumeLayout(false);
            this.pagePanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Button page2Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pagePanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pagePanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button page3Button;
    }
}

