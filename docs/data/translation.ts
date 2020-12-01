// Auto Generated Typescript Model interface

import { cellPatternTranslation } from "./cellPatternTranslation";
import { cell } from "./cell";

export interface translation 
{
    TranslationId : string;
    createdTime? : Date;
    Name? : string;
    CustomDescription? : string;
    Id? : number;
    Cells? : string[];
    CellPatternTranslations? : string[];
    Description? : string;
    
    Translation_CellPatternTranslations : cellPatternTranslation[];
    RotateTranslation_Cells : cell[];
    
}
