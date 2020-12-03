using DotNet.Lib.CellPatterns;
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
            var cell = board.TryToMatchCellPattern<TwoInARowTopPattern>();
            if (cell is null) cell = board.TryToMatchCellPattern<TwoInARowMiddlePattern>();
            if (cell is null) cell = board.TryToMatchCellPattern<TwoInARowDiagonalPattern>();
            if (cell is null) cell = board.TryToMatchCellPattern<TwoOutsideMiddlePattern>();
            if (cell is null) cell = board.TryToMatchCellPattern<TwoOutsideDiagonalPattern>();
            if (cell is null) cell = board.TryToMatchCellPattern<TwoOutsideTopPattern>();
            if (cell != null)
            {
                object o = 1;
            }
            return cell;
        }
    }
}
