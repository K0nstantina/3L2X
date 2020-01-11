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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            System.Windows.Forms.Label uPhoneLabel;
            System.Windows.Forms.Label uRecoverEmailLabel;
            System.Windows.Forms.Label uEmailLabel;
            System.Windows.Forms.Label uPasswordLabel;
            System.Windows.Forms.Label uNameLabel;
            System.Windows.Forms.Label lNameLabel;
            System.Windows.Forms.Label fNameLabel;
            System.Windows.Forms.Label useridlabel;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.treeview_panel = new System.Windows.Forms.Panel();
            this.treeviewdatabase = new System.Windows.Forms.TreeView();
            this.categoriesMidPanel = new System.Windows.Forms.Panel();
            this.CategoriesTabC = new System.Windows.Forms.TabControl();
            this.AdsCategoriesTab = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.catIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catTitleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catParentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aggeliesDBDataSet = new AdministratorPanel.AggeliesDBDataSet();
            this.AdsPropertiesTab = new System.Windows.Forms.TabPage();
            this.propertiesGridView = new System.Windows.Forms.DataGridView();
            this.pIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propertyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propertiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.categoriesRightPanel = new System.Windows.Forms.Panel();
            this.AdsCategoriesRightPanel = new System.Windows.Forms.Panel();
            this.updateCatB = new System.Windows.Forms.Button();
            this.AddCategoryB = new System.Windows.Forms.Button();
            this.updateCatTBox = new System.Windows.Forms.TextBox();
            this.addCatNameTBox = new System.Windows.Forms.TextBox();
            this.updateCatCBox = new System.Windows.Forms.ComboBox();
            this.parentCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addCatNameCBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.updateCatIDL = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.catNameL = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.categoriesRightPanelHeader = new System.Windows.Forms.Label();
            this.PropertiesRightPanel = new System.Windows.Forms.Panel();
            this.propertyID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.updatePropertyB = new System.Windows.Forms.Button();
            this.propertyAddButton = new System.Windows.Forms.Button();
            this.allCategoriesCBox = new System.Windows.Forms.ComboBox();
            this.parentCategoriesCMB = new System.Windows.Forms.ComboBox();
            this.pNameUpdateTBox = new System.Windows.Forms.TextBox();
            this.propertyNameTBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.whichcatLabel = new System.Windows.Forms.Label();
            this.properynameLabel = new System.Windows.Forms.Label();
            this.editpropertyLabel = new System.Windows.Forms.Label();
            this.addingPropertyL = new System.Windows.Forms.Label();
            this.usersRightPanel = new System.Windows.Forms.Panel();
            this.checkbox_blacklist = new System.Windows.Forms.CheckBox();
            this.txt_age = new System.Windows.Forms.TextBox();
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.Menu_panel = new System.Windows.Forms.Panel();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_category = new System.Windows.Forms.Button();
            this.btn_email = new System.Windows.Forms.Button();
            this.btn_profile = new System.Windows.Forms.Button();
            this.btn_ads = new System.Windows.Forms.Button();
            this.btn_users = new System.Windows.Forms.Button();
            this.Statistics = new System.Windows.Forms.Button();
            this.searchlabel = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
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
            this.usersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.aggeliesDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.adCategoryAdsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adCategoryAdsTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.adCategoryAdsTableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.aggeliesDBDataSet1 = new AdministratorPanel.AggeliesDBDataSet();
            this.adCategoryBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            uAgeLabel = new System.Windows.Forms.Label();
            uPhoneLabel = new System.Windows.Forms.Label();
            uRecoverEmailLabel = new System.Windows.Forms.Label();
            uEmailLabel = new System.Windows.Forms.Label();
            uPasswordLabel = new System.Windows.Forms.Label();
            uNameLabel = new System.Windows.Forms.Label();
            lNameLabel = new System.Windows.Forms.Label();
            fNameLabel = new System.Windows.Forms.Label();
            useridlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.treeview_panel.SuspendLayout();
            this.categoriesMidPanel.SuspendLayout();
            this.CategoriesTabC.SuspendLayout();
            this.AdsCategoriesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aggeliesDBDataSet)).BeginInit();
            this.AdsPropertiesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesBindingSource)).BeginInit();
            this.usersMidPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.categoriesRightPanel.SuspendLayout();
            this.AdsCategoriesRightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parentCategoriesBindingSource)).BeginInit();
            this.PropertiesRightPanel.SuspendLayout();
            this.usersRightPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.Menu_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Menu_navigator)).BeginInit();
            this.Menu_navigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aggeliesDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adCategoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesTBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adCategoryBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adCategoryAdsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adCategoryAdsTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adCategoryAdsTableBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aggeliesDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adCategoryBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // uAgeLabel
            // 
            resources.ApplyResources(uAgeLabel, "uAgeLabel");
            uAgeLabel.Name = "uAgeLabel";
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            resources.ApplyResources(this.splitContainer1.Panel2, "splitContainer1.Panel2");
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.RosyBrown;
            this.splitContainer1.Panel2.Controls.Add(this.categoriesRightPanel);
            this.splitContainer1.Panel2.Controls.Add(this.usersRightPanel);
            // 
            // splitContainer2
            // 
            resources.ApplyResources(this.splitContainer2, "splitContainer2");
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
            // 
            // treeview_panel
            // 
            this.treeview_panel.Controls.Add(this.treeviewdatabase);
            resources.ApplyResources(this.treeview_panel, "treeview_panel");
            this.treeview_panel.Name = "treeview_panel";
            // 
            // treeviewdatabase
            // 
            resources.ApplyResources(this.treeviewdatabase, "treeviewdatabase");
            this.treeviewdatabase.Name = "treeviewdatabase";
            // 
            // categoriesMidPanel
            // 
            this.categoriesMidPanel.BackColor = System.Drawing.SystemColors.Control;
            this.categoriesMidPanel.Controls.Add(this.CategoriesTabC);
            resources.ApplyResources(this.categoriesMidPanel, "categoriesMidPanel");
            this.categoriesMidPanel.Name = "categoriesMidPanel";
            // 
            // CategoriesTabC
            // 
            this.CategoriesTabC.Controls.Add(this.AdsCategoriesTab);
            this.CategoriesTabC.Controls.Add(this.AdsPropertiesTab);
            resources.ApplyResources(this.CategoriesTabC, "CategoriesTabC");
            this.CategoriesTabC.Name = "CategoriesTabC";
            this.CategoriesTabC.SelectedIndex = 0;
            this.CategoriesTabC.Selected += new System.Windows.Forms.TabControlEventHandler(this.CategoriesTabC_Selected);
            // 
            // AdsCategoriesTab
            // 
            this.AdsCategoriesTab.Controls.Add(this.dataGridView2);
            resources.ApplyResources(this.AdsCategoriesTab, "AdsCategoriesTab");
            this.AdsCategoriesTab.Name = "AdsCategoriesTab";
            this.AdsCategoriesTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.catIDDataGridViewTextBoxColumn,
            this.catTitleDataGridViewTextBoxColumn1,
            this.catParentDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.adCategoryBindingSource;
            resources.ApplyResources(this.dataGridView2, "dataGridView2");
            this.dataGridView2.Name = "dataGridView2";
            // 
            // catIDDataGridViewTextBoxColumn
            // 
            this.catIDDataGridViewTextBoxColumn.DataPropertyName = "catID";
            resources.ApplyResources(this.catIDDataGridViewTextBoxColumn, "catIDDataGridViewTextBoxColumn");
            this.catIDDataGridViewTextBoxColumn.Name = "catIDDataGridViewTextBoxColumn";
            // 
            // catTitleDataGridViewTextBoxColumn1
            // 
            this.catTitleDataGridViewTextBoxColumn1.DataPropertyName = "catTitle";
            resources.ApplyResources(this.catTitleDataGridViewTextBoxColumn1, "catTitleDataGridViewTextBoxColumn1");
            this.catTitleDataGridViewTextBoxColumn1.Name = "catTitleDataGridViewTextBoxColumn1";
            // 
            // catParentDataGridViewTextBoxColumn
            // 
            this.catParentDataGridViewTextBoxColumn.DataPropertyName = "catParent";
            resources.ApplyResources(this.catParentDataGridViewTextBoxColumn, "catParentDataGridViewTextBoxColumn");
            this.catParentDataGridViewTextBoxColumn.Name = "catParentDataGridViewTextBoxColumn";
            // 
            // adCategoryBindingSource
            // 
            this.adCategoryBindingSource.DataMember = "AdCategory";
            this.adCategoryBindingSource.DataSource = this.aggeliesDBDataSet;
            // 
            // aggeliesDBDataSet
            // 
            this.aggeliesDBDataSet.DataSetName = "AggeliesDBDataSet";
            this.aggeliesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AdsPropertiesTab
            // 
            this.AdsPropertiesTab.Controls.Add(this.propertiesGridView);
            resources.ApplyResources(this.AdsPropertiesTab, "AdsPropertiesTab");
            this.AdsPropertiesTab.Name = "AdsPropertiesTab";
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
            resources.ApplyResources(this.propertiesGridView, "propertiesGridView");
            this.propertiesGridView.Name = "propertiesGridView";
            // 
            // pIDDataGridViewTextBoxColumn
            // 
            this.pIDDataGridViewTextBoxColumn.DataPropertyName = "pID";
            resources.ApplyResources(this.pIDDataGridViewTextBoxColumn, "pIDDataGridViewTextBoxColumn");
            this.pIDDataGridViewTextBoxColumn.Name = "pIDDataGridViewTextBoxColumn";
            // 
            // propertyDataGridViewTextBoxColumn
            // 
            this.propertyDataGridViewTextBoxColumn.DataPropertyName = "property";
            resources.ApplyResources(this.propertyDataGridViewTextBoxColumn, "propertyDataGridViewTextBoxColumn");
            this.propertyDataGridViewTextBoxColumn.Name = "propertyDataGridViewTextBoxColumn";
            // 
            // catTitleDataGridViewTextBoxColumn
            // 
            this.catTitleDataGridViewTextBoxColumn.DataPropertyName = "catTitle";
            resources.ApplyResources(this.catTitleDataGridViewTextBoxColumn, "catTitleDataGridViewTextBoxColumn");
            this.catTitleDataGridViewTextBoxColumn.Name = "catTitleDataGridViewTextBoxColumn";
            // 
            // propertiesBindingSource
            // 
            this.propertiesBindingSource.DataMember = "Properties";
            this.propertiesBindingSource.DataSource = this.aggeliesDBDataSet;
            // 
            // usersMidPanel
            // 
            this.usersMidPanel.BackColor = System.Drawing.SystemColors.Control;
            this.usersMidPanel.Controls.Add(this.dataGridView1);
            this.usersMidPanel.Controls.Add(this.statusStrip);
            resources.ApplyResources(this.usersMidPanel, "usersMidPanel");
            this.usersMidPanel.Name = "usersMidPanel";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
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
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "userID";
            resources.ApplyResources(this.userIDDataGridViewTextBoxColumn, "userIDDataGridViewTextBoxColumn");
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            // 
            // fNameDataGridViewTextBoxColumn
            // 
            this.fNameDataGridViewTextBoxColumn.DataPropertyName = "fName";
            resources.ApplyResources(this.fNameDataGridViewTextBoxColumn, "fNameDataGridViewTextBoxColumn");
            this.fNameDataGridViewTextBoxColumn.Name = "fNameDataGridViewTextBoxColumn";
            // 
            // lNameDataGridViewTextBoxColumn
            // 
            this.lNameDataGridViewTextBoxColumn.DataPropertyName = "lName";
            resources.ApplyResources(this.lNameDataGridViewTextBoxColumn, "lNameDataGridViewTextBoxColumn");
            this.lNameDataGridViewTextBoxColumn.Name = "lNameDataGridViewTextBoxColumn";
            // 
            // uNameDataGridViewTextBoxColumn
            // 
            this.uNameDataGridViewTextBoxColumn.DataPropertyName = "uName";
            resources.ApplyResources(this.uNameDataGridViewTextBoxColumn, "uNameDataGridViewTextBoxColumn");
            this.uNameDataGridViewTextBoxColumn.Name = "uNameDataGridViewTextBoxColumn";
            // 
            // uPasswordDataGridViewTextBoxColumn
            // 
            this.uPasswordDataGridViewTextBoxColumn.DataPropertyName = "uPassword";
            resources.ApplyResources(this.uPasswordDataGridViewTextBoxColumn, "uPasswordDataGridViewTextBoxColumn");
            this.uPasswordDataGridViewTextBoxColumn.Name = "uPasswordDataGridViewTextBoxColumn";
            // 
            // uEmailDataGridViewTextBoxColumn
            // 
            this.uEmailDataGridViewTextBoxColumn.DataPropertyName = "uEmail";
            resources.ApplyResources(this.uEmailDataGridViewTextBoxColumn, "uEmailDataGridViewTextBoxColumn");
            this.uEmailDataGridViewTextBoxColumn.Name = "uEmailDataGridViewTextBoxColumn";
            // 
            // uCatDataGridViewTextBoxColumn
            // 
            this.uCatDataGridViewTextBoxColumn.DataPropertyName = "uCat";
            resources.ApplyResources(this.uCatDataGridViewTextBoxColumn, "uCatDataGridViewTextBoxColumn");
            this.uCatDataGridViewTextBoxColumn.Name = "uCatDataGridViewTextBoxColumn";
            // 
            // uAgeDataGridViewTextBoxColumn
            // 
            this.uAgeDataGridViewTextBoxColumn.DataPropertyName = "uAge";
            resources.ApplyResources(this.uAgeDataGridViewTextBoxColumn, "uAgeDataGridViewTextBoxColumn");
            this.uAgeDataGridViewTextBoxColumn.Name = "uAgeDataGridViewTextBoxColumn";
            // 
            // uRecoverEmailDataGridViewTextBoxColumn
            // 
            this.uRecoverEmailDataGridViewTextBoxColumn.DataPropertyName = "uRecoverEmail";
            resources.ApplyResources(this.uRecoverEmailDataGridViewTextBoxColumn, "uRecoverEmailDataGridViewTextBoxColumn");
            this.uRecoverEmailDataGridViewTextBoxColumn.Name = "uRecoverEmailDataGridViewTextBoxColumn";
            // 
            // uPhoneDataGridViewTextBoxColumn
            // 
            this.uPhoneDataGridViewTextBoxColumn.DataPropertyName = "uPhone";
            resources.ApplyResources(this.uPhoneDataGridViewTextBoxColumn, "uPhoneDataGridViewTextBoxColumn");
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
            resources.ApplyResources(this.statusStrip, "statusStrip");
            this.statusStrip.Name = "statusStrip";
            // 
            // Statuslabel
            // 
            this.Statuslabel.BackColor = System.Drawing.Color.MistyRose;
            this.Statuslabel.Name = "Statuslabel";
            resources.ApplyResources(this.Statuslabel, "Statuslabel");
            // 
            // categoriesRightPanel
            // 
            this.categoriesRightPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.categoriesRightPanel.Controls.Add(this.AdsCategoriesRightPanel);
            this.categoriesRightPanel.Controls.Add(this.PropertiesRightPanel);
            resources.ApplyResources(this.categoriesRightPanel, "categoriesRightPanel");
            this.categoriesRightPanel.Name = "categoriesRightPanel";
            // 
            // AdsCategoriesRightPanel
            // 
            this.AdsCategoriesRightPanel.Controls.Add(this.updateCatB);
            this.AdsCategoriesRightPanel.Controls.Add(this.AddCategoryB);
            this.AdsCategoriesRightPanel.Controls.Add(this.updateCatTBox);
            this.AdsCategoriesRightPanel.Controls.Add(this.addCatNameTBox);
            this.AdsCategoriesRightPanel.Controls.Add(this.updateCatCBox);
            this.AdsCategoriesRightPanel.Controls.Add(this.addCatNameCBox);
            this.AdsCategoriesRightPanel.Controls.Add(this.label7);
            this.AdsCategoriesRightPanel.Controls.Add(this.label6);
            this.AdsCategoriesRightPanel.Controls.Add(this.updateCatIDL);
            this.AdsCategoriesRightPanel.Controls.Add(this.label8);
            this.AdsCategoriesRightPanel.Controls.Add(this.label5);
            this.AdsCategoriesRightPanel.Controls.Add(this.catNameL);
            this.AdsCategoriesRightPanel.Controls.Add(this.label4);
            this.AdsCategoriesRightPanel.Controls.Add(this.categoriesRightPanelHeader);
            resources.ApplyResources(this.AdsCategoriesRightPanel, "AdsCategoriesRightPanel");
            this.AdsCategoriesRightPanel.Name = "AdsCategoriesRightPanel";
            // 
            // updateCatB
            // 
            resources.ApplyResources(this.updateCatB, "updateCatB");
            this.updateCatB.Name = "updateCatB";
            this.updateCatB.UseVisualStyleBackColor = true;
            this.updateCatB.Click += new System.EventHandler(this.updateCatB_Click);
            // 
            // AddCategoryB
            // 
            resources.ApplyResources(this.AddCategoryB, "AddCategoryB");
            this.AddCategoryB.Name = "AddCategoryB";
            this.AddCategoryB.UseVisualStyleBackColor = true;
            this.AddCategoryB.Click += new System.EventHandler(this.AddCategoryB_Click);
            // 
            // updateCatTBox
            // 
            this.updateCatTBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adCategoryBindingSource, "catTitle", true));
            resources.ApplyResources(this.updateCatTBox, "updateCatTBox");
            this.updateCatTBox.Name = "updateCatTBox";
            // 
            // addCatNameTBox
            // 
            this.addCatNameTBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adCategoryBindingSource, "catTitle", true));
            resources.ApplyResources(this.addCatNameTBox, "addCatNameTBox");
            this.addCatNameTBox.Name = "addCatNameTBox";
            // 
            // updateCatCBox
            // 
            this.updateCatCBox.DataSource = this.parentCategoriesBindingSource;
            this.updateCatCBox.DisplayMember = "catTitle";
            this.updateCatCBox.FormattingEnabled = true;
            resources.ApplyResources(this.updateCatCBox, "updateCatCBox");
            this.updateCatCBox.Name = "updateCatCBox";
            this.updateCatCBox.ValueMember = "catID";
            // 
            // parentCategoriesBindingSource
            // 
            this.parentCategoriesBindingSource.DataMember = "ParentCategories";
            this.parentCategoriesBindingSource.DataSource = this.aggeliesDBDataSet;
            // 
            // addCatNameCBox
            // 
            this.addCatNameCBox.DataSource = this.parentCategoriesBindingSource;
            this.addCatNameCBox.DisplayMember = "catTitle";
            this.addCatNameCBox.FormattingEnabled = true;
            resources.ApplyResources(this.addCatNameCBox, "addCatNameCBox");
            this.addCatNameCBox.Name = "addCatNameCBox";
            this.addCatNameCBox.ValueMember = "catID";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // updateCatIDL
            // 
            resources.ApplyResources(this.updateCatIDL, "updateCatIDL");
            this.updateCatIDL.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adCategoryBindingSource, "catID", true));
            this.updateCatIDL.Name = "updateCatIDL";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // catNameL
            // 
            resources.ApplyResources(this.catNameL, "catNameL");
            this.catNameL.Name = "catNameL";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // categoriesRightPanelHeader
            // 
            resources.ApplyResources(this.categoriesRightPanelHeader, "categoriesRightPanelHeader");
            this.categoriesRightPanelHeader.Name = "categoriesRightPanelHeader";
            // 
            // PropertiesRightPanel
            // 
            this.PropertiesRightPanel.Controls.Add(this.propertyID);
            this.PropertiesRightPanel.Controls.Add(this.label3);
            this.PropertiesRightPanel.Controls.Add(this.updatePropertyB);
            this.PropertiesRightPanel.Controls.Add(this.propertyAddButton);
            this.PropertiesRightPanel.Controls.Add(this.allCategoriesCBox);
            this.PropertiesRightPanel.Controls.Add(this.parentCategoriesCMB);
            this.PropertiesRightPanel.Controls.Add(this.pNameUpdateTBox);
            this.PropertiesRightPanel.Controls.Add(this.propertyNameTBox);
            this.PropertiesRightPanel.Controls.Add(this.label1);
            this.PropertiesRightPanel.Controls.Add(this.label2);
            this.PropertiesRightPanel.Controls.Add(this.whichcatLabel);
            this.PropertiesRightPanel.Controls.Add(this.properynameLabel);
            this.PropertiesRightPanel.Controls.Add(this.editpropertyLabel);
            this.PropertiesRightPanel.Controls.Add(this.addingPropertyL);
            resources.ApplyResources(this.PropertiesRightPanel, "PropertiesRightPanel");
            this.PropertiesRightPanel.Name = "PropertiesRightPanel";
            // 
            // propertyID
            // 
            resources.ApplyResources(this.propertyID, "propertyID");
            this.propertyID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propertiesBindingSource, "pID", true));
            this.propertyID.Name = "propertyID";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // updatePropertyB
            // 
            resources.ApplyResources(this.updatePropertyB, "updatePropertyB");
            this.updatePropertyB.Name = "updatePropertyB";
            this.updatePropertyB.UseVisualStyleBackColor = true;
            this.updatePropertyB.Click += new System.EventHandler(this.updatePropertyB_Click);
            // 
            // propertyAddButton
            // 
            resources.ApplyResources(this.propertyAddButton, "propertyAddButton");
            this.propertyAddButton.Name = "propertyAddButton";
            this.propertyAddButton.UseVisualStyleBackColor = true;
            this.propertyAddButton.Click += new System.EventHandler(this.PropertyAddButton_Click);
            // 
            // allCategoriesCBox
            // 
            this.allCategoriesCBox.DataSource = this.parentCategoriesBindingSource;
            this.allCategoriesCBox.DisplayMember = "catTitle";
            this.allCategoriesCBox.FormattingEnabled = true;
            resources.ApplyResources(this.allCategoriesCBox, "allCategoriesCBox");
            this.allCategoriesCBox.Name = "allCategoriesCBox";
            this.allCategoriesCBox.ValueMember = "catID";
            // 
            // parentCategoriesCMB
            // 
            this.parentCategoriesCMB.DataSource = this.parentCategoriesBindingSource;
            this.parentCategoriesCMB.DisplayMember = "catTitle";
            this.parentCategoriesCMB.FormattingEnabled = true;
            resources.ApplyResources(this.parentCategoriesCMB, "parentCategoriesCMB");
            this.parentCategoriesCMB.Name = "parentCategoriesCMB";
            this.parentCategoriesCMB.ValueMember = "catID";
            // 
            // pNameUpdateTBox
            // 
            this.pNameUpdateTBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propertiesBindingSource, "property", true));
            resources.ApplyResources(this.pNameUpdateTBox, "pNameUpdateTBox");
            this.pNameUpdateTBox.Name = "pNameUpdateTBox";
            // 
            // propertyNameTBox
            // 
            resources.ApplyResources(this.propertyNameTBox, "propertyNameTBox");
            this.propertyNameTBox.Name = "propertyNameTBox";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // whichcatLabel
            // 
            resources.ApplyResources(this.whichcatLabel, "whichcatLabel");
            this.whichcatLabel.Name = "whichcatLabel";
            // 
            // properynameLabel
            // 
            resources.ApplyResources(this.properynameLabel, "properynameLabel");
            this.properynameLabel.Name = "properynameLabel";
            // 
            // editpropertyLabel
            // 
            resources.ApplyResources(this.editpropertyLabel, "editpropertyLabel");
            this.editpropertyLabel.Name = "editpropertyLabel";
            // 
            // addingPropertyL
            // 
            resources.ApplyResources(this.addingPropertyL, "addingPropertyL");
            this.addingPropertyL.Name = "addingPropertyL";
            // 
            // usersRightPanel
            // 
            this.usersRightPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.usersRightPanel.Controls.Add(this.checkbox_blacklist);
            this.usersRightPanel.Controls.Add(uAgeLabel);
            this.usersRightPanel.Controls.Add(this.txt_age);
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
            resources.ApplyResources(this.usersRightPanel, "usersRightPanel");
            this.usersRightPanel.Name = "usersRightPanel";
            // 
            // checkbox_blacklist
            // 
            resources.ApplyResources(this.checkbox_blacklist, "checkbox_blacklist");
            this.checkbox_blacklist.Name = "checkbox_blacklist";
            this.checkbox_blacklist.UseVisualStyleBackColor = true;
            // 
            // txt_age
            // 
            this.txt_age.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource1, "uAge", true));
            resources.ApplyResources(this.txt_age, "txt_age");
            this.txt_age.Name = "txt_age";
            // 
            // uPhoneLabel
            // 
            resources.ApplyResources(uPhoneLabel, "uPhoneLabel");
            uPhoneLabel.Name = "uPhoneLabel";
            // 
            // txt_phone
            // 
            this.txt_phone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource1, "uPhone", true));
            resources.ApplyResources(this.txt_phone, "txt_phone");
            this.txt_phone.Name = "txt_phone";
            // 
            // uRecoverEmailLabel
            // 
            resources.ApplyResources(uRecoverEmailLabel, "uRecoverEmailLabel");
            uRecoverEmailLabel.Name = "uRecoverEmailLabel";
            // 
            // txt_recoveremail
            // 
            this.txt_recoveremail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource1, "uRecoverEmail", true));
            resources.ApplyResources(this.txt_recoveremail, "txt_recoveremail");
            this.txt_recoveremail.Name = "txt_recoveremail";
            // 
            // uEmailLabel
            // 
            resources.ApplyResources(uEmailLabel, "uEmailLabel");
            uEmailLabel.Name = "uEmailLabel";
            // 
            // txt_email
            // 
            this.txt_email.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource1, "uEmail", true));
            resources.ApplyResources(this.txt_email, "txt_email");
            this.txt_email.Name = "txt_email";
            // 
            // uPasswordLabel
            // 
            resources.ApplyResources(uPasswordLabel, "uPasswordLabel");
            uPasswordLabel.Name = "uPasswordLabel";
            // 
            // txt_password
            // 
            this.txt_password.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource1, "uPassword", true));
            resources.ApplyResources(this.txt_password, "txt_password");
            this.txt_password.Name = "txt_password";
            // 
            // uNameLabel
            // 
            resources.ApplyResources(uNameLabel, "uNameLabel");
            uNameLabel.Name = "uNameLabel";
            // 
            // txt_username
            // 
            this.txt_username.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource1, "uName", true));
            resources.ApplyResources(this.txt_username, "txt_username");
            this.txt_username.Name = "txt_username";
            // 
            // lNameLabel
            // 
            resources.ApplyResources(lNameLabel, "lNameLabel");
            lNameLabel.Name = "lNameLabel";
            // 
            // txt_lastname
            // 
            this.txt_lastname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource1, "lName", true));
            resources.ApplyResources(this.txt_lastname, "txt_lastname");
            this.txt_lastname.Name = "txt_lastname";
            // 
            // fNameLabel
            // 
            resources.ApplyResources(fNameLabel, "fNameLabel");
            fNameLabel.Name = "fNameLabel";
            // 
            // txt_firstname
            // 
            this.txt_firstname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource1, "fName", true));
            resources.ApplyResources(this.txt_firstname, "txt_firstname");
            this.txt_firstname.Name = "txt_firstname";
            // 
            // useridlabel
            // 
            resources.ApplyResources(useridlabel, "useridlabel");
            useridlabel.Name = "useridlabel";
            // 
            // txt_userid
            // 
            this.txt_userid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource1, "userID", true));
            resources.ApplyResources(this.txt_userid, "txt_userid");
            this.txt_userid.Name = "txt_userid";
            // 
            // btn_update
            // 
            resources.ApplyResources(this.btn_update, "btn_update");
            this.btn_update.Name = "btn_update";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            resources.ApplyResources(this.btn_delete, "btn_delete");
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            resources.ApplyResources(this.btn_save, "btn_save");
            this.btn_save.Name = "btn_save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_next
            // 
            resources.ApplyResources(this.btn_next, "btn_next");
            this.btn_next.Name = "btn_next";
            this.btn_next.UseVisualStyleBackColor = true;
            // 
            // btn_addnew
            // 
            resources.ApplyResources(this.btn_addnew, "btn_addnew");
            this.btn_addnew.Name = "btn_addnew";
            this.btn_addnew.UseVisualStyleBackColor = true;
            // 
            // btn_previous
            // 
            resources.ApplyResources(this.btn_previous, "btn_previous");
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.UseVisualStyleBackColor = true;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.Menu_panel);
            resources.ApplyResources(this.topPanel, "topPanel");
            this.topPanel.Name = "topPanel";
            // 
            // Menu_panel
            // 
            this.Menu_panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Menu_panel.Controls.Add(this.btn_settings);
            this.Menu_panel.Controls.Add(this.btn_category);
            this.Menu_panel.Controls.Add(this.btn_email);
            this.Menu_panel.Controls.Add(this.btn_profile);
            this.Menu_panel.Controls.Add(this.btn_ads);
            this.Menu_panel.Controls.Add(this.btn_users);
            this.Menu_panel.Controls.Add(this.Statistics);
            this.Menu_panel.Controls.Add(this.searchlabel);
            this.Menu_panel.Controls.Add(this.txt_search);
            this.Menu_panel.Controls.Add(this.Menu_navigator);
            resources.ApplyResources(this.Menu_panel, "Menu_panel");
            this.Menu_panel.Name = "Menu_panel";
            // 
            // btn_settings
            // 
            this.btn_settings.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btn_settings, "btn_settings");
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.UseVisualStyleBackColor = false;
            // 
            // btn_category
            // 
            this.btn_category.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btn_category, "btn_category");
            this.btn_category.Name = "btn_category";
            this.btn_category.UseVisualStyleBackColor = false;
            this.btn_category.Click += new System.EventHandler(this.btn_category_Click);
            // 
            // btn_email
            // 
            this.btn_email.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btn_email, "btn_email");
            this.btn_email.Name = "btn_email";
            this.btn_email.UseVisualStyleBackColor = false;
            // 
            // btn_profile
            // 
            this.btn_profile.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btn_profile, "btn_profile");
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.UseVisualStyleBackColor = false;
            // 
            // btn_ads
            // 
            this.btn_ads.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btn_ads, "btn_ads");
            this.btn_ads.Name = "btn_ads";
            this.btn_ads.UseVisualStyleBackColor = false;
            // 
            // btn_users
            // 
            this.btn_users.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btn_users, "btn_users");
            this.btn_users.Name = "btn_users";
            this.btn_users.UseVisualStyleBackColor = false;
            this.btn_users.Click += new System.EventHandler(this.btn_users_Click);
            // 
            // Statistics
            // 
            this.Statistics.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.Statistics, "Statistics");
            this.Statistics.Name = "Statistics";
            this.Statistics.UseVisualStyleBackColor = false;
            // 
            // searchlabel
            // 
            resources.ApplyResources(this.searchlabel, "searchlabel");
            this.searchlabel.Name = "searchlabel";
            // 
            // txt_search
            // 
            resources.ApplyResources(this.txt_search, "txt_search");
            this.txt_search.Name = "txt_search";
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
            resources.ApplyResources(this.Menu_navigator, "Menu_navigator");
            this.Menu_navigator.MoveFirstItem = null;
            this.Menu_navigator.MoveLastItem = null;
            this.Menu_navigator.MoveNextItem = null;
            this.Menu_navigator.MovePreviousItem = null;
            this.Menu_navigator.Name = "Menu_navigator";
            this.Menu_navigator.PositionItem = null;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            resources.ApplyResources(this.bindingNavigatorCountItem, "bindingNavigatorCountItem");
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMoveFirstItem, "bindingNavigatorMoveFirstItem");
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMovePreviousItem, "bindingNavigatorMovePreviousItem");
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            resources.ApplyResources(this.bindingNavigatorSeparator, "bindingNavigatorSeparator");
            // 
            // bindingNavigatorPositionItem
            // 
            resources.ApplyResources(this.bindingNavigatorPositionItem, "bindingNavigatorPositionItem");
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            resources.ApplyResources(this.bindingNavigatorSeparator1, "bindingNavigatorSeparator1");
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMoveNextItem, "bindingNavigatorMoveNextItem");
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMoveLastItem, "bindingNavigatorMoveLastItem");
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            resources.ApplyResources(this.bindingNavigatorSeparator2, "bindingNavigatorSeparator2");
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.ForeColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.bindingNavigatorAddNewItem, "bindingNavigatorAddNewItem");
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.ForeColor = System.Drawing.Color.DarkGoldenrod;
            resources.ApplyResources(this.bindingNavigatorDeleteItem, "bindingNavigatorDeleteItem");
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.ForeColor = System.Drawing.SystemColors.InfoText;
            resources.ApplyResources(this.toolStripButton1, "toolStripButton1");
            this.toolStripButton1.Name = "toolStripButton1";
            // 
            // toolStripRefresh
            // 
            this.toolStripRefresh.ForeColor = System.Drawing.SystemColors.InfoText;
            resources.ApplyResources(this.toolStripRefresh, "toolStripRefresh");
            this.toolStripRefresh.Name = "toolStripRefresh";
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
            // adCategoryAdsTableBindingSource
            // 
            this.adCategoryAdsTableBindingSource.DataMember = "adCategoryAdsTable";
            this.adCategoryAdsTableBindingSource.DataSource = this.adCategoryBindingSource;
            // 
            // adCategoryAdsTableBindingSource1
            // 
            this.adCategoryAdsTableBindingSource1.DataMember = "adCategoryAdsTable";
            this.adCategoryAdsTableBindingSource1.DataSource = this.adCategoryBindingSource;
            // 
            // adCategoryAdsTableBindingSource2
            // 
            this.adCategoryAdsTableBindingSource2.DataMember = "adCategoryAdsTable";
            this.adCategoryAdsTableBindingSource2.DataSource = this.adCategoryBindingSource;
            // 
            // aggeliesDBDataSet1
            // 
            this.aggeliesDBDataSet1.DataSetName = "AggeliesDBDataSet";
            this.aggeliesDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adCategoryBindingSource3
            // 
            this.adCategoryBindingSource3.DataMember = "AdCategory";
            this.adCategoryBindingSource3.DataSource = this.aggeliesDBDataSet1;
            // 
            // AdminForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.topPanel);
            this.Name = "AdminForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.treeview_panel.ResumeLayout(false);
            this.categoriesMidPanel.ResumeLayout(false);
            this.CategoriesTabC.ResumeLayout(false);
            this.AdsCategoriesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aggeliesDBDataSet)).EndInit();
            this.AdsPropertiesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.propertiesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesBindingSource)).EndInit();
            this.usersMidPanel.ResumeLayout(false);
            this.usersMidPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.categoriesRightPanel.ResumeLayout(false);
            this.AdsCategoriesRightPanel.ResumeLayout(false);
            this.AdsCategoriesRightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parentCategoriesBindingSource)).EndInit();
            this.PropertiesRightPanel.ResumeLayout(false);
            this.PropertiesRightPanel.PerformLayout();
            this.usersRightPanel.ResumeLayout(false);
            this.usersRightPanel.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.Menu_panel.ResumeLayout(false);
            this.Menu_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Menu_navigator)).EndInit();
            this.Menu_navigator.ResumeLayout(false);
            this.Menu_navigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aggeliesDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adCategoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesTBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adCategoryBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adCategoryAdsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adCategoryAdsTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adCategoryAdsTableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aggeliesDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adCategoryBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
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
        private System.Windows.Forms.TextBox txt_search;
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
        private System.Windows.Forms.TextBox txt_age;
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
        private System.Windows.Forms.Label whichcatLabel;
        private System.Windows.Forms.Label properynameLabel;
        private System.Windows.Forms.Label addingPropertyL;
        private System.Windows.Forms.ComboBox parentCategoriesCMB;
        private System.Windows.Forms.TextBox propertyNameTBox;
    
        private System.Windows.Forms.BindingSource adCategoryBindingSource2;
      
        private System.Windows.Forms.BindingSource parentCategoriesBindingSource;
        private AggeliesDBDataSetTableAdapters.ParentCategoriesTableAdapter parentCategoriesTableAdapter;
        private System.Windows.Forms.Button propertyAddButton;
        private System.Windows.Forms.Panel AdsCategoriesRightPanel;

        private System.Windows.Forms.Label editpropertyLabel;

        private System.Windows.Forms.Button btn_settings;
        public System.Windows.Forms.Button btn_category;
        private System.Windows.Forms.CheckBox checkbox_blacklist;
        private System.Windows.Forms.TextBox pNameUpdateTBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updatePropertyB;
        private System.Windows.Forms.ComboBox allCategoriesCBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource adCategoryAdsTableBindingSource;
        private System.Windows.Forms.BindingSource adCategoryAdsTableBindingSource1;
        private System.Windows.Forms.BindingSource adCategoryAdsTableBindingSource2;
        private System.Windows.Forms.Label propertyID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private AggeliesDBDataSet aggeliesDBDataSet1;
        private System.Windows.Forms.BindingSource adCategoryBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn catIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catTitleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn catParentDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox addCatNameTBox;
        private System.Windows.Forms.ComboBox addCatNameCBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label catNameL;
        private System.Windows.Forms.Label categoriesRightPanelHeader;
        private System.Windows.Forms.Button AddCategoryB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button updateCatB;
        private System.Windows.Forms.TextBox updateCatTBox;
        private System.Windows.Forms.ComboBox updateCatCBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label updateCatIDL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
    }
}