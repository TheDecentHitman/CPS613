Public Class phonecall1
    Private Sub HangUpButton_Click(sender As Object, e As EventArgs) Handles HangUpButton.Click
        MainForm.onPhone = False
        Dim newHomeScreen As New HomeScreen
        newHomeScreen.CommunicationsButton.Text = "Communications"
        MainForm.ChangeScreen(Me, newHomeScreen)
        ' TODO Close window, return to scanning main form
    End Sub
End Class
