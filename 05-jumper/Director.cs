using System;

namespace _05_jumper
{
    public class Director
    {
        public bool _keepPlaying;
        public Word _word;
        public Board _board;
        public Jumper _jumper;
        public bool _isRightGuess;

        public User_Service _userService;
        public char _letter;

        public Director()
        {
            _word = new Word();
            _board = new Board();
            _userService = new User_Service();
            _jumper = new Jumper();
            _keepPlaying = true;
            _letter = ' ';
            _isRightGuess = true;
        }

        /// <summary>
        /// This method starts the game and continues running until it is finished.
        /// Calls the RandomWord function and chooses a random secret word from the list
        /// that will be used in the game
        /// </summary>
        public void StartGame()
        {
            _board.displayBoard(_jumper.GetWrongGuesses(), _word.GetCoveredWord(), _isRightGuess);

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
            Console.WriteLine(_word.GetRandomWord());

            

            string prompt = "Guess a letter [a-z]: ";
            _letter = _userService.GetLetterGuess(prompt);
        }

       
        public void DoUpdates()
        {
            _isRightGuess = _jumper.CheckLetter(_word.GetRandomWord(), _letter);
            if (_isRightGuess)
            {
                _word.replaceUnderScore(_letter);
            }

            Console.WriteLine(_jumper.GetWrongGuesses());


            if (!_jumper.IsAlive() || _word.GetRandomWord() == _word.GetCoveredWord())
            {
                _keepPlaying = false;
            }
        }

       
        public void DoOutputs()
        {
            _isRightGuess = _board.displayBoard(_jumper.GetWrongGuesses(), _word.GetCoveredWord(), _isRightGuess);

            _userService.EndMessage(_jumper.IsAlive(), _word.GetRandomWord(), _word.GetCoveredWord());
        }
    }
}