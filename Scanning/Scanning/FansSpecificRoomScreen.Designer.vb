<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FansSpecificRoomScreen
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
        Me.FansSpecRoom_BedroomButton = New System.Windows.Forms.Button()
        Me.FansSpecRoom_KitchenButton = New System.Windows.Forms.Button()
        Me.FansSpecRoom_LivingRoomButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'FansSpecRoom_BedroomButton
        '
        Me.FansSpecRoom_BedroomButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FansSpecRoom_BedroomButton.Location = New System.Drawing.Point(69, 295)
        Me.FansSpecRoom_BedroomButton.Name = "FansSpecRoom_BedroomButton"
        Me.FansSpecRoom_BedroomButton.Size = New System.Drawing.Size(303, 115)
        Me.FansSpecRoom_BedroomButton.TabIndex = 5
        Me.FansSpecRoom_BedroomButton.Text = "Bedroom"
        Me.FansSpecRoom_BedroomButton.UseVisualStyleBackColor = True
        '
        'FansSpecRoom_KitchenButton
        '
        Me.FansSpecRoom_KitchenButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FansSpecRoom_KitchenButton.Location = New System.Drawing.Point(69, 163)
        Me.FansSpecRoom_KitchenButton.Name = "FansSpecRoom_KitchenButton"
        Me.FansSpecRoom_KitchenButton.Size = New System.Drawing.Size(303, 115)
        Me.FansSpecRoom_KitchenButton.TabIndex = 4
        Me.FansSpecRoom_KitchenButton.Text = "Kitchen"
        Me.FansSpecRoom_KitchenButton.UseVisualStyleBackColor = True
        '
        'FansSpecRoom_LivingRoomButton
        '
        Me.FansSpecRoom_LivingRoomButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FansSpecRoom_LivingRoomButton.Location = New System.Drawing.Point(69, 31)
        Me.FansSpecRoom_LivingRoomButton.Name = "FansSpecRoom_LivingRoomButton"
        Me.FansSpecRoom_LivingRoomButton.Size = New System.Drawing.Size(303, 115)
        Me.FansSpecRoom_LivingRoomButton.TabIndex = 3
        Me.FansSpecRoom_LivingRoomButton.Text = "Living Room"
        Me.FansSpecRoom_LivingRoomButton.UseVisualStyleBackColor = True
        '
        'FansSpecificRoomScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.FansSpecRoom_BedroomButton)
        Me.Controls.Add(Me.FansSpecRoom_KitchenButton)
        Me.Controls.Add(Me.FansSpecRoom_LivingRoomButton)
        Me.Name = "FansSpecificRoomScreen"
        Me.Size = New System.Drawing.Size(440, 440)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FansSpecRoom_BedroomButton As System.Windows.Forms.Button
    Friend WithEvents FansSpecRoom_KitchenButton As System.Windows.Forms.Button
    Friend WithEvents FansSpecRoom_LivingRoomButton As System.Windows.Forms.Button

End Class
