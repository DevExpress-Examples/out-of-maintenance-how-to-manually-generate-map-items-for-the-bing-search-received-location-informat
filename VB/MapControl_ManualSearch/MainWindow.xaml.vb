Imports System.Windows
Imports DevExpress.Xpf.Map

Namespace MapControl_ManualSearch
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
        End Sub

        #Region "#ManualItemGenerationEventHandler"
        Private Sub BingSearchDataProvider_SearchCompleted(ByVal sender As Object, ByVal e As BingSearchCompletedEventArgs)
            If e.Cancelled Then
                Return
            End If
            If e.RequestResult.ResultCode <> RequestResultCode.Success Then
                Return
            End If

            storage.Items.Clear()
            If e.RequestResult.SearchResults.Count <> 0 Then
                For Each locationInformation As LocationInformation In e.RequestResult.SearchResults
                    AddMapItem(locationInformation)
                Next locationInformation
            Else
                AddMapItem(e.RequestResult.SearchRegion)
            End If
        End Sub

        Private Sub AddMapItem(ByVal locationInformation As LocationInformation)
            storage.Items.Add(New MapDot() With {.Location = locationInformation.Location, .ToolTipPattern = locationInformation.DisplayName, .Size = 20})
        End Sub
        #End Region ' #ManualItemGenerationEventHandler
    End Class
End Namespace
