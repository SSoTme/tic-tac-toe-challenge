using DotNet.Lib.CellPatterns;
namespace TicTacToe.DotNet.Lib
{
    public partial class TicTacToeBoard 
    {
        private void CheckForWin()
        { 
            if ( this.CheckForWin<EdgeWinPattern>() ||
                 this.CheckForWin<Row3Pattern>() ||
                 this.CheckForWin<Column1Pattern>() ||
                 this.CheckForWin<Column3Pattern>() ||
                 this.CheckForWin<RightLeftDiagonalPattern>() ||
                 this.CheckForWin<Column2Pattern>() ||
                 this.CheckForWin<Row1Pattern>() ||
                 this.CheckForWin<LeftRightDiagonalPattern>() ||
                 this.CheckForWin<MiddleWinPattern>() ||
                 this.CheckForWin<Row2Pattern>() ||
                 this.CheckForWin<DiagonalWinPattern>())
            {
                this.HandleWin();
            }
        }
    }
}