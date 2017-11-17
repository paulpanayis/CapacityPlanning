<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.CtlYearView1 = New Capacity_Planning_VB.ctlYearView()
        Me.SuspendLayout()
        '
        'CtlYearView1
        '
        Me.CtlYearView1.ActiveDayColour = System.Drawing.Color.Orange
        Me.CtlYearView1.ActiveYear = 2017
        Me.CtlYearView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CtlYearView1.Colour1 = System.Drawing.Color.Empty
        Me.CtlYearView1.Colour2 = System.Drawing.Color.Empty
        Me.CtlYearView1.Colour3 = System.Drawing.Color.Empty
        Me.CtlYearView1.Colour4 = System.Drawing.Color.Empty
        Me.CtlYearView1.Colour5 = System.Drawing.Color.Empty
        Me.CtlYearView1.Colour6 = System.Drawing.Color.Empty
        Me.CtlYearView1.Font = New System.Drawing.Font("Calibri", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtlYearView1.Location = New System.Drawing.Point(12, 12)
        Me.CtlYearView1.Name = "CtlYearView1"
        Me.CtlYearView1.OtherYearWeekdayColour = System.Drawing.Color.LightGray
        Me.CtlYearView1.OtherYearWeekendColour = System.Drawing.Color.Gray
        Me.CtlYearView1.Size = New System.Drawing.Size(1851, 1405)
        Me.CtlYearView1.TabIndex = 0
        Me.CtlYearView1.ThisYearWeekdayColour = System.Drawing.Color.White
        Me.CtlYearView1.ThisYearWeekendColour = System.Drawing.Color.PaleGoldenrod
        Me.CtlYearView1.TodayColour = System.Drawing.Color.RoyalBlue
        Me.CtlYearView1.TodayTextColour = System.Drawing.Color.White
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1875, 1429)
        Me.Controls.Add(Me.CtlYearView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CtlYearView1 As ctlYearView
End Class
