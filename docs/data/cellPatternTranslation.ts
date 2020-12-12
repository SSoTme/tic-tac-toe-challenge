// Auto Generated Typescript Model interface

import { aILevel } from "./aILevel";
import { cellPattern } from "./cellPattern";
import { translation } from "./translation";

export interface cellPatternTranslation 
{
    CellPatternTranslationId : string;
    createdTime? : Date;
    Translation? : string[];
    CellPattern? : string[];
    Count? : number;
    SortOrder? : number;
    Name? : string;
    TranslationId? : number;
    CPTCode? : number;
    CellPatternName? : string;
    TranslationName? : string;
    
    Users_AILevels : aILevel[];
    CellPatternTranslations_CellPatterns : cellPattern[];
    CellPatternTranslations_Translations : translation[];
    
}
