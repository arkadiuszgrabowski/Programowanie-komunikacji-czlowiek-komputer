<?xml version="1.0" encoding="utf-8" ?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns="http://www.w3.org/1999/xhtml">
    <xsl:output method="xml" version="1.0" encoding="utf-8" doctype-public="-//W3C//DTD XHTML 1.0 Strict//EN" doctype-system="http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd" />
    <xsl:template match="/">
        <xsl:element name="html">
            <xsl:copy-of select="document('')/xsl:stylesheet/namespace::*[not(local-name() = 'xsl')]" />
            <xsl:attribute name="xml:lang">pl</xsl:attribute>
            <xsl:attribute name="lang">pl</xsl:attribute>
            <xsl:element name="head">
                <xsl:element name="meta">
                    <xsl:attribute name="name">
                        <xsl:text>description</xsl:text>
                    </xsl:attribute>
                    <xsl:attribute name="content">
                        <xsl:text>Shop report</xsl:text>
                    </xsl:attribute>
                </xsl:element>
                <xsl:element name="meta">
                    <xsl:attribute name="name">
                        <xsl:text>author</xsl:text>
                    </xsl:attribute>
                    <xsl:attribute name="content">
                        <xsl:text>Arkadiusz Grabowski, Kacper Prądzyński</xsl:text>
                    </xsl:attribute>
                </xsl:element>
                <xsl:element name="meta">
                    <xsl:attribute name="http-equiv">
                        <xsl:text>content-type</xsl:text>
                    </xsl:attribute>
                    <xsl:attribute name="content">
                        <xsl:text>text/html;charset=UTF-8</xsl:text>
                    </xsl:attribute>
                </xsl:element>
                <xsl:element name="title">
                    <xsl:text>Report XHTML</xsl:text>
                </xsl:element>
                <xsl:element name="link">
                    <xsl:attribute name="rel">
                        <xsl:text>stylesheet</xsl:text>
                    </xsl:attribute>
                    <xsl:attribute name="type">
                        <xsl:text>text/css</xsl:text>
                    </xsl:attribute>
                    <xsl:attribute name="href">
                        <xsl:text>report.css</xsl:text>
                    </xsl:attribute>
                </xsl:element>
            </xsl:element>
            <xsl:element name="body">
                <xsl:element name="div">
                    <xsl:attribute name="class">
                        <xsl:text>links</xsl:text>
                    </xsl:attribute>
                    <xsl:element name="a">
                        <xsl:attribute name="href">
                            <xsl:text>#authors</xsl:text>
                        </xsl:attribute>
                        <xsl:attribute name="class">
                            <xsl:text>links</xsl:text>
                        </xsl:attribute>
                        <xsl:text>Authors</xsl:text>
                    </xsl:element>
                    <xsl:text>&#x9;|&#x9;</xsl:text>
                    <xsl:element name="a">
                        <xsl:attribute name="href">
                            <xsl:text>#report</xsl:text>
                        </xsl:attribute>
                        <xsl:attribute name="class">
                            <xsl:text>links</xsl:text>
                        </xsl:attribute>
                        <xsl:text>Report</xsl:text>
                    </xsl:element>
                </xsl:element>
                <xsl:apply-templates />
            </xsl:element>
        </xsl:element>
    </xsl:template>
    <xsl:template match="Authors">
        <xsl:element name="div">
            <xsl:attribute name="class">
                <xsl:text>authors</xsl:text>
            </xsl:attribute>
            <xsl:element name="p">
                <xsl:attribute name="class">
                    <xsl:text>authors-title</xsl:text>
                </xsl:attribute>
                <xsl:element name="a">
                    <xsl:attribute name="name">
                        <xsl:text>authors</xsl:text>
                    </xsl:attribute>
                    <xsl:text>Authors:&#x20;</xsl:text>
                </xsl:element>
            </xsl:element>
            <xsl:apply-templates />
        </xsl:element>
    </xsl:template>
    <xsl:template match="Author">
        <xsl:element name="p">
            <xsl:attribute name="class">
                <xsl:text>author</xsl:text>
            </xsl:attribute>
            <xsl:value-of select="./@Forename" />
            <xsl:text>&#x20;</xsl:text>
            <xsl:value-of select="./@Name" />
            <xsl:text>&#x20;(</xsl:text>
            <xsl:value-of select="./@AuthorId" />
            <xsl:text>)</xsl:text>
        </xsl:element>
    </xsl:template>
    <xsl:template match="ProductsRepository">
        <xsl:element name="div">
            <xsl:attribute name="class">
                <xsl:text>report</xsl:text>
            </xsl:attribute>
            <xsl:element name="p">
                <xsl:attribute name="class">
                    <xsl:text>report-title</xsl:text>
                </xsl:attribute>
                <xsl:text>Report: </xsl:text>
            </xsl:element>
        </xsl:element>
        <xsl:element name="p">
            <xsl:attribute name="class">
                <xsl:text>types-of-products</xsl:text>
            </xsl:attribute>
            <xsl:text>Number of types of products: </xsl:text>
            <xsl:value-of select="count(/Company/ProductsRepository/Product)" />
        </xsl:element>
    </xsl:template>
    <xsl:template match="Orders">
        <xsl:element name="p">
            <xsl:attribute name="class">
                <xsl:text>sold-products</xsl:text>
            </xsl:attribute>
            <xsl:text>Amount of sold products: </xsl:text>
            <xsl:value-of select="sum(/Company/Orders/Order/Items/Item/Quantity)" />
        </xsl:element>
        <xsl:element name="p">
            <xsl:attribute name="class">
                <xsl:text>total-value</xsl:text>
            </xsl:attribute>
            <xsl:text>Value of ordered products: </xsl:text>
            <xsl:value-of select="concat(sum(/Company/Orders/Order/OrderPrice), 'zł')" />
        </xsl:element>
        <xsl:element name="div">
            <xsl:attribute name="class">
                <xsl:text>orders</xsl:text>
            </xsl:attribute>
            <xsl:element name="h4">
                <xsl:text>Orders:</xsl:text>
            </xsl:element>
            <xsl:element name="div">
                <xsl:attribute name="class">
                    <xsl:text>new</xsl:text>
                </xsl:attribute>
                <xsl:element name="p">
                    <xsl:attribute name="class">
                        <xsl:text>order-type</xsl:text>
                    </xsl:attribute>
                    <xsl:text>New:</xsl:text>
                    <xsl:for-each select="/Company/Orders/Order[@OrderType = 'New']">
                        <xsl:element name="p">
                            <xsl:attribute name="class">
                                <xsl:text>order-id</xsl:text>
                            </xsl:attribute>
                            <xsl:value-of select="@OrderId"></xsl:value-of>
                        </xsl:element>
                    </xsl:for-each>
                </xsl:element>
            </xsl:element>
            <xsl:element name="div">
                <xsl:attribute name="class">
                    <xsl:text>processing</xsl:text>
                </xsl:attribute>
                <xsl:element name="p">
                    <xsl:attribute name="class">
                        <xsl:text>order-type</xsl:text>
                    </xsl:attribute>
                    <xsl:text>Processing:</xsl:text>
                    <xsl:for-each select="/Company/Orders/Order[@OrderType = 'Processing']">
                        <xsl:element name="p">
                            <xsl:attribute name="class">
                                <xsl:text>order-id</xsl:text>
                            </xsl:attribute>
                            <xsl:value-of select="@OrderId"></xsl:value-of>
                        </xsl:element>
                    </xsl:for-each>
                </xsl:element>
            </xsl:element>
            <xsl:element name="div">
                <xsl:attribute name="class">
                    <xsl:text>completed</xsl:text>
                </xsl:attribute>
                <xsl:element name="p">
                    <xsl:attribute name="class">
                        <xsl:text>order-type</xsl:text>
                    </xsl:attribute>
                    <xsl:text>Completed:</xsl:text>
                    <xsl:for-each select="/Company/Orders/Order[@OrderType = 'Complete']">
                        <xsl:element name="p">
                            <xsl:attribute name="class">
                                <xsl:text>order-id</xsl:text>
                            </xsl:attribute>
                            <xsl:value-of select="@OrderId"></xsl:value-of>
                        </xsl:element>
                    </xsl:for-each>
                </xsl:element>
            </xsl:element>
            <xsl:element name="div">
                <xsl:attribute name="class">
                    <xsl:text>closed</xsl:text>
                </xsl:attribute>
                <xsl:element name="p">
                    <xsl:attribute name="class">
                        <xsl:text>order-type</xsl:text>
                    </xsl:attribute>
                    <xsl:text>Closed:</xsl:text>
                    <xsl:for-each select="/Company/Orders/Order[@OrderType = 'Closed']">
                        <xsl:element name="p">
                            <xsl:attribute name="class">
                                <xsl:text>order-id</xsl:text>
                            </xsl:attribute>
                            <xsl:value-of select="@OrderId"></xsl:value-of>
                        </xsl:element>
                    </xsl:for-each>
                </xsl:element>
            </xsl:element>
            <xsl:element name="div">
                <xsl:attribute name="class">
                    <xsl:text>canceled</xsl:text>
                </xsl:attribute>
                <xsl:element name="p">
                    <xsl:attribute name="class">
                        <xsl:text>order-type</xsl:text>
                    </xsl:attribute>
                    <xsl:text>Canceled:</xsl:text>
                    <xsl:for-each select="/Company/Orders/Order[@OrderType = 'Canceled']">
                        <xsl:element name="p">
                            <xsl:attribute name="class">
                                <xsl:text>order-id</xsl:text>
                            </xsl:attribute>
                            <xsl:value-of select="@OrderId"></xsl:value-of>
                        </xsl:element>
                    </xsl:for-each>
                </xsl:element>
            </xsl:element>
        </xsl:element>
    </xsl:template>
</xsl:stylesheet>