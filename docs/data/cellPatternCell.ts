// Auto Generated Typescript Model interface

import { cellPattern } from "./cellPattern";
import { cell } from "./cell";
import { cellState } from "./cellState";

export interface cellPatternCell 
{
    CellPatternCellId : string;
    createdTime? : Date;
    Cell? : string[];
    CellPattern? : string[];
    CellState? : string[];
    Name? : string;
    CellIndex? : number;
    CellStateId? : number;
    CellCellState? : number;
    
    CellPatternCells_CellPatterns : cellPattern[];
    CellPatternCells_Cells : cell[];
    CellPatternCells_CellStates : cellState[];
    
}
