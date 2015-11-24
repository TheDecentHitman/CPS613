<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WindowBlindOpenCloseScreen
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
        Me.WindowBlindOpenButton = New System.Windows.Forms.Button()
        Me.WindowBlindCloseButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'WindowBlindOpenButton
        '
        Me.WindowBlindOpenButton.Location = New System.Drawing.Point(53, 149)
        Me.WindowBlindOpenButton.Name = "WindowBlindOpenButton"
        Me.WindowBlindOpenButton.Size = New System.Drawing.Size(138, 128)
        Me.WindowBlindOpenButton.TabIndex = 3
        Me.WindowBlindOpenButton.Text = "Open"
        Me.WindowBlindOpenButton.UseVisualStyleBackColor = True
        '
        'WindowBlindCloseButton
        '
        Me.WindowBlindCloseButton.Location = New System.Drawing.Point(243, 149)
        Me.WindowBlindCloseButton.Name = "WindowBlindCloseButton"
        Me.WindowBlindCloseButton.Size = New System.Drawing.Size(138, 128)
        Me.WindowBlindCloseButton.TabIndex = 4
        Me.WindowBlindCloseButton.Text = "Close"
        Me.WindowBlindCloseButton.UseVisualStyleBackColor = True
        '
        'WindowBlindOpenCloseScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.WindowBlindCloseButton)
        Me.Controls.Add(Me.WindowBlindOpenButton)
        Me.Name = "WindowBlindOpenCloseScreen"
        Me.Size = New System.Drawing.Size(440, 440)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WindowBlindOpenButton As System.Windows.Forms.Button
    Friend WithEvents WindowBlindCloseButton As System.Windows.Forms.Button

End Class
