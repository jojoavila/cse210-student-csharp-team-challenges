using System;

namespace _06_mastermind
{


    
    // private _board


    class Board
    {
        private string _secretCode = "1234";
        public Board()
        {
            //generate code the first time
        }

        public string GetHint(string guess)
        {
            string hint = "****";

            for (int pos = 0; pos < _secretCode.Length; pos++)
            {
                // Checks if specific spot is correct
                if (guess[pos] == _secretCode[pos])
                {
                    hint = hint.Remove(pos, 1).Insert(pos, "X");
                }
                // Checks if code entry is in the secretCode at all
                else if (_secretCode.Contains(guess[pos]))
                {
                    hint = hint.Remove(pos, 1).Insert(pos, "O");
                }   
            }
            return hint;
        }
    }

    //GetHint(Guess, secretCode), update the * with o's or x's: Return a new string.
    //logic: Compare the strings characters for each string. 
    //return string
    //Christian

    ///IsWin(Guess,SecretCode) compare the secretCode to user input.
    // return Bool
    // Brighton

    //Generatecode, generate random number, 1000-9999. 
    //Change randomInteger into a string
    //return newStringCode
    //Tyler

    //DisplayBoard(Hint, lastplayerhint, Player), player names needs brought in from roster and guess, display hint.
    //Josue

    
    













}
