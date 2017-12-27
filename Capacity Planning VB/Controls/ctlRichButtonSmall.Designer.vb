<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlRichButtonSmall
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
        Me.pnlControl = New System.Windows.Forms.Panel()
        Me.cmdPic = New System.Windows.Forms.PictureBox()
        Me.lblText = New System.Windows.Forms.LinkLabel()
        Me.lblHeader = New System.Windows.Forms.LinkLabel()
        Me.pnlControl.SuspendLayout()
        CType(Me.cmdPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlControl
        '
        Me.pnlControl.BackColor = System.Drawing.Color.Transparent
        Me.pnlControl.Controls.Add(Me.cmdPic)
        Me.pnlControl.Controls.Add(Me.lblText)
        Me.pnlControl.Controls.Add(Me.lblHeader)
        Me.pnlControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlControl.Location = New System.Drawing.Point(0, 0)
        Me.pnlControl.Margin = New System.Windows.Forms.Padding(6)
        Me.pnlControl.Name = "pnlControl"
        Me.pnlControl.Size = New System.Drawing.Size(100, 38)
        Me.pnlControl.TabIndex = 21
        '
        'cmdPic
        '
        Me.cmdPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdPic.Location = New System.Drawing.Point(3, 3)
        Me.cmdPic.MaximumSize = New System.Drawing.Size(32, 32)
        Me.cmdPic.MinimumSize = New System.Drawing.Size(32, 32)
        Me.cmdPic.Name = "cmdPic"
        Me.cmdPic.Size = New System.Drawing.Size(32, 32)
        Me.cmdPic.TabIndex = 16
        Me.cmdPic.TabStop = False
        '
        'lblText
        '
        Me.lblText.ActiveLinkColor = System.Drawing.Color.Red
        Me.lblText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblText.BackColor = System.Drawing.Color.Transparent
        Me.lblText.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.lblText.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.lblText.LinkColor = System.Drawing.Color.Gray
        Me.lblText.Location = New System.Drawing.Point(39, 20)
        Me.lblText.Margin = New System.Windows.Forms.Padding(1)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(60, 15)
        Me.lblText.TabIndex = 14
        Me.lblText.TabStop = True
        Me.lblText.Text = "Body"
        Me.lblText.VisitedLinkColor = System.Drawing.Color.Gray
        '
        'lblHeader
        '
        Me.lblHeader.ActiveLinkColor = System.Drawing.Color.Red
        Me.lblHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHeader.BackColor = System.Drawing.Color.Transparent
        Me.lblHeader.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.lblHeader.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.lblHeader.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblHeader.Location = New System.Drawing.Point(39, 3)
        Me.lblHeader.Margin = New System.Windows.Forms.Padding(1)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(60, 15)
        Me.lblHeader.TabIndex = 15
        Me.lblHeader.TabStop = True
        Me.lblHeader.Text = "Main"
        Me.lblHeader.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
        '
        'ctlRichButtonSmall
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.pnlControl)
        Me.MaximumSize = New System.Drawing.Size(0, 38)
        Me.MinimumSize = New System.Drawing.Size(100, 38)
        Me.Name = "ctlRichButtonSmall"
        Me.Size = New System.Drawing.Size(100, 38)
        Me.pnlControl.ResumeLayout(False)
        CType(Me.cmdPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlControl As Panel
    Friend WithEvents lblText As LinkLabel
    Friend WithEvents lblHeader As LinkLabel
    Friend WithEvents cmdPic As PictureBox
End Class
