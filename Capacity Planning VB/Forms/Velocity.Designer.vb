<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Velocity
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Velocity))
        Me.pnlBottomBar = New System.Windows.Forms.Panel()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cboTeams = New System.Windows.Forms.ComboBox()
        Me.lvwSprintActuals = New System.Windows.Forms.ListView()
        Me.tmrSprintActualSave = New System.Windows.Forms.Timer(Me.components)
        Me.lblSprintNumber = New System.Windows.Forms.Label()
        Me.txtVelocity = New System.Windows.Forms.TextBox()
        Me.lblVelocity = New System.Windows.Forms.Label()
        Me.lblSprintNumberValue = New System.Windows.Forms.Label()
        Me.lblVelocityTitle = New System.Windows.Forms.Label()
        Me.ctlDeleteVelocity = New Capacity_Planning.ctlRichButtonSmall()
        Me.pnlBottomBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBottomBar
        '
        Me.pnlBottomBar.BackColor = System.Drawing.Color.Transparent
        Me.pnlBottomBar.Controls.Add(Me.lblCopyright)
        Me.pnlBottomBar.Controls.Add(Me.cmdClose)
        Me.pnlBottomBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottomBar.Location = New System.Drawing.Point(0, 496)
        Me.pnlBottomBar.Margin = New System.Windows.Forms.Padding(6)
        Me.pnlBottomBar.Name = "pnlBottomBar"
        Me.pnlBottomBar.Size = New System.Drawing.Size(628, 57)
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
        Me.cmdClose.Location = New System.Drawing.Point(538, 19)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 3
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'cboTeams
        '
        Me.cboTeams.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTeams.FormattingEnabled = True
        Me.cboTeams.Location = New System.Drawing.Point(15, 15)
        Me.cboTeams.Margin = New System.Windows.Forms.Padding(6)
        Me.cboTeams.Name = "cboTeams"
        Me.cboTeams.Size = New System.Drawing.Size(598, 21)
        Me.cboTeams.TabIndex = 89
        '
        'lvwSprintActuals
        '
        Me.lvwSprintActuals.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwSprintActuals.FullRowSelect = True
        Me.lvwSprintActuals.HideSelection = False
        Me.lvwSprintActuals.Location = New System.Drawing.Point(15, 48)
        Me.lvwSprintActuals.Margin = New System.Windows.Forms.Padding(6)
        Me.lvwSprintActuals.MultiSelect = False
        Me.lvwSprintActuals.Name = "lvwSprintActuals"
        Me.lvwSprintActuals.Size = New System.Drawing.Size(598, 341)
        Me.lvwSprintActuals.TabIndex = 90
        Me.lvwSprintActuals.UseCompatibleStateImageBehavior = False
        Me.lvwSprintActuals.View = System.Windows.Forms.View.Details
        '
        'tmrSprintActualSave
        '
        Me.tmrSprintActualSave.Interval = 1000
        '
        'lblSprintNumber
        '
        Me.lblSprintNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSprintNumber.AutoSize = True
        Me.lblSprintNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblSprintNumber.Location = New System.Drawing.Point(12, 395)
        Me.lblSprintNumber.Name = "lblSprintNumber"
        Me.lblSprintNumber.Size = New System.Drawing.Size(74, 13)
        Me.lblSprintNumber.TabIndex = 103
        Me.lblSprintNumber.Text = "Sprint Number"
        '
        'txtVelocity
        '
        Me.txtVelocity.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtVelocity.Location = New System.Drawing.Point(15, 464)
        Me.txtVelocity.Margin = New System.Windows.Forms.Padding(6)
        Me.txtVelocity.Name = "txtVelocity"
        Me.txtVelocity.Size = New System.Drawing.Size(174, 20)
        Me.txtVelocity.TabIndex = 104
        '
        'lblVelocity
        '
        Me.lblVelocity.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblVelocity.AutoSize = True
        Me.lblVelocity.BackColor = System.Drawing.Color.Transparent
        Me.lblVelocity.Location = New System.Drawing.Point(12, 445)
        Me.lblVelocity.Name = "lblVelocity"
        Me.lblVelocity.Size = New System.Drawing.Size(92, 13)
        Me.lblVelocity.TabIndex = 105
        Me.lblVelocity.Text = "Velocity Achieved"
        '
        'lblSprintNumberValue
        '
        Me.lblSprintNumberValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSprintNumberValue.BackColor = System.Drawing.Color.LightGray
        Me.lblSprintNumberValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSprintNumberValue.ForeColor = System.Drawing.Color.Gray
        Me.lblSprintNumberValue.Location = New System.Drawing.Point(15, 413)
        Me.lblSprintNumberValue.Name = "lblSprintNumberValue"
        Me.lblSprintNumberValue.Size = New System.Drawing.Size(174, 22)
        Me.lblSprintNumberValue.TabIndex = 115
        Me.lblSprintNumberValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVelocityTitle
        '
        Me.lblVelocityTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVelocityTitle.AutoSize = True
        Me.lblVelocityTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblVelocityTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVelocityTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.lblVelocityTitle.Location = New System.Drawing.Point(300, 383)
        Me.lblVelocityTitle.Name = "lblVelocityTitle"
        Me.lblVelocityTitle.Size = New System.Drawing.Size(313, 55)
        Me.lblVelocityTitle.TabIndex = 116
        Me.lblVelocityTitle.Text = "sprint velocity"
        '
        'ctlDeleteVelocity
        '
        Me.ctlDeleteVelocity.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ctlDeleteVelocity.BackColor = System.Drawing.Color.Transparent
        Me.ctlDeleteVelocity.ColourHighlight = System.Drawing.Color.Lavender
        Me.ctlDeleteVelocity.Image = CType(resources.GetObject("ctlDeleteVelocity.Image"), System.Drawing.Image)
        Me.ctlDeleteVelocity.Location = New System.Drawing.Point(198, 449)
        Me.ctlDeleteVelocity.MaximumSize = New System.Drawing.Size(0, 38)
        Me.ctlDeleteVelocity.MinimumSize = New System.Drawing.Size(100, 38)
        Me.ctlDeleteVelocity.Name = "ctlDeleteVelocity"
        Me.ctlDeleteVelocity.Selected = False
        Me.ctlDeleteVelocity.Size = New System.Drawing.Size(100, 38)
        Me.ctlDeleteVelocity.TabIndex = 117
        Me.ctlDeleteVelocity.TextDescription = "Velocity"
        Me.ctlDeleteVelocity.TextTitle = "Remove"
        '
        'Velocity
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(628, 553)
        Me.Controls.Add(Me.lvwSprintActuals)
        Me.Controls.Add(Me.ctlDeleteVelocity)
        Me.Controls.Add(Me.lblVelocityTitle)
        Me.Controls.Add(Me.lblSprintNumberValue)
        Me.Controls.Add(Me.txtVelocity)
        Me.Controls.Add(Me.lblVelocity)
        Me.Controls.Add(Me.lblSprintNumber)
        Me.Controls.Add(Me.cboTeams)
        Me.Controls.Add(Me.pnlBottomBar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Velocity"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Velocity"
        Me.pnlBottomBar.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlBottomBar As Panel
    Friend WithEvents lblCopyright As Label
    Friend WithEvents cmdClose As Button
    Friend WithEvents cboTeams As ComboBox
    Friend WithEvents lvwSprintActuals As ListView
    Friend WithEvents tmrSprintActualSave As Timer
    Friend WithEvents lblSprintNumber As Label
    Friend WithEvents txtVelocity As TextBox
    Friend WithEvents lblVelocity As Label
    Friend WithEvents lblSprintNumberValue As Label
    Friend WithEvents ctlDeleteVelocity As ctlRichButtonSmall
    Friend WithEvents lblVelocityTitle As Label
End Class
