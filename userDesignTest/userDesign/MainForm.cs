using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace userDesign
{
    public partial class MainForm : Form
    {
        List<Panel> panels = new List<Panel>();
        public MainForm()
        {
            InitializeComponent();

            panels.Add(homePanel); //0
            panels.Add(pagePanel1); //1
            panels.Add(pagePanel2); //2
            panels[0].BringToFront();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            panels[0].BringToFront();
        }

        private void page2Button_Click(object sender, EventArgs e)
        {
            panels[1].BringToFront();
        }

        private void page3Button_Click(object sender, EventArgs e)
        {
            panels[2].BringToFront();
        }
    }
}
