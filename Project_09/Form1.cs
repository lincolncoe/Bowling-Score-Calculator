//I provide this code for free so people can see my code and provide comments and learn from it
//Please do not distribute without permission - Lincoln Coe http://panoramacoding.com

//Windows Program Icon is from Freepik from www.flaticon.com is licensed under Creative Commons BY 3.0

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_09
{//Start Namespace
    public partial class Form1 : Form
    {//Start Class
        /*Since this program needs to have the "business side" of code in 
another class, we need to reference that here*/
        private Bowlers bw;

        public Form1()
        {//Start Form1
            InitializeComponent();
            //Now we need to create a new object to reference it which will be bw
            //We know we don't need more than 10 entries so we'll set its value to 10
            bw = new Bowlers(10);
        }//End Form1
        //We need to create an integer to hold the number of entries in the array 
        int entries = 0;
        //And we need to create a string to hold the players and their scores
        string outputPlayers = "";


        // The aboutToolStripMenuItem method
        // Purpose: This code will display a new MessageBox and output the information I entered 
        // Returns: New Message Box pop up 
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {//Start About Menu Item
            MessageBox.Show("Created by Lincoln Coe \n http://panoramacoding.com");
        }//End About Menu Item

        // The exitToolStripMenuItem method
        // Purpose: This code will exit the program when the user clicks Exit 
        // Returns: Program is exited 
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {//Start Exit Menu Item
            this.Close();
        }//End Exit Menu Item

        // The inputTextBox_KeyDown method
        // Purpose: This code passes the value to our Bowlers class or if there's nothing, it ends the form 
        // Returns: If nothing is inputted, returns the high score, low score and average score.
        private void inputTextBox_KeyDown(object sender, KeyEventArgs e)
        {//Start KeyDown
            if (e.KeyData == Keys.Enter)
            {//Start if the Enter key is pressed
                //We'll need to declare a basic string to hold the user input to determine if it has value or not
                string userInput = inputTextBox.Text;

                //Start if check statement for user input
                if (userInput != "")
                {//Start if
                    entries++;
                    //Clear the text box
                    inputTextBox.Clear();
                    //Add the information from the textbox to our array
                    bw.AddBowler(userInput);
                }//End if
                else
                {//Start else
                    //Create a string for the high scoring player
                    string highScorer = bw.HighScorePlayer();
                    //Combine the high scorer with his/her score and be ready to output it
                    highScorer = highScorer + string.Format(": {0:d}", bw.HighScore());
                    //Output the high scorer and his/her score to the textbox.
                    highTextBox.Text = highScorer;
                    //Create a string for the low scoring player
                    string lowScorer = bw.LowScorePlayer();
                    //Combine the low scoring player with his/her score 
                    lowScorer = lowScorer + string.Format(": {0:d}", bw.LowScore());
                    //Output the low scorer with his/her score to the textbox
                    lowTextBox.Text = lowScorer;
                    //Output the average score to the textbox
                    averageTextBox.Text = string.Format("{0:f2}", bw.AverageScore());
                    //Now we need to establish a loop to open all elements of our array to show all players and scores
                    for (int i = 0; i < entries; i++)
                    {//Start for
                        //Now we need to add the player names and scores into an interger and create a new line
                        outputPlayers += bw.playerNames[i] + ": " + bw.playerScores[i] + Environment.NewLine;

                    }//End for
                    //Now we can output the string with each player name and score in it
                    playersTextBox.Text = outputPlayers;
                }//End else
            }//End enter key check
        }//End KeyDown
    }//End Class
}//End Namespace
