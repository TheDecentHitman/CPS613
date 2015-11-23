<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TemperatureAndFansScreen
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
        Me.FanLabel = New System.Windows.Forms.Label()
        Me.TemperatureLabel = New System.Windows.Forms.Label()
        Me.FanSubMenu = New Scanning.SubMenu()
        Me.FansSpecRoomButton = New System.Windows.Forms.Button()
        Me.FansCentralAptButton = New System.Windows.Forms.Button()
        Me.TemperatureSubMenu = New Scanning.SubMenu()
        Me.TempSpecRoomButton = New System.Windows.Forms.Button()
        Me.TempCentralAptButton = New System.Windows.Forms.Button()
        Me.FanSubMenu.SuspendLayout()
        Me.TemperatureSubMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'FanLabel
        '
        Me.FanLabel.AutoSize = True
        Me.FanLabel.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FanLabel.Location = New System.Drawing.Point(198, 241)
        Me.FanLabel.Name = "FanLabel"
        Me.FanLabel.Size = New System.Drawing.Size(45, 21)
        Me.FanLabel.TabIndex = 18
        Me.FanLabel.Text = "Fans"
        '
        'TemperatureLabel
        '
        Me.TemperatureLabel.AutoSize = True
        Me.TemperatureLabel.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TemperatureLabel.Location = New System.Drawing.Point(169, 10)
        Me.TemperatureLabel.Name = "TemperatureLabel"
        Me.TemperatureLabel.Size = New System.Drawing.Size(103, 21)
        Me.TemperatureLabel.TabIndex = 17
        Me.TemperatureLabel.Text = "Temperature"
        '
        'FanSubMenu
        '
        Me.FanSubMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FanSubMenu.Controls.Add(Me.FansSpecRoomButton)
        Me.FanSubMenu.Controls.Add(Me.FansCentralAptButton)
        Me.FanSubMenu.Location = New System.Drawing.Point(0, 271)
        Me.FanSubMenu.Name = "FanSubMenu"
        Me.FanSubMenu.Size = New System.Drawing.Size(440, 160)
        Me.FanSubMenu.TabIndex = 4
        '
        'FansSpecRoomButton
        '
        Me.FansSpecRoomButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FansSpecRoomButton.Location = New System.Drawing.Point(231, 22)
        Me.FansSpecRoomButton.Name = "FansSpecRoomButton"
        Me.FansSpecRoomButton.Size = New System.Drawing.Size(200, 120)
        Me.FansSpecRoomButton.TabIndex = 4
        Me.FansSpecRoomButton.Text = "Specific Room"
        Me.FansSpecRoomButton.UseVisualStyleBackColor = True
        '
        'FansCentralAptButton
        '
        Me.FansCentralAptButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FansCentralAptButton.Location = New System.Drawing.Point(6, 22)
        Me.FansCentralAptButton.Name = "FansCentralAptButton"
        Me.FansCentralAptButton.Size = New System.Drawing.Size(200, 120)
        Me.FansCentralAptButton.TabIndex = 3
        Me.FansCentralAptButton.Text = "Central Apartment"
        Me.FansCentralAptButton.UseVisualStyleBackColor = True
        '
        'TemperatureSubMenu
        '
        Me.TemperatureSubMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TemperatureSubMenu.Controls.Add(Me.TempSpecRoomButton)
        Me.TemperatureSubMenu.Controls.Add(Me.TempCentralAptButton)
        Me.TemperatureSubMenu.Location = New System.Drawing.Point(0, 41)
        Me.TemperatureSubMenu.Name = "TemperatureSubMenu"
        Me.TemperatureSubMenu.Size = New System.Drawing.Size(440, 160)
        Me.TemperatureSubMenu.TabIndex = 3
        '
        'TempSpecRoomButton
        '
        Me.TempSpecRoomButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TempSpecRoomButton.Location = New System.Drawing.Point(231, 17)
        Me.TempSpecRoomButton.Name = "TempSpecRoomButton"
        Me.TempSpecRoomButton.Size = New System.Drawing.Size(200, 120)
        Me.TempSpecRoomButton.TabIndex = 4
        Me.TempSpecRoomButton.Text = "Specific Room"
        Me.TempSpecRoomButton.UseVisualStyleBackColor = True
        '
        'TempCentralAptButton
        '
        Me.TempCentralAptButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TempCentralAptButton.Location = New System.Drawing.Point(6, 17)
        Me.TempCentralAptButton.Name = "TempCentralAptButton"
        Me.TempCentralAptButton.Size = New System.Drawing.Size(200, 120)
        Me.TempCentralAptButton.TabIndex = 3
        Me.TempCentralAptButton.Text = "Central Apartment"
        Me.TempCentralAptButton.UseVisualStyleBackColor = True
        '
        'TemperatureAndFansScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.FanLabel)
        Me.Controls.Add(Me.TemperatureLabel)
        Me.Controls.Add(Me.FanSubMenu)
        Me.Controls.Add(Me.TemperatureSubMenu)
        Me.Name = "TemperatureAndFansScreen"
        Me.Size = New System.Drawing.Size(440, 440)
        Me.FanSubMenu.ResumeLayout(False)
        Me.TemperatureSubMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FanLabel As System.Windows.Forms.Label
    Friend WithEvents TemperatureLabel As System.Windows.Forms.Label
    Friend WithEvents FanSubMenu As Scanning.SubMenu
    Friend WithEvents FansSpecRoomButton As System.Windows.Forms.Button
    Friend WithEvents FansCentralAptButton As System.Windows.Forms.Button
    Friend WithEvents TemperatureSubMenu As Scanning.SubMenu
    Friend WithEvents TempSpecRoomButton As System.Windows.Forms.Button
    Friend WithEvents TempCentralAptButton As System.Windows.Forms.Button

End Class
