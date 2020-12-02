using System;
using System.Collections.Generic;
using System.Linq;
using TicTacToeChallenge.Lib.DataClasses;

public static partial class Translations
{
    public static Dictionary<TranslationsEnum, Translation> ByEnum { get; }
    public static List<Translation> List { get; }
    static Translations()
    {
        Translations.ByEnum = new Dictionary<TranslationsEnum, Translation>();
        Translations.List = new List<Translation>();
        Translations.InitTranslations();
    }    
}