using System;
using System.Linq;
using TicTacToeChallenge.Lib.DataClasses;

public static partial class CellPatternTranslations
{
    private static void InitCellPatternTranslations()
    {
        // setup each one...
        
            
        var T1_TwoInARowDiagonalRotate3 = new CellPatternTranslation()
        {
            CellPatternTranslationId = @"rec9PRnE4xpUCcMit",
            createdTime = DateTime.Parse("2020-11-26T20:39:35Z"),
            Translation = new string[] { @"recgdoYW4iJ8gaAha" },
            CellPattern = new string[] { @"recZCV8dlP1pNK9kK" },
            Count = 3,
            SortOrder = 1,
            Name = @"T1-TwoInARowDiagonal:Rotate:3",
            TranslationId = 0,
            CPTCode = 30,
            DisplayName = @"Rotate 3 times",
            CellPatternName = @"TwoInARowDiagonal",
            TranslationName = @"Rotate"
        };

        List.Add(T1_TwoInARowDiagonalRotate3);
        ByEnum[CellPatternTranslationsEnum.T1_TwoInARowDiagonalRotate3] = T1_TwoInARowDiagonalRotate3;
        
            
        var T1_EdgeWinRotate3 = new CellPatternTranslation()
        {
            CellPatternTranslationId = @"recD87U0swUjjhnTj",
            createdTime = DateTime.Parse("2020-11-26T20:39:24Z"),
            Translation = new string[] { @"recgdoYW4iJ8gaAha" },
            CellPattern = new string[] { @"recBDK2nzNlGSJNgJ" },
            Count = 3,
            SortOrder = 1,
            Name = @"T1-EdgeWin:Rotate:3",
            TranslationId = 0,
            CPTCode = 30,
            DisplayName = @"Rotate 3 times",
            CellPatternName = @"EdgeWin",
            TranslationName = @"Rotate"
        };

        List.Add(T1_EdgeWinRotate3);
        ByEnum[CellPatternTranslationsEnum.T1_EdgeWinRotate3] = T1_EdgeWinRotate3;
        
            
        var T1_TwoInARowMiddleRotate3 = new CellPatternTranslation()
        {
            CellPatternTranslationId = @"recJjgKw24kaBFH0i",
            createdTime = DateTime.Parse("2020-11-26T20:39:35Z"),
            Translation = new string[] { @"recgdoYW4iJ8gaAha" },
            CellPattern = new string[] { @"recqn6vuQrx71nQii" },
            Count = 3,
            SortOrder = 1,
            Name = @"T1-TwoInARowMiddle:Rotate:3",
            TranslationId = 0,
            CPTCode = 30,
            DisplayName = @"Rotate 3 times",
            CellPatternName = @"TwoInARowMiddle",
            TranslationName = @"Rotate"
        };

        List.Add(T1_TwoInARowMiddleRotate3);
        ByEnum[CellPatternTranslationsEnum.T1_TwoInARowMiddleRotate3] = T1_TwoInARowMiddleRotate3;
        
            
        var T1_MiddleWinRotate1 = new CellPatternTranslation()
        {
            CellPatternTranslationId = @"recNz0LuN77HIXjmB",
            createdTime = DateTime.Parse("2020-11-26T20:39:35Z"),
            Translation = new string[] { @"recgdoYW4iJ8gaAha" },
            CellPattern = new string[] { @"recodVK2HKbzC26Db" },
            Count = 1,
            SortOrder = 1,
            Name = @"T1-MiddleWin:Rotate:1",
            TranslationId = 0,
            CPTCode = 10,
            DisplayName = @"Rotate Once",
            CellPatternName = @"MiddleWin",
            TranslationName = @"Rotate"
        };

        List.Add(T1_MiddleWinRotate1);
        ByEnum[CellPatternTranslationsEnum.T1_MiddleWinRotate1] = T1_MiddleWinRotate1;
        
            
        var T1_TwoOutsideMiddleRotate1 = new CellPatternTranslation()
        {
            CellPatternTranslationId = @"recafoRwqvCh5HZOd",
            createdTime = DateTime.Parse("2020-11-26T20:39:35Z"),
            Translation = new string[] { @"recgdoYW4iJ8gaAha" },
            CellPattern = new string[] { @"recobCShOEyZjP8bY" },
            Count = 1,
            SortOrder = 1,
            Name = @"T1-TwoOutsideMiddle:Rotate:1",
            TranslationId = 0,
            CPTCode = 10,
            DisplayName = @"Rotate Once",
            CellPatternName = @"TwoOutsideMiddle",
            TranslationName = @"Rotate"
        };

        List.Add(T1_TwoOutsideMiddleRotate1);
        ByEnum[CellPatternTranslationsEnum.T1_TwoOutsideMiddleRotate1] = T1_TwoOutsideMiddleRotate1;
        
            
        var T1_DiagonalWinFlip1 = new CellPatternTranslation()
        {
            CellPatternTranslationId = @"recmUpophHSQKe5VF",
            createdTime = DateTime.Parse("2020-12-18T20:42:34Z"),
            Name = @"T1-DiagonalWin:Flip:1",
            CPTCode = 11,
            DisplayName = @"Flip Once",
            CellPattern = new string[] { @"recuenPSYKnW2WfOH" },
            CellPatternName = @"DiagonalWin",
            Translation = new string[] { @"recQ0PgyWBky0wm32" },
            TranslationId = 1,
            TranslationName = @"Flip",
            SortOrder = 1,
            Count = 1
        };

        List.Add(T1_DiagonalWinFlip1);
        ByEnum[CellPatternTranslationsEnum.T1_DiagonalWinFlip1] = T1_DiagonalWinFlip1;
        
            
        var T1_TwoOutsideDiagonalRotate1 = new CellPatternTranslation()
        {
            CellPatternTranslationId = @"recoPtQQ8QZtClJK0",
            createdTime = DateTime.Parse("2020-11-26T20:39:35Z"),
            Translation = new string[] { @"recgdoYW4iJ8gaAha" },
            CellPattern = new string[] { @"recg1ttw7l3n96PDG" },
            Count = 1,
            SortOrder = 1,
            Name = @"T1-TwoOutsideDiagonal:Rotate:1",
            TranslationId = 0,
            CPTCode = 10,
            DisplayName = @"Rotate Once",
            CellPatternName = @"TwoOutsideDiagonal",
            TranslationName = @"Rotate"
        };

        List.Add(T1_TwoOutsideDiagonalRotate1);
        ByEnum[CellPatternTranslationsEnum.T1_TwoOutsideDiagonalRotate1] = T1_TwoOutsideDiagonalRotate1;
        
            
        var T1_TwoInARowTopRotate3 = new CellPatternTranslation()
        {
            CellPatternTranslationId = @"recqJB1goFBhhsIVZ",
            createdTime = DateTime.Parse("2020-11-26T20:39:35Z"),
            Translation = new string[] { @"recgdoYW4iJ8gaAha" },
            CellPattern = new string[] { @"rec55PqGhtUYK5Rcb" },
            Count = 3,
            SortOrder = 1,
            Name = @"T1-TwoInARowTop:Rotate:3",
            TranslationId = 0,
            CPTCode = 30,
            DisplayName = @"Rotate 3 times",
            CellPatternName = @"TwoInARowTop",
            TranslationName = @"Rotate"
        };

        List.Add(T1_TwoInARowTopRotate3);
        ByEnum[CellPatternTranslationsEnum.T1_TwoInARowTopRotate3] = T1_TwoInARowTopRotate3;
        
            
        var T1_TwoOutsideTopRotate3 = new CellPatternTranslation()
        {
            CellPatternTranslationId = @"reczr6h68ZUdkDIZb",
            createdTime = DateTime.Parse("2020-11-26T20:39:35Z"),
            Translation = new string[] { @"recgdoYW4iJ8gaAha" },
            CellPattern = new string[] { @"recYmKv2dBpnAA1gs" },
            Count = 3,
            SortOrder = 1,
            Name = @"T1-TwoOutsideTop:Rotate:3",
            TranslationId = 0,
            CPTCode = 30,
            DisplayName = @"Rotate 3 times",
            CellPatternName = @"TwoOutsideTop",
            TranslationName = @"Rotate"
        };

        List.Add(T1_TwoOutsideTopRotate3);
        ByEnum[CellPatternTranslationsEnum.T1_TwoOutsideTopRotate3] = T1_TwoOutsideTopRotate3;
        
            
        var T2_TwoInARowTopFlip1 = new CellPatternTranslation()
        {
            CellPatternTranslationId = @"recwuYqQZ0iCw2WfQ",
            createdTime = DateTime.Parse("2020-11-26T21:11:07Z"),
            Translation = new string[] { @"recQ0PgyWBky0wm32" },
            CellPattern = new string[] { @"rec55PqGhtUYK5Rcb" },
            Count = 1,
            SortOrder = 2,
            Name = @"T2-TwoInARowTop:Flip:1",
            TranslationId = 1,
            CPTCode = 11,
            DisplayName = @"Flip Once",
            CellPatternName = @"TwoInARowTop",
            TranslationName = @"Flip"
        };

        List.Add(T2_TwoInARowTopFlip1);
        ByEnum[CellPatternTranslationsEnum.T2_TwoInARowTopFlip1] = T2_TwoInARowTopFlip1;
        
            
        var T3_TwoInARowTopRotate3 = new CellPatternTranslation()
        {
            CellPatternTranslationId = @"recUD9c7vXgkNLQi9",
            createdTime = DateTime.Parse("2020-11-26T21:13:00Z"),
            Translation = new string[] { @"recgdoYW4iJ8gaAha" },
            CellPattern = new string[] { @"rec55PqGhtUYK5Rcb" },
            Count = 3,
            SortOrder = 3,
            Name = @"T3-TwoInARowTop:Rotate:3",
            TranslationId = 0,
            CPTCode = 30,
            DisplayName = @"Rotate 3 times",
            CellPatternName = @"TwoInARowTop",
            TranslationName = @"Rotate"
        };

        List.Add(T3_TwoInARowTopRotate3);
        ByEnum[CellPatternTranslationsEnum.T3_TwoInARowTopRotate3] = T3_TwoInARowTopRotate3;
        
    }

}