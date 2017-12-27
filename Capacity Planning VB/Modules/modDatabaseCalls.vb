Module modDatabaseCalls

    Public Function Get_Teams() As String

        Dim strSQL As String

        strSQL = "SELECT TeamID "
        strSQL = strSQL + ",TeamName Team "
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

        strSQL = "SELECT PersonID "
        strSQL = strSQL + ",PersonName Name "

        strSQL = strSQL + "FROM Person "

        strSQL = strSQL & "WHERE TeamID = " & intTeamID & " "

        strSQL = strSQL + "ORDER BY PersonName "

        Return strSQL
    End Function


    Public Function Get_Reports() As String
        Dim strSQL As String

        strSQL = "SELECT ReportID "
        strSQL = strSQL + ",Name "
        strSQL = strSQL + ",Description "

        strSQL = strSQL + "FROM Report "

        strSQL = strSQL + "ORDER BY Name "

        Return strSQL
    End Function


    Public Function Get_ReportByID(ByVal intReportID As Integer) As String
        Dim strSQL As String

        strSQL = "SELECT ReportID "
        strSQL = strSQL & ",Name "
        strSQL = strSQL & ",Description "
        strSQL = strSQL & ",StoredProcedure "
        strSQL = strSQL & ",DateFromLabel "
        strSQL = strSQL & ",DateToLabel "

        strSQL = strSQL & "FROM Report "

        strSQL = strSQL & "WHERE ReportID = " & intReportID & " "

        Return strSQL
    End Function


End Module
