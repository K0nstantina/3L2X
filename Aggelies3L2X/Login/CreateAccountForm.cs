using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace Login
{
    public partial class CreateAccountForm : Form
    {
        public CreateAccountForm()
        {
            InitializeComponent();
        }

        private void CreateAccountForm_Load(object sender, EventArgs e)
        {

        }


        private void ChangeLanguage(string lang)
        {
            foreach (Control c in this.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(CreateAccountForm));
                resources.ApplyResources(c, c.Name, new CultureInfo(lang));
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {

        }

        private void lang_button_Click(object sender, EventArgs e)
        {
            if (lang_button.Text == "GR")
            { ChangeLanguage("gr"); }

            else if (lang_button.Text == "EN")
            { ChangeLanguage("en"); }
        }
    }
}
