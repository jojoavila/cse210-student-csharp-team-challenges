using System;
using System.Collections.Generic;

namespace _05_jumper
{
    /// <summary>
    /// This class is responsible for creating a new board.
    /// Also stores the amount of wrong guesses
    /// This class also updates the board based on the amount of wrong guesses.
    /// </summary>
    public class Board
    {
        
        public List<string> STATIC_BOARD = new List<string> { 
            "  /|\\  ",
            "  / \\  ",
            "        ",
            "^^^^^^^^" 
        };

        public List<string> _paracuteList = new List<string>();
           
        public Board()
        {
            generateBoard();
        }
        /// <summary>
        /// The generateBoard function creates a new board state for a new game instance.
        /// clears the previous list(board) and adds the board to an empty list
        ///
        /// </summary>

        public void generateBoard() {
            _paracuteList.Clear();

            _paracuteList.Add("  ___  ");
            _paracuteList.Add(" /___\\ ");
            _paracuteList.Add(" \\   / ");
            _paracuteList.Add("  \\ /  ");
            _paracuteList.Add("   0   ");
        }


        /// <summary>
        /// The displayBoard function will update the board with incorrect guesses/
        /// also keeps track of those incorrect guesses and shows the game over screen when 
        /// incorrect guesses reaches 4
        /// </summary>
        public bool displayBoard(int wrongGuesses, string coveredWord, bool isRightGuess) {
            
            Console.WriteLine(coveredWord);

            if (wrongGuesses < 4) 
            {
                Console.WriteLine($"Before chute delete: {wrongGuesses}");
                if (!isRightGuess)
                {
                    _paracuteList.RemoveAt(0);
                }

                for (int i = 0; i < _paracuteList.Count; i++) 
                {
                    Console.WriteLine(_paracuteList[i]);
                }
            }
            else 
            {
                Console.WriteLine("   x   ");
            }

            for (int i = 0; i < STATIC_BOARD.Count; i++) 
            {
                Console.WriteLine(STATIC_BOARD[i]);
            }
            
            return true;
        }
    }
}