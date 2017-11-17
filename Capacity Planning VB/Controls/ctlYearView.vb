Imports System.Globalization

Public Class ctlYearView
    Public Event DateClick(ByVal sender As Object, ByVal e As Date)

    Private maryDiaryItems(,) As Double
    Private maryDateCoordinates(,) As Object
    Private maryDateUserAreaCoordinates(,) As Object

    Protected Overrides Sub OnPaintBackground(ByVal pevent As PaintEventArgs)
        ' Graphics object needed to call FillRectangle
        Dim g As Graphics = pevent.Graphics

        ' Fill our control with the specified gradient
        DrawYear(g)
    End Sub

    Private Sub DrawYear(ByVal g As Graphics)
        '
        ' this procedure will perform all the calculations for drawing the year 
        ' once all the calultations have been done it will paint the year view
        ' it will then overlay this with any additional items provided in the DiaryItem array
        '
        Dim lngScaleHeight As Long
        Dim lngScaleWidth As Long
        Dim lngLeft As Long
        Dim lngTop As Long
        Dim dblXDivision As Double
        Dim dblYDivision As Double
        Dim intX As Integer
        Dim intY As Integer
        Dim intLeft As Integer
        Dim intTop As Integer
        Dim intWidth As Integer
        Dim intHeight As Integer
        Dim lngRow As Long
        Dim lngColumn As Long
        Dim clrColour As Color
        Dim dteDrawingDate As Date
        Dim blnValidDate As Boolean

        Dim dteFirstOfMonth As Date
        Dim intDayOfMonthOffset As Integer
        Dim intDaysInMonth As Integer

        Dim myForeBrush As Brush
        Dim myFont As Font
        Dim mySmallFont As Font
        Dim sngFontSize As Single
        Dim sngSmallSize As Single
        Dim textSize As SizeF
        Dim myString As String

        'ReDim maryDateCoordinates(0 To 5, 0 To 42)
        'ReDim maryDateUserAreaCoordinates(0 To 5, 0 To 42)

        g.Clear(Me.BackColor)
        myForeBrush = New SolidBrush(Me.ForeColor)
        sngFontSize = 12
        myFont = New Font(Me.Font.FontFamily, sngFontSize, FontStyle.Regular)
        sngSmallSize = sngFontSize * 0.75
        mySmallFont = New Font(Me.Font.FontFamily, sngSmallSize, FontStyle.Regular)
        textSize = g.MeasureString("WWW", myFont)

        lngLeft = textSize.Width + 4
        lngScaleWidth = CLng(Me.ClientSize.Width) - lngLeft

        lngTop = textSize.Height + 4
        lngScaleHeight = CLng(Me.ClientSize.Height) - lngTop

        dblXDivision = (lngScaleWidth - 3) / 12
        dblYDivision = (lngScaleHeight - 2) / 37

        ' resize the font so it fits - minimum font size of 4 points
        Do While sngFontSize > 4 And (textSize.Width > dblXDivision Or textSize.Height > dblYDivision)
            sngFontSize = sngFontSize - 0.25
            myFont = New Font(Me.Font.FontFamily, sngFontSize, FontStyle.Regular)
            sngSmallSize = sngFontSize * 0.75
            mySmallFont = New Font(Me.Font.FontFamily, sngSmallSize, FontStyle.Regular)

            textSize = g.MeasureString("WWW", myFont)

            lngLeft = textSize.Width + 4
            lngScaleWidth = CLng(Me.ClientSize.Width) - lngLeft

            lngTop = textSize.Height + 4
            lngScaleHeight = CLng(Me.ClientSize.Height) - lngTop

            dblXDivision = (lngScaleWidth - 3) / 12
            dblYDivision = (lngScaleHeight - 2) / 37
        Loop

        ' draw the months
        For lngColumn = 0 To 11
            myString = New DateTime(2017, lngColumn + 1, 1).ToString("MMM", CultureInfo.InvariantCulture)

            myFont = New Font(Me.Font.FontFamily, sngFontSize, FontStyle.Regular)
            textSize = g.MeasureString(myString, myFont)

            intY = 1
            intX = lngLeft + (lngColumn * dblXDivision) + ((dblXDivision - textSize.Width) / 2)

            g.DrawString(myString, myFont, myForeBrush, intX, intY)
        Next lngColumn

        ' draw days of week
        For lngRow = 1 To 37
            myString = ""
            Select Case lngRow Mod 7
                Case 0
                    myString = "SAT"
                Case 1
                    myString = "SUN"
                Case 2
                    myString = "MON"
                Case 3
                    myString = "TUE"
                Case 4
                    myString = "WED"
                Case 5
                    myString = "THU"
                Case 6
                    myString = "FRI"
            End Select

            myFont = New Font(Me.Font.FontFamily, sngFontSize, FontStyle.Regular)
            textSize = g.MeasureString(myString, myFont)

            intX = ((lngLeft - textSize.Width) / 2)
            intY = lngTop + ((lngRow - 1) * dblYDivision) + ((dblYDivision - textSize.Height) / 2)

            g.DrawString(myString, myFont, myForeBrush, intX, intY)

        Next lngRow

        ' draw the grid
        dteDrawingDate = New DateTime(ActiveYear, 1, 1)

        For lngColumn = 1 To 12
            For lngRow = 1 To 37

                dteFirstOfMonth = New DateTime(ActiveYear, lngColumn, 1)
                intDayOfMonthOffset = Weekday(dteFirstOfMonth, DayOfWeek.Monday)
                intDaysInMonth = 0
                blnValidDate = False

                If (lngColumn = 12) Then
                    ' last month in year
                    intDaysInMonth = (New DateTime(ActiveYear + 1, 1, 1) - New DateTime(ActiveYear, lngColumn, 1)).TotalDays
                Else
                    intDaysInMonth = (New DateTime(ActiveYear, lngColumn + 1, 1) - New DateTime(ActiveYear, lngColumn, 1)).TotalDays
                End If

                If (lngRow >= intDayOfMonthOffset) And (lngRow < (intDayOfMonthOffset + intDaysInMonth)) Then
                    dteDrawingDate = New DateTime(ActiveYear, lngColumn, lngRow - intDayOfMonthOffset + 1)
                    blnValidDate = True
                End If

                ' draw in the appropriate colour
                If blnValidDate = True Then
                    ' is a valid date square
                    If (lngRow Mod 7 = 1 Or lngRow Mod 7 = 0) Then
                        ' weekend
                        clrColour = ThisYearWeekendColour
                    Else
                        ' weekday
                        clrColour = ThisYearWeekdayColour
                    End If
                Else
                    ' is not a valid date square
                    If (lngRow Mod 7 = 1 Or lngRow Mod 7 = 0) Then
                        ' weekend
                        clrColour = OtherYearWeekdayColour
                    Else
                        ' weekday
                        clrColour = OtherYearWeekendColour
                    End If
                End If

                intLeft = lngLeft + ((lngColumn - 1) * dblXDivision)
                intTop = lngTop + ((lngRow - 1) * dblYDivision)
                intWidth = dblXDivision
                intHeight = dblYDivision

                If dteDrawingDate = Now.Date Then
                    g.FillRectangle(New SolidBrush(TodayColour), intLeft, intTop, intWidth, intHeight)

                    If blnValidDate Then
                        g.DrawString(dteDrawingDate.Day.ToString, mySmallFont, New SolidBrush(TodayTextColour), intLeft, intTop)
                    End If
                Else
                    g.FillRectangle(New SolidBrush(clrColour), intLeft, intTop, intWidth, intHeight)
                    If blnValidDate Then
                        g.DrawString(dteDrawingDate.Day.ToString, mySmallFont, myForeBrush, intLeft, intTop)
                    End If
                End If

                ' now cut out the outline so each square is separate
                g.DrawRectangle(New Pen(Me.BackColor), intLeft, intTop, intWidth, intHeight)

            Next lngRow
        Next lngColumn
    End Sub


    Private ActiveYearValue As Integer
    Public Property ActiveYear() As Integer
        Get
            Return ActiveYearValue
        End Get
        Set(ByVal value As Integer)
            ActiveYearValue = value
        End Set
    End Property

    Private ActiveDayColourValue As Color = Color.Orange
    Public Property ActiveDayColour() As Color
        Get
            Return ActiveDayColourValue
        End Get
        Set(ByVal value As Color)
            ActiveDayColourValue = value
        End Set
    End Property

    Private OtherYearWeekdayColourValue As Color = Color.LightGray
    Public Property OtherYearWeekdayColour() As Color
        Get
            Return OtherYearWeekdayColourValue
        End Get
        Set(ByVal value As Color)
            OtherYearWeekdayColourValue = value
        End Set
    End Property

    Private OtherYearWeekendColourValue As Color = Color.Gray
    Public Property OtherYearWeekendColour() As Color
        Get
            Return OtherYearWeekendColourValue
        End Get
        Set(ByVal value As Color)
            OtherYearWeekendColourValue = value
        End Set
    End Property

    Private ThisYearWeekdayColourValue As Color = Color.White
    Public Property ThisYearWeekdayColour() As Color
        Get
            Return ThisYearWeekdayColourValue
        End Get
        Set(ByVal value As Color)
            ThisYearWeekdayColourValue = value
        End Set
    End Property

    Private ThisYearWeekendColourValue As Color = Color.PaleGoldenrod
    Public Property ThisYearWeekendColour() As Color
        Get
            Return ThisYearWeekendColourValue
        End Get
        Set(ByVal value As Color)
            ThisYearWeekendColourValue = value
        End Set
    End Property

    Private TodayColourValue As Color = Color.RoyalBlue
    Public Property TodayColour() As Color
        Get
            Return TodayColourValue
        End Get
        Set(ByVal value As Color)
            TodayColourValue = value
        End Set
    End Property

    Private TodayTextColourValue As Color = Color.White
    Public Property TodayTextColour() As Color
        Get
            Return TodayTextColourValue
        End Get
        Set(ByVal value As Color)
            TodayTextColourValue = value
        End Set
    End Property

    Private Colour1Value As Color
    Public Property Colour1() As Color
        Get
            Return Colour1Value
        End Get
        Set(ByVal value As Color)
            Colour1Value = value
        End Set
    End Property

    Private Colour2Value As Color
    Public Property Colour2() As Color
        Get
            Return Colour2Value
        End Get
        Set(ByVal value As Color)
            Colour2Value = value
        End Set
    End Property

    Private Colour3Value As Color
    Public Property Colour3() As Color
        Get
            Return Colour3Value
        End Get
        Set(ByVal value As Color)
            Colour3Value = value
        End Set
    End Property

    Private Colour4Value As Color
    Public Property Colour4() As Color
        Get
            Return Colour4Value
        End Get
        Set(ByVal value As Color)
            Colour4Value = value
        End Set
    End Property

    Private Colour5Value As Color
    Public Property Colour5() As Color
        Get
            Return Colour5Value
        End Get
        Set(ByVal value As Color)
            Colour5Value = value
        End Set
    End Property

    Private Colour6Value As Color
    Public Property Colour6() As Color
        Get
            Return Colour6Value
        End Get
        Set(ByVal value As Color)
            Colour6Value = value
        End Set
    End Property


    Private Sub MonthView_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ActiveYear = Now.Year
    End Sub


    Private Sub MonthView_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Dim lngPointer As Long

        For lngPointer = 1 To 41
            'If e.X >= maryDateCoordinates(2, lngPointer) And e.X <= maryDateCoordinates(3, lngPointer) And
            '    e.Y >= maryDateCoordinates(4, lngPointer) And e.Y <= maryDateCoordinates(5, lngPointer) Then
            '    ' has selected a date
            '    If Format(maryDateCoordinates(1, lngPointer), "MMMM yyyy") = Format(ActiveDate, "MMMM yyyy") Then
            '        ActiveDate = maryDateCoordinates(1, lngPointer)
            '        RaiseEvent DateClick(Me, maryDateCoordinates(1, lngPointer))
            '        Me.Refresh()
            '    End If
            '    Exit For
            'End If
        Next

    End Sub

    'Private Sub InitializeComponent()
    '    Me.SuspendLayout()
    '    '
    '    'ctlYearView
    '    '
    '    Me.Name = "ctlYearView"
    '    Me.ResumeLayout(False)

    'End Sub

    Private Sub ctlYearView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
