using System;

namespace _07_speed
{
    /// <summary>
    /// The score board in the top portion of the game.
    /// </summary>
    class ScoreBoard : Actor
    {
        private int _points = 0;

        public ScoreBoard()
        {
            _position = new Point(1, 0);
            _width = 0;
            _height = 0;
            
            UpdateText();
        }

        /// <summary>
        /// Increments the points by the amount specified and updates the
        /// text.
        /// </summary>
        /// <param name="points"></param>
        public void AddPoints(int points)
        {
            _points += points;
            UpdateText();
        }

        /// <summary>
        /// Removes points worth half the amount of characters in a word.
        /// </summary>
        public void RemovePoints(int points)
        {
            _points -= points / 2;
            UpdateText();
        }

        /// <summary>
        /// Updates the text to reflect the new points amount.
        /// This should be called whenever the points are updated.
        /// </summary>
        private void UpdateText()
        {
            _text = $"Score: {_points}";
        }

        public int GetPoints()
        {
            return _points;
        }
    }
}