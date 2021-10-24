using System;

namespace _06_mastermind
{
    class Board
    {
        string _secretCode; 
        UserService _userService = new UserService();
   
        public Board()
        {
            RandomCode();
        }

        public void RandomCode()
        {
            Random randNum = new Random();
            int num = randNum.Next(1000,10000);
            
            _secretCode = num.ToString();

            // Debug code --> shows secret code before guessing starts
            Console.WriteLine(_secretCode);
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

        public void DisplayBoard(Player player1, Player player2)
        {
            Console.WriteLine("");
            Console.WriteLine("--------------------");
            Console.WriteLine($"Player {player1.GetName()}: {player1.GetGuess()}, {player1.GetHint()}");
            Console.WriteLine($"Player {player2.GetName()}: {player2.GetGuess()}, {player2.GetHint()}");
            Console.WriteLine("--------------------");
        }

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