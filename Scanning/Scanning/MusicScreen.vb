Public Class MusicScreen
    Private SelectedSortButton As Button

    Private Sub MusicScreen_ControlAdded(sender As Object, e As EventArgs) Handles Me.ControlAdded
        PlaylistsMusicSortButton_Click(Nothing, Nothing)
    End Sub

    Private Sub PlaylistsMusicSortButton_Click(sender As Object, e As EventArgs) Handles PlaylistsMusicSortButton.Click
        If Not IsNothing(SelectedSortButton) Then
            SelectedSortButton.Enabled = True
            MusicListBox.Items.Clear()
        End If
        PlaylistsMusicSortButton.Enabled = False
        SelectedSortButton = PlaylistsMusicSortButton
        Dim FileNames = My.Computer.FileSystem.GetFiles("../../Resources/Music/Playlists", FileIO.SearchOption.SearchTopLevelOnly, "*")
        For Each FileName As String In FileNames
            MusicListBox.Items.Add(FileName.Substring(FileName.LastIndexOf("\") + 1))
        Next
        MusicListBox.SelectedIndex = 0
    End Sub

    Private Sub ArtistsMusicSortButton_Click(sender As Object, e As EventArgs) Handles ArtistsMusicSortButton.Click
        If Not IsNothing(SelectedSortButton) Then
            SelectedSortButton.Enabled = True
            MusicListBox.Items.Clear()
        End If
        ArtistsMusicSortButton.Enabled = False
        SelectedSortButton = ArtistsMusicSortButton
        Dim FileNames = My.Computer.FileSystem.GetFiles("../../Resources/Music/Artists", FileIO.SearchOption.SearchTopLevelOnly, "*")
        For Each FileName As String In FileNames
            MusicListBox.Items.Add(FileName.Substring(FileName.LastIndexOf("\") + 1))
        Next
        MusicListBox.SelectedIndex = 0
    End Sub

    Private Sub MusicUpButton_Click(sender As Object, e As EventArgs) Handles MusicUpButton.Click
        If MusicListBox.SelectedIndex = 0 Then
            MusicListBox.SelectedIndex = MusicListBox.Items.Count - 1
        Else
            MusicListBox.SelectedIndex -= 1
        End If
    End Sub

    Private Sub MusicDownButton_Click(sender As Object, e As EventArgs) Handles MusicDownButton.Click
        If MusicListBox.SelectedIndex = MusicListBox.Items.Count - 1 Then
            MusicListBox.SelectedIndex = 0
        Else
            MusicListBox.SelectedIndex += 1
        End If
    End Sub

    Private Sub MusicSelectButton_Click(sender As Object, e As EventArgs) Handles MusicSelectButton.Click
        My.Computer.Audio.Play(My.Computer.FileSystem.GetFiles("../../Resources/Music", FileIO.SearchOption.SearchAllSubDirectories, "*" + MusicListBox.Items(MusicListBox.SelectedIndex) + "*").First())
    End Sub

    Private Sub MusicPlayPauseButton_Click(sender As Object, e As EventArgs) Handles MusicPlayPauseButton.Click
        ' TODO
    End Sub
End Class
