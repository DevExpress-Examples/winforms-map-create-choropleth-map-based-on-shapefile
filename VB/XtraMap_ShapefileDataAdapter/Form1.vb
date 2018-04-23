Imports DevExpress.XtraMap
Imports System
Imports System.Drawing
Imports System.Windows.Forms

Namespace XtraMap_ShapefileDataAdapter
    Partial Public Class Form1
        Inherits Form

        Private Const filename As String = "../../Data/Countries.shp"

        Private ReadOnly Property MapLayer() As VectorItemsLayer
            Get
                Return CType(mapControl1.Layers("MapLayer"), VectorItemsLayer)
            End Get
        End Property

        Public Sub New()
            InitializeComponent()

'            #Region "#DataProperty"
            ' Create data for the MapLayer.
            MapLayer.Data = CreateData()
'            #End Region ' #DataProperty
'            #Region "#ColorizerProperty"
            ' Create colorizer for the MapLayer.
            MapLayer.Colorizer = CreateColorizer()
'            #End Region ' #ColorizerProperty

'            #Region "#LegendsProperty"
            ' Create a legend and add it to the map.
            mapControl1.Legends.Add(CreateLegend(MapLayer))
'            #End Region ' #LegendsProperty
        End Sub

        #Region "#CreateData"
        Private Function CreateData() As MapDataAdapterBase
            Dim baseUri As New Uri(System.Reflection.Assembly.GetEntryAssembly().Location)

            ' Create an adapter to load data from shapefile.
            Dim adapter As New ShapefileDataAdapter() With {.FileUri = New Uri(baseUri, filename)}

            Return adapter
        End Function
        #End Region ' #CreateData

        #Region "#CreateColorizer"
        Private Function CreateColorizer() As MapColorizer
            ' Create a Choropleth colorizer
            Dim colorizer As New ChoroplethColorizer()

            ' Specify colors for the colorizer.
            colorizer.ColorItems.AddRange(New ColorizerColorItem() { _
                New ColorizerColorItem(Color.FromArgb(&H5F, &H8B, &H95)), _
                New ColorizerColorItem(Color.FromArgb(&H79, &H96, &H89)), _
                New ColorizerColorItem(Color.FromArgb(&HA2, &HA8, &H75)), _
                New ColorizerColorItem(Color.FromArgb(&HCE, &HBB, &H5F)), _
                New ColorizerColorItem(Color.FromArgb(&HF2, &HCB, &H4E)), _
                New ColorizerColorItem(Color.FromArgb(&HF1, &HC1, &H49)), _
                New ColorizerColorItem(Color.FromArgb(&HE5, &HA8, &H4D)), _
                New ColorizerColorItem(Color.FromArgb(&HD6, &H86, &H4E)), _
                New ColorizerColorItem(Color.FromArgb(&HC5, &H64, &H50)), _
                New ColorizerColorItem(Color.FromArgb(&HBA, &H4D, &H51)) _
            })

            ' Specify range stops for the colorizer.
            colorizer.RangeStops.AddRange(New Double() { 0, 3000, 10000, 18000, 28000, 44000, 82000, 185000, 1000000, 2500000, 15000000 })

            ' Specify the attribute that provides data values for the colorizer.
            colorizer.ValueProvider = New ShapeAttributeValueProvider() With {.AttributeName = "GDP_MD_EST"}

            Return colorizer
        End Function
        #End Region ' #CreateColorizer

        #Region "#CreateLegend"
        Private Function CreateLegend(ByVal layer As MapItemsLayerBase) As MapLegendBase
            ' Create a color scale legend.
            Return New ColorScaleLegend() With {.Header = "GDP by Countries", .Description = "In US dollars", .RangeStopsFormat = "0,B", .Layer = layer}
        End Function
        #End Region ' #CreateLegend
    End Class
End Namespace
