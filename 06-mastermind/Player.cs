using System;

namespace _06_mastermind
{
    /// <summary>
    /// Represents a person taking part in the game. This course keeps track
    /// of their name and their current move.
    /// 
    /// Stereotype:
    ///     Information Holder
    /// </summary>
    class Player
    {
        private string _name;
        private string _guess = "----";
        private string _lastHint = "****";


    /// <summary>
    /// This function takes in a string and updates the _name member variable.
    /// </summary>
        public Player(string name)
        {
            _name = name;
        }

    /// <summary>
    /// This function takes in a string and updates the _guess member variable.
    /// </summary>
        public void SetGuess(string playerGuess)
        {
            _guess = playerGuess;
        }
        
    /// <summary>
    /// This function takes in a string and updates the _lastHint with the most recent hint to be used later.
    /// </summary>
        public void SetLastHint(string hint)
        {
            _lastHint = hint;
        }

    /// <summary>
    /// A getter that returns the player's name, gets member variable _name
    /// </summary>
        public string GetName()
        {
            return _name;
        }
    /// <summary>
    /// A getter that returns the player's guess, gets member variable _guess
    /// </summary>

        public string GetGuess()
        {
            return _guess;
        }

    /// <summary>
    /// A getter that returns the player's most recent guess, gets member variable _guess
    /// </summary>

        public string GetHint()
        {
            return _lastHint;
        }
    }
}