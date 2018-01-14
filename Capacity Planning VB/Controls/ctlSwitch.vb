Public Class ctlSwitch

    Private mblnOn As Boolean = False
    Public Event Clicked(ByVal sender As Object)

    Public Enum enumSwitchType
        ' these correspond to the indexes of these images
        ' in the imlBackgrounds control
        BlueOnWhiteOff = 0
        GreenGoWhiteOff = 1
        GrrenOkRedErr = 2
        GreenYesRedNo = 3
        GreenYesWhiteNo = 4
        OrangeOnWhiteOff = 5
        OrangeYesWhiteNo = 6
        WhiteOnRedOff = 7
        TransparentYesWhiteNo = 8
        TransparentOnWhiteOff = 9
        ' different switch type
        ButtonBlueOn = 10
        ButtonGreenGo = 11
        ButtonGreenOk = 12
        ButtonGreenTick = 13
        ButtonGreenYes = 14
        ButtonOrangeOn = 15
        ButtonOrangeYes = 16
        ButtonWhiteOn = 17
        ButtonTransparentYes = 18
        ButtonTransparentOn = 19
    End Enum

    Private mtypeSwitchType As enumSwitchType = 0
    Public Property SwitchType() As enumSwitchType
        Get
            Return mtypeSwitchType
        End Get
        Set(ByVal value As enumSwitchType)
            mtypeSwitchType = value
            If value < enumSwitchType.ButtonBlueOn Then
                picSwitch.BackgroundImage = imlBackgrounds.Images(value)
                Me.Width = 86
                Me.Height = 30
                picSwitch.Width = 86
                picSwitch.Height = 30
            Else
                picSwitch.BackgroundImage = imlButtons.Images(value + 1 - enumSwitchType.ButtonBlueOn)
                picSwitch.Image = Nothing
                Me.Width = 43
                Me.Height = 30
                picSwitch.Width = 43
                picSwitch.Height = 30
            End If
            CheckText()
        End Set
    End Property

    Public Property Value() As Boolean
        Get
            Return mblnOn
        End Get
        Set(ByVal value As Boolean)
            mblnOn = value
            If SwitchType < enumSwitchType.ButtonBlueOn Then
                If mblnOn = True Then
                    picSwitch.Image = imlSwitch.Images("On")
                Else
                    picSwitch.Image = imlSwitch.Images("Off")
                End If
            Else
                If mblnOn = True Then
                    picSwitch.BackgroundImage = imlButtons.Images(SwitchType + 1 - enumSwitchType.ButtonBlueOn)
                Else
                    picSwitch.BackgroundImage = imlButtons.Images(0)
                End If
            End If
            CheckText()
        End Set
    End Property

    Private Sub CheckText()
        ' now see if we need to display the transparent text overlay
        If mtypeSwitchType = enumSwitchType.TransparentYesWhiteNo Then
            If lblOnText.Text <> "YES" Then
                lblOnText.Text = "YES"
            End If
            If lblOnText.Visible <> mblnOn Then
                lblOnText.Visible = mblnOn
            End If
        ElseIf mtypeSwitchType = enumSwitchType.TransparentOnWhiteOff Then
            If lblOnText.Text <> "ON" Then
                lblOnText.Text = "ON"
            End If
            If lblOnText.Visible <> mblnOn Then
                lblOnText.Visible = mblnOn
            End If
        ElseIf mtypeSwitchType = enumSwitchType.ButtonTransparentYes Then
            If lblOnText.Text <> "YES" Then
                lblOnText.Text = "YES"
            End If
            If lblOnText.Visible <> mblnOn Then
                lblOnText.Visible = mblnOn
            End If
        ElseIf mtypeSwitchType = enumSwitchType.ButtonTransparentOn Then
            If lblOnText.Text <> "ON" Then
                lblOnText.Text = "ON"
            End If
            If lblOnText.Visible <> mblnOn Then
                lblOnText.Visible = mblnOn
            End If
        Else
            If lblOnText.Visible = True Then
                lblOnText.Visible = False
            End If
        End If
    End Sub

    Private Sub picSwitch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picSwitch.Click, lblOnText.Click
        ' user has clicked on the control, so flick the switch
        ' flip the on/off state of the switch
        Value = True - mblnOn
        RaiseEvent Clicked(Me)
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        picSwitch.BackgroundImage = imlBackgrounds.Images(0)
        picSwitch.Image = imlSwitch.Images("Off")
    End Sub

    Private Sub ctlSwitch_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If SwitchType < enumSwitchType.ButtonBlueOn Then
            picSwitch.BackgroundImage = imlBackgrounds.Images(SwitchType)
            Me.Width = 86
            Me.Height = 30
            picSwitch.Width = 86
            picSwitch.Height = 30
        Else
            picSwitch.BackgroundImage = imlBackgrounds.Images(SwitchType + 1 - enumSwitchType.ButtonBlueOn)
            picSwitch.Image = Nothing
            Me.Width = 43
            Me.Height = 30
            picSwitch.Width = 43
            picSwitch.Height = 30
        End If
    End Sub

    Public Property TextColour() As Color
        Get
            Return lblOnText.ForeColor
        End Get
        Set(ByVal value As Color)
            lblOnText.ForeColor = value
        End Set
    End Property
End Class
