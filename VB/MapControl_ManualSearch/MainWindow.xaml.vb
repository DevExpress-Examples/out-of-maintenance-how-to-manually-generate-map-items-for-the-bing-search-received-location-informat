Imports System.Windows
Imports DevExpress.Xpf.Map

Namespace MapControl_ManualSearch

    Public Partial Class MainWindow
        Inherits System.Windows.Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

'#Region "#ManualItemGenerationEventHandler"
        Private Sub BingSearchDataProvider_SearchCompleted(ByVal sender As Object, ByVal e As DevExpress.Xpf.Map.BingSearchCompletedEventArgs)
            If e.Cancelled Then Return
            If e.RequestResult.ResultCode <> DevExpress.Xpf.Map.RequestResultCode.Success Then Return
            Me.storage.Items.Clear()
            If e.RequestResult.SearchResults.Count <> 0 Then
                For Each locationInformation As DevExpress.Xpf.Map.LocationInformation In e.RequestResult.SearchResults
                    Me.AddMapItem(locationInformation)
                Next
            Else
                Me.AddMapItem(e.RequestResult.SearchRegion)
            End If
        End Sub

        Private Sub AddMapItem(ByVal locationInformation As DevExpress.Xpf.Map.LocationInformation)
            Me.storage.Items.Add(New DevExpress.Xpf.Map.MapDot() With {.Location = locationInformation.Location, .ToolTipPattern = locationInformation.DisplayName, .Size = 20})
        End Sub
'#End Region  ' #ManualItemGenerationEventHandler
    End Class
End Namespace
