using System;

namespace _05_jumper
{
    public class User_Service
    {
        
        /// <summary>
        /// Asks user for a guess and converts it
        /// to a useable char variable.
        /// </summary>
        public char GetLetterGuess(string promptText)
        {
            Console.Write(promptText);
            string userInput = Console.ReadLine();

            // Converts userInput to a char
            var letter = userInput[0];
            return letter;
        }

        /// <summary>
        /// Displays a message depending on what triggered the game's end state.
        /// </summary>
        public void EndMessage(bool isAlive, string word, string coveredWord)
        {
            if (isAlive == false) 
            {
                Console.WriteLine("Oh no! You lost. Thanks for playing.");
            }
            else if (word == coveredWord)
            {
                Console.WriteLine("Congrats! You won!");
            }
        }

        string UserGuess()
        {
            Console.WriteLine($"Guess a letter [a-z]: ");
            string guess = Console.ReadLine();
            
            return guess;

        }
    }    
}