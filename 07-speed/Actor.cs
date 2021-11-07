using System;

namespace _07_speed
{
    /// <summary>
    /// Base class for all actors in the game.
    /// </summary>
    public class Actor
    {
        protected Point _position;
        protected Point _velocity;

        protected int _width = 0;
        protected int _height = 0;

        protected string _text = "";

        public Actor()
        {

        }

        public bool HasText()
        {
            return _text != "";
        }

        public bool HasBox()
        {
            return _width > 0 && _height > 0;
        }

        public string GetText()
        {
            return _text;
        }

        public int GetX()
        {
            return _position.GetX();
        }

        public int GetY()
        {
            return _position.GetY();
        }

        public int GetWidth()
        {
            return _width;
        }

        public int GetHeight()
        {
            return _height;
        }

        public Point GetPosition()
        {
            return _position;
        }

        public Point GetVelocity()
        {
            return _velocity;
        }

        public void SetVelocity(Point newVelocity)
        {
            _velocity = newVelocity;
        }

        /// <summary>
        /// Moves the actor forward one space according to the current
        /// velocity.
        /// </summary>
        public void MoveNext()
        {
            int x = _position.GetX();
            int y = _position.GetY();

            int dx = _velocity.GetX();
            int dy = _velocity.GetY();

            int newX = (x + dx) % Constants.MAX_X;
            int newY = (y + dy) % Constants.MAX_Y;

            _position = new Point(newX, newY);
        }

        public override string ToString()
        {
            return $"Position: ({_position.GetX()}, {_position.GetY()}), Velocity({_velocity.GetX()}, {_velocity.GetY()})";
        }

        /// <summary>
        /// Checks if an actor reaches a specific x point in the
        /// drawing.
        /// </summary>
        public bool IsOffScreen()
        {
            return _position.GetX() <= -10;
        }
    }
}