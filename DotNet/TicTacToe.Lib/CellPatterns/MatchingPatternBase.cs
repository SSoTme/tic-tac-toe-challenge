using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe.DotNet.Lib;
using TicTacToeChallenge.Lib.DataClasses;

namespace DotNet.Lib.CellPatterns
{
    public abstract class MatchingPatternBase : CellPattern
    {
        public string CurrentPlayerState { get; set; }

        public abstract Cell CheckForMatch(TicTacToeBoard ticTacToeBoard);
    }
}
