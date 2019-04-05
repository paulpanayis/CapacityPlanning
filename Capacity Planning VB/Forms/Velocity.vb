Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class Velocity
    Private maryTeams() As Long
    Private mintTeamID As Integer
    Private mintSprintID As Integer
    ' we are not using SprintActualID here, which may seem strange
    '  the reason is that we want the creation of this record to be invisible to the user
    '  the SprintActualID is the result of the sprintid / teamid combination, which we should always have
    Private mblnLoadingSprintActual As Boolean


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

    Private Sub About_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadFormData()
        lblCopyright.Text = My.Settings.Copyright
        LoadFormSizeAndPosition(Me)
    End Sub

    Private Sub About_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SaveFormSizeAndPosition(Me)
        Me.Dispose()
    End Sub

    Private Sub About_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        MainMenu.Focus()
    End Sub

    Private Sub LoadFormData()
        Dim strSQL As String

        ' Fill out the teams
        strSQL = Get_Teams()

        FillListBox(cboTeams, maryTeams, "Name", strSQL, "ID")

        If cboTeams.Items.Count > 0 Then
            cboTeams.SelectedItem = cboTeams.Items(0)
        End If

    End Sub

    Private Sub cboTeams_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTeams.SelectedIndexChanged
        mintTeamID = maryTeams(cboTeams.SelectedIndex)
        mintSprintID = 0
        ShowSprintsForTeam()
    End Sub

    Private Sub ShowSprintsForTeam()
        Dim strSQL As String
        Dim intSprintID As Integer

        intSprintID = mintSprintID

        strSQL = Get_SprintActuals(mintTeamID)
        FillListView(Me, lvwSprintActuals, strSQL, "ID", True, True, True, True)
        If lvwSprintActuals.Items.Count > 0 Then
            If intSprintID > 0 Then
                ListViewSelectByTag(lvwSprintActuals, intSprintID)
            Else
                lvwSprintActuals.Items(0).Selected = True
            End If
        Else
            mblnLoadingSprintActual = True
            mintSprintID = 0
            lblSprintNumberValue.Text = ""
            txtVelocity.Text = ""
            mblnLoadingSprintActual = False
        End If

        ' ensure the timer is not active and trying to save some old sprint
        tmrSprintActualSave.Enabled = False
    End Sub

    Private Sub lvwSprintActuals_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwSprintActuals.SelectedIndexChanged
        Dim intSprintID As Integer

        mblnLoadingSprintActual = True

        ' get the sprint id
        If lvwSprintActuals.SelectedItems.Count > 0 Then
            intSprintID = lvwSprintActuals.SelectedItems(0).Tag
            lblSprintNumberValue.Text = lvwSprintActuals.SelectedItems(0).Text
            If IsNumeric(lvwSprintActuals.SelectedItems(0).SubItems(3).Text) Then
                txtVelocity.Text = lvwSprintActuals.SelectedItems(0).SubItems(3).Text
            Else
                txtVelocity.Text = ""
            End If

            Highlight(txtVelocity)
        Else
            intSprintID = 0
            lblSprintNumberValue.Text = ""
            txtVelocity.Text = ""
        End If

        mintSprintID = intSprintID

        mblnLoadingSprintActual = False
    End Sub

    Private Sub StartSaveSprintActualTimer()
        If mblnLoadingSprintActual = False Then
            tmrSprintActualSave.Enabled = False
            tmrSprintActualSave.Enabled = True
        End If
    End Sub

    Private Sub txtVelocity_TextChanged(sender As Object, e As EventArgs) Handles txtVelocity.TextChanged
        If mintSprintID > 0 And mintTeamID > 0 Then
            StartSaveSprintActualTimer()
        End If
    End Sub

    Private Sub tmrSprintActualSave_Tick(sender As Object, e As EventArgs) Handles tmrSprintActualSave.Tick
        Dim decVelocity As Decimal

        tmrSprintActualSave.Enabled = False

        decVelocity = txtVelocity.Text

        If UpdateInsert_SprintVelocity(mintTeamID, mintSprintID, decVelocity) = False Then
            MsgBox("There was a problem trying to update the sprint velocity")
        Else
            ' saved successfully
            ShowSprintsForTeam()
        End If

    End Sub

    Private Sub ctlDeleteVelocity_Clicked() Handles ctlDeleteVelocity.Clicked
        Dim intTeamID As Integer
        Dim intSprintID As Integer

        intTeamID = mintTeamID
        intSprintID = mintSprintID

        If intSprintID > 0 And intTeamID > 0 Then
            If MsgBox("Please confirm you wish to delete the actual velocity for sprint '" & lblSprintNumberValue.Text & "'", Buttons:=MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If Delete_SprintActual(intTeamID, intSprintID) = False Then
                    MsgBox("There was a problem when trying to delete the selected Sprint Actual Velocity")
                Else
                    intSprintID = 0
                End If
                ShowSprintsForTeam()
            End If
        ElseIf intTeamID = 0 Then
            MsgBox("Please select a team and the Sprint Actual to delete first")
        ElseIf intSprintID = 0 Then
            MsgBox("Please select the Sprint Actual to delete first")
        End If
    End Sub

    Private Sub lvwSprintActuals_MouseUp(sender As Object, e As MouseEventArgs) Handles lvwSprintActuals.MouseUp
        Highlight(txtVelocity)
    End Sub
End Class