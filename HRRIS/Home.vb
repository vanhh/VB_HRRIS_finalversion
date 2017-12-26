Public Class frmHome
    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        frmCustomer.Show()
        Me.Hide()
    End Sub

    Private Sub btnRoom_Click(sender As Object, e As EventArgs) Handles btnRoom.Click

        frmRoom.Show()
        Me.Hide()

    End Sub

    Private Sub btnBooking_Click(sender As Object, e As EventArgs) Handles btnBooking.Click

        frmBooking.Show()
            Me.Hide()

    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Me.Hide()
        frmReport.Show()
    End Sub

End Class