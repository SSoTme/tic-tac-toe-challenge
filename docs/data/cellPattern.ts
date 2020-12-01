// Auto Generated Typescript Model interface

import { cellPatternTranslation } from "./cellPatternTranslation";
import { cellPatternCell } from "./cellPatternCell";
import { cell } from "./cell";
import { cellState } from "./cellState";

export interface cellPattern 
{
    CellPatternId : string;
    createdTime? : Date;
    Name? : string;
    Description? : string;
    IsWinPattern? : boolean;
    CellPatternCells? : string[];
    CellPatternTranslations? : string[];
    TargetCell? : string[];
    TargetCellState? : string[];
    SortOrder? : number;
    TargetCellIndex? : number;
    TargetCellStateId? : number;
    CellPatternTranslationCodes? : number[];
    Cells? : string;
    CellPatternCellStates? : number[];
    Target? : number;
    Translations? : string;
    
    CellPattern_CellPatternTranslations : cellPatternTranslation[];
    CellPattern_CellPatternCells : cellPatternCell[];
    CellPatterns_Cells : cell[];
    CellPatterns_CellStates : cellState[];
    
}
