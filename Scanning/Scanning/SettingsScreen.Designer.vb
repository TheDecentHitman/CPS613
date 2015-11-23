<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsScreen
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
        Me.ScanningSpeedSubMenu = New Scanning.SubMenu()
        Me.ScanningSpeedSectionLabel = New System.Windows.Forms.Label()
        Me.ScannerSpeedLabel = New System.Windows.Forms.Label()
        Me.IncreaseSpeedButton = New System.Windows.Forms.Button()
        Me.DecreaseSpeedButton = New System.Windows.Forms.Button()
        Me.ScanningSpeedSubMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'ScanningSpeedSubMenu
        '
        Me.ScanningSpeedSubMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ScanningSpeedSubMenu.Controls.Add(Me.ScanningSpeedSectionLabel)
        Me.ScanningSpeedSubMenu.Controls.Add(Me.ScannerSpeedLabel)
        Me.ScanningSpeedSubMenu.Controls.Add(Me.IncreaseSpeedButton)
        Me.ScanningSpeedSubMenu.Controls.Add(Me.DecreaseSpeedButton)
        Me.ScanningSpeedSubMenu.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ScanningSpeedSubMenu.Location = New System.Drawing.Point(0, 39)
        Me.ScanningSpeedSubMenu.Name = "ScanningSpeedSubMenu"
        Me.ScanningSpeedSubMenu.Size = New System.Drawing.Size(440, 120)
        Me.ScanningSpeedSubMenu.TabIndex = 3
        '
        'ScanningSpeedSectionLabel
        '
        Me.ScanningSpeedSectionLabel.AutoSize = True
        Me.ScanningSpeedSectionLabel.Location = New System.Drawing.Point(3, 0)
        Me.ScanningSpeedSectionLabel.Name = "ScanningSpeedSectionLabel"
        Me.ScanningSpeedSectionLabel.Size = New System.Drawing.Size(86, 13)
        Me.ScanningSpeedSectionLabel.TabIndex = 3
        Me.ScanningSpeedSectionLabel.Text = "Scanning Speed"
        '
        'ScannerSpeedLabel
        '
        Me.ScannerSpeedLabel.AutoSize = True
        Me.ScannerSpeedLabel.Location = New System.Drawing.Point(218, 56)
        Me.ScannerSpeedLabel.Name = "ScannerSpeedLabel"
        Me.ScannerSpeedLabel.Size = New System.Drawing.Size(0, 13)
        Me.ScannerSpeedLabel.TabIndex = 2
        '
        'IncreaseSpeedButton
        '
        Me.IncreaseSpeedButton.Location = New System.Drawing.Point(304, 21)
        Me.IncreaseSpeedButton.Name = "IncreaseSpeedButton"
        Me.IncreaseSpeedButton.Size = New System.Drawing.Size(75, 75)
        Me.IncreaseSpeedButton.TabIndex = 4
        Me.IncreaseSpeedButton.Text = "Increase Speed"
        Me.IncreaseSpeedButton.UseVisualStyleBackColor = True
        '
        'DecreaseSpeedButton
        '
        Me.DecreaseSpeedButton.Location = New System.Drawing.Point(57, 21)
        Me.DecreaseSpeedButton.Name = "DecreaseSpeedButton"
        Me.DecreaseSpeedButton.Size = New System.Drawing.Size(75, 75)
        Me.DecreaseSpeedButton.TabIndex = 3
        Me.DecreaseSpeedButton.Text = "Decrease Speed"
        Me.DecreaseSpeedButton.UseVisualStyleBackColor = True
        '
        'SettingsScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ScanningSpeedSubMenu)
        Me.Name = "SettingsScreen"
        Me.Size = New System.Drawing.Size(440, 440)
        Me.ScanningSpeedSubMenu.ResumeLayout(False)
        Me.ScanningSpeedSubMenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ScanningSpeedSubMenu As Scanning.SubMenu
    Friend WithEvents IncreaseSpeedButton As System.Windows.Forms.Button
    Friend WithEvents DecreaseSpeedButton As System.Windows.Forms.Button
    Friend WithEvents ScannerSpeedLabel As System.Windows.Forms.Label
    Friend WithEvents ScanningSpeedSectionLabel As System.Windows.Forms.Label

End Class
