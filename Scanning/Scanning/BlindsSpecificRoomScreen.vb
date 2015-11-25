Public Class BlindsSpecificRoomScreen
    ' TODO

    Private Sub BlindsSpecRoom_LivingRoomButton_Click(sender As Object, e As EventArgs) Handles BlindsSpecRoom_LivingRoomButton.Click
        If BlindsSpecRoom_LivingRoomButton.Text = "Living Room (Closed)" Then
            BlindsSpecRoom_LivingRoomButton.Text = "Living Room (Open)"
        ElseIf BlindsSpecRoom_LivingRoomButton.Text = "Living Room (Open)" Then
            BlindsSpecRoom_LivingRoomButton.Text = "Living Room (Closed)"
        End If
    End Sub

    Private Sub BlindsSpecRoom_KitchenButton_Click(sender As Object, e As EventArgs) Handles BlindsSpecRoom_KitchenButton.Click
        If BlindsSpecRoom_KitchenButton.Text = "Kitchen (Closed)" Then
            BlindsSpecRoom_KitchenButton.Text = "Kitchen (Open)"
        ElseIf BlindsSpecRoom_KitchenButton.Text = "Kitchen (Open)" Then
            BlindsSpecRoom_KitchenButton.Text = "Kitchen (Closed)"
        End If
    End Sub

    Private Sub BlindsSpecRoom_BedroomButton_Click(sender As Object, e As EventArgs) Handles BlindsSpecRoom_BedroomButton.Click
        If BlindsSpecRoom_BedroomButton.Text = "Bedroom (Closed)" Then
            BlindsSpecRoom_BedroomButton.Text = "Bedroom (Open)"
        ElseIf BlindsSpecRoom_BedroomButton.Text = "Bedroom (Open)" Then
            BlindsSpecRoom_BedroomButton.Text = "Bedroom (Closed)"
        End If
    End Sub
End Class
