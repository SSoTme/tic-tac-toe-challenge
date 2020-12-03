// Auto Generated Typescript Model interface

import { cellPattern } from "./cellPattern";
import { cellPatternCell } from "./cellPatternCell";
import { cell } from "./cell";

export interface cellState 
{
    CellStateId : string;
    createdTime? : Date;
    Name? : string;
    Code? : string;
    Description? : string;
    Color? : string;
    DefaultMark? : string;
    Cursor? : string;
    SortOrder? : number;
    Id? : number;
    CellPatternCells? : string[];
    CurrentStateCells? : string[];
    FontColor? : string;
    CellPatterns? : string[];
    DefaultStateCells? : string[];
    
    TargetCellState_CellPatterns : cellPattern[];
    CellState_CellPatternCells : cellPatternCell[];
    CurrentCellState_Cells : cell[];
    DefaultCellState_Cells : cell[];
    
}
