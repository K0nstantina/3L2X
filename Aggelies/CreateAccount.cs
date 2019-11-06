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
    public partial class CreateAccount : Form

    {

       


        public CreateAccount()
        {
            InitializeComponent();
            //CONNECTION STRING 
//            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\petre\Source\Repos\K0nstantina\3L2X\Aggelies\Aggelies.accdb;
//Persist Security Info=False;";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {

            try
            {
                

                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                if (txt_pass.Text == txt_confpass.Text)
               {
                    cmd.CommandText = "INSERT INTO Spitia (FirstName, LastName, Email, Username, [Password]) VALUES " +
                      "(?, ?, ?, ?, ?)";
                    cmd.Parameters.AddWithValue("FirstName", txt_firstname.Text);
                    cmd.Parameters.AddWithValue("LastName", txt_lastname.Text);
                    cmd.Parameters.AddWithValue("Email", txt_mail.Text);
                    cmd.Parameters.AddWithValue("Username", txt_username.Text);
                    cmd.Parameters.AddWithValue("Password", txt_pass.Text);
                    OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\petre\Source\Repos\K0nstantina\3L2X\Aggelies\Aggelies.accdb;
Persist Security Info=False;");
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                }
              else
              {
                 MessageBox.Show("The passwords don't match. ");
                 txt_pass.Text = "";
                 txt_confpass.Text = "";

               }

                
                
                //connection.Close();
                
                MessageBox.Show("Registration complete.");
                this.Hide();
                 Login l1 = new Login();
                 l1.ShowDialog();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex);
            }

        }
    }
}
