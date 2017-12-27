<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reports))
        Me.lvwReports = New System.Windows.Forms.ListView()
        Me.fraReport = New System.Windows.Forms.GroupBox()
        Me.pnlConditionDateTo = New System.Windows.Forms.Panel()
        Me.lblConditionDateTo = New System.Windows.Forms.Label()
        Me.cmdDateTo = New System.Windows.Forms.Button()
        Me.pnlConditionDateFrom = New System.Windows.Forms.Panel()
        Me.lblConditionDateFrom = New System.Windows.Forms.Label()
        Me.cmdDateFrom = New System.Windows.Forms.Button()
        Me.lblReportDescription = New System.Windows.Forms.Label()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.lvwResults = New System.Windows.Forms.ListView()
        Me.PrintDialog = New System.Windows.Forms.PrintDialog()
        Me.PrintDoc = New System.Drawing.Printing.PrintDocument()
        Me.pnlBottomBar = New System.Windows.Forms.Panel()
        Me.ctlPrint = New Capacity_Planning.ctlRichButtonSmall()
        Me.ctlExcel = New Capacity_Planning.ctlRichButtonSmall()
        Me.ctlReport = New Capacity_Planning.ctlRichButtonSmall()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.blCopyright = New System.Windows.Forms.Label()
        Me.fraReport.SuspendLayout()
        Me.pnlConditionDateTo.SuspendLayout()
        Me.pnlConditionDateFrom.SuspendLayout()
        Me.pnlBottomBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvwReports
        '
        Me.lvwReports.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwReports.FullRowSelect = True
        Me.lvwReports.Location = New System.Drawing.Point(24, 23)
        Me.lvwReports.Margin = New System.Windows.Forms.Padding(6)
        Me.lvwReports.MultiSelect = False
        Me.lvwReports.Name = "lvwReports"
        Me.lvwReports.Size = New System.Drawing.Size(427, 286)
        Me.lvwReports.TabIndex = 1
        Me.lvwReports.UseCompatibleStateImageBehavior = False
        Me.lvwReports.View = System.Windows.Forms.View.Details
        '
        'fraReport
        '
        Me.fraReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fraReport.BackColor = System.Drawing.Color.Transparent
        Me.fraReport.Controls.Add(Me.pnlConditionDateTo)
        Me.fraReport.Controls.Add(Me.pnlConditionDateFrom)
        Me.fraReport.Controls.Add(Me.lblReportDescription)
        Me.fraReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraReport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.fraReport.Location = New System.Drawing.Point(467, 23)
        Me.fraReport.Margin = New System.Windows.Forms.Padding(6)
        Me.fraReport.Name = "fraReport"
        Me.fraReport.Padding = New System.Windows.Forms.Padding(6)
        Me.fraReport.Size = New System.Drawing.Size(494, 286)
        Me.fraReport.TabIndex = 13
        Me.fraReport.TabStop = False
        Me.fraReport.Text = "Report Details"
        '
        'pnlConditionDateTo
        '
        Me.pnlConditionDateTo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlConditionDateTo.Controls.Add(Me.lblConditionDateTo)
        Me.pnlConditionDateTo.Controls.Add(Me.cmdDateTo)
        Me.pnlConditionDateTo.Location = New System.Drawing.Point(159, 208)
        Me.pnlConditionDateTo.Margin = New System.Windows.Forms.Padding(6)
        Me.pnlConditionDateTo.Name = "pnlConditionDateTo"
        Me.pnlConditionDateTo.Size = New System.Drawing.Size(135, 66)
        Me.pnlConditionDateTo.TabIndex = 71
        Me.pnlConditionDateTo.Visible = False
        '
        'lblConditionDateTo
        '
        Me.lblConditionDateTo.AutoSize = True
        Me.lblConditionDateTo.BackColor = System.Drawing.Color.Transparent
        Me.lblConditionDateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConditionDateTo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblConditionDateTo.Location = New System.Drawing.Point(0, 0)
        Me.lblConditionDateTo.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblConditionDateTo.Name = "lblConditionDateTo"
        Me.lblConditionDateTo.Size = New System.Drawing.Size(78, 13)
        Me.lblConditionDateTo.TabIndex = 15
        Me.lblConditionDateTo.Text = "Date Up To (<)"
        '
        'cmdDateTo
        '
        Me.cmdDateTo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdDateTo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmdDateTo.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.cmdDateTo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdDateTo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdDateTo.FlatAppearance.BorderColor = System.Drawing.Color.Lavender
        Me.cmdDateTo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cmdDateTo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender
        Me.cmdDateTo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDateTo.ForeColor = System.Drawing.Color.Black
        Me.cmdDateTo.Location = New System.Drawing.Point(6, 25)
        Me.cmdDateTo.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdDateTo.Name = "cmdDateTo"
        Me.cmdDateTo.Size = New System.Drawing.Size(122, 29)
        Me.cmdDateTo.TabIndex = 0
        Me.cmdDateTo.Text = "Click for Date"
        Me.cmdDateTo.UseVisualStyleBackColor = False
        '
        'pnlConditionDateFrom
        '
        Me.pnlConditionDateFrom.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlConditionDateFrom.Controls.Add(Me.lblConditionDateFrom)
        Me.pnlConditionDateFrom.Controls.Add(Me.cmdDateFrom)
        Me.pnlConditionDateFrom.Location = New System.Drawing.Point(12, 208)
        Me.pnlConditionDateFrom.Margin = New System.Windows.Forms.Padding(6)
        Me.pnlConditionDateFrom.Name = "pnlConditionDateFrom"
        Me.pnlConditionDateFrom.Size = New System.Drawing.Size(135, 66)
        Me.pnlConditionDateFrom.TabIndex = 71
        Me.pnlConditionDateFrom.Visible = False
        '
        'lblConditionDateFrom
        '
        Me.lblConditionDateFrom.AutoSize = True
        Me.lblConditionDateFrom.BackColor = System.Drawing.Color.Transparent
        Me.lblConditionDateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConditionDateFrom.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblConditionDateFrom.Location = New System.Drawing.Point(0, 0)
        Me.lblConditionDateFrom.Margin = New System.Windows.Forms.Padding(6)
        Me.lblConditionDateFrom.Name = "lblConditionDateFrom"
        Me.lblConditionDateFrom.Size = New System.Drawing.Size(77, 13)
        Me.lblConditionDateFrom.TabIndex = 15
        Me.lblConditionDateFrom.Text = "Date From (>=)"
        '
        'cmdDateFrom
        '
        Me.cmdDateFrom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmdDateFrom.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.cmdDateFrom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdDateFrom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdDateFrom.FlatAppearance.BorderColor = System.Drawing.Color.Lavender
        Me.cmdDateFrom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.cmdDateFrom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender
        Me.cmdDateFrom.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDateFrom.ForeColor = System.Drawing.Color.Black
        Me.cmdDateFrom.Location = New System.Drawing.Point(6, 25)
        Me.cmdDateFrom.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdDateFrom.Name = "cmdDateFrom"
        Me.cmdDateFrom.Size = New System.Drawing.Size(122, 29)
        Me.cmdDateFrom.TabIndex = 0
        Me.cmdDateFrom.Text = "Click for Date"
        Me.cmdDateFrom.UseVisualStyleBackColor = False
        '
        'lblReportDescription
        '
        Me.lblReportDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportDescription.ForeColor = System.Drawing.Color.Gray
        Me.lblReportDescription.Location = New System.Drawing.Point(12, 31)
        Me.lblReportDescription.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblReportDescription.Name = "lblReportDescription"
        Me.lblReportDescription.Size = New System.Drawing.Size(470, 158)
        Me.lblReportDescription.TabIndex = 0
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.BackColor = System.Drawing.Color.Transparent
        Me.lblResults.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblResults.Location = New System.Drawing.Point(21, 315)
        Me.lblResults.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(42, 13)
        Me.lblResults.TabIndex = 16
        Me.lblResults.Text = "Results"
        '
        'lvwResults
        '
        Me.lvwResults.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwResults.FullRowSelect = True
        Me.lvwResults.Location = New System.Drawing.Point(24, 334)
        Me.lvwResults.Margin = New System.Windows.Forms.Padding(6)
        Me.lvwResults.MultiSelect = False
        Me.lvwResults.Name = "lvwResults"
        Me.lvwResults.Size = New System.Drawing.Size(937, 235)
        Me.lvwResults.TabIndex = 17
        Me.lvwResults.UseCompatibleStateImageBehavior = False
        Me.lvwResults.View = System.Windows.Forms.View.Details
        '
        'PrintDialog
        '
        Me.PrintDialog.Document = Me.PrintDoc
        Me.PrintDialog.UseEXDialog = True
        '
        'PrintDoc
        '
        '
        'pnlBottomBar
        '
        Me.pnlBottomBar.BackColor = System.Drawing.Color.White
        Me.pnlBottomBar.Controls.Add(Me.blCopyright)
        Me.pnlBottomBar.Controls.Add(Me.ctlPrint)
        Me.pnlBottomBar.Controls.Add(Me.ctlExcel)
        Me.pnlBottomBar.Controls.Add(Me.ctlReport)
        Me.pnlBottomBar.Controls.Add(Me.cmdClose)
        Me.pnlBottomBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottomBar.Location = New System.Drawing.Point(0, 592)
        Me.pnlBottomBar.Margin = New System.Windows.Forms.Padding(6)
        Me.pnlBottomBar.Name = "pnlBottomBar"
        Me.pnlBottomBar.Size = New System.Drawing.Size(985, 57)
        Me.pnlBottomBar.TabIndex = 59
        '
        'ctlPrint
        '
        Me.ctlPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ctlPrint.BackColor = System.Drawing.Color.Transparent
        Me.ctlPrint.ColourHighlight = System.Drawing.Color.Lavender
        Me.ctlPrint.Image = CType(resources.GetObject("ctlPrint.Image"), System.Drawing.Image)
        Me.ctlPrint.Location = New System.Drawing.Point(786, 7)
        Me.ctlPrint.MaximumSize = New System.Drawing.Size(0, 38)
        Me.ctlPrint.MinimumSize = New System.Drawing.Size(100, 38)
        Me.ctlPrint.Name = "ctlPrint"
        Me.ctlPrint.Selected = False
        Me.ctlPrint.Size = New System.Drawing.Size(100, 38)
        Me.ctlPrint.TabIndex = 6
        Me.ctlPrint.TextDescription = "Results"
        Me.ctlPrint.TextTitle = "Print"
        '
        'ctlExcel
        '
        Me.ctlExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ctlExcel.BackColor = System.Drawing.Color.Transparent
        Me.ctlExcel.ColourHighlight = System.Drawing.Color.Lavender
        Me.ctlExcel.Image = CType(resources.GetObject("ctlExcel.Image"), System.Drawing.Image)
        Me.ctlExcel.Location = New System.Drawing.Point(680, 7)
        Me.ctlExcel.MaximumSize = New System.Drawing.Size(0, 38)
        Me.ctlExcel.MinimumSize = New System.Drawing.Size(100, 38)
        Me.ctlExcel.Name = "ctlExcel"
        Me.ctlExcel.Selected = False
        Me.ctlExcel.Size = New System.Drawing.Size(100, 38)
        Me.ctlExcel.TabIndex = 5
        Me.ctlExcel.TextDescription = "Export"
        Me.ctlExcel.TextTitle = "Excel"
        '
        'ctlReport
        '
        Me.ctlReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ctlReport.BackColor = System.Drawing.Color.Transparent
        Me.ctlReport.ColourHighlight = System.Drawing.Color.Lavender
        Me.ctlReport.Image = CType(resources.GetObject("ctlReport.Image"), System.Drawing.Image)
        Me.ctlReport.Location = New System.Drawing.Point(12, 7)
        Me.ctlReport.MaximumSize = New System.Drawing.Size(0, 38)
        Me.ctlReport.MinimumSize = New System.Drawing.Size(100, 38)
        Me.ctlReport.Name = "ctlReport"
        Me.ctlReport.Selected = False
        Me.ctlReport.Size = New System.Drawing.Size(100, 38)
        Me.ctlReport.TabIndex = 4
        Me.ctlReport.TextDescription = "Report"
        Me.ctlReport.TextTitle = "Run"
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdClose.Location = New System.Drawing.Point(895, 19)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 3
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'blCopyright
        '
        Me.blCopyright.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.blCopyright.BackColor = System.Drawing.Color.Transparent
        Me.blCopyright.Font = New System.Drawing.Font("Calibri", 10.125!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.blCopyright.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.blCopyright.Location = New System.Drawing.Point(118, 14)
        Me.blCopyright.Name = "blCopyright"
        Me.blCopyright.Size = New System.Drawing.Size(556, 29)
        Me.blCopyright.TabIndex = 62
        Me.blCopyright.Text = "© Paul Panayis, 2018"
        Me.blCopyright.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Reports
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(985, 649)
        Me.Controls.Add(Me.pnlBottomBar)
        Me.Controls.Add(Me.lvwResults)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.fraReport)
        Me.Controls.Add(Me.lvwReports)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Reports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reports"
        Me.fraReport.ResumeLayout(False)
        Me.pnlConditionDateTo.ResumeLayout(False)
        Me.pnlConditionDateTo.PerformLayout()
        Me.pnlConditionDateFrom.ResumeLayout(False)
        Me.pnlConditionDateFrom.PerformLayout()
        Me.pnlBottomBar.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvwReports As ListView
    Friend WithEvents fraReport As GroupBox
    Friend WithEvents pnlConditionDateTo As Panel
    Friend WithEvents lblConditionDateTo As Label
    Friend WithEvents cmdDateTo As Button
    Friend WithEvents pnlConditionDateFrom As Panel
    Friend WithEvents lblConditionDateFrom As Label
    Friend WithEvents cmdDateFrom As Button
    Friend WithEvents lblReportDescription As Label
    Friend WithEvents lblResults As Label
    Friend WithEvents lvwResults As ListView
    Friend WithEvents PrintDialog As PrintDialog
    Friend WithEvents PrintDoc As Printing.PrintDocument
    Friend WithEvents pnlBottomBar As Panel
    Friend WithEvents cmdClose As Button
    Friend WithEvents ctlPrint As ctlRichButtonSmall
    Friend WithEvents ctlExcel As ctlRichButtonSmall
    Friend WithEvents ctlReport As ctlRichButtonSmall
    Friend WithEvents blCopyright As Label
End Class
