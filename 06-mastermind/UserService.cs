using System;

namespace _06_mastermind
{
    /// <summary>
    /// This class abstracts the User interface for the project. In this case
    /// it wraps calls to the Console to display and get information from the user.
    /// </summary>
    public class UserService
    {
        /// <summary>
        /// Displays the provided text.
        /// </summary>
        /// <param name="text">The text to display</param>
        public void DisplayText(string text)
        {
            Console.WriteLine(text);
        }

        /// <summary>
        /// Gets a string value from the user after displaying the provided prompt text.
        /// </summary>
        /// <param name="promptText">The text to display as a prompt</param>
        /// <returns>The user's response</returns>
        public string GetStringInput(string promptText)
        {
            Console.Write(promptText);
            string userInput = Console.ReadLine();

            return userInput;
        }
    }
}