<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.OptionsSubMenu = New Scanning.SubMenu()
        Me.SettingsButton = New System.Windows.Forms.Button()
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.MainSubMenu = New Scanning.SubMenu()
        Me.NavigationButton = New System.Windows.Forms.Button()
        Me.EnvironmentButton = New System.Windows.Forms.Button()
        Me.CommunicationsButton = New System.Windows.Forms.Button()
        Me.EntertainmentButton = New System.Windows.Forms.Button()
        Me.TopMenu = New Scanning.TopMenu()
        Me.OptionsSubMenu.SuspendLayout()
        Me.MainSubMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'OptionsSubMenu
        '
        Me.OptionsSubMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.OptionsSubMenu.Controls.Add(Me.SettingsButton)
        Me.OptionsSubMenu.Controls.Add(Me.HomeButton)
        Me.OptionsSubMenu.Controls.Add(Me.BackButton)
        Me.OptionsSubMenu.Location = New System.Drawing.Point(17, 499)
        Me.OptionsSubMenu.Name = "OptionsSubMenu"
        Me.OptionsSubMenu.Size = New System.Drawing.Size(500, 110)
        Me.OptionsSubMenu.TabIndex = 9
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
        'MainSubMenu
        '
        Me.MainSubMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MainSubMenu.Controls.Add(Me.NavigationButton)
        Me.MainSubMenu.Controls.Add(Me.EnvironmentButton)
        Me.MainSubMenu.Controls.Add(Me.CommunicationsButton)
        Me.MainSubMenu.Controls.Add(Me.EntertainmentButton)
        Me.MainSubMenu.Location = New System.Drawing.Point(17, 5)
        Me.MainSubMenu.Name = "MainSubMenu"
        Me.MainSubMenu.Size = New System.Drawing.Size(500, 500)
        Me.MainSubMenu.TabIndex = 9
        '
        'NavigationButton
        '
        Me.NavigationButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavigationButton.Location = New System.Drawing.Point(10, 9)
        Me.NavigationButton.Name = "NavigationButton"
        Me.NavigationButton.Size = New System.Drawing.Size(240, 240)
        Me.NavigationButton.TabIndex = 0
        Me.NavigationButton.Text = "Navigation"
        Me.NavigationButton.UseVisualStyleBackColor = True
        '
        'EnvironmentButton
        '
        Me.EnvironmentButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnvironmentButton.Location = New System.Drawing.Point(247, 9)
        Me.EnvironmentButton.Name = "EnvironmentButton"
        Me.EnvironmentButton.Size = New System.Drawing.Size(240, 240)
        Me.EnvironmentButton.TabIndex = 1
        Me.EnvironmentButton.Text = "Environment"
        Me.EnvironmentButton.UseVisualStyleBackColor = True
        '
        'CommunicationsButton
        '
        Me.CommunicationsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CommunicationsButton.Location = New System.Drawing.Point(247, 246)
        Me.CommunicationsButton.Name = "CommunicationsButton"
        Me.CommunicationsButton.Size = New System.Drawing.Size(240, 240)
        Me.CommunicationsButton.TabIndex = 3
        Me.CommunicationsButton.Text = "Communications"
        Me.CommunicationsButton.UseVisualStyleBackColor = True
        '
        'EntertainmentButton
        '
        Me.EntertainmentButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EntertainmentButton.Location = New System.Drawing.Point(10, 246)
        Me.EntertainmentButton.Name = "EntertainmentButton"
        Me.EntertainmentButton.Size = New System.Drawing.Size(240, 240)
        Me.EntertainmentButton.TabIndex = 2
        Me.EntertainmentButton.Text = "Entertainment"
        Me.EntertainmentButton.UseVisualStyleBackColor = True
        '
        'TopMenu
        '
        Me.TopMenu.Location = New System.Drawing.Point(578, 12)
        Me.TopMenu.Name = "TopMenu"
        Me.TopMenu.ScanningInterval = 1000
        Me.TopMenu.Size = New System.Drawing.Size(25, 30)
        Me.TopMenu.TabIndex = 3
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 611)
        Me.Controls.Add(Me.OptionsSubMenu)
        Me.Controls.Add(Me.MainSubMenu)
        Me.Controls.Add(Me.TopMenu)
        Me.Name = "MainForm"
        Me.Text = "CPS613 Scanning Example"
        Me.OptionsSubMenu.ResumeLayout(False)
        Me.MainSubMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TopMenu As Scanning.TopMenu
    Friend WithEvents CommunicationsButton As System.Windows.Forms.Button
    Friend WithEvents EntertainmentButton As System.Windows.Forms.Button
    Friend WithEvents EnvironmentButton As System.Windows.Forms.Button
    Friend WithEvents NavigationButton As System.Windows.Forms.Button
    Friend WithEvents MainSubMenu As Scanning.SubMenu
    Friend WithEvents OptionsSubMenu As Scanning.SubMenu
    Friend WithEvents SettingsButton As System.Windows.Forms.Button
    Friend WithEvents HomeButton As System.Windows.Forms.Button
    Friend WithEvents BackButton As System.Windows.Forms.Button
End Class
