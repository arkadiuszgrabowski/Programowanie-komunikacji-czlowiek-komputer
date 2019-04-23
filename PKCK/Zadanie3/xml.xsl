<?xml version="1.0" encoding="UTF-8" ?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:date="http://exslt.org/dates-and-times" extension-element-prefixes="date">
    <xsl:output method="xml" version="1.0" encoding="UTF-8" media-type="text/xml" omit-xml-declaration="no" indent="yes"></xsl:output>
    <xsl:key use="@ProductId" name="ProductId" match="//ProductsRepository/Product" />
    <xsl:template match="node()|@*">
        <xsl:copy>
            <xsl:apply-templates select="*[not(node())]" />
        </xsl:copy>
    </xsl:template>
    <xsl:template match="/">
        <xsl:element name="Generated">
            <xsl:apply-templates />
            <Report>
                <Stats>
                    <NumberOfTypesOfProducts>
                        <xsl:value-of select="count(//Company/ProductsRepository/Product/@ProductId)" />
                    </NumberOfTypesOfProducts>
                    <AmountOfSoldProducts>
                        <xsl:value-of select="sum(//Company/Orders/Order/Items/Item/Quantity)" />
                    </AmountOfSoldProducts>
                    <TotalPriceOfOrders>
                        <xsl:value-of select="concat(sum(//Company/Orders/Order/OrderPrice), 'zł')" />
                    </TotalPriceOfOrders>
                </Stats>
                <ClosedOrders>
                    <xsl:for-each select="//Company/Orders/Order[@OrderType = 'Closed']">
                        <OrderId>
                            <xsl:value-of select="@OrderId" />
                        </OrderId>
                    </xsl:for-each>
                </ClosedOrders>
                <CanceledOrders>
                    <xsl:for-each select="//Company/Orders/Order[@OrderType = 'Canceled']">
                        <OrderId>
                            <xsl:value-of select="@OrderId" />
                        </OrderId>
                    </xsl:for-each>
                </CanceledOrders>
                <NewOrders>
                    <xsl:for-each select="//Company/Orders/Order[@OrderType = 'New']">
                        <OrderId>
                            <xsl:value-of select="@OrderId" />
                        </OrderId>
                    </xsl:for-each>
                </NewOrders>
                <ProcessingOrders>
                    <xsl:for-each select="//Company/Orders/Order[@OrderType = 'Processing']">
                        <OrderId>
                            <xsl:value-of select="@OrderId" />
                        </OrderId>
                    </xsl:for-each>
                </ProcessingOrders>
                <CompletedOrders>
                    <xsl:for-each select="//Company/Orders/Order[@OrderType = 'Complete']">
                        <OrderId>
                            <xsl:value-of select="@OrderId" />
                        </OrderId>
                    </xsl:for-each>
                </CompletedOrders>
                <Authors>
                    <xsl:for-each select="//Company/Authors/Author">
                        <Author>
                            <Forename>
                                <xsl:value-of select="@Forename" />
                            </Forename>
                            <Name>
                                <xsl:value-of select="@Name" />
                            </Name>
                            <ID>
                                <xsl:value-of select="@AuthorId" />
                            </ID>
                        </Author>
                    </xsl:for-each>
                </Authors>
                <ReportDate>
                    <Date>
                        <xsl:value-of select="date:date-time()" />
                    </Date>
                </ReportDate>
            </Report>
        </xsl:element>
    </xsl:template>
</xsl:stylesheet>