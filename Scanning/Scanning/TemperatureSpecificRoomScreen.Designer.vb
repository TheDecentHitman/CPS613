<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TemperatureSpecificRoomScreen
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
        Me.TempSpecRoom_BedroomButton = New System.Windows.Forms.Button()
        Me.TempSpecRoom_KitchenButton = New System.Windows.Forms.Button()
        Me.TempSpecRoom_LivingRoomButton = New System.Windows.Forms.Button()
        Me.SubMenu1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SubMenu1
        '
        Me.SubMenu1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SubMenu1.Controls.Add(Me.TempSpecRoom_BedroomButton)
        Me.SubMenu1.Controls.Add(Me.TempSpecRoom_KitchenButton)
        Me.SubMenu1.Controls.Add(Me.TempSpecRoom_LivingRoomButton)
        Me.SubMenu1.Location = New System.Drawing.Point(0, 10)
        Me.SubMenu1.Name = "SubMenu1"
        Me.SubMenu1.Size = New System.Drawing.Size(440, 420)
        Me.SubMenu1.TabIndex = 3
        '
        'TempSpecRoom_BedroomButton
        '
        Me.TempSpecRoom_BedroomButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TempSpecRoom_BedroomButton.Location = New System.Drawing.Point(67, 283)
        Me.TempSpecRoom_BedroomButton.Name = "TempSpecRoom_BedroomButton"
        Me.TempSpecRoom_BedroomButton.Size = New System.Drawing.Size(303, 115)
        Me.TempSpecRoom_BedroomButton.TabIndex = 5
        Me.TempSpecRoom_BedroomButton.Text = "Bedroom"
        Me.TempSpecRoom_BedroomButton.UseVisualStyleBackColor = True
        '
        'TempSpecRoom_KitchenButton
        '
        Me.TempSpecRoom_KitchenButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TempSpecRoom_KitchenButton.Location = New System.Drawing.Point(67, 151)
        Me.TempSpecRoom_KitchenButton.Name = "TempSpecRoom_KitchenButton"
        Me.TempSpecRoom_KitchenButton.Size = New System.Drawing.Size(303, 115)
        Me.TempSpecRoom_KitchenButton.TabIndex = 4
        Me.TempSpecRoom_KitchenButton.Text = "Kitchen"
        Me.TempSpecRoom_KitchenButton.UseVisualStyleBackColor = True
        '
        'TempSpecRoom_LivingRoomButton
        '
        Me.TempSpecRoom_LivingRoomButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TempSpecRoom_LivingRoomButton.Location = New System.Drawing.Point(67, 19)
        Me.TempSpecRoom_LivingRoomButton.Name = "TempSpecRoom_LivingRoomButton"
        Me.TempSpecRoom_LivingRoomButton.Size = New System.Drawing.Size(303, 115)
        Me.TempSpecRoom_LivingRoomButton.TabIndex = 3
        Me.TempSpecRoom_LivingRoomButton.Text = "Living Room"
        Me.TempSpecRoom_LivingRoomButton.UseVisualStyleBackColor = True
        '
        'TemperatureSpecificRoomScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SubMenu1)
        Me.Name = "TemperatureSpecificRoomScreen"
        Me.Size = New System.Drawing.Size(440, 440)
        Me.SubMenu1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SubMenu1 As Scanning.SubMenu
    Friend WithEvents TempSpecRoom_BedroomButton As System.Windows.Forms.Button
    Friend WithEvents TempSpecRoom_KitchenButton As System.Windows.Forms.Button
    Friend WithEvents TempSpecRoom_LivingRoomButton As System.Windows.Forms.Button

End Class
