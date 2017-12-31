Imports System.ComponentModel

Public Class frmTimeSelect

    Private mdteStartTime As Date
    Public Property StartTime() As Date
        Get
            Return mdteStartTime
        End Get
        Set(ByVal value As Date)
            mdteStartTime = value
        End Set
    End Property

    Public ReadOnly Property TimeSelected() As String
        Get
            Return Format(CDate(lstHour.Text & ":" & lstMinutes.Text), "HH:mm")
        End Get
    End Property

    Public Sub Initialise()
        ListBoxSelect(lstHour, Microsoft.VisualBasic.Left(mdteStartTime, 2))
        ListBoxSelect(lstMinutes, Microsoft.VisualBasic.Mid(mdteStartTime, 3))
    End Sub

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        Me.Tag = "OK"
        Me.Hide()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Tag = "Cancel"
        Me.Hide()
    End Sub

    Private Sub frmTimeSelect_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lstHour.SelectedIndex = 0
        lstMinutes.SelectedIndex = 0
        LoadFormSizeAndPosition(Me)
    End Sub

    Private Sub lstMinutes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstMinutes.SelectedIndexChanged
        If lstMinutes.Text <> "" And lstHour.Text <> "" Then
            lbl12hr.Text = Format(CDate(lstHour.Text & ":" & lstMinutes.Text), "h:mm tt")
        End If
    End Sub

    Private Sub lstHour_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstHour.SelectedIndexChanged
        If lstMinutes.Text <> "" And lstHour.Text <> "" Then
            lbl12hr.Text = Format(CDate(lstHour.Text & ":" & lstMinutes.Text), "h:mm tt")
        End If
    End Sub

    Private Sub frmTimeSelect_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SaveFormSizeAndPosition(Me)
    End Sub
End Class