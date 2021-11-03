using System;
using Raylib_cs;

namespace _07_speed
{
    /// <summary>
    /// Handles all the interaction with the user input library.
    /// </summary>
    public class InputService
    {
        public InputService()
        {

        }


        private int keyInt = Raylib.GetKeyPressed();
        private string keyString = "";
        public void GetInput()
        {
            if (keyInt != 0)
            {
            char keyChar = (char)keyInt;
            keyString = keyChar.ToString().ToLower();
            }
        }

        /// <summary>
        /// Returns true if the user has attempted to close the window.
        /// </summary>
        /// <returns></returns>
        public bool IsWindowClosing()
        {
            return Raylib.WindowShouldClose();
        }

       public string UserKeyString()
       {
           return keyString;
       }
    }

}