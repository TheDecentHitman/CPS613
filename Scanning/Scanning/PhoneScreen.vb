Public Class PhoneScreen
    Private SelectedSortButton As Button

    Private Sub PhoneScreen_ControlAdded(sender As Object, e As EventArgs) Handles Me.ControlAdded
        PhoneContactEmergencySortButton_Click(Nothing, Nothing)
    End Sub

    Private Sub PhoneContactEmergencySortButton_Click(sender As Object, e As EventArgs) Handles PhoneContactEmergencySortButton.Click
        If Not IsNothing(SelectedSortButton) Then
            SelectedSortButton.Enabled = True
            PhoneContactListBox.Items.Clear()
        End If
        PhoneContactEmergencySortButton.Enabled = False
        SelectedSortButton = PhoneContactEmergencySortButton

        PhoneContactListBox.Items.Clear()
        PhoneContactListBox.Items.Add("911")
        PhoneContactListBox.SelectedIndex = 0

        If Not IsNothing(sender) Then
            PhoneContactSortSubMenu.BackColor = DefaultBackColor
            MainForm.bottomBarActive = False
            MainForm.FocusLabel.Focus()
            MainForm.focusIsOn = 4
            MainForm.scanninglevel = 1
            PhoneContactListSubMenu.BackColor = Color.LightBlue
            PhoneContactListSubMenu.StartInnerScanning()
        End If
    End Sub

    Private Sub PhoneContactFavoritesSortButton_Click(sender As Object, e As EventArgs) Handles PhoneContactFavoritesSortButton.Click
        If Not IsNothing(SelectedSortButton) Then
            SelectedSortButton.Enabled = True
            PhoneContactListBox.Items.Clear()
        End If
        PhoneContactFavoritesSortButton.Enabled = False
        SelectedSortButton = PhoneContactFavoritesSortButton

        PhoneContactListBox.Items.Clear()
        PhoneContactListBox.Items.Add("Bobby")
        PhoneContactListBox.Items.Add("Chris")
        PhoneContactListBox.Items.Add("Alex")
        PhoneContactListBox.SelectedIndex = 0

        If Not IsNothing(sender) Then
            PhoneContactSortSubMenu.BackColor = DefaultBackColor
            MainForm.bottomBarActive = False
            MainForm.FocusLabel.Focus()
            MainForm.focusIsOn = 4
            MainForm.scanninglevel = 1
            PhoneContactListSubMenu.BackColor = Color.LightBlue
            PhoneContactListSubMenu.StartInnerScanning()
        End If
    End Sub

    Private Sub PhoneContactAllSortButton_Click(sender As Object, e As EventArgs) Handles PhoneContactAllSortButton.Click
        If Not IsNothing(SelectedSortButton) Then
            SelectedSortButton.Enabled = True
            PhoneContactListBox.Items.Clear()
        End If
        PhoneContactAllSortButton.Enabled = False
        SelectedSortButton = PhoneContactAllSortButton

        PhoneContactListBox.Items.Clear()
        PhoneContactListBox.Items.Add("Bobby")
        PhoneContactListBox.Items.Add("Chris")
        PhoneContactListBox.Items.Add("Alex")
        PhoneContactListBox.Items.Add("Mom")
        PhoneContactListBox.Items.Add("Dad")
        PhoneContactListBox.SelectedIndex = 0

        If Not IsNothing(sender) Then
            PhoneContactSortSubMenu.BackColor = DefaultBackColor
            MainForm.bottomBarActive = False
            MainForm.FocusLabel.Focus()
            MainForm.focusIsOn = 4
            MainForm.scanninglevel = 1
            PhoneContactListSubMenu.BackColor = Color.LightBlue
            PhoneContactListSubMenu.StartInnerScanning()
        End If
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
    End Sub
End Class
