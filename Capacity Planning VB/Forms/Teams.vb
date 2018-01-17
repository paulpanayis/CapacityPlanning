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
    Private mblnLoadingTeam As Boolean

    Private mintPersonID As Integer
    Private mstrPersonName As String
    Private mintPersonTeamID As Integer
    Private mintLocationID As Integer
    Private mblnLoadingPerson As Boolean

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
        LoadFormData()
        LoadFormSizeAndPosition(Me)
    End Sub

    Private Sub LoadFormData()
        Dim strSQL As String

        ' fill out the locations
        strSQL = Get_Locations()
        FillListBox(cboLocation, maryLocations, "Name", strSQL, "ID")

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
    End Sub

    Private Sub Teams_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SaveFormSizeAndPosition(Me)
        Me.Dispose()
    End Sub

    Private Sub Teams_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        MainMenu.Focus()
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

        ShowPerson(0)

        FillListView(Me, lvwPeople, strSQL, "ID", True, True, True, True)
    End Sub

    Private Sub ShowTeam(ByVal intTeamID As Integer)
        Dim strSQL As String
        Dim dataTable As DataTable

        tmrTeamSave.Enabled = False
        mblnLoadingTeam = True

        mintTeamID = intTeamID

        If intTeamID = 0 Then
            ' blank
            mstrTeamName = ""
            mintSprintTemplateID = 0
            mintLocationID = 0

            txtTeamName.Text = ""
            cboSprintTemplate.SelectedIndex = -1
            cboLocation.SelectedIndex = -1
        Else
            strSQL = Get_TeamByID(intTeamID)
            dataTable = gDB.OpenDataset(strSQL).Tables("Table")

            If dataTable.Rows.Count > 0 Then
                Dim drCurrent As DataRow

                For Each drCurrent In dataTable.Rows
                    ' hopefully only one!
                    mstrTeamName = drCurrent("Name").ToString
                    mintSprintTemplateID = drCurrent("SprintTemplateID")

                    txtTeamName.Text = mstrTeamName
                    ListBoxSelect(cboSprintTemplate, marySprintTemplates, mintSprintTemplateID)
                Next
            End If
        End If

        mblnLoadingTeam = False

    End Sub

    Private Sub lvwPeople_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwPeople.SelectedIndexChanged
        Dim intPersonID As Integer

        ' get the team id
        If lvwPeople.SelectedItems.Count > 0 Then
            intPersonID = lvwPeople.SelectedItems(0).Tag
        Else
            intPersonID = 0
        End If

        ' show the team details
        ShowPerson(intPersonID)
    End Sub

    Private Sub ShowPerson(ByVal intPersonID As Integer)
        Dim strSQL As String
        Dim dataTable As DataTable

        tmrPersonSave.Enabled = False
        mblnLoadingPerson = True

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
                    mintLocationID = drCurrent("LocationID")

                    txtPersonName.Text = mstrPersonName
                    ListBoxSelect(cboPersonTeam, maryTeams, mintPersonTeamID)
                    ListBoxSelect(cboLocation, maryLocations, mintLocationID)
                Next
            End If
        End If

        mblnLoadingPerson = False

    End Sub

    Private Sub txtPersonName_TextChanged(sender As Object, e As EventArgs) Handles txtPersonName.TextChanged
        StartSavePersonTimer()
    End Sub

    Private Sub cboPersonTeam_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPersonTeam.SelectedIndexChanged
        StartSavePersonTimer()
    End Sub

    Private Sub cboLocation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLocation.SelectedIndexChanged
        StartSavePersonTimer()
    End Sub

    Private Sub StartSavePersonTimer()
        If mblnLoadingPerson = False Then
            tmrPersonSave.Enabled = False
            tmrPersonSave.Enabled = True
        End If
    End Sub

    Private Sub txtTeamName_TextChanged(sender As Object, e As EventArgs) Handles txtTeamName.TextChanged
        StartSaveTeamTimer()
    End Sub

    Private Sub cboSprintTemplate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSprintTemplate.SelectedIndexChanged
        StartSaveTeamTimer()
    End Sub

    Private Sub StartSaveTeamTimer()
        If mblnLoadingTeam = False Then
            tmrTeamSave.Enabled = False
            tmrTeamSave.Enabled = True
        End If
    End Sub

    Private Sub tmrPersonSave_Tick(sender As Object, e As EventArgs) Handles tmrPersonSave.Tick
        Dim strSQL As String
        Dim intTeamID As Integer


        tmrPersonSave.Enabled = False
        mstrPersonName = txtPersonName.Text
        mintPersonTeamID = maryTeams(cboPersonTeam.SelectedIndex)

        If cboLocation.SelectedIndex = -1 Then
            mintLocationID = 0
        Else
            mintLocationID = maryLocations(cboLocation.SelectedIndex)
        End If

        If Update_Person(mintPersonID, mstrPersonName, mintPersonTeamID, mintLocationID) = False Then
            MsgBox("There was a problem trying to update the person's details")
        Else
            ' saved successfully

            ' get the team id
            intTeamID = maryTeams(cboTeams.SelectedIndex)

            ' get the people in the team
            strSQL = Get_PeopleInTeam(intTeamID)

            FillListView(Me, lvwPeople, strSQL, "ID", True, True, True, True)

            ListViewSelectByTag(lvwPeople, mintPersonID)
            If lvwPeople.SelectedItems.Count = 0 Then
                ShowPerson(0)
            End If
        End If
    End Sub

    Private Sub tmrTeamSave_Tick(sender As Object, e As EventArgs) Handles tmrTeamSave.Tick
        Dim intTeamID As Integer

        tmrTeamSave.Enabled = False

        mstrTeamName = txtTeamName.Text
        If cboSprintTemplate.SelectedIndex = -1 Then
            mintSprintTemplateID = 0
        Else
            mintSprintTemplateID = marySprintTemplates(cboSprintTemplate.SelectedIndex)
        End If


        If Update_Team(mintTeamID, mstrTeamName, mintSprintTemplateID) = False Then
            MsgBox("There was a problem trying to update the team's details")
        Else
            intTeamID = mintTeamID
            ShowPerson(0)

            LoadFormData()
            ListViewSelectByTag(lvwTeams, intTeamID)
        End If
    End Sub

    Private Sub ctlAddTeam_Clicked() Handles ctlAddTeam.Clicked
        Dim intTeamID As Integer

        intTeamID = Add_Team()
        ShowPerson(0)

        LoadFormData()
        ListViewSelectByTag(lvwTeams, intTeamID)
    End Sub

    Private Sub ctlDeleteSprintTeam_Clicked() Handles ctlDeleteSprintTeam.Clicked
        Dim intTeamID As Integer

        intTeamID = mintTeamID

        If intTeamID > 0 Then
            If MsgBox("Please confirm you wish to delete team '" & txtTeamName.Text & "'", Buttons:=MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If Delete_Team(intTeamID) = False Then
                    MsgBox("There was a problem when trying to delete the selected Team")
                Else
                    intTeamID = 0
                End If
                ShowPerson(0)

                LoadFormData()
                ListViewSelectByTag(lvwTeams, intTeamID)
            End If
        Else
            MsgBox("Please select the team to delete first")
        End If
    End Sub

    Private Sub ctlAddPerson_Clicked() Handles ctlAddPerson.Clicked
        Dim intPersonID As Integer
        Dim strSQL As String

        intPersonID = Add_Person(mintTeamID)

        ' get the people in the team
        strSQL = Get_PeopleInTeam(mintTeamID)

        FillListView(Me, lvwPeople, strSQL, "ID", True, True, True, True)

        ShowPerson(intPersonID)
    End Sub

    Private Sub ctlDeletePerson_Clicked() Handles ctlDeletePerson.Clicked
        Dim intPersonID As Integer
        Dim strSQL As String

        intPersonID = mintPersonID

        If intPersonID > 0 Then
            If MsgBox("Please confirm you wish to delete person '" & txtPersonName.Text & "'", Buttons:=MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If Delete_Person(intPersonID) = False Then
                    MsgBox("There was a problem when trying to delete the selected Person")
                Else
                    intPersonID = 0
                End If
                ' get the people in the team
                strSQL = Get_PeopleInTeam(mintTeamID)

                FillListView(Me, lvwPeople, strSQL, "ID", True, True, True, True)

                ShowPerson(intPersonID)
            End If
        Else
            MsgBox("Please select the person to delete first")
        End If
    End Sub

    Private Sub lvwTeams_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwTeams.SelectedIndexChanged
        If lvwTeams.SelectedItems.Count > 0 Then
            mintTeamID = Convert.ToInt32(lvwTeams.SelectedItems(0).Tag)
            ListBoxSelect(cboTeams, maryTeams, mintTeamID)
        End If
    End Sub

End Class