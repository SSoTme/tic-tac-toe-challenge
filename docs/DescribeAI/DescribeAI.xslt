<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl" xmlns:xs="http://www.w3.org/2001/XMLSchema">
    <xsl:output method="xml" indent="yes" />
    <xsl:include href="CommonXsltTemplates.xslt"/>
    <xsl:variable name="cells1" select="document('Airtable.xml')/*/Cells/Cell" />
    <xsl:variable name="cells2">
        <xsl:for-each select="$cells1">
            <xsl:sort select="CellIndex" />
            <xsl:copy-of select="." />
        </xsl:for-each>
    </xsl:variable>
    <xsl:variable name="cells" select="msxsl:node-set($cells2)/*" />
    <xsl:variable name="cell-states" select="document('Airtable.xml')/*/CellStates/CellState" />
    <xsl:variable name="cell-patterns" select="document('Airtable.xml')/*/CellPatterns/CellPattern" />
    <xsl:variable name="cell-pattern-cells" select="document('Airtable.xml')/*/CellPatternCells/CellPatternCell" />
    <xsl:variable name="cell-pattern-translations" select="document('Airtable.xml')/*/CellPatternTranslations/CellPatternTranslation" />
    <xsl:variable name="pp-cell-patterns" select="document('PreProcessedCellPatterns.xml')//PreProcessedCellPatterns/PreProcessedCellPattern" />
    <xsl:variable name="player-levels1" select="document('Airtable.xml')/*/AILevels//AILevel" />
    <xsl:variable name="player-levels2">
        <xsl:for-each select="$player-levels1">
            <xsl:sort select="SortOrder" data-type="number" />
            <xsl:copy-of select="." />
        </xsl:for-each>
    </xsl:variable>
    <xsl:variable name="player-levels" select="msxsl:node-set($player-levels2)/*" />
    <xsl:variable name="strategies" select="document('Airtable.xml')/*/AIStrategies//AIStrategy" />
    <xsl:variable name="language-tokens" select="document('Airtable.xml')/*/LanguageTokens//LanguageToken" />
    <xsl:variable name="target-platforms" select="document('Airtable.xml')/*/TargetPlatforms/TargetPlatform" />
    <xsl:variable name="translations" select="document('Airtable.xml')/*/Translations/Translation" /> 


    <xsl:template match="@*|node()">
        <xsl:copy>
            <xsl:apply-templates select="@*|node()" />
        </xsl:copy>
    </xsl:template>

    <xsl:template match="/">
        <FileSet>
            <FileSetFiles>
                <FileSetFile>
                    <RelativePath>
                        ../TheBoard.html
                    </RelativePath>
                    <OverwriteMode>Always</OverwriteMode>
                    <FileContents>
                        <html>
                            <head>
                                <title>
                                    Players <xsl:value-of select="Name"/>
                                </title>
                                <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
                                <xsl:call-template name="bootstrap-links" />
                                <script src="../TTTJS/TicTacToe.js" type="text/javascript"></script>
                            </head>
                            <body style="padding: 1em;">

                                <xsl:call-template name="page-header">
                                    <xsl:with-param name="name" select="'TheBoard'" />
                                    <xsl:with-param name="edit-link" select="'https://airtable.com/tblKnVgLBllRGF80z/viwCkYHx0mUk3W986?blocks=hide'" />
                                </xsl:call-template>
                                <p>
                                    The board has 9 cells.
                                    The meta data associated with these cells describes their...

                                </p>
                                <ul>
                                    <li>Name</li>
                                    <li>Description</li>
                                    <li>X/Y Coordinates</li>
                                    <li>An Index</li>
                                    <li>An Index After a 90 degree clockwise rotation. </li>
                                    <li>An Index after being flipped vertically</li>
                                </ul>

                                <p>
                                    These are examples of things which are calculated (and included statically in this spec) which
                                    means that even though there are now <xsl:value-of select="count($target-platforms)"/> target
                                    platforms for this Tic-Tac-Toe implementation, none of them will need to actually calculate how
                                    to rotate a 9x9 grid 90 degrees - they can just follow the map established here, liked this.
                                </p>

                                <h3>In Game Language</h3>
                                <ul>
                                    <xsl:for-each select="$language-tokens">
                                        <xsl:sort select="SortOrder" data-type="number" />
                                        <li><b><xsl:value-of select="Token" />: </b><xsl:value-of select="DisplayName" /></li>
                                    </xsl:for-each>
                                </ul>



                              <h3>The Cells</h3>
                              <p>
                                Each of the <xsl:value-of select="count($cells)"/> cells can have one of these
                                <xsl:value-of select="count($cell-states)"/> cell states.
                              </p>

                              <ol>
                                <xsl:for-each select="$cell-states">
                                <xsl:sort select="SortOrder" data-type="number" />
                                  <li>
                                    
                                    <div>
                                      <xsl:attribute name="style">
                                        <xsl:text>width: 5em; background-color: </xsl:text>
                                        <xsl:value-of select="Color"/>
                                        <xsl:text>; color: </xsl:text>
                                        <xsl:value-of select="FontColor"/>
                                      </xsl:attribute>
                                      <xsl:value-of select="Name"/>
                                    </div>
                                  </li>
                                </xsl:for-each>
                              </ol>

                                <h4>Default Board</h4>
                                <xsl:call-template name="print-board">
                                    <xsl:with-param name="cells" select="$cells" />
                                    <xsl:with-param name="field" select="'DefaultState'" />
                                </xsl:call-template>
                                <h4>Sample play</h4>
                                <xsl:call-template name="print-board">
                                    <xsl:with-param name="cells" select="$cells" />
                                    <xsl:with-param name="field" select="'CurrentState'" />
                                </xsl:call-template>


                                <h3>Translations</h3>
                                <p>
                                    Any implementation of this board (in any platform) is expected to implement the following
                                    cell translations in order to help any AI strategies that might want to use them.
                                    This list of cells can then be re-arranged in a variety of ways.  This is list of
                                    <a href="Translations.html">Translations</a> (<a>edit</a>) which can be applied
                                    to a 3x3 "board" of cells.
                                </p>


                                <h3>List of Cells</h3>
                                <xsl:variable name="value-columns" select="$cells[position() = 1]/*[string-length(substring-after(text(), 'rec')) != 14 and name() != 'createdTime']" />
                                <table>
                                    <tr>
                                        <xsl:for-each select="$value-columns"><th style="padding: 0.25em;font-size: 0.6em;">
                                        <xsl:value-of select="name()" /></th></xsl:for-each>
                                    </tr>
                                    <xsl:for-each select="$cells">
                                        <xsl:variable name="cell" select="." />
                                    <tr>
                                        <xsl:for-each select="$value-columns">
                                        <xsl:variable name="name" select="name()" />
                                        <td style="padding: 0.25em; font-size: 0.8em;">
                                        <xsl:value-of select="$cell/*[name() = $name]" /></td></xsl:for-each>
                                    </tr>
                                    </xsl:for-each>
                                </table>



                            </body>
                        </html>

                    </FileContents>
                </FileSetFile>
                <FileSetFile>
                    <RelativePath>../PlayerLevels.html</RelativePath>
                    <OverwriteMode>Always</OverwriteMode>
                    <FileContents>
                        <html>
                            <head>
                                <title>
                                    Players <xsl:value-of select="Name"/>
                                </title>
                                <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
                                <xsl:call-template name="bootstrap-links" />
                                <script src="../TTTJS/TicTacToe.js" type="text/javascript"></script>
                            </head>
                            <body style="padding: 1em;">

                                <xsl:call-template name="page-header">
                                    <xsl:with-param name="name" select="'PlayerLevels'" />
                                    <xsl:with-param name="edit-link" select="'https://airtable.com/tblc2u9AaoC7CCbl4/viwzCywB1NedsrSDh?blocks=hide'" />
                                </xsl:call-template>
                                <p>
                                    An implementation of 3x3 Tic Tac Toe is expected to support a number of different kinds of players.  Human players,
                                    learning players and Rules based Players.  Currently, there are <xsl:value-of select="count($player-levels)"/> player types in
                                    this app.
                                </p>

                                <ol>
                                    <xsl:for-each select="$player-levels">
                                        <xsl:sort select="AILevelIndex"  data-type="number"/>
                                        <li>
                                            <a>
                                                <xsl:attribute name="href">
                                                    <xsl:text>Player_</xsl:text>
                                                    <xsl:value-of select="Name"/>
                                                    <xsl:text>.html</xsl:text>
                                                </xsl:attribute>
                                                <xsl:value-of select="Name"/>
                                            </a>
                                            <div>
                                                <small>
                                                    <xsl:value-of select="Description"/>
                                                    <br />
                                                  <b>
                                                    <xsl:value-of select="PlayerType"/>
                                                  </b>
                                                  <br />

                                                  <br />
                                                </small>
                                            </div>
                                        </li>
                                    </xsl:for-each>
                                </ol>
                            </body>
                        </html>

                    </FileContents>
                </FileSetFile>
                <xsl:for-each select="$player-levels">

                    <FileSetFile>
                        <RelativePath>
                            <xsl:text>../Player_</xsl:text>
                            <xsl:value-of select="Name"/>
                            <xsl:text>.html</xsl:text>
                        </RelativePath>
                        <OverwriteMode>Always</OverwriteMode>
                        <FileContents>
                            <html>
                                <title>
                                    Player Summary: <xsl:value-of select="Name"/>
                                </title>
                                <xsl:call-template name="bootstrap-links" />
                                <head>
                                </head>
                                <body style="padding: 1em;">
                                    <xsl:call-template name="page-header">
                                        <xsl:with-param name="name" select="Name" />
                                        <xsl:with-param name="edit-link" select="'https://airtable.com/tblc2u9AaoC7CCbl4/viwzCywB1NedsrSDh?blocks=hide'" />
                                    </xsl:call-template>

                                    <p>
                                        This player employes the following strategies.
                                    </p>
                                    <xsl:for-each select="$strategies[not(PlayerLevel > current()/AILevelIndex) and (PlayerLevel >= current()/MinAILevelIndex)] ">
                                        <xsl:sort select="StrategyRank" order="ascending" data-type="number"/>
                                        <div>
                                            <div style="float: left; min-width: 35px; min-height: 35x;">
                                                <xsl:choose>
                                                    <xsl:when test="normalize-space(IsDefensive) = 'true'">
                                                        <img width="32" src="Images/Shield.png" />
                                                    </xsl:when>
                                                    <xsl:when test="normalize-space(IsDefensive) = 'false'">
                                                        <img width="32" src="Images/Sword.png" />
                                                    </xsl:when>
                                                </xsl:choose>
                                                &#32;
                                            </div>
                                            <div style="margin-left: 40px;">
                                                <b>
                                                    <xsl:call-template name="camel-to-title-case">
                                                        <xsl:with-param name="text" select="Name" />
                                                    </xsl:call-template>
                                                </b>
                                                <div>
                                                    <small>
                                                        <xsl:value-of select="Description"/>
                                                        <br />
                                                        <br />
                                                    </small>
                                                </div>
                                            </div>
                                        </div>
                                        <div style="clear: both"></div>

                                    </xsl:for-each>
                                </body>
                            </html>
                        </FileContents>
                    </FileSetFile>
                </xsl:for-each>
                <FileSetFile>
                    <RelativePath>
                        <xsl:text>../Translations.html</xsl:text>
                    </RelativePath>
                    <OverwriteMode>Always</OverwriteMode>
                    <FileContents>
                        <html>
                            <title>
                                Board Translations....
                            </title>
                            <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
                            <xsl:call-template name="bootstrap-links" />
                            <script src="Derived_TicTacToe.js" type="text/javascript"></script>
                            <script src="TicTacToe.js" type="text/javascript"></script>
                            <script src="beginnerBrain.js" type="text/javascript"></script>
                            <head>
                            </head>
                            <body style="padding: 1em;">
                                <xsl:call-template name="page-header">
                                    <xsl:with-param name="name" select="'Translations'" />
                                    <xsl:with-param name="edit-link" select="'https://airtable.com/tblinXLfSQ2QLzcdC/viwzYolN6m6yrtm2F?blocks=hide'" />
                                </xsl:call-template>
                                <div>
                                    <a href="https://docs.google.com/spreadsheets/d/1xpLGHj6wHyot9Kp2lpKTG8AcKJNMSkxjp-aTQT7yB90/edit#gid=1934124403"  target="_blank">Edit Map</a>
                                </div>
                                <p>
                                    There are a number of patterns which occur in TicTacToe, which are then
                                    repeated through various cell translations.  In other words, the same
                                    operation needs can be performed repeatedly after (for example) rotating
                                    the board after each evalution. The board can be "translated" or transformed in the following ways..
                                </p>

                                <h3>SDK Complete 'Board' functionality</h3>
                                <p>
                                    A "complete" implementation of this specification would include the following
                                    translations that could be performed on a "board".  This specification says nothing about
                                    HOW these translations shall be implemented - only that they must be implemented, and
                                    what the end result needs to be.
                                </p>
                                <ol>
                                    <xsl:for-each select="$translations">
                                    <xsl:sort select="Id" />
                                        <li>
                                            <div style="font-size: 1.1em; font-weight: bold">
                                                <a>
                                                    <xsl:attribute name="href">
                                                        <xsl:text>Translation_</xsl:text>
                                                        <xsl:value-of select="Name"/>
                                                        <xsl:text>.html</xsl:text>
                                                    </xsl:attribute>
                                                    <xsl:value-of select="Name"/>
                                                </a>
                                            </div>
                                            <p>
                                                <xsl:value-of select="Description"/>
                                            </p>

                                            <div style="clear: both"></div>
                                        </li>
                                    </xsl:for-each>
                                </ol>
                                <h3>Javascript Translation Testing</h3>
                                <p>
                                    The following board rotations are accomplished by assigning the Sample Values from the spec to
                                    each cell on the baord, then calling 3 rotates, a flip and then 3 more rotates.  This takes the
                                    board through every possible combination of cells.  But the exact translations are determined by "the spec".
                                </p>
                                <script>
                                  var b = jQueryBoard(function() {
                                  var cellStateAttributeToPrint = 'DefaultMark'
                                  b.printInfo('Initial Board', true, cellStateAttributeToPrint);
                                  b.rotate();
                                  b.printInfo('Rotated Board', true, cellStateAttributeToPrint);
                                  b.rotate();
                                  b.printInfo('Rotated Board', true, cellStateAttributeToPrint);
                                  b.rotate();
                                  b.printInfo('Rotated Board', true, cellStateAttributeToPrint);
                                  b.flip();
                                  b.printInfo('Flipped Board', true, cellStateAttributeToPrint);
                                  b.rotate();
                                  b.printInfo('Rotated Board', true, cellStateAttributeToPrint);
                                  b.rotate();
                                  b.printInfo('Rotated Board', true, cellStateAttributeToPrint);
                                  b.rotate();
                                  b.printInfo('Rotated Board', true, cellStateAttributeToPrint);
                                  });
                                  console.log(b);
                                </script>
                              <div style="float: left; width: 45%">
                                <pre>

