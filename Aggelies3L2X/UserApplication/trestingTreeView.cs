using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using UserApplication.AggeliesDBDataSetTableAdapters;

namespace UserApplication
{
    public partial class trestingTreeView : Form
    {
        string connectionString = Properties.Settings.Default.AggeliesDBConnectionString;
        private string imagesLocation;
        public trestingTreeView()
        {
            InitializeComponent();
            var directoryName = Application.StartupPath;
            //Console.WriteLine(directoryName);
            var path = Directory.GetParent(directoryName).FullName;
            //Console.WriteLine(path);
            var z = Directory.GetParent(path).FullName;
            imagesLocation = z.ToString()+@"\Resources\images\";

            Console.WriteLine(z);
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
                t.Text = dr["catTitle"].ToString();
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

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ShowNodeData(e.Node);
        }
        private void ShowNodeData(TreeNode nod)
        {
            int catID = int.Parse(nod.Name.ToString());
            string selectQuery = "SELECT adID, adTitle, Published FROM AdsTable WHERE Published=true AND adCategory=" + catID.ToString();
            OleDbConnection connection = new OleDbConnection(connectionString);
            OleDbCommand command = new OleDbCommand(selectQuery, connection);
            OleDbDataReader reader;

            resetValues();

            connection.Open();
            // Execute reader.
            reader = command.ExecuteReader();
            // If user exists.
            while (reader.Read())
            {
                listBox1.Items.Add(reader["adTitle"].ToString());                       
            }
            if (listBox1.Items.Count > 0)
            {
                listBox1.SelectedIndex = 0;
            }
            else
            {
                listBox1.Items.Add("Select a sub category");
            }
            
            reader.Close();
            connection.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectQuery = "SELECT adID, adTitle, adDesc, media, Published FROM AdsTable WHERE Published=true AND adTitle='" + listBox1.SelectedItem.ToString()+"'";
            OleDbConnection connection = new OleDbConnection(connectionString);
            OleDbCommand command = new OleDbCommand(selectQuery, connection);
            OleDbDataReader reader;

            connection.Open();
            // Execute reader.
            reader = command.ExecuteReader();
            // If user exists.
            if (reader.HasRows)
            {
                reader.Read();
                displayAd1.adTitle.Text = reader["adTitle"].ToString();
                displayAd1.adDesc.Text = reader["adDesc"].ToString();
                if (reader["media"].ToString()!="")
                {
                    displayAd1.adImage.Source = new BitmapImage(new Uri(imagesLocation + reader["media"].ToString()));
                }
                textBox1.Text = reader["adID"].ToString();
                textBox2.Text = reader["adTitle"].ToString();
                reader.Close();
            }
            connection.Close();
        }
        private void resetValues()
        {
            listBox1.Items.Clear();
            displayAd1.adTitle.Text = "";
            displayAd1.adDesc.Text = "";
            displayAd1.adImage.Source = null;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }
    }
}
