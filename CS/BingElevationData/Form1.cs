using DevExpress.XtraMap;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BingElevationData {
    public partial class Form1 : Form {
        InformationLayer layer { get { return (InformationLayer)mapControl.Layers[1]; } }
        VectorItemsLayer vectorLayer { get { return (VectorItemsLayer)mapControl.Layers[2]; } }
        BingElevationDataProvider provider { get { return (BingElevationDataProvider)layer.DataProvider; } }
        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            provider.ElevationsCalculated += OnElevationCalculated;
            provider.GenerateLayerItems = false;
            List<GeoPoint> locations = new List<GeoPoint> {
                new GeoPoint(41.145556, -73.995),
                new GeoPoint(36.131389, -95.937222),
                new GeoPoint(36.175, -115.136389)
            };
            provider.RequestPointsElevations(locations);
        }
        void OnElevationCalculated(object sender, ElevationsCalculatedEventArgs e) {
            MapItemStorage storage = new MapItemStorage();
            foreach (ElevationInformation elevationInformation in e.Result.Locations) {
                storage.Items.Add(new MapCallout() {
                    Text = string.Format("{0}\nElevation = {1} m", elevationInformation.Location, elevationInformation.Elevation),
                    Location = elevationInformation.Location
                });
            }
            vectorLayer.Data = storage;
        }
    }
}