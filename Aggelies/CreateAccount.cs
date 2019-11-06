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

        private OleDbConnection connection = new OleDbConnection();


        public CreateAccount()
        {
            InitializeComponent();
            //CONNECTION STRING 
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\anast\source\repos\Aggelies\Aggelies.accdb;
Persist Security Info=False;";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {

            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand();

                command.Connection = connection;
                if (txt_pass.Text == txt_confpass.Text)
                {
                    command.CommandText = "insert into Spitia (FirstName,LastName,Email,Username,Password) values('" + txt_firstname.Text + "','" + txt_lastname.Text + "','" + txt__mail.Text + "','" + txt__username.Text + "','" + txt_pass.Text + "')";
                    
                }
                else
                {
                    MessageBox.Show("The passwords don't match. ");
                    txt_pass.Text = "";
                    txt_confpass.Text = "";

                }


                command.ExecuteNonQuery();
                
                
                MessageBox.Show("Registration complete.");
                this.Hide();
                this.Close();
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
