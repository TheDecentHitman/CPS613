<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class phonecall1
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
        Me.HangUpButton = New System.Windows.Forms.Button()
        Me.TypeVoiceMessageButton = New System.Windows.Forms.Button()
        Me.StandardVoiceMessagetton = New System.Windows.Forms.Button()
        Me.CallerPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.CallerPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HangUpButton
        '
        Me.HangUpButton.Location = New System.Drawing.Point(288, 234)
        Me.HangUpButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.HangUpButton.Name = "HangUpButton"
        Me.HangUpButton.Size = New System.Drawing.Size(112, 83)
        Me.HangUpButton.TabIndex = 5
        Me.HangUpButton.Text = "Hang Up"
        Me.HangUpButton.UseVisualStyleBackColor = True
        '
        'TypeVoiceMessageButton
        '
        Me.TypeVoiceMessageButton.Enabled = False
        Me.TypeVoiceMessageButton.Location = New System.Drawing.Point(166, 234)
        Me.TypeVoiceMessageButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TypeVoiceMessageButton.Name = "TypeVoiceMessageButton"
        Me.TypeVoiceMessageButton.Size = New System.Drawing.Size(112, 83)
        Me.TypeVoiceMessageButton.TabIndex = 4
        Me.TypeVoiceMessageButton.Text = "Type Voice Message"
        Me.TypeVoiceMessageButton.UseVisualStyleBackColor = True
        '
        'StandardVoiceMessagetton
        '
        Me.StandardVoiceMessagetton.Location = New System.Drawing.Point(44, 234)
        Me.StandardVoiceMessagetton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.StandardVoiceMessagetton.Name = "StandardVoiceMessagetton"
        Me.StandardVoiceMessagetton.Size = New System.Drawing.Size(112, 83)
        Me.StandardVoiceMessagetton.TabIndex = 3
        Me.StandardVoiceMessagetton.Text = "Standard Voice Message"
        Me.StandardVoiceMessagetton.UseVisualStyleBackColor = True
        '
        'CallerPictureBox
        '
        Me.CallerPictureBox.Location = New System.Drawing.Point(144, 70)
        Me.CallerPictureBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CallerPictureBox.Name = "CallerPictureBox"
        Me.CallerPictureBox.Size = New System.Drawing.Size(150, 154)
        Me.CallerPictureBox.TabStop = False
        '
        'phonecall1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.HangUpButton)
        Me.Controls.Add(Me.TypeVoiceMessageButton)
        Me.Controls.Add(Me.StandardVoiceMessagetton)
        Me.Controls.Add(Me.CallerPictureBox)
        Me.Name = "phonecall1"
        Me.Size = New System.Drawing.Size(440, 440)
        CType(Me.CallerPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HangUpButton As Button
    Friend WithEvents TypeVoiceMessageButton As Button
    Friend WithEvents StandardVoiceMessagetton As Button
    Friend WithEvents CallerPictureBox As PictureBox
End Class
