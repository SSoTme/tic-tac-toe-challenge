using System;
using TicTacToe.DotNet.Lib;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TicTacToe DotNet!");
            var tttBoard = new TicTacToeBoard();
            tttBoard.PrintConsoleBoard();
            tttBoard.Rotate();
            tttBoard.PrintConsoleBoard();
            tttBoard.Flip();
            tttBoard.PrintConsoleBoard();
            Console.ReadKey();
        }
    }
}
