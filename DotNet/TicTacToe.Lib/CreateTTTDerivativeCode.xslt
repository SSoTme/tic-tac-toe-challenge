<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="xml" indent="yes"/>

    <xsl:param name="output-filename" select="'output.txt'" />

    <xsl:template match="@* | node()">
        <xsl:copy>
            <xsl:apply-templates select="@* | node()"/>
        </xsl:copy>
    </xsl:template>

    <xsl:template match="/*">
        <FileSet>
            <FileSetFiles>
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
            </FileSetFiles>
        </FileSet>
    </xsl:template>
</xsl:stylesheet>
