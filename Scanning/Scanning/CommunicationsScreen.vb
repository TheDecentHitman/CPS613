Public Class CommunicationsScreen

    Private Sub PhoneButton_Click(sender As Object, e As EventArgs) Handles PhoneButton.Click
        MainForm.ChangeScreen(Me, New PhoneScreen)
    End Sub

    Private Sub MessageButton_Click(sender As Object, e As EventArgs) Handles MessageButton.Click
        MainForm.ChangeScreen(Me, New MessageScreen)
    End Sub
End Class
