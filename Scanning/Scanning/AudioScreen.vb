Imports System.IO

Public Class AudioScreen
    Private SelectedSortButton As Button

    Private Sub AudioScreen_Load(sender As Object, e As EventArgs) Handles Me.ControlAdded
        AudioRadioSortButton_Click(Nothing, Nothing)
    End Sub

    Private Sub AudioRadioSortButton_Click(sender As Object, e As EventArgs) Handles AudioRadioSortButton.Click
        If Not IsNothing(SelectedSortButton) Then
            SelectedSortButton.Enabled = True
            AudioListBox.Items.Clear()
        End If
        AudioRadioSortButton.Enabled = False
        SelectedSortButton = AudioRadioSortButton
        Dim FileNames = My.Computer.FileSystem.GetFiles("../../Resources/Audio/Radio", FileIO.SearchOption.SearchTopLevelOnly, "*")
        For Each FileName As String In FileNames
            AudioListBox.Items.Add(FileName.Substring(FileName.LastIndexOf("\") + 1))
        Next
        AudioDeleteButton.Enabled = False
        AudioListBox.SelectedIndex = 0
    End Sub

    Private Sub AudioPodcastsSortButton_Click(sender As Object, e As EventArgs) Handles AudioPodcastsSortButton.Click
        If Not IsNothing(SelectedSortButton) Then
            SelectedSortButton.Enabled = True
            AudioListBox.Items.Clear()
        End If
        AudioPodcastsSortButton.Enabled = False
        SelectedSortButton = AudioRadioSortButton
        Dim FileNames As String() = Directory.GetFiles("../../Resources/Audio/Podcasts", "*")
        For Each FileName In FileNames
            AudioListBox.Items.Add(FileName.Substring(FileName.LastIndexOf("\") + 1))
        Next
        AudioDeleteButton.Enabled = True
        AudioListBox.SelectedIndex = 0
    End Sub

    Private Sub AudioLocalSortButton_Click(sender As Object, e As EventArgs) Handles AudioLocalSortButton.Click
        If Not IsNothing(SelectedSortButton) Then
            SelectedSortButton.Enabled = True
            AudioListBox.Items.Clear()
        End If
        AudioLocalSortButton.Enabled = False
        SelectedSortButton = AudioRadioSortButton
        Dim FileNames As String() = Directory.GetFiles("../../Resources/Audio/Local", "*")
        For Each FileName In FileNames
            AudioListBox.Items.Add(FileName.Substring(FileName.LastIndexOf("\") + 1))
        Next
        AudioDeleteButton.Enabled = True
        AudioListBox.SelectedIndex = 0
    End Sub

    Private Sub AudioUpButton_Click(sender As Object, e As EventArgs) Handles AudioUpButton.Click
        If AudioListBox.SelectedIndex = 0 Then
            AudioListBox.SelectedIndex = AudioListBox.Items.Count - 1
        Else
            AudioListBox.SelectedIndex -= 1
        End If
    End Sub

    Private Sub AudioDownButton_Click(sender As Object, e As EventArgs) Handles AudioDownButton.Click
        If AudioListBox.SelectedIndex = AudioListBox.Items.Count - 1 Then
            AudioListBox.SelectedIndex = 0
        Else
            AudioListBox.SelectedIndex += 1
        End If
    End Sub

    Private Sub AudioSelectButton_Click(sender As Object, e As EventArgs) Handles AudioSelectButton.Click, AudioPlayPauseButton.Click
        My.Computer.Audio.Play(My.Computer.FileSystem.GetFiles("../../Resources/Audio", FileIO.SearchOption.SearchAllSubDirectories, "*" + AudioListBox.Items(AudioListBox.SelectedIndex) + "*").First())
    End Sub

    Private Sub AudioDeleteButton_Click(sender As Object, e As EventArgs) Handles AudioDeleteButton.Click
        ' TODO Confirm deletion
    End Sub
End Class
