Public Class LightsScreen

    Private Sub LightsCentralAptButton_Click(sender As Object, e As EventArgs) Handles LightsCentralAptButton.Click
        ' TODO
    End Sub

    Private Sub LightsSpecRoomButton_Click(sender As Object, e As EventArgs) Handles LightsSpecRoomButton.Click
        MainForm.ChangeScreen(Me, New LightsSpecificRoomScreen)
    End Sub
End Class
