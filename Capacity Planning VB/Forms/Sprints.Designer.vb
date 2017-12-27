<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sprints
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
        Me.pnlBottomBar = New System.Windows.Forms.Panel()
        Me.blCopyright = New System.Windows.Forms.Label()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.pnlBottomBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBottomBar
        '
        Me.pnlBottomBar.BackColor = System.Drawing.Color.Transparent
        Me.pnlBottomBar.Controls.Add(Me.blCopyright)
        Me.pnlBottomBar.Controls.Add(Me.cmdClose)
        Me.pnlBottomBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottomBar.Location = New System.Drawing.Point(0, 432)
        Me.pnlBottomBar.Margin = New System.Windows.Forms.Padding(6)
        Me.pnlBottomBar.Name = "pnlBottomBar"
        Me.pnlBottomBar.Size = New System.Drawing.Size(756, 68)
        Me.pnlBottomBar.TabIndex = 59
        '
        'blCopyright
        '
        Me.blCopyright.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.blCopyright.BackColor = System.Drawing.Color.Transparent
        Me.blCopyright.Font = New System.Drawing.Font("Calibri", 10.125!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.blCopyright.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.blCopyright.Location = New System.Drawing.Point(9, 30)
        Me.blCopyright.Name = "blCopyright"
        Me.blCopyright.Size = New System.Drawing.Size(181, 29)
        Me.blCopyright.TabIndex = 61
        Me.blCopyright.Text = "© Paul Panayis, 2018"
        Me.blCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdClose.Location = New System.Drawing.Point(666, 30)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 3
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'Sprints
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(756, 500)
        Me.Controls.Add(Me.pnlBottomBar)
        Me.Name = "Sprints"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sprints"
        Me.pnlBottomBar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlBottomBar As Panel
    Friend WithEvents blCopyright As Label
    Friend WithEvents cmdClose As Button
End Class
