using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserApplication.AggeliesDBDataSetTableAdapters;

namespace UserApplication
{
    public partial class trestingTreeView : Form
    {
        public trestingTreeView()
        {
            InitializeComponent();
        }
        private void PopulateTreeView(int parentId, TreeNode parentNode)
        {

            TreeNode childNode;
            AggeliesDBDataSet.AdCategoryDataTable dt = new AggeliesDBDataSet.AdCategoryDataTable();
            BindingSource bs = new BindingSource();
            bs.DataSource = adCategoryTableAdapter1.Fill(dt);
            foreach (DataRow dr in dt.Select("[catParent]=" + parentId))
            {
                TreeNode t = new TreeNode();
                t.Text = dr["catID"].ToString() + " - " + dr["catTitle"].ToString();
                t.Name = dr["catID"].ToString();
                t.Tag = dt.Rows.IndexOf(dr);
                if (parentNode == null)
                {
                    treeView1.Nodes.Add(t);
                    childNode = t;
                }
                else
                {
                    parentNode.Nodes.Add(t);
                    childNode = t;
                }
                PopulateTreeView(Convert.ToInt32(dr["catID"].ToString()), childNode);
            }
        }

        private void trestingTreeView_Load(object sender, EventArgs e)
        {
            PopulateTreeView(0, null);
        }
    }
}
