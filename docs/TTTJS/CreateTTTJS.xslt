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
    <xsl:variable name="player-levels" select="document('Airtable.xml')/*/AILevels/AILevel" />
    <xsl:variable name="strategies" select="document('Airtable.xml')/*/AIStrategies/AIStrategy" />
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
                        <xsl:text>../Derived_TicTacToe.js</xsl:text>
                    </RelativePath>
                    <OverwriteMode>Always</OverwriteMode>
                    <FileContents>
                        <xsl:text>
// ***************************************************************************************************
//
// AUTO GENERATED - DO NOT CHANGE
// Created By: EJ Alexandra (2016)
//
// ***************************************************************************************************

// ***************************************************************************************************
// Constants for the relationship between the name and cellIndex of the cell in the cells array.
// ***************************************************************************************************</xsl:text>
                        <xsl:for-each select="$cells">
                            <xsl:sort select="CellIndex" />
                            <xsl:text>
var </xsl:text>
                            <xsl:value-of select="Name" />
                            <xsl:text>Cell = </xsl:text>
                            <xsl:value-of select="CellIndex" />
                            <xsl:text>;</xsl:text>
                        </xsl:for-each>
                        <xsl:text>


// ***************************************************************************************************
// This function adds board translations to a javascript representation of the 3x3 TicTacToe board.
// ***************************************************************************************************
function addDerivedCode(newBoard) {</xsl:text>
                        <xsl:for-each select="$translations">
                            <xsl:sort select="Id" />
                            <xsl:variable name="translation-name" select="Name" />
                            <xsl:variable name="camel-name">
                                <xsl:call-template name="camel-case-identifier">
                                    <xsl:with-param name="identifier" select="$translation-name" />
                                </xsl:call-template>
                            </xsl:variable>
                            <xsl:text>
    // ***************************************************************************************************
    // TRANSLATION FUNCTION: 
    // </xsl:text>
                            <xsl:value-of select="Name" />
                            <xsl:text>
    // Description: 
    // </xsl:text>
                            <xsl:value-of select="Description" />
                            <xsl:text>
    // ***************************************************************************************************
    newBoard.</xsl:text>
                            <xsl:value-of select="$camel-name" />
                            <xsl:text> = function () {
        var tempValues = [];
        var b = this;
        </xsl:text>
                            <xsl:for-each select="$cells">
                                <xsl:sort select="CellIndex" />
                                <xsl:variable name="rotated-index" select="*[name() = concat($translation-name, 'Index')]" />
                                <xsl:if test="CellIndex != $rotated-index">
                                    <xsl:text>
        tempValues[</xsl:text>
                                    <xsl:value-of select="concat(Name, 'Cell')" />
                                    <xsl:text>] = b.values[</xsl:text>
                                    <xsl:value-of select="concat($cells[CellIndex = $rotated-index]/Name, 'Cell')" />
                                    <xsl:text>];  // MOVE </xsl:text>
                                    <xsl:value-of select="$cells[CellIndex = $rotated-index]/Name"/>
                                    <xsl:text> to the </xsl:text>
                                    <xsl:value-of select="Name"/>
                                </xsl:if>
                            </xsl:for-each>
                            <xsl:text>
        for (var i = 0; i &lt; 9; i++) {
            if (tempValues[i]) b.values[i] = tempValues[i];
        }
    };

                            </xsl:text>
                        </xsl:for-each>
                        <xsl:for-each select="$cell-patterns[IsWinPattern = 'true']">
                            <xsl:variable name="pattern-name" select="Name"/>
                            <xsl:variable name="pattern-id" select="CellPatternId"/>
                            <xsl:text>

    newBoard.check</xsl:text>
                            <xsl:value-of select="$pattern-name" />
                            <xsl:text>Step = function (testBoard, cellStateToFind) {
        </xsl:text>
                            <xsl:for-each select="$cell-pattern-cells[CellPattern = $pattern-id]">
                                <xsl:sort select="CellIndex" />
                                <xsl:choose>
                                    <xsl:when test="position() = 1">
                                        <xsl:text>
        if </xsl:text>
                                    </xsl:when>
                                    <xsl:otherwise>
                                        <xsl:text>
        else if </xsl:text>
                                    </xsl:otherwise>
                                </xsl:choose>
                                <xsl:text>((testBoard.values[</xsl:text><xsl:value-of select="$cells[CellIndex = current()/CellIndex]/Name" />
                                <xsl:text>Cell].CurrentState !== cellStateToFind)) return false;</xsl:text>
                            </xsl:for-each>
                            <xsl:text>
        else return true;
    }
    </xsl:text>

                        </xsl:for-each>

                        <xsl:for-each select="$cell-patterns[IsWinPattern = 'true']">
                            <xsl:variable name="pattern-name" select="Name"/>
                            <xsl:variable name="pattern-id" select="CellPatternId"/>
                            <xsl:text>
    newBoard.check</xsl:text>
                            <xsl:value-of select="Name"/>
                            <xsl:text> = function () {
        var testBoard = this;
        var cellStateToFind = testBoard.cellStates[testBoard.myTurn ? 0 : 1].Name;
        
        // Check for a match...
        if (testBoard.check</xsl:text>
                                <xsl:value-of select="$pattern-name"/>
                                <xsl:text>Step(testBoard, cellStateToFind)) return true;</xsl:text>


                            <xsl:for-each select="$cell-pattern-translations[CellPattern=$pattern-id]">
                                <xsl:variable name="cell-pattern-translation" select="." />
                                <xsl:for-each select="/*/AIStrategies/*[position() &lt;= $cell-pattern-translation/Count]">
                                    <xsl:text>
        // </xsl:text>
                                    <xsl:value-of select="$cell-pattern-translation/TranslationName" />
                                    <xsl:text> the test board to try another test...
        testBoard.</xsl:text>
                                    <xsl:value-of select="translate(substring($cell-pattern-translation/TranslationName, 1, 1), $ucletters, $lcletters)" />
                                    <xsl:value-of select="substring($cell-pattern-translation/TranslationName, 2, string-length($cell-pattern-translation/TranslationName))" />
                                    <xsl:text>();</xsl:text>
                                <xsl:text>
        // Check for a match...
        if (testBoard.check</xsl:text>
                                <xsl:value-of select="$pattern-name"/>
                                <xsl:text>Step(testBoard, cellStateToFind)) return true;</xsl:text>
                            </xsl:for-each>
                              </xsl:for-each>
                            <xsl:text>
        return false;
    }
    </xsl:text>
                        </xsl:for-each>
                        <xsl:text>

    newBoard.checkForWin = function () {
        console.log(newBoard);
        var testBoard = jQuery.extend(true, {}, newBoard);

        </xsl:text>
                        <xsl:for-each select="$cell-patterns[IsWinPattern = 'true']">
                            <xsl:if test="position() > 1">else </xsl:if>if (testBoard.check<xsl:value-of select="Name"/><xsl:text>()) return true;
        </xsl:text>
                        </xsl:for-each>
                        <xsl:text>
        else return false;
    }
}

</xsl:text>
                    </FileContents>
                </FileSetFile>
                <xsl:for-each select="$player-levels">
                <xsl:variable name="lowerName" select="translate(Name, $ucletters, $lcletters)" />
                <FileSetFile>
                  <RelativePath><xsl:text>../</xsl:text><xsl:value-of select="$lowerName" /><xsl:text>Brain.js</xsl:text></RelativePath>
                  <OverwriteMode>Never</OverwriteMode>
                  <FileContents>
var <xsl:value-of select="$lowerName" />Brain = {};
<xsl:value-of select="$lowerName" />Brain.play = function (board, availableCells) {
    // Play randomly until a human writes custom code to control this Brain
    return randomBrain.play(board, availableCells);
}
                  </FileContents>
                </FileSetFile>
                </xsl:for-each>
            </FileSetFiles>
        </FileSet>
    </xsl:template>
</xsl:stylesheet>
