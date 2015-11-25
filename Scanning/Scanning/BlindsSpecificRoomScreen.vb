Public Class BlindsSpecificRoomScreen

    Private Sub BlindsSpecRoom_LivingRoomButton_Click(sender As Object, e As EventArgs) Handles BlindsSpecRoom_LivingRoomButton.Click
        If MainForm.blindsOpen(0) Then
            BlindsSpecRoom_LivingRoomButton.Text = "Living Room (Closed)"
            MainForm.blindsOpen(0) = False
        Else
            BlindsSpecRoom_LivingRoomButton.Text = "Living Room (Open)"
            MainForm.blindsOpen(0) = True
        End If
    End Sub

    Private Sub BlindsSpecRoom_KitchenButton_Click(sender As Object, e As EventArgs) Handles BlindsSpecRoom_KitchenButton.Click
        If MainForm.blindsOpen(1) Then
            BlindsSpecRoom_KitchenButton.Text = "Kitchen (Closed)"
            MainForm.blindsOpen(1) = False
        Else
            BlindsSpecRoom_KitchenButton.Text = "Kitchen (Open)"
            MainForm.blindsOpen(1) = True
        End If
    End Sub

    Private Sub BlindsSpecRoom_BedroomButton_Click(sender As Object, e As EventArgs) Handles BlindsSpecRoom_BedroomButton.Click
        If MainForm.blindsOpen(2) Then
            BlindsSpecRoom_BedroomButton.Text = "Bedroom (Closed)"
            MainForm.blindsOpen(2) = False
        Else
            BlindsSpecRoom_BedroomButton.Text = "Bedroom (Open)"
            MainForm.blindsOpen(2) = True
        End If
    End Sub

    Private Sub BlindsSpecificRoomScreen_Load(sender As Object, e As EventArgs) Handles Me.Load
        If (MainForm.blindsOpen(0)) Then
            BlindsSpecRoom_LivingRoomButton.Text = "Living Room (Open)"
        Else
            BlindsSpecRoom_LivingRoomButton.Text = "Living Room (Closed)"
        End If

        If (MainForm.blindsOpen(1)) Then
            BlindsSpecRoom_KitchenButton.Text = "Kitchen (Open)"
        Else
            BlindsSpecRoom_KitchenButton.Text = "Kitchen (Closed)"
        End If

        If (MainForm.blindsOpen(2)) Then
            BlindsSpecRoom_BedroomButton.Text = "Bedroom (Open)"
        Else
            BlindsSpecRoom_BedroomButton.Text = "Bedroom (Closed)"
        End If
    End Sub
End Class
