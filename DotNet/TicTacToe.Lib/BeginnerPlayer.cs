using DotNet.Lib.Strategies;
using System;
using TicTacToeChallenge.Lib.DataClasses;

namespace TicTacToe.DotNet.Lib
{
    public class BeginnerPlayer : Player
    {
        public BeginnerPlayer() 
            : base("Beginner")
        {

        }

        public override Cell Play(TicTacToeBoard board)
        {
            var cell = board.UseStrategy<WinIfPossibleStrategy>();
            if (cell is null) cell = board.UseStrategy<PlayInMiddleIfAvailableStrategy>();
            if (cell is null) cell = board.UseStrategy<RandomStrategy>();
            this.DisplayCellChoice(cell);
            return cell;
        }
    }
}