<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.ctlSprint = New Capacity_Planning.ctlBigButton()
        Me.ctlTeam = New Capacity_Planning.ctlBigButton()
        Me.ctlVelocity = New Capacity_Planning.ctlBigButton()
        Me.ctlCapacityPlan = New Capacity_Planning.ctlBigButton()
        Me.ctlCalendar = New Capacity_Planning.ctlBigButton()
        Me.pnlBottomBar = New System.Windows.Forms.Panel()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.cmdAbout = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.ctlReport = New Capacity_Planning.ctlBigButton()
        Me.ctlLocations = New Capacity_Planning.ctlBigButton()
        Me.lblTeamsTitle = New System.Windows.Forms.Label()
        Me.pnlBottomBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'ctlSprint
        '
        Me.ctlSprint.BackColor = System.Drawing.Color.Transparent
        Me.ctlSprint.ColourHighlight = System.Drawing.Color.Lavender
        Me.ctlSprint.Image = CType(resources.GetObject("ctlSprint.Image"), System.Drawing.Image)
        Me.ctlSprint.Location = New System.Drawing.Point(334, 149)
        Me.ctlSprint.Margin = New System.Windows.Forms.Padding(18)
        Me.ctlSprint.MaximumSize = New System.Drawing.Size(388, 122)
        Me.ctlSprint.MinimumSize = New System.Drawing.Size(236, 68)
        Me.ctlSprint.Name = "ctlSprint"
        Me.ctlSprint.Selected = False
        Me.ctlSprint.Size = New System.Drawing.Size(271, 86)
        Me.ctlSprint.TabIndex = 5
        Me.ctlSprint.TextDescription = "Setup Sprints and their regular cadence"
        Me.ctlSprint.TextTitle = "Sprints"
        '
        'ctlTeam
        '
        Me.ctlTeam.BackColor = System.Drawing.Color.Transparent
        Me.ctlTeam.ColourHighlight = System.Drawing.Color.Lavender
        Me.ctlTeam.Image = CType(resources.GetObject("ctlTeam.Image"), System.Drawing.Image)
        Me.ctlTeam.Location = New System.Drawing.Point(27, 149)
        Me.ctlTeam.Margin = New System.Windows.Forms.Padding(18)
        Me.ctlTeam.MaximumSize = New System.Drawing.Size(388, 122)
        Me.ctlTeam.MinimumSize = New System.Drawing.Size(236, 68)
        Me.ctlTeam.Name = "ctlTeam"
        Me.ctlTeam.Selected = False
        Me.ctlTeam.Size = New System.Drawing.Size(271, 86)
        Me.ctlTeam.TabIndex = 4
        Me.ctlTeam.TextDescription = "Setup Teams and the team members"
        Me.ctlTeam.TextTitle = "Teams / People"
        '
        'ctlVelocity
        '
        Me.ctlVelocity.BackColor = System.Drawing.Color.Transparent
        Me.ctlVelocity.ColourHighlight = System.Drawing.Color.Lavender
        Me.ctlVelocity.Image = CType(resources.GetObject("ctlVelocity.Image"), System.Drawing.Image)
        Me.ctlVelocity.Location = New System.Drawing.Point(334, 27)
        Me.ctlVelocity.Margin = New System.Windows.Forms.Padding(18)
        Me.ctlVelocity.MaximumSize = New System.Drawing.Size(388, 122)
        Me.ctlVelocity.MinimumSize = New System.Drawing.Size(236, 68)
        Me.ctlVelocity.Name = "ctlVelocity"
        Me.ctlVelocity.Selected = False
        Me.ctlVelocity.Size = New System.Drawing.Size(271, 86)
        Me.ctlVelocity.TabIndex = 2
        Me.ctlVelocity.TextDescription = "Enter the velocity achieved by teams"
        Me.ctlVelocity.TextTitle = "Actual Velocity"
        '
        'ctlCapacityPlan
        '
        Me.ctlCapacityPlan.BackColor = System.Drawing.Color.Transparent
        Me.ctlCapacityPlan.ColourHighlight = System.Drawing.Color.Lavender
        Me.ctlCapacityPlan.Image = CType(resources.GetObject("ctlCapacityPlan.Image"), System.Drawing.Image)
        Me.ctlCapacityPlan.Location = New System.Drawing.Point(27, 27)
        Me.ctlCapacityPlan.Margin = New System.Windows.Forms.Padding(18)
        Me.ctlCapacityPlan.MaximumSize = New System.Drawing.Size(388, 122)
        Me.ctlCapacityPlan.MinimumSize = New System.Drawing.Size(236, 68)
        Me.ctlCapacityPlan.Name = "ctlCapacityPlan"
        Me.ctlCapacityPlan.Selected = False
        Me.ctlCapacityPlan.Size = New System.Drawing.Size(271, 86)
        Me.ctlCapacityPlan.TabIndex = 1
        Me.ctlCapacityPlan.TextDescription = "Current and past capacity plans"
        Me.ctlCapacityPlan.TextTitle = "Capacity Plans"
        '
        'ctlCalendar
        '
        Me.ctlCalendar.BackColor = System.Drawing.Color.Transparent
        Me.ctlCalendar.ColourHighlight = System.Drawing.Color.Lavender
        Me.ctlCalendar.Image = CType(resources.GetObject("ctlCalendar.Image"), System.Drawing.Image)
        Me.ctlCalendar.Location = New System.Drawing.Point(641, 27)
        Me.ctlCalendar.Margin = New System.Windows.Forms.Padding(18)
        Me.ctlCalendar.MaximumSize = New System.Drawing.Size(388, 122)
        Me.ctlCalendar.MinimumSize = New System.Drawing.Size(236, 68)
        Me.ctlCalendar.Name = "ctlCalendar"
        Me.ctlCalendar.Selected = False
        Me.ctlCalendar.Size = New System.Drawing.Size(271, 86)
        Me.ctlCalendar.TabIndex = 3
        Me.ctlCalendar.TextDescription = "Enter holidays and other absences for both teams and individuals"
        Me.ctlCalendar.TextTitle = "Holidays / Sickness"
        '
        'pnlBottomBar
        '
        Me.pnlBottomBar.BackColor = System.Drawing.Color.Transparent
        Me.pnlBottomBar.Controls.Add(Me.lblCopyright)
        Me.pnlBottomBar.Controls.Add(Me.cmdAbout)
        Me.pnlBottomBar.Controls.Add(Me.cmdClose)
        Me.pnlBottomBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottomBar.Location = New System.Drawing.Point(0, 388)
        Me.pnlBottomBar.Margin = New System.Windows.Forms.Padding(6)
        Me.pnlBottomBar.Name = "pnlBottomBar"
        Me.pnlBottomBar.Size = New System.Drawing.Size(924, 57)
        Me.pnlBottomBar.TabIndex = 66
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
        Me.lblCopyright.TabIndex = 62
        Me.lblCopyright.Text = "© Paul Panayis, 2018"
        Me.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdAbout
        '
        Me.cmdAbout.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAbout.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAbout.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAbout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdAbout.Location = New System.Drawing.Point(747, 19)
        Me.cmdAbout.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdAbout.Name = "cmdAbout"
        Me.cmdAbout.Size = New System.Drawing.Size(75, 23)
        Me.cmdAbout.TabIndex = 9
        Me.cmdAbout.Text = "About"
        Me.cmdAbout.UseVisualStyleBackColor = False
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdClose.Location = New System.Drawing.Point(834, 19)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 0
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'ctlReport
        '
        Me.ctlReport.BackColor = System.Drawing.Color.Transparent
        Me.ctlReport.ColourHighlight = System.Drawing.Color.Lavender
        Me.ctlReport.Image = CType(resources.GetObject("ctlReport.Image"), System.Drawing.Image)
        Me.ctlReport.Location = New System.Drawing.Point(27, 271)
        Me.ctlReport.Margin = New System.Windows.Forms.Padding(18)
        Me.ctlReport.MaximumSize = New System.Drawing.Size(271, 86)
        Me.ctlReport.MinimumSize = New System.Drawing.Size(271, 86)
        Me.ctlReport.Name = "ctlReport"
        Me.ctlReport.Selected = False
        Me.ctlReport.Size = New System.Drawing.Size(271, 86)
        Me.ctlReport.TabIndex = 7
        Me.ctlReport.TextDescription = "Run, Export and Print all management and team reports"
        Me.ctlReport.TextTitle = "Reports"
        '
        'ctlLocations
        '
        Me.ctlLocations.BackColor = System.Drawing.Color.Transparent
        Me.ctlLocations.ColourHighlight = System.Drawing.Color.Lavender
        Me.ctlLocations.Image = CType(resources.GetObject("ctlLocations.Image"), System.Drawing.Image)
        Me.ctlLocations.Location = New System.Drawing.Point(641, 149)
        Me.ctlLocations.Margin = New System.Windows.Forms.Padding(18)
        Me.ctlLocations.MaximumSize = New System.Drawing.Size(388, 122)
        Me.ctlLocations.MinimumSize = New System.Drawing.Size(236, 68)
        Me.ctlLocations.Name = "ctlLocations"
        Me.ctlLocations.Selected = False
        Me.ctlLocations.Size = New System.Drawing.Size(271, 86)
        Me.ctlLocations.TabIndex = 6
        Me.ctlLocations.TextDescription = "Setup Locations for your teams. Team events and holidays are by Location"
        Me.ctlLocations.TextTitle = "Locations"
        '
        'lblTeamsTitle
        '
        Me.lblTeamsTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTeamsTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTeamsTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeamsTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.lblTeamsTitle.Location = New System.Drawing.Point(431, 296)
        Me.lblTeamsTitle.Name = "lblTeamsTitle"
        Me.lblTeamsTitle.Size = New System.Drawing.Size(493, 61)
        Me.lblTeamsTitle.TabIndex = 76
        Me.lblTeamsTitle.Text = "capacity planning tool"
        Me.lblTeamsTitle.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'MainMenu
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(924, 445)
        Me.Controls.Add(Me.lblTeamsTitle)
        Me.Controls.Add(Me.ctlLocations)
        Me.Controls.Add(Me.ctlReport)
        Me.Controls.Add(Me.pnlBottomBar)
        Me.Controls.Add(Me.ctlSprint)
        Me.Controls.Add(Me.ctlTeam)
        Me.Controls.Add(Me.ctlVelocity)
        Me.Controls.Add(Me.ctlCapacityPlan)
        Me.Controls.Add(Me.ctlCalendar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Capacity Planning Tool"
        Me.pnlBottomBar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ctlCalendar As ctlBigButton
    Friend WithEvents ctlCapacityPlan As ctlBigButton
    Friend WithEvents ctlVelocity As ctlBigButton
    Friend WithEvents ctlTeam As ctlBigButton
    Friend WithEvents ctlSprint As ctlBigButton
    Friend WithEvents pnlBottomBar As Panel
    Friend WithEvents cmdClose As Button
    Friend WithEvents cmdAbout As Button
    Friend WithEvents ctlReport As ctlBigButton
    Friend WithEvents ctlLocations As ctlBigButton
    Friend WithEvents lblCopyright As Label
    Friend WithEvents lblTeamsTitle As Label
End Class
