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

        public Player(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }
    }
}