// Auto Generated Typescript Model interface

import { aILevel } from "./aILevel";
import { cellPattern } from "./cellPattern";
import { translation } from "./translation";

export interface cellPatternTranslation 
{
    CellPatternTranslationId : string;
    createdTime? : Date;
    Name? : string;
    CPTCode? : number;
    CellPattern? : string[];
    CellPatternName? : string;
    Count? : number;
    Translation? : string[];
    TranslationId? : number;
    TranslationName? : string;
    SortOrder? : number;
    
    Users_AILevels : aILevel[];
    CellPatternTranslations_CellPatterns : cellPattern[];
    CellPatternTranslations_Translations : translation[];
    
}
