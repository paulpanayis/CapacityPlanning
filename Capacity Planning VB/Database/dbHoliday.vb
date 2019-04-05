Module dbHoliday
    Public Enum enumAbsenceArrayColumn
        ID = 0
        AbsenceDate = 1
        AbsenceType = 2
        TeamID = 3
        PersonID = 4
        HalfDay = 5
        WholeTeamAbsence = 6
        OtherReason = 7
        LocationAbsence = 8
        UpdateStatus = 9
    End Enum

    Public Function Get_Absences(ByVal intYear As Integer, ByVal TeamID As Integer, Optional ByVal strTypesCSV As String = "", Optional ByVal PersonID As Integer = 0) As String
        Dim strSQL As String

        ' firstly the team and person absences
        strSQL = "SELECT Absence.AbsenceID ID "
        strSQL = strSQL & ", Absence.AbsenceDate "
        strSQL = strSQL & ", Absence.AbsenceTypeID "
        strSQL = strSQL & ", Team.TeamID "
        strSQL = strSQL & ", ISNULL(Absence.PersonID, 0) PersonID "
        strSQL = strSQL & ", Absence.HalfDay "
        strSQL = strSQL & ", Absence.WholeTeamAbsence "
        strSQL = strSQL & ", Absence.OtherReason "
        strSQL = strSQL & ", 0 AS LocationAbsence "

        strSQL = strSQL & "FROM Team "
        strSQL = strSQL & "INNER JOIN Absence ON Team.TeamID = Absence.TeamID "

        strSQL = strSQL & "WHERE Team.TeamID = " & TeamID & " "
        strSQL = strSQL & "AND YEAR(Absence.AbsenceDate) = " & intYear & " "
        If PersonID > 0 Then
            strSQL = strSQL & "AND (Absence.PersonID = " & PersonID & " OR Absence.WholeTeamAbsence = 1) "
        Else
            strSQL = strSQL & "AND Absence.WholeTeamAbsence = 1 "
        End If
        If strTypesCSV <> "" Then
            strSQL = strSQL & "AND Absence.AbsenceTypeID IN (" & strTypesCSV & ") "
        End If

        strSQL = strSQL & "ORDER BY Absence.AbsenceDate "

        Return strSQL
    End Function

    Public Function Get_LocationAbsences(ByVal intYear As Integer, ByVal PersonID As Integer) As String
        Dim strSQL As String

        ' different team members may be in different locations, with different public holidays
        ' so we have to do location absences by person and can't do it by team
        strSQL = "SELECT LocationAbsence.LocationAbsenceID ID "
        strSQL = strSQL & ", LocationAbsence.AbsenceDate "
        strSQL = strSQL & ", LocationAbsence.AbsenceTypeID "
        strSQL = strSQL & ", Team.TeamID "
        strSQL = strSQL & ", Person.PersonID AS PersonID "
        strSQL = strSQL & ", 0 AS HalfDay "
        strSQL = strSQL & ", 0 AS WholeTeamAbsence "
        strSQL = strSQL & ", LocationAbsence.OtherReason "
        strSQL = strSQL & ", 1 AS LocationAbsence "

        strSQL = strSQL & "FROM Person "
        strSQL = strSQL & "INNER JOIN Team ON Person.TeamID = Team.TeamID "
        strSQL = strSQL & "INNER JOIN LocationAbsence ON Person.LocationID = LocationAbsence.LocationID "

        strSQL = strSQL & "WHERE Person.PersonID = " & PersonID & " "
        strSQL = strSQL & "AND YEAR(LocationAbsence.AbsenceDate) = " & intYear & " "

        strSQL = strSQL & "ORDER BY LocationAbsence.AbsenceDate "

        Return strSQL
    End Function

    Public Function Update_Absence(ByVal dteAbsenceDate As Date, ByVal blnHalfDay As Boolean, ByVal intAbsenceType As Integer, ByVal intTeamID As Integer, Optional ByVal intPersonID As Integer = 0) As Boolean
        Dim strSQL As String
        Dim blnSuccess As Boolean

        blnSuccess = True
        On Error GoTo ERR_UpdateAbsenceFailed

        If intPersonID = 0 Then
            strSQL = "EXEC HOLIDAY_TOGGLE_ABSENCE_TEAM " & intTeamID & " "
            strSQL = strSQL & ", " & SQLDate(dteAbsenceDate) & " "
            strSQL = strSQL & ", " & intAbsenceType & " "
            If blnHalfDay Then
                strSQL = strSQL & ", 1 "
            Else
                strSQL = strSQL & ", 0 "
            End If
        Else
            strSQL = "EXEC HOLIDAY_TOGGLE_ABSENCE_PERSON " & intPersonID & " "
            strSQL = strSQL & ", " & intTeamID & " "
            strSQL = strSQL & ", " & SQLDate(dteAbsenceDate) & " "
            strSQL = strSQL & ", " & intAbsenceType & " "
            If blnHalfDay Then
                strSQL = strSQL & ", 1 "
            Else
                strSQL = strSQL & ", 0 "
            End If
        End If
        gDB.Execute(strSQL)

RES_UpdateAbsenceFailed:
        Return blnSuccess
ERR_UpdateAbsenceFailed:
        blnSuccess = False
        Resume RES_UpdateAbsenceFailed
    End Function
End Module
