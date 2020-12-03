using System;
using System.Linq;
using TicTacToeChallenge.Lib.DataClasses;

public static partial class AdditionalResources
{
    private static void InitAdditionalResources()
    {
        // setup each one...
        
            
        var ProjectIntro = new AdditionalResource()
        {
            AdditionalResourceId = @"recHcwHGoetrVzZl2",
            createdTime = DateTime.Parse("2020-11-26T20:08:44Z"),
            Name = @"ProjectIntro",
            Description = @"An introduction to the project",
            Type = @"GDoc",
            GoogleKey = @"1LVxFmVcm2DgzH2AGNQ4c9buus16l42a6aNhEmwqjWzs",
            IsActiveDownload = Boolean.Parse("true")
        };

        List.Add(ProjectIntro);
        ByEnum[AdditionalResourcesEnum.ProjectIntro] = ProjectIntro;
        
            
        var LanguageTokens = new AdditionalResource()
        {
            AdditionalResourceId = @"recSwRg5YB2sQj3Dn",
            createdTime = DateTime.Parse("2020-11-26T20:08:44Z"),
            Name = @"LanguageTokens",
            Description = @"A list of language tokens used in the app.",
            Type = @"GSheet",
            GoogleKey = @"1xpLGHj6wHyot9Kp2lpKTG8AcKJNMSkxjp-aTQT7yB90",
            GID = 112651157,
            IsActiveDownload = Boolean.Parse("true")
        };

        List.Add(LanguageTokens);
        ByEnum[AdditionalResourcesEnum.LanguageTokens] = LanguageTokens;
        
            
        var AIStrategies = new AdditionalResource()
        {
            AdditionalResourceId = @"recSzeONBNQyGam4a",
            createdTime = DateTime.Parse("2020-11-26T20:08:44Z"),
            Name = @"AIStrategies",
            Description = @"A list of strategies used by the AI, and which AI levels that start be used at.",
            Type = @"GSheet",
            GoogleKey = @"1xpLGHj6wHyot9Kp2lpKTG8AcKJNMSkxjp-aTQT7yB90",
            GID = 780350443,
            IsActiveDownload = Boolean.Parse("true")
        };

        List.Add(AIStrategies);
        ByEnum[AdditionalResourcesEnum.AIStrategies] = AIStrategies;
        
            
        var TranslationTests = new AdditionalResource()
        {
            AdditionalResourceId = @"recTnaatiHVKftVNt",
            createdTime = DateTime.Parse("2020-11-26T20:08:44Z"),
            Name = @"TranslationTests",
            Description = @"These values validate the rotate and flip index values",
            Type = @"GSheet",
            GoogleKey = @"1xpLGHj6wHyot9Kp2lpKTG8AcKJNMSkxjp-aTQT7yB90",
            GID = 1640541132,
            IsActiveDownload = Boolean.Parse("true")
        };

        List.Add(TranslationTests);
        ByEnum[AdditionalResourcesEnum.TranslationTests] = TranslationTests;
        
            
        var Entities = new AdditionalResource()
        {
            AdditionalResourceId = @"recYXFpjsUJpxDAtz",
            createdTime = DateTime.Parse("2020-11-26T20:08:44Z"),
            Name = @"Entities",
            Description = @"A list of entities in the project (Player, Opponent, Game, Mark, Win, Loss, etc)",
            Type = @"GSheet",
            GoogleKey = @"1C_awugxQh7vQx4cCKGK7YKynOEUNdvT0htLzESZqhHA",
            GID = 0
        };

        List.Add(Entities);
        ByEnum[AdditionalResourcesEnum.Entities] = Entities;
        
            
        var CellPatterns = new AdditionalResource()
        {
            AdditionalResourceId = @"recat8Ojn2epezalz",
            createdTime = DateTime.Parse("2020-11-26T20:08:44Z"),
            Name = @"CellPatterns",
            Description = @"A list of cells and a target if a match is found.",
            Type = @"GSheet",
            GoogleKey = @"1xpLGHj6wHyot9Kp2lpKTG8AcKJNMSkxjp-aTQT7yB90",
            GID = 412235242,
            IsActiveDownload = Boolean.Parse("true")
        };

        List.Add(CellPatterns);
        ByEnum[AdditionalResourcesEnum.CellPatterns] = CellPatterns;
        
            
        var Cells = new AdditionalResource()
        {
            AdditionalResourceId = @"receQpkmZcWMKHTQy",
            createdTime = DateTime.Parse("2020-11-26T20:08:44Z"),
            Name = @"Cells",
            Description = @"A formal list of the cells in the 3x3 game of tic tac toe.",
            Type = @"GSheet",
            GoogleKey = @"1xpLGHj6wHyot9Kp2lpKTG8AcKJNMSkxjp-aTQT7yB90",
            GID = 1934124403,
            IsActiveDownload = Boolean.Parse("true")
        };

        List.Add(Cells);
        ByEnum[AdditionalResourcesEnum.Cells] = Cells;
        
            
        var TargetPlatforms = new AdditionalResource()
        {
            AdditionalResourceId = @"receawL0rBK391VX5",
            createdTime = DateTime.Parse("2020-11-26T20:08:44Z"),
            Name = @"TargetPlatforms",
            Description = @"A list of target platforms that the SDK will support",
            Type = @"GSheet",
            GoogleKey = @"1xpLGHj6wHyot9Kp2lpKTG8AcKJNMSkxjp-aTQT7yB90",
            GID = 2077194606,
            IsActiveDownload = Boolean.Parse("true")
        };

        List.Add(TargetPlatforms);
        ByEnum[AdditionalResourcesEnum.TargetPlatforms] = TargetPlatforms;
        
            
        var AILevels = new AdditionalResource()
        {
            AdditionalResourceId = @"reciUfmmPt7wX7Ey7",
            createdTime = DateTime.Parse("2020-11-26T20:08:44Z"),
            Name = @"AILevels",
            Description = @"A list of AI Levels which the game supports starting with None (no ai) and working up to an AI that will win or tie every game.",
            Type = @"GSheet",
            GoogleKey = @"1xpLGHj6wHyot9Kp2lpKTG8AcKJNMSkxjp-aTQT7yB90",
            GID = 260512170,
            IsActiveDownload = Boolean.Parse("true")
        };

        List.Add(AILevels);
        ByEnum[AdditionalResourcesEnum.AILevels] = AILevels;
        
            
        var AdditionalResources = new AdditionalResource()
        {
            AdditionalResourceId = @"reco9SceAeSSTdk7l",
            createdTime = DateTime.Parse("2020-11-26T20:08:44Z"),
            Name = @"AdditionalResources",
            Description = @"A list of additional resources used by the project",
            Type = @"GSheet",
            GoogleKey = @"1xpLGHj6wHyot9Kp2lpKTG8AcKJNMSkxjp-aTQT7yB90",
            GID = 1887184744
        };

        List.Add(AdditionalResources);
        ByEnum[AdditionalResourcesEnum.AdditionalResources] = AdditionalResources;
        
            
        var CellStates = new AdditionalResource()
        {
            AdditionalResourceId = @"rect8IKCh05pywdx3",
            createdTime = DateTime.Parse("2020-11-26T20:08:44Z"),
            Name = @"CellStates",
            Description = @"A list of states that a cell can have",
            Type = @"GSheet",
            GoogleKey = @"1xpLGHj6wHyot9Kp2lpKTG8AcKJNMSkxjp-aTQT7yB90",
            GID = 194238261,
            IsActiveDownload = Boolean.Parse("true")
        };

        List.Add(CellStates);
        ByEnum[AdditionalResourcesEnum.CellStates] = CellStates;
        
            
        var Translations = new AdditionalResource()
        {
            AdditionalResourceId = @"recvL0ljpLGaPyUJX",
            createdTime = DateTime.Parse("2020-11-26T20:08:44Z"),
            Name = @"Translations",
            Description = @"A list of transaltions which any implementation of this game needs to support",
            Type = @"GSheet",
            GoogleKey = @"1xpLGHj6wHyot9Kp2lpKTG8AcKJNMSkxjp-aTQT7yB90",
            GID = 1319606678,
            IsActiveDownload = Boolean.Parse("true")
        };

        List.Add(Translations);
        ByEnum[AdditionalResourcesEnum.Translations] = Translations;
        
            
        var Settings = new AdditionalResource()
        {
            AdditionalResourceId = @"recz3Z6BkBERUjDP7",
            createdTime = DateTime.Parse("2020-11-26T20:08:44Z"),
            Name = @"Settings",
            Description = @"Global settings for the entire TicTacToe project",
            Type = @"GSheet",
            GoogleKey = @"1xpLGHj6wHyot9Kp2lpKTG8AcKJNMSkxjp-aTQT7yB90",
            GID = 0
        };

        List.Add(Settings);
        ByEnum[AdditionalResourcesEnum.Settings] = Settings;
        
    }

}