using System;

namespace _06_mastermind
{
    /// <summary>
    /// This class abstracts the User interface for the project. In this case
    /// it wraps calls to the Console to display and get information from the user.

    /// 
    /// Stereotype:
    ///     Service Provider, Interfacer

    /// </summary>
    public class UserService
    {
        public void DisplayText(string text)
        {
            Console.WriteLine(text);
        }

        public string GetUserInput(string promprText)
        {
            Console.Write(promprText);
            string userInput = Console.ReadLine();
            return userInput;
        }
    }
}