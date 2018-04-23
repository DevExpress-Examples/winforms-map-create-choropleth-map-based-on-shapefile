# How to colorize map contours loaded from Shapefiles using the Choropleth colorizer 


<p>This example demonstrates how to paint each map contour in a specific color depending on GDP data from Shapefiles (<strong>Countries.dbf</strong>, <strong>Countries.shp</strong>).</p>


<h3>Description</h3>

<p>For this, create a colorizer (a choropleth colorizer or graph colorizer) and assign it to the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapVectorItemsLayer_Colorizertopic">VectorFileLayer.Colorizer</a>&nbsp;property.<br />In this example, the CreateColorizer method is used to create a choropleth colorizer and customize its properties.</p>
<p>To access GDP information from Shapefiles, assign a <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapShapeAttributeValueProvidertopic">ShapeAttributeValueProvider</a> object with the specified attribute name (<a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapShapeAttributeValueProvider_AttributeNametopic">ShapeAttributeValueProvider.AttributeName</a>) to the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapChoroplethColorizer_ValueProvidertopic">ChoroplethColorizer.ValueProvider</a> property.<br />Then, add range stops (data splits in ranges) for the colorizer to the <strong>DoubleCollection</strong> object, which can be accessed via the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapChoroplethColorizer_RangeStopstopic">ChoroplethColorizer.RangeStops</a> property.<br />Finally, specify the desired set of colors in the&nbsp;<a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapGenericColorizerItemCollection~T~topic">GenericColorizerColorItemCollection&lt;ColorizerColorItem&gt;</a> object, which is accessed via the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapChoroplethColorizer_ColorItemstopic">MapColorizer.ColorItems</a> property. The colorizer automatically associates each color with the specified data range to colorize map shapes.</p>
<p><br />If you wish to see information on what each color means when map shapes are colored by the colorizer, create a color scale legend. For this, create a <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapColorScaleLegendtopic">ColorScaleLegend</a> object,&nbsp;assign <strong>VectorFileLayer</strong>&nbsp;to the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapItemsLayerLegend_Layertopic">ColorScaleLegend.Layer</a> property of the object and set the legend to the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapChoroplethColorizer_Legendtopic">ChoroplethColorizer.Legend</a> property. After that, specify the legend description, header and range stop format using the corresponding legend properties.</p>

<br/>


