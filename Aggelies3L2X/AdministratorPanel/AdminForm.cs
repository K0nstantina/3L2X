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
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aggeliesDBDataSet.AdsTable' table. You can move, or remove it, as needed.
            this.adsTableTableAdapter.Fill(this.aggeliesDBDataSet.AdsTable);
            // TODO: This line of code loads data into the 'aggeliesDBDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter1.Fill(this.aggeliesDBDataSet.Users);
            // TODO: This line of code loads data into the 'aggeliesDBDataSet1.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.aggeliesDBDataSet1.Users);

        }
    }
}
