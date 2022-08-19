Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraMap

Namespace Colorizer

    Public Partial Class Form1
        Inherits Form

        Private shapefilePath As String = "../../Data/Countries.shp"

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            ' Create a map control and specify its dock style.
            Dim map As MapControl = New MapControl()
            map.Dock = DockStyle.Fill
            ' Specify the map's initial view.  
            map.ZoomLevel = 2
            map.CenterPoint = New GeoPoint(38, -100)
            ' Create a file layer and assign a shape loader to it.
            Dim fileLayer As VectorFileLayer = New VectorFileLayer()
            map.Layers.Add(fileLayer)
            fileLayer.FileLoader = CreateShapefileLoader()
            ' Create a colorizer.
            fileLayer.Colorizer = CreateGDPColorizer()
            ' Add the map control to the window. 
            Me.Controls.Add(map)
        End Sub

        Private Function CreateShapefileLoader() As ShapefileLoader
            ' Create an object to load data from a shapefile.
            Dim loader As ShapefileLoader = New ShapefileLoader()
            ' Determine the path to the Shapefile.
            Dim baseUri As Uri = New Uri(Reflection.Assembly.GetEntryAssembly().Location)
            loader.FileUri = New Uri(baseUri, shapefilePath)
            Return loader
        End Function

        Private Function CreateGDPColorizer() As ChoroplethColorizer
            ' Create a choropleth colorizer.
            Dim colorizer As ChoroplethColorizer = New ChoroplethColorizer()
            ' Specify the attribute that provides data values for the colorizer.
            colorizer.ValueProvider = New ShapeAttributeValueProvider() With {.AttributeName = "GDP_MD_EST"}
            ' Specify range stops for the colorizer.
            colorizer.RangeStops.AddRange(New List(Of Double) From {0, 3000, 10000, 18000, 28000, 44000, 82000, 185000, 1000000, 2500000, 15000000})
            ' Specify colors for the colorizer.
            colorizer.Colors.AddRange(New List(Of Color) From {Color.FromArgb(&H5F, &H8B, &H95), Color.FromArgb(&H79, &H96, &H89), Color.FromArgb(&HA2, &HA8, &H75), Color.FromArgb(&HCE, &HBB, &H5F), Color.FromArgb(&HF2, &HCB, &H4E), Color.FromArgb(&HF1, &HC1, &H49), Color.FromArgb(&HE5, &HA8, &H4D), Color.FromArgb(&HD6, &H86, &H4E), Color.FromArgb(&HC5, &H64, &H50), Color.FromArgb(&HBA, &H4D, &H51)})
            ' Create a color scale legend and adjust its properties.
            Dim legend As ColorScaleLegend = New ColorScaleLegend()
            legend.Header = "GDP by Countries"
            legend.Description = "In US dollars"
            legend.RangeStopsFormat = "0,B"
            colorizer.Legend = legend
            Return colorizer
        End Function
    End Class
End Namespace
