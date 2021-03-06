﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGameAssignment2
{
    public partial class PlayAgain : Form
    {
        public difficultySelect difficultySelectForm;
        public HomePage homePageForm;
     

        public PlayAgain()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; 
        }

        private void btn_yes_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            MessageBox.Show("Please choose a difficulty", "Difficulty");
            difficultySelect ds = new difficultySelect();
            ds.Show();
            
            
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Going back to Home", "Exiting");
            HomePage hp = new HomePage();
            hp.Show();

        }

        private void PlayAgain_Load(object sender, EventArgs e)
        {

        }
    }
}
