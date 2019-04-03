Module dbSprints
    Public Function Get_SprintTemplates() As String
        Dim strSQL As String

        strSQL = "SELECT SprintTemplateID ID "
        strSQL = strSQL & ",TemplateName Name "
        strSQL = strSQL & ",SprintStartDay StartDay "

        strSQL = strSQL & "FROM SprintTemplate "

        strSQL = strSQL & "ORDER BY TemplateName "

        Return strSQL
    End Function


    Public Function Get_Sprints(ByVal intSprintTemplateID As Integer, ByVal intYearFilter As Integer) As String
        Dim strSQL As String

        ' there could be a lot of sprints, so limit to last 200
        strSQL = "SELECT Top 200 SprintID ID "
        strSQL = strSQL & ",SprintNumber [Sprint Number] "
        strSQL = strSQL & ",FORMAT(StartDate,'d MMM yyyy') [Start Date] "
        strSQL = strSQL & ",FORMAT(EndDate,'d MMM yyyy') [End Date] "

        strSQL = strSQL & "FROM Sprint "

        strSQL = strSQL & "WHERE SprintTemplateID = " & intSprintTemplateID & " "
        If intYearFilter > 0 Then
            strSQL = strSQL & "AND (YEAR(StartDate) = " & intYearFilter & " OR YEAR(EndDate) = " & intYearFilter & ") "
        End If

        ' display in reverse date order (so we get latest first)
        strSQL = strSQL & "ORDER BY StartDate DESC "

        Return strSQL
    End Function


    Public Function Add_SprintTemplate() As Integer
        Dim strSQL As String
        Dim intLastID As Integer
        Dim dataTable As DataTable

        strSQL = "INSERT INTO SprintTemplate (TemplateName, SprintStartDay) VALUES ('New Template','Monday'); SELECT SCOPE_IDENTITY() ID; "
        intLastID = 0

        dataTable = gDB.OpenDataset(strSQL).Tables("Table")

        If dataTable.Rows.Count > 0 Then
            Dim drCurrent As DataRow

            For Each drCurrent In dataTable.Rows
                ' hopefully only one!
                intLastID = drCurrent("ID")
            Next
        End If

        Return intLastID
    End Function

    Public Function Add_Sprints(ByVal intSprintTemplateID As Integer, ByVal intSprintStartNumber As Integer, ByVal dteStart As Date, ByVal dteEnd As Date, ByVal intWeeksInSprint As Integer)
        Dim blnSuccess As Boolean
        Dim strSQL As String
        Dim intSprintNumber As Integer
        Dim dteWorking As Date
        Dim dteEndDate As Date
        Dim intSprintCount As Integer

        intSprintCount = 0
        dteWorking = dteStart
        ' we'll add one to the sprint working number straight away, so start at the sprint number before
        intSprintNumber = intSprintStartNumber - 1

        blnSuccess = True
        On Error GoTo ERR_AddSprintsFailed

        ' add range of sprints
        Do While dteWorking <= dteEnd
            intSprintCount = intSprintCount + 1
            intSprintNumber = intSprintNumber + 1
            dteEndDate = DateAdd(DateInterval.Day, (intWeeksInSprint * 7) - 1, dteWorking)

            strSQL = "INSERT INTO Sprint (SprintTemplateID, SprintNumber, StartDate, EndDate) "
            strSQL = strSQL & "VALUES ( " & intSprintTemplateID & " "
            strSQL = strSQL & "," & intSprintNumber & " "
            strSQL = strSQL & "," & SQLDate(dteWorking) & " "
            strSQL = strSQL & "," & SQLDate(dteEndDate) & " "
            strSQL = strSQL & ") "
            gDB.Execute(strSQL)

            dteWorking = DateAdd(DateInterval.Day, (intWeeksInSprint * 7), dteWorking)
        Loop

RES_AddSprintsFailed:
        Return blnSuccess
ERR_AddSprintsFailed:
        blnSuccess = False
        MsgBox(Err.Description)
        Resume RES_AddSprintsFailed
    End Function

    Public Function Delete_SprintTemplate(ByVal intTemplateID As Integer) As Boolean
        Dim strSQL As String
        Dim blnSuccess As Boolean

        blnSuccess = True
        On Error GoTo ERR_DeleteTemplateFailed

        strSQL = "DELETE FROM SprintTemplate "
        strSQL = strSQL & "WHERE SprintTemplateID = " & intTemplateID & " "

        gDB.Execute(strSQL)

RES_DeleteTemplateFailed:
        Return blnSuccess
ERR_DeleteTemplateFailed:
        blnSuccess = False
        Resume RES_DeleteTemplateFailed
    End Function


    Public Function Update_SprintTemplate(ByVal intTemplateID As Integer, ByVal strTemplateName As String, ByVal strTemplateStartDay As String) As Boolean
        Dim strSQL As String
        Dim blnSuccess As Boolean

        blnSuccess = True
        On Error GoTo ERR_UpdateTemplateFailed

        strSQL = "UPDATE SprintTemplate "

        strSQL = strSQL & "SET TemplateName = '" & SQLString(strTemplateName) & "' "
        strSQL = strSQL & ",SprintStartDay = '" & SQLString(strTemplateStartDay) & "' "

        strSQL = strSQL & "WHERE SprintTemplateID = " & intTemplateID & " "

        gDB.Execute(strSQL)

RES_UpdateTemplateFailed:
        Return blnSuccess
ERR_UpdateTemplateFailed:
        blnSuccess = False
        Resume RES_UpdateTemplateFailed
    End Function


    Public Function Update_Sprint(ByVal intSprintID As Integer, ByVal intSprintNumber As Integer, ByVal strStartDate As String, ByVal strEndDate As String) As Boolean
        Dim strSQL As String
        Dim blnSuccess As Boolean

        blnSuccess = True
        On Error GoTo ERR_UpdateSprintFailed

        strSQL = "UPDATE Sprint "

        strSQL = strSQL & "SET SprintNumber = " & intSprintNumber & " "
        strSQL = strSQL & ",StartDate = " & SQLDate(CDate(strStartDate)) & " "
        strSQL = strSQL & ",EndDate = " & SQLString(CDate(strEndDate)) & " "

        strSQL = strSQL & "WHERE SprintID = " & intSprintID & " "

        gDB.Execute(strSQL)

RES_UpdateSprintFailed:
        Return blnSuccess
ERR_UpdateSprintFailed:
        blnSuccess = False
        Resume RES_UpdateSprintFailed
    End Function


    Public Function Delete_Sprint(ByVal intSprintID As Integer) As Boolean
        Dim strSQL As String
        Dim blnSuccess As Boolean

        blnSuccess = True
        On Error GoTo ERR_DeleteSprintFailed

        strSQL = "DELETE FROM Sprint "
        strSQL = strSQL & "WHERE SprintID = " & intSprintID & " "

        gDB.Execute(strSQL)

RES_DeleteSprintFailed:
        Return blnSuccess
ERR_DeleteSprintFailed:
        blnSuccess = False
        Resume RES_DeleteSprintFailed
    End Function

End Module
