<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IncomingPhoneCall
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
        Me.CallerNameLabel = New System.Windows.Forms.Label()
        Me.AcceptButton = New System.Windows.Forms.Button()
        Me.DeclineButton = New System.Windows.Forms.Button()
        Me.CallFromLabel = New System.Windows.Forms.Label()
        Me.CallerPictureBox = New System.Windows.Forms.PictureBox()
        Me.DeclineAndMessageButton = New System.Windows.Forms.Button()
        CType(Me.CallerPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CallerNameLabel
        '
        Me.CallerNameLabel.AutoSize = True
        Me.CallerNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CallerNameLabel.Location = New System.Drawing.Point(234, 13)
        Me.CallerNameLabel.Name = "CallerNameLabel"
        Me.CallerNameLabel.Size = New System.Drawing.Size(89, 20)
        Me.CallerNameLabel.TabIndex = 1
        Me.CallerNameLabel.Text = "John Smith"
        '
        'AcceptButton
        '
        Me.AcceptButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AcceptButton.Location = New System.Drawing.Point(146, 37)
        Me.AcceptButton.Name = "AcceptButton"
        Me.AcceptButton.Size = New System.Drawing.Size(70, 54)
        Me.AcceptButton.TabIndex = 0
        Me.AcceptButton.Text = "Accept"
        Me.AcceptButton.UseVisualStyleBackColor = True
        '
        'DeclineButton
        '
        Me.DeclineButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DeclineButton.Location = New System.Drawing.Point(222, 37)
        Me.DeclineButton.Name = "DeclineButton"
        Me.DeclineButton.Size = New System.Drawing.Size(70, 54)
        Me.DeclineButton.TabIndex = 2
        Me.DeclineButton.Text = "Decline"
        Me.DeclineButton.UseVisualStyleBackColor = True
        '
        'CallFromLabel
        '
        Me.CallFromLabel.AutoSize = True
        Me.CallFromLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CallFromLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CallFromLabel.Location = New System.Drawing.Point(142, 9)
        Me.CallFromLabel.Name = "CallFromLabel"
        Me.CallFromLabel.Size = New System.Drawing.Size(96, 24)
        Me.CallFromLabel.TabIndex = 5
        Me.CallFromLabel.Text = "Call From:"
        '
        'CallerPictureBox
        '
        Me.CallerPictureBox.Location = New System.Drawing.Point(12, 9)
        Me.CallerPictureBox.Name = "CallerPictureBox"
        Me.CallerPictureBox.Size = New System.Drawing.Size(100, 90)
        Me.CallerPictureBox.TabIndex = 0
        Me.CallerPictureBox.TabStop = False
        '
        'DeclineAndMessageButton
        '
        Me.DeclineAndMessageButton.Location = New System.Drawing.Point(298, 37)
        Me.DeclineAndMessageButton.Name = "DeclineAndMessageButton"
        Me.DeclineAndMessageButton.Size = New System.Drawing.Size(70, 54)
        Me.DeclineAndMessageButton.TabIndex = 6
        Me.DeclineAndMessageButton.Text = "Decline and Message"
        Me.DeclineAndMessageButton.UseVisualStyleBackColor = True
        '
        'IncomingPhoneCall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 103)
        Me.Controls.Add(Me.DeclineAndMessageButton)
        Me.Controls.Add(Me.DeclineButton)
        Me.Controls.Add(Me.CallFromLabel)
        Me.Controls.Add(Me.AcceptButton)
        Me.Controls.Add(Me.CallerNameLabel)
        Me.Controls.Add(Me.CallerPictureBox)
        Me.Name = "IncomingPhoneCall"
        Me.Text = "Phone call from"
        CType(Me.CallerPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CallerPictureBox As PictureBox
    Friend WithEvents CallerNameLabel As Label
    Friend WithEvents AcceptButton As Button
    Friend WithEvents DeclineButton As Button
    Friend WithEvents CallFromLabel As Label
    Friend WithEvents DeclineAndMessageButton As System.Windows.Forms.Button
End Class
