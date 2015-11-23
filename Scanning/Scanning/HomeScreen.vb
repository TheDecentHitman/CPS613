Public Class HomeScreen

    Private Sub NavigationButton_Click(sender As Object, e As EventArgs) Handles NavigationButton.Click
        MainForm.ChangeScreen(Me, New NavigationScreen)
    End Sub

    Private Sub EnvironmentButton_Click(sender As Object, e As EventArgs) Handles EnvironmentButton.Click
        MainForm.ChangeScreen(Me, New EnvironmentScreen)
    End Sub

    Private Sub EntertainmentButton_Click(sender As Object, e As EventArgs) Handles EntertainmentButton.Click
        MainForm.ChangeScreen(Me, New EntertainmentScreen)
    End Sub

    Private Sub CommunicationButton_Click(sender As Object, e As EventArgs) Handles CommunicationsButton.Click
        MainForm.ChangeScreen(Me, New CommunicationScreen)
    End Sub
End Class
