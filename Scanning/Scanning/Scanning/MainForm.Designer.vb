<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Me.SubMenu1 = New Scanning.SubMenu()
        Me.SubMenu2 = New Scanning.SubMenu()
        Me.SubMenu3 = New Scanning.SubMenu()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'SubMenu1
        '
        Me.SubMenu1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SubMenu1.Location = New System.Drawing.Point(53, 45)
        Me.SubMenu1.MenuOffset = 0
        Me.SubMenu1.Name = "SubMenu1"
        Me.SubMenu1.Size = New System.Drawing.Size(307, 104)
        Me.SubMenu1.TabIndex = 0
        Me.SubMenu1.TotalButtons = 3
        '
        'SubMenu2
        '
        Me.SubMenu2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SubMenu2.Location = New System.Drawing.Point(53, 176)
        Me.SubMenu2.MenuOffset = 3
        Me.SubMenu2.Name = "SubMenu2"
        Me.SubMenu2.Size = New System.Drawing.Size(508, 104)
        Me.SubMenu2.TabIndex = 1
        Me.SubMenu2.TotalButtons = 5
        '
        'SubMenu3
        '
        Me.SubMenu3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SubMenu3.Location = New System.Drawing.Point(53, 324)
        Me.SubMenu3.MenuOffset = 8
        Me.SubMenu3.Name = "SubMenu3"
        Me.SubMenu3.Size = New System.Drawing.Size(408, 104)
        Me.SubMenu3.TabIndex = 2
        Me.SubMenu3.TotalButtons = 4
        '
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 653)
        Me.Controls.Add(Me.SubMenu3)
        Me.Controls.Add(Me.SubMenu2)
        Me.Controls.Add(Me.SubMenu1)
        Me.Name = "MainForm"
        Me.Text = "CPS613 Scanning example"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SubMenu1 As Scanning.SubMenu
    Friend WithEvents SubMenu2 As Scanning.SubMenu
    Friend WithEvents SubMenu3 As Scanning.SubMenu
    Friend WithEvents Timer As System.Windows.Forms.Timer

End Class
