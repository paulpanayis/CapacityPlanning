Module modDateUtility
    Public Enum enmDaySequenceInMonth
        dsmFirst = 1
        dsmSecond = 2
        dsmThird = 3
        dsmFourth = 4
        dsmLast = 5
    End Enum

    Public Enum enmDayTypeInMonth
        dtmDay = 1
        dtmWeekday = 2
        dtmWeekendDay = 3
        dtmMonday = 4
        dtmTuesday = 5
        dtmWednesday = 6
        dtmThursday = 7
        dtmFriday = 8
        dtmSaturday = 9
        dtmSunday = 10
    End Enum

    Function DatePartOnly(ByVal dteDateTime As Date) As Date
        DatePartOnly = CDate(Format(dteDateTime, "d MMM yyyy"))
    End Function

    Function UKDateFormat()
        If CDate("01/02/1990") = CDate("1 February 1990") Then
            UKDateFormat = True
        Else
            UKDateFormat = False
        End If
    End Function

    Function MonthStart(ByVal dtADate As Date) As Date
        MonthStart = CDate("1 " & Format(dtADate, "MMM yyyy"))
    End Function

    Function MonthEnd(ByVal dtADate As Date) As Date
        Dim dtTemp As Date

        dtTemp = CDate("1 " & Format(dtADate, "MMM yyyy"))
        dtTemp = DateAdd("m", 1, dtTemp)
        MonthEnd = DateAdd("d", -1, dtTemp)
    End Function


    Function WednesdayinMonth(ByVal nWeek As Integer, ByVal nMonth As Integer, ByVal nYear As Integer) As Date
        Dim nDayOfWeek As Integer
        Dim dtDate As Date

        dtDate = CDate("01/" & CStr(nMonth) & "/" & CStr(nYear))
        nDayOfWeek = Weekday(dtDate, vbWednesday)
        WednesdayinMonth = DateAdd("ww", nWeek - 1, DateAdd("d", (7 - nDayOfWeek + 1), dtDate))
    End Function


    Function MonthEndWeekDay(ByVal dteADate As Date) As Date
        Dim dteTemp As Date

        dteTemp = CDate("1 " & Format(dteADate, "MMM yyyy"))
        dteTemp = DateAdd("m", 1, dteTemp)
        dteTemp = DateAdd("d", -1, dteTemp)

        If Weekday(dteTemp) = vbSunday Then
            dteTemp = DateAdd("d", -2, dteTemp)
        ElseIf Weekday(dteTemp) = vbSaturday Then
            dteTemp = DateAdd("d", -1, dteTemp)
        End If

        MonthEndWeekDay = dteTemp
    End Function

    Function MonthEndWeekendDay(ByVal dteADate As Date) As Date
        Dim dteTemp As Date

        dteTemp = CDate("1 " & Format(dteADate, "MMM yyyy"))
        dteTemp = DateAdd("m", 1, dteTemp)
        dteTemp = DateAdd("d", -1, dteTemp)

        If Weekday(dteTemp) = vbMonday Then
            dteTemp = DateAdd("d", -1, dteTemp)
        ElseIf Weekday(dteTemp) = vbTuesday Then
            dteTemp = DateAdd("d", -2, dteTemp)
        ElseIf Weekday(dteTemp) = vbWednesday Then
            dteTemp = DateAdd("d", -3, dteTemp)
        ElseIf Weekday(dteTemp) = vbThursday Then
            dteTemp = DateAdd("d", -4, dteTemp)
        ElseIf Weekday(dteTemp) = vbFriday Then
            dteTemp = DateAdd("d", -5, dteTemp)
        End If

        MonthEndWeekendDay = dteTemp
    End Function


    Public Function Age(ByVal dteDOB As Date, Optional ByVal strDate As String = "") As Long

        Dim lngAge As Long
        Dim lngDay1 As Long
        Dim lngDay2 As Long

        '
        ' this function will calculate the age of a person on the date
        ' provided (2nd argument) if they are born on the given Date of Birth
        '

        '
        ' N.B.
        ' I chose 1992 as my default year as this is a leap year and as such
        ' provides the greatest day/month range
        ' Similarly, I chose January as my default month as this has 31 days in it
        '
        Dim dteDate As Date

        If strDate = "" Then
            dteDate = DateTime.Today
        Else
            dteDate = CDate(strDate)
        End If

        lngAge = DateDiff("yyyy", dteDOB, dteDate)
        If DateDiff("m", CDate(Format(dteDOB, "d MMM") & " 1992"), CDate(Format(dteDate, "d MMM") & " 1992")) < 0 Then
            lngAge = lngAge - 1
        ElseIf DateDiff("m", CDate(Format(dteDOB, "d MMM") & " 1992"), CDate(Format(dteDate, "d MMM") & " 1992")) = 0 Then
            lngDay1 = Format(dteDOB, "dd")
            lngDay2 = Format(dteDate, "dd")
            If DateDiff("d", CDate(lngDay1 & " Jan 1992"), CDate(lngDay2 & " Jan 1992")) < 0 Then
                lngAge = lngAge - 1
            End If
        End If

        Age = lngAge

    End Function


    Public Sub TaxYearDates(ByRef dteStart As Date, ByRef dteEnd As Date, ByVal dteSeedDate As Date)

        '
        ' this function will return the tax year start and end dates
        ' for the tax year
        '
        ' if the 3rd argument is provided it will work in the following way:
        ' DateAdd("yyyy", -1, TimeNow) = last tax year
        ' DateAdd("yyyy", 0, TimeNow) = this tax year
        ' DateAdd("yyyy", 1, TimeNow) = next tax year
        ' DateAdd("yyyy", 2, TimeNow) = tax year in 2 years time etc..
        '
        Dim dteNow As Date


        dteNow = dteSeedDate

        If dteNow >= CDate("6 April " & Year(dteNow)) Then
            ' set to 6 April
            dteStart = CDate("6 April " & Year(dteNow))
            dteEnd = CDate("5 April " & (Year(dteNow) + 1))
        Else
            ' previous year
            dteStart = CDate("6 April " & (Year(dteNow) - 1))
            dteEnd = CDate("5 April " & Year(dteNow))
        End If

    End Sub

    Public Function MonthText(ByVal lngMonth As Long, Optional ByVal blnShortVersion As Boolean = False) As String

        Dim strMonth As String

        Select Case lngMonth
            Case 1
                strMonth = "January"
            Case 2
                strMonth = "February"
            Case 3
                strMonth = "March"
            Case 4
                strMonth = "April"
            Case 5
                strMonth = "May"
            Case 6
                strMonth = "June"
            Case 7
                strMonth = "July"
            Case 8
                strMonth = "August"
            Case 9
                strMonth = "September"
            Case 10
                strMonth = "October"
            Case 11
                strMonth = "November"
            Case 12
                strMonth = "December"
            Case Else
                strMonth = "January"
        End Select

        If blnShortVersion Then
            MonthText = Left(strMonth, 3)
        Else
            MonthText = strMonth
        End If

    End Function

    Public Function AddWeekDays(ByVal dteStart As Date, ByVal lngWeekDays As Long) As Date

        Dim dteCurrent As Date


        ' add the Week days onto the start date
        dteCurrent = dteStart
        Do While lngWeekDays > 0
            dteCurrent = DateAdd(DateInterval.Day, 1, dteCurrent)
            If Weekday(dteCurrent) = vbSunday Then
                ' not a Week day
            ElseIf Weekday(dteCurrent) = vbSaturday Then
                ' not a Week day
            Else
                lngWeekDays = lngWeekDays - 1
            End If
        Loop

        ' return the date
        AddWeekDays = dteCurrent

    End Function

    Public Function WeekdayXth(ByVal dteStart As Date, ByVal lngWeekDays As Long) As Date

        Dim dteCurrent As Date


        ' add the Week days onto the start date
        dteCurrent = dteStart
        Do While lngWeekDays > 0
            If Weekday(dteCurrent) = vbSunday Then
                ' not a Week day
            ElseIf Weekday(dteCurrent) = vbSaturday Then
                ' not a Week day
            Else
                lngWeekDays = lngWeekDays - 1
            End If
            If lngWeekDays > 0 Then
                dteCurrent = DateAdd(DateInterval.Day, 1, dteCurrent)
            End If
        Loop

        ' return the date
        WeekdayXth = dteCurrent

    End Function

    Public Function AddWeekendDays(ByVal dteStart As Date, ByVal lngWeekendDays As Long) As Date

        Dim dteCurrent As Date


        ' add the weekend days onto the start date
        dteCurrent = dteStart
        Do While lngWeekendDays > 0
            dteCurrent = DateAdd(DateInterval.Day, 1, dteCurrent)
            If Weekday(dteCurrent) = vbSunday Or Weekday(dteCurrent) = vbSaturday Then
                lngWeekendDays = lngWeekendDays - 1
            Else
                ' not a weekend day
            End If
        Loop

        ' return the date
        AddWeekendDays = dteCurrent

    End Function

    Public Function WeekendXth(ByVal dteStart As Date, ByVal lngWeekendDays As Long) As Date

        Dim dteCurrent As Date


        ' add the weekend days onto the start date
        dteCurrent = dteStart
        Do While lngWeekendDays > 0
            If Weekday(dteCurrent) = vbSunday Or Weekday(dteCurrent) = vbSaturday Then
                lngWeekendDays = lngWeekendDays - 1
            Else
                ' not a weekend day
            End If
            If lngWeekendDays > 0 Then
                dteCurrent = DateAdd(DateInterval.Day, 1, dteCurrent)
            End If
        Loop

        ' return the date
        WeekendXth = dteCurrent

    End Function

    Public Function SubtractWeekDays(ByVal dteStart As Date, ByVal lngWeekDays As Long) As Date

        Dim dteCurrent As Date


        ' add the Week days onto the start date
        dteCurrent = dteStart
        Do While lngWeekDays > 0
            dteCurrent = DateAdd(DateInterval.Day, -1, dteCurrent)
            If Weekday(dteCurrent) = vbSunday Then
                ' not a Week day
            ElseIf Weekday(dteCurrent) = vbSaturday Then
                ' not a Week day
            Else
                lngWeekDays = lngWeekDays - 1
            End If
        Loop

        ' return the date
        SubtractWeekDays = dteCurrent

    End Function

    Public Function SubtractWeekendDays(ByVal dteStart As Date, ByVal lngWeekendDays As Long) As Date

        Dim dteCurrent As Date


        ' add the weekend days onto the start date
        dteCurrent = dteStart
        Do While lngWeekendDays > 0
            dteCurrent = DateAdd(DateInterval.Day, -1, dteCurrent)
            If Weekday(dteCurrent) = vbSunday Or Weekday(dteCurrent) = vbSaturday Then
                lngWeekendDays = lngWeekendDays - 1
            Else
                ' not a weekend day
            End If
        Loop

        ' return the date
        SubtractWeekendDays = dteCurrent

    End Function


    Function MonthStartWeekDay(ByVal dteADate As Date) As Date
        Dim dteTemp As Date

        dteTemp = CDate("01/" & Format(dteADate, "mm/yyyy"))
        If Weekday(dteTemp) = vbSunday Then
            dteTemp = DateAdd("d", 1, dteTemp)
        ElseIf Weekday(dteTemp) = vbSaturday Then
            dteTemp = DateAdd("d", 2, dteTemp)
        End If

        MonthStartWeekDay = dteTemp
    End Function

    Function WeekDayOnOrAfter(ByVal dteADate As Date) As Date
        Dim dteTemp As Date

        dteTemp = dteADate

        If Weekday(dteTemp) = vbSunday Then
            dteTemp = DateAdd("d", 1, dteTemp)
        ElseIf Weekday(dteTemp) = vbSaturday Then
            dteTemp = DateAdd("d", 2, dteTemp)
        End If

        WeekDayOnOrAfter = dteTemp
    End Function

    Function PreviousWeekDay(ByVal dteADate As Date) As Date
        Dim dteTemp As Date

        dteTemp = dteADate

        If Weekday(dteTemp) = vbSunday Then
            dteTemp = DateAdd("d", -2, dteTemp)
        ElseIf Weekday(dteTemp) = vbSaturday Then
            dteTemp = DateAdd("d", -1, dteTemp)
        End If

        PreviousWeekDay = dteTemp
    End Function

    Function DayTypeDateInMonth(ByVal dteDate As Date, ByVal enmDaySequence As enmDaySequenceInMonth, ByVal enmDayType As enmDayTypeInMonth) As Date
        '
        ' this function will find the date for the day type specified
        '
        ' examples of the day type are:
        ' first tuesday; last weekend day; second sunday, last friday etc..
        '
        Dim dteReturnDate As Date

        Select Case enmDayType
            Case enmDayTypeInMonth.dtmDay
                ' easy if we are talking about any day
                If enmDaySequence = enmDaySequenceInMonth.dsmLast Then
                    dteReturnDate = MonthEnd(dteDate)
                Else
                    dteReturnDate = CDate(enmDaySequence & " " & Format(dteDate, "MMMM yyyy"))
                End If
            Case enmDayTypeInMonth.dtmWeekday
                ' easy if we are talking about any weekday
                If enmDaySequence = enmDaySequenceInMonth.dsmLast Then
                    dteReturnDate = MonthEndWeekDay(dteDate)
                Else
                    dteReturnDate = WeekdayXth("1 " & Format(dteDate, "MMMM yyyy"), enmDaySequence)
                End If
            Case enmDayTypeInMonth.dtmWeekendDay
                ' easy if we are talking about any weekday
                If enmDaySequence = enmDaySequenceInMonth.dsmLast Then
                    dteReturnDate = MonthEndWeekendDay(dteDate)
                Else
                    dteReturnDate = WeekendXth("1 " & Format(dteDate, "MMMM yyyy"), enmDaySequence)
                End If
            Case Else
                ' specific week day specified
                ' so use more effecient algorithms
                ' pass monday as day 1, tuesday as 2 etc..
                dteReturnDate = DayOfWeekXth(dteDate, enmDayType - 3, enmDaySequence)
        End Select

        DayTypeDateInMonth = dteReturnDate
    End Function


    Public Function DayOfWeekXth(ByVal dteDate As Date, ByVal lngDay As Long, ByVal enmDaySequence As enmDaySequenceInMonth) As Date
        '
        ' this function will return the first tuesday, last friday of the month etc..
        '
        ' the lngDay is passed in as 1 - Monday, 2 - Tuesday throught to 7 - Sunday
        ' the enmDaySequence is a value 1 to 5, 1 being first, 5 being last of month
        ' NB. 4th and Last may produce the same result
        '
        Dim dteReturnDate As Date
        Dim dteFirstDate As Date
        Dim dteMonthEnd As Date
        Dim lngStepForward As Long

        ' lets calculate the first specified day of the month to start with
        ' we can then add weeks to this date

        dteFirstDate = CDate("1 " & Format(dteDate, "MMM yyyy"))
        dteMonthEnd = MonthEnd(dteDate)

        lngStepForward = lngDay - Weekday(dteFirstDate, vbMonday)
        If lngStepForward < 0 Then
            lngStepForward = lngStepForward + 7
        End If

        dteFirstDate = DateAdd("d", lngStepForward, dteFirstDate)

        dteReturnDate = DateAdd("ww", enmDaySequence - 1, dteFirstDate)
        ' add the number of weeks we are talking about

        ' now step backwards to ensure that we are still within the bounds of the month
        Do While dteReturnDate > dteMonthEnd
            dteReturnDate = DateAdd("ww", -1, dteReturnDate)
        Loop

        DayOfWeekXth = dteReturnDate

    End Function

    Public Function LongDateFormat(ByVal dteX As Date) As String
        ' format date in longest format
        ' e.g.  21st September, 2008
        LongDateFormat = dteX.Day & NumberSuffix(dteX.Day) & " " & Format(dteX, "MMMM, yyyy")
    End Function

    Public Function GetDate(ByVal dteStartDate As Date, ByVal lngStartYear As Long, ByVal lngEndYear As Long, Optional ByVal blnSelectDay As Boolean = True) As Date
        frmDateSelector.ActiveDate = dteStartDate
        frmDateSelector.ActiveStartYear = lngStartYear
        frmDateSelector.ActiveEndYear = lngEndYear

        If blnSelectDay Then
            frmDateSelector.ShowDay()
        Else
            frmDateSelector.HideDay()
        End If

        frmDateSelector.Initialise()

        frmDateSelector.ShowDialog()

        If frmDateSelector.Tag = "OK" Then
            Return frmDateSelector.DateSelected
        Else
            Return dteStartDate
        End If

        frmDateSelector.Dispose()
    End Function

    Public Function GetTime(ByVal strStartTime24hr As String) As String

        frmTimeSelect.StartTime = strStartTime24hr
        frmTimeSelect.Initialise()
        frmTimeSelect.ShowDialog()

        If frmTimeSelect.Tag = "OK" Then
            Return frmTimeSelect.TimeSelected
        Else
            Return strStartTime24hr
        End If

    End Function

End Module
