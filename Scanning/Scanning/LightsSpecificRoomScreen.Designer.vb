﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LightsSpecificRoomScreen
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
        Me.LightsSpecRoom_BedroomButton = New System.Windows.Forms.Button()
        Me.LightsSpecRoom_KitchenButton = New System.Windows.Forms.Button()
        Me.LightsSpecRoom_LivingRoomButton = New System.Windows.Forms.Button()
        Me.SubMenu1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SubMenu1
        '
        Me.SubMenu1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SubMenu1.Controls.Add(Me.LightsSpecRoom_BedroomButton)
        Me.SubMenu1.Controls.Add(Me.LightsSpecRoom_KitchenButton)
        Me.SubMenu1.Controls.Add(Me.LightsSpecRoom_LivingRoomButton)
        Me.SubMenu1.Location = New System.Drawing.Point(0, 10)
        Me.SubMenu1.Name = "SubMenu1"
        Me.SubMenu1.Size = New System.Drawing.Size(440, 420)
        Me.SubMenu1.TabIndex = 3
        '
        'LightsSpecRoom_BedroomButton
        '
        Me.LightsSpecRoom_BedroomButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LightsSpecRoom_BedroomButton.Location = New System.Drawing.Point(67, 283)
        Me.LightsSpecRoom_BedroomButton.Name = "LightsSpecRoom_BedroomButton"
        Me.LightsSpecRoom_BedroomButton.Size = New System.Drawing.Size(303, 115)
        Me.LightsSpecRoom_BedroomButton.TabIndex = 5
        Me.LightsSpecRoom_BedroomButton.Text = "Bedroom"
        Me.LightsSpecRoom_BedroomButton.UseVisualStyleBackColor = True
        '
        'LightsSpecRoom_KitchenButton
        '
        Me.LightsSpecRoom_KitchenButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LightsSpecRoom_KitchenButton.Location = New System.Drawing.Point(67, 151)
        Me.LightsSpecRoom_KitchenButton.Name = "LightsSpecRoom_KitchenButton"
        Me.LightsSpecRoom_KitchenButton.Size = New System.Drawing.Size(303, 115)
        Me.LightsSpecRoom_KitchenButton.TabIndex = 4
        Me.LightsSpecRoom_KitchenButton.Text = "Kitchen"
        Me.LightsSpecRoom_KitchenButton.UseVisualStyleBackColor = True
        '
        'LightsSpecRoom_LivingRoomButton
        '
        Me.LightsSpecRoom_LivingRoomButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LightsSpecRoom_LivingRoomButton.Location = New System.Drawing.Point(67, 19)
        Me.LightsSpecRoom_LivingRoomButton.Name = "LightsSpecRoom_LivingRoomButton"
        Me.LightsSpecRoom_LivingRoomButton.Size = New System.Drawing.Size(303, 115)
        Me.LightsSpecRoom_LivingRoomButton.TabIndex = 3
        Me.LightsSpecRoom_LivingRoomButton.Text = "Living Room"
        Me.LightsSpecRoom_LivingRoomButton.UseVisualStyleBackColor = True
        '
        'LightsSpecificRoomScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SubMenu1)
        Me.Name = "LightsSpecificRoomScreen"
        Me.Size = New System.Drawing.Size(440, 440)
        Me.SubMenu1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SubMenu1 As Scanning.SubMenu
    Friend WithEvents LightsSpecRoom_BedroomButton As System.Windows.Forms.Button
    Friend WithEvents LightsSpecRoom_KitchenButton As System.Windows.Forms.Button
    Friend WithEvents LightsSpecRoom_LivingRoomButton As System.Windows.Forms.Button

End Class
