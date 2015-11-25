Public Class PhoneScreen

    Private Sub PhoneContactEmergencySortButton_Click(sender As Object, e As EventArgs) Handles PhoneContactEmergencySortButton.Click
        ' TODO Same thing as sort buttons in AudioScreen, except with lists of contacts
    End Sub

    Private Sub PhoneContactFavoritesSortButton_Click(sender As Object, e As EventArgs) Handles PhoneContactFavoritesSortButton.Click
        ' TODO Same thing as sort buttons in AudioScreen, except with lists of contacts
    End Sub

    Private Sub PhoneContactAllSortButton_Click(sender As Object, e As EventArgs) Handles PhoneContactAllSortButton.Click
        ' TODO Same thing as sort buttons in AudioScreen, except with lists of contacts
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
