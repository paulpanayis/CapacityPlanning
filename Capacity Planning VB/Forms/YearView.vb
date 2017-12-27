Public Class YearView
    Private Sub ctlYearView_Resize(sender As Object, e As EventArgs) Handles ctlYearView.Resize
        ctlYearView.Refresh()
    End Sub

    Private Sub cmdYearUp_Click(sender As Object, e As EventArgs) Handles cmdYearUp.Click
        lblYear.Text = Val(lblYear.Text) + 1
        Me.Text = "Year View " + lblYear.Text
        ctlYearView.ActiveYear = lblYear.Text
        ctlYearView.Refresh()
    End Sub

    Private Sub cmdYearDown_Click(sender As Object, e As EventArgs) Handles cmdYearDown.Click
        lblYear.Text = Val(lblYear.Text) - 1
        Me.Text = "Year View " + lblYear.Text
        ctlYearView.ActiveYear = lblYear.Text
        ctlYearView.Refresh()
    End Sub

    Private Sub ctlYearView_DateClick(sender As Object, e As Date) Handles ctlYearView.DateClick
        ' lblDateClicked.Text = e.ToLongDateString
    End Sub

    Private Sub ctlYearView_DateOver(sender As Object, e As Date) Handles ctlYearView.DateOver
        ' lblDateOver.Text = e.ToLongDateString
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

End Class

