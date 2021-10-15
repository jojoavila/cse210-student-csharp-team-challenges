using System;

namespace _05_jumper
{
    public class Director
    {
        
        Word _word = new Word();
        
        

        /// <summary>
        /// This method starts the game and continues running until it is finished.
        /// </summary>
        public void StartGame()
        {
            string w = _word.RandomWord();
            Console.WriteLine(w);
        }

       
        public void GetInputs()
        {
            throw new NotImplementedException();
        }

       
        public void DoUpdates()
        {
            throw new NotImplementedException();
        }

       
        public void DoOutputs()
        {
            throw new NotImplementedException();
        }
    }
}