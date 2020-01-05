using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
