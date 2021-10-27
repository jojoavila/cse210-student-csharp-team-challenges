using System;
using Raylib_cs;

namespace _07_snake
{
    /// <summary>
    /// Handles all the interaction with the user input library.
    /// </summary>
    public class InputService
    {
        public InputService()
        {

        }


        //int keyInt = Raylib.GetKeyPressed();
        //string keyString = "";
        //if (keyInt != 0)
        //{
        // char keyChar = (char)keyInt;
        //keyString = keyChar.ToString().ToLower();
        //}

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