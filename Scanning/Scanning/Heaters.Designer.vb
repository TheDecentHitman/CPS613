<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Heaters
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
        Me.Higher = New System.Windows.Forms.Button()
        Me.Lower = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Higher
        '
        Me.Higher.Location = New System.Drawing.Point(371, 343)
        Me.Higher.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Higher.Name = "Higher"
        Me.Higher.Size = New System.Drawing.Size(148, 131)
        Me.Higher.TabIndex = 4
        Me.Higher.Text = "Increase"
        Me.Higher.UseVisualStyleBackColor = True
        '
        'Lower
        '
        Me.Lower.Location = New System.Drawing.Point(141, 343)
        Me.Lower.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Lower.Name = "Lower"
        Me.Lower.Size = New System.Drawing.Size(148, 131)
        Me.Lower.TabIndex = 3
        Me.Lower.Text = "Decrease"
        Me.Lower.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(310, 286)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "0°C"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(235, 202)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 64)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Heater"
        '
        'Heaters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Higher)
        Me.Controls.Add(Me.Lower)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Heaters"
        Me.Size = New System.Drawing.Size(660, 677)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Higher As Button
    Friend WithEvents Lower As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
