<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeScreen
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
        Me.NavigationButton = New System.Windows.Forms.Button()
        Me.EnvironmentButton = New System.Windows.Forms.Button()
        Me.CommunicationsButton = New System.Windows.Forms.Button()
        Me.EntertainmentButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NavigationButton
        '
        Me.NavigationButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavigationButton.Location = New System.Drawing.Point(0, 0)
        Me.NavigationButton.Name = "NavigationButton"
        Me.NavigationButton.Size = New System.Drawing.Size(220, 220)
        Me.NavigationButton.TabIndex = 3
        Me.NavigationButton.Text = "Navigation"
        Me.NavigationButton.UseVisualStyleBackColor = True
        '
        'EnvironmentButton
        '
        Me.EnvironmentButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnvironmentButton.Location = New System.Drawing.Point(220, 0)
        Me.EnvironmentButton.Name = "EnvironmentButton"
        Me.EnvironmentButton.Size = New System.Drawing.Size(220, 220)
        Me.EnvironmentButton.TabIndex = 4
        Me.EnvironmentButton.Text = "Environment"
        Me.EnvironmentButton.UseVisualStyleBackColor = True
        '
        'CommunicationsButton
        '
        Me.CommunicationsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CommunicationsButton.Location = New System.Drawing.Point(220, 220)
        Me.CommunicationsButton.Name = "CommunicationsButton"
        Me.CommunicationsButton.Size = New System.Drawing.Size(220, 220)
        Me.CommunicationsButton.TabIndex = 6
        Me.CommunicationsButton.Text = "Communications"
        Me.CommunicationsButton.UseVisualStyleBackColor = True
        '
        'EntertainmentButton
        '
        Me.EntertainmentButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EntertainmentButton.Location = New System.Drawing.Point(0, 220)
        Me.EntertainmentButton.Name = "EntertainmentButton"
        Me.EntertainmentButton.Size = New System.Drawing.Size(220, 220)
        Me.EntertainmentButton.TabIndex = 5
        Me.EntertainmentButton.Text = "Entertainment"
        Me.EntertainmentButton.UseVisualStyleBackColor = True
        '
        'HomeScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.NavigationButton)
        Me.Controls.Add(Me.EnvironmentButton)
        Me.Controls.Add(Me.CommunicationsButton)
        Me.Controls.Add(Me.EntertainmentButton)
        Me.Name = "HomeScreen"
        Me.Size = New System.Drawing.Size(440, 440)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NavigationButton As System.Windows.Forms.Button
    Friend WithEvents EnvironmentButton As System.Windows.Forms.Button
    Friend WithEvents CommunicationsButton As System.Windows.Forms.Button
    Friend WithEvents EntertainmentButton As System.Windows.Forms.Button

End Class
