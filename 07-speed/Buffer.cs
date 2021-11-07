using System;
using Raylib_cs;
namespace _07_speed
{
    class Buffer : Actor
    {
        InputService _inputService = new InputService();
        OutputService _outputService = new OutputService();

        private string _input = "";
        public Buffer()
        {
            _position = new Point(1, Constants.MAX_Y - 25);
            _width = 0;
            _height = 0;

            UpdateText();
        }

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

        public string GetBufferText()
        {
            return _input;
        }
    }
}
