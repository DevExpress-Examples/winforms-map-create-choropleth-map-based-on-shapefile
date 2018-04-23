using DevExpress.XtraMap;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace XtraMap_ShapefileDataAdapter {
    public partial class Form1 : Form {
        const string filename = "../../Data/Countries.shp";

        VectorItemsLayer MapLayer { get { return (VectorItemsLayer)mapControl1.Layers["MapLayer"]; } }

        public Form1() {
            InitializeComponent();
        
            #region #DataProperty
            // Create data for the MapLayer.
            MapLayer.Data = CreateData();
            #endregion #DataProperty
            #region #ColorizerProperty
            // Create colorizer for the MapLayer.
            MapLayer.Colorizer = CreateColorizer();
            #endregion #ColorizerProperty

            #region #LegendsProperty
            // Create a legend and add it to the map.
            mapControl1.Legends.Add(CreateLegend(MapLayer));
            #endregion #LegendsProperty
        }

        #region #CreateData
        private MapDataAdapterBase CreateData() {
            Uri baseUri = new Uri(System.Reflection.Assembly.GetEntryAssembly().Location);

            // Create an adapter to load data from shapefile.
            ShapefileDataAdapter adapter = new ShapefileDataAdapter() {
                FileUri = new Uri(baseUri, filename)
            };

            return adapter;
        }
        #endregion #CreateData

        #region #CreateColorizer
        private MapColorizer CreateColorizer() {
            // Create a Choropleth colorizer
            ChoroplethColorizer colorizer = new ChoroplethColorizer();

            // Specify colors for the colorizer.
            colorizer.ColorItems.AddRange(new ColorizerColorItem[] {
                new ColorizerColorItem(Color.FromArgb(0x5F, 0x8B, 0x95)), 
                new ColorizerColorItem(Color.FromArgb(0x79, 0x96, 0x89)),
                new ColorizerColorItem(Color.FromArgb(0xA2, 0xA8, 0x75)), 
                new ColorizerColorItem(Color.FromArgb(0xCE, 0xBB, 0x5F)),
                new ColorizerColorItem(Color.FromArgb(0xF2, 0xCB, 0x4E)),
                new ColorizerColorItem(Color.FromArgb(0xF1, 0xC1, 0x49)), 
                new ColorizerColorItem(Color.FromArgb(0xE5, 0xA8, 0x4D)),
                new ColorizerColorItem(Color.FromArgb(0xD6, 0x86, 0x4E)),
                new ColorizerColorItem(Color.FromArgb(0xC5, 0x64, 0x50)), 
                new ColorizerColorItem(Color.FromArgb(0xBA, 0x4D, 0x51))
            });

            // Specify range stops for the colorizer.
            colorizer.RangeStops.AddRange(new double[] { 0, 3000, 10000, 18000, 28000, 
                44000, 82000, 185000, 1000000, 2500000, 15000000 });

            // Specify the attribute that provides data values for the colorizer.
            colorizer.ValueProvider = new ShapeAttributeValueProvider() { AttributeName = "GDP_MD_EST" };

            return colorizer;
        }
        #endregion #CreateColorizer

        #region #CreateLegend
        private MapLegendBase CreateLegend(MapItemsLayerBase layer) {
            // Create a color scale legend.
            return new ColorScaleLegend() {
                Header = "GDP by Countries",
                Description = "In US dollars",
                RangeStopsFormat = "0,B",
                Layer = layer
            };
        }
        #endregion #CreateLegend
    }
}
