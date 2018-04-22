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
    public partial class MatchingGame : Form
    {
        public PlayAgain playAgainForm;
        public difficultySelect difficultySelectForm;
        Label firstClicked = null;
        Label secondClicked = null;
        double startingScore = 1000;
        double newScore = 0;
        double multiplier = 0.25;
        int timer = 0 ;

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
            difficultySelect ds = new difficultySelect();
           
            if (ds.sprEasyClicked == true)
            {
                timer = 95;
                lbl_timer.Text = "95 seconds";
                timeElpased.Start();
                return;
            }
            else if (ds.easyClicked == true)
            {
                timer = 85;
                lbl_timer.Text = "85 seconds";
                timeElpased.Start();
                return;
            }
            
             else if (ds.mediumClicked == false)
            {
                timer = 75;
                lbl_timer.Text = "75 seconds";
                timeElpased.Start();
                return;
            }
            else if (ds.hardClicked == false)
            {
                timer = 60;
                lbl_timer.Text = "60 seconds";
                timeElpased.Start();
            }
            else if (ds.sprHardClicked == false)
            {
                timer = 30;
                lbl_timer.Text = "30 seconds";
                timeElpased.Start();
            }
            else
                MessageBox.Show("Something Went Wrong", "Error");
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
                
                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;

                    newScore = startingScore * multiplier;
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

            MessageBox.Show("You matched all the icons!", "Congrats!!");
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
                lbl_timer.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry");
                this.Hide();
                PlayAgain pa = new PlayAgain();
                pa.Show();

            }
        }

        
    }
}
