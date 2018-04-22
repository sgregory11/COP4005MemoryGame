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

        public bool sprEasyClicked ;
        public bool easyClicked ;
        public bool mediumClicked;
        public bool hardClicked ;
        public bool sprHardClicked;

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
             sprEasyClicked = true ;
            this.Hide();
            MatchingGame mg = new MatchingGame();
            mg.Show();
            mg.gameTimer.Interval = 850;
        }

        private void btn_easy_Click(object sender, EventArgs e)
        {
            easyClicked = true;
            this.Hide();
            MatchingGame mg = new MatchingGame();
            mg.Show();
            mg.gameTimer.Interval = 800;
        }

        private void btn_medium_Click(object sender, EventArgs e)
        {
            this.Hide();
            MatchingGame mg = new MatchingGame();
            mg.Show();
            mg.gameTimer.Interval = 700;
        }

        private void btn_hard_Click(object sender, EventArgs e)
        {
            this.Hide();
            MatchingGame mg = new MatchingGame();
            mg.Show();
            mg.gameTimer.Interval = 600;
        }

        private void btn_sprHard_Click(object sender, EventArgs e)
        {
            this.Hide();
            MatchingGame mg = new MatchingGame();
            mg.Show();
            mg.gameTimer.Interval = 500;
        }
    }
}
