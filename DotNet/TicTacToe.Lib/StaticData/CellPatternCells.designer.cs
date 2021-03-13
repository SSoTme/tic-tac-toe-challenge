using System;
using System.Linq;
using TicTacToeChallenge.Lib.DataClasses;

public static partial class CellPatternCells
{
    private static void InitCellPatternCells()
    {
        // setup each one...
        
            
        var RightLeftDiagonalPlayerAMiddle = new CellPatternCell()
        {
            CellPatternCellId = @"rec1Gsh1wvAQ3BO0w",
            createdTime = DateTime.Parse("2020-12-12T00:49:12Z"),
            Cell = new string[] { @"rec35HZOaRy6ge0jk" },
            CellPattern = new string[] { @"recWQyBlj7xHrYNPx" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"RightLeftDiagonal:PlayerA:Middle",
            CellPatternType = @"NamedSet",
            CellIndex = 4,
            CellStateId = 0,
            CellCellState = 40,
            CellName = @"Middle",
            CellStateName = @"PlayerA"
        };

        List.Add(RightLeftDiagonalPlayerAMiddle);
        ByEnum[CellPatternCellsEnum.RightLeftDiagonalPlayerAMiddle] = RightLeftDiagonalPlayerAMiddle;
        
            
        var Column1PlayerATopLeft = new CellPatternCell()
        {
            CellPatternCellId = @"rec1hqH6Ty1vueu48",
            createdTime = DateTime.Parse("2020-12-12T00:47:10Z"),
            Cell = new string[] { @"rec50MWM91QHzlEzO" },
            CellPattern = new string[] { @"recJ1wDRP5taMg2Tj" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"Column1:PlayerA:TopLeft",
            CellPatternType = @"NamedSet",
            CellIndex = 0,
            CellStateId = 0,
            CellCellState = 00,
            CellName = @"TopLeft",
            CellStateName = @"PlayerA"
        };

        List.Add(Column1PlayerATopLeft);
        ByEnum[CellPatternCellsEnum.Column1PlayerATopLeft] = Column1PlayerATopLeft;
        
            
        var Column2PlayerATop = new CellPatternCell()
        {
            CellPatternCellId = @"rec3K2fxtqlgu5oeA",
            createdTime = DateTime.Parse("2020-12-12T00:47:07Z"),
            Cell = new string[] { @"recpPYOZtnp3lTOua" },
            CellPattern = new string[] { @"recXBksm5DIUqOfDn" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"Column2:PlayerA:Top",
            CellPatternType = @"NamedSet",
            CellIndex = 1,
            CellStateId = 0,
            CellCellState = 10,
            CellName = @"Top",
            CellStateName = @"PlayerA"
        };

        List.Add(Column2PlayerATop);
        ByEnum[CellPatternCellsEnum.Column2PlayerATop] = Column2PlayerATop;
        
            
        var TwoInARowDiagonalNoPlayerBottomRight = new CellPatternCell()
        {
            CellPatternCellId = @"rec5D3fwk2h5GzjIB",
            createdTime = DateTime.Parse("2020-11-26T20:43:48Z"),
            Cell = new string[] { @"recczW2Y4WMv9buZ8" },
            CellPattern = new string[] { @"recZCV8dlP1pNK9kK" },
            CellState = new string[] { @"recJAi8YoTOQmzhfH" },
            Name = @"TwoInARowDiagonal:NoPlayer:BottomRight",
            CellPatternType = @"PossibleWin",
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
            CellPatternType = @"PossibleWin",
            CellIndex = 5,
            CellStateId = 0,
            CellCellState = 50,
            CellName = @"MiddleRight",
            CellStateName = @"PlayerA"
        };

        List.Add(TwoOutsideMiddlePlayerAMiddleRight);
        ByEnum[CellPatternCellsEnum.TwoOutsideMiddlePlayerAMiddleRight] = TwoOutsideMiddlePlayerAMiddleRight;
        
            
        var Row3PlayerABottomLeft = new CellPatternCell()
        {
            CellPatternCellId = @"rec7NXPxQPU4PzKX0",
            createdTime = DateTime.Parse("2020-12-12T00:47:14Z"),
            Cell = new string[] { @"recmjtZPRUfoCU2sr" },
            CellPattern = new string[] { @"recHqX6LLAZZAo1RQ" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"Row3:PlayerA:BottomLeft",
            CellPatternType = @"NamedSet",
            CellIndex = 6,
            CellStateId = 0,
            CellCellState = 60,
            CellName = @"BottomLeft",
            CellStateName = @"PlayerA"
        };

        List.Add(Row3PlayerABottomLeft);
        ByEnum[CellPatternCellsEnum.Row3PlayerABottomLeft] = Row3PlayerABottomLeft;
        
            
        var TwoOutsideTopPlayerATopRight = new CellPatternCell()
        {
            CellPatternCellId = @"rec8bt4pVcy9OY8XO",
            createdTime = DateTime.Parse("2020-11-26T20:44:14Z"),
            Cell = new string[] { @"recTGnKjXTE8LfT3C" },
            CellPattern = new string[] { @"recYmKv2dBpnAA1gs" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"TwoOutsideTop:PlayerA:TopRight",
            CellPatternType = @"PossibleWin",
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
            CellPatternType = @"PossibleWin",
            CellIndex = 0,
            CellStateId = 0,
            CellCellState = 00,
            CellName = @"TopLeft",
            CellStateName = @"PlayerA"
        };

        List.Add(TwoInARowDiagonalPlayerATopLeft);
        ByEnum[CellPatternCellsEnum.TwoInARowDiagonalPlayerATopLeft] = TwoInARowDiagonalPlayerATopLeft;
        
            
        var LeftRightDiagonalPlayerAMiddle = new CellPatternCell()
        {
            CellPatternCellId = @"recAJ25e2uael63Kw",
            createdTime = DateTime.Parse("2020-12-12T00:49:01Z"),
            Cell = new string[] { @"rec35HZOaRy6ge0jk" },
            CellPattern = new string[] { @"reccf6U6b21xlIOh7" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"LeftRightDiagonal:PlayerA:Middle",
            CellPatternType = @"NamedSet",
            CellIndex = 4,
            CellStateId = 0,
            CellCellState = 40,
            CellName = @"Middle",
            CellStateName = @"PlayerA"
        };

        List.Add(LeftRightDiagonalPlayerAMiddle);
        ByEnum[CellPatternCellsEnum.LeftRightDiagonalPlayerAMiddle] = LeftRightDiagonalPlayerAMiddle;
        
            
        var MiddleWinPlayerAMiddleRight = new CellPatternCell()
        {
            CellPatternCellId = @"recAy4XNSSKRZGZsh",
            createdTime = DateTime.Parse("2020-11-26T20:42:02Z"),
            Cell = new string[] { @"recfSe8zeEdCAtcGq" },
            CellPattern = new string[] { @"recodVK2HKbzC26Db" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"MiddleWin:PlayerA:MiddleRight",
            CellPatternType = @"Win",
            CellIndex = 5,
            CellStateId = 0,
            CellCellState = 50,
            CellName = @"MiddleRight",
            CellStateName = @"PlayerA"
        };

        List.Add(MiddleWinPlayerAMiddleRight);
        ByEnum[CellPatternCellsEnum.MiddleWinPlayerAMiddleRight] = MiddleWinPlayerAMiddleRight;
        
            
        var Row2PlayerAMiddleRight = new CellPatternCell()
        {
            CellPatternCellId = @"recBi8mtXhiWj7TJH",
            createdTime = DateTime.Parse("2020-12-12T00:48:52Z"),
            Cell = new string[] { @"recfSe8zeEdCAtcGq" },
            CellPattern = new string[] { @"recqpmR7MAtp5afiM" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"Row2:PlayerA:MiddleRight",
            CellPatternType = @"NamedSet",
            CellIndex = 5,
            CellStateId = 0,
            CellCellState = 50,
            CellName = @"MiddleRight",
            CellStateName = @"PlayerA"
        };

        List.Add(Row2PlayerAMiddleRight);
        ByEnum[CellPatternCellsEnum.Row2PlayerAMiddleRight] = Row2PlayerAMiddleRight;
        
            
        var Row1PlayerATopRight = new CellPatternCell()
        {
            CellPatternCellId = @"recD2BUDpoknNF4Lh",
            createdTime = DateTime.Parse("2020-12-12T00:48:48Z"),
            Cell = new string[] { @"recTGnKjXTE8LfT3C" },
            CellPattern = new string[] { @"recYQei900zbRIFTw" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"Row1:PlayerA:TopRight",
            CellPatternType = @"NamedSet",
            CellIndex = 2,
            CellStateId = 0,
            CellCellState = 20,
            CellName = @"TopRight",
            CellStateName = @"PlayerA"
        };

        List.Add(Row1PlayerATopRight);
        ByEnum[CellPatternCellsEnum.Row1PlayerATopRight] = Row1PlayerATopRight;
        
            
        var TwoInARowTopPlayerATop = new CellPatternCell()
        {
            CellPatternCellId = @"recFITGoLxBQs1ocD",
            createdTime = DateTime.Parse("2020-11-26T20:44:06Z"),
            Cell = new string[] { @"recpPYOZtnp3lTOua" },
            CellPattern = new string[] { @"rec55PqGhtUYK5Rcb" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"TwoInARowTop:PlayerA:Top",
            CellPatternType = @"PossibleWin",
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
            CellPatternType = @"Win",
            CellIndex = 4,
            CellStateId = 0,
            CellCellState = 40,
            CellName = @"Middle",
            CellStateName = @"PlayerA"
        };

        List.Add(MiddleWinPlayerAMiddle);
        ByEnum[CellPatternCellsEnum.MiddleWinPlayerAMiddle] = MiddleWinPlayerAMiddle;
        
            
        var Row1PlayerATop = new CellPatternCell()
        {
            CellPatternCellId = @"recJtIPt56a61dAFz",
            createdTime = DateTime.Parse("2020-12-12T00:48:48Z"),
            Cell = new string[] { @"recpPYOZtnp3lTOua" },
            CellPattern = new string[] { @"recYQei900zbRIFTw" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"Row1:PlayerA:Top",
            CellPatternType = @"NamedSet",
            CellIndex = 1,
            CellStateId = 0,
            CellCellState = 10,
            CellName = @"Top",
            CellStateName = @"PlayerA"
        };

        List.Add(Row1PlayerATop);
        ByEnum[CellPatternCellsEnum.Row1PlayerATop] = Row1PlayerATop;
        
            
        var TwoOutsideTopPlayerATopLeft = new CellPatternCell()
        {
            CellPatternCellId = @"recKj18pU9k6V6MAx",
            createdTime = DateTime.Parse("2020-11-26T20:37:58Z"),
            Cell = new string[] { @"rec50MWM91QHzlEzO" },
            CellPattern = new string[] { @"recYmKv2dBpnAA1gs" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"TwoOutsideTop:PlayerA:TopLeft",
            CellPatternType = @"PossibleWin",
            CellIndex = 0,
            CellStateId = 0,
            CellCellState = 00,
            CellName = @"TopLeft",
            CellStateName = @"PlayerA"
        };

        List.Add(TwoOutsideTopPlayerATopLeft);
        ByEnum[CellPatternCellsEnum.TwoOutsideTopPlayerATopLeft] = TwoOutsideTopPlayerATopLeft;
        
            
        var Row1PlayerATopLeft = new CellPatternCell()
        {
            CellPatternCellId = @"recLcTgsFF8EuGUz3",
            createdTime = DateTime.Parse("2020-12-12T00:45:27Z"),
            Cell = new string[] { @"rec50MWM91QHzlEzO" },
            CellPattern = new string[] { @"recYQei900zbRIFTw" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"Row1:PlayerA:TopLeft",
            CellPatternType = @"NamedSet",
            CellIndex = 0,
            CellStateId = 0,
            CellCellState = 00,
            CellName = @"TopLeft",
            CellStateName = @"PlayerA"
        };

        List.Add(Row1PlayerATopLeft);
        ByEnum[CellPatternCellsEnum.Row1PlayerATopLeft] = Row1PlayerATopLeft;
        
            
        var Column3PlayerATopRight = new CellPatternCell()
        {
            CellPatternCellId = @"recO1aArEBMEvWxoD",
            createdTime = DateTime.Parse("2020-12-12T00:46:41Z"),
            Cell = new string[] { @"recTGnKjXTE8LfT3C" },
            CellPattern = new string[] { @"recNW9KXsm9KvWa7B" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"Column3:PlayerA:TopRight",
            CellPatternType = @"NamedSet",
            CellIndex = 2,
            CellStateId = 0,
            CellCellState = 20,
            CellName = @"TopRight",
            CellStateName = @"PlayerA"
        };

        List.Add(Column3PlayerATopRight);
        ByEnum[CellPatternCellsEnum.Column3PlayerATopRight] = Column3PlayerATopRight;
        
            
        var EdgeWinPlayerATopRight = new CellPatternCell()
        {
            CellPatternCellId = @"recPHA9ppFH8cjenC",
            createdTime = DateTime.Parse("2020-11-26T20:38:15Z"),
            Cell = new string[] { @"recTGnKjXTE8LfT3C" },
            CellPattern = new string[] { @"recBDK2nzNlGSJNgJ" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"EdgeWin:PlayerA:TopRight",
            CellPatternType = @"Win",
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
            CellPatternType = @"PossibleWin",
            CellIndex = 4,
            CellStateId = 0,
            CellCellState = 40,
            CellName = @"Middle",
            CellStateName = @"PlayerA"
        };

        List.Add(TwoInARowMiddlePlayerAMiddle);
        ByEnum[CellPatternCellsEnum.TwoInARowMiddlePlayerAMiddle] = TwoInARowMiddlePlayerAMiddle;
        
            
        var DiagonalWinPlayerATopLeft = new CellPatternCell()
        {
            CellPatternCellId = @"recR4dC3tW41PPZ8x",
            createdTime = DateTime.Parse("2020-12-18T20:42:16Z"),
            Name = @"DiagonalWin:PlayerA:TopLeft",
            CellCellState = 00,
            CellPattern = new string[] { @"recuenPSYKnW2WfOH" },
            CellPatternType = @"Win",
            Cell = new string[] { @"rec50MWM91QHzlEzO" },
            CellIndex = 0,
            CellName = @"TopLeft",
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            CellStateId = 0,
            CellStateName = @"PlayerA"
        };

        List.Add(DiagonalWinPlayerATopLeft);
        ByEnum[CellPatternCellsEnum.DiagonalWinPlayerATopLeft] = DiagonalWinPlayerATopLeft;
        
            
        var Column1PlayerABottomLeft = new CellPatternCell()
        {
            CellPatternCellId = @"recShopv0fRnIWAbr",
            createdTime = DateTime.Parse("2020-12-12T00:48:31Z"),
            Cell = new string[] { @"recmjtZPRUfoCU2sr" },
            CellPattern = new string[] { @"recJ1wDRP5taMg2Tj" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"Column1:PlayerA:BottomLeft",
            CellPatternType = @"NamedSet",
            CellIndex = 6,
            CellStateId = 0,
            CellCellState = 60,
            CellName = @"BottomLeft",
            CellStateName = @"PlayerA"
        };

        List.Add(Column1PlayerABottomLeft);
        ByEnum[CellPatternCellsEnum.Column1PlayerABottomLeft] = Column1PlayerABottomLeft;
        
            
        var DiagonalWinPlayerABottomRight = new CellPatternCell()
        {
            CellPatternCellId = @"recTcBwvPbWD9wMyy",
            createdTime = DateTime.Parse("2020-12-18T20:43:33Z"),
            CellPattern = new string[] { @"recuenPSYKnW2WfOH" },
            Name = @"DiagonalWin:PlayerA:BottomRight",
            CellPatternType = @"Win",
            CellCellState = 80,
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            CellStateId = 0,
            CellStateName = @"PlayerA",
            Cell = new string[] { @"recczW2Y4WMv9buZ8" },
            CellIndex = 8,
            CellName = @"BottomRight"
        };

        List.Add(DiagonalWinPlayerABottomRight);
        ByEnum[CellPatternCellsEnum.DiagonalWinPlayerABottomRight] = DiagonalWinPlayerABottomRight;
        
            
        var RightLeftDiagonalPlayerABottomLeft = new CellPatternCell()
        {
            CellPatternCellId = @"recTk43h9Sd9Qw1aQ",
            createdTime = DateTime.Parse("2020-12-12T00:49:12Z"),
            Cell = new string[] { @"recmjtZPRUfoCU2sr" },
            CellPattern = new string[] { @"recWQyBlj7xHrYNPx" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"RightLeftDiagonal:PlayerA:BottomLeft",
            CellPatternType = @"NamedSet",
            CellIndex = 6,
            CellStateId = 0,
            CellCellState = 60,
            CellName = @"BottomLeft",
            CellStateName = @"PlayerA"
        };

        List.Add(RightLeftDiagonalPlayerABottomLeft);
        ByEnum[CellPatternCellsEnum.RightLeftDiagonalPlayerABottomLeft] = RightLeftDiagonalPlayerABottomLeft;
        
            
        var EdgeWinPlayerATopLeft = new CellPatternCell()
        {
            CellPatternCellId = @"recU9O3yxyMeQ1eU4",
            createdTime = DateTime.Parse("2020-11-26T20:35:31Z"),
            Cell = new string[] { @"rec50MWM91QHzlEzO" },
            CellPattern = new string[] { @"recBDK2nzNlGSJNgJ" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"EdgeWin:PlayerA:TopLeft",
            CellPatternType = @"Win",
            CellIndex = 0,
            CellStateId = 0,
            CellCellState = 00,
            CellName = @"TopLeft",
            CellStateName = @"PlayerA"
        };

        List.Add(EdgeWinPlayerATopLeft);
        ByEnum[CellPatternCellsEnum.EdgeWinPlayerATopLeft] = EdgeWinPlayerATopLeft;
        
            
        var Row2PlayerAMiddle = new CellPatternCell()
        {
            CellPatternCellId = @"recUNdmTwmeITNGEZ",
            createdTime = DateTime.Parse("2020-12-12T00:48:52Z"),
            Cell = new string[] { @"rec35HZOaRy6ge0jk" },
            CellPattern = new string[] { @"recqpmR7MAtp5afiM" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"Row2:PlayerA:Middle",
            CellPatternType = @"NamedSet",
            CellIndex = 4,
            CellStateId = 0,
            CellCellState = 40,
            CellName = @"Middle",
            CellStateName = @"PlayerA"
        };

        List.Add(Row2PlayerAMiddle);
        ByEnum[CellPatternCellsEnum.Row2PlayerAMiddle] = Row2PlayerAMiddle;
        
            
        var Column2PlayerABottom = new CellPatternCell()
        {
            CellPatternCellId = @"recVxUYMsnvGIqGZ2",
            createdTime = DateTime.Parse("2020-12-12T00:48:40Z"),
            Cell = new string[] { @"rec3OzG8nTAkUhjVn" },
            CellPattern = new string[] { @"recXBksm5DIUqOfDn" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"Column2:PlayerA:Bottom",
            CellPatternType = @"NamedSet",
            CellIndex = 7,
            CellStateId = 0,
            CellCellState = 70,
            CellName = @"Bottom",
            CellStateName = @"PlayerA"
        };

        List.Add(Column2PlayerABottom);
        ByEnum[CellPatternCellsEnum.Column2PlayerABottom] = Column2PlayerABottom;
        
            
        var TwoOutsideDiagonalNoPlayerMiddle = new CellPatternCell()
        {
            CellPatternCellId = @"recWoh5Qk0b1xBV67",
            createdTime = DateTime.Parse("2020-11-26T20:42:17Z"),
            Cell = new string[] { @"rec35HZOaRy6ge0jk" },
            CellPattern = new string[] { @"recg1ttw7l3n96PDG" },
            CellState = new string[] { @"recJAi8YoTOQmzhfH" },
            Name = @"TwoOutsideDiagonal:NoPlayer:Middle",
            CellPatternType = @"PossibleWin",
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
            CellPatternType = @"PossibleWin",
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
            CellPatternType = @"PossibleWin",
            CellIndex = 4,
            CellStateId = 2,
            CellCellState = 42,
            CellName = @"Middle",
            CellStateName = @"NoPlayer"
        };

        List.Add(TwoOutsideMiddleNoPlayerMiddle);
        ByEnum[CellPatternCellsEnum.TwoOutsideMiddleNoPlayerMiddle] = TwoOutsideMiddleNoPlayerMiddle;
        
            
        var Row3PlayerABottomRight = new CellPatternCell()
        {
            CellPatternCellId = @"recc99ZERSFi8OZgJ",
            createdTime = DateTime.Parse("2020-12-12T00:48:55Z"),
            Cell = new string[] { @"recczW2Y4WMv9buZ8" },
            CellPattern = new string[] { @"recHqX6LLAZZAo1RQ" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"Row3:PlayerA:BottomRight",
            CellPatternType = @"NamedSet",
            CellIndex = 8,
            CellStateId = 0,
            CellCellState = 80,
            CellName = @"BottomRight",
            CellStateName = @"PlayerA"
        };

        List.Add(Row3PlayerABottomRight);
        ByEnum[CellPatternCellsEnum.Row3PlayerABottomRight] = Row3PlayerABottomRight;
        
            
        var TwoInARowTopPlayerATopLeft = new CellPatternCell()
        {
            CellPatternCellId = @"recclaJuN3LJWLC4N",
            createdTime = DateTime.Parse("2020-11-26T20:35:31Z"),
            Cell = new string[] { @"rec50MWM91QHzlEzO" },
            CellPattern = new string[] { @"rec55PqGhtUYK5Rcb" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"TwoInARowTop:PlayerA:TopLeft",
            CellPatternType = @"PossibleWin",
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
            CellPatternType = @"PossibleWin",
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
            CellPatternType = @"Win",
            CellIndex = 1,
            CellStateId = 0,
            CellCellState = 10,
            CellName = @"Top",
            CellStateName = @"PlayerA"
        };

        List.Add(EdgeWinPlayerATop);
        ByEnum[CellPatternCellsEnum.EdgeWinPlayerATop] = EdgeWinPlayerATop;
        
            
        var LeftRightDiagonalPlayerABottomRight = new CellPatternCell()
        {
            CellPatternCellId = @"recfjQk3Amk3Ofo0S",
            createdTime = DateTime.Parse("2020-12-12T00:49:01Z"),
            Cell = new string[] { @"recczW2Y4WMv9buZ8" },
            CellPattern = new string[] { @"reccf6U6b21xlIOh7" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"LeftRightDiagonal:PlayerA:BottomRight",
            CellPatternType = @"NamedSet",
            CellIndex = 8,
            CellStateId = 0,
            CellCellState = 80,
            CellName = @"BottomRight",
            CellStateName = @"PlayerA"
        };

        List.Add(LeftRightDiagonalPlayerABottomRight);
        ByEnum[CellPatternCellsEnum.LeftRightDiagonalPlayerABottomRight] = LeftRightDiagonalPlayerABottomRight;
        
            
        var TwoInARowMiddleNoPlayerMiddleRight = new CellPatternCell()
        {
            CellPatternCellId = @"rechiocdDSSkR1IFz",
            createdTime = DateTime.Parse("2020-11-26T20:44:04Z"),
            Cell = new string[] { @"recfSe8zeEdCAtcGq" },
            CellPattern = new string[] { @"recqn6vuQrx71nQii" },
            CellState = new string[] { @"recJAi8YoTOQmzhfH" },
            Name = @"TwoInARowMiddle:NoPlayer:MiddleRight",
            CellPatternType = @"PossibleWin",
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
            CellPatternType = @"Win",
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
            CellPatternType = @"PossibleWin",
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
            CellPatternType = @"PossibleWin",
            CellIndex = 1,
            CellStateId = 2,
            CellCellState = 12,
            CellName = @"Top",
            CellStateName = @"NoPlayer"
        };

        List.Add(TwoOutsideTopNoPlayerTop);
        ByEnum[CellPatternCellsEnum.TwoOutsideTopNoPlayerTop] = TwoOutsideTopNoPlayerTop;
        
            
        var Column1PlayerAMiddleLeft = new CellPatternCell()
        {
            CellPatternCellId = @"recmEXEqSbCsI5kUB",
            createdTime = DateTime.Parse("2020-12-12T00:48:31Z"),
            Cell = new string[] { @"recxIf3GoDzEtonFU" },
            CellPattern = new string[] { @"recJ1wDRP5taMg2Tj" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"Column1:PlayerA:MiddleLeft",
            CellPatternType = @"NamedSet",
            CellIndex = 3,
            CellStateId = 0,
            CellCellState = 30,
            CellName = @"MiddleLeft",
            CellStateName = @"PlayerA"
        };

        List.Add(Column1PlayerAMiddleLeft);
        ByEnum[CellPatternCellsEnum.Column1PlayerAMiddleLeft] = Column1PlayerAMiddleLeft;
        
            
        var Row3PlayerABottom = new CellPatternCell()
        {
            CellPatternCellId = @"recmHFemnt2tO9Q5u",
            createdTime = DateTime.Parse("2020-12-12T00:48:55Z"),
            Cell = new string[] { @"rec3OzG8nTAkUhjVn" },
            CellPattern = new string[] { @"recHqX6LLAZZAo1RQ" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"Row3:PlayerA:Bottom",
            CellPatternType = @"NamedSet",
            CellIndex = 7,
            CellStateId = 0,
            CellCellState = 70,
            CellName = @"Bottom",
            CellStateName = @"PlayerA"
        };

        List.Add(Row3PlayerABottom);
        ByEnum[CellPatternCellsEnum.Row3PlayerABottom] = Row3PlayerABottom;
        
            
        var Row2PlayerAMiddleLeft = new CellPatternCell()
        {
            CellPatternCellId = @"recpAYbzVjDRhc1L4",
            createdTime = DateTime.Parse("2020-12-12T00:45:41Z"),
            Cell = new string[] { @"recxIf3GoDzEtonFU" },
            CellPattern = new string[] { @"recqpmR7MAtp5afiM" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"Row2:PlayerA:MiddleLeft",
            CellPatternType = @"NamedSet",
            CellIndex = 3,
            CellStateId = 0,
            CellCellState = 30,
            CellName = @"MiddleLeft",
            CellStateName = @"PlayerA"
        };

        List.Add(Row2PlayerAMiddleLeft);
        ByEnum[CellPatternCellsEnum.Row2PlayerAMiddleLeft] = Row2PlayerAMiddleLeft;
        
            
        var DiagonalWinPlayerAMiddle = new CellPatternCell()
        {
            CellPatternCellId = @"recq7x7WkznTcTKS7",
            createdTime = DateTime.Parse("2020-12-18T20:43:31Z"),
            CellPattern = new string[] { @"recuenPSYKnW2WfOH" },
            Name = @"DiagonalWin:PlayerA:Middle",
            CellPatternType = @"Win",
            CellCellState = 40,
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            CellStateId = 0,
            CellStateName = @"PlayerA",
            Cell = new string[] { @"rec35HZOaRy6ge0jk" },
            CellIndex = 4,
            CellName = @"Middle"
        };

        List.Add(DiagonalWinPlayerAMiddle);
        ByEnum[CellPatternCellsEnum.DiagonalWinPlayerAMiddle] = DiagonalWinPlayerAMiddle;
        
            
        var RightLeftDiagonalPlayerATopRight = new CellPatternCell()
        {
            CellPatternCellId = @"recrfBGkdzZ67jeLa",
            createdTime = DateTime.Parse("2020-12-12T00:47:01Z"),
            Cell = new string[] { @"recTGnKjXTE8LfT3C" },
            CellPattern = new string[] { @"recWQyBlj7xHrYNPx" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"RightLeftDiagonal:PlayerA:TopRight",
            CellPatternType = @"NamedSet",
            CellIndex = 2,
            CellStateId = 0,
            CellCellState = 20,
            CellName = @"TopRight",
            CellStateName = @"PlayerA"
        };

        List.Add(RightLeftDiagonalPlayerATopRight);
        ByEnum[CellPatternCellsEnum.RightLeftDiagonalPlayerATopRight] = RightLeftDiagonalPlayerATopRight;
        
            
        var LeftRightDiagonalPlayerATopLeft = new CellPatternCell()
        {
            CellPatternCellId = @"recuKKiaqoaXhFxSC",
            createdTime = DateTime.Parse("2020-12-12T00:46:38Z"),
            Cell = new string[] { @"rec50MWM91QHzlEzO" },
            CellPattern = new string[] { @"reccf6U6b21xlIOh7" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"LeftRightDiagonal:PlayerA:TopLeft",
            CellPatternType = @"NamedSet",
            CellIndex = 0,
            CellStateId = 0,
            CellCellState = 00,
            CellName = @"TopLeft",
            CellStateName = @"PlayerA"
        };

        List.Add(LeftRightDiagonalPlayerATopLeft);
        ByEnum[CellPatternCellsEnum.LeftRightDiagonalPlayerATopLeft] = LeftRightDiagonalPlayerATopLeft;
        
            
        var Column3PlayerAMiddleRight = new CellPatternCell()
        {
            CellPatternCellId = @"recvjeyFh2sWFF8us",
            createdTime = DateTime.Parse("2020-12-12T00:48:43Z"),
            Cell = new string[] { @"recfSe8zeEdCAtcGq" },
            CellPattern = new string[] { @"recNW9KXsm9KvWa7B" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"Column3:PlayerA:MiddleRight",
            CellPatternType = @"NamedSet",
            CellIndex = 5,
            CellStateId = 0,
            CellCellState = 50,
            CellName = @"MiddleRight",
            CellStateName = @"PlayerA"
        };

        List.Add(Column3PlayerAMiddleRight);
        ByEnum[CellPatternCellsEnum.Column3PlayerAMiddleRight] = Column3PlayerAMiddleRight;
        
            
        var TwoInARowDiagonalPlayerAMiddle = new CellPatternCell()
        {
            CellPatternCellId = @"recwQ3ZI5MBVHPKgl",
            createdTime = DateTime.Parse("2020-11-26T20:43:44Z"),
            Cell = new string[] { @"rec35HZOaRy6ge0jk" },
            CellPattern = new string[] { @"recZCV8dlP1pNK9kK" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"TwoInARowDiagonal:PlayerA:Middle",
            CellPatternType = @"PossibleWin",
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
            CellPatternType = @"PossibleWin",
            CellIndex = 3,
            CellStateId = 0,
            CellCellState = 30,
            CellName = @"MiddleLeft",
            CellStateName = @"PlayerA"
        };

        List.Add(TwoInARowMiddlePlayerAMiddleLeft);
        ByEnum[CellPatternCellsEnum.TwoInARowMiddlePlayerAMiddleLeft] = TwoInARowMiddlePlayerAMiddleLeft;
        
            
        var Column2PlayerAMiddle = new CellPatternCell()
        {
            CellPatternCellId = @"recy5CwlzxHvsubBr",
            createdTime = DateTime.Parse("2020-12-12T00:48:40Z"),
            Cell = new string[] { @"rec35HZOaRy6ge0jk" },
            CellPattern = new string[] { @"recXBksm5DIUqOfDn" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"Column2:PlayerA:Middle",
            CellPatternType = @"NamedSet",
            CellIndex = 4,
            CellStateId = 0,
            CellCellState = 40,
            CellName = @"Middle",
            CellStateName = @"PlayerA"
        };

        List.Add(Column2PlayerAMiddle);
        ByEnum[CellPatternCellsEnum.Column2PlayerAMiddle] = Column2PlayerAMiddle;
        
            
        var TwoOutsideMiddlePlayerAMiddleLeft = new CellPatternCell()
        {
            CellPatternCellId = @"recyZobcdc9yOkGuC",
            createdTime = DateTime.Parse("2020-11-26T20:37:58Z"),
            Cell = new string[] { @"recxIf3GoDzEtonFU" },
            CellPattern = new string[] { @"recobCShOEyZjP8bY" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"TwoOutsideMiddle:PlayerA:MiddleLeft",
            CellPatternType = @"PossibleWin",
            CellIndex = 3,
            CellStateId = 0,
            CellCellState = 30,
            CellName = @"MiddleLeft",
            CellStateName = @"PlayerA"
        };

        List.Add(TwoOutsideMiddlePlayerAMiddleLeft);
        ByEnum[CellPatternCellsEnum.TwoOutsideMiddlePlayerAMiddleLeft] = TwoOutsideMiddlePlayerAMiddleLeft;
        
            
        var Column3PlayerABottomRight = new CellPatternCell()
        {
            CellPatternCellId = @"reczQDKs6sXAjFvhP",
            createdTime = DateTime.Parse("2020-12-12T00:48:43Z"),
            Cell = new string[] { @"recczW2Y4WMv9buZ8" },
            CellPattern = new string[] { @"recNW9KXsm9KvWa7B" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"Column3:PlayerA:BottomRight",
            CellPatternType = @"NamedSet",
            CellIndex = 8,
            CellStateId = 0,
            CellCellState = 80,
            CellName = @"BottomRight",
            CellStateName = @"PlayerA"
        };

        List.Add(Column3PlayerABottomRight);
        ByEnum[CellPatternCellsEnum.Column3PlayerABottomRight] = Column3PlayerABottomRight;
        
    }

}