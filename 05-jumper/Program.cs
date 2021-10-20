using System;

namespace _05_jumper
{
    class Program
    {
        static void Main(string[] args)
        {
            Director theDirector = new Director();
            theDirector.StartGame();
            Console.WriteLine("Brighton");
        }
    }
}