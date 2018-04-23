using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraMap;

namespace Colorizer {

    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Create a map control and specify its dock style.
            MapControl map = new MapControl();
            map.Dock = DockStyle.Fill;

            // Specify the map's initial view.  
            map.ZoomLevel = 2;
            map.CenterPoint = new GeoPoint(38, -100);

            // Create a file layer and assign a shape loader to it.
            VectorFileLayer fileLayer = new VectorFileLayer();
            fileLayer.FileLoader = CreateShapefileLoader();
            map.Layers.Add(fileLayer);

            // Create a colorizer.
            map.Colorizer = CreateGDPColorizer();

            // Add the map control to the window. 
            this.Controls.Add(map);
        }

        private ShapefileLoader CreateShapefileLoader() {
            // Create an object to load data from a shapefile.
            ShapefileLoader loader = new ShapefileLoader();

            // Determine the path to the Shapefile.
            Uri baseUri = new Uri(System.Reflection.Assembly.GetEntryAssembly().Location);
            string shapefilePath = "../../Data/Countries.shp";
            loader.FileUri = new Uri(baseUri, shapefilePath);

            return loader;
        }

        private ChoroplethColorizer CreateGDPColorizer() {
            // Create a choropleth colorizer.
            ChoroplethColorizer colorizer = new ChoroplethColorizer();

            // Specify the attribute that provides data values for the colorizer.
            colorizer.ValueProvider = new ShapeAttributeValueProvider() { AttributeName = "GDP_MD_EST" };

            // Specify range stops for the colorizer.
            colorizer.RangeStops.AddRange(new List<double> { 0, 3000, 10000, 18000, 28000, 
                44000, 82000, 185000, 1000000, 2500000, 15000000 });

            // Specify colors for the colorizer.
            colorizer.Colors.AddRange(new List<Color> { Color.FromArgb(0x5F, 0x8B, 0x95), 
                                                        Color.FromArgb(0x79, 0x96, 0x89), 
                                                        Color.FromArgb(0xA2, 0xA8, 0x75), 
                                                        Color.FromArgb(0xCE, 0xBB, 0x5F),
                                                        Color.FromArgb(0xF2, 0xCB, 0x4E),
                                                        Color.FromArgb(0xF1, 0xC1, 0x49), 
                                                        Color.FromArgb(0xE5, 0xA8, 0x4D),
                                                        Color.FromArgb(0xD6, 0x86, 0x4E),
                                                        Color.FromArgb(0xC5, 0x64, 0x50), 
                                                        Color.FromArgb(0xBA, 0x4D, 0x51)});


            // Create a color scale legend and adjust its properties.
            ColorScaleLegend legend = new ColorScaleLegend();
            legend.Header = "GDP by Countries";
            legend.Description = "In US dollars";
            legend.RangeStopsFormat = "0,B";
            colorizer.Legend = legend;

            return colorizer;
        }
    }
}

