using DotNet.Lib.Strategies;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TicTacToeChallenge.Lib.DataClasses;

namespace TicTacToe.DotNet.Lib
{
    public class TicTacToeBoard
    {
        public TicTacToeBoard()
        {
            this.Random = new Random();
            this.BoardCells = JsonConvert.DeserializeObject<List<Cell>>(JsonConvert.SerializeObject(Cells.List));
        }

        public Cell UseStrategy<T>()
            where T : StrategyBase, new()
        {
            var strategyHandler = new T();
            var cell = strategyHandler.CheckBoard(this);
            if (!(cell is null)) Console.WriteLine("Successfully used strategy: {0} to play {1}.", typeof(T).Name, cell.Name);
            return cell;
        }

        public Cell GetRandomAvailableCell()
        {
            var randomCell = this.Random.Next(this.AvailableCells.Count);
            var randomAvailableCell = this.AvailableCells[randomCell];
            return randomAvailableCell;
        }


        public void NewGame()
        {
            this.InitBoard();
            while (!this.IsGameOver)
            {
                var player = default(Player);
                if (this.IsYourTurn) player = this.Player1;
                else player = this.Player2;
                var cell = player.Play(this);
                cell.CurrentState = CellStates.List[this.IsYourTurn ? 0 : 1].Name;
                this.IsYourTurn = !this.IsYourTurn;
                this.PrintConsoleBoard();
            }

        }

        private void InitBoard()
        {
            this.IsYourTurn = true;
            this.BoardCells.ForEach(cell => cell.CurrentState = CellStatesEnum.NoPlayer.ToString());
            Console.WriteLine("Player1: {0}", this.Player1.Name);
            Console.WriteLine("Player2: {0}", this.Player2.Name);
            this.PrintConsoleBoard();
        }

        public void AddPlayer(Player player)
        {
            if (this.Player1 == null) this.Player1 = player;
            else if (this.Player2 == null) this.Player2 = player;
            else throw new Exception("both player's already registered");
        }

        public void Rotate()
        {
            var tempCells = JsonConvert.DeserializeObject<List<Cell>>(JsonConvert.SerializeObject(this.BoardCells));
            for (var i = 0; i < 9; i++)
            {
                var rotateFrom = Cells.List[i].RotateIndex.Value;
                this.BoardCells[i].CurrentState = tempCells[rotateFrom].CurrentState;
            }
        }
        public void Flip()
        {
            var tempCells = JsonConvert.DeserializeObject<List<Cell>>(JsonConvert.SerializeObject(this.BoardCells));
            for (var i = 0; i < 9; i++)
            {
                var flipFrom = Cells.List[i].FlipIndex.Value;
                this.BoardCells[i].CurrentState = tempCells[flipFrom].CurrentState;
            }
        }

        public Random Random { get; }
        public List<Cell> BoardCells { get; }
        public Player Player1 { get; private set; }
        public Player Player2 { get; private set; }
        public List<Cell> AvailableCells
        {
            get { return this.BoardCells.Where(cell => cell.CurrentState == CellStatesEnum.NoPlayer.ToString()).ToList(); }
        }
        public bool IsYourTurn { get; private set; }
        public bool IsGameOver
        {
            get { return !this.AvailableCells.Any(); }
        }

        public void PrintConsoleBoard()
        {
            Console.WriteLine(" ---");
            for (int i = 0; i < 9; i++)
            {
                if (i % 3 == 0) Console.Write("-");
                this.PrintCell(i);
                if (i % 3 == 2) Console.WriteLine("");
            }
            Console.WriteLine();
        }

        private void PrintCell(int i)
        {
            if (this.BoardCells[i].CurrentState == CellStates.ByEnum[CellStatesEnum.PlayerA].Name) Console.Write("A");
            else if (this.BoardCells[i].CurrentState == CellStates.ByEnum[CellStatesEnum.PlayerB].Name) Console.Write("B");
            else Console.Write(" ");
        }
    }
}
