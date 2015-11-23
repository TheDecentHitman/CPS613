Public Class WindowsAndBlindsScreen

    Private Sub WindowsCentralAptButton_Click(sender As Object, e As EventArgs) Handles WindowsCentralAptButton.Click
        ' TODO
    End Sub

    Private Sub WindowsSpecRoomButton_Click(sender As Object, e As EventArgs) Handles WindowsSpecRoomButton.Click
        MainForm.ChangeScreen(Me, New WindowsSpecificRoomScreen)
    End Sub

    Private Sub BlindsCentralAptButton_Click(sender As Object, e As EventArgs) Handles BlindsCentralAptButton.Click
        ' TODO
    End Sub

    Private Sub BlindsSpecRoomButton_Click(sender As Object, e As EventArgs) Handles BlindsSpecRoomButton.Click
        MainForm.ChangeScreen(Me, New BlindsSpecificRoomScreen)
    End Sub
End Class
