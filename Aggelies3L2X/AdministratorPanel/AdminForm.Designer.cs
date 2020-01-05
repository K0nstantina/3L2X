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
            System.Windows.Forms.Label uAgeLabel;
            System.Windows.Forms.Label uPhoneLabel;
            System.Windows.Forms.Label uRecoverEmailLabel;
            System.Windows.Forms.Label uEmailLabel;
            System.Windows.Forms.Label uPasswordLabel;
            System.Windows.Forms.Label uNameLabel;
            System.Windows.Forms.Label lNameLabel;
            System.Windows.Forms.Label fNameLabel;
            System.Windows.Forms.Label useridlabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Menu_panel = new System.Windows.Forms.Panel();
            this.btn_email = new System.Windows.Forms.Button();
            this.btn_profile = new System.Windows.Forms.Button();
            this.btn_ads = new System.Windows.Forms.Button();
            this.btn_users = new System.Windows.Forms.Button();
            this.Statistics = new System.Windows.Forms.Button();
            this.searchlabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Menu_navigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripRefresh = new System.Windows.Forms.ToolStripButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.treeview_panel = new System.Windows.Forms.Panel();
            this.treeviewdatabase = new System.Windows.Forms.TreeView();
            this.categoriesMidPanel = new System.Windows.Forms.Panel();
            this.CategoriesTabC = new System.Windows.Forms.TabControl();
            this.AdsCategoriesTab = new System.Windows.Forms.TabPage();
            this.AdsPropertiesTab = new System.Windows.Forms.TabPage();
            this.propertiesGridView = new System.Windows.Forms.DataGridView();
            this.pIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propertyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propertiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aggeliesDBDataSet = new AdministratorPanel.AggeliesDBDataSet();
            this.usersMidPanel = new System.Windows.Forms.Panel();
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
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.Statuslabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.adCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.aggeliesDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.categoriesRightPanel = new System.Windows.Forms.Panel();
            this.AdsCategoriesRightPanel = new System.Windows.Forms.Panel();
            this.PropertiesRightPanel = new System.Windows.Forms.Panel();
            this.propertyAddButton = new System.Windows.Forms.Button();
            this.parentCategoriesCMB = new System.Windows.Forms.ComboBox();
            this.parentCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.propertyNameTBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addingPropertyL = new System.Windows.Forms.Label();
            this.usersRightPanel = new System.Windows.Forms.Panel();
            this.uAgeTextBox = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_recoveremail = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.txt_firstname = new System.Windows.Forms.TextBox();
            this.txt_userid = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_addnew = new System.Windows.Forms.Button();
            this.btn_previous = new System.Windows.Forms.Button();
            this.adsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter1 = new AdministratorPanel.AggeliesDBDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager1 = new AdministratorPanel.AggeliesDBDataSetTableAdapters.TableAdapterManager();
            this.adsTableTableAdapter = new AdministratorPanel.AggeliesDBDataSetTableAdapters.AdsTableTableAdapter();
            this.usersBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.adCategoryTableAdapter = new AdministratorPanel.AggeliesDBDataSetTableAdapters.AdCategoryTableAdapter();
            this.userCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userCategoriesTableAdapter = new AdministratorPanel.AggeliesDBDataSetTableAdapters.userCategoriesTableAdapter();
            this.adCategoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.propertiesTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.propertiesTBTableAdapter = new AdministratorPanel.AggeliesDBDataSetTableAdapters.PropertiesTBTableAdapter();
            this.propertiesTbAdapter = new AdministratorPanel.AggeliesDBDataSetTableAdapters.PropertiesTbAdapter();
            this.adCategoryBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.parentCategoriesTableAdapter = new AdministratorPanel.AggeliesDBDataSetTableAdapters.ParentCategoriesTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            uAgeLabel = new System.Windows.Forms.Label();
            uPhoneLabel = new System.Windows.Forms.Label();
            uRecoverEmailLabel = new System.Windows.Forms.Label();
            uEmailLabel = new System.Windows.Forms.Label();
            uPasswordLabel = new System.Windows.Forms.Label();
            uNameLabel = new System.Windows.Forms.Label();
            lNameLabel = new System.Windows.Forms.Label();
            fNameLabel = new System.Windows.Forms.Label();
            useridlabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.Menu_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Menu_navigator)).BeginInit();
            this.Menu_navigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.treeview_panel.SuspendLayout();
            this.categoriesMidPanel.SuspendLayout();
            this.CategoriesTabC.SuspendLayout();
            this.AdsPropertiesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aggeliesDBDataSet)).BeginInit();
            this.usersMidPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aggeliesDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.categoriesRightPanel.SuspendLayout();
            this.PropertiesRightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parentCategoriesBindingSource)).BeginInit();
            this.usersRightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adCategoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesTBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adCategoryBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // uAgeLabel
            // 
            uAgeLabel.AutoSize = true;
            uAgeLabel.Location = new System.Drawing.Point(36, 145);
            uAgeLabel.Name = "uAgeLabel";
            uAgeLabel.Size = new System.Drawing.Size(30, 12);
            uAgeLabel.TabIndex = 70;
            uAgeLabel.Text = "Age:";
            // 
            // uPhoneLabel
            // 
            uPhoneLabel.AutoSize = true;
            uPhoneLabel.Location = new System.Drawing.Point(24, 119);
            uPhoneLabel.Name = "uPhoneLabel";
            uPhoneLabel.Size = new System.Drawing.Size(43, 12);
            uPhoneLabel.TabIndex = 68;
            uPhoneLabel.Text = "Phone:";
            // 
            // uRecoverEmailLabel
            // 
            uRecoverEmailLabel.AutoSize = true;
            uRecoverEmailLabel.Location = new System.Drawing.Point(182, 65);
            uRecoverEmailLabel.Name = "uRecoverEmailLabel";
            uRecoverEmailLabel.Size = new System.Drawing.Size(88, 12);
            uRecoverEmailLabel.TabIndex = 66;
            uRecoverEmailLabel.Text = "Recover Email:";
            // 
            // uEmailLabel
            // 
            uEmailLabel.AutoSize = true;
            uEmailLabel.Location = new System.Drawing.Point(31, 91);
            uEmailLabel.Name = "uEmailLabel";
            uEmailLabel.Size = new System.Drawing.Size(38, 12);
            uEmailLabel.TabIndex = 63;
            uEmailLabel.Text = "Email:";
            // 
            // uPasswordLabel
            // 
            uPasswordLabel.AutoSize = true;
            uPasswordLabel.Location = new System.Drawing.Point(202, 39);
            uPasswordLabel.Name = "uPasswordLabel";
            uPasswordLabel.Size = new System.Drawing.Size(62, 12);
            uPasswordLabel.TabIndex = 62;
            uPasswordLabel.Text = "Password:";
            // 
            // uNameLabel
            // 
            uNameLabel.AutoSize = true;
            uNameLabel.Location = new System.Drawing.Point(198, 13);
            uNameLabel.Name = "uNameLabel";
            uNameLabel.Size = new System.Drawing.Size(65, 12);
            uNameLabel.TabIndex = 60;
            uNameLabel.Text = "Username:";
            // 
            // lNameLabel
            // 
            lNameLabel.AutoSize = true;
            lNameLabel.Location = new System.Drawing.Point(5, 65);
            lNameLabel.Name = "lNameLabel";
            lNameLabel.Size = new System.Drawing.Size(67, 12);
            lNameLabel.TabIndex = 58;
            lNameLabel.Text = "Last Name:";
            // 
            // fNameLabel
            // 
            fNameLabel.AutoSize = true;
            fNameLabel.Location = new System.Drawing.Point(6, 39);
            fNameLabel.Name = "fNameLabel";
            fNameLabel.Size = new System.Drawing.Size(68, 12);
            fNameLabel.TabIndex = 56;
            fNameLabel.Text = "First Name:";
            // 
            // useridlabel
            // 
            useridlabel.AutoSize = true;
            useridlabel.Location = new System.Drawing.Point(17, 13);
            useridlabel.Name = "useridlabel";
            useridlabel.Size = new System.Drawing.Size(53, 12);
            useridlabel.TabIndex = 54;
            useridlabel.Text = "Userr ID:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Menu_panel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1230, 71);
            this.panel1.TabIndex = 0;
            // 
            // Menu_panel
            // 
            this.Menu_panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Menu_panel.Controls.Add(this.btn_email);
            this.Menu_panel.Controls.Add(this.btn_profile);
            this.Menu_panel.Controls.Add(this.btn_ads);
            this.Menu_panel.Controls.Add(this.btn_users);
            this.Menu_panel.Controls.Add(this.Statistics);
            this.Menu_panel.Controls.Add(this.searchlabel);
            this.Menu_panel.Controls.Add(this.textBox1);
            this.Menu_panel.Controls.Add(this.Menu_navigator);
            this.Menu_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Menu_panel.Location = new System.Drawing.Point(0, 0);
            this.Menu_panel.Name = "Menu_panel";
            this.Menu_panel.Size = new System.Drawing.Size(1230, 69);
            this.Menu_panel.TabIndex = 0;
            // 
            // btn_email
            // 
            this.btn_email.BackColor = System.Drawing.Color.White;
            this.btn_email.Image = ((System.Drawing.Image)(resources.GetObject("btn_email.Image")));
            this.btn_email.Location = new System.Drawing.Point(227, 30);
            this.btn_email.Name = "btn_email";
            this.btn_email.Size = new System.Drawing.Size(50, 36);
            this.btn_email.TabIndex = 30;
            this.btn_email.UseVisualStyleBackColor = false;
            // 
            // btn_profile
            // 
            this.btn_profile.BackColor = System.Drawing.Color.White;
            this.btn_profile.Image = ((System.Drawing.Image)(resources.GetObject("btn_profile.Image")));
            this.btn_profile.Location = new System.Drawing.Point(171, 30);
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.Size = new System.Drawing.Size(50, 36);
            this.btn_profile.TabIndex = 29;
            this.btn_profile.UseVisualStyleBackColor = false;
            // 
            // btn_ads
            // 
            this.btn_ads.BackColor = System.Drawing.Color.White;
            this.btn_ads.Image = ((System.Drawing.Image)(resources.GetObject("btn_ads.Image")));
            this.btn_ads.Location = new System.Drawing.Point(115, 30);
            this.btn_ads.Name = "btn_ads";
            this.btn_ads.Size = new System.Drawing.Size(50, 36);
            this.btn_ads.TabIndex = 28;
            this.btn_ads.UseVisualStyleBackColor = false;
            // 
            // btn_users
            // 
            this.btn_users.BackColor = System.Drawing.Color.White;
            this.btn_users.Image = ((System.Drawing.Image)(resources.GetObject("btn_users.Image")));
            this.btn_users.Location = new System.Drawing.Point(59, 30);
            this.btn_users.Name = "btn_users";
            this.btn_users.Size = new System.Drawing.Size(50, 36);
            this.btn_users.TabIndex = 27;
            this.btn_users.UseVisualStyleBackColor = false;
            // 
            // Statistics
            // 
            this.Statistics.BackColor = System.Drawing.Color.White;
            this.Statistics.Image = ((System.Drawing.Image)(resources.GetObject("Statistics.Image")));
            this.Statistics.Location = new System.Drawing.Point(3, 30);
            this.Statistics.Name = "Statistics";
            this.Statistics.Size = new System.Drawing.Size(50, 36);
            this.Statistics.TabIndex = 26;
            this.Statistics.UseVisualStyleBackColor = false;
            // 
            // searchlabel
            // 
            this.searchlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchlabel.AutoSize = true;
            this.searchlabel.Location = new System.Drawing.Point(830, 42);
            this.searchlabel.Name = "searchlabel";
            this.searchlabel.Size = new System.Drawing.Size(47, 13);
            this.searchlabel.TabIndex = 24;
            this.searchlabel.Text = "Search :";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(883, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 25;
            // 
            // Menu_navigator
            // 
            this.Menu_navigator.AddNewItem = null;
            this.Menu_navigator.CountItem = this.bindingNavigatorCountItem;
            this.Menu_navigator.DeleteItem = null;
            this.Menu_navigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripButton1,
            this.toolStripRefresh});
            this.Menu_navigator.Location = new System.Drawing.Point(0, 0);
            this.Menu_navigator.MoveFirstItem = null;
            this.Menu_navigator.MoveLastItem = null;
            this.Menu_navigator.MoveNextItem = null;
            this.Menu_navigator.MovePreviousItem = null;
            this.Menu_navigator.Name = "Menu_navigator";
            this.Menu_navigator.PositionItem = null;
            this.Menu_navigator.Size = new System.Drawing.Size(1230, 25);
            this.Menu_navigator.TabIndex = 0;
            this.Menu_navigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.ForeColor = System.Drawing.Color.Red;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(74, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(60, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(98, 22);
            this.toolStripButton1.Text = "Save | Update";
            // 
            // toolStripRefresh
            // 
            this.toolStripRefresh.ForeColor = System.Drawing.SystemColors.InfoText;
            this.toolStripRefresh.Image = ((System.Drawing.Image)(resources.GetObject("toolStripRefresh.Image")));
            this.toolStripRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRefresh.Name = "toolStripRefresh";
            this.toolStripRefresh.Size = new System.Drawing.Size(66, 22);
            this.toolStripRefresh.Text = "Refresh";
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
            this.splitContainer2.Panel1.Controls.Add(this.treeview_panel);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.SandyBrown;
            this.splitContainer2.Panel2.Controls.Add(this.categoriesMidPanel);
            this.splitContainer2.Panel2.Controls.Add(this.usersMidPanel);
            this.splitContainer2.Size = new System.Drawing.Size(829, 428);
            this.splitContainer2.SplitterDistance = 200;
            this.splitContainer2.TabIndex = 0;
            // 
            // treeview_panel
            // 
            this.treeview_panel.Controls.Add(this.treeviewdatabase);
            this.treeview_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeview_panel.Location = new System.Drawing.Point(0, 0);
            this.treeview_panel.Name = "treeview_panel";
            this.treeview_panel.Size = new System.Drawing.Size(200, 428);
            this.treeview_panel.TabIndex = 0;
            // 
            // treeviewdatabase
            // 
            this.treeviewdatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeviewdatabase.Location = new System.Drawing.Point(0, 0);
            this.treeviewdatabase.Name = "treeviewdatabase";
            this.treeviewdatabase.Size = new System.Drawing.Size(200, 428);
            this.treeviewdatabase.TabIndex = 0;
            // 
            // categoriesMidPanel
            // 
            this.categoriesMidPanel.BackColor = System.Drawing.SystemColors.Control;
            this.categoriesMidPanel.Controls.Add(this.CategoriesTabC);
            this.categoriesMidPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoriesMidPanel.Location = new System.Drawing.Point(0, 0);
            this.categoriesMidPanel.Name = "categoriesMidPanel";
            this.categoriesMidPanel.Size = new System.Drawing.Size(625, 428);
            this.categoriesMidPanel.TabIndex = 3;
            // 
            // CategoriesTabC
            // 
            this.CategoriesTabC.Controls.Add(this.AdsCategoriesTab);
            this.CategoriesTabC.Controls.Add(this.AdsPropertiesTab);
            this.CategoriesTabC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoriesTabC.Location = new System.Drawing.Point(0, 0);
            this.CategoriesTabC.Name = "CategoriesTabC";
            this.CategoriesTabC.SelectedIndex = 0;
            this.CategoriesTabC.Size = new System.Drawing.Size(625, 428);
            this.CategoriesTabC.TabIndex = 0;
            this.CategoriesTabC.Click += new System.EventHandler(this.CategoriesTabC_Click);
            // 
            // AdsCategoriesTab
            // 
            this.AdsCategoriesTab.Location = new System.Drawing.Point(4, 22);
            this.AdsCategoriesTab.Name = "AdsCategoriesTab";
            this.AdsCategoriesTab.Padding = new System.Windows.Forms.Padding(3);
            this.AdsCategoriesTab.Size = new System.Drawing.Size(617, 402);
            this.AdsCategoriesTab.TabIndex = 0;
            this.AdsCategoriesTab.Text = "Ads Categories";
            this.AdsCategoriesTab.UseVisualStyleBackColor = true;
            // 
            // AdsPropertiesTab
            // 
            this.AdsPropertiesTab.Controls.Add(this.propertiesGridView);
            this.AdsPropertiesTab.Location = new System.Drawing.Point(4, 22);
            this.AdsPropertiesTab.Name = "AdsPropertiesTab";
            this.AdsPropertiesTab.Padding = new System.Windows.Forms.Padding(3);
            this.AdsPropertiesTab.Size = new System.Drawing.Size(617, 402);
            this.AdsPropertiesTab.TabIndex = 1;
            this.AdsPropertiesTab.Text = "Ads Properties";
            this.AdsPropertiesTab.UseVisualStyleBackColor = true;
            // 
            // propertiesGridView
            // 
            this.propertiesGridView.AutoGenerateColumns = false;
            this.propertiesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.propertiesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pIDDataGridViewTextBoxColumn,
            this.propertyDataGridViewTextBoxColumn,
            this.catTitleDataGridViewTextBoxColumn});
            this.propertiesGridView.DataSource = this.propertiesBindingSource;
            this.propertiesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertiesGridView.Location = new System.Drawing.Point(3, 3);
            this.propertiesGridView.Name = "propertiesGridView";
            this.propertiesGridView.Size = new System.Drawing.Size(611, 396);
            this.propertiesGridView.TabIndex = 0;
            // 
            // pIDDataGridViewTextBoxColumn
            // 
            this.pIDDataGridViewTextBoxColumn.DataPropertyName = "pID";
            this.pIDDataGridViewTextBoxColumn.HeaderText = "pID";
            this.pIDDataGridViewTextBoxColumn.Name = "pIDDataGridViewTextBoxColumn";
            // 
            // propertyDataGridViewTextBoxColumn
            // 
            this.propertyDataGridViewTextBoxColumn.DataPropertyName = "property";
            this.propertyDataGridViewTextBoxColumn.HeaderText = "property";
            this.propertyDataGridViewTextBoxColumn.Name = "propertyDataGridViewTextBoxColumn";
            // 
            // catTitleDataGridViewTextBoxColumn
            // 
            this.catTitleDataGridViewTextBoxColumn.DataPropertyName = "catTitle";
            this.catTitleDataGridViewTextBoxColumn.HeaderText = "catTitle";
            this.catTitleDataGridViewTextBoxColumn.Name = "catTitleDataGridViewTextBoxColumn";
            // 
            // propertiesBindingSource
            // 
            this.propertiesBindingSource.DataMember = "Properties";
            this.propertiesBindingSource.DataSource = this.aggeliesDBDataSet;
            // 
            // aggeliesDBDataSet
            // 
            this.aggeliesDBDataSet.DataSetName = "AggeliesDBDataSet";
            this.aggeliesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersMidPanel
            // 
            this.usersMidPanel.BackColor = System.Drawing.SystemColors.Control;
            this.usersMidPanel.Controls.Add(this.dataGridView1);
            this.usersMidPanel.Controls.Add(this.statusStrip);
            this.usersMidPanel.Location = new System.Drawing.Point(0, 0);
            this.usersMidPanel.Name = "usersMidPanel";
            this.usersMidPanel.Size = new System.Drawing.Size(625, 428);
            this.usersMidPanel.TabIndex = 0;
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
            this.dataGridView1.DataSource = this.usersBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(625, 406);
            this.dataGridView1.TabIndex = 2;
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
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "Users";
            this.usersBindingSource1.DataSource = this.aggeliesDBDataSet;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Statuslabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 406);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(625, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "Status";
            // 
            // Statuslabel
            // 
            this.Statuslabel.BackColor = System.Drawing.Color.MistyRose;
            this.Statuslabel.Name = "Statuslabel";
            this.Statuslabel.Size = new System.Drawing.Size(39, 17);
            this.Statuslabel.Text = "Status";
            // 
            // adCategoryBindingSource
            // 
            this.adCategoryBindingSource.DataMember = "AdCategory";
            this.adCategoryBindingSource.DataSource = this.aggeliesDBDataSet;
            // 
            // aggeliesDBDataSetBindingSource
            // 
            this.aggeliesDBDataSetBindingSource.DataSource = this.aggeliesDBDataSet;
            this.aggeliesDBDataSetBindingSource.Position = 0;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.aggeliesDBDataSetBindingSource;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 71);
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
            this.splitContainer1.Panel2.Controls.Add(this.categoriesRightPanel);
            this.splitContainer1.Panel2.Controls.Add(this.usersRightPanel);
            this.splitContainer1.Size = new System.Drawing.Size(1230, 428);
            this.splitContainer1.SplitterDistance = 829;
            this.splitContainer1.TabIndex = 1;
            // 
            // categoriesRightPanel
            // 
            this.categoriesRightPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.categoriesRightPanel.Controls.Add(this.PropertiesRightPanel);
            this.categoriesRightPanel.Controls.Add(this.AdsCategoriesRightPanel);
            this.categoriesRightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoriesRightPanel.Location = new System.Drawing.Point(0, 0);
            this.categoriesRightPanel.Name = "categoriesRightPanel";
            this.categoriesRightPanel.Size = new System.Drawing.Size(397, 428);
            this.categoriesRightPanel.TabIndex = 72;
            // 
            // AdsCategoriesRightPanel
            // 
            this.AdsCategoriesRightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdsCategoriesRightPanel.Location = new System.Drawing.Point(0, 0);
            this.AdsCategoriesRightPanel.Name = "AdsCategoriesRightPanel";
            this.AdsCategoriesRightPanel.Size = new System.Drawing.Size(397, 428);
            this.AdsCategoriesRightPanel.TabIndex = 4;
            // 
            // PropertiesRightPanel
            // 
            this.PropertiesRightPanel.Controls.Add(this.propertyAddButton);
            this.PropertiesRightPanel.Controls.Add(this.parentCategoriesCMB);
            this.PropertiesRightPanel.Controls.Add(this.propertyNameTBox);
            this.PropertiesRightPanel.Controls.Add(this.label3);
            this.PropertiesRightPanel.Controls.Add(this.label2);
            this.PropertiesRightPanel.Controls.Add(this.label1);
            this.PropertiesRightPanel.Controls.Add(this.addingPropertyL);
            this.PropertiesRightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PropertiesRightPanel.Location = new System.Drawing.Point(0, 0);
            this.PropertiesRightPanel.Name = "PropertiesRightPanel";
            this.PropertiesRightPanel.Size = new System.Drawing.Size(397, 428);
            this.PropertiesRightPanel.TabIndex = 0;
            this.PropertiesRightPanel.Visible = false;
            // 
            // propertyAddButton
            // 
            this.propertyAddButton.Location = new System.Drawing.Point(12, 138);
            this.propertyAddButton.Name = "propertyAddButton";
            this.propertyAddButton.Size = new System.Drawing.Size(75, 23);
            this.propertyAddButton.TabIndex = 3;
            this.propertyAddButton.Text = "Add";
            this.propertyAddButton.UseVisualStyleBackColor = true;
            this.propertyAddButton.Click += new System.EventHandler(this.propertyAddButton_Click);
            // 
            // parentCategoriesCMB
            // 
            this.parentCategoriesCMB.DataSource = this.parentCategoriesBindingSource;
            this.parentCategoriesCMB.DisplayMember = "catTitle";
            this.parentCategoriesCMB.FormattingEnabled = true;
            this.parentCategoriesCMB.Location = new System.Drawing.Point(12, 108);
            this.parentCategoriesCMB.Name = "parentCategoriesCMB";
            this.parentCategoriesCMB.Size = new System.Drawing.Size(139, 21);
            this.parentCategoriesCMB.TabIndex = 2;
            this.parentCategoriesCMB.ValueMember = "catID";
            // 
            // parentCategoriesBindingSource
            // 
            this.parentCategoriesBindingSource.DataMember = "ParentCategories";
            this.parentCategoriesBindingSource.DataSource = this.aggeliesDBDataSet;
            // 
            // propertyNameTBox
            // 
            this.propertyNameTBox.Location = new System.Drawing.Point(93, 59);
            this.propertyNameTBox.Name = "propertyNameTBox";
            this.propertyNameTBox.Size = new System.Drawing.Size(170, 20);
            this.propertyNameTBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Which category do you want to assign this property?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Property Name";
            // 
            // addingPropertyL
            // 
            this.addingPropertyL.AutoSize = true;
            this.addingPropertyL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addingPropertyL.Location = new System.Drawing.Point(9, 32);
            this.addingPropertyL.Name = "addingPropertyL";
            this.addingPropertyL.Size = new System.Drawing.Size(158, 19);
            this.addingPropertyL.TabIndex = 0;
            this.addingPropertyL.Text = "Add a new property";
            // 
            // usersRightPanel
            // 
            this.usersRightPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.usersRightPanel.Controls.Add(uAgeLabel);
            this.usersRightPanel.Controls.Add(this.uAgeTextBox);
            this.usersRightPanel.Controls.Add(uPhoneLabel);
            this.usersRightPanel.Controls.Add(this.txt_phone);
            this.usersRightPanel.Controls.Add(uRecoverEmailLabel);
            this.usersRightPanel.Controls.Add(this.txt_recoveremail);
            this.usersRightPanel.Controls.Add(uEmailLabel);
            this.usersRightPanel.Controls.Add(this.txt_email);
            this.usersRightPanel.Controls.Add(uPasswordLabel);
            this.usersRightPanel.Controls.Add(this.txt_password);
            this.usersRightPanel.Controls.Add(uNameLabel);
            this.usersRightPanel.Controls.Add(this.txt_username);
            this.usersRightPanel.Controls.Add(lNameLabel);
            this.usersRightPanel.Controls.Add(this.txt_lastname);
            this.usersRightPanel.Controls.Add(fNameLabel);
            this.usersRightPanel.Controls.Add(this.txt_firstname);
            this.usersRightPanel.Controls.Add(useridlabel);
            this.usersRightPanel.Controls.Add(this.txt_userid);
            this.usersRightPanel.Controls.Add(this.btn_update);
            this.usersRightPanel.Controls.Add(this.btn_delete);
            this.usersRightPanel.Controls.Add(this.btn_save);
            this.usersRightPanel.Controls.Add(this.btn_next);
            this.usersRightPanel.Controls.Add(this.btn_addnew);
            this.usersRightPanel.Controls.Add(this.btn_previous);
            this.usersRightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersRightPanel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersRightPanel.Location = new System.Drawing.Point(0, 0);
            this.usersRightPanel.Name = "usersRightPanel";
            this.usersRightPanel.Size = new System.Drawing.Size(397, 428);
            this.usersRightPanel.TabIndex = 0;
            // 
            // uAgeTextBox
            // 
            this.uAgeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource1, "uAge", true));
            this.uAgeTextBox.Location = new System.Drawing.Point(76, 138);
            this.uAgeTextBox.Name = "uAgeTextBox";
            this.uAgeTextBox.Size = new System.Drawing.Size(100, 20);
            this.uAgeTextBox.TabIndex = 71;
            // 
            // txt_phone
            // 
            this.txt_phone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource1, "uPhone", true));
            this.txt_phone.Location = new System.Drawing.Point(76, 112);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(100, 20);
            this.txt_phone.TabIndex = 69;
            // 
            // txt_recoveremail
            // 
            this.txt_recoveremail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource1, "uRecoverEmail", true));
            this.txt_recoveremail.Location = new System.Drawing.Point(270, 59);
            this.txt_recoveremail.Name = "txt_recoveremail";
            this.txt_recoveremail.Size = new System.Drawing.Size(100, 20);
            this.txt_recoveremail.TabIndex = 67;
            // 
            // txt_email
            // 
            this.txt_email.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource1, "uEmail", true));
            this.txt_email.Location = new System.Drawing.Point(76, 84);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(100, 20);
            this.txt_email.TabIndex = 65;
            // 
            // txt_password
            // 
            this.txt_password.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource1, "uPassword", true));
            this.txt_password.Location = new System.Drawing.Point(270, 33);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(100, 20);
            this.txt_password.TabIndex = 64;
            // 
            // txt_username
            // 
            this.txt_username.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource1, "uName", true));
            this.txt_username.Location = new System.Drawing.Point(270, 7);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(100, 20);
            this.txt_username.TabIndex = 61;
            // 
            // txt_lastname
            // 
            this.txt_lastname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource1, "lName", true));
            this.txt_lastname.Location = new System.Drawing.Point(76, 58);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(100, 20);
            this.txt_lastname.TabIndex = 59;
            // 
            // txt_firstname
            // 
            this.txt_firstname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource1, "fName", true));
            this.txt_firstname.Font = new System.Drawing.Font("Arial Nova", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_firstname.Location = new System.Drawing.Point(76, 32);
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.Size = new System.Drawing.Size(100, 21);
            this.txt_firstname.TabIndex = 57;
            // 
            // txt_userid
            // 
            this.txt_userid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource1, "userID", true));
            this.txt_userid.Location = new System.Drawing.Point(76, 6);
            this.txt_userid.Name = "txt_userid";
            this.txt_userid.Size = new System.Drawing.Size(100, 20);
            this.txt_userid.TabIndex = 55;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(238, 382);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 53;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(157, 382);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 52;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(76, 382);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 51;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(238, 353);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 50;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            // 
            // btn_addnew
            // 
            this.btn_addnew.Location = new System.Drawing.Point(157, 353);
            this.btn_addnew.Name = "btn_addnew";
            this.btn_addnew.Size = new System.Drawing.Size(75, 23);
            this.btn_addnew.TabIndex = 49;
            this.btn_addnew.Text = "Add New";
            this.btn_addnew.UseVisualStyleBackColor = true;
            // 
            // btn_previous
            // 
            this.btn_previous.Location = new System.Drawing.Point(76, 353);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(75, 23);
            this.btn_previous.TabIndex = 48;
            this.btn_previous.Text = "Previous";
            this.btn_previous.UseVisualStyleBackColor = true;
            // 
            // adsTableBindingSource
            // 
            this.adsTableBindingSource.DataMember = "AdsTable";
            this.adsTableBindingSource.DataSource = this.aggeliesDBDataSetBindingSource;
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
            this.tableAdapterManager1.ParentCategoriesTableAdapter = null;
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
            // usersBindingSource3
            // 
            this.usersBindingSource3.DataMember = "Users";
            this.usersBindingSource3.DataSource = this.aggeliesDBDataSet;
            // 
            // adCategoryTableAdapter
            // 
            this.adCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // userCategoriesBindingSource
            // 
            this.userCategoriesBindingSource.DataMember = "userCategories";
            this.userCategoriesBindingSource.DataSource = this.aggeliesDBDataSet;
            // 
            // userCategoriesTableAdapter
            // 
            this.userCategoriesTableAdapter.ClearBeforeFill = true;
            // 
            // adCategoryBindingSource1
            // 
            this.adCategoryBindingSource1.DataMember = "AdCategory";
            this.adCategoryBindingSource1.DataSource = this.aggeliesDBDataSet;
            // 
            // propertiesTBBindingSource
            // 
            this.propertiesTBBindingSource.DataMember = "PropertiesTB";
            this.propertiesTBBindingSource.DataSource = this.aggeliesDBDataSet;
            // 
            // propertiesTBTableAdapter
            // 
            this.propertiesTBTableAdapter.ClearBeforeFill = true;
            // 
            // propertiesTbAdapter
            // 
            this.propertiesTbAdapter.ClearBeforeFill = true;
            // 
            // adCategoryBindingSource2
            // 
            this.adCategoryBindingSource2.DataMember = "AdCategory";
            this.adCategoryBindingSource2.DataSource = this.aggeliesDBDataSet;
            // 
            // parentCategoriesTableAdapter
            // 
            this.parentCategoriesTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit the selected property";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 499);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.Text = "Administrator Form";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panel1.ResumeLayout(false);
            this.Menu_panel.ResumeLayout(false);
            this.Menu_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Menu_navigator)).EndInit();
            this.Menu_navigator.ResumeLayout(false);
            this.Menu_navigator.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.treeview_panel.ResumeLayout(false);
            this.categoriesMidPanel.ResumeLayout(false);
            this.CategoriesTabC.ResumeLayout(false);
            this.AdsPropertiesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.propertiesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aggeliesDBDataSet)).EndInit();
            this.usersMidPanel.ResumeLayout(false);
            this.usersMidPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aggeliesDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.categoriesRightPanel.ResumeLayout(false);
            this.PropertiesRightPanel.ResumeLayout(false);
            this.PropertiesRightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parentCategoriesBindingSource)).EndInit();
            this.usersRightPanel.ResumeLayout(false);
            this.usersRightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adCategoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesTBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adCategoryBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Menu_panel;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private AggeliesDBDataSet aggeliesDBDataSet;
        private System.Windows.Forms.BindingSource aggeliesDBDataSetBindingSource;
       
        private System.Windows.Forms.BindingSource usersBindingSource;
  
       
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private AggeliesDBDataSetTableAdapters.UsersTableAdapter usersTableAdapter1;
        private AggeliesDBDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource usersBindingSource2;
        private AggeliesDBDataSetTableAdapters.AdsTableTableAdapter adsTableTableAdapter;
        private System.Windows.Forms.BindingSource adsTableBindingSource;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripRefresh;
        public System.Windows.Forms.BindingNavigator Menu_navigator;
        private System.Windows.Forms.Label searchlabel;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button btn_email;
        private System.Windows.Forms.Button btn_profile;
        private System.Windows.Forms.Button btn_ads;
        private System.Windows.Forms.Button btn_users;
        private System.Windows.Forms.Button Statistics;
        private System.Windows.Forms.Panel treeview_panel;
        private System.Windows.Forms.Panel usersMidPanel;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel Statuslabel;
        private System.Windows.Forms.Panel usersRightPanel;
        private System.Windows.Forms.TextBox uAgeTextBox;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_recoveremail;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_lastname;
        private System.Windows.Forms.TextBox txt_firstname;
        private System.Windows.Forms.TextBox txt_userid;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_addnew;
        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.BindingSource usersBindingSource3;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.Panel categoriesMidPanel;
        private System.Windows.Forms.Panel categoriesRightPanel;
       
        private System.Windows.Forms.BindingSource adCategoryBindingSource;
        private AggeliesDBDataSetTableAdapters.AdCategoryTableAdapter adCategoryTableAdapter;
        private System.Windows.Forms.TreeView treeviewdatabase;
        private System.Windows.Forms.BindingSource userCategoriesBindingSource;
        private AggeliesDBDataSetTableAdapters.userCategoriesTableAdapter userCategoriesTableAdapter;
        private System.Windows.Forms.TabControl CategoriesTabC;
        private System.Windows.Forms.TabPage AdsCategoriesTab;
        private System.Windows.Forms.BindingSource adCategoryBindingSource1;
        private System.Windows.Forms.TabPage AdsPropertiesTab;
        private System.Windows.Forms.BindingSource propertiesTBBindingSource;
        private AggeliesDBDataSetTableAdapters.PropertiesTBTableAdapter propertiesTBTableAdapter;
        private System.Windows.Forms.DataGridView propertiesGridView;
       
        private System.Windows.Forms.BindingSource propertiesBindingSource;
        private AggeliesDBDataSetTableAdapters.PropertiesTbAdapter propertiesTbAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn propertyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel PropertiesRightPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label addingPropertyL;
        private System.Windows.Forms.ComboBox parentCategoriesCMB;
        private System.Windows.Forms.TextBox propertyNameTBox;
    
        private System.Windows.Forms.BindingSource adCategoryBindingSource2;
      
        private System.Windows.Forms.BindingSource parentCategoriesBindingSource;
        private AggeliesDBDataSetTableAdapters.ParentCategoriesTableAdapter parentCategoriesTableAdapter;
        private System.Windows.Forms.Button propertyAddButton;
        private System.Windows.Forms.Panel AdsCategoriesRightPanel;
        private System.Windows.Forms.Label label1;
    }
}