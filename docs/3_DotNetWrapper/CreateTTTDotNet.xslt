<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl" xmlns:xs="http://www.w3.org/2001/XMLSchema">
    <xsl:output method="xml" indent="yes" />
    <xsl:param name="root" />
    <xsl:param name="sdk-root" />
    <xsl:include href="../../SharedTools/CommonXsltTemplates.xslt"/>
    <xsl:variable name="lib-root">
        <xsl:value-of select="$sdk-root"  />
        <xsl:text>../../Microsoft/LibTicTacToe/</xsl:text>
    </xsl:variable>
    <xsl:variable name="win-root">
        <xsl:value-of select="$sdk-root"  />
        <xsl:text>../../Microsoft/WinTicTacToe/</xsl:text>
    </xsl:variable>
    <xsl:variable name="odxml" select="/" />
    <xsl:variable name="settings" select="/" />
    <xsl:variable name="entities" select="document(concat($sdk-root, 'GoogleData/AdditionalResources/Entities.csv.xml'))" />
    <xsl:variable name="project-name" select="$settings//Setting[Name = 'ProjectName']/Value" />
    <xsl:variable name="player-levels" select="document(concat($sdk-root, 'GoogleData/AdditionalResources/AILevels.csv.xml'))//AILevel" />
    <xsl:variable name="strategies" select="document(concat($sdk-root, 'GoogleData/AdditionalResources/AIStrategies.csv.xml'))//AIStrategy" />
    <xsl:variable name="cell-states" select="document(concat($sdk-root, 'GoogleData/AdditionalResources/CellStates.csv.xml'))//CellState" />
    <xsl:variable name="cells" select="document(concat($sdk-root, 'GoogleData/AdditionalResources/Cells.csv.xml'))//Cell" />

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
                        <xsl:value-of select="$lib-root" />Enums/CellStateEnum.cs<xsl:text />
                    </RelativePath>
                    <OverwriteMode>Always</OverwriteMode>
                    <FileContents>
                        <xsl:text>using System;
using KP.CODEiverse.TicTacToe.Lib.Enums;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP.CODEiverse.TicTacToe.Lib.Enums
{
    public enum CellStateEnum
    {
        </xsl:text>
                        <xsl:for-each select="$cell-states">
                            <xsl:value-of select="Name"/>
                            <xsl:if test="position() &lt; count($cell-states)">
                                <xsl:text>,
        </xsl:text>  
                            </xsl:if>
                        </xsl:for-each>
                        <xsl:text>
    }

    public static class CellStateLookup 
    {
        public static Dictionary&lt;CellStateEnum, Color> CellStateColors { get;set; }
        static CellStateLookup()
        {
            CellStateColors = new Dictionary&lt;CellStateEnum, Color>();
         </xsl:text>
                        <xsl:for-each select="$cell-states">
                            <xsl:text>
            CellStateColors[CellStateEnum.</xsl:text><xsl:value-of select="Name"/>] = Color.FromName("<xsl:value-of select="Color"/>");
                        </xsl:for-each>
                        <xsl:text>
        }
    }
}
</xsl:text>
                    </FileContents>
                </FileSetFile>
                <FileSetFile>
                    <RelativePath>
                        <xsl:value-of select="$lib-root" />TTTBoard.designer.cs<xsl:text />
                    </RelativePath>
                    <OverwriteMode>Always</OverwriteMode>
                    <FileContents>
                        <xsl:text>using System;
using KP.CODEiverse.TicTacToe.Lib.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP.CODEiverse.TicTacToe.Lib
{
    public partial class TTTBoard
    {
       

        private int[,] YRotations = new int[,] {
        </xsl:text>
                        <xsl:for-each select="$cells">
                            <xsl:variable name="rotated-cell" select="$cells[RotateIndex = current()/CellIndex]" />
                            <xsl:if test="(position() + 2) mod 3 = 0">
                                <xsl:text>
             { </xsl:text>
                            </xsl:if>
                            <xsl:value-of select="$rotated-cell/Y" />
                            <xsl:text>, </xsl:text>
                            <xsl:if test="position() mod 3 = 0">
                                <xsl:text>}</xsl:text>
                                <xsl:if test="position() &lt; 8">
                                    <xsl:text>, </xsl:text>
                                </xsl:if>
                            </xsl:if>
                        </xsl:for-each>
                        <xsl:text>
        };
          private int[,] XFlips = new int[,] {
        </xsl:text>
                        <xsl:for-each select="$cells">
                            <xsl:variable name="flipped-cell" select="$cells[FlipIndex = current()/CellIndex]" />
                            <xsl:if test="(position() + 2) mod 3 = 0">
                                <xsl:text>
             { </xsl:text>
                            </xsl:if>
                            <xsl:value-of select="$flipped-cell/X" />
                            <xsl:text>, </xsl:text>
                            <xsl:if test="position() mod 3 = 0">
                                <xsl:text>}</xsl:text>
                                <xsl:if test="position() &lt; 8">
                                    <xsl:text>, </xsl:text>
                                </xsl:if>
                            </xsl:if>
                        </xsl:for-each>
                        <xsl:text>
        };

        private int[,] YFlips = new int[,] {
        </xsl:text>
                        <xsl:for-each select="$cells">
                            <xsl:variable name="flipped-cell" select="$cells[FlipIndex = current()/CellIndex]" />
                            <xsl:if test="(position() + 2) mod 3 = 0">
                                <xsl:text>
             { </xsl:text>
                            </xsl:if>
                            <xsl:value-of select="$flipped-cell/Y" />
                            <xsl:text>, </xsl:text>
                            <xsl:if test="position() mod 3 = 0">
                                <xsl:text>}</xsl:text>
                                <xsl:if test="position() &lt; 8">
                                    <xsl:text>, </xsl:text>
                                </xsl:if>
                            </xsl:if>
                        </xsl:for-each>
                        <xsl:text>
        };

        public void PopulateBoardState()
        {
            this.CellStates = new CellStateEnum[,] {
                                    { CellStateEnum.Unplayed, CellStateEnum.Unplayed,CellStateEnum.Unplayed},
                                    { CellStateEnum.Unplayed, CellStateEnum.Unplayed,CellStateEnum.Unplayed },
                                    { CellStateEnum.Unplayed, CellStateEnum.Unplayed,CellStateEnum.Unplayed} };
        }
    }
}
</xsl:text>
                    </FileContents>
                </FileSetFile>
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
        <xsl:param name="transform-name" />
        <xsl:param name="cells" />
        <xsl:param name="field" />
        <xsl:param name="highlight-first3" select="false" />
        <xsl:variable name="field-value" select="*[name() = $field]" />

        <xsl:text>
        public int[,] $transform-name = new int[,] {
        </xsl:text>
                        <xsl:for-each select="$cells">
                            <xsl:if test="(position() - 1) mod 3 = 0">
                                <xsl:text>
             { </xsl:text>
                            </xsl:if>
                            <xsl:value-of select="$field-value" />
                            <xsl:text>, </xsl:text>
                            <xsl:if test="position() mod 3 = 0">
                                <xsl:text>}</xsl:text>
                                <xsl:if test="position() &lt; 8">
                                    <xsl:text>, </xsl:text>
                                </xsl:if>
                            </xsl:if>
                        </xsl:for-each>
        <xsl:text>
        };
</xsl:text>
    </xsl:template>
</xsl:stylesheet>
