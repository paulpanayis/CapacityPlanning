Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class About
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub About_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub

    Private Sub About_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        MainMenu.Focus()
    End Sub

    Private Sub About_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblCopyright.Text = My.Settings.Copyright
    End Sub
End Class