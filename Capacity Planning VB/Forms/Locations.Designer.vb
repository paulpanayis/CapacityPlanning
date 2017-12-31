<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Locations
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Locations))
        Me.pnlBottomBar = New System.Windows.Forms.Panel()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.lblLocationsTitle = New System.Windows.Forms.Label()
        Me.ctlDeleteLocation = New Capacity_Planning.ctlRichButtonSmall()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.lblLocationName = New System.Windows.Forms.Label()
        Me.ctlAddLocation = New Capacity_Planning.ctlRichButtonSmall()
        Me.lvwLocations = New System.Windows.Forms.ListView()
        Me.tmrLocationSave = New System.Windows.Forms.Timer(Me.components)
        Me.pnlBottomBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBottomBar
        '
        Me.pnlBottomBar.BackColor = System.Drawing.Color.Transparent
        Me.pnlBottomBar.Controls.Add(Me.lblCopyright)
        Me.pnlBottomBar.Controls.Add(Me.cmdClose)
        Me.pnlBottomBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottomBar.Location = New System.Drawing.Point(0, 501)
        Me.pnlBottomBar.Margin = New System.Windows.Forms.Padding(6)
        Me.pnlBottomBar.Name = "pnlBottomBar"
        Me.pnlBottomBar.Size = New System.Drawing.Size(621, 57)
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
        Me.cmdClose.Location = New System.Drawing.Point(531, 19)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 3
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'lblLocationsTitle
        '
        Me.lblLocationsTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLocationsTitle.AutoSize = True
        Me.lblLocationsTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblLocationsTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocationsTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.lblLocationsTitle.Location = New System.Drawing.Point(396, 423)
        Me.lblLocationsTitle.Name = "lblLocationsTitle"
        Me.lblLocationsTitle.Size = New System.Drawing.Size(213, 55)
        Me.lblLocationsTitle.TabIndex = 76
        Me.lblLocationsTitle.Text = "locations"
        '
        'ctlDeleteLocation
        '
        Me.ctlDeleteLocation.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ctlDeleteLocation.BackColor = System.Drawing.Color.Transparent
        Me.ctlDeleteLocation.ColourHighlight = System.Drawing.Color.Lavender
        Me.ctlDeleteLocation.Image = CType(resources.GetObject("ctlDeleteLocation.Image"), System.Drawing.Image)
        Me.ctlDeleteLocation.Location = New System.Drawing.Point(290, 438)
        Me.ctlDeleteLocation.MaximumSize = New System.Drawing.Size(0, 38)
        Me.ctlDeleteLocation.MinimumSize = New System.Drawing.Size(100, 38)
        Me.ctlDeleteLocation.Name = "ctlDeleteLocation"
        Me.ctlDeleteLocation.Selected = False
        Me.ctlDeleteLocation.Size = New System.Drawing.Size(100, 38)
        Me.ctlDeleteLocation.TabIndex = 87
        Me.ctlDeleteLocation.TextDescription = "Location"
        Me.ctlDeleteLocation.TextTitle = "Delete"
        '
        'txtLocation
        '
        Me.txtLocation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLocation.Location = New System.Drawing.Point(15, 454)
        Me.txtLocation.Margin = New System.Windows.Forms.Padding(6)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(266, 20)
        Me.txtLocation.TabIndex = 85
        '
        'lblLocationName
        '
        Me.lblLocationName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblLocationName.AutoSize = True
        Me.lblLocationName.BackColor = System.Drawing.Color.Transparent
        Me.lblLocationName.Location = New System.Drawing.Point(12, 435)
        Me.lblLocationName.Name = "lblLocationName"
        Me.lblLocationName.Size = New System.Drawing.Size(79, 13)
        Me.lblLocationName.TabIndex = 86
        Me.lblLocationName.Text = "Location Name"
        '
        'ctlAddLocation
        '
        Me.ctlAddLocation.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ctlAddLocation.BackColor = System.Drawing.Color.Transparent
        Me.ctlAddLocation.ColourHighlight = System.Drawing.Color.Lavender
        Me.ctlAddLocation.Image = CType(resources.GetObject("ctlAddLocation.Image"), System.Drawing.Image)
        Me.ctlAddLocation.Location = New System.Drawing.Point(509, 12)
        Me.ctlAddLocation.MaximumSize = New System.Drawing.Size(0, 38)
        Me.ctlAddLocation.MinimumSize = New System.Drawing.Size(100, 38)
        Me.ctlAddLocation.Name = "ctlAddLocation"
        Me.ctlAddLocation.Selected = False
        Me.ctlAddLocation.Size = New System.Drawing.Size(100, 38)
        Me.ctlAddLocation.TabIndex = 84
        Me.ctlAddLocation.TextDescription = "Location"
        Me.ctlAddLocation.TextTitle = "New"
        '
        'lvwLocations
        '
        Me.lvwLocations.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwLocations.FullRowSelect = True
        Me.lvwLocations.Location = New System.Drawing.Point(15, 15)
        Me.lvwLocations.Margin = New System.Windows.Forms.Padding(6)
        Me.lvwLocations.MultiSelect = False
        Me.lvwLocations.Name = "lvwLocations"
        Me.lvwLocations.Size = New System.Drawing.Size(485, 414)
        Me.lvwLocations.TabIndex = 83
        Me.lvwLocations.UseCompatibleStateImageBehavior = False
        Me.lvwLocations.View = System.Windows.Forms.View.Details
        '
        'tmrLocationSave
        '
        Me.tmrLocationSave.Interval = 1000
        '
        'Locations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(621, 558)
        Me.Controls.Add(Me.ctlDeleteLocation)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.lblLocationName)
        Me.Controls.Add(Me.ctlAddLocation)
        Me.Controls.Add(Me.lvwLocations)
        Me.Controls.Add(Me.lblLocationsTitle)
        Me.Controls.Add(Me.pnlBottomBar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Locations"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Locations"
        Me.pnlBottomBar.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlBottomBar As Panel
    Friend WithEvents lblCopyright As Label
    Friend WithEvents cmdClose As Button
    Friend WithEvents lblLocationsTitle As Label
    Friend WithEvents ctlDeleteLocation As ctlRichButtonSmall
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents lblLocationName As Label
    Friend WithEvents ctlAddLocation As ctlRichButtonSmall
    Friend WithEvents lvwLocations As ListView
    Friend WithEvents tmrLocationSave As Timer
End Class
