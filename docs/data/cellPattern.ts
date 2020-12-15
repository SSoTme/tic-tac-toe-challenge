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
    CellPatternCells? : string[];
    CellPatternTranslations? : string[];
    TargetCell? : string[];
    TargetCellState? : string[];
    SortOrder? : number;
    CellPatternType? : string;
    IsWinPattern? : boolean;
    TargetCellIndex? : number;
    TargetCellStateId? : number;
    CellPatternTranslationCodes? : number[];
    Cells? : string;
    CellPatternCellStates? : number[];
    Target? : number;
    Translations? : string;
    CellPatternCelICellIndexes? : number[];
    CellPatternCellCells? : string[];
    CellPatternCellCellNames? : string[];
    TranslationNames? : string[];
    TargetDescription? : string;
    TargetCellName? : string;
    TargetCellStateName? : string;
    
    CellPattern_CellPatternTranslations : cellPatternTranslation[];
    CellPattern_CellPatternCells : cellPatternCell[];
    TargetCellForCellPatterns_Cells : cell[];
    NamedSetPatterns_Cells : cell[];
    CellPatterns_CellStates : cellState[];
    
}
