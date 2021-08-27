<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128576138/13.2.8%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4691)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Colorizer/Form1.cs) (VB: [Form1.vb](./VB/Colorizer/Form1.vb))
<!-- default file list end -->
# How to colorize map contours loaded from Shapefiles using the Choropleth colorizer 


<p>This example demonstrates how to paint each map contour in a specific color depending on GDP data from Shapefiles (<strong>Countries.dbf</strong>, <strong>Countries.shp</strong>).</p>


<h3>Description</h3>

<p>For this, create a colorizer (choropleth colorizer or graph colorizer) and assign it to the <strong>VectorFileLayer.Colorizer </strong>property. </p><p><br />
In this example the CreateGDPColorizer method is used to create a choropleth colorizer and customize its properties.</p><p><br />
To access GDP information from Shapefiles, assign a <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapShapeAttributeValueProvidertopic"><u>ShapeAttributeValueProvider</u></a> object with the specified attribute name (<a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapShapeAttributeValueProvider_AttributeNametopic"><u>ShapeAttributeValueProvider.AttributeName</u></a>) to the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapChoroplethColorizer_ValueProvidertopic"><u>ChoroplethColorizer.ValueProvider</u></a> property.</p><p>Then, add range stops (data splits in ranges) for the colorizer to the <strong>DoubleCollection</strong> object that can be accessed via the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapChoroplethColorizer_RangeStopstopic"><u>ChoroplethColorizer.RangeStops</u></a> property.</p><p><br />
Finally, specify the desired set of colors in the <strong>ColorCollection</strong> object that is accessed via the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapMapColorizer_Colorstopic"><u>MapColorizer.Colors</u></a> property. The colorizer automatically associates each color with the specified data range to colorize map shapes. </p><p><br />
If you wish to see the information on what each color means when map shapes are colored by the colorizer, create a color scale legend. For this, assign a <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapColorScaleLegendtopic"><u>ColorScaleLegend</u></a> object to the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapChoroplethColorizer_Legendtopic"><u>ChoroplethColorizer.Legend</u></a> property. After that specify the legend description, header and range stop format using the legend&#39;s corresponding properties. </p><p><br />
</p>

<br/>


