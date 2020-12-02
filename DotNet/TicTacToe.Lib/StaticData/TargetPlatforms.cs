using System;
using System.Collections.Generic;
using System.Linq;
using TicTacToeChallenge.Lib.DataClasses;

public static partial class TargetPlatforms
{
    public static Dictionary<TargetPlatformsEnum, TargetPlatform> ByEnum { get; }
    public static List<TargetPlatform> List { get; }
    static TargetPlatforms()
    {
        TargetPlatforms.ByEnum = new Dictionary<TargetPlatformsEnum, TargetPlatform>();
        TargetPlatforms.List = new List<TargetPlatform>();
        TargetPlatforms.InitTargetPlatforms();
    }    
}