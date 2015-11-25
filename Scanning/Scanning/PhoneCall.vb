Public Class PhoneCall

    Private Sub StandardVoiceMessagetton_Click(sender As Object, e As EventArgs) Handles StandardVoiceMessagetton.Click
        ' TODO Show list of voice messages to send
    End Sub

    Private Sub HangUpButton_Click(sender As Object, e As EventArgs) Handles HangUpButton.Click
        MainForm.onPhone = False
        Dim newHomeScreen As New HomeScreen
        newHomeScreen.CommunicationsButton.Text = "Communications"
        MainForm.ChangeScreen(Me, newHomeScreen)
        ' TODO Close window, return to scanning main form
    End Sub
End Class