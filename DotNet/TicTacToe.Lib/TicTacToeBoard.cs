using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TicTacToeChallenge.Lib.DataClasses;

namespace TicTacToe.DotNet.Lib
{
    public class TicTacToeBoard
    {
        public TicTacToeBoard()
        {
            this.BoardCells = JsonConvert.DeserializeObject<List<Cell>>(JsonConvert.SerializeObject(Cells.List));
        }

        public void Rotate()
        {
            var tempCells = JsonConvert.DeserializeObject<List<Cell>>(JsonConvert.SerializeObject(this.BoardCells));
            for (var i = 0; i < 9; i++){
                var rotateFrom = Cells.List[i].RotateIndex.Value;
                this.BoardCells[i] = tempCells[rotateFrom];
            }
        }
        public void Flip()
        {
            var tempCells = JsonConvert.DeserializeObject<List<Cell>>(JsonConvert.SerializeObject(this.BoardCells));
            for (var i = 0; i < 9; i++)
            {
                var rotateFrom = Cells.List[i].FlipIndex.Value;
                this.BoardCells[i] = tempCells[rotateFrom];
            }
        }

        public List<Cell> BoardCells { get; }

        public void PrintConsoleBoard()
        {
            Console.WriteLine(" ---");
            for (int i = 0; i < 9; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("-");
                }

                if (this.BoardCells[i].CurrentState == CellStates.ByEnum[CellStatesEnum.PlayerA].Name) Console.Write("A");
                else if (this.BoardCells[i].CurrentState == CellStates.ByEnum[CellStatesEnum.PlayerB].Name) Console.Write("B");
                else Console.Write(" ");

                if (i % 3 == 2)
                {
                    Console.WriteLine("");
                }
            }
            Console.WriteLine();
        }
    }
}
