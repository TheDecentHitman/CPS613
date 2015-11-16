Public Class MainForm


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TopMenu.Initialize(MainSubMenu, OptionsSubMenu)

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        TopMenu.StartScanning()
    End Sub


    Private Sub Button_Click(sender As Object, e As EventArgs) Handles NavigationButton.Click, EnvironmentButton.Click, EntertainmentButton.Click, CommunicationsButton.Click, BackButton.Click, HomeButton.Click, SettingsButton.Click
        TopMenu.StopScanning()
        Dim b As Button = sender
        MsgBox(b.ToString() & " was selected")
        TopMenu.ResumeScanning()
    End Sub
End Class