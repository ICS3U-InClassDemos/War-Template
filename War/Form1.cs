using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//header info

namespace War
{
    public partial class Form1 : Form
    {
        //random generator for picking new cards  
        Random randGen = new Random();

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
            playerCard = randGen.Next(1, 11);
            cpuCard = randGen.Next(1, 11);

            //display card values to the labels
            playerCardLabel.Text = $"{playerCard}";
            cpuCardLabel.Text = $"{cpuCard}";

            // check output of game and apply score
            if (playerCard > cpuCard)
            {
                playerScore++;
                playerScoreLabel.Text = $"{playerScore}";
                outputLabel.Text = "You Win!!";
            }
            else if (cpuCard > playerCard)
            {
                cpuScore++;
                cpuScoreLabel.Text = $"{cpuScore}";
                outputLabel.Text = "You Lose :(";
            }
            else 
            {
                outputLabel.Text = "It's a tie";
            }

        }
    }
}
