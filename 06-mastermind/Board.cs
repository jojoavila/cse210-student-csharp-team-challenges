using System;

namespace _06_mastermind
{

    /// <summary>
    ///This class stores the secret code
    ///it's also responsible for creating a new board.
    /// also it compares the secret code to userguess to give current hint
    /// determins if game is over
    /// </summary>
    class Board
    {
        string _secretCode; 
        UserService _userService = new UserService();
   

        /// <summary>
        /// This class will initialize the secret code, and make it a string.
        /// </summary>
        public Board()
        {
            RandomCode();
        }


        /// <summary>
        /// This function will generate a new random code and convert the random secret code to  a string.
        /// Also stores a debug print if needed.
        /// </summary>
        public void RandomCode()
        {
            Random randNum = new Random();
            int num = randNum.Next(1000,10000);
            
            _secretCode = num.ToString();

            // Debug code --> shows secret code before guessing starts
            // Uncomment if debug needed.
            // Console.WriteLine(_secretCode);
        }

        /// <summary>
        /// This function takes in a the guess and copmares it to the secret code
        /// first it seese if the spot is correct then updates with an X
        /// or it just continues to see if there is any part in the code at all and adds 0
        /// returns the new hint string
        /// </summary>
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

        /// <summary>
        /// This function takes in the player 1 and 2 information
        /// prints out the board with the relavent player information
        /// </summary>
        public void DisplayBoard(Player player1, Player player2)
        {
            Console.WriteLine("");
            Console.WriteLine("--------------------");
            Console.WriteLine($"Player {player1.GetName()}: {player1.GetGuess()}, {player1.GetHint()}");
            Console.WriteLine($"Player {player2.GetName()}: {player2.GetGuess()}, {player2.GetHint()}");
            Console.WriteLine("--------------------");
        }


        /// <summary>
        /// Determins if player guess equals the scecret code 
        /// returns bool true if game is over
        /// </summary>
        public bool IsWin(string guess)
        {
            bool win = false;

            if(_secretCode == guess)
            {
                win = true;
            }
            return win;
        }
    }
}