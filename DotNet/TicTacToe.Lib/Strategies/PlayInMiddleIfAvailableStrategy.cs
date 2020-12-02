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
            if (ticTacToeBoard.BoardCells[4].CurrentState == CellStatesEnum.NoPlayer.ToString())
            {
                return ticTacToeBoard.BoardCells[4];
            }
            else return Cell.None;
        }
    }
}
