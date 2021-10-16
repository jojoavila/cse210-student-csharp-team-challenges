using System;

namespace _05_jumper
{
    /// <summary>
    /// The Word class is responsible for creating a list of secret words.
    /// Then choosing a word at random from the list.
    ///
    /// </summary>
    class Word
    {
        Random r = new Random();

        string[] words = {"man", "rat", "cow", "chicken"};

        /// <summary>
        /// Pulls from the list of words from the class, then chooses one at random
        /// as the secret word for the jumper game.
        /// </summary>
        public string RandomWord()
        {
            string randomWord = (words[r.Next(0, words.Length)]);
            return randomWord;
        }
    }
}