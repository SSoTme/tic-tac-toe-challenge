using System;
using System.Collections.Generic;
using System.Linq;
using TicTacToeChallenge.Lib.DataClasses;

namespace TicTacToe.DotNet.Lib
{
    public class HumanPlayer : Player
    {
        private string Name;

        public HumanPlayer(string name)
            : base(name)
        {
        }

        public override Cell Play(TicTacToeBoard board)
        {

            while (true)
            {
                var availableCellNames = string.Join(", ", board.AvailableCells.Select(cell => cell.CellIndex + 1));
                Console.WriteLine();
                Console.WriteLine("Which cell would you like to play in? {0}", availableCellNames);
                Console.Write("Cell #: ");
                var cmdKey = Console.ReadKey().KeyChar.ToString();
                if (cmdKey == "r")
                {
                    board.Rotate();
                    board.PrintConsoleBoard();
                }
                else if (cmdKey == "f")
                {
                    board.Rotate();
                    board.PrintConsoleBoard();
                }
                else if (Int32.TryParse(cmdKey, out var cellIndex))
                {
                    Console.WriteLine();
                    var selectedCell = board.AvailableCells.FirstOrDefault(cell => cell.CellIndex == cellIndex - 1);
                    if (selectedCell is null) Console.WriteLine("That is not a valid choice - sorry.");
                    else
                    {
                        Console.WriteLine("You selected Cell: {0}", selectedCell.Name);
                        return selectedCell;
                    }
                }
                else Console.WriteLine("\r\nInvalid selection...");
            }
        }

    }
}