using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multipleForms
{
    public class publicMethods
    {
        /// <summary>
        /// Exits the application.
        /// </summary>
        /// <param name="sender">pictureBox</param>
        /// <param name="e">Click</param>
        public void exitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Closes current form and opens the startup form.
        /// </summary>
        /// <param name="sender">backButton</param>
        /// <param name="e">Click</param>
        public void startupForm_Click(object sender, EventArgs e)
        {
            //Get current open form and close it.
            var s = Application.OpenForms[Application.OpenForms.Count - 1];
            s.Hide();
            startupForm startform = new startupForm();
            startform.Show();
        }
    }
}
