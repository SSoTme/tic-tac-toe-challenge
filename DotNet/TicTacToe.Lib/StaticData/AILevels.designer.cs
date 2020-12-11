using System;
using System.Linq;
using TicTacToeChallenge.Lib.DataClasses;

public static partial class AILevels
{
    private static void InitAILevels()
    {
        // setup each one...
        
            
        var Human = new AILevel()
        {
            AILevelId = @"rec7zRHCI6raiEXNA",
            createdTime = DateTime.Parse("2020-12-04T00:16:07Z"),
            Name = @"Human",
            PlayerType = @"Human",
            MinAILevelIndex = null,
            AILevelIndex = null,
            Description = @"Represents a human player",
            SortOrder = null
        };

        List.Add(Human);
        ByEnum[AILevelsEnum.Human] = Human;
        
            
        var Beginner = new AILevel()
        {
            AILevelId = @"recmMBaevl2jHl0hC",
            createdTime = DateTime.Parse("2020-11-26T20:02:01Z"),
            Name = @"Beginner",
            PlayerType = @"SimpleRules",
            MinAILevelIndex = null,
            AILevelIndex = null,
            Description = @"Wins, prevents a win or plays randomly.",
            SortOrder = null,
            Users = new string[] { @"reczDCJCYSs4dIML4" },
            AIStrategies = new string[] { @"recyOJc1noL5zIhmx", "recZDBLLFUvFztYzW", "reca1n3gYdwjbxrcn" },
            AIStrategyNames = @"WinIfPossible, PlayInMiddleIfAvailable, Random"
        };

        List.Add(Beginner);
        ByEnum[AILevelsEnum.Beginner] = Beginner;
        
            
        var Intermediate = new AILevel()
        {
            AILevelId = @"recPPp5z8K4EAA2FW",
            createdTime = DateTime.Parse("2020-11-26T20:02:01Z"),
            Name = @"Intermediate",
            PlayerType = @"SimpleRules",
            MinAILevelIndex = null,
            AILevelIndex = null,
            Description = @"This guy's pretty good - but not the best",
            SortOrder = null,
            Users = new string[] { @"recWpIDbiWQXKUBEA" },
            AIStrategies = new string[] { @"recyOJc1noL5zIhmx", "recZDBLLFUvFztYzW", "reca1n3gYdwjbxrcn", "rec9YSojkIl2F85fV", "recGEVGA3ajKMQ2kD", "recMqBdImRECSijls" },
            AIStrategyNames = @"WinIfPossible, PlayInMiddleIfAvailable, Random, PreventWinIfPossible, ForceWinNextTurn, PreventForceWinNextTurn"
        };

        List.Add(Intermediate);
        ByEnum[AILevelsEnum.Intermediate] = Intermediate;
        
            
        var Advanced = new AILevel()
        {
            AILevelId = @"rec6OhVu8y6RKPscT",
            createdTime = DateTime.Parse("2020-11-26T20:02:01Z"),
            Name = @"Advanced",
            PlayerType = @"SimpleRules",
            MinAILevelIndex = null,
            AILevelIndex = null,
            Description = @"The best - all strategies are employed.  This AI should never lose.  It will only win if the opponent makes a mistake, but otherwise, it at least tie.",
            SortOrder = null,
            Users = new string[] { @"recHAHw4jlVpSUYNo" },
            AIStrategies = new string[] { @"recyOJc1noL5zIhmx", "recZDBLLFUvFztYzW", "reca1n3gYdwjbxrcn", "rec9YSojkIl2F85fV", "recGEVGA3ajKMQ2kD", "recMqBdImRECSijls", "reclttwLO9tNIHGlo", "recx2tCavviw3I7It", "recuWctNLBYnhhsgj", "reccQN2uoTvoIlAQR" },
            AIStrategyNames = @"WinIfPossible, PlayInMiddleIfAvailable, Random, PreventWinIfPossible, ForceWinNextTurn, PreventForceWinNextTurn, PlayInCornerIfAvailable, SetupForceWinNextTurn, PreventSetupForceWinNextTurn, LearnFromMistakes"
        };

        List.Add(Advanced);
        ByEnum[AILevelsEnum.Advanced] = Advanced;
        
    }

}