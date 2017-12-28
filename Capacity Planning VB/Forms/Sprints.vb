Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class Sprints
    Private maryTemplates() As Long
    Private mintTemplateID As Integer
    Private mstrTemplateName As String
    Private mstrTemplateStartDay As String
    Private mblnLoadingTemplate As Boolean

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
        Me.Close()
    End Sub

    Private Sub MeLoad(sender As Object, e As EventArgs) Handles Me.Load
        LoadFormData()
        LoadFormSizeAndPosition(Me)
    End Sub

    Private Sub LoadFormData()
        Dim strSQL As String

        ' Fill out the teams
        strSQL = Get_SprintTemplates()

        FillListView(Me, lvwTemplates, strSQL, "ID", True, True, True, True)
        FillListBox(cboTemplates, maryTemplates, "Name", strSQL, "ID")

        If lvwTemplates.Items.Count > 0 Then
            lvwTemplates.Items.Item(0).Selected = True
        End If
    End Sub

    Private Sub MeClosing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SaveFormSizeAndPosition(Me)
        Me.Dispose()
    End Sub

    Private Sub MeDisposed(sender As Object, e As EventArgs) Handles Me.Disposed
        MainMenu.Focus()
    End Sub

    Private Sub cmdDateFrom_Click(sender As Object, e As EventArgs) Handles cmdStartDate.Click
        Dim dteStart As Date

        If IsDate(cmdStartDate.Text) Then
            dteStart = CDate(cmdStartDate.Text)
        Else
            dteStart = Date.Now
        End If

        cmdStartDate.Text = GetDate(dteStart, Now.Year - 1, Now.Year + 5, True).ToString("d MMM yyyy")
    End Sub

    Private Sub cmdDateTo_Click(sender As Object, e As EventArgs) Handles cmdEndDate.Click
        Dim dteStart As Date

        If IsDate(cmdEndDate.Text) Then
            dteStart = CDate(cmdEndDate.Text)
        Else
            dteStart = Date.Now
        End If

        cmdEndDate.Text = GetDate(dteStart, Now.Year - 1, Now.Year + 5, True).ToString("d MMM yyyy")
    End Sub

    Private Sub lvwTemplates_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwTemplates.SelectedIndexChanged
        If lvwTemplates.SelectedItems.Count > 0 Then
            mintTemplateID = Convert.ToInt32(lvwTemplates.SelectedItems(0).Tag)
            txtTemplateName.Text = lvwTemplates.SelectedItems(0).Text
            ListBoxSelect(cboSprintStartDay, lvwTemplates.SelectedItems(0).SubItems(1).Text)
            ListBoxSelect(cboTemplates, maryTemplates, mintTemplateID)
        End If
    End Sub

End Class