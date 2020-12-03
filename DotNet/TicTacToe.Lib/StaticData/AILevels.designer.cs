using System;
using System.Linq;
using TicTacToeChallenge.Lib.DataClasses;

public static partial class AILevels
{
    private static void InitAILevels()
    {
        // setup each one...
        
            
        var Beginner = new AILevel()
        {
            AILevelId = @"recmMBaevl2jHl0hC",
            createdTime = DateTime.Parse("2020-11-26T20:02:01Z"),
            Name = @"Beginner",
            PlayerType = @"SimpleRules",
            MinAILevelIndex = 0,
            AILevelIndex = 1,
            Description = @"Wins, prevents a win or plays randomly.",
            SortOrder = 1
        };

        List.Add(Beginner);
        ByEnum[AILevelsEnum.Beginner] = Beginner;
        
            
        var Intermediate = new AILevel()
        {
            AILevelId = @"recPPp5z8K4EAA2FW",
            createdTime = DateTime.Parse("2020-11-26T20:02:01Z"),
            Name = @"Intermediate",
            PlayerType = @"SimpleRules",
            MinAILevelIndex = 0,
            AILevelIndex = 2,
            Description = @"This guy's pretty good - but not the best",
            SortOrder = 2
        };

        List.Add(Intermediate);
        ByEnum[AILevelsEnum.Intermediate] = Intermediate;
        
            
        var Advanced = new AILevel()
        {
            AILevelId = @"rec6OhVu8y6RKPscT",
            createdTime = DateTime.Parse("2020-11-26T20:02:01Z"),
            Name = @"Advanced",
            PlayerType = @"SimpleRules",
            MinAILevelIndex = 0,
            AILevelIndex = 3,
            Description = @"The best - all strategies are employed.  This AI should never lose.  It will only win if the opponent makes a mistake, but otherwise, it at least tie.",
            SortOrder = 3
        };

        List.Add(Advanced);
        ByEnum[AILevelsEnum.Advanced] = Advanced;
        
    }

}