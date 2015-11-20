<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TextMessage
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
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Send = New System.Windows.Forms.Button()
        Me.Back = New System.Windows.Forms.Button()
        Me.SubMenu1 = New Scanning.SubMenu()
        Me.CName = New System.Windows.Forms.Label()
        Me.SubMenu1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 185)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(260, 161)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'Send
        '
        Me.Send.Location = New System.Drawing.Point(191, 3)
        Me.Send.Name = "Send"
        Me.Send.Size = New System.Drawing.Size(75, 23)
        Me.Send.TabIndex = 1
        Me.Send.Text = "Send"
        Me.Send.UseVisualStyleBackColor = True
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(3, 3)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(75, 23)
        Me.Back.TabIndex = 2
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = True
        '
        'SubMenu1
        '
        Me.SubMenu1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SubMenu1.Controls.Add(Me.Back)
        Me.SubMenu1.Controls.Add(Me.Send)
        Me.SubMenu1.Location = New System.Drawing.Point(7, 151)
        Me.SubMenu1.Name = "SubMenu1"
        Me.SubMenu1.Size = New System.Drawing.Size(273, 34)
        Me.SubMenu1.TabIndex = 3
        '
        'CName
        '
        Me.CName.AutoSize = True
        Me.CName.Location = New System.Drawing.Point(100, 9)
        Me.CName.Name = "CName"
        Me.CName.Size = New System.Drawing.Size(75, 13)
        Me.CName.TabIndex = 4
        Me.CName.Text = "Contact Name"
        '
        'TextMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 358)
        Me.Controls.Add(Me.CName)
        Me.Controls.Add(Me.SubMenu1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Name = "TextMessage"
        Me.Text = "TextMessage"
        Me.SubMenu1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Send As Button
    Friend WithEvents Back As Button
    Friend WithEvents SubMenu1 As SubMenu
    Friend WithEvents CName As Label
End Class
