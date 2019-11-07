using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testingMainDB
{
    public partial class Form1 : Form
    {
        // Connection String and Query
        string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\TEO\\Downloads\\AggeliesDatabase.accdb";
        string selectQuery = "SELECT * FROM Extras";
        OleDbCommand command;
        // Create the CheckedListBox 
        CheckedListBox extrasCheckedListBox = new CheckedListBox();
        public Form1()
        {
            // Set checkOnClick and adding event listener
            extrasCheckedListBox.CheckOnClick = true;
            extrasCheckedListBox.SelectedIndexChanged += new System.EventHandler(extrasCheckedListBox_SelectedIndexChanged);
            // Form init
            InitializeComponent();
            // Dock and Add to mainPanel
            extrasCheckedListBox.Dock = DockStyle.Left;
            mainPanel.Controls.Add(extrasCheckedListBox);
            // Start the connection
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                command = new OleDbCommand(selectQuery, connection);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();
                // For each entry add to list
                while (reader.Read())
                {
                    //populate the CheckedListBox
                    extrasCheckedListBox.Items.Add(reader["exTitle"].ToString());
                }
                // Close reading.
                reader.Close();
                connection.Close();
            }
        }
        private void extrasCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get selected value
            string str = extrasCheckedListBox.SelectedItem.ToString();
            // If checked add to selectedIndexesLabel
            if (extrasCheckedListBox.GetItemChecked(extrasCheckedListBox.SelectedIndex))
            {
                selectedIndexesLabel.Text += " " + str;
            }
            else
            {
                selectedIndexesLabel.Text.Replace(str, " ");
            }
        }
    }
}
