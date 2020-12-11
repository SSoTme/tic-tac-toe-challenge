// Auto Generated Typescript Model interface

import { aILevel } from "./aILevel";

export interface aIStrategy 
{
    AIStrategyId : string;
    createdTime? : Date;
    Name? : string;
    Description? : string;
    PlayerLevel? : number;
    IsDefensive? : boolean;
    StrategyRank? : number;
    SortOrder? : number;
    AILevels? : string[];
    AILevelNames? : string;
    
    AIStrategies_AILevels : aILevel[];
    
}
