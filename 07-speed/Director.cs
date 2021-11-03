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

        OutputService _outputService = new OutputService();
        //InputService _inputService = new InputService();

        private List<Word> _words = new List<Word>();
        
        ScoreBoard _scoreBoard = new ScoreBoard();

        Random _randomGenerator = new Random();

        WordBank _wordBank = new WordBank();

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

        }

        /// <summary>
        /// Update any of the actors.
        /// </summary>
        private void DoUpdates()
        {
            foreach (Word word in _words)
            {
                word.MoveNext();
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

            foreach (Word word in _words)
            {
                _outputService.DrawActor(word);
            }
            

            _outputService.EndDrawing();
        }


        /// <summary>
        /// Returns true if the two actors are overlapping.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public bool IsCollision(Actor first, Actor second)
        {
            int x1 = first.GetX();
            int y1 = first.GetY();
            int width1 = first.GetWidth();
            int height1 = first.GetHeight();

            Raylib_cs.Rectangle rectangle1
                = new Raylib_cs.Rectangle(x1, y1, width1, height1);

            int x2 = second.GetX();
            int y2 = second.GetY();
            int width2 = second.GetWidth();
            int height2 = second.GetHeight();

            Raylib_cs.Rectangle rectangle2
                = new Raylib_cs.Rectangle(x2, y2, width2, height2);

            return Raylib.CheckCollisionRecs(rectangle1, rectangle2);
        }

        public void WordCleanUp()
        {
            List<Word> wordsToRemove = new List<Word>();

            foreach (Word word in _words)
            {
                if (word.IsOffScreen())
                {
                    wordsToRemove.Add(word);
                }
            }

            foreach (Word word in wordsToRemove)
            {
                _words.Remove(word);   
            }

            wordsToRemove.Clear();
        }

        ///<summary>
        ///
        ///
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