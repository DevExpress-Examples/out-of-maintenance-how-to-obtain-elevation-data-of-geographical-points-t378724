namespace BingElevationData {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.mapControl = new DevExpress.XtraMap.MapControl();
            this.imageLayer = new DevExpress.XtraMap.ImageLayer();
            this.bingMapDataProvider = new DevExpress.XtraMap.BingMapDataProvider();
            this.informationLayer = new DevExpress.XtraMap.InformationLayer();
            this.bingElevationDataProvider = new DevExpress.XtraMap.BingElevationDataProvider();
            this.vectorItemsLayer = new DevExpress.XtraMap.VectorItemsLayer();
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).BeginInit();
            this.SuspendLayout();
            // 
            // mapControl
            // 
            this.mapControl.CenterPoint = new DevExpress.XtraMap.GeoPoint(35D, -90D);
            this.mapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl.Layers.Add(this.imageLayer);
            this.mapControl.Layers.Add(this.informationLayer);
            this.mapControl.Layers.Add(this.vectorItemsLayer);
            this.mapControl.Location = new System.Drawing.Point(0, 0);
            this.mapControl.Name = "mapControl";
            this.mapControl.Size = new System.Drawing.Size(909, 488);
            this.mapControl.TabIndex = 0;
            this.mapControl.ZoomLevel = 4D;
            // 
            // imageLayer
            // 
            this.imageLayer.DataProvider = this.bingMapDataProvider;
            // 
            // bingMapDataProvider
            // 
            this.bingMapDataProvider.BingKey = "INSERT_YOUR_BING_KEY";
            this.bingMapDataProvider.TileSource = null;
            // 
            // informationLayer
            // 
            this.informationLayer.DataProvider = this.bingElevationDataProvider;
            // 
            // bingElevationDataProvider
            // 
            this.bingElevationDataProvider.BingKey = "INSERT_YOUR_BING_KEY";
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 488);
            this.Controls.Add(this.mapControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraMap.MapControl mapControl;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
        private DevExpress.XtraMap.ImageLayer imageLayer;
        private DevExpress.XtraMap.BingMapDataProvider bingMapDataProvider;
        private DevExpress.XtraMap.InformationLayer informationLayer;
        private DevExpress.XtraMap.BingElevationDataProvider bingElevationDataProvider;
        private DevExpress.XtraMap.VectorItemsLayer vectorItemsLayer;
    }
}

