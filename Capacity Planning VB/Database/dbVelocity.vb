Module dbVelocity
    Public Function Get_SprintActuals(ByVal intTeamID As Integer) As String
        Dim strSQL As String

        ' there could be a lot of sprints, so limit to last 200
        strSQL = "SELECT Top 200 Sprint.SprintID ID "
        strSQL = strSQL & ",Sprint.SprintNumber [Sprint Number] "
        strSQL = strSQL & ",FORMAT(StartDate,'d MMM yyyy') [Start Date] "
        strSQL = strSQL & ",FORMAT(EndDate,'d MMM yyyy') [End Date] "
        strSQL = strSQL & ",ISNULL(CAST(StoryPoints AS varchar(11)),'<no record>') Velocity "

        strSQL = strSQL & "FROM Team "
        strSQL = strSQL & "INNER JOIN Sprint ON Team.SprintTemplateID = Sprint.SprintTemplateID "
        strSQL = strSQL & "LEFT JOIN SprintActual ON Sprint.SprintID = SprintActual.SprintID AND SprintActual.TeamID = " & intTeamID & " "

        strSQL = strSQL & "WHERE Team.TeamID = " & intTeamID & " "
        strSQL = strSQL & "AND Sprint.EndDate < DateAdd(d,1,GetDate()) "

        ' display in reverse date order (so we get latest first)
        strSQL = strSQL & "ORDER BY Sprint.EndDate DESC "

        Return strSQL
    End Function

    Public Function Delete_SprintActual(ByVal intTeamID As Integer, ByVal intSprintID As Integer) As Boolean
        Dim strSQL As String
        Dim blnSuccess As Boolean

        blnSuccess = True
        On Error GoTo ERR_DeleteSprintActualFailed

        strSQL = "DELETE FROM SprintActual "
        strSQL = strSQL & "WHERE TeamID = " & intTeamID & " "
        strSQL = strSQL & "AND SprintID = " & intSprintID & " "

        gDB.Execute(strSQL)

RES_DeleteSprintActualFailed:
        Return blnSuccess
ERR_DeleteSprintActualFailed:
        blnSuccess = False
        Resume RES_DeleteSprintActualFailed
    End Function

    Public Function UpdateInsert_SprintVelocity(ByVal intTeamID As Integer, ByVal intSprintID As Integer, ByVal decVelocity As Decimal) As Boolean
        Dim strSQL As String
        Dim blnSuccess As Boolean

        blnSuccess = True
        On Error GoTo ERR_UpdateInsertVelocityFailed


        strSQL = "IF EXISTS(SELECT 1 FROM SprintActual WHERE TeamID = " & intTeamID & " AND SprintID = " & intSprintID & ") "

        strSQL = strSQL & "  BEGIN "
        strSQL = strSQL & "UPDATE SprintActual "
        strSQL = strSQL & "SET StoryPoints = " & decVelocity & " "
        strSQL = strSQL & "WHERE TeamID = " & intTeamID & " "
        strSQL = strSQL & "AND SprintID = " & intSprintID & " "

        strSQL = strSQL & "  END "
        strSQL = strSQL & "ELSE "
        strSQL = strSQL & "  BEGIN "

        strSQL = strSQL & "INSERT INTO SprintActual (TeamID, SprintID, StoryPoints) "
        strSQL = strSQL & "VALUES ( "
        strSQL = strSQL & " " & intTeamID & " "
        strSQL = strSQL & "," & intSprintID & " "
        strSQL = strSQL & "," & decVelocity & " "
        strSQL = strSQL & ") "

        strSQL = strSQL & "  END "

        gDB.Execute(strSQL)

RES_UpdateInsertVelocityFailed:
        Return blnSuccess
ERR_UpdateInsertVelocityFailed:
        blnSuccess = False
        Resume RES_UpdateInsertVelocityFailed
    End Function

End Module
