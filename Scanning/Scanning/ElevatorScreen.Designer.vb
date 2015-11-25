<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ElevatorScreen
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
        Me.DefaultFloorButton = New System.Windows.Forms.Button()
        Me.ElevatorFloorsSubMenu = New Scanning.SubMenu()
        Me.Floor6Button = New System.Windows.Forms.Button()
        Me.Floor7Button = New System.Windows.Forms.Button()
        Me.Floor8Button = New System.Windows.Forms.Button()
        Me.Floor5Button = New System.Windows.Forms.Button()
        Me.FloorGButton = New System.Windows.Forms.Button()
        Me.Floor2Button = New System.Windows.Forms.Button()
        Me.Floor3Button = New System.Windows.Forms.Button()
        Me.Floor4Button = New System.Windows.Forms.Button()
        Me.FloorPButton = New System.Windows.Forms.Button()
        Me.ElevatorFloorsSubMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'DefaultFloorButton
        '
        Me.DefaultFloorButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DefaultFloorButton.Location = New System.Drawing.Point(104, 48)
        Me.DefaultFloorButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DefaultFloorButton.Name = "DefaultFloorButton"
        Me.DefaultFloorButton.Size = New System.Drawing.Size(454, 177)
        Me.DefaultFloorButton.TabIndex = 3
        Me.DefaultFloorButton.Text = "Default Floor"
        Me.DefaultFloorButton.UseVisualStyleBackColor = True
        '
        'ElevatorFloorsSubMenu
        '
        Me.ElevatorFloorsSubMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ElevatorFloorsSubMenu.Controls.Add(Me.Floor6Button)
        Me.ElevatorFloorsSubMenu.Controls.Add(Me.Floor7Button)
        Me.ElevatorFloorsSubMenu.Controls.Add(Me.Floor8Button)
        Me.ElevatorFloorsSubMenu.Controls.Add(Me.Floor5Button)
        Me.ElevatorFloorsSubMenu.Controls.Add(Me.FloorGButton)
        Me.ElevatorFloorsSubMenu.Controls.Add(Me.Floor2Button)
        Me.ElevatorFloorsSubMenu.Controls.Add(Me.Floor3Button)
        Me.ElevatorFloorsSubMenu.Controls.Add(Me.Floor4Button)
        Me.ElevatorFloorsSubMenu.Controls.Add(Me.FloorPButton)
        Me.ElevatorFloorsSubMenu.Location = New System.Drawing.Point(26, 257)
        Me.ElevatorFloorsSubMenu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ElevatorFloorsSubMenu.Name = "ElevatorFloorsSubMenu"
        Me.ElevatorFloorsSubMenu.Size = New System.Drawing.Size(607, 356)
        Me.ElevatorFloorsSubMenu.TabIndex = 4
        '
        'Floor6Button
        '
        Me.Floor6Button.Location = New System.Drawing.Point(158, 152)
        Me.Floor6Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Floor6Button.Name = "Floor6Button"
        Me.Floor6Button.Size = New System.Drawing.Size(45, 46)
        Me.Floor6Button.TabIndex = 9
        Me.Floor6Button.Text = "6"
        Me.Floor6Button.UseVisualStyleBackColor = True
        '
        'Floor7Button
        '
        Me.Floor7Button.Location = New System.Drawing.Point(279, 152)
        Me.Floor7Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Floor7Button.Name = "Floor7Button"
        Me.Floor7Button.Size = New System.Drawing.Size(45, 46)
        Me.Floor7Button.TabIndex = 10
        Me.Floor7Button.Text = "7"
        Me.Floor7Button.UseVisualStyleBackColor = True
        '
        'Floor8Button
        '
        Me.Floor8Button.Location = New System.Drawing.Point(400, 152)
        Me.Floor8Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Floor8Button.Name = "Floor8Button"
        Me.Floor8Button.Size = New System.Drawing.Size(45, 46)
        Me.Floor8Button.TabIndex = 11
        Me.Floor8Button.Text = "8"
        Me.Floor8Button.UseVisualStyleBackColor = True
        '
        'Floor5Button
        '
        Me.Floor5Button.Location = New System.Drawing.Point(36, 152)
        Me.Floor5Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Floor5Button.Name = "Floor5Button"
        Me.Floor5Button.Size = New System.Drawing.Size(45, 46)
        Me.Floor5Button.TabIndex = 8
        Me.Floor5Button.Text = "5"
        Me.Floor5Button.UseVisualStyleBackColor = True
        '
        'FloorGButton
        '
        Me.FloorGButton.Location = New System.Drawing.Point(158, 25)
        Me.FloorGButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FloorGButton.Name = "FloorGButton"
        Me.FloorGButton.Size = New System.Drawing.Size(45, 46)
        Me.FloorGButton.TabIndex = 4
        Me.FloorGButton.Text = "G"
        Me.FloorGButton.UseVisualStyleBackColor = True
        '
        'Floor2Button
        '
        Me.Floor2Button.Location = New System.Drawing.Point(279, 25)
        Me.Floor2Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Floor2Button.Name = "Floor2Button"
        Me.Floor2Button.Size = New System.Drawing.Size(45, 46)
        Me.Floor2Button.TabIndex = 5
        Me.Floor2Button.Text = "2"
        Me.Floor2Button.UseVisualStyleBackColor = True
        '
        'Floor3Button
        '
        Me.Floor3Button.Location = New System.Drawing.Point(400, 25)
        Me.Floor3Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Floor3Button.Name = "Floor3Button"
        Me.Floor3Button.Size = New System.Drawing.Size(45, 46)
        Me.Floor3Button.TabIndex = 6
        Me.Floor3Button.Text = "3"
        Me.Floor3Button.UseVisualStyleBackColor = True
        '
        'Floor4Button
        '
        Me.Floor4Button.Location = New System.Drawing.Point(522, 25)
        Me.Floor4Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Floor4Button.Name = "Floor4Button"
        Me.Floor4Button.Size = New System.Drawing.Size(45, 46)
        Me.Floor4Button.TabIndex = 7
        Me.Floor4Button.Text = "4"
        Me.Floor4Button.UseVisualStyleBackColor = True
        '
        'FloorPButton
        '
        Me.FloorPButton.Location = New System.Drawing.Point(36, 25)
        Me.FloorPButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FloorPButton.Name = "FloorPButton"
        Me.FloorPButton.Size = New System.Drawing.Size(45, 46)
        Me.FloorPButton.TabIndex = 3
        Me.FloorPButton.Text = "P"
        Me.FloorPButton.UseVisualStyleBackColor = True
        '
        'ElevatorScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ElevatorFloorsSubMenu)
        Me.Controls.Add(Me.DefaultFloorButton)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ElevatorScreen"
        Me.Size = New System.Drawing.Size(660, 677)
        Me.ElevatorFloorsSubMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DefaultFloorButton As System.Windows.Forms.Button
    Friend WithEvents ElevatorFloorsSubMenu As Scanning.SubMenu
    Friend WithEvents Floor6Button As System.Windows.Forms.Button
    Friend WithEvents Floor7Button As System.Windows.Forms.Button
    Friend WithEvents Floor8Button As System.Windows.Forms.Button
    Friend WithEvents Floor5Button As System.Windows.Forms.Button
    Friend WithEvents FloorGButton As System.Windows.Forms.Button
    Friend WithEvents Floor2Button As System.Windows.Forms.Button
    Friend WithEvents Floor3Button As System.Windows.Forms.Button
    Friend WithEvents Floor4Button As System.Windows.Forms.Button
    Friend WithEvents FloorPButton As System.Windows.Forms.Button

End Class
