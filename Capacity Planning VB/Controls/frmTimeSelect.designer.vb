<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimeSelect
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
        Me.lstHour = New System.Windows.Forms.ListBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.lstMinutes = New System.Windows.Forms.ListBox()
        Me.lbl12hr = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstHour
        '
        Me.lstHour.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lstHour.FormattingEnabled = True
        Me.lstHour.ItemHeight = 18
        Me.lstHour.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.lstHour.Location = New System.Drawing.Point(12, 12)
        Me.lstHour.Name = "lstHour"
        Me.lstHour.Size = New System.Drawing.Size(75, 436)
        Me.lstHour.TabIndex = 0
        '
        'cmdCancel
        '
        Me.cmdCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdCancel.Location = New System.Drawing.Point(11, 491)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 2
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdOK
        '
        Me.cmdOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmdOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdOK.Location = New System.Drawing.Point(92, 491)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(75, 23)
        Me.cmdOK.TabIndex = 3
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = False
        '
        'lstMinutes
        '
        Me.lstMinutes.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lstMinutes.FormattingEnabled = True
        Me.lstMinutes.ItemHeight = 18
        Me.lstMinutes.Items.AddRange(New Object() {"00", "05", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55"})
        Me.lstMinutes.Location = New System.Drawing.Point(92, 12)
        Me.lstMinutes.Name = "lstMinutes"
        Me.lstMinutes.Size = New System.Drawing.Size(75, 220)
        Me.lstMinutes.TabIndex = 1
        '
        'lbl12hr
        '
        Me.lbl12hr.BackColor = System.Drawing.Color.Transparent
        Me.lbl12hr.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl12hr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl12hr.Location = New System.Drawing.Point(12, 460)
        Me.lbl12hr.Name = "lbl12hr"
        Me.lbl12hr.Size = New System.Drawing.Size(155, 20)
        Me.lbl12hr.TabIndex = 30
        Me.lbl12hr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmTimeSelect
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(179, 526)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbl12hr)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.lstMinutes)
        Me.Controls.Add(Me.lstHour)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(195, 565)
        Me.MinimumSize = New System.Drawing.Size(195, 565)
        Me.Name = "frmTimeSelect"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Please Select Time"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstHour As System.Windows.Forms.ListBox
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdOK As System.Windows.Forms.Button
    Friend WithEvents lstMinutes As System.Windows.Forms.ListBox
    Friend WithEvents lbl12hr As System.Windows.Forms.Label
End Class
