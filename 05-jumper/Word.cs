using System;
using System.Collections.Generic;

namespace _05_jumper
{
    /// <summary>
    /// The Word class is responsible for creating a list of secret words.
    /// Then choosing a word at random from the list.
    ///
    /// </summary>
    public class Word
    {
        public List<string> _words = new List<string> 
        {
            "man",
            "rat",
            "cow",
            "chicken",
            "house",
            "car",
            "cave",
            "computer",
            "programming",
            "cheese",
            "mouse",
            "light",
            "carrot",
            "block",
            "pen"
        };

        public string _randomWord;
        public string _coveredWord;
        
        public Word()
        {
            RandomWord();
            _coveredWord = _randomWord;
            CoveredWord();
        }

        /// <summary>
        /// Pulls from the list of words from the class, then chooses one at random
        /// as the secret word for the jumper game.
        /// </summary>
        public void RandomWord()
        {
            Random r = new Random();
            _randomWord = (_words[r.Next(0, _words.Count)]);
        }

        /// <summary>
        /// Uses the randomly selected word and initializes it
        /// as a series of underscores to be used by the game.
        /// </summary>
        public void CoveredWord()
        {
            for (int i = 0; i < _coveredWord.Length; i++)
            {
                _coveredWord = _coveredWord.Remove(i, 1).Insert(i, "_");
            }       
        }

        /// <summary>
        /// Will replace the underscores of the covered word with all
        /// instances of the user selected letter.
        /// </summary>
        public void replaceUnderScore(char letterGuess)
        {
            int pos = 0;
            foreach (char letter in _randomWord)
            {
                if (letter == letterGuess)
                {
                    _coveredWord = _coveredWord.Remove(pos, 1).Insert(pos, letterGuess.ToString());
                }
                pos++;
            }
        }

        /// <summary>
        /// Returns the covered word.
        /// </summary>
        public string GetCoveredWord()
        {
            return _coveredWord;
        }

        /// <summary>
        /// Returns the randomly selected word.
        /// </summary>
        public string GetRandomWord()
        {
            return _randomWord;
        }

    }
}