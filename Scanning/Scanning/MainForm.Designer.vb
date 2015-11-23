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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.ScanningTimer = New System.Windows.Forms.Timer(Me.components)
        Me.BottomBar = New Scanning.BottomBar()
        Me.HomeScreen = New Scanning.HomeScreen()
        Me.SuspendLayout()
        '
        'ScanningTimer
        '
        Me.ScanningTimer.Interval = 1000
        '
        'BottomBar
        '
        Me.BottomBar.Location = New System.Drawing.Point(47, 551)
        Me.BottomBar.Name = "BottomBar"
        Me.BottomBar.Size = New System.Drawing.Size(440, 125)
        Me.BottomBar.TabIndex = 0
        '
        'HomeScreen
        '
        Me.HomeScreen.Location = New System.Drawing.Point(47, 87)
        Me.HomeScreen.Name = "HomeScreen"
        Me.HomeScreen.Size = New System.Drawing.Size(440, 440)
        Me.HomeScreen.TabIndex = 1
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(534, 762)
        Me.Controls.Add(Me.BottomBar)
        Me.Controls.Add(Me.HomeScreen)
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.Name = "MainForm"
        Me.Text = "CPS613 Scanning Example"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ScanningTimer As System.Windows.Forms.Timer
    Friend WithEvents HomeScreen As Scanning.HomeScreen
    Friend WithEvents BottomBar As Scanning.BottomBar
End Class
