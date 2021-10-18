using System;
using System.Collections.Generic;

namespace _05_jumper
{
    /// <summary>
    /// The Word class is responsible for creating a list of secret words.
    /// Then choosing a word at random from the list.
    ///
    /// </summary>
    public class Word
    {
        public List<string> _words = new List<string> 
        {
            "man",
            "rat",
            "cow",
            "chicken"
        };
        
        public Word()
        {
            
        }
/// <summary>
/// Pulls from the list of words from the class, then chooses one at random
/// as the secret word for the jumper game.
/// </summary>
        public string RandomWord()
        {
            Random r = new Random();
            string randomWord = (_words[r.Next(0, _words.Count)]);
            return randomWord;
        }
    }
}