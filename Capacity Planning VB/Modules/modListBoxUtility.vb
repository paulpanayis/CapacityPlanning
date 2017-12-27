Module modListBoxUtility

    Public Sub FillListBox(ByRef ListBox As ListBox, ByRef aryX() As Long, ByVal TextField As String, ByVal SQLStatement As String, Optional ByVal KeyField As String = "", Optional ByVal blnDontClearDown As Boolean = False)
        Dim dataTable As DataTable
        Dim dataRow As DataRow

        Dim strSQL As String
        Dim intMaxRows As Integer
        Dim intItem As Integer


        strSQL = SQLStatement

        dataTable = gDB.OpenDataset(strSQL).Tables("Table")
        If blnDontClearDown = False Then
            ListBox.Items.Clear()
        End If

        If dataTable.IsInitialized Then
            intMaxRows = dataTable.Rows.Count

            ReDim aryX(0 To intMaxRows)

            For Each dataRow In dataTable.Rows
                intItem = ListBox.Items.Add(dataRow.Item(0).Value)
                If KeyField <> "" Then
                    aryX(intItem) = CLng(dataRow.Item(KeyField).Value)
                End If
            Next
        End If

        ListBox.Visible = True

    End Sub

    Public Sub FillListBox(ByRef ListBox As Combobox, ByRef aryX() As Long, ByVal TextField As String, ByVal SQLStatement As String, Optional ByVal KeyField As String = "", Optional ByVal blnDontClearDown As Boolean = False)
        Dim dataTable As DataTable
        Dim dataRow As DataRow

        Dim strSQL As String
        Dim intMaxRows As Integer
        Dim intItem As Integer


        strSQL = SQLStatement

        dataTable = gDB.OpenDataset(strSQL).Tables("Table")
        If blnDontClearDown = False Then
            ListBox.Items.Clear()
        End If

        If dataTable.IsInitialized Then
            intMaxRows = dataTable.Rows.Count

            ReDim aryX(0 To intMaxRows)

            For Each dataRow In dataTable.Rows
                intItem = ListBox.Items.Add(dataRow.Item(TextField).ToString)
                If KeyField <> "" Then
                    aryX(intItem) = CLng(dataRow.Item(KeyField))
                End If
            Next
        End If

        ListBox.Visible = True

    End Sub

    Public Sub ListBoxSelect(ByRef cboLevel As ListBox, ByVal strItemToFind As String)
        Dim intPointer As Integer

        For intPointer = 0 To cboLevel.Items.Count - 1
            If cboLevel.Items(intPointer).ToString = strItemToFind Then
                cboLevel.SelectedItem = cboLevel.Items(intPointer)
                Exit For
            End If
        Next
    End Sub

    Public Sub ListBoxSelect(ByRef cboLevel As ListBox, ByRef aryX() As Long, ByVal lngItemToFind As Long)
        Dim intPointer As Integer

        For intPointer = 0 To aryX.GetUpperBound(0)
            If aryX(intPointer) = lngItemToFind Then
                cboLevel.SelectedItem = cboLevel.Items(intPointer)
                Exit For
            End If
        Next
    End Sub

    Public Sub ListBoxSelect(ByRef cboLevel As ComboBox, ByVal strItemToFind As String)
        Dim intPointer As Integer

        For intPointer = 0 To cboLevel.Items.Count - 1
            If cboLevel.Items(intPointer).ToString = strItemToFind Then
                cboLevel.SelectedItem = cboLevel.Items(intPointer)
                Exit For
            End If
        Next
    End Sub

    Public Sub ListBoxSelect(ByRef cboLevel As ComboBox, ByRef aryX() As Long, ByVal lngItemToFind As Long)
        Dim intPointer As Integer

        For intPointer = 0 To aryX.GetUpperBound(0) - 1
            If aryX(intPointer) = lngItemToFind Then
                cboLevel.SelectedItem = cboLevel.Items(intPointer)
                Exit For
            End If
        Next
    End Sub

End Module
