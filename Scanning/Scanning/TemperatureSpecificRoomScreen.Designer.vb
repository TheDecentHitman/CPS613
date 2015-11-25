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
        Me.TempSpecRoom_BedroomButton = New System.Windows.Forms.Button()
        Me.TempSpecRoom_KitchenButton = New System.Windows.Forms.Button()
        Me.TempSpecRoom_LivingRoomButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TempSpecRoom_BedroomButton
        '
        Me.TempSpecRoom_BedroomButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TempSpecRoom_BedroomButton.Location = New System.Drawing.Point(104, 454)
        Me.TempSpecRoom_BedroomButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TempSpecRoom_BedroomButton.Name = "TempSpecRoom_BedroomButton"
        Me.TempSpecRoom_BedroomButton.Size = New System.Drawing.Size(454, 177)
        Me.TempSpecRoom_BedroomButton.TabIndex = 5
        Me.TempSpecRoom_BedroomButton.Text = "Bedroom"
        Me.TempSpecRoom_BedroomButton.UseVisualStyleBackColor = True
        '
        'TempSpecRoom_KitchenButton
        '
        Me.TempSpecRoom_KitchenButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TempSpecRoom_KitchenButton.Location = New System.Drawing.Point(104, 251)
        Me.TempSpecRoom_KitchenButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TempSpecRoom_KitchenButton.Name = "TempSpecRoom_KitchenButton"
        Me.TempSpecRoom_KitchenButton.Size = New System.Drawing.Size(454, 177)
        Me.TempSpecRoom_KitchenButton.TabIndex = 4
        Me.TempSpecRoom_KitchenButton.Text = "Kitchen"
        Me.TempSpecRoom_KitchenButton.UseVisualStyleBackColor = True
        '
        'TempSpecRoom_LivingRoomButton
        '
        Me.TempSpecRoom_LivingRoomButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TempSpecRoom_LivingRoomButton.Location = New System.Drawing.Point(104, 48)
        Me.TempSpecRoom_LivingRoomButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TempSpecRoom_LivingRoomButton.Name = "TempSpecRoom_LivingRoomButton"
        Me.TempSpecRoom_LivingRoomButton.Size = New System.Drawing.Size(454, 177)
        Me.TempSpecRoom_LivingRoomButton.TabIndex = 3
        Me.TempSpecRoom_LivingRoomButton.Text = "Living Room"
        Me.TempSpecRoom_LivingRoomButton.UseVisualStyleBackColor = True
        '
        'TemperatureSpecificRoomScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TempSpecRoom_BedroomButton)
        Me.Controls.Add(Me.TempSpecRoom_KitchenButton)
        Me.Controls.Add(Me.TempSpecRoom_LivingRoomButton)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "TemperatureSpecificRoomScreen"
        Me.Size = New System.Drawing.Size(660, 677)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TempSpecRoom_BedroomButton As System.Windows.Forms.Button
    Friend WithEvents TempSpecRoom_KitchenButton As System.Windows.Forms.Button
    Friend WithEvents TempSpecRoom_LivingRoomButton As System.Windows.Forms.Button

End Class
