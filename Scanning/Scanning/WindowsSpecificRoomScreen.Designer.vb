<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WindowsSpecificRoomScreen
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
        Me.SubMenu1 = New Scanning.SubMenu()
        Me.WindowsSpecRoom_BedroomButton = New System.Windows.Forms.Button()
        Me.WindowsSpecRoom_KitchenButton = New System.Windows.Forms.Button()
        Me.WindowsSpecRoom_LivingRoomButton = New System.Windows.Forms.Button()
        Me.SubMenu1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SubMenu1
        '
        Me.SubMenu1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SubMenu1.Controls.Add(Me.WindowsSpecRoom_BedroomButton)
        Me.SubMenu1.Controls.Add(Me.WindowsSpecRoom_KitchenButton)
        Me.SubMenu1.Controls.Add(Me.WindowsSpecRoom_LivingRoomButton)
        Me.SubMenu1.Location = New System.Drawing.Point(0, 10)
        Me.SubMenu1.Name = "SubMenu1"
        Me.SubMenu1.Size = New System.Drawing.Size(440, 420)
        Me.SubMenu1.TabIndex = 4
        '
        'WindowsSpecRoom_BedroomButton
        '
        Me.WindowsSpecRoom_BedroomButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WindowsSpecRoom_BedroomButton.Location = New System.Drawing.Point(67, 283)
        Me.WindowsSpecRoom_BedroomButton.Name = "WindowsSpecRoom_BedroomButton"
        Me.WindowsSpecRoom_BedroomButton.Size = New System.Drawing.Size(303, 115)
        Me.WindowsSpecRoom_BedroomButton.TabIndex = 5
        Me.WindowsSpecRoom_BedroomButton.Text = "Bedroom"
        Me.WindowsSpecRoom_BedroomButton.UseVisualStyleBackColor = True
        '
        'WindowsSpecRoom_KitchenButton
        '
        Me.WindowsSpecRoom_KitchenButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WindowsSpecRoom_KitchenButton.Location = New System.Drawing.Point(67, 151)
        Me.WindowsSpecRoom_KitchenButton.Name = "WindowsSpecRoom_KitchenButton"
        Me.WindowsSpecRoom_KitchenButton.Size = New System.Drawing.Size(303, 115)
        Me.WindowsSpecRoom_KitchenButton.TabIndex = 4
        Me.WindowsSpecRoom_KitchenButton.Text = "Kitchen"
        Me.WindowsSpecRoom_KitchenButton.UseVisualStyleBackColor = True
        '
        'WindowsSpecRoom_LivingRoomButton
        '
        Me.WindowsSpecRoom_LivingRoomButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WindowsSpecRoom_LivingRoomButton.Location = New System.Drawing.Point(67, 19)
        Me.WindowsSpecRoom_LivingRoomButton.Name = "WindowsSpecRoom_LivingRoomButton"
        Me.WindowsSpecRoom_LivingRoomButton.Size = New System.Drawing.Size(303, 115)
        Me.WindowsSpecRoom_LivingRoomButton.TabIndex = 3
        Me.WindowsSpecRoom_LivingRoomButton.Text = "Living Room"
        Me.WindowsSpecRoom_LivingRoomButton.UseVisualStyleBackColor = True
        '
        'WindowsSpecificRoomScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SubMenu1)
        Me.Name = "WindowsSpecificRoomScreen"
        Me.Size = New System.Drawing.Size(440, 440)
        Me.SubMenu1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SubMenu1 As Scanning.SubMenu
    Friend WithEvents WindowsSpecRoom_BedroomButton As System.Windows.Forms.Button
    Friend WithEvents WindowsSpecRoom_KitchenButton As System.Windows.Forms.Button
    Friend WithEvents WindowsSpecRoom_LivingRoomButton As System.Windows.Forms.Button

End Class
