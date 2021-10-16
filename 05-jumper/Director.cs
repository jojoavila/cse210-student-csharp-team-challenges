using System;

namespace _05_jumper
{
    public class Director
    {
        public bool _keepPlaying;
        public Word _word;
        public Board _board;

        public Director()
        {
            _keepPlaying = true;
            _word = new Word();
            _board = new Board();
            _board.generateBoard();
        }

        /// <summary>
        /// This method starts the game and continues running until it is finished.
        /// Calls the RandomWord function and chooses a random secret word from the list
        /// that will be used in the game
        /// </summary>
        public void StartGame()
        {
            while (_keepPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

       
        public void GetInputs()
        {
            // debug code
            Console.WriteLine(_word._word);

            _board.displayBoard(0, _word._coveredWord);

            Console.Write("Guess a letter [a-z]: ");
            string letter = Console.ReadLine();
        }

       
        public void DoUpdates()
        {
            throw new NotImplementedException();
        }

       
        public void DoOutputs()
        {
            throw new NotImplementedException();
        }
    }
}