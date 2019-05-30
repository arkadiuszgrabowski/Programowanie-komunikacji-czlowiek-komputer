<?xml version="1.0" encoding="UTF-8" ?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:svg="http://www.w3.org/2000/svg" xmlns="http://www.w3.org/2000/svg" version="1.0">
    <script type="text/javascript" src="authors.js"/>
    <xsl:output method="xml" media-type="image/svg" encoding="utf-8" doctype-public="-//W3C//DTD SVG 1.1//EN" doctype-system="http://www.w3.org/TR/2001/REC-SVG-20010904/DTD/svg10.dtd" />
    <xsl:template match="/">
        <svg:svg width="800" height="600" font-family="Calibri">
            <svg:title>
                Shop orders report
            </svg:title>
            <rect x="100" y="30" width="400" height="320" fill="#F5DA81" stroke="black" />
            <rect x="110" y="70" width="{count(/Generated/Report/ClosedOrders/OrderId)*40}" height="30" fill="blue" />
            <svg:text x="490" y="90" fill="black" font-weight="bold" text-anchor="middle">
                <xsl:value-of select="count(/Generated/Report/ClosedOrders/OrderId)" />
            </svg:text>
            <rect x="110" y="110" width="{count(/Generated/Report/CanceledOrders/OrderId)*40}" height="30" fill="#DF0101" />
            <svg:text x="490" y="130" fill="black" font-weight="bold" text-anchor="middle">
                <xsl:value-of select="count(/Generated/Report/CanceledOrders/OrderId)" />
            </svg:text>
            <rect x="110" y="150" width="{count(/Generated/Report/NewOrders/OrderId)*40}" height="30" fill="#000000" />
            <svg:text x="490" y="170" fill="black" font-weight="bold" text-anchor="middle">
                <xsl:value-of select="count(/Generated/Report/NewOrders/OrderId)" />
            </svg:text>
            <rect x="110" y="190" width="{count(/Generated/Report/ProcessingOrders/OrderId)*40}" height="30" fill="#01DF01" />
            <svg:text x="490" y="210" fill="black" font-weight="bold" text-anchor="middle">
                <xsl:value-of select="count(/Generated/Report/ProcessingOrders/OrderId)" />
            </svg:text>
            <rect x="110" y="230" width="{count(/Generated/Report/CompletedOrders/OrderId)*40}" height="30" fill="#FF00BF" />
            <svg:text x="490" y="250" fill="black" font-weight="bold" text-anchor="middle">
                <xsl:value-of select="count(/Generated/Report/CompletedOrders/OrderId)" />
            </svg:text>
            <svg:text x="300" y="50" font-size="18" fill="black" font-weight="bold" text-anchor="middle">
                Shop orders report
            </svg:text>
            <line id="axis-y" x1="105" y1="60" x2="105" y2="270" style="fill:none;stroke:rgb(0,0,0);stroke-width:2" />
            <line id="axis-x" x1="105" y1="270" x2="490" y2="270" style="fill:none;stroke:rgb(0,0,0);stroke-width:2" />
            <svg:text x="300" y="290" font-size="18" fill="black" font-weight="bold" text-anchor="middle">
                Legend
            </svg:text>
            <rect x="120" y="300" width="40" height="20" fill="blue" stroke="black" />
            <svg:text x="140" y="330" fill="black" font-weight="bold" font-size="12" text-anchor="middle">
                Closed
            </svg:text>
            <rect x="200" y="300" width="40" height="20" fill="#DF0101" stroke="black" />
            <svg:text x="220" y="330" fill="black" font-weight="bold" font-size="12" text-anchor="middle">
                Canceled
            </svg:text>
            <rect x="280" y="300" width="40" height="20" fill="#000000" stroke="black" />
            <svg:text x="300" y="330" fill="black" font-weight="bold" font-size="12" text-anchor="middle">
                New
            </svg:text>
            <rect x="360" y="300" width="40" height="20" fill="#01DF01" stroke="black" />
            <svg:text x="380" y="330" fill="black" font-weight="bold" font-size="12" text-anchor="middle">
                Processing
            </svg:text>
            <rect x="440" y="300" width="40" height="20" fill="#FF00BF" stroke="black" />
            <svg:text x="460" y="330" fill="black" font-weight="bold" font-size="12" text-anchor="middle">
                Completed
            </svg:text>
            <svg:g class="btn" onclick="alert('Authors:\nArkadiusz Grabowski 210191\nKacper Prądzyński 210299')" cursor="pointer">
                <svg:rect x="270" y="360" width="60" height="20" fill="blue" stroke="black" />
                <svg:text x="274" y="375" fill="white" font-weight="bold" font-size="16">Authors</svg:text>
            </svg:g>
            
        </svg:svg>
    </xsl:template>
    
    
</xsl:stylesheet>