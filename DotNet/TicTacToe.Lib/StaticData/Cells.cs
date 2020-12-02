using System;
using System.Collections.Generic;
using System.Linq;
using TicTacToeChallenge.Lib.DataClasses;

public static partial class Cells
{
    public static Dictionary<CellsEnum, Cell> ByEnum { get; }
    public static List<Cell> List { get; }
    static Cells()
    {
        Cells.ByEnum = new Dictionary<CellsEnum, Cell>();
        Cells.List = new List<Cell>();
        Cells.InitCells();
    }    
}