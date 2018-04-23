Namespace BingElevationData
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.mapControl = New DevExpress.XtraMap.MapControl()
            Me.imageLayer = New DevExpress.XtraMap.ImageLayer()
            Me.bingMapDataProvider = New DevExpress.XtraMap.BingMapDataProvider()
            Me.informationLayer = New DevExpress.XtraMap.InformationLayer()
            Me.bingElevationDataProvider = New DevExpress.XtraMap.BingElevationDataProvider()
            Me.vectorItemsLayer = New DevExpress.XtraMap.VectorItemsLayer()
            Me.defaultLookAndFeel = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            DirectCast(Me.mapControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' mapControl
            ' 
            Me.mapControl.CenterPoint = New DevExpress.XtraMap.GeoPoint(35R, -90R)
            Me.mapControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mapControl.Layers.Add(Me.imageLayer)
            Me.mapControl.Layers.Add(Me.informationLayer)
            Me.mapControl.Layers.Add(Me.vectorItemsLayer)
            Me.mapControl.Location = New System.Drawing.Point(0, 0)
            Me.mapControl.Name = "mapControl"
            Me.mapControl.Size = New System.Drawing.Size(909, 488)
            Me.mapControl.TabIndex = 0
            Me.mapControl.ZoomLevel = 4R
            ' 
            ' imageLayer
            ' 
            Me.imageLayer.DataProvider = Me.bingMapDataProvider
            ' 
            ' bingMapDataProvider
            ' 
            Me.bingMapDataProvider.BingKey = "INSERT_YOUR_BING_KEY"
            Me.bingMapDataProvider.TileSource = Nothing
            ' 
            ' informationLayer
            ' 
            Me.informationLayer.DataProvider = Me.bingElevationDataProvider
            ' 
            ' bingElevationDataProvider
            ' 
            Me.bingElevationDataProvider.BingKey = "INSERT_YOUR_BING_KEY"
            ' 
            ' defaultLookAndFeel
            ' 
            Me.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2016 Colorful"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(909, 488)
            Me.Controls.Add(Me.mapControl)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.mapControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private mapControl As DevExpress.XtraMap.MapControl
        Private defaultLookAndFeel As DevExpress.LookAndFeel.DefaultLookAndFeel
        Private imageLayer As DevExpress.XtraMap.ImageLayer
        Private bingMapDataProvider As DevExpress.XtraMap.BingMapDataProvider
        Private informationLayer As DevExpress.XtraMap.InformationLayer
        Private bingElevationDataProvider As DevExpress.XtraMap.BingElevationDataProvider
        Private vectorItemsLayer As DevExpress.XtraMap.VectorItemsLayer
    End Class
End Namespace

