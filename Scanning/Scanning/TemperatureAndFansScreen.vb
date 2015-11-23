Public Class TemperatureAndFansScreen

    Private Sub TempCentralAptButton_Click(sender As Object, e As EventArgs) Handles TempCentralAptButton.Click
        ' TODO
    End Sub

    Private Sub TempSpecRoomButton_Click(sender As Object, e As EventArgs) Handles TempSpecRoomButton.Click
        MainForm.ChangeScreen(Me, New TemperatureSpecificRoomScreen)
    End Sub

    Private Sub FansCentralAptButton_Click(sender As Object, e As EventArgs) Handles FansCentralAptButton.Click
        ' TODO
    End Sub

    Private Sub FansSpecRoomButton_Click(sender As Object, e As EventArgs) Handles FansSpecRoomButton.Click
        MainForm.ChangeScreen(Me, New FansSpecificRoomScreen)
    End Sub
End Class
