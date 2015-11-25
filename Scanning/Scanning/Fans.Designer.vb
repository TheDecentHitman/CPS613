<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fans
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
        Me.OnB = New System.Windows.Forms.Button()
        Me.off = New System.Windows.Forms.Button()
        Me.Fan = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'OnB
        '
        Me.OnB.Location = New System.Drawing.Point(372, 314)
        Me.OnB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OnB.Name = "OnB"
        Me.OnB.Size = New System.Drawing.Size(148, 131)
        Me.OnB.TabIndex = 4
        Me.OnB.Text = "On"
        Me.OnB.UseVisualStyleBackColor = True
        '
        'off
        '
        Me.off.Enabled = False
        Me.off.Location = New System.Drawing.Point(140, 314)
        Me.off.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.off.Name = "off"
        Me.off.Size = New System.Drawing.Size(148, 131)
        Me.off.TabIndex = 3
        Me.off.Text = "Off"
        Me.off.UseVisualStyleBackColor = True
        '
        'Fan
        '
        Me.Fan.AutoSize = True
        Me.Fan.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fan.Location = New System.Drawing.Point(272, 231)
        Me.Fan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Fan.Name = "Fan"
        Me.Fan.Size = New System.Drawing.Size(124, 64)
        Me.Fan.Text = "Fan"
        '
        'Fans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.OnB)
        Me.Controls.Add(Me.off)
        Me.Controls.Add(Me.Fan)
        Me.Name = "Fans"
        Me.Size = New System.Drawing.Size(660, 677)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OnB As Button
    Friend WithEvents off As Button
    Friend WithEvents Fan As Label
End Class
