using System;

namespace _07_speed
{
    /// <summary>
    /// A class to represent a word in the game.
    /// </summary>
    class Word : Actor
    {

        
        /// <summary>
        /// Takes in a string, makes the _text from the actor class equal to the randWord string.
        /// Creates a random position and velocity for the word actor.
        /// </summary>
        public Word(string randomWord)
        {
            // Set random word as text
            _text = randomWord;

            // Initialize position
            Random randNum = new Random();
            int x = Constants.MAX_X;
            int y = randNum.Next(40, Constants.MAX_Y - 40);
            _position = new Point(x, y);

            // Inisitalize velocity
            int dx = randNum.Next(1,3);
            _velocity = new Point(-dx, 0);
        }

        /// <summary>
        /// Returns the word's length to determine the amount of points it's worth.
        /// </summary>
        public int GetPoints()
        {
            return _text.Length;
        }

    }
}