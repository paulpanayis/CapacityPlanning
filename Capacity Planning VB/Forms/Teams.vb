Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class Teams
    Private maryTeams() As Long
    Private maryLocations() As Long
    Private marySprintTemplates() As Long

    Private mintTeamID As Integer
    Private mstrTeamName As String
    Private mintSprintTemplateID As Integer
    Private mintTeamLocationID As Integer

    Private mintPersonID As Integer
    Private mstrPersonName As String
    Private mintPersonTeamID As Integer

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

    Private Sub Teams_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim strSQL As String

        ' fill out the locations
        strSQL = Get_Locations()
        FillListBox(cboTeamLocation, maryLocations, "Name", strSQL, "ID")

        ' fill out the sprint templates
        strSQL = Get_SprintTemplates()
        FillListBox(cboSprintTemplate, marySprintTemplates, "Name", strSQL, "ID")

        ' Fill out the teams
        strSQL = Get_Teams()

        FillListView(Me, lvwTeams, strSQL, "ID", True, True, True, True)
        FillListBox(cboPersonTeam, maryTeams, "Name", strSQL, "ID")
        FillListBox(cboTeams, maryTeams, "Name", strSQL, "ID")

        If lvwTeams.Items.Count > 0 Then
            lvwTeams.Items.Item(0).Selected = True
        End If

        LoadFormSizeAndPosition(Me)
    End Sub

    Private Sub Teams_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SaveFormSizeAndPosition(Me)
        Me.Dispose()
    End Sub

    Private Sub Teams_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        MainMenu.Focus()
    End Sub

    Private Sub lvwTeams_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles lvwTeams.ItemSelectionChanged
        ListBoxSelect(cboTeams, maryTeams, Convert.ToInt32(e.Item.Tag))
    End Sub

    Private Sub cboTeams_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTeams.SelectedIndexChanged
        Dim strSQL As String
        Dim intTeamID As Integer

        ' get the team id
        intTeamID = maryTeams(cboTeams.SelectedIndex)

        ' show the team details
        ShowTeam(intTeamID)

        ' get the people in the team
        strSQL = Get_PeopleInTeam(intTeamID)

        FillListView(Me, lvwPeople, strSQL, "ID", True, True, True, True)
    End Sub

    Private Sub ShowTeam(ByVal intTeamID As Integer)
        Dim strSQL As String
        Dim dataTable As DataTable

        mintTeamID = intTeamID

        If intTeamID = 0 Then
            ' blank
            mstrTeamName = ""
            mintSprintTemplateID = 0
            mintTeamLocationID = 0

            txtTeamName.Text = ""
            cboSprintTemplate.SelectedIndex = -1
            cboTeamLocation.SelectedIndex = -1
        Else
            strSQL = Get_TeamByID(intTeamID)
            dataTable = gDB.OpenDataset(strSQL).Tables("Table")

            If dataTable.Rows.Count > 0 Then
                Dim drCurrent As DataRow

                For Each drCurrent In dataTable.Rows
                    ' hopefully only one!
                    mstrTeamName = drCurrent("Name").ToString
                    mintSprintTemplateID = drCurrent("SprintTemplateID")
                    mintTeamLocationID = drCurrent("LocationID")

                    txtTeamName.Text = mstrTeamName
                    ListBoxSelect(cboSprintTemplate, marySprintTemplates, mintSprintTemplateID)
                    ListBoxSelect(cboTeamLocation, maryLocations, mintTeamLocationID)
                Next
            End If
        End If
    End Sub

    Private Sub lvwPeople_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwPeople.SelectedIndexChanged
        Dim intPersonID As Integer

        ' get the team id
        intPersonID = lvwPeople.SelectedItems(0).Tag

        ' show the team details
        ShowPerson(intPersonID)
    End Sub

    Private Sub ShowPerson(ByVal intPersonID As Integer)
        Dim strSQL As String
        Dim dataTable As DataTable

        mintPersonID = intPersonID

        If intPersonID = 0 Then
            ' blank
            mstrPersonName = ""
            mintPersonTeamID = 0

            txtPersonName.Text = mstrPersonName
            cboPersonTeam.SelectedIndex = -1
        Else
            strSQL = Get_PersonByID(intPersonID)
            dataTable = gDB.OpenDataset(strSQL).Tables("Table")

            If dataTable.Rows.Count > 0 Then
                Dim drCurrent As DataRow

                For Each drCurrent In dataTable.Rows
                    ' hopefully only one!
                    mstrPersonName = drCurrent("Name").ToString
                    mintPersonTeamID = drCurrent("TeamID")

                    txtPersonName.Text = mstrPersonName
                    ListBoxSelect(cboPersonTeam, maryTeams, mintPersonTeamID)
                Next
            End If
        End If
    End Sub

End Class