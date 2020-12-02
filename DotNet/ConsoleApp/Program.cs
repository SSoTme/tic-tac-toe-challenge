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
            tttBoard.AddPlayer(new HumanPlayer("ej"));
            tttBoard.AddPlayer(new BeginnerPlayer());
            tttBoard.NewGame();
            Console.ReadKey();
        }
    }
}
