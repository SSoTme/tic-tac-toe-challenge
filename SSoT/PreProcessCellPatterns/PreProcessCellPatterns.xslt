<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl" xmlns:xs="http://www.w3.org/2001/XMLSchema">
    <xsl:output method="xml" indent="yes" />
    <xsl:param name="root" />
    <xsl:param name="sdk-root" select="'./'" />
    <xsl:include href="CommonXsltTemplates.xslt"/>
    <!-- <xsl:variable name="odxml" select="/" />
    <xsl:variable name="settings" select="/" />
    <xsl:variable name="entities" select="document(concat($sdk-root, 'GoogleData/AdditionalResources/Entities.csv.xml'))" />
    <xsl:variable name="project-name" select="$settings//Setting[Name = 'ProjectName']/Value" />
    <xsl:variable name="cells" select="document(concat($sdk-root, 'GoogleData/AdditionalResources/Cells.csv.xml'))//Cell" />
    <xsl:variable name="player-levels" select="document(concat($sdk-root, 'GoogleData/AdditionalResources/AILevels.csv.xml'))//AILevel" />
    <xsl:variable name="strategies" select="document(concat($sdk-root, 'GoogleData/AdditionalResources/AIStrategies.csv.xml'))//AIStrategy" />
    <xsl:variable name="target-platforms" select="document(concat($sdk-root, 'GoogleData/AdditionalResources/TargetPlatforms.csv.xml'))//TargetPlatform" />
    <xsl:variable name="translations" select="document(concat($sdk-root, 'GoogleData/AdditionalResources/Translations.csv.xml'))//Translation" /> -->

    <xsl:variable name="cell-patterns" select="document('Airtable.xml')//CellPatterns/CellPattern" />
    <xsl:variable name="cells1" select="document('Airtable.xml')/*/Cells/Cell" />
    <xsl:variable name="cells2">
        <xsl:for-each select="$cells1">
            <xsl:sort select="CellIndex" />
            <xsl:copy-of select="." />
        </xsl:for-each>
    </xsl:variable>
    <xsl:variable name="cells" select="msxsl:node-set($cells2)/*" />
    <xsl:variable name="cell-states" select="document('Airtable.xml')//CellStates/CellState" />
    <xsl:variable name="translations" select="document('Airtable.xml')//Translations/Translation" />


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
                        <xsl:value-of select="$sdk-root"  /><xsl:text>PreProcessedCellPatterns.xml</xsl:text>
                    </RelativePath>
                    <OverwriteMode>Always</OverwriteMode>
                    <FileContents>
                        <PreProcessedCellPatterns>
                            <COUNT><xsl:value-of select="count($cell-patterns)" /></COUNT>
                            <xsl:for-each select="$cell-patterns">
                            <xsl:sort select="SortOrder" />
                                <xsl:variable name="pattern-cells1">
                                    <xsl:call-template name="get-cells">
                                        <xsl:with-param name="pattern-cells" select="$cells" />
                                        <xsl:with-param name="pattern-string" select="Cells" />
                                    </xsl:call-template>
                                </xsl:variable>
                                <xsl:variable name="pattern-cells" select="msxsl:node-set($pattern-cells1)/*" />
                                <PreProcessedCellPattern>
                                    <xsl:copy-of select="." />
                                    <PatternSets>
                                        <PatternSet>
                                            <TransformName />
                                            <xsl:copy-of select="$pattern-cells" />
                                        </PatternSet>
                                        <xsl:call-template name="print-translations">
                                            <xsl:with-param name="pattern-cells" select="$pattern-cells" />
                                            <xsl:with-param name="translations" select="Translations" />
                                        </xsl:call-template>
                                    </PatternSets>
                                </PreProcessedCellPattern>
                            </xsl:for-each>
                        </PreProcessedCellPatterns>
                    </FileContents>
                </FileSetFile>
            </FileSetFiles>
        </FileSet>
    </xsl:template>

    <xsl:template name="print-translations">
        <xsl:param name="pattern-cells" />
        <xsl:param name="translations" />
        <xsl:variable name="next-translation" select="substring-before(concat(translate($translations, ' ', ''), ';'), ';')" />
        <xsl:variable name="more-translations" select="substring-after($translations, ';')" />
        <xsl:if test="string-length($next-translation) = 2">
            <xsl:call-template name="print-translation">
                <xsl:with-param name="translation" select="$next-translation" />
                <xsl:with-param name="pattern-cells" select="$pattern-cells" />
                <xsl:with-param name="more-translations" select="$more-translations" />
            </xsl:call-template>
        </xsl:if>
    </xsl:template>

    <xsl:template name="print-translation">
        <xsl:param name="pattern-cells" />
        <xsl:param name="field" />
        <xsl:param name="translation" />
        <xsl:param name="more-translations" />
        <xsl:call-template name="transform-and-print">
            <xsl:with-param name="pattern-cells" select="$pattern-cells" />
            <xsl:with-param name="transform-name" select="$translations[Id = substring($translation, 2, 1)]/Name" />
            <xsl:with-param name="repeat" select="substring($translation, 1, 1)" />
            <xsl:with-param name="more-translations" select="$more-translations" />
        </xsl:call-template>
    </xsl:template>

    <xsl:template name="transform-and-print">
        <xsl:param name="pattern-cells" />
        <xsl:param name="field" />
        <xsl:param name="transform-name" />
        <xsl:param name="more-translations" />
        <xsl:param name="repeat" select="0" />
        <xsl:variable name="transformed1">
            <xsl:call-template name="transform-cells">
                <xsl:with-param name="pattern-cells" select="$pattern-cells" />
                <xsl:with-param name="transform-name" select="concat($transform-name, 'Index')" />
            </xsl:call-template>
        </xsl:variable>
        <xsl:variable name="transformed" select="msxsl:node-set($transformed1)/*" />
        <PV>
            <xsl:value-of select="$transform-name" />
        </PV>
        <PatternSet>
            <TransformName>
                <xsl:value-of select="$transform-name"/>
            </TransformName>
            <xsl:copy-of select="$transformed"/>
        </PatternSet>
        <xsl:choose>
            <xsl:when test="$repeat > 1">
                <xsl:call-template name="transform-and-print">
                    <xsl:with-param name="pattern-cells" select="$transformed" />
                    <xsl:with-param name="transform-name" select="$transform-name" />
                    <xsl:with-param name="repeat" select="$repeat - 1" />
                    <xsl:with-param name="more-translations" select="$more-translations" />
                </xsl:call-template>
            </xsl:when>
            <xsl:when test="string-length($more-translations) > 0">
                <xsl:call-template name="print-translations">
                    <xsl:with-param name="pattern-cells" select="$transformed" />
                    <xsl:with-param name="translations" select="$more-translations" />
                </xsl:call-template>
            </xsl:when>
        </xsl:choose>

    </xsl:template>

    <xsl:template name="get-cells">
        <xsl:param name="pattern-cells" />
        <xsl:param name="pattern-string" />
        <xsl:for-each select="$pattern-cells">
                            <xsl:sort select="SortOrder" />
            <xsl:variable name="pattern-cell" select="." />
            <Cell>
                <xsl:copy-of select="CellIndex"/>
                <xsl:variable name="test-pattern" select="concat(';', translate($pattern-string, ' ', ''), ';')" />
                <xsl:variable name="looking-for" select="concat(';', $pattern-cell/CellIndex)" />
                <xsl:variable name="find-pattern" select="substring-before(substring-after($test-pattern, $looking-for), ';')" />
                <xsl:if test="string-length($find-pattern) > 0">
                    <PatternCellStateId>
                        <xsl:value-of select="$cell-states[Id = $find-pattern]/Id" />
                    </PatternCellStateId>
                </xsl:if>
            </Cell>
        </xsl:for-each>
    </xsl:template>

    <xsl:template name="transform-cells">
        <xsl:param name="pattern-cells" />
        <xsl:param name="transform-name" />
        <xsl:for-each select="$cells">
            <xsl:variable name="transformed-index" select="*[name() = $transform-name]" />
            <xsl:variable name="transformed-cell" select="$pattern-cells[CellIndex = $transformed-index]" />
            <xsl:if test="count($cells[CellIndex = $transformed-index]) > 0">
            <Cell>
                <xsl:copy-of select="CellIndex" />
                <PatternCellStateId>
                    <xsl:value-of select="$transformed-cell/PatternCellStateId" />
                </PatternCellStateId>
            </Cell>
            </xsl:if>
        </xsl:for-each>
    </xsl:template>



</xsl:stylesheet>
