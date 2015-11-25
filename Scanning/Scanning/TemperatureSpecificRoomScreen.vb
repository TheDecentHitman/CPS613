Public Class TemperatureSpecificRoomScreen
    Private Sub TempSpecRoom_LivingRoomButton_Click(sender As Object, e As EventArgs) Handles TempSpecRoom_LivingRoomButton.Click
        MainForm.ChangeScreen(Me, New Heaters)
    End Sub

    Private Sub TempSpecRoom_KitchenButton_Click(sender As Object, e As EventArgs) Handles TempSpecRoom_KitchenButton.Click
        MainForm.ChangeScreen(Me, New Heaters)
    End Sub

    Private Sub TempSpecRoom_BedroomButton_Click(sender As Object, e As EventArgs) Handles TempSpecRoom_BedroomButton.Click
        MainForm.ChangeScreen(Me, New Heaters)
    End Sub
    ' TODO
End Class
