using System;

namespace _07_speed
{
    /// <summary>
    /// A class to represent a word in the game.
    /// </summary>
    class Word : Actor
    {
        public Word(string randomWord)
        {
            Random randNum = new Random();

            _text = randomWord;

            int x = Constants.MAX_X;
            int y = randNum.Next(40, Constants.MAX_Y - 40);

            _position = new Point(x, y);

            
            int dx = randNum.Next(1,3);

            _velocity = new Point(-dx, 0);
        }

        public int GetPoints()
        {
            return _text.Length;
        }

    }
}