Imports Microsoft.Office.Interop


Public Class clsExcel

    Private objApp As Excel.Application
    Private objBook As Excel._Workbook

    Public Sub New()
        objApp = New Excel.Application()
    End Sub

    Public Function ExcelInstalled() As Boolean
        '
        ' this procedure will determine if office si installed on this PC
        '
        On Error GoTo ERR_ExcelInstalled

        If objApp Is Nothing Then
            ExcelInstalled = False
        Else
            ExcelInstalled = True
            ' we have proven it is installed, now release the object we just created
            objApp = Nothing
        End If

RES_ExcelInstalled:

        Exit Function

ERR_ExcelInstalled:
        ExcelInstalled = False
        Resume RES_ExcelInstalled

    End Function


    Public Sub PasteListView(ByVal lvwX As ListView, Optional ByVal NoHeader As Boolean = False)
        Dim intRows As Integer
        Dim intColumns As Integer


        Dim objBooks As Excel.Workbooks
        Dim objSheets As Excel.Sheets
        Dim objSheet As Excel._Worksheet
        Dim range As Excel.Range


        If lvwX.Items.Count = 0 Then
            GoTo PasteListView_EXIT
        End If

        ' Create a new instance of Excel and start a new workbook.
        objBooks = objApp.Workbooks
        objBook = objBooks.Add
        objSheets = objBook.Worksheets
        objSheet = objSheets(1)

        If NoHeader Then
            intRows = lvwX.Items.Count
        Else
            intRows = lvwX.Items.Count + 1
        End If
        intColumns = lvwX.Columns.Count

        'Get the range where the starting cell has the address
        'm_sStartingCell and its dimensions are m_iNumRows x m_iNumCols.
        range = objSheet.Range("A1", Reflection.Missing.Value)
        range = range.Resize(intRows, intColumns)

        'Create an array.
        Dim saRet(intRows, intColumns) As String

        'Fill the array.
        Dim iRow As Integer
        Dim iCol As Integer

        For iRow = 0 To intRows - 1
            If NoHeader = False And iRow = 0 Then
                ' header row
                For iCol = 0 To intColumns - 1

                    'Put the row and column address in the cell.
                    saRet(iRow, iCol) = lvwX.Columns(iCol).Text
                Next iCol
            Else
                For iCol = 0 To intColumns - 1
                    If NoHeader = False Then
                        ' take into account that our row count will be one greater than it should be
                        saRet(iRow, iCol) = Replace(lvwX.Items(iRow - 1).SubItems(iCol).Text, vbCrLf, vbLf)
                    Else
                        saRet(iRow, iCol) = Replace(lvwX.Items(iRow).SubItems(iCol).Text, vbCrLf, vbLf)
                    End If
                    'Put the row and column address in the cell.
                Next iCol
            End If
        Next iRow

        'Set the range value to the array.
        range.Value = saRet


        'Return control of Excel to the user.
        objApp.Visible = True
        objApp.UserControl = True

        'Clean up a little.
        range = Nothing
        objSheet = Nothing
        objSheets = Nothing
        objBooks = Nothing
PasteListView_EXIT:
    End Sub

End Class

