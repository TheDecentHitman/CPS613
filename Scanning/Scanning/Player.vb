Public Class Player

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TopMenu1.Initialize(SubMenu1, OptionsSubMenu)

    End Sub


    Private Sub Player_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        TopMenu1.StopScanning()
        TopMenu1.ResumeScanning()

    End Sub

    Private Sub Player_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TopMenu1.StartScanning()

    End Sub
End Class