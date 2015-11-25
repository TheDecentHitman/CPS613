Public Class incomecall
    Private Sub AcceptButton_Click(sender As Object, e As EventArgs) Handles AcceptButton.Click
        MainForm.onPhone = True
        Dim newHomeScreen As New HomeScreen
        newHomeScreen.CommunicationsButton.Text = "Phone"
        MainForm.ChangeScreen(Me, newHomeScreen)
        ' TODO Close window, replace with phone call window
    End Sub
End Class
