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

                
        /// <summary>
        /// If the actor has text, returns true.
        /// </summary>
        public bool HasText()
        {
            return _text != "";
        }

        /// <summary>
        /// If the actor has a width and a height,
        /// returns true.
        /// </summary>
        public bool HasBox()
        {
            return _width > 0 && _height > 0;
        }

        /// <summary>
        /// A getter to return a text member variable.
        /// </summary>
        public string GetText()
        {
            return _text;
        }

         /// <summary>
        /// A getter to return the X position of the actor
        /// </summary>
        public int GetX()
        {
            return _position.GetX();
        }

        /// <summary>
        /// A getter to return the Y position of the actor
        /// </summary>
        public int GetY()
        {
            return _position.GetY();
        }
        /// <summary>
        /// A getter to return the width of the actor.
        /// </summary>
        public int GetWidth()
        {
            return _width;
        }

        /// <summary>
        /// A getter to return the height of the actor.
        /// </summary>
        public int GetHeight()
        {
            return _height;
        }

        /// <summary>
        /// A getter to return the position of the actor from the point class.
        /// </summary>
        public Point GetPosition()
        {
            return _position;
        }

        /// <summary>
        /// A getter to return the velocity form the point class.
        /// </summary>
        public Point GetVelocity()
        {
            return _velocity;
        }

        /// <summary>
        /// Accepts user input as a point to set a new velocity
        /// </summary>
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

        /// <summary>
        /// Returns the position x and y, and the velocity in the x and y.
        /// </summary>
        public override string ToString()
        {
            return $"Position: ({_position.GetX()}, {_position.GetY()}), Velocity({_velocity.GetX()}, {_velocity.GetY()})";
        }
         /// <summary>
        /// Return's true if the actor is off screen.
        /// </summary>
        public bool IsOffScreen()
        {
            return _position.GetX() <= -10;
        }

    }

}