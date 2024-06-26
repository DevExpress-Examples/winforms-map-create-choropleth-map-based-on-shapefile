<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128576138/14.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4691)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[Form1.cs](./CS/Colorizer/Form1.cs) (VB: [Form1.vb](./VB/Colorizer/Form1.vb))**
<!-- default file list end -->
# How to colorize map contours loaded from Shapefiles using the Choropleth colorizer 


<p>This example demonstrates how to paint each map contour in a specific color depending on GDP data from Shapefiles (<strong>Countries.dbf</strong>, <strong>Countries.shp</strong>).</p>


<h3>Description</h3>

For this, create a colorizer (a choropleth colorizer or graph colorizer) and assign it to the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapVectorItemsLayer_Colorizertopic">VectorFileLayer.Colorizer</a>&nbsp;property.<br />In this example, the CreateColorizer method is used to create a choropleth colorizer and customize its properties.
<p>&nbsp;</p>
<p>To access GDP information from Shapefiles, assign a <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapShapeAttributeValueProvidertopic">ShapeAttributeValueProvider</a> object with the specified attribute name (<a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapShapeAttributeValueProvider_AttributeNametopic">ShapeAttributeValueProvider.AttributeName</a>) to the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapChoroplethColorizer_ValueProvidertopic">ChoroplethColorizer.ValueProvider</a> property.<br />Then, add range stops (data splits in ranges) for the colorizer to the <strong>DoubleCollection</strong> object, which can be accessed via the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapChoroplethColorizer_RangeStopstopic">ChoroplethColorizer.RangeStops</a> property.<br />Finally, specify the desired set of colors in the&nbsp;<a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapGenericColorizerItemCollection~T~topic">GenericColorizerColorItemCollection&lt;ColorizerColorItem&gt;</a> object, which is accessed via the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapChoroplethColorizer_ColorItemstopic">MapColorizer.ColorItems</a> property. The colorizer automatically associates each color with the specified data range to colorize map shapes.</p>
<p><br />If you wish to see information on what each color means when map shapes are colored by the colorizer, create a color scale legend. For this, create a <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapColorScaleLegendtopic">ColorScaleLegend</a> object,&nbsp;assign <strong>VectorFileLayer</strong>&nbsp;to the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapItemsLayerLegend_Layertopic">ColorScaleLegend.Layer</a> property of the object and set the legend to the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapChoroplethColorizer_Legendtopic">ChoroplethColorizer.Legend</a> property. After that, specify the legend description, header and range stop format using the corresponding legend properties.</p>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-map-create-choropleth-map-based-on-shapefile&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-map-create-choropleth-map-based-on-shapefile&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
