using System;
using System.Collections.Generic;

namespace _05_jumper
{
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
        
        public string RandomWord()
        {
            Random r = new Random();
            string randomWord = (_words[r.Next(0, _words.Count)]);
            return randomWord;
        }
    }
}