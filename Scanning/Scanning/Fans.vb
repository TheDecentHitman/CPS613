Public Class Fans
    Private Sub OnB_Click(sender As Object, e As EventArgs) Handles OnB.Click
        off.Enabled = True
        OnB.Enabled = False
    End Sub

    Private Sub off_Click(sender As Object, e As EventArgs) Handles off.Click
        OnB.Enabled = True
        off.Enabled = False
    End Sub
End Class
