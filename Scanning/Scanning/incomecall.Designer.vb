<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class incomecall
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
        Me.DeclineAndMessageButton = New System.Windows.Forms.Button()
        Me.DeclineButton = New System.Windows.Forms.Button()
        Me.CallFromLabel = New System.Windows.Forms.Label()
        Me.AcceptButton = New System.Windows.Forms.Button()
        Me.CallerNameLabel = New System.Windows.Forms.Label()
        Me.CallerPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.CallerPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DeclineAndMessageButton
        '
        Me.DeclineAndMessageButton.Location = New System.Drawing.Point(375, 360)
        Me.DeclineAndMessageButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DeclineAndMessageButton.Name = "DeclineAndMessageButton"
        Me.DeclineAndMessageButton.Size = New System.Drawing.Size(105, 83)
        Me.DeclineAndMessageButton.TabIndex = 5
        Me.DeclineAndMessageButton.Text = "Decline and Message"
        Me.DeclineAndMessageButton.UseVisualStyleBackColor = True
        '
        'DeclineButton
        '
        Me.DeclineButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DeclineButton.Location = New System.Drawing.Point(261, 360)
        Me.DeclineButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DeclineButton.Name = "DeclineButton"
        Me.DeclineButton.Size = New System.Drawing.Size(105, 83)
        Me.DeclineButton.TabIndex = 4
        Me.DeclineButton.Text = "Decline"
        Me.DeclineButton.UseVisualStyleBackColor = True
        '
        'CallFromLabel
        '
        Me.CallFromLabel.AutoSize = True
        Me.CallFromLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CallFromLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CallFromLabel.Location = New System.Drawing.Point(141, 317)
        Me.CallFromLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CallFromLabel.Name = "CallFromLabel"
        Me.CallFromLabel.Size = New System.Drawing.Size(151, 33)
        Me.CallFromLabel.TabIndex = 5
        Me.CallFromLabel.Text = "Call From:"
        '
        'AcceptButton
        '
        Me.AcceptButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AcceptButton.Location = New System.Drawing.Point(147, 360)
        Me.AcceptButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AcceptButton.Name = "AcceptButton"
        Me.AcceptButton.Size = New System.Drawing.Size(105, 83)
        Me.AcceptButton.TabIndex = 3
        Me.AcceptButton.Text = "Accept"
        Me.AcceptButton.UseVisualStyleBackColor = True
        '
        'CallerNameLabel
        '
        Me.CallerNameLabel.AutoSize = True
        Me.CallerNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CallerNameLabel.Location = New System.Drawing.Point(285, 321)
        Me.CallerNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CallerNameLabel.Name = "CallerNameLabel"
        Me.CallerNameLabel.Size = New System.Drawing.Size(132, 29)
        Me.CallerNameLabel.TabIndex = 6
        Me.CallerNameLabel.Text = "John Smith"
        '
        'CallerPictureBox
        '
        Me.CallerPictureBox.Location = New System.Drawing.Point(235, 174)
        Me.CallerPictureBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CallerPictureBox.Name = "CallerPictureBox"
        Me.CallerPictureBox.Size = New System.Drawing.Size(150, 138)
        Me.CallerPictureBox.TabIndex = 7
        Me.CallerPictureBox.TabStop = False
        '
        'incomecall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DeclineAndMessageButton)
        Me.Controls.Add(Me.DeclineButton)
        Me.Controls.Add(Me.CallFromLabel)
        Me.Controls.Add(Me.AcceptButton)
        Me.Controls.Add(Me.CallerNameLabel)
        Me.Controls.Add(Me.CallerPictureBox)
        Me.Name = "incomecall"
        Me.Size = New System.Drawing.Size(660, 677)
        CType(Me.CallerPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DeclineAndMessageButton As Button
    Friend WithEvents DeclineButton As Button
    Friend WithEvents CallFromLabel As Label
    Friend WithEvents AcceptButton As Button
    Friend WithEvents CallerNameLabel As Label
    Friend WithEvents CallerPictureBox As PictureBox
End Class
