<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MessageScreen
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
        Me.MessageLogRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.MessageContactListBox = New System.Windows.Forms.ListBox()
        Me.MessageContactSortSubMenu = New Scanning.SubMenu()
        Me.MessageContactAllSortButton = New System.Windows.Forms.Button()
        Me.MessageContactFavoritesSortButton = New System.Windows.Forms.Button()
        Me.MessageContactEmergencySortButton = New System.Windows.Forms.Button()
        Me.MessageContactListSubMenu = New Scanning.SubMenu()
        Me.MessageContactSelectButton = New System.Windows.Forms.Button()
        Me.MessageContactDownButton = New System.Windows.Forms.Button()
        Me.MessageContactUpButton = New System.Windows.Forms.Button()
        Me.MessageResponsesSubMenu = New Scanning.SubMenu()
        Me.MessageStandardResponseButton = New System.Windows.Forms.Button()
        Me.MessageTypeResponseButton = New System.Windows.Forms.Button()
        Me.MessageContactSortSubMenu.SuspendLayout()
        Me.MessageContactListSubMenu.SuspendLayout()
        Me.MessageResponsesSubMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'MessageLogRichTextBox
        '
        Me.MessageLogRichTextBox.Location = New System.Drawing.Point(0, 270)
        Me.MessageLogRichTextBox.Name = "MessageLogRichTextBox"
        Me.MessageLogRichTextBox.Size = New System.Drawing.Size(440, 114)
        Me.MessageLogRichTextBox.TabIndex = 5
        Me.MessageLogRichTextBox.Text = ""
        '
        'MessageContactListBox
        '
        Me.MessageContactListBox.FormattingEnabled = True
        Me.MessageContactListBox.Location = New System.Drawing.Point(3, 3)
        Me.MessageContactListBox.Name = "MessageContactListBox"
        Me.MessageContactListBox.Size = New System.Drawing.Size(314, 186)
        Me.MessageContactListBox.TabIndex = 3
        '
        'MessageContactSortSubMenu
        '
        Me.MessageContactSortSubMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MessageContactSortSubMenu.Controls.Add(Me.MessageContactAllSortButton)
        Me.MessageContactSortSubMenu.Controls.Add(Me.MessageContactFavoritesSortButton)
        Me.MessageContactSortSubMenu.Controls.Add(Me.MessageContactEmergencySortButton)
        Me.MessageContactSortSubMenu.Location = New System.Drawing.Point(3, 7)
        Me.MessageContactSortSubMenu.Name = "MessageContactSortSubMenu"
        Me.MessageContactSortSubMenu.Size = New System.Drawing.Size(434, 58)
        Me.MessageContactSortSubMenu.TabIndex = 3
        '
        'MessageContactAllSortButton
        '
        Me.MessageContactAllSortButton.Location = New System.Drawing.Point(322, 3)
        Me.MessageContactAllSortButton.Name = "MessageContactAllSortButton"
        Me.MessageContactAllSortButton.Size = New System.Drawing.Size(75, 48)
        Me.MessageContactAllSortButton.TabIndex = 5
        Me.MessageContactAllSortButton.Text = "All"
        Me.MessageContactAllSortButton.UseVisualStyleBackColor = True
        '
        'MessageContactFavoritesSortButton
        '
        Me.MessageContactFavoritesSortButton.Location = New System.Drawing.Point(178, 3)
        Me.MessageContactFavoritesSortButton.Name = "MessageContactFavoritesSortButton"
        Me.MessageContactFavoritesSortButton.Size = New System.Drawing.Size(75, 48)
        Me.MessageContactFavoritesSortButton.TabIndex = 4
        Me.MessageContactFavoritesSortButton.Text = "Favorites"
        Me.MessageContactFavoritesSortButton.UseVisualStyleBackColor = True
        '
        'MessageContactEmergencySortButton
        '
        Me.MessageContactEmergencySortButton.Location = New System.Drawing.Point(34, 3)
        Me.MessageContactEmergencySortButton.Name = "MessageContactEmergencySortButton"
        Me.MessageContactEmergencySortButton.Size = New System.Drawing.Size(75, 48)
        Me.MessageContactEmergencySortButton.TabIndex = 3
        Me.MessageContactEmergencySortButton.Text = "Emergency"
        Me.MessageContactEmergencySortButton.UseVisualStyleBackColor = True
        '
        'MessageContactListSubMenu
        '
        Me.MessageContactListSubMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MessageContactListSubMenu.Controls.Add(Me.MessageContactSelectButton)
        Me.MessageContactListSubMenu.Controls.Add(Me.MessageContactListBox)
        Me.MessageContactListSubMenu.Controls.Add(Me.MessageContactDownButton)
        Me.MessageContactListSubMenu.Controls.Add(Me.MessageContactUpButton)
        Me.MessageContactListSubMenu.Location = New System.Drawing.Point(0, 72)
        Me.MessageContactListSubMenu.Name = "MessageContactListSubMenu"
        Me.MessageContactListSubMenu.Size = New System.Drawing.Size(440, 196)
        Me.MessageContactListSubMenu.TabIndex = 4
        '
        'MessageContactSelectButton
        '
        Me.MessageContactSelectButton.Location = New System.Drawing.Point(340, 130)
        Me.MessageContactSelectButton.Name = "MessageContactSelectButton"
        Me.MessageContactSelectButton.Size = New System.Drawing.Size(75, 50)
        Me.MessageContactSelectButton.TabIndex = 5
        Me.MessageContactSelectButton.Text = "Select"
        Me.MessageContactSelectButton.UseVisualStyleBackColor = True
        '
        'MessageContactDownButton
        '
        Me.MessageContactDownButton.Location = New System.Drawing.Point(340, 71)
        Me.MessageContactDownButton.Name = "MessageContactDownButton"
        Me.MessageContactDownButton.Size = New System.Drawing.Size(75, 50)
        Me.MessageContactDownButton.TabIndex = 4
        Me.MessageContactDownButton.Text = "Down"
        Me.MessageContactDownButton.UseVisualStyleBackColor = True
        '
        'MessageContactUpButton
        '
        Me.MessageContactUpButton.Location = New System.Drawing.Point(340, 12)
        Me.MessageContactUpButton.Name = "MessageContactUpButton"
        Me.MessageContactUpButton.Size = New System.Drawing.Size(75, 50)
        Me.MessageContactUpButton.TabIndex = 3
        Me.MessageContactUpButton.Text = "Up"
        Me.MessageContactUpButton.UseVisualStyleBackColor = True
        '
        'MessageResponsesSubMenu
        '
        Me.MessageResponsesSubMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MessageResponsesSubMenu.Controls.Add(Me.MessageStandardResponseButton)
        Me.MessageResponsesSubMenu.Controls.Add(Me.MessageTypeResponseButton)
        Me.MessageResponsesSubMenu.Location = New System.Drawing.Point(0, 385)
        Me.MessageResponsesSubMenu.Name = "MessageResponsesSubMenu"
        Me.MessageResponsesSubMenu.Size = New System.Drawing.Size(440, 52)
        Me.MessageResponsesSubMenu.TabIndex = 5
        '
        'MessageStandardResponseButton
        '
        Me.MessageStandardResponseButton.Location = New System.Drawing.Point(93, 4)
        Me.MessageStandardResponseButton.Name = "MessageStandardResponseButton"
        Me.MessageStandardResponseButton.Size = New System.Drawing.Size(75, 40)
        Me.MessageStandardResponseButton.TabIndex = 3
        Me.MessageStandardResponseButton.Text = "Standard Response"
        Me.MessageStandardResponseButton.UseVisualStyleBackColor = True
        '
        'MessageTypeResponseButton
        '
        Me.MessageTypeResponseButton.Enabled = False
        Me.MessageTypeResponseButton.Location = New System.Drawing.Point(268, 4)
        Me.MessageTypeResponseButton.Name = "MessageTypeResponseButton"
        Me.MessageTypeResponseButton.Size = New System.Drawing.Size(75, 40)
        Me.MessageTypeResponseButton.TabIndex = 4
        Me.MessageTypeResponseButton.Text = "Type Response"
        Me.MessageTypeResponseButton.UseVisualStyleBackColor = True
        '
        'MessageScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MessageResponsesSubMenu)
        Me.Controls.Add(Me.MessageContactListSubMenu)
        Me.Controls.Add(Me.MessageContactSortSubMenu)
        Me.Controls.Add(Me.MessageLogRichTextBox)
        Me.Name = "MessageScreen"
        Me.Size = New System.Drawing.Size(440, 440)
        Me.MessageContactSortSubMenu.ResumeLayout(False)
        Me.MessageContactListSubMenu.ResumeLayout(False)
        Me.MessageResponsesSubMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MessageLogRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents MessageContactListBox As System.Windows.Forms.ListBox
    Friend WithEvents MessageContactSortSubMenu As Scanning.SubMenu
    Friend WithEvents MessageContactAllSortButton As System.Windows.Forms.Button
    Friend WithEvents MessageContactFavoritesSortButton As System.Windows.Forms.Button
    Friend WithEvents MessageContactEmergencySortButton As System.Windows.Forms.Button
    Friend WithEvents MessageContactListSubMenu As Scanning.SubMenu
    Friend WithEvents MessageContactSelectButton As System.Windows.Forms.Button
    Friend WithEvents MessageContactDownButton As System.Windows.Forms.Button
    Friend WithEvents MessageContactUpButton As System.Windows.Forms.Button
    Friend WithEvents MessageResponsesSubMenu As Scanning.SubMenu
    Friend WithEvents MessageTypeResponseButton As System.Windows.Forms.Button
    Friend WithEvents MessageStandardResponseButton As System.Windows.Forms.Button

End Class
