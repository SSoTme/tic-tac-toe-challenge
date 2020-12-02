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

            Console.ReadKey();
        }
    }
}
