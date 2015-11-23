<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EntertainmentScreen
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
        Me.MusicButton = New System.Windows.Forms.Button()
        Me.AudioButton = New System.Windows.Forms.Button()
        Me.MovieButton = New System.Windows.Forms.Button()
        Me.TVButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MusicButton
        '
        Me.MusicButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MusicButton.Location = New System.Drawing.Point(0, 0)
        Me.MusicButton.Name = "MusicButton"
        Me.MusicButton.Size = New System.Drawing.Size(220, 220)
        Me.MusicButton.TabIndex = 3
        Me.MusicButton.Text = "Music"
        Me.MusicButton.UseVisualStyleBackColor = True
        '
        'AudioButton
        '
        Me.AudioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AudioButton.Location = New System.Drawing.Point(220, 0)
        Me.AudioButton.Name = "AudioButton"
        Me.AudioButton.Size = New System.Drawing.Size(220, 220)
        Me.AudioButton.TabIndex = 4
        Me.AudioButton.Text = "Audio"
        Me.AudioButton.UseVisualStyleBackColor = True
        '
        'MovieButton
        '
        Me.MovieButton.Enabled = False
        Me.MovieButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MovieButton.Location = New System.Drawing.Point(220, 220)
        Me.MovieButton.Name = "MovieButton"
        Me.MovieButton.Size = New System.Drawing.Size(220, 220)
        Me.MovieButton.TabIndex = 6
        Me.MovieButton.Text = "Movie"
        Me.MovieButton.UseVisualStyleBackColor = True
        '
        'TVButton
        '
        Me.TVButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TVButton.Location = New System.Drawing.Point(0, 220)
        Me.TVButton.Name = "TVButton"
        Me.TVButton.Size = New System.Drawing.Size(220, 220)
        Me.TVButton.TabIndex = 5
        Me.TVButton.Text = "TV"
        Me.TVButton.UseVisualStyleBackColor = True
        '
        'EntertainmentScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MusicButton)
        Me.Controls.Add(Me.AudioButton)
        Me.Controls.Add(Me.MovieButton)
        Me.Controls.Add(Me.TVButton)
        Me.Name = "EntertainmentScreen"
        Me.Size = New System.Drawing.Size(440, 440)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MusicButton As System.Windows.Forms.Button
    Friend WithEvents AudioButton As System.Windows.Forms.Button
    Friend WithEvents MovieButton As System.Windows.Forms.Button
    Friend WithEvents TVButton As System.Windows.Forms.Button

End Class
