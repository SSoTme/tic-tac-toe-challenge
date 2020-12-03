<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="xml" indent="yes"/>

    <xsl:param name="output-filename" select="'output.txt'" />
    <xsl:variable name="win-patterns" select="//CellPatterns/CellPattern[normalize-space(IsWinPattern) = 'true']" />
    <xsl:template match="@* | node()">
        <xsl:copy>
            <xsl:apply-templates select="@* | node()"/>
        </xsl:copy>
    </xsl:template>

    <xsl:template match="/*">
        <FileSet>
            <FileSetFiles>                
                <FileSetFile>
                    <RelativePath>TicTacToeBoard.designer.cs</RelativePath>
                    <FileContents>using DotNet.Lib.CellPatterns;
namespace TicTacToe.DotNet.Lib
{
    public partial class TicTacToeBoard 
    {
        private void CheckForWin()
        { 
            if (<xsl:for-each select="$win-patterns"> this.CheckForWin&lt;<xsl:value-of select="Name"/>Pattern>()<xsl:if test="position() &lt; count($win-patterns)"> ||
                </xsl:if></xsl:for-each>)
            {
                this.HandleWin();
            }
        }
    }
}</FileContents>
                </FileSetFile>
                <xsl:for-each select="//AILevels/AILevel">
                <FileSetFile>
                    <RelativePath>
                        <xsl:value-of select="Name"/>
                        <xsl:text>Player.cs</xsl:text>
                    </RelativePath>
                    <OverwriteMode>Never</OverwriteMode>
                    <xsl:element name="FileContents" xml:space="preserve">using System;
using TicTacToeChallenge.Lib.DataClasses;

namespace TicTacToe.DotNet.Lib
{
    public class <xsl:value-of select="Name"/>Player : Player
    {
        public <xsl:value-of select="Name"/>Player() 
            : base("<xsl:value-of select="Name"/>")
        {

        }

        public override Cell Play(TicTacToeBoard board)
        {
            // Play randomly for now until a Human changes this code to do something more specific
            var randomCell = board.GetRandomAvailableCell();
            Console.WriteLine("{0} player, playing at {1}", this.Name, randomCell.Name);
            return randomCell;
        }
    }
}
</xsl:element>
                </FileSetFile>
                </xsl:for-each>
                <xsl:for-each select="//AIStrategies/AIStrategy">
                    <FileSetFile>
                        <RelativePath>Strategies/<xsl:value-of select="Name"/>Strategy.cs</RelativePath>
                        <OverwriteMode>Never</OverwriteMode>
                        <FileContents>using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe.DotNet.Lib;
using TicTacToeChallenge.Lib.DataClasses;

namespace DotNet.Lib.Strategies
{
    public class <xsl:value-of select="Name"/>Strategy : StrategyBase
    {
        public override Cell CheckBoard(TicTacToeBoard ticTacToeBoard)
        {
            throw new NotImplementedException();
        }
    }
}
</FileContents>
                    </FileSetFile>
                </xsl:for-each>
                <xsl:for-each select="//CellPatterns/CellPattern">
                    <xsl:variable name="cell-pattern" select="." />
                    <FileSetFile>
                        <RelativePath>
                            <xsl:text>CellPatterns/</xsl:text>
                            <xsl:value-of select="Name"/>
                            <xsl:text>Pattern.cs</xsl:text>
                        </RelativePath>
                        <FileContents>using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe.DotNet.Lib;
using TicTacToeChallenge.Lib.DataClasses;

