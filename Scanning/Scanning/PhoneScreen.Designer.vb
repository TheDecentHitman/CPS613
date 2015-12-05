<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PhoneScreen
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
        Me.PhoneContactListBox = New System.Windows.Forms.ListBox()
        Me.PhoneContactCallButton = New System.Windows.Forms.Button()
        Me.PhoneContactDownButton = New System.Windows.Forms.Button()
        Me.PhoneContactUpButton = New System.Windows.Forms.Button()
        Me.PhoneContactSortSubMenu = New Scanning.SubMenu()
        Me.PhoneContactAllSortButton = New System.Windows.Forms.Button()
        Me.PhoneContactFavoritesSortButton = New System.Windows.Forms.Button()
        Me.PhoneContactEmergencySortButton = New System.Windows.Forms.Button()
        Me.PhoneContactListSubMenu = New Scanning.SubMenu()
        Me.PhoneContactSortSubMenu.SuspendLayout()
        Me.PhoneContactListSubMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'PhoneContactListBox
        '
        Me.PhoneContactListBox.FormattingEnabled = True
        Me.PhoneContactListBox.Location = New System.Drawing.Point(21, 5)
        Me.PhoneContactListBox.Name = "PhoneContactListBox"
        Me.PhoneContactListBox.Size = New System.Drawing.Size(255, 329)
        Me.PhoneContactListBox.TabIndex = 4
        '
        'PhoneContactCallButton
        '
        Me.PhoneContactCallButton.Location = New System.Drawing.Point(324, 229)
        Me.PhoneContactCallButton.Name = "PhoneContactCallButton"
        Me.PhoneContactCallButton.Size = New System.Drawing.Size(75, 50)
        Me.PhoneContactCallButton.TabIndex = 5
        Me.PhoneContactCallButton.Text = "Call"
        Me.PhoneContactCallButton.UseVisualStyleBackColor = True
        '
        'PhoneContactDownButton
        '
        Me.PhoneContactDownButton.Location = New System.Drawing.Point(324, 145)
        Me.PhoneContactDownButton.Name = "PhoneContactDownButton"
        Me.PhoneContactDownButton.Size = New System.Drawing.Size(75, 50)
        Me.PhoneContactDownButton.TabIndex = 4
        Me.PhoneContactDownButton.Text = "Down"
        Me.PhoneContactDownButton.UseVisualStyleBackColor = True
        '
        'PhoneContactUpButton
        '
        Me.PhoneContactUpButton.Location = New System.Drawing.Point(324, 61)
        Me.PhoneContactUpButton.Name = "PhoneContactUpButton"
        Me.PhoneContactUpButton.Size = New System.Drawing.Size(75, 50)
        Me.PhoneContactUpButton.TabIndex = 3
        Me.PhoneContactUpButton.Text = "Up"
        Me.PhoneContactUpButton.UseVisualStyleBackColor = True
        '
        'PhoneContactSortSubMenu
        '
        Me.PhoneContactSortSubMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PhoneContactSortSubMenu.Controls.Add(Me.PhoneContactAllSortButton)
        Me.PhoneContactSortSubMenu.Controls.Add(Me.PhoneContactFavoritesSortButton)
        Me.PhoneContactSortSubMenu.Controls.Add(Me.PhoneContactEmergencySortButton)
        Me.PhoneContactSortSubMenu.Location = New System.Drawing.Point(3, 6)
        Me.PhoneContactSortSubMenu.Name = "PhoneContactSortSubMenu"
        Me.PhoneContactSortSubMenu.Size = New System.Drawing.Size(434, 58)
        Me.PhoneContactSortSubMenu.TabIndex = 3
        '
        'PhoneContactAllSortButton
        '
        Me.PhoneContactAllSortButton.Location = New System.Drawing.Point(322, 3)
        Me.PhoneContactAllSortButton.Name = "PhoneContactAllSortButton"
        Me.PhoneContactAllSortButton.Size = New System.Drawing.Size(75, 48)
        Me.PhoneContactAllSortButton.TabIndex = 5
        Me.PhoneContactAllSortButton.Text = "All"
        Me.PhoneContactAllSortButton.UseVisualStyleBackColor = True
        '
        'PhoneContactFavoritesSortButton
        '
        Me.PhoneContactFavoritesSortButton.Location = New System.Drawing.Point(178, 3)
        Me.PhoneContactFavoritesSortButton.Name = "PhoneContactFavoritesSortButton"
        Me.PhoneContactFavoritesSortButton.Size = New System.Drawing.Size(75, 48)
        Me.PhoneContactFavoritesSortButton.TabIndex = 4
        Me.PhoneContactFavoritesSortButton.Text = "Favorites"
        Me.PhoneContactFavoritesSortButton.UseVisualStyleBackColor = True
        '
        'PhoneContactEmergencySortButton
        '
        Me.PhoneContactEmergencySortButton.Enabled = False
        Me.PhoneContactEmergencySortButton.Location = New System.Drawing.Point(34, 3)
        Me.PhoneContactEmergencySortButton.Name = "PhoneContactEmergencySortButton"
        Me.PhoneContactEmergencySortButton.Size = New System.Drawing.Size(75, 48)
        Me.PhoneContactEmergencySortButton.TabIndex = 3
        Me.PhoneContactEmergencySortButton.Text = "Emergency"
        Me.PhoneContactEmergencySortButton.UseVisualStyleBackColor = True
        '
        'PhoneContactListSubMenu
        '
        Me.PhoneContactListSubMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PhoneContactListSubMenu.Controls.Add(Me.PhoneContactListBox)
        Me.PhoneContactListSubMenu.Controls.Add(Me.PhoneContactUpButton)
        Me.PhoneContactListSubMenu.Controls.Add(Me.PhoneContactCallButton)
        Me.PhoneContactListSubMenu.Controls.Add(Me.PhoneContactDownButton)
        Me.PhoneContactListSubMenu.Location = New System.Drawing.Point(0, 76)
        Me.PhoneContactListSubMenu.Name = "PhoneContactListSubMenu"
        Me.PhoneContactListSubMenu.Size = New System.Drawing.Size(440, 345)
        Me.PhoneContactListSubMenu.TabIndex = 4
        '
        'PhoneScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PhoneContactListSubMenu)
        Me.Controls.Add(Me.PhoneContactSortSubMenu)
        Me.Name = "PhoneScreen"
        Me.Size = New System.Drawing.Size(440, 440)
        Me.PhoneContactSortSubMenu.ResumeLayout(False)
        Me.PhoneContactListSubMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PhoneContactListBox As System.Windows.Forms.ListBox
    Friend WithEvents PhoneContactCallButton As System.Windows.Forms.Button
    Friend WithEvents PhoneContactDownButton As System.Windows.Forms.Button
    Friend WithEvents PhoneContactUpButton As System.Windows.Forms.Button
    Friend WithEvents PhoneContactSortSubMenu As Scanning.SubMenu
    Friend WithEvents PhoneContactAllSortButton As System.Windows.Forms.Button
    Friend WithEvents PhoneContactFavoritesSortButton As System.Windows.Forms.Button
    Friend WithEvents PhoneContactEmergencySortButton As System.Windows.Forms.Button
    Friend WithEvents PhoneContactListSubMenu As Scanning.SubMenu

End Class
