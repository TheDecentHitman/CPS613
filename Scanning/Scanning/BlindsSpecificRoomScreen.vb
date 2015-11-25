Public Class BlindsSpecificRoomScreen
    ' TODO

    Private Sub BlindsSpecRoom_LivingRoomButton_Click(sender As Object, e As EventArgs) Handles BlindsSpecRoom_LivingRoomButton.Click
        MainForm.ChangeScreen(Me, New WindowBlindOpenCloseScreen)
    End Sub

    Private Sub BlindsSpecRoom_KitchenButton_Click(sender As Object, e As EventArgs) Handles BlindsSpecRoom_KitchenButton.Click
        MainForm.ChangeScreen(Me, New WindowBlindOpenCloseScreen)

    End Sub

    Private Sub BlindsSpecRoom_BedroomButton_Click(sender As Object, e As EventArgs) Handles BlindsSpecRoom_BedroomButton.Click
        MainForm.ChangeScreen(Me, New WindowBlindOpenCloseScreen)
    End Sub
End Class
