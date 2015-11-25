Public Class IncomingPhoneCall

    Private Sub AcceptButton_Click(sender As Object, e As EventArgs) Handles AcceptButton.Click
        MainForm.onPhone = True
        Dim newHomeScreen As New HomeScreen
        newHomeScreen.CommunicationsButton.Text = "Phone"
        MainForm.ChangeScreen(Me, newHomeScreen)
        ' TODO Close window, replace with phone call window
    End Sub

    Private Sub DeclineButton_Click(sender As Object, e As EventArgs) Handles DeclineButton.Click
        ' TODO Close window, return to scanning main form
    End Sub

    Private Sub DeclineAndMessageButton_Click(sender As Object, e As EventArgs) Handles DeclineAndMessageButton.Click
        ' TODO Close window, change to MessageScreen with caller already selected
    End Sub
End Class