Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraMap

Namespace Colorizer

	Partial Public Class Form1
		Inherits Form

		Private shapefilePath As String = "../../Data/Countries.shp"

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' Create a map control and add it to the form.
			Dim map As New MapControl()
			map.Dock = DockStyle.Fill
			Me.Controls.Add(map)

			' Specify the map's initial view.
			map.ZoomLevel = 2
			map.CenterPoint = New GeoPoint(38, -100)

			' Create a layer to display shape data.
			Dim fileLayer As New VectorFileLayer()
			map.Layers.Add(fileLayer)

			fileLayer.FileLoader = CreateShapefileLoader()
			fileLayer.Colorizer = CreateGDPColorizer()

			' Create a legend.
			map.Legends.Add(CreateGDPLegend(fileLayer))
		End Sub

		Private Function CreateShapefileLoader() As ShapefileLoader
			' Create an object to load data from a Shapefile.
			Dim loader As New ShapefileLoader()

			' Determine the path to the Shapefile.
			Dim baseUri As New Uri(System.Reflection.Assembly.GetEntryAssembly().Location)
			loader.FileUri = New Uri(baseUri, shapefilePath)
			Return loader
		End Function

		Private Function CreateGDPColorizer() As ChoroplethColorizer
			' Create a Choropleth colorizer.
			Dim colorizer As New ChoroplethColorizer()

			' Specify the attribute that provides data values for the colorizer.
			colorizer.ValueProvider = New ShapeAttributeValueProvider() With {.AttributeName = "GDP_MD_EST"}

			' Specify range stops for the colorizer.
			colorizer.RangeStops.AddRange(New List(Of Double) (New Double() {0, 3000, 10000, 18000, 28000, 44000, 82000, 185000, 1000000, 2500000, 15000000}))

			' Specify colors for the colorizer.
			colorizer.ColorItems.AddRange(New List(Of ColorizerColorItem) (New ColorizerColorItem() {New ColorizerColorItem(Color.FromArgb(&H5F, &H8B, &H95)), New ColorizerColorItem(Color.FromArgb(&H79, &H96, &H89)), New ColorizerColorItem(Color.FromArgb(&HA2, &HA8, &H75)), New ColorizerColorItem(Color.FromArgb(&HCE, &HBB, &H5F)), New ColorizerColorItem(Color.FromArgb(&HF2, &HCB, &H4E)), New ColorizerColorItem(Color.FromArgb(&HF1, &HC1, &H49)), New ColorizerColorItem(Color.FromArgb(&HE5, &HA8, &H4D)), New ColorizerColorItem(Color.FromArgb(&HD6, &H86, &H4E)), New ColorizerColorItem(Color.FromArgb(&HC5, &H64, &H50)), New ColorizerColorItem(Color.FromArgb(&HBA, &H4D, &H51))}))


			Return colorizer
		End Function

		Private Function CreateGDPLegend(ByVal layer As MapItemsLayerBase) As ColorScaleLegend
			' Create a color scale legend and adjust its properties.
			Dim legend As New ColorScaleLegend()
			legend.Header = "GDP by Countries"
			legend.Description = "In US dollars"
			legend.RangeStopsFormat = "0,B"
			legend.Layer = layer

			Return legend
		End Function
	End Class
End Namespace

