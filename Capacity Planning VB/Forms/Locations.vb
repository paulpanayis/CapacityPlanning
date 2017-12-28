Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class Locations
    Private mblnLoadingLocation As Boolean
    Private mintLocationID As Integer


    Protected Overrides Sub OnPaintBackground(ByVal pevent As PaintEventArgs)
        Dim x, y, w, h As Integer
        With pevent.ClipRectangle
            x = 0
            y = 0
            w = Me.Width
            h = Me.Height - pnlBottomBar.Height
        End With
        ' Create a new LinearGradientBrush sized to our control
        Dim linGrBrush As New LinearGradientBrush(
            New RectangleF(x, y, w, h), My.Settings.FormBackColour, Color.White, LinearGradientMode.Vertical)
        ' Graphics object needed to call FillRectangle
        Dim gc As Graphics = pevent.Graphics
        ' Fill our control with the specified gradient
        gc.FillRectangle(linGrBrush, pevent.ClipRectangle)
    End Sub

    Private Sub pnlBottomBar_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlBottomBar.Paint
        Dim x, y, w, h As Integer
        With e.ClipRectangle
            x = 0
            y = 0
            w = pnlBottomBar.Width
            h = pnlBottomBar.Height
        End With
        ' Create a new LinearGradientBrush sized to our control
        Dim linGrBrush As New LinearGradientBrush(
            New RectangleF(x, y, w, h), Color.White, My.Settings.FormBackColour, LinearGradientMode.Vertical)
        ' Graphics object needed to call FillRectangle
        Dim gc As Graphics = e.Graphics
        ' Fill our control with the specified gradient
        gc.FillRectangle(linGrBrush, e.ClipRectangle)
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        tmrLocationSave.Enabled = False
        Me.Close()
    End Sub

    Private Sub MeLoad(sender As Object, e As EventArgs) Handles Me.Load
        LoadFormSizeAndPosition(Me)
        LoadLocations()
    End Sub

    Private Sub MeClosing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SaveFormSizeAndPosition(Me)
        Me.Dispose()
    End Sub

    Private Sub MeDisposed(sender As Object, e As EventArgs) Handles Me.Disposed
        MainMenu.Focus()
    End Sub

    Private Sub LoadLocations()
        Dim strSQL As String

        tmrLocationSave.Enabled = False
        mblnLoadingLocation = True

        strSQL = Get_Locations()
        FillListView(Me, lvwLocations, strSQL, "ID", True, True, True, True)

        If mintLocationID > 0 Then
            ListViewSelectByTag(lvwLocations, mintLocationID)
        End If

        mblnLoadingLocation = False
    End Sub

    Private Sub lvwLocations_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwLocations.SelectedIndexChanged
        If lvwLocations.SelectedItems.Count > 0 Then
            mintLocationID = Convert.ToInt32(lvwLocations.SelectedItems(0).Tag)
        End If
    End Sub

    Private Sub txtLocation_TextChanged(sender As Object, e As EventArgs) Handles txtLocation.TextChanged
        StartSaveLocationTimer()
    End Sub

    Private Sub StartSaveLocationTimer()
        If mblnLoadingLocation = False Then
            tmrLocationSave.Enabled = False
            tmrLocationSave.Enabled = True
        End If
    End Sub

    Private Sub ctlDeleteLocation_Clicked() Handles ctlDeleteLocation.Clicked

    End Sub

    Private Sub ctlAddLocation_Clicked() Handles ctlAddLocation.Clicked

    End Sub

End Class