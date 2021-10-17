using System;

namespace _05_jumper
{
    public class Jumper
    {
        public int _wrongGuesses;
        public int _rightGuesses;

        public Jumper()
        {
            _wrongGuesses = 0;
            _rightGuesses = 0;
        }

        public bool CheckLetter(string word, char guess)
        {
            int pos = 0;
                foreach (char letter in word)
                {
                    if (letter == guess)
                    {
                        _rightGuesses++;
                        return true;
                    }
                    pos++;
                }
                _wrongGuesses++;
                return false;
        }

        public int GetWrongGuesses()
        {
            return _wrongGuesses;
        }

        public int GetRightGuesses()
        {
            return _rightGuesses;
        }


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