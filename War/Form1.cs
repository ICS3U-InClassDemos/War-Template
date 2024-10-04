using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//A simple card war game
//Created by: Mr. T.
//Date: October 2024

namespace War
{
    public partial class Form1 : Form
    {
        //random generator for picking new cards   
        Random randomGenerator = new Random();

        //variables to hold card values 
        int playerCard, cpuCard;

        //variables to hold scores, initialized to 0
        int playerScore = 0;
        int cpuScore = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void warButton_Click(object sender, EventArgs e)
        {
            //clear card back images
            playerCardLabel.Image = null;
            cpuCardLabel.Image = null;

            //get random value between 1 and 10 for both player and cpu
            playerCard = randomGenerator.Next(1, 11);
            cpuCard = randomGenerator.Next(1, 11);

            //display card values to the labels
            playerCardLabel.Text = $"{playerCard}";
            cpuCardLabel.Text = $"{cpuCard}";

            // if player value is greater then cpu card
            //    add to player score 
            //    show new player score 
            //    show message saying player won
            if (playerCard > cpuCard)
            {
                playerScore++;
                outputLabel.Text = $"Player wins";
                playerScoreLabel.Text = $"{playerScore}";
            }
            
            if (cpuCard > cpuScore) 
            {
                cpuScore++;
                outputLabel.Text = "Computer wins";
                cpuScoreLabel.Text = $"{cpuScore}";
            }
              
            if (cpuCard == playerCard)
            {
                outputLabel.Text = "It's a tie";
            }

        }
    }
}
