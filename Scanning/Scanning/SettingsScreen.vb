Public Class SettingsScreen

    Private Sub SettingsScreen_Load(sender As Object, e As EventArgs) Handles Me.Load
        ScannerSpeedLabel.Text = MainForm.ScanningTimer.Interval
    End Sub

    Private Sub DecreaseSpeedButton_Click(sender As Object, e As EventArgs) Handles DecreaseSpeedButton.Click
        MainForm.ScanningTimer.Interval += 100
        ScannerSpeedLabel.Text = MainForm.ScanningTimer.Interval
    End Sub

    Private Sub IncreaseSpeedButton_Click(sender As Object, e As EventArgs) Handles IncreaseSpeedButton.Click
        If MainForm.ScanningTimer.Interval > 100 Then
            MainForm.ScanningTimer.Interval -= 100
            ScannerSpeedLabel.Text = MainForm.ScanningTimer.Interval
        End If
    End Sub
End Class