// Create a Board (in the sample player state) 
// which uses jQuery to load the game parameters
// The function parameter is invoked when the board 
// parameters have been loaded.

var b = jQueryBoard(function() {

  var cellStateAttributeToPrint = 'DefaultMark'

  // Print the board
  b.printInfo('Initial Board', true, cellStateAttributeToPrint);
  
  
  // Rotate - then Print()
  b.rotate();
  b.printInfo('Rotated Board', true, cellStateAttributeToPrint);
  
  
  // Rotate - then Print()
  b.rotate();
  b.printInfo('Rotated Board', true, cellStateAttributeToPrint);
  
  
  // Rotate - then Print()
  b.rotate();
  b.printInfo('Rotated Board', true, cellStateAttributeToPrint);
  
  
  //  ----- Flip ----- then Print()
  b.flip();
  b.printInfo('Flipped Board', true, cellStateAttributeToPrint);
  
  
  // Rotate - then Print()
  b.rotate();
  b.printInfo('Rotated Board', true, cellStateAttributeToPrint);
  
  
  // Rotate - then Print()
  b.rotate();
  b.printInfo('Rotated Board', true, cellStateAttributeToPrint);
  
  
  // Rotate - then Print()
  b.rotate();
  b.printInfo('Rotated Board', true, cellStateAttributeToPrint);
  
  
});
                                </pre>
                              </div>
                              <div style="float: left; width: 45%">
                                <pre style="padding-top: 6em;">
                                  <h3>Javascript Output</h3>
                                 
                                  <span id="rotations">
                                    
                                  </span>
                                </pre>
                              </div>
                            </body>
                        </html>
                    </FileContents>
                </FileSetFile>
                <xsl:for-each select="$translations">
                    <FileSetFile>
                        <RelativePath>
                            <xsl:text>../Translation_</xsl:text>
                            <xsl:value-of select="Name"/>
                            <xsl:text>.html</xsl:text>
                        </RelativePath>
                        <OverwriteMode>Always</OverwriteMode>
                        <FileContents>
                            <html>
                                <title>
                                    <xsl:value-of select="Name"/> Translation
                                </title>
                                <xsl:call-template name="bootstrap-links" />
                                <head>
                                </head>
                                <body style="padding: 1em;">
                                    <xsl:call-template name="page-header">
                                        <xsl:with-param name="name" select="Name" />
                                        <xsl:with-param name="edit-link" select="'https://airtable.com/tblinXLfSQ2QLzcdC/viwzYolN6m6yrtm2F?blocks=hide'" />
                                    </xsl:call-template>
                                    <p>
                                        <xsl:value-of select="Description"/>
                                    </p>
                                    <h3>
                                        Before <xsl:value-of select="Name" />
                                    </h3>

                                    <xsl:variable name="transformed-cells1" >
                                        <xsl:call-template name="transform-cells">
                                            <xsl:with-param name="cells" select="$cells" />
                                            <xsl:with-param name="transform-name" select="concat(Name, 'Index')" />
                                        </xsl:call-template>
                                    </xsl:variable>
                                    <xsl:variable name="transformed-cells" select="msxsl:node-set($transformed-cells1)//Cell" />

                                    <xsl:call-template name="print-board">
                                        <xsl:with-param name="cells" select="$cells" />
                                        <xsl:with-param name="field" select="'SampleValue'" />
                                        <xsl:with-param name="highlight-first3" select="1" />
                                    </xsl:call-template>

                                    <h3>
                                        After <xsl:value-of select="Name" />
                                    </h3>

                                    <xsl:call-template name="print-board">
                                        <xsl:with-param name="cells" select="$transformed-cells" />
                                        <xsl:with-param name="field" select="'SampleValue'" />
                                        <xsl:with-param name="highlight-first3" select="1" />
                                    </xsl:call-template>

                                    <h3>All Translations</h3>
                                    <ul>
                                        <xsl:for-each select="$translations">
                                        <xsl:sort select="Id"  data-type="number"/>
                                            <li>
                                                <a>
                                                    <xsl:attribute name="href">
                                                        <xsl:text>Translation_</xsl:text>
                                                        <xsl:value-of select="Name"/>
                                                        <xsl:text>.html</xsl:text>
                                                    </xsl:attribute>
                                                    <xsl:value-of select="Name"/>
                                                </a>
                                                <br />
                                                <small>
                                                    <xsl:value-of select="Description"/>
                                                    <br />
                                                    <br />
                                                </small>
                                            </li>

                                        </xsl:for-each>
                                    </ul>
                                </body>
                            </html>
                        </FileContents>
                    </FileSetFile>
                </xsl:for-each>
                <FileSetFile>
                    <RelativePath>
                        <xsl:text>../TargetPlatforms.html</xsl:text>
                    </RelativePath>
                    <OverwriteMode>Always</OverwriteMode>
                    <FileContents>
                        <html>
                            <title>
                                Target Platforms
                            </title>
                            <xsl:call-template name="bootstrap-links" />
                            <script src="../TTTJS/TicTacToe.js" type="text/javascript"></script>
                            <head>
                            </head>
                            <body style="padding: 1em;">
                                <xsl:call-template name="page-header">
                                    <xsl:with-param name="name" select="'Target Platforms'" />
                                    <xsl:with-param name="edit-link" select="'https://airtable.com/tblAF2Un6SivOUBIt/viwveiMH6pJy4jtSP?blocks=hide'" />
                                </xsl:call-template>


                                <p>
                                    This version of TicTacToe is intended to implementable in virtually any
                                    language/platform/context.  Where - once implemented, it will behave consistently
                                    with the other clients written against this SDK.
                                </p>


                                <h3>JS Fiddle example </h3>
                                <p>This uses the javascript portion of the sdk.  The JSFiddle references <b>http://localhost:8080/TicTacToe.js</b>, among
                                other files.</p>
                                <pre> # After cloning this repository, run the documentation as an http server on localhost.
 $ npm install -g http-server
 $ cd /docs
 $ http-server .
                                </pre>
                                <iframe width="100%" height="1000" src="https://jsfiddle.net/eejai42/bpwf1xto/9/embedded/result/" allowfullscreen="allowfullscreen" frameborder="0"></iframe>

                                <h3>Other Environments/Languages</h3>
                                <xsl:for-each select="$target-platforms">
                                    <xsl:sort select="SortOrder" />
                                    <div style="font-size: 1.1em; font-weight: bold">
                                            <xsl:attribute name="href">
                                                <xsl:text>TargetPlatform_</xsl:text>
                                                <xsl:value-of select="Name"/>
                                                <xsl:text>.html</xsl:text>
                                            </xsl:attribute>
                                            <xsl:value-of select="Name"/>
                                         (<a>
                                            <xsl:attribute name="href">
                                                <xsl:value-of select="DemoUrl"/>
                                            </xsl:attribute>
                                            launch
                                        </a>)
                                    </div>
                                    <p>
                                        <xsl:value-of select="Description"/>
                                    </p>

                                    <div style="clear: both"></div>

                                </xsl:for-each>

                            </body>
                        </html>
                    </FileContents>
                </FileSetFile>
                <xsl:for-each select="$target-platforms">
                    <FileSetFile>
                        <RelativePath>
                            <xsl:text>../TargetPlatform_</xsl:text>
                            <xsl:value-of select="Name"/>
                            <xsl:text>.html</xsl:text>
                        </RelativePath>
                        <OverwriteMode>Always</OverwriteMode>
                        <FileContents>
                            <html>
                                <title>
                                    <xsl:value-of select="Name"/> Target Platform
                                </title>
                                <xsl:call-template name="bootstrap-links" />
                                <head>
                                </head>
                                <body style="padding: 1em;">
                                    These are the target platforms for  <xsl:value-of select="Name"/>
                                </body>
                            </html>
                        </FileContents>
                    </FileSetFile>
                </xsl:for-each>
                <FileSetFile>
                    <RelativePath>
                        <xsl:text>../CellPatterns.html</xsl:text>
                    </RelativePath>
                    <OverwriteMode>Always</OverwriteMode>
                    <FileContents>
                        <html>
                            <title>
                                Cell Patterns - as explained by the spec
                            </title>
                            <xsl:call-template name="bootstrap-links" />
                            <script src="../TTTJS/TicTacToe.js" type="text/javascript"></script>
                            <head>
                            </head>
                            <body style="padding: 1em;">
                                <xsl:call-template name="page-header">
                                    <xsl:with-param name="name" select="'Cell Patterns'" />
                                    <xsl:with-param name="edit-link" select="'https://airtable.com/tblmOthRhNZyNxuXL/viwvACq4rF7AMZlEr?blocks=hide'" />
                                </xsl:call-template>

                                <xsl:variable name="winning-patterns" select="$cell-patterns[normalize-space(IsWinPattern) = 'true']" />
                                <xsl:variable name="general-patterns" select="$cell-patterns[normalize-space(IsWinPattern) != 'true']" />
                                <h3>Winning Patterns</h3>
                                <p>There are 2 ways that this specification defines winning patterns. The first is simply to list the 
                                    <xsl:value-of select="count($winning-patterns[CellPatternType='NamedSet'])"/> sets of winning cells.  The 2nd 
                                    method is to describe a more compact set of <xsl:value-of select="count($winning-patterns[CellPatternType='Win'])"  />
                                    sets of 3 cells, along with transformtions (rotations and flips) to find all possible variations of those
                                    original 3 cells specified.
                                </p>

                                    <h4>Specific Winning Sets: </h4>
                                <p>
                                    There are <xsl:value-of select="count($winning-patterns[CellPatternType='NamedSet'])"  /> winning patterns defined.
                                </p>
                                <xsl:for-each select="$winning-patterns[CellPatternType='NamedSet']">
                                    <xsl:sort select="SortOrder" data-type="number" />
                                    <xsl:apply-templates select="." />
                                </xsl:for-each>


                                    <h4>Compact Sets w/ Translations: </h4>
                                <p>
                                    There are <xsl:value-of select="count($winning-patterns[CellPatternType='Win'])"  /> winning patterns defined with one
                                    set of 3 cells, plus 1 or more transformations to find all of the related "versions" of that pattern within the baord.
                                </p>

                                <xsl:for-each select="$winning-patterns[CellPatternType='Win']">
                                    <xsl:sort select="SortOrder" data-type="number" />
                                    <xsl:apply-templates select="." />
                                </xsl:for-each>


                                <h3>Partial Win Match</h3>
                                <p>
                                    There are <xsl:value-of select="count($general-patterns)"  /> patterns which
                                    match 2/3rds of a winning pattern using translations to represent all arrangements of cells on a board.
                                </p>
                                <xsl:for-each select="$general-patterns">
                                    <xsl:sort select="SortOrder" data-type="number" />
                                    <xsl:apply-templates select="." />
                                </xsl:for-each>
                            </body>
                        </html>
                    </FileContents>
                </FileSetFile>
                <xsl:for-each select="$cell-patterns">
                    <xsl:variable name="is-win-pattern" select="normalize-space(IsWinPattern)" />
                    <xsl:variable name="cell-pattern" select="." />
                    <FileSetFile>
                        <RelativePath>
                            <xsl:text>../CellPattern_</xsl:text>
                            <xsl:value-of select="Name"/>
                            <xsl:text>.html</xsl:text>
                        </RelativePath>
                        <OverwriteMode>Always</OverwriteMode>
                        <FileContents>
                            <html>
                                <title>
                                    <xsl:value-of select="Name"/> Cell Pattern
                                </title>
                                <xsl:call-template name="bootstrap-links" />
                                <head>
                                </head>
                                <body style="padding: 1em;">
                                    <xsl:call-template name="page-header">
                                      <xsl:with-param name="name">
                                        <xsl:call-template name="camel-to-title-case">
                                          <xsl:with-param name="text" select="Name" />                                          
                                        </xsl:call-template>
                                        
                                      </xsl:with-param>
                                        <xsl:with-param name="edit-link" select="'https://airtable.com/tblmOthRhNZyNxuXL/viwvACq4rF7AMZlEr?blocks=hide'" />
                                    </xsl:call-template>

                                    <div>
                                        <a href="CellPatterns.html">
                                          &lt;&lt; Back to All Patterns
                                        </a>
                                    </div>
                                    <p>
                                        
                                        <xsl:value-of select="Description"/>
                                    </p>                                    
                                    <xsl:if test="IsWinPattern='true'">A winning player will have played in all of these cells. </xsl:if>
                                    <hr />
                                        Cells - <xsl:for-each select="CellPatternCellCellNames"><xsl:if test="position() > 1">, 
                                        </xsl:if>
                                            <xsl:value-of select="." />

                                        </xsl:for-each>
                                        <xsl:if test="normalize-space(TargetDescription) != ''">
                                        where <xsl:value-of select="TargetDescription" />
                                        </xsl:if>
                                        
                                        <xsl:if test="count(TranslationNames) > 0">
                                            <div style="font-weight: normal;">
                                                Then <xsl:for-each select="TranslationNames"><xsl:if test="position() > 1">, </xsl:if><xsl:value-of select="." /></xsl:for-each> to find all variations of the pattern.
                                            </div>
                                        </xsl:if>
                                    <hr />
                                    <xsl:for-each select="$pp-cell-patterns[CellPattern/Name = current()/Name]">
                                        <div>
                                            <xsl:choose>
                                            <xsl:when test="$is-win-pattern = 'true'">
                                            <p>
                                                Any player that can match any of the 
                                                <b><xsl:value-of select="count(.//PatternSet)"/> patterns</b> listed below will 
                                                <b>Win The Game</b>.

                                            </p>
                                            </xsl:when>
                                            <xsl:otherwise>
                                            <p>
                                                To find a match for this pattern, one of the following
                                                <b>
                                              <xsl:value-of select="count(.//PatternSet)"/> patterns
                                            </b>
                                                must match.
                                            </p>
                                            </xsl:otherwise>
                                            </xsl:choose>
                                            
                                            
                                        </div>
                                        <h3>1. Initial Position</h3>
                                        <xsl:call-template name="print-board">
                                            <xsl:with-param name="cells" select=".//PatternSet[position() = 1]/*" />
                                            <xsl:with-param name="field" select="'PatternCellStateId'" />
                                        </xsl:call-template>

                                        <xsl:for-each select=".//PatternSet[position() > 1]">
                                            <h3>
                                               <xsl:value-of select="position() + 1" />. After <xsl:value-of select="TransformName"/>
                                            </h3>
                                            <xsl:call-template name="print-board">
                                                <xsl:with-param name="cells" select="Cell" />
                                                <xsl:with-param name="field" select="'PatternCellStateId'" />
                                            </xsl:call-template>
                                        </xsl:for-each>
                                    </xsl:for-each>
                                </body>
                            </html>
                        </FileContents>
                    </FileSetFile>
                </xsl:for-each>
                <FileSetFile>
                    <RelativePath>
                        <xsl:text>../AvailableStrategies.html</xsl:text>
                    </RelativePath>
                    <FileContents><html>
    <head>
                                <title>
                                 Strategies Available for Level Configuration
                                </title>
                                <xsl:call-template name="bootstrap-links" />
    </head>

        <body style="padding: 1em;">
            <xsl:call-template name="page-header">
                <xsl:with-param name="name" select="'Available Strategies'" />
                <xsl:with-param name="edit-link" select="'https://airtable.com/tbli1vk1OgW5aeMvj/viwIAh1d1ww4MxtCb?blocks=hide'" />
            </xsl:call-template>

                <xsl:for-each select="$strategies"><xsl:sort select="PlayerLevel" data-type="number" /><xsl:sort select="StrategyRank" data-type="number" />
                 <div style="max-width: 40em;">
                 <div style="float: right;">
                    <xsl:text></xsl:text>
                    <xsl:value-of select="$player-levels[AILevelIndex >= current()/PlayerLevel]/Name" />
                    <xsl:if test="count($player-levels[sum(AILevelIndex) >= sum(current()/PlayerLevel)]) = 0">
                    NO IMPLEMENTATION YET
                    </xsl:if>
                 </div>
                    <b><xsl:value-of select="Name" /></b>
                    <div style="font-size: 0.8em; padding: 0.25em;">
                        <xsl:value-of select="Description" />
                    </div>
                 </div>
                </xsl:for-each>
    </body>
