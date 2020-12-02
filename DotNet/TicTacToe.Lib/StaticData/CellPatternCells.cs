using System;
using System.Collections.Generic;
using System.Linq;
using TicTacToeChallenge.Lib.DataClasses;

public static partial class CellPatternCells
{
    public static Dictionary<CellPatternCellsEnum, CellPatternCell> ByEnum { get; }
    public static List<CellPatternCell> List { get; }
    static CellPatternCells()
    {
        CellPatternCells.ByEnum = new Dictionary<CellPatternCellsEnum, CellPatternCell>();
        CellPatternCells.List = new List<CellPatternCell>();
        CellPatternCells.InitCellPatternCells();
    }    
}