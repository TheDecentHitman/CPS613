Public Class LightsScreen

    Private Sub LightsCentralAptButton_Click(sender As Object, e As EventArgs) Handles LightsCentralAptButton.Click
        If LightsCentralAptButton.BackColor = DefaultBackColor Then
            LightsCentralAptButton.BackColor = Color.Yellow
        Else If  LightsCentralAptButton.BackColor = Color.Yellow Then
            LightsCentralAptButton.BackColor = DefaultBackColor
        End If
    End Sub

    Private Sub LightsSpecRoomButton_Click(sender As Object, e As EventArgs) Handles LightsSpecRoomButton.Click
        MainForm.ChangeScreen(Me, New LightsSpecificRoomScreen)
    End Sub
End Class
