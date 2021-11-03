using System;
using System.Collections.Generic;


namespace _07_speed
{
    /// <summary>
    /// A class to have a word bank, get random word from array, create a new word class with random word
    /// </summary>
    public class WordBank
    {

        private List<string> _words = new List<string> 
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
            "darkness",
        };

        private List<string> _wordsToRemove = new List<string>{};

        private string _randWord;


        public WordBank()
        {
            GetRandomWord();
        }
        public string GetRandomWord()
        {
            Random randomGenerator = new Random();
            int num = randomGenerator.Next(0,17);
            _randWord =_words[num];

            return _randWord; 
        }
        
        private void RemoveWord()
        {

            foreach(string w in _words)
            {
                //buffer.match == word
                if(true)
                {
                    _wordsToRemove.Add(w);
                }
            }
            foreach(string removalWord in _wordsToRemove)
            {
                _words.Remove(removalWord);

            }
            
            // how to remove from list, for each word in list of words
            // if (buffer.match)
            // _wordsToRemve.add(w)

        // add the list into a new list,
        // go through new list and remove them from the old list
        // for each word removalWord in words to remove
        // _words.remove(removal word)
        }
 
    }


}