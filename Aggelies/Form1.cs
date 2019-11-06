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

namespace Aggelies
{
    public partial class Login : Form
    {

        private OleDbConnection connection = new OleDbConnection();

        public Login()
        {
            InitializeComponent();
            //CONNECTION STRING 
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\anast\source\repos\Aggelies\Aggelies.accdb;
Persist Security Info=False;";

        }

        private void connect_Click(object sender, EventArgs e)
        {
            connection.Open();

            OleDbCommand command = new OleDbCommand();

            command.Connection = connection;
            command.CommandText = "select * from Spitia where Username = '" + txt_username.Text + " ' and Password = '" + txt_password.Text + "' ";


            //gia krathma epistrofhs tou query
            OleDbDataReader reader = command.ExecuteReader();
            int count = 0;


            //gia diavasma timis query
            while (reader.Read())
            {
                count++;
            }

            //if me 3 condition!!
            //1 elegxos swsth sundesh
            //2 elegxos i cant remember
            //3 elegxos lathos pass or username
            if (count == 1)
            {
                MessageBox.Show("Welcome back! ");
                connection.Close();
                connection.Dispose();
                this.Hide();
                AccManagement f2 = new AccManagement();

                f2.ShowDialog();

            }

            else if (count > 1)
            {
                MessageBox.Show("Duplicate username and password.");

                

            }

            else
            {
                MessageBox.Show("username or password is not correct.");

            }


            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            CreateAccount C1 = new CreateAccount();
            C1.ShowDialog();
        }
    }
}
