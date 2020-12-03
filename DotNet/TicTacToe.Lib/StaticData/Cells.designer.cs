using System;
using System.Linq;
using TicTacToeChallenge.Lib.DataClasses;

public static partial class Cells
{
    private static void InitCells()
    {
        // setup each one...
        
            
        var TopLeft = new Cell()
        {
            CellId = @"rec50MWM91QHzlEzO",
            createdTime = DateTime.Parse("2020-11-26T20:06:06Z"),
            Name = @"TopLeft",
            Clockwise = new string[] { @"recmjtZPRUfoCU2sr" },
            CounterClockwise = new string[] { @"recTGnKjXTE8LfT3C" },
            Flip = new string[] { @"recTGnKjXTE8LfT3C" },
            SampleValue = @"A",
            Description = @"Cell 0,0",
            X = 0,
            Y = 0,
            RotateTranslation = new string[] { @"recgdoYW4iJ8gaAha" },
            CellIndex = 0,
            CellPatternCells = new string[] { @"recU9O3yxyMeQ1eU4", "recYR4cE90EOVnYD5", "rec91aKNdkT2cw93v", "recclaJuN3LJWLC4N", "recKj18pU9k6V6MAx" },
            CurrentCellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            DefaultCellState = new string[] { @"recJAi8YoTOQmzhfH" },
            CellKey = 7,
            RotateDescription = @"From BottomLeft to TopLeft",
            RotateIndex = 6,
            DefaultState = @"NoPlayer",
            CurrentState = @"PlayerA",
            RotateFrom = @"BottomLeft",
            IsClockwise = Boolean.Parse("true"),
            ClockwiseRotateFrom = @"BottomLeft",
            CounterClockwiseRotateFrom = @"TopRight",
            FlipFromName = @"TopRight",
            FlipIndex = 2,
            ClockwiseRotateFromIndex = 6,
            CounterClockwiseRotateFromIndex = 2,
            FlipDescription = @"From TopRight to TopLeft",
            SortOrder = 0
        };

        List.Add(TopLeft);
        ByEnum[CellsEnum.TopLeft] = TopLeft;
        
            
        var Top = new Cell()
        {
            CellId = @"recpPYOZtnp3lTOua",
            createdTime = DateTime.Parse("2020-11-26T20:06:06Z"),
            Name = @"Top",
            Clockwise = new string[] { @"recxIf3GoDzEtonFU" },
            CounterClockwise = new string[] { @"recfSe8zeEdCAtcGq" },
            Flip = new string[] { @"recpPYOZtnp3lTOua" },
            SampleValue = @"B",
            Description = @"Cell 0,1",
            X = 0,
            Y = 1,
            RotateTranslation = new string[] { @"recgdoYW4iJ8gaAha" },
            CellIndex = 1,
            CellPatternCells = new string[] { @"recf1uu1YY0iPps8E", "recFITGoLxBQs1ocD", "recljMfqekOodaaWx" },
            CellPatterns = new string[] { @"recYmKv2dBpnAA1gs" },
            CurrentCellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            DefaultCellState = new string[] { @"recJAi8YoTOQmzhfH" },
            CellKey = 8,
            RotateDescription = @"From MiddleLeft to Top",
            RotateIndex = 3,
            DefaultState = @"NoPlayer",
            CurrentState = @"PlayerA",
            RotateFrom = @"MiddleLeft",
            IsClockwise = Boolean.Parse("true"),
            ClockwiseRotateFrom = @"MiddleLeft",
            CounterClockwiseRotateFrom = @"MiddleRight",
            FlipFromName = @"Top",
            FlipIndex = 1,
            ClockwiseRotateFromIndex = 3,
            CounterClockwiseRotateFromIndex = 5,
            FlipDescription = @"No Movement",
            SortOrder = 1
        };

        List.Add(Top);
        ByEnum[CellsEnum.Top] = Top;
        
            
        var TopRight = new Cell()
        {
            CellId = @"recTGnKjXTE8LfT3C",
            createdTime = DateTime.Parse("2020-11-26T20:06:06Z"),
            Name = @"TopRight",
            Clockwise = new string[] { @"rec50MWM91QHzlEzO" },
            CounterClockwise = new string[] { @"recczW2Y4WMv9buZ8" },
            Flip = new string[] { @"rec50MWM91QHzlEzO" },
            SampleValue = @"C",
            Description = @"Cell 0,2",
            X = 0,
            Y = 2,
            RotateTranslation = new string[] { @"recgdoYW4iJ8gaAha" },
            CellIndex = 2,
            CellPatternCells = new string[] { @"recPHA9ppFH8cjenC", "reccnHG0Yfk8tgTt6", "rec8bt4pVcy9OY8XO" },
            CellPatterns = new string[] { @"rec55PqGhtUYK5Rcb" },
            CurrentCellState = new string[] { @"recJAi8YoTOQmzhfH" },
            DefaultCellState = new string[] { @"recJAi8YoTOQmzhfH" },
            CellKey = 9,
            RotateDescription = @"From TopLeft to TopRight",
            RotateIndex = 0,
            DefaultState = @"NoPlayer",
            CurrentState = @"NoPlayer",
            RotateFrom = @"TopLeft",
            IsClockwise = Boolean.Parse("true"),
            ClockwiseRotateFrom = @"TopLeft",
            CounterClockwiseRotateFrom = @"BottomRight",
            FlipFromName = @"TopLeft",
            FlipIndex = 0,
            ClockwiseRotateFromIndex = 0,
            CounterClockwiseRotateFromIndex = 8,
            FlipDescription = @"From TopLeft to TopRight",
            SortOrder = 2
        };

        List.Add(TopRight);
        ByEnum[CellsEnum.TopRight] = TopRight;
        
            
        var MiddleLeft = new Cell()
        {
            CellId = @"recxIf3GoDzEtonFU",
            createdTime = DateTime.Parse("2020-11-26T20:06:06Z"),
            Name = @"MiddleLeft",
            Clockwise = new string[] { @"rec3OzG8nTAkUhjVn" },
            CounterClockwise = new string[] { @"recpPYOZtnp3lTOua" },
            Flip = new string[] { @"recfSe8zeEdCAtcGq" },
            SampleValue = @"d",
            Description = @"Cell 1,0",
            X = 1,
            Y = 0,
            RotateTranslation = new string[] { @"recgdoYW4iJ8gaAha" },
            CellIndex = 3,
            CellPatternCells = new string[] { @"reckcKNNnyDSWpFrH", "recxWA16nieZY83Sv", "recyZobcdc9yOkGuC" },
            CurrentCellState = new string[] { @"recJAi8YoTOQmzhfH" },
            DefaultCellState = new string[] { @"recJAi8YoTOQmzhfH" },
            CellKey = 4,
            RotateDescription = @"From Bottom to MiddleLeft",
            RotateIndex = 7,
            DefaultState = @"NoPlayer",
            CurrentState = @"NoPlayer",
            RotateFrom = @"Bottom",
            IsClockwise = Boolean.Parse("true"),
            ClockwiseRotateFrom = @"Bottom",
            CounterClockwiseRotateFrom = @"Top",
            FlipFromName = @"MiddleRight",
            FlipIndex = 5,
            ClockwiseRotateFromIndex = 7,
            CounterClockwiseRotateFromIndex = 1,
            FlipDescription = @"From MiddleRight to MiddleLeft",
            SortOrder = 3
        };

        List.Add(MiddleLeft);
        ByEnum[CellsEnum.MiddleLeft] = MiddleLeft;
        
            
        var Middle = new Cell()
        {
            CellId = @"rec35HZOaRy6ge0jk",
            createdTime = DateTime.Parse("2020-11-26T20:06:06Z"),
            Name = @"Middle",
            Clockwise = new string[] { @"rec35HZOaRy6ge0jk" },
            CounterClockwise = new string[] { @"rec35HZOaRy6ge0jk" },
            Flip = new string[] { @"rec35HZOaRy6ge0jk" },
            SampleValue = @"e",
            Description = @"Cell 1,1",
            X = 1,
            Y = 1,
            RotateTranslation = new string[] { @"recgdoYW4iJ8gaAha" },
            CellIndex = 4,
            CellPatternCells = new string[] { @"recGP80BxFCLlmgw7", "recWoh5Qk0b1xBV67", "recwQ3ZI5MBVHPKgl", "recPmKMMNhYSxBWJ0", "recaPLycHtpRQfWnE" },
            CellPatterns = new string[] { @"recobCShOEyZjP8bY", "recg1ttw7l3n96PDG" },
            CurrentCellState = new string[] { @"recw0SsqNfCk96xZs" },
            DefaultCellState = new string[] { @"recJAi8YoTOQmzhfH" },
            CellKey = 5,
            RotateDescription = @"From Middle to Middle",
            RotateIndex = 4,
            DefaultState = @"NoPlayer",
            CurrentState = @"PlayerB",
            RotateFrom = @"Middle",
            IsClockwise = Boolean.Parse("true"),
            ClockwiseRotateFrom = @"Middle",
            CounterClockwiseRotateFrom = @"Middle",
            FlipFromName = @"Middle",
            FlipIndex = 4,
            ClockwiseRotateFromIndex = 4,
            CounterClockwiseRotateFromIndex = 4,
            FlipDescription = @"No Movement",
            SortOrder = 4
        };

        List.Add(Middle);
        ByEnum[CellsEnum.Middle] = Middle;
        
            
        var MiddleRight = new Cell()
        {
            CellId = @"recfSe8zeEdCAtcGq",
            createdTime = DateTime.Parse("2020-11-26T20:06:06Z"),
            Name = @"MiddleRight",
            Clockwise = new string[] { @"recpPYOZtnp3lTOua" },
            CounterClockwise = new string[] { @"rec3OzG8nTAkUhjVn" },
            Flip = new string[] { @"recxIf3GoDzEtonFU" },
            SampleValue = @"f",
            Description = @"Cell 1,2",
            X = 1,
            Y = 2,
            RotateTranslation = new string[] { @"recgdoYW4iJ8gaAha" },
            CellIndex = 5,
            CellPatternCells = new string[] { @"recAy4XNSSKRZGZsh", "rechiocdDSSkR1IFz", "rec6RGGCG5ORVBnA3" },
            CellPatterns = new string[] { @"recqn6vuQrx71nQii" },
            CurrentCellState = new string[] { @"recw0SsqNfCk96xZs" },
            DefaultCellState = new string[] { @"recJAi8YoTOQmzhfH" },
            CellKey = 6,
            RotateDescription = @"From Top to MiddleRight",
            RotateIndex = 1,
            DefaultState = @"NoPlayer",
            CurrentState = @"PlayerB",
            RotateFrom = @"Top",
            IsClockwise = Boolean.Parse("true"),
            ClockwiseRotateFrom = @"Top",
            CounterClockwiseRotateFrom = @"Bottom",
            FlipFromName = @"MiddleLeft",
            FlipIndex = 3,
            ClockwiseRotateFromIndex = 1,
            CounterClockwiseRotateFromIndex = 7,
            FlipDescription = @"From MiddleLeft to MiddleRight",
            SortOrder = 5
        };

        List.Add(MiddleRight);
        ByEnum[CellsEnum.MiddleRight] = MiddleRight;
        
            
        var BottomLeft = new Cell()
        {
            CellId = @"recmjtZPRUfoCU2sr",
            createdTime = DateTime.Parse("2020-11-26T20:06:06Z"),
            Name = @"BottomLeft",
            Clockwise = new string[] { @"recczW2Y4WMv9buZ8" },
            CounterClockwise = new string[] { @"rec50MWM91QHzlEzO" },
            Flip = new string[] { @"recczW2Y4WMv9buZ8" },
            SampleValue = @"g",
            Description = @"Cell 2,0",
            X = 2,
            Y = 0,
            RotateTranslation = new string[] { @"recgdoYW4iJ8gaAha" },
            CellIndex = 6,
            CurrentCellState = new string[] { @"recJAi8YoTOQmzhfH" },
            DefaultCellState = new string[] { @"recJAi8YoTOQmzhfH" },
            CellKey = 1,
            RotateDescription = @"From BottomRight to BottomLeft",
            RotateIndex = 8,
            DefaultState = @"NoPlayer",
            CurrentState = @"NoPlayer",
            RotateFrom = @"BottomRight",
            IsClockwise = Boolean.Parse("true"),
            ClockwiseRotateFrom = @"BottomRight",
            CounterClockwiseRotateFrom = @"TopLeft",
            FlipFromName = @"BottomRight",
            FlipIndex = 8,
            ClockwiseRotateFromIndex = 8,
            CounterClockwiseRotateFromIndex = 0,
            FlipDescription = @"From BottomRight to BottomLeft",
            SortOrder = 6
        };

        List.Add(BottomLeft);
        ByEnum[CellsEnum.BottomLeft] = BottomLeft;
        
            
        var Bottom = new Cell()
        {
            CellId = @"rec3OzG8nTAkUhjVn",
            createdTime = DateTime.Parse("2020-11-26T20:06:06Z"),
            Name = @"Bottom",
            Clockwise = new string[] { @"recfSe8zeEdCAtcGq" },
            CounterClockwise = new string[] { @"recxIf3GoDzEtonFU" },
            Flip = new string[] { @"rec3OzG8nTAkUhjVn" },
            SampleValue = @"h",
            Description = @"Cell 2,1",
            X = 2,
            Y = 1,
            RotateTranslation = new string[] { @"recgdoYW4iJ8gaAha" },
            CellIndex = 7,
            CurrentCellState = new string[] { @"recJAi8YoTOQmzhfH" },
            DefaultCellState = new string[] { @"recJAi8YoTOQmzhfH" },
            CellKey = 2,
            RotateDescription = @"From MiddleRight to Bottom",
            RotateIndex = 5,
            DefaultState = @"NoPlayer",
            CurrentState = @"NoPlayer",
            RotateFrom = @"MiddleRight",
            IsClockwise = Boolean.Parse("true"),
            ClockwiseRotateFrom = @"MiddleRight",
            CounterClockwiseRotateFrom = @"MiddleLeft",
            FlipFromName = @"Bottom",
            FlipIndex = 7,
            ClockwiseRotateFromIndex = 5,
            CounterClockwiseRotateFromIndex = 3,
            FlipDescription = @"No Movement",
            SortOrder = 7
        };

        List.Add(Bottom);
        ByEnum[CellsEnum.Bottom] = Bottom;
        
            
        var BottomRight = new Cell()
        {
            CellId = @"recczW2Y4WMv9buZ8",
            createdTime = DateTime.Parse("2020-11-26T20:06:06Z"),
            Name = @"BottomRight",
            Clockwise = new string[] { @"recTGnKjXTE8LfT3C" },
            CounterClockwise = new string[] { @"recmjtZPRUfoCU2sr" },
            Flip = new string[] { @"recmjtZPRUfoCU2sr" },
            SampleValue = @"i",
            Description = @"Cell 2,2",
            X = 2,
            Y = 2,
            RotateTranslation = new string[] { @"recgdoYW4iJ8gaAha" },
            CellIndex = 8,
            CellPatternCells = new string[] { @"reclDV8jky7y1JNzH", "rec5D3fwk2h5GzjIB" },
            CellPatterns = new string[] { @"recZCV8dlP1pNK9kK" },
            CurrentCellState = new string[] { @"recJAi8YoTOQmzhfH" },
            DefaultCellState = new string[] { @"recJAi8YoTOQmzhfH" },
            CellKey = 3,
            RotateDescription = @"From TopRight to BottomRight",
            RotateIndex = 2,
            DefaultState = @"NoPlayer",
            CurrentState = @"NoPlayer",
            RotateFrom = @"TopRight",
            IsClockwise = Boolean.Parse("true"),
            ClockwiseRotateFrom = @"TopRight",
            CounterClockwiseRotateFrom = @"BottomLeft",
            FlipFromName = @"BottomLeft",
            FlipIndex = 6,
            ClockwiseRotateFromIndex = 2,
            CounterClockwiseRotateFromIndex = 6,
            FlipDescription = @"From BottomLeft to BottomRight",
            SortOrder = 8
        };

        List.Add(BottomRight);
        ByEnum[CellsEnum.BottomRight] = BottomRight;
        
    }

}