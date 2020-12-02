<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="xml" indent="yes"/>
    <xsl:include href="../CommonXsltTemplates.xslt"/>
    <xsl:param name="output-filename" select="'output.txt'" />
    <xsl:variable name="q">"</xsl:variable>
    <xsl:variable name="sq">'</xsl:variable>
    <xsl:variable name="odxml" select="document('Airtable.odxml')" />
    <xsl:variable name="static-data" select="document('StaticData.xml')" />

    <xsl:template match="@* | node()">
        <xsl:copy>
            <xsl:apply-templates select="@* | node()"/>
        </xsl:copy>
    </xsl:template>

    <xsl:template match="/*">
        <FileSet>
            <FileSetFiles>
                <xsl:for-each select="$odxml//ObjectDef[normalize-space(PluralName) != '']">
                    <xsl:variable name="od" select="." />
                    <xsl:variable name="od-static" select="$static-data/*/*[name() = $od/PluralName]/*[name() = $od/Name]" />
                <FileSetFile>
                    <RelativePath>
                        <xsl:value-of select="PluralName" />
                        <xsl:text>Enum.cs</xsl:text>
                    </RelativePath>
                    <FileContents>
public enum <xsl:value-of select="PluralName" /><xsl:text>Enum</xsl:text>
{
    <xsl:for-each select="$od-static"><xsl:sort select="SortOrder" data-type="number"/>
        <xsl:if test="translate(substring(Name, 1, 1), '0123456789', '____________') = '_'">_</xsl:if>
        <xsl:value-of select="translate(Name,'`~@#$%^*()-_=+,&amp;&lt;>./?&quot;:;','____________________')"/>
    <xsl:if test="position() &lt; count($od-static)">,
    </xsl:if>
    </xsl:for-each>
}
                    </FileContents>
                </FileSetFile>
                <FileSetFile>
                    <RelativePath>
                        <xsl:value-of select="PluralName" />
                        <xsl:text>.cs</xsl:text>
                    </RelativePath>
                    <OverwriteMode>Never</OverwriteMode>
                    <FileContents>using System;
using System.Collections.Generic;
using System.Linq;
using TicTacToeChallenge.Lib.DataClasses;

public static partial class <xsl:value-of select="PluralName" />
{
    public static Dictionary&lt;<xsl:value-of select="PluralName" />Enum, <xsl:value-of select="Name" />> ByEnum { get; }
    public static List&lt;<xsl:value-of select="Name" />> List { get; }
    static <xsl:value-of select="PluralName" />()
    {
        <xsl:value-of select="PluralName" />.ByEnum = new Dictionary&lt;<xsl:value-of select="PluralName" />Enum, <xsl:value-of select="Name" />>();
        <xsl:value-of select="PluralName" />.List = new List&lt;<xsl:value-of select="Name" />>();
        <xsl:value-of select="PluralName" />.Init<xsl:value-of select="PluralName" />();
    }    
}</FileContents>
                </FileSetFile>
                    <FileSetFile>
                    <RelativePath>
                        <xsl:value-of select="PluralName" />
                        <xsl:text>.designer.cs</xsl:text>
                    </RelativePath>
                    <FileContents>using System;
using System.Linq;
using TicTacToeChallenge.Lib.DataClasses;

public static partial class <xsl:value-of select="PluralName" />
{
    private static void Init<xsl:value-of select="PluralName" />()
    {
        // setup each one... <xsl:copy-of select="$static-data"/>
        <xsl:for-each select="$od-static">
            <xsl:variable name="ods-item" select="." />
            <xsl:variable name="name" select="translate(Name,'`~@#$%^*()-_=+,&amp;&lt;>./?&quot;:;','____________________')" />
            
        var <xsl:value-of select="$name"/> = new <xsl:value-of select="$od/Name" />()
        {
            <xsl:for-each select="*">
                <xsl:variable name="value-pos" select="position()" />
                <xsl:variable name="value-name" select="name()" />
                <xsl:variable name="odsi-value" select="." />
                <xsl:variable name="pd" select="$od/PropertyDefs/PropertyDef[Name = name($odsi-value)]" />

                <xsl:if test="count($pd) > 0 and count(../*[position() &lt; $value-pos and name() = $value-name]) = 0">
            <xsl:value-of select="name()"/> = <xsl:choose>
                <xsl:when test="translate($pd/DataType, $lcletters, $ucletters) = 'TEXT'">
                    <xsl:if test="$pd/IsCollection = 1">new string[] { </xsl:if>
                    <xsl:text>@"</xsl:text><xsl:value-of select="translate(translate(.,$q,$sq),'\','\\')"/><xsl:text>"</xsl:text>
                    <xsl:for-each select="../*[position() > $value-pos and name() = $value-name]">, "<xsl:value-of select="."/>"</xsl:for-each>
                    <xsl:if test="$pd/IsCollection = 1"> }</xsl:if>
                </xsl:when>
                <xsl:when test="translate($pd/DataType, $lcletters, $ucletters) = 'DATETIME'">
                    <xsl:text>DateTime.Parse("</xsl:text>
                    <xsl:value-of select="."/>
                    <xsl:text>")</xsl:text>
                </xsl:when>
                <xsl:when test="translate($pd/DataType, $lcletters, $ucletters) = 'BOOLEAN'">
                    <xsl:text>Boolean.Parse("</xsl:text>
                    <xsl:value-of select="."/>
                    <xsl:text>")</xsl:text>
                </xsl:when>
                <xsl:when test="translate($pd/DataType, $lcletters, $ucletters) = 'INT32'">
                    
                    
                    <xsl:if test="$pd/IsCollection = 1">new int[] { </xsl:if>
                    <xsl:value-of select="."/>
                    <xsl:for-each select="../*[position() > $value-pos and name() = $value-name]">
                        <xsl:text>, </xsl:text><xsl:value-of select="."/>
                    </xsl:for-each>
                    <xsl:if test="$pd/IsCollection = 1"> }</xsl:if>
                </xsl:when>
                <xsl:otherwise>null</xsl:otherwise>
            </xsl:choose><xsl:if test="position() &lt; count(../*)">,
            </xsl:if>
                </xsl:if>
            </xsl:for-each>
        };

        List.Add(<xsl:value-of select="$name"/>);
        ByEnum[<xsl:value-of select="$od/PluralName" />Enum.<xsl:value-of select="$name"/>] = <xsl:value-of select="$name"/>;
        </xsl:for-each>
    }

}</FileContents>
                </FileSetFile>

                </xsl:for-each>

                <FileSetFile>
                    <RelativePath>
                        <xsl:text>Objects.txt</xsl:text>
                    </RelativePath>
                    <xsl:element name="FileContents" xml:space="preserve">test
                    <xsl:for-each select="$odxml//ObjectDef">
                    -- <xsl:value-of select="Name" />
                    </xsl:for-each>
</xsl:element>
                </FileSetFile>
            </FileSetFiles>
        </FileSet>
    </xsl:template>
</xsl:stylesheet>
