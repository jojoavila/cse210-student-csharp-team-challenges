using System;
using System.Collections.Generic;

namespace _05_jumper
{
    class Board
    {
        public List<string> STATIC_BOARD = new List<string> { 
            "  /|\\  ",
            "  / \\  ",
            "        ",
            "^^^^^^^^" 
        };

        public List<string> _paracuteList = new List<string>();
        public int _wrongGuesses;    

        public void generateBoard() {
            _paracuteList.Clear();

            _paracuteList.Add("  ___  ");
            _paracuteList.Add(" /___\\ ");
            _paracuteList.Add(" \\   / ");
            _paracuteList.Add("  \\ /  ");
            _paracuteList.Add("   0   ");
        }

        public void displayBoard() {
            _wrongGuesses = 3;

            if (_wrongGuesses < 4) {
                for (int i = 0; i < _wrongGuesses; i++) {
                    _paracuteList.RemoveAt(0);
                }

                for (int i = 0; i < _paracuteList.Count; i++) {
                    Console.WriteLine(_paracuteList[i]);
                }
            }
            else {
                Console.WriteLine("   x   ");
            }

            for (int i = 0; i < STATIC_BOARD.Count; i++) {
                Console.WriteLine(STATIC_BOARD[i]);
            }
            
        }
    
    }
}