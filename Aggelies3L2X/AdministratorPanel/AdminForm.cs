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
            PopulateAdsCategories(1, null);
        }

        private void PopulateAdsCategories(int parentId,TreeNode parentNode)
        {
            AggeliesDBDataSet.AdCategoryDataTable catTable = new AggeliesDBDataSet.AdCategoryDataTable();
            using (AggeliesDBDataSetTableAdapters.AdCategoryTableAdapter categories = new AggeliesDBDataSetTableAdapters.AdCategoryTableAdapter())
            {
                categories.Fill(catTable);
            }
            TreeNode childNode;
            foreach (DataRow dr in catTable.Select("[catParent]=" + parentId))
            {
                TreeNode t = new TreeNode
                {
                    Text = catTable.catIDColumn.ToString() + " - " + catTable.catTitleColumn.ToString(),
                    Name = catTable.catIDColumn.ToString(),
                    Tag = catTable.Rows.IndexOf(dr)
                };
                if (parentNode == null)
                {
                    filtersTree.Nodes.Add(t);
                    childNode = t;
                }
                else
                {
                    parentNode.Nodes.Add(t);
                    childNode = t;
                }
                Console.WriteLine(catTable.catIDColumn);
               // PopulateAdsCategories(Convert.ToInt32(catTable.catIDColumn.ToString()), childNode);
            }
        }
    }
}
