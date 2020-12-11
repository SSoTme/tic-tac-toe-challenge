using System;
using System.Linq;
using TicTacToeChallenge.Lib.DataClasses;

public static partial class AIStrategies
{
    private static void InitAIStrategies()
    {
        // setup each one...
        
            
        var WaitsForInstruction = new AIStrategy()
        {
            AIStrategyId = @"recQQG2R7vnRDgWNW",
            createdTime = DateTime.Parse("2020-11-26T20:02:26Z"),
            Name = @"WaitsForInstruction",
            Description = @"Plays as proxy for a human.  A UI is needed to communicate the human's intentions.",
            PlayerLevel = null,
            StrategyRank = 1,
            SortOrder = 1
        };

        List.Add(WaitsForInstruction);
        ByEnum[AIStrategiesEnum.WaitsForInstruction] = WaitsForInstruction;
        
            
        var Random = new AIStrategy()
        {
            AIStrategyId = @"reca1n3gYdwjbxrcn",
            createdTime = DateTime.Parse("2020-11-26T20:02:26Z"),
            Name = @"Random",
            Description = @"Choice from a random selection amongst available cells",
            PlayerLevel = null,
            StrategyRank = 80,
            SortOrder = 2,
            AILevels = new string[] { @"recmMBaevl2jHl0hC", "recPPp5z8K4EAA2FW", "rec6OhVu8y6RKPscT" },
            AILevelNames = @"Beginner, Intermediate, Advanced"
        };

        List.Add(Random);
        ByEnum[AIStrategiesEnum.Random] = Random;
        
            
        var PlayInMiddleIfAvailable = new AIStrategy()
        {
            AIStrategyId = @"recZDBLLFUvFztYzW",
            createdTime = DateTime.Parse("2020-11-26T20:02:26Z"),
            Name = @"PlayInMiddleIfAvailable",
            Description = @"If there are no other winning strategies, play in the middle cell",
            PlayerLevel = null,
            StrategyRank = 50,
            SortOrder = 3,
            AILevels = new string[] { @"recmMBaevl2jHl0hC", "recPPp5z8K4EAA2FW", "rec6OhVu8y6RKPscT" },
            AILevelNames = @"Beginner, Intermediate, Advanced"
        };

        List.Add(PlayInMiddleIfAvailable);
        ByEnum[AIStrategiesEnum.PlayInMiddleIfAvailable] = PlayInMiddleIfAvailable;
        
            
        var WinIfPossible = new AIStrategy()
        {
            AIStrategyId = @"recyOJc1noL5zIhmx",
            createdTime = DateTime.Parse("2020-11-26T20:02:26Z"),
            Name = @"WinIfPossible",
            Description = @"If any two cells are already filled in by the AI, and the 3rd cell in that row is available, play there.",
            PlayerLevel = null,
            IsDefensive = Boolean.Parse("false"),
            StrategyRank = 2,
            SortOrder = 4,
            AILevels = new string[] { @"recmMBaevl2jHl0hC", "recPPp5z8K4EAA2FW", "rec6OhVu8y6RKPscT" },
            AILevelNames = @"Beginner, Intermediate, Advanced"
        };

        List.Add(WinIfPossible);
        ByEnum[AIStrategiesEnum.WinIfPossible] = WinIfPossible;
        
            
        var PreventWinIfPossible = new AIStrategy()
        {
            AIStrategyId = @"rec9YSojkIl2F85fV",
            createdTime = DateTime.Parse("2020-11-26T20:02:26Z"),
            Name = @"PreventWinIfPossible",
            Description = @"Prevent opponent from using WinIfPossible strategy",
            PlayerLevel = null,
            IsDefensive = Boolean.Parse("true"),
            StrategyRank = 5,
            SortOrder = 5,
            AILevels = new string[] { @"recPPp5z8K4EAA2FW", "rec6OhVu8y6RKPscT" },
            AILevelNames = @"Intermediate, Advanced"
        };

        List.Add(PreventWinIfPossible);
        ByEnum[AIStrategiesEnum.PreventWinIfPossible] = PreventWinIfPossible;
        
            
        var ForceWinNextTurn = new AIStrategy()
        {
            AIStrategyId = @"recGEVGA3ajKMQ2kD",
            createdTime = DateTime.Parse("2020-11-26T20:02:26Z"),
            Name = @"ForceWinNextTurn",
            Description = @"Check for a move that will force a win the next turn, regardless of what the opponent does.",
            PlayerLevel = null,
            IsDefensive = Boolean.Parse("false"),
            StrategyRank = 10,
            SortOrder = 6,
            AILevels = new string[] { @"recPPp5z8K4EAA2FW", "rec6OhVu8y6RKPscT" },
            AILevelNames = @"Intermediate, Advanced"
        };

        List.Add(ForceWinNextTurn);
        ByEnum[AIStrategiesEnum.ForceWinNextTurn] = ForceWinNextTurn;
        
            
        var PreventForceWinNextTurn = new AIStrategy()
        {
            AIStrategyId = @"recMqBdImRECSijls",
            createdTime = DateTime.Parse("2020-11-26T20:02:26Z"),
            Name = @"PreventForceWinNextTurn",
            Description = @"Prevent opponent from using ForceWinNextTurn strategy",
            PlayerLevel = null,
            IsDefensive = Boolean.Parse("true"),
            StrategyRank = 14,
            SortOrder = 7,
            AILevels = new string[] { @"recPPp5z8K4EAA2FW", "rec6OhVu8y6RKPscT" },
            AILevelNames = @"Intermediate, Advanced"
        };

        List.Add(PreventForceWinNextTurn);
        ByEnum[AIStrategiesEnum.PreventForceWinNextTurn] = PreventForceWinNextTurn;
        
            
        var PlayInCornerIfAvailable = new AIStrategy()
        {
            AIStrategyId = @"reclttwLO9tNIHGlo",
            createdTime = DateTime.Parse("2020-11-26T20:02:26Z"),
            Name = @"PlayInCornerIfAvailable",
            Description = @"If there are any corner positions available, player there",
            PlayerLevel = null,
            StrategyRank = 53,
            SortOrder = 8,
            AILevels = new string[] { @"rec6OhVu8y6RKPscT" },
            AILevelNames = @"Advanced"
        };

        List.Add(PlayInCornerIfAvailable);
        ByEnum[AIStrategiesEnum.PlayInCornerIfAvailable] = PlayInCornerIfAvailable;
        
            
        var SetupForceWinNextTurn = new AIStrategy()
        {
            AIStrategyId = @"recx2tCavviw3I7It",
            createdTime = DateTime.Parse("2020-11-26T20:02:26Z"),
            Name = @"SetupForceWinNextTurn",
            Description = @"Check if there's a move which will allow a force win next turn.",
            PlayerLevel = null,
            IsDefensive = Boolean.Parse("false"),
            StrategyRank = 16,
            SortOrder = 9,
            AILevels = new string[] { @"rec6OhVu8y6RKPscT" },
            AILevelNames = @"Advanced"
        };

        List.Add(SetupForceWinNextTurn);
        ByEnum[AIStrategiesEnum.SetupForceWinNextTurn] = SetupForceWinNextTurn;
        
            
        var PreventSetupForceWinNextTurn = new AIStrategy()
        {
            AIStrategyId = @"recuWctNLBYnhhsgj",
            createdTime = DateTime.Parse("2020-11-26T20:02:26Z"),
            Name = @"PreventSetupForceWinNextTurn",
            Description = @"Prevent opponent from using SetupForceWinNextTurn strategy",
            PlayerLevel = null,
            IsDefensive = Boolean.Parse("true"),
            StrategyRank = 20,
            SortOrder = 10,
            AILevels = new string[] { @"rec6OhVu8y6RKPscT" },
            AILevelNames = @"Advanced"
        };

        List.Add(PreventSetupForceWinNextTurn);
        ByEnum[AIStrategiesEnum.PreventSetupForceWinNextTurn] = PreventSetupForceWinNextTurn;
        
            
        var LearnFromMistakes = new AIStrategy()
        {
            AIStrategyId = @"reccQN2uoTvoIlAQR",
            createdTime = DateTime.Parse("2020-11-26T20:02:26Z"),
            Name = @"LearnFromMistakes",
            Description = @"Plays randomly, but keeps track of what moves are made, and learn from mistakes",
            PlayerLevel = null,
            StrategyRank = 200,
            SortOrder = 11,
            AILevels = new string[] { @"rec6OhVu8y6RKPscT" },
            AILevelNames = @"Advanced"
        };

        List.Add(LearnFromMistakes);
        ByEnum[AIStrategiesEnum.LearnFromMistakes] = LearnFromMistakes;
        
    }

}