<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NavigationScreen
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
        Me.FloorSubMenu = New Scanning.SubMenu()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button0 = New System.Windows.Forms.Button()
        Me.EleSubMenu = New Scanning.SubMenu()
        Me.SelFloorButton = New System.Windows.Forms.Button()
        Me.DefFloorButton = New System.Windows.Forms.Button()
        Me.NavSubMenu = New Scanning.SubMenu()
        Me.DoorbellButton = New System.Windows.Forms.Button()
        Me.ElevatorControlButton = New System.Windows.Forms.Button()
        Me.DoorControlButton = New System.Windows.Forms.Button()
        Me.FloorSubMenu.SuspendLayout()
        Me.EleSubMenu.SuspendLayout()
        Me.NavSubMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'FloorSubMenu
        '
        Me.FloorSubMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FloorSubMenu.Controls.Add(Me.Button6)
        Me.FloorSubMenu.Controls.Add(Me.Button5)
        Me.FloorSubMenu.Controls.Add(Me.Button4)
        Me.FloorSubMenu.Controls.Add(Me.Button3)
        Me.FloorSubMenu.Controls.Add(Me.Button2)
        Me.FloorSubMenu.Controls.Add(Me.Button1)
        Me.FloorSubMenu.Controls.Add(Me.Button0)
        Me.FloorSubMenu.Location = New System.Drawing.Point(1, 348)
        Me.FloorSubMenu.Name = "FloorSubMenu"
        Me.FloorSubMenu.Size = New System.Drawing.Size(440, 89)
        Me.FloorSubMenu.TabIndex = 5
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(394, 27)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(39, 30)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(329, 27)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(39, 30)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(264, 27)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(39, 30)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(199, 27)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(39, 30)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(134, 27)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(39, 30)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(69, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(39, 30)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "G"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button0
        '
        Me.Button0.Location = New System.Drawing.Point(4, 27)
        Me.Button0.Name = "Button0"
        Me.Button0.Size = New System.Drawing.Size(39, 30)
        Me.Button0.TabIndex = 3
        Me.Button0.Text = "B"
        Me.Button0.UseVisualStyleBackColor = True
        '
        'EleSubMenu
        '
        Me.EleSubMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.EleSubMenu.Controls.Add(Me.SelFloorButton)
        Me.EleSubMenu.Controls.Add(Me.DefFloorButton)
        Me.EleSubMenu.Location = New System.Drawing.Point(0, 204)
        Me.EleSubMenu.Name = "EleSubMenu"
        Me.EleSubMenu.Size = New System.Drawing.Size(440, 111)
        Me.EleSubMenu.TabIndex = 4
        '
        'SelFloorButton
        '
        Me.SelFloorButton.Location = New System.Drawing.Point(256, 29)
        Me.SelFloorButton.Name = "SelFloorButton"
        Me.SelFloorButton.Size = New System.Drawing.Size(153, 53)
        Me.SelFloorButton.TabIndex = 4
        Me.SelFloorButton.Text = "Select Floor"
        Me.SelFloorButton.UseVisualStyleBackColor = True
        '
        'DefFloorButton
        '
        Me.DefFloorButton.Location = New System.Drawing.Point(28, 29)
        Me.DefFloorButton.Name = "DefFloorButton"
        Me.DefFloorButton.Size = New System.Drawing.Size(153, 53)
        Me.DefFloorButton.TabIndex = 3
        Me.DefFloorButton.Text = "Default Floor"
        Me.DefFloorButton.UseVisualStyleBackColor = True
        '
        'NavSubMenu
        '
        Me.NavSubMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.NavSubMenu.Controls.Add(Me.DoorbellButton)
        Me.NavSubMenu.Controls.Add(Me.ElevatorControlButton)
        Me.NavSubMenu.Controls.Add(Me.DoorControlButton)
        Me.NavSubMenu.Location = New System.Drawing.Point(0, 4)
        Me.NavSubMenu.Name = "NavSubMenu"
        Me.NavSubMenu.Size = New System.Drawing.Size(440, 183)
        Me.NavSubMenu.TabIndex = 3
        '
        'DoorbellButton
        '
        Me.DoorbellButton.Location = New System.Drawing.Point(26, 134)
        Me.DoorbellButton.Name = "DoorbellButton"
        Me.DoorbellButton.Size = New System.Drawing.Size(115, 23)
        Me.DoorbellButton.TabIndex = 5
        Me.DoorbellButton.Text = "Doorbell"
        Me.DoorbellButton.UseVisualStyleBackColor = True
        '
        'ElevatorControlButton
        '
        Me.ElevatorControlButton.Location = New System.Drawing.Point(296, 19)
        Me.ElevatorControlButton.Name = "ElevatorControlButton"
        Me.ElevatorControlButton.Size = New System.Drawing.Size(114, 89)
        Me.ElevatorControlButton.TabIndex = 4
        Me.ElevatorControlButton.Text = "Elevator Control"
        Me.ElevatorControlButton.UseVisualStyleBackColor = True
        '
        'DoorControlButton
        '
        Me.DoorControlButton.Location = New System.Drawing.Point(26, 19)
        Me.DoorControlButton.Name = "DoorControlButton"
        Me.DoorControlButton.Size = New System.Drawing.Size(115, 89)
        Me.DoorControlButton.TabIndex = 3
        Me.DoorControlButton.Text = "Door Control"
        Me.DoorControlButton.UseVisualStyleBackColor = True
        '
        'NavigationScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.FloorSubMenu)
        Me.Controls.Add(Me.EleSubMenu)
        Me.Controls.Add(Me.NavSubMenu)
        Me.Name = "NavigationScreen"
        Me.Size = New System.Drawing.Size(440, 440)
        Me.FloorSubMenu.ResumeLayout(False)
        Me.EleSubMenu.ResumeLayout(False)
        Me.NavSubMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FloorSubMenu As Scanning.SubMenu
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button0 As System.Windows.Forms.Button
    Friend WithEvents EleSubMenu As Scanning.SubMenu
    Friend WithEvents SelFloorButton As System.Windows.Forms.Button
    Friend WithEvents DefFloorButton As System.Windows.Forms.Button
    Friend WithEvents NavSubMenu As Scanning.SubMenu
    Friend WithEvents DoorbellButton As System.Windows.Forms.Button
    Friend WithEvents ElevatorControlButton As System.Windows.Forms.Button
    Friend WithEvents DoorControlButton As System.Windows.Forms.Button

End Class
