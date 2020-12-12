using DotNet.Lib.CellPatterns;
namespace TicTacToe.DotNet.Lib
{
    public partial class TicTacToeBoard 
    {
        private void CheckForWin()
        { 
            if ( this.CheckForWin<EdgeWinPattern>() ||
                 this.CheckForWin<DiagonalWinPattern>() ||
                 this.CheckForWin<MiddleWinPattern>())
            {
                this.HandleWin();
            }
        }
    }
}