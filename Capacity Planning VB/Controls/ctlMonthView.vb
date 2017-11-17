Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class ctlMonthView
    Public Event DateClick(ByVal sender As Object, ByVal e As Date)

    Private maryDiaryItems(,) As Double
    Private maryDateCoordinates(,) As Object
    Private maryDateUserAreaCoordinates(,) As Object

    Protected Overrides Sub OnPaintBackground(ByVal pevent As PaintEventArgs)
        ' Graphics object needed to call FillRectangle
        Dim g As Graphics = pevent.Graphics

        ' Fill our control with the specified gradient
        DrawMonth(g)
    End Sub

    Private Sub DrawMonth(ByVal g As Graphics)
        '
        ' this procedure will perform all the calculations for drawing the month and
        ' any leading/trailing dates that will be shown
        ' once all the calultations have been done it will paint the month view
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
        Dim lngDayOffset As Long
        Dim dteGridStartDate As Date
        Dim dteCurrentDate As Date
        Dim lngItem As Long
        Dim blnExtendedView As Boolean
        Dim lngPointer As Long
        Dim blnOutsideThisMonth As Boolean

        Dim myForeBrush As Brush
        Dim myFont As Font
        Dim sngFontSize As Single
        Dim textSize As SizeF
        Dim myString As String

        ReDim maryDateCoordinates(0 To 5, 0 To 42)
        ReDim maryDateUserAreaCoordinates(0 To 5, 0 To 42)

        If maryDiaryItems Is Nothing Then
            blnExtendedView = False
        Else
            If UBound(maryDiaryItems, 1) >= 4 Then
                blnExtendedView = True
            Else
                blnExtendedView = False
            End If
        End If

        g.Clear(Me.BackColor)
        myForeBrush = New SolidBrush(Me.ForeColor)
        sngFontSize = 8
        myFont = New Font("Tahoma", sngFontSize, FontStyle.Regular)
        textSize = g.MeasureString("Wed", myFont)

        lngLeft = 1
        lngScaleWidth = CLng(Me.ClientSize.Width)

        lngTop = textSize.Height
        lngScaleHeight = CLng(Me.ClientSize.Height) - lngTop

        dblXDivision = (lngScaleWidth - 3) / 7
        dblYDivision = (lngScaleHeight - 2) / 6

        Do While sngFontSize > 4 And (textSize.Width > dblXDivision Or textSize.Height > dblYDivision)
            sngFontSize = sngFontSize - 0.25
            myFont = New Font("Tahoma", sngFontSize, FontStyle.Regular)
            textSize = g.MeasureString("Wed", myFont)
            lngTop = textSize.Height + 4
            lngScaleHeight = CLng(g.VisibleClipBounds.Height) - lngTop - 1

            dblXDivision = (lngScaleWidth - 3) / 7
            dblYDivision = (lngScaleHeight - 2) / 6
        Loop

        lngDayOffset = Weekday("1 " & Format(ActiveDate, "MMM yyyy"), vbMonday) - 1
        dteGridStartDate = DateAdd("d", -lngDayOffset, "1 " & Format(ActiveDate, "MMM yyyy"))

        ' draw the days
        For lngColumn = 0 To 6
            myString = Format(DateAdd(DateInterval.Day, lngColumn, dteGridStartDate), "ddd")
            myFont = New Font("Tahoma", sngFontSize, FontStyle.Regular)
            textSize = g.MeasureString(myString, myFont)

            intY = 1
            intX = lngLeft + (lngColumn * dblXDivision) + ((dblXDivision - textSize.Width) / 2)

            g.DrawString(myString, myFont, myForeBrush, intX, intY)
        Next lngColumn

        ' draw the grid
        dteCurrentDate = dteGridStartDate
        lngItem = 1
        For lngRow = 0 To 5
            For lngColumn = 0 To 6

                ' draw in the appropriate colour
                If Format(dteCurrentDate, "MMMM yyyy") <> Format(ActiveDate, "MMMM yyyy") Then
                    clrColour = OtherMonthColourValue
                    blnOutsideThisMonth = True
                ElseIf HaveDiaryItem(dteCurrentDate) And blnExtendedView = False Then
                    clrColour = DiaryItemColour(dteCurrentDate)
                    blnOutsideThisMonth = False
                Else
                    clrColour = ThisMonthColourValue
                    blnOutsideThisMonth = False
                End If

                intLeft = lngLeft + (lngColumn * dblXDivision)
                intTop = lngTop + (lngRow * dblYDivision)
                intWidth = (lngLeft + ((lngColumn + 1) * dblXDivision))
                intWidth = intWidth - intLeft
                intHeight = (lngTop + ((lngRow + 1) * dblYDivision))
                intHeight = intHeight - intTop

                If dteCurrentDate = ActiveDate Then
                    g.FillRectangle(New SolidBrush(clrColour), New Rectangle(New Point(intLeft, intTop), New Size(intWidth, intHeight)))
                    g.FillRectangle(New SolidBrush(ActiveDayColourValue), New Rectangle(New Point(intLeft + 1, intTop + 1), New Size(intWidth - 1, textSize.Height)))
                    g.DrawRectangle(New Pen(ActiveDayColourValue), New Rectangle(New Point(intLeft + 1, intTop + 1), New Size(intWidth - 2, intHeight - 2)))
                Else
                    g.FillRectangle(New SolidBrush(clrColour), New Rectangle(New Point(intLeft, intTop), New Size(intWidth, intHeight)))
                End If
                g.DrawRectangle(New Pen(Me.BackColor), New Rectangle(New Point(intLeft, intTop), New Size(intWidth, intHeight)))

                ' now draw in the dates day

                If Format(dteCurrentDate, "MMMM yyyy") = Format(ActiveDate, "MMMM yyyy") Then
                    If dteCurrentDate = Now.Date Then
                        myFont = New Font("Tahoma", sngFontSize, FontStyle.Bold)
                    Else
                        myFont = New Font("Tahoma", sngFontSize, FontStyle.Regular)
                    End If
                    intY = lngTop + (lngRow * dblYDivision) + 1

                    myString = dteCurrentDate.Day.ToString
                    textSize = g.MeasureString(myString, myFont)

                    intX = lngLeft + (lngColumn * dblXDivision) + (dblXDivision - 1 - textSize.Width)
                    g.DrawString(myString, myFont, myForeBrush, intX, intY)
                End If

                ' main date coordinates

                If lngColumn * lngRow = 30 Then
                    maryDateCoordinates(1, lngItem) = DateTime.Today
                Else
                    maryDateCoordinates(1, lngItem) = dteCurrentDate
                End If
                maryDateCoordinates(2, lngItem) = intLeft
                maryDateCoordinates(3, lngItem) = intLeft + intWidth
                maryDateCoordinates(4, lngItem) = intTop
                maryDateCoordinates(5, lngItem) = intTop + intHeight

                ' setting user drawable area
                If lngColumn * lngRow = 30 Then
                    maryDateUserAreaCoordinates(1, lngItem) = DateTime.Today
                Else
                    maryDateUserAreaCoordinates(1, lngItem) = dteCurrentDate
                End If
                maryDateUserAreaCoordinates(2, lngItem) = intLeft + 2
                maryDateUserAreaCoordinates(3, lngItem) = intLeft + intWidth - 2
                maryDateUserAreaCoordinates(4, lngItem) = intTop + textSize.Height + 1
                maryDateUserAreaCoordinates(5, lngItem) = intTop + intHeight - 2

                ' clear the user area
                If Format(dteCurrentDate, "MMMM yyyy") = Format(ActiveDate, "MMMM yyyy") And HaveDiaryItem(dteCurrentDate) Then
                    g.FillRectangle(New SolidBrush(ThisMonthColour), New Rectangle(maryDateUserAreaCoordinates(2, lngItem), maryDateUserAreaCoordinates(4, lngItem), maryDateUserAreaCoordinates(3, lngItem) - maryDateUserAreaCoordinates(2, lngItem), maryDateUserAreaCoordinates(5, lngItem) - maryDateUserAreaCoordinates(4, lngItem)))
                    g.DrawRectangle(New Pen(Me.BackColor), New Rectangle(maryDateUserAreaCoordinates(2, lngItem), maryDateUserAreaCoordinates(4, lngItem), maryDateUserAreaCoordinates(3, lngItem) - maryDateUserAreaCoordinates(2, lngItem), maryDateUserAreaCoordinates(5, lngItem) - maryDateUserAreaCoordinates(4, lngItem)))
                End If

                ' draw in the more detailed day
                If blnExtendedView = True And HaveDiaryItem(dteCurrentDate) And blnOutsideThisMonth = False Then
                    For lngPointer = 1 To UBound(maryDiaryItems, 2)
                        If maryDiaryItems(1, lngPointer) = dteCurrentDate.ToOADate Then
                            Select Case maryDiaryItems(2, lngPointer)
                                Case 1
                                    clrColour = Colour1
                                Case 2
                                    clrColour = Colour2
                                Case 3
                                    clrColour = Colour3
                                Case 4
                                    clrColour = Colour4
                            End Select

                            ' draw in the day part
                            intLeft = maryDateUserAreaCoordinates(2, lngItem)
                            intTop = ((maryDateUserAreaCoordinates(5, lngItem) - maryDateUserAreaCoordinates(4, lngItem)) * maryDiaryItems(3, lngPointer) / 100) + maryDateUserAreaCoordinates(4, lngItem)
                            intWidth = maryDateUserAreaCoordinates(3, lngItem) - intLeft
                            intHeight = (((maryDateUserAreaCoordinates(5, lngItem) - maryDateUserAreaCoordinates(4, lngItem)) * maryDiaryItems(4, lngPointer) / 100) + maryDateUserAreaCoordinates(4, lngItem)) - intTop
                            If intHeight <= 1 Then
                                ' ensure this item is visible
                                ' by having a minimum height
                                intHeight = 2
                            End If
                            g.FillRectangle(New SolidBrush(clrColour), New Rectangle(intLeft + 1, intTop + 1, intWidth - 1, intHeight - 1))

                        End If
                    Next lngPointer
                End If

                dteCurrentDate = DateAdd(DateInterval.Day, 1, dteCurrentDate)
                lngItem = lngItem + 1

            Next lngColumn
        Next lngRow

    End Sub

    Private Function DiaryItemColour(ByVal dteDate As Date) As Color
        '
        ' looks through the item array provided and determines the colour of the selected diary item
        '
        Dim lngPointer As Long
        Dim clrColour As Color

        ' default to this months colour
        clrColour = ThisMonthColour

        If Not maryDiaryItems Is Nothing Then
            For lngPointer = 1 To UBound(maryDiaryItems, 2)
                If maryDiaryItems(1, lngPointer) = dteDate.ToOADate Then
                    Select Case maryDiaryItems(2, lngPointer)
                        Case 1
                            clrColour = Colour1
                        Case 2
                            clrColour = Colour2
                        Case 3
                            clrColour = Colour3
                        Case 4
                            clrColour = Colour4
                    End Select
                    Exit For
                End If
            Next lngPointer
        End If

        DiaryItemColour = clrColour
    End Function

    Private Function HaveDiaryItem(ByVal dteDate As Date) As Boolean
        '
        ' looks through the item array provided and determines if there is a matching date
        '
        Dim lngPointer As Long
        Dim blnFound As Boolean

        blnFound = False

        If Not maryDiaryItems Is Nothing Then
            For lngPointer = 1 To UBound(maryDiaryItems, 2)
                If maryDiaryItems(1, lngPointer) = dteDate.ToOADate Then
                    blnFound = True
                    Exit For
                End If
            Next lngPointer
        End If
        HaveDiaryItem = blnFound
    End Function

    Public Sub SetDiaryItems(ByRef aryItems(,) As Double)
        maryDiaryItems = aryItems
    End Sub

    Private ActiveDateValue As Date
    Public Property ActiveDate() As Date
        Get
            Return ActiveDateValue
        End Get
        Set(ByVal value As Date)
            ActiveDateValue = value
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

    Private OtherMonthColourValue As Color = Color.Gray
    Public Property OtherMonthColour() As Color
        Get
            Return OtherMonthColourValue
        End Get
        Set(ByVal value As Color)
            OtherMonthColourValue = value
        End Set
    End Property

    Private ThisMonthColourValue As Color = Color.White
    Public Property ThisMonthColour() As Color
        Get
            Return ThisMonthColourValue
        End Get
        Set(ByVal value As Color)
            ThisMonthColourValue = value
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


    Private Sub MonthView_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If ActiveDate = Date.FromOADate(0) Then
            ActiveDate = Now.Date
        End If
    End Sub


    Private Sub MonthView_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Dim lngPointer As Long

        For lngPointer = 1 To 41
            If e.X >= maryDateCoordinates(2, lngPointer) And e.X <= maryDateCoordinates(3, lngPointer) And _
                e.Y >= maryDateCoordinates(4, lngPointer) And e.Y <= maryDateCoordinates(5, lngPointer) Then
                ' has selected a date
                If Format(maryDateCoordinates(1, lngPointer), "MMMM yyyy") = Format(ActiveDate, "MMMM yyyy") Then
                    ActiveDate = maryDateCoordinates(1, lngPointer)
                    RaiseEvent DateClick(Me, maryDateCoordinates(1, lngPointer))
                    Me.Refresh()
                End If
                Exit For
            End If
        Next

    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'ctlMonthView
        '
        Me.Name = "ctlMonthView"
        Me.ResumeLayout(False)

    End Sub

    Private Sub ctlMonthView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
