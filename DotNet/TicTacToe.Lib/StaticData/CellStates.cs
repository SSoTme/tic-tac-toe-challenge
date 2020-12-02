using System;
using System.Collections.Generic;
using System.Linq;
using TicTacToeChallenge.Lib.DataClasses;

public static partial class CellStates
{
    public static Dictionary<CellStatesEnum, CellState> ByEnum { get; }
    public static List<CellState> List { get; }
    static CellStates()
    {
        CellStates.ByEnum = new Dictionary<CellStatesEnum, CellState>();
        CellStates.List = new List<CellState>();
        CellStates.InitCellStates();
    }    
}