Imports System.drawing.Printing

Module modUtilities
    Public Function SplitCSVIntoLines(ByVal sString As String) As Object
        SplitCSVIntoLines = SplitIntoLines(sString, ",")
    End Function

    Public Function SplitStringIntoLines(ByVal sString As String) As Object
        SplitStringIntoLines = SplitIntoLines(sString, " ")
    End Function

    Private Function SplitIntoLines(ByVal strString As String, ByVal strSeperator As String) As Object
        Dim iX As Integer
        Dim sLine() As String
        Dim sTemp As String
        Dim sRemaining As String
        Dim iLines As Integer

        sRemaining = Trim(strString)
        iLines = 0
        ReDim sLine(0 To 0)
        iX = InStr(sRemaining, strSeperator)
        Do While iX > 0
            sTemp = Mid(sRemaining, 1, iX - 1)
            If Trim(sTemp) <> "" Then
                iLines = iLines + 1
                ReDim Preserve sLine(0 To iLines)
                sLine(iLines) = Trim(sTemp)
                sRemaining = Mid(sRemaining, iX + 1)
                iX = InStr(sRemaining, strSeperator)
            Else
                sRemaining = Mid(sRemaining, 2)
                iX = InStr(sRemaining, strSeperator)
            End If
        Loop
        If Trim(sRemaining) <> "" Then
            iLines = iLines + 1
            ReDim Preserve sLine(0 To iLines)
            sLine(iLines) = sRemaining
        End If
        SplitIntoLines = sLine
    End Function

    Function IsInCSV(ByVal sString As String, ByVal dblNumber As Double) As Boolean
        Dim Temp() As String
        Dim iX As Integer

        If sString = "" Then
            IsInCSV = False
        ElseIf sString = "ALL" Then
            IsInCSV = True
        Else
            If Left(sString, 1) = "{" Then
                IsInCSV = (InStr(sString, "{" & dblNumber & "}") > 0)
            Else
                Temp = SplitCSVIntoLines(sString)
                IsInCSV = False
                For iX = LBound(Temp) To UBound(Temp)
                    If Val(Temp(iX)) = dblNumber Then
                        IsInCSV = True
                        Exit For
                    End If
                Next
            End If
        End If
    End Function

    Function ValueOf(ByVal strString As String) As Double
        ' this function will strip out all non-numeric characters and return the value of the remaining string
        Dim strTemp As String
        Dim lngPointer As Long


        strTemp = ""
        For lngPointer = 1 To Len(strString)
            Select Case Mid(strString, lngPointer, 1)
                Case "+", "-", "0" To "9", "."
                    strTemp = strTemp & Mid(strString, lngPointer, 1)
            End Select
        Next

        ValueOf = Val(strTemp)
    End Function

    Public Sub SaveFormSizeAndPosition(ByVal frmForm As Form)

        '
        ' save the size and position of the form in the registry
        ' also all listview column widths
        '

        Dim intColumn As Integer
        Dim ctrlX As Control
        Dim ctlListView As ListView
        Dim strKey As String

        On Error Resume Next

        strKey = My.Application.Info.AssemblyName

        SaveSetting(strKey, frmForm.Name, "WindowState", frmForm.WindowState)

        If frmForm.WindowState = vbNormal Then
            SaveSetting(strKey, frmForm.Name, "Top", frmForm.Top)
            SaveSetting(strKey, frmForm.Name, "Left", frmForm.Left)
            SaveSetting(strKey, frmForm.Name, "Width", frmForm.Width)
            SaveSetting(strKey, frmForm.Name, "Height", frmForm.Height)
        End If

        '
        ' this procedure will save the column widths for each listview on a Form
        '
        For Each ctrlX In frmForm.Controls
            If TypeOf ctrlX Is TabControl Then
                SaveAllListViewSizesAndPositionsFromControl(frmForm, ctrlX)
            ElseIf TypeOf ctrlX Is Panel Then
                SaveAllListViewSizesAndPositionsFromControl(frmForm, ctrlX)
            ElseIf TypeOf ctrlX Is GroupBox Then
                SaveAllListViewSizesAndPositionsFromControl(frmForm, ctrlX)
            ElseIf TypeOf ctrlX Is FlowLayoutPanel Then
                SaveAllListViewSizesAndPositionsFromControl(frmForm, ctrlX)
            ElseIf TypeOf ctrlX Is TableLayoutPanel Then
                SaveAllListViewSizesAndPositionsFromControl(frmForm, ctrlX)
            ElseIf TypeOf ctrlX Is SplitContainer Then
                SaveAllListViewSizesAndPositionsFromControl(frmForm, ctrlX)
            ElseIf TypeOf ctrlX Is ListView Then
                ctlListView = ctrlX
                SaveListViewSizeAndPosition(frmForm, ctlListView)
            End If
        Next

    End Sub

    Public Sub SaveAllListViewSizesAndPositionsFromControl(ByRef frmForm As Form, ByRef ctlContainer As Control)
        Dim ctrlX As Control
        Dim strKey As String
        Dim ctlListView As ListView

        strKey = My.Application.Info.AssemblyName

        For Each ctrlX In ctlContainer.Controls
            If TypeOf ctrlX Is TabControl Then
                SaveAllListViewSizesAndPositionsFromControl(frmForm, ctrlX)
            ElseIf TypeOf ctrlX Is Panel Then
                SaveAllListViewSizesAndPositionsFromControl(frmForm, ctrlX)
            ElseIf TypeOf ctrlX Is GroupBox Then
                SaveAllListViewSizesAndPositionsFromControl(frmForm, ctrlX)
            ElseIf TypeOf ctrlX Is FlowLayoutPanel Then
                SaveAllListViewSizesAndPositionsFromControl(frmForm, ctrlX)
            ElseIf TypeOf ctrlX Is TableLayoutPanel Then
                SaveAllListViewSizesAndPositionsFromControl(frmForm, ctrlX)
            ElseIf TypeOf ctrlX Is SplitContainer Then
                SaveAllListViewSizesAndPositionsFromControl(frmForm, ctrlX)
            ElseIf TypeOf ctrlX Is ListView Then
                ctlListView = ctrlX
                SaveListViewSizeAndPosition(frmForm, ctlListView)
            End If
        Next

    End Sub

    Public Sub LoadFormSizeAndPosition(ByVal frmForm As Form)

        '
        ' load the size and position of the form from the registry
        ' also all listview column widths
        '

        Dim intColumn As Integer
        Dim ctrlX As Control
        Dim ctlListView As ListView
        Dim strKey As String

        On Error Resume Next

        strKey = My.Application.Info.AssemblyName

        If frmForm.WindowState = FormWindowState.Minimized Then
            Exit Sub
        End If

        frmForm.Top = GetSetting(strKey, frmForm.Name, "Top", frmForm.Top)
        frmForm.Left = GetSetting(strKey, frmForm.Name, "Left", frmForm.Left)
        If frmForm.FormBorderStyle = FormBorderStyle.Sizable Or frmForm.FormBorderStyle = FormBorderStyle.SizableToolWindow Then
            ' dont resize fixed border forms
            frmForm.Width = GetSetting(strKey, frmForm.Name, "Width", frmForm.Width)
            frmForm.Height = GetSetting(strKey, frmForm.Name, "Height", frmForm.Height)
        End If
        frmForm.WindowState = GetSetting(strKey, frmForm.Name, "WindowState", frmForm.WindowState)

        If (frmForm.Left + frmForm.Width > My.Computer.Screen.Bounds.Width) Or
            (frmForm.Top + frmForm.Height > My.Computer.Screen.Bounds.Height) Then
            frmForm.Left = (My.Computer.Screen.Bounds.Width - frmForm.Width) \ 2
            frmForm.Top = (My.Computer.Screen.Bounds.Height - frmForm.Height) \ 2
        End If
        If (frmForm.Left + frmForm.Width > My.Computer.Screen.Bounds.Width) Or
            (frmForm.Top + frmForm.Height > My.Computer.Screen.Bounds.Height) Then
            frmForm.Left = 0
            frmForm.Top = 0
        End If
        If (frmForm.Left + frmForm.Width > My.Computer.Screen.Bounds.Width) Or
            (frmForm.Top + frmForm.Height > My.Computer.Screen.Bounds.Height) Then
            frmForm.WindowState = FormWindowState.Maximized
        End If

        For Each ctrlX In frmForm.Controls
            If TypeOf ctrlX Is ListView Then
                ctlListView = ctrlX
                For intColumn = 0 To ctlListView.Columns.Count - 1

                    ctlListView.Columns(intColumn).Width = GetSetting(strKey,
                                    frmForm.Name & "." & ctlListView.Name,
                                    "Column " & intColumn,
                                     ctlListView.Columns(intColumn).Width)
                Next
                ctlListView.View = GetSetting(strKey,
                                frmForm.Name & "." & ctlListView.Name,
                                "View",
                                 ctlListView.View)
            End If
        Next

        FadeIn(frmForm)

    End Sub

    Public Sub FadeIn(ByRef frmX As Form, Optional ByVal Seconds As Double = 1)
        Dim lngOpacity As Long
        Dim lngMax As Long

        lngMax = 600 * Seconds

        frmX.Opacity = 0
        frmX.Visible = True
        My.Application.DoEvents()

        For lngOpacity = 0 To lngMax
            If frmX.Opacity <> (lngOpacity / lngMax) * 100 Then
                frmX.Opacity = (lngOpacity / lngMax) * 100
            End If
        Next

    End Sub

    Public Sub FadeOut(ByRef frmX As Form, Optional ByVal Seconds As Long = 1)
        Dim lngOpacity As Long
        Dim lngMax As Long

        lngMax = 1500 * Seconds

        If frmX.Visible = True Then
            For lngOpacity = lngMax To 0 Step -1
                If frmX.Opacity <> (lngOpacity / lngMax) * 100 Then
                    frmX.Opacity = (lngOpacity / lngMax) * 100
                    My.Application.DoEvents()
                End If
            Next
        End If

    End Sub

    Public Function Capitalise(ByRef txtText As TextBox, ByVal KeyChar As Char) As Char

        '
        ' this procedure will return the KeyAscii value that will result in
        ' captalisation of the text in a textbox
        '

        ' this is interface only functionality, so dont let it cause a problem
        On Error Resume Next

        If Len(txtText.Text) = 0 Then
            KeyChar = UCase(KeyChar)
        Else
            If txtText.SelectionStart > 0 Then
                If Trim(Mid(txtText.Text, txtText.SelectionStart)) = "" Or Mid(txtText.Text, txtText.SelectionStart) = vbLf Then
                    ' is at last position and follows a space
                    Select Case Mid(txtText.Text, txtText.SelectionStart, 1)
                        Case " ", "'", "-", vbLf
                            KeyChar = UCase(KeyChar)
                    End Select
                End If
            End If
        End If

        Capitalise = KeyChar

    End Function

    Public Sub Highlight(ByRef txtText As TextBox)
        '
        ' highlight the text in the control
        '

        ' this is interface only functionality, so dont let it cause a problem
        On Error Resume Next
        txtText.SelectionStart = 0
        txtText.SelectionLength = Len(txtText.Text)
    End Sub

    Public Sub Highlight(ByRef cboText As ComboBox)
        '
        ' highlight the text in the control
        '

        ' this is interface only functionality, so dont let it cause a problem
        On Error Resume Next
        cboText.SelectionStart = 0
        cboText.SelectionLength = Len(cboText.Text)
    End Sub

    Public Function CurrencyFormat(ByVal Original As Object) As String
        CurrencyFormat = Format(Val(Original), "£ #,##0.00")
    End Function

    Public Sub HoursMinutesFromMinutes(ByVal lngHoursMinutes As Long, ByRef lngHours As Long, ByRef lngMinutes As Long)
        '
        ' convert the passed minutes into hours minutes
        '
        lngHours = lngHoursMinutes \ 60
        lngMinutes = lngHoursMinutes Mod 60
    End Sub

    Public Function HoursMinuteStringFromMinutes(ByVal lngMinutes As Long) As String
        Dim lngHours As Long
        Dim lngMins As Long

        HoursMinutesFromMinutes(lngMinutes, lngHours, lngMins)

        If lngHours = 0 And lngMins = 0 Then
            HoursMinuteStringFromMinutes = "0 hrs 0 mins"
        ElseIf lngMins = 0 Then
            If lngHours = 1 Then
                Return Format(lngHours, "0") & " hr "
            Else
                Return Format(lngHours, "0") & " hrs"
            End If
        ElseIf lngHours = 0 Then
            Return Format(lngMins, "0") & " mins"
        Else
            If lngHours = 1 Then
                Return Format(lngHours, "0") & " hr " & Format(lngMins, "0") & " mins"
            Else
                Return Format(lngHours, "0") & " hrs " & Format(lngMins, "0") & " mins"
            End If
        End If

    End Function

    Public Function HoursMinuteStringCompactFromMinutes(ByVal lngMinutes As Long) As String
        Dim lngHours As Long
        Dim lngMins As Long

        HoursMinutesFromMinutes(lngMinutes, lngHours, lngMins)

        HoursMinuteStringCompactFromMinutes = Format(lngHours, "00") & ":" & Format(lngMins, "00")

    End Function

    Public Function MinutesFromHoursMinuteString(ByVal strString As String) As Long
        Dim lngHours As Long
        Dim lngMins As Long

        If InStr(strString, "h") > 0 Then
            lngHours = Val(strString)
            lngMins = Val(Mid(strString, InStr(strString, "h") + 3))
        Else
            lngMins = Val(strString)
        End If
        Return (lngHours * 60) + lngMins
    End Function

    Public Function TimeToMinutes(ByVal strTime As String) As Long
        Return Val(strTime) * 60 + Val(Mid(strTime, 4))
    End Function

    Public Function TimeAdd(ByVal strTime As String, ByVal lngDurationMinutes As Long) As String
        TimeAdd = HoursMinuteStringCompactFromMinutes(Left(strTime, 2) * 60 + Mid(strTime, 4) + lngDurationMinutes)
    End Function

    Public Function MinutesFromHoursMinutes(ByVal strTime As String) As Long
        Return TimeToMinutes(strTime)
    End Function

    Public Function NumberSuffix(ByVal lngNumber As Long) As String
        Select Case lngNumber Mod 100
            Case 11
                NumberSuffix = "th"
            Case 12
                NumberSuffix = "th"
            Case 13
                NumberSuffix = "th"
            Case Else
                Select Case lngNumber Mod 10
                    Case 1
                        NumberSuffix = "st"
                    Case 2
                        NumberSuffix = "nd"
                    Case 3
                        NumberSuffix = "rd"
                    Case Else
                        NumberSuffix = "th"
                End Select
        End Select
    End Function

End Module
