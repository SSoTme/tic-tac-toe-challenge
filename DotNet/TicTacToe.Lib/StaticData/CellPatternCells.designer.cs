using System;
using System.Linq;
using TicTacToeChallenge.Lib.DataClasses;

public static partial class CellPatternCells
{
    private static void InitCellPatternCells()
    {
        // setup each one...
        
            
        var TwoInARowDiagonalNoPlayerBottomRight = new CellPatternCell()
        {
            CellPatternCellId = @"rec5D3fwk2h5GzjIB",
            createdTime = DateTime.Parse("2020-11-26T20:43:48Z"),
            Cell = new string[] { @"recczW2Y4WMv9buZ8" },
            CellPattern = new string[] { @"recZCV8dlP1pNK9kK" },
            CellState = new string[] { @"recJAi8YoTOQmzhfH" },
            Name = @"TwoInARowDiagonal:NoPlayer:BottomRight",
            CellIndex = 8,
            CellStateId = 2,
            CellCellState = 82,
            CellName = @"BottomRight",
            CellStateName = @"NoPlayer"
        };

        List.Add(TwoInARowDiagonalNoPlayerBottomRight);
        ByEnum[CellPatternCellsEnum.TwoInARowDiagonalNoPlayerBottomRight] = TwoInARowDiagonalNoPlayerBottomRight;
        
            
        var TwoOutsideMiddlePlayerMiddleRight = new CellPatternCell()
        {
            CellPatternCellId = @"rec6RGGCG5ORVBnA3",
            createdTime = DateTime.Parse("2020-11-26T20:44:11Z"),
            Cell = new string[] { @"recfSe8zeEdCAtcGq" },
            CellPattern = new string[] { @"recobCShOEyZjP8bY" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"TwoOutsideMiddle:Player:MiddleRight",
            CellIndex = 5,
            CellStateId = 0,
            CellCellState = 50,
            CellName = @"MiddleRight",
            CellStateName = @"Player"
        };

        List.Add(TwoOutsideMiddlePlayerMiddleRight);
        ByEnum[CellPatternCellsEnum.TwoOutsideMiddlePlayerMiddleRight] = TwoOutsideMiddlePlayerMiddleRight;
        
            
        var TwoOutsideTopPlayerTopRight = new CellPatternCell()
        {
            CellPatternCellId = @"rec8bt4pVcy9OY8XO",
            createdTime = DateTime.Parse("2020-11-26T20:44:14Z"),
            Cell = new string[] { @"recTGnKjXTE8LfT3C" },
            CellPattern = new string[] { @"recYmKv2dBpnAA1gs" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"TwoOutsideTop:Player:TopRight",
            CellIndex = 2,
            CellStateId = 0,
            CellCellState = 20,
            CellName = @"TopRight",
            CellStateName = @"Player"
        };

        List.Add(TwoOutsideTopPlayerTopRight);
        ByEnum[CellPatternCellsEnum.TwoOutsideTopPlayerTopRight] = TwoOutsideTopPlayerTopRight;
        
            
        var TwoInARowDiagonalPlayerTopLeft = new CellPatternCell()
        {
            CellPatternCellId = @"rec91aKNdkT2cw93v",
            createdTime = DateTime.Parse("2020-11-26T20:37:58Z"),
            Cell = new string[] { @"rec50MWM91QHzlEzO" },
            CellPattern = new string[] { @"recZCV8dlP1pNK9kK" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"TwoInARowDiagonal:Player:TopLeft",
            CellIndex = 0,
            CellStateId = 0,
            CellCellState = 00,
            CellName = @"TopLeft",
            CellStateName = @"Player"
        };

        List.Add(TwoInARowDiagonalPlayerTopLeft);
        ByEnum[CellPatternCellsEnum.TwoInARowDiagonalPlayerTopLeft] = TwoInARowDiagonalPlayerTopLeft;
        
            
        var MiddleWinPlayerMiddleRight = new CellPatternCell()
        {
            CellPatternCellId = @"recAy4XNSSKRZGZsh",
            createdTime = DateTime.Parse("2020-11-26T20:42:02Z"),
            Cell = new string[] { @"recfSe8zeEdCAtcGq" },
            CellPattern = new string[] { @"recodVK2HKbzC26Db" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"MiddleWin:Player:MiddleRight",
            CellIndex = 5,
            CellStateId = 0,
            CellCellState = 50,
            CellName = @"MiddleRight",
            CellStateName = @"Player"
        };

        List.Add(MiddleWinPlayerMiddleRight);
        ByEnum[CellPatternCellsEnum.MiddleWinPlayerMiddleRight] = MiddleWinPlayerMiddleRight;
        
            
        var DiagonalWinPlayerMiddle = new CellPatternCell()
        {
            CellPatternCellId = @"recEX4e2JD90yYDDr",
            createdTime = DateTime.Parse("2020-12-11T20:02:08Z"),
            CellPattern = new string[] { @"recg6YsAgLEBikQ3F" },
            Name = @"DiagonalWin:Player:Middle",
            CellCellState = 40,
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            CellStateId = 0,
            CellStateName = @"Player",
            Cell = new string[] { @"rec35HZOaRy6ge0jk" },
            CellIndex = 4,
            CellName = @"Middle"
        };

        List.Add(DiagonalWinPlayerMiddle);
        ByEnum[CellPatternCellsEnum.DiagonalWinPlayerMiddle] = DiagonalWinPlayerMiddle;
        
            
        var TwoInARowTopPlayerTop = new CellPatternCell()
        {
            CellPatternCellId = @"recFITGoLxBQs1ocD",
            createdTime = DateTime.Parse("2020-11-26T20:44:06Z"),
            Cell = new string[] { @"recpPYOZtnp3lTOua" },
            CellPattern = new string[] { @"rec55PqGhtUYK5Rcb" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"TwoInARowTop:Player:Top",
            CellIndex = 1,
            CellStateId = 0,
            CellCellState = 10,
            CellName = @"Top",
            CellStateName = @"Player"
        };

        List.Add(TwoInARowTopPlayerTop);
        ByEnum[CellPatternCellsEnum.TwoInARowTopPlayerTop] = TwoInARowTopPlayerTop;
        
            
        var MiddleWinPlayerMiddle = new CellPatternCell()
        {
            CellPatternCellId = @"recGP80BxFCLlmgw7",
            createdTime = DateTime.Parse("2020-11-26T20:41:59Z"),
            Cell = new string[] { @"rec35HZOaRy6ge0jk" },
            CellPattern = new string[] { @"recodVK2HKbzC26Db" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"MiddleWin:Player:Middle",
            CellIndex = 4,
            CellStateId = 0,
            CellCellState = 40,
            CellName = @"Middle",
            CellStateName = @"Player"
        };

        List.Add(MiddleWinPlayerMiddle);
        ByEnum[CellPatternCellsEnum.MiddleWinPlayerMiddle] = MiddleWinPlayerMiddle;
        
            
        var DiagonalWinPlayerBottomRight = new CellPatternCell()
        {
            CellPatternCellId = @"recJzgHATmFMUyW7E",
            createdTime = DateTime.Parse("2020-12-11T20:02:08Z"),
            CellPattern = new string[] { @"recg6YsAgLEBikQ3F" },
            Name = @"DiagonalWin:Player:BottomRight",
            CellCellState = 80,
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            CellStateId = 0,
            CellStateName = @"Player",
            Cell = new string[] { @"recczW2Y4WMv9buZ8" },
            CellIndex = 8,
            CellName = @"BottomRight"
        };

        List.Add(DiagonalWinPlayerBottomRight);
        ByEnum[CellPatternCellsEnum.DiagonalWinPlayerBottomRight] = DiagonalWinPlayerBottomRight;
        
            
        var TwoOutsideTopPlayerTopLeft = new CellPatternCell()
        {
            CellPatternCellId = @"recKj18pU9k6V6MAx",
            createdTime = DateTime.Parse("2020-11-26T20:37:58Z"),
            Cell = new string[] { @"rec50MWM91QHzlEzO" },
            CellPattern = new string[] { @"recYmKv2dBpnAA1gs" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"TwoOutsideTop:Player:TopLeft",
            CellIndex = 0,
            CellStateId = 0,
            CellCellState = 00,
            CellName = @"TopLeft",
            CellStateName = @"Player"
        };

        List.Add(TwoOutsideTopPlayerTopLeft);
        ByEnum[CellPatternCellsEnum.TwoOutsideTopPlayerTopLeft] = TwoOutsideTopPlayerTopLeft;
        
            
        var EdgeWinPlayerTopRight = new CellPatternCell()
        {
            CellPatternCellId = @"recPHA9ppFH8cjenC",
            createdTime = DateTime.Parse("2020-11-26T20:38:15Z"),
            Cell = new string[] { @"recTGnKjXTE8LfT3C" },
            CellPattern = new string[] { @"recBDK2nzNlGSJNgJ" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"EdgeWin:Player:TopRight",
            CellIndex = 2,
            CellStateId = 0,
            CellCellState = 20,
            CellName = @"TopRight",
            CellStateName = @"Player"
        };

        List.Add(EdgeWinPlayerTopRight);
        ByEnum[CellPatternCellsEnum.EdgeWinPlayerTopRight] = EdgeWinPlayerTopRight;
        
            
        var TwoInARowMiddlePlayerMiddle = new CellPatternCell()
        {
            CellPatternCellId = @"recPmKMMNhYSxBWJ0",
            createdTime = DateTime.Parse("2020-11-26T20:44:04Z"),
            Cell = new string[] { @"rec35HZOaRy6ge0jk" },
            CellPattern = new string[] { @"recqn6vuQrx71nQii" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"TwoInARowMiddle:Player:Middle",
            CellIndex = 4,
            CellStateId = 0,
            CellCellState = 40,
            CellName = @"Middle",
            CellStateName = @"Player"
        };

        List.Add(TwoInARowMiddlePlayerMiddle);
        ByEnum[CellPatternCellsEnum.TwoInARowMiddlePlayerMiddle] = TwoInARowMiddlePlayerMiddle;
        
            
        var EdgeWinPlayerTopLeft = new CellPatternCell()
        {
            CellPatternCellId = @"recU9O3yxyMeQ1eU4",
            createdTime = DateTime.Parse("2020-11-26T20:35:31Z"),
            Cell = new string[] { @"rec50MWM91QHzlEzO" },
            CellPattern = new string[] { @"recBDK2nzNlGSJNgJ" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"EdgeWin:Player:TopLeft",
            CellIndex = 0,
            CellStateId = 0,
            CellCellState = 00,
            CellName = @"TopLeft",
            CellStateName = @"Player"
        };

        List.Add(EdgeWinPlayerTopLeft);
        ByEnum[CellPatternCellsEnum.EdgeWinPlayerTopLeft] = EdgeWinPlayerTopLeft;
        
            
        var TwoOutsideDiagonalNoPlayerMiddle = new CellPatternCell()
        {
            CellPatternCellId = @"recWoh5Qk0b1xBV67",
            createdTime = DateTime.Parse("2020-11-26T20:42:17Z"),
            Cell = new string[] { @"rec35HZOaRy6ge0jk" },
            CellPattern = new string[] { @"recg1ttw7l3n96PDG" },
            CellState = new string[] { @"recJAi8YoTOQmzhfH" },
            Name = @"TwoOutsideDiagonal:NoPlayer:Middle",
            CellIndex = 4,
            CellStateId = 2,
            CellCellState = 42,
            CellName = @"Middle",
            CellStateName = @"NoPlayer"
        };

        List.Add(TwoOutsideDiagonalNoPlayerMiddle);
        ByEnum[CellPatternCellsEnum.TwoOutsideDiagonalNoPlayerMiddle] = TwoOutsideDiagonalNoPlayerMiddle;
        
            
        var TwoOutsideDiagonalPlayerTopLeft = new CellPatternCell()
        {
            CellPatternCellId = @"recYR4cE90EOVnYD5",
            createdTime = DateTime.Parse("2020-11-26T20:37:58Z"),
            Cell = new string[] { @"rec50MWM91QHzlEzO" },
            CellPattern = new string[] { @"recg1ttw7l3n96PDG" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"TwoOutsideDiagonal:Player:TopLeft",
            CellIndex = 0,
            CellStateId = 0,
            CellCellState = 00,
            CellName = @"TopLeft",
            CellStateName = @"Player"
        };

        List.Add(TwoOutsideDiagonalPlayerTopLeft);
        ByEnum[CellPatternCellsEnum.TwoOutsideDiagonalPlayerTopLeft] = TwoOutsideDiagonalPlayerTopLeft;
        
            
        var TwoOutsideMiddleNoPlayerMiddle = new CellPatternCell()
        {
            CellPatternCellId = @"recaPLycHtpRQfWnE",
            createdTime = DateTime.Parse("2020-11-26T20:44:11Z"),
            Cell = new string[] { @"rec35HZOaRy6ge0jk" },
            CellPattern = new string[] { @"recobCShOEyZjP8bY" },
            CellState = new string[] { @"recJAi8YoTOQmzhfH" },
            Name = @"TwoOutsideMiddle:NoPlayer:Middle",
            CellIndex = 4,
            CellStateId = 2,
            CellCellState = 42,
            CellName = @"Middle",
            CellStateName = @"NoPlayer"
        };

        List.Add(TwoOutsideMiddleNoPlayerMiddle);
        ByEnum[CellPatternCellsEnum.TwoOutsideMiddleNoPlayerMiddle] = TwoOutsideMiddleNoPlayerMiddle;
        
            
        var TwoInARowTopPlayerTopLeft = new CellPatternCell()
        {
            CellPatternCellId = @"recclaJuN3LJWLC4N",
            createdTime = DateTime.Parse("2020-11-26T20:35:31Z"),
            Cell = new string[] { @"rec50MWM91QHzlEzO" },
            CellPattern = new string[] { @"rec55PqGhtUYK5Rcb" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"TwoInARowTop:Player:TopLeft",
            CellIndex = 0,
            CellStateId = 0,
            CellCellState = 00,
            CellName = @"TopLeft",
            CellStateName = @"Player"
        };

        List.Add(TwoInARowTopPlayerTopLeft);
        ByEnum[CellPatternCellsEnum.TwoInARowTopPlayerTopLeft] = TwoInARowTopPlayerTopLeft;
        
            
        var TwoInARowTopNoPlayerTopRight = new CellPatternCell()
        {
            CellPatternCellId = @"reccnHG0Yfk8tgTt6",
            createdTime = DateTime.Parse("2020-11-26T20:44:07Z"),
            Cell = new string[] { @"recTGnKjXTE8LfT3C" },
            CellPattern = new string[] { @"rec55PqGhtUYK5Rcb" },
            CellState = new string[] { @"recJAi8YoTOQmzhfH" },
            Name = @"TwoInARowTop:NoPlayer:TopRight",
            CellIndex = 2,
            CellStateId = 2,
            CellCellState = 22,
            CellName = @"TopRight",
            CellStateName = @"NoPlayer"
        };

        List.Add(TwoInARowTopNoPlayerTopRight);
        ByEnum[CellPatternCellsEnum.TwoInARowTopNoPlayerTopRight] = TwoInARowTopNoPlayerTopRight;
        
            
        var EdgeWinPlayerTop = new CellPatternCell()
        {
            CellPatternCellId = @"recf1uu1YY0iPps8E",
            createdTime = DateTime.Parse("2020-11-26T20:38:12Z"),
            Cell = new string[] { @"recpPYOZtnp3lTOua" },
            CellPattern = new string[] { @"recBDK2nzNlGSJNgJ" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"EdgeWin:Player:Top",
            CellIndex = 1,
            CellStateId = 0,
            CellCellState = 10,
            CellName = @"Top",
            CellStateName = @"Player"
        };

        List.Add(EdgeWinPlayerTop);
        ByEnum[CellPatternCellsEnum.EdgeWinPlayerTop] = EdgeWinPlayerTop;
        
            
        var TwoInARowMiddleNoPlayerMiddleRight = new CellPatternCell()
        {
            CellPatternCellId = @"rechiocdDSSkR1IFz",
            createdTime = DateTime.Parse("2020-11-26T20:44:04Z"),
            Cell = new string[] { @"recfSe8zeEdCAtcGq" },
            CellPattern = new string[] { @"recqn6vuQrx71nQii" },
            CellState = new string[] { @"recJAi8YoTOQmzhfH" },
            Name = @"TwoInARowMiddle:NoPlayer:MiddleRight",
            CellIndex = 5,
            CellStateId = 2,
            CellCellState = 52,
            CellName = @"MiddleRight",
            CellStateName = @"NoPlayer"
        };

        List.Add(TwoInARowMiddleNoPlayerMiddleRight);
        ByEnum[CellPatternCellsEnum.TwoInARowMiddleNoPlayerMiddleRight] = TwoInARowMiddleNoPlayerMiddleRight;
        
            
        var MiddleWinPlayerMiddleLeft = new CellPatternCell()
        {
            CellPatternCellId = @"reckcKNNnyDSWpFrH",
            createdTime = DateTime.Parse("2020-11-26T20:35:31Z"),
            Cell = new string[] { @"recxIf3GoDzEtonFU" },
            CellPattern = new string[] { @"recodVK2HKbzC26Db" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"MiddleWin:Player:MiddleLeft",
            CellIndex = 3,
            CellStateId = 0,
            CellCellState = 30,
            CellName = @"MiddleLeft",
            CellStateName = @"Player"
        };

        List.Add(MiddleWinPlayerMiddleLeft);
        ByEnum[CellPatternCellsEnum.MiddleWinPlayerMiddleLeft] = MiddleWinPlayerMiddleLeft;
        
            
        var TwoOutsideDiagonalPlayerBottomRight = new CellPatternCell()
        {
            CellPatternCellId = @"reclDV8jky7y1JNzH",
            createdTime = DateTime.Parse("2020-11-26T20:42:19Z"),
            Cell = new string[] { @"recczW2Y4WMv9buZ8" },
            CellPattern = new string[] { @"recg1ttw7l3n96PDG" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"TwoOutsideDiagonal:Player:BottomRight",
            CellIndex = 8,
            CellStateId = 0,
            CellCellState = 80,
            CellName = @"BottomRight",
            CellStateName = @"Player"
        };

        List.Add(TwoOutsideDiagonalPlayerBottomRight);
        ByEnum[CellPatternCellsEnum.TwoOutsideDiagonalPlayerBottomRight] = TwoOutsideDiagonalPlayerBottomRight;
        
            
        var TwoOutsideTopNoPlayerTop = new CellPatternCell()
        {
            CellPatternCellId = @"recljMfqekOodaaWx",
            createdTime = DateTime.Parse("2020-11-26T20:44:14Z"),
            Cell = new string[] { @"recpPYOZtnp3lTOua" },
            CellPattern = new string[] { @"recYmKv2dBpnAA1gs" },
            CellState = new string[] { @"recJAi8YoTOQmzhfH" },
            Name = @"TwoOutsideTop:NoPlayer:Top",
            CellIndex = 1,
            CellStateId = 2,
            CellCellState = 12,
            CellName = @"Top",
            CellStateName = @"NoPlayer"
        };

        List.Add(TwoOutsideTopNoPlayerTop);
        ByEnum[CellPatternCellsEnum.TwoOutsideTopNoPlayerTop] = TwoOutsideTopNoPlayerTop;
        
            
        var DiagonalWinPlayerTopLeft = new CellPatternCell()
        {
            CellPatternCellId = @"recqMa5gtwmjYgF2X",
            createdTime = DateTime.Parse("2020-12-11T20:01:38Z"),
            Name = @"DiagonalWin:Player:TopLeft",
            CellCellState = 00,
            CellPattern = new string[] { @"recg6YsAgLEBikQ3F" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            CellStateId = 0,
            CellStateName = @"Player",
            Cell = new string[] { @"rec50MWM91QHzlEzO" },
            CellIndex = 0,
            CellName = @"TopLeft"
        };

        List.Add(DiagonalWinPlayerTopLeft);
        ByEnum[CellPatternCellsEnum.DiagonalWinPlayerTopLeft] = DiagonalWinPlayerTopLeft;
        
            
        var TwoInARowDiagonalPlayerMiddle = new CellPatternCell()
        {
            CellPatternCellId = @"recwQ3ZI5MBVHPKgl",
            createdTime = DateTime.Parse("2020-11-26T20:43:44Z"),
            Cell = new string[] { @"rec35HZOaRy6ge0jk" },
            CellPattern = new string[] { @"recZCV8dlP1pNK9kK" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"TwoInARowDiagonal:Player:Middle",
            CellIndex = 4,
            CellStateId = 0,
            CellCellState = 40,
            CellName = @"Middle",
            CellStateName = @"Player"
        };

        List.Add(TwoInARowDiagonalPlayerMiddle);
        ByEnum[CellPatternCellsEnum.TwoInARowDiagonalPlayerMiddle] = TwoInARowDiagonalPlayerMiddle;
        
            
        var TwoInARowMiddlePlayerMiddleLeft = new CellPatternCell()
        {
            CellPatternCellId = @"recxWA16nieZY83Sv",
            createdTime = DateTime.Parse("2020-11-26T20:37:58Z"),
            Cell = new string[] { @"recxIf3GoDzEtonFU" },
            CellPattern = new string[] { @"recqn6vuQrx71nQii" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"TwoInARowMiddle:Player:MiddleLeft",
            CellIndex = 3,
            CellStateId = 0,
            CellCellState = 30,
            CellName = @"MiddleLeft",
            CellStateName = @"Player"
        };

        List.Add(TwoInARowMiddlePlayerMiddleLeft);
        ByEnum[CellPatternCellsEnum.TwoInARowMiddlePlayerMiddleLeft] = TwoInARowMiddlePlayerMiddleLeft;
        
            
        var TwoOutsideMiddlePlayerMiddleLeft = new CellPatternCell()
        {
            CellPatternCellId = @"recyZobcdc9yOkGuC",
            createdTime = DateTime.Parse("2020-11-26T20:37:58Z"),
            Cell = new string[] { @"recxIf3GoDzEtonFU" },
            CellPattern = new string[] { @"recobCShOEyZjP8bY" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"TwoOutsideMiddle:Player:MiddleLeft",
            CellIndex = 3,
            CellStateId = 0,
            CellCellState = 30,
            CellName = @"MiddleLeft",
            CellStateName = @"Player"
        };

        List.Add(TwoOutsideMiddlePlayerMiddleLeft);
        ByEnum[CellPatternCellsEnum.TwoOutsideMiddlePlayerMiddleLeft] = TwoOutsideMiddlePlayerMiddleLeft;
        
    }

}