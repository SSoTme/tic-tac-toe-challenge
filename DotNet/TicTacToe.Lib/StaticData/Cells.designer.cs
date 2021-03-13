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
            CellPatternCells = new string[] { @"recU9O3yxyMeQ1eU4", "recYR4cE90EOVnYD5", "rec91aKNdkT2cw93v", "recclaJuN3LJWLC4N", "recKj18pU9k6V6MAx", "rec1hqH6Ty1vueu48", "recuKKiaqoaXhFxSC", "recLcTgsFF8EuGUz3", "recR4dC3tW41PPZ8x" },
            CurrentCellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            DefaultCellState = new string[] { @"recJAi8YoTOQmzhfH" },
            CellKey = 7,
            AlexesNumber = 10010010,
            IsClockwise = Boolean.Parse("true"),
            ClockwiseRotateFrom = @"BottomLeft",
            CounterClockwiseRotateFrom = @"TopRight",
            RotateFrom = @"BottomLeft",
            RotateDescription = @"From BottomLeft to TopLeft",
            ClockwiseRotateFromIndex = 6,
            CounterClockwiseRotateFromIndex = 2,
            RotateIndex = 6,
            DefaultState = @"NoPlayer",
            CurrentState = @"PlayerA",
            FlipIndex = 2,
            FlipFromName = @"TopRight",
            FlipDescription = @"From TopRight to TopLeft",
            SortOrder = 0,
            NamedSetPatterns = new string[] { @"recJ1wDRP5taMg2Tj", "reccf6U6b21xlIOh7", "recYQei900zbRIFTw" },
            IsInRow1 = 1,
            IsInRow2 = 0,
            IsInRow3 = 0,
            IsInColumn1 = 1,
            IsInColumn2 = 0,
            IsInColumn3 = 0,
            IsInLeftRightDiagonal = 1,
            IsInRightLeftDiagonal = 0
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
            CellPatternCells = new string[] { @"recf1uu1YY0iPps8E", "recFITGoLxBQs1ocD", "recljMfqekOodaaWx", "rec3K2fxtqlgu5oeA", "recJtIPt56a61dAFz" },
            TargetCellForCellPatterns = new string[] { @"recYmKv2dBpnAA1gs" },
            CurrentCellState = new string[] { @"recJAi8YoTOQmzhfH" },
            DefaultCellState = new string[] { @"recJAi8YoTOQmzhfH" },
            CellKey = 8,
            AlexesNumber = 10001000,
            IsClockwise = Boolean.Parse("true"),
            ClockwiseRotateFrom = @"MiddleLeft",
            CounterClockwiseRotateFrom = @"MiddleRight",
            RotateFrom = @"MiddleLeft",
            RotateDescription = @"From MiddleLeft to Top",
            ClockwiseRotateFromIndex = 3,
            CounterClockwiseRotateFromIndex = 5,
            RotateIndex = 3,
            DefaultState = @"NoPlayer",
            CurrentState = @"NoPlayer",
            FlipIndex = 1,
            FlipFromName = @"Top",
            FlipDescription = @"No Movement",
            SortOrder = 1,
            NamedSetPatterns = new string[] { @"recXBksm5DIUqOfDn", "recYQei900zbRIFTw" },
            IsInRow1 = 1,
            IsInRow2 = 0,
            IsInRow3 = 0,
            IsInColumn1 = 0,
            IsInColumn2 = 1,
            IsInColumn3 = 0,
            IsInLeftRightDiagonal = 0,
            IsInRightLeftDiagonal = 0
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
            CellPatternCells = new string[] { @"recPHA9ppFH8cjenC", "reccnHG0Yfk8tgTt6", "rec8bt4pVcy9OY8XO", "recO1aArEBMEvWxoD", "recrfBGkdzZ67jeLa", "recD2BUDpoknNF4Lh" },
            TargetCellForCellPatterns = new string[] { @"rec55PqGhtUYK5Rcb" },
            CurrentCellState = new string[] { @"recwMqGt97gQ22PsK" },
            DefaultCellState = new string[] { @"recJAi8YoTOQmzhfH" },
            CellKey = 9,
            AlexesNumber = 10000101,
            IsClockwise = Boolean.Parse("true"),
            ClockwiseRotateFrom = @"TopLeft",
            CounterClockwiseRotateFrom = @"BottomRight",
            RotateFrom = @"TopLeft",
            RotateDescription = @"From TopLeft to TopRight",
            ClockwiseRotateFromIndex = 0,
            CounterClockwiseRotateFromIndex = 8,
            RotateIndex = 0,
            DefaultState = @"NoPlayer",
            CurrentState = @"PlayerB",
            FlipIndex = 0,
            FlipFromName = @"TopLeft",
            FlipDescription = @"From TopLeft to TopRight",
            SortOrder = 2,
            NamedSetPatterns = new string[] { @"recNW9KXsm9KvWa7B", "recWQyBlj7xHrYNPx", "recYQei900zbRIFTw" },
            IsInRow1 = 1,
            IsInRow2 = 0,
            IsInRow3 = 0,
            IsInColumn1 = 0,
            IsInColumn2 = 0,
            IsInColumn3 = 1,
            IsInLeftRightDiagonal = 0,
            IsInRightLeftDiagonal = 1
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
            CellPatternCells = new string[] { @"reckcKNNnyDSWpFrH", "recxWA16nieZY83Sv", "recyZobcdc9yOkGuC", "recmEXEqSbCsI5kUB", "recpAYbzVjDRhc1L4" },
            CurrentCellState = new string[] { @"recJAi8YoTOQmzhfH" },
            DefaultCellState = new string[] { @"recJAi8YoTOQmzhfH" },
            CellKey = 4,
            AlexesNumber = 01010000,
            IsClockwise = Boolean.Parse("true"),
            ClockwiseRotateFrom = @"Bottom",
            CounterClockwiseRotateFrom = @"Top",
            RotateFrom = @"Bottom",
            RotateDescription = @"From Bottom to MiddleLeft",
            ClockwiseRotateFromIndex = 7,
            CounterClockwiseRotateFromIndex = 1,
            RotateIndex = 7,
            DefaultState = @"NoPlayer",
            CurrentState = @"NoPlayer",
            FlipIndex = 5,
            FlipFromName = @"MiddleRight",
            FlipDescription = @"From MiddleRight to MiddleLeft",
            SortOrder = 3,
            NamedSetPatterns = new string[] { @"recJ1wDRP5taMg2Tj", "recqpmR7MAtp5afiM" },
            IsInRow1 = 0,
            IsInRow2 = 1,
            IsInRow3 = 0,
            IsInColumn1 = 1,
            IsInColumn2 = 0,
            IsInColumn3 = 0,
            IsInLeftRightDiagonal = 0,
            IsInRightLeftDiagonal = 0
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
            CellPatternCells = new string[] { @"recGP80BxFCLlmgw7", "recWoh5Qk0b1xBV67", "recwQ3ZI5MBVHPKgl", "recPmKMMNhYSxBWJ0", "recaPLycHtpRQfWnE", "recy5CwlzxHvsubBr", "recAJ25e2uael63Kw", "rec1Gsh1wvAQ3BO0w", "recUNdmTwmeITNGEZ", "recq7x7WkznTcTKS7" },
            TargetCellForCellPatterns = new string[] { @"recobCShOEyZjP8bY", "recg1ttw7l3n96PDG" },
            CurrentCellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            DefaultCellState = new string[] { @"recJAi8YoTOQmzhfH" },
            CellKey = 5,
            AlexesNumber = 01001011,
            IsClockwise = Boolean.Parse("true"),
            ClockwiseRotateFrom = @"Middle",
            CounterClockwiseRotateFrom = @"Middle",
            RotateFrom = @"Middle",
            RotateDescription = @"From Middle to Middle",
            ClockwiseRotateFromIndex = 4,
            CounterClockwiseRotateFromIndex = 4,
            RotateIndex = 4,
            DefaultState = @"NoPlayer",
            CurrentState = @"PlayerA",
            FlipIndex = 4,
            FlipFromName = @"Middle",
            FlipDescription = @"No Movement",
            SortOrder = 4,
            NamedSetPatterns = new string[] { @"recXBksm5DIUqOfDn", "reccf6U6b21xlIOh7", "recWQyBlj7xHrYNPx", "recqpmR7MAtp5afiM" },
            IsInRow1 = 0,
            IsInRow2 = 1,
            IsInRow3 = 0,
            IsInColumn1 = 0,
            IsInColumn2 = 1,
            IsInColumn3 = 0,
            IsInLeftRightDiagonal = 1,
            IsInRightLeftDiagonal = 1
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
            CellPatternCells = new string[] { @"recAy4XNSSKRZGZsh", "rechiocdDSSkR1IFz", "rec6RGGCG5ORVBnA3", "recvjeyFh2sWFF8us", "recBi8mtXhiWj7TJH" },
            TargetCellForCellPatterns = new string[] { @"recqn6vuQrx71nQii" },
            CurrentCellState = new string[] { @"recJAi8YoTOQmzhfH" },
            DefaultCellState = new string[] { @"recJAi8YoTOQmzhfH" },
            CellKey = 6,
            IsDailyDouble = Boolean.Parse("true"),
            AlexesNumber = 01000100,
            IsClockwise = Boolean.Parse("true"),
            ClockwiseRotateFrom = @"Top",
            CounterClockwiseRotateFrom = @"Bottom",
            RotateFrom = @"Top",
            RotateDescription = @"From Top to MiddleRight",
            ClockwiseRotateFromIndex = 1,
            CounterClockwiseRotateFromIndex = 7,
            RotateIndex = 1,
            DefaultState = @"NoPlayer",
            CurrentState = @"NoPlayer",
            FlipIndex = 3,
            FlipFromName = @"MiddleLeft",
            FlipDescription = @"From MiddleLeft to MiddleRight",
            SortOrder = 5,
            NamedSetPatterns = new string[] { @"recNW9KXsm9KvWa7B", "recqpmR7MAtp5afiM" },
            IsInRow1 = 0,
            IsInRow2 = 1,
            IsInRow3 = 0,
            IsInColumn1 = 0,
            IsInColumn2 = 0,
            IsInColumn3 = 1,
            IsInLeftRightDiagonal = 0,
            IsInRightLeftDiagonal = 0
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
            CellPatternCells = new string[] { @"recShopv0fRnIWAbr", "recTk43h9Sd9Qw1aQ", "rec7NXPxQPU4PzKX0" },
            CurrentCellState = new string[] { @"recJAi8YoTOQmzhfH" },
            DefaultCellState = new string[] { @"recJAi8YoTOQmzhfH" },
            CellKey = 1,
            AlexesNumber = 00110001,
            IsClockwise = Boolean.Parse("true"),
            ClockwiseRotateFrom = @"BottomRight",
            CounterClockwiseRotateFrom = @"TopLeft",
            RotateFrom = @"BottomRight",
            RotateDescription = @"From BottomRight to BottomLeft",
            ClockwiseRotateFromIndex = 8,
            CounterClockwiseRotateFromIndex = 0,
            RotateIndex = 8,
            DefaultState = @"NoPlayer",
            CurrentState = @"NoPlayer",
            FlipIndex = 8,
            FlipFromName = @"BottomRight",
            FlipDescription = @"From BottomRight to BottomLeft",
            SortOrder = 6,
            NamedSetPatterns = new string[] { @"recJ1wDRP5taMg2Tj", "recWQyBlj7xHrYNPx", "recHqX6LLAZZAo1RQ" },
            IsInRow1 = 0,
            IsInRow2 = 0,
            IsInRow3 = 1,
            IsInColumn1 = 1,
            IsInColumn2 = 0,
            IsInColumn3 = 0,
            IsInLeftRightDiagonal = 0,
            IsInRightLeftDiagonal = 1
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
            CellPatternCells = new string[] { @"recVxUYMsnvGIqGZ2", "recmHFemnt2tO9Q5u" },
            CurrentCellState = new string[] { @"recwMqGt97gQ22PsK" },
            DefaultCellState = new string[] { @"recJAi8YoTOQmzhfH" },
            CellKey = 2,
            AlexesNumber = 00101000,
            IsClockwise = Boolean.Parse("true"),
            ClockwiseRotateFrom = @"MiddleRight",
            CounterClockwiseRotateFrom = @"MiddleLeft",
            RotateFrom = @"MiddleRight",
            RotateDescription = @"From MiddleRight to Bottom",
            ClockwiseRotateFromIndex = 5,
            CounterClockwiseRotateFromIndex = 3,
            RotateIndex = 5,
            DefaultState = @"NoPlayer",
            CurrentState = @"PlayerB",
            FlipIndex = 7,
            FlipFromName = @"Bottom",
            FlipDescription = @"No Movement",
            SortOrder = 7,
            NamedSetPatterns = new string[] { @"recXBksm5DIUqOfDn", "recHqX6LLAZZAo1RQ" },
            IsInRow1 = 0,
            IsInRow2 = 0,
            IsInRow3 = 1,
            IsInColumn1 = 0,
            IsInColumn2 = 1,
            IsInColumn3 = 0,
            IsInLeftRightDiagonal = 0,
            IsInRightLeftDiagonal = 0
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
            CellPatternCells = new string[] { @"reclDV8jky7y1JNzH", "rec5D3fwk2h5GzjIB", "reczQDKs6sXAjFvhP", "recfjQk3Amk3Ofo0S", "recc99ZERSFi8OZgJ", "recTcBwvPbWD9wMyy" },
            TargetCellForCellPatterns = new string[] { @"recZCV8dlP1pNK9kK" },
            CurrentCellState = new string[] { @"recJAi8YoTOQmzhfH" },
            DefaultCellState = new string[] { @"recJAi8YoTOQmzhfH" },
            CellKey = 3,
            AlexesNumber = 00100110,
            IsClockwise = Boolean.Parse("true"),
            ClockwiseRotateFrom = @"TopRight",
            CounterClockwiseRotateFrom = @"BottomLeft",
            RotateFrom = @"TopRight",
            RotateDescription = @"From TopRight to BottomRight",
            ClockwiseRotateFromIndex = 2,
            CounterClockwiseRotateFromIndex = 6,
            RotateIndex = 2,
            DefaultState = @"NoPlayer",
            CurrentState = @"NoPlayer",
            FlipIndex = 6,
            FlipFromName = @"BottomLeft",
            FlipDescription = @"From BottomLeft to BottomRight",
            SortOrder = 8,
            NamedSetPatterns = new string[] { @"recNW9KXsm9KvWa7B", "reccf6U6b21xlIOh7", "recHqX6LLAZZAo1RQ" },
            IsInRow1 = 0,
            IsInRow2 = 0,
            IsInRow3 = 1,
            IsInColumn1 = 0,
            IsInColumn2 = 0,
            IsInColumn3 = 1,
            IsInLeftRightDiagonal = 1,
            IsInRightLeftDiagonal = 0
        };

        List.Add(BottomRight);
        ByEnum[CellsEnum.BottomRight] = BottomRight;
        
    }

}