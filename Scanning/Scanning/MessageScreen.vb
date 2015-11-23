Public Class MessageScreen

    Private Sub MessageScreen_Load(sender As Object, e As EventArgs) Handles Me.ControlAdded
        MessageContactEmergencySortButton_Click(Nothing, Nothing)
    End Sub

    Private Sub MessageContactEmergencySortButton_Click(sender As Object, e As EventArgs) Handles MessageContactEmergencySortButton.Click
        ' TODO Same thing as sort buttons in AudioScreen, except with lists of contacts, show message log of first contact in new list
    End Sub

    Private Sub MessageContactFavoritesSortButton_Click(sender As Object, e As EventArgs) Handles MessageContactFavoritesSortButton.Click
        ' TODO Same thing as sort buttons in AudioScreen, except with lists of contacts, show message log of first contact in new list
    End Sub

    Private Sub MessageContactAllSortButton_Click(sender As Object, e As EventArgs) Handles MessageContactAllSortButton.Click
        ' TODO Same thing as sort buttons in AudioScreen, except with lists of contacts, show message log of first contact in new list
    End Sub

    Private Sub MessageContactUpButton_Click(sender As Object, e As EventArgs) Handles MessageContactUpButton.Click
        If MessageContactListBox.SelectedIndex = 0 Then
            MessageContactListBox.SelectedIndex = MessageContactListBox.Items.Count - 1
        Else
            MessageContactListBox.SelectedIndex -= 1
        End If

        ' TODO Show message log of selected contact
    End Sub

    Private Sub MessageContactDownButton_Click(sender As Object, e As EventArgs) Handles MessageContactDownButton.Click
        If MessageContactListBox.SelectedIndex = MessageContactListBox.Items.Count - 1 Then
            MessageContactListBox.SelectedIndex = 0
        Else
            MessageContactListBox.SelectedIndex += 1
        End If

        ' TODO Show message log of selected contact
    End Sub

    Private Sub MessageContactSelectButton_Click(sender As Object, e As EventArgs) Handles MessageContactSelectButton.Click
        ' TODO Switch selected submenu to MessageResponsesSubMenu
    End Sub

    Private Sub MessageStandardResponseButton_Click(sender As Object, e As EventArgs) Handles MessageStandardResponseButton.Click
        ' TODO Show list of standard responses, selected one should be added to the selected message log
    End Sub
End Class
