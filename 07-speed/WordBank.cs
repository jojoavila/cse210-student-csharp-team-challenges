using System;
using System.Collections.Generic;


namespace _07_speed
{
    /// <summary>
    /// A class to have a word bank, get random word from array, create a new word class with random word
    /// </summary>
    public class WordBank
    {
        private List<string> _wordList = new List<string>();

        public WordBank()
        {
            InitializeWordList();
        }
        
        /// <summary>
        /// Prepares a word bank to be used when
        /// creating new Word objects.
        /// </summary>
        private void InitializeWordList()
        {
            List<string> wordList = new List<string>
            {
                "person",
                "dog",
                "cart",
                "chicken",
                "house",
                "car",
                "laptop",
                "computer",
                "programming",
                "refridgerator",
                "notebook",
                "light",
                "onion",
                "pen",
                "pencil",
                "world",
                "power",
                "darkness"
            };

            _wordList = wordList;
        }

        /// <summary>
        /// Returns a random word from the list stored in
        /// WordBank.
        /// </summary>
        public string GetRandomWord()
        {
            Random randomGenerator = new Random();

            return _wordList[randomGenerator.Next(0,_wordList.Count)];
        }
    }
}