</html></FileContents>
                </FileSetFile>

                <xsl:for-each select="$strategies">
                <FileSetFile>
                    <RelativePath>
                        <xsl:text>../Strategy_</xsl:text>
                        <xsl:value-of select="Name" />
                        <xsl:text>.html</xsl:text>
                    </RelativePath>
                    <FileContents><html>
    <head>
                                <title>
                                 Strategies Available for Level Configuration
                                </title>
                                <xsl:call-template name="bootstrap-links" />
    </head>

        <body style="padding: 1em;">
            <xsl:call-template name="page-header">
                <xsl:with-param name="name" select="Name" />
                <xsl:with-param name="edit-link" select="'https://airtable.com/tbli1vk1OgW5aeMvj/viwIAh1d1ww4MxtCb?blocks=hide'" />
            </xsl:call-template>

                 <div>
                    <b><xsl:value-of select="Name" /></b>
                    <div style="font-size: 0.8em; padding: 0.25em;">
                        <xsl:value-of select="Description" />
                    </div>
                 </div>
    </body>
</html></FileContents>
                </FileSetFile>
                </xsl:for-each>
            </FileSetFiles>
        </FileSet>
    </xsl:template>


    <xsl:template name="transform-cells">
        <xsl:param name="cells" />
        <xsl:param name="transform-name" />
        <xsl:for-each select="$cells">
            <xsl:variable name="transformed-index" select="*[name() = $transform-name]" />
            <xsl:copy-of select="$cells[CellIndex = $transformed-index]" />
        </xsl:for-each>
    </xsl:template>

    <xsl:template name="print-board">
        <xsl:param name="cells" />
        <xsl:param name="field" />
        <xsl:param name="highlight-first3" select="false" />
        <style>
            th, td { padding: 1em;; border: 1px solid black; }
        </style>
        <table>
            <tr>
                <th>The Board</th>
                <th style="text-align: center">X=1</th>
                <th style="text-align: center">X=2</th>
                <th style="text-align: center">X=3</th>
            </tr>
            <xsl:for-each select="$cells[name() = 'Cell']">
                <xsl:variable name="field-value1" select="*[name() = $field]" />
                <xsl:variable name="field-value">
                    <xsl:choose>
                        <xsl:when test="substring-before($field, 'CellStateId')">
                            <xsl:value-of select="$cell-states[Id = $field-value1]/Name"/>
                        </xsl:when>
                        <xsl:otherwise>
                            <xsl:value-of select="$field-value1"/>
                        </xsl:otherwise>
                    </xsl:choose>
                </xsl:variable>
                <xsl:variable name="matching-cell-state"  select="$cell-states[Name = $field-value]" />
                <xsl:if test="(position() - 1) mod 3 = 0">
                    <xsl:text>&lt;tr></xsl:text>
                    <th style="text-align: center">
                        Y=<xsl:value-of select="substring-before(position() div 3, '.')"/>
                    </th>
                </xsl:if>
                <td align="center" style="position: relative;">
                    <xsl:if test="CellIndex &lt; 3 and $highlight-first3">
                        <xsl:attribute name="style">position: relative; background-color: lightgray;</xsl:attribute>
                    </xsl:if>
                    <xsl:if test="count($matching-cell-state)">
                        <xsl:attribute name="style">
                            <xsl:text>position: relative; color: white; background-color: </xsl:text>
                            <xsl:value-of select="$matching-cell-state/Color"/>; color: <xsl:value-of select="$matching-cell-state/FontColor"/>
                        </xsl:attribute>
                    </xsl:if>
                    <div style="width: 1em; height 1em; font-size: 0.7em; position: absolute; right: 0px; top: 0px; border: 1px solid;">
                        <xsl:value-of select="CellIndex"/>
                    </div>
                    <div style="padding-top: 1em; min-height: 3em; min-width: 3em; vertical-align: middle; ">
                    <xsl:value-of select="$field-value"/>
                    </div>
                </td>
                <xsl:if test="(position()) mod 3 = 0">
                    <xsl:text>&lt;/tr></xsl:text>
                </xsl:if>
            </xsl:for-each>
        </table>
    </xsl:template>

    <xsl:template name="page-header">
        <xsl:param name="name" />
        <xsl:param name="edit-link" />
        <h1>
            <xsl:value-of select="$name"/>
            <xsl:if test="normalize-space($edit-link) != ''">
                (<a target="_blank">
                    <xsl:attribute name="href">
                        <xsl:value-of select="$edit-link"/>
                    </xsl:attribute>
                    edit
                </a>)
            </xsl:if>
        </h1>
        <p>
            <a href="index.html">&lt;&lt; Home</a>
            <xsl:call-template name="print-link">
                <xsl:with-param name="current" select="$name" />
                <xsl:with-param name="name" select="'Target Platforms'" />
            </xsl:call-template>

            <xsl:call-template name="print-link">
                <xsl:with-param name="current" select="$name" />
                <xsl:with-param name="name" select="'TheBoard'" />
            </xsl:call-template>
          
          <xsl:call-template name="print-link">
            <xsl:with-param name="current" select="$name" />
            <xsl:with-param name="display-name" select="'Player Levels'" />
            <xsl:with-param name="name" select="'PlayerLevels'" />
          </xsl:call-template>

          <!--<xsl:call-template name="print-link">
                <xsl:with-param name="current" select="$name" />
                <xsl:with-param name="name" select="'Cells'" />
            </xsl:call-template>-->

            <xsl:call-template name="print-link">
                <xsl:with-param name="current" select="$name" />
                <xsl:with-param name="name" select="'Cell Patterns'" />
            </xsl:call-template>

            <xsl:call-template name="print-link">
                <xsl:with-param name="current" select="$name" />
                <xsl:with-param name="name" select="'Translations'" />
            </xsl:call-template>

            <xsl:call-template name="print-link">
                <xsl:with-param name="current" select="$name" />
                <xsl:with-param name="name" select="'Available Strategies'" />
            </xsl:call-template>

            <xsl:call-template name="print-link">
                <xsl:with-param name="current" select="$name" />
                <xsl:with-param name="display-name" select="'Challenge Rules'" />
                <xsl:with-param name="name" select="'ReadMe'" />
            </xsl:call-template>

            

        </p>
    </xsl:template>

    <xsl:template name="print-link">
        <xsl:param name="current" />
      <xsl:param name="display-name" />
      <xsl:param name="name" />
        <xsl:text> | </xsl:text>
        <xsl:choose>
            <xsl:when test="$current = $name">
                  <xsl:choose>
                    <xsl:when test="normalize-space($display-name) != ''">
                      <xsl:value-of select="$display-name"/>
                    </xsl:when>
                    <xsl:otherwise>
                      <xsl:call-template name="camel-to-title-case">
                        <xsl:with-param name="text" select="$name" />
                      </xsl:call-template>
                    </xsl:otherwise>
                  </xsl:choose>
            </xsl:when>
            <xsl:otherwise>
                <a>
                    <xsl:attribute name="href">
                        <xsl:value-of select="translate($name, ' ', '')"/>
                        <xsl:text>.html</xsl:text>
                    </xsl:attribute>
                  <xsl:choose>
                    <xsl:when test="normalize-space($display-name) != ''">
                      <xsl:value-of select="$display-name"/>
                    </xsl:when>
                    <xsl:otherwise>
                      <xsl:call-template name="camel-to-title-case">
                        <xsl:with-param name="text" select="$name" />
                      </xsl:call-template>
                    </xsl:otherwise>
                  </xsl:choose>
                </a>
            </xsl:otherwise>
        </xsl:choose>

    </xsl:template>
    <xsl:template match="CellPattern"><xsl:variable name="cell-pattern" select="." />
        <div style="font-size: 1.1em; font-weight: bold; max-width: 50em;">
        <div style="float: right; font-size: 0.7em; text-align: right;">
            <xsl:for-each select="CellPatternCellCellNames"><xsl:if test="position() > 1">, 
            </xsl:if>
            <xsl:choose>
                <xsl:when test="text() = $cell-pattern/Name"><xsl:value-of select="." /> (EMPTY)</xsl:when>
                <xsl:otherwise><xsl:value-of select="." /></xsl:otherwise>
            </xsl:choose>
            </xsl:for-each>

            <xsl:if test="normalize-space(TargetDescription) != ''">
                <span style="font-weight: normal">
                where 
                <xsl:value-of select="TargetDescription" />
                </span>
            </xsl:if>

            <br />            

            <span style="font-weight: normal;">
                <xsl:for-each select="TranslationNames"><xsl:if test="position() > 1">, </xsl:if><xsl:value-of select="." /></xsl:for-each>
            </span>

            <div style="font-weight: normal;">
                Cell Indexes: <xsl:for-each select="CellPatternCelICellIndexes"><xsl:if test="position() > 1">, </xsl:if><xsl:value-of select="." /></xsl:for-each>
            </div>
            
        </div>
            <a>
                <xsl:attribute name="href">
                    <xsl:text>CellPattern_</xsl:text>
                    <xsl:value-of select="Name"/>
                    <xsl:text>.html</xsl:text>
                </xsl:attribute>
                <xsl:call-template name="camel-to-title-case">
                    <xsl:with-param name="text" select="Name" />
                </xsl:call-template>
            </a>
        </div>
        <p>
            <xsl:value-of select="Description"/>
        </p>

        <div style="clear: both"></div>
    </xsl:template>

</xsl:stylesheet>
