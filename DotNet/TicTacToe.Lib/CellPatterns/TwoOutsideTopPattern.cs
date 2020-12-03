using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe.DotNet.Lib;
using TicTacToeChallenge.Lib.DataClasses;

namespace DotNet.Lib.CellPatterns
{
    public class TwoOutsideTopPattern : MatchingPatternBase
    {

        public override Cell CheckForMatch(TicTacToeBoard ticTacToeBoard)
        {
            this.CurrentPlayerState = ticTacToeBoard.GetCurrentPlayerState();

            var cell = (this.CheckForMatchStep(ticTacToeBoard));
            if (!(cell is null)) return cell;

            
            // TRANSLATION: T1-TwoOutsideTop:Rotate:3
            ticTacToeBoard.Rotate();
            cell = (this.CheckForMatchStep(ticTacToeBoard));
            if (!(cell is null)) return cell;
            
            ticTacToeBoard.Rotate();
            cell = (this.CheckForMatchStep(ticTacToeBoard));
            if (!(cell is null)) return cell;
            
            ticTacToeBoard.Rotate();
            cell = (this.CheckForMatchStep(ticTacToeBoard));
            if (!(cell is null)) return cell;
            
            return cell;
        }

        private Cell CheckForMatchStep(TicTacToeBoard ticTacToeBoard)
        {
            
            if (
                (ticTacToeBoard.BoardCells[(int)CellsEnum.TopLeft].CurrentState == this.CurrentPlayerState ) &&
                (ticTacToeBoard.BoardCells[(int)CellsEnum.Top].CurrentState == "NoPlayer" ) &&
                (ticTacToeBoard.BoardCells[(int)CellsEnum.TopRight].CurrentState == this.CurrentPlayerState ) )
            {
                return ticTacToeBoard.BoardCells[(int)CellsEnum.Top];
            }
            else return null;
        }        
    } 
}