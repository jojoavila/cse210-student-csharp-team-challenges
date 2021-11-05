using System;
using System.Collections.Generic;
using Raylib_cs;

namespace _07_speed
{
    /// <summary>
    /// The director is responsible to direct the game, including to keep track of all
    /// the actors and to control the sequence of play.
    /// 
    /// Stereotype:
    ///     Controller
    /// </summary>
    public class Director
    {
        private bool _keepPlaying = true;
        Buffer _buffer = new Buffer();

        OutputService _outputService = new OutputService();
        InputService _inputService = new InputService();

        private List<Word> _words = new List<Word>();
        private List<Word> _wordsToRemove = new List<Word>();
        
        ScoreBoard _scoreBoard = new ScoreBoard();

        Random _randomGenerator = new Random();

        WordBank _wordBank = new WordBank();

        private int _keyInt;

        /// <summary>
        /// This method starts the game and continues running until it is finished.
        /// </summary>
        public void StartGame()
        {
            PrepareGame();

            while (_keepPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }

            Console.WriteLine("Game over!");
        }

        /// <summary>
        /// Performs any initial setup for the game.
        /// </summary>
        private void PrepareGame()
        {
            _outputService.OpenWindow(Constants.MAX_X, Constants.MAX_Y, "Speed", Constants.FRAME_RATE);

            for (int i = 0; i < _randomGenerator.Next(2,5); i++)
            {
                Word w = new Word(_wordBank.GetRandomWord());
                _words.Add(w);
            }
        }

        /// <summary>
        /// Get any input needed from the user.
        /// </summary>
        private void GetInputs()
        {
            _keyInt =_inputService.GetInput();
        }

        /// <summary>
        /// Update any of the actors.
        /// </summary>
        private void DoUpdates()
        {
            // To parse through the input to get the desired action.
            if (_keyInt == 257)
            {
                CompareBufferToWord();
                _buffer.ResetInput();
            }
            else if (_keyInt == 259)
            {
                _buffer.DeleteInputText();
            }
            else
            {
                string text = _inputService.ConvertKeyIntToString(_keyInt);
                _buffer.AddInputText(text);
            }

            foreach (Word word in _words)
            {
                word.MoveNext();

                if (word.IsOffScreen())
                {
                    _wordsToRemove.Add(word);
                }
            }

            AddNewWords();
            WordCleanUp();
        }

        /// <summary>
        /// Display the updated state of the game to the user.
        /// </summary>
        private void DoOutputs()
        {
            _outputService.StartDrawing();

            _outputService.DrawActor(_scoreBoard);
            _outputService.DrawActor(_buffer);
          
            foreach (Word word in _words)
            {
                _outputService.DrawActor(word);
            }
          
            _outputService.EndDrawing();
        }

        public void WordCleanUp()
        {
            // foreach (Word word in _words)
            // {
                
            // }

            foreach (Word word in _wordsToRemove)
            {
                _words.Remove(word);   
            }

            _wordsToRemove.Clear();
        }

        ///<summary>
        /// Compares the Buffer string all Word objects
        /// currently on the screen. If they match, the
        /// onscreen word is added to the list of Word
        /// objects to be removed.
        ///</summary>
        public void CompareBufferToWord()
        {
            foreach (Word word in _words)
            {
                if (word.GetText() == _buffer.GetBufferText())
                {
                    _wordsToRemove.Add(word);
                }
            }
        }

        ///<summary>
        /// Will add new Word objects to the Word object List
        /// if there are less words on screen than the limit
        ///</summary>
        public void AddNewWords()
        {
            if (_words.Count < Constants.ON_SCREEN_WORD_LIMIT)
            {
                double conditionNum = _randomGenerator.NextDouble();
                // Console.WriteLine($"Random Number: {conditionNum}");

                if (conditionNum > .98)
                {
                    Word w = new Word(_wordBank.GetRandomWord());
                    _words.Add(w);
                }
            }
        }

    }

}