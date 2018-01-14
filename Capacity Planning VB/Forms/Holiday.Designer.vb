<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Holiday
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Holiday))
        Me.pnlBottomBar = New System.Windows.Forms.Panel()
        Me.lblHalfDay = New System.Windows.Forms.Label()
        Me.ctlHalfDay = New Capacity_Planning.ctlSwitch()
        Me.lblWriteMode = New System.Windows.Forms.Label()
        Me.ctlEditMode = New Capacity_Planning.ctlSwitch()
        Me.lblShowType6 = New System.Windows.Forms.Label()
        Me.ctlType6 = New Capacity_Planning.ctlSwitch()
        Me.lblShowType5 = New System.Windows.Forms.Label()
        Me.ctlType5 = New Capacity_Planning.ctlSwitch()
        Me.lblShowType4 = New System.Windows.Forms.Label()
        Me.ctlType4 = New Capacity_Planning.ctlSwitch()
        Me.lblShowType3 = New System.Windows.Forms.Label()
        Me.ctlType3 = New Capacity_Planning.ctlSwitch()
        Me.lblShowType2 = New System.Windows.Forms.Label()
        Me.ctlType2 = New Capacity_Planning.ctlSwitch()
        Me.lblShowType1 = New System.Windows.Forms.Label()
        Me.ctlType1 = New Capacity_Planning.ctlSwitch()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cboTeams = New System.Windows.Forms.ComboBox()
        Me.cboPeople = New System.Windows.Forms.ComboBox()
        Me.cboYear = New System.Windows.Forms.ComboBox()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblTeam = New System.Windows.Forms.Label()
        Me.lblPerson = New System.Windows.Forms.Label()
        Me.ctlYearView = New Capacity_Planning.ctlYearView()
        Me.pnlBottomBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBottomBar
        '
        Me.pnlBottomBar.BackColor = System.Drawing.Color.Transparent
        Me.pnlBottomBar.Controls.Add(Me.lblHalfDay)
        Me.pnlBottomBar.Controls.Add(Me.ctlHalfDay)
        Me.pnlBottomBar.Controls.Add(Me.lblWriteMode)
        Me.pnlBottomBar.Controls.Add(Me.ctlEditMode)
        Me.pnlBottomBar.Controls.Add(Me.lblShowType6)
        Me.pnlBottomBar.Controls.Add(Me.ctlType6)
        Me.pnlBottomBar.Controls.Add(Me.lblShowType5)
        Me.pnlBottomBar.Controls.Add(Me.ctlType5)
        Me.pnlBottomBar.Controls.Add(Me.lblShowType4)
        Me.pnlBottomBar.Controls.Add(Me.ctlType4)
        Me.pnlBottomBar.Controls.Add(Me.lblShowType3)
        Me.pnlBottomBar.Controls.Add(Me.ctlType3)
        Me.pnlBottomBar.Controls.Add(Me.lblShowType2)
        Me.pnlBottomBar.Controls.Add(Me.ctlType2)
        Me.pnlBottomBar.Controls.Add(Me.lblShowType1)
        Me.pnlBottomBar.Controls.Add(Me.ctlType1)
        Me.pnlBottomBar.Controls.Add(Me.cmdClose)
        Me.pnlBottomBar.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlBottomBar.Location = New System.Drawing.Point(878, 0)
        Me.pnlBottomBar.Margin = New System.Windows.Forms.Padding(6)
        Me.pnlBottomBar.Name = "pnlBottomBar"
        Me.pnlBottomBar.Padding = New System.Windows.Forms.Padding(6)
        Me.pnlBottomBar.Size = New System.Drawing.Size(107, 720)
        Me.pnlBottomBar.TabIndex = 59
        '
        'lblHalfDay
        '
        Me.lblHalfDay.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHalfDay.BackColor = System.Drawing.Color.Transparent
        Me.lblHalfDay.Location = New System.Drawing.Point(6, 73)
        Me.lblHalfDay.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.lblHalfDay.Name = "lblHalfDay"
        Me.lblHalfDay.Size = New System.Drawing.Size(89, 13)
        Me.lblHalfDay.TabIndex = 120
        Me.lblHalfDay.Text = "HalfDay"
        '
        'ctlHalfDay
        '
        Me.ctlHalfDay.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ctlHalfDay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ctlHalfDay.Location = New System.Drawing.Point(6, 92)
        Me.ctlHalfDay.Margin = New System.Windows.Forms.Padding(0)
        Me.ctlHalfDay.MaximumSize = New System.Drawing.Size(86, 30)
        Me.ctlHalfDay.MinimumSize = New System.Drawing.Size(43, 30)
        Me.ctlHalfDay.Name = "ctlHalfDay"
        Me.ctlHalfDay.Size = New System.Drawing.Size(86, 30)
        Me.ctlHalfDay.SwitchType = Capacity_Planning.ctlSwitch.enumSwitchType.OrangeYesWhiteNo
        Me.ctlHalfDay.TabIndex = 119
        Me.ctlHalfDay.Value = False
        '
        'lblWriteMode
        '
        Me.lblWriteMode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblWriteMode.BackColor = System.Drawing.Color.Transparent
        Me.lblWriteMode.Location = New System.Drawing.Point(6, 15)
        Me.lblWriteMode.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.lblWriteMode.Name = "lblWriteMode"
        Me.lblWriteMode.Size = New System.Drawing.Size(89, 13)
        Me.lblWriteMode.TabIndex = 118
        Me.lblWriteMode.Text = "Edit Mode"
        '
        'ctlEditMode
        '
        Me.ctlEditMode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ctlEditMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ctlEditMode.Location = New System.Drawing.Point(6, 34)
        Me.ctlEditMode.Margin = New System.Windows.Forms.Padding(0)
        Me.ctlEditMode.MaximumSize = New System.Drawing.Size(86, 30)
        Me.ctlEditMode.MinimumSize = New System.Drawing.Size(43, 30)
        Me.ctlEditMode.Name = "ctlEditMode"
        Me.ctlEditMode.Size = New System.Drawing.Size(86, 30)
        Me.ctlEditMode.SwitchType = Capacity_Planning.ctlSwitch.enumSwitchType.GreenYesWhiteNo
        Me.ctlEditMode.TabIndex = 117
        Me.ctlEditMode.Value = False
        '
        'lblShowType6
        '
        Me.lblShowType6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblShowType6.BackColor = System.Drawing.Color.Transparent
        Me.lblShowType6.Location = New System.Drawing.Point(6, 445)
        Me.lblShowType6.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.lblShowType6.Name = "lblShowType6"
        Me.lblShowType6.Size = New System.Drawing.Size(89, 13)
        Me.lblShowType6.TabIndex = 116
        Me.lblShowType6.Text = "Other"
        Me.lblShowType6.Visible = False
        '
        'ctlType6
        '
        Me.ctlType6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ctlType6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ctlType6.Location = New System.Drawing.Point(6, 464)
        Me.ctlType6.Margin = New System.Windows.Forms.Padding(0)
        Me.ctlType6.MaximumSize = New System.Drawing.Size(86, 30)
        Me.ctlType6.MinimumSize = New System.Drawing.Size(43, 30)
        Me.ctlType6.Name = "ctlType6"
        Me.ctlType6.Size = New System.Drawing.Size(86, 30)
        Me.ctlType6.SwitchType = Capacity_Planning.ctlSwitch.enumSwitchType.BlueOnWhiteOff
        Me.ctlType6.TabIndex = 115
        Me.ctlType6.Value = True
        Me.ctlType6.Visible = False
        '
        'lblShowType5
        '
        Me.lblShowType5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblShowType5.BackColor = System.Drawing.Color.Transparent
        Me.lblShowType5.Location = New System.Drawing.Point(6, 387)
        Me.lblShowType5.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.lblShowType5.Name = "lblShowType5"
        Me.lblShowType5.Size = New System.Drawing.Size(89, 13)
        Me.lblShowType5.TabIndex = 114
        Me.lblShowType5.Text = "Parental"
        Me.lblShowType5.Visible = False
        '
        'ctlType5
        '
        Me.ctlType5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ctlType5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ctlType5.Location = New System.Drawing.Point(6, 406)
        Me.ctlType5.Margin = New System.Windows.Forms.Padding(0)
        Me.ctlType5.MaximumSize = New System.Drawing.Size(86, 30)
        Me.ctlType5.MinimumSize = New System.Drawing.Size(43, 30)
        Me.ctlType5.Name = "ctlType5"
        Me.ctlType5.Size = New System.Drawing.Size(86, 30)
        Me.ctlType5.SwitchType = Capacity_Planning.ctlSwitch.enumSwitchType.BlueOnWhiteOff
        Me.ctlType5.TabIndex = 113
        Me.ctlType5.Value = True
        Me.ctlType5.Visible = False
        '
        'lblShowType4
        '
        Me.lblShowType4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblShowType4.BackColor = System.Drawing.Color.Transparent
        Me.lblShowType4.Location = New System.Drawing.Point(6, 329)
        Me.lblShowType4.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.lblShowType4.Name = "lblShowType4"
        Me.lblShowType4.Size = New System.Drawing.Size(89, 13)
        Me.lblShowType4.TabIndex = 112
        Me.lblShowType4.Text = "Other Holiday"
        Me.lblShowType4.Visible = False
        '
        'ctlType4
        '
        Me.ctlType4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ctlType4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ctlType4.Location = New System.Drawing.Point(6, 348)
        Me.ctlType4.Margin = New System.Windows.Forms.Padding(0)
        Me.ctlType4.MaximumSize = New System.Drawing.Size(86, 30)
        Me.ctlType4.MinimumSize = New System.Drawing.Size(43, 30)
        Me.ctlType4.Name = "ctlType4"
        Me.ctlType4.Size = New System.Drawing.Size(86, 30)
        Me.ctlType4.SwitchType = Capacity_Planning.ctlSwitch.enumSwitchType.BlueOnWhiteOff
        Me.ctlType4.TabIndex = 111
        Me.ctlType4.Value = True
        Me.ctlType4.Visible = False
        '
        'lblShowType3
        '
        Me.lblShowType3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblShowType3.BackColor = System.Drawing.Color.Transparent
        Me.lblShowType3.Location = New System.Drawing.Point(6, 271)
        Me.lblShowType3.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.lblShowType3.Name = "lblShowType3"
        Me.lblShowType3.Size = New System.Drawing.Size(89, 13)
        Me.lblShowType3.TabIndex = 110
        Me.lblShowType3.Text = "Training"
        Me.lblShowType3.Visible = False
        '
        'ctlType3
        '
        Me.ctlType3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ctlType3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ctlType3.Location = New System.Drawing.Point(6, 290)
        Me.ctlType3.Margin = New System.Windows.Forms.Padding(0)
        Me.ctlType3.MaximumSize = New System.Drawing.Size(86, 30)
        Me.ctlType3.MinimumSize = New System.Drawing.Size(43, 30)
        Me.ctlType3.Name = "ctlType3"
        Me.ctlType3.Size = New System.Drawing.Size(86, 30)
        Me.ctlType3.SwitchType = Capacity_Planning.ctlSwitch.enumSwitchType.BlueOnWhiteOff
        Me.ctlType3.TabIndex = 109
        Me.ctlType3.Value = True
        Me.ctlType3.Visible = False
        '
        'lblShowType2
        '
        Me.lblShowType2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblShowType2.BackColor = System.Drawing.Color.Transparent
        Me.lblShowType2.Location = New System.Drawing.Point(6, 213)
        Me.lblShowType2.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.lblShowType2.Name = "lblShowType2"
        Me.lblShowType2.Size = New System.Drawing.Size(89, 13)
        Me.lblShowType2.TabIndex = 108
        Me.lblShowType2.Text = "Sickness"
        Me.lblShowType2.Visible = False
        '
        'ctlType2
        '
        Me.ctlType2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ctlType2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ctlType2.Location = New System.Drawing.Point(6, 232)
        Me.ctlType2.Margin = New System.Windows.Forms.Padding(0)
        Me.ctlType2.MaximumSize = New System.Drawing.Size(86, 30)
        Me.ctlType2.MinimumSize = New System.Drawing.Size(43, 30)
        Me.ctlType2.Name = "ctlType2"
        Me.ctlType2.Size = New System.Drawing.Size(86, 30)
        Me.ctlType2.SwitchType = Capacity_Planning.ctlSwitch.enumSwitchType.BlueOnWhiteOff
        Me.ctlType2.TabIndex = 107
        Me.ctlType2.Value = True
        Me.ctlType2.Visible = False
        '
        'lblShowType1
        '
        Me.lblShowType1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblShowType1.BackColor = System.Drawing.Color.Transparent
        Me.lblShowType1.Location = New System.Drawing.Point(6, 155)
        Me.lblShowType1.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.lblShowType1.Name = "lblShowType1"
        Me.lblShowType1.Size = New System.Drawing.Size(89, 13)
        Me.lblShowType1.TabIndex = 106
        Me.lblShowType1.Text = "Holiday"
        Me.lblShowType1.Visible = False
        '
        'ctlType1
        '
        Me.ctlType1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ctlType1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ctlType1.Location = New System.Drawing.Point(6, 174)
        Me.ctlType1.Margin = New System.Windows.Forms.Padding(0)
        Me.ctlType1.MaximumSize = New System.Drawing.Size(86, 30)
        Me.ctlType1.MinimumSize = New System.Drawing.Size(43, 30)
        Me.ctlType1.Name = "ctlType1"
        Me.ctlType1.Size = New System.Drawing.Size(86, 30)
        Me.ctlType1.SwitchType = Capacity_Planning.ctlSwitch.enumSwitchType.BlueOnWhiteOff
        Me.ctlType1.TabIndex = 105
        Me.ctlType1.Value = True
        Me.ctlType1.Visible = False
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdClose.Location = New System.Drawing.Point(20, 682)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 3
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'cboTeams
        '
        Me.cboTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTeams.FormattingEnabled = True
        Me.cboTeams.Location = New System.Drawing.Point(162, 28)
        Me.cboTeams.Name = "cboTeams"
        Me.cboTeams.Size = New System.Drawing.Size(305, 21)
        Me.cboTeams.TabIndex = 70
        '
        'cboPeople
        '
        Me.cboPeople.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboPeople.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPeople.FormattingEnabled = True
        Me.cboPeople.Location = New System.Drawing.Point(473, 28)
        Me.cboPeople.Name = "cboPeople"
        Me.cboPeople.Size = New System.Drawing.Size(396, 21)
        Me.cboPeople.TabIndex = 71
        '
        'cboYear
        '
        Me.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.Location = New System.Drawing.Point(11, 28)
        Me.cboYear.Margin = New System.Windows.Forms.Padding(6)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(142, 21)
        Me.cboYear.TabIndex = 101
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.BackColor = System.Drawing.Color.Transparent
        Me.lblYear.Location = New System.Drawing.Point(8, 9)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(29, 13)
        Me.lblYear.TabIndex = 100
        Me.lblYear.Text = "Year"
        '
        'lblTeam
        '
        Me.lblTeam.AutoSize = True
        Me.lblTeam.BackColor = System.Drawing.Color.Transparent
        Me.lblTeam.Location = New System.Drawing.Point(160, 9)
        Me.lblTeam.Name = "lblTeam"
        Me.lblTeam.Size = New System.Drawing.Size(34, 13)
        Me.lblTeam.TabIndex = 102
        Me.lblTeam.Text = "Team"
        '
        'lblPerson
        '
        Me.lblPerson.AutoSize = True
        Me.lblPerson.BackColor = System.Drawing.Color.Transparent
        Me.lblPerson.Location = New System.Drawing.Point(470, 9)
        Me.lblPerson.Name = "lblPerson"
        Me.lblPerson.Size = New System.Drawing.Size(40, 13)
        Me.lblPerson.TabIndex = 103
        Me.lblPerson.Text = "Person"
        '
        'ctlYearView
        '
        Me.ctlYearView.ActiveDayColour = System.Drawing.Color.Orange
        Me.ctlYearView.ActiveYear = 2018
        Me.ctlYearView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ctlYearView.Colour1 = System.Drawing.Color.CornflowerBlue
        Me.ctlYearView.Colour2 = System.Drawing.Color.MediumAquamarine
        Me.ctlYearView.Colour3 = System.Drawing.Color.Firebrick
        Me.ctlYearView.Colour4 = System.Drawing.Color.Goldenrod
        Me.ctlYearView.Colour5 = System.Drawing.Color.Pink
        Me.ctlYearView.Colour6 = System.Drawing.Color.Silver
        Me.ctlYearView.Location = New System.Drawing.Point(11, 57)
        Me.ctlYearView.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ctlYearView.Name = "ctlYearView"
        Me.ctlYearView.OtherYearWeekdayColour = System.Drawing.Color.LightGray
        Me.ctlYearView.OtherYearWeekendColour = System.Drawing.Color.LightSteelBlue
        Me.ctlYearView.Size = New System.Drawing.Size(858, 652)
        Me.ctlYearView.TabIndex = 105
        Me.ctlYearView.ThisYearWeekdayColour = System.Drawing.Color.White
        Me.ctlYearView.ThisYearWeekendColour = System.Drawing.Color.PaleGoldenrod
        Me.ctlYearView.TodayColour = System.Drawing.Color.RoyalBlue
        Me.ctlYearView.TodayTextColour = System.Drawing.Color.White
        '
        'Holiday
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(985, 720)
        Me.Controls.Add(Me.ctlYearView)
        Me.Controls.Add(Me.lblPerson)
        Me.Controls.Add(Me.lblTeam)
        Me.Controls.Add(Me.cboYear)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.cboPeople)
        Me.Controls.Add(Me.cboTeams)
        Me.Controls.Add(Me.pnlBottomBar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Holiday"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Holiday"
        Me.pnlBottomBar.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlBottomBar As Panel
    Friend WithEvents cmdClose As Button
    Friend WithEvents cboTeams As ComboBox
    Friend WithEvents cboPeople As ComboBox
    Friend WithEvents cboYear As ComboBox
    Friend WithEvents lblYear As Label
    Friend WithEvents lblTeam As Label
    Friend WithEvents lblPerson As Label
    Friend WithEvents lblShowType2 As Label
    Friend WithEvents ctlType2 As ctlSwitch
    Friend WithEvents lblShowType1 As Label
    Friend WithEvents ctlType1 As ctlSwitch
    Friend WithEvents ctlYearView As ctlYearView
    Friend WithEvents lblShowType6 As Label
    Friend WithEvents ctlType6 As ctlSwitch
    Friend WithEvents lblShowType5 As Label
    Friend WithEvents ctlType5 As ctlSwitch
    Friend WithEvents lblShowType4 As Label
    Friend WithEvents ctlType4 As ctlSwitch
    Friend WithEvents lblShowType3 As Label
    Friend WithEvents ctlType3 As ctlSwitch
    Friend WithEvents lblHalfDay As Label
    Friend WithEvents ctlHalfDay As ctlSwitch
    Friend WithEvents lblWriteMode As Label
    Friend WithEvents ctlEditMode As ctlSwitch
End Class
