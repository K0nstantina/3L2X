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
using System.IO;

namespace AdministratorPanel
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            var directoryName = Application.StartupPath;
            Console.WriteLine(directoryName);
            var path = Directory.GetParent(directoryName).FullName;
            Console.WriteLine(path);
            var z = Directory.GetParent(path).FullName;
            Console.WriteLine(z);
            InitializeComponent();
          
        }

       

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aggeliesDBDataSet1.AdCategory' table. You can move, or remove it, as needed.
            this.adCategoryTableAdapter.Fill(this.aggeliesDBDataSet1.AdCategory);
            // TODO: This line of code loads data into the 'aggeliesDBDataSet.AdsTable' table. You can move, or remove it, as needed.
            this.adsTableTableAdapter.Fill(this.aggeliesDBDataSet.AdsTable);



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

      

        private void btn_category_Click(object sender, EventArgs e)
        {
            this.categoriesMidPanel.Visible = true;
            this.categoriesMidPanel.BringToFront();
            this.categoriesRightPanel.Visible = true;
            this.categoriesRightPanel.BringToFront();


        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            this.usersMidPanel.Visible = true;
            this.usersMidPanel.BringToFront();
            this.usersRightPanel.Visible = true;
            this.usersRightPanel.BringToFront();
        }

      


       

        

        private void updatePropertyB_Click(object sender, EventArgs e)
        {
            this.propertiesTbAdapter.UpdateProperty(pNameUpdateTBox.Text,Int32.Parse(allCategoriesCBox.SelectedValue.ToString()), Convert.ToInt32(propertyID.Text));
            this.propertiesTbAdapter.Fill(this.aggeliesDBDataSet.Properties);
        }

        private void AddCategoryB_Click(object sender, EventArgs e)
        {
            this.adCategoryTableAdapter.Insert(addCatNameTBox.Text, Int32.Parse(addCatNameCBox.SelectedValue.ToString()));
            this.adCategoryTableAdapter.Fill(this.aggeliesDBDataSet.AdCategory);
        }

        private void updateCatB_Click(object sender, EventArgs e)
        {
            this.adCategoryTableAdapter.UpdateAdCategory(updateCatTBox.Text, Int32.Parse(updateCatCBox.SelectedValue.ToString()),Convert.ToInt32(updateCatIDL.Text));
            this.adCategoryTableAdapter.Fill(this.aggeliesDBDataSet.AdCategory);
        }


        private void CategoriesTabC_Selected(object sender, TabControlEventArgs e)
        {
            if (CategoriesTabC.SelectedTab.Name == "AdsCategoriesTab")
            {
                PropertiesRightPanel.Visible = false;
                PropertiesRightPanel.SendToBack();
                AdsCategoriesRightPanel.Visible = true;
                AdsCategoriesRightPanel.BringToFront();
            }
            else if(CategoriesTabC.SelectedTab.Name == "AdsPropertiesTab")
            {
                AdsCategoriesRightPanel.Visible = false;
                AdsCategoriesRightPanel.SendToBack();
                PropertiesRightPanel.Visible = true;
                PropertiesRightPanel.BringToFront();
            }
        }
    }
}
