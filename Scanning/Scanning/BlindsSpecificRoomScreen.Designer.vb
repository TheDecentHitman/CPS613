﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BlindsSpecificRoomScreen
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
        Me.BlindsSpecRoom_BedroomButton = New System.Windows.Forms.Button()
        Me.BlindsSpecRoom_KitchenButton = New System.Windows.Forms.Button()
        Me.BlindsSpecRoom_LivingRoomButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BlindsSpecRoom_BedroomButton
        '
        Me.BlindsSpecRoom_BedroomButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BlindsSpecRoom_BedroomButton.Location = New System.Drawing.Point(69, 295)
        Me.BlindsSpecRoom_BedroomButton.Name = "BlindsSpecRoom_BedroomButton"
        Me.BlindsSpecRoom_BedroomButton.Size = New System.Drawing.Size(303, 115)
        Me.BlindsSpecRoom_BedroomButton.TabIndex = 5
        Me.BlindsSpecRoom_BedroomButton.Text = "Bedroom"
        Me.BlindsSpecRoom_BedroomButton.UseVisualStyleBackColor = True
        '
        'BlindsSpecRoom_KitchenButton
        '
        Me.BlindsSpecRoom_KitchenButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BlindsSpecRoom_KitchenButton.Location = New System.Drawing.Point(69, 163)
        Me.BlindsSpecRoom_KitchenButton.Name = "BlindsSpecRoom_KitchenButton"
        Me.BlindsSpecRoom_KitchenButton.Size = New System.Drawing.Size(303, 115)
        Me.BlindsSpecRoom_KitchenButton.TabIndex = 4
        Me.BlindsSpecRoom_KitchenButton.Text = "Kitchen"
        Me.BlindsSpecRoom_KitchenButton.UseVisualStyleBackColor = True
        '
        'BlindsSpecRoom_LivingRoomButton
        '
        Me.BlindsSpecRoom_LivingRoomButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BlindsSpecRoom_LivingRoomButton.Location = New System.Drawing.Point(69, 31)
        Me.BlindsSpecRoom_LivingRoomButton.Name = "BlindsSpecRoom_LivingRoomButton"
        Me.BlindsSpecRoom_LivingRoomButton.Size = New System.Drawing.Size(303, 115)
        Me.BlindsSpecRoom_LivingRoomButton.TabIndex = 3
        Me.BlindsSpecRoom_LivingRoomButton.Text = "Living Room"
        Me.BlindsSpecRoom_LivingRoomButton.UseVisualStyleBackColor = True
        '
        'BlindsSpecificRoomScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BlindsSpecRoom_BedroomButton)
        Me.Controls.Add(Me.BlindsSpecRoom_KitchenButton)
        Me.Controls.Add(Me.BlindsSpecRoom_LivingRoomButton)
        Me.Name = "BlindsSpecificRoomScreen"
        Me.Size = New System.Drawing.Size(440, 440)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BlindsSpecRoom_BedroomButton As System.Windows.Forms.Button
    Friend WithEvents BlindsSpecRoom_KitchenButton As System.Windows.Forms.Button
    Friend WithEvents BlindsSpecRoom_LivingRoomButton As System.Windows.Forms.Button

End Class
