using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

        

        private void Button1_Click(object sender, EventArgs e)
        {
            ChangeLang("el");
        }

        private void ChangeLang(string lang)
        {
            CultureInfo ci = new CultureInfo(lang);

            System.Resources.ResourceManager rm = new System.Resources.ResourceManager("AdministratorPanel.MyResources.Labels", typeof(AdminForm).Assembly);
            label1.Text = rm.GetString("Authentication", ci);
            button1.Text = rm.GetString("Button", ci);
           
            this.Text = rm.GetString("Authentication", ci);
        }
    }
}
