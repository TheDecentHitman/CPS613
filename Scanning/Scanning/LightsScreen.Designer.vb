<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LightsScreen
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
        Me.LightsLabel = New System.Windows.Forms.Label()
        Me.LightsSubMenu = New Scanning.SubMenu()
        Me.LightsSpecRoomButton = New System.Windows.Forms.Button()
        Me.LightsCentralAptButton = New System.Windows.Forms.Button()
        Me.LightsSubMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'LightsLabel
        '
        Me.LightsLabel.AutoSize = True
        Me.LightsLabel.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LightsLabel.Location = New System.Drawing.Point(193, 125)
        Me.LightsLabel.Name = "LightsLabel"
        Me.LightsLabel.Size = New System.Drawing.Size(54, 21)
        Me.LightsLabel.TabIndex = 18
        Me.LightsLabel.Text = "Lights"
        '
        'LightsSubMenu
        '
        Me.LightsSubMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LightsSubMenu.Controls.Add(Me.LightsSpecRoomButton)
        Me.LightsSubMenu.Controls.Add(Me.LightsCentralAptButton)
        Me.LightsSubMenu.Location = New System.Drawing.Point(0, 156)
        Me.LightsSubMenu.Name = "LightsSubMenu"
        Me.LightsSubMenu.Size = New System.Drawing.Size(440, 160)
        Me.LightsSubMenu.TabIndex = 3
        '
        'LightsSpecRoomButton
        '
        Me.LightsSpecRoomButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LightsSpecRoomButton.Location = New System.Drawing.Point(231, 17)
        Me.LightsSpecRoomButton.Name = "LightsSpecRoomButton"
        Me.LightsSpecRoomButton.Size = New System.Drawing.Size(200, 120)
        Me.LightsSpecRoomButton.TabIndex = 4
        Me.LightsSpecRoomButton.Text = "Specific Room"
        Me.LightsSpecRoomButton.UseVisualStyleBackColor = True
        '
        'LightsCentralAptButton
        '
        Me.LightsCentralAptButton.BackColor = System.Drawing.SystemColors.Control
        Me.LightsCentralAptButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LightsCentralAptButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LightsCentralAptButton.Location = New System.Drawing.Point(6, 17)
        Me.LightsCentralAptButton.Name = "LightsCentralAptButton"
        Me.LightsCentralAptButton.Size = New System.Drawing.Size(200, 120)
        Me.LightsCentralAptButton.TabIndex = 3
        Me.LightsCentralAptButton.Text = "Central Apartment"
        Me.LightsCentralAptButton.UseVisualStyleBackColor = False
        '
        'LightsScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LightsLabel)
        Me.Controls.Add(Me.LightsSubMenu)
        Me.Name = "LightsScreen"
        Me.Size = New System.Drawing.Size(440, 440)
        Me.LightsSubMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LightsLabel As System.Windows.Forms.Label
    Friend WithEvents LightsSubMenu As Scanning.SubMenu
    Friend WithEvents LightsSpecRoomButton As System.Windows.Forms.Button
    Friend WithEvents LightsCentralAptButton As System.Windows.Forms.Button

End Class
