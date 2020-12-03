using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe.DotNet.Lib;
using TicTacToeChallenge.Lib.DataClasses;

namespace DotNet.Lib.Strategies
{
    public class PlayInMiddleIfAvailableStrategy : StrategyBase
    {
        public override Cell CheckBoard(TicTacToeBoard ticTacToeBoard)
        {
            if (ticTacToeBoard.BoardCells[(int)CellsEnum.Middle].CurrentState == CellStatesEnum.NoPlayer.ToString())
            {
                return ticTacToeBoard.BoardCells[(int)CellsEnum.Middle];
            }
            else return Cell.None;
        }
    }
}
