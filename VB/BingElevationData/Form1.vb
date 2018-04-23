Imports DevExpress.XtraMap
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace BingElevationData
    Partial Public Class Form1
        Inherits Form

        Private ReadOnly Property layer() As InformationLayer
            Get
                Return CType(mapControl.Layers(1), InformationLayer)
            End Get
        End Property
        Private ReadOnly Property vectorLayer() As VectorItemsLayer
            Get
                Return CType(mapControl.Layers(2), VectorItemsLayer)
            End Get
        End Property
        Private ReadOnly Property provider() As BingElevationDataProvider
            Get
                Return CType(layer.DataProvider, BingElevationDataProvider)
            End Get
        End Property
        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            AddHandler provider.ElevationsCalculated, AddressOf OnElevationCalculated
            provider.GenerateLayerItems = False
            Dim locations As New List(Of GeoPoint)() From { _
                New GeoPoint(41.145556, -73.995), _
                New GeoPoint(36.131389, -95.937222), _
                New GeoPoint(36.175, -115.136389) _
            }
            provider.RequestPointsElevations(locations)
        End Sub
        Private Sub OnElevationCalculated(ByVal sender As Object, ByVal e As ElevationsCalculatedEventArgs)
            Dim storage As New MapItemStorage()
            For Each elevationInformation As ElevationInformation In e.Result.Locations
                storage.Items.Add(New MapCallout() With {.Text = String.Format("{0}" & ControlChars.Lf & "Elevation = {1} m", elevationInformation.Location, elevationInformation.Elevation), .Location = elevationInformation.Location})
            Next elevationInformation
            vectorLayer.Data = storage
        End Sub
    End Class
End Namespace