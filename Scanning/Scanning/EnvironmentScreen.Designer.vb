<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnvironmentScreen
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
        Me.LightsButton = New System.Windows.Forms.Button()
        Me.WindowsandBlindsButton = New System.Windows.Forms.Button()
        Me.TemperatureFansButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LightsButton
        '
        Me.LightsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LightsButton.Location = New System.Drawing.Point(41, 287)
        Me.LightsButton.Name = "LightsButton"
        Me.LightsButton.Size = New System.Drawing.Size(358, 118)
        Me.LightsButton.TabIndex = 5
        Me.LightsButton.Text = "Lights"
        Me.LightsButton.UseVisualStyleBackColor = True
        '
        'WindowsandBlindsButton
        '
        Me.WindowsandBlindsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WindowsandBlindsButton.Location = New System.Drawing.Point(41, 161)
        Me.WindowsandBlindsButton.Name = "WindowsandBlindsButton"
        Me.WindowsandBlindsButton.Size = New System.Drawing.Size(358, 118)
        Me.WindowsandBlindsButton.TabIndex = 4
        Me.WindowsandBlindsButton.Text = "Windows and Blinds"
        Me.WindowsandBlindsButton.UseVisualStyleBackColor = True
        '
        'TemperatureFansButton
        '
        Me.TemperatureFansButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TemperatureFansButton.Location = New System.Drawing.Point(41, 35)
        Me.TemperatureFansButton.Name = "TemperatureFansButton"
        Me.TemperatureFansButton.Size = New System.Drawing.Size(358, 118)
        Me.TemperatureFansButton.TabIndex = 3
        Me.TemperatureFansButton.Text = "Temperature and Fans"
        Me.TemperatureFansButton.UseVisualStyleBackColor = True
        '
        'EnvironmentScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LightsButton)
        Me.Controls.Add(Me.WindowsandBlindsButton)
        Me.Controls.Add(Me.TemperatureFansButton)
        Me.Name = "EnvironmentScreen"
        Me.Size = New System.Drawing.Size(440, 440)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LightsButton As System.Windows.Forms.Button
    Friend WithEvents WindowsandBlindsButton As System.Windows.Forms.Button
    Friend WithEvents TemperatureFansButton As System.Windows.Forms.Button

End Class
