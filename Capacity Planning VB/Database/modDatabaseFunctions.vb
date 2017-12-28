Module modDatabaseCalls

    Public gDB As New clsSQLDB

    Public Function SQLString(ByVal sIN As Object) As String
        Dim sTemp As String
        Dim sOut As String
        Dim iX As Integer
        Dim vTemp As Object

        vTemp = sIN
        sOut = ""

        Select Case VarType(vTemp)
            Case vbNull
                sOut = "NULL"
            Case vbEmpty
                sOut = "''"
            Case vbString
                sTemp = Trim(vTemp)
                sOut = ""
                For iX = 1 To Len(sTemp)
                    Select Case Mid(sTemp, iX, 1)
                        Case "A" To "Z", "a" To "z", "0" To "9", "!", """", "£", "$", "%", "^", "&", "*", "(", ")", "_", "-", "+", "=", "{", "}", "[", "]", "@", ";", ":", "<", ">", ",", ".", "?", "/", "¬", "|", "#", "~", " "
                            sOut = sOut & Mid(sTemp, iX, 1)
                        Case vbCr, vbLf
                            sOut = sOut & Mid(sTemp, iX, 1)
                        Case "\"
                            sOut = sOut & "\\"
                        Case "'"
                            sOut = sOut & "''"
                    End Select
                Next
            Case vbDate
                sOut = SQLDate(vTemp)
            Case vbInteger, vbLong, vbByte
                sOut = Format(vTemp, "0")
            Case vbDouble, vbSingle, vbDecimal, vbCurrency
                sOut = Format(vTemp, "General Number")
            Case vbBoolean
                sOut = Math.Abs(vTemp) & ""
        End Select
        SQLString = Trim(sOut)

    End Function

    Public Function SQLDate(ByVal dteDate As Date) As String
        SQLDate = "'" & Format(dteDate, "yyyy-MM-dd") & "'"
    End Function

    Public Function SQLDateTime(ByVal dteDate As Date) As String
        SQLDateTime = "'" & Format(dteDate, "yyyy-MM-dd hh:nn:ss") & "'"
    End Function

    Public Function ZeroIfNull(ByVal valX As Object) As Double
        If IsDBNull(valX) = True Then
            ZeroIfNull = 0
        Else
            ZeroIfNull = valX
        End If
    End Function

    Public Function Get_Teams() As String

        Dim strSQL As String

        strSQL = "SELECT TeamID ID "
        strSQL = strSQL + ",TeamName Name "
        strSQL = strSQL + ",ISNULL(LocationName,'') Location "
        strSQL = strSQL + ",ISNULL(TemplateName,'') Template "

        strSQL = strSQL + "FROM Team "
        strSQL = strSQL + "LEFT JOIN SprintTemplate ON Team.SprintTemplateID = SprintTemplate.SprintTemplateID "
        strSQL = strSQL + "LEFT JOIN Location ON Team.LocationID = Location.LocationID "

        strSQL = strSQL + "ORDER BY TeamName "

        Return strSQL
    End Function

    Public Function Get_PeopleInTeam(ByVal intTeamID As Integer) As String

        Dim strSQL As String

        strSQL = "SELECT PersonID ID "
        strSQL = strSQL + ",PersonName Name "

        strSQL = strSQL + "FROM Person "

        strSQL = strSQL & "WHERE TeamID = " & intTeamID & " "

        strSQL = strSQL + "ORDER BY PersonName "

        Return strSQL
    End Function


    Public Function Get_Reports() As String
        Dim strSQL As String

        strSQL = "SELECT ReportID ID "
        strSQL = strSQL + ",Name "
        strSQL = strSQL + ",Description "

        strSQL = strSQL + "FROM Report "

        strSQL = strSQL + "ORDER BY Name "

        Return strSQL
    End Function


    Public Function Get_Locations() As String
        Dim strSQL As String

        strSQL = "SELECT LocationID ID "
        strSQL = strSQL + ",LocationName Name "

        strSQL = strSQL + "FROM Location "

        strSQL = strSQL + "ORDER BY LocationName "

        Return strSQL
    End Function


    Public Function Get_SprintTemplates() As String
        Dim strSQL As String

        strSQL = "SELECT SprintTemplateID ID "
        strSQL = strSQL + ",TemplateName Name "

        strSQL = strSQL + "FROM SprintTemplate "

        strSQL = strSQL + "ORDER BY TemplateName "

        Return strSQL
    End Function


    Public Function Get_ReportByID(ByVal intReportID As Integer) As String
        Dim strSQL As String

        strSQL = "SELECT ReportID ID "
        strSQL = strSQL & ",Name "
        strSQL = strSQL & ",Description "
        strSQL = strSQL & ",StoredProcedure "
        strSQL = strSQL & ",DateFromLabel "
        strSQL = strSQL & ",DateToLabel "

        strSQL = strSQL & "FROM Report "

        strSQL = strSQL & "WHERE ReportID = " & intReportID & " "

        Return strSQL
    End Function


    Public Function Get_TeamByID(ByVal intTeamID As Integer) As String
        Dim strSQL As String

        strSQL = "SELECT TeamName Name "
        strSQL = strSQL & ",ISNULL(SprintTemplateID,0) SprintTemplateID "
        strSQL = strSQL & ",ISNULL(LocationID,0) LocationID "

        strSQL = strSQL & "FROM Team "

        strSQL = strSQL & "WHERE TeamID = " & intTeamID & " "

        Return strSQL
    End Function


    Public Function Get_PersonByID(ByVal intPersonID As Integer) As String
        Dim strSQL As String

        strSQL = "SELECT PersonName Name "
        strSQL = strSQL & ",TeamID "

        strSQL = strSQL & "FROM Person "

        strSQL = strSQL & "WHERE PersonID = " & intPersonID & " "

        Return strSQL
    End Function


    Public Function Update_Person(ByVal intPersonID As Integer, ByVal strPersonName As String, ByVal intPersonTeamID As Integer) As Boolean
        Dim strSQL As String
        Dim blnSuccess As Boolean

        blnSuccess = True
        On Error GoTo ERR_UpdatePersonFailed

        strSQL = "UPDATE Person "

        strSQL = strSQL & "SET PersonName = '" & SQLString(strPersonName) & "' "
        strSQL = strSQL & ",TeamID = " & intPersonTeamID & " "

        strSQL = strSQL & "WHERE PersonID = " & intPersonID & " "

        gDB.Execute(strSQL)

RES_UpdatePersonFailed:
        Return blnSuccess
ERR_UpdatePersonFailed:
        blnSuccess = False
        Resume RES_UpdatePersonFailed
    End Function

    Public Function Update_Team(ByVal intTeamID As Integer, ByVal strTeamName As String, ByVal intSprintTemplateID As Integer, ByVal intTeamLocationID As Integer) As Boolean
        Dim strSQL As String
        Dim blnSuccess As Boolean

        blnSuccess = True
        On Error GoTo ERR_UpdateTeamFailed

        strSQL = "UPDATE Team "

        strSQL = strSQL & "SET TeamName = '" & SQLString(strTeamName) & "' "
        strSQL = strSQL & ",SprintTemplateID = " & intSprintTemplateID & " "
        strSQL = strSQL & ",LocationID = " & intTeamLocationID & " "

        strSQL = strSQL & "WHERE TeamID = " & intTeamID & " "

        gDB.Execute(strSQL)

RES_UpdateTeamFailed:
        Return blnSuccess
ERR_UpdateTeamFailed:
        blnSuccess = False
        Resume RES_UpdateTeamFailed
    End Function

    Public Function Add_Team() As Integer
        Dim strSQL As String
        Dim intLastID As Integer
        Dim dataTable As DataTable

        strSQL = "INSERT INTO Team (TeamName) VALUES ('New Team'); SELECT SCOPE_IDENTITY() ID; "
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

    Public Function Add_Person(ByVal intTeamID As Integer) As Integer
        Dim strSQL As String
        Dim intLastID As Integer
        Dim dataTable As DataTable

        strSQL = "INSERT INTO Person (PersonName, TeamID) VALUES ('New Person'," & intTeamID & "); SELECT SCOPE_IDENTITY() ID; "
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

    Public Function Delete_Team(ByVal intTeamID As Integer) As Boolean
        Dim strSQL As String
        Dim blnSuccess As Boolean

        blnSuccess = True
        On Error GoTo ERR_DeleteTeamFailed

        strSQL = "DELETE Team "
        strSQL = strSQL & "WHERE TeamID = " & intTeamID & " "

        gDB.Execute(strSQL)

RES_DeleteTeamFailed:
        Return blnSuccess
ERR_DeleteTeamFailed:
        blnSuccess = False
        Resume RES_DeleteTeamFailed
    End Function

    Public Function Delete_Person(ByVal intPersonID As Integer) As Boolean
        Dim strSQL As String
        Dim blnSuccess As Boolean

        blnSuccess = True
        On Error GoTo ERR_DeletePersonFailed

        strSQL = "DELETE Person "
        strSQL = strSQL & "WHERE PersonID = " & intPersonID & " "

        gDB.Execute(strSQL)

RES_DeletePersonFailed:
        Return blnSuccess
ERR_DeletePersonFailed:
        blnSuccess = False
        Resume RES_DeletePersonFailed
    End Function

End Module
