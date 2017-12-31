Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class frmDateSelector

    Private mstrDateFormat As String = "d MMMM yyyy"


    Protected Overrides Sub OnPaintBackground(ByVal pevent As PaintEventArgs)
        Dim x, y, w, h As Integer
        With pevent.ClipRectangle
            x = 0
            y = 0
            w = Me.Width
            h = Me.Height
        End With
        ' Create a new LinearGradientBrush sized to our control
        'Dim linGrBrush As New LinearGradientBrush(
        '    New RectangleF(x, y, w, h), My.Settings.FormBackColour, Color.White, LinearGradientMode.Vertical)
        Dim linGrBrush As New LinearGradientBrush(
            New RectangleF(x, y, w, h), Color.AliceBlue, Color.White, LinearGradientMode.Vertical)
        ' Graphics object needed to call FillRectangle
        Dim gc As Graphics = pevent.Graphics
        ' Fill our control with the specified gradient
        gc.FillRectangle(linGrBrush, pevent.ClipRectangle)
    End Sub

    Private mdteActiveDate As Date
    Public Property ActiveDate() As Date
        Get
            Return mdteActiveDate
        End Get
        Set(ByVal value As Date)
            mdteActiveDate = value
        End Set
    End Property

    Private mlngStartYear As Long
    Public Property ActiveStartYear() As Long
        Get
            Return mlngStartYear
        End Get
        Set(ByVal value As Long)
            mlngStartYear = value
        End Set
    End Property

    Private mlngEndYear As Long
    Public Property ActiveEndYear() As Long
        Get
            Return mlngEndYear
        End Get
        Set(ByVal value As Long)
            mlngEndYear = value
        End Set
    End Property

    Public Sub Initialise()
        ' now all of the information should hvae been passed
        ' populate all the form controls
        Dim lngYear As Long

        cboYear.Items.Clear()
        If ActiveStartYear <= ActiveEndYear Then
            For lngYear = ActiveStartYear To ActiveEndYear
                cboYear.Items.Add(lngYear)
            Next
        Else
            For lngYear = ActiveStartYear To ActiveEndYear Step -1
                cboYear.Items.Add(lngYear)
            Next
        End If

        MonthView.ActiveDate = ActiveDate
        ListBoxSelect(cboMonth, Format(ActiveDate, "MMMM"))
        cboYear.Text = Format(ActiveDate, "yyyy")
    End Sub

    Public ReadOnly Property DateSelected() As Date
        Get
            Return MonthView.ActiveDate
        End Get
    End Property

    Private Sub cboYear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboYear.SelectedIndexChanged, cboYear.TextChanged
        If IsDate(Format(MonthView.ActiveDate, "d MMMM ") & cboYear.Text) Then
            MonthView.ActiveDate = CDate(Format(MonthView.ActiveDate, "d MMMM ") & cboYear.Text)
            MonthView.Refresh()
            lblDate.Text = Format(MonthView.ActiveDate, mstrDateFormat)
        ElseIf IsDate("30 " & Format(MonthView.ActiveDate, "MMMM ") & cboYear.Text) Then
            MonthView.ActiveDate = CDate("30 " & Format(MonthView.ActiveDate, "MMMM ") & cboYear.Text)
            MonthView.Refresh()
            lblDate.Text = Format(MonthView.ActiveDate, mstrDateFormat)
        ElseIf IsDate("29 " & Format(MonthView.ActiveDate, "MMMM ") & cboYear.Text) Then
            MonthView.ActiveDate = CDate("29 " & Format(MonthView.ActiveDate, "MMMM ") & cboYear.Text)
            MonthView.Refresh()
            lblDate.Text = Format(MonthView.ActiveDate, mstrDateFormat)
        ElseIf IsDate("28 " & Format(MonthView.ActiveDate, "MMMM ") & cboYear.Text) Then
            MonthView.ActiveDate = CDate("28 " & Format(MonthView.ActiveDate, "MMMM ") & cboYear.Text)
            MonthView.Refresh()
            lblDate.Text = Format(MonthView.ActiveDate, mstrDateFormat)
        End If
    End Sub

    Private Sub cboMonth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMonth.SelectedIndexChanged
        If IsDate(Format(MonthView.ActiveDate, "d ") & cboMonth.Text & Format(MonthView.ActiveDate, " yyyy")) Then
            MonthView.ActiveDate = CDate(Format(MonthView.ActiveDate, "d ") & cboMonth.Text & Format(MonthView.ActiveDate, " yyyy"))
            MonthView.Refresh()
            lblDate.Text = Format(MonthView.ActiveDate, mstrDateFormat)
        ElseIf IsDate("30 " & cboMonth.Text & Format(MonthView.ActiveDate, " yyyy")) Then
            MonthView.ActiveDate = CDate("30 " & cboMonth.Text & Format(MonthView.ActiveDate, " yyyy"))
            MonthView.Refresh()
            lblDate.Text = Format(MonthView.ActiveDate, mstrDateFormat)
        ElseIf IsDate("29 " & cboMonth.Text & Format(MonthView.ActiveDate, " yyyy")) Then
            MonthView.ActiveDate = CDate("29 " & cboMonth.Text & Format(MonthView.ActiveDate, " yyyy"))
            MonthView.Refresh()
            lblDate.Text = Format(MonthView.ActiveDate, mstrDateFormat)
        ElseIf IsDate("28 " & cboMonth.Text & Format(MonthView.ActiveDate, " yyyy")) Then
            MonthView.ActiveDate = CDate("28 " & cboMonth.Text & Format(MonthView.ActiveDate, " yyyy"))
            MonthView.Refresh()
            lblDate.Text = Format(MonthView.ActiveDate, mstrDateFormat)
        End If
    End Sub

    Private Sub MonthView_DateClick(ByVal sender As Object, ByVal e As Date) Handles MonthView.DateClick
        lblDate.Text = Format(MonthView.ActiveDate, mstrDateFormat)
    End Sub

    Sub HideDay()
        MonthView.Visible = False
        mstrDateFormat = "MMMM yyyy"
        Me.Width = 287
        Me.Height = 351
    End Sub

    Sub ShowDay()
        MonthView.Visible = True
        mstrDateFormat = "d MMMM yyyy"
        Me.Width = 521
        Me.Height = 311
    End Sub

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        Me.Tag = "OK"
        Me.Hide()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Tag = "Cancel"
        Me.Hide()
    End Sub

    Private Sub cmdToday_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdToday.Click
        MonthView.ActiveDate = Today
        ListBoxSelect(cboMonth, Format(MonthView.ActiveDate, "MMMM"))
        cboYear.Text = Format(MonthView.ActiveDate, "yyyy")
        MonthView.Refresh()
        lblDate.Text = Format(MonthView.ActiveDate, mstrDateFormat)
    End Sub

    Private Sub MonthView_Resize(sender As Object, e As EventArgs) Handles MonthView.Resize
        MonthView.Refresh()
    End Sub

    Private Sub frmDateSelector_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadFormSizeAndPosition(Me)
    End Sub

    Private Sub frmDateSelector_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SaveFormSizeAndPosition(Me)
    End Sub
End Class
