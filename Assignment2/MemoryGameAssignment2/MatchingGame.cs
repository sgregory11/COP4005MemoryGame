using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MemoryGameAssignment2
{
    public partial class MatchingGame : Form
    {
        public PlayAgain playAgainForm;
        public difficultySelect difficultySelectForm;
        Label firstClicked = null;
        Label secondClicked = null;
        static double newScore = 0;
        double finalScore;
        public int timer = 0 ;

        //initiates random icons for squares
        Random random = new Random();

        //sets random icons
        List<string> icons = new List<string>(){
            "!", "!", "N", "N", ",", ",", "k", "k",
            "b", "b", "v", "v", "w", "w", "z", "z"
        };

        private void MatchingGame_Load(object sender, EventArgs e)
        { }

        //assigns each icon from icons list to random square
        private void assignIconsToSquares()
        {
            foreach (Control control in GamePanel.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }

            }
        }

        public MatchingGame()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; 
            assignIconsToSquares();
        }

        private void label_Click(object sender, EventArgs e)
        {
            //sets timer on only after 2 non matching icons
            if (gameTimer.Enabled == true)
                return;

            Label clickedLabel = sender as Label;
            //Label scoreLabel = lbl_score as Label;

            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }

                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;

                checkForWinner();
                //Scoring
                
                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;

                    newScore = newScore + 100;
                    lbl_score.Text = newScore.ToString();

                    return;
                }

                gameTimer.Start();

            }

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //stop timer
            gameTimer.Stop();

            //hide icons
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            //resets first and second clicks for timer
            firstClicked = null;
            secondClicked = null;
        }

        private void checkForWinner()
        {
            foreach (Control control in GamePanel.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }

            finalScore = newScore * timer;
            MessageBox.Show("Your final score is : " + finalScore + "!", "Winner!");
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\Projects;Initial Catalog=memoryGame;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;");
            con.Open();
            string query =  "insert into highScores (scores) values (@scores)";
            SqlCommand myCommand = new SqlCommand(query, con);
            myCommand.Parameters.AddWithValue("@scores", finalScore);
            myCommand.ExecuteNonQuery();
            con.Close();
            PlayAgain pa = new PlayAgain();
            pa.Show();
            Close();
        }

        public void timeElpased_Tick_1(object sender, EventArgs e)
        {
            if (timer > 0)
            {
                timer = timer - 1;
                lbl_timer.Text = timer + " seconds";
            }
            else
            {
                timeElpased.Stop();
                finalScore = newScore;
                lbl_timer.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time. \n      Your Score: " + finalScore, "Sorry");
                this.Hide();
                PlayAgain pa = new PlayAgain();
                pa.Show();

            }
        }
 
    }
}
