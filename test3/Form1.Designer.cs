namespace test3
{
    partial class Form1
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
            this.checkCon = new System.Windows.Forms.Label();
            this.NameHouse = new System.Windows.Forms.Label();
            this.PriceHouse = new System.Windows.Forms.Label();
            this.LoadButton = new System.Windows.Forms.Button();
            this.name_house_text = new System.Windows.Forms.TextBox();
            this.house_price_Text = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saved_data = new System.Windows.Forms.Button();
            this.delete_Data = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkCon
            // 
            this.checkCon.AutoSize = true;
            this.checkCon.Location = new System.Drawing.Point(12, 175);
            this.checkCon.Name = "checkCon";
            this.checkCon.Size = new System.Drawing.Size(0, 13);
            this.checkCon.TabIndex = 1;
            this.checkCon.Click += new System.EventHandler(this.label1_Click);
            // 
            // NameHouse
            // 
            this.NameHouse.AutoSize = true;
            this.NameHouse.Location = new System.Drawing.Point(0, 3);
            this.NameHouse.Name = "NameHouse";
            this.NameHouse.Size = new System.Drawing.Size(76, 13);
            this.NameHouse.TabIndex = 2;
            this.NameHouse.Text = "Onoma Spitiou";
            this.NameHouse.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // PriceHouse
            // 
            this.PriceHouse.AutoSize = true;
            this.PriceHouse.Location = new System.Drawing.Point(6, 37);
            this.PriceHouse.Name = "PriceHouse";
            this.PriceHouse.Size = new System.Drawing.Size(61, 13);
            this.PriceHouse.TabIndex = 3;
            this.PriceHouse.Text = "Timi Spitiou";
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(9, 75);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(142, 22);
            this.LoadButton.TabIndex = 4;
            this.LoadButton.Text = "Load Random House";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // name_house_text
            // 
            this.name_house_text.Location = new System.Drawing.Point(94, 0);
            this.name_house_text.Name = "name_house_text";
            this.name_house_text.Size = new System.Drawing.Size(100, 20);
            this.name_house_text.TabIndex = 5;
            // 
            // house_price_Text
            // 
            this.house_price_Text.Location = new System.Drawing.Point(94, 37);
            this.house_price_Text.Name = "house_price_Text";
            this.house_price_Text.Size = new System.Drawing.Size(100, 20);
            this.house_price_Text.TabIndex = 6;
            this.house_price_Text.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.delete_Data);
            this.groupBox1.Controls.Add(this.saved_data);
            this.groupBox1.Controls.Add(this.house_price_Text);
            this.groupBox1.Controls.Add(this.name_house_text);
            this.groupBox1.Controls.Add(this.LoadButton);
            this.groupBox1.Controls.Add(this.PriceHouse);
            this.groupBox1.Controls.Add(this.NameHouse);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 176);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dunno";
            // 
            // saved_data
            // 
            this.saved_data.Location = new System.Drawing.Point(9, 104);
            this.saved_data.Name = "saved_data";
            this.saved_data.Size = new System.Drawing.Size(75, 23);
            this.saved_data.TabIndex = 7;
            this.saved_data.Text = "Insert";
            this.saved_data.UseVisualStyleBackColor = true;
            this.saved_data.Click += new System.EventHandler(this.saved_data_Click);
            // 
            // delete_Data
            // 
            this.delete_Data.Location = new System.Drawing.Point(9, 134);
            this.delete_Data.Name = "delete_Data";
            this.delete_Data.Size = new System.Drawing.Size(75, 23);
            this.delete_Data.TabIndex = 8;
            this.delete_Data.Text = "Delete";
            this.delete_Data.UseVisualStyleBackColor = true;
            this.delete_Data.Click += new System.EventHandler(this.delete_Data_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 328);
            this.Controls.Add(this.checkCon);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label checkCon;
        private System.Windows.Forms.Label NameHouse;
        private System.Windows.Forms.Label PriceHouse;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.TextBox name_house_text;
        private System.Windows.Forms.TextBox house_price_Text;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button delete_Data;
        private System.Windows.Forms.Button saved_data;
    }
}

