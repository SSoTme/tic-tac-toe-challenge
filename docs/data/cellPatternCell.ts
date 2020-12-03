// Auto Generated Typescript Model interface

import { cellPattern } from "./cellPattern";
import { cell } from "./cell";
import { cellState } from "./cellState";

export interface cellPatternCell 
{
    CellPatternCellId : string;
    createdTime? : Date;
    Name? : string;
    CellCellState? : number;
    CellPattern? : string[];
    CellState? : string[];
    CellStateId? : number;
    CellStateName? : string;
    Cell? : string[];
    CellIndex? : number;
    CellName? : string;
    
    CellPatternCells_CellPatterns : cellPattern[];
    CellPatternCells_Cells : cell[];
    CellPatternCells_CellStates : cellState[];
    
}
