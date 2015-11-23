<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PhoneCall
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.CallerPictureBox = New System.Windows.Forms.PictureBox()
        Me.StandardVoiceMessagetton = New System.Windows.Forms.Button()
        Me.TypeVoiceMessageButton = New System.Windows.Forms.Button()
        Me.HangUpButton = New System.Windows.Forms.Button()
        CType(Me.CallerPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CallerPictureBox
        '
        Me.CallerPictureBox.Location = New System.Drawing.Point(15, 15)
        Me.CallerPictureBox.Name = "CallerPictureBox"
        Me.CallerPictureBox.Size = New System.Drawing.Size(100, 100)
        Me.CallerPictureBox.TabIndex = 0
        Me.CallerPictureBox.TabStop = False
        '
        'StandardVoiceMessagetton
        '
        Me.StandardVoiceMessagetton.Location = New System.Drawing.Point(132, 38)
        Me.StandardVoiceMessagetton.Name = "StandardVoiceMessagetton"
        Me.StandardVoiceMessagetton.Size = New System.Drawing.Size(75, 54)
        Me.StandardVoiceMessagetton.TabIndex = 0
        Me.StandardVoiceMessagetton.Text = "Standard Voice Message"
        Me.StandardVoiceMessagetton.UseVisualStyleBackColor = True
        '
        'TypeVoiceMessageButton
        '
        Me.TypeVoiceMessageButton.Enabled = False
        Me.TypeVoiceMessageButton.Location = New System.Drawing.Point(213, 38)
        Me.TypeVoiceMessageButton.Name = "TypeVoiceMessageButton"
        Me.TypeVoiceMessageButton.Size = New System.Drawing.Size(75, 54)
        Me.TypeVoiceMessageButton.TabIndex = 1
        Me.TypeVoiceMessageButton.Text = "Type Voice Message"
        Me.TypeVoiceMessageButton.UseVisualStyleBackColor = True
        '
        'HangUpButton
        '
        Me.HangUpButton.Location = New System.Drawing.Point(295, 38)
        Me.HangUpButton.Name = "HangUpButton"
        Me.HangUpButton.Size = New System.Drawing.Size(75, 54)
        Me.HangUpButton.TabIndex = 2
        Me.HangUpButton.Text = "Hang Up"
        Me.HangUpButton.UseVisualStyleBackColor = True
        '
        'PhoneCall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 130)
        Me.Controls.Add(Me.HangUpButton)
        Me.Controls.Add(Me.TypeVoiceMessageButton)
        Me.Controls.Add(Me.StandardVoiceMessagetton)
        Me.Controls.Add(Me.CallerPictureBox)
        Me.Name = "PhoneCall"
        Me.Text = "Call with"
        CType(Me.CallerPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CallerPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents StandardVoiceMessagetton As System.Windows.Forms.Button
    Friend WithEvents TypeVoiceMessageButton As System.Windows.Forms.Button
    Friend WithEvents HangUpButton As System.Windows.Forms.Button
End Class
