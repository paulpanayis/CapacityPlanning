<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDateSelector
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cboYear = New System.Windows.Forms.ComboBox
        Me.cboMonth = New System.Windows.Forms.ListBox
        Me.cmdOK = New System.Windows.Forms.Button
        Me.lblDate = New System.Windows.Forms.Label
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdToday = New System.Windows.Forms.Button
        Me.MonthView = New ctlMonthView
        Me.SuspendLayout()
        '
        'cboYear
        '
        Me.cboYear.DropDownHeight = 500
        Me.cboYear.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.IntegralHeight = False
        Me.cboYear.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.cboYear.Location = New System.Drawing.Point(12, 12)
        Me.cboYear.MaxDropDownItems = 30
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(103, 26)
        Me.cboYear.TabIndex = 0
        Me.cboYear.Text = "2006"
        '
        'cboMonth
        '
        Me.cboMonth.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMonth.FormattingEnabled = True
        Me.cboMonth.ItemHeight = 18
        Me.cboMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cboMonth.Location = New System.Drawing.Point(120, 12)
        Me.cboMonth.Name = "cboMonth"
        Me.cboMonth.Size = New System.Drawing.Size(150, 220)
        Me.cboMonth.TabIndex = 1
        '
        'cmdOK
        '
        Me.cmdOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmdOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdOK.Location = New System.Drawing.Point(428, 252)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(75, 23)
        Me.cmdOK.TabIndex = 5
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = False
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblDate.Location = New System.Drawing.Point(12, 253)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(248, 20)
        Me.lblDate.TabIndex = 28
        '
        'cmdCancel
        '
        Me.cmdCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdCancel.Location = New System.Drawing.Point(347, 252)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 4
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdToday
        '
        Me.cmdToday.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdToday.BackColor = System.Drawing.SystemColors.Control
        Me.cmdToday.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdToday.Location = New System.Drawing.Point(266, 252)
        Me.cmdToday.Name = "cmdToday"
        Me.cmdToday.Size = New System.Drawing.Size(75, 23)
        Me.cmdToday.TabIndex = 3
        Me.cmdToday.Text = "Today"
        Me.cmdToday.UseVisualStyleBackColor = False
        '
        'MonthView
        '
        Me.MonthView.ActiveDate = New Date(CType(0, Long))
        Me.MonthView.ActiveDayColour = System.Drawing.Color.Orange
        Me.MonthView.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MonthView.Colour1 = System.Drawing.Color.Empty
        Me.MonthView.Colour2 = System.Drawing.Color.Empty
        Me.MonthView.Colour3 = System.Drawing.Color.Empty
        Me.MonthView.Colour4 = System.Drawing.Color.Empty
        Me.MonthView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MonthView.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthView.Location = New System.Drawing.Point(276, 13)
        Me.MonthView.Name = "MonthView"
        Me.MonthView.OtherMonthColour = System.Drawing.Color.Gray
        Me.MonthView.Size = New System.Drawing.Size(233, 219)
        Me.MonthView.TabIndex = 2
        Me.MonthView.ThisMonthColour = System.Drawing.Color.White
        Me.MonthView.TodayColour = System.Drawing.Color.RoyalBlue
        Me.MonthView.TodayTextColour = System.Drawing.Color.White
        '
        'frmDateSelector
        '
        Me.AcceptButton = Me.cmdOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(515, 287)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdToday)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.cboMonth)
        Me.Controls.Add(Me.MonthView)
        Me.Controls.Add(Me.cboYear)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDateSelector"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Please Select Date"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cboYear As System.Windows.Forms.ComboBox
    Friend WithEvents MonthView As ctlMonthView
    Friend WithEvents cboMonth As System.Windows.Forms.ListBox
    Friend WithEvents cmdOK As System.Windows.Forms.Button
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdToday As System.Windows.Forms.Button

End Class
