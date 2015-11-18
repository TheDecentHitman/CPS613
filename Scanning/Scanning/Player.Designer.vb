<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Player
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SubMenu1 = New Scanning.SubMenu()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TopMenu1 = New Scanning.TopMenu()
        Me.OptionsSubMenu = New Scanning.SubMenu()
        Me.SettingsButton = New System.Windows.Forms.Button()
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SubMenu1.SuspendLayout()
        Me.OptionsSubMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Scanning.My.Resources.Resources.movie_theater_auditorium_540x360
        Me.PictureBox1.InitialImage = Global.Scanning.My.Resources.Resources.movie_theater_auditorium_540x360
        Me.PictureBox1.Location = New System.Drawing.Point(12, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(509, 365)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'SubMenu1
        '
        Me.SubMenu1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SubMenu1.Controls.Add(Me.Button7)
        Me.SubMenu1.Controls.Add(Me.Button6)
        Me.SubMenu1.Controls.Add(Me.Button5)
        Me.SubMenu1.Controls.Add(Me.Button4)
        Me.SubMenu1.Controls.Add(Me.Button3)
        Me.SubMenu1.Controls.Add(Me.Button2)
        Me.SubMenu1.Controls.Add(Me.Button1)
        Me.SubMenu1.Location = New System.Drawing.Point(12, 381)
        Me.SubMenu1.Name = "SubMenu1"
        Me.SubMenu1.Size = New System.Drawing.Size(510, 92)
        Me.SubMenu1.TabIndex = 1
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(62, 47)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "Forward"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(62, 18)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Rewind"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(384, 47)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Volume -"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(384, 18)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Volume +"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(214, 61)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Stop"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(214, 32)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Pause"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(214, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Play"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TopMenu1
        '
        Me.TopMenu1.Location = New System.Drawing.Point(7, 7)
        Me.TopMenu1.Name = "TopMenu1"
        Me.TopMenu1.ScanningInterval = 1000
        Me.TopMenu1.Size = New System.Drawing.Size(522, 594)
        Me.TopMenu1.TabIndex = 0
        '
        'OptionsSubMenu
        '
        Me.OptionsSubMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.OptionsSubMenu.Controls.Add(Me.SettingsButton)
        Me.OptionsSubMenu.Controls.Add(Me.HomeButton)
        Me.OptionsSubMenu.Controls.Add(Me.BackButton)
        Me.OptionsSubMenu.Location = New System.Drawing.Point(12, 489)
        Me.OptionsSubMenu.Name = "OptionsSubMenu"
        Me.OptionsSubMenu.Size = New System.Drawing.Size(509, 110)
        Me.OptionsSubMenu.TabIndex = 10
        '
        'SettingsButton
        '
        Me.SettingsButton.Location = New System.Drawing.Point(333, 3)
        Me.SettingsButton.Name = "SettingsButton"
        Me.SettingsButton.Size = New System.Drawing.Size(150, 100)
        Me.SettingsButton.TabIndex = 2
        Me.SettingsButton.Text = "Settings"
        Me.SettingsButton.UseVisualStyleBackColor = True
        '
        'HomeButton
        '
        Me.HomeButton.Location = New System.Drawing.Point(173, 3)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(150, 100)
        Me.HomeButton.TabIndex = 1
        Me.HomeButton.Text = "Home"
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(13, 3)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(150, 100)
        Me.BackButton.TabIndex = 0
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'Player
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 611)
        Me.Controls.Add(Me.OptionsSubMenu)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.SubMenu1)
        Me.Controls.Add(Me.TopMenu1)
        Me.Name = "Player"
        Me.Text = "Player"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SubMenu1.ResumeLayout(False)
        Me.OptionsSubMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TopMenu1 As TopMenu
    Friend WithEvents SubMenu1 As SubMenu
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents OptionsSubMenu As SubMenu
    Friend WithEvents SettingsButton As Button
    Friend WithEvents HomeButton As Button
    Friend WithEvents BackButton As Button
End Class
