Module modDatabaseFunctions

    Public gDB As New clsSQLDB

    Public Enum enumScanType
        BeltScan = 0
        ChefScan = 1
        TillScan = 2
        WasteScan = 3
    End Enum

    Public Function GetColourID(ByVal strKey As String) As String
        Dim dataTable As DataTable

        dataTable = gDB.OpenDataset("EXEC [dbo].[rec_GetPlate] '" & SQLString(strKey) & "'").Tables("Table")
        GetColourID = dataTable.Rows.Item(0)(0).ToString()
    End Function

    Public Sub ScanKey(ByVal strKey As String, ByVal ScanType As enumScanType, Optional ByVal MenuItemID As Int16 = 0)
        Dim strSQL As String

        Select Case ScanType
            Case enumScanType.ChefScan
                strSQL = "EXEC pr_ChefScan '" & SQLString(strKey) & "', " & MenuItemID & ""

            Case enumScanType.BeltScan
                strSQL = "EXEC pr_BeltScan '" & SQLString(strKey) & "'"

            Case enumScanType.TillScan
                strSQL = "EXEC pr_TillScan '" & SQLString(strKey) & "'"

            Case enumScanType.WasteScan
                strSQL = "EXEC pr_WasteScan '" & SQLString(strKey) & "'"

            Case Else
                strSQL = ""
        End Select

        If strSQL <> "" Then
            Interaction.Beep()
            gDB.Execute(strSQL)
        End If

    End Sub

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

End Module
