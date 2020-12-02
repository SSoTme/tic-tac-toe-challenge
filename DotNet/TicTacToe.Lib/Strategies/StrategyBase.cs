using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe.DotNet.Lib;
using TicTacToeChallenge.Lib.DataClasses;

namespace DotNet.Lib.Strategies
{
    public abstract class StrategyBase
    {
        public abstract Cell CheckBoard(TicTacToeBoard ticTacToeBoard);
    }
}
