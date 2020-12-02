using System;
using System.Collections.Generic;
using System.Linq;
using TicTacToeChallenge.Lib.DataClasses;

public static partial class AILevels
{
    public static Dictionary<AILevelsEnum, AILevel> ByEnum { get; }
    public static List<AILevel> List { get; }
    static AILevels()
    {
        AILevels.ByEnum = new Dictionary<AILevelsEnum, AILevel>();
        AILevels.List = new List<AILevel>();
        AILevels.InitAILevels();
    }    
}