using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe.DotNet.Lib;
using TicTacToeChallenge.Lib.DataClasses;

namespace DotNet.Lib.Strategies
{
    public class PreventSetupForceWinNextTurnStrategy : StrategyBase
    {
        public override Cell CheckBoard(TicTacToeBoard ticTacToeBoard)
        {
            throw new NotImplementedException();
        }
    }
}
