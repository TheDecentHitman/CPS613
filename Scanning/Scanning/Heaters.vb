Public Class Heaters


    Private Sub Higher_Click(sender As Object, e As EventArgs) Handles Higher.Click
        MainForm.temperature += 1
        Label2.Text = "" + MainForm.temperature.ToString + "°C"
    End Sub

    Private Sub Lower_Click(sender As Object, e As EventArgs) Handles Lower.Click
        MainForm.temperature -= 1
        Label2.Text = "" + MainForm.temperature.ToString + "°C"
    End Sub

    Private Sub Heaters_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = "" + MainForm.temperature.ToString + "°C"
    End Sub
End Class
