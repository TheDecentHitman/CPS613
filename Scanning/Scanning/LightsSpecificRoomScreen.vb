Public Class LightsSpecificRoomScreen
    ' TODO

    Private Sub LightsSpecRoom_LivingRoomButton_Click(sender As Object, e As EventArgs) Handles LightsSpecRoom_LivingRoomButton.Click
        If LightsSpecRoom_LivingRoomButton.BackColor = DefaultBackColor Then
            LightsSpecRoom_LivingRoomButton.BackColor = Color.Yellow
        ElseIf LightsSpecRoom_LivingRoomButton.BackColor = Color.Yellow Then
            LightsSpecRoom_LivingRoomButton.BackColor = DefaultBackColor
        End If
    End Sub

    Private Sub LightsSpecRoom_KitchenButton_Click(sender As Object, e As EventArgs) Handles LightsSpecRoom_KitchenButton.Click
        If LightsSpecRoom_KitchenButton.BackColor = DefaultBackColor Then
            LightsSpecRoom_KitchenButton.BackColor = Color.Yellow
        ElseIf LightsSpecRoom_KitchenButton.BackColor = Color.Yellow Then
            LightsSpecRoom_KitchenButton.BackColor = DefaultBackColor
        End If
    End Sub

    Private Sub LightsSpecRoom_BedroomButton_Click(sender As Object, e As EventArgs) Handles LightsSpecRoom_BedroomButton.Click
        If LightsSpecRoom_BedroomButton.BackColor = DefaultBackColor Then
            LightsSpecRoom_BedroomButton.BackColor = Color.Yellow
        ElseIf LightsSpecRoom_BedroomButton.BackColor = Color.Yellow Then
            LightsSpecRoom_BedroomButton.BackColor = DefaultBackColor
        End If
    End Sub
End Class
