Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class Reports
    Private maryReportID(0 To 0) As Long
    Private mlngPage As Long
    Private mlngRow As Long

    Private mlngID As Integer
    Private mstrReportName As String
    Private mstrReportDescription As String
    Private mstrReportStoredProcedure As String


    Protected Overrides Sub OnPaintBackground(ByVal pevent As PaintEventArgs)
        Dim x, y, w, h As Integer
        With pevent.ClipRectangle
            x = 0
            y = 0
            w = Me.Width
            h = Me.Height - pnlBottomBar.Height
        End With
        ' Create a new LinearGradientBrush sized to our control
        Dim linGrBrush As New LinearGradientBrush(
            New RectangleF(x, y, w, h), My.Settings.FormBackColour, Color.White, LinearGradientMode.Vertical)
        ' Graphics object needed to call FillRectangle
        Dim gc As Graphics = pevent.Graphics
        ' Fill our control with the specified gradient
        gc.FillRectangle(linGrBrush, pevent.ClipRectangle)
    End Sub

    Private Sub pnlBottomBar_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlBottomBar.Paint
        Dim x, y, w, h As Integer
        With e.ClipRectangle
            x = 0
            y = 0
            w = pnlBottomBar.Width
            h = pnlBottomBar.Height
        End With
        ' Create a new LinearGradientBrush sized to our control
        Dim linGrBrush As New LinearGradientBrush(
            New RectangleF(x, y, w, h), Color.White, My.Settings.FormBackColour, LinearGradientMode.Vertical)
        ' Graphics object needed to call FillRectangle
        Dim gc As Graphics = e.Graphics
        ' Fill our control with the specified gradient
        gc.FillRectangle(linGrBrush, e.ClipRectangle)
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub frmReport_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        MainMenu.Focus()
    End Sub

    Private Sub frmReport_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        SaveFormSizeAndPosition(Me)
        Me.Dispose()
    End Sub

    Private Sub frmReport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim strSQL As String

        strSQL = Get_Reports()

        FillListView(Me, lvwReports, strSQL, "ID", True, True, True, True)

        If lvwReports.Items.Count > 0 Then
            lvwReports.Items.Item(0).Selected = True
        End If

        LoadFormSizeAndPosition(Me)

    End Sub

    Private Sub PrintDoc_EndPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PrintDoc.EndPrint
        Me.Cursor = Cursors.Default
        Me.Enabled = True
    End Sub

    Private Sub PrintDoc_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDoc.PrintPage
        PrintListView(e, PrintDoc, lvwResults, mlngRow, mlngPage, lvwReports.Text, lblReportDescription.Text)
    End Sub

    Private Sub cmdDateFrom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDateFrom.Click
        Dim dteStart As Date

        If IsDate(cmdDateFrom.Text) Then
            dteStart = CDate(cmdDateFrom.Text)
        Else
            dteStart = Date.Now
        End If

        cmdDateFrom.Text = GetDate(dteStart, Now.Year - 100, Now.Year + 1, True).ToString("d MMM yyyy")
    End Sub

    Private Sub cmdDateTo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDateTo.Click
        Dim dteStart As Date

        If IsDate(cmdDateTo.Text) Then
            dteStart = CDate(cmdDateTo.Text)
        Else
            dteStart = Date.Now
        End If

        cmdDateTo.Text = GetDate(dteStart, Now.Year - 100, Now.Year + 1, True).ToString("d MMM yyyy")
    End Sub

    Private Sub ShowReport(ByVal intReportID As Integer)
        Dim strSQL As String
        Dim dataTable As DataTable


        lvwResults.Items.Clear()
        ctlExcel.Enabled = False
        ctlPrint.Enabled = False
        ctlReport.Enabled = True

        mstrReportName = ""
        mstrReportDescription = ""

        strSQL = Get_ReportByID(intReportID)
        dataTable = gDB.OpenDataset(strSQL).Tables("Table")

        If dataTable.Rows.Count > 0 Then
            Dim drCurrent As DataRow

            For Each drCurrent In dataTable.Rows
                mlngID = intReportID
                mstrReportName = drCurrent("Name").ToString
                mstrReportDescription = "" & drCurrent("Description").ToString
                mstrReportStoredProcedure = drCurrent("StoredProcedure").ToString

                ' now show the optional parameters/controls
                If "" & drCurrent("DateFromLabel").ToString = "" Then
                    pnlConditionDateFrom.Visible = False
                Else
                    lblConditionDateFrom.Text = drCurrent("DateFromLabel").ToString
                    cmdDateFrom.Text = GetSetting(My.Application.Info.AssemblyName, Me.Name, "Report" & intReportID & "DateFrom", Format(Now, "d MMM yyyy"))
                    pnlConditionDateFrom.Visible = True
                End If

                If "" & drCurrent("DateToLabel").ToString = "" Then
                    pnlConditionDateTo.Visible = False
                Else
                    lblConditionDateTo.Text = drCurrent("DateToLabel").ToString
                    cmdDateTo.Text = GetSetting(My.Application.Info.AssemblyName, Me.Name, "Report" & intReportID & "DateTo", Format(Now, "d MMM yyyy"))
                    pnlConditionDateTo.Visible = True
                End If

                lblReportDescription.Text = mstrReportDescription

                ctlReport.Enabled = True
            Next
        End If

    End Sub

    Private Sub RunExcelExport() Handles ctlExcel.Clicked
        Me.Enabled = False
        Me.Cursor = Cursors.WaitCursor
        ExportListViewToExcel(lvwResults)
        Me.Cursor = Cursors.Default
        Me.Enabled = True
    End Sub

    Private Sub ctlPrint_Clicked() Handles ctlPrint.Clicked
        Me.Enabled = False
        Me.Cursor = Cursors.WaitCursor
        mlngPage = 1
        mlngRow = 0
        If PrintDialog.ShowDialog(Me) = DialogResult.OK Then
            PrintDoc.Print()
        End If
        Me.Cursor = Cursors.Default
        Me.Enabled = True
    End Sub

    Private Sub lvwReports_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvwReports.ColumnClick
        SortListView(lvwReports, lvwReports.Columns(e.Column))
    End Sub

    Private Sub lvwReports_ColumnWidthChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnWidthChangedEventArgs) Handles lvwReports.ColumnWidthChanged
        SaveListViewSizeAndPosition(Me, lvwReports)
    End Sub

    Private Sub lvwReports_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwReports.DoubleClick
        RunReport()
    End Sub

    Private Sub lvwResults_DoubleClick(sender As Object, e As EventArgs) Handles lvwResults.DoubleClick
        RunExcelExport()
    End Sub

    Private Sub lvwReports_ItemSelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles lvwReports.ItemSelectionChanged
        If e.Item.Selected = True Then
            ShowReport(Val(e.Item.Tag))
        End If
    End Sub

    Private Sub RunReport() Handles ctlReport.Clicked
        Dim strSQL As String
        Dim strWhere As String
        Dim blnWhereStarted As Boolean

        ctlReport.Enabled = False
        ctlExcel.Enabled = False
        ctlPrint.Enabled = False

        Me.Cursor = System.Windows.Forms.Cursors.AppStarting

        ' build the SQL
        strSQL = "EXEC " & mstrReportStoredProcedure & " " & SQLDate(cmdDateFrom.Text) & ", " & SQLDate(cmdDateTo.Text)

        FillListView(Me, lvwResults, strSQL, "", True, True, True, False)


        UpdateReportRunColumns()

RES_QuerySyntax:
        Me.Cursor = System.Windows.Forms.Cursors.Default
        ctlExcel.Enabled = True
        ctlPrint.Enabled = True
        ctlReport.Enabled = True

        Exit Sub

ERR_QuerySyntax:
        MsgBox("There was a problem running the report.  The error reported is as follows:" & vbCrLf & Err.Description, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Report Error")
        System.Windows.Forms.Application.DoEvents()
        Resume RES_QuerySyntax
    End Sub

    Private Sub UpdateReportRunColumns()
        ' save last conditions used
        SaveSetting(My.Application.Info.AssemblyName, Me.Name, "Report" & mlngID & "DateFrom", cmdDateFrom.Text)
        SaveSetting(My.Application.Info.AssemblyName, Me.Name, "Report" & mlngID & "DateTo", cmdDateTo.Text)
    End Sub

    Private Sub lvwResults_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvwResults.ColumnClick
        SortListView(lvwResults, lvwResults.Columns(e.Column))
    End Sub

    Private Sub lvwResults_ColumnWidthChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnWidthChangedEventArgs) Handles lvwResults.ColumnWidthChanged
        SaveListViewSizeAndPosition(Me, lvwResults)
    End Sub

End Class