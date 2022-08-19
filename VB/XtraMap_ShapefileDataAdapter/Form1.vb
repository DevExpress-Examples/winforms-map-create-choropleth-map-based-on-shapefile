Imports DevExpress.XtraMap
Imports System
Imports System.Drawing
Imports System.Windows.Forms

Namespace XtraMap_ShapefileDataAdapter

    Public Partial Class Form1
        Inherits System.Windows.Forms.Form

        Const filename As String = "../../Data/Countries.shp"

        Private ReadOnly Property MapLayer As VectorItemsLayer
            Get
                Return CType(Me.mapControl1.Layers("MapLayer"), DevExpress.XtraMap.VectorItemsLayer)
            End Get
        End Property

        Public Sub New()
            Me.InitializeComponent()
'#Region "#DataProperty"
            ' Create data for the MapLayer.
            Me.MapLayer.Data = Me.CreateData()
'#End Region  ' #DataProperty
'#Region "#ColorizerProperty"
            ' Create colorizer for the MapLayer.
            Me.MapLayer.Colorizer = Me.CreateColorizer()
'#End Region  ' #ColorizerProperty
'#Region "#LegendsProperty"
            ' Create a legend and add it to the map.
            Me.mapControl1.Legends.Add(Me.CreateLegend(Me.MapLayer))
'#End Region  ' #LegendsProperty
        End Sub

'#Region "#CreateData"
        Private Function CreateData() As MapDataAdapterBase
            Dim baseUri As System.Uri = New System.Uri(System.Reflection.Assembly.GetEntryAssembly().Location)
            ' Create an adapter to load data from shapefile.
            Dim adapter As DevExpress.XtraMap.ShapefileDataAdapter = New DevExpress.XtraMap.ShapefileDataAdapter() With {.FileUri = New System.Uri(baseUri, XtraMap_ShapefileDataAdapter.Form1.filename)}
            Return adapter
        End Function

'#End Region  ' #CreateData
'#Region "#CreateColorizer"
        Private Function CreateColorizer() As MapColorizer
            ' Create a Choropleth colorizer
            Dim colorizer As DevExpress.XtraMap.ChoroplethColorizer = New DevExpress.XtraMap.ChoroplethColorizer()
            ' Specify colors for the colorizer.
            colorizer.ColorItems.AddRange(New DevExpress.XtraMap.ColorizerColorItem() {New DevExpress.XtraMap.ColorizerColorItem(System.Drawing.Color.FromArgb(&H5F, &H8B, &H95)), New DevExpress.XtraMap.ColorizerColorItem(System.Drawing.Color.FromArgb(&H79, &H96, &H89)), New DevExpress.XtraMap.ColorizerColorItem(System.Drawing.Color.FromArgb(&HA2, &HA8, &H75)), New DevExpress.XtraMap.ColorizerColorItem(System.Drawing.Color.FromArgb(&HCE, &HBB, &H5F)), New DevExpress.XtraMap.ColorizerColorItem(System.Drawing.Color.FromArgb(&HF2, &HCB, &H4E)), New DevExpress.XtraMap.ColorizerColorItem(System.Drawing.Color.FromArgb(&HF1, &HC1, &H49)), New DevExpress.XtraMap.ColorizerColorItem(System.Drawing.Color.FromArgb(&HE5, &HA8, &H4D)), New DevExpress.XtraMap.ColorizerColorItem(System.Drawing.Color.FromArgb(&HD6, &H86, &H4E)), New DevExpress.XtraMap.ColorizerColorItem(System.Drawing.Color.FromArgb(&HC5, &H64, &H50)), New DevExpress.XtraMap.ColorizerColorItem(System.Drawing.Color.FromArgb(&HBA, &H4D, &H51))})
            ' Specify range stops for the colorizer.
            colorizer.RangeStops.AddRange(New Double() {0, 3000, 10000, 18000, 28000, 44000, 82000, 185000, 1000000, 2500000, 15000000})
            ' Specify the attribute that provides data values for the colorizer.
            colorizer.ValueProvider = New DevExpress.XtraMap.ShapeAttributeValueProvider() With {.AttributeName = "GDP_MD_EST"}
            Return colorizer
        End Function

'#End Region  ' #CreateColorizer
'#Region "#CreateLegend"
        Private Function CreateLegend(ByVal layer As DevExpress.XtraMap.MapItemsLayerBase) As MapLegendBase
            ' Create a color scale legend.
            Return New DevExpress.XtraMap.ColorScaleLegend() With {.Header = "GDP by Countries", .Description = "In US dollars", .RangeStopsFormat = "0,B", .Layer = layer}
        End Function
'#End Region  ' #CreateLegend
    End Class
End Namespace
