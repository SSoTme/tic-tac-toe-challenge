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

        Random random = new Random();
        public override Cell Play(TicTacToeBoard board)
        {
            // Play randomly for now
            var randomCell = this.random.Next(board.AvailableCells.Count);
            var cell = board.AvailableCells[randomCell];
            Console.WriteLine("{0} player, playing at {1}", this.Name, cell.Name);
            return cell;
        }
    }
}