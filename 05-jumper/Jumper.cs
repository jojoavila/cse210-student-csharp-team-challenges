using System;

namespace _05_jumper
{
    public class Jumper
    {
        public int _wrongGuesses;

        public Jumper()
        {
            _wrongGuesses = 0;
        }

        /// <summary>
        /// Compares the user's selected letter to the random
        /// word being used. If that letter ins't found within
        /// the word the number of wrong guesses will go up one.
        /// </summary>
        public bool CheckLetter(string word, char guess)
        {
            int pos = 0;
                foreach (char letter in word)
                {
                    if (letter == guess)
                    {
                        return true;
                    }
                    pos++;
                }
                _wrongGuesses++;
                return false;
        }

        /// <summary>
        /// Returns the number of wrong guesses.
        /// </summary>
        public int GetWrongGuesses()
        {
            return _wrongGuesses;
        }

        /// <summary>
        /// Returns whether the jumper is alive or not.
        /// </summary>
        public bool IsAlive()
        {
            if (_wrongGuesses == 4)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}