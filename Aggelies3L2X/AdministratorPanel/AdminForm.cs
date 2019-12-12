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
            this.adminMenu1.GetHomeB.Click += GetHomeB_Click;
        }

        private void GetHomeB_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.homePanel.BringToFront();
            this.splitContainer1.SplitterDistance = 300;
            this.splitContainer2.SplitterDistance = 1000;
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'users_DataSet.Users' table. You can move, or remove it, as needed.
            

        }
    }
}
