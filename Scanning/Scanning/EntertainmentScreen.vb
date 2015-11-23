Public Class EntertainmentScreen

    Private Sub AudioButton_Click(sender As Object, e As EventArgs) Handles AudioButton.Click
        MainForm.ChangeScreen(Me, New AudioScreen)
    End Sub

    Private Sub MusicButton_Click(sender As Object, e As EventArgs) Handles MusicButton.Click
        MainForm.ChangeScreen(Me, New MusicScreen)
    End Sub

    Private Sub TVButton_Click(sender As Object, e As EventArgs) Handles TVButton.Click
        MainForm.ChangeScreen(Me, New TVScreen)
    End Sub
End Class
