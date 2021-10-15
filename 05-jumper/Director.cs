using System;

namespace _05_jumper
{
    public class Director
    {
        public bool _keepPlaying;
        public Word _word;
        
        public Director()
        {
            _keepPlaying = true;
            _word = new Word();
        }

        /// <summary>
        /// This method starts the game and continues running until it is finished.
        /// </summary>
        public void StartGame()
        {
            while (_keepPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

       
        public void GetInputs()
        {
            string w = _word.RandomWord();
            Console.WriteLine(w);
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