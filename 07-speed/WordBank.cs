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
        
        /// <summary>
        /// Initializes the word list
        /// </summary>
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
            // This may seem redundant now, but if it is
            // decided later on to pull a list of words
            // from a file then this is way we'll do that.
            // For now this function is just a place holder.
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

        // The Word object is suppose to be removed from the
        // Word object List declared in the Director class, not
        // a word from the list of available words to choose from.
        //
        // private void RemoveWord()
        // {

        //     foreach(string w in _words)
        //     {
        //         //buffer.match == word
        //         if(true)
        //         {
        //             _wordsToRemove.Add(w);
        //         }
        //     }
        //     foreach(string removalWord in _wordsToRemove)
        //     {
        //         _words.Remove(removalWord);

        //     }
        // }

        /// <summary>
        /// Returns a random word pulled from the list of strings based on their index
        /// </summary>
        public string GetRandomWord()
        {
            Random randomGenerator = new Random();

            return _wordList[randomGenerator.Next(0,_wordList.Count)];
        }
    }
}
