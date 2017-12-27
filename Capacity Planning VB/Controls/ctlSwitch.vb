Public Class ctlSwitch

    Private mblnOn As Boolean = False

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
        ' different switch type
        ButtonBlueOn = 8
        ButtonGreenGo = 9
        ButtonGreenOk = 10
        ButtonGreenTick = 11
        ButtonGreenYes = 12
        ButtonOrangeOn = 13
        ButtonOrangeYes = 14
        ButtonWhiteOn = 15
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
                picSwitch.BackgroundImage = imlButtons.Images(value - 7)
                picSwitch.Image = Nothing
                Me.Width = 43
                Me.Height = 30
                picSwitch.Width = 43
                picSwitch.Height = 30
            End If
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
                    picSwitch.BackgroundImage = imlButtons.Images(SwitchType - 7)
                Else
                    picSwitch.BackgroundImage = imlButtons.Images(0)
                End If
            End If
        End Set
    End Property

    Private Sub picSwitch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picSwitch.Click
        ' user has clicked on the control, so flick the switch
        ' flip the on/off state of the switch
        If SwitchType < enumSwitchType.ButtonBlueOn Then
            mblnOn = True - mblnOn

            If mblnOn = True Then
                picSwitch.Image = imlSwitch.Images("On")
            Else
                picSwitch.Image = imlSwitch.Images("Off")
            End If
        End If
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
            picSwitch.BackgroundImage = imlBackgrounds.Images(SwitchType - 7)
            picSwitch.Image = Nothing
            Me.Width = 43
            Me.Height = 30
            picSwitch.Width = 43
            picSwitch.Height = 30
        End If
    End Sub
End Class
