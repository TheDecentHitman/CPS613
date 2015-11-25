Public Class LightsScreen

    Private Sub LightsCentralAptButton_Click(sender As Object, e As EventArgs) Handles LightsCentralAptButton.Click
        If (MainForm.lightsOn(0) OrElse MainForm.lightsOn(1) OrElse MainForm.lightsOn(2)) Then
            MainForm.lightsOn(0) = False
            MainForm.lightsOn(1) = False
            MainForm.lightsOn(2) = False
            LightsCentralAptButton.Text = "All On"
        Else
            MainForm.lightsOn(0) = True
            MainForm.lightsOn(1) = True
            MainForm.lightsOn(2) = True
            LightsCentralAptButton.Text = "All Off"
        End If
    End Sub

    Private Sub LightsSpecRoomButton_Click(sender As Object, e As EventArgs) Handles LightsSpecRoomButton.Click
        MainForm.ChangeScreen(Me, New LightsSpecificRoomScreen)
    End Sub

    Private Sub LightsScreen_Load(sender As Object, e As EventArgs) Handles Me.Load
        If (MainForm.lightsOn(0) OrElse MainForm.lightsOn(1) OrElse MainForm.lightsOn(2)) Then
            LightsCentralAptButton.Text = "All Off"
        Else
            LightsCentralAptButton.Text = "All On"
        End If
    End Sub
End Class
