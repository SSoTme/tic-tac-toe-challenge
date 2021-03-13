using System;
using System.Linq;
using TicTacToeChallenge.Lib.DataClasses;

public static partial class CellPatterns
{
    private static void InitCellPatterns()
    {
        // setup each one...
        
            
        var DiagonalWin = new CellPattern()
        {
            CellPatternId = @"recuenPSYKnW2WfOH",
            createdTime = DateTime.Parse("2020-12-18T20:42:06Z"),
            SortOrder = 20,
            CellPatternType = @"Win",
            IsWinPattern = Boolean.Parse("true"),
            Cells = @"00;40;80",
            Translations = @"11",
            Name = @"DiagonalWin",
            Description = @"Win along either diagonal",
            CellPatternCells = new string[] { @"recR4dC3tW41PPZ8x", "recq7x7WkznTcTKS7", "recTcBwvPbWD9wMyy" },
            CellPatternCellStates = new int[] { 00, 40, 80 },
            CellPatternCelICellIndexes = new int[] { 0, 4, 8 },
            CellPatternCellCells = new string[] { @"rec50MWM91QHzlEzO", "rec35HZOaRy6ge0jk", "recczW2Y4WMv9buZ8" },
            CellPatternCellCellNames = new string[] { @"TopLeft", "Middle", "BottomRight" },
            CellPatternTranslations = new string[] { @"recmUpophHSQKe5VF" },
            CellPatternTranslationCodes = new int[] { 11 },
            TranslationNames = new string[] { @"Flip Once" }
        };

        List.Add(DiagonalWin);
        ByEnum[CellPatternsEnum.DiagonalWin] = DiagonalWin;
        
            
        var Row1 = new CellPattern()
        {
            CellPatternId = @"recYQei900zbRIFTw",
            createdTime = DateTime.Parse("2020-12-12T00:45:13Z"),
            Name = @"Row1",
            Description = @"The firist (top) row in the puzzle",
            CellPatternCells = new string[] { @"recLcTgsFF8EuGUz3", "recJtIPt56a61dAFz", "recD2BUDpoknNF4Lh" },
            SortOrder = 30,
            CellPatternType = @"NamedSet",
            IsWinPattern = Boolean.Parse("true"),
            CellPatternCellStates = new int[] { 00, 10, 20 },
            Cells = @"00;10;20",
            CellPatternCelICellIndexes = new int[] { 0, 1, 2 },
            CellPatternCellCells = new string[] { @"rec50MWM91QHzlEzO", "recpPYOZtnp3lTOua", "recTGnKjXTE8LfT3C" },
            CellPatternCellCellNames = new string[] { @"TopLeft", "Top", "TopRight" },
            
        };

        List.Add(Row1);
        ByEnum[CellPatternsEnum.Row1] = Row1;
        
            
        var Row2 = new CellPattern()
        {
            CellPatternId = @"recqpmR7MAtp5afiM",
            createdTime = DateTime.Parse("2020-12-12T00:45:33Z"),
            Name = @"Row2",
            Description = @"The 2nd (middle) row in the puzzle",
            CellPatternCells = new string[] { @"recpAYbzVjDRhc1L4", "recUNdmTwmeITNGEZ", "recBi8mtXhiWj7TJH" },
            SortOrder = 31,
            CellPatternType = @"NamedSet",
            IsWinPattern = Boolean.Parse("true"),
            CellPatternCellStates = new int[] { 30, 40, 50 },
            Cells = @"30;40;50",
            CellPatternCelICellIndexes = new int[] { 3, 4, 5 },
            CellPatternCellCells = new string[] { @"recxIf3GoDzEtonFU", "rec35HZOaRy6ge0jk", "recfSe8zeEdCAtcGq" },
            CellPatternCellCellNames = new string[] { @"MiddleLeft", "Middle", "MiddleRight" },
            
        };

        List.Add(Row2);
        ByEnum[CellPatternsEnum.Row2] = Row2;
        
            
        var Row3 = new CellPattern()
        {
            CellPatternId = @"recHqX6LLAZZAo1RQ",
            createdTime = DateTime.Parse("2020-12-12T00:45:52Z"),
            Name = @"Row3",
            Description = @"The 3rd (bottom) row in the puzzle.",
            CellPatternCells = new string[] { @"rec7NXPxQPU4PzKX0", "recmHFemnt2tO9Q5u", "recc99ZERSFi8OZgJ" },
            SortOrder = 32,
            CellPatternType = @"NamedSet",
            IsWinPattern = Boolean.Parse("true"),
            CellPatternCellStates = new int[] { 60, 70, 80 },
            Cells = @"60;70;80",
            CellPatternCelICellIndexes = new int[] { 6, 7, 8 },
            CellPatternCellCells = new string[] { @"recmjtZPRUfoCU2sr", "rec3OzG8nTAkUhjVn", "recczW2Y4WMv9buZ8" },
            CellPatternCellCellNames = new string[] { @"BottomLeft", "Bottom", "BottomRight" },
            
        };

        List.Add(Row3);
        ByEnum[CellPatternsEnum.Row3] = Row3;
        
            
        var Column1 = new CellPattern()
        {
            CellPatternId = @"recJ1wDRP5taMg2Tj",
            createdTime = DateTime.Parse("2020-12-12T00:45:58Z"),
            Name = @"Column1",
            Description = @"The 1st (leftmost)column in the puzzle.",
            CellPatternCells = new string[] { @"rec1hqH6Ty1vueu48", "recmEXEqSbCsI5kUB", "recShopv0fRnIWAbr" },
            SortOrder = 40,
            CellPatternType = @"NamedSet",
            IsWinPattern = Boolean.Parse("true"),
            CellPatternCellStates = new int[] { 00, 30, 60 },
            Cells = @"00;30;60",
            CellPatternCelICellIndexes = new int[] { 0, 3, 6 },
            CellPatternCellCells = new string[] { @"rec50MWM91QHzlEzO", "recxIf3GoDzEtonFU", "recmjtZPRUfoCU2sr" },
            CellPatternCellCellNames = new string[] { @"TopLeft", "MiddleLeft", "BottomLeft" },
            
        };

        List.Add(Column1);
        ByEnum[CellPatternsEnum.Column1] = Column1;
        
            
        var Column2 = new CellPattern()
        {
            CellPatternId = @"recXBksm5DIUqOfDn",
            createdTime = DateTime.Parse("2020-12-12T00:45:59Z"),
            Name = @"Column2",
            Description = @"The 2nd (middle) column in the puzzle.",
            CellPatternCells = new string[] { @"rec3K2fxtqlgu5oeA", "recy5CwlzxHvsubBr", "recVxUYMsnvGIqGZ2" },
            SortOrder = 41,
            CellPatternType = @"NamedSet",
            IsWinPattern = Boolean.Parse("true"),
            CellPatternCellStates = new int[] { 10, 40, 70 },
            Cells = @"10;40;70",
            CellPatternCelICellIndexes = new int[] { 1, 4, 7 },
            CellPatternCellCells = new string[] { @"recpPYOZtnp3lTOua", "rec35HZOaRy6ge0jk", "rec3OzG8nTAkUhjVn" },
            CellPatternCellCellNames = new string[] { @"Top", "Middle", "Bottom" },
            
        };

        List.Add(Column2);
        ByEnum[CellPatternsEnum.Column2] = Column2;
        
            
        var Column3 = new CellPattern()
        {
            CellPatternId = @"recNW9KXsm9KvWa7B",
            createdTime = DateTime.Parse("2020-12-12T00:46:00Z"),
            Name = @"Column3",
            Description = @"The 3rd (rightmost) column in the puzzle.",
            CellPatternCells = new string[] { @"recO1aArEBMEvWxoD", "recvjeyFh2sWFF8us", "reczQDKs6sXAjFvhP" },
            SortOrder = 42,
            CellPatternType = @"NamedSet",
            IsWinPattern = Boolean.Parse("true"),
            CellPatternCellStates = new int[] { 20, 50, 80 },
            Cells = @"20;50;80",
            CellPatternCelICellIndexes = new int[] { 2, 5, 8 },
            CellPatternCellCells = new string[] { @"recTGnKjXTE8LfT3C", "recfSe8zeEdCAtcGq", "recczW2Y4WMv9buZ8" },
            CellPatternCellCellNames = new string[] { @"TopRight", "MiddleRight", "BottomRight" },
            
        };

        List.Add(Column3);
        ByEnum[CellPatternsEnum.Column3] = Column3;
        
            
        var LeftRightDiagonal = new CellPattern()
        {
            CellPatternId = @"reccf6U6b21xlIOh7",
            createdTime = DateTime.Parse("2020-12-12T00:46:07Z"),
            Name = @"LeftRightDiagonal",
            Description = @"The diagonal from top left to bottom right.",
            CellPatternCells = new string[] { @"recuKKiaqoaXhFxSC", "recAJ25e2uael63Kw", "recfjQk3Amk3Ofo0S" },
            SortOrder = 50,
            CellPatternType = @"NamedSet",
            IsWinPattern = Boolean.Parse("true"),
            CellPatternCellStates = new int[] { 00, 40, 80 },
            Cells = @"00;40;80",
            CellPatternCelICellIndexes = new int[] { 0, 4, 8 },
            CellPatternCellCells = new string[] { @"rec50MWM91QHzlEzO", "rec35HZOaRy6ge0jk", "recczW2Y4WMv9buZ8" },
            CellPatternCellCellNames = new string[] { @"TopLeft", "Middle", "BottomRight" },
            
        };

        List.Add(LeftRightDiagonal);
        ByEnum[CellPatternsEnum.LeftRightDiagonal] = LeftRightDiagonal;
        
            
        var RightLeftDiagonal = new CellPattern()
        {
            CellPatternId = @"recWQyBlj7xHrYNPx",
            createdTime = DateTime.Parse("2020-12-12T00:46:19Z"),
            Name = @"RightLeftDiagonal",
            Description = @"The Diagonal from top right to bottom left.",
            CellPatternCells = new string[] { @"recrfBGkdzZ67jeLa", "rec1Gsh1wvAQ3BO0w", "recTk43h9Sd9Qw1aQ" },
            SortOrder = 51,
            CellPatternType = @"NamedSet",
            IsWinPattern = Boolean.Parse("true"),
            CellPatternCellStates = new int[] { 20, 40, 60 },
            Cells = @"20;40;60",
            CellPatternCelICellIndexes = new int[] { 2, 4, 6 },
            CellPatternCellCells = new string[] { @"recTGnKjXTE8LfT3C", "rec35HZOaRy6ge0jk", "recmjtZPRUfoCU2sr" },
            CellPatternCellCellNames = new string[] { @"TopRight", "Middle", "BottomLeft" },
            
        };

        List.Add(RightLeftDiagonal);
        ByEnum[CellPatternsEnum.RightLeftDiagonal] = RightLeftDiagonal;
        
            
        var EdgeWin = new CellPattern()
        {
            CellPatternId = @"recBDK2nzNlGSJNgJ",
            createdTime = DateTime.Parse("2020-11-26T20:06:43Z"),
            Name = @"EdgeWin",
            Description = @"Starting with the top row, 3 additional rotates will find all edge wins.",
            CellPatternCells = new string[] { @"recU9O3yxyMeQ1eU4", "recf1uu1YY0iPps8E", "recPHA9ppFH8cjenC" },
            CellPatternTranslations = new string[] { @"recD87U0swUjjhnTj" },
            SortOrder = 75,
            CellPatternType = @"Win",
            IsWinPattern = Boolean.Parse("true"),
            CellPatternCellStates = new int[] { 00, 10, 20 },
            Cells = @"00;10;20",
            CellPatternTranslationCodes = new int[] { 30 },
            Translations = @"30",
            CellPatternCelICellIndexes = new int[] { 0, 1, 2 },
            CellPatternCellCells = new string[] { @"rec50MWM91QHzlEzO", "recpPYOZtnp3lTOua", "recTGnKjXTE8LfT3C" },
            CellPatternCellCellNames = new string[] { @"TopLeft", "Top", "TopRight" },
            TranslationNames = new string[] { @"Rotate 3 times" }
        };

        List.Add(EdgeWin);
        ByEnum[CellPatternsEnum.EdgeWin] = EdgeWin;
        
            
        var MiddleWin = new CellPattern()
        {
            CellPatternId = @"recodVK2HKbzC26Db",
            createdTime = DateTime.Parse("2020-11-26T20:06:43Z"),
            Name = @"MiddleWin",
            Description = @"Starting with the middle row selected, a single rotations finds both middle wins",
            CellPatternCells = new string[] { @"reckcKNNnyDSWpFrH", "recGP80BxFCLlmgw7", "recAy4XNSSKRZGZsh" },
            CellPatternTranslations = new string[] { @"recNz0LuN77HIXjmB" },
            SortOrder = 76,
            CellPatternType = @"Win",
            IsWinPattern = Boolean.Parse("true"),
            CellPatternCellStates = new int[] { 30, 40, 50 },
            Cells = @"30;40;50",
            CellPatternTranslationCodes = new int[] { 10 },
            Translations = @"10",
            CellPatternCelICellIndexes = new int[] { 3, 4, 5 },
            CellPatternCellCells = new string[] { @"recxIf3GoDzEtonFU", "rec35HZOaRy6ge0jk", "recfSe8zeEdCAtcGq" },
            CellPatternCellCellNames = new string[] { @"MiddleLeft", "Middle", "MiddleRight" },
            TranslationNames = new string[] { @"Rotate Once" }
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
            SortOrder = 103,
            CellPatternType = @"PossibleWin",
            IsWinPattern = Boolean.Parse("false"),
            TargetCellStateId = 2,
            CellPatternCellStates = new int[] { 00, 10, 22 },
            Cells = @"00;10;22",
            TargetCellIndex = 2,
            Target = 22,
            CellPatternTranslationCodes = new int[] { 30, 11, 30 },
            Translations = @"30;11;30",
            CellPatternCelICellIndexes = new int[] { 0, 1, 2 },
            CellPatternCellCells = new string[] { @"rec50MWM91QHzlEzO", "recpPYOZtnp3lTOua", "recTGnKjXTE8LfT3C" },
            CellPatternCellCellNames = new string[] { @"TopLeft", "Top", "TopRight" },
            TranslationNames = new string[] { @"Rotate 3 times", "Flip Once", "Rotate 3 times" },
            TargetDescription = @"TopRight is NoPlayer",
            TargetCellName = @"TopRight",
            TargetCellStateName = @"NoPlayer"
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
            SortOrder = 104,
            CellPatternType = @"PossibleWin",
            IsWinPattern = Boolean.Parse("false"),
            TargetCellStateId = 2,
            CellPatternCellStates = new int[] { 30, 40, 52 },
            Cells = @"30;40;52",
            TargetCellIndex = 5,
            Target = 52,
            CellPatternTranslationCodes = new int[] { 30 },
            Translations = @"30",
            CellPatternCelICellIndexes = new int[] { 3, 4, 5 },
            CellPatternCellCells = new string[] { @"recxIf3GoDzEtonFU", "rec35HZOaRy6ge0jk", "recfSe8zeEdCAtcGq" },
            CellPatternCellCellNames = new string[] { @"MiddleLeft", "Middle", "MiddleRight" },
            TranslationNames = new string[] { @"Rotate 3 times" },
            TargetDescription = @"MiddleRight is NoPlayer",
            TargetCellName = @"MiddleRight",
            TargetCellStateName = @"NoPlayer"
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
            SortOrder = 105,
            CellPatternType = @"PossibleWin",
            IsWinPattern = Boolean.Parse("false"),
            TargetCellStateId = 2,
            CellPatternCellStates = new int[] { 00, 40, 82 },
            Cells = @"00;40;82",
            TargetCellIndex = 8,
            Target = 82,
            CellPatternTranslationCodes = new int[] { 30 },
            Translations = @"30",
            CellPatternCelICellIndexes = new int[] { 0, 4, 8 },
            CellPatternCellCells = new string[] { @"rec50MWM91QHzlEzO", "rec35HZOaRy6ge0jk", "recczW2Y4WMv9buZ8" },
            CellPatternCellCellNames = new string[] { @"TopLeft", "Middle", "BottomRight" },
            TranslationNames = new string[] { @"Rotate 3 times" },
            TargetDescription = @"BottomRight is NoPlayer",
            TargetCellName = @"BottomRight",
            TargetCellStateName = @"NoPlayer"
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
            SortOrder = 106,
            CellPatternType = @"PossibleWin",
            IsWinPattern = Boolean.Parse("false"),
            TargetCellStateId = 2,
            CellPatternCellStates = new int[] { 00, 12, 20 },
            Cells = @"00;12;20",
            TargetCellIndex = 1,
            Target = 12,
            CellPatternTranslationCodes = new int[] { 30 },
            Translations = @"30",
            CellPatternCelICellIndexes = new int[] { 0, 1, 2 },
            CellPatternCellCells = new string[] { @"rec50MWM91QHzlEzO", "recpPYOZtnp3lTOua", "recTGnKjXTE8LfT3C" },
            CellPatternCellCellNames = new string[] { @"TopLeft", "Top", "TopRight" },
            TranslationNames = new string[] { @"Rotate 3 times" },
            TargetDescription = @"Top is NoPlayer",
            TargetCellName = @"Top",
            TargetCellStateName = @"NoPlayer"
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
            SortOrder = 107,
            CellPatternType = @"PossibleWin",
            IsWinPattern = Boolean.Parse("false"),
            TargetCellStateId = 2,
            CellPatternCellStates = new int[] { 30, 42, 50 },
            Cells = @"30;42;50",
            TargetCellIndex = 4,
            Target = 42,
            CellPatternTranslationCodes = new int[] { 10 },
            Translations = @"10",
            CellPatternCelICellIndexes = new int[] { 3, 4, 5 },
            CellPatternCellCells = new string[] { @"recxIf3GoDzEtonFU", "rec35HZOaRy6ge0jk", "recfSe8zeEdCAtcGq" },
            CellPatternCellCellNames = new string[] { @"MiddleLeft", "Middle", "MiddleRight" },
            TranslationNames = new string[] { @"Rotate Once" },
            TargetDescription = @"Middle is NoPlayer",
            TargetCellName = @"Middle",
            TargetCellStateName = @"NoPlayer"
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
            SortOrder = 108,
            CellPatternType = @"PossibleWin",
            IsWinPattern = Boolean.Parse("false"),
            TargetCellStateId = 2,
            CellPatternCellStates = new int[] { 00, 42, 80 },
            Cells = @"00;42;80",
            TargetCellIndex = 4,
            Target = 42,
            CellPatternTranslationCodes = new int[] { 10 },
            Translations = @"10",
            CellPatternCelICellIndexes = new int[] { 0, 4, 8 },
            CellPatternCellCells = new string[] { @"rec50MWM91QHzlEzO", "rec35HZOaRy6ge0jk", "recczW2Y4WMv9buZ8" },
            CellPatternCellCellNames = new string[] { @"TopLeft", "Middle", "BottomRight" },
            TranslationNames = new string[] { @"Rotate Once" },
            TargetDescription = @"Middle is NoPlayer",
            TargetCellName = @"Middle",
            TargetCellStateName = @"NoPlayer"
        };

        List.Add(TwoOutsideDiagonal);
        ByEnum[CellPatternsEnum.TwoOutsideDiagonal] = TwoOutsideDiagonal;
        
    }

}