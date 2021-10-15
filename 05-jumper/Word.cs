using System;

namespace _05_jumper
{
    class Word
    {
        Random r = new Random();

        string[] words = {"man", "rat", "cow", "chicken"};

        public string RandomWord()
        {
            string randomWord = (words[r.Next(0, words.Length)]);
            return randomWord;
        }
    }
}