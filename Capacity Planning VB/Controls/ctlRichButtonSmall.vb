Public Class ctlRichButtonSmall
    Public Event Clicked()

    Private Sub cmdPic_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdPic.Click, lblText.LinkClicked, lblText.Click, lblHeader.LinkClicked, lblHeader.Click
        RaiseEvent Clicked()
    End Sub

    Private Sub pnlControl_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlControl.Click
        RaiseEvent Clicked()
    End Sub

    Private Sub cmdPic_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblText.MouseEnter, lblHeader.MouseEnter, Me.MouseEnter, pnlControl.MouseEnter, cmdPic.MouseEnter
        cmdPic.BackColor = ColourHighlight
        Me.BackColor = ColourHighlight
    End Sub

    Private Sub cmdPic_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblText.MouseLeave, lblHeader.MouseLeave, Me.MouseLeave, pnlControl.MouseLeave, cmdPic.MouseLeave
        cmdPic.BackColor = Color.Transparent
        Me.BackColor = Color.White
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
            Return cmdPic.BackgroundImage
        End Get
        Set(ByVal value As Image)
            cmdPic.BackgroundImage = value
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

End Class
