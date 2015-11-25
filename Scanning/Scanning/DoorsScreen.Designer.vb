<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DoorsScreen
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
        Me.BathroomDoorButton = New System.Windows.Forms.Button()
        Me.ApartmentFrontDoorButton = New System.Windows.Forms.Button()
        Me.BuildingFrontDoorButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BathroomDoorButton
        '
        Me.BathroomDoorButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BathroomDoorButton.Location = New System.Drawing.Point(69, 295)
        Me.BathroomDoorButton.Name = "BathroomDoorButton"
        Me.BathroomDoorButton.Size = New System.Drawing.Size(303, 115)
        Me.BathroomDoorButton.TabIndex = 5
        Me.BathroomDoorButton.Text = "Bathroom Door"
        Me.BathroomDoorButton.UseVisualStyleBackColor = True
        '
        'ApartmentFrontDoorButton
        '
        Me.ApartmentFrontDoorButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApartmentFrontDoorButton.Location = New System.Drawing.Point(69, 163)
        Me.ApartmentFrontDoorButton.Name = "ApartmentFrontDoorButton"
        Me.ApartmentFrontDoorButton.Size = New System.Drawing.Size(303, 115)
        Me.ApartmentFrontDoorButton.TabIndex = 4
        Me.ApartmentFrontDoorButton.Text = "Apartment Front Door"
        Me.ApartmentFrontDoorButton.UseVisualStyleBackColor = True
        '
        'BuildingFrontDoorButton
        '
        Me.BuildingFrontDoorButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuildingFrontDoorButton.Location = New System.Drawing.Point(69, 31)
        Me.BuildingFrontDoorButton.Name = "BuildingFrontDoorButton"
        Me.BuildingFrontDoorButton.Size = New System.Drawing.Size(303, 115)
        Me.BuildingFrontDoorButton.TabIndex = 3
        Me.BuildingFrontDoorButton.Text = "Building Front Door"
        Me.BuildingFrontDoorButton.UseVisualStyleBackColor = True
        '
        'DoorScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BathroomDoorButton)
        Me.Controls.Add(Me.ApartmentFrontDoorButton)
        Me.Controls.Add(Me.BuildingFrontDoorButton)
        Me.Name = "DoorScreen"
        Me.Size = New System.Drawing.Size(440, 440)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BathroomDoorButton As System.Windows.Forms.Button
    Friend WithEvents ApartmentFrontDoorButton As System.Windows.Forms.Button
    Friend WithEvents BuildingFrontDoorButton As System.Windows.Forms.Button

End Class
