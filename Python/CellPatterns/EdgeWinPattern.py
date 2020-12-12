using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe.DotNet.Lib;
using TicTacToeChallenge.Lib.DataClasses;

namespace DotNet.Lib.CellPatterns
{
    public class EdgeWinPattern : WinningPatternBase
    {
        public override bool CheckForWin(TicTacToeBoard ticTacToeBoard)
        {
            this.CurrentPlayerState = ticTacToeBoard.GetCurrentPlayerState();

            if (this.CheckForWinStep(ticTacToeBoard)) return true;
            
            // TRANSLATION: T1-EdgeWin:Rotate:3
            ticTacToeBoard.Rotate();
            if (this.CheckForWinStep(ticTacToeBoard)) return true;
            
            ticTacToeBoard.Rotate();
            if (this.CheckForWinStep(ticTacToeBoard)) return true;
            
            ticTacToeBoard.Rotate();
            if (this.CheckForWinStep(ticTacToeBoard)) return true;
            
            
            return false;
        }

        private bool CheckForWinStep(TicTacToeBoard ticTacToeBoard)
        {
            
            if (
                (ticTacToeBoard.BoardCells[(int)CellsEnum.TopLeft].CurrentState == this.CurrentPlayerState ) &&
                (ticTacToeBoard.BoardCells[(int)CellsEnum.Top].CurrentState == this.CurrentPlayerState ) &&
                (ticTacToeBoard.BoardCells[(int)CellsEnum.TopRight].CurrentState == this.CurrentPlayerState ) )
            {
                return true;
            }
            else return false;
        }
    }
     
}