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
            List<Cell> availableCells = board.AvailableCells;

            var availableCellNames = string.Join(", ", availableCells.Select(cell => cell.CellIndex + 1));

            Console.WriteLine("Which cell would you like to play in? {0}", availableCellNames);
            Console.Write("Cell #: ");
            var newCell = Console.ReadKey().KeyChar.ToString();
            Console.WriteLine();
            var cellIndex = Int32.Parse(newCell);
            var selectedCell = availableCells.FirstOrDefault(cell => cell.CellIndex == cellIndex - 1);
            Console.WriteLine("You selected Cell: {0}", selectedCell.Name);
            return selectedCell;
        }
        
    }
}