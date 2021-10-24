using System;

namespace _06_mastermind
{
    /// <summary>
    /// This class abstracts the User interface for the project. 
    /// puts all the userinput into one place
    //  we can also display text with this class.

    /// </summary>
    public class UserService
    {

    /// <summary>
    /// This function takes in a string and displays it to the console.
    /// </summary>
        public void DisplayText(string text)
        {
            Console.WriteLine(text);
        }


    /// <summary>
    /// This function takes a string and displays it as a prompt text
    /// takes in the user input and returns it.
    /// </summary>
        public string GetUserInput(string promprText)
        {
            Console.Write(promprText);
            string userInput = Console.ReadLine();
            return userInput;
        }
    }
}