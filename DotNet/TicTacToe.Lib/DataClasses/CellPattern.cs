/*************************************************
Initially Generated by SSoT.me - 2017
    EJ Alexandra - An odxml42 Tool
    This file WILL NOT be overwritten once changes are made.
*************************************************/
using System;
using System.ComponentModel;
                        
namespace TicTacToeChallenge.Lib.DataClasses
{                   
    
    public partial class CellPattern 
    {
        public CellPattern()
        {
            this.InitPoco();
        }

        public override String ToString()
        {
            return String.Format("CellPattern: {0}", this.Name);
        }
                            
    }
}