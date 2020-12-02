using System;
using System.Collections.Generic;
using System.Linq;
using TicTacToeChallenge.Lib.DataClasses;

public static partial class CellPatternTranslations
{
    public static Dictionary<CellPatternTranslationsEnum, CellPatternTranslation> ByEnum { get; }
    public static List<CellPatternTranslation> List { get; }
    static CellPatternTranslations()
    {
        CellPatternTranslations.ByEnum = new Dictionary<CellPatternTranslationsEnum, CellPatternTranslation>();
        CellPatternTranslations.List = new List<CellPatternTranslation>();
        CellPatternTranslations.InitCellPatternTranslations();
    }    
}