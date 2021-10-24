using System;

namespace _06_mastermind
{
    class Board
    {
        string _secretCode; 
        UserService _userService = new UserService();
        Roster _roster = new Roster();
   
        public string RandomCode()
        {
            string numInt;
            Random ran = new Random();
            int num = ran.Next(1000,10000);
            numInt = num.ToString();
            _secretCode = numInt;
            Console.WriteLine(_secretCode);
            return numInt;
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

        public void DisplayBoard(Player player1, Player player2, string algo, string guess)
        {
            _userService.DisplayText($"Player {player1.GetName()}: {guess}, {algo}");
            _userService.DisplayText($"Player {player2.GetName()}: {guess}, {algo}");
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