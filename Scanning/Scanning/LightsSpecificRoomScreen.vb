Public Class LightsSpecificRoomScreen

    Private Sub LightsSpecRoom_LivingRoomButton_Click(sender As Object, e As EventArgs) Handles LightsSpecRoom_LivingRoomButton.Click
        If MainForm.lightsOn(0) Then
            LightsSpecRoom_LivingRoomButton.Text = "Living Room (Off)"
            MainForm.lightsOn(0) = False
        Else
            LightsSpecRoom_LivingRoomButton.Text = "Living Room (On)"
            MainForm.lightsOn(0) = True
        End If
    End Sub

    Private Sub LightsSpecRoom_KitchenButton_Click(sender As Object, e As EventArgs) Handles LightsSpecRoom_KitchenButton.Click
        If MainForm.lightsOn(1) Then
            LightsSpecRoom_KitchenButton.Text = "Kitchen (Off)"
            MainForm.lightsOn(1) = False
        Else
            LightsSpecRoom_KitchenButton.Text = "Kitchen (On)"
            MainForm.lightsOn(1) = True
        End If
    End Sub

    Private Sub LightsSpecRoom_BedroomButton_Click(sender As Object, e As EventArgs) Handles LightsSpecRoom_BedroomButton.Click
        If MainForm.lightsOn(2) Then
            LightsSpecRoom_BedroomButton.Text = "Bedroom (Off)"
            MainForm.lightsOn(2) = False
        Else
            LightsSpecRoom_BedroomButton.Text = "Bedroom (On)"
            MainForm.lightsOn(2) = True
        End If
    End Sub

    Private Sub LightsSpecificRoomScreen_Load(sender As Object, e As EventArgs) Handles Me.Load
        If (MainForm.lightsOn(0)) Then
            LightsSpecRoom_LivingRoomButton.Text = "Living Room (On)"
        Else
            LightsSpecRoom_LivingRoomButton.Text = "Living Room (Off)"
        End If

        If (MainForm.lightsOn(1)) Then
            LightsSpecRoom_KitchenButton.Text = "Kitchen (On)"
        Else
            LightsSpecRoom_KitchenButton.Text = "Kitchen (Off)"
        End If

        If (MainForm.lightsOn(2)) Then
            LightsSpecRoom_BedroomButton.Text = "Bedroom (On)"
        Else
            LightsSpecRoom_BedroomButton.Text = "Bedroom (Off)"
        End If
    End Sub
End Class
