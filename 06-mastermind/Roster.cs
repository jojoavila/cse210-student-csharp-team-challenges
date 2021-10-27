using System;
using System.Collections.Generic;

namespace _06_mastermind
{
    /// <summary>
    /// Keeps track of all the players in the game. Provides a way
    /// to get the current player and to advance to the next one.
    /// </summary>
    class Roster
    {
        private int _currentPlayerIndex = 0;
        private List<Player> _player = new List<Player>();


         /// <summary>
        /// Adds a new player to the list of players
        /// </summary>
        public void AddPlayer(Player player)
        {
            _player.Add(player);
        }

        
         /// <summary>
        /// Gets current player's turn
        /// returns player's index
        /// </summary>
        public Player GetCurrentPlayer()
        {
            return _player[_currentPlayerIndex];
        }

                
        /// <summary>
        /// Swtiches to the next players turn by adding one to player index 
        /// % amount of players in the _player list.
        /// </summary>
        public void AdvanceNextPlayer()
        {
            _currentPlayerIndex = (_currentPlayerIndex + 1) % _player.Count;
        }

        /// <summary>
        /// A getter to obtain the player 1's information outside of this class
        /// returns player 1's information when called.
        /// </summary>
        public Player GetPlayer1()
        {
            return _player[0];
        }

        /// <summary>
        /// A getter to obtain the player 2's information outside of this class
        /// returns player 2's information when called.
        /// </summary>
        public Player GetPlayer2()
        {
            return _player[1];
        }
    }
}
