<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SprintsAdd
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SprintsAdd))
        Me.pnlBottomBar = New System.Windows.Forms.Panel()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.lblSprintStartDay = New System.Windows.Forms.Label()
        Me.txtTemplateName = New System.Windows.Forms.TextBox()
        Me.lblTeamName = New System.Windows.Forms.Label()
        Me.txtTemplateStartDay = New System.Windows.Forms.TextBox()
        Me.grpSprints = New System.Windows.Forms.GroupBox()
        Me.lblRangeValue = New System.Windows.Forms.Label()
        Me.lblRange = New System.Windows.Forms.Label()
        Me.cmdEndDate = New System.Windows.Forms.Button()
        Me.lblEndDate = New System.Windows.Forms.Label()
        Me.lblSprintsToAddValue = New System.Windows.Forms.Label()
        Me.lblEndDateLastSprintValue = New System.Windows.Forms.Label()
        Me.lblNoteOver100Sprints = New System.Windows.Forms.Label()
        Me.lblEndDateLastSprint = New System.Windows.Forms.Label()
        Me.lblSprintsToAdd = New System.Windows.Forms.Label()
        Me.lblNoteEndSprintDate = New System.Windows.Forms.Label()
        Me.lblNoteStartDayNotMatching = New System.Windows.Forms.Label()
        Me.lblNote = New System.Windows.Forms.Label()
        Me.lblNoteStartSprint = New System.Windows.Forms.Label()
        Me.ctlCreateSprints = New Capacity_Planning.ctlRichButtonSmall()
        Me.cmdStartDate = New System.Windows.Forms.Button()
        Me.lblStartDate = New System.Windows.Forms.Label()
        Me.lblStartSprintNumber = New System.Windows.Forms.Label()
        Me.txtStartSprintNumber = New System.Windows.Forms.TextBox()
        Me.pnlBottomBar.SuspendLayout()
        Me.grpSprints.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBottomBar
        '
        Me.pnlBottomBar.BackColor = System.Drawing.Color.Transparent
        Me.pnlBottomBar.Controls.Add(Me.lblCopyright)
        Me.pnlBottomBar.Controls.Add(Me.cmdClose)
        Me.pnlBottomBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottomBar.Location = New System.Drawing.Point(0, 412)
        Me.pnlBottomBar.Margin = New System.Windows.Forms.Padding(6)
        Me.pnlBottomBar.Name = "pnlBottomBar"
        Me.pnlBottomBar.Size = New System.Drawing.Size(481, 57)
        Me.pnlBottomBar.TabIndex = 60
        '
        'lblCopyright
        '
        Me.lblCopyright.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCopyright.BackColor = System.Drawing.Color.Transparent
        Me.lblCopyright.Font = New System.Drawing.Font("Calibri", 10.125!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyright.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblCopyright.Location = New System.Drawing.Point(9, 19)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(181, 29)
        Me.lblCopyright.TabIndex = 61
        Me.lblCopyright.Text = "© Paul Panayis, 2018"
        Me.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdClose.Location = New System.Drawing.Point(391, 19)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 3
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'lblSprintStartDay
        '
        Me.lblSprintStartDay.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSprintStartDay.AutoSize = True
        Me.lblSprintStartDay.BackColor = System.Drawing.Color.Transparent
        Me.lblSprintStartDay.Location = New System.Drawing.Point(322, 9)
        Me.lblSprintStartDay.Name = "lblSprintStartDay"
        Me.lblSprintStartDay.Size = New System.Drawing.Size(81, 13)
        Me.lblSprintStartDay.TabIndex = 91
        Me.lblSprintStartDay.Text = "Sprint Start Day"
        '
        'txtTemplateName
        '
        Me.txtTemplateName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTemplateName.Enabled = False
        Me.txtTemplateName.Location = New System.Drawing.Point(15, 28)
        Me.txtTemplateName.Margin = New System.Windows.Forms.Padding(6)
        Me.txtTemplateName.Name = "txtTemplateName"
        Me.txtTemplateName.Size = New System.Drawing.Size(298, 20)
        Me.txtTemplateName.TabIndex = 89
        '
        'lblTeamName
        '
        Me.lblTeamName.AutoSize = True
        Me.lblTeamName.BackColor = System.Drawing.Color.Transparent
        Me.lblTeamName.Location = New System.Drawing.Point(12, 9)
        Me.lblTeamName.Name = "lblTeamName"
        Me.lblTeamName.Size = New System.Drawing.Size(112, 13)
        Me.lblTeamName.TabIndex = 90
        Me.lblTeamName.Text = "Sprint Template Name"
        '
        'txtTemplateStartDay
        '
        Me.txtTemplateStartDay.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTemplateStartDay.Enabled = False
        Me.txtTemplateStartDay.Location = New System.Drawing.Point(325, 28)
        Me.txtTemplateStartDay.Margin = New System.Windows.Forms.Padding(6)
        Me.txtTemplateStartDay.Name = "txtTemplateStartDay"
        Me.txtTemplateStartDay.Size = New System.Drawing.Size(141, 20)
        Me.txtTemplateStartDay.TabIndex = 92
        '
        'grpSprints
        '
        Me.grpSprints.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpSprints.Controls.Add(Me.lblRangeValue)
        Me.grpSprints.Controls.Add(Me.lblRange)
        Me.grpSprints.Controls.Add(Me.cmdEndDate)
        Me.grpSprints.Controls.Add(Me.lblEndDate)
        Me.grpSprints.Controls.Add(Me.lblSprintsToAddValue)
        Me.grpSprints.Controls.Add(Me.lblEndDateLastSprintValue)
        Me.grpSprints.Controls.Add(Me.lblNoteOver100Sprints)
        Me.grpSprints.Controls.Add(Me.lblEndDateLastSprint)
        Me.grpSprints.Controls.Add(Me.lblSprintsToAdd)
        Me.grpSprints.Controls.Add(Me.lblNoteEndSprintDate)
        Me.grpSprints.Controls.Add(Me.lblNoteStartDayNotMatching)
        Me.grpSprints.Controls.Add(Me.lblNote)
        Me.grpSprints.Controls.Add(Me.lblNoteStartSprint)
        Me.grpSprints.Controls.Add(Me.ctlCreateSprints)
        Me.grpSprints.Controls.Add(Me.cmdStartDate)
        Me.grpSprints.Controls.Add(Me.lblStartDate)
        Me.grpSprints.Controls.Add(Me.lblStartSprintNumber)
        Me.grpSprints.Controls.Add(Me.txtStartSprintNumber)
        Me.grpSprints.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpSprints.Location = New System.Drawing.Point(15, 57)
        Me.grpSprints.Name = "grpSprints"
        Me.grpSprints.Size = New System.Drawing.Size(451, 346)
        Me.grpSprints.TabIndex = 93
        Me.grpSprints.TabStop = False
        Me.grpSprints.Text = "Sprints to Add"
        '
        'lblRangeValue
        '
        Me.lblRangeValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRangeValue.BackColor = System.Drawing.Color.LightGray
        Me.lblRangeValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRangeValue.ForeColor = System.Drawing.Color.Gray
        Me.lblRangeValue.Location = New System.Drawing.Point(143, 253)
        Me.lblRangeValue.Name = "lblRangeValue"
        Me.lblRangeValue.Size = New System.Drawing.Size(302, 23)
        Me.lblRangeValue.TabIndex = 118
        Me.lblRangeValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRange
        '
        Me.lblRange.AutoSize = True
        Me.lblRange.BackColor = System.Drawing.Color.Transparent
        Me.lblRange.ForeColor = System.Drawing.Color.Gray
        Me.lblRange.Location = New System.Drawing.Point(140, 236)
        Me.lblRange.Name = "lblRange"
        Me.lblRange.Size = New System.Drawing.Size(115, 13)
        Me.lblRange.TabIndex = 117
        Me.lblRange.Text = "Sprint Range to Create"
        '
        'cmdEndDate
        '
        Me.cmdEndDate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmdEndDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.cmdEndDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdEndDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdEndDate.FlatAppearance.BorderColor = System.Drawing.Color.Lavender
        Me.cmdEndDate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cmdEndDate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender
        Me.cmdEndDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdEndDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEndDate.ForeColor = System.Drawing.Color.Black
        Me.cmdEndDate.Location = New System.Drawing.Point(9, 163)
        Me.cmdEndDate.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdEndDate.Name = "cmdEndDate"
        Me.cmdEndDate.Size = New System.Drawing.Size(122, 29)
        Me.cmdEndDate.TabIndex = 116
        Me.cmdEndDate.Text = "Click for Date"
        Me.cmdEndDate.UseVisualStyleBackColor = False
        '
        'lblEndDate
        '
        Me.lblEndDate.AutoSize = True
        Me.lblEndDate.BackColor = System.Drawing.Color.Transparent
        Me.lblEndDate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblEndDate.Location = New System.Drawing.Point(6, 144)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(89, 13)
        Me.lblEndDate.TabIndex = 115
        Me.lblEndDate.Text = "Sprints' End Date"
        '
        'lblSprintsToAddValue
        '
        Me.lblSprintsToAddValue.BackColor = System.Drawing.Color.LightGray
        Me.lblSprintsToAddValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSprintsToAddValue.ForeColor = System.Drawing.Color.Gray
        Me.lblSprintsToAddValue.Location = New System.Drawing.Point(9, 253)
        Me.lblSprintsToAddValue.Name = "lblSprintsToAddValue"
        Me.lblSprintsToAddValue.Size = New System.Drawing.Size(125, 23)
        Me.lblSprintsToAddValue.TabIndex = 114
        Me.lblSprintsToAddValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEndDateLastSprintValue
        '
        Me.lblEndDateLastSprintValue.BackColor = System.Drawing.Color.LightGray
        Me.lblEndDateLastSprintValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEndDateLastSprintValue.ForeColor = System.Drawing.Color.Gray
        Me.lblEndDateLastSprintValue.Location = New System.Drawing.Point(9, 312)
        Me.lblEndDateLastSprintValue.Name = "lblEndDateLastSprintValue"
        Me.lblEndDateLastSprintValue.Padding = New System.Windows.Forms.Padding(1)
        Me.lblEndDateLastSprintValue.Size = New System.Drawing.Size(125, 23)
        Me.lblEndDateLastSprintValue.TabIndex = 113
        Me.lblEndDateLastSprintValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNoteOver100Sprints
        '
        Me.lblNoteOver100Sprints.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNoteOver100Sprints.BackColor = System.Drawing.Color.Transparent
        Me.lblNoteOver100Sprints.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoteOver100Sprints.ForeColor = System.Drawing.Color.Maroon
        Me.lblNoteOver100Sprints.Location = New System.Drawing.Point(143, 307)
        Me.lblNoteOver100Sprints.Name = "lblNoteOver100Sprints"
        Me.lblNoteOver100Sprints.Size = New System.Drawing.Size(196, 29)
        Me.lblNoteOver100Sprints.TabIndex = 112
        Me.lblNoteOver100Sprints.Text = "Create over 100 new Sprints?"
        Me.lblNoteOver100Sprints.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblNoteOver100Sprints.Visible = False
        '
        'lblEndDateLastSprint
        '
        Me.lblEndDateLastSprint.AutoSize = True
        Me.lblEndDateLastSprint.BackColor = System.Drawing.Color.Transparent
        Me.lblEndDateLastSprint.ForeColor = System.Drawing.Color.Gray
        Me.lblEndDateLastSprint.Location = New System.Drawing.Point(6, 295)
        Me.lblEndDateLastSprint.Name = "lblEndDateLastSprint"
        Me.lblEndDateLastSprint.Size = New System.Drawing.Size(117, 13)
        Me.lblEndDateLastSprint.TabIndex = 110
        Me.lblEndDateLastSprint.Text = "End Date of Last Sprint"
        '
        'lblSprintsToAdd
        '
        Me.lblSprintsToAdd.AutoSize = True
        Me.lblSprintsToAdd.BackColor = System.Drawing.Color.Transparent
        Me.lblSprintsToAdd.ForeColor = System.Drawing.Color.Gray
        Me.lblSprintsToAdd.Location = New System.Drawing.Point(6, 236)
        Me.lblSprintsToAdd.Name = "lblSprintsToAdd"
        Me.lblSprintsToAdd.Size = New System.Drawing.Size(73, 13)
        Me.lblSprintsToAdd.TabIndex = 108
        Me.lblSprintsToAdd.Text = "Sprints to Add"
        '
        'lblNoteEndSprintDate
        '
        Me.lblNoteEndSprintDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNoteEndSprintDate.BackColor = System.Drawing.Color.Transparent
        Me.lblNoteEndSprintDate.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoteEndSprintDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNoteEndSprintDate.Location = New System.Drawing.Point(140, 164)
        Me.lblNoteEndSprintDate.Name = "lblNoteEndSprintDate"
        Me.lblNoteEndSprintDate.Size = New System.Drawing.Size(305, 29)
        Me.lblNoteEndSprintDate.TabIndex = 107
        Me.lblNoteEndSprintDate.Text = "Note: Sprint End Date must be on or after the first sprint"
        Me.lblNoteEndSprintDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblNoteEndSprintDate.Visible = False
        '
        'lblNoteStartDayNotMatching
        '
        Me.lblNoteStartDayNotMatching.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNoteStartDayNotMatching.BackColor = System.Drawing.Color.Transparent
        Me.lblNoteStartDayNotMatching.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoteStartDayNotMatching.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNoteStartDayNotMatching.Location = New System.Drawing.Point(140, 107)
        Me.lblNoteStartDayNotMatching.Name = "lblNoteStartDayNotMatching"
        Me.lblNoteStartDayNotMatching.Size = New System.Drawing.Size(305, 21)
        Me.lblNoteStartDayNotMatching.TabIndex = 106
        Me.lblNoteStartDayNotMatching.Text = "Warning: Start Date does not match template Sprint Start Day"
        Me.lblNoteStartDayNotMatching.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblNoteStartDayNotMatching.Visible = False
        '
        'lblNote
        '
        Me.lblNote.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNote.BackColor = System.Drawing.Color.Transparent
        Me.lblNote.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNote.ForeColor = System.Drawing.Color.Gray
        Me.lblNote.Location = New System.Drawing.Point(6, 198)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(439, 23)
        Me.lblNote.TabIndex = 105
        Me.lblNote.Text = "Note: Each Sprint will be two weeks in length"
        Me.lblNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNoteStartSprint
        '
        Me.lblNoteStartSprint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNoteStartSprint.BackColor = System.Drawing.Color.Transparent
        Me.lblNoteStartSprint.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoteStartSprint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNoteStartSprint.Location = New System.Drawing.Point(182, 44)
        Me.lblNoteStartSprint.Name = "lblNoteStartSprint"
        Me.lblNoteStartSprint.Size = New System.Drawing.Size(263, 29)
        Me.lblNoteStartSprint.TabIndex = 104
        Me.lblNoteStartSprint.Text = "Note: Start Sprint Number must be a number over zero"
        Me.lblNoteStartSprint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblNoteStartSprint.Visible = False
        '
        'ctlCreateSprints
        '
        Me.ctlCreateSprints.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ctlCreateSprints.BackColor = System.Drawing.Color.Transparent
        Me.ctlCreateSprints.ColourHighlight = System.Drawing.Color.Lavender
        Me.ctlCreateSprints.Image = CType(resources.GetObject("ctlCreateSprints.Image"), System.Drawing.Image)
        Me.ctlCreateSprints.Location = New System.Drawing.Point(345, 302)
        Me.ctlCreateSprints.MaximumSize = New System.Drawing.Size(0, 38)
        Me.ctlCreateSprints.MinimumSize = New System.Drawing.Size(100, 38)
        Me.ctlCreateSprints.Name = "ctlCreateSprints"
        Me.ctlCreateSprints.Selected = False
        Me.ctlCreateSprints.Size = New System.Drawing.Size(100, 38)
        Me.ctlCreateSprints.TabIndex = 101
        Me.ctlCreateSprints.TextDescription = "Sprints"
        Me.ctlCreateSprints.TextTitle = "Create"
        '
        'cmdStartDate
        '
        Me.cmdStartDate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmdStartDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.cmdStartDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdStartDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdStartDate.FlatAppearance.BorderColor = System.Drawing.Color.Lavender
        Me.cmdStartDate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cmdStartDate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender
        Me.cmdStartDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdStartDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdStartDate.ForeColor = System.Drawing.Color.Black
        Me.cmdStartDate.Location = New System.Drawing.Point(9, 102)
        Me.cmdStartDate.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdStartDate.Name = "cmdStartDate"
        Me.cmdStartDate.Size = New System.Drawing.Size(122, 29)
        Me.cmdStartDate.TabIndex = 100
        Me.cmdStartDate.Text = "Click for Date"
        Me.cmdStartDate.UseVisualStyleBackColor = False
        '
        'lblStartDate
        '
        Me.lblStartDate.AutoSize = True
        Me.lblStartDate.BackColor = System.Drawing.Color.Transparent
        Me.lblStartDate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblStartDate.Location = New System.Drawing.Point(6, 83)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(92, 13)
        Me.lblStartDate.TabIndex = 99
        Me.lblStartDate.Text = "Sprints' Start Date"
        '
        'lblStartSprintNumber
        '
        Me.lblStartSprintNumber.AutoSize = True
        Me.lblStartSprintNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblStartSprintNumber.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblStartSprintNumber.Location = New System.Drawing.Point(6, 29)
        Me.lblStartSprintNumber.Name = "lblStartSprintNumber"
        Me.lblStartSprintNumber.Size = New System.Drawing.Size(142, 13)
        Me.lblStartSprintNumber.TabIndex = 98
        Me.lblStartSprintNumber.Text = "First Sprint Number to Create"
        '
        'txtStartSprintNumber
        '
        Me.txtStartSprintNumber.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtStartSprintNumber.Location = New System.Drawing.Point(9, 48)
        Me.txtStartSprintNumber.Margin = New System.Windows.Forms.Padding(6)
        Me.txtStartSprintNumber.Name = "txtStartSprintNumber"
        Me.txtStartSprintNumber.Size = New System.Drawing.Size(164, 20)
        Me.txtStartSprintNumber.TabIndex = 97
        '
        'SprintsAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(481, 469)
        Me.Controls.Add(Me.grpSprints)
        Me.Controls.Add(Me.txtTemplateStartDay)
        Me.Controls.Add(Me.lblSprintStartDay)
        Me.Controls.Add(Me.txtTemplateName)
        Me.Controls.Add(Me.lblTeamName)
        Me.Controls.Add(Me.pnlBottomBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SprintsAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create Sprints"
        Me.pnlBottomBar.ResumeLayout(False)
        Me.grpSprints.ResumeLayout(False)
        Me.grpSprints.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlBottomBar As Panel
    Friend WithEvents lblCopyright As Label
    Friend WithEvents cmdClose As Button
    Friend WithEvents lblSprintStartDay As Label
    Friend WithEvents txtTemplateName As TextBox
    Friend WithEvents lblTeamName As Label
    Friend WithEvents txtTemplateStartDay As TextBox
    Friend WithEvents grpSprints As GroupBox
    Friend WithEvents cmdStartDate As Button
    Friend WithEvents lblStartDate As Label
    Friend WithEvents lblStartSprintNumber As Label
    Friend WithEvents txtStartSprintNumber As TextBox
    Friend WithEvents ctlCreateSprints As ctlRichButtonSmall
    Friend WithEvents lblNoteStartSprint As Label
    Friend WithEvents lblNote As Label
    Friend WithEvents lblNoteStartDayNotMatching As Label
    Friend WithEvents lblNoteEndSprintDate As Label
    Friend WithEvents lblEndDateLastSprint As Label
    Friend WithEvents lblSprintsToAdd As Label
    Friend WithEvents lblSprintsToAddValue As Label
    Friend WithEvents lblEndDateLastSprintValue As Label
    Friend WithEvents lblNoteOver100Sprints As Label
    Friend WithEvents cmdEndDate As Button
    Friend WithEvents lblEndDate As Label
    Friend WithEvents lblRangeValue As Label
    Friend WithEvents lblRange As Label
End Class
