using aggeliesWpfLab;

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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label userIDLabel;
            System.Windows.Forms.Label fNameLabel;
            System.Windows.Forms.Label lNameLabel;
            System.Windows.Forms.Label uNameLabel;
            System.Windows.Forms.Label uPasswordLabel;
            System.Windows.Forms.Label uEmailLabel;
            System.Windows.Forms.Label uRecoverEmailLabel;
            System.Windows.Forms.Label uPhoneLabel;
            System.Windows.Forms.Label uAgeLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.status_label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uCatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uRecoverEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.aggeliesDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aggeliesDBDataSet = new AdministratorPanel.AggeliesDBDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aggeliesDBDataSet1 = new AdministratorPanel.AggeliesDBDataSet1();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.uAgeTextBox = new System.Windows.Forms.TextBox();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.uPhoneTextBox = new System.Windows.Forms.TextBox();
            this.uRecoverEmailTextBox = new System.Windows.Forms.TextBox();
            this.uEmailTextBox = new System.Windows.Forms.TextBox();
            this.uPasswordTextBox = new System.Windows.Forms.TextBox();
            this.uNameTextBox = new System.Windows.Forms.TextBox();
            this.lNameTextBox = new System.Windows.Forms.TextBox();
            this.fNameTextBox = new System.Windows.Forms.TextBox();
            this.userIDTextBox = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.next_button = new System.Windows.Forms.Button();
            this.addnew_button = new System.Windows.Forms.Button();
            this.previous_button = new System.Windows.Forms.Button();
            this.usersTableAdapter = new AdministratorPanel.AggeliesDBDataSet1TableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new AdministratorPanel.AggeliesDBDataSet1TableAdapters.TableAdapterManager();
            this.usersTableAdapter1 = new AdministratorPanel.AggeliesDBDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager1 = new AdministratorPanel.AggeliesDBDataSetTableAdapters.TableAdapterManager();
            this.adsTableTableAdapter = new AdministratorPanel.AggeliesDBDataSetTableAdapters.AdsTableTableAdapter();
            this.adsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            userIDLabel = new System.Windows.Forms.Label();
            fNameLabel = new System.Windows.Forms.Label();
            lNameLabel = new System.Windows.Forms.Label();
            uNameLabel = new System.Windows.Forms.Label();
            uPasswordLabel = new System.Windows.Forms.Label();
            uEmailLabel = new System.Windows.Forms.Label();
            uRecoverEmailLabel = new System.Windows.Forms.Label();
            uPhoneLabel = new System.Windows.Forms.Label();
            uAgeLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aggeliesDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aggeliesDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aggeliesDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adsTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // userIDLabel
            // 
            userIDLabel.AutoSize = true;
            userIDLabel.Location = new System.Drawing.Point(22, 17);
            userIDLabel.Name = "userIDLabel";
            userIDLabel.Size = new System.Drawing.Size(44, 13);
            userIDLabel.TabIndex = 13;
            userIDLabel.Text = "user ID:";
            // 
            // fNameLabel
            // 
            fNameLabel.AutoSize = true;
            fNameLabel.Location = new System.Drawing.Point(22, 43);
            fNameLabel.Name = "fNameLabel";
            fNameLabel.Size = new System.Drawing.Size(44, 13);
            fNameLabel.TabIndex = 14;
            fNameLabel.Text = "f Name:";
            // 
            // lNameLabel
            // 
            lNameLabel.AutoSize = true;
            lNameLabel.Location = new System.Drawing.Point(23, 69);
            lNameLabel.Name = "lNameLabel";
            lNameLabel.Size = new System.Drawing.Size(43, 13);
            lNameLabel.TabIndex = 15;
            lNameLabel.Text = "l Name:";
            // 
            // uNameLabel
            // 
            uNameLabel.AutoSize = true;
            uNameLabel.Location = new System.Drawing.Point(205, 17);
            uNameLabel.Name = "uNameLabel";
            uNameLabel.Size = new System.Drawing.Size(47, 13);
            uNameLabel.TabIndex = 16;
            uNameLabel.Text = "u Name:";
            // 
            // uPasswordLabel
            // 
            uPasswordLabel.AutoSize = true;
            uPasswordLabel.Location = new System.Drawing.Point(187, 43);
            uPasswordLabel.Name = "uPasswordLabel";
            uPasswordLabel.Size = new System.Drawing.Size(65, 13);
            uPasswordLabel.TabIndex = 17;
            uPasswordLabel.Text = "u Password:";
            // 
            // uEmailLabel
            // 
            uEmailLabel.AutoSize = true;
            uEmailLabel.Location = new System.Drawing.Point(22, 95);
            uEmailLabel.Name = "uEmailLabel";
            uEmailLabel.Size = new System.Drawing.Size(44, 13);
            uEmailLabel.TabIndex = 18;
            uEmailLabel.Text = "u Email:";
            // 
            // uRecoverEmailLabel
            // 
            uRecoverEmailLabel.AutoSize = true;
            uRecoverEmailLabel.Location = new System.Drawing.Point(164, 69);
            uRecoverEmailLabel.Name = "uRecoverEmailLabel";
            uRecoverEmailLabel.Size = new System.Drawing.Size(88, 13);
            uRecoverEmailLabel.TabIndex = 19;
            uRecoverEmailLabel.Text = "u Recover Email:";
            // 
            // uPhoneLabel
            // 
            uPhoneLabel.AutoSize = true;
            uPhoneLabel.Location = new System.Drawing.Point(16, 123);
            uPhoneLabel.Name = "uPhoneLabel";
            uPhoneLabel.Size = new System.Drawing.Size(50, 13);
            uPhoneLabel.TabIndex = 20;
            uPhoneLabel.Text = "u Phone:";
            // 
            // uAgeLabel
            // 
            uAgeLabel.AutoSize = true;
            uAgeLabel.Location = new System.Drawing.Point(28, 149);
            uAgeLabel.Name = "uAgeLabel";
            uAgeLabel.Size = new System.Drawing.Size(38, 13);
            uAgeLabel.TabIndex = 22;
            uAgeLabel.Text = "u Age:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1230, 62);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1230, 59);
            this.panel2.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.DarkKhaki;
            this.splitContainer2.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.SandyBrown;
            this.splitContainer2.Panel2.Controls.Add(this.status_label);
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer2.Size = new System.Drawing.Size(832, 566);
            this.splitContainer2.SplitterDistance = 202;
            this.splitContainer2.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(202, 566);
            this.treeView1.TabIndex = 0;
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Location = new System.Drawing.Point(3, 547);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(43, 13);
            this.status_label.TabIndex = 1;
            this.status_label.Text = "Status: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.fNameDataGridViewTextBoxColumn,
            this.lNameDataGridViewTextBoxColumn,
            this.uNameDataGridViewTextBoxColumn,
            this.uPasswordDataGridViewTextBoxColumn,
            this.uEmailDataGridViewTextBoxColumn,
            this.uCatDataGridViewTextBoxColumn,
            this.uAgeDataGridViewTextBoxColumn,
            this.uRecoverEmailDataGridViewTextBoxColumn,
            this.uPhoneDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usersBindingSource2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(626, 544);
            this.dataGridView1.TabIndex = 0;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "userID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "userID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            // 
            // fNameDataGridViewTextBoxColumn
            // 
            this.fNameDataGridViewTextBoxColumn.DataPropertyName = "fName";
            this.fNameDataGridViewTextBoxColumn.HeaderText = "fName";
            this.fNameDataGridViewTextBoxColumn.Name = "fNameDataGridViewTextBoxColumn";
            // 
            // lNameDataGridViewTextBoxColumn
            // 
            this.lNameDataGridViewTextBoxColumn.DataPropertyName = "lName";
            this.lNameDataGridViewTextBoxColumn.HeaderText = "lName";
            this.lNameDataGridViewTextBoxColumn.Name = "lNameDataGridViewTextBoxColumn";
            // 
            // uNameDataGridViewTextBoxColumn
            // 
            this.uNameDataGridViewTextBoxColumn.DataPropertyName = "uName";
            this.uNameDataGridViewTextBoxColumn.HeaderText = "uName";
            this.uNameDataGridViewTextBoxColumn.Name = "uNameDataGridViewTextBoxColumn";
            // 
            // uPasswordDataGridViewTextBoxColumn
            // 
            this.uPasswordDataGridViewTextBoxColumn.DataPropertyName = "uPassword";
            this.uPasswordDataGridViewTextBoxColumn.HeaderText = "uPassword";
            this.uPasswordDataGridViewTextBoxColumn.Name = "uPasswordDataGridViewTextBoxColumn";
            // 
            // uEmailDataGridViewTextBoxColumn
            // 
            this.uEmailDataGridViewTextBoxColumn.DataPropertyName = "uEmail";
            this.uEmailDataGridViewTextBoxColumn.HeaderText = "uEmail";
            this.uEmailDataGridViewTextBoxColumn.Name = "uEmailDataGridViewTextBoxColumn";
            // 
            // uCatDataGridViewTextBoxColumn
            // 
            this.uCatDataGridViewTextBoxColumn.DataPropertyName = "uCat";
            this.uCatDataGridViewTextBoxColumn.HeaderText = "uCat";
            this.uCatDataGridViewTextBoxColumn.Name = "uCatDataGridViewTextBoxColumn";
            // 
            // uAgeDataGridViewTextBoxColumn
            // 
            this.uAgeDataGridViewTextBoxColumn.DataPropertyName = "uAge";
            this.uAgeDataGridViewTextBoxColumn.HeaderText = "uAge";
            this.uAgeDataGridViewTextBoxColumn.Name = "uAgeDataGridViewTextBoxColumn";
            // 
            // uRecoverEmailDataGridViewTextBoxColumn
            // 
            this.uRecoverEmailDataGridViewTextBoxColumn.DataPropertyName = "uRecoverEmail";
            this.uRecoverEmailDataGridViewTextBoxColumn.HeaderText = "uRecoverEmail";
            this.uRecoverEmailDataGridViewTextBoxColumn.Name = "uRecoverEmailDataGridViewTextBoxColumn";
            // 
            // uPhoneDataGridViewTextBoxColumn
            // 
            this.uPhoneDataGridViewTextBoxColumn.DataPropertyName = "uPhone";
            this.uPhoneDataGridViewTextBoxColumn.HeaderText = "uPhone";
            this.uPhoneDataGridViewTextBoxColumn.Name = "uPhoneDataGridViewTextBoxColumn";
            // 
            // usersBindingSource2
            // 
            this.usersBindingSource2.DataMember = "Users";
            this.usersBindingSource2.DataSource = this.aggeliesDBDataSetBindingSource;
            // 
            // aggeliesDBDataSetBindingSource
            // 
            this.aggeliesDBDataSetBindingSource.DataSource = this.aggeliesDBDataSet;
            this.aggeliesDBDataSetBindingSource.Position = 0;
            // 
            // aggeliesDBDataSet
            // 
            this.aggeliesDBDataSet.DataSetName = "AggeliesDBDataSet";
            this.aggeliesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.aggeliesDBDataSet1;
            // 
            // aggeliesDBDataSet1
            // 
            this.aggeliesDBDataSet1.DataSetName = "AggeliesDBDataSet1";
            this.aggeliesDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 62);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.RosyBrown;
            this.splitContainer1.Panel2.Controls.Add(uAgeLabel);
            this.splitContainer1.Panel2.Controls.Add(this.uAgeTextBox);
            this.splitContainer1.Panel2.Controls.Add(uPhoneLabel);
            this.splitContainer1.Panel2.Controls.Add(this.uPhoneTextBox);
            this.splitContainer1.Panel2.Controls.Add(uRecoverEmailLabel);
            this.splitContainer1.Panel2.Controls.Add(this.uRecoverEmailTextBox);
            this.splitContainer1.Panel2.Controls.Add(uEmailLabel);
            this.splitContainer1.Panel2.Controls.Add(this.uEmailTextBox);
            this.splitContainer1.Panel2.Controls.Add(uPasswordLabel);
            this.splitContainer1.Panel2.Controls.Add(this.uPasswordTextBox);
            this.splitContainer1.Panel2.Controls.Add(uNameLabel);
            this.splitContainer1.Panel2.Controls.Add(this.uNameTextBox);
            this.splitContainer1.Panel2.Controls.Add(lNameLabel);
            this.splitContainer1.Panel2.Controls.Add(this.lNameTextBox);
            this.splitContainer1.Panel2.Controls.Add(fNameLabel);
            this.splitContainer1.Panel2.Controls.Add(this.fNameTextBox);
            this.splitContainer1.Panel2.Controls.Add(userIDLabel);
            this.splitContainer1.Panel2.Controls.Add(this.userIDTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.button6);
            this.splitContainer1.Panel2.Controls.Add(this.delete_button);
            this.splitContainer1.Panel2.Controls.Add(this.Save_button);
            this.splitContainer1.Panel2.Controls.Add(this.next_button);
            this.splitContainer1.Panel2.Controls.Add(this.addnew_button);
            this.splitContainer1.Panel2.Controls.Add(this.previous_button);
            this.splitContainer1.Size = new System.Drawing.Size(1230, 566);
            this.splitContainer1.SplitterDistance = 832;
            this.splitContainer1.TabIndex = 1;
            // 
            // uAgeTextBox
            // 
            this.uAgeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource1, "uAge", true));
            this.uAgeTextBox.Location = new System.Drawing.Point(72, 146);
            this.uAgeTextBox.Name = "uAgeTextBox";
            this.uAgeTextBox.Size = new System.Drawing.Size(100, 20);
            this.uAgeTextBox.TabIndex = 23;
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "Users";
            this.usersBindingSource1.DataSource = this.aggeliesDBDataSet;
            // 
            // uPhoneTextBox
            // 
            this.uPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource1, "uPhone", true));
            this.uPhoneTextBox.Location = new System.Drawing.Point(72, 120);
            this.uPhoneTextBox.Name = "uPhoneTextBox";
            this.uPhoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.uPhoneTextBox.TabIndex = 21;
            // 
            // uRecoverEmailTextBox
            // 
            this.uRecoverEmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource1, "uRecoverEmail", true));
            this.uRecoverEmailTextBox.Location = new System.Drawing.Point(258, 69);
            this.uRecoverEmailTextBox.Name = "uRecoverEmailTextBox";
            this.uRecoverEmailTextBox.Size = new System.Drawing.Size(100, 20);
            this.uRecoverEmailTextBox.TabIndex = 20;
            // 
            // uEmailTextBox
            // 
            this.uEmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource1, "uEmail", true));
            this.uEmailTextBox.Location = new System.Drawing.Point(72, 92);
            this.uEmailTextBox.Name = "uEmailTextBox";
            this.uEmailTextBox.Size = new System.Drawing.Size(100, 20);
            this.uEmailTextBox.TabIndex = 19;
            // 
            // uPasswordTextBox
            // 
            this.uPasswordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource1, "uPassword", true));
            this.uPasswordTextBox.Location = new System.Drawing.Point(258, 40);
            this.uPasswordTextBox.Name = "uPasswordTextBox";
            this.uPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.uPasswordTextBox.TabIndex = 18;
            // 
            // uNameTextBox
            // 
            this.uNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource1, "uName", true));
            this.uNameTextBox.Location = new System.Drawing.Point(258, 14);
            this.uNameTextBox.Name = "uNameTextBox";
            this.uNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.uNameTextBox.TabIndex = 17;
            // 
            // lNameTextBox
            // 
            this.lNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource1, "lName", true));
            this.lNameTextBox.Location = new System.Drawing.Point(72, 66);
            this.lNameTextBox.Name = "lNameTextBox";
            this.lNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lNameTextBox.TabIndex = 16;
            // 
            // fNameTextBox
            // 
            this.fNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource1, "fName", true));
            this.fNameTextBox.Location = new System.Drawing.Point(72, 40);
            this.fNameTextBox.Name = "fNameTextBox";
            this.fNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.fNameTextBox.TabIndex = 15;
            // 
            // userIDTextBox
            // 
            this.userIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource1, "userID", true));
            this.userIDTextBox.Location = new System.Drawing.Point(72, 14);
            this.userIDTextBox.Name = "userIDTextBox";
            this.userIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.userIDTextBox.TabIndex = 14;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(234, 222);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 13;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(153, 222);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(75, 23);
            this.delete_button.TabIndex = 12;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(72, 222);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(75, 23);
            this.Save_button.TabIndex = 11;
            this.Save_button.Text = "Save";
            this.Save_button.UseVisualStyleBackColor = true;
            // 
            // next_button
            // 
            this.next_button.Location = new System.Drawing.Point(234, 193);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(75, 23);
            this.next_button.TabIndex = 10;
            this.next_button.Text = "Next";
            this.next_button.UseVisualStyleBackColor = true;
            // 
            // addnew_button
            // 
            this.addnew_button.Location = new System.Drawing.Point(153, 193);
            this.addnew_button.Name = "addnew_button";
            this.addnew_button.Size = new System.Drawing.Size(75, 23);
            this.addnew_button.TabIndex = 9;
            this.addnew_button.Text = "Add New";
            this.addnew_button.UseVisualStyleBackColor = true;
            // 
            // previous_button
            // 
            this.previous_button.Location = new System.Drawing.Point(72, 193);
            this.previous_button.Name = "previous_button";
            this.previous_button.Size = new System.Drawing.Size(75, 23);
            this.previous_button.TabIndex = 8;
            this.previous_button.Text = "Previous";
            this.previous_button.UseVisualStyleBackColor = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = AdministratorPanel.AggeliesDBDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AdCategoryTableAdapter = null;
            this.tableAdapterManager1.AdsStatusTableAdapter = null;
            this.tableAdapterManager1.AdsTableTableAdapter = this.adsTableTableAdapter;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ImagesTableAdapter = null;
            this.tableAdapterManager1.MediaTableAdapter = null;
            this.tableAdapterManager1.MediaValueTableAdapter = null;
            this.tableAdapterManager1.PropertiesTBTableAdapter = null;
            this.tableAdapterManager1.PropertiesValuesTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = AdministratorPanel.AggeliesDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.UsefulDataTableAdapter = null;
            this.tableAdapterManager1.userCategoriesTableAdapter = null;
            this.tableAdapterManager1.UsersTableAdapter = this.usersTableAdapter1;
            // 
            // adsTableTableAdapter
            // 
            this.adsTableTableAdapter.ClearBeforeFill = true;
            // 
            // adsTableBindingSource
            // 
            this.adsTableBindingSource.DataMember = "AdsTable";
            this.adsTableBindingSource.DataSource = this.aggeliesDBDataSetBindingSource;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 628);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "AdminForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aggeliesDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aggeliesDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aggeliesDBDataSet1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adsTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AggeliesDBDataSet aggeliesDBDataSet;
        private System.Windows.Forms.BindingSource aggeliesDBDataSetBindingSource;
        private AggeliesDBDataSet1 aggeliesDBDataSet1;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private AggeliesDBDataSet1TableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Button previous_button;
        private AggeliesDBDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Button next_button;
        private System.Windows.Forms.Button addnew_button;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private AggeliesDBDataSetTableAdapters.UsersTableAdapter usersTableAdapter1;
        private AggeliesDBDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource usersBindingSource2;
        private AggeliesDBDataSetTableAdapters.AdsTableTableAdapter adsTableTableAdapter;
        private System.Windows.Forms.BindingSource adsTableBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uCatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uRecoverEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox uAgeTextBox;
        private System.Windows.Forms.TextBox uPhoneTextBox;
        private System.Windows.Forms.TextBox uRecoverEmailTextBox;
        private System.Windows.Forms.TextBox uEmailTextBox;
        private System.Windows.Forms.TextBox uPasswordTextBox;
        private System.Windows.Forms.TextBox uNameTextBox;
        private System.Windows.Forms.TextBox lNameTextBox;
        private System.Windows.Forms.TextBox fNameTextBox;
        private System.Windows.Forms.TextBox userIDTextBox;
    }
}