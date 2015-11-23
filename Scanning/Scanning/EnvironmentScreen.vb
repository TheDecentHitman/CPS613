Public Class EnvironmentScreen

    Private Sub TemperatureFansButton_Click(sender As Object, e As EventArgs) Handles TemperatureFansButton.Click
        MainForm.ChangeScreen(Me, New TemperatureAndFansScreen)
    End Sub

    Private Sub WindowsandBlindsButton_Click(sender As Object, e As EventArgs) Handles WindowsandBlindsButton.Click
        MainForm.ChangeScreen(Me, New WindowsAndBlindsScreen)
    End Sub

    Private Sub LightsButton_Click(sender As Object, e As EventArgs) Handles LightsButton.Click
        MainForm.ChangeScreen(Me, New LightsScreen)
    End Sub
End Class
