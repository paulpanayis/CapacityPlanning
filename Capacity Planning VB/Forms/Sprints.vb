Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class Sprints
    Private maryTemplates() As Long
    Private mintTemplateID As Integer
    Private mintSprintID As Integer
    Private mstrTemplateName As String
    Private mstrTemplateStartDay As String
    Private mblnLoadingTemplate As Boolean
    Private mblnLoadingSprints As Boolean
    Private mblnStopCircularSelect As Boolean


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

    Private Sub MeLoad(sender As Object, e As EventArgs) Handles Me.Load
        LoadFormData()
        lblCopyright.Text = My.Settings.Copyright
        LoadFormSizeAndPosition(Me)
    End Sub

    Private Sub LoadFormData()
        Dim strSQL As String
        Dim intFirstItem As Integer
        Dim intItem As Integer
        Dim intStartYear As Integer

        ' Fill out the teams
        strSQL = Get_SprintTemplates()

        FillListView(Me, lvwTemplates, strSQL, "ID", True, True, True, True)
        FillListBox(cboTemplates, maryTemplates, "Name", strSQL, "ID")

        cboYear.Items.Clear()
        intFirstItem = cboYear.Items.Add("<No Filter - Max 200>")

        intStartYear = Year(Now) - 2
        intItem = cboYear.Items.Add(intStartYear)
        intItem = cboYear.Items.Add(intStartYear + 1)
        intItem = cboYear.Items.Add(intStartYear + 2)
        intItem = cboYear.Items.Add(intStartYear + 3)
        intItem = cboYear.Items.Add(intStartYear + 4)
        intItem = cboYear.Items.Add(intStartYear + 5)

        cboYear.SelectedItem = cboYear.Items(intFirstItem)

        If lvwTemplates.Items.Count > 0 Then
            lvwTemplates.Items.Item(0).Selected = True
        End If
    End Sub

    Private Sub MeClosing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SaveFormSizeAndPosition(Me)
        Me.Dispose()
    End Sub

    Private Sub MeDisposed(sender As Object, e As EventArgs) Handles Me.Disposed
        MainMenu.Focus()
    End Sub

    Private Sub cmdDateFrom_Click(sender As Object, e As EventArgs) Handles cmdStartDate.Click
        Dim dteStart As Date

        If IsDate(cmdStartDate.Text) Then
            dteStart = CDate(cmdStartDate.Text)
        Else
            dteStart = Date.Now
        End If

        cmdStartDate.Text = GetDate(dteStart, Now.Year - 2, Now.Year + 3, True).ToString("d MMM yyyy")
        If dteStart <> CDate(cmdStartDate.Text) Then
            StartSaveSprintTimer()
        End If
    End Sub

    Private Sub cmdDateTo_Click(sender As Object, e As EventArgs) Handles cmdEndDate.Click
        Dim dteStart As Date

        If IsDate(cmdEndDate.Text) Then
            dteStart = CDate(cmdEndDate.Text)
        Else
            dteStart = Date.Now
        End If

        cmdEndDate.Text = GetDate(dteStart, Now.Year - 2, Now.Year + 3, True).ToString("d MMM yyyy")
        If dteStart <> CDate(cmdEndDate.Text) Then
            StartSaveSprintTimer()
        End If
    End Sub

    Private Sub lvwTemplates_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwTemplates.SelectedIndexChanged
        If lvwTemplates.SelectedItems.Count > 0 Then
            If mblnStopCircularSelect = False Then
                mblnLoadingTemplate = True
            End If

            mintTemplateID = Convert.ToInt32(lvwTemplates.SelectedItems(0).Tag)
            txtTemplateName.Text = lvwTemplates.SelectedItems(0).Text
            ListBoxSelect(cboSprintStartDay, lvwTemplates.SelectedItems(0).SubItems(1).Text)
            cboSprintStartDay.Text = lvwTemplates.SelectedItems(0).SubItems(0).Text
            mstrTemplateStartDay = cboSprintStartDay.Text

            If mblnStopCircularSelect = False Then
                mblnStopCircularSelect = True
                ListBoxSelect(cboTemplates, maryTemplates, mintTemplateID)
                mblnStopCircularSelect = False
            End If

            mstrTemplateName = txtTemplateName.Text

            If mblnStopCircularSelect = False Then
                mblnLoadingTemplate = False
            End If
        End If
    End Sub

    Private Sub txtTemplateName_TextChanged(sender As Object, e As EventArgs) Handles txtTemplateName.TextChanged
        StartSaveTemplateTimer()
    End Sub

    Private Sub cboSprintStartDay_TextChanged(sender As Object, e As EventArgs) Handles cboSprintStartDay.TextChanged
        StartSaveTemplateTimer()
    End Sub

    Private Sub cboSprintStartDay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSprintStartDay.SelectedIndexChanged
        StartSaveTemplateTimer()
    End Sub

    Private Sub StartSaveTemplateTimer()
        If mblnLoadingTemplate = False Then
            tmrTemplateSave.Enabled = False
            tmrTemplateSave.Enabled = True
        End If
    End Sub

    Private Sub tmrTemplateSave_Tick(sender As Object, e As EventArgs) Handles tmrTemplateSave.Tick
        Dim intTemplateID As Integer
        Dim strSQL As String

        tmrTemplateSave.Enabled = False

        intTemplateID = mintTemplateID
        mstrTemplateName = txtTemplateName.Text
        mstrTemplateStartDay = cboSprintStartDay.Text

        If Update_SprintTemplate(mintTemplateID, mstrTemplateName, mstrTemplateStartDay) = False Then
            MsgBox("There was a problem trying to update the sprint template details")
        Else
            ' saved successfully
            strSQL = Get_SprintTemplates()

            FillListView(Me, lvwTemplates, strSQL, "ID", True, True, True, True)
            FillListBox(cboTemplates, maryTemplates, "Name", strSQL, "ID")

            ListViewSelectByTag(lvwTemplates, intTemplateID)
        End If
    End Sub

    Private Sub ctlAddTemplate_Clicked() Handles ctlAddTemplate.Clicked
        Dim intTemplateID As Integer
        Dim strSQL As String

        intTemplateID = Add_SprintTemplate()
        strSQL = Get_SprintTemplates()

        FillListView(Me, lvwTemplates, strSQL, "ID", True, True, True, True)
        FillListBox(cboTemplates, maryTemplates, "Name", strSQL, "ID")

        ListViewSelectByTag(lvwTemplates, intTemplateID)
    End Sub

    Private Sub ctlDeleteTemplate_Clicked() Handles ctlDeleteTemplate.Clicked
        Dim intTemplateID As Integer
        Dim strSQL As String

        intTemplateID = mintTemplateID

        If intTemplateID > 0 Then
            If MsgBox("Please confirm you wish to delete Template '" & txtTemplateName.Text & "'", Buttons:=MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If Delete_SprintTemplate(intTemplateID) = False Then
                    MsgBox("There was a problem when trying to delete the selected Template")
                Else
                    intTemplateID = 0
                End If
                strSQL = Get_SprintTemplates()

                FillListView(Me, lvwTemplates, strSQL, "ID", True, True, True, True)
                FillListBox(cboTemplates, maryTemplates, "Name", strSQL, "ID")

                If lvwTemplates.Items.Count > 0 Then
                    lvwTemplates.Items.Item(0).Selected = True
                End If
            End If
        Else
            MsgBox("Please select the Template to delete first")
        End If
    End Sub

    Private Sub ShowSprintsForTemplate()
        Dim strSQL As String
        Dim intYear As Integer

        If IsNumeric(cboYear.Text) Then
            ' no need to filter the results by year
            intYear = Convert.ToInt32(cboYear.Text)
        Else
            intYear = 0
        End If

        strSQL = Get_Sprints(mintTemplateID, intYear)
        FillListView(Me, lvwSprints, strSQL, "ID", True, True, True, True)
        If lvwSprints.Items.Count > 0 Then
            lvwSprints.Items(0).Selected = True
        Else
            mblnLoadingSprints = True
            mintSprintID = 0
            txtSprintNumber.Text = ""
            cmdStartDate.Text = "Click for Date"
            cmdEndDate.Text = "Click for Date"
            mblnLoadingSprints = False
        End If

        ' ensure the timer is not active and trying to save some old sprint
        tmrSprintSave.Enabled = False
    End Sub

    Private Sub cboTemplates_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTemplates.SelectedIndexChanged
        If mblnLoadingSprints = False Then
            If cboTemplates.SelectedIndex > -1 Then
                If mblnStopCircularSelect = False Then
                    mblnLoadingSprints = True
                End If

                mintTemplateID = maryTemplates(cboTemplates.SelectedIndex)
                    ShowSprintsForTemplate()

                    If mblnStopCircularSelect = False Then
                        mblnStopCircularSelect = True
                        ListViewSelectByTag(lvwTemplates, mintTemplateID)
                        mblnStopCircularSelect = False
                    End If

                If mblnStopCircularSelect = False Then
                    mblnLoadingSprints = False
                End If
            End If
            End If
    End Sub

    Private Sub cboYear_TextChanged(sender As Object, e As EventArgs) Handles cboYear.TextChanged, cboYear.SelectedIndexChanged
        If mblnLoadingSprints = False Then
            mblnLoadingSprints = True
            ShowSprintsForTemplate()
            mblnLoadingSprints = False
        End If
    End Sub

    Private Sub txtSprintNumber_TextChanged(sender As Object, e As EventArgs) Handles txtSprintNumber.TextChanged
        StartSaveSprintTimer()
    End Sub

    Private Sub StartSaveSprintTimer()
        If mblnLoadingSprints = False Then
            tmrSprintSave.Enabled = False
            tmrSprintSave.Enabled = True
        End If
    End Sub

    Private Sub lvwSprints_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwSprints.SelectedIndexChanged
        Dim intSprintID As Integer

        mblnLoadingSprints = True

        ' get the sprint id
        If lvwSprints.SelectedItems.Count > 0 Then
            intSprintID = lvwSprints.SelectedItems(0).Tag
            txtSprintNumber.Text = lvwSprints.SelectedItems(0).Text
            cmdStartDate.Text = lvwSprints.SelectedItems(0).SubItems(1).Text
            cmdEndDate.Text = lvwSprints.SelectedItems(0).SubItems(2).Text
        Else
            intSprintID = 0
            txtSprintNumber.Text = ""
            cmdStartDate.Text = "Click for Date"
            cmdEndDate.Text = "Click for Date"
        End If

        mintSprintID = intSprintID

        mblnLoadingSprints = False

    End Sub

    Private Sub tmrSprintSave_Tick(sender As Object, e As EventArgs) Handles tmrSprintSave.Tick
        Dim intSprintID As Integer
        Dim intSprintNumber As Integer
        Dim strStartDate As String
        Dim strEndDate As String

        tmrSprintSave.Enabled = False

        If IsNumeric(txtSprintNumber.Text) = False Then
            MsgBox("Sprint Number must be a number")
            Highlight(txtSprintNumber)
        ElseIf IsDate(cmdStartDate.text) = False Then
            MsgBox("Please select a start date")
            cmdStartDate.Select()
        ElseIf IsDate(cmdEndDate.text) = False Then
            MsgBox("Please select an end date")
            cmdEndDate.Select()
        Else
            mblnLoadingSprints = True
            txtSprintNumber.Text = CInt(txtSprintNumber.Text)
            mblnLoadingSprints = False

            intSprintNumber = txtSprintNumber.Text
            strStartDate = cmdStartDate.Text
            strEndDate = cmdEndDate.Text

            If Update_Sprint(mintSprintID, intSprintNumber, strStartDate, strEndDate) = False Then
                MsgBox("There was a problem trying to update the sprint's details")
            Else
                ' saved successfully

                ' get the sprint id
                intSprintID = mintSprintID

                ShowSprintsForTemplate()

                mblnLoadingSprints = True
                ListViewSelectByTag(lvwSprints, intSprintID)
                mblnLoadingSprints = False
            End If
        End If

    End Sub

    Private Sub ctlDeleteSprint_Clicked() Handles ctlDeleteSprint.Clicked
        Dim intSprintID As Integer

        intSprintID = mintSprintID

        If intSprintID > 0 Then
            If MsgBox("Please confirm you wish to delete Sprint '" & txtSprintNumber.Text & "'", Buttons:=MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If Delete_Sprint(intSprintID) = False Then
                    MsgBox("There was a problem when trying to delete the selected Sprint")
                Else
                    intSprintID = 0
                End If
                ShowSprintsForTemplate()
            End If
        Else
            MsgBox("Please select the Sprint to delete first")
        End If
    End Sub

    Private Sub ctlCreateSprints_Clicked() Handles ctlCreateSprints.Clicked
        SprintsAdd.Visible = False
        SprintsAdd.SprintTemplateID = mintTemplateID
        SprintsAdd.SprintTemplateName = mstrTemplateName
        SprintsAdd.SprintTemplateStartDay = mstrTemplateStartDay

        ' use show dialog so that we can show the new sprints (if any) immediately
        SprintsAdd.ShowDialog(Me)

        ShowSprintsForTemplate()
    End Sub

End Class