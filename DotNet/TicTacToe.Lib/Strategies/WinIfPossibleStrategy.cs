using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe.DotNet.Lib;
using TicTacToeChallenge.Lib.DataClasses;

namespace DotNet.Lib.Strategies
{
    public class WinIfPossibleStrategy : StrategyBase
    {
        public override Cell CheckBoard(TicTacToeBoard board)
        {
            if ((board.BoardCells[0].CurrentState == CellStatesEnum.Opponent.ToString()) &&
                (board.BoardCells[1].CurrentState == CellStatesEnum.Opponent.ToString()) &&
                (board.BoardCells[2].CurrentState == CellStatesEnum.NoPlayer.ToString()))
            {
                return board.BoardCells[2];
            }
            else return Cell.None;
        }
    }
}
