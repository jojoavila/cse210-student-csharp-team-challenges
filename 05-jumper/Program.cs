using System;

namespace _05_jumper
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();    
            Console.WriteLine("Starting point for the Jumper project.");
            board.generateBoard();
            board.displayBoard();
        }
    }
}
