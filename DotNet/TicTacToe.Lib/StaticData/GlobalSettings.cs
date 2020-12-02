using System;
using System.Collections.Generic;
using System.Linq;
using TicTacToeChallenge.Lib.DataClasses;

public static partial class GlobalSettings
{
    public static Dictionary<GlobalSettingsEnum, GlobalSetting> ByEnum { get; }
    public static List<GlobalSetting> List { get; }
    static GlobalSettings()
    {
        GlobalSettings.ByEnum = new Dictionary<GlobalSettingsEnum, GlobalSetting>();
        GlobalSettings.List = new List<GlobalSetting>();
        GlobalSettings.InitGlobalSettings();
    }    
}