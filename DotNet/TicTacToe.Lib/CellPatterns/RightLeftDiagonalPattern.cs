using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe.DotNet.Lib;
using TicTacToeChallenge.Lib.DataClasses;

namespace DotNet.Lib.CellPatterns
{
    public class RightLeftDiagonalPattern : WinningPatternBase
    {
        public override bool CheckForWin(TicTacToeBoard ticTacToeBoard)
        {
            this.CurrentPlayerState = ticTacToeBoard.GetCurrentPlayerState();

            if (this.CheckForWinStep(ticTacToeBoard)) return true;
            
            
            return false;
        }

        private bool CheckForWinStep(TicTacToeBoard ticTacToeBoard)
        {
            
            if (
                (ticTacToeBoard.BoardCells[(int)CellsEnum.TopRight].CurrentState == this.CurrentPlayerState ) &&
                (ticTacToeBoard.BoardCells[(int)CellsEnum.Middle].CurrentState == this.CurrentPlayerState ) &&
                (ticTacToeBoard.BoardCells[(int)CellsEnum.BottomLeft].CurrentState == this.CurrentPlayerState ) )
            {
                return true;
            }
            else return false;
        }
    }
     
}