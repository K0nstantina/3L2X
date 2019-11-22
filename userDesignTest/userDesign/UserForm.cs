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
    public partial class UserForm : Form
    {
        #region Variables
        List<Panel> panels = new List<Panel>();
        List<Button> buttons = new List<Button>();
        DataRowView view;
        int userid = 1;
        private string imgPath, imgName, imgNewPath;
        private string imagesLocation = @"C:\Users\TEO\Source\examples\userDesign\userDesign\Resources\images\";
        #endregion

        #region Constructor
        public UserForm()
        {
            InitializeComponent();
            controlsList();
            homeButton.BackColor = Color.Red;
        }
        #endregion

        #region Navigation
        private void homeButton_Click(object sender, EventArgs e)
        {
            buttonStyle();
            panels[0].BringToFront();
            homeButton.BackColor = Color.Red;
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            buttonStyle();
            panels[1].BringToFront();
            settingsButton.BackColor = Color.Red;
        }

        private void adsButton_Click(object sender, EventArgs e)
        {
            buttonStyle();
            panels[2].BringToFront();
            adsButton.BackColor = Color.Red;
        }

        private void page4Button_Click(object sender, EventArgs e)
        {
            buttonStyle();
            panels[3].BringToFront();
            page4Button.BackColor = Color.Red;
        }

        private void page5Button_Click(object sender, EventArgs e)
        {
            buttonStyle();
            panels[4].BringToFront();
            page5Button.BackColor = Color.Red;
        }

        private void page6Button_Click(object sender, EventArgs e)
        {
            buttonStyle();
            panels[5].BringToFront();
            page6Button.BackColor = Color.Red;
        }
        /// <summary>
        /// Resets all buttons backColor to default.
        /// </summary>
        private void buttonStyle()
        {
            foreach (Button btn in buttons)
            {
                btn.BackColor = SystemColors.ActiveCaption;
            }
        }
        /// <summary>
        /// Populates the panel and control lists
        /// </summary>
        private void controlsList()
        {
            panels.Add(homePanel); //0
            panels.Add(settingsPanel); //1
            panels.Add(adsPanel); //2
            panels.Add(page4Panel);
            panels.Add(page5Panel);
            panels.Add(page6Panel);

            buttons.Add(homeButton);
            buttons.Add(settingsButton);
            buttons.Add(adsButton);
            buttons.Add(page4Button);
            buttons.Add(page5Button);
            buttons.Add(page6Button);

            panels[0].BringToFront();
        }
        #endregion

        #region Private Methods
        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aggeliesDBDataSet.AdsTable' table. You can move, or remove it, as needed.
            this.adsTableTableAdapter.AdsPerUser(this.aggeliesDBDataSet.AdsTable, userid);
            adsListBox_SelectedIndexChanged(adsListBox, e);
        }

        /// <summary>
        /// Enables editing the titleTextBox.
        /// Changes editTitlePictureBox image accordingly.
        /// </summary>
        /// <param name="sender">editTitlePictureBox</param>
        /// <param name="e">Click</param>
        private void editTitlePictureBox_Click(object sender, EventArgs e)
        {
            if (titleTextBox.Enabled == false)
            {
                titleTextBox.Enabled = true;
                editTitlePictureBox.Image = userDesign.Properties.Resources.save1;
            }
            else
            {
                titleTextBox.Enabled = false;
                editTitlePictureBox.Image = userDesign.Properties.Resources.edit1;
                try 
                {
                    view = adsListBox.SelectedItem as DataRowView;
                    int adID = Int32.Parse(view["adID"].ToString());
                    this.adsTableTableAdapter.UpdateTitleDescQuery(titleTextBox.Text, descriptionRichTextBox.Text, adID);
                    //pageRefresh();
                }
                catch (Exception)
                {
                    MessageBox.Show("not updated");
                }
            }
        }

        /// <summary>
        /// Enables editing the descriptionRichTextBox.
        /// Changes editDescriptionPictureBox image accordingly.
        /// </summary>
        /// <param name="sender">editTitlePictureBox</param>
        /// <param name="e">Click</param>
        private void editDescriptionPictureBox_Click(object sender, EventArgs e)
        {
            if (descriptionRichTextBox.Enabled == false)
            {
                descriptionRichTextBox.Enabled = true;
                editDescriptionPictureBox.Image = userDesign.Properties.Resources.save1;
            }
            else
            {
                descriptionRichTextBox.Enabled = false;
                editDescriptionPictureBox.Image = userDesign.Properties.Resources.edit1;
            }
        }

        /// <summary>
        /// Changes the image path in database per adID.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editPicturePictureBox_Click(object sender, EventArgs e)
        {
            try
            {
                // Open file dialog and set directory and file filters.
                OpenFileDialog imgDialog = new OpenFileDialog();
                //imgDialog.InitialDirectory = "C:\\";
                imgDialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png) |*.png| All files(*.*)|*.*";
                // OK button clicked (file selected).
                if (imgDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    // If file exists (no error in filename).
                    if (imgDialog.CheckFileExists)
                    {
                        // Get file path and name.
                        imgPath = imgDialog.FileName;
                        imgName = System.IO.Path.GetFileName(imgDialog.FileName);
                        // Set the new local path
                        imgNewPath = imagesLocation + imgName;
                        // Copy file to images folder and update avatarPictureBox.
                        System.IO.File.Copy(imgDialog.FileName, imagesLocation + imgName);
                        // Set adsPicturebox new image.
                        adsPictureBox.ImageLocation = imgNewPath;
                        // Get current adID.
                        view = adsListBox.SelectedItem as DataRowView;
                        int adID = Int32.Parse(view["adID"].ToString());
                        // Update the image path in database.
                        this.adsTableTableAdapter.UpdateImageQuery(imgNewPath, adID);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occured" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Event handler for selected index in adsListBox.
        /// Updates the title and description text in controls.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void adsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            titleTextBox.Text = adsListBox.Text;
            view = adsListBox.SelectedItem as DataRowView;
            string title = view["adTitle"].ToString();
            string desc = view["adDesc"].ToString();
            titleTextBox.Text = title;
            descriptionRichTextBox.Text = desc;
            adsPictureBox.ImageLocation = view["media"].ToString();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        // Testing listbox item update...
        private void pageRefresh()
        {
            adsListBox.Refresh();
            adsListBox.Update();
        }
        #endregion

    }
}
