using System;
using System.Collections.Generic;
using System.Linq;
using TicTacToeChallenge.Lib.DataClasses;

public static partial class LanguageTokens
{
    public static Dictionary<LanguageTokensEnum, LanguageToken> ByEnum { get; }
    public static List<LanguageToken> List { get; }
    static LanguageTokens()
    {
        LanguageTokens.ByEnum = new Dictionary<LanguageTokensEnum, LanguageToken>();
        LanguageTokens.List = new List<LanguageToken>();
        LanguageTokens.InitLanguageTokens();
    }    
}