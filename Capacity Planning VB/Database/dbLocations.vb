Module dbLocations
    Public Function Get_Locations() As String
        Dim strSQL As String

        strSQL = "SELECT LocationID ID "
        strSQL = strSQL & ",LocationName Name "

        strSQL = strSQL & "FROM Location "

        strSQL = strSQL & "ORDER BY LocationName "

        Return strSQL
    End Function

    Public Function Update_Location(ByVal intLocationID As Integer, ByVal strLocationName As String) As Boolean
        Dim strSQL As String
        Dim blnSuccess As Boolean

        blnSuccess = True
        On Error GoTo ERR_UpdateLocationFailed

        strSQL = "UPDATE Location "

        strSQL = strSQL & "SET LocationName = '" & SQLString(strLocationName) & "' "

        strSQL = strSQL & "WHERE LocationID = " & intLocationID & " "

        gDB.Execute(strSQL)

RES_UpdateLocationFailed:
        Return blnSuccess
ERR_UpdateLocationFailed:
        blnSuccess = False
        Resume RES_UpdateLocationFailed
    End Function


    Public Function Add_Location() As Integer
        Dim strSQL As String
        Dim intLastID As Integer
        Dim dataTable As DataTable

        strSQL = "INSERT INTO Location (LocationName) VALUES ('New Location'); SELECT SCOPE_IDENTITY() ID; "
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


    Public Function Delete_Location(ByVal intLocationID As Integer) As Boolean
        Dim strSQL As String
        Dim blnSuccess As Boolean

        blnSuccess = True
        On Error GoTo ERR_DeleteLocationFailed

        strSQL = "DELETE FROM Location "
        strSQL = strSQL & "WHERE LocationID = " & intLocationID & " "

        gDB.Execute(strSQL)

RES_DeleteLocationFailed:
        Return blnSuccess
ERR_DeleteLocationFailed:
        blnSuccess = False
        Resume RES_DeleteLocationFailed
    End Function
End Module
