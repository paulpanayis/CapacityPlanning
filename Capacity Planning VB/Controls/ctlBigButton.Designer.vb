<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlBigButton
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.cmdPic = New System.Windows.Forms.Button()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblText = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdPic
        '
        Me.cmdPic.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdPic.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmdPic.BackColor = System.Drawing.Color.Transparent
        Me.cmdPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdPic.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdPic.FlatAppearance.BorderSize = 0
        Me.cmdPic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.cmdPic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.cmdPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPic.Location = New System.Drawing.Point(3, 3)
        Me.cmdPic.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdPic.Name = "cmdPic"
        Me.cmdPic.Padding = New System.Windows.Forms.Padding(3)
        Me.cmdPic.Size = New System.Drawing.Size(80, 80)
        Me.cmdPic.TabIndex = 0
        Me.cmdPic.UseVisualStyleBackColor = False
        '
        'lblHeader
        '
        Me.lblHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHeader.BackColor = System.Drawing.Color.Transparent
        Me.lblHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblHeader.Location = New System.Drawing.Point(92, 3)
        Me.lblHeader.Margin = New System.Windows.Forms.Padding(3)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Padding = New System.Windows.Forms.Padding(3)
        Me.lblHeader.Size = New System.Drawing.Size(176, 27)
        Me.lblHeader.TabIndex = 1
        Me.lblHeader.Text = "Main"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblText
        '
        Me.lblText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblText.BackColor = System.Drawing.Color.Transparent
        Me.lblText.ForeColor = System.Drawing.Color.Gray
        Me.lblText.Location = New System.Drawing.Point(92, 36)
        Me.lblText.Margin = New System.Windows.Forms.Padding(3)
        Me.lblText.Name = "lblText"
        Me.lblText.Padding = New System.Windows.Forms.Padding(3)
        Me.lblText.Size = New System.Drawing.Size(176, 47)
        Me.lblText.TabIndex = 2
        Me.lblText.Text = "Body"
        '
        'ctlBigButton
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.cmdPic)
        Me.MaximumSize = New System.Drawing.Size(271, 86)
        Me.MinimumSize = New System.Drawing.Size(271, 86)
        Me.Name = "ctlBigButton"
        Me.Size = New System.Drawing.Size(271, 86)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdPic As Button
    Friend WithEvents lblHeader As Label
    Friend WithEvents lblText As Label
End Class
