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
    CellPatterns? : string[];
    DefaultCellState? : string[];
    CellKey? : number;
    RotateDescription? : string;
    RotateIndex? : number;
    DefaultState? : string;
    CurrentState? : string;
    RotateFrom? : string;
    IsClockwise? : boolean;
    ClockwiseRotateFrom? : string;
    CounterClockwiseRotateFrom? : string;
    FlipFromName? : string;
    FlipIndex? : number;
    ClockwiseRotateFromIndex? : number;
    CounterClockwiseRotateFromIndex? : number;
    FlipDescription? : string;
    SortOrder? : number;
    CurrentCellState? : string[];
    
    TargetCell_CellPatterns : cellPattern[];
    Cell_CellPatternCells : cellPatternCell[];
    Clockwise_Cells : cell[];
    CounterClockwise_Cells : cell[];
    Flip_Cells : cell[];
    Cells_Translations : translation[];
    CurrentStateCells_CellStates : cellState[];
    DefaultStateCells_CellStates : cellState[];
    
}
