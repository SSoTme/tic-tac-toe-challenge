using System;
using System.Linq;
using TicTacToeChallenge.Lib.DataClasses;

public static partial class CellStates
{
    private static void InitCellStates()
    {
        // setup each one...
        
            
        var PlayerA = new CellState()
        {
            CellStateId = @"rec0xQjo4VL3DFTXg",
            createdTime = DateTime.Parse("2020-11-26T20:04:48Z"),
            Name = @"PlayerA",
            Code = @"P",
            Description = @"This cell has been marked by the active player",
            Color = @"yellow",
            FontColor = @"black",
            DefaultMark = @"A",
            Cursor = @"Default",
            SortOrder = 1,
            Id = 0,
            CellPatternCells = new string[] { @"recU9O3yxyMeQ1eU4", "recf1uu1YY0iPps8E", "recPHA9ppFH8cjenC", "reckcKNNnyDSWpFrH", "recGP80BxFCLlmgw7", "recAy4XNSSKRZGZsh", "recYR4cE90EOVnYD5", "reclDV8jky7y1JNzH", "rec91aKNdkT2cw93v", "recwQ3ZI5MBVHPKgl", "recxWA16nieZY83Sv", "recPmKMMNhYSxBWJ0", "recclaJuN3LJWLC4N", "recFITGoLxBQs1ocD", "recyZobcdc9yOkGuC", "rec6RGGCG5ORVBnA3", "recKj18pU9k6V6MAx", "rec8bt4pVcy9OY8XO" },
            CurrentStateCells = new string[] { @"rec50MWM91QHzlEzO", "rec35HZOaRy6ge0jk" },
            
        };

        List.Add(PlayerA);
        ByEnum[CellStatesEnum.PlayerA] = PlayerA;
        
            
        var PlayerB = new CellState()
        {
            CellStateId = @"recw0SsqNfCk96xZs",
            createdTime = DateTime.Parse("2020-11-26T20:04:48Z"),
            Name = @"PlayerB",
            Code = @"O",
            Description = @"This cell has been marked by thhe active player's opponent.",
            Color = @"black",
            FontColor = @"white",
            DefaultMark = @"B",
            Cursor = @"Default",
            SortOrder = 2,
            Id = 1,
            CurrentStateCells = new string[] { @"recfSe8zeEdCAtcGq", "rec3OzG8nTAkUhjVn" },
            
        };

        List.Add(PlayerB);
        ByEnum[CellStatesEnum.PlayerB] = PlayerB;
        
            
        var NoPlayer = new CellState()
        {
            CellStateId = @"recJAi8YoTOQmzhfH",
            createdTime = DateTime.Parse("2020-11-26T20:04:48Z"),
            Name = @"NoPlayer",
            Code = @"N",
            Description = @"The space has not yet been played in",
            Color = @"white",
            FontColor = @"darkgray",
            Cursor = @"Pointer",
            SortOrder = 3,
            Id = 2,
            CellPatternCells = new string[] { @"recWoh5Qk0b1xBV67", "rec5D3fwk2h5GzjIB", "rechiocdDSSkR1IFz", "reccnHG0Yfk8tgTt6", "recaPLycHtpRQfWnE", "recljMfqekOodaaWx" },
            CellPatterns = new string[] { @"rec55PqGhtUYK5Rcb", "recqn6vuQrx71nQii", "recZCV8dlP1pNK9kK", "recYmKv2dBpnAA1gs", "recobCShOEyZjP8bY", "recg1ttw7l3n96PDG" },
            CurrentStateCells = new string[] { @"recxIf3GoDzEtonFU", "recmjtZPRUfoCU2sr", "recTGnKjXTE8LfT3C", "recczW2Y4WMv9buZ8", "recpPYOZtnp3lTOua" },
            DefaultStateCells = new string[] { @"recxIf3GoDzEtonFU", "recfSe8zeEdCAtcGq", "recmjtZPRUfoCU2sr", "rec3OzG8nTAkUhjVn", "rec50MWM91QHzlEzO", "recpPYOZtnp3lTOua", "recTGnKjXTE8LfT3C", "rec35HZOaRy6ge0jk", "recczW2Y4WMv9buZ8" },
            
        };

        List.Add(NoPlayer);
        ByEnum[CellStatesEnum.NoPlayer] = NoPlayer;
        
    }

}