Public Class WindowsSpecificRoomScreen
    ' TODO

    Private Sub WindowsSpecRoom_LivingRoomButton_Click(sender As Object, e As EventArgs) Handles WindowsSpecRoom_LivingRoomButton.Click
        MainForm.ChangeScreen(Me, New WindowBlindOpenCloseScreen)
    End Sub

    Private Sub WindowsSpecRoom_KitchenButton_Click(sender As Object, e As EventArgs) Handles WindowsSpecRoom_KitchenButton.Click
        MainForm.ChangeScreen(Me, New WindowBlindOpenCloseScreen)
    End Sub

    Private Sub WindowsSpecRoom_BedroomButton_Click(sender As Object, e As EventArgs) Handles WindowsSpecRoom_BedroomButton.Click
        MainForm.ChangeScreen(Me, New WindowBlindOpenCloseScreen)
    End Sub
End Class
