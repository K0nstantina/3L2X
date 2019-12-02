using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; 


namespace BlackList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Table1' table. You can move, or remove it, as needed.
            this.table1TableAdapter.Fill(this.database1DataSet.Table1);
            // TODO: This line of code loads data into the 'testSalampasis1DataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.testSalampasis1DataSet.Users);

        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                txt_id.Text = row.Cells["user ID"].Value.ToString();
                txt_fname.Text = row.Cells["First Name"].Value.ToString();
                txt_lname.Text = row.Cells["Last Name"].Value.ToString();
                txt_uName.Text = row.Cells["User Name"].Value.ToString();
                txt_uName.Text = row.Cells["uEmail"].Value.ToString();


            }
        }
    }
}
