using System;
using System.Linq;
using TicTacToeChallenge.Lib.DataClasses;

public static partial class LanguageTokens
{
    private static void InitLanguageTokens()
    {
        // setup each one...
        
            
        var testtoken = new LanguageToken()
        {
            LanguageTokenId = @"rec7hUrPQOlsmHWTK",
            createdTime = DateTime.Parse("2020-12-16T00:36:17Z"),
            Name = @"testtoken",
            Token = @"testtoken"
        };

        List.Add(testtoken);
        ByEnum[LanguageTokensEnum.testtoken] = testtoken;
        
            
        var Title = new LanguageToken()
        {
            LanguageTokenId = @"recNnnObNV1wEGXUI",
            createdTime = DateTime.Parse("2020-11-26T20:01:30Z"),
            Name = @"Title",
            DisplayName = @"Bob's 3x3 Tic-Tac-Toe",
            SortOrder = 1,
            Token = @"Title"
        };

        List.Add(Title);
        ByEnum[LanguageTokensEnum.Title] = Title;
        
            
        var GameOn = new LanguageToken()
        {
            LanguageTokenId = @"recTxNSWmH6qLLtgj",
            createdTime = DateTime.Parse("2020-11-26T20:01:30Z"),
            Name = @"GameOn",
            DisplayName = @"Game On",
            SortOrder = 2,
            Token = @"GameOn"
        };

        List.Add(GameOn);
        ByEnum[LanguageTokensEnum.GameOn] = GameOn;
        
            
        var GameOver = new LanguageToken()
        {
            LanguageTokenId = @"rec1au6Wnbaf3oO1u",
            createdTime = DateTime.Parse("2020-11-26T20:01:30Z"),
            Name = @"GameOver",
            DisplayName = @"Game Over",
            SortOrder = 3,
            Token = @"GameOver"
        };

        List.Add(GameOver);
        ByEnum[LanguageTokensEnum.GameOver] = GameOver;
        
            
        var YourTurn = new LanguageToken()
        {
            LanguageTokenId = @"recFy1FsoP1ORWYWj",
            createdTime = DateTime.Parse("2020-11-26T20:01:30Z"),
            Name = @"YourTurn",
            DisplayName = @"It's your turn",
            SortOrder = 4,
            Token = @"YourTurn"
        };

        List.Add(YourTurn);
        ByEnum[LanguageTokensEnum.YourTurn] = YourTurn;
        
            
        var TheirTurn = new LanguageToken()
        {
            LanguageTokenId = @"recdK8VdwOgWPXEf4",
            createdTime = DateTime.Parse("2020-11-26T20:01:30Z"),
            Name = @"TheirTurn",
            DisplayName = @"It's their turn",
            SortOrder = 5,
            Token = @"TheirTurn"
        };

        List.Add(TheirTurn);
        ByEnum[LanguageTokensEnum.TheirTurn] = TheirTurn;
        
            
        var YouWon = new LanguageToken()
        {
            LanguageTokenId = @"recPamDrUmmMfoUtj",
            createdTime = DateTime.Parse("2020-11-26T20:01:30Z"),
            Name = @"YouWon",
            DisplayName = @"You Won",
            SortOrder = 6,
            Token = @"YouWon"
        };

        List.Add(YouWon);
        ByEnum[LanguageTokensEnum.YouWon] = YouWon;
        
            
        var TheyWon = new LanguageToken()
        {
            LanguageTokenId = @"recOqDsQXph2jV645",
            createdTime = DateTime.Parse("2020-11-26T20:01:30Z"),
            Name = @"TheyWon",
            DisplayName = @"You Lost",
            SortOrder = 7,
            Token = @"TheyWon"
        };

        List.Add(TheyWon);
        ByEnum[LanguageTokensEnum.TheyWon] = TheyWon;
        
    }

}