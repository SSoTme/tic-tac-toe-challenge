using System;
using System.Linq;
using TicTacToeChallenge.Lib.DataClasses;

public static partial class CellPatternCells
{
    private static void InitCellPatternCells()
    {
        // setup each one... <Airtable><Entities><Entity><EntityId>rec5CTsiJR6Xdxslf</EntityId><createdTime>2020-11-26T21:15:34Z</createdTime><Name>CellPatternTranslation</Name><PluralName>CellPatternTranslations</PluralName><AirtableName>CellPatternTranslations</AirtableName></Entity><Entity><EntityId>recAWOgja5ZyIFuQp</EntityId><createdTime>2020-11-26T21:14:31Z</createdTime><Name>LanguageToken</Name><PluralName>LanguageTokens</PluralName><AirtableName>LanguageTokens</AirtableName></Entity><Entity><EntityId>recBFSJ9xt8TSaDcs</EntityId><createdTime>2020-11-26T21:14:31Z</createdTime><Name>AILevel</Name><PluralName>AILevels</PluralName><AirtableName>AILevels</AirtableName></Entity><Entity><EntityId>recE60WOJMdkFz521</EntityId><createdTime>2020-11-26T21:15:27Z</createdTime><Name>CellPattern</Name><PluralName>CellPatterns</PluralName><AirtableName>CellPatterns</AirtableName></Entity><Entity><EntityId>recMjqgnvie3zkeqL</EntityId><createdTime>2020-11-26T21:14:31Z</createdTime><Name>AIStrategy</Name><PluralName>AIStrategies</PluralName><AirtableName>AIStrategies</AirtableName></Entity><Entity><EntityId>recNJ6QD2b3l7yodW</EntityId><createdTime>2020-11-26T21:15:27Z</createdTime><Name>CellPatternCell</Name><PluralName>CellPatternCells</PluralName><AirtableName>CellPatternCells</AirtableName></Entity><Entity><EntityId>recOshv4aBOtAhL9c</EntityId><createdTime>2020-11-26T21:15:27Z</createdTime><Name>Cell</Name><PluralName>Cells</PluralName><AirtableName>Cells</AirtableName></Entity><Entity><EntityId>recQMV5zL3kK2ZJu3</EntityId><createdTime>2020-11-26T21:15:47Z</createdTime><Name>TargetPlatform</Name><PluralName>TargetPlatforms</PluralName><AirtableName>TargetPlatforms</AirtableName></Entity><Entity><EntityId>recXLMGfF7EPE8afM</EntityId><createdTime>2020-11-26T21:16:17Z</createdTime><Name>AdditionalResource</Name><PluralName>AdditionalResources</PluralName><AirtableName>Additional Resources</AirtableName></Entity><Entity><EntityId>recg2BWutwt40yMpU</EntityId><createdTime>2020-11-26T21:15:20Z</createdTime><Name>Translation</Name><PluralName>Translations</PluralName><AirtableName>Translations</AirtableName></Entity><Entity><EntityId>recr7hRnb8KeiqDEb</EntityId><createdTime>2020-11-26T21:15:54Z</createdTime><Name>GlobalSetting</Name><PluralName>GlobalSettings</PluralName><AirtableName>Global Settings</AirtableName></Entity><Entity><EntityId>recvjej0ICJm2Z1El</EntityId><createdTime>2020-11-26T21:15:20Z</createdTime><Name>CellState</Name><PluralName>CellStates</PluralName><AirtableName>CellStates</AirtableName></Entity></Entities><CellPatternTranslations><CellPatternTranslation><CellPatternTranslationId>rec9PRnE4xpUCcMit</CellPatternTranslationId><createdTime>2020-11-26T20:39:35Z</createdTime><Translation>recgdoYW4iJ8gaAha</Translation><CellPattern>recZCV8dlP1pNK9kK</CellPattern><Count>3</Count><SortOrder>1</SortOrder><Name>T1-TwoInARowDiagonal:Rotate:3</Name><CellPatternName>TwoInARowDiagonal</CellPatternName><TranslationName>Rotate</TranslationName><TranslationId>0</TranslationId><CPTCode>30</CPTCode></CellPatternTranslation><CellPatternTranslation><CellPatternTranslationId>recD87U0swUjjhnTj</CellPatternTranslationId><createdTime>2020-11-26T20:39:24Z</createdTime><Translation>recgdoYW4iJ8gaAha</Translation><CellPattern>recBDK2nzNlGSJNgJ</CellPattern><Count>3</Count><SortOrder>1</SortOrder><Name>T1-EdgeWin:Rotate:3</Name><CellPatternName>EdgeWin</CellPatternName><TranslationName>Rotate</TranslationName><TranslationId>0</TranslationId><CPTCode>30</CPTCode></CellPatternTranslation><CellPatternTranslation><CellPatternTranslationId>recJjgKw24kaBFH0i</CellPatternTranslationId><createdTime>2020-11-26T20:39:35Z</createdTime><Translation>recgdoYW4iJ8gaAha</Translation><CellPattern>recqn6vuQrx71nQii</CellPattern><Count>3</Count><SortOrder>1</SortOrder><Name>T1-TwoInARowMiddle:Rotate:3</Name><CellPatternName>TwoInARowMiddle</CellPatternName><TranslationName>Rotate</TranslationName><TranslationId>0</TranslationId><CPTCode>30</CPTCode></CellPatternTranslation><CellPatternTranslation><CellPatternTranslationId>recNz0LuN77HIXjmB</CellPatternTranslationId><createdTime>2020-11-26T20:39:35Z</createdTime><Translation>recgdoYW4iJ8gaAha</Translation><CellPattern>recodVK2HKbzC26Db</CellPattern><Count>1</Count><SortOrder>1</SortOrder><Name>T1-MiddleWin:Rotate:1</Name><CellPatternName>MiddleWin</CellPatternName><TranslationName>Rotate</TranslationName><TranslationId>0</TranslationId><CPTCode>10</CPTCode></CellPatternTranslation><CellPatternTranslation><CellPatternTranslationId>recUD9c7vXgkNLQi9</CellPatternTranslationId><createdTime>2020-11-26T21:13:00Z</createdTime><Translation>recgdoYW4iJ8gaAha</Translation><CellPattern>rec55PqGhtUYK5Rcb</CellPattern><Count>3</Count><SortOrder>3</SortOrder><Name>T3-TwoInARowTop:Rotate:3</Name><CellPatternName>TwoInARowTop</CellPatternName><TranslationName>Rotate</TranslationName><TranslationId>0</TranslationId><CPTCode>30</CPTCode></CellPatternTranslation><CellPatternTranslation><CellPatternTranslationId>recafoRwqvCh5HZOd</CellPatternTranslationId><createdTime>2020-11-26T20:39:35Z</createdTime><Translation>recgdoYW4iJ8gaAha</Translation><CellPattern>recobCShOEyZjP8bY</CellPattern><Count>1</Count><SortOrder>1</SortOrder><Name>T1-TwoOutsideMiddle:Rotate:1</Name><CellPatternName>TwoOutsideMiddle</CellPatternName><TranslationName>Rotate</TranslationName><TranslationId>0</TranslationId><CPTCode>10</CPTCode></CellPatternTranslation><CellPatternTranslation><CellPatternTranslationId>recoPtQQ8QZtClJK0</CellPatternTranslationId><createdTime>2020-11-26T20:39:35Z</createdTime><Translation>recgdoYW4iJ8gaAha</Translation><CellPattern>recg1ttw7l3n96PDG</CellPattern><Count>1</Count><SortOrder>1</SortOrder><Name>T1-TwoOutsideDiagonal:Rotate:1</Name><CellPatternName>TwoOutsideDiagonal</CellPatternName><TranslationName>Rotate</TranslationName><TranslationId>0</TranslationId><CPTCode>10</CPTCode></CellPatternTranslation><CellPatternTranslation><CellPatternTranslationId>recqJB1goFBhhsIVZ</CellPatternTranslationId><createdTime>2020-11-26T20:39:35Z</createdTime><Translation>recgdoYW4iJ8gaAha</Translation><CellPattern>rec55PqGhtUYK5Rcb</CellPattern><Count>3</Count><SortOrder>1</SortOrder><Name>T1-TwoInARowTop:Rotate:3</Name><CellPatternName>TwoInARowTop</CellPatternName><TranslationName>Rotate</TranslationName><TranslationId>0</TranslationId><CPTCode>30</CPTCode></CellPatternTranslation><CellPatternTranslation><CellPatternTranslationId>recwuYqQZ0iCw2WfQ</CellPatternTranslationId><createdTime>2020-11-26T21:11:07Z</createdTime><Translation>recQ0PgyWBky0wm32</Translation><CellPattern>rec55PqGhtUYK5Rcb</CellPattern><Count>1</Count><SortOrder>2</SortOrder><Name>T2-TwoInARowTop:Flip:1</Name><CellPatternName>TwoInARowTop</CellPatternName><TranslationName>Flip</TranslationName><TranslationId>1</TranslationId><CPTCode>11</CPTCode></CellPatternTranslation><CellPatternTranslation><CellPatternTranslationId>reczr6h68ZUdkDIZb</CellPatternTranslationId><createdTime>2020-11-26T20:39:35Z</createdTime><Translation>recgdoYW4iJ8gaAha</Translation><CellPattern>recYmKv2dBpnAA1gs</CellPattern><Count>3</Count><SortOrder>1</SortOrder><Name>T1-TwoOutsideTop:Rotate:3</Name><CellPatternName>TwoOutsideTop</CellPatternName><TranslationName>Rotate</TranslationName><TranslationId>0</TranslationId><CPTCode>30</CPTCode></CellPatternTranslation></CellPatternTranslations><LanguageTokens><LanguageToken><LanguageTokenId>rec1au6Wnbaf3oO1u</LanguageTokenId><createdTime>2020-11-26T20:01:30Z</createdTime><Name>GameOver</Name><DisplayName>Game Over</DisplayName><SortOrder>3</SortOrder><Token>GameOver</Token></LanguageToken><LanguageToken><LanguageTokenId>recFy1FsoP1ORWYWj</LanguageTokenId><createdTime>2020-11-26T20:01:30Z</createdTime><Name>YourTurn</Name><DisplayName>It's your turn</DisplayName><SortOrder>4</SortOrder><Token>YourTurn</Token></LanguageToken><LanguageToken><LanguageTokenId>recNnnObNV1wEGXUI</LanguageTokenId><createdTime>2020-11-26T20:01:30Z</createdTime><Name>Title</Name><DisplayName>Suzanne's Tic Tac Toe</DisplayName><SortOrder>1</SortOrder><Token>Title</Token></LanguageToken><LanguageToken><LanguageTokenId>recOqDsQXph2jV645</LanguageTokenId><createdTime>2020-11-26T20:01:30Z</createdTime><Name>TheyWon</Name><DisplayName>Loser</DisplayName><SortOrder>7</SortOrder><Token>TheyWon</Token></LanguageToken><LanguageToken><LanguageTokenId>recPamDrUmmMfoUtj</LanguageTokenId><createdTime>2020-11-26T20:01:30Z</createdTime><Name>YouWon</Name><DisplayName>Winner</DisplayName><SortOrder>6</SortOrder><Token>YouWon</Token></LanguageToken><LanguageToken><LanguageTokenId>recTxNSWmH6qLLtgj</LanguageTokenId><createdTime>2020-11-26T20:01:30Z</createdTime><Name>GameOn</Name><DisplayName>Game On</DisplayName><SortOrder>2</SortOrder><Token>GameOn</Token></LanguageToken><LanguageToken><LanguageTokenId>recdK8VdwOgWPXEf4</LanguageTokenId><createdTime>2020-11-26T20:01:30Z</createdTime><Name>TheirTurn</Name><DisplayName>It's their turn</DisplayName><SortOrder>5</SortOrder><Token>TheirTurn</Token></LanguageToken></LanguageTokens><AILevels><AILevel><AILevelId>rec6OhVu8y6RKPscT</AILevelId><createdTime>2020-11-26T20:02:01Z</createdTime><Name>Advanced</Name><PlayerType>SimpleRules</PlayerType><MinAILevelIndex>0</MinAILevelIndex><AILevelIndex>3</AILevelIndex><Description>The best - all strategies are employed.  This AI should never lose.  It will only win if the opponent makes a mistake, but otherwise, it at least tie.</Description><SortOrder>3</SortOrder></AILevel><AILevel><AILevelId>recPPp5z8K4EAA2FW</AILevelId><createdTime>2020-11-26T20:02:01Z</createdTime><Name>Intermediate</Name><PlayerType>SimpleRules</PlayerType><MinAILevelIndex>0</MinAILevelIndex><AILevelIndex>2</AILevelIndex><Description>This guy's pretty good - but not the best</Description><SortOrder>2</SortOrder></AILevel><AILevel><AILevelId>recmMBaevl2jHl0hC</AILevelId><createdTime>2020-11-26T20:02:01Z</createdTime><Name>Beginner</Name><PlayerType>SimpleRules</PlayerType><MinAILevelIndex>0</MinAILevelIndex><AILevelIndex>1</AILevelIndex><Description>Wins, prevents a win or plays randomly.</Description><SortOrder>1</SortOrder></AILevel></AILevels><CellPatterns><CellPattern><CellPatternId>rec55PqGhtUYK5Rcb</CellPatternId><createdTime>2020-11-26T20:06:43Z</createdTime><Name>TwoInARowTop</Name><Description>Two marks top left, top middle with top right empty - and then a full rotation/flip scheme.</Description><CellPatternCells>recclaJuN3LJWLC4N</CellPatternCells><CellPatternCells>recFITGoLxBQs1ocD</CellPatternCells><CellPatternCells>reccnHG0Yfk8tgTt6</CellPatternCells><CellPatternTranslations>recqJB1goFBhhsIVZ</CellPatternTranslations><CellPatternTranslations>recwuYqQZ0iCw2WfQ</CellPatternTranslations><CellPatternTranslations>recUD9c7vXgkNLQi9</CellPatternTranslations><TargetCell>recTGnKjXTE8LfT3C</TargetCell><TargetCellState>recJAi8YoTOQmzhfH</TargetCellState><SortOrder>3</SortOrder><TargetCellIndex>2</TargetCellIndex><TargetCellStateId>2</TargetCellStateId><CellPatternTranslationCodes>30</CellPatternTranslationCodes><CellPatternTranslationCodes>11</CellPatternTranslationCodes><CellPatternTranslationCodes>30</CellPatternTranslationCodes><Cells>00;10;22</Cells><CellPatternCellStates>00</CellPatternCellStates><CellPatternCellStates>10</CellPatternCellStates><CellPatternCellStates>22</CellPatternCellStates><Target>22</Target><Translations>30;11;30</Translations></CellPattern><CellPattern><CellPatternId>recBDK2nzNlGSJNgJ</CellPatternId><createdTime>2020-11-26T20:06:43Z</createdTime><Name>EdgeWin</Name><Description>Starting with the top row, 3 additional rotates will find all edge wins.</Description><IsWinPattern>true</IsWinPattern><CellPatternCells>recU9O3yxyMeQ1eU4</CellPatternCells><CellPatternCells>recf1uu1YY0iPps8E</CellPatternCells><CellPatternCells>recPHA9ppFH8cjenC</CellPatternCells><CellPatternTranslations>recD87U0swUjjhnTj</CellPatternTranslations><SortOrder>1</SortOrder><CellPatternTranslationCodes>30</CellPatternTranslationCodes><Cells>00;10;20</Cells><CellPatternCellStates>00</CellPatternCellStates><CellPatternCellStates>10</CellPatternCellStates><CellPatternCellStates>20</CellPatternCellStates><Translations>30</Translations></CellPattern><CellPattern><CellPatternId>recYmKv2dBpnAA1gs</CellPatternId><createdTime>2020-11-26T20:06:43Z</createdTime><Name>TwoOutsideTop</Name><Description>Top left and top right filled, middle empty - finds all positions with 3 rotations.</Description><CellPatternCells>recKj18pU9k6V6MAx</CellPatternCells><CellPatternCells>recljMfqekOodaaWx</CellPatternCells><CellPatternCells>rec8bt4pVcy9OY8XO</CellPatternCells><CellPatternTranslations>reczr6h68ZUdkDIZb</CellPatternTranslations><TargetCell>recpPYOZtnp3lTOua</TargetCell><TargetCellState>recJAi8YoTOQmzhfH</TargetCellState><SortOrder>6</SortOrder><TargetCellIndex>1</TargetCellIndex><TargetCellStateId>2</TargetCellStateId><CellPatternTranslationCodes>30</CellPatternTranslationCodes><Cells>00;12;20</Cells><CellPatternCellStates>00</CellPatternCellStates><CellPatternCellStates>12</CellPatternCellStates><CellPatternCellStates>20</CellPatternCellStates><Target>12</Target><Translations>30</Translations></CellPattern><CellPattern><CellPatternId>recZCV8dlP1pNK9kK</CellPatternId><createdTime>2020-11-26T20:06:43Z</createdTime><Name>TwoInARowDiagonal</Name><Description>Two in a row on the diagonal, with the third cell empty - finds all positions with 3 rotations.</Description><CellPatternCells>rec91aKNdkT2cw93v</CellPatternCells><CellPatternCells>recwQ3ZI5MBVHPKgl</CellPatternCells><CellPatternCells>rec5D3fwk2h5GzjIB</CellPatternCells><CellPatternTranslations>rec9PRnE4xpUCcMit</CellPatternTranslations><TargetCell>recczW2Y4WMv9buZ8</TargetCell><TargetCellState>recJAi8YoTOQmzhfH</TargetCellState><SortOrder>5</SortOrder><TargetCellIndex>8</TargetCellIndex><TargetCellStateId>2</TargetCellStateId><CellPatternTranslationCodes>30</CellPatternTranslationCodes><Cells>00;40;82</Cells><CellPatternCellStates>00</CellPatternCellStates><CellPatternCellStates>40</CellPatternCellStates><CellPatternCellStates>82</CellPatternCellStates><Target>82</Target><Translations>30</Translations></CellPattern><CellPattern><CellPatternId>recg1ttw7l3n96PDG</CellPatternId><createdTime>2020-11-26T20:06:43Z</createdTime><Name>TwoOutsideDiagonal</Name><Description>Top left and bottom right with middle empty  - 1 rotation finds the one variation of the starting pattern.</Description><CellPatternCells>recYR4cE90EOVnYD5</CellPatternCells><CellPatternCells>recWoh5Qk0b1xBV67</CellPatternCells><CellPatternCells>reclDV8jky7y1JNzH</CellPatternCells><CellPatternTranslations>recoPtQQ8QZtClJK0</CellPatternTranslations><TargetCell>rec35HZOaRy6ge0jk</TargetCell><TargetCellState>recJAi8YoTOQmzhfH</TargetCellState><SortOrder>8</SortOrder><TargetCellIndex>4</TargetCellIndex><TargetCellStateId>2</TargetCellStateId><CellPatternTranslationCodes>10</CellPatternTranslationCodes><Cells>00;42;80</Cells><CellPatternCellStates>00</CellPatternCellStates><CellPatternCellStates>42</CellPatternCellStates><CellPatternCellStates>80</CellPatternCellStates><Target>42</Target><Translations>10</Translations></CellPattern><CellPattern><CellPatternId>recobCShOEyZjP8bY</CellPatternId><createdTime>2020-11-26T20:06:43Z</createdTime><Name>TwoOutsideMiddle</Name><Description>Middle left and right, center empty - 1 rotation finds the one variation of the starting pattern.</Description><CellPatternCells>recyZobcdc9yOkGuC</CellPatternCells><CellPatternCells>recaPLycHtpRQfWnE</CellPatternCells><CellPatternCells>rec6RGGCG5ORVBnA3</CellPatternCells><CellPatternTranslations>recafoRwqvCh5HZOd</CellPatternTranslations><TargetCell>rec35HZOaRy6ge0jk</TargetCell><TargetCellState>recJAi8YoTOQmzhfH</TargetCellState><SortOrder>7</SortOrder><TargetCellIndex>4</TargetCellIndex><TargetCellStateId>2</TargetCellStateId><CellPatternTranslationCodes>10</CellPatternTranslationCodes><Cells>30;42;50</Cells><CellPatternCellStates>30</CellPatternCellStates><CellPatternCellStates>42</CellPatternCellStates><CellPatternCellStates>50</CellPatternCellStates><Target>42</Target><Translations>10</Translations></CellPattern><CellPattern><CellPatternId>recodVK2HKbzC26Db</CellPatternId><createdTime>2020-11-26T20:06:43Z</createdTime><Name>MiddleWin</Name><Description>Starting with the middle row selected, a single rotations finds both middle wins</Description><IsWinPattern>true</IsWinPattern><CellPatternCells>reckcKNNnyDSWpFrH</CellPatternCells><CellPatternCells>recGP80BxFCLlmgw7</CellPatternCells><CellPatternCells>recAy4XNSSKRZGZsh</CellPatternCells><CellPatternTranslations>recNz0LuN77HIXjmB</CellPatternTranslations><SortOrder>2</SortOrder><CellPatternTranslationCodes>10</CellPatternTranslationCodes><Cells>30;40;50</Cells><CellPatternCellStates>30</CellPatternCellStates><CellPatternCellStates>40</CellPatternCellStates><CellPatternCellStates>50</CellPatternCellStates><Translations>10</Translations></CellPattern><CellPattern><CellPatternId>recqn6vuQrx71nQii</CellPatternId><createdTime>2020-11-26T20:06:43Z</createdTime><Name>TwoInARowMiddle</Name><Description>Two in a row on the middle row, right side empty - finds all positions with 3 rotations.</Description><CellPatternCells>recxWA16nieZY83Sv</CellPatternCells><CellPatternCells>recPmKMMNhYSxBWJ0</CellPatternCells><CellPatternCells>rechiocdDSSkR1IFz</CellPatternCells><CellPatternTranslations>recJjgKw24kaBFH0i</CellPatternTranslations><TargetCell>recfSe8zeEdCAtcGq</TargetCell><TargetCellState>recJAi8YoTOQmzhfH</TargetCellState><SortOrder>4</SortOrder><TargetCellIndex>5</TargetCellIndex><TargetCellStateId>2</TargetCellStateId><CellPatternTranslationCodes>30</CellPatternTranslationCodes><Cells>30;40;52</Cells><CellPatternCellStates>30</CellPatternCellStates><CellPatternCellStates>40</CellPatternCellStates><CellPatternCellStates>52</CellPatternCellStates><Target>52</Target><Translations>30</Translations></CellPattern></CellPatterns><AIStrategies><AIStrategy><AIStrategyId>rec9YSojkIl2F85fV</AIStrategyId><createdTime>2020-11-26T20:02:26Z</createdTime><Name>PreventWinIfPossible</Name><Description>Prevent opponent from using WinIfPossible strategy</Description><PlayerLevel>2</PlayerLevel><IsDefensive>true</IsDefensive><StrategyRank>2</StrategyRank><SortOrder>5</SortOrder></AIStrategy><AIStrategy><AIStrategyId>recGEVGA3ajKMQ2kD</AIStrategyId><createdTime>2020-11-26T20:02:26Z</createdTime><Name>ForceWinNextTurn</Name><Description>Check for a move that will force a win the next turn, regardless of what the opponent does.</Description><PlayerLevel>2</PlayerLevel><IsDefensive>false</IsDefensive><StrategyRank>3</StrategyRank><SortOrder>6</SortOrder></AIStrategy><AIStrategy><AIStrategyId>recMqBdImRECSijls</AIStrategyId><createdTime>2020-11-26T20:02:26Z</createdTime><Name>PreventForceWinNextTurn</Name><Description>Prevent opponent from using ForceWinNextTurn strategy</Description><PlayerLevel>2</PlayerLevel><IsDefensive>true</IsDefensive><StrategyRank>4</StrategyRank><SortOrder>7</SortOrder></AIStrategy><AIStrategy><AIStrategyId>recQQG2R7vnRDgWNW</AIStrategyId><createdTime>2020-11-26T20:02:26Z</createdTime><Name>WaitsForInstruction</Name><Description>Plays as proxy for a human.  A UI is needed to communicate the human's intentions.</Description><PlayerLevel>-1</PlayerLevel><StrategyRank>1</StrategyRank><SortOrder>1</SortOrder></AIStrategy><AIStrategy><AIStrategyId>recZDBLLFUvFztYzW</AIStrategyId><createdTime>2020-11-26T20:02:26Z</createdTime><Name>PlayInMiddleIfAvailable</Name><Description>If there are no other winning strategies, play in the middle cell</Description><PlayerLevel>1</PlayerLevel><StrategyRank>90</StrategyRank><SortOrder>3</SortOrder></AIStrategy><AIStrategy><AIStrategyId>reca1n3gYdwjbxrcn</AIStrategyId><createdTime>2020-11-26T20:02:26Z</createdTime><Name>Random</Name><Description>Choice from a random selection amongst available cells</Description><PlayerLevel>0</PlayerLevel><StrategyRank>100</StrategyRank><SortOrder>2</SortOrder></AIStrategy><AIStrategy><AIStrategyId>reccQN2uoTvoIlAQR</AIStrategyId><createdTime>2020-11-26T20:02:26Z</createdTime><Name>LearnFromMistakes</Name><Description>Plays randomly, but keeps track of what moves are made, and learn from mistakes</Description><PlayerLevel>8</PlayerLevel><StrategyRank>200</StrategyRank><SortOrder>11</SortOrder></AIStrategy><AIStrategy><AIStrategyId>reclttwLO9tNIHGlo</AIStrategyId><createdTime>2020-11-26T20:02:26Z</createdTime><Name>PlayInCornerIfAvailable</Name><Description>If there are any corner positions available, player there</Description><PlayerLevel>2</PlayerLevel><StrategyRank>95</StrategyRank><SortOrder>8</SortOrder></AIStrategy><AIStrategy><AIStrategyId>recuWctNLBYnhhsgj</AIStrategyId><createdTime>2020-11-26T20:02:26Z</createdTime><Name>PreventSetupForceWinNextTurn</Name><Description>Prevent opponent from using SetupForceWinNextTurn strategy</Description><PlayerLevel>3</PlayerLevel><IsDefensive>true</IsDefensive><StrategyRank>6</StrategyRank><SortOrder>10</SortOrder></AIStrategy><AIStrategy><AIStrategyId>recx2tCavviw3I7It</AIStrategyId><createdTime>2020-11-26T20:02:26Z</createdTime><Name>SetupForceWinNextTurn</Name><Description>Check if there's a move which will allow a force win next turn.</Description><PlayerLevel>3</PlayerLevel><IsDefensive>false</IsDefensive><StrategyRank>5</StrategyRank><SortOrder>9</SortOrder></AIStrategy><AIStrategy><AIStrategyId>recyOJc1noL5zIhmx</AIStrategyId><createdTime>2020-11-26T20:02:26Z</createdTime><Name>WinIfPossible</Name><Description>If any two cells are already filled in by the AI, and the 3rd cell in that row is available, play there.</Description><PlayerLevel>1</PlayerLevel><IsDefensive>false</IsDefensive><StrategyRank>1</StrategyRank><SortOrder>4</SortOrder></AIStrategy></AIStrategies><CellPatternCells><CellPatternCell><CellPatternCellId>rec5D3fwk2h5GzjIB</CellPatternCellId><createdTime>2020-11-26T20:43:48Z</createdTime><Cell>recczW2Y4WMv9buZ8</Cell><CellPattern>recZCV8dlP1pNK9kK</CellPattern><CellState>recJAi8YoTOQmzhfH</CellState><Name>TwoInARowDiagonal:NoPlayer:BottomRight</Name><CellIndex>8</CellIndex><CellStateId>2</CellStateId><CellCellState>82</CellCellState><CellName>BottomRight</CellName><CellStateName>NoPlayer</CellStateName></CellPatternCell><CellPatternCell><CellPatternCellId>rec6RGGCG5ORVBnA3</CellPatternCellId><createdTime>2020-11-26T20:44:11Z</createdTime><Cell>recfSe8zeEdCAtcGq</Cell><CellPattern>recobCShOEyZjP8bY</CellPattern><CellState>rec0xQjo4VL3DFTXg</CellState><Name>TwoOutsideMiddle:PlayerA:MiddleRight</Name><CellIndex>5</CellIndex><CellStateId>0</CellStateId><CellCellState>50</CellCellState><CellName>MiddleRight</CellName><CellStateName>PlayerA</CellStateName></CellPatternCell><CellPatternCell><CellPatternCellId>rec8bt4pVcy9OY8XO</CellPatternCellId><createdTime>2020-11-26T20:44:14Z</createdTime><Cell>recTGnKjXTE8LfT3C</Cell><CellPattern>recYmKv2dBpnAA1gs</CellPattern><CellState>rec0xQjo4VL3DFTXg</CellState><Name>TwoOutsideTop:PlayerA:TopRight</Name><CellIndex>2</CellIndex><CellStateId>0</CellStateId><CellCellState>20</CellCellState><CellName>TopRight</CellName><CellStateName>PlayerA</CellStateName></CellPatternCell><CellPatternCell><CellPatternCellId>rec91aKNdkT2cw93v</CellPatternCellId><createdTime>2020-11-26T20:37:58Z</createdTime><Cell>rec50MWM91QHzlEzO</Cell><CellPattern>recZCV8dlP1pNK9kK</CellPattern><CellState>rec0xQjo4VL3DFTXg</CellState><Name>TwoInARowDiagonal:PlayerA:TopLeft</Name><CellIndex>0</CellIndex><CellStateId>0</CellStateId><CellCellState>00</CellCellState><CellName>TopLeft</CellName><CellStateName>PlayerA</CellStateName></CellPatternCell><CellPatternCell><CellPatternCellId>recAy4XNSSKRZGZsh</CellPatternCellId><createdTime>2020-11-26T20:42:02Z</createdTime><Cell>recfSe8zeEdCAtcGq</Cell><CellPattern>recodVK2HKbzC26Db</CellPattern><CellState>rec0xQjo4VL3DFTXg</CellState><Name>MiddleWin:PlayerA:MiddleRight</Name><CellIndex>5</CellIndex><CellStateId>0</CellStateId><CellCellState>50</CellCellState><CellName>MiddleRight</CellName><CellStateName>PlayerA</CellStateName></CellPatternCell><CellPatternCell><CellPatternCellId>recFITGoLxBQs1ocD</CellPatternCellId><createdTime>2020-11-26T20:44:06Z</createdTime><Cell>recpPYOZtnp3lTOua</Cell><CellPattern>rec55PqGhtUYK5Rcb</CellPattern><CellState>rec0xQjo4VL3DFTXg</CellState><Name>TwoInARowTop:PlayerA:Top</Name><CellIndex>1</CellIndex><CellStateId>0</CellStateId><CellCellState>10</CellCellState><CellName>Top</CellName><CellStateName>PlayerA</CellStateName></CellPatternCell><CellPatternCell><CellPatternCellId>recGP80BxFCLlmgw7</CellPatternCellId><createdTime>2020-11-26T20:41:59Z</createdTime><Cell>rec35HZOaRy6ge0jk</Cell><CellPattern>recodVK2HKbzC26Db</CellPattern><CellState>rec0xQjo4VL3DFTXg</CellState><Name>MiddleWin:PlayerA:Middle</Name><CellIndex>4</CellIndex><CellStateId>0</CellStateId><CellCellState>40</CellCellState><CellName>Middle</CellName><CellStateName>PlayerA</CellStateName></CellPatternCell><CellPatternCell><CellPatternCellId>recKj18pU9k6V6MAx</CellPatternCellId><createdTime>2020-11-26T20:37:58Z</createdTime><Cell>rec50MWM91QHzlEzO</Cell><CellPattern>recYmKv2dBpnAA1gs</CellPattern><CellState>rec0xQjo4VL3DFTXg</CellState><Name>TwoOutsideTop:PlayerA:TopLeft</Name><CellIndex>0</CellIndex><CellStateId>0</CellStateId><CellCellState>00</CellCellState><CellName>TopLeft</CellName><CellStateName>PlayerA</CellStateName></CellPatternCell><CellPatternCell><CellPatternCellId>recPHA9ppFH8cjenC</CellPatternCellId><createdTime>2020-11-26T20:38:15Z</createdTime><Cell>recTGnKjXTE8LfT3C</Cell><CellPattern>recBDK2nzNlGSJNgJ</CellPattern><CellState>rec0xQjo4VL3DFTXg</CellState><Name>EdgeWin:PlayerA:TopRight</Name><CellIndex>2</CellIndex><CellStateId>0</CellStateId><CellCellState>20</CellCellState><CellName>TopRight</CellName><CellStateName>PlayerA</CellStateName></CellPatternCell><CellPatternCell><CellPatternCellId>recPmKMMNhYSxBWJ0</CellPatternCellId><createdTime>2020-11-26T20:44:04Z</createdTime><Cell>rec35HZOaRy6ge0jk</Cell><CellPattern>recqn6vuQrx71nQii</CellPattern><CellState>rec0xQjo4VL3DFTXg</CellState><Name>TwoInARowMiddle:PlayerA:Middle</Name><CellIndex>4</CellIndex><CellStateId>0</CellStateId><CellCellState>40</CellCellState><CellName>Middle</CellName><CellStateName>PlayerA</CellStateName></CellPatternCell><CellPatternCell><CellPatternCellId>recU9O3yxyMeQ1eU4</CellPatternCellId><createdTime>2020-11-26T20:35:31Z</createdTime><Cell>rec50MWM91QHzlEzO</Cell><CellPattern>recBDK2nzNlGSJNgJ</CellPattern><CellState>rec0xQjo4VL3DFTXg</CellState><Name>EdgeWin:PlayerA:TopLeft</Name><CellIndex>0</CellIndex><CellStateId>0</CellStateId><CellCellState>00</CellCellState><CellName>TopLeft</CellName><CellStateName>PlayerA</CellStateName></CellPatternCell><CellPatternCell><CellPatternCellId>recWoh5Qk0b1xBV67</CellPatternCellId><createdTime>2020-11-26T20:42:17Z</createdTime><Cell>rec35HZOaRy6ge0jk</Cell><CellPattern>recg1ttw7l3n96PDG</CellPattern><CellState>recJAi8YoTOQmzhfH</CellState><Name>TwoOutsideDiagonal:NoPlayer:Middle</Name><CellIndex>4</CellIndex><CellStateId>2</CellStateId><CellCellState>42</CellCellState><CellName>Middle</CellName><CellStateName>NoPlayer</CellStateName></CellPatternCell><CellPatternCell><CellPatternCellId>recYR4cE90EOVnYD5</CellPatternCellId><createdTime>2020-11-26T20:37:58Z</createdTime><Cell>rec50MWM91QHzlEzO</Cell><CellPattern>recg1ttw7l3n96PDG</CellPattern><CellState>rec0xQjo4VL3DFTXg</CellState><Name>TwoOutsideDiagonal:PlayerA:TopLeft</Name><CellIndex>0</CellIndex><CellStateId>0</CellStateId><CellCellState>00</CellCellState><CellName>TopLeft</CellName><CellStateName>PlayerA</CellStateName></CellPatternCell><CellPatternCell><CellPatternCellId>recaPLycHtpRQfWnE</CellPatternCellId><createdTime>2020-11-26T20:44:11Z</createdTime><Cell>rec35HZOaRy6ge0jk</Cell><CellPattern>recobCShOEyZjP8bY</CellPattern><CellState>recJAi8YoTOQmzhfH</CellState><Name>TwoOutsideMiddle:NoPlayer:Middle</Name><CellIndex>4</CellIndex><CellStateId>2</CellStateId><CellCellState>42</CellCellState><CellName>Middle</CellName><CellStateName>NoPlayer</CellStateName></CellPatternCell><CellPatternCell><CellPatternCellId>recclaJuN3LJWLC4N</CellPatternCellId><createdTime>2020-11-26T20:35:31Z</createdTime><Cell>rec50MWM91QHzlEzO</Cell><CellPattern>rec55PqGhtUYK5Rcb</CellPattern><CellState>rec0xQjo4VL3DFTXg</CellState><Name>TwoInARowTop:PlayerA:TopLeft</Name><CellIndex>0</CellIndex><CellStateId>0</CellStateId><CellCellState>00</CellCellState><CellName>TopLeft</CellName><CellStateName>PlayerA</CellStateName></CellPatternCell><CellPatternCell><CellPatternCellId>reccnHG0Yfk8tgTt6</CellPatternCellId><createdTime>2020-11-26T20:44:07Z</createdTime><Cell>recTGnKjXTE8LfT3C</Cell><CellPattern>rec55PqGhtUYK5Rcb</CellPattern><CellState>recJAi8YoTOQmzhfH</CellState><Name>TwoInARowTop:NoPlayer:TopRight</Name><CellIndex>2</CellIndex><CellStateId>2</CellStateId><CellCellState>22</CellCellState><CellName>TopRight</CellName><CellStateName>NoPlayer</CellStateName></CellPatternCell><CellPatternCell><CellPatternCellId>recf1uu1YY0iPps8E</CellPatternCellId><createdTime>2020-11-26T20:38:12Z</createdTime><Cell>recpPYOZtnp3lTOua</Cell><CellPattern>recBDK2nzNlGSJNgJ</CellPattern><CellState>rec0xQjo4VL3DFTXg</CellState><Name>EdgeWin:PlayerA:Top</Name><CellIndex>1</CellIndex><CellStateId>0</CellStateId><CellCellState>10</CellCellState><CellName>Top</CellName><CellStateName>PlayerA</CellStateName></CellPatternCell><CellPatternCell><CellPatternCellId>rechiocdDSSkR1IFz</CellPatternCellId><createdTime>2020-11-26T20:44:04Z</createdTime><Cell>recfSe8zeEdCAtcGq</Cell><CellPattern>recqn6vuQrx71nQii</CellPattern><CellState>recJAi8YoTOQmzhfH</CellState><Name>TwoInARowMiddle:NoPlayer:MiddleRight</Name><CellIndex>5</CellIndex><CellStateId>2</CellStateId><CellCellState>52</CellCellState><CellName>MiddleRight</CellName><CellStateName>NoPlayer</CellStateName></CellPatternCell><CellPatternCell><CellPatternCellId>reckcKNNnyDSWpFrH</CellPatternCellId><createdTime>2020-11-26T20:35:31Z</createdTime><Cell>recxIf3GoDzEtonFU</Cell><CellPattern>recodVK2HKbzC26Db</CellPattern><CellState>rec0xQjo4VL3DFTXg</CellState><Name>MiddleWin:PlayerA:MiddleLeft</Name><CellIndex>3</CellIndex><CellStateId>0</CellStateId><CellCellState>30</CellCellState><CellName>MiddleLeft</CellName><CellStateName>PlayerA</CellStateName></CellPatternCell><CellPatternCell><CellPatternCellId>reclDV8jky7y1JNzH</CellPatternCellId><createdTime>2020-11-26T20:42:19Z</createdTime><Cell>recczW2Y4WMv9buZ8</Cell><CellPattern>recg1ttw7l3n96PDG</CellPattern><CellState>rec0xQjo4VL3DFTXg</CellState><Name>TwoOutsideDiagonal:PlayerA:BottomRight</Name><CellIndex>8</CellIndex><CellStateId>0</CellStateId><CellCellState>80</CellCellState><CellName>BottomRight</CellName><CellStateName>PlayerA</CellStateName></CellPatternCell><CellPatternCell><CellPatternCellId>recljMfqekOodaaWx</CellPatternCellId><createdTime>2020-11-26T20:44:14Z</createdTime><Cell>recpPYOZtnp3lTOua</Cell><CellPattern>recYmKv2dBpnAA1gs</CellPattern><CellState>recJAi8YoTOQmzhfH</CellState><Name>TwoOutsideTop:NoPlayer:Top</Name><CellIndex>1</CellIndex><CellStateId>2</CellStateId><CellCellState>12</CellCellState><CellName>Top</CellName><CellStateName>NoPlayer</CellStateName></CellPatternCell><CellPatternCell><CellPatternCellId>recwQ3ZI5MBVHPKgl</CellPatternCellId><createdTime>2020-11-26T20:43:44Z</createdTime><Cell>rec35HZOaRy6ge0jk</Cell><CellPattern>recZCV8dlP1pNK9kK</CellPattern><CellState>rec0xQjo4VL3DFTXg</CellState><Name>TwoInARowDiagonal:PlayerA:Middle</Name><CellIndex>4</CellIndex><CellStateId>0</CellStateId><CellCellState>40</CellCellState><CellName>Middle</CellName><CellStateName>PlayerA</CellStateName></CellPatternCell><CellPatternCell><CellPatternCellId>recxWA16nieZY83Sv</CellPatternCellId><createdTime>2020-11-26T20:37:58Z</createdTime><Cell>recxIf3GoDzEtonFU</Cell><CellPattern>recqn6vuQrx71nQii</CellPattern><CellState>rec0xQjo4VL3DFTXg</CellState><Name>TwoInARowMiddle:PlayerA:MiddleLeft</Name><CellIndex>3</CellIndex><CellStateId>0</CellStateId><CellCellState>30</CellCellState><CellName>MiddleLeft</CellName><CellStateName>PlayerA</CellStateName></CellPatternCell><CellPatternCell><CellPatternCellId>recyZobcdc9yOkGuC</CellPatternCellId><createdTime>2020-11-26T20:37:58Z</createdTime><Cell>recxIf3GoDzEtonFU</Cell><CellPattern>recobCShOEyZjP8bY</CellPattern><CellState>rec0xQjo4VL3DFTXg</CellState><Name>TwoOutsideMiddle:PlayerA:MiddleLeft</Name><CellIndex>3</CellIndex><CellStateId>0</CellStateId><CellCellState>30</CellCellState><CellName>MiddleLeft</CellName><CellStateName>PlayerA</CellStateName></CellPatternCell></CellPatternCells><Cells><Cell><CellId>rec35HZOaRy6ge0jk</CellId><createdTime>2020-11-26T20:06:06Z</createdTime><Name>Middle</Name><Clockwise>rec35HZOaRy6ge0jk</Clockwise><CounterClockwise>rec35HZOaRy6ge0jk</CounterClockwise><Flip>rec35HZOaRy6ge0jk</Flip><SampleValue>e</SampleValue><Description>Cell 1,1</Description><X>1</X><Y>1</Y><RotateTranslation>recgdoYW4iJ8gaAha</RotateTranslation><CellIndex>4</CellIndex><CellPatternCells>recGP80BxFCLlmgw7</CellPatternCells><CellPatternCells>recWoh5Qk0b1xBV67</CellPatternCells><CellPatternCells>recwQ3ZI5MBVHPKgl</CellPatternCells><CellPatternCells>recPmKMMNhYSxBWJ0</CellPatternCells><CellPatternCells>recaPLycHtpRQfWnE</CellPatternCells><CellPatterns>recobCShOEyZjP8bY</CellPatterns><CellPatterns>recg1ttw7l3n96PDG</CellPatterns><CurrentCellState>rec0xQjo4VL3DFTXg</CurrentCellState><DefaultCellState>recJAi8YoTOQmzhfH</DefaultCellState><CellKey>5</CellKey><RotateDescription>From Middle to Middle</RotateDescription><RotateIndex>4</RotateIndex><DefaultState>NoPlayer</DefaultState><CurrentState>PlayerA</CurrentState><RotateFrom>Middle</RotateFrom><IsClockwise>true</IsClockwise><ClockwiseRotateFrom>Middle</ClockwiseRotateFrom><CounterClockwiseRotateFrom>Middle</CounterClockwiseRotateFrom><FlipFromName>Middle</FlipFromName><FlipIndex>4</FlipIndex><ClockwiseRotateFromIndex>4</ClockwiseRotateFromIndex><CounterClockwiseRotateFromIndex>4</CounterClockwiseRotateFromIndex><FlipDescription>No Movement</FlipDescription><SortOrder>4</SortOrder></Cell><Cell><CellId>rec3OzG8nTAkUhjVn</CellId><createdTime>2020-11-26T20:06:06Z</createdTime><Name>Bottom</Name><Clockwise>recfSe8zeEdCAtcGq</Clockwise><CounterClockwise>recxIf3GoDzEtonFU</CounterClockwise><Flip>rec3OzG8nTAkUhjVn</Flip><SampleValue>h</SampleValue><Description>Cell 2,1</Description><X>2</X><Y>1</Y><RotateTranslation>recgdoYW4iJ8gaAha</RotateTranslation><CellIndex>7</CellIndex><CurrentCellState>recJAi8YoTOQmzhfH</CurrentCellState><DefaultCellState>recJAi8YoTOQmzhfH</DefaultCellState><CellKey>2</CellKey><RotateDescription>From MiddleRight to Bottom</RotateDescription><RotateIndex>5</RotateIndex><DefaultState>NoPlayer</DefaultState><CurrentState>NoPlayer</CurrentState><RotateFrom>MiddleRight</RotateFrom><IsClockwise>true</IsClockwise><ClockwiseRotateFrom>MiddleRight</ClockwiseRotateFrom><CounterClockwiseRotateFrom>MiddleLeft</CounterClockwiseRotateFrom><FlipFromName>Bottom</FlipFromName><FlipIndex>7</FlipIndex><ClockwiseRotateFromIndex>5</ClockwiseRotateFromIndex><CounterClockwiseRotateFromIndex>3</CounterClockwiseRotateFromIndex><FlipDescription>No Movement</FlipDescription><SortOrder>7</SortOrder></Cell><Cell><CellId>rec50MWM91QHzlEzO</CellId><createdTime>2020-11-26T20:06:06Z</createdTime><Name>TopLeft</Name><Clockwise>recmjtZPRUfoCU2sr</Clockwise><CounterClockwise>recTGnKjXTE8LfT3C</CounterClockwise><Flip>recTGnKjXTE8LfT3C</Flip><SampleValue>A</SampleValue><Description>Cell 0,0</Description><X>0</X><Y>0</Y><RotateTranslation>recgdoYW4iJ8gaAha</RotateTranslation><CellIndex>0</CellIndex><CellPatternCells>recU9O3yxyMeQ1eU4</CellPatternCells><CellPatternCells>recYR4cE90EOVnYD5</CellPatternCells><CellPatternCells>rec91aKNdkT2cw93v</CellPatternCells><CellPatternCells>recclaJuN3LJWLC4N</CellPatternCells><CellPatternCells>recKj18pU9k6V6MAx</CellPatternCells><CurrentCellState>recw0SsqNfCk96xZs</CurrentCellState><DefaultCellState>recJAi8YoTOQmzhfH</DefaultCellState><CellKey>7</CellKey><RotateDescription>From BottomLeft to TopLeft</RotateDescription><RotateIndex>6</RotateIndex><DefaultState>NoPlayer</DefaultState><CurrentState>PlayerB</CurrentState><RotateFrom>BottomLeft</RotateFrom><IsClockwise>true</IsClockwise><ClockwiseRotateFrom>BottomLeft</ClockwiseRotateFrom><CounterClockwiseRotateFrom>TopRight</CounterClockwiseRotateFrom><FlipFromName>TopRight</FlipFromName><FlipIndex>2</FlipIndex><ClockwiseRotateFromIndex>6</ClockwiseRotateFromIndex><CounterClockwiseRotateFromIndex>2</CounterClockwiseRotateFromIndex><FlipDescription>From TopRight to TopLeft</FlipDescription><SortOrder>0</SortOrder></Cell><Cell><CellId>recTGnKjXTE8LfT3C</CellId><createdTime>2020-11-26T20:06:06Z</createdTime><Name>TopRight</Name><Clockwise>rec50MWM91QHzlEzO</Clockwise><CounterClockwise>recczW2Y4WMv9buZ8</CounterClockwise><Flip>rec50MWM91QHzlEzO</Flip><SampleValue>C</SampleValue><Description>Cell 0,2</Description><X>0</X><Y>2</Y><RotateTranslation>recgdoYW4iJ8gaAha</RotateTranslation><CellIndex>2</CellIndex><CellPatternCells>recPHA9ppFH8cjenC</CellPatternCells><CellPatternCells>reccnHG0Yfk8tgTt6</CellPatternCells><CellPatternCells>rec8bt4pVcy9OY8XO</CellPatternCells><CellPatterns>rec55PqGhtUYK5Rcb</CellPatterns><CurrentCellState>recJAi8YoTOQmzhfH</CurrentCellState><DefaultCellState>recJAi8YoTOQmzhfH</DefaultCellState><CellKey>9</CellKey><RotateDescription>From TopLeft to TopRight</RotateDescription><RotateIndex>0</RotateIndex><DefaultState>NoPlayer</DefaultState><CurrentState>NoPlayer</CurrentState><RotateFrom>TopLeft</RotateFrom><IsClockwise>true</IsClockwise><ClockwiseRotateFrom>TopLeft</ClockwiseRotateFrom><CounterClockwiseRotateFrom>BottomRight</CounterClockwiseRotateFrom><FlipFromName>TopLeft</FlipFromName><FlipIndex>0</FlipIndex><ClockwiseRotateFromIndex>0</ClockwiseRotateFromIndex><CounterClockwiseRotateFromIndex>8</CounterClockwiseRotateFromIndex><FlipDescription>From TopLeft to TopRight</FlipDescription><SortOrder>2</SortOrder></Cell><Cell><CellId>recczW2Y4WMv9buZ8</CellId><createdTime>2020-11-26T20:06:06Z</createdTime><Name>BottomRight</Name><Clockwise>recTGnKjXTE8LfT3C</Clockwise><CounterClockwise>recmjtZPRUfoCU2sr</CounterClockwise><Flip>recmjtZPRUfoCU2sr</Flip><SampleValue>i</SampleValue><Description>Cell 2,2</Description><X>2</X><Y>2</Y><RotateTranslation>recgdoYW4iJ8gaAha</RotateTranslation><CellIndex>8</CellIndex><CellPatternCells>reclDV8jky7y1JNzH</CellPatternCells><CellPatternCells>rec5D3fwk2h5GzjIB</CellPatternCells><CellPatterns>recZCV8dlP1pNK9kK</CellPatterns><CurrentCellState>recJAi8YoTOQmzhfH</CurrentCellState><DefaultCellState>recJAi8YoTOQmzhfH</DefaultCellState><CellKey>3</CellKey><RotateDescription>From TopRight to BottomRight</RotateDescription><RotateIndex>2</RotateIndex><DefaultState>NoPlayer</DefaultState><CurrentState>NoPlayer</CurrentState><RotateFrom>TopRight</RotateFrom><IsClockwise>true</IsClockwise><ClockwiseRotateFrom>TopRight</ClockwiseRotateFrom><CounterClockwiseRotateFrom>BottomLeft</CounterClockwiseRotateFrom><FlipFromName>BottomLeft</FlipFromName><FlipIndex>6</FlipIndex><ClockwiseRotateFromIndex>2</ClockwiseRotateFromIndex><CounterClockwiseRotateFromIndex>6</CounterClockwiseRotateFromIndex><FlipDescription>From BottomLeft to BottomRight</FlipDescription><SortOrder>8</SortOrder></Cell><Cell><CellId>recfSe8zeEdCAtcGq</CellId><createdTime>2020-11-26T20:06:06Z</createdTime><Name>MiddleRight</Name><Clockwise>recpPYOZtnp3lTOua</Clockwise><CounterClockwise>rec3OzG8nTAkUhjVn</CounterClockwise><Flip>recxIf3GoDzEtonFU</Flip><SampleValue>f</SampleValue><Description>Cell 1,2</Description><X>1</X><Y>2</Y><RotateTranslation>recgdoYW4iJ8gaAha</RotateTranslation><CellIndex>5</CellIndex><CellPatternCells>recAy4XNSSKRZGZsh</CellPatternCells><CellPatternCells>rechiocdDSSkR1IFz</CellPatternCells><CellPatternCells>rec6RGGCG5ORVBnA3</CellPatternCells><CellPatterns>recqn6vuQrx71nQii</CellPatterns><CurrentCellState>rec0xQjo4VL3DFTXg</CurrentCellState><DefaultCellState>recJAi8YoTOQmzhfH</DefaultCellState><CellKey>6</CellKey><RotateDescription>From Top to MiddleRight</RotateDescription><RotateIndex>1</RotateIndex><DefaultState>NoPlayer</DefaultState><CurrentState>PlayerA</CurrentState><RotateFrom>Top</RotateFrom><IsClockwise>true</IsClockwise><ClockwiseRotateFrom>Top</ClockwiseRotateFrom><CounterClockwiseRotateFrom>Bottom</CounterClockwiseRotateFrom><FlipFromName>MiddleLeft</FlipFromName><FlipIndex>3</FlipIndex><ClockwiseRotateFromIndex>1</ClockwiseRotateFromIndex><CounterClockwiseRotateFromIndex>7</CounterClockwiseRotateFromIndex><FlipDescription>From MiddleLeft to MiddleRight</FlipDescription><SortOrder>5</SortOrder></Cell><Cell><CellId>recmjtZPRUfoCU2sr</CellId><createdTime>2020-11-26T20:06:06Z</createdTime><Name>BottomLeft</Name><Clockwise>recczW2Y4WMv9buZ8</Clockwise><CounterClockwise>rec50MWM91QHzlEzO</CounterClockwise><Flip>recczW2Y4WMv9buZ8</Flip><SampleValue>g</SampleValue><Description>Cell 2,0</Description><X>2</X><Y>0</Y><RotateTranslation>recgdoYW4iJ8gaAha</RotateTranslation><CellIndex>6</CellIndex><CurrentCellState>recJAi8YoTOQmzhfH</CurrentCellState><DefaultCellState>recJAi8YoTOQmzhfH</DefaultCellState><CellKey>1</CellKey><RotateDescription>From BottomRight to BottomLeft</RotateDescription><RotateIndex>8</RotateIndex><DefaultState>NoPlayer</DefaultState><CurrentState>NoPlayer</CurrentState><RotateFrom>BottomRight</RotateFrom><IsClockwise>true</IsClockwise><ClockwiseRotateFrom>BottomRight</ClockwiseRotateFrom><CounterClockwiseRotateFrom>TopLeft</CounterClockwiseRotateFrom><FlipFromName>BottomRight</FlipFromName><FlipIndex>8</FlipIndex><ClockwiseRotateFromIndex>8</ClockwiseRotateFromIndex><CounterClockwiseRotateFromIndex>0</CounterClockwiseRotateFromIndex><FlipDescription>From BottomRight to BottomLeft</FlipDescription><SortOrder>6</SortOrder></Cell><Cell><CellId>recpPYOZtnp3lTOua</CellId><createdTime>2020-11-26T20:06:06Z</createdTime><Name>Top</Name><Clockwise>recxIf3GoDzEtonFU</Clockwise><CounterClockwise>recfSe8zeEdCAtcGq</CounterClockwise><Flip>recpPYOZtnp3lTOua</Flip><SampleValue>B</SampleValue><Description>Cell 0,1</Description><X>0</X><Y>1</Y><RotateTranslation>recgdoYW4iJ8gaAha</RotateTranslation><CellIndex>1</CellIndex><CellPatternCells>recf1uu1YY0iPps8E</CellPatternCells><CellPatternCells>recFITGoLxBQs1ocD</CellPatternCells><CellPatternCells>recljMfqekOodaaWx</CellPatternCells><CellPatterns>recYmKv2dBpnAA1gs</CellPatterns><CurrentCellState>recw0SsqNfCk96xZs</CurrentCellState><DefaultCellState>recJAi8YoTOQmzhfH</DefaultCellState><CellKey>8</CellKey><RotateDescription>From MiddleLeft to Top</RotateDescription><RotateIndex>3</RotateIndex><DefaultState>NoPlayer</DefaultState><CurrentState>PlayerB</CurrentState><RotateFrom>MiddleLeft</RotateFrom><IsClockwise>true</IsClockwise><ClockwiseRotateFrom>MiddleLeft</ClockwiseRotateFrom><CounterClockwiseRotateFrom>MiddleRight</CounterClockwiseRotateFrom><FlipFromName>Top</FlipFromName><FlipIndex>1</FlipIndex><ClockwiseRotateFromIndex>3</ClockwiseRotateFromIndex><CounterClockwiseRotateFromIndex>5</CounterClockwiseRotateFromIndex><FlipDescription>No Movement</FlipDescription><SortOrder>1</SortOrder></Cell><Cell><CellId>recxIf3GoDzEtonFU</CellId><createdTime>2020-11-26T20:06:06Z</createdTime><Name>MiddleLeft</Name><Clockwise>rec3OzG8nTAkUhjVn</Clockwise><CounterClockwise>recpPYOZtnp3lTOua</CounterClockwise><Flip>recfSe8zeEdCAtcGq</Flip><SampleValue>d</SampleValue><Description>Cell 1,0</Description><X>1</X><Y>0</Y><RotateTranslation>recgdoYW4iJ8gaAha</RotateTranslation><CellIndex>3</CellIndex><CellPatternCells>reckcKNNnyDSWpFrH</CellPatternCells><CellPatternCells>recxWA16nieZY83Sv</CellPatternCells><CellPatternCells>recyZobcdc9yOkGuC</CellPatternCells><CurrentCellState>recJAi8YoTOQmzhfH</CurrentCellState><DefaultCellState>recJAi8YoTOQmzhfH</DefaultCellState><CellKey>4</CellKey><RotateDescription>From Bottom to MiddleLeft</RotateDescription><RotateIndex>7</RotateIndex><DefaultState>NoPlayer</DefaultState><CurrentState>NoPlayer</CurrentState><RotateFrom>Bottom</RotateFrom><IsClockwise>true</IsClockwise><ClockwiseRotateFrom>Bottom</ClockwiseRotateFrom><CounterClockwiseRotateFrom>Top</CounterClockwiseRotateFrom><FlipFromName>MiddleRight</FlipFromName><FlipIndex>5</FlipIndex><ClockwiseRotateFromIndex>7</ClockwiseRotateFromIndex><CounterClockwiseRotateFromIndex>1</CounterClockwiseRotateFromIndex><FlipDescription>From MiddleRight to MiddleLeft</FlipDescription><SortOrder>3</SortOrder></Cell></Cells><TargetPlatforms><TargetPlatform><TargetPlatformId>rec4ch22B23xyBKFE</TargetPlatformId><createdTime>2020-11-26T20:07:32Z</createdTime><Name>Html</Name><ShortDescription>Documentation</ShortDescription><Description>The resulting HTML version of the wiki</Description><Implemented>TRUE</Implemented><DemoUrl>https://eejai42.sdks.codeiverse.com/TicTacToeSDK/Docs/ReadMe.html</DemoUrl><HasAnyUI>FALSE</HasAnyUI><IsHumanyPlayable>FALSE</IsHumanyPlayable><HasAnyAI>FALSE</HasAnyAI><DetectsWin>FALSE</DetectsWin><DetectsLoss>FALSE</DetectsLoss><DetectsTie>FALSE</DetectsTie><HasRuleFollowingAI>FALSE</HasRuleFollowingAI><HasUIForHuman>FALSE</HasUIForHuman><FullSimpleRules>FALSE</FullSimpleRules><FullMLAI>FALSE</FullMLAI><ImplementsRotate>FALSE</ImplementsRotate><ImplementsFlip>FALSE</ImplementsFlip><ImplementsCustomTranslations>FALSE</ImplementsCustomTranslations><SortOrder>4</SortOrder></TargetPlatform><TargetPlatform><TargetPlatformId>rec9TVW9uwN4omDSH</TargetPlatformId><createdTime>2020-11-26T20:07:32Z</createdTime><Name>JSFiddle</Name><ShortDescription>Simple web client</ShortDescription><Description>A JSFiddle implementation of every aspect of the specification.</Description><Implemented>TRUE</Implemented><DemoUrl>https://jsfiddle.net/eejai42/g5ndz2mp/</DemoUrl><HasAnyUI>TRUE</HasAnyUI><IsHumanyPlayable>TRUE</IsHumanyPlayable><HasAnyAI>TRUE</HasAnyAI><DetectsWin>TRUE</DetectsWin><DetectsLoss>TRUE</DetectsLoss><DetectsTie>FALSE</DetectsTie><HasRuleFollowingAI>TRUE</HasRuleFollowingAI><HasUIForHuman>TRUE</HasUIForHuman><FullSimpleRules>FALSE</FullSimpleRules><FullMLAI>FALSE</FullMLAI><ImplementsRotate>TRUE</ImplementsRotate><ImplementsFlip>TRUE</ImplementsFlip><ImplementsCustomTranslations>TRUE</ImplementsCustomTranslations><SortOrder>1</SortOrder></TargetPlatform><TargetPlatform><TargetPlatformId>recma037MKuzvQ5Gn</TargetPlatformId><createdTime>2020-11-26T20:07:32Z</createdTime><Name>Windows</Name><ShortDescription>Windows App</ShortDescription><Description>A windows forms version of the game, which also implements every aspect of the game.</Description><Implemented>TRUE</Implemented><DemoUrl>https://eejai42.sdks.codeiverse.com/ClickOnce/TicTacToe/publish.htm</DemoUrl><HasAnyUI>FALSE</HasAnyUI><IsHumanyPlayable>FALSE</IsHumanyPlayable><HasAnyAI>FALSE</HasAnyAI><DetectsWin>FALSE</DetectsWin><DetectsLoss>FALSE</DetectsLoss><DetectsTie>FALSE</DetectsTie><HasRuleFollowingAI>FALSE</HasRuleFollowingAI><HasUIForHuman>FALSE</HasUIForHuman><FullSimpleRules>FALSE</FullSimpleRules><FullMLAI>FALSE</FullMLAI><ImplementsRotate>FALSE</ImplementsRotate><ImplementsFlip>FALSE</ImplementsFlip><ImplementsCustomTranslations>FALSE</ImplementsCustomTranslations><SortOrder>2</SortOrder></TargetPlatform><TargetPlatform><TargetPlatformId>recn4ZBd69hcEBkIl</TargetPlatformId><createdTime>2020-11-26T20:07:32Z</createdTime><Name>CSharp</Name><ShortDescription>TTT Library</ShortDescription><Description>A csharp library which implements the SDK</Description><Implemented>TRUE</Implemented><DemoUrl>https://eejai42.sdks.codeiverse.com/ClickOnce/TicTacToe/publish.htm</DemoUrl><HasAnyUI>FALSE</HasAnyUI><IsHumanyPlayable>FALSE</IsHumanyPlayable><HasAnyAI>FALSE</HasAnyAI><DetectsWin>FALSE</DetectsWin><DetectsLoss>FALSE</DetectsLoss><DetectsTie>FALSE</DetectsTie><HasRuleFollowingAI>FALSE</HasRuleFollowingAI><HasUIForHuman>FALSE</HasUIForHuman><FullSimpleRules>FALSE</FullSimpleRules><FullMLAI>FALSE</FullMLAI><ImplementsRotate>FALSE</ImplementsRotate><ImplementsFlip>FALSE</ImplementsFlip><ImplementsCustomTranslations>FALSE</ImplementsCustomTranslations><SortOrder>6</SortOrder></TargetPlatform><TargetPlatform><TargetPlatformId>recqb7MghLHT7bidn</TargetPlatformId><createdTime>2020-11-26T20:07:32Z</createdTime><Name>GDocs</Name><ShortDescription>Documentation</ShortDescription><Description>The original source documentation (not really a target I guess :) )</Description><Implemented>TRUE</Implemented><DemoUrl>https://docs.google.com/spreadsheets/d/1xpLGHj6wHyot9Kp2lpKTG8AcKJNMSkxjp-aTQT7yB90/edit#gid=0</DemoUrl><HasAnyUI>FALSE</HasAnyUI><IsHumanyPlayable>FALSE</IsHumanyPlayable><HasAnyAI>FALSE</HasAnyAI><DetectsWin>FALSE</DetectsWin><DetectsLoss>FALSE</DetectsLoss><DetectsTie>FALSE</DetectsTie><HasRuleFollowingAI>FALSE</HasRuleFollowingAI><HasUIForHuman>FALSE</HasUIForHuman><FullSimpleRules>FALSE</FullSimpleRules><FullMLAI>FALSE</FullMLAI><ImplementsRotate>FALSE</ImplementsRotate><ImplementsFlip>FALSE</ImplementsFlip><ImplementsCustomTranslations>FALSE</ImplementsCustomTranslations><SortOrder>3</SortOrder></TargetPlatform><TargetPlatform><TargetPlatformId>recvHhGpUR9sun8YL</TargetPlatformId><createdTime>2020-11-26T20:07:32Z</createdTime><Name>Javascript</Name><ShortDescription>TTT Library</ShortDescription><Description>A javascript library (which implements the SDK)</Description><Implemented>TRUE</Implemented><DemoUrl>https://eejai42.sdks.codeiverse.com/TicTacToeSDK/Docs/Translations.html</DemoUrl><HasAnyUI>FALSE</HasAnyUI><IsHumanyPlayable>FALSE</IsHumanyPlayable><HasAnyAI>FALSE</HasAnyAI><DetectsWin>FALSE</DetectsWin><DetectsLoss>FALSE</DetectsLoss><DetectsTie>FALSE</DetectsTie><HasRuleFollowingAI>FALSE</HasRuleFollowingAI><HasUIForHuman>FALSE</HasUIForHuman><FullSimpleRules>FALSE</FullSimpleRules><FullMLAI>FALSE</FullMLAI><ImplementsRotate>FALSE</ImplementsRotate><ImplementsFlip>FALSE</ImplementsFlip><ImplementsCustomTranslations>FALSE</ImplementsCustomTranslations><SortOrder>5</SortOrder></TargetPlatform></TargetPlatforms><AdditionalResources><AdditionalResource><AdditionalResourceId>recHcwHGoetrVzZl2</AdditionalResourceId><createdTime>2020-11-26T20:08:44Z</createdTime><Name>ProjectIntro</Name><Description>An introduction to the project</Description><Type>GDoc</Type><GoogleKey>1LVxFmVcm2DgzH2AGNQ4c9buus16l42a6aNhEmwqjWzs</GoogleKey><IsActiveDownload>true</IsActiveDownload></AdditionalResource><AdditionalResource><AdditionalResourceId>recSwRg5YB2sQj3Dn</AdditionalResourceId><createdTime>2020-11-26T20:08:44Z</createdTime><Name>LanguageTokens</Name><Description>A list of language tokens used in the app.</Description><Type>GSheet</Type><GoogleKey>1xpLGHj6wHyot9Kp2lpKTG8AcKJNMSkxjp-aTQT7yB90</GoogleKey><GID>112651157</GID><IsActiveDownload>true</IsActiveDownload></AdditionalResource><AdditionalResource><AdditionalResourceId>recSzeONBNQyGam4a</AdditionalResourceId><createdTime>2020-11-26T20:08:44Z</createdTime><Name>AIStrategies</Name><Description>A list of strategies used by the AI, and which AI levels that start be used at.</Description><Type>GSheet</Type><GoogleKey>1xpLGHj6wHyot9Kp2lpKTG8AcKJNMSkxjp-aTQT7yB90</GoogleKey><GID>780350443</GID><IsActiveDownload>true</IsActiveDownload></AdditionalResource><AdditionalResource><AdditionalResourceId>recTnaatiHVKftVNt</AdditionalResourceId><createdTime>2020-11-26T20:08:44Z</createdTime><Name>TranslationTests</Name><Description>These values validate the rotate and flip index values</Description><Type>GSheet</Type><GoogleKey>1xpLGHj6wHyot9Kp2lpKTG8AcKJNMSkxjp-aTQT7yB90</GoogleKey><GID>1640541132</GID><IsActiveDownload>true</IsActiveDownload></AdditionalResource><AdditionalResource><AdditionalResourceId>recYXFpjsUJpxDAtz</AdditionalResourceId><createdTime>2020-11-26T20:08:44Z</createdTime><Name>Entities</Name><Description>A list of entities in the project (Player, Opponent, Game, Mark, Win, Loss, etc)</Description><Type>GSheet</Type><GoogleKey>1C_awugxQh7vQx4cCKGK7YKynOEUNdvT0htLzESZqhHA</GoogleKey><GID>0</GID></AdditionalResource><AdditionalResource><AdditionalResourceId>recat8Ojn2epezalz</AdditionalResourceId><createdTime>2020-11-26T20:08:44Z</createdTime><Name>CellPatterns</Name><Description>A list of cells and a target if a match is found.</Description><Type>GSheet</Type><GoogleKey>1xpLGHj6wHyot9Kp2lpKTG8AcKJNMSkxjp-aTQT7yB90</GoogleKey><GID>412235242</GID><IsActiveDownload>true</IsActiveDownload></AdditionalResource><AdditionalResource><AdditionalResourceId>receQpkmZcWMKHTQy</AdditionalResourceId><createdTime>2020-11-26T20:08:44Z</createdTime><Name>Cells</Name><Description>A formal list of the cells in the 3x3 game of tic tac toe.</Description><Type>GSheet</Type><GoogleKey>1xpLGHj6wHyot9Kp2lpKTG8AcKJNMSkxjp-aTQT7yB90</GoogleKey><GID>1934124403</GID><IsActiveDownload>true</IsActiveDownload></AdditionalResource><AdditionalResource><AdditionalResourceId>receawL0rBK391VX5</AdditionalResourceId><createdTime>2020-11-26T20:08:44Z</createdTime><Name>TargetPlatforms</Name><Description>A list of target platforms that the SDK will support</Description><Type>GSheet</Type><GoogleKey>1xpLGHj6wHyot9Kp2lpKTG8AcKJNMSkxjp-aTQT7yB90</GoogleKey><GID>2077194606</GID><IsActiveDownload>true</IsActiveDownload></AdditionalResource><AdditionalResource><AdditionalResourceId>reciUfmmPt7wX7Ey7</AdditionalResourceId><createdTime>2020-11-26T20:08:44Z</createdTime><Name>AILevels</Name><Description>A list of AI Levels which the game supports starting with None (no ai) and working up to an AI that will win or tie every game.</Description><Type>GSheet</Type><GoogleKey>1xpLGHj6wHyot9Kp2lpKTG8AcKJNMSkxjp-aTQT7yB90</GoogleKey><GID>260512170</GID><IsActiveDownload>true</IsActiveDownload></AdditionalResource><AdditionalResource><AdditionalResourceId>reco9SceAeSSTdk7l</AdditionalResourceId><createdTime>2020-11-26T20:08:44Z</createdTime><Name>AdditionalResources</Name><Description>A list of additional resources used by the project</Description><Type>GSheet</Type><GoogleKey>1xpLGHj6wHyot9Kp2lpKTG8AcKJNMSkxjp-aTQT7yB90</GoogleKey><GID>1887184744</GID></AdditionalResource><AdditionalResource><AdditionalResourceId>rect8IKCh05pywdx3</AdditionalResourceId><createdTime>2020-11-26T20:08:44Z</createdTime><Name>CellStates</Name><Description>A list of states that a cell can have</Description><Type>GSheet</Type><GoogleKey>1xpLGHj6wHyot9Kp2lpKTG8AcKJNMSkxjp-aTQT7yB90</GoogleKey><GID>194238261</GID><IsActiveDownload>true</IsActiveDownload></AdditionalResource><AdditionalResource><AdditionalResourceId>recvL0ljpLGaPyUJX</AdditionalResourceId><createdTime>2020-11-26T20:08:44Z</createdTime><Name>Translations</Name><Description>A list of transaltions which any implementation of this game needs to support</Description><Type>GSheet</Type><GoogleKey>1xpLGHj6wHyot9Kp2lpKTG8AcKJNMSkxjp-aTQT7yB90</GoogleKey><GID>1319606678</GID><IsActiveDownload>true</IsActiveDownload></AdditionalResource><AdditionalResource><AdditionalResourceId>recz3Z6BkBERUjDP7</AdditionalResourceId><createdTime>2020-11-26T20:08:44Z</createdTime><Name>Settings</Name><Description>Global settings for the entire TicTacToe project</Description><Type>GSheet</Type><GoogleKey>1xpLGHj6wHyot9Kp2lpKTG8AcKJNMSkxjp-aTQT7yB90</GoogleKey><GID>0</GID></AdditionalResource></AdditionalResources><Translations><Translation><TranslationId>recQ0PgyWBky0wm32</TranslationId><createdTime>2020-11-26T20:02:48Z</createdTime><Name>Flip</Name><CustomDescription>Flip the board along the vertical axis</CustomDescription><Id>1</Id><CellPatternTranslations>recwuYqQZ0iCw2WfQ</CellPatternTranslations><Description>Flip the board along the vertical axis</Description></Translation><Translation><TranslationId>recgdoYW4iJ8gaAha</TranslationId><createdTime>2020-11-26T20:02:48Z</createdTime><Name>Rotate</Name><Id>0</Id><IsClockwise>true</IsClockwise><Cells>rec50MWM91QHzlEzO</Cells><Cells>recpPYOZtnp3lTOua</Cells><Cells>recczW2Y4WMv9buZ8</Cells><Cells>recTGnKjXTE8LfT3C</Cells><Cells>recxIf3GoDzEtonFU</Cells><Cells>rec35HZOaRy6ge0jk</Cells><Cells>recfSe8zeEdCAtcGq</Cells><Cells>recmjtZPRUfoCU2sr</Cells><Cells>rec3OzG8nTAkUhjVn</Cells><CellPatternTranslations>recD87U0swUjjhnTj</CellPatternTranslations><CellPatternTranslations>recNz0LuN77HIXjmB</CellPatternTranslations><CellPatternTranslations>recqJB1goFBhhsIVZ</CellPatternTranslations><CellPatternTranslations>recJjgKw24kaBFH0i</CellPatternTranslations><CellPatternTranslations>rec9PRnE4xpUCcMit</CellPatternTranslations><CellPatternTranslations>reczr6h68ZUdkDIZb</CellPatternTranslations><CellPatternTranslations>recafoRwqvCh5HZOd</CellPatternTranslations><CellPatternTranslations>recoPtQQ8QZtClJK0</CellPatternTranslations><CellPatternTranslations>recUD9c7vXgkNLQi9</CellPatternTranslations><Description>Rotate 3x3 "board" 90 degrees RIGHT-hand (Clockwise) around the middle cell</Description></Translation></Translations><GlobalSettings><GlobalSetting><GlobalSettingId>rec2UsqxDo27MB0tS</GlobalSettingId><createdTime>2020-11-26T20:08:44Z</createdTime><Name>ExampleData</Name><Value>ExampleData</Value><Description>A list of sample values</Description><Prefix>SampleValues</Prefix><GoogleKey>1C_awugxQh7vQx4cCKGK7YKynOEUNdvT0htLzESZqhHA</GoogleKey><GID>0</GID></GlobalSetting><GlobalSetting><GlobalSettingId>rec4PYXvquNHrdkEm</GlobalSettingId><createdTime>2020-11-26T20:08:44Z</createdTime><Name>Descriptions</Name><Value>Descriptions</Value><Description>A list of description resources</Description><Prefix>Description</Prefix><GoogleKey>1C_awugxQh7vQx4cCKGK7YKynOEUNdvT0htLzESZqhHA</GoogleKey><GID>0</GID></GlobalSetting><GlobalSetting><GlobalSettingId>rec6rBbwkMlBgkC7Y</GlobalSettingId><createdTime>2020-11-26T20:08:44Z</createdTime><Name>ChameleonCodeHostUri</Name><Value>https://eejai42.sdks.codeiverse.com/</Value><Description>The root path to the SDK Doc Host</Description></GlobalSetting><GlobalSetting><GlobalSettingId>recCJ8WknVZI8eBoL</GlobalSettingId><createdTime>2020-11-26T20:08:44Z</createdTime><Name>Properties</Name><Value>Properties</Value><Description>A list of attribute resource</Description><Prefix>Attributes</Prefix><GoogleKey>1C_awugxQh7vQx4cCKGK7YKynOEUNdvT0htLzESZqhHA</GoogleKey><GID>0</GID></GlobalSetting><GlobalSetting><GlobalSettingId>recGXKYpNkpkMIAY5</GlobalSettingId><createdTime>2020-11-26T20:08:44Z</createdTime><Name>BaseNamespace</Name><Value>CODEiverse.Projects.TicTacToe</Value><Description>A reasonable base Namespace (to be used as a base namespace for code)</Description></GlobalSetting><GlobalSetting><GlobalSettingId>recO4hw3TPGZxFqSJ</GlobalSettingId><createdTime>2020-11-26T20:08:44Z</createdTime><Name>GoogleResourceList</Name><Value>AdditionalResources</Value><Description>A list of additional resources</Description><GoogleKey>1xpLGHj6wHyot9Kp2lpKTG8AcKJNMSkxjp-aTQT7yB90</GoogleKey><GID>1887184744</GID></GlobalSetting><GlobalSetting><GlobalSettingId>recO7Lsgh9rJLgojo</GlobalSettingId><createdTime>2020-11-26T20:08:44Z</createdTime><Name>Language1</Name><Value>EN</Value><Description>The primary language</Description><DefaultValue>EN</DefaultValue></GlobalSetting><GlobalSetting><GlobalSettingId>recOb5NWYwez7gF9t</GlobalSettingId><createdTime>2020-11-26T20:08:44Z</createdTime><Name>Language2</Name><Description>Additional languages</Description><DefaultValue>NA</DefaultValue></GlobalSetting><GlobalSetting><GlobalSettingId>recPhjZpPVPkwJsGq</GlobalSettingId><createdTime>2020-11-26T20:08:44Z</createdTime><Name>DisplayName</Name><Value>3x3 Tic-Tac-Toe</Value><Description>A "friendly" display name for the project which can be changed at any time.</Description></GlobalSetting><GlobalSetting><GlobalSettingId>recmBbQmUKdbqmMzk</GlobalSettingId><createdTime>2020-11-26T20:08:44Z</createdTime><Name>ChameleonCodeSDKUri</Name><Value>TicTacToeSDK/</Value><Description>The relative path within the dochost</Description><DefaultValue>ChameleonCode/</DefaultValue><AssociatedLink>https://eejai42.sdks.codeiverse.com/TicTacToeSDK/Docs/ReadMe.html</AssociatedLink></GlobalSetting><GlobalSetting><GlobalSettingId>recnP7mBv8TxwPbJ3</GlobalSettingId><createdTime>2020-11-26T20:08:44Z</createdTime><Name>ProjectName</Name><Value>TicTacToe</Value><Description>The name of the project</Description></GlobalSetting><GlobalSetting><GlobalSettingId>recu7jbuZGXLaz6aN</GlobalSettingId><createdTime>2020-11-26T20:08:44Z</createdTime><Name>ChameleonCodeSDKPath</Name><Value>TicTacToeChallenge/ChameleonCodeSDK/</Value><Description>The physical path to the doc host folder relative to the CODEE_ROOT_PATH</Description><DefaultValue>ChameleonCodeSDK\</DefaultValue></GlobalSetting></GlobalSettings><CellStates><CellState><CellStateId>rec0xQjo4VL3DFTXg</CellStateId><createdTime>2020-11-26T20:04:48Z</createdTime><Name>PlayerA</Name><Code>P</Code><Description>This cell has been marked by the active player</Description><Color>yellow</Color><FontColor>black</FontColor><DefaultMark>X</DefaultMark><Cursor>Default</Cursor><SortOrder>1</SortOrder><Id>0</Id><CellPatternCells>recU9O3yxyMeQ1eU4</CellPatternCells><CellPatternCells>recf1uu1YY0iPps8E</CellPatternCells><CellPatternCells>recPHA9ppFH8cjenC</CellPatternCells><CellPatternCells>reckcKNNnyDSWpFrH</CellPatternCells><CellPatternCells>recGP80BxFCLlmgw7</CellPatternCells><CellPatternCells>recAy4XNSSKRZGZsh</CellPatternCells><CellPatternCells>recYR4cE90EOVnYD5</CellPatternCells><CellPatternCells>reclDV8jky7y1JNzH</CellPatternCells><CellPatternCells>rec91aKNdkT2cw93v</CellPatternCells><CellPatternCells>recwQ3ZI5MBVHPKgl</CellPatternCells><CellPatternCells>recxWA16nieZY83Sv</CellPatternCells><CellPatternCells>recPmKMMNhYSxBWJ0</CellPatternCells><CellPatternCells>recclaJuN3LJWLC4N</CellPatternCells><CellPatternCells>recFITGoLxBQs1ocD</CellPatternCells><CellPatternCells>recyZobcdc9yOkGuC</CellPatternCells><CellPatternCells>rec6RGGCG5ORVBnA3</CellPatternCells><CellPatternCells>recKj18pU9k6V6MAx</CellPatternCells><CellPatternCells>rec8bt4pVcy9OY8XO</CellPatternCells><CurrentStateCells>rec35HZOaRy6ge0jk</CurrentStateCells><CurrentStateCells>recfSe8zeEdCAtcGq</CurrentStateCells></CellState><CellState><CellStateId>recJAi8YoTOQmzhfH</CellStateId><createdTime>2020-11-26T20:04:48Z</createdTime><Name>NoPlayer</Name><Code>N</Code><Description>The space has not yet been played in</Description><Color>white</Color><FontColor>darkgray</FontColor><Cursor>Pointer</Cursor><SortOrder>3</SortOrder><Id>2</Id><CellPatternCells>recWoh5Qk0b1xBV67</CellPatternCells><CellPatternCells>rec5D3fwk2h5GzjIB</CellPatternCells><CellPatternCells>rechiocdDSSkR1IFz</CellPatternCells><CellPatternCells>reccnHG0Yfk8tgTt6</CellPatternCells><CellPatternCells>recaPLycHtpRQfWnE</CellPatternCells><CellPatternCells>recljMfqekOodaaWx</CellPatternCells><CellPatterns>rec55PqGhtUYK5Rcb</CellPatterns><CellPatterns>recqn6vuQrx71nQii</CellPatterns><CellPatterns>recZCV8dlP1pNK9kK</CellPatterns><CellPatterns>recYmKv2dBpnAA1gs</CellPatterns><CellPatterns>recobCShOEyZjP8bY</CellPatterns><CellPatterns>recg1ttw7l3n96PDG</CellPatterns><CurrentStateCells>recxIf3GoDzEtonFU</CurrentStateCells><CurrentStateCells>recmjtZPRUfoCU2sr</CurrentStateCells><CurrentStateCells>rec3OzG8nTAkUhjVn</CurrentStateCells><CurrentStateCells>recTGnKjXTE8LfT3C</CurrentStateCells><CurrentStateCells>recczW2Y4WMv9buZ8</CurrentStateCells><DefaultStateCells>recxIf3GoDzEtonFU</DefaultStateCells><DefaultStateCells>recfSe8zeEdCAtcGq</DefaultStateCells><DefaultStateCells>recmjtZPRUfoCU2sr</DefaultStateCells><DefaultStateCells>rec3OzG8nTAkUhjVn</DefaultStateCells><DefaultStateCells>rec50MWM91QHzlEzO</DefaultStateCells><DefaultStateCells>recpPYOZtnp3lTOua</DefaultStateCells><DefaultStateCells>recTGnKjXTE8LfT3C</DefaultStateCells><DefaultStateCells>rec35HZOaRy6ge0jk</DefaultStateCells><DefaultStateCells>recczW2Y4WMv9buZ8</DefaultStateCells></CellState><CellState><CellStateId>recw0SsqNfCk96xZs</CellStateId><createdTime>2020-11-26T20:04:48Z</createdTime><Name>PlayerB</Name><Code>O</Code><Description>This cell has been marked by thhe active player's opponent.</Description><Color>black</Color><FontColor>white</FontColor><DefaultMark>O</DefaultMark><Cursor>Default</Cursor><SortOrder>2</SortOrder><Id>1</Id><CurrentStateCells>recpPYOZtnp3lTOua</CurrentStateCells><CurrentStateCells>rec50MWM91QHzlEzO</CurrentStateCells></CellState></CellStates></Airtable>
            
        var TwoInARowDiagonalNoPlayerBottomRight = new CellPatternCell()
        {
            CellPatternCellId = @"rec5D3fwk2h5GzjIB",
            createdTime = DateTime.Parse("2020-11-26T20:43:48Z"),
            Cell = new string[] { @"recczW2Y4WMv9buZ8" },
            CellPattern = new string[] { @"recZCV8dlP1pNK9kK" },
            CellState = new string[] { @"recJAi8YoTOQmzhfH" },
            Name = @"TwoInARowDiagonal:NoPlayer:BottomRight",
            CellIndex = 8,
            CellStateId = 2,
            CellCellState = 82,
            CellName = @"BottomRight",
            CellStateName = @"NoPlayer"
        };

        List.Add(TwoInARowDiagonalNoPlayerBottomRight);
        ByEnum[CellPatternCellsEnum.TwoInARowDiagonalNoPlayerBottomRight] = TwoInARowDiagonalNoPlayerBottomRight;
        
            
        var TwoOutsideMiddlePlayerAMiddleRight = new CellPatternCell()
        {
            CellPatternCellId = @"rec6RGGCG5ORVBnA3",
            createdTime = DateTime.Parse("2020-11-26T20:44:11Z"),
            Cell = new string[] { @"recfSe8zeEdCAtcGq" },
            CellPattern = new string[] { @"recobCShOEyZjP8bY" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"TwoOutsideMiddle:PlayerA:MiddleRight",
            CellIndex = 5,
            CellStateId = 0,
            CellCellState = 50,
            CellName = @"MiddleRight",
            CellStateName = @"PlayerA"
        };

        List.Add(TwoOutsideMiddlePlayerAMiddleRight);
        ByEnum[CellPatternCellsEnum.TwoOutsideMiddlePlayerAMiddleRight] = TwoOutsideMiddlePlayerAMiddleRight;
        
            
        var TwoOutsideTopPlayerATopRight = new CellPatternCell()
        {
            CellPatternCellId = @"rec8bt4pVcy9OY8XO",
            createdTime = DateTime.Parse("2020-11-26T20:44:14Z"),
            Cell = new string[] { @"recTGnKjXTE8LfT3C" },
            CellPattern = new string[] { @"recYmKv2dBpnAA1gs" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"TwoOutsideTop:PlayerA:TopRight",
            CellIndex = 2,
            CellStateId = 0,
            CellCellState = 20,
            CellName = @"TopRight",
            CellStateName = @"PlayerA"
        };

        List.Add(TwoOutsideTopPlayerATopRight);
        ByEnum[CellPatternCellsEnum.TwoOutsideTopPlayerATopRight] = TwoOutsideTopPlayerATopRight;
        
            
        var TwoInARowDiagonalPlayerATopLeft = new CellPatternCell()
        {
            CellPatternCellId = @"rec91aKNdkT2cw93v",
            createdTime = DateTime.Parse("2020-11-26T20:37:58Z"),
            Cell = new string[] { @"rec50MWM91QHzlEzO" },
            CellPattern = new string[] { @"recZCV8dlP1pNK9kK" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"TwoInARowDiagonal:PlayerA:TopLeft",
            CellIndex = 0,
            CellStateId = 0,
            CellCellState = 00,
            CellName = @"TopLeft",
            CellStateName = @"PlayerA"
        };

        List.Add(TwoInARowDiagonalPlayerATopLeft);
        ByEnum[CellPatternCellsEnum.TwoInARowDiagonalPlayerATopLeft] = TwoInARowDiagonalPlayerATopLeft;
        
            
        var MiddleWinPlayerAMiddleRight = new CellPatternCell()
        {
            CellPatternCellId = @"recAy4XNSSKRZGZsh",
            createdTime = DateTime.Parse("2020-11-26T20:42:02Z"),
            Cell = new string[] { @"recfSe8zeEdCAtcGq" },
            CellPattern = new string[] { @"recodVK2HKbzC26Db" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"MiddleWin:PlayerA:MiddleRight",
            CellIndex = 5,
            CellStateId = 0,
            CellCellState = 50,
            CellName = @"MiddleRight",
            CellStateName = @"PlayerA"
        };

        List.Add(MiddleWinPlayerAMiddleRight);
        ByEnum[CellPatternCellsEnum.MiddleWinPlayerAMiddleRight] = MiddleWinPlayerAMiddleRight;
        
            
        var TwoInARowTopPlayerATop = new CellPatternCell()
        {
            CellPatternCellId = @"recFITGoLxBQs1ocD",
            createdTime = DateTime.Parse("2020-11-26T20:44:06Z"),
            Cell = new string[] { @"recpPYOZtnp3lTOua" },
            CellPattern = new string[] { @"rec55PqGhtUYK5Rcb" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"TwoInARowTop:PlayerA:Top",
            CellIndex = 1,
            CellStateId = 0,
            CellCellState = 10,
            CellName = @"Top",
            CellStateName = @"PlayerA"
        };

        List.Add(TwoInARowTopPlayerATop);
        ByEnum[CellPatternCellsEnum.TwoInARowTopPlayerATop] = TwoInARowTopPlayerATop;
        
            
        var MiddleWinPlayerAMiddle = new CellPatternCell()
        {
            CellPatternCellId = @"recGP80BxFCLlmgw7",
            createdTime = DateTime.Parse("2020-11-26T20:41:59Z"),
            Cell = new string[] { @"rec35HZOaRy6ge0jk" },
            CellPattern = new string[] { @"recodVK2HKbzC26Db" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"MiddleWin:PlayerA:Middle",
            CellIndex = 4,
            CellStateId = 0,
            CellCellState = 40,
            CellName = @"Middle",
            CellStateName = @"PlayerA"
        };

        List.Add(MiddleWinPlayerAMiddle);
        ByEnum[CellPatternCellsEnum.MiddleWinPlayerAMiddle] = MiddleWinPlayerAMiddle;
        
            
        var TwoOutsideTopPlayerATopLeft = new CellPatternCell()
        {
            CellPatternCellId = @"recKj18pU9k6V6MAx",
            createdTime = DateTime.Parse("2020-11-26T20:37:58Z"),
            Cell = new string[] { @"rec50MWM91QHzlEzO" },
            CellPattern = new string[] { @"recYmKv2dBpnAA1gs" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"TwoOutsideTop:PlayerA:TopLeft",
            CellIndex = 0,
            CellStateId = 0,
            CellCellState = 00,
            CellName = @"TopLeft",
            CellStateName = @"PlayerA"
        };

        List.Add(TwoOutsideTopPlayerATopLeft);
        ByEnum[CellPatternCellsEnum.TwoOutsideTopPlayerATopLeft] = TwoOutsideTopPlayerATopLeft;
        
            
        var EdgeWinPlayerATopRight = new CellPatternCell()
        {
            CellPatternCellId = @"recPHA9ppFH8cjenC",
            createdTime = DateTime.Parse("2020-11-26T20:38:15Z"),
            Cell = new string[] { @"recTGnKjXTE8LfT3C" },
            CellPattern = new string[] { @"recBDK2nzNlGSJNgJ" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"EdgeWin:PlayerA:TopRight",
            CellIndex = 2,
            CellStateId = 0,
            CellCellState = 20,
            CellName = @"TopRight",
            CellStateName = @"PlayerA"
        };

        List.Add(EdgeWinPlayerATopRight);
        ByEnum[CellPatternCellsEnum.EdgeWinPlayerATopRight] = EdgeWinPlayerATopRight;
        
            
        var TwoInARowMiddlePlayerAMiddle = new CellPatternCell()
        {
            CellPatternCellId = @"recPmKMMNhYSxBWJ0",
            createdTime = DateTime.Parse("2020-11-26T20:44:04Z"),
            Cell = new string[] { @"rec35HZOaRy6ge0jk" },
            CellPattern = new string[] { @"recqn6vuQrx71nQii" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"TwoInARowMiddle:PlayerA:Middle",
            CellIndex = 4,
            CellStateId = 0,
            CellCellState = 40,
            CellName = @"Middle",
            CellStateName = @"PlayerA"
        };

        List.Add(TwoInARowMiddlePlayerAMiddle);
        ByEnum[CellPatternCellsEnum.TwoInARowMiddlePlayerAMiddle] = TwoInARowMiddlePlayerAMiddle;
        
            
        var EdgeWinPlayerATopLeft = new CellPatternCell()
        {
            CellPatternCellId = @"recU9O3yxyMeQ1eU4",
            createdTime = DateTime.Parse("2020-11-26T20:35:31Z"),
            Cell = new string[] { @"rec50MWM91QHzlEzO" },
            CellPattern = new string[] { @"recBDK2nzNlGSJNgJ" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"EdgeWin:PlayerA:TopLeft",
            CellIndex = 0,
            CellStateId = 0,
            CellCellState = 00,
            CellName = @"TopLeft",
            CellStateName = @"PlayerA"
        };

        List.Add(EdgeWinPlayerATopLeft);
        ByEnum[CellPatternCellsEnum.EdgeWinPlayerATopLeft] = EdgeWinPlayerATopLeft;
        
            
        var TwoOutsideDiagonalNoPlayerMiddle = new CellPatternCell()
        {
            CellPatternCellId = @"recWoh5Qk0b1xBV67",
            createdTime = DateTime.Parse("2020-11-26T20:42:17Z"),
            Cell = new string[] { @"rec35HZOaRy6ge0jk" },
            CellPattern = new string[] { @"recg1ttw7l3n96PDG" },
            CellState = new string[] { @"recJAi8YoTOQmzhfH" },
            Name = @"TwoOutsideDiagonal:NoPlayer:Middle",
            CellIndex = 4,
            CellStateId = 2,
            CellCellState = 42,
            CellName = @"Middle",
            CellStateName = @"NoPlayer"
        };

        List.Add(TwoOutsideDiagonalNoPlayerMiddle);
        ByEnum[CellPatternCellsEnum.TwoOutsideDiagonalNoPlayerMiddle] = TwoOutsideDiagonalNoPlayerMiddle;
        
            
        var TwoOutsideDiagonalPlayerATopLeft = new CellPatternCell()
        {
            CellPatternCellId = @"recYR4cE90EOVnYD5",
            createdTime = DateTime.Parse("2020-11-26T20:37:58Z"),
            Cell = new string[] { @"rec50MWM91QHzlEzO" },
            CellPattern = new string[] { @"recg1ttw7l3n96PDG" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"TwoOutsideDiagonal:PlayerA:TopLeft",
            CellIndex = 0,
            CellStateId = 0,
            CellCellState = 00,
            CellName = @"TopLeft",
            CellStateName = @"PlayerA"
        };

        List.Add(TwoOutsideDiagonalPlayerATopLeft);
        ByEnum[CellPatternCellsEnum.TwoOutsideDiagonalPlayerATopLeft] = TwoOutsideDiagonalPlayerATopLeft;
        
            
        var TwoOutsideMiddleNoPlayerMiddle = new CellPatternCell()
        {
            CellPatternCellId = @"recaPLycHtpRQfWnE",
            createdTime = DateTime.Parse("2020-11-26T20:44:11Z"),
            Cell = new string[] { @"rec35HZOaRy6ge0jk" },
            CellPattern = new string[] { @"recobCShOEyZjP8bY" },
            CellState = new string[] { @"recJAi8YoTOQmzhfH" },
            Name = @"TwoOutsideMiddle:NoPlayer:Middle",
            CellIndex = 4,
            CellStateId = 2,
            CellCellState = 42,
            CellName = @"Middle",
            CellStateName = @"NoPlayer"
        };

        List.Add(TwoOutsideMiddleNoPlayerMiddle);
        ByEnum[CellPatternCellsEnum.TwoOutsideMiddleNoPlayerMiddle] = TwoOutsideMiddleNoPlayerMiddle;
        
            
        var TwoInARowTopPlayerATopLeft = new CellPatternCell()
        {
            CellPatternCellId = @"recclaJuN3LJWLC4N",
            createdTime = DateTime.Parse("2020-11-26T20:35:31Z"),
            Cell = new string[] { @"rec50MWM91QHzlEzO" },
            CellPattern = new string[] { @"rec55PqGhtUYK5Rcb" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"TwoInARowTop:PlayerA:TopLeft",
            CellIndex = 0,
            CellStateId = 0,
            CellCellState = 00,
            CellName = @"TopLeft",
            CellStateName = @"PlayerA"
        };

        List.Add(TwoInARowTopPlayerATopLeft);
        ByEnum[CellPatternCellsEnum.TwoInARowTopPlayerATopLeft] = TwoInARowTopPlayerATopLeft;
        
            
        var TwoInARowTopNoPlayerTopRight = new CellPatternCell()
        {
            CellPatternCellId = @"reccnHG0Yfk8tgTt6",
            createdTime = DateTime.Parse("2020-11-26T20:44:07Z"),
            Cell = new string[] { @"recTGnKjXTE8LfT3C" },
            CellPattern = new string[] { @"rec55PqGhtUYK5Rcb" },
            CellState = new string[] { @"recJAi8YoTOQmzhfH" },
            Name = @"TwoInARowTop:NoPlayer:TopRight",
            CellIndex = 2,
            CellStateId = 2,
            CellCellState = 22,
            CellName = @"TopRight",
            CellStateName = @"NoPlayer"
        };

        List.Add(TwoInARowTopNoPlayerTopRight);
        ByEnum[CellPatternCellsEnum.TwoInARowTopNoPlayerTopRight] = TwoInARowTopNoPlayerTopRight;
        
            
        var EdgeWinPlayerATop = new CellPatternCell()
        {
            CellPatternCellId = @"recf1uu1YY0iPps8E",
            createdTime = DateTime.Parse("2020-11-26T20:38:12Z"),
            Cell = new string[] { @"recpPYOZtnp3lTOua" },
            CellPattern = new string[] { @"recBDK2nzNlGSJNgJ" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"EdgeWin:PlayerA:Top",
            CellIndex = 1,
            CellStateId = 0,
            CellCellState = 10,
            CellName = @"Top",
            CellStateName = @"PlayerA"
        };

        List.Add(EdgeWinPlayerATop);
        ByEnum[CellPatternCellsEnum.EdgeWinPlayerATop] = EdgeWinPlayerATop;
        
            
        var TwoInARowMiddleNoPlayerMiddleRight = new CellPatternCell()
        {
            CellPatternCellId = @"rechiocdDSSkR1IFz",
            createdTime = DateTime.Parse("2020-11-26T20:44:04Z"),
            Cell = new string[] { @"recfSe8zeEdCAtcGq" },
            CellPattern = new string[] { @"recqn6vuQrx71nQii" },
            CellState = new string[] { @"recJAi8YoTOQmzhfH" },
            Name = @"TwoInARowMiddle:NoPlayer:MiddleRight",
            CellIndex = 5,
            CellStateId = 2,
            CellCellState = 52,
            CellName = @"MiddleRight",
            CellStateName = @"NoPlayer"
        };

        List.Add(TwoInARowMiddleNoPlayerMiddleRight);
        ByEnum[CellPatternCellsEnum.TwoInARowMiddleNoPlayerMiddleRight] = TwoInARowMiddleNoPlayerMiddleRight;
        
            
        var MiddleWinPlayerAMiddleLeft = new CellPatternCell()
        {
            CellPatternCellId = @"reckcKNNnyDSWpFrH",
            createdTime = DateTime.Parse("2020-11-26T20:35:31Z"),
            Cell = new string[] { @"recxIf3GoDzEtonFU" },
            CellPattern = new string[] { @"recodVK2HKbzC26Db" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"MiddleWin:PlayerA:MiddleLeft",
            CellIndex = 3,
            CellStateId = 0,
            CellCellState = 30,
            CellName = @"MiddleLeft",
            CellStateName = @"PlayerA"
        };

        List.Add(MiddleWinPlayerAMiddleLeft);
        ByEnum[CellPatternCellsEnum.MiddleWinPlayerAMiddleLeft] = MiddleWinPlayerAMiddleLeft;
        
            
        var TwoOutsideDiagonalPlayerABottomRight = new CellPatternCell()
        {
            CellPatternCellId = @"reclDV8jky7y1JNzH",
            createdTime = DateTime.Parse("2020-11-26T20:42:19Z"),
            Cell = new string[] { @"recczW2Y4WMv9buZ8" },
            CellPattern = new string[] { @"recg1ttw7l3n96PDG" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"TwoOutsideDiagonal:PlayerA:BottomRight",
            CellIndex = 8,
            CellStateId = 0,
            CellCellState = 80,
            CellName = @"BottomRight",
            CellStateName = @"PlayerA"
        };

        List.Add(TwoOutsideDiagonalPlayerABottomRight);
        ByEnum[CellPatternCellsEnum.TwoOutsideDiagonalPlayerABottomRight] = TwoOutsideDiagonalPlayerABottomRight;
        
            
        var TwoOutsideTopNoPlayerTop = new CellPatternCell()
        {
            CellPatternCellId = @"recljMfqekOodaaWx",
            createdTime = DateTime.Parse("2020-11-26T20:44:14Z"),
            Cell = new string[] { @"recpPYOZtnp3lTOua" },
            CellPattern = new string[] { @"recYmKv2dBpnAA1gs" },
            CellState = new string[] { @"recJAi8YoTOQmzhfH" },
            Name = @"TwoOutsideTop:NoPlayer:Top",
            CellIndex = 1,
            CellStateId = 2,
            CellCellState = 12,
            CellName = @"Top",
            CellStateName = @"NoPlayer"
        };

        List.Add(TwoOutsideTopNoPlayerTop);
        ByEnum[CellPatternCellsEnum.TwoOutsideTopNoPlayerTop] = TwoOutsideTopNoPlayerTop;
        
            
        var TwoInARowDiagonalPlayerAMiddle = new CellPatternCell()
        {
            CellPatternCellId = @"recwQ3ZI5MBVHPKgl",
            createdTime = DateTime.Parse("2020-11-26T20:43:44Z"),
            Cell = new string[] { @"rec35HZOaRy6ge0jk" },
            CellPattern = new string[] { @"recZCV8dlP1pNK9kK" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"TwoInARowDiagonal:PlayerA:Middle",
            CellIndex = 4,
            CellStateId = 0,
            CellCellState = 40,
            CellName = @"Middle",
            CellStateName = @"PlayerA"
        };

        List.Add(TwoInARowDiagonalPlayerAMiddle);
        ByEnum[CellPatternCellsEnum.TwoInARowDiagonalPlayerAMiddle] = TwoInARowDiagonalPlayerAMiddle;
        
            
        var TwoInARowMiddlePlayerAMiddleLeft = new CellPatternCell()
        {
            CellPatternCellId = @"recxWA16nieZY83Sv",
            createdTime = DateTime.Parse("2020-11-26T20:37:58Z"),
            Cell = new string[] { @"recxIf3GoDzEtonFU" },
            CellPattern = new string[] { @"recqn6vuQrx71nQii" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"TwoInARowMiddle:PlayerA:MiddleLeft",
            CellIndex = 3,
            CellStateId = 0,
            CellCellState = 30,
            CellName = @"MiddleLeft",
            CellStateName = @"PlayerA"
        };

        List.Add(TwoInARowMiddlePlayerAMiddleLeft);
        ByEnum[CellPatternCellsEnum.TwoInARowMiddlePlayerAMiddleLeft] = TwoInARowMiddlePlayerAMiddleLeft;
        
            
        var TwoOutsideMiddlePlayerAMiddleLeft = new CellPatternCell()
        {
            CellPatternCellId = @"recyZobcdc9yOkGuC",
            createdTime = DateTime.Parse("2020-11-26T20:37:58Z"),
            Cell = new string[] { @"recxIf3GoDzEtonFU" },
            CellPattern = new string[] { @"recobCShOEyZjP8bY" },
            CellState = new string[] { @"rec0xQjo4VL3DFTXg" },
            Name = @"TwoOutsideMiddle:PlayerA:MiddleLeft",
            CellIndex = 3,
            CellStateId = 0,
            CellCellState = 30,
            CellName = @"MiddleLeft",
            CellStateName = @"PlayerA"
        };

        List.Add(TwoOutsideMiddlePlayerAMiddleLeft);
        ByEnum[CellPatternCellsEnum.TwoOutsideMiddlePlayerAMiddleLeft] = TwoOutsideMiddlePlayerAMiddleLeft;
        
    }

}