using System;
using Raylib_cs;

namespace _07_speed
{
    /// <summary>
    /// Handles all the interaction with the user input library.
    /// </summary>
    public class InputService
    {
        /// <summary>
        /// Will get user input key code.
        /// </summary>
        public int GetInput()
        {
            return Raylib.GetKeyPressed();
        }

        /// <summary>
        /// Converts an input key code to
        /// it's corresponding string
        /// </summary>
        public string ConvertKeyIntToString(int keyInt)
        {
            string keyString = "";
            
            if (keyInt != 0)
            {
                char keyChar = (char)keyInt;
                keyString = keyChar.ToString().ToLower();
            }

            return keyString;
        }

        /// <summary>
        /// Returns true if the user has attempted to close the window.
        /// </summary>
        /// <returns></returns>
        public bool IsWindowClosing()
        {
            return Raylib.WindowShouldClose();
        }
    }
}