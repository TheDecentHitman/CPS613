<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CommunicationScreen
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
        Me.PhoneButton = New System.Windows.Forms.Button()
        Me.MessageButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PhoneButton
        '
        Me.PhoneButton.Location = New System.Drawing.Point(0, 0)
        Me.PhoneButton.Name = "PhoneButton"
        Me.PhoneButton.Size = New System.Drawing.Size(440, 220)
        Me.PhoneButton.TabIndex = 0
        Me.PhoneButton.Text = "Phone"
        Me.PhoneButton.UseVisualStyleBackColor = True
        '
        'MessageButton
        '
        Me.MessageButton.Location = New System.Drawing.Point(0, 220)
        Me.MessageButton.Name = "MessageButton"
        Me.MessageButton.Size = New System.Drawing.Size(440, 220)
        Me.MessageButton.TabIndex = 1
        Me.MessageButton.Text = "Message"
        Me.MessageButton.UseVisualStyleBackColor = True
        '
        'CommunicationScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MessageButton)
        Me.Controls.Add(Me.PhoneButton)
        Me.Name = "CommunicationScreen"
        Me.Size = New System.Drawing.Size(440, 440)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PhoneButton As System.Windows.Forms.Button
    Friend WithEvents MessageButton As System.Windows.Forms.Button

End Class
