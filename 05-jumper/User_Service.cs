using System;

namespace _05_jumper
{
    public class User_Service
    {
        


        public char GetLetterGuess(string promptText)
        {
            Console.Write(promptText);
            string userInput = Console.ReadLine();

            // Converts 
            var letter = userInput[0];
            return letter;
        }

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
    }
}