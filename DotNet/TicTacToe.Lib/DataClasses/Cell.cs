/*************************************************
Initially Generated by SSoT.me - 2017
    EJ Alexandra - An odxml42 Tool
    This file WILL NOT be overwritten once changes are made.
*************************************************/
using System;
using System.ComponentModel;

namespace TicTacToeChallenge.Lib.DataClasses
{

    public partial class Cell
    {
        public Cell()
        {
            this.InitPoco();
        }

        public static Cell None { get { return null; } }        
        public override String ToString()
        {
            return this.ToString(false);
        }
        public String ToString(bool excludeState = false)
        {
            return String.Format("{0}. {1} - {2}", this.CellKey, this.Name, excludeState ? "" : this.CurrentState);
        }

    }
}