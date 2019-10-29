using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace test3
{
    public partial class Form1 : Form
    {   

        //GLOBAL VAR ONLY TO FORM1
        private OleDbConnection connection = new OleDbConnection();
        public Form1()
        {
            InitializeComponent();
            //CONNECTION STRING 
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\anast\source\repos\test3\Aggelies.accdb;
Persist Security Info=False;";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                          

                connection.Open();

                checkCon.Text = "Connection Successful";

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR +" + ex);

            
            }





        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

       

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                Random rnd = new Random();

                int num = rnd.Next(1,3);

                string query = "select * from Spitia where ID=" + num + " ";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    name_house_text.Text = reader["OnomaSpitiou"].ToString();
                    house_price_Text.Text = reader["TimhSpitiou"].ToString();


                }

                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR " + ex);
            }
            
            
            }

        private void saved_data_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into Spitia (OnomaSpitiou,TimhSpitiou) values('" + name_house_text.Text + "','" + house_price_Text.Text + "')";

                command.ExecuteNonQuery();
                MessageBox.Show("Data Saved.");

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex);
            }
        }

        private void delete_Data_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "delete from Spitia where OnomaSpitiou= '" + name_house_text.Text + "' ";

               

                command.CommandText = query;
                command.ExecuteNonQuery();
                MessageBox.Show("Data Deleted.");

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex);
            }
        }
    }
}
