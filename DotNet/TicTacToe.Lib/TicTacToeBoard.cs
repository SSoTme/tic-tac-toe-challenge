using DotNet.Lib.CellPatterns;
using DotNet.Lib.Strategies;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using TicTacToeChallenge.Lib.DataClasses;

namespace TicTacToe.DotNet.Lib
{
    public partial class TicTacToeBoard
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
            if (!(cell is null)) {
                cell.ChosenUsingStrategy = typeof(T).Name;
                Console.WriteLine("Successfully used strategy: {0} to play {1}.", typeof(T).Name, cell.Name);
            }
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
                this.SavePosition();
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
                this.RestorPosition();
                this.PrintConsoleBoard();
            }

        }

        private void HandleWin()
        {
            var gameOverStr = LanguageTokens.ByEnum[LanguageTokensEnum.GameOver].DisplayName;
            var youWon = LanguageTokens.ByEnum[LanguageTokensEnum.YouWon].DisplayName;
            var theyWon = LanguageTokens.ByEnum[LanguageTokensEnum.TheyWon].DisplayName;
            var wonStr = this.IsYourTurn ? youWon : theyWon;
            Console.WriteLine("{2} ({3}) - " +
                "{0}: {1} - ", gameOverStr, wonStr, this.GetCurrentPlayer().Name, this.GetCurrentPlayerState());
            this.IsGameOver = true;
        }

        private Player GetCurrentPlayer()
        {
            return this.IsYourTurn ? this.Player1 : this.Player2;
        }

        public void RestorPosition()
        {
            if (this.IsFlipped) this.Flip();
            while (this.Rotation != 0) this.Rotate();
        }

        public void SavePosition()
        {
            this.Rotation = 0;
            this.IsFlipped = false;
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
            this.Rotation = (this.Rotation + 90) % 360;
            // Console.WriteLine("   - ROTATE: {0}/{1}", this.IsFlipped, this.Rotation);
            var tempCells = JsonConvert.DeserializeObject<List<Cell>>(JsonConvert.SerializeObject(this.BoardCells));
            for (var i = 0; i < 9; i++)
            {
                var rotateFrom = Cells.List[i].RotateIndex.Value;
                this.BoardCells[i].CurrentState = tempCells[rotateFrom].CurrentState;
            }
        }
        public void Flip()
        {
            this.IsFlipped = !this.IsFlipped;
            if ((this.Rotation == 90) || (this.Rotation == 270)) this.Rotation = (this.Rotation + 180) % 360;
            // Console.WriteLine("   - FLIP: {0}/{1}", this.IsFlipped, this.Rotation);
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

        public int Rotation { get; private set; }
        public bool IsFlipped { get; private set; }

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
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }

        private void PrintCell(int i)
        {
            Console.Write(" ");
            if (this.BoardCells[i].CurrentState == CellStates.ByEnum[CellStatesEnum.Player].Name)
            {
                var state = CellStates.ByEnum[CellStatesEnum.Player];
                Console.ForegroundColor = this.GetConsoleColor(state.FontColor);
                Console.BackgroundColor = this.GetConsoleColor(state.Color);
                Console.Write(state.DefaultMark);
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else if (this.BoardCells[i].CurrentState == CellStates.ByEnum[CellStatesEnum.Opponent].Name)
            {
                var state = CellStates.ByEnum[CellStatesEnum.Opponent];
                Console.ForegroundColor = this.GetConsoleColor(state.FontColor);
                Console.BackgroundColor = this.GetConsoleColor(state.Color);
                Console.Write(state.DefaultMark);
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else Console.Write(" ");
        }

        private ConsoleColor GetConsoleColor(string fontColor)
        {
            var cc = new ColorConverter();
            var color = (Color)cc.ConvertFromString(fontColor);
            int index = (color.R > 128 | color.G > 128 | color.B > 128) ? 8 : 0; // Bright bit
            index |= (color.R > 64) ? 4 : 0; // Red bit
            index |= (color.G > 64) ? 2 : 0; // Green bit
            index |= (color.B > 64) ? 1 : 0; // Blue bit
            return (System.ConsoleColor)index;
        }
    }
}