namespace DotNet.Lib.CellPatterns
{
    public class <xsl:value-of select="Name"/>Pattern : <xsl:choose>
        <xsl:when test="normalize-space(IsWinPattern) = 'true'">WinningPatternBase
    {
        public override bool CheckForWin(TicTacToeBoard ticTacToeBoard)
        {
            this.CurrentPlayerState = ticTacToeBoard.GetCurrentPlayerState();

            if (this.CheckForWinStep(ticTacToeBoard)) return true;
            <xsl:for-each select="//CellPatternTranslations/CellPatternTranslation[CellPattern=$cell-pattern/CellPatternId]">
            // TRANSLATION: <xsl:value-of select="Name"/>
            <xsl:variable name="cpt" select="." />
            <xsl:for-each select="//Entities/Entity[position() &lt;= $cpt/Count]">
            ticTacToeBoard.<xsl:value-of select="$cpt/TranslationName" />();
            if (this.CheckForWinStep(ticTacToeBoard)) return true;
            </xsl:for-each>
            </xsl:for-each>
            
            return false;
        }

        private bool CheckForWinStep(TicTacToeBoard ticTacToeBoard)
        {
            <xsl:variable name="cpcs" select="//CellPatternCells/CellPatternCell[CellPattern = $cell-pattern/CellPatternId]" />
            if (<xsl:for-each select="$cpcs">
                <xsl:sort select="CellIndex" data-type="number" />
                (ticTacToeBoard.BoardCells[(int)CellsEnum.<xsl:value-of select="CellName" />].CurrentState == <xsl:choose>
                    <xsl:when test="CellStateName = 'PlayerA'">this.CurrentPlayerState</xsl:when>
                    <xsl:otherwise>"NoPlayer"</xsl:otherwise>
                </xsl:choose> ) <xsl:if test="position() &lt; count($cpcs)">&amp;&amp;</xsl:if>
                </xsl:for-each>)
            {
                return true;
            }
            else return false;
        }
    }
    </xsl:when>
        <xsl:otherwise>MatchingPatternBase
    {

        public override Cell CheckForMatch(TicTacToeBoard ticTacToeBoard)
        {
            this.CurrentPlayerState = ticTacToeBoard.GetCurrentPlayerState();

            var cell = (this.CheckForMatchStep(ticTacToeBoard));
            if (!(cell is null)) return cell;

            <xsl:for-each select="//CellPatternTranslations/CellPatternTranslation[CellPattern=$cell-pattern/CellPatternId]">
                <xsl:sort select="SortOrder" data-type="number" />
            // TRANSLATION: <xsl:value-of select="Name"/>
            <xsl:variable name="cpt" select="." />
            <xsl:for-each select="//Entities/Entity[position() &lt;= $cpt/Count]">
            ticTacToeBoard.<xsl:value-of select="$cpt/TranslationName" />();
            cell = (this.CheckForMatchStep(ticTacToeBoard));
            if (!(cell is null)) return cell;
            </xsl:for-each>
            </xsl:for-each>
            return cell;
        }

        private Cell CheckForMatchStep(TicTacToeBoard ticTacToeBoard)
        {
            <xsl:variable name="cpcs" select="//CellPatternCells/CellPatternCell[CellPattern = $cell-pattern/CellPatternId]" />
            if (<xsl:for-each select="$cpcs">
                <xsl:sort select="CellIndex" data-type="number" />
                (ticTacToeBoard.BoardCells[(int)CellsEnum.<xsl:value-of select="CellName" />].CurrentState == <xsl:choose>
                    <xsl:when test="CellStateName = 'PlayerA'">this.CurrentPlayerState</xsl:when>
                    <xsl:otherwise>"NoPlayer"</xsl:otherwise>
                </xsl:choose> ) <xsl:if test="position() &lt; count($cpcs)">&amp;&amp;</xsl:if>
                </xsl:for-each>)
            {
                return ticTacToeBoard.BoardCells[(int)CellsEnum.<xsl:value-of select="$cpcs[CellStateName='NoPlayer']/CellName" />];
            }
            else return null;
        }        
    }</xsl:otherwise>
    </xsl:choose> 
}</FileContents>
                    </FileSetFile>
                </xsl:for-each>
            </FileSetFiles>
        </FileSet>
    </xsl:template>
</xsl:stylesheet>
