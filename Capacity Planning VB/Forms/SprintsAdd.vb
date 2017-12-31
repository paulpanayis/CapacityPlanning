Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class SprintsAdd
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub About_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub

    Private Sub About_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Sprints.Focus()
    End Sub

    Private mintSprintTemplateID As Integer
    Public Property SprintTemplateID() As Integer
        Get
            Return mintSprintTemplateID
        End Get
        Set(ByVal value As Integer)
            mintSprintTemplateID = value
        End Set
    End Property

    Private mstrSprintTemplateName As String
    Public Property SprintTemplateName() As String
        Get
            Return mstrSprintTemplateName
        End Get
        Set(ByVal value As String)
            mstrSprintTemplateName = value
            txtTemplateName.Text = value
        End Set
    End Property

    Private mstrSprintTemplateStartDay As String
    Public Property SprintTemplateStartDay() As String
        Get
            Return mstrSprintTemplateStartDay
        End Get
        Set(ByVal value As String)
            mstrSprintTemplateStartDay = value
            txtTemplateStartDay.Text = value
        End Set
    End Property

    Private Sub cmdStartDate_Click(sender As Object, e As EventArgs) Handles cmdStartDate.Click
        Dim dteStart As Date

        If IsDate(cmdStartDate.Text) Then
            dteStart = CDate(cmdStartDate.Text)
        Else
            dteStart = Date.Now
        End If

        cmdStartDate.Text = GetDate(dteStart, Now.Year - 2, Now.Year + 3, True).ToString("d MMM yyyy")
        ShowNotes()
    End Sub

    Private Sub txtSprintNumber_TextChanged(sender As Object, e As EventArgs) Handles txtStartSprintNumber.TextChanged
        ShowNotes()
    End Sub

    Private Function ValidateFormFields() As Boolean
        Dim blnAllValid As Boolean

        ' let's be optimistic
        blnAllValid = True

        ' start sprint number
        If IsNumeric(txtStartSprintNumber.Text) Then
            If CInt(txtStartSprintNumber.Text) > 0 Then
                lblStartDate.Text = "Sprint " & txtStartSprintNumber.Text & " Start Date"
                If lblNoteStartSprint.Visible = True Then
                    lblNoteStartSprint.Visible = False
                End If
            Else
                If lblNoteStartSprint.Visible = False Then
                    lblNoteStartSprint.Visible = True
                    blnAllValid = False
                End If
            End If
        Else
            lblStartDate.Text = "Sprints' Start Date"
            If lblNoteStartSprint.Visible = False Then
                lblNoteStartSprint.Visible = True
            End If
            blnAllValid = False
        End If

        ' start date of first sprint
        If IsDate(cmdStartDate.Text) = False Then
            If lblNoteStartDayNotMatching.Visible = False Then
                lblNoteStartDayNotMatching.Visible = True
            End If
            blnAllValid = False
        Else
            If CDate(cmdStartDate.Text).DayOfWeek.ToString <> txtTemplateStartDay.Text Then
                lblNoteStartDayNotMatching.Visible = True
                ' this is only a warning, so we dont need to invalidate the calculations
            Else
                lblNoteStartDayNotMatching.Visible = False
            End If

            If CDate(cmdStartDate.Text).DayOfWeek.ToString <> txtTemplateStartDay.Text Then
                lblNoteStartDayNotMatching.Visible = True
                ' this is only a warning, so we dont need to invalidate the calculations
            Else
                lblNoteStartDayNotMatching.Visible = False
            End If
        End If

        ' end date of last sprint
        If IsDate(cmdEndDate.Text) = False Then
            If lblNoteEndSprintDate.Visible = False Then
                lblNoteEndSprintDate.Visible = True
            End If
            blnAllValid = False
        Else
            If CDate(cmdEndDate.Text) < CDate(cmdStartDate.Text) Then
                If lblNoteEndSprintDate.Visible = False Then
                    lblNoteEndSprintDate.Visible = True
                    ' this is only a warning, so we dont need to invalidate the calculations
                End If
            Else
                If lblNoteEndSprintDate.Visible = True Then
                    lblNoteEndSprintDate.Visible = False
                End If
            End If
        End If

        Return blnAllValid
    End Function

    Private Sub ShowNotes()
        ' if everything is valid enough to allow calculations, so calculate how many sprint the entered figures will generate
        If ValidateFormFields() Then
            CalculateSprintsToCreate(CInt(txtStartSprintNumber.Text), CDate(cmdStartDate.Text), CDate(cmdEndDate.Text), 2)
        End If
    End Sub

    Private Sub cmdEndDate_Click(sender As Object, e As EventArgs) Handles cmdEndDate.Click
        Dim dteStart As Date

        If IsDate(cmdEndDate.Text) Then
            dteStart = CDate(cmdEndDate.Text)
        Else
            dteStart = Date.Now
        End If

        cmdEndDate.Text = GetDate(dteStart, Now.Year - 2, Now.Year + 3, True).ToString("d MMM yyyy")
        ShowNotes()
    End Sub

    Private Sub lblSprintsToAddValue_TextChanged(sender As Object, e As EventArgs) Handles lblSprintsToAddValue.TextChanged
        If Val(lblSprintsToAddValue.Text) > 100 Then
            If lblNoteOver100Sprints.Visible = False Then
                lblNoteOver100Sprints.Visible = True
            End If
        Else
            If lblNoteOver100Sprints.Visible = True Then
                lblNoteOver100Sprints.Visible = False
            End If
        End If
    End Sub

    Private Sub CalculateSprintsToCreate(ByVal intSprintNumber As Integer, ByVal dteStart As Date, ByVal dteEnd As Date, ByVal intWeeksInSprint As Integer)
        ' calculate the number of sprints in the given date range, along with the end date of the last sprint
        Dim intSprintWorking As Integer
        Dim dteWorking As Date
        Dim dteEndDate As Date
        Dim intSprintCount As Integer

        intSprintCount = 0
        dteWorking = dteStart
        ' we'll add one to the sprint working number straight away, so start at the sprint number before
        intSprintWorking = intSprintNumber - 1

        Do While dteWorking <= dteEnd
            intSprintCount = intSprintCount + 1
            intSprintWorking = intSprintWorking + 1
            dteEndDate = DateAdd(DateInterval.Day, (intWeeksInSprint * 7) - 1, dteWorking)

            dteWorking = DateAdd(DateInterval.Day, (intWeeksInSprint * 7), dteWorking)
        Loop

        lblSprintsToAddValue.Text = intSprintCount
        lblEndDateLastSprintValue.Text = dteEndDate.ToString("d MMM yyyy")
        If intSprintCount = 0 Then
            lblRangeValue.Text = "None"
        Else
            lblRangeValue.Text = intSprintNumber & " - " & intSprintWorking
        End If
    End Sub

    Private Sub ctlCreateSprints_Clicked() Handles ctlCreateSprints.Clicked
        ' if everything is valid enough to allow sprint creation then create the sprints
        If ValidateFormFields() Then
            If Add_Sprints(mintSprintTemplateID, CInt(txtStartSprintNumber.Text), CDate(cmdStartDate.Text), CDate(cmdEndDate.Text), 2) Then
                MsgBox("Sprints have been added successfully")
                Me.Close()
            Else
                MsgBox("There was a problem trying to add the requested sprints to the Template")
            End If
        Else
            MsgBox("Some of the information is not correctly completed.  Please fix these problems before creating the Sprints.")
        End If
    End Sub

End Class