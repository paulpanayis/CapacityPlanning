Imports System.Globalization

Public Class ctlYearView
    Public Event DateClick(ByVal sender As Object, ByVal e As Date)
    Public Event DateOver(ByVal sender As Object, ByVal e As Date)

    Private maryDateCoordinates(,) As Object
    Private maryDateUserAreaCoordinates(,) As Object
    Private mintMouseX As Integer = 0
    Private mintMouseY As Integer = 0
    Private mdteDateClicked As Date
    Private mblnValidDate As Boolean = False


    Protected Overrides Sub OnPaintBackground(ByVal pevent As PaintEventArgs)
        ' Graphics object needed to call FillRectangle
        Dim g As Graphics = pevent.Graphics

        ' Fill our control with the specified gradient
        DrawYear(g)
    End Sub

    Private maryDiaryItems(,) As Double ' date (.ToOADate), value
    Public Sub DiaryItemArray(ByVal aryX(,) As Double)
        maryDiaryItems = aryX.Clone
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
        Dim intClientLeft As Integer
        Dim intClientTop As Integer
        Dim intClientWidth As Integer
        Dim intClientHeight As Integer
        Dim lngRow As Long
        Dim lngColumn As Long
        Dim clrColour As Color
        Dim dteDrawingDate As Date
        Dim intDiaryItemType As Integer
        Dim blnValidDate As Boolean
        Dim blnHitBox As Boolean

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

        'ReDim maryDiaryItems(0 To 5, 0 To 2)
        'maryDiaryItems(0, 1) = CDate("5 Feb 2018").ToOADate
        'maryDiaryItems(0, 2) = 1
        'maryDiaryItems(1, 1) = CDate("31 Mar 2018").ToOADate
        'maryDiaryItems(1, 2) = 2
        'maryDiaryItems(2, 1) = CDate("18 Mar 2018").ToOADate
        'maryDiaryItems(2, 2) = 3
        'maryDiaryItems(3, 1) = CDate("28 Mar 2018").ToOADate
        'maryDiaryItems(3, 2) = 4
        'maryDiaryItems(4, 1) = CDate("10 Feb 2018").ToOADate
        'maryDiaryItems(4, 2) = 5
        'maryDiaryItems(5, 1) = CDate("15 Feb 2018").ToOADate
        'maryDiaryItems(5, 2) = 6

        mblnValidDate = False
        g.Clear(Me.BackColor)
        myForeBrush = New SolidBrush(Me.ForeColor)
        sngFontSize = 12
        myFont = New Font(Me.Font.FontFamily, sngFontSize, FontStyle.Regular)
        sngSmallSize = sngFontSize * 0.75
        mySmallFont = New Font(Me.Font.FontFamily, sngSmallSize, FontStyle.Regular)
        textSize = g.MeasureString("WWW", myFont)

        lngLeft = textSize.Width
        lngScaleWidth = CLng(Me.ClientSize.Width) - lngLeft

        lngTop = textSize.Height
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

            lngLeft = textSize.Width
            lngScaleWidth = CLng(Me.ClientSize.Width) - lngLeft

            lngTop = textSize.Height
            lngScaleHeight = CLng(Me.ClientSize.Height) - lngTop

            dblXDivision = (lngScaleWidth) / 12
            dblYDivision = (lngScaleHeight) / 37
        Loop

        ' draw the grid
        dteDrawingDate = New DateTime(ActiveYear, 1, 1)

        For lngColumn = 0 To 12
            For lngRow = 1 To 37
                blnHitBox = False

                If (lngColumn = 0) Then
                    intDayOfMonthOffset = 0
                Else
                    dteFirstOfMonth = New DateTime(ActiveYear, lngColumn, 1)
                    intDayOfMonthOffset = Weekday(dteFirstOfMonth, DayOfWeek.Monday)
                End If
                intDaysInMonth = 0
                blnValidDate = False

                If (lngColumn = 12) Then
                    ' last month in year
                    intDaysInMonth = (New DateTime(ActiveYear + 1, 1, 1) - New DateTime(ActiveYear, lngColumn, 1)).TotalDays
                ElseIf (lngColumn <> 0) Then
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

                ' get full box sizes
                intLeft = lngLeft + ((lngColumn - 1) * dblXDivision)
                intTop = lngTop + ((lngRow - 1) * dblYDivision)
                intWidth = dblXDivision
                intHeight = dblYDivision

                ' get custom marker box sizes
                textSize = g.MeasureString("88", mySmallFont)
                intClientLeft = lngLeft + ((lngColumn - 1) * (dblXDivision)) + textSize.Width
                intClientTop = lngTop + ((lngRow - 1) * dblYDivision) + 4
                intClientWidth = dblXDivision - textSize.Width - 6
                intClientHeight = dblYDivision - 6


                If blnValidDate And (mintMouseX >= intLeft And mintMouseX <= intLeft + intWidth) And (mintMouseY >= intTop And mintMouseY <= intTop + intHeight) Then
                    blnHitBox = True
                    clrColour = Color.HotPink
                    mdteDateClicked = dteDrawingDate
                    mblnValidDate = True
                End If

                If blnValidDate And dteDrawingDate = Now.Date Then
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

                ' now draw in the client area
                If blnValidDate Then
                    intDiaryItemType = GetDiaryItemValue(dteDrawingDate.ToOADate) ' will default to zero
                    If intDiaryItemType <> 0 Then
                        Select Case intDiaryItemType
                            Case 1
                                clrColour = Colour1
                            Case 2
                                clrColour = Colour2
                            Case 3
                                clrColour = Colour3
                            Case 4
                                clrColour = Colour4
                            Case 5
                                clrColour = Colour5
                            Case 6
                                clrColour = Colour6
                        End Select
                        g.FillRectangle(New SolidBrush(clrColour), intClientLeft, intClientTop, intClientWidth, intClientHeight)
                    Else
                        g.FillRectangle(New SolidBrush(Color.FromArgb(25, Color.Green)), intClientLeft, intClientTop, intClientWidth, intClientHeight)
                    End If
                End If

                ' now cut out the outline so each square is separate
                g.DrawRectangle(New Pen(Me.BackColor), intLeft, intTop, intWidth, intHeight)

            Next lngRow
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

            'myFont = New Font(Me.Font.FontFamily, sngFontSize, FontStyle.Regular)
            textSize = g.MeasureString(myString, mySmallFont)

            intX = ((lngLeft - textSize.Width) / 2)
            intY = lngTop + ((lngRow - 1) * dblYDivision) + ((dblYDivision - textSize.Height) / 2)

            g.DrawString(myString, mySmallFont, myForeBrush, intX, intY)
        Next lngRow

        ' draw the months
        For lngColumn = 0 To 11
            myString = New DateTime(2017, lngColumn + 1, 1).ToString("MMM", CultureInfo.InvariantCulture)

            textSize = g.MeasureString(myString, myFont)

            intY = 1
            intX = lngLeft + (lngColumn * dblXDivision) + ((dblXDivision - textSize.Width) / 2)

            g.DrawString(myString, myFont, myForeBrush, intX, intY)
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

    Private OtherYearWeekendColourValue As Color = Color.LightSteelBlue
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
        If mblnValidDate = True Then
            RaiseEvent DateClick(Me, mdteDateClicked)
        End If
    End Sub

    Private Sub ctlYearView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        'ctlYearView
        '
        Me.Name = "ctlYearView"
    End Sub

    Private Sub ctlYearView_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        mintMouseX = e.X
        mintMouseY = e.Y
        Me.Refresh()
        If mblnValidDate = True Then
            RaiseEvent DateOver(Me, mdteDateClicked)
        End If
    End Sub

    Private Sub ctlYearView_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        mintMouseX = 0
        mintMouseY = 0
        mblnValidDate = False
    End Sub

    Private Function GetDiaryItemValue(ByVal dblDate As Double) As Integer
        Dim intReturn As Integer
        Dim lngPointer As Long

        intReturn = 0
        If Not ((maryDiaryItems Is Nothing) OrElse (maryDiaryItems.Length = 0) OrElse (maryDiaryItems.GetValue(0, 1) Is Nothing)) Then
            For lngPointer = maryDiaryItems.GetLowerBound(0) To maryDiaryItems.GetUpperBound(0)
                If maryDiaryItems(lngPointer, 1) = dblDate Then
                    intReturn = maryDiaryItems(lngPointer, 2)
                    Exit For
                End If
            Next
        End If
        Return intReturn
    End Function

End Class
