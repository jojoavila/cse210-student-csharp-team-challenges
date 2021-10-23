using System;

namespace _06_mastermind
{
    class Board
    {
        private int _secretCode;
        // private _board
        public Board()
        {
            Random randomGenerator = new Random();
            _secretCode = randomGenerator.Next(1000, 10000);

            //generate code the first time
        }

        private string CodeGeneratorString()
        {
            string codeString = Convert.ToString(_secretCode);
            Console.WriteLine(_secretCode);

            return codeString;
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
