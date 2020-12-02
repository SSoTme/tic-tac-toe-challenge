using TicTacToeChallenge.Lib.DataClasses;

namespace TicTacToe.DotNet.Lib
{
    public abstract class Player
    {
        public string Name { get; set; }

        protected Player(string name)
        {
            this.Name = name;
        }

        public abstract Cell Play(TicTacToeBoard board);
    }
}