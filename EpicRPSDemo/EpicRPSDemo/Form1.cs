// AUthor: Katie Straughn
// Date: 11/26/2016
// Program: Epis RPS
// Purpose: A classic game of rock-paper-scissors against the computer.
// The first to win three matches wins the game.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace EpicRPSDemo
{
    public partial class GameForm : Form
    {
        // Declare and initialize scores for user and comp, and declare vars for their items
        int userScore = 0, compScore = 0, userItem, compItem;

        // Enumeration of the items
        enum Items
        {
            ROCK = 1, PAPER, SCISSORS
        }

        // This enumeration holds a value stating who won
        /* Not used currently */
        enum Winner
        {
            USERWON, COMPWON, TIE
        }

        public GameForm()
        {
            InitializeComponent();
            //SoundPlayer bgMusic = new SoundPlayer(@"C:\Users\Katie\Music\Katie's Songs\Town Theme 1.wav");
            //bgMusic.Play();
        }

        /* This method activates when the rock button is clicked */
        private void rockButton_Click(object sender, EventArgs e)
        { 
            userItem = (int)Items.ROCK;
            ChangeUserImage();
            ComputerSelectsItem();
            FindWinner();
        }

        /* This method activates when the paper button is clicked */
        private void paperButton_Click(object sender, EventArgs e)
        {
            userItem = (int)Items.PAPER;
            ChangeUserImage();
            ComputerSelectsItem();
            FindWinner();
        }

        /* This method activates when the scissors button is clicked */
        private void scissorsButton_Click(object sender, EventArgs e)
        {
            userItem = (int)Items.SCISSORS;
            ChangeUserImage();
            ComputerSelectsItem();
            FindWinner();
        }

        /* This method activates when the play again button is clicked */
        private void playAgainButton_Click(object sender, EventArgs e)
        {
            winLosePanel.Visible = false; // Hide panel                           
            // Hide picture boxes
            userItemPic.Image = null;
            compItemPic.Image = null;
            // Check if someone has won
            if (userScore == 3 || compScore == 3)
            {
                // Reset scores
                userScore = 0;
                compScore = 0;
                userScorePic.Image = null;
                compScorePic.Image = null;
            }
        }

        private void winLoseLabel_Click(object sender, EventArgs e)
        {

        }

        /* This method changes the user's item picture box image based on the item selected */
        private void ChangeUserImage()
        {
            switch ((Items)userItem)
            {
                case Items.ROCK:
                    userItemPic.Image = EpicRPSDemo.Properties.Resources.rock;
                    break;
                case Items.PAPER:
                    userItemPic.Image = EpicRPSDemo.Properties.Resources.paper;
                    break;
                case Items.SCISSORS:
                    userItemPic.Image = EpicRPSDemo.Properties.Resources.scissors;
                    break;
            }
        }

       /* This method randomizes an item for the computer, and changes it's picture box to match */
       private void ComputerSelectsItem()
       {
           // Computer chooses an item at random
           Random random = new Random();
           int randomNumber = random.Next(1, 4);
           compItem = (int)(Items)randomNumber;

           // This switch statement changes compPic's image to match item selected
           switch ((Items)compItem)
            {
                case Items.ROCK:
                    compItemPic.Image = EpicRPSDemo.Properties.Resources.rock;
                    break;
                case Items.PAPER:
                    compItemPic.Image = EpicRPSDemo.Properties.Resources.paper;
                    break;
                case Items.SCISSORS:
                    compItemPic.Image = EpicRPSDemo.Properties.Resources.scissors;
                    break;
            }
        }

       /* This method finds the winner of the match */
       private void FindWinner()
       {
            int theWinner; // Hold the enumeration Winner value to find who earns a point

           // If statments compare the user's chosen item and the computer's to determine the winner
           // Both the user and comp having the same item will result in a tie
           if ((userItem == (int)Items.ROCK && compItem == (int)Items.ROCK) ||
                (userItem == (int)Items.PAPER && compItem == (int)Items.PAPER) ||
                (userItem == (int)Items.SCISSORS && compItem == (int)Items.SCISSORS))
            {
                winLoseLabel.Text = "It's a tie!"; // label will display "it's a tie!"
                //theWinner = (int)Winner.TIE;
            }
           // If the user has chosen the stronger item, then they win
           else if ((userItem == (int)Items.ROCK && compItem == (int)Items.SCISSORS) ||
                (userItem == (int)Items.PAPER && compItem == (int)Items.ROCK) ||
                (userItem == (int)Items.SCISSORS && compItem == (int)Items.PAPER))
            {
                winLoseLabel.Text = "You win!"; // label will display "you win!"
                userScore += 1;
                //theWinner = (int)Winner.USERWON;
            }
            else // Any other aterantive will result in a lose
            {
                winLoseLabel.Text = "You lose..."; // label will display "you lose..."
                compScore += 1;
                //theWinner = (int)Winner.COMPWON;
            }

            winLosePanel.Visible = true; // panel made visible

            // Increment the score of the user if they won
            if (userScore == 1)
                userScorePic.Image = EpicRPSDemo.Properties.Resources.point1;
            else if (userScore == 2)
                userScorePic.Image = EpicRPSDemo.Properties.Resources.point2;
            else if (userScore == 3) // If the score has reached 3, you have won
            {
                userScorePic.Image = EpicRPSDemo.Properties.Resources.point3;
                winLoseLabel.Text = "You have won the game!";
            }

            // Increment the score of the comp if it won
            if (compScore == 1)
                compScorePic.Image = EpicRPSDemo.Properties.Resources.point1;
            else if (compScore == 2)
                compScorePic.Image = EpicRPSDemo.Properties.Resources.point2;
            else if (compScore == 3) // If the score has reached 3, the computer has won
            {
                compScorePic.Image = EpicRPSDemo.Properties.Resources.point3;
                winLoseLabel.Text = "The compter has won the game!";
            }
        }
    }
}
