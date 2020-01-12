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
        string connectionString = Properties.Settings.Default.AggeliesDBConnectionString;
        private string imagesLocation;
        public AdminForm()
        {
            var directoryName = Application.StartupPath;
            var path = Directory.GetParent(directoryName).FullName;
            var z = Directory.GetParent(path).FullName;
            imagesLocation = z.ToString() + @"\Resources\images\";
            InitializeComponent();
          
        }

        private void PopulateTreeViewAdsCategory(int parentId, TreeNode parentNode)
        {

            TreeNode childNode;
            AggeliesDBDataSet.AdCategoryDataTable dt = new AggeliesDBDataSet.AdCategoryDataTable();
            BindingSource bs = new BindingSource();
            bs.DataSource = adCategoryTableAdapter.Fill(dt);
            foreach (DataRow dr in dt.Select("[catParent]=" + parentId))
            {
                TreeNode t = new TreeNode();
                t.Text = dr["catID"].ToString() + " - " + dr["catTitle"].ToString();
                t.Name = dr["catID"].ToString();
                t.Tag = dt.Rows.IndexOf(dr);
                if (parentNode == null)
                {
                    treeviewdatabase.Nodes.Add(t);
                    childNode = t;
                }
                else
                {
                    parentNode.Nodes.Add(t);
                    childNode = t;
                }
                PopulateTreeViewAdsCategory(Convert.ToInt32(dr["catID"].ToString()), childNode);
            }
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

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string fileName = "AggeliesDB.accdb";
            string sourcePath = AppDomain.CurrentDomain.BaseDirectory;
            sourcePath = sourcePath.Remove(sourcePath.Length - 1);
            string targetPath = AppDomain.CurrentDomain.BaseDirectory;
            targetPath = targetPath.Remove(targetPath.Length - 29);
            targetPath += @"AppData";
            //Console.WriteLine(fileName);
            //Console.WriteLine(sourcePath);
            //Console.WriteLine(targetPath);
            // Use Path class to manipulate file and directory paths.
            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, fileName);
            //Console.WriteLine(sourceFile);
            //Console.WriteLine(destFile);
            // To copy a file to another location and 
            // overwrite the destination file if it already exists.
            System.IO.File.Copy(sourceFile, destFile, true);
            Application.Exit();
        }


        private void toolSortB_Click(object sender, EventArgs e)
        {
            this.adsTableTableAdapter.FillByOwner(this.aggeliesDBDataSet.AdsTable, Int32.Parse(userIDSortTB.Text.ToString()));
        }

        private void toolDelB_Click(object sender, EventArgs e)
        {
            this.adsTableTableAdapter.DeleteAd(Int32.Parse(adIDTB.Text.ToString()));
            this.adsTableTableAdapter.Fill(this.aggeliesDBDataSet.AdsTable);
        }

        private void toolSaveB_Click(object sender, EventArgs e)
        {
            this.adsTableTableAdapter.Update(this.aggeliesDBDataSet.AdsTable);
            MessageBox.Show("Table updated !");
        }

        private void ShowNodeData(TreeNode nod)
        {
            if (nod.Nodes.Count == 0) { 
            this.adsTableTableAdapter.FillByCategory(this.aggeliesDBDataSet.AdsTable,Int32.Parse(nod.Name));
            }


        }
        private void treeviewdatabase_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
           
            ShowNodeData(e.Node);
        }

        private void AdsLabel_Click(object sender, EventArgs e)
        {
            this.adsTableTableAdapter.Fill(this.aggeliesDBDataSet.AdsTable);
        }

        private void btn_ads_Click(object sender, EventArgs e)
        {
            PopulateTreeViewAdsCategory(0, null);
            AdsMidPanel.BringToFront();
            AdsRightPanel.BringToFront();
        }
    }
}
