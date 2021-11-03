using System;
using System.Collections.Generic;


namespace _07_speed
{
    /// <summary>
    /// A class to have a word bank, get random word from array, create a new word class with random word
    /// </summary>
    public class WordBank
    {

        public List<string> _words = new List<string> 
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


        public WordBank()
        {
            
        }

        // make new list, wordsToRemove
        public void RemoveWord()
        {
            // how to remove from list, for each word in list of words
            // if (buffer.match)
            // _wordsToRemve.add(w)
        }
        // add the list into a new list,
        // go through new list and remove them from the old list
        // for each word removal word in words to remove
        // _words.remove(removal word)
        // random number 0-1, 

        public string GetRandomWord()
        {
            Random randomGenerator = new Random();

            return _words[randomGenerator.Next(0,_words.Count)];
        }
    }


}