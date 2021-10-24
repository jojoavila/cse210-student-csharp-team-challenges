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
        

    /// <summary>
    /// Starts the game loop and also calls the PrepareGame function to start the game.
    /// </summary>
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

    /// <summary>
    /// Set up code for adding players to the roster
    /// calls the userService class to accept user input
    /// also get's current player from roster.
    /// </summary>
        private void PrepareGame()
        {
            
            for (int i = 0; i < 2; i++)
            {
                string prompt = $"Enter a name for player {i + 1}: ";
                string name = _userService.GetUserInput(prompt);
                Player player = new Player(name);
                _roster.AddPlayer(player);
            
                _currentPlayer = _roster.GetCurrentPlayer();
            }
        }

    /// <summary>
    /// Displays the most up to date game board.
    /// Stores current player's guess within the player itself.
    /// </summary>
        private void GetInputs()
        {
            
            _board.DisplayBoard(_roster.GetPlayer1(), _roster.GetPlayer2());

            _userService.DisplayText($"{_currentPlayer.GetName()}'s turn: ");

            _currentPlayer.SetGuess(_userService.GetUserInput($"What is your guess? "));

            
        }

    /// <summary>
    /// stores the player's last given hint by calling the board's getHint function
    /// and the player's getGuess function.
    /// </summary>
        private void DoUpdates()
        {

            _currentPlayer.SetLastHint(_board.GetHint(_currentPlayer.GetGuess()));
        }

    /// <summary>
    /// Checks if the player's guess matches the secretCode
    /// Advances to the next player and sets _currentPlayer as the next player
    /// </summary>
        private void DoOutputs()
        {
            
            if (_board.IsWin(_currentPlayer.GetGuess()))
            {
                _userService.DisplayText($"{_currentPlayer.GetName()} won!");
                
                _keepPlaying = false;
            }

            _roster.AdvanceNextPlayer();
            _currentPlayer = _roster.GetCurrentPlayer();
        }
    }
}