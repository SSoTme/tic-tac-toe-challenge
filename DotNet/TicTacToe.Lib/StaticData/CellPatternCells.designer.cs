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
        
            
        var TwoOutsideMiddlePlayerAMiddleRight = new CellPatternCell()
        {
            CellPatternCellId = @"rec6RGGCG5ORVBnA3",
            createdTime = DateTime.Parse("2020-11-26T20:44:11Z"),
            Cell = new string[] { @"recfSe8zeEdCAtcGq" },
            CellPattern = new string[] { @"recobCShOEyZjP8bY" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"TwoOutsideMiddle:PlayerA:MiddleRight",
            CellIndex = 5,
            CellStateId = 0,
            CellCellState = 50,
            CellName = @"MiddleRight",
            CellStateName = @"PlayerA"
        };

        List.Add(TwoOutsideMiddlePlayerAMiddleRight);
        ByEnum[CellPatternCellsEnum.TwoOutsideMiddlePlayerAMiddleRight] = TwoOutsideMiddlePlayerAMiddleRight;
        
            
        var TwoOutsideTopPlayerATopRight = new CellPatternCell()
        {
            CellPatternCellId = @"rec8bt4pVcy9OY8XO",
            createdTime = DateTime.Parse("2020-11-26T20:44:14Z"),
            Cell = new string[] { @"recTGnKjXTE8LfT3C" },
            CellPattern = new string[] { @"recYmKv2dBpnAA1gs" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"TwoOutsideTop:PlayerA:TopRight",
            CellIndex = 2,
            CellStateId = 0,
            CellCellState = 20,
            CellName = @"TopRight",
            CellStateName = @"PlayerA"
        };

        List.Add(TwoOutsideTopPlayerATopRight);
        ByEnum[CellPatternCellsEnum.TwoOutsideTopPlayerATopRight] = TwoOutsideTopPlayerATopRight;
        
            
        var TwoInARowDiagonalPlayerATopLeft = new CellPatternCell()
        {
            CellPatternCellId = @"rec91aKNdkT2cw93v",
            createdTime = DateTime.Parse("2020-11-26T20:37:58Z"),
            Cell = new string[] { @"rec50MWM91QHzlEzO" },
            CellPattern = new string[] { @"recZCV8dlP1pNK9kK" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"TwoInARowDiagonal:PlayerA:TopLeft",
            CellIndex = 0,
            CellStateId = 0,
            CellCellState = 00,
            CellName = @"TopLeft",
            CellStateName = @"PlayerA"
        };

        List.Add(TwoInARowDiagonalPlayerATopLeft);
        ByEnum[CellPatternCellsEnum.TwoInARowDiagonalPlayerATopLeft] = TwoInARowDiagonalPlayerATopLeft;
        
            
        var MiddleWinPlayerAMiddleRight = new CellPatternCell()
        {
            CellPatternCellId = @"recAy4XNSSKRZGZsh",
            createdTime = DateTime.Parse("2020-11-26T20:42:02Z"),
            Cell = new string[] { @"recfSe8zeEdCAtcGq" },
            CellPattern = new string[] { @"recodVK2HKbzC26Db" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"MiddleWin:PlayerA:MiddleRight",
            CellIndex = 5,
            CellStateId = 0,
            CellCellState = 50,
            CellName = @"MiddleRight",
            CellStateName = @"PlayerA"
        };

        List.Add(MiddleWinPlayerAMiddleRight);
        ByEnum[CellPatternCellsEnum.MiddleWinPlayerAMiddleRight] = MiddleWinPlayerAMiddleRight;
        
            
        var TwoInARowTopPlayerATop = new CellPatternCell()
        {
            CellPatternCellId = @"recFITGoLxBQs1ocD",
            createdTime = DateTime.Parse("2020-11-26T20:44:06Z"),
            Cell = new string[] { @"recpPYOZtnp3lTOua" },
            CellPattern = new string[] { @"rec55PqGhtUYK5Rcb" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"TwoInARowTop:PlayerA:Top",
            CellIndex = 1,
            CellStateId = 0,
            CellCellState = 10,
            CellName = @"Top",
            CellStateName = @"PlayerA"
        };

        List.Add(TwoInARowTopPlayerATop);
        ByEnum[CellPatternCellsEnum.TwoInARowTopPlayerATop] = TwoInARowTopPlayerATop;
        
            
        var MiddleWinPlayerAMiddle = new CellPatternCell()
        {
            CellPatternCellId = @"recGP80BxFCLlmgw7",
            createdTime = DateTime.Parse("2020-11-26T20:41:59Z"),
            Cell = new string[] { @"rec35HZOaRy6ge0jk" },
            CellPattern = new string[] { @"recodVK2HKbzC26Db" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"MiddleWin:PlayerA:Middle",
            CellIndex = 4,
            CellStateId = 0,
            CellCellState = 40,
            CellName = @"Middle",
            CellStateName = @"PlayerA"
        };

        List.Add(MiddleWinPlayerAMiddle);
        ByEnum[CellPatternCellsEnum.MiddleWinPlayerAMiddle] = MiddleWinPlayerAMiddle;
        
            
        var TwoOutsideTopPlayerATopLeft = new CellPatternCell()
        {
            CellPatternCellId = @"recKj18pU9k6V6MAx",
            createdTime = DateTime.Parse("2020-11-26T20:37:58Z"),
            Cell = new string[] { @"rec50MWM91QHzlEzO" },
            CellPattern = new string[] { @"recYmKv2dBpnAA1gs" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"TwoOutsideTop:PlayerA:TopLeft",
            CellIndex = 0,
            CellStateId = 0,
            CellCellState = 00,
            CellName = @"TopLeft",
            CellStateName = @"PlayerA"
        };

        List.Add(TwoOutsideTopPlayerATopLeft);
        ByEnum[CellPatternCellsEnum.TwoOutsideTopPlayerATopLeft] = TwoOutsideTopPlayerATopLeft;
        
            
        var EdgeWinPlayerATopRight = new CellPatternCell()
        {
            CellPatternCellId = @"recPHA9ppFH8cjenC",
            createdTime = DateTime.Parse("2020-11-26T20:38:15Z"),
            Cell = new string[] { @"recTGnKjXTE8LfT3C" },
            CellPattern = new string[] { @"recBDK2nzNlGSJNgJ" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"EdgeWin:PlayerA:TopRight",
            CellIndex = 2,
            CellStateId = 0,
            CellCellState = 20,
            CellName = @"TopRight",
            CellStateName = @"PlayerA"
        };

        List.Add(EdgeWinPlayerATopRight);
        ByEnum[CellPatternCellsEnum.EdgeWinPlayerATopRight] = EdgeWinPlayerATopRight;
        
            
        var TwoInARowMiddlePlayerAMiddle = new CellPatternCell()
        {
            CellPatternCellId = @"recPmKMMNhYSxBWJ0",
            createdTime = DateTime.Parse("2020-11-26T20:44:04Z"),
            Cell = new string[] { @"rec35HZOaRy6ge0jk" },
            CellPattern = new string[] { @"recqn6vuQrx71nQii" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"TwoInARowMiddle:PlayerA:Middle",
            CellIndex = 4,
            CellStateId = 0,
            CellCellState = 40,
            CellName = @"Middle",
            CellStateName = @"PlayerA"
        };

        List.Add(TwoInARowMiddlePlayerAMiddle);
        ByEnum[CellPatternCellsEnum.TwoInARowMiddlePlayerAMiddle] = TwoInARowMiddlePlayerAMiddle;
        
            
        var EdgeWinPlayerATopLeft = new CellPatternCell()
        {
            CellPatternCellId = @"recU9O3yxyMeQ1eU4",
            createdTime = DateTime.Parse("2020-11-26T20:35:31Z"),
            Cell = new string[] { @"rec50MWM91QHzlEzO" },
            CellPattern = new string[] { @"recBDK2nzNlGSJNgJ" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"EdgeWin:PlayerA:TopLeft",
            CellIndex = 0,
            CellStateId = 0,
            CellCellState = 00,
            CellName = @"TopLeft",
            CellStateName = @"PlayerA"
        };

        List.Add(EdgeWinPlayerATopLeft);
        ByEnum[CellPatternCellsEnum.EdgeWinPlayerATopLeft] = EdgeWinPlayerATopLeft;
        
            
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
        
            
        var TwoOutsideDiagonalPlayerATopLeft = new CellPatternCell()
        {
            CellPatternCellId = @"recYR4cE90EOVnYD5",
            createdTime = DateTime.Parse("2020-11-26T20:37:58Z"),
            Cell = new string[] { @"rec50MWM91QHzlEzO" },
            CellPattern = new string[] { @"recg1ttw7l3n96PDG" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"TwoOutsideDiagonal:PlayerA:TopLeft",
            CellIndex = 0,
            CellStateId = 0,
            CellCellState = 00,
            CellName = @"TopLeft",
            CellStateName = @"PlayerA"
        };

        List.Add(TwoOutsideDiagonalPlayerATopLeft);
        ByEnum[CellPatternCellsEnum.TwoOutsideDiagonalPlayerATopLeft] = TwoOutsideDiagonalPlayerATopLeft;
        
            
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
        
            
        var TwoInARowTopPlayerATopLeft = new CellPatternCell()
        {
            CellPatternCellId = @"recclaJuN3LJWLC4N",
            createdTime = DateTime.Parse("2020-11-26T20:35:31Z"),
            Cell = new string[] { @"rec50MWM91QHzlEzO" },
            CellPattern = new string[] { @"rec55PqGhtUYK5Rcb" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"TwoInARowTop:PlayerA:TopLeft",
            CellIndex = 0,
            CellStateId = 0,
            CellCellState = 00,
            CellName = @"TopLeft",
            CellStateName = @"PlayerA"
        };

        List.Add(TwoInARowTopPlayerATopLeft);
        ByEnum[CellPatternCellsEnum.TwoInARowTopPlayerATopLeft] = TwoInARowTopPlayerATopLeft;
        
            
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
        
            
        var EdgeWinPlayerATop = new CellPatternCell()
        {
            CellPatternCellId = @"recf1uu1YY0iPps8E",
            createdTime = DateTime.Parse("2020-11-26T20:38:12Z"),
            Cell = new string[] { @"recpPYOZtnp3lTOua" },
            CellPattern = new string[] { @"recBDK2nzNlGSJNgJ" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"EdgeWin:PlayerA:Top",
            CellIndex = 1,
            CellStateId = 0,
            CellCellState = 10,
            CellName = @"Top",
            CellStateName = @"PlayerA"
        };

        List.Add(EdgeWinPlayerATop);
        ByEnum[CellPatternCellsEnum.EdgeWinPlayerATop] = EdgeWinPlayerATop;
        
            
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
        
            
        var MiddleWinPlayerAMiddleLeft = new CellPatternCell()
        {
            CellPatternCellId = @"reckcKNNnyDSWpFrH",
            createdTime = DateTime.Parse("2020-11-26T20:35:31Z"),
            Cell = new string[] { @"recxIf3GoDzEtonFU" },
            CellPattern = new string[] { @"recodVK2HKbzC26Db" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"MiddleWin:PlayerA:MiddleLeft",
            CellIndex = 3,
            CellStateId = 0,
            CellCellState = 30,
            CellName = @"MiddleLeft",
            CellStateName = @"PlayerA"
        };

        List.Add(MiddleWinPlayerAMiddleLeft);
        ByEnum[CellPatternCellsEnum.MiddleWinPlayerAMiddleLeft] = MiddleWinPlayerAMiddleLeft;
        
            
        var TwoOutsideDiagonalPlayerABottomRight = new CellPatternCell()
        {
            CellPatternCellId = @"reclDV8jky7y1JNzH",
            createdTime = DateTime.Parse("2020-11-26T20:42:19Z"),
            Cell = new string[] { @"recczW2Y4WMv9buZ8" },
            CellPattern = new string[] { @"recg1ttw7l3n96PDG" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"TwoOutsideDiagonal:PlayerA:BottomRight",
            CellIndex = 8,
            CellStateId = 0,
            CellCellState = 80,
            CellName = @"BottomRight",
            CellStateName = @"PlayerA"
        };

        List.Add(TwoOutsideDiagonalPlayerABottomRight);
        ByEnum[CellPatternCellsEnum.TwoOutsideDiagonalPlayerABottomRight] = TwoOutsideDiagonalPlayerABottomRight;
        
            
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
        
            
        var TwoInARowDiagonalPlayerAMiddle = new CellPatternCell()
        {
            CellPatternCellId = @"recwQ3ZI5MBVHPKgl",
            createdTime = DateTime.Parse("2020-11-26T20:43:44Z"),
            Cell = new string[] { @"rec35HZOaRy6ge0jk" },
            CellPattern = new string[] { @"recZCV8dlP1pNK9kK" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"TwoInARowDiagonal:PlayerA:Middle",
            CellIndex = 4,
            CellStateId = 0,
            CellCellState = 40,
            CellName = @"Middle",
            CellStateName = @"PlayerA"
        };

        List.Add(TwoInARowDiagonalPlayerAMiddle);
        ByEnum[CellPatternCellsEnum.TwoInARowDiagonalPlayerAMiddle] = TwoInARowDiagonalPlayerAMiddle;
        
            
        var TwoInARowMiddlePlayerAMiddleLeft = new CellPatternCell()
        {
            CellPatternCellId = @"recxWA16nieZY83Sv",
            createdTime = DateTime.Parse("2020-11-26T20:37:58Z"),
            Cell = new string[] { @"recxIf3GoDzEtonFU" },
            CellPattern = new string[] { @"recqn6vuQrx71nQii" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"TwoInARowMiddle:PlayerA:MiddleLeft",
            CellIndex = 3,
            CellStateId = 0,
            CellCellState = 30,
            CellName = @"MiddleLeft",
            CellStateName = @"PlayerA"
        };

        List.Add(TwoInARowMiddlePlayerAMiddleLeft);
        ByEnum[CellPatternCellsEnum.TwoInARowMiddlePlayerAMiddleLeft] = TwoInARowMiddlePlayerAMiddleLeft;
        
            
        var TwoOutsideMiddlePlayerAMiddleLeft = new CellPatternCell()
        {
            CellPatternCellId = @"recyZobcdc9yOkGuC",
            createdTime = DateTime.Parse("2020-11-26T20:37:58Z"),
            Cell = new string[] { @"recxIf3GoDzEtonFU" },
            CellPattern = new string[] { @"recobCShOEyZjP8bY" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"TwoOutsideMiddle:PlayerA:MiddleLeft",
            CellIndex = 3,
            CellStateId = 0,
            CellCellState = 30,
            CellName = @"MiddleLeft",
            CellStateName = @"PlayerA"
        };

        List.Add(TwoOutsideMiddlePlayerAMiddleLeft);
        ByEnum[CellPatternCellsEnum.TwoOutsideMiddlePlayerAMiddleLeft] = TwoOutsideMiddlePlayerAMiddleLeft;
        
    }

}