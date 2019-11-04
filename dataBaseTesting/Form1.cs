using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataBaseTesting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSampleDataSet.houses' table. You can move, or remove it, as needed.
            this.housesTableAdapter.Fill(this.dataSampleDataSet.houses);

        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            string conString = Properties.Settings.Default.dataSampleConnectionString;
            OleDbConnection cnn = new OleDbConnection(conString);
            cnn.Open();
            this.housesTableAdapter.Insert("Ελληνικό κείμενο", 123123);
            this.housesTableAdapter.Fill(this.dataSampleDataSet.houses);
            cnn.Close();
        }
    }
}
