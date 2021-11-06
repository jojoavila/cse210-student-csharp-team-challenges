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

            // _outputService.DrawText(1, Constants.MAX_Y - 25, $"Buffer: {_text}", true);
            UpdateText();
        }

        private void UpdateText()
        {
            
            _text = $"Buffer: {_input}";

        }

        // public void DisplayBuffer()
        // {
        //     _text = $"Buffer: {_inputService.UserKeyString()}";
        // }

        public void AddInput(string input2)
        {
            _input = _input + input2;
            UpdateText();
        }
        public void CleaningBuffer(string input)
        {
            _input = input;
            UpdateText();
        }
    }
}
