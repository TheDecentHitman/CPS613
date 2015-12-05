Public Class incomecall
    Private Sub AcceptButton_Click(sender As Object, e As EventArgs) Handles AcceptButton.Click
        MainForm.onPhone = True
        Dim NewScreen As HomeScreen = New HomeScreen
        NewScreen.CommunicationsButton.Text = "Phone"
        NewScreen.CommunicationsButton.ForeColor = Color.Green
        MainForm.ChangeScreen(Me, NewScreen)
    End Sub
End Class
