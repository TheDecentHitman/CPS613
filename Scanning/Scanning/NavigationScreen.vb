Public Class NavigationScreen
    ' TODO FOR ZACK Change to work with modified scanning

    Private Sub DoorsButton_Click(sender As Object, e As EventArgs) Handles DoorsButton.Click
        MainForm.ChangeScreen(Me, New DoorsScreen)
    End Sub

    Private Sub ElevatorButton_Click(sender As Object, e As EventArgs) Handles ElevatorButton.Click
        MainForm.ChangeScreen(Me, New ElevatorScreen)
    End Sub
End Class
