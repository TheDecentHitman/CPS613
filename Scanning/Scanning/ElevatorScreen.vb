Public Class ElevatorScreen
    Private Sub ElevatorScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If MainForm.currentFloor = 1 Then
            DefaultFloorButton.Text = "Your Floor"
        Else
            DefaultFloorButton.Text = "Ground Floor"
        End If
    End Sub

    Private Sub DefaultFloorButton_Click(sender As Object, e As EventArgs) Handles DefaultFloorButton.Click
        If MainForm.currentFloor = 1 Then
            MainForm.currentFloor = 3
            DefaultFloorButton.Text = "Ground Floor"
            MsgBox("Elevator at your floor")
        Else
            MainForm.currentFloor = 1
            DefaultFloorButton.Text = "Your Floor"
            MsgBox("Elevator at ground floor")
        End If
    End Sub
End Class
