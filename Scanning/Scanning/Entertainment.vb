Public Class Entertainment

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TopMenu1.Initialize(SubMenu1, OptionsSubMenu)

    End Sub
    Private Sub Entertainment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TopMenu1.StartScanning()
    End Sub
    Private Sub Entertainment_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        TopMenu1.StopScanning()
        TopMenu1.ResumeScanning()

    End Sub

    Private Sub TVB_Click(sender As Object, e As EventArgs) Handles TVB.Click
        TopMenu1.StopScanning()
        Stream.Visible = True
        Recorded.Visible = True
        TopMenu1.Initialize(SubMenu2, OptionsSubMenu)
        TopMenu1.StartScanning()

    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Me.Hide()
        MainForm.Show()
    End Sub

    Private Sub MusicB_Click(sender As Object, e As EventArgs) Handles MusicB.Click
        TopMenu1.StopScanning()
        Iphone.Visible = True
        Mp3.Visible = True
        TopMenu1.Initialize(SubMenu3, OptionsSubMenu)
        TopMenu1.StartScanning()
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Stream.Click, Recorded.Click, Iphone.Click, Mp3.Click, DVDB.Click
        TopMenu1.StopScanning()
        Button5.Visible = True
        Button6.Visible = True
        Button7.Visible = True
        Button8.Visible = True
        TopMenu1.Initialize(SubMenu4, OptionsSubMenu)
        TopMenu1.StartScanning()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Player.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Player.Show()
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        Player.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Hide()
        Player.Show()
    End Sub
End Class