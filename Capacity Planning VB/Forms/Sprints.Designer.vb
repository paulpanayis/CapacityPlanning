<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Sprints
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sprints))
        Me.pnlBottomBar = New System.Windows.Forms.Panel()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.tabSprints = New System.Windows.Forms.TabControl()
        Me.tabTemplate = New System.Windows.Forms.TabPage()
        Me.ctlDeleteTemplate = New Capacity_Planning.ctlRichButtonSmall()
        Me.cboSprintStartDay = New System.Windows.Forms.ComboBox()
        Me.lblSprintStartDay = New System.Windows.Forms.Label()
        Me.txtTemplateName = New System.Windows.Forms.TextBox()
        Me.lblTeamName = New System.Windows.Forms.Label()
        Me.ctlAddTemplate = New Capacity_Planning.ctlRichButtonSmall()
        Me.lvwTemplates = New System.Windows.Forms.ListView()
        Me.lblTemplatesTitle = New System.Windows.Forms.Label()
        Me.tabTemplateSprints = New System.Windows.Forms.TabPage()
        Me.cboYear = New System.Windows.Forms.ComboBox()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.cmdEndDate = New System.Windows.Forms.Button()
        Me.cmdStartDate = New System.Windows.Forms.Button()
        Me.lblEndDate = New System.Windows.Forms.Label()
        Me.lblStartDate = New System.Windows.Forms.Label()
        Me.lblSprintNumber = New System.Windows.Forms.Label()
        Me.ctlDeleteSprint = New Capacity_Planning.ctlRichButtonSmall()
        Me.txtSprintNumber = New System.Windows.Forms.TextBox()
        Me.cboTemplates = New System.Windows.Forms.ComboBox()
        Me.lvwSprints = New System.Windows.Forms.ListView()
        Me.lblSprintsTitle = New System.Windows.Forms.Label()
        Me.ctlCreateSprints = New Capacity_Planning.ctlRichButtonSmall()
        Me.pnlBottomBar.SuspendLayout()
        Me.tabSprints.SuspendLayout()
        Me.tabTemplate.SuspendLayout()
        Me.tabTemplateSprints.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBottomBar
        '
        Me.pnlBottomBar.BackColor = System.Drawing.Color.Transparent
        Me.pnlBottomBar.Controls.Add(Me.lblCopyright)
        Me.pnlBottomBar.Controls.Add(Me.cmdClose)
        Me.pnlBottomBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottomBar.Location = New System.Drawing.Point(0, 624)
        Me.pnlBottomBar.Margin = New System.Windows.Forms.Padding(6)
        Me.pnlBottomBar.Name = "pnlBottomBar"
        Me.pnlBottomBar.Size = New System.Drawing.Size(925, 57)
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
        Me.cmdClose.Location = New System.Drawing.Point(835, 19)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 3
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'tabSprints
        '
        Me.tabSprints.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabSprints.Controls.Add(Me.tabTemplate)
        Me.tabSprints.Controls.Add(Me.tabTemplateSprints)
        Me.tabSprints.Location = New System.Drawing.Point(12, 12)
        Me.tabSprints.Name = "tabSprints"
        Me.tabSprints.SelectedIndex = 0
        Me.tabSprints.Size = New System.Drawing.Size(901, 603)
        Me.tabSprints.TabIndex = 60
        '
        'tabTemplate
        '
        Me.tabTemplate.Controls.Add(Me.ctlDeleteTemplate)
        Me.tabTemplate.Controls.Add(Me.cboSprintStartDay)
        Me.tabTemplate.Controls.Add(Me.lblSprintStartDay)
        Me.tabTemplate.Controls.Add(Me.txtTemplateName)
        Me.tabTemplate.Controls.Add(Me.lblTeamName)
        Me.tabTemplate.Controls.Add(Me.ctlAddTemplate)
        Me.tabTemplate.Controls.Add(Me.lvwTemplates)
        Me.tabTemplate.Controls.Add(Me.lblTemplatesTitle)
        Me.tabTemplate.Location = New System.Drawing.Point(4, 22)
        Me.tabTemplate.Name = "tabTemplate"
        Me.tabTemplate.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTemplate.Size = New System.Drawing.Size(893, 577)
        Me.tabTemplate.TabIndex = 0
        Me.tabTemplate.Text = "Templates"
        Me.tabTemplate.UseVisualStyleBackColor = True
        '
        'ctlDeleteTemplate
        '
        Me.ctlDeleteTemplate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ctlDeleteTemplate.BackColor = System.Drawing.Color.Transparent
        Me.ctlDeleteTemplate.ColourHighlight = System.Drawing.Color.Lavender
        Me.ctlDeleteTemplate.Image = CType(resources.GetObject("ctlDeleteTemplate.Image"), System.Drawing.Image)
        Me.ctlDeleteTemplate.Location = New System.Drawing.Point(412, 492)
        Me.ctlDeleteTemplate.MaximumSize = New System.Drawing.Size(0, 38)
        Me.ctlDeleteTemplate.MinimumSize = New System.Drawing.Size(100, 38)
        Me.ctlDeleteTemplate.Name = "ctlDeleteTemplate"
        Me.ctlDeleteTemplate.Selected = False
        Me.ctlDeleteTemplate.Size = New System.Drawing.Size(100, 38)
        Me.ctlDeleteTemplate.TabIndex = 90
        Me.ctlDeleteTemplate.TextDescription = "Template"
        Me.ctlDeleteTemplate.TextTitle = "Delete"
        '
        'cboSprintStartDay
        '
        Me.cboSprintStartDay.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboSprintStartDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSprintStartDay.FormattingEnabled = True
        Me.cboSprintStartDay.Items.AddRange(New Object() {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"})
        Me.cboSprintStartDay.Location = New System.Drawing.Point(9, 550)
        Me.cboSprintStartDay.MaxDropDownItems = 7
        Me.cboSprintStartDay.Name = "cboSprintStartDay"
        Me.cboSprintStartDay.Size = New System.Drawing.Size(394, 21)
        Me.cboSprintStartDay.TabIndex = 89
        '
        'lblSprintStartDay
        '
        Me.lblSprintStartDay.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSprintStartDay.AutoSize = True
        Me.lblSprintStartDay.BackColor = System.Drawing.Color.Transparent
        Me.lblSprintStartDay.Location = New System.Drawing.Point(6, 534)
        Me.lblSprintStartDay.Name = "lblSprintStartDay"
        Me.lblSprintStartDay.Size = New System.Drawing.Size(81, 13)
        Me.lblSprintStartDay.TabIndex = 88
        Me.lblSprintStartDay.Text = "Sprint Start Day"
        '
        'txtTemplateName
        '
        Me.txtTemplateName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTemplateName.Location = New System.Drawing.Point(9, 508)
        Me.txtTemplateName.Margin = New System.Windows.Forms.Padding(6)
        Me.txtTemplateName.Name = "txtTemplateName"
        Me.txtTemplateName.Size = New System.Drawing.Size(394, 20)
        Me.txtTemplateName.TabIndex = 86
        '
        'lblTeamName
        '
        Me.lblTeamName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTeamName.AutoSize = True
        Me.lblTeamName.BackColor = System.Drawing.Color.Transparent
        Me.lblTeamName.Location = New System.Drawing.Point(6, 489)
        Me.lblTeamName.Name = "lblTeamName"
        Me.lblTeamName.Size = New System.Drawing.Size(112, 13)
        Me.lblTeamName.TabIndex = 87
        Me.lblTeamName.Text = "Sprint Template Name"
        '
        'ctlAddTemplate
        '
        Me.ctlAddTemplate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ctlAddTemplate.BackColor = System.Drawing.Color.Transparent
        Me.ctlAddTemplate.ColourHighlight = System.Drawing.Color.Lavender
        Me.ctlAddTemplate.Image = CType(resources.GetObject("ctlAddTemplate.Image"), System.Drawing.Image)
        Me.ctlAddTemplate.Location = New System.Drawing.Point(787, 6)
        Me.ctlAddTemplate.MaximumSize = New System.Drawing.Size(0, 38)
        Me.ctlAddTemplate.MinimumSize = New System.Drawing.Size(100, 38)
        Me.ctlAddTemplate.Name = "ctlAddTemplate"
        Me.ctlAddTemplate.Selected = False
        Me.ctlAddTemplate.Size = New System.Drawing.Size(100, 38)
        Me.ctlAddTemplate.TabIndex = 84
        Me.ctlAddTemplate.TextDescription = "Template"
        Me.ctlAddTemplate.TextTitle = "New"
        '
        'lvwTemplates
        '
        Me.lvwTemplates.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwTemplates.FullRowSelect = True
        Me.lvwTemplates.Location = New System.Drawing.Point(9, 9)
        Me.lvwTemplates.Margin = New System.Windows.Forms.Padding(6)
        Me.lvwTemplates.MultiSelect = False
        Me.lvwTemplates.Name = "lvwTemplates"
        Me.lvwTemplates.Size = New System.Drawing.Size(769, 474)
        Me.lvwTemplates.TabIndex = 83
        Me.lvwTemplates.UseCompatibleStateImageBehavior = False
        Me.lvwTemplates.View = System.Windows.Forms.View.Details
        '
        'lblTemplatesTitle
        '
        Me.lblTemplatesTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTemplatesTitle.AutoSize = True
        Me.lblTemplatesTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTemplatesTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTemplatesTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.lblTemplatesTitle.Location = New System.Drawing.Point(518, 476)
        Me.lblTemplatesTitle.Name = "lblTemplatesTitle"
        Me.lblTemplatesTitle.Size = New System.Drawing.Size(362, 55)
        Me.lblTemplatesTitle.TabIndex = 85
        Me.lblTemplatesTitle.Text = "sprint templates"
        '
        'tabTemplateSprints
        '
        Me.tabTemplateSprints.Controls.Add(Me.cboYear)
        Me.tabTemplateSprints.Controls.Add(Me.lblYear)
        Me.tabTemplateSprints.Controls.Add(Me.cmdEndDate)
        Me.tabTemplateSprints.Controls.Add(Me.cmdStartDate)
        Me.tabTemplateSprints.Controls.Add(Me.lblEndDate)
        Me.tabTemplateSprints.Controls.Add(Me.lblStartDate)
        Me.tabTemplateSprints.Controls.Add(Me.lblSprintNumber)
        Me.tabTemplateSprints.Controls.Add(Me.ctlDeleteSprint)
        Me.tabTemplateSprints.Controls.Add(Me.txtSprintNumber)
        Me.tabTemplateSprints.Controls.Add(Me.cboTemplates)
        Me.tabTemplateSprints.Controls.Add(Me.lvwSprints)
        Me.tabTemplateSprints.Controls.Add(Me.lblSprintsTitle)
        Me.tabTemplateSprints.Controls.Add(Me.ctlCreateSprints)
        Me.tabTemplateSprints.Location = New System.Drawing.Point(4, 22)
        Me.tabTemplateSprints.Margin = New System.Windows.Forms.Padding(6)
        Me.tabTemplateSprints.Name = "tabTemplateSprints"
        Me.tabTemplateSprints.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTemplateSprints.Size = New System.Drawing.Size(893, 577)
        Me.tabTemplateSprints.TabIndex = 1
        Me.tabTemplateSprints.Text = "Sprints"
        Me.tabTemplateSprints.UseVisualStyleBackColor = True
        '
        'cboYear
        '
        Me.cboYear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.Location = New System.Drawing.Point(661, 9)
        Me.cboYear.Margin = New System.Windows.Forms.Padding(6)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(117, 21)
        Me.cboYear.TabIndex = 99
        '
        'lblYear
        '
        Me.lblYear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblYear.AutoSize = True
        Me.lblYear.BackColor = System.Drawing.Color.Transparent
        Me.lblYear.Location = New System.Drawing.Point(623, 12)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(29, 13)
        Me.lblYear.TabIndex = 98
        Me.lblYear.Text = "Year"
        '
        'cmdEndDate
        '
        Me.cmdEndDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
        Me.cmdEndDate.Location = New System.Drawing.Point(190, 539)
        Me.cmdEndDate.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdEndDate.Name = "cmdEndDate"
        Me.cmdEndDate.Size = New System.Drawing.Size(122, 29)
        Me.cmdEndDate.TabIndex = 97
        Me.cmdEndDate.Text = "Click for Date"
        Me.cmdEndDate.UseVisualStyleBackColor = False
        '
        'cmdStartDate
        '
        Me.cmdStartDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
        Me.cmdStartDate.Location = New System.Drawing.Point(9, 539)
        Me.cmdStartDate.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdStartDate.Name = "cmdStartDate"
        Me.cmdStartDate.Size = New System.Drawing.Size(122, 29)
        Me.cmdStartDate.TabIndex = 96
        Me.cmdStartDate.Text = "Click for Date"
        Me.cmdStartDate.UseVisualStyleBackColor = False
        '
        'lblEndDate
        '
        Me.lblEndDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblEndDate.AutoSize = True
        Me.lblEndDate.BackColor = System.Drawing.Color.Transparent
        Me.lblEndDate.Location = New System.Drawing.Point(187, 520)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(52, 13)
        Me.lblEndDate.TabIndex = 95
        Me.lblEndDate.Text = "End Date"
        '
        'lblStartDate
        '
        Me.lblStartDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblStartDate.AutoSize = True
        Me.lblStartDate.BackColor = System.Drawing.Color.Transparent
        Me.lblStartDate.Location = New System.Drawing.Point(6, 520)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(55, 13)
        Me.lblStartDate.TabIndex = 94
        Me.lblStartDate.Text = "Start Date"
        '
        'lblSprintNumber
        '
        Me.lblSprintNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSprintNumber.AutoSize = True
        Me.lblSprintNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblSprintNumber.Location = New System.Drawing.Point(6, 475)
        Me.lblSprintNumber.Name = "lblSprintNumber"
        Me.lblSprintNumber.Size = New System.Drawing.Size(74, 13)
        Me.lblSprintNumber.TabIndex = 93
        Me.lblSprintNumber.Text = "Sprint Number"
        '
        'ctlDeleteSprint
        '
        Me.ctlDeleteSprint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ctlDeleteSprint.BackColor = System.Drawing.Color.Transparent
        Me.ctlDeleteSprint.ColourHighlight = System.Drawing.Color.Lavender
        Me.ctlDeleteSprint.Image = CType(resources.GetObject("ctlDeleteSprint.Image"), System.Drawing.Image)
        Me.ctlDeleteSprint.Location = New System.Drawing.Point(336, 476)
        Me.ctlDeleteSprint.MaximumSize = New System.Drawing.Size(0, 38)
        Me.ctlDeleteSprint.MinimumSize = New System.Drawing.Size(100, 38)
        Me.ctlDeleteSprint.Name = "ctlDeleteSprint"
        Me.ctlDeleteSprint.Selected = False
        Me.ctlDeleteSprint.Size = New System.Drawing.Size(100, 38)
        Me.ctlDeleteSprint.TabIndex = 92
        Me.ctlDeleteSprint.TextDescription = "Sprint"
        Me.ctlDeleteSprint.TextTitle = "Delete"
        '
        'txtSprintNumber
        '
        Me.txtSprintNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSprintNumber.Location = New System.Drawing.Point(9, 494)
        Me.txtSprintNumber.Margin = New System.Windows.Forms.Padding(6)
        Me.txtSprintNumber.Name = "txtSprintNumber"
        Me.txtSprintNumber.Size = New System.Drawing.Size(303, 20)
        Me.txtSprintNumber.TabIndex = 89
        '
        'cboTemplates
        '
        Me.cboTemplates.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTemplates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTemplates.FormattingEnabled = True
        Me.cboTemplates.Location = New System.Drawing.Point(9, 9)
        Me.cboTemplates.Margin = New System.Windows.Forms.Padding(6)
        Me.cboTemplates.Name = "cboTemplates"
        Me.cboTemplates.Size = New System.Drawing.Size(605, 21)
        Me.cboTemplates.TabIndex = 88
        '
        'lvwSprints
        '
        Me.lvwSprints.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwSprints.FullRowSelect = True
        Me.lvwSprints.Location = New System.Drawing.Point(9, 39)
        Me.lvwSprints.Margin = New System.Windows.Forms.Padding(6)
        Me.lvwSprints.MultiSelect = False
        Me.lvwSprints.Name = "lvwSprints"
        Me.lvwSprints.Size = New System.Drawing.Size(769, 428)
        Me.lvwSprints.TabIndex = 86
        Me.lvwSprints.UseCompatibleStateImageBehavior = False
        Me.lvwSprints.View = System.Windows.Forms.View.Details
        '
        'lblSprintsTitle
        '
        Me.lblSprintsTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSprintsTitle.AutoSize = True
        Me.lblSprintsTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSprintsTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSprintsTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.lblSprintsTitle.Location = New System.Drawing.Point(678, 459)
        Me.lblSprintsTitle.Name = "lblSprintsTitle"
        Me.lblSprintsTitle.Size = New System.Drawing.Size(165, 55)
        Me.lblSprintsTitle.TabIndex = 91
        Me.lblSprintsTitle.Text = "sprints"
        '
        'ctlCreateSprints
        '
        Me.ctlCreateSprints.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ctlCreateSprints.BackColor = System.Drawing.Color.Transparent
        Me.ctlCreateSprints.ColourHighlight = System.Drawing.Color.Lavender
        Me.ctlCreateSprints.Image = CType(resources.GetObject("ctlCreateSprints.Image"), System.Drawing.Image)
        Me.ctlCreateSprints.Location = New System.Drawing.Point(787, 6)
        Me.ctlCreateSprints.MaximumSize = New System.Drawing.Size(0, 38)
        Me.ctlCreateSprints.MinimumSize = New System.Drawing.Size(100, 38)
        Me.ctlCreateSprints.Name = "ctlCreateSprints"
        Me.ctlCreateSprints.Selected = False
        Me.ctlCreateSprints.Size = New System.Drawing.Size(100, 38)
        Me.ctlCreateSprints.TabIndex = 87
        Me.ctlCreateSprints.TextDescription = "Sprints"
        Me.ctlCreateSprints.TextTitle = "Create"
        '
        'Sprints
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(925, 681)
        Me.Controls.Add(Me.tabSprints)
        Me.Controls.Add(Me.pnlBottomBar)
        Me.Name = "Sprints"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sprints"
        Me.pnlBottomBar.ResumeLayout(False)
        Me.tabSprints.ResumeLayout(False)
        Me.tabTemplate.ResumeLayout(False)
        Me.tabTemplate.PerformLayout()
        Me.tabTemplateSprints.ResumeLayout(False)
        Me.tabTemplateSprints.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlBottomBar As Panel
    Friend WithEvents lblCopyright As Label
    Friend WithEvents cmdClose As Button
    Friend WithEvents tabSprints As TabControl
    Friend WithEvents tabTemplate As TabPage
    Friend WithEvents tabTemplateSprints As TabPage
    Friend WithEvents ctlDeleteTemplate As ctlRichButtonSmall
    Friend WithEvents cboSprintStartDay As ComboBox
    Friend WithEvents lblSprintStartDay As Label
    Friend WithEvents txtTemplateName As TextBox
    Friend WithEvents lblTeamName As Label
    Friend WithEvents ctlAddTemplate As ctlRichButtonSmall
    Friend WithEvents lvwTemplates As ListView
    Friend WithEvents lblTemplatesTitle As Label
    Friend WithEvents ctlDeleteSprint As ctlRichButtonSmall
    Friend WithEvents txtSprintNumber As TextBox
    Friend WithEvents cboTemplates As ComboBox
    Friend WithEvents lvwSprints As ListView
    Friend WithEvents lblSprintsTitle As Label
    Friend WithEvents ctlCreateSprints As ctlRichButtonSmall
    Friend WithEvents lblEndDate As Label
    Friend WithEvents lblStartDate As Label
    Friend WithEvents lblSprintNumber As Label
    Friend WithEvents cmdEndDate As Button
    Friend WithEvents cmdStartDate As Button
    Friend WithEvents cboYear As ComboBox
    Friend WithEvents lblYear As Label
End Class
