using System;

namespace _05_jumper
{
    public class User_Service
    {
        string UserGuess()
        {
            Console.WriteLine($"Guess a letter [a-z]: ");
            string guess = Console.ReadLine();
            
            return guess;
        }
    }
}