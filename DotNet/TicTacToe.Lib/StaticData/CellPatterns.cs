using System;
using System.Collections.Generic;
using System.Linq;
using TicTacToeChallenge.Lib.DataClasses;

public static partial class CellPatterns
{
    public static Dictionary<CellPatternsEnum, CellPattern> ByEnum { get; }
    public static List<CellPattern> List { get; }
    static CellPatterns()
    {
        CellPatterns.ByEnum = new Dictionary<CellPatternsEnum, CellPattern>();
        CellPatterns.List = new List<CellPattern>();
        CellPatterns.InitCellPatterns();
    }    
}