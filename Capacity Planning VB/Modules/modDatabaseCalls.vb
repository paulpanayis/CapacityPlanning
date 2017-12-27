Module modDatabaseCalls

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
        strSQL = strSQL & ",SprintTemplateID "
        strSQL = strSQL & ",LocationID "

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


End Module
