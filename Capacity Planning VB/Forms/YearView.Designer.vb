<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class YearView
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
        Me.components = New System.ComponentModel.Container()
        Me.pnlTopBar = New System.Windows.Forms.Panel()
        Me.cmdYearUp = New System.Windows.Forms.Button()
        Me.cmdYearDown = New System.Windows.Forms.Button()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.TblTeamBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.pnlBottomBar = New System.Windows.Forms.Panel()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.ctlYearView = New Capacity_Planning.ctlYearView()
        Me.pnlOnRight = New System.Windows.Forms.Panel()
        Me.pnlTopBar.SuspendLayout()
        CType(Me.TblTeamBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBottomBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTopBar
        '
        Me.pnlTopBar.Controls.Add(Me.cmdYearUp)
        Me.pnlTopBar.Controls.Add(Me.cmdYearDown)
        Me.pnlTopBar.Controls.Add(Me.lblYear)
        Me.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopBar.Location = New System.Drawing.Point(1, 1)
        Me.pnlTopBar.Name = "pnlTopBar"
        Me.pnlTopBar.Padding = New System.Windows.Forms.Padding(6)
        Me.pnlTopBar.Size = New System.Drawing.Size(1130, 30)
        Me.pnlTopBar.TabIndex = 1
        '
        'cmdYearUp
        '
        Me.cmdYearUp.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cmdYearUp.Location = New System.Drawing.Point(153, 3)
        Me.cmdYearUp.Name = "cmdYearUp"
        Me.cmdYearUp.Size = New System.Drawing.Size(23, 23)
        Me.cmdYearUp.TabIndex = 4
        Me.cmdYearUp.Text = "+"
        Me.cmdYearUp.UseVisualStyleBackColor = False
        '
        'cmdYearDown
        '
        Me.cmdYearDown.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cmdYearDown.Location = New System.Drawing.Point(3, 3)
        Me.cmdYearDown.Name = "cmdYearDown"
        Me.cmdYearDown.Size = New System.Drawing.Size(23, 23)
        Me.cmdYearDown.TabIndex = 3
        Me.cmdYearDown.Text = "-"
        Me.cmdYearDown.UseVisualStyleBackColor = False
        '
        'lblYear
        '
        Me.lblYear.Location = New System.Drawing.Point(32, 3)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(115, 23)
        Me.lblYear.TabIndex = 2
        Me.lblYear.Text = "2017"
        Me.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlBottomBar
        '
        Me.pnlBottomBar.BackColor = System.Drawing.Color.Transparent
        Me.pnlBottomBar.Controls.Add(Me.cmdClose)
        Me.pnlBottomBar.Controls.Add(Me.lblCopyright)
        Me.pnlBottomBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottomBar.Location = New System.Drawing.Point(1, 530)
        Me.pnlBottomBar.Margin = New System.Windows.Forms.Padding(6)
        Me.pnlBottomBar.Name = "pnlBottomBar"
        Me.pnlBottomBar.Size = New System.Drawing.Size(1130, 57)
        Me.pnlBottomBar.TabIndex = 60
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdClose.Location = New System.Drawing.Point(1040, 19)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 62
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = False
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
        'ctlYearView
        '
        Me.ctlYearView.ActiveDayColour = System.Drawing.Color.Orange
        Me.ctlYearView.ActiveYear = 2017
        Me.ctlYearView.Colour1 = System.Drawing.Color.Empty
        Me.ctlYearView.Colour2 = System.Drawing.Color.Empty
        Me.ctlYearView.Colour3 = System.Drawing.Color.Empty
        Me.ctlYearView.Colour4 = System.Drawing.Color.Empty
        Me.ctlYearView.Colour5 = System.Drawing.Color.Empty
        Me.ctlYearView.Colour6 = System.Drawing.Color.Empty
        Me.ctlYearView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ctlYearView.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ctlYearView.Location = New System.Drawing.Point(1, 31)
        Me.ctlYearView.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ctlYearView.Name = "ctlYearView"
        Me.ctlYearView.OtherYearWeekdayColour = System.Drawing.Color.LightGray
        Me.ctlYearView.OtherYearWeekendColour = System.Drawing.Color.LightSteelBlue
        Me.ctlYearView.Size = New System.Drawing.Size(939, 499)
        Me.ctlYearView.TabIndex = 61
        Me.ctlYearView.ThisYearWeekdayColour = System.Drawing.Color.White
        Me.ctlYearView.ThisYearWeekendColour = System.Drawing.Color.PaleGoldenrod
        Me.ctlYearView.TodayColour = System.Drawing.Color.RoyalBlue
        Me.ctlYearView.TodayTextColour = System.Drawing.Color.White
        '
        'pnlOnRight
        '
        Me.pnlOnRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlOnRight.Location = New System.Drawing.Point(940, 31)
        Me.pnlOnRight.Name = "pnlOnRight"
        Me.pnlOnRight.Size = New System.Drawing.Size(191, 499)
        Me.pnlOnRight.TabIndex = 62
        '
        'YearView
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1132, 588)
        Me.Controls.Add(Me.ctlYearView)
        Me.Controls.Add(Me.pnlOnRight)
        Me.Controls.Add(Me.pnlBottomBar)
        Me.Controls.Add(Me.pnlTopBar)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Name = "YearView"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Year Calendar 2017"
        Me.pnlTopBar.ResumeLayout(False)
        CType(Me.TblTeamBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBottomBar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTopBar As Panel
    Friend WithEvents cmdYearUp As Button
    Friend WithEvents cmdYearDown As Button
    Friend WithEvents lblYear As Label
    Friend WithEvents TblTeamBindingSource As BindingSource
    Friend WithEvents pnlBottomBar As Panel
    Friend WithEvents lblCopyright As Label
    Friend WithEvents ctlYearView As ctlYearView
    Friend WithEvents cmdClose As Button
    Friend WithEvents pnlOnRight As Panel
End Class
