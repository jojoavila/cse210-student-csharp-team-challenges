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
        Player _currentPlayer;
        
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
            // Set up code for adding players to the roster
            for (int i = 0; i < 2; i++)
            {
                string prompt = $"Enter a name for player {i + 1}: ";
                string name = _userService.GetUserInput(prompt);
                Player player = new Player(name);
                _roster.AddPlayer(player);
            
                _currentPlayer = _roster.GetCurrentPlayer();
            }
        }

        
        private void GetInputs()
        {
            // Displays the most up to date game board
            _board.DisplayBoard(_roster.GetPlayer1(), _roster.GetPlayer2());

            _userService.DisplayText($"{_currentPlayer.GetName()}'s turn: ");

            // Stores current player's guess within the player itself
            _currentPlayer.SetGuess(_userService.GetUserInput($"What is your guess? "));

            
        }

        private void DoUpdates()
        {
            // stores the player's last given hint by calling the board's getHint function
            // and the player's getGuess function.
            _currentPlayer.SetLastHint(_board.GetHint(_currentPlayer.GetGuess()));
        }

        private void DoOutputs()
        {
            // Checks if the player's guess matches the secretCode
            if (_board.IsWin(_currentPlayer.GetGuess()))
            {
                _userService.DisplayText($"{_currentPlayer.GetName()} won!");
                
                _keepPlaying = false;
            }

            // Advances to the next player and sets _currentPlayer as the next
            // player
            _roster.AdvanceNextPlayer();
            _currentPlayer = _roster.GetCurrentPlayer();
        }
    }
}