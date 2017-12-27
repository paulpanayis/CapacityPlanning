Imports System.IO
Imports System.Drawing.Printing


Module modListViewUtility

    Private CurrentX As Single
    Private CurrentY As Single

    Sub FillListView(ByVal frmX As Form, ByVal lvwListView As ListView, ByVal strSQL As String, ByVal pTagColumn As String, ByVal bClearFirst As Boolean, ByVal bAutoSize As Boolean, ByVal bAutoAlign As Boolean, ByVal bHideKeyField As Boolean, ByVal ParamArray sColumnFormat() As Object)
        Dim iX As Integer
        Dim itmX As Object
        Dim fldX() As DataColumn
        Dim fldXValue As Object
        Dim fldXName As String
        Dim listitemsX As ListView.ListViewItemCollection
        Dim iFields As Integer
        Dim iColumnSizersDone As Integer
        Dim iColumnFormats As Integer
        Dim sTagColumn As String
        Dim intColumnCount As Long
        Dim intColumnPointer As Integer
        Dim lngFieldModifier As Long
        Dim dataTable As DataTable
        Dim dataRow As DataRow


        If lvwListView.Tag = "Populated" Then
            SaveListViewSizeAndPosition(frmX, lvwListView)
        End If

        lvwListView.SuspendLayout()
        lvwListView.Sorting = SortOrder.None
        If bClearFirst Then
            lvwListView.Items.Clear()
        End If

        sTagColumn = UCase(pTagColumn)
        iColumnFormats = UBound(sColumnFormat)

        dataTable = gDB.OpenDataset(strSQL).Tables("Table")

        intColumnCount = dataTable.Columns.Count

        If bHideKeyField And pTagColumn <> "" Then
            intColumnCount = intColumnCount - 1
        ElseIf bHideKeyField And pTagColumn = "" Then
            bHideKeyField = False
        End If

        ' add or remove columns in the listview as necessary
        If intColumnCount > lvwListView.Columns.Count Then
            For iX = lvwListView.Columns.Count + 1 To intColumnCount
                If bAutoSize Then
                    lvwListView.Columns.Add("", CInt(GetSetting(My.Application.Info.AssemblyName, frmX.Name & "." & lvwListView.Name, "Column " & lvwListView.Columns.Count, 30)))
                Else
                    lvwListView.Columns.Add("")
                End If
            Next
        End If
        If intColumnCount < lvwListView.Columns.Count Then
            For iX = lvwListView.Columns.Count To intColumnCount + 1 Step -1
                lvwListView.Columns.Remove(lvwListView.Columns(iX - 1))
            Next
        End If
        ' replace the headers of the listview with the field names
        intColumnPointer = 0
        For iX = 1 To dataTable.Columns.Count
            If UCase(dataTable.Columns(iX - 1).ColumnName) <> sTagColumn Or bHideKeyField = False Then
                ' set the column alignment if required 
                ' (note that the first column will always be left aligned)
                If lvwListView.HeaderStyle <> ColumnHeaderStyle.None Then
                    If Trim(lvwListView.Columns(intColumnPointer).Text) = "" Or bClearFirst Then
                        lvwListView.Columns(intColumnPointer).Text = dataTable.Columns(iX - 1).ColumnName
                    End If
                End If


                lvwListView.Columns(intColumnPointer).TextAlign = HorizontalAlignment.Left

                intColumnPointer = intColumnPointer + 1
            End If
        Next

        iColumnSizersDone = 0

        ' now add the rows to the listview
        listitemsX = lvwListView.Items
        For Each dataRow In dataTable.Rows

            itmX = listitemsX.Add("")
            With itmX
                If UCase(dataTable.Columns(0).ColumnName) <> sTagColumn Or bHideKeyField = False Then
                    ' first item is NOT the Key column, or we are not trying to hide the key column
                    If iColumnFormats >= 0 Then
                        If sColumnFormat(0) <> "" Then
                            .Text = Format(dataRow.Item(0).ToString & "", sColumnFormat(0))
                        Else
                            .Text = dataRow.Item(0).ToString & ""
                        End If
                    Else
                        .Text = dataRow.Item(0).ToString & ""
                    End If

                    If UCase(dataTable.Columns(0).ColumnName) = sTagColumn Then
                        On Error Resume Next
                        .Tag = dataRow.Item(0).ToString
                        On Error GoTo 0
                    End If
                ElseIf UCase(dataTable.Columns(0).ColumnName) = sTagColumn And bHideKeyField = True Then
                    ' column 0 IS the key column and we wish to hide it
                    ' so make the list item text be the second field (field element 1)
                    If iColumnFormats >= 0 Then
                        If sColumnFormat(1) <> "" Then
                            .Text = Format(dataRow.Item(1).ToString & "", sColumnFormat(1))
                        Else
                            .Text = dataRow.Item(1).ToString & ""
                        End If
                    Else
                        .Text = dataRow.Item(1).ToString & ""
                    End If

                    On Error Resume Next
                    .tag = dataRow.Item(0).ToString
                    On Error GoTo 0
                End If

                lngFieldModifier = 0
                For iX = 1 To dataTable.Columns.Count - 1
                    If UCase(dataTable.Columns(0).ColumnName) = sTagColumn And bHideKeyField = True And iX = 1 Then
                        ' skip if we have already used this column
                        iX = 2
                        lngFieldModifier = -1
                        If iX > (dataTable.Columns.Count - 1) Then
                            Exit For
                        End If
                    End If

                    fldXValue = dataRow.Item(iX).ToString

                    If UCase(dataTable.Columns(iX).ColumnName) <> sTagColumn Or bHideKeyField = False Then

                        If IsDBNull(fldXValue) Then
                            If iColumnFormats >= iX Then
                                If sColumnFormat(iX) = "" Then
                                    .SubItems.Add("-")
                                Else
                                    .SubItems.Add("")
                                End If
                            Else
                                .SubItems.Add("-")
                            End If
                        ElseIf iColumnFormats >= iX Then
                            If sColumnFormat(iX) = "" Then
                                .SubItems.Add(fldXValue)
                            Else
                                .SubItems.Add(Format(fldXValue, sColumnFormat(iX)))
                            End If
                        Else
                            .SubItems.Add(fldXValue)
                        End If

                    End If

                    If UCase(dataTable.Columns(iX).ColumnName) = sTagColumn Then
                        On Error Resume Next
                        .Tag = fldXValue
                        On Error GoTo 0
                    End If
                Next
            End With

        Next

        ' auto size the columns to the data unless size already set
        For iX = 0 To lvwListView.Columns.Count - 1
            If bAutoSize = True Then
                If CInt(GetSetting(My.Application.Info.AssemblyName, frmX.Name & "." & lvwListView.Name, "Column " & iX, 0)) = 0 Then
                    If lvwListView.HeaderStyle = ColumnHeaderStyle.None Then
                        lvwListView.Columns(iX).AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
                    Else
                        lvwListView.Columns(iX).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
                    End If
                End If
            End If
        Next

        lvwListView.Tag = "Populated"

        lvwListView.ResumeLayout(True)

        'lvwListView.Visible = True
    End Sub

    Public Sub SetColumnHeaderWidths(ByVal frmX As Form, ByVal lvwX As ListView)
        Dim iX As Integer
        Dim dblCount As Double

        For iX = 0 To lvwX.Columns.Count - 1
            lvwX.Columns(iX).Width = GetSetting(My.Application.Info.AssemblyName, frmX.Name & "." & lvwX.Name, "Column " & iX, lvwX.Columns(iX).Width)
            dblCount = dblCount + lvwX.Columns(iX).Width
        Next

        If dblCount = 0 Then
            lvwX.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        End If
    End Sub

    Public Sub SaveListViewSizeAndPosition(ByVal frmForm As Form, ByVal lvwListView As ListView)

        '
        ' save the size and position of the form in the registry
        ' also all listview column widths
        '

        Dim intColumn As Integer
        Dim strKey As String

        On Error Resume Next

        strKey = My.Application.Info.AssemblyName

        '
        ' this procedure will save the column widths for each listview on a Form
        '

        For intColumn = 0 To lvwListView.Columns.Count - 1
            SaveSetting(strKey, _
                        frmForm.Name & "." & lvwListView.Name, _
                        "Column " & intColumn, _
                        lvwListView.Columns(intColumn).Width)

        Next
        SaveSetting(strKey, _
                    frmForm.Name & "." & lvwListView.Name, _
                    "View", _
                    lvwListView.View)

    End Sub

    Sub ExportListViewToCSV(ByRef lvwX As ListView, Optional ByVal blnNoHeader As Boolean = False)
        Dim lngRow As Integer
        Dim intColumn As Integer
        Dim intNotepadInstance As Integer
        Dim strLine As String
        Dim strFilename As String


        ' open the file for writing
        strFilename = Environ("Temp")
        If Right(strFilename, 1) <> "\" Then
            strFilename = strFilename & "\DiplomatReportTemp.txt"
        Else
            strFilename = strFilename & "DiplomatReportTemp.txt"
        End If

        On Error GoTo 0

        If lvwX.Items.Count > 0 Then
            Using sw As StreamWriter = New StreamWriter(strFilename, False)


                ' write the header information (if required)
                If blnNoHeader = False Then
                    strLine = ""
                    For intColumn = 0 To lvwX.Columns.Count - 1
                        If intColumn <> 0 Then
                            strLine = strLine & ","
                        End If
                        strLine = strLine & Replace(lvwX.Columns(intColumn).Text, ",", " ")
                    Next
                    sw.WriteLine(strLine)
                End If

                ' now write the data records
                For lngRow = 0 To lvwX.Items.Count - 1
                    strLine = ""
                    For intColumn = 1 To lvwX.Columns.Count
                        If intColumn <> 1 Then
                            strLine = strLine & ","
                        End If
                        strLine = strLine & Replace(lvwX.Items(lngRow).SubItems(intColumn - 1).Text, ",", " ")
                    Next
                    sw.WriteLine(strLine)
                Next

                sw.Close()

            End Using

            ' now launch notepad, opening the file
            intNotepadInstance = Shell("notepad.exe """ & strFilename & """", AppWinStyle.NormalFocus)

        End If
    End Sub


    Public Sub PrintListView(ByVal e As System.Drawing.Printing.PrintPageEventArgs, ByRef PrintDoc As PrintDocument, ByRef lvwToPrint As ListView, ByRef lngStartRow As Long, ByRef lngStartPage As Long, Optional ByVal strTitle As String = "", Optional ByVal strSubTitle As String = "")
        '
        ' this method will send the contents of a list view to the printer object
        '

        ''=================================================
        ''EXAMPLE OF USAGE
        ''
        ''=================================================
        ''Module Level Private Variables
        ''=================================================
        'Private mlngPage As Long
        'Private mlngRow As Long
        ''=================================================
        ''Calling Sub (picPrint_Click) and 
        ''corresponding PrintDialog (component named PrintDialog) event
        ''corresponding PrintDocument (component named PrintDoc) event
        ''=================================================
        'Private Sub picPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPrint.Click, lblPrint1.Click, lblPrint2.Click
        '    mlngPage = 1
        '    mlngRow = 0
        '    If PrintDialog.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
        '        PrintDoc.Print()
        '    End If   
        'End Sub
        ''
        'Private Sub PrintDoc_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDoc.PrintPage
        '    PrintListView(e, PrintDoc, lvwResults, mlngRow, mlngPage, "Report Main Title", "Sub Title/Description")
        'End Sub
        ''=================================================

        Dim dblPrinterLeft As Double
        Dim dblPrinterRight As Double
        Dim dblPrinterWidth As Double
        Dim dblPrinterTop As Double
        Dim dblPrinterBottom As Double
        Dim dblPrinterHeight As Double

        Dim fntX As Font
        Dim TextSize As New System.Drawing.SizeF
        Dim TextSizePageBreak As New System.Drawing.SizeF

        Dim intColumn As Integer
        Dim intPointer As Integer
        Dim intColumnWidth As Integer
        Dim lngTotalWidth As Long
        Dim dblZoomFactor As Double
        Dim blnShadedRow As Boolean

        Dim g As Graphics = e.Graphics

        dblPrinterLeft = 0
        dblPrinterRight = PrintDoc.DefaultPageSettings.PrintableArea.Width - 5
        dblPrinterWidth = dblPrinterRight - dblPrinterLeft
        dblPrinterTop = 0
        dblPrinterBottom = PrintDoc.DefaultPageSettings.PrintableArea.Height - 5
        dblPrinterHeight = dblPrinterBottom - dblPrinterTop

        CurrentX = dblPrinterLeft
        CurrentY = dblPrinterTop
        blnShadedRow = True


        fntX = New Font("Arial", 10, FontStyle.Regular)
        TextSize = g.MeasureString("Xg", fntX)
        TextSizePageBreak = g.MeasureString("Xg" & vbCrLf & "Xg" & vbCrLf & "Xg" & vbCrLf & "Xg", fntX)

        ' get the width of the list view
        lngTotalWidth = 0
        For intColumn = 0 To lvwToPrint.Columns.Count - 1
            lngTotalWidth = lngTotalWidth + lvwToPrint.Columns(intColumn).Width
        Next

        ' now determine the width of the paper
        ' and how we can distribute the listview text across it
        dblZoomFactor = dblPrinterWidth / lngTotalWidth

        If lngStartPage > 1 Then
            PrintListviewTitle(g, PrintDoc, strTitle, "...cont")
            PrintListViewHeaders(g, PrintDoc, lvwToPrint, dblZoomFactor)
        Else
            PrintListviewTitle(g, PrintDoc, strTitle, strSubTitle)
            PrintListViewHeaders(g, PrintDoc, lvwToPrint, dblZoomFactor)
        End If

        ' print the contents
        For intPointer = lngStartRow To lvwToPrint.Items.Count - 1
            lngStartRow = intPointer + 1

            fntX = New Font("Arial", 8, FontStyle.Regular)
            TextSize = g.MeasureString("Xg", fntX)

            With lvwToPrint.Items(intPointer)
                For intColumn = 0 To lvwToPrint.Columns.Count - 1
                    intColumnWidth = lvwToPrint.Columns(intColumn).Width * dblZoomFactor
                    If blnShadedRow Then
                        g.FillRectangle(Brushes.Bisque, CurrentX, CurrentY, intColumnWidth, TextSize.Height)
                    Else
                        g.FillRectangle(Brushes.White, CurrentX, CurrentY, intColumnWidth, TextSize.Height)
                    End If

                    '//draw the cell text
                    g.DrawString(.SubItems(intColumn).Text, fntX, Brushes.Black, New RectangleF(CurrentX, CurrentY, intColumnWidth, TextSize.Height))

                    '//next cell
                    CurrentX = CurrentX + (lvwToPrint.Columns(intColumn).Width * dblZoomFactor)

                Next

            End With

            ' move to next line
            CurrentY = CurrentY + TextSize.Height * 1.1
            CurrentX = dblPrinterLeft

            ' check to see if we need to put in a page break
            If lvwToPrint.Items.Count - intPointer > 4 Then
                If CurrentY + TextSizePageBreak.Height > dblPrinterHeight Then
                    ' not enough room for three more lines
                    fntX = New Font("Arial", 10, FontStyle.Regular)
                    TextSize = g.MeasureString("Page " & lngStartPage & "XXXX" & vbCrLf & "Page " & lngStartPage & "XXXX", fntX)
                    CurrentX = dblPrinterRight - TextSize.Width
                    CurrentY = dblPrinterBottom - TextSize.Height
                    g.DrawString("Page " & lngStartPage, fntX, Brushes.Black, New RectangleF(CurrentX, CurrentY, TextSize.Width, TextSize.Height))

                    fntX = New Font("Arial", 10, FontStyle.Italic)
                    TextSize = g.MeasureString("cont...XXXX", fntX)
                    CurrentX = dblPrinterRight - TextSize.Width
                    CurrentY = CurrentY + TextSize.Height
                    g.DrawString("cont...", fntX, Brushes.Black, New RectangleF(CurrentX, CurrentY, TextSize.Width, TextSize.Height))

                    lngStartPage = lngStartPage + 1
                    CurrentY = dblPrinterTop
                    CurrentX = dblPrinterLeft
                    e.HasMorePages = True
                    Exit Sub

                End If
            End If

            blnShadedRow = True - blnShadedRow
        Next

        fntX = New Font("Arial", 10, FontStyle.Regular)
        TextSize = g.MeasureString("Page " & lngStartPage & "XXXX", fntX)
        CurrentX = dblPrinterRight - TextSize.Width
        CurrentY = dblPrinterBottom - TextSize.Height
        g.DrawString("Page " & lngStartPage, fntX, Brushes.Black, New RectangleF(CurrentX, CurrentY, TextSize.Width, TextSize.Height))

    End Sub

    Private Sub PrintListviewTitle(ByVal g As Graphics, ByRef PrintDoc As PrintDocument, ByVal strTitle As String, ByVal strSubTitle As String)
        '
        ' supporting procedure to the PrintListView Sub
        '
        Dim dblPrinterLeft As Double
        Dim dblPrinterRight As Double
        Dim dblPrinterWidth As Double
        Dim fntX As Font
        Dim TextSize As New System.Drawing.SizeF

        dblPrinterLeft = 0
        dblPrinterRight = PrintDoc.DefaultPageSettings.PrintableArea.Width - 5
        dblPrinterWidth = dblPrinterRight - dblPrinterLeft
        CurrentX = 0

        If strTitle <> "" Then
            fntX = New Font("Arial", 18, FontStyle.Bold)
            TextSize = g.MeasureString("Xg", fntX)
            g.DrawString(strTitle, fntX, Brushes.Black, New RectangleF(CurrentX, CurrentY, dblPrinterWidth, TextSize.Height))
            CurrentY = CurrentY + TextSize.Height

            fntX = New Font("Arial", 10, FontStyle.Italic)
            TextSize = g.MeasureString("Xg", fntX)
            g.DrawString(strSubTitle, fntX, Brushes.Black, New RectangleF(CurrentX, CurrentY, dblPrinterWidth, TextSize.Height * 3))
            CurrentY = CurrentY + TextSize.Height * 2.1
        End If
        CurrentX = dblPrinterLeft

    End Sub

    Private Sub PrintListViewHeaders(ByVal g As Graphics, ByRef PrintDoc As PrintDocument, ByRef lvwToPrint As ListView, ByVal dblZoomFactor As Double)
        '
        ' supporting procedure to the PrintListView Sub
        '
        Dim dblRunningTotal As Double
        Dim intColumn As Integer
        Dim dblPrinterLeft As Double
        Dim dblPrinterRight As Double
        Dim dblPrinterWidth As Double
        Dim intColumnWidth As Integer
        Dim fntX As Font


        dblPrinterLeft = 0
        dblPrinterRight = PrintDoc.DefaultPageSettings.PrintableArea.Width - 5
        dblPrinterWidth = dblPrinterRight - dblPrinterLeft

        fntX = New Font("Arial", 8, FontStyle.Bold)

        CurrentX = dblPrinterLeft

        ' print the headers
        dblRunningTotal = 0

        Dim TextSize As New System.Drawing.SizeF
        TextSize = g.MeasureString("Xg", fntX)

        For intColumn = 0 To lvwToPrint.Columns.Count - 1
            '//advance X according to order
            '//draw the cell bounds (lines) and back color
            intColumnWidth = lvwToPrint.Columns(intColumn).Width * dblZoomFactor
            g.FillRectangle(Brushes.Wheat, CurrentX, CurrentY, intColumnWidth, TextSize.Height)
            g.DrawRectangle(Pens.Tan, CurrentX, CurrentY, intColumnWidth, TextSize.Height)

            '//draw the cell text
            g.DrawString(lvwToPrint.Columns(intColumn).Text, fntX, Brushes.Black, New RectangleF(CurrentX, CurrentY, intColumnWidth, TextSize.Height))

            '//next cell
            CurrentX = CurrentX + intColumnWidth
        Next

        CurrentX = dblPrinterLeft
        CurrentY = CurrentY + TextSize.Height * 1.25

    End Sub

    Public Sub ShowListviewChanges(ByVal lvwTarget As ListView)
        ' this procedure will remove any data in columns that are shown on the previous row
        Dim intRow As Integer
        Dim intColumn As Integer


        If lvwTarget.Items.Count > 1 Then
            ' ensure that there is more than 1 row (otherwise it would be pointless)
            For intRow = lvwTarget.Items.Count - 1 To 1 Step -1
                ' step backwards through the listview
                ' only change the sub-items, always leave the date (i.e. dont change the TEXT property)
                For intColumn = 1 To lvwTarget.Columns.Count - 1
                    If lvwTarget.Items(intRow).SubItems(intColumn).Text = lvwTarget.Items(intRow - 1).SubItems(intColumn).Text Then
                        lvwTarget.Items(intRow).SubItems(intColumn).Text = "-"
                    End If
                Next
            Next
        End If
    End Sub

    Public Sub ResetTreeviewNodeColor(ByVal node As TreeNode, ByVal nodExclude As TreeNode)
        If Not (node.BackColor = Color.Transparent Or node Is nodExclude) Then
            node.BackColor = Color.Transparent
        End If
        If Not node.FirstNode Is Nothing AndAlso node.IsExpanded Then
            For Each child As TreeNode In node.Nodes
                If Not (child.BackColor = Color.Transparent Or child Is nodExclude) Then
                    child.BackColor = Color.Transparent
                End If
                If Not child.FirstNode Is Nothing AndAlso child.IsExpanded Then
                    ResetTreeviewNodeColor(child, nodExclude)
                End If
            Next
        End If
    End Sub

    Public Sub ListViewSelectByTag(ByRef lvwList As ListView, ByVal strItemToFind As String)
        Dim intPointer As Integer

        For intPointer = 0 To lvwList.Items.Count - 1
            If lvwList.Items(intPointer).Tag = strItemToFind Then
                lvwList.Items(intPointer).Selected = True
                Exit For
            End If
        Next
    End Sub

    Public Sub ListViewSelectByText(ByRef lvwList As ListView, ByVal strItemToFind As String)
        Dim intPointer As Integer

        For intPointer = 0 To lvwList.Items.Count - 1
            If lvwList.Items(intPointer).Text = strItemToFind Then
                lvwList.Items(intPointer).Selected = True
                Exit For
            ElseIf lvwList.Items(intPointer).Text = "" And lvwList.Items(intPointer).SubItems.Count > 0 Then
                ' if there is no text in text column use the first 
                ' subitem text if it is available
                If lvwList.Items(intPointer).SubItems(1).Text = strItemToFind Then
                    lvwList.Items(intPointer).Selected = True
                    Exit For
                End If
            End If
        Next
    End Sub

    Public Sub SortListView(ByVal lvwX As ListView, ByVal colX As ColumnHeader)
        Dim aryItems() As ListViewItem
        Dim arySorted() As ListViewItem
        Dim itmX As ListViewItem
        Dim lngCounter As Long
        Dim blnAscending As Boolean


        ReDim aryItems(0)
        ReDim arySorted(0)

        If Mid(lvwX.Tag, 1, 1) = "A" And Mid(lvwX.Tag, 2) = colX.Text Then
            blnAscending = False
            lvwX.Tag = "D" & Mid(lvwX.Tag, 2)
        Else
            blnAscending = True
            lvwX.Tag = "A" & Mid(lvwX.Tag, 2)
        End If

        lvwX.Tag = Mid(lvwX.Tag, 1, 1) & colX.Text

        ' get the 
        ReDim aryItems(0 To lvwX.Items.Count)
        lngCounter = 1
        For Each itmX In lvwX.Items
            aryItems(lngCounter) = itmX
            lngCounter = lngCounter + 1
        Next

        QuickSortListviewItems(aryItems, arySorted, colX.Index, blnAscending)

        ' sorted, so now re-insert them back into the listview
        lvwX.SuspendLayout()

        lvwX.Items.Clear()

        For lngCounter = 1 To arySorted.GetUpperBound(0)
            lvwX.Items.Add(arySorted(lngCounter))
        Next

        lvwX.ResumeLayout(True)

    End Sub

    Private Sub QuickSortListviewItems(ByRef aryItems() As ListViewItem, ByRef aryItemsSorted() As ListViewItem, ByVal lngColumn As Long, ByVal blnAscending As Boolean)
        Dim itmX As ListViewItem
        Dim aryHigher() As ListViewItem
        Dim aryLower() As ListViewItem
        Dim aryHigherSorted() As ListViewItem
        Dim aryLowerSorted() As ListViewItem
        Dim lngPointer As Long
        Dim lngCounter As Long
        Dim intIndex As Integer
        Dim strText1 As String
        Dim strText2 As String



        itmX = aryItems(1)
        ReDim aryHigher(0)
        ReDim aryLower(0)
        ReDim aryHigherSorted(0)
        ReDim aryLowerSorted(0)

        If aryItems.GetUpperBound(0) = 1 Then
            ' first exit condition.. there is only one item in this array
            ReDim aryItemsSorted(0 To 1)
            aryItemsSorted(1) = itmX
        ElseIf aryItems.GetUpperBound(0) = 2 Then
            ' second exit condition, two items.. simple comparison
            ReDim aryItemsSorted(0 To 2)

            If lngColumn = 0 Then
                strText1 = itmX.Text
            Else
                intIndex = lngColumn
                strText1 = itmX.SubItems(intIndex).Text
            End If

            If lngColumn = 0 Then
                strText2 = aryItems(2).Text
            Else
                intIndex = lngColumn
                strText2 = aryItems(2).SubItems(intIndex).Text
            End If

            If IsDate(strText1) And IsDate(strText2) Then
                If CDate(strText1) >= CDate(strText2) Then
                    If blnAscending Then
                        aryItemsSorted(1) = aryItems(2)
                        aryItemsSorted(2) = aryItems(1)
                    Else
                        aryItemsSorted(1) = aryItems(1)
                        aryItemsSorted(2) = aryItems(2)
                    End If
                Else ' > first item
                    If blnAscending Then
                        aryItemsSorted(1) = aryItems(1)
                        aryItemsSorted(2) = aryItems(2)
                    Else
                        aryItemsSorted(1) = aryItems(2)
                        aryItemsSorted(2) = aryItems(1)
                    End If
                End If
            ElseIf IsNumeric(strText1) And IsNumeric(strText2) Then
                If ValueOf(strText1) >= ValueOf(strText2) Then
                    If blnAscending Then
                        aryItemsSorted(1) = aryItems(2)
                        aryItemsSorted(2) = aryItems(1)
                    Else
                        aryItemsSorted(1) = aryItems(1)
                        aryItemsSorted(2) = aryItems(2)
                    End If
                Else ' > first item
                    If blnAscending Then
                        aryItemsSorted(1) = aryItems(1)
                        aryItemsSorted(2) = aryItems(2)
                    Else
                        aryItemsSorted(1) = aryItems(2)
                        aryItemsSorted(2) = aryItems(1)
                    End If
                End If

            Else ' are not dates
                If strText1 >= strText2 Then
                    If blnAscending Then
                        aryItemsSorted(1) = aryItems(2)
                        aryItemsSorted(2) = aryItems(1)
                    Else
                        aryItemsSorted(1) = aryItems(1)
                        aryItemsSorted(2) = aryItems(2)
                    End If
                Else ' > first item
                    If blnAscending Then
                        aryItemsSorted(1) = aryItems(1)
                        aryItemsSorted(2) = aryItems(2)
                    Else
                        aryItemsSorted(1) = aryItems(2)
                        aryItemsSorted(2) = aryItems(1)
                    End If
                End If

            End If

        Else
            ' more than two elements to sort
            ' firstly filter into the higher and lower arrays
            For lngPointer = 2 To aryItems.GetUpperBound(0)

                If lngColumn = 0 Then
                    strText1 = itmX.Text
                Else
                    intIndex = lngColumn
                    strText1 = itmX.SubItems(intIndex).Text
                End If

                If lngColumn = 0 Then
                    strText2 = aryItems(lngPointer).Text
                Else
                    intIndex = lngColumn
                    strText2 = aryItems(lngPointer).SubItems(intIndex).Text
                End If

                If IsDate(strText1) And IsDate(strText2) Then
                    If CDate(strText1) >= CDate(strText2) Then
                        ' add to lower array
                        ReDim Preserve aryLower(0 To aryLower.GetUpperBound(0) + 1)
                        aryLower(aryLower.GetUpperBound(0)) = aryItems(lngPointer)
                    Else ' > first item
                        ' add to higher array
                        ReDim Preserve aryHigher(0 To aryHigher.GetUpperBound(0) + 1)
                        aryHigher(aryHigher.GetUpperBound(0)) = aryItems(lngPointer)
                    End If
                ElseIf IsNumeric(strText1) And IsNumeric(strText2) Then
                    If ValueOf(strText1) >= ValueOf(strText2) Then
                        ' add to lower array
                        ReDim Preserve aryLower(0 To aryLower.GetUpperBound(0) + 1)
                        aryLower(aryLower.GetUpperBound(0)) = aryItems(lngPointer)

                    Else ' > first item
                        ' add to higher array
                        ReDim Preserve aryHigher(0 To aryHigher.GetUpperBound(0) + 1)
                        aryHigher(aryHigher.GetUpperBound(0)) = aryItems(lngPointer)
                    End If

                Else
                    If strText1 >= strText2 Then
                        ' add to lower array
                        ReDim Preserve aryLower(0 To aryLower.GetUpperBound(0) + 1)
                        aryLower(aryLower.GetUpperBound(0)) = aryItems(lngPointer)

                    Else ' > first item
                        ' add to higher array
                        ReDim Preserve aryHigher(0 To aryHigher.GetUpperBound(0) + 1)
                        aryHigher(aryHigher.GetUpperBound(0)) = aryItems(lngPointer)
                    End If

                End If

            Next

            ' now sort the higher and lower arrays
            If aryLower.GetUpperBound(0) > 0 Then
                QuickSortListviewItems(aryLower, aryLowerSorted, lngColumn, blnAscending)
            End If
            If aryHigher.GetUpperBound(0) > 0 Then
                QuickSortListviewItems(aryHigher, aryHigherSorted, lngColumn, blnAscending)
            End If

            ' now return the sorted array
            ReDim aryItemsSorted(0 To aryLower.GetUpperBound(0) + aryHigher.GetUpperBound(0) + 1)
            lngCounter = 1
            If blnAscending Then
                ' lower
                For lngPointer = 1 To aryLowerSorted.GetUpperBound(0)
                    aryItemsSorted(lngCounter) = aryLowerSorted(lngPointer)
                    lngCounter = lngCounter + 1
                Next
                ' middle
                aryItemsSorted(lngCounter) = itmX
                lngCounter = lngCounter + 1
                ' upper
                For lngPointer = 1 To aryHigherSorted.GetUpperBound(0)
                    aryItemsSorted(lngCounter) = aryHigherSorted(lngPointer)
                    lngCounter = lngCounter + 1
                Next
            Else
                ' upper
                For lngPointer = 1 To aryHigherSorted.GetUpperBound(0)
                    aryItemsSorted(lngCounter) = aryHigherSorted(lngPointer)
                    lngCounter = lngCounter + 1
                Next
                ' middle
                aryItemsSorted(lngCounter) = itmX
                lngCounter = lngCounter + 1
                ' lower
                For lngPointer = 1 To aryLowerSorted.GetUpperBound(0)
                    aryItemsSorted(lngCounter) = aryLowerSorted(lngPointer)
                    lngCounter = lngCounter + 1
                Next
            End If

        End If

    End Sub

End Module
