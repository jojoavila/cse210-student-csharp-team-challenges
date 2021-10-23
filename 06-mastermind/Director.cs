using System;

namespace _06_mastermind
{
    /// <summary>
    /// The director is responsible to direct the game, including to keep track of all
    /// the actors and to control the sequence of play.
    /// 
    /// Stereotype:
    ///     Controller
    /// </summary>
    class Director
    {
        Board _board = new Board();
        UserService _userService = new UserService();
        Roster _roster = new Roster();
        private bool _keepPlaying = true;
        private string _code;
        string _guess = "----";
        string algo = "****";
        private string _limit = "--------------------";
        
        public void StartGame()
        {
            PrepareGame();

            while(_keepPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        private void PrepareGame()
        {
            _code = _board.RandomCode();
            for (int i = 0; i < 2; i++)
            {
                string prompt = $"Enter a name for player {i + 1}: ";
                string name = _userService.GetUserInput(prompt);
                Player player = new Player(name);
                _roster.AddPlayer(player);
            }
        }

        
        private void GetInputs()
        {
            Console.WriteLine("");
            _userService.DisplayText($"{_limit}");
            Player player1 = _roster.GetPlayer1();
            Player player2 = _roster.GetPlayer2();
            _board.DisplayBoard(player1, player2, algo, _guess);
            
            _userService.DisplayText($"{_limit}");
            Player currentPlayer = _roster.GetCurrentPlayer();
            _userService.DisplayText($"{currentPlayer.GetName()}'s turn: ");
            _guess = _userService.GetUserInput($"What is your guess? ");
            
            Console.WriteLine("");

        }

        private void DoUpdates()
        {
            algo = _board.GetHint(_guess);
        }

        private void DoOutputs()
        {
            if (_board.IsWin(_guess))
            {
                Player winningPlayer = _roster.GetCurrentPlayer();
                string name = winningPlayer.GetName();

                _userService.DisplayText($"{name} won!");
                _keepPlaying = false;
            }
            _roster.AdvanceNextPlayer();
        }
    }
}