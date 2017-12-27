Public Class ctlBigButton
    Public Event Clicked()
    Private mblnSmallSize As Boolean


    Private Sub cmdPic_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblText.Click, lblHeader.Click, Me.Click, cmdPic.Click
        RaiseEvent Clicked()
    End Sub

    Private Sub cmdPic_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblText.MouseEnter, lblHeader.MouseEnter, Me.MouseEnter, cmdPic.MouseEnter
        cmdPic.BackColor = ColourHighlight
        Me.BackColor = ColourHighlight
    End Sub

    Private Sub cmdPic_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblText.MouseLeave, lblHeader.MouseLeave, Me.MouseLeave, cmdPic.MouseLeave
        cmdPic.BackColor = Color.Transparent
        Me.BackColor = Color.Transparent
    End Sub

    Private mblnSelected As Boolean = False
    Public Property Selected() As Boolean
        Get
            Return mblnSelected
        End Get
        Set(ByVal value As Boolean)
            mblnSelected = value
            If mblnSelected = True Then
                Me.BackColor = Color.PaleGoldenrod
            Else
                Me.BackColor = Color.Transparent
            End If
        End Set
    End Property

    Private mcolColourHighlight As Color = Color.Lavender
    Public Property ColourHighlight() As Color
        Get
            Return mcolColourHighlight
        End Get
        Set(ByVal value As Color)
            mcolColourHighlight = value
        End Set
    End Property

    Public Property Image() As Image
        Get
            Return cmdPic.Image
        End Get
        Set(ByVal value As Image)
            cmdPic.Image = value
        End Set
    End Property

    Public Property TextTitle() As String
        Get
            Return lblHeader.Text
        End Get
        Set(ByVal value As String)
            lblHeader.Text = value
        End Set
    End Property

    Public Property TextDescription() As String
        Get
            Return lblText.Text
        End Get
        Set(ByVal value As String)
            lblText.Text = value
        End Set
    End Property

    Private Sub ctlBigButton_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.SuspendLayout()

        ' see if we are working in a small size or large size
        ' this will affect the control layout
        If Me.Height < 90 Or Me.Width < 250 Then
            mblnSmallSize = True
        Else
            mblnSmallSize = False
        End If

        If mblnSmallSize Then
            cmdPic.Padding = New Padding(1, 1, 1, 1)
            lblHeader.Padding = New Padding(1, 1, 1, 1)
            lblHeader.Height = 30
            lblText.Padding = New Padding(1, 1, 1, 1)

            cmdPic.Location = New Point(1, 1)
            cmdPic.Size = New Size(Me.Height - 2, Me.Height - 2)
            lblHeader.Location = New Point(Me.Height, 1)
            lblHeader.Width = Me.Width - lblHeader.Left - 1
            lblText.Location = New Point(Me.Height, lblHeader.Top + lblHeader.Height + 1)
            lblText.Size = New Size(lblHeader.Width, Me.Height - lblText.Top - 1)
        Else
            cmdPic.Padding = New Padding(6, 6, 6, 6)
            lblHeader.Padding = New Padding(6, 6, 6, 6)
            lblHeader.Height = 39
            lblText.Padding = New Padding(6, 6, 6, 6)

            cmdPic.Location = New Point(3, 3)
            cmdPic.Size = New Size(Me.Height - 6, Me.Height - 6)
            lblHeader.Location = New Point(Me.Height, 3)
            lblHeader.Width = Me.Width - lblHeader.Left - 3
            lblText.Location = New Point(Me.Height, lblHeader.Top + lblHeader.Height + 3)
            lblText.Size = New Size(lblHeader.Width, Me.Height - lblText.Top - 3)
        End If
        Me.ResumeLayout(True)
    End Sub
End Class
