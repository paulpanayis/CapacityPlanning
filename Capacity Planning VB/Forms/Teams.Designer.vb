<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Teams
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Teams))
        Me.pnlBottomBar = New System.Windows.Forms.Panel()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.lvwPeople = New System.Windows.Forms.ListView()
        Me.tabMain = New System.Windows.Forms.TabControl()
        Me.tabTeams = New System.Windows.Forms.TabPage()
        Me.ctlDeleteSprintTeam = New Capacity_Planning.ctlRichButtonSmall()
        Me.cboSprintTemplate = New System.Windows.Forms.ComboBox()
        Me.lblSprintTemplate = New System.Windows.Forms.Label()
        Me.cboTeamLocation = New System.Windows.Forms.ComboBox()
        Me.lbllocation = New System.Windows.Forms.Label()
        Me.txtTeamName = New System.Windows.Forms.TextBox()
        Me.lblTeamName = New System.Windows.Forms.Label()
        Me.ctlAddTeam = New Capacity_Planning.ctlRichButtonSmall()
        Me.lvwTeams = New System.Windows.Forms.ListView()
        Me.lblTeamsTitle = New System.Windows.Forms.Label()
        Me.tabPeople = New System.Windows.Forms.TabPage()
        Me.ctlDeletePerson = New Capacity_Planning.ctlRichButtonSmall()
        Me.cboPersonTeam = New System.Windows.Forms.ComboBox()
        Me.lblPersonTeam = New System.Windows.Forms.Label()
        Me.txtPersonName = New System.Windows.Forms.TextBox()
        Me.lblPersonName = New System.Windows.Forms.Label()
        Me.cboTeams = New System.Windows.Forms.ComboBox()
        Me.lblPeopleTitle = New System.Windows.Forms.Label()
        Me.ctlAddPerson = New Capacity_Planning.ctlRichButtonSmall()
        Me.tmrPersonSave = New System.Windows.Forms.Timer(Me.components)
        Me.tmrTeamSave = New System.Windows.Forms.Timer(Me.components)
        Me.pnlBottomBar.SuspendLayout()
        Me.tabMain.SuspendLayout()
        Me.tabTeams.SuspendLayout()
        Me.tabPeople.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBottomBar
        '
        Me.pnlBottomBar.BackColor = System.Drawing.Color.Transparent
        Me.pnlBottomBar.Controls.Add(Me.lblCopyright)
        Me.pnlBottomBar.Controls.Add(Me.cmdClose)
        Me.pnlBottomBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottomBar.Location = New System.Drawing.Point(0, 588)
        Me.pnlBottomBar.Margin = New System.Windows.Forms.Padding(6)
        Me.pnlBottomBar.Name = "pnlBottomBar"
        Me.pnlBottomBar.Size = New System.Drawing.Size(842, 57)
        Me.pnlBottomBar.TabIndex = 59
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
        Me.cmdClose.Location = New System.Drawing.Point(705, 13)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(122, 29)
        Me.cmdClose.TabIndex = 3
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'lvwPeople
        '
        Me.lvwPeople.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwPeople.FullRowSelect = True
        Me.lvwPeople.HideSelection = False
        Me.lvwPeople.Location = New System.Drawing.Point(9, 42)
        Me.lvwPeople.Margin = New System.Windows.Forms.Padding(6)
        Me.lvwPeople.MultiSelect = False
        Me.lvwPeople.Name = "lvwPeople"
        Me.lvwPeople.Size = New System.Drawing.Size(686, 405)
        Me.lvwPeople.TabIndex = 63
        Me.lvwPeople.UseCompatibleStateImageBehavior = False
        Me.lvwPeople.View = System.Windows.Forms.View.Details
        '
        'tabMain
        '
        Me.tabMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabMain.Controls.Add(Me.tabTeams)
        Me.tabMain.Controls.Add(Me.tabPeople)
        Me.tabMain.Location = New System.Drawing.Point(12, 12)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedIndex = 0
        Me.tabMain.Size = New System.Drawing.Size(818, 567)
        Me.tabMain.TabIndex = 69
        '
        'tabTeams
        '
        Me.tabTeams.Controls.Add(Me.ctlDeleteSprintTeam)
        Me.tabTeams.Controls.Add(Me.cboSprintTemplate)
        Me.tabTeams.Controls.Add(Me.lblSprintTemplate)
        Me.tabTeams.Controls.Add(Me.cboTeamLocation)
        Me.tabTeams.Controls.Add(Me.lbllocation)
        Me.tabTeams.Controls.Add(Me.txtTeamName)
        Me.tabTeams.Controls.Add(Me.lblTeamName)
        Me.tabTeams.Controls.Add(Me.ctlAddTeam)
        Me.tabTeams.Controls.Add(Me.lvwTeams)
        Me.tabTeams.Controls.Add(Me.lblTeamsTitle)
        Me.tabTeams.Location = New System.Drawing.Point(4, 22)
        Me.tabTeams.Name = "tabTeams"
        Me.tabTeams.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTeams.Size = New System.Drawing.Size(810, 541)
        Me.tabTeams.TabIndex = 0
        Me.tabTeams.Text = "Teams"
        Me.tabTeams.UseVisualStyleBackColor = True
        '
        'ctlDeleteSprintTeam
        '
        Me.ctlDeleteSprintTeam.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ctlDeleteSprintTeam.BackColor = System.Drawing.Color.Transparent
        Me.ctlDeleteSprintTeam.ColourHighlight = System.Drawing.Color.Lavender
        Me.ctlDeleteSprintTeam.Image = CType(resources.GetObject("ctlDeleteSprintTeam.Image"), System.Drawing.Image)
        Me.ctlDeleteSprintTeam.Location = New System.Drawing.Point(457, 413)
        Me.ctlDeleteSprintTeam.MaximumSize = New System.Drawing.Size(0, 38)
        Me.ctlDeleteSprintTeam.MinimumSize = New System.Drawing.Size(100, 38)
        Me.ctlDeleteSprintTeam.Name = "ctlDeleteSprintTeam"
        Me.ctlDeleteSprintTeam.Selected = False
        Me.ctlDeleteSprintTeam.Size = New System.Drawing.Size(100, 38)
        Me.ctlDeleteSprintTeam.TabIndex = 82
        Me.ctlDeleteSprintTeam.TextDescription = "Team"
        Me.ctlDeleteSprintTeam.TextTitle = "Delete"
        '
        'cboSprintTemplate
        '
        Me.cboSprintTemplate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboSprintTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSprintTemplate.FormattingEnabled = True
        Me.cboSprintTemplate.Location = New System.Drawing.Point(9, 514)
        Me.cboSprintTemplate.Name = "cboSprintTemplate"
        Me.cboSprintTemplate.Size = New System.Drawing.Size(439, 21)
        Me.cboSprintTemplate.TabIndex = 81
        '
        'lblSprintTemplate
        '
        Me.lblSprintTemplate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSprintTemplate.AutoSize = True
        Me.lblSprintTemplate.BackColor = System.Drawing.Color.Transparent
        Me.lblSprintTemplate.Location = New System.Drawing.Point(6, 498)
        Me.lblSprintTemplate.Name = "lblSprintTemplate"
        Me.lblSprintTemplate.Size = New System.Drawing.Size(81, 13)
        Me.lblSprintTemplate.TabIndex = 80
        Me.lblSprintTemplate.Text = "Sprint Template"
        '
        'cboTeamLocation
        '
        Me.cboTeamLocation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTeamLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTeamLocation.FormattingEnabled = True
        Me.cboTeamLocation.Location = New System.Drawing.Point(9, 471)
        Me.cboTeamLocation.Name = "cboTeamLocation"
        Me.cboTeamLocation.Size = New System.Drawing.Size(439, 21)
        Me.cboTeamLocation.TabIndex = 79
        '
        'lbllocation
        '
        Me.lbllocation.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbllocation.AutoSize = True
        Me.lbllocation.BackColor = System.Drawing.Color.Transparent
        Me.lbllocation.Location = New System.Drawing.Point(6, 455)
        Me.lbllocation.Name = "lbllocation"
        Me.lbllocation.Size = New System.Drawing.Size(48, 13)
        Me.lbllocation.TabIndex = 78
        Me.lbllocation.Text = "Location"
        '
        'txtTeamName
        '
        Me.txtTeamName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTeamName.Location = New System.Drawing.Point(9, 429)
        Me.txtTeamName.Margin = New System.Windows.Forms.Padding(6)
        Me.txtTeamName.Name = "txtTeamName"
        Me.txtTeamName.Size = New System.Drawing.Size(439, 20)
        Me.txtTeamName.TabIndex = 76
        '
        'lblTeamName
        '
        Me.lblTeamName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTeamName.AutoSize = True
        Me.lblTeamName.BackColor = System.Drawing.Color.Transparent
        Me.lblTeamName.Location = New System.Drawing.Point(6, 410)
        Me.lblTeamName.Name = "lblTeamName"
        Me.lblTeamName.Size = New System.Drawing.Size(65, 13)
        Me.lblTeamName.TabIndex = 77
        Me.lblTeamName.Text = "Team Name"
        '
        'ctlAddTeam
        '
        Me.ctlAddTeam.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ctlAddTeam.BackColor = System.Drawing.Color.Transparent
        Me.ctlAddTeam.ColourHighlight = System.Drawing.Color.Lavender
        Me.ctlAddTeam.Image = CType(resources.GetObject("ctlAddTeam.Image"), System.Drawing.Image)
        Me.ctlAddTeam.Location = New System.Drawing.Point(704, 6)
        Me.ctlAddTeam.MaximumSize = New System.Drawing.Size(0, 38)
        Me.ctlAddTeam.MinimumSize = New System.Drawing.Size(100, 38)
        Me.ctlAddTeam.Name = "ctlAddTeam"
        Me.ctlAddTeam.Selected = False
        Me.ctlAddTeam.Size = New System.Drawing.Size(100, 38)
        Me.ctlAddTeam.TabIndex = 64
        Me.ctlAddTeam.TextDescription = "Team"
        Me.ctlAddTeam.TextTitle = "New"
        '
        'lvwTeams
        '
        Me.lvwTeams.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwTeams.FullRowSelect = True
        Me.lvwTeams.HideSelection = False
        Me.lvwTeams.Location = New System.Drawing.Point(9, 9)
        Me.lvwTeams.Margin = New System.Windows.Forms.Padding(6)
        Me.lvwTeams.MultiSelect = False
        Me.lvwTeams.Name = "lvwTeams"
        Me.lvwTeams.Size = New System.Drawing.Size(686, 395)
        Me.lvwTeams.TabIndex = 63
        Me.lvwTeams.UseCompatibleStateImageBehavior = False
        Me.lvwTeams.View = System.Windows.Forms.View.Details
        '
        'lblTeamsTitle
        '
        Me.lblTeamsTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTeamsTitle.AutoSize = True
        Me.lblTeamsTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTeamsTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeamsTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.lblTeamsTitle.Location = New System.Drawing.Point(603, 394)
        Me.lblTeamsTitle.Name = "lblTeamsTitle"
        Me.lblTeamsTitle.Size = New System.Drawing.Size(155, 55)
        Me.lblTeamsTitle.TabIndex = 75
        Me.lblTeamsTitle.Text = "teams"
        '
        'tabPeople
        '
        Me.tabPeople.Controls.Add(Me.ctlDeletePerson)
        Me.tabPeople.Controls.Add(Me.cboPersonTeam)
        Me.tabPeople.Controls.Add(Me.lblPersonTeam)
        Me.tabPeople.Controls.Add(Me.txtPersonName)
        Me.tabPeople.Controls.Add(Me.lblPersonName)
        Me.tabPeople.Controls.Add(Me.cboTeams)
        Me.tabPeople.Controls.Add(Me.lvwPeople)
        Me.tabPeople.Controls.Add(Me.lblPeopleTitle)
        Me.tabPeople.Controls.Add(Me.ctlAddPerson)
        Me.tabPeople.ForeColor = System.Drawing.Color.Blue
        Me.tabPeople.Location = New System.Drawing.Point(4, 22)
        Me.tabPeople.Name = "tabPeople"
        Me.tabPeople.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPeople.Size = New System.Drawing.Size(810, 541)
        Me.tabPeople.TabIndex = 1
        Me.tabPeople.Text = "People"
        Me.tabPeople.UseVisualStyleBackColor = True
        '
        'ctlDeletePerson
        '
        Me.ctlDeletePerson.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ctlDeletePerson.BackColor = System.Drawing.Color.Transparent
        Me.ctlDeletePerson.ColourHighlight = System.Drawing.Color.Lavender
        Me.ctlDeletePerson.Image = CType(resources.GetObject("ctlDeletePerson.Image"), System.Drawing.Image)
        Me.ctlDeletePerson.Location = New System.Drawing.Point(457, 456)
        Me.ctlDeletePerson.MaximumSize = New System.Drawing.Size(0, 38)
        Me.ctlDeletePerson.MinimumSize = New System.Drawing.Size(100, 38)
        Me.ctlDeletePerson.Name = "ctlDeletePerson"
        Me.ctlDeletePerson.Selected = False
        Me.ctlDeletePerson.Size = New System.Drawing.Size(100, 38)
        Me.ctlDeletePerson.TabIndex = 85
        Me.ctlDeletePerson.TextDescription = "Person"
        Me.ctlDeletePerson.TextTitle = "Delete"
        '
        'cboPersonTeam
        '
        Me.cboPersonTeam.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboPersonTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPersonTeam.FormattingEnabled = True
        Me.cboPersonTeam.Location = New System.Drawing.Point(9, 514)
        Me.cboPersonTeam.Name = "cboPersonTeam"
        Me.cboPersonTeam.Size = New System.Drawing.Size(439, 21)
        Me.cboPersonTeam.TabIndex = 83
        '
        'lblPersonTeam
        '
        Me.lblPersonTeam.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPersonTeam.AutoSize = True
        Me.lblPersonTeam.BackColor = System.Drawing.Color.Transparent
        Me.lblPersonTeam.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPersonTeam.Location = New System.Drawing.Point(6, 498)
        Me.lblPersonTeam.Name = "lblPersonTeam"
        Me.lblPersonTeam.Size = New System.Drawing.Size(34, 13)
        Me.lblPersonTeam.TabIndex = 82
        Me.lblPersonTeam.Text = "Team"
        '
        'txtPersonName
        '
        Me.txtPersonName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPersonName.Location = New System.Drawing.Point(9, 472)
        Me.txtPersonName.Margin = New System.Windows.Forms.Padding(6)
        Me.txtPersonName.Name = "txtPersonName"
        Me.txtPersonName.Size = New System.Drawing.Size(439, 20)
        Me.txtPersonName.TabIndex = 80
        '
        'lblPersonName
        '
        Me.lblPersonName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPersonName.AutoSize = True
        Me.lblPersonName.BackColor = System.Drawing.Color.Transparent
        Me.lblPersonName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPersonName.Location = New System.Drawing.Point(6, 453)
        Me.lblPersonName.Name = "lblPersonName"
        Me.lblPersonName.Size = New System.Drawing.Size(35, 13)
        Me.lblPersonName.TabIndex = 81
        Me.lblPersonName.Text = "Name"
        '
        'cboTeams
        '
        Me.cboTeams.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTeams.FormattingEnabled = True
        Me.cboTeams.Location = New System.Drawing.Point(9, 12)
        Me.cboTeams.Name = "cboTeams"
        Me.cboTeams.Size = New System.Drawing.Size(686, 21)
        Me.cboTeams.TabIndex = 69
        '
        'lblPeopleTitle
        '
        Me.lblPeopleTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPeopleTitle.AutoSize = True
        Me.lblPeopleTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblPeopleTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeopleTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.lblPeopleTitle.Location = New System.Drawing.Point(586, 437)
        Me.lblPeopleTitle.Name = "lblPeopleTitle"
        Me.lblPeopleTitle.Size = New System.Drawing.Size(169, 55)
        Me.lblPeopleTitle.TabIndex = 84
        Me.lblPeopleTitle.Text = "people"
        '
        'ctlAddPerson
        '
        Me.ctlAddPerson.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ctlAddPerson.BackColor = System.Drawing.Color.Transparent
        Me.ctlAddPerson.ColourHighlight = System.Drawing.Color.Lavender
        Me.ctlAddPerson.Image = CType(resources.GetObject("ctlAddPerson.Image"), System.Drawing.Image)
        Me.ctlAddPerson.Location = New System.Drawing.Point(704, 6)
        Me.ctlAddPerson.MaximumSize = New System.Drawing.Size(0, 38)
        Me.ctlAddPerson.MinimumSize = New System.Drawing.Size(100, 38)
        Me.ctlAddPerson.Name = "ctlAddPerson"
        Me.ctlAddPerson.Selected = False
        Me.ctlAddPerson.Size = New System.Drawing.Size(100, 38)
        Me.ctlAddPerson.TabIndex = 66
        Me.ctlAddPerson.TextDescription = "Person"
        Me.ctlAddPerson.TextTitle = "New"
        '
        'tmrPersonSave
        '
        Me.tmrPersonSave.Interval = 1000
        '
        'tmrTeamSave
        '
        Me.tmrTeamSave.Interval = 1000
        '
        'Teams
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(842, 645)
        Me.Controls.Add(Me.tabMain)
        Me.Controls.Add(Me.pnlBottomBar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Teams"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Teams"
        Me.pnlBottomBar.ResumeLayout(False)
        Me.tabMain.ResumeLayout(False)
        Me.tabTeams.ResumeLayout(False)
        Me.tabTeams.PerformLayout()
        Me.tabPeople.ResumeLayout(False)
        Me.tabPeople.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlBottomBar As Panel
    Friend WithEvents lblCopyright As Label
    Friend WithEvents cmdClose As Button
    Friend WithEvents lvwPeople As ListView
    Friend WithEvents ctlAddPerson As ctlRichButtonSmall
    Friend WithEvents tabMain As TabControl
    Friend WithEvents tabTeams As TabPage
    Friend WithEvents ctlAddTeam As ctlRichButtonSmall
    Friend WithEvents lvwTeams As ListView
    Friend WithEvents tabPeople As TabPage
    Friend WithEvents cboTeams As ComboBox
    Friend WithEvents cboSprintTemplate As ComboBox
    Friend WithEvents lblSprintTemplate As Label
    Friend WithEvents cboTeamLocation As ComboBox
    Friend WithEvents lbllocation As Label
    Friend WithEvents txtTeamName As TextBox
    Friend WithEvents lblTeamName As Label
    Friend WithEvents lblTeamsTitle As Label
    Friend WithEvents cboPersonTeam As ComboBox
    Friend WithEvents lblPersonTeam As Label
    Friend WithEvents txtPersonName As TextBox
    Friend WithEvents lblPersonName As Label
    Friend WithEvents lblPeopleTitle As Label
    Friend WithEvents tmrPersonSave As Timer
    Friend WithEvents tmrTeamSave As Timer
    Friend WithEvents ctlDeleteSprintTeam As ctlRichButtonSmall
    Friend WithEvents ctlDeletePerson As ctlRichButtonSmall
End Class
