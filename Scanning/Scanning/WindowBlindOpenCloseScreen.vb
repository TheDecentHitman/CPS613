Public Class WindowBlindOpenCloseScreen

    Private Sub WindowBlindOpenButton_Click(sender As Object, e As EventArgs) Handles WindowBlindOpenButton.Click
        MainForm.ChangeScreen(Me, New HomeScreen)
    End Sub

    Private Sub WindowBlindCloseButton_Click(sender As Object, e As EventArgs) Handles WindowBlindCloseButton.Click
        MainForm.ChangeScreen(Me, New HomeScreen)
    End Sub
End Class
