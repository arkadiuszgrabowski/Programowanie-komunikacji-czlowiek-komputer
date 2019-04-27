<?xml version="1.0" encoding="utf-8" ?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:date="http://exslt.org/dates-and-times" extension-element-prefixes="date">
    <xsl:output method="text" />
    <xsl:template match="text()">
        <xsl:if test="normalize-space(.)">
            <xsl:value-of select="concat(normalize-space(.), '')" />
        </xsl:if>
        <xsl:apply-templates />
    </xsl:template>
    <xsl:template match="/">
        <xsl:text>Report:</xsl:text>
        <xsl:apply-templates />
    </xsl:template>
    <xsl:template match="Authors">
        <xsl:text>&#xA;Authors:&#xA;</xsl:text>
        <xsl:apply-templates select="Author" />
    </xsl:template>
    <xsl:template match="Author">
        <xsl:value-of select="./Forename" />
        <xsl:text> </xsl:text>
        <xsl:value-of select="./Name" />
        <xsl:text> (</xsl:text>
        <xsl:value-of select="./ID" />
        <xsl:text>) &#xA;</xsl:text>
    </xsl:template>
    <xsl:template match="ReportDate">
        <xsl:text>Generated: </xsl:text>
        <xsl:value-of select="substring(.,14,10)" />
    </xsl:template>
    <xsl:template match="Report">
        <xsl:apply-templates select="Authors" />
        <xsl:apply-templates select="ReportDate" />
        <xsl:text>&#xA;</xsl:text>
        <xsl:text>Number of types of products:&#xA;</xsl:text>
        <xsl:value-of select="./Stats/NumberOfTypesOfProducts" />
        <xsl:text>&#xA;</xsl:text>
        <xsl:text>Amount of sold products:&#xA;</xsl:text>
        <xsl:value-of select="./Stats/AmountOfSoldProducts" />
        <xsl:text>&#xA;</xsl:text>
        <xsl:text>Total price of orders:&#xA;</xsl:text>
        <xsl:value-of select="./Stats/TotalPriceOfOrders" />
        <xsl:text>&#xA;</xsl:text>
        <xsl:text>Orders:&#xA;</xsl:text>
        <xsl:text>&#x9;Closed:&#xA;</xsl:text>
        <xsl:for-each select="./ClosedOrders/OrderId">
            <xsl:text>&#x9;&#x9;</xsl:text>
            <xsl:value-of select="node()" />
            <xsl:text>&#xA;</xsl:text>
        </xsl:for-each>
        <xsl:text>&#x9;Canceled:&#xA;</xsl:text>
        <xsl:for-each select="./CanceledOrders/OrderId">
            <xsl:text>&#x9;&#x9;</xsl:text>
            <xsl:value-of select="node()" />
            <xsl:text>&#xA;</xsl:text>
        </xsl:for-each>
        <xsl:text>&#x9;New:&#xA;</xsl:text>
        <xsl:for-each select="./NewOrders/OrderId">
            <xsl:text>&#x9;&#x9;</xsl:text>
            <xsl:value-of select="node()" />
            <xsl:text>&#xA;</xsl:text>
        </xsl:for-each>
        <xsl:text>&#x9;Processing:&#xA;</xsl:text>
        <xsl:for-each select="./ProcessingOrders/OrderId">
            <xsl:text>&#x9;&#x9;</xsl:text>
            <xsl:value-of select="node()" />
            <xsl:text>&#xA;</xsl:text>
        </xsl:for-each>
        <xsl:text>&#x9;Complete:&#xA;</xsl:text>
        <xsl:for-each select="./CompletedOrders/OrderId">
            <xsl:text>&#x9;&#x9;</xsl:text>
            <xsl:value-of select="node()" />
            <xsl:text>&#xA;</xsl:text>
        </xsl:for-each>
    </xsl:template>
</xsl:stylesheet>