<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlSwitch
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlSwitch))
        Me.imlBackgrounds = New System.Windows.Forms.ImageList(Me.components)
        Me.imlSwitch = New System.Windows.Forms.ImageList(Me.components)
        Me.picSwitch = New System.Windows.Forms.PictureBox()
        Me.imlButtons = New System.Windows.Forms.ImageList(Me.components)
        Me.lblOnText = New System.Windows.Forms.Label()
        CType(Me.picSwitch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imlBackgrounds
        '
        Me.imlBackgrounds.ImageStream = CType(resources.GetObject("imlBackgrounds.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlBackgrounds.TransparentColor = System.Drawing.Color.Transparent
        Me.imlBackgrounds.Images.SetKeyName(0, "BlueOnWhiteOff")
        Me.imlBackgrounds.Images.SetKeyName(1, "GreenGoWhiteOff")
        Me.imlBackgrounds.Images.SetKeyName(2, "GreenOkRedErr")
        Me.imlBackgrounds.Images.SetKeyName(3, "GreenYesRedNo")
        Me.imlBackgrounds.Images.SetKeyName(4, "GreenYesWhiteNo")
        Me.imlBackgrounds.Images.SetKeyName(5, "OrangeOnWhiteOff")
        Me.imlBackgrounds.Images.SetKeyName(6, "OrangeYesWhiteNo")
        Me.imlBackgrounds.Images.SetKeyName(7, "WhiteOnRedOff")
        Me.imlBackgrounds.Images.SetKeyName(8, "TransparentWhiteNoSlider.png")
        Me.imlBackgrounds.Images.SetKeyName(9, "TransparentWhiteOffSlider.png")
        '
        'imlSwitch
        '
        Me.imlSwitch.ImageStream = CType(resources.GetObject("imlSwitch.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlSwitch.TransparentColor = System.Drawing.Color.Magenta
        Me.imlSwitch.Images.SetKeyName(0, "On")
        Me.imlSwitch.Images.SetKeyName(1, "Off")
        '
        'picSwitch
        '
        Me.picSwitch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picSwitch.BackColor = System.Drawing.Color.Transparent
        Me.picSwitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picSwitch.ErrorImage = Nothing
        Me.picSwitch.InitialImage = Nothing
        Me.picSwitch.Location = New System.Drawing.Point(0, 0)
        Me.picSwitch.Margin = New System.Windows.Forms.Padding(0)
        Me.picSwitch.Name = "picSwitch"
        Me.picSwitch.Size = New System.Drawing.Size(86, 30)
        Me.picSwitch.TabIndex = 0
        Me.picSwitch.TabStop = False
        '
        'imlButtons
        '
        Me.imlButtons.ImageStream = CType(resources.GetObject("imlButtons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlButtons.TransparentColor = System.Drawing.Color.Magenta
        Me.imlButtons.Images.SetKeyName(0, "ButtonBlank.bmp")
        Me.imlButtons.Images.SetKeyName(1, "ButtonBlueOn.bmp")
        Me.imlButtons.Images.SetKeyName(2, "ButtonGreenGo.bmp")
        Me.imlButtons.Images.SetKeyName(3, "ButtonGreenOk.bmp")
        Me.imlButtons.Images.SetKeyName(4, "ButtonGreenTick.bmp")
        Me.imlButtons.Images.SetKeyName(5, "ButtonGreenYes.bmp")
        Me.imlButtons.Images.SetKeyName(6, "ButtonOrangeOn.bmp")
        Me.imlButtons.Images.SetKeyName(7, "ButtonOrangeYes.bmp")
        Me.imlButtons.Images.SetKeyName(8, "ButtonWhiteOn.bmp")
        '
        'lblOnText
        '
        Me.lblOnText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOnText.BackColor = System.Drawing.Color.Transparent
        Me.lblOnText.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOnText.ForeColor = System.Drawing.Color.White
        Me.lblOnText.Location = New System.Drawing.Point(3, 3)
        Me.lblOnText.Name = "lblOnText"
        Me.lblOnText.Size = New System.Drawing.Size(38, 23)
        Me.lblOnText.TabIndex = 1
        Me.lblOnText.Text = "ON"
        Me.lblOnText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblOnText.Visible = False
        '
        'ctlSwitch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Controls.Add(Me.lblOnText)
        Me.Controls.Add(Me.picSwitch)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.MaximumSize = New System.Drawing.Size(86, 30)
        Me.MinimumSize = New System.Drawing.Size(43, 30)
        Me.Name = "ctlSwitch"
        Me.Size = New System.Drawing.Size(86, 30)
        CType(Me.picSwitch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents imlBackgrounds As System.Windows.Forms.ImageList
    Friend WithEvents imlSwitch As System.Windows.Forms.ImageList
    Friend WithEvents picSwitch As System.Windows.Forms.PictureBox
    Friend WithEvents imlButtons As System.Windows.Forms.ImageList
    Friend WithEvents lblOnText As Label
End Class
