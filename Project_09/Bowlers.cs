using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_09
{//Start Namespace
    class Bowlers
    {//Start Class
        //We need an int for our arrays to keep track of entries for our math.
        int value;
        //Now we need an int for the scores and a string for the player names.
        public int[] playerScores;
        public string[] playerNames;

        //We need to add default values in a constructor. The value will be 10
        public Bowlers(int values)
        {
            //playerNames will hold their names from the split
            playerNames = new string[values];
            //playerScoes will hold the player scores from the split
            playerScores = new int[values];
            value = 0;
        }
        // The AddBowler method
        // Purpose: This code splits the user input and adds it into their variables
        // Returns: Nothing, variables are inputted with data.
        public void AddBowler(string input)
        {//Start AddBowler
            //We need to split the input into 2
            string[] addingBowler = input.Split();
            //Now we can add the first part into our playerNames variable
            playerNames[value] = addingBowler[0];
            //And we can add the second part into the playerScores variable
            playerScores[value] = int.Parse(addingBowler[1]);
            //Now we need to increase how many times we've entered data so we can calculate average score
            value++;
        }//End AddBowler

        // The HighScore method
        // Purpose: This code finds the high score and returns it
        // Returns: The highest number in the array
        public int HighScore()
        {//Start HighScore
            int highScoreOutput = 0;
            for (int a = 0; a < value; a++)
            {//Start for
                if (playerScores[a] > playerScores[highScoreOutput])
                {//Start if
                    highScoreOutput = a;
                }//End if
            }//End for
            return playerScores[highScoreOutput];
        }//End HighScore

        // The HighScorePlayer method
        // Purpose: This code finds the highest scoring player and returns it
        // Returns: The highest scoring player in the array
        public string HighScorePlayer()
        {//Start HighScorePlayer
            int highScorePlayerOutput = 0;
            for (int a = 0; a < value; a++)
            {//Start for
                if (playerScores[a] > playerScores[highScorePlayerOutput])
                {//Start if
                    highScorePlayerOutput = a;
                }//End if
            }//End for
            return playerNames[highScorePlayerOutput];
        }//End HighScorePlayer

        // The AverageScore method
        // Purpose: This code finds the average score and returns it
        // Returns: The average score in the array
        public double AverageScore()
        {//Start AverageScore
           double averageScoreOutput = 0.0;
           double averageScoreCalc = 0.0;
            for (int a = 0; a < value; a++)
            {//Start for
                averageScoreCalc += (double)playerScores[a];
                averageScoreOutput = averageScoreCalc / value;
            }//End for
            return averageScoreOutput;
        }//End AverageScore

        // The LowScore method
        // Purpose: This code finds the low score and returns it
        // Returns: The lowest number in the array
        public int LowScore()
        {//Start LowScore
            int lowScoreOutput = 0;
            for (int a = 0; a < value; a++)
            {//Start for
                if (playerScores[a] < playerScores[lowScoreOutput])
                {//Start if
                    lowScoreOutput = a;
                }//End if
            }//End for
            return playerScores[lowScoreOutput];
        }//End LowScore

        // The LowScorePlayer method
        // Purpose: This code finds the lowest scoring player and returns it
        // Returns: The lowest scoring player in the array
        public string LowScorePlayer()
        {//Start LowScorePlayer
            int lowScorePlayerOutput = 0;
            for (int a = 0; a < value; a++)
            {//Start for
                if (playerScores[a] < playerScores[lowScorePlayerOutput])
                {//Start if
                    lowScorePlayerOutput = a;
                }//End if
            }//End for
            return playerNames[lowScorePlayerOutput];
        }//End LowScorePlayer


    }//End Class
}//End namespace
