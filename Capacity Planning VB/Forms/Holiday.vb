Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class Holiday
    Private mblnUpdatingControls As Boolean
    Private mblnLoadingYear As Boolean
    Private maryTeams() As Long
    Private maryPeople() As Long
    Private maryDiaryItems(,) As String
    Private maryDiaryDisplayItems(,) As Double

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub About_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadFormData()
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
        Dim intItem As Integer
        Dim intStartYear As Integer

        ReDim maryDiaryItems(0 To 0, 0 To 9)

        intStartYear = Year(Now) - 2
        intItem = cboYear.Items.Add(intStartYear)
        intItem = cboYear.Items.Add(intStartYear + 1)
        intItem = cboYear.Items.Add(intStartYear + 2)
        ' select the current year by default
        cboYear.SelectedItem = cboYear.Items(intItem)
        intItem = cboYear.Items.Add(intStartYear + 3)
        intItem = cboYear.Items.Add(intStartYear + 4)
        intItem = cboYear.Items.Add(intStartYear + 5)

        ' Fill out the teams
        strSQL = Get_Teams()

        FillListBox(cboTeams, maryTeams, "Name", strSQL, "ID")
    End Sub

    Private Sub cboTeams_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTeams.SelectedIndexChanged
        Dim strSQL As String
        Dim intTeamID As Integer
        Dim intItem As Integer

        ' get the team id
        intTeamID = maryTeams(cboTeams.SelectedIndex)

        ' get the people in the team
        strSQL = Get_PeopleInTeam(intTeamID)

        cboPeople.Items.Clear()
        intItem = cboPeople.Items.Add("<Whole Team>")
        cboPeople.SelectedItem = cboPeople.Items(intItem)

        FillListBox(cboPeople, maryPeople, "Name", strSQL, "ID", True)
    End Sub


    ' indicate if the form is in edit (view mode if false)
    Private mblnEditMode As Boolean = False
    Public Property EditMode() As Boolean
        Get
            Return mblnEditMode
        End Get
        Set(ByVal value As Boolean)
            mblnEditMode = value

            If value Then
                pnlBottomBar.BackColor = Color.Azure
            Else
                pnlBottomBar.BackColor = Color.Transparent
            End If
        End Set
    End Property

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        EditMode = True
        CheckControls()
    End Sub

    Private Sub cmdView_Click(sender As Object, e As EventArgs) Handles cmdView.Click
        EditMode = False
        CheckControls()
    End Sub

    Private Sub CheckControls(Optional ByRef ctlX As ctlSwitch = Nothing)
        mblnUpdatingControls = True

        If EditMode Then
            ' we only need to enforce controls if edit mode is set
            ' in edit mode only allow one type of holiday to be selected at once
            If ctlType1.Value = True And (ctlX Is Nothing Or ctlX Is ctlType1) Then
                ' ensure that the other controls have their value to false
                ctlType2.Value = False
                ctlType3.Value = False
                ctlType4.Value = False
                ctlType5.Value = False
                ctlType6.Value = False
            ElseIf ctlType2.Value = True And (ctlX Is Nothing Or ctlX Is ctlType2) Then
                ctlType1.Value = False
                ctlType3.Value = False
                ctlType4.Value = False
                ctlType5.Value = False
                ctlType6.Value = False
            ElseIf ctlType3.Value = True And (ctlX Is Nothing Or ctlX Is ctlType3) Then
                ctlType1.Value = False
                ctlType2.Value = False
                ctlType4.Value = False
                ctlType5.Value = False
                ctlType6.Value = False
            ElseIf ctlType4.Value = True And (ctlX Is Nothing Or ctlX Is ctlType4) Then
                ctlType1.Value = False
                ctlType2.Value = False
                ctlType3.Value = False
                ctlType5.Value = False
                ctlType6.Value = False
            ElseIf ctlType5.Value = True And (ctlX Is Nothing Or ctlX Is ctlType5) Then
                ctlType1.Value = False
                ctlType2.Value = False
                ctlType3.Value = False
                ctlType4.Value = False
                ctlType6.Value = False
            ElseIf ctlType6.Value = True And (ctlX Is Nothing Or ctlX Is ctlType6) Then
                ctlType1.Value = False
                ctlType2.Value = False
                ctlType3.Value = False
                ctlType4.Value = False
                ctlType5.Value = False
            End If

            ' for editing, show the hald-day option
            If lblHalfDay.Visible = False Then
                lblHalfDay.Visible = True
            End If
            If ctlHalfDay.Visible = False Then
                ctlHalfDay.Visible = True
            End If
        Else
            ' in view mode, so make sure we dont display the half day or whole team
            ' dont display the half day option
            If lblHalfDay.Visible = True Then
                lblHalfDay.Visible = False
            End If
            If ctlHalfDay.Visible = True Then
                ctlHalfDay.Visible = False
            End If
        End If

        mblnUpdatingControls = False
    End Sub

    Private Sub ctlType1_Click(sender As Object) Handles ctlType1.Clicked, ctlType2.Clicked, ctlType3.Clicked, ctlType4.Clicked, ctlType5.Clicked, ctlType6.Clicked
        If mblnUpdatingControls = False Then
            CheckControls(sender)
            StartShowYearTimer()
        End If
    End Sub

    Private Sub ctlYearView_Resize(sender As Object, e As EventArgs) Handles ctlYearView.Resize
        ctlYearView.Refresh()
    End Sub

    Private Sub StartShowYearTimer()
        If cboTeams.SelectedIndex > -1 Then
            If mblnLoadingYear = False Then
                tmrShowCalendar.Enabled = False
                tmrShowCalendar.Enabled = True
            End If
        End If
    End Sub

    Private Sub tmrShowCalendar_Tick(sender As Object, e As EventArgs) Handles tmrShowCalendar.Tick
        tmrShowCalendar.Enabled = False
        If cboTeams.SelectedIndex > -1 Then
            mblnLoadingYear = True
            ShowYearData()
            mblnLoadingYear = False
        End If
    End Sub

    Private Sub ShowYearData()
        '
        ' this procude will show the data for the selected team / person and taking the display options selected
        '
        ' a value of -1 is used to represent a non-entity
        Dim strTypeCSV As String
        Dim intYear As Integer
        Dim intTeamID As Integer
        Dim intPersonID As Integer
        Dim strSQL As String


        strTypeCSV = GetTypeCSV()
        intYear = cboYear.Text
        If cboTeams.SelectedIndex > -1 Then
            intTeamID = maryTeams(cboTeams.SelectedIndex)
            If cboPeople.Text <> "<Whole Team>" Then
                intPersonID = maryTeams(cboPeople.SelectedIndex)
            Else
                intPersonID = 0
            End If

            strSQL = Get_Absences(intYear, intTeamID, strTypeCSV, intPersonID)

            PopulateAbsenceArray(strSQL)

            PopulateDiaryDisplayArray()

            ' set the diary items to display
            ctlYearView.DiaryItemArray(maryDiaryDisplayItems)
            ctlYearView.Refresh()
        End If
    End Sub

    Private Function GetTypeCSV() As String
        Dim strTypeCSV As String

        strTypeCSV = ""

        If ctlType1.Value Then
            If strTypeCSV <> "" Then
                strTypeCSV = strTypeCSV & ","
            End If
            strTypeCSV = strTypeCSV & "1"
        End If
        If ctlType2.Value Then
            If strTypeCSV <> "" Then
                strTypeCSV = strTypeCSV & ","
            End If
            strTypeCSV = strTypeCSV & "2"
        End If
        If ctlType3.Value Then
            If strTypeCSV <> "" Then
                strTypeCSV = strTypeCSV & ","
            End If
            strTypeCSV = strTypeCSV & "3"
        End If
        If ctlType4.Value Then
            If strTypeCSV <> "" Then
                strTypeCSV = strTypeCSV & ","
            End If
            strTypeCSV = strTypeCSV & "4"
        End If
        If ctlType5.Value Then
            If strTypeCSV <> "" Then
                strTypeCSV = strTypeCSV & ","
            End If
            strTypeCSV = strTypeCSV & "5"
        End If
        If ctlType6.Value Then
            If strTypeCSV <> "" Then
                strTypeCSV = strTypeCSV & ","
            End If
            strTypeCSV = strTypeCSV & "6"
        End If

        Return strTypeCSV
    End Function

    Private Sub PopulateAbsenceArray(ByVal SQLStatement As String)
        Dim dataTable As DataTable
        Dim dataRow As DataRow

        Dim strSQL As String
        Dim intMaxRows As Integer
        Dim intItem As Integer


        strSQL = SQLStatement

        intItem = 1

        dataTable = gDB.OpenDataset(strSQL).Tables("Table")

        If dataTable.IsInitialized Then
            intMaxRows = dataTable.Rows.Count

            ReDim maryDiaryItems(0 To intMaxRows, 0 To 9)

            For Each dataRow In dataTable.Rows
                maryDiaryItems(intItem, enumAbsenceArrayColumn.ID) = dataRow.Item("ID").ToString & ""
                maryDiaryItems(intItem, enumAbsenceArrayColumn.AbsenceDate) = dataRow.Item("AbsenceDate").ToString & ""
                maryDiaryItems(intItem, enumAbsenceArrayColumn.AbsenceType) = dataRow.Item("AbsenceTypeID").ToString & ""
                maryDiaryItems(intItem, enumAbsenceArrayColumn.TeamID) = dataRow.Item("TeamID").ToString & ""
                maryDiaryItems(intItem, enumAbsenceArrayColumn.PersonID) = dataRow.Item("PersonID").ToString & ""
                maryDiaryItems(intItem, enumAbsenceArrayColumn.HalfDay) = dataRow.Item("HalfDay").ToString & ""
                maryDiaryItems(intItem, enumAbsenceArrayColumn.WholeTeamAbsence) = dataRow.Item("WholeTeamAbsence").ToString & ""
                maryDiaryItems(intItem, enumAbsenceArrayColumn.OtherReason) = dataRow.Item("OtherReason").ToString & ""
                maryDiaryItems(intItem, enumAbsenceArrayColumn.LocationAbsence) = dataRow.Item("LocationAbsence").ToString & ""
                maryDiaryItems(intItem, enumAbsenceArrayColumn.UpdateStatus) = "0" ' 0 = unchanged

                intItem = intItem + 1
            Next
        End If

    End Sub

    Private Sub PopulateDiaryDisplayArray()
        Dim intPointer As Integer

        ReDim maryDiaryDisplayItems(0 To UBound(maryDiaryItems, 1), 0 To 2)

        For intPointer = 1 To UBound(maryDiaryItems, 1)
            maryDiaryDisplayItems(intPointer, 1) = CDate(maryDiaryItems(intPointer, enumAbsenceArrayColumn.AbsenceDate)).ToOADate
            maryDiaryDisplayItems(intPointer, 2) = CInt(maryDiaryItems(intPointer, enumAbsenceArrayColumn.AbsenceType))
        Next
    End Sub

    Private Sub SelectionChanged(sender As Object, e As EventArgs) Handles cboYear.SelectedIndexChanged, cboTeams.SelectedIndexChanged, cboPeople.SelectedIndexChanged
        ctlYearView.ActiveYear = cboYear.Text
        StartShowYearTimer()
    End Sub
End Class