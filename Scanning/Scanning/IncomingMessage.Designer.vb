<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IncomingMessage
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
        Me.MessageFromLabel = New System.Windows.Forms.Label()
        Me.MessageSenderLabel = New System.Windows.Forms.Label()
        Me.MessageContentLabel = New System.Windows.Forms.Label()
        Me.MessageRespondButton = New System.Windows.Forms.Button()
        Me.MessageIgnoreButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MessageFromLabel
        '
        Me.MessageFromLabel.AutoSize = True
        Me.MessageFromLabel.Location = New System.Drawing.Point(13, 13)
        Me.MessageFromLabel.Name = "MessageFromLabel"
        Me.MessageFromLabel.Size = New System.Drawing.Size(79, 13)
        Me.MessageFromLabel.TabIndex = 0
        Me.MessageFromLabel.Text = "Message From:"
        '
        'MessageSenderLabel
        '
        Me.MessageSenderLabel.AutoSize = True
        Me.MessageSenderLabel.Location = New System.Drawing.Point(98, 13)
        Me.MessageSenderLabel.Name = "MessageSenderLabel"
        Me.MessageSenderLabel.Size = New System.Drawing.Size(59, 13)
        Me.MessageSenderLabel.TabIndex = 1
        Me.MessageSenderLabel.Text = "John Smith"
        '
        'MessageContentLabel
        '
        Me.MessageContentLabel.AutoSize = True
        Me.MessageContentLabel.Location = New System.Drawing.Point(13, 38)
        Me.MessageContentLabel.Name = "MessageContentLabel"
        Me.MessageContentLabel.Size = New System.Drawing.Size(83, 13)
        Me.MessageContentLabel.TabIndex = 2
        Me.MessageContentLabel.Text = "Hey, what's up?"
        '
        'MessageRespondButton
        '
        Me.MessageRespondButton.Location = New System.Drawing.Point(63, 173)
        Me.MessageRespondButton.Name = "MessageRespondButton"
        Me.MessageRespondButton.Size = New System.Drawing.Size(75, 23)
        Me.MessageRespondButton.TabIndex = 3
        Me.MessageRespondButton.Text = "Respond"
        Me.MessageRespondButton.UseVisualStyleBackColor = True
        '
        'MessageIgnoreButton
        '
        Me.MessageIgnoreButton.Location = New System.Drawing.Point(250, 173)
        Me.MessageIgnoreButton.Name = "MessageIgnoreButton"
        Me.MessageIgnoreButton.Size = New System.Drawing.Size(75, 23)
        Me.MessageIgnoreButton.TabIndex = 4
        Me.MessageIgnoreButton.Text = "Ignore"
        Me.MessageIgnoreButton.UseVisualStyleBackColor = True
        '
        'IncomingMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 220)
        Me.Controls.Add(Me.MessageIgnoreButton)
        Me.Controls.Add(Me.MessageRespondButton)
        Me.Controls.Add(Me.MessageContentLabel)
        Me.Controls.Add(Me.MessageSenderLabel)
        Me.Controls.Add(Me.MessageFromLabel)
        Me.Name = "IncomingMessage"
        Me.Text = "Message from"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MessageFromLabel As System.Windows.Forms.Label
    Friend WithEvents MessageSenderLabel As System.Windows.Forms.Label
    Friend WithEvents MessageContentLabel As System.Windows.Forms.Label
    Friend WithEvents MessageRespondButton As System.Windows.Forms.Button
    Friend WithEvents MessageIgnoreButton As System.Windows.Forms.Button
End Class
