Public Class WindowsSpecificRoomScreen

    Private Sub WindowsSpecRoom_LivingRoomButton_Click(sender As Object, e As EventArgs) Handles WindowsSpecRoom_LivingRoomButton.Click
        If MainForm.windowsOpen(0) Then
            WindowsSpecRoom_LivingRoomButton.Text = "Living Room (Closed)"
            MainForm.windowsOpen(0) = False
        Else
            WindowsSpecRoom_LivingRoomButton.Text = "Living Room (Open)"
            MainForm.windowsOpen(0) = True
        End If
    End Sub

    Private Sub WindowsSpecRoom_KitchenButton_Click(sender As Object, e As EventArgs) Handles WindowsSpecRoom_KitchenButton.Click
        If MainForm.windowsOpen(1) Then
            WindowsSpecRoom_KitchenButton.Text = "Kitchen (Closed)"
            MainForm.windowsOpen(1) = False
        Else
            WindowsSpecRoom_KitchenButton.Text = "Kitchen (Open)"
            MainForm.windowsOpen(1) = True
        End If
    End Sub

    Private Sub WindowsSpecRoom_BedroomButton_Click(sender As Object, e As EventArgs) Handles WindowsSpecRoom_BedroomButton.Click
        If MainForm.windowsOpen(2) Then
            WindowsSpecRoom_BedroomButton.Text = "Bedroom (Closed)"
            MainForm.windowsOpen(2) = False
        Else
            WindowsSpecRoom_BedroomButton.Text = "Bedroom (Open)"
            MainForm.windowsOpen(2) = True
        End If
    End Sub

    Private Sub WindowsSpecificRoomScreen_Load(sender As Object, e As EventArgs) Handles Me.Load
        If (MainForm.windowsOpen(0)) Then
            WindowsSpecRoom_LivingRoomButton.Text = "Living Room (Open)"
        Else
            WindowsSpecRoom_LivingRoomButton.Text = "Living Room (Closed)"
        End If

        If (MainForm.windowsOpen(1)) Then
            WindowsSpecRoom_KitchenButton.Text = "Kitchen (Open)"
        Else
            WindowsSpecRoom_KitchenButton.Text = "Kitchen (Closed)"
        End If

        If (MainForm.windowsOpen(2)) Then
            WindowsSpecRoom_BedroomButton.Text = "Bedroom (Open)"
        Else
            WindowsSpecRoom_BedroomButton.Text = "Bedroom (Closed)"
        End If
    End Sub
End Class
