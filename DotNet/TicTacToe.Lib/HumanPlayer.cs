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
                var availableCellList = board.AvailableCells.Select(cell => cell.GetDisplayName());
                var availableCellNames = string.Join(", ", availableCellList);
                Console.WriteLine();
                Console.WriteLine("Which cell would you like to play in? {0}", availableCellNames);
                Console.Write("Cell #: ");
                var cmdKey = Console.ReadKey().KeyChar.ToString();
                if (Int32.TryParse(cmdKey, out var cellIndex))
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
                else
                {
                    if (cmdKey == "r")
                    {
                        board.Rotate();
                    }
                    else if (cmdKey == "f")
                    {
                        board.Rotate();
                    }
                    else Console.WriteLine("\r\nInvalid selection...");
                    board.PrintConsoleBoard();
                }
            }
        }
    }
}