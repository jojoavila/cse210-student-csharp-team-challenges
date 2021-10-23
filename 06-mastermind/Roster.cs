using System;
using System.Collections.Generic;

namespace _06_mastermind
{
    /// <summary>
    /// Keeps track of all the players in the game. Provides a way
    /// to get the current player and to advance to the next one.
    /// 
    /// Stereotype:
    ///     Information Holder
    /// </summary>
    class Roster
    {
        private int _currentPlayerIndex = 0;
        private List<Player> _player = new List<Player>();

        public void AddPlayer(Player player)
        {
            _player.Add(player);
        }

        public Player GetCurrentPlayer()
        {
            return _player[_currentPlayerIndex];
        }

        public void AdvanceNextPlayer()
        {
            _currentPlayerIndex = (_currentPlayerIndex + 1) % _player.Count;
        }

        public Player GetPlayer1()
        {
            return _player[0];
        }

        public Player GetPlayer2()
        {
            return _player[1];
        }
    }
}
