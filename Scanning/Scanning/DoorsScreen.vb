Public Class DoorsScreen

    Private Sub BuildingFrontDoorButton_Click(sender As Object, e As EventArgs) Handles BuildingFrontDoorButton.Click
        MsgBox("Building front door opened")
    End Sub

    Private Sub ApartmentFrontDoorButton_Click(sender As Object, e As EventArgs) Handles ApartmentFrontDoorButton.Click
        MsgBox("Apartment front door opened")
    End Sub

    Private Sub BathroomDoorButton_Click(sender As Object, e As EventArgs) Handles BathroomDoorButton.Click
        MsgBox("Bathroom door opened")
    End Sub
End Class
