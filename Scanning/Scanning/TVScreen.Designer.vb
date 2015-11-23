<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TVScreen
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
        Me.TVStreamSortButton = New System.Windows.Forms.Button()
        Me.TVPreviousButton = New System.Windows.Forms.Button()
        Me.TVNextButton = New System.Windows.Forms.Button()
        Me.TVPlayerSubMenu = New Scanning.SubMenu()
        Me.TVFastForwardButton = New System.Windows.Forms.Button()
        Me.TVRewindButton = New System.Windows.Forms.Button()
        Me.TVPlayPauseButton = New System.Windows.Forms.Button()
        Me.TVListSubMenu = New Scanning.SubMenu()
        Me.TVSortSubMenu = New Scanning.SubMenu()
        Me.TVLocalSortButton = New System.Windows.Forms.Button()
        Me.TVLiveSortButton = New System.Windows.Forms.Button()
        Me.TVPlayerSubMenu.SuspendLayout()
        Me.TVSortSubMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'TVStreamSortButton
        '
        Me.TVStreamSortButton.Enabled = False
        Me.TVStreamSortButton.Location = New System.Drawing.Point(178, 3)
        Me.TVStreamSortButton.Name = "TVStreamSortButton"
        Me.TVStreamSortButton.Size = New System.Drawing.Size(75, 48)
        Me.TVStreamSortButton.TabIndex = 4
        Me.TVStreamSortButton.Text = "Stream"
        Me.TVStreamSortButton.UseVisualStyleBackColor = True
        '
        'TVPreviousButton
        '
        Me.TVPreviousButton.Enabled = False
        Me.TVPreviousButton.Location = New System.Drawing.Point(5, 20)
        Me.TVPreviousButton.Name = "TVPreviousButton"
        Me.TVPreviousButton.Size = New System.Drawing.Size(75, 23)
        Me.TVPreviousButton.TabIndex = 3
        Me.TVPreviousButton.Text = "Previous"
        Me.TVPreviousButton.UseVisualStyleBackColor = True
        '
        'TVNextButton
        '
        Me.TVNextButton.Enabled = False
        Me.TVNextButton.Location = New System.Drawing.Point(349, 20)
        Me.TVNextButton.Name = "TVNextButton"
        Me.TVNextButton.Size = New System.Drawing.Size(75, 23)
        Me.TVNextButton.TabIndex = 7
        Me.TVNextButton.Text = "Next"
        Me.TVNextButton.UseVisualStyleBackColor = True
        '
        'TVPlayerSubMenu
        '
        Me.TVPlayerSubMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TVPlayerSubMenu.Controls.Add(Me.TVNextButton)
        Me.TVPlayerSubMenu.Controls.Add(Me.TVPreviousButton)
        Me.TVPlayerSubMenu.Controls.Add(Me.TVFastForwardButton)
        Me.TVPlayerSubMenu.Controls.Add(Me.TVRewindButton)
        Me.TVPlayerSubMenu.Controls.Add(Me.TVPlayPauseButton)
        Me.TVPlayerSubMenu.Location = New System.Drawing.Point(4, 370)
        Me.TVPlayerSubMenu.Name = "TVPlayerSubMenu"
        Me.TVPlayerSubMenu.Size = New System.Drawing.Size(433, 67)
        Me.TVPlayerSubMenu.TabIndex = 5
        '
        'TVFastForwardButton
        '
        Me.TVFastForwardButton.Enabled = False
        Me.TVFastForwardButton.Location = New System.Drawing.Point(263, 20)
        Me.TVFastForwardButton.Name = "TVFastForwardButton"
        Me.TVFastForwardButton.Size = New System.Drawing.Size(75, 23)
        Me.TVFastForwardButton.TabIndex = 6
        Me.TVFastForwardButton.Text = "Fast Forward"
        Me.TVFastForwardButton.UseVisualStyleBackColor = True
        '
        'TVRewindButton
        '
        Me.TVRewindButton.Enabled = False
        Me.TVRewindButton.Location = New System.Drawing.Point(91, 20)
        Me.TVRewindButton.Name = "TVRewindButton"
        Me.TVRewindButton.Size = New System.Drawing.Size(75, 23)
        Me.TVRewindButton.TabIndex = 4
        Me.TVRewindButton.Text = "Rewind"
        Me.TVRewindButton.UseVisualStyleBackColor = True
        '
        'TVPlayPauseButton
        '
        Me.TVPlayPauseButton.Location = New System.Drawing.Point(177, 20)
        Me.TVPlayPauseButton.Name = "TVPlayPauseButton"
        Me.TVPlayPauseButton.Size = New System.Drawing.Size(75, 23)
        Me.TVPlayPauseButton.TabIndex = 5
        Me.TVPlayPauseButton.Text = "Play/Pause"
        Me.TVPlayPauseButton.UseVisualStyleBackColor = True
        '
        'TVListSubMenu
        '
        Me.TVListSubMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TVListSubMenu.Location = New System.Drawing.Point(4, 67)
        Me.TVListSubMenu.Name = "TVListSubMenu"
        Me.TVListSubMenu.Size = New System.Drawing.Size(433, 297)
        Me.TVListSubMenu.TabIndex = 4
        '
        'TVSortSubMenu
        '
        Me.TVSortSubMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TVSortSubMenu.Controls.Add(Me.TVLocalSortButton)
        Me.TVSortSubMenu.Controls.Add(Me.TVStreamSortButton)
        Me.TVSortSubMenu.Controls.Add(Me.TVLiveSortButton)
        Me.TVSortSubMenu.Location = New System.Drawing.Point(3, 4)
        Me.TVSortSubMenu.Name = "TVSortSubMenu"
        Me.TVSortSubMenu.Size = New System.Drawing.Size(434, 58)
        Me.TVSortSubMenu.TabIndex = 3
        '
        'TVLocalSortButton
        '
        Me.TVLocalSortButton.Location = New System.Drawing.Point(322, 3)
        Me.TVLocalSortButton.Name = "TVLocalSortButton"
        Me.TVLocalSortButton.Size = New System.Drawing.Size(75, 48)
        Me.TVLocalSortButton.TabIndex = 5
        Me.TVLocalSortButton.Text = "Local"
        Me.TVLocalSortButton.UseVisualStyleBackColor = True
        '
        'TVLiveSortButton
        '
        Me.TVLiveSortButton.Location = New System.Drawing.Point(34, 3)
        Me.TVLiveSortButton.Name = "TVLiveSortButton"
        Me.TVLiveSortButton.Size = New System.Drawing.Size(75, 48)
        Me.TVLiveSortButton.TabIndex = 3
        Me.TVLiveSortButton.Text = "Live"
        Me.TVLiveSortButton.UseVisualStyleBackColor = True
        '
        'TVScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TVPlayerSubMenu)
        Me.Controls.Add(Me.TVListSubMenu)
        Me.Controls.Add(Me.TVSortSubMenu)
        Me.Name = "TVScreen"
        Me.Size = New System.Drawing.Size(440, 440)
        Me.TVPlayerSubMenu.ResumeLayout(False)
        Me.TVSortSubMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TVStreamSortButton As System.Windows.Forms.Button
    Friend WithEvents TVPreviousButton As System.Windows.Forms.Button
    Friend WithEvents TVNextButton As System.Windows.Forms.Button
    Friend WithEvents TVPlayerSubMenu As Scanning.SubMenu
    Friend WithEvents TVFastForwardButton As System.Windows.Forms.Button
    Friend WithEvents TVRewindButton As System.Windows.Forms.Button
    Friend WithEvents TVPlayPauseButton As System.Windows.Forms.Button
    Friend WithEvents TVListSubMenu As Scanning.SubMenu
    Friend WithEvents TVSortSubMenu As Scanning.SubMenu
    Friend WithEvents TVLocalSortButton As System.Windows.Forms.Button
    Friend WithEvents TVLiveSortButton As System.Windows.Forms.Button

End Class
