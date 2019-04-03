Module dbTeams
    Public Function Get_Teams() As String

        Dim strSQL As String

        strSQL = "SELECT TeamID ID "
        strSQL = strSQL & ",TeamName Name "
        strSQL = strSQL & ",ISNULL(TemplateName,'') Template "

        strSQL = strSQL & "FROM Team "
        strSQL = strSQL & "LEFT JOIN SprintTemplate ON Team.SprintTemplateID = SprintTemplate.SprintTemplateID "

        strSQL = strSQL & "ORDER BY TeamName "

        Return strSQL
    End Function


    Public Function Get_PeopleInTeam(ByVal intTeamID As Integer) As String

        Dim strSQL As String

        strSQL = "SELECT PersonID ID "
        strSQL = strSQL & ",PersonName Name "
        strSQL = strSQL & ",ISNULL(LocationName,'') Location "

        strSQL = strSQL & "FROM Person "
        strSQL = strSQL & "LEFT JOIN Location ON Person.LocationID = Location.LocationID "

        strSQL = strSQL & "WHERE TeamID = " & intTeamID & " "

        strSQL = strSQL & "ORDER BY PersonName "

        Return strSQL
    End Function


    Public Function Get_TeamByID(ByVal intTeamID As Integer) As String
        Dim strSQL As String

        strSQL = "SELECT TeamName Name "
        strSQL = strSQL & ",ISNULL(SprintTemplateID,0) SprintTemplateID "

        strSQL = strSQL & "FROM Team "

        strSQL = strSQL & "WHERE TeamID = " & intTeamID & " "

        Return strSQL
    End Function


    Public Function Get_PersonByID(ByVal intPersonID As Integer) As String
        Dim strSQL As String

        strSQL = "SELECT PersonName Name "
        strSQL = strSQL & ",TeamID "
        strSQL = strSQL & ",LocationID "

        strSQL = strSQL & "FROM Person "

        strSQL = strSQL & "WHERE PersonID = " & intPersonID & " "

        Return strSQL
    End Function


    Public Function Update_Team(ByVal intTeamID As Integer, ByVal strTeamName As String, ByVal intSprintTemplateID As Integer) As Boolean
        Dim strSQL As String
        Dim blnSuccess As Boolean

        blnSuccess = True
        On Error GoTo ERR_UpdateTeamFailed

        strSQL = "UPDATE Team "

        strSQL = strSQL & "SET TeamName = '" & SQLString(strTeamName) & "' "
        strSQL = strSQL & ",SprintTemplateID = " & intSprintTemplateID & " "

        strSQL = strSQL & "WHERE TeamID = " & intTeamID & " "

        gDB.Execute(strSQL)

RES_UpdateTeamFailed:
        Return blnSuccess
ERR_UpdateTeamFailed:
        blnSuccess = False
        Resume RES_UpdateTeamFailed
    End Function


    Public Function Update_Person(ByVal intPersonID As Integer, ByVal strPersonName As String, ByVal intPersonTeamID As Integer, ByVal intLocationID As Integer) As Boolean
        Dim strSQL As String
        Dim blnSuccess As Boolean

        blnSuccess = True
        On Error GoTo ERR_UpdatePersonFailed

        strSQL = "UPDATE Person "

        strSQL = strSQL & "SET PersonName = '" & SQLString(strPersonName) & "' "
        strSQL = strSQL & ",TeamID = " & intPersonTeamID & " "
        strSQL = strSQL & ",LocationID = " & intLocationID & " "

        strSQL = strSQL & "WHERE PersonID = " & intPersonID & " "

        gDB.Execute(strSQL)

RES_UpdatePersonFailed:
        Return blnSuccess
ERR_UpdatePersonFailed:
        blnSuccess = False
        Resume RES_UpdatePersonFailed
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

        strSQL = "INSERT INTO Person (PersonName, TeamID, LocationID) VALUES ('New Person'," & intTeamID & ",0); SELECT SCOPE_IDENTITY() ID; "
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

        strSQL = "DELETE FROM Team "
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

        strSQL = "DELETE FROM Person "
        strSQL = strSQL & "WHERE PersonID = " & intPersonID & " "

        gDB.Execute(strSQL)

RES_DeletePersonFailed:
        Return blnSuccess
ERR_DeletePersonFailed:
        blnSuccess = False
        Resume RES_DeletePersonFailed
    End Function

End Module
