using System;
using System.Linq;
using TicTacToeChallenge.Lib.DataClasses;

public static partial class CellPatterns
{
    private static void InitCellPatterns()
    {
        // setup each one...
        
            
        var EdgeWin = new CellPattern()
        {
            CellPatternId = @"recBDK2nzNlGSJNgJ",
            createdTime = DateTime.Parse("2020-11-26T20:06:43Z"),
            Name = @"EdgeWin",
            Description = @"Starting with the top row, 3 additional rotates will find all edge wins.",
            IsWinPattern = Boolean.Parse("true"),
            CellPatternCells = new string[] { @"recU9O3yxyMeQ1eU4", "recf1uu1YY0iPps8E", "recPHA9ppFH8cjenC" },
            CellPatternTranslations = new string[] { @"recD87U0swUjjhnTj" },
            SortOrder = 1,
            CellPatternTranslationCodes = new int[] { 30 },
            Cells = @"00;10;20",
            CellPatternCellStates = new int[] { 00, 10, 20 },
            Translations = @"30"
        };

        List.Add(EdgeWin);
        ByEnum[CellPatternsEnum.EdgeWin] = EdgeWin;
        
            
        var MiddleWin = new CellPattern()
        {
            CellPatternId = @"recodVK2HKbzC26Db",
            createdTime = DateTime.Parse("2020-11-26T20:06:43Z"),
            Name = @"MiddleWin",
            Description = @"Starting with the middle row selected, a single rotations finds both middle wins",
            IsWinPattern = Boolean.Parse("true"),
            CellPatternCells = new string[] { @"reckcKNNnyDSWpFrH", "recGP80BxFCLlmgw7", "recAy4XNSSKRZGZsh" },
            CellPatternTranslations = new string[] { @"recNz0LuN77HIXjmB" },
            SortOrder = 2,
            CellPatternTranslationCodes = new int[] { 10 },
            Cells = @"30;40;50",
            CellPatternCellStates = new int[] { 30, 40, 50 },
            Translations = @"10"
        };

        List.Add(MiddleWin);
        ByEnum[CellPatternsEnum.MiddleWin] = MiddleWin;
        
            
        var TwoInARowTop = new CellPattern()
        {
            CellPatternId = @"rec55PqGhtUYK5Rcb",
            createdTime = DateTime.Parse("2020-11-26T20:06:43Z"),
            Name = @"TwoInARowTop",
            Description = @"Two marks top left, top middle with top right empty - and then a full rotation/flip scheme.",
            CellPatternCells = new string[] { @"recclaJuN3LJWLC4N", "recFITGoLxBQs1ocD", "reccnHG0Yfk8tgTt6" },
            CellPatternTranslations = new string[] { @"recqJB1goFBhhsIVZ", "recwuYqQZ0iCw2WfQ", "recUD9c7vXgkNLQi9" },
            TargetCell = new string[] { @"recTGnKjXTE8LfT3C" },
            TargetCellState = new string[] { @"recJAi8YoTOQmzhfH" },
            SortOrder = 3,
            TargetCellIndex = 2,
            TargetCellStateId = 2,
            CellPatternTranslationCodes = new int[] { 30, 11, 30 },
            Cells = @"00;10;22",
            CellPatternCellStates = new int[] { 00, 10, 22 },
            Target = 22,
            Translations = @"30;11;30"
        };

        List.Add(TwoInARowTop);
        ByEnum[CellPatternsEnum.TwoInARowTop] = TwoInARowTop;
        
            
        var TwoInARowMiddle = new CellPattern()
        {
            CellPatternId = @"recqn6vuQrx71nQii",
            createdTime = DateTime.Parse("2020-11-26T20:06:43Z"),
            Name = @"TwoInARowMiddle",
            Description = @"Two in a row on the middle row, right side empty - finds all positions with 3 rotations.",
            CellPatternCells = new string[] { @"recxWA16nieZY83Sv", "recPmKMMNhYSxBWJ0", "rechiocdDSSkR1IFz" },
            CellPatternTranslations = new string[] { @"recJjgKw24kaBFH0i" },
            TargetCell = new string[] { @"recfSe8zeEdCAtcGq" },
            TargetCellState = new string[] { @"recJAi8YoTOQmzhfH" },
            SortOrder = 4,
            TargetCellIndex = 5,
            TargetCellStateId = 2,
            CellPatternTranslationCodes = new int[] { 30 },
            Cells = @"30;40;52",
            CellPatternCellStates = new int[] { 30, 40, 52 },
            Target = 52,
            Translations = @"30"
        };

        List.Add(TwoInARowMiddle);
        ByEnum[CellPatternsEnum.TwoInARowMiddle] = TwoInARowMiddle;
        
            
        var TwoInARowDiagonal = new CellPattern()
        {
            CellPatternId = @"recZCV8dlP1pNK9kK",
            createdTime = DateTime.Parse("2020-11-26T20:06:43Z"),
            Name = @"TwoInARowDiagonal",
            Description = @"Two in a row on the diagonal, with the third cell empty - finds all positions with 3 rotations.",
            CellPatternCells = new string[] { @"rec91aKNdkT2cw93v", "recwQ3ZI5MBVHPKgl", "rec5D3fwk2h5GzjIB" },
            CellPatternTranslations = new string[] { @"rec9PRnE4xpUCcMit" },
            TargetCell = new string[] { @"recczW2Y4WMv9buZ8" },
            TargetCellState = new string[] { @"recJAi8YoTOQmzhfH" },
            SortOrder = 5,
            TargetCellIndex = 8,
            TargetCellStateId = 2,
            CellPatternTranslationCodes = new int[] { 30 },
            Cells = @"00;40;82",
            CellPatternCellStates = new int[] { 00, 40, 82 },
            Target = 82,
            Translations = @"30"
        };

        List.Add(TwoInARowDiagonal);
        ByEnum[CellPatternsEnum.TwoInARowDiagonal] = TwoInARowDiagonal;
        
            
        var TwoOutsideTop = new CellPattern()
        {
            CellPatternId = @"recYmKv2dBpnAA1gs",
            createdTime = DateTime.Parse("2020-11-26T20:06:43Z"),
            Name = @"TwoOutsideTop",
            Description = @"Top left and top right filled, middle empty - finds all positions with 3 rotations.",
            CellPatternCells = new string[] { @"recKj18pU9k6V6MAx", "recljMfqekOodaaWx", "rec8bt4pVcy9OY8XO" },
            CellPatternTranslations = new string[] { @"reczr6h68ZUdkDIZb" },
            TargetCell = new string[] { @"recpPYOZtnp3lTOua" },
            TargetCellState = new string[] { @"recJAi8YoTOQmzhfH" },
            SortOrder = 6,
            TargetCellIndex = 1,
            TargetCellStateId = 2,
            CellPatternTranslationCodes = new int[] { 30 },
            Cells = @"00;12;20",
            CellPatternCellStates = new int[] { 00, 12, 20 },
            Target = 12,
            Translations = @"30"
        };

        List.Add(TwoOutsideTop);
        ByEnum[CellPatternsEnum.TwoOutsideTop] = TwoOutsideTop;
        
            
        var TwoOutsideMiddle = new CellPattern()
        {
            CellPatternId = @"recobCShOEyZjP8bY",
            createdTime = DateTime.Parse("2020-11-26T20:06:43Z"),
            Name = @"TwoOutsideMiddle",
            Description = @"Middle left and right, center empty - 1 rotation finds the one variation of the starting pattern.",
            CellPatternCells = new string[] { @"recyZobcdc9yOkGuC", "recaPLycHtpRQfWnE", "rec6RGGCG5ORVBnA3" },
            CellPatternTranslations = new string[] { @"recafoRwqvCh5HZOd" },
            TargetCell = new string[] { @"rec35HZOaRy6ge0jk" },
            TargetCellState = new string[] { @"recJAi8YoTOQmzhfH" },
            SortOrder = 7,
            TargetCellIndex = 4,
            TargetCellStateId = 2,
            CellPatternTranslationCodes = new int[] { 10 },
            Cells = @"30;42;50",
            CellPatternCellStates = new int[] { 30, 42, 50 },
            Target = 42,
            Translations = @"10"
        };

        List.Add(TwoOutsideMiddle);
        ByEnum[CellPatternsEnum.TwoOutsideMiddle] = TwoOutsideMiddle;
        
            
        var TwoOutsideDiagonal = new CellPattern()
        {
            CellPatternId = @"recg1ttw7l3n96PDG",
            createdTime = DateTime.Parse("2020-11-26T20:06:43Z"),
            Name = @"TwoOutsideDiagonal",
            Description = @"Top left and bottom right with middle empty  - 1 rotation finds the one variation of the starting pattern.",
            CellPatternCells = new string[] { @"recYR4cE90EOVnYD5", "recWoh5Qk0b1xBV67", "reclDV8jky7y1JNzH" },
            CellPatternTranslations = new string[] { @"recoPtQQ8QZtClJK0" },
            TargetCell = new string[] { @"rec35HZOaRy6ge0jk" },
            TargetCellState = new string[] { @"recJAi8YoTOQmzhfH" },
            SortOrder = 8,
            TargetCellIndex = 4,
            TargetCellStateId = 2,
            CellPatternTranslationCodes = new int[] { 10 },
            Cells = @"00;42;80",
            CellPatternCellStates = new int[] { 00, 42, 80 },
            Target = 42,
            Translations = @"10"
        };

        List.Add(TwoOutsideDiagonal);
        ByEnum[CellPatternsEnum.TwoOutsideDiagonal] = TwoOutsideDiagonal;
        
    }

}