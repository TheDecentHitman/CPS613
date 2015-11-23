<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WindowsAndBlindsScreen
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
        Me.WindowsLabel = New System.Windows.Forms.Label()
        Me.WindowsSubMenu = New Scanning.SubMenu()
        Me.WindowsSpecRoomButton = New System.Windows.Forms.Button()
        Me.WindowsCentralAptButton = New System.Windows.Forms.Button()
        Me.BlindsLabel = New System.Windows.Forms.Label()
        Me.BlindsSubMenu = New Scanning.SubMenu()
        Me.BlindsSpecRoomButton = New System.Windows.Forms.Button()
        Me.BlindsCentralAptButton = New System.Windows.Forms.Button()
        Me.WindowsSubMenu.SuspendLayout()
        Me.BlindsSubMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'WindowsLabel
        '
        Me.WindowsLabel.AutoSize = True
        Me.WindowsLabel.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WindowsLabel.Location = New System.Drawing.Point(183, 10)
        Me.WindowsLabel.Name = "WindowsLabel"
        Me.WindowsLabel.Size = New System.Drawing.Size(75, 21)
        Me.WindowsLabel.TabIndex = 24
        Me.WindowsLabel.Text = "Windows"
        '
        'WindowsSubMenu
        '
        Me.WindowsSubMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.WindowsSubMenu.Controls.Add(Me.WindowsSpecRoomButton)
        Me.WindowsSubMenu.Controls.Add(Me.WindowsCentralAptButton)
        Me.WindowsSubMenu.Location = New System.Drawing.Point(0, 41)
        Me.WindowsSubMenu.Name = "WindowsSubMenu"
        Me.WindowsSubMenu.Size = New System.Drawing.Size(440, 160)
        Me.WindowsSubMenu.TabIndex = 3
        '
        'WindowsSpecRoomButton
        '
        Me.WindowsSpecRoomButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WindowsSpecRoomButton.Location = New System.Drawing.Point(231, 17)
        Me.WindowsSpecRoomButton.Name = "WindowsSpecRoomButton"
        Me.WindowsSpecRoomButton.Size = New System.Drawing.Size(200, 120)
        Me.WindowsSpecRoomButton.TabIndex = 4
        Me.WindowsSpecRoomButton.Text = "Specific Room"
        Me.WindowsSpecRoomButton.UseVisualStyleBackColor = True
        '
        'WindowsCentralAptButton
        '
        Me.WindowsCentralAptButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WindowsCentralAptButton.Location = New System.Drawing.Point(6, 17)
        Me.WindowsCentralAptButton.Name = "WindowsCentralAptButton"
        Me.WindowsCentralAptButton.Size = New System.Drawing.Size(200, 120)
        Me.WindowsCentralAptButton.TabIndex = 3
        Me.WindowsCentralAptButton.Text = "Central Apartment"
        Me.WindowsCentralAptButton.UseVisualStyleBackColor = True
        '
        'BlindsLabel
        '
        Me.BlindsLabel.AutoSize = True
        Me.BlindsLabel.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BlindsLabel.Location = New System.Drawing.Point(193, 241)
        Me.BlindsLabel.Name = "BlindsLabel"
        Me.BlindsLabel.Size = New System.Drawing.Size(54, 21)
        Me.BlindsLabel.TabIndex = 25
        Me.BlindsLabel.Text = "Blinds"
        '
        'BlindsSubMenu
        '
        Me.BlindsSubMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BlindsSubMenu.Controls.Add(Me.BlindsSpecRoomButton)
        Me.BlindsSubMenu.Controls.Add(Me.BlindsCentralAptButton)
        Me.BlindsSubMenu.Location = New System.Drawing.Point(0, 271)
        Me.BlindsSubMenu.Name = "BlindsSubMenu"
        Me.BlindsSubMenu.Size = New System.Drawing.Size(440, 160)
        Me.BlindsSubMenu.TabIndex = 4
        '
        'BlindsSpecRoomButton
        '
        Me.BlindsSpecRoomButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BlindsSpecRoomButton.Location = New System.Drawing.Point(231, 22)
        Me.BlindsSpecRoomButton.Name = "BlindsSpecRoomButton"
        Me.BlindsSpecRoomButton.Size = New System.Drawing.Size(200, 120)
        Me.BlindsSpecRoomButton.TabIndex = 4
        Me.BlindsSpecRoomButton.Text = "Specific Room"
        Me.BlindsSpecRoomButton.UseVisualStyleBackColor = True
        '
        'BlindsCentralAptButton
        '
        Me.BlindsCentralAptButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BlindsCentralAptButton.Location = New System.Drawing.Point(6, 22)
        Me.BlindsCentralAptButton.Name = "BlindsCentralAptButton"
        Me.BlindsCentralAptButton.Size = New System.Drawing.Size(200, 120)
        Me.BlindsCentralAptButton.TabIndex = 3
        Me.BlindsCentralAptButton.Text = "Central Apartment"
        Me.BlindsCentralAptButton.UseVisualStyleBackColor = True
        '
        'WindowsAndBlindsScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.WindowsLabel)
        Me.Controls.Add(Me.WindowsSubMenu)
        Me.Controls.Add(Me.BlindsLabel)
        Me.Controls.Add(Me.BlindsSubMenu)
        Me.Name = "WindowsAndBlindsScreen"
        Me.Size = New System.Drawing.Size(440, 440)
        Me.WindowsSubMenu.ResumeLayout(False)
        Me.BlindsSubMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WindowsLabel As System.Windows.Forms.Label
    Friend WithEvents WindowsSubMenu As Scanning.SubMenu
    Friend WithEvents WindowsSpecRoomButton As System.Windows.Forms.Button
    Friend WithEvents WindowsCentralAptButton As System.Windows.Forms.Button
    Friend WithEvents BlindsLabel As System.Windows.Forms.Label
    Friend WithEvents BlindsSubMenu As Scanning.SubMenu
    Friend WithEvents BlindsSpecRoomButton As System.Windows.Forms.Button
    Friend WithEvents BlindsCentralAptButton As System.Windows.Forms.Button

End Class
