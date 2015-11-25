Public Class PhoneScreen

    Private Sub PhoneScreen_ControlAdded(sender As Object, e As EventArgs) Handles Me.ControlAdded
        PhoneContactEmergencySortButton_Click(Nothing, Nothing)
    End Sub

    Private Sub PhoneContactEmergencySortButton_Click(sender As Object, e As EventArgs) Handles PhoneContactEmergencySortButton.Click
        Me.PhoneContactListBox.Items.Clear()
        Me.PhoneContactListBox.Items.Add("911")
        PhoneContactListBox.SelectedIndex = 0
    End Sub

    Private Sub PhoneContactFavoritesSortButton_Click(sender As Object, e As EventArgs) Handles PhoneContactFavoritesSortButton.Click
        Me.PhoneContactListBox.Items.Clear()
        Me.PhoneContactListBox.Items.Add("Bobby")
        Me.PhoneContactListBox.Items.Add("Chris")
        Me.PhoneContactListBox.Items.Add("Alex")
        PhoneContactListBox.SelectedIndex = 0
    End Sub

    Private Sub PhoneContactAllSortButton_Click(sender As Object, e As EventArgs) Handles PhoneContactAllSortButton.Click
        Me.PhoneContactListBox.Items.Clear()
        Me.PhoneContactListBox.Items.Add("Bobby")
        Me.PhoneContactListBox.Items.Add("Chris")
        Me.PhoneContactListBox.Items.Add("Alex")
        Me.PhoneContactListBox.Items.Add("Mom")
        Me.PhoneContactListBox.Items.Add("Dad")
        PhoneContactListBox.SelectedIndex = 0
    End Sub

    Private Sub PhoneContactUpButton_Click(sender As Object, e As EventArgs) Handles PhoneContactUpButton.Click
        If PhoneContactListBox.SelectedIndex = 0 Then
            PhoneContactListBox.SelectedIndex = PhoneContactListBox.Items.Count - 1
        Else
            PhoneContactListBox.SelectedIndex -= 1
        End If
    End Sub

    Private Sub PhoneContactDownButton_Click(sender As Object, e As EventArgs) Handles PhoneContactDownButton.Click
        If PhoneContactListBox.SelectedIndex = PhoneContactListBox.Items.Count - 1 Then
            PhoneContactListBox.SelectedIndex = 0
        Else
            PhoneContactListBox.SelectedIndex += 1
        End If
    End Sub

    Private Sub PhoneContactCallButton_Click(sender As Object, e As EventArgs) Handles PhoneContactCallButton.Click
        MainForm.ChangeScreen(Me, New HomeScreen)
        MainForm.IncomingPhoneCall()
        ' TODO Stop scanning, create PhoneCall form, start scanning PhoneCall form
    End Sub
End Class
