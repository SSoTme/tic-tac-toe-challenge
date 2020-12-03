using DotNet.Lib.CellPatterns;
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
        public List<Cell> BoardCells { get; private set; }
        public Player Player1 { get; private set; }

        internal Cell TryToMatchCellPattern<T>()
            where T : MatchingPatternBase, new()
        {
            var matchingPattern = new T();
            return matchingPattern.CheckForMatch(this);
        }

        public Player Player2 { get; private set; }
        public bool IsYourTurn { get; private set; }
        public bool IsGameOver { get; set; }
        private string SavedPosition { get; set; }
        public Random Random { get; }

        public TicTacToeBoard()
        {
            this.Random = new Random();
            this.BoardCells = JsonConvert.DeserializeObject<List<Cell>>(JsonConvert.SerializeObject(Cells.List));
        }

        internal string GetCurrentPlayerState()
        {
            return CellStates.List[this.IsYourTurn ? 0 : 1].Name;
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
            if (!this.AvailableCells.Any()) return default(Cell);
            else
            {
                var randomCell = this.Random.Next(this.AvailableCells.Count);
                var randomAvailableCell = this.AvailableCells[randomCell];
                return randomAvailableCell;
            }
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
                if (cell is null)
                {
                    Console.WriteLine("Game over");
                    this.IsGameOver = true;
                }
                else
                {
                    cell.CurrentState = CellStates.List[this.IsYourTurn ? 0 : 1].Name;
                    this.CheckForWin();
                    this.IsYourTurn = !this.IsYourTurn;
                }
                this.PrintConsoleBoard();
            }

        }

        private void CheckForWin()
        {
            this.SavePosition();
            if (this.CheckForWin<EdgeWinPattern>() ||
                this.CheckForWin<DiagonalWinPattern>() ||
                this.CheckForWin<MiddleWinPattern>())
            {
                var gameOverStr = LanguageTokens.ByEnum[LanguageTokensEnum.GameOver].DisplayName;
                var youWon = LanguageTokens.ByEnum[LanguageTokensEnum.YouWon].DisplayName;
                var theyWon = LanguageTokens.ByEnum[LanguageTokensEnum.TheyWon].DisplayName;
                var wonStr = this.IsYourTurn ? youWon : theyWon;
                Console.WriteLine("{2} ({3}) - " +
                    "{0}: {1} - ", gameOverStr, wonStr, this.GetCurrentPlayer().Name, this.GetCurrentPlayerState());
                this.IsGameOver = true;
            }
            this.RestorPosition();
        }

        private Player GetCurrentPlayer()
        {
            return this.IsYourTurn ? this.Player1 : this.Player2;
        }

        public void RestorPosition()
        {
            this.BoardCells = JsonConvert.DeserializeObject<List<Cell>>(this.SavedPosition);
        }

        public void SavePosition()
        {
            this.SavedPosition = JsonConvert.SerializeObject(this.BoardCells);
        }

        private bool CheckForWin<T>()
            where T : WinningPatternBase, new()
        {
            var winPattern = new T();
            return winPattern.CheckForWin(this);
        }

        private void InitBoard()
        {
            this.IsGameOver = false;
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

        public List<Cell> AvailableCells
        {
            get { return this.BoardCells.Where(cell => cell.CurrentState == CellStatesEnum.NoPlayer.ToString()).ToList(); }
        }
        public void PrintConsoleBoard()
        {
            Console.WriteLine("   | | |");
            for (int i = 0; i < 9; i++)
            {
                if (i % 3 == 0) Console.Write("--");
                this.PrintCell(i);
                if (i % 3 == 2) Console.WriteLine("");
            }
            Console.WriteLine();
        }

        private void PrintCell(int i)
        {
            Console.Write(" ");
            if (this.BoardCells[i].CurrentState == CellStates.ByEnum[CellStatesEnum.PlayerA].Name) Console.Write(CellStates.ByEnum[CellStatesEnum.PlayerA].DefaultMark);
            else if (this.BoardCells[i].CurrentState == CellStates.ByEnum[CellStatesEnum.PlayerB].Name) Console.Write(CellStates.ByEnum[CellStatesEnum.PlayerB].DefaultMark);
            else Console.Write(" ");
        }
    }
}
