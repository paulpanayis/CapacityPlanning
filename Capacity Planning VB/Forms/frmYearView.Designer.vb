<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmYearView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlTopBar = New System.Windows.Forms.Panel()
        Me.cboTeamMember = New System.Windows.Forms.ComboBox()
        Me.cboTeam = New System.Windows.Forms.ComboBox()
        Me.cmdYearUp = New System.Windows.Forms.Button()
        Me.cmdYearDown = New System.Windows.Forms.Button()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.pnlBottomBar = New System.Windows.Forms.Panel()
        Me.lblDateOver = New System.Windows.Forms.Label()
        Me.lblDateClicked = New System.Windows.Forms.Label()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.ctlYearView = New Capacity_Planning_VB.ctlYearView()
        Me.pnlTopBar.SuspendLayout()
        Me.pnlBottomBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTopBar
        '
        Me.pnlTopBar.Controls.Add(Me.cboTeamMember)
        Me.pnlTopBar.Controls.Add(Me.cboTeam)
        Me.pnlTopBar.Controls.Add(Me.cmdYearUp)
        Me.pnlTopBar.Controls.Add(Me.cmdYearDown)
        Me.pnlTopBar.Controls.Add(Me.lblYear)
        Me.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopBar.Location = New System.Drawing.Point(1, 1)
        Me.pnlTopBar.Name = "pnlTopBar"
        Me.pnlTopBar.Padding = New System.Windows.Forms.Padding(6)
        Me.pnlTopBar.Size = New System.Drawing.Size(1824, 71)
        Me.pnlTopBar.TabIndex = 1
        '
        'cboTeamMember
        '
        Me.cboTeamMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTeamMember.FormattingEnabled = True
        Me.cboTeamMember.Location = New System.Drawing.Point(678, 17)
        Me.cboTeamMember.Name = "cboTeamMember"
        Me.cboTeamMember.Size = New System.Drawing.Size(384, 33)
        Me.cboTeamMember.Sorted = True
        Me.cboTeamMember.TabIndex = 6
        '
        'cboTeam
        '
        Me.cboTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTeam.FormattingEnabled = True
        Me.cboTeam.Location = New System.Drawing.Point(274, 17)
        Me.cboTeam.Name = "cboTeam"
        Me.cboTeam.Size = New System.Drawing.Size(384, 33)
        Me.cboTeam.Sorted = True
        Me.cboTeam.TabIndex = 5
        '
        'cmdYearUp
        '
        Me.cmdYearUp.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cmdYearUp.Location = New System.Drawing.Point(192, 6)
        Me.cmdYearUp.Name = "cmdYearUp"
        Me.cmdYearUp.Size = New System.Drawing.Size(53, 53)
        Me.cmdYearUp.TabIndex = 4
        Me.cmdYearUp.Text = "+"
        Me.cmdYearUp.UseVisualStyleBackColor = False
        '
        'cmdYearDown
        '
        Me.cmdYearDown.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cmdYearDown.Location = New System.Drawing.Point(12, 9)
        Me.cmdYearDown.Name = "cmdYearDown"
        Me.cmdYearDown.Size = New System.Drawing.Size(53, 53)
        Me.cmdYearDown.TabIndex = 3
        Me.cmdYearDown.Text = "-"
        Me.cmdYearDown.UseVisualStyleBackColor = False
        '
        'lblYear
        '
        Me.lblYear.Location = New System.Drawing.Point(71, 20)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(115, 25)
        Me.lblYear.TabIndex = 2
        Me.lblYear.Text = "2017"
        Me.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlBottomBar
        '
        Me.pnlBottomBar.Controls.Add(Me.lblDateOver)
        Me.pnlBottomBar.Controls.Add(Me.lblDateClicked)
        Me.pnlBottomBar.Controls.Add(Me.cmdClose)
        Me.pnlBottomBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottomBar.Location = New System.Drawing.Point(1, 1308)
        Me.pnlBottomBar.Name = "pnlBottomBar"
        Me.pnlBottomBar.Padding = New System.Windows.Forms.Padding(6)
        Me.pnlBottomBar.Size = New System.Drawing.Size(1824, 71)
        Me.pnlBottomBar.TabIndex = 2
        '
        'lblDateOver
        '
        Me.lblDateOver.Location = New System.Drawing.Point(7, 23)
        Me.lblDateOver.Name = "lblDateOver"
        Me.lblDateOver.Size = New System.Drawing.Size(266, 25)
        Me.lblDateOver.TabIndex = 9
        Me.lblDateOver.Text = "Mouse Over"
        Me.lblDateOver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDateClicked
        '
        Me.lblDateClicked.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDateClicked.Location = New System.Drawing.Point(1352, 23)
        Me.lblDateClicked.Name = "lblDateClicked"
        Me.lblDateClicked.Size = New System.Drawing.Size(266, 25)
        Me.lblDateClicked.TabIndex = 8
        Me.lblDateClicked.Text = "Click Date"
        Me.lblDateClicked.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.Location = New System.Drawing.Point(1624, 9)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(191, 53)
        Me.cmdClose.TabIndex = 7
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'ctlYearView
        '
        Me.ctlYearView.ActiveDayColour = System.Drawing.Color.Orange
        Me.ctlYearView.ActiveYear = 2017
        Me.ctlYearView.BackColor = System.Drawing.SystemColors.Control
        Me.ctlYearView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ctlYearView.Colour1 = System.Drawing.Color.Empty
        Me.ctlYearView.Colour2 = System.Drawing.Color.Empty
        Me.ctlYearView.Colour3 = System.Drawing.Color.Empty
        Me.ctlYearView.Colour4 = System.Drawing.Color.Empty
        Me.ctlYearView.Colour5 = System.Drawing.Color.Empty
        Me.ctlYearView.Colour6 = System.Drawing.Color.Empty
        Me.ctlYearView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ctlYearView.Location = New System.Drawing.Point(1, 72)
        Me.ctlYearView.Name = "ctlYearView"
        Me.ctlYearView.OtherYearWeekdayColour = System.Drawing.Color.LightGray
        Me.ctlYearView.OtherYearWeekendColour = System.Drawing.Color.LightSteelBlue
        Me.ctlYearView.Size = New System.Drawing.Size(1824, 1236)
        Me.ctlYearView.TabIndex = 0
        Me.ctlYearView.ThisYearWeekdayColour = System.Drawing.Color.White
        Me.ctlYearView.ThisYearWeekendColour = System.Drawing.Color.PaleGoldenrod
        Me.ctlYearView.TodayColour = System.Drawing.Color.RoyalBlue
        Me.ctlYearView.TodayTextColour = System.Drawing.Color.White
        '
        'frmYearView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1826, 1380)
        Me.Controls.Add(Me.ctlYearView)
        Me.Controls.Add(Me.pnlBottomBar)
        Me.Controls.Add(Me.pnlTopBar)
        Me.Name = "frmYearView"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Year Calendar 2017"
        Me.pnlTopBar.ResumeLayout(False)
        Me.pnlBottomBar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ctlYearView As ctlYearView
    Friend WithEvents pnlTopBar As Panel
    Friend WithEvents cmdYearUp As Button
    Friend WithEvents cmdYearDown As Button
    Friend WithEvents lblYear As Label
    Friend WithEvents pnlBottomBar As Panel
    Friend WithEvents cboTeamMember As ComboBox
    Friend WithEvents cboTeam As ComboBox
    Friend WithEvents lblDateOver As Label
    Friend WithEvents lblDateClicked As Label
    Friend WithEvents cmdClose As Button
End Class
