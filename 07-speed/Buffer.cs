using System;
using Raylib_cs;
namespace _07_speed
{
    /// <summary>
    /// Inherits from the actor class.
    /// A class in charge of updating the text in the actor class.
    /// Also creates a string based on user character input
    /// </summary>
    class Buffer : Actor
    {
        InputService _inputService = new InputService();
        OutputService _outputService = new OutputService();

        private string _input = "";
        
        /// <summary>
        /// Sets position of the buffer onto the board with a width and height.
        /// Runs the update text function
        /// </summary>
        public Buffer()
        {
            _position = new Point(1, Constants.MAX_Y - 25);
            _width = 0;
            _height = 0;

            UpdateText();
        }

        /// <summary>
        /// This will update the text inhereted from the actor class.
        /// makes the text varible updated to the input from the buffer.
        /// </summary>
        private void UpdateText()
        {
            _text = $"Buffer: {_input}";
        }

        /// <summary>
        /// Will add a key press to the string displayed
        /// on Buffer.
        /// </summary>
        public void AddInputText(string text)
        {
            _input = _input + text;
            UpdateText();
        }

        /// <summary>
        /// Will delete a character from the end of the
        /// string displayed on Buffer.
        /// </summary>
        public void DeleteInputText()
        {
            _input = _input.Remove(_input.Length - 1);
            UpdateText();
        }

        /// <summary>
        /// Will reset the string that is displayed
        /// on Buffer.
        /// </summary>
        public void ResetInput()
        {
            _input = "";
            UpdateText();
        }
        /// <summary>
        /// A getter to return the what the player types into the buffer
        /// </summary>
        public string GetBufferText()
        {
            return _input;
        }
    }
}
