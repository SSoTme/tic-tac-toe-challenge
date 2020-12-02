using System;
using System.Collections.Generic;
using System.Linq;
using TicTacToeChallenge.Lib.DataClasses;

public static partial class AIStrategies
{
    public static Dictionary<AIStrategiesEnum, AIStrategy> ByEnum { get; }
    public static List<AIStrategy> List { get; }
    static AIStrategies()
    {
        AIStrategies.ByEnum = new Dictionary<AIStrategiesEnum, AIStrategy>();
        AIStrategies.List = new List<AIStrategy>();
        AIStrategies.InitAIStrategies();
    }    
}