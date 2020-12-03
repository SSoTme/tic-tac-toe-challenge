using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe.DotNet.Lib;
using TicTacToeChallenge.Lib.DataClasses;

namespace DotNet.Lib.CellPatterns
{
    public abstract class WinningPatternBase : CellPattern
    {
        public string CurrentPlayerState { get; internal set; }

        public abstract bool CheckForWin(TicTacToeBoard ticTacToeBoard);
    }
}
