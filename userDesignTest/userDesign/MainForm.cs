﻿using System;
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
        List<Button> buttons = new List<Button>();
        public MainForm()
        {
            InitializeComponent();

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
            homeButton.BackColor = Color.Red;
            
        }

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

        private void buttonStyle()
        {
            foreach (Button btn in buttons)
            {
                btn.BackColor = SystemColors.ActiveCaption;
            }
        }
    }
}
