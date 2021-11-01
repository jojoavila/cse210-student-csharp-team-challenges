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

            int x = Constants.MAX_X - 100;
            int y = randNum.Next(0, Constants.MAX_Y);

            _position = new Point(x, y);

            
            int dx = randNum.Next(1,5);

            _velocity = new Point(-dx, 0);
        }
    }
}