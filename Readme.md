<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128576138/14.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4691)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# How to Colorize Map Contours Loaded from Shapefiles Using the Choropleth Colorizer

This example paints each map contour in a specific color based on GDP data loaded from Shapefiles (**Countries.dbf**, **Countries.shp**).

To colorize map shapes, create a colorizer (for example, a **choropleth colorizer** or **graph colorizer**) and assign it to the [`VectorFileLayer.Colorizer`](https://docs.devexpress.com/WindowsForms/DevExpress.XtraMap.VectorItemsLayer.Colorizer) property.

In this example, the `CreateColorizer` method is used to create and configure a choropleth colorizer.

### Accessing GDP Data from Shapefiles

Follow the steps below to retrieve GDP values from Shapefiles.

1. Create a [`ShapeAttributeValueProvider`](https://docs.devexpress.com/WindowsForms/DevExpress.XtraMap.ShapeAttributeValueProvider) and use the [`ShapeAttributeValueProvider.AttributeName`](https://docs.devexpress.com/WindowsForms/DevExpress.XtraMap.ShapeAttributeValueProvider.AttributeName) property to specify the attribute name.
2. Assign the provider to the [`ChoroplethColorizer.ValueProvider`](https://docs.devexpress.com/WindowsForms/DevExpress.XtraMap.ChoroplethColorizer.ValueProvider) property.
3. Add range stops to the [`ChoroplethColorizer.RangeStops`](https://docs.devexpress.com/WindowsForms/DevExpress.XtraMap.ChoroplethColorizer.RangeStops) collection to define data ranges.
4. Specify colors for each range with the [`MapColorizer.ColorItems`](https://docs.devexpress.com/WindowsForms/DevExpress.XtraMap.MapColorizer.ColorItems) collection (`GenericColorizerColorItemCollection<ColorizerColorItem>`).

The colorizer automatically associates each color with the corresponding data range and applies it to map shapes.

### Adding a Color Scale Legend

To display information about what each color represents:

1. Create a [`ColorScaleLegend`](https://docs.devexpress.com/WindowsForms/DevExpress.XtraMap.ColorScaleLegend).
2. Assign the target layer to the [`ColorScaleLegend.Layer`](https://docs.devexpress.com/WindowsForms/DevExpress.XtraMap.ItemsLayerLegend.Layer) property.
3. Assign the legend to the [`ChoroplethColorizer.Legend`](https://docs.devexpress.com/WindowsForms/DevExpress.XtraMap.ChoroplethColorizer.Legend) property.
4. Configure the legend header, description, and range stop format using the corresponding properties.

<!-- default file list -->
## Files to Review

**[Form1.cs](./CS/Colorizer/Form1.cs) (VB: [Form1.vb](./VB/Colorizer/Form1.vb))**
<!-- default file list end -->

<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-map-create-choropleth-map-based-on-shapefile&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-map-create-choropleth-map-based-on-shapefile&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
