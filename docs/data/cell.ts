// Auto Generated Typescript Model interface

import { cellPattern } from "./cellPattern";
import { cellPatternCell } from "./cellPatternCell";
import { cell } from "./cell";
import { translation } from "./translation";
import { cellState } from "./cellState";

export interface cell 
{
    CellId : string;
    createdTime? : Date;
    Name? : string;
    Clockwise? : string[];
    CounterClockwise? : string[];
    Flip? : string[];
    SampleValue? : string;
    Description? : string;
    X? : number;
    Y? : number;
    RotateTranslation? : string[];
    CellIndex? : number;
    CellPatternCells? : string[];
    TargetCellForCellPatterns? : string[];
    CurrentCellState? : string[];
    DefaultCellState? : string[];
    CellKey? : number;
    IsDailyDouble? : boolean;
    AlexesNumber? : number;
    IsClockwise? : boolean;
    ClockwiseRotateFrom? : string;
    CounterClockwiseRotateFrom? : string;
    RotateFrom? : string;
    RotateDescription? : string;
    ClockwiseRotateFromIndex? : number;
    CounterClockwiseRotateFromIndex? : number;
    RotateIndex? : number;
    DefaultState? : string;
    CurrentState? : string;
    FlipIndex? : number;
    FlipFromName? : string;
    FlipDescription? : string;
    SortOrder? : number;
    NamedSetPatterns? : string[];
    IsInRow1? : number;
    IsInRow2? : number;
    IsInRow3? : number;
    IsInColumn1? : number;
    IsInColumn2? : number;
    IsInColumn3? : number;
    IsInLeftRightDiagonal? : number;
    IsInRightLeftDiagonal? : number;
    
    TargetCell_CellPatterns : cellPattern[];
    CellPatternCellCells_CellPatterns : cellPattern[];
    Cell_CellPatternCells : cellPatternCell[];
    Clockwise_Cells : cell[];
    CounterClockwise_Cells : cell[];
    Flip_Cells : cell[];
    Cells_Translations : translation[];
    CurrentStateCells_CellStates : cellState[];
    DefaultStateCells_CellStates : cellState[];
    
}
