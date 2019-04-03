Module dbReports
    Public Function Get_Reports() As String
        Dim strSQL As String

        strSQL = "SELECT ReportID ID "
        strSQL = strSQL & ",Name "
        strSQL = strSQL & ",Description "

        strSQL = strSQL & "FROM Report "

        strSQL = strSQL & "ORDER BY Name "

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
End Module
