Public Class MainForm

    Const TOTALMENUS As Integer = 3
    Private SubMenus(TOTALMENUS) As SubMenu
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        SubMenus(0) = SubMenu1
        SubMenus(1) = SubMenu2
        SubMenus(2) = SubMenu3
        For i = 0 To TOTALMENUS - 1
            SubMenus(i).Initialise(Me)
        Next

        StartScanning()

    End Sub

    Public Sub ShowButtonPressed(buttonnum As Integer)
        MsgBox("Button pressed: " & buttonnum)
    End Sub

#Region "Scanning functionality"
    Private focusIsOn As Integer
    Private Sub StartScanning()
        SubMenus(0).ReceiveFocus()
        focusIsOn = 0
        Timer.Start()
    End Sub
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        SubMenus(focusIsOn).LoseFocus()
        focusIsOn = (focusIsOn + 1) Mod TOTALMENUS
        SubMenus(focusIsOn).ReceiveFocus()
    End Sub

#End Region

End Class
