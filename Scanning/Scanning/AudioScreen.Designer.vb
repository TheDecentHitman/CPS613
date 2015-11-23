<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AudioScreen
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
        Me.AudioPlayerSubMenu = New Scanning.SubMenu()
        Me.AudioNextButton = New System.Windows.Forms.Button()
        Me.AudioPreviousButton = New System.Windows.Forms.Button()
        Me.AudioFastForwardButton = New System.Windows.Forms.Button()
        Me.AudioRewindButton = New System.Windows.Forms.Button()
        Me.AudioPlayPauseButton = New System.Windows.Forms.Button()
        Me.AudioListSubMenu = New Scanning.SubMenu()
        Me.AudioDeleteButton = New System.Windows.Forms.Button()
        Me.AudioSelectButton = New System.Windows.Forms.Button()
        Me.AudioDownButton = New System.Windows.Forms.Button()
        Me.AudioUpButton = New System.Windows.Forms.Button()
        Me.AudioListBox = New System.Windows.Forms.ListBox()
        Me.AudioSortSubMenu = New Scanning.SubMenu()
        Me.AudioLocalSortButton = New System.Windows.Forms.Button()
        Me.AudioPodcastsSortButton = New System.Windows.Forms.Button()
        Me.AudioRadioSortButton = New System.Windows.Forms.Button()
        Me.AudioPlayerSubMenu.SuspendLayout()
        Me.AudioListSubMenu.SuspendLayout()
        Me.AudioSortSubMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'AudioPlayerSubMenu
        '
        Me.AudioPlayerSubMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AudioPlayerSubMenu.Controls.Add(Me.AudioNextButton)
        Me.AudioPlayerSubMenu.Controls.Add(Me.AudioPreviousButton)
        Me.AudioPlayerSubMenu.Controls.Add(Me.AudioFastForwardButton)
        Me.AudioPlayerSubMenu.Controls.Add(Me.AudioRewindButton)
        Me.AudioPlayerSubMenu.Controls.Add(Me.AudioPlayPauseButton)
        Me.AudioPlayerSubMenu.Location = New System.Drawing.Point(4, 366)
        Me.AudioPlayerSubMenu.Name = "AudioPlayerSubMenu"
        Me.AudioPlayerSubMenu.Size = New System.Drawing.Size(433, 71)
        Me.AudioPlayerSubMenu.TabIndex = 5
        '
        'AudioNextButton
        '
        Me.AudioNextButton.Enabled = False
        Me.AudioNextButton.Location = New System.Drawing.Point(349, 22)
        Me.AudioNextButton.Name = "AudioNextButton"
        Me.AudioNextButton.Size = New System.Drawing.Size(75, 23)
        Me.AudioNextButton.TabIndex = 7
        Me.AudioNextButton.Text = "Next"
        Me.AudioNextButton.UseVisualStyleBackColor = True
        '
        'AudioPreviousButton
        '
        Me.AudioPreviousButton.Enabled = False
        Me.AudioPreviousButton.Location = New System.Drawing.Point(5, 22)
        Me.AudioPreviousButton.Name = "AudioPreviousButton"
        Me.AudioPreviousButton.Size = New System.Drawing.Size(75, 23)
        Me.AudioPreviousButton.TabIndex = 3
        Me.AudioPreviousButton.Text = "Previous"
        Me.AudioPreviousButton.UseVisualStyleBackColor = True
        '
        'AudioFastForwardButton
        '
        Me.AudioFastForwardButton.Enabled = False
        Me.AudioFastForwardButton.Location = New System.Drawing.Point(263, 22)
        Me.AudioFastForwardButton.Name = "AudioFastForwardButton"
        Me.AudioFastForwardButton.Size = New System.Drawing.Size(75, 23)
        Me.AudioFastForwardButton.TabIndex = 6
        Me.AudioFastForwardButton.Text = "Fast Forward"
        Me.AudioFastForwardButton.UseVisualStyleBackColor = True
        '
        'AudioRewindButton
        '
        Me.AudioRewindButton.Enabled = False
        Me.AudioRewindButton.Location = New System.Drawing.Point(91, 22)
        Me.AudioRewindButton.Name = "AudioRewindButton"
        Me.AudioRewindButton.Size = New System.Drawing.Size(75, 23)
        Me.AudioRewindButton.TabIndex = 4
        Me.AudioRewindButton.Text = "Rewind"
        Me.AudioRewindButton.UseVisualStyleBackColor = True
        '
        'AudioPlayPauseButton
        '
        Me.AudioPlayPauseButton.Location = New System.Drawing.Point(177, 22)
        Me.AudioPlayPauseButton.Name = "AudioPlayPauseButton"
        Me.AudioPlayPauseButton.Size = New System.Drawing.Size(75, 23)
        Me.AudioPlayPauseButton.TabIndex = 5
        Me.AudioPlayPauseButton.Text = "Play/Pause"
        Me.AudioPlayPauseButton.UseVisualStyleBackColor = True
        '
        'AudioListSubMenu
        '
        Me.AudioListSubMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AudioListSubMenu.Controls.Add(Me.AudioDeleteButton)
        Me.AudioListSubMenu.Controls.Add(Me.AudioSelectButton)
        Me.AudioListSubMenu.Controls.Add(Me.AudioDownButton)
        Me.AudioListSubMenu.Controls.Add(Me.AudioUpButton)
        Me.AudioListSubMenu.Controls.Add(Me.AudioListBox)
        Me.AudioListSubMenu.Location = New System.Drawing.Point(4, 67)
        Me.AudioListSubMenu.Name = "AudioListSubMenu"
        Me.AudioListSubMenu.Size = New System.Drawing.Size(433, 293)
        Me.AudioListSubMenu.TabIndex = 4
        '
        'AudioDeleteButton
        '
        Me.AudioDeleteButton.Location = New System.Drawing.Point(346, 218)
        Me.AudioDeleteButton.Name = "AudioDeleteButton"
        Me.AudioDeleteButton.Size = New System.Drawing.Size(75, 50)
        Me.AudioDeleteButton.TabIndex = 6
        Me.AudioDeleteButton.Text = "Delete"
        Me.AudioDeleteButton.UseVisualStyleBackColor = True
        '
        'AudioSelectButton
        '
        Me.AudioSelectButton.Location = New System.Drawing.Point(346, 150)
        Me.AudioSelectButton.Name = "AudioSelectButton"
        Me.AudioSelectButton.Size = New System.Drawing.Size(75, 50)
        Me.AudioSelectButton.TabIndex = 5
        Me.AudioSelectButton.Text = "Select"
        Me.AudioSelectButton.UseVisualStyleBackColor = True
        '
        'AudioDownButton
        '
        Me.AudioDownButton.Location = New System.Drawing.Point(346, 82)
        Me.AudioDownButton.Name = "AudioDownButton"
        Me.AudioDownButton.Size = New System.Drawing.Size(75, 50)
        Me.AudioDownButton.TabIndex = 4
        Me.AudioDownButton.Text = "Down"
        Me.AudioDownButton.UseVisualStyleBackColor = True
        '
        'AudioUpButton
        '
        Me.AudioUpButton.Location = New System.Drawing.Point(346, 14)
        Me.AudioUpButton.Name = "AudioUpButton"
        Me.AudioUpButton.Size = New System.Drawing.Size(75, 50)
        Me.AudioUpButton.TabIndex = 3
        Me.AudioUpButton.Text = "Up"
        Me.AudioUpButton.UseVisualStyleBackColor = True
        '
        'AudioListBox
        '
        Me.AudioListBox.FormattingEnabled = True
        Me.AudioListBox.Location = New System.Drawing.Point(3, 3)
        Me.AudioListBox.Name = "AudioListBox"
        Me.AudioListBox.Size = New System.Drawing.Size(330, 277)
        Me.AudioListBox.TabIndex = 0
        '
        'AudioSortSubMenu
        '
        Me.AudioSortSubMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AudioSortSubMenu.Controls.Add(Me.AudioLocalSortButton)
        Me.AudioSortSubMenu.Controls.Add(Me.AudioPodcastsSortButton)
        Me.AudioSortSubMenu.Controls.Add(Me.AudioRadioSortButton)
        Me.AudioSortSubMenu.Location = New System.Drawing.Point(3, 4)
        Me.AudioSortSubMenu.Name = "AudioSortSubMenu"
        Me.AudioSortSubMenu.Size = New System.Drawing.Size(434, 58)
        Me.AudioSortSubMenu.TabIndex = 3
        '
        'AudioLocalSortButton
        '
        Me.AudioLocalSortButton.Location = New System.Drawing.Point(322, 3)
        Me.AudioLocalSortButton.Name = "AudioLocalSortButton"
        Me.AudioLocalSortButton.Size = New System.Drawing.Size(75, 48)
        Me.AudioLocalSortButton.TabIndex = 5
        Me.AudioLocalSortButton.Text = "Local"
        Me.AudioLocalSortButton.UseVisualStyleBackColor = True
        '
        'AudioPodcastsSortButton
        '
        Me.AudioPodcastsSortButton.Location = New System.Drawing.Point(178, 3)
        Me.AudioPodcastsSortButton.Name = "AudioPodcastsSortButton"
        Me.AudioPodcastsSortButton.Size = New System.Drawing.Size(75, 48)
        Me.AudioPodcastsSortButton.TabIndex = 4
        Me.AudioPodcastsSortButton.Text = "Podcasts"
        Me.AudioPodcastsSortButton.UseVisualStyleBackColor = True
        '
        'AudioRadioSortButton
        '
        Me.AudioRadioSortButton.Location = New System.Drawing.Point(34, 3)
        Me.AudioRadioSortButton.Name = "AudioRadioSortButton"
        Me.AudioRadioSortButton.Size = New System.Drawing.Size(75, 48)
        Me.AudioRadioSortButton.TabIndex = 3
        Me.AudioRadioSortButton.Text = "Radio"
        Me.AudioRadioSortButton.UseVisualStyleBackColor = True
        '
        'AudioScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.AudioPlayerSubMenu)
        Me.Controls.Add(Me.AudioListSubMenu)
        Me.Controls.Add(Me.AudioSortSubMenu)
        Me.Name = "AudioScreen"
        Me.Size = New System.Drawing.Size(440, 440)
        Me.AudioPlayerSubMenu.ResumeLayout(False)
        Me.AudioListSubMenu.ResumeLayout(False)
        Me.AudioSortSubMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AudioSortSubMenu As Scanning.SubMenu
    Friend WithEvents AudioLocalSortButton As System.Windows.Forms.Button
    Friend WithEvents AudioPodcastsSortButton As System.Windows.Forms.Button
    Friend WithEvents AudioRadioSortButton As System.Windows.Forms.Button
    Friend WithEvents AudioListSubMenu As Scanning.SubMenu
    Friend WithEvents AudioPlayerSubMenu As Scanning.SubMenu
    Friend WithEvents AudioFastForwardButton As System.Windows.Forms.Button
    Friend WithEvents AudioRewindButton As System.Windows.Forms.Button
    Friend WithEvents AudioPlayPauseButton As System.Windows.Forms.Button
    Friend WithEvents AudioNextButton As System.Windows.Forms.Button
    Friend WithEvents AudioPreviousButton As System.Windows.Forms.Button
    Friend WithEvents AudioListBox As System.Windows.Forms.ListBox
    Friend WithEvents AudioDeleteButton As System.Windows.Forms.Button
    Friend WithEvents AudioSelectButton As System.Windows.Forms.Button
    Friend WithEvents AudioDownButton As System.Windows.Forms.Button
    Friend WithEvents AudioUpButton As System.Windows.Forms.Button

End Class
