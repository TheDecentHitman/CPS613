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
        Me.ElevatorButton = New System.Windows.Forms.Button()
        Me.DoorsButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ElevatorButton
        '
        Me.ElevatorButton.Location = New System.Drawing.Point(0, 220)
        Me.ElevatorButton.Name = "ElevatorButton"
        Me.ElevatorButton.Size = New System.Drawing.Size(440, 220)
        Me.ElevatorButton.TabIndex = 4
        Me.ElevatorButton.Text = "Elevator"
        Me.ElevatorButton.UseVisualStyleBackColor = True
        '
        'DoorsButton
        '
        Me.DoorsButton.Location = New System.Drawing.Point(0, 0)
        Me.DoorsButton.Name = "DoorsButton"
        Me.DoorsButton.Size = New System.Drawing.Size(440, 220)
        Me.DoorsButton.TabIndex = 3
        Me.DoorsButton.Text = "Doors"
        Me.DoorsButton.UseVisualStyleBackColor = True
        '
        'NavigationScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ElevatorButton)
        Me.Controls.Add(Me.DoorsButton)
        Me.Name = "NavigationScreen"
        Me.Size = New System.Drawing.Size(440, 440)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ElevatorButton As System.Windows.Forms.Button
    Friend WithEvents DoorsButton As System.Windows.Forms.Button

End Class
