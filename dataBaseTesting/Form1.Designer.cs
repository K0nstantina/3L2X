namespace dataBaseTesting
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
            this.components = new System.ComponentModel.Container();
            this.idLabel = new System.Windows.Forms.Label();
            this.descLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.descBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.insertButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.houseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseDescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.housePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.housesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSampleDataSet = new dataBaseTesting.dataSampleDataSet();
            this.housesTableAdapter = new dataBaseTesting.dataSampleDataSetTableAdapters.housesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.housesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSampleDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(12, 27);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 13);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "ID";
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.Location = new System.Drawing.Point(12, 80);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(60, 13);
            this.descLabel.TabIndex = 1;
            this.descLabel.Text = "Description";
            this.descLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(12, 134);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(31, 13);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "Price";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(95, 20);
            this.textBox1.TabIndex = 3;
            // 
            // descBox
            // 
            this.descBox.Location = new System.Drawing.Point(86, 80);
            this.descBox.Name = "descBox";
            this.descBox.Size = new System.Drawing.Size(331, 20);
            this.descBox.TabIndex = 4;
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(86, 134);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(331, 20);
            this.priceBox.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.houseIDDataGridViewTextBoxColumn,
            this.houseDescDataGridViewTextBoxColumn,
            this.housePriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.housesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(443, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 426);
            this.dataGridView1.TabIndex = 6;
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(15, 210);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(75, 23);
            this.insertButton.TabIndex = 7;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(96, 210);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 8;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // houseIDDataGridViewTextBoxColumn
            // 
            this.houseIDDataGridViewTextBoxColumn.DataPropertyName = "houseID";
            this.houseIDDataGridViewTextBoxColumn.HeaderText = "houseID";
            this.houseIDDataGridViewTextBoxColumn.Name = "houseIDDataGridViewTextBoxColumn";
            // 
            // houseDescDataGridViewTextBoxColumn
            // 
            this.houseDescDataGridViewTextBoxColumn.DataPropertyName = "houseDesc";
            this.houseDescDataGridViewTextBoxColumn.HeaderText = "houseDesc";
            this.houseDescDataGridViewTextBoxColumn.Name = "houseDescDataGridViewTextBoxColumn";
            // 
            // housePriceDataGridViewTextBoxColumn
            // 
            this.housePriceDataGridViewTextBoxColumn.DataPropertyName = "housePrice";
            this.housePriceDataGridViewTextBoxColumn.HeaderText = "housePrice";
            this.housePriceDataGridViewTextBoxColumn.Name = "housePriceDataGridViewTextBoxColumn";
            // 
            // housesBindingSource
            // 
            this.housesBindingSource.DataMember = "houses";
            this.housesBindingSource.DataSource = this.dataSampleDataSet;
            // 
            // dataSampleDataSet
            // 
            this.dataSampleDataSet.DataSetName = "dataSampleDataSet";
            this.dataSampleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // housesTableAdapter
            // 
            this.housesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.descBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.idLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.housesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSampleDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox descBox;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dataSampleDataSet dataSampleDataSet;
        private System.Windows.Forms.BindingSource housesBindingSource;
        private dataSampleDataSetTableAdapters.housesTableAdapter housesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseDescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn housePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button updateButton;
    }
}

