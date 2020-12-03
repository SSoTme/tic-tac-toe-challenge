using DotNet.Lib.CellPatterns;
namespace TicTacToe.DotNet.Lib
{
    public partial class TicTacToeBoard 
    {
        private void CheckForWin()
        { 
            if ( this.CheckForWin<EdgeWinPattern>() ||
                 this.CheckForWin<DiagaonalPattern>() ||
                 this.CheckForWin<MiddleWinPattern>())
            {
                this.HandleWin();
            }
        }
    }
}