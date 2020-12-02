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
            else Console.WriteLine("{0} player, playing at {1}", this.Name, cell.Name);
        }

    }
}