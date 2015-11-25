<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MusicScreen
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PlaylistsMusicSortButton = New System.Windows.Forms.Button()
        Me.MusicPlayerSubMenu2 = New Scanning.SubMenu()
        Me.MusicShuffleButton = New System.Windows.Forms.Button()
        Me.MusicRepeatButton = New System.Windows.Forms.Button()
        Me.MusicPreviousButton = New System.Windows.Forms.Button()
        Me.MusicNextButton = New System.Windows.Forms.Button()
        Me.MusicPlayerSubMenu = New Scanning.SubMenu()
        Me.MusicFastForwardButton = New System.Windows.Forms.Button()
        Me.MusicRewindButton = New System.Windows.Forms.Button()
        Me.MusicPlayPauseButton = New System.Windows.Forms.Button()
        Me.MusicListSubMenu = New Scanning.SubMenu()
        Me.MusicSelectButton = New System.Windows.Forms.Button()
        Me.MusicDownButton = New System.Windows.Forms.Button()
        Me.MusicUpButton = New System.Windows.Forms.Button()
        Me.MusicListBox = New System.Windows.Forms.ListBox()
        Me.MusicSortSubMenu = New Scanning.SubMenu()
        Me.ArtistsMusicSortButton = New System.Windows.Forms.Button()
        Me.MusicPlayerSubMenu2.SuspendLayout()
        Me.MusicPlayerSubMenu.SuspendLayout()
        Me.MusicListSubMenu.SuspendLayout()
        Me.MusicSortSubMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'PlaylistsMusicSortButton
        '
        Me.PlaylistsMusicSortButton.Enabled = False
        Me.PlaylistsMusicSortButton.Location = New System.Drawing.Point(81, 3)
        Me.PlaylistsMusicSortButton.Name = "PlaylistsMusicSortButton"
        Me.PlaylistsMusicSortButton.Size = New System.Drawing.Size(75, 48)
        Me.PlaylistsMusicSortButton.TabIndex = 4
        Me.PlaylistsMusicSortButton.Text = "Playlists"
        Me.PlaylistsMusicSortButton.UseVisualStyleBackColor = True
        '
        'MusicPlayerSubMenu2
        '
        Me.MusicPlayerSubMenu2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MusicPlayerSubMenu2.Controls.Add(Me.MusicShuffleButton)
        Me.MusicPlayerSubMenu2.Controls.Add(Me.MusicRepeatButton)
        Me.MusicPlayerSubMenu2.Controls.Add(Me.MusicPreviousButton)
        Me.MusicPlayerSubMenu2.Controls.Add(Me.MusicNextButton)
        Me.MusicPlayerSubMenu2.Location = New System.Drawing.Point(4, 383)
        Me.MusicPlayerSubMenu2.Name = "MusicPlayerSubMenu2"
        Me.MusicPlayerSubMenu2.Size = New System.Drawing.Size(433, 54)
        Me.MusicPlayerSubMenu2.TabIndex = 6
        '
        'MusicShuffleButton
        '
        Me.MusicShuffleButton.Enabled = False
        Me.MusicShuffleButton.Location = New System.Drawing.Point(123, 14)
        Me.MusicShuffleButton.Name = "MusicShuffleButton"
        Me.MusicShuffleButton.Size = New System.Drawing.Size(75, 23)
        Me.MusicShuffleButton.TabIndex = 4
        Me.MusicShuffleButton.Text = "Shuffle"
        Me.MusicShuffleButton.UseVisualStyleBackColor = True
        '
        'MusicRepeatButton
        '
        Me.MusicRepeatButton.Enabled = False
        Me.MusicRepeatButton.Location = New System.Drawing.Point(15, 13)
        Me.MusicRepeatButton.Name = "MusicRepeatButton"
        Me.MusicRepeatButton.Size = New System.Drawing.Size(75, 23)
        Me.MusicRepeatButton.TabIndex = 3
        Me.MusicRepeatButton.Text = "Repeat"
        Me.MusicRepeatButton.UseVisualStyleBackColor = True
        '
        'MusicPreviousButton
        '
        Me.MusicPreviousButton.Enabled = False
        Me.MusicPreviousButton.Location = New System.Drawing.Point(231, 13)
        Me.MusicPreviousButton.Name = "MusicPreviousButton"
        Me.MusicPreviousButton.Size = New System.Drawing.Size(75, 23)
        Me.MusicPreviousButton.TabIndex = 5
        Me.MusicPreviousButton.Text = "Previous"
        Me.MusicPreviousButton.UseVisualStyleBackColor = True
        '
        'MusicNextButton
        '
        Me.MusicNextButton.Enabled = False
        Me.MusicNextButton.Location = New System.Drawing.Point(339, 13)
        Me.MusicNextButton.Name = "MusicNextButton"
        Me.MusicNextButton.Size = New System.Drawing.Size(75, 23)
        Me.MusicNextButton.TabIndex = 6
        Me.MusicNextButton.Text = "Next"
        Me.MusicNextButton.UseVisualStyleBackColor = True
        '
        'MusicPlayerSubMenu
        '
        Me.MusicPlayerSubMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MusicPlayerSubMenu.Controls.Add(Me.MusicFastForwardButton)
        Me.MusicPlayerSubMenu.Controls.Add(Me.MusicRewindButton)
        Me.MusicPlayerSubMenu.Controls.Add(Me.MusicPlayPauseButton)
        Me.MusicPlayerSubMenu.Location = New System.Drawing.Point(4, 330)
        Me.MusicPlayerSubMenu.Name = "MusicPlayerSubMenu"
        Me.MusicPlayerSubMenu.Size = New System.Drawing.Size(433, 47)
        Me.MusicPlayerSubMenu.TabIndex = 5
        '
        'MusicFastForwardButton
        '
        Me.MusicFastForwardButton.Enabled = False
        Me.MusicFastForwardButton.Location = New System.Drawing.Point(268, 10)
        Me.MusicFastForwardButton.Name = "MusicFastForwardButton"
        Me.MusicFastForwardButton.Size = New System.Drawing.Size(75, 23)
        Me.MusicFastForwardButton.TabIndex = 5
        Me.MusicFastForwardButton.Text = "Fast Forward"
        Me.MusicFastForwardButton.UseVisualStyleBackColor = True
        '
        'MusicRewindButton
        '
        Me.MusicRewindButton.Enabled = False
        Me.MusicRewindButton.Location = New System.Drawing.Point(86, 10)
        Me.MusicRewindButton.Name = "MusicRewindButton"
        Me.MusicRewindButton.Size = New System.Drawing.Size(75, 23)
        Me.MusicRewindButton.TabIndex = 3
        Me.MusicRewindButton.Text = "Rewind"
        Me.MusicRewindButton.UseVisualStyleBackColor = True
        '
        'MusicPlayPauseButton
        '
        Me.MusicPlayPauseButton.Location = New System.Drawing.Point(177, 10)
        Me.MusicPlayPauseButton.Name = "MusicPlayPauseButton"
        Me.MusicPlayPauseButton.Size = New System.Drawing.Size(75, 23)
        Me.MusicPlayPauseButton.TabIndex = 4
        Me.MusicPlayPauseButton.Text = "Play/Pause"
        Me.MusicPlayPauseButton.UseVisualStyleBackColor = True
        '
        'MusicListSubMenu
        '
        Me.MusicListSubMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MusicListSubMenu.Controls.Add(Me.MusicSelectButton)
        Me.MusicListSubMenu.Controls.Add(Me.MusicDownButton)
        Me.MusicListSubMenu.Controls.Add(Me.MusicUpButton)
        Me.MusicListSubMenu.Controls.Add(Me.MusicListBox)
        Me.MusicListSubMenu.Location = New System.Drawing.Point(4, 67)
        Me.MusicListSubMenu.Name = "MusicListSubMenu"
        Me.MusicListSubMenu.Size = New System.Drawing.Size(433, 255)
        Me.MusicListSubMenu.TabIndex = 4
        '
        'MusicSelectButton
        '
        Me.MusicSelectButton.Location = New System.Drawing.Point(348, 176)
        Me.MusicSelectButton.Name = "MusicSelectButton"
        Me.MusicSelectButton.Size = New System.Drawing.Size(75, 50)
        Me.MusicSelectButton.TabIndex = 5
        Me.MusicSelectButton.Text = "Select"
        Me.MusicSelectButton.UseVisualStyleBackColor = True
        '
        'MusicDownButton
        '
        Me.MusicDownButton.Location = New System.Drawing.Point(348, 100)
        Me.MusicDownButton.Name = "MusicDownButton"
        Me.MusicDownButton.Size = New System.Drawing.Size(75, 50)
        Me.MusicDownButton.TabIndex = 4
        Me.MusicDownButton.Text = "Down"
        Me.MusicDownButton.UseVisualStyleBackColor = True
        '
        'MusicUpButton
        '
        Me.MusicUpButton.Location = New System.Drawing.Point(348, 24)
        Me.MusicUpButton.Name = "MusicUpButton"
        Me.MusicUpButton.Size = New System.Drawing.Size(75, 50)
        Me.MusicUpButton.TabIndex = 3
        Me.MusicUpButton.Text = "Up"
        Me.MusicUpButton.UseVisualStyleBackColor = True
        '
        'MusicListBox
        '
        Me.MusicListBox.FormattingEnabled = True
        Me.MusicListBox.Location = New System.Drawing.Point(5, 6)
        Me.MusicListBox.Name = "MusicListBox"
        Me.MusicListBox.Size = New System.Drawing.Size(330, 238)
        Me.MusicListBox.TabIndex = 7
        '
        'MusicSortSubMenu
        '
        Me.MusicSortSubMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MusicSortSubMenu.Controls.Add(Me.ArtistsMusicSortButton)
        Me.MusicSortSubMenu.Controls.Add(Me.PlaylistsMusicSortButton)
        Me.MusicSortSubMenu.Location = New System.Drawing.Point(3, 4)
        Me.MusicSortSubMenu.Name = "MusicSortSubMenu"
        Me.MusicSortSubMenu.Size = New System.Drawing.Size(434, 58)
        Me.MusicSortSubMenu.TabIndex = 3
        '
        'ArtistsMusicSortButton
        '
        Me.ArtistsMusicSortButton.Location = New System.Drawing.Point(275, 3)
        Me.ArtistsMusicSortButton.Name = "ArtistsMusicSortButton"
        Me.ArtistsMusicSortButton.Size = New System.Drawing.Size(75, 48)
        Me.ArtistsMusicSortButton.TabIndex = 5
        Me.ArtistsMusicSortButton.Text = "Artists"
        Me.ArtistsMusicSortButton.UseVisualStyleBackColor = True
        '
        'MusicScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MusicPlayerSubMenu2)
        Me.Controls.Add(Me.MusicPlayerSubMenu)
        Me.Controls.Add(Me.MusicListSubMenu)
        Me.Controls.Add(Me.MusicSortSubMenu)
        Me.Name = "MusicScreen"
        Me.Size = New System.Drawing.Size(440, 440)
        Me.MusicPlayerSubMenu2.ResumeLayout(False)
        Me.MusicPlayerSubMenu.ResumeLayout(False)
        Me.MusicListSubMenu.ResumeLayout(False)
        Me.MusicSortSubMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PlaylistsMusicSortButton As System.Windows.Forms.Button
    Friend WithEvents MusicPlayerSubMenu2 As Scanning.SubMenu
    Friend WithEvents MusicShuffleButton As System.Windows.Forms.Button
    Friend WithEvents MusicRepeatButton As System.Windows.Forms.Button
    Friend WithEvents MusicPreviousButton As System.Windows.Forms.Button
    Friend WithEvents MusicNextButton As System.Windows.Forms.Button
    Friend WithEvents MusicPlayerSubMenu As Scanning.SubMenu
    Friend WithEvents MusicFastForwardButton As System.Windows.Forms.Button
    Friend WithEvents MusicRewindButton As System.Windows.Forms.Button
    Friend WithEvents MusicPlayPauseButton As System.Windows.Forms.Button
    Friend WithEvents MusicListSubMenu As Scanning.SubMenu
    Friend WithEvents MusicSortSubMenu As Scanning.SubMenu
    Friend WithEvents ArtistsMusicSortButton As System.Windows.Forms.Button
    Friend WithEvents MusicSelectButton As System.Windows.Forms.Button
    Friend WithEvents MusicDownButton As System.Windows.Forms.Button
    Friend WithEvents MusicUpButton As System.Windows.Forms.Button
    Friend WithEvents MusicListBox As System.Windows.Forms.ListBox

End Class
