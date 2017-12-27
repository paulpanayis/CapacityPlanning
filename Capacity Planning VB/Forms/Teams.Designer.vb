<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Teams
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Teams))
        Me.pnlBottomBar = New System.Windows.Forms.Panel()
        Me.blCopyright = New System.Windows.Forms.Label()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.lvwPeople = New System.Windows.Forms.ListView()
        Me.tabMain = New System.Windows.Forms.TabControl()
        Me.tabTeams = New System.Windows.Forms.TabPage()
        Me.ctlDeleteTeam = New Capacity_Planning.ctlRichButtonSmall()
        Me.ctlAddTeam = New Capacity_Planning.ctlRichButtonSmall()
        Me.lvwTeams = New System.Windows.Forms.ListView()
        Me.tabPeople = New System.Windows.Forms.TabPage()
        Me.cboTeams = New System.Windows.Forms.ComboBox()
        Me.ctlAddPerson = New Capacity_Planning.ctlRichButtonSmall()
        Me.ctlDeletePerson = New Capacity_Planning.ctlRichButtonSmall()
        Me.lblTeams = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnlBottomBar.SuspendLayout()
        Me.tabMain.SuspendLayout()
        Me.tabTeams.SuspendLayout()
        Me.tabPeople.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBottomBar
        '
        Me.pnlBottomBar.BackColor = System.Drawing.Color.Transparent
        Me.pnlBottomBar.Controls.Add(Me.blCopyright)
        Me.pnlBottomBar.Controls.Add(Me.cmdClose)
        Me.pnlBottomBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottomBar.Location = New System.Drawing.Point(0, 577)
        Me.pnlBottomBar.Margin = New System.Windows.Forms.Padding(6)
        Me.pnlBottomBar.Name = "pnlBottomBar"
        Me.pnlBottomBar.Size = New System.Drawing.Size(842, 68)
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
        Me.cmdClose.Location = New System.Drawing.Point(705, 24)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(122, 29)
        Me.cmdClose.TabIndex = 3
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'lvwPeople
        '
        Me.lvwPeople.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwPeople.FullRowSelect = True
        Me.lvwPeople.Location = New System.Drawing.Point(9, 42)
        Me.lvwPeople.Margin = New System.Windows.Forms.Padding(6)
        Me.lvwPeople.MultiSelect = False
        Me.lvwPeople.Name = "lvwPeople"
        Me.lvwPeople.Size = New System.Drawing.Size(686, 394)
        Me.lvwPeople.TabIndex = 63
        Me.lvwPeople.UseCompatibleStateImageBehavior = False
        Me.lvwPeople.View = System.Windows.Forms.View.Details
        '
        'tabMain
        '
        Me.tabMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabMain.Controls.Add(Me.tabTeams)
        Me.tabMain.Controls.Add(Me.tabPeople)
        Me.tabMain.Location = New System.Drawing.Point(12, 12)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedIndex = 0
        Me.tabMain.Size = New System.Drawing.Size(818, 556)
        Me.tabMain.TabIndex = 69
        '
        'tabTeams
        '
        Me.tabTeams.Controls.Add(Me.ComboBox2)
        Me.tabTeams.Controls.Add(Me.Label2)
        Me.tabTeams.Controls.Add(Me.ComboBox1)
        Me.tabTeams.Controls.Add(Me.Label1)
        Me.tabTeams.Controls.Add(Me.txtName)
        Me.tabTeams.Controls.Add(Me.lblName)
        Me.tabTeams.Controls.Add(Me.ctlDeleteTeam)
        Me.tabTeams.Controls.Add(Me.ctlAddTeam)
        Me.tabTeams.Controls.Add(Me.lvwTeams)
        Me.tabTeams.Controls.Add(Me.lblTeams)
        Me.tabTeams.Location = New System.Drawing.Point(4, 22)
        Me.tabTeams.Name = "tabTeams"
        Me.tabTeams.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTeams.Size = New System.Drawing.Size(810, 530)
        Me.tabTeams.TabIndex = 0
        Me.tabTeams.Text = "Teams"
        Me.tabTeams.UseVisualStyleBackColor = True
        '
        'ctlDeleteTeam
        '
        Me.ctlDeleteTeam.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ctlDeleteTeam.BackColor = System.Drawing.Color.Transparent
        Me.ctlDeleteTeam.ColourHighlight = System.Drawing.Color.Lavender
        Me.ctlDeleteTeam.Image = CType(resources.GetObject("ctlDeleteTeam.Image"), System.Drawing.Image)
        Me.ctlDeleteTeam.Location = New System.Drawing.Point(704, 486)
        Me.ctlDeleteTeam.MaximumSize = New System.Drawing.Size(0, 38)
        Me.ctlDeleteTeam.MinimumSize = New System.Drawing.Size(100, 38)
        Me.ctlDeleteTeam.Name = "ctlDeleteTeam"
        Me.ctlDeleteTeam.Selected = False
        Me.ctlDeleteTeam.Size = New System.Drawing.Size(100, 38)
        Me.ctlDeleteTeam.TabIndex = 65
        Me.ctlDeleteTeam.TextDescription = "Team"
        Me.ctlDeleteTeam.TextTitle = "Delete"
        '
        'ctlAddTeam
        '
        Me.ctlAddTeam.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ctlAddTeam.BackColor = System.Drawing.Color.Transparent
        Me.ctlAddTeam.ColourHighlight = System.Drawing.Color.Lavender
        Me.ctlAddTeam.Image = CType(resources.GetObject("ctlAddTeam.Image"), System.Drawing.Image)
        Me.ctlAddTeam.Location = New System.Drawing.Point(704, 6)
        Me.ctlAddTeam.MaximumSize = New System.Drawing.Size(0, 38)
        Me.ctlAddTeam.MinimumSize = New System.Drawing.Size(100, 38)
        Me.ctlAddTeam.Name = "ctlAddTeam"
        Me.ctlAddTeam.Selected = False
        Me.ctlAddTeam.Size = New System.Drawing.Size(100, 38)
        Me.ctlAddTeam.TabIndex = 64
        Me.ctlAddTeam.TextDescription = "Team"
        Me.ctlAddTeam.TextTitle = "New"
        '
        'lvwTeams
        '
        Me.lvwTeams.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwTeams.FullRowSelect = True
        Me.lvwTeams.Location = New System.Drawing.Point(9, 9)
        Me.lvwTeams.Margin = New System.Windows.Forms.Padding(6)
        Me.lvwTeams.MultiSelect = False
        Me.lvwTeams.Name = "lvwTeams"
        Me.lvwTeams.Size = New System.Drawing.Size(686, 384)
        Me.lvwTeams.TabIndex = 63
        Me.lvwTeams.UseCompatibleStateImageBehavior = False
        Me.lvwTeams.View = System.Windows.Forms.View.Details
        '
        'tabPeople
        '
        Me.tabPeople.Controls.Add(Me.ComboBox3)
        Me.tabPeople.Controls.Add(Me.Label3)
        Me.tabPeople.Controls.Add(Me.TextBox1)
        Me.tabPeople.Controls.Add(Me.Label4)
        Me.tabPeople.Controls.Add(Me.cboTeams)
        Me.tabPeople.Controls.Add(Me.lvwPeople)
        Me.tabPeople.Controls.Add(Me.ctlAddPerson)
        Me.tabPeople.Controls.Add(Me.ctlDeletePerson)
        Me.tabPeople.Controls.Add(Me.Label5)
        Me.tabPeople.ForeColor = System.Drawing.Color.Blue
        Me.tabPeople.Location = New System.Drawing.Point(4, 22)
        Me.tabPeople.Name = "tabPeople"
        Me.tabPeople.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPeople.Size = New System.Drawing.Size(810, 530)
        Me.tabPeople.TabIndex = 1
        Me.tabPeople.Text = "People"
        Me.tabPeople.UseVisualStyleBackColor = True
        '
        'cboTeams
        '
        Me.cboTeams.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTeams.FormattingEnabled = True
        Me.cboTeams.Location = New System.Drawing.Point(9, 12)
        Me.cboTeams.Name = "cboTeams"
        Me.cboTeams.Size = New System.Drawing.Size(686, 21)
        Me.cboTeams.TabIndex = 69
        '
        'ctlAddPerson
        '
        Me.ctlAddPerson.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ctlAddPerson.BackColor = System.Drawing.Color.Transparent
        Me.ctlAddPerson.ColourHighlight = System.Drawing.Color.Lavender
        Me.ctlAddPerson.Image = CType(resources.GetObject("ctlAddPerson.Image"), System.Drawing.Image)
        Me.ctlAddPerson.Location = New System.Drawing.Point(704, 6)
        Me.ctlAddPerson.MaximumSize = New System.Drawing.Size(0, 38)
        Me.ctlAddPerson.MinimumSize = New System.Drawing.Size(100, 38)
        Me.ctlAddPerson.Name = "ctlAddPerson"
        Me.ctlAddPerson.Selected = False
        Me.ctlAddPerson.Size = New System.Drawing.Size(100, 38)
        Me.ctlAddPerson.TabIndex = 66
        Me.ctlAddPerson.TextDescription = "Person"
        Me.ctlAddPerson.TextTitle = "New"
        '
        'ctlDeletePerson
        '
        Me.ctlDeletePerson.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ctlDeletePerson.BackColor = System.Drawing.Color.Transparent
        Me.ctlDeletePerson.ColourHighlight = System.Drawing.Color.Lavender
        Me.ctlDeletePerson.Image = CType(resources.GetObject("ctlDeletePerson.Image"), System.Drawing.Image)
        Me.ctlDeletePerson.Location = New System.Drawing.Point(704, 486)
        Me.ctlDeletePerson.MaximumSize = New System.Drawing.Size(0, 38)
        Me.ctlDeletePerson.MinimumSize = New System.Drawing.Size(100, 38)
        Me.ctlDeletePerson.Name = "ctlDeletePerson"
        Me.ctlDeletePerson.Selected = False
        Me.ctlDeletePerson.Size = New System.Drawing.Size(100, 38)
        Me.ctlDeletePerson.TabIndex = 67
        Me.ctlDeletePerson.TextDescription = "Person"
        Me.ctlDeletePerson.TextTitle = "Delete"
        '
        'lblTeams
        '
        Me.lblTeams.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTeams.AutoSize = True
        Me.lblTeams.BackColor = System.Drawing.Color.Transparent
        Me.lblTeams.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeams.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.lblTeams.Location = New System.Drawing.Point(603, 383)
        Me.lblTeams.Name = "lblTeams"
        Me.lblTeams.Size = New System.Drawing.Size(155, 55)
        Me.lblTeams.TabIndex = 75
        Me.lblTeams.Text = "teams"
        '
        'txtName
        '
        Me.txtName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.Location = New System.Drawing.Point(9, 418)
        Me.txtName.Margin = New System.Windows.Forms.Padding(6)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(439, 20)
        Me.txtName.TabIndex = 76
        '
        'lblName
        '
        Me.lblName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Location = New System.Drawing.Point(6, 399)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(65, 13)
        Me.lblName.TabIndex = 77
        Me.lblName.Text = "Team Name"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(6, 444)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Location"
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(9, 460)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(439, 21)
        Me.ComboBox1.TabIndex = 79
        '
        'ComboBox2
        '
        Me.ComboBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(9, 503)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(439, 21)
        Me.ComboBox2.TabIndex = 81
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(6, 487)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "Sprint Template"
        '
        'ComboBox3
        '
        Me.ComboBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(9, 503)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(439, 21)
        Me.ComboBox3.TabIndex = 83
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(6, 487)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Team"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(9, 461)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(439, 20)
        Me.TextBox1.TabIndex = 80
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(6, 442)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "Name"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(586, 426)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(169, 55)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "people"
        '
        'Teams
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(842, 645)
        Me.Controls.Add(Me.tabMain)
        Me.Controls.Add(Me.pnlBottomBar)
        Me.Name = "Teams"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Teams"
        Me.pnlBottomBar.ResumeLayout(False)
        Me.tabMain.ResumeLayout(False)
        Me.tabTeams.ResumeLayout(False)
        Me.tabTeams.PerformLayout()
        Me.tabPeople.ResumeLayout(False)
        Me.tabPeople.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlBottomBar As Panel
    Friend WithEvents blCopyright As Label
    Friend WithEvents cmdClose As Button
    Friend WithEvents lvwPeople As ListView
    Friend WithEvents ctlDeletePerson As ctlRichButtonSmall
    Friend WithEvents ctlAddPerson As ctlRichButtonSmall
    Friend WithEvents tabMain As TabControl
    Friend WithEvents tabTeams As TabPage
    Friend WithEvents ctlDeleteTeam As ctlRichButtonSmall
    Friend WithEvents ctlAddTeam As ctlRichButtonSmall
    Friend WithEvents lvwTeams As ListView
    Friend WithEvents tabPeople As TabPage
    Friend WithEvents cboTeams As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblTeams As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
