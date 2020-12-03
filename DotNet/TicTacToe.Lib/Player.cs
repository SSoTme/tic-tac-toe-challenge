using System;
using TicTacToeChallenge.Lib.DataClasses;

namespace TicTacToe.DotNet.Lib
{
    public abstract class Player
    {
        public string Name { get; set; }
        public Random Random { get; set; }

        protected Player(string name)
        {
            this.Random = new Random();
            this.Name = name;
        }

        public abstract Cell Play(TicTacToeBoard board);

        protected void DisplayCellChoice(Cell cell)
        {
            if (cell is null) Console.WriteLine("\r\nNo cell chosen");
            else {
                var strategyIfPresent = String.IsNullOrEmpty(cell.ChosenUsingStrategy) ? "" : $"Chosen using {cell.ChosenUsingStrategy}";
                Console.WriteLine($"{this.Name} player, playing at {cell.Name}{strategyIfPresent}");
            }
        }

    }
}