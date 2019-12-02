using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;


namespace TestingWPFhostControl
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            adminMenu1.HomeBut.Click += HomeBut_Click;
            adminMenu1.userBut.Click += UserBut_Click;
           
        }

        private void UserBut_Click(object sender, System.Windows.RoutedEventArgs e)
        {

            UsersPanel.BringToFront();
           
        }

        private void HomeBut_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            HomePanel.BringToFront();

        }
    }
}
