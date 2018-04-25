using System;
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
    public partial class difficultySelect : Form
    {
        public MatchingGame matchingGameForm;
        public HomePage homePageForm;

        public difficultySelect()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; 
        }

        private void difficultySelect_Load(object sender, EventArgs e)
        {

        }

        public void btn_sprEasy_Click(object sender, EventArgs e)
        { 
            this.Hide();
            MatchingGame mg = new MatchingGame();
            mg.Show();
            mg.gameTimer.Interval = 800;
            mg.timer = 95;
            mg.lbl_timer.Text = "95 seconds";
            mg.timeElpased.Start();
        }

        private void btn_easy_Click(object sender, EventArgs e)
        {
            this.Hide();
            MatchingGame mg = new MatchingGame();
            mg.Show();
            mg.gameTimer.Interval = 700;
            mg.timer = 85;
            mg.lbl_timer.Text = "85 seconds";
            mg.timeElpased.Start();
        }

        private void btn_medium_Click(object sender, EventArgs e)
        {
            this.Hide();
            MatchingGame mg = new MatchingGame();
            mg.Show();
            mg.gameTimer.Interval = 600;
            mg.timer = 75;
            mg.lbl_timer.Text = "75 seconds";
            mg.timeElpased.Start();
        }

        private void btn_hard_Click(object sender, EventArgs e)
        {
            this.Hide();
            MatchingGame mg = new MatchingGame();
            mg.Show();
            mg.gameTimer.Interval = 500;
            mg.timer = 60;
            mg.lbl_timer.Text = "60 seconds";
            mg.timeElpased.Start();
        }

        private void btn_sprHard_Click(object sender, EventArgs e)
        {
            this.Hide();
            MatchingGame mg = new MatchingGame();
            mg.Show();
            mg.gameTimer.Interval = 400;
            mg.timer = 30;
            mg.lbl_timer.Text = "30 seconds";
            mg.timeElpased.Start();
        }
    }
}
