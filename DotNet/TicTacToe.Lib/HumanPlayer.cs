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
                var availableCellList = board.AvailableCells.Select(cell => cell.ToString(true));
                var availableCellNames = string.Join(Environment.NewLine, availableCellList);
                Console.WriteLine();
                Console.WriteLine("Which cell would you like to play in? {0}{1}", Environment.NewLine, availableCellNames);
                Console.Write("Cell #: ");
                var cmdKey = Console.ReadKey().KeyChar.ToString();
                if (Int32.TryParse(cmdKey, out var cellKey))
                {
                    Console.WriteLine();
                    var selectedCell = board.AvailableCells.FirstOrDefault(cell => cell.CellKey == cellKey);
                    if (selectedCell is null) Console.WriteLine("That is not a valid choice - sorry.");
                    else
                    {
                        Console.Clear();
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