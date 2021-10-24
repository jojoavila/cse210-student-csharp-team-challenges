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

        public Player(string name)
        {
            _name = name;
        }

        public void SetGuess(string playerGuess)
        {
            _guess = playerGuess;
        }

        public void SetLastHint(string hint)
        {
            _lastHint = hint;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetGuess()
        {
            return _guess;
        }

        public string GetHint()
        {
            return _lastHint;
        }
    }
}