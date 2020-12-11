// Auto Generated Typescript Model interface

import { aIStrategy } from "./aIStrategy";

export interface aILevel 
{
    AILevelId : string;
    createdTime? : Date;
    Name? : string;
    PlayerType? : string;
    MinAILevelIndex? : number;
    AILevelIndex? : number;
    Description? : string;
    SortOrder? : number;
    Users? : string[];
    AIStrategies? : string[];
    AIStrategyNames? : string;
    
    AILevels_AIStrategies : aIStrategy[];
    
}
