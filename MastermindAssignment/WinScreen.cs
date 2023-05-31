﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MastermindAssignment
{
    public partial class WinScreen : Form
    {
        public WinScreen()
        {
            InitializeComponent();
        }

        public MainMenu MainMenu
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// /// <summary>
        /// Creates a new MainMenu Object, which is shown and hides the WinScreen.
        /// </summary>
        private void playAgainButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new();
            mainMenu.Show();
            Hide();
        }
        /// <summary>
        /// Quits the program.
        /// </summary>
        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
