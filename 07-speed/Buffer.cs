
namespace _07_speed
{
    class Buffer : Actor
    {
        InputService _inputService = new InputService();
        public Buffer()
        {
            _position = new Point(1, Constants.MAX_Y - 25);
            _width = 0;
            _height = 0;
            
            UpdateText();
        }

        private void UpdateText()
        {
            _text = $"Buffer: {_inputService.UserKeyString()}";
        }
    }
}
