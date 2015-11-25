Public Class FansSpecificRoomScreen
    Private Sub FansSpecRoom_LivingRoomButton_Click(sender As Object, e As EventArgs) Handles FansSpecRoom_LivingRoomButton.Click
        MainForm.ChangeScreen(Me, New Fans)
    End Sub

    Private Sub FansSpecRoom_KitchenButton_Click(sender As Object, e As EventArgs) Handles FansSpecRoom_KitchenButton.Click
        MainForm.ChangeScreen(Me, New Fans)
    End Sub

    Private Sub FansSpecRoom_BedroomButton_Click(sender As Object, e As EventArgs) Handles FansSpecRoom_BedroomButton.Click
        MainForm.ChangeScreen(Me, New Fans)
    End Sub
    ' TODO
End Class
