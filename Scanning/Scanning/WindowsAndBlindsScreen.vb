Public Class WindowsAndBlindsScreen

    Private Sub WindowsCentralAptButton_Click(sender As Object, e As EventArgs) Handles WindowsCentralAptButton.Click
        If (MainForm.windowsOpen(0) OrElse MainForm.windowsOpen(1) OrElse MainForm.windowsOpen(2)) Then
            MainForm.windowsOpen(0) = False
            MainForm.windowsOpen(1) = False
            MainForm.windowsOpen(2) = False
            WindowsCentralAptButton.Text = "Open All"
        Else
            MainForm.windowsOpen(0) = True
            MainForm.windowsOpen(1) = True
            MainForm.windowsOpen(2) = True
            WindowsCentralAptButton.Text = "Close All"
        End If
    End Sub

    Private Sub WindowsSpecRoomButton_Click(sender As Object, e As EventArgs) Handles WindowsSpecRoomButton.Click
        MainForm.ChangeScreen(Me, New WindowsSpecificRoomScreen)
    End Sub

    Private Sub BlindsCentralAptButton_Click(sender As Object, e As EventArgs) Handles BlindsCentralAptButton.Click
        If (MainForm.blindsOpen(0) OrElse MainForm.blindsOpen(1) OrElse MainForm.blindsOpen(2)) Then
            MainForm.blindsOpen(0) = False
            MainForm.blindsOpen(1) = False
            MainForm.blindsOpen(2) = False
            BlindsCentralAptButton.Text = "Open All"
        Else
            MainForm.blindsOpen(0) = True
            MainForm.blindsOpen(1) = True
            MainForm.blindsOpen(2) = True
            BlindsCentralAptButton.Text = "Close All"
        End If
    End Sub

    Private Sub BlindsSpecRoomButton_Click(sender As Object, e As EventArgs) Handles BlindsSpecRoomButton.Click
        MainForm.ChangeScreen(Me, New BlindsSpecificRoomScreen)
    End Sub

    Private Sub WindowsAndBlindsScreen_Load(sender As Object, e As EventArgs) Handles Me.Load
        If (MainForm.windowsOpen(0) OrElse MainForm.windowsOpen(1) OrElse MainForm.windowsOpen(2)) Then
            WindowsCentralAptButton.Text = "Close All"
        Else
            WindowsCentralAptButton.Text = "Open All"
        End If
        If (MainForm.blindsOpen(0) OrElse MainForm.blindsOpen(1) OrElse MainForm.blindsOpen(2)) Then
            BlindsCentralAptButton.Text = "Close All"
        Else
            BlindsCentralAptButton.Text = "Open All"
        End If
    End Sub
End Class
