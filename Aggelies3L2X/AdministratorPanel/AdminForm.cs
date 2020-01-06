using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;


namespace AdministratorPanel
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

       

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aggeliesDBDataSet5.ParentCategories' table. You can move, or remove it, as needed.
            this.parentCategoriesTableAdapter.Fill(this.aggeliesDBDataSet.ParentCategories);
            // TODO: This line of code loads data into the 'aggeliesDBDataSet4.AdCategory' table. You can move, or remove it, as needed.
            this.adCategoryTableAdapter.Fill(this.aggeliesDBDataSet.AdCategory);
            // TODO: This line of code loads data into the 'aggeliesDBDataSet3.Properties' table. You can move, or remove it, as needed.
            this.propertiesTbAdapter.Fill(this.aggeliesDBDataSet.Properties);
            // TODO: This line of code loads data into the 'aggeliesDBDataSet2.PropertiesTB' table. You can move, or remove it, as needed.
            this.propertiesTBTableAdapter.Fill(this.aggeliesDBDataSet.PropertiesTB);
            // TODO: This line of code loads data into the 'aggeliesDBDataSet2.userCategories' table. You can move, or remove it, as needed.
            this.userCategoriesTableAdapter.Fill(this.aggeliesDBDataSet.userCategories);
            // TODO: This line of code loads data into the 'aggeliesDBDataSet2.AdCategory' table. You can move, or remove it, as needed.
            this.adCategoryTableAdapter.Fill(this.aggeliesDBDataSet.AdCategory);
            // TODO: This line of code loads data into the 'aggeliesDBDataSet1.AdCategory' table. You can move, or remove it, as needed.
            this.adCategoryTableAdapter.Fill(this.aggeliesDBDataSet.AdCategory);
            // TODO: This line of code loads data into the 'aggeliesDBDataSet.AdsTable' table. You can move, or remove it, as needed.
            this.adsTableTableAdapter.Fill(this.aggeliesDBDataSet.AdsTable);
            // TODO: This line of code loads data into the 'aggeliesDBDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter1.Fill(this.aggeliesDBDataSet.Users);
            // TODO: This line of code loads data into the 'aggeliesDBDataSet1.Users' table. You can move, or remove it, as needed.

            lang_combobox.Items.Add("US");
            lang_combobox.Items.Add("GR");
           
            lang_combobox.SelectedIndex = 0;

        }

        private void PropertyAddButton_Click(object sender, EventArgs e)
        {
            this.propertiesTbAdapter.InsertProperties(Int32.Parse(parentCategoriesCMB.SelectedValue.ToString()),propertyNameTBox.Text);
            this.propertiesTbAdapter.Fill(this.aggeliesDBDataSet.Properties);
        }

        private void CategoriesTabC_Click(object sender, EventArgs e)
        {
            AdsCategoriesRightPanel.Visible = false;
            PropertiesRightPanel.Visible = true;
            PropertiesRightPanel.BringToFront();
        }

        private void btn_category_Click(object sender, EventArgs e)
        {
            this.categoriesMidPanel.Visible = true;
            this.categoriesMidPanel.BringToFront();

        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            this.usersMidPanel.Visible = true;
            this.usersMidPanel.BringToFront();
            this.usersRightPanel.Visible = true;
            this.usersRightPanel.BringToFront();
        }

        private void btn_lang_Click(object sender, EventArgs e)
        {
           

        }


        private void ChangeLanguage(string lang)
        {
            foreach (Control c in this.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(AdminForm));
                resources.ApplyResources(c, c.Name, new CultureInfo(lang));
            }
        }

        private void lang_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lang_combobox.SelectedItem.ToString() == "US")
            {
                ChangeLanguage("us");
            }

            else if ((lang_combobox.SelectedItem.ToString() == "GR"))            {
                ChangeLanguage("gr");
            }
        }
    }
}
