using System;
using System.Linq;
using TicTacToeChallenge.Lib.DataClasses;

public static partial class TargetPlatforms
{
    private static void InitTargetPlatforms()
    {
        // setup each one...
        
            
        var JSFiddle = new TargetPlatform()
        {
            TargetPlatformId = @"rec9TVW9uwN4omDSH",
            createdTime = DateTime.Parse("2020-11-26T20:07:32Z"),
            Name = @"JSFiddle",
            ShortDescription = @"Simple web client",
            Description = @"A JSFiddle implementation of every aspect of the specification.",
            Implemented = @"TRUE",
            DemoUrl = @"https://jsfiddle.net/eejai42/g5ndz2mp/",
            HasAnyUI = @"TRUE",
            IsHumanyPlayable = @"TRUE",
            HasAnyAI = @"TRUE",
            DetectsWin = @"TRUE",
            DetectsLoss = @"TRUE",
            DetectsTie = @"FALSE",
            HasRuleFollowingAI = @"TRUE",
            HasUIForHuman = @"TRUE",
            FullSimpleRules = @"FALSE",
            FullMLAI = @"FALSE",
            ImplementsRotate = @"TRUE",
            ImplementsFlip = @"TRUE",
            ImplementsCustomTranslations = @"TRUE",
            SortOrder = 1
        };

        List.Add(JSFiddle);
        ByEnum[TargetPlatformsEnum.JSFiddle] = JSFiddle;
        
            
        var Windows = new TargetPlatform()
        {
            TargetPlatformId = @"recma037MKuzvQ5Gn",
            createdTime = DateTime.Parse("2020-11-26T20:07:32Z"),
            Name = @"Windows",
            ShortDescription = @"Windows App",
            Description = @"A windows forms version of the game, which also implements every aspect of the game.",
            Implemented = @"TRUE",
            DemoUrl = @"https://eejai42.sdks.codeiverse.com/ClickOnce/TicTacToe/publish.htm",
            HasAnyUI = @"FALSE",
            IsHumanyPlayable = @"FALSE",
            HasAnyAI = @"FALSE",
            DetectsWin = @"FALSE",
            DetectsLoss = @"FALSE",
            DetectsTie = @"FALSE",
            HasRuleFollowingAI = @"FALSE",
            HasUIForHuman = @"FALSE",
            FullSimpleRules = @"FALSE",
            FullMLAI = @"FALSE",
            ImplementsRotate = @"FALSE",
            ImplementsFlip = @"FALSE",
            ImplementsCustomTranslations = @"FALSE",
            SortOrder = 2
        };

        List.Add(Windows);
        ByEnum[TargetPlatformsEnum.Windows] = Windows;
        
            
        var GDocs = new TargetPlatform()
        {
            TargetPlatformId = @"recqb7MghLHT7bidn",
            createdTime = DateTime.Parse("2020-11-26T20:07:32Z"),
            Name = @"GDocs",
            ShortDescription = @"Documentation",
            Description = @"The original source documentation (not really a target I guess :) )",
            Implemented = @"TRUE",
            DemoUrl = @"https://docs.google.com/spreadsheets/d/1xpLGHj6wHyot9Kp2lpKTG8AcKJNMSkxjp-aTQT7yB90/edit#gid=0",
            HasAnyUI = @"FALSE",
            IsHumanyPlayable = @"FALSE",
            HasAnyAI = @"FALSE",
            DetectsWin = @"FALSE",
            DetectsLoss = @"FALSE",
            DetectsTie = @"FALSE",
            HasRuleFollowingAI = @"FALSE",
            HasUIForHuman = @"FALSE",
            FullSimpleRules = @"FALSE",
            FullMLAI = @"FALSE",
            ImplementsRotate = @"FALSE",
            ImplementsFlip = @"FALSE",
            ImplementsCustomTranslations = @"FALSE",
            SortOrder = 3
        };

        List.Add(GDocs);
        ByEnum[TargetPlatformsEnum.GDocs] = GDocs;
        
            
        var Html = new TargetPlatform()
        {
            TargetPlatformId = @"rec4ch22B23xyBKFE",
            createdTime = DateTime.Parse("2020-11-26T20:07:32Z"),
            Name = @"Html",
            ShortDescription = @"Documentation",
            Description = @"The resulting HTML version of the wiki",
            Implemented = @"TRUE",
            DemoUrl = @"https://eejai42.sdks.codeiverse.com/TicTacToeSDK/Docs/ReadMe.html",
            HasAnyUI = @"FALSE",
            IsHumanyPlayable = @"FALSE",
            HasAnyAI = @"FALSE",
            DetectsWin = @"FALSE",
            DetectsLoss = @"FALSE",
            DetectsTie = @"FALSE",
            HasRuleFollowingAI = @"FALSE",
            HasUIForHuman = @"FALSE",
            FullSimpleRules = @"FALSE",
            FullMLAI = @"FALSE",
            ImplementsRotate = @"FALSE",
            ImplementsFlip = @"FALSE",
            ImplementsCustomTranslations = @"FALSE",
            SortOrder = 4
        };

        List.Add(Html);
        ByEnum[TargetPlatformsEnum.Html] = Html;
        
            
        var Javascript = new TargetPlatform()
        {
            TargetPlatformId = @"recvHhGpUR9sun8YL",
            createdTime = DateTime.Parse("2020-11-26T20:07:32Z"),
            Name = @"Javascript",
            ShortDescription = @"TTT Library",
            Description = @"A javascript library (which implements the SDK)",
            Implemented = @"TRUE",
            DemoUrl = @"https://eejai42.sdks.codeiverse.com/TicTacToeSDK/Docs/Translations.html",
            HasAnyUI = @"FALSE",
            IsHumanyPlayable = @"FALSE",
            HasAnyAI = @"FALSE",
            DetectsWin = @"FALSE",
            DetectsLoss = @"FALSE",
            DetectsTie = @"FALSE",
            HasRuleFollowingAI = @"FALSE",
            HasUIForHuman = @"FALSE",
            FullSimpleRules = @"FALSE",
            FullMLAI = @"FALSE",
            ImplementsRotate = @"FALSE",
            ImplementsFlip = @"FALSE",
            ImplementsCustomTranslations = @"FALSE",
            SortOrder = 5
        };

        List.Add(Javascript);
        ByEnum[TargetPlatformsEnum.Javascript] = Javascript;
        
            
        var CSharp = new TargetPlatform()
        {
            TargetPlatformId = @"recn4ZBd69hcEBkIl",
            createdTime = DateTime.Parse("2020-11-26T20:07:32Z"),
            Name = @"CSharp",
            ShortDescription = @"TTT Library",
            Description = @"A csharp library which implements the SDK",
            Implemented = @"TRUE",
            DemoUrl = @"https://eejai42.sdks.codeiverse.com/ClickOnce/TicTacToe/publish.htm",
            HasAnyUI = @"FALSE",
            IsHumanyPlayable = @"FALSE",
            HasAnyAI = @"FALSE",
            DetectsWin = @"FALSE",
            DetectsLoss = @"FALSE",
            DetectsTie = @"FALSE",
            HasRuleFollowingAI = @"FALSE",
            HasUIForHuman = @"FALSE",
            FullSimpleRules = @"FALSE",
            FullMLAI = @"FALSE",
            ImplementsRotate = @"FALSE",
            ImplementsFlip = @"FALSE",
            ImplementsCustomTranslations = @"FALSE",
            SortOrder = 6
        };

        List.Add(CSharp);
        ByEnum[TargetPlatformsEnum.CSharp] = CSharp;
        
    }

}