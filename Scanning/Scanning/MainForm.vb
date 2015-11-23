Public Class MainForm
    Private setup As Boolean = True
    Private totalcontrols As Integer
    Private SelectableControls As Control()
    Private focusIsOn As Integer
    Public scanninglevel As Integer
    Public ScreenHistory As Stack

    ' TODO FOR ZACK Change scanning so BottomBar is scanned as SubMenu

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Show
        InitializeScanning()
        ScreenHistory = New Stack()
        setup = False
    End Sub

    Public Sub ChangeScreen(OldScreen As Control, NewScreen As Control)
        If Not IsNothing(OldScreen) Then
            ScreenHistory.Push(OldScreen.Name)
        End If

        Me.Controls.RemoveAt(1)
        NewScreen.Location = New Point(47, 87)
        Me.Controls.Add(NewScreen)
    End Sub

    Public Sub IncomingPhoneCall()
        ' TODO Stop scanning, create IncomingPhoneCall form, start scanning IncomingPhoneCall form
    End Sub

    Public Sub IncomingMessage()
        ' TODO Stop scanning, create IncomingMessage form, start scanning IncomingMessage form
    End Sub

    Public Sub InitializeScanning()
        ReDim SelectableControls(0)
        totalcontrols = 0
        For Each Control In Me.Controls
            For Each SubControl In Control.Controls
                ReDim Preserve SelectableControls(SelectableControls.Length + Control.Controls.Count)
                If TypeOf SubControl Is Button OrElse TypeOf SubControl Is SubMenu Then
                    If SubControl.tabIndex >= SelectableControls.Length Then
                        ReDim Preserve SelectableControls(SubControl.tabIndex)
                    End If
                    SelectableControls(SubControl.tabIndex) = SubControl
                    totalcontrols += 1
                End If
            Next
        Next
        ReDim Preserve SelectableControls(totalcontrols - 1)
        InitializeSubMenus(SelectableControls)
        StartScanning()
    End Sub

    Private Sub InitializeSubMenus(SelectableControls)
        For Each Control In SelectableControls
            If TypeOf Control Is SubMenu Then
                CType(Control, SubMenu).Initialize()
            End If
        Next
    End Sub

    ' Start scanning on the first submenu
    Public Sub StartScanning()
        scanninglevel = 0
        focusIsOn = BottomBar.Controls.Count

        If TypeOf SelectableControls(focusIsOn) Is Button Then
            CType(SelectableControls(focusIsOn), Button).FlatStyle = FlatStyle.System
            CType(SelectableControls(focusIsOn), Button).Focus()
        Else
            CType(SelectableControls(focusIsOn), SubMenu).ReceiveFocus()
        End If

        ScanningTimer.Start()
    End Sub

    ' Stop scanning
    Public Sub StopScanning()
        ScanningTimer.Stop()
        If TypeOf SelectableControls(focusIsOn) Is Button Then
            CType(SelectableControls(focusIsOn), Button).FlatStyle = FlatStyle.System
            Me.Focus()
        Else
            CType(SelectableControls(focusIsOn), SubMenu).LoseFocus()
        End If
        Me.Focus()
    End Sub

    ' Resume scanning on the same submenu where you stopped
    ' to restrat scanning at the beginning, use StartScanning
    Public Sub ResumeScanning()
        scanninglevel = 0
        If TypeOf SelectableControls(focusIsOn) Is Button Then
            CType(SelectableControls(focusIsOn), Button).FlatStyle = FlatStyle.System
            CType(SelectableControls(focusIsOn), Button).Focus()
        Else
            CType(SelectableControls(focusIsOn), SubMenu).ReceiveFocus()
            CType(SelectableControls(focusIsOn), SubMenu).Focus()
        End If
        ScanningTimer.Start()
    End Sub

    ' When the timer goes off, scan to next submenu
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles ScanningTimer.Tick
        If scanninglevel = 0 Then
            If TypeOf SelectableControls(focusIsOn) Is Button Then
                CType(SelectableControls(focusIsOn), Button).FlatStyle = FlatStyle.System
                Me.Focus()
            Else
                CType(SelectableControls(focusIsOn), SubMenu).LoseFocus()
            End If

            Do
                focusIsOn = (focusIsOn + 1) Mod totalcontrols
            Loop Until SelectableControls(focusIsOn).Enabled

            If TypeOf SelectableControls(focusIsOn) Is Button Then
                CType(SelectableControls(focusIsOn), Button).FlatStyle = FlatStyle.Standard
                CType(SelectableControls(focusIsOn), Button).Focus()
            Else
                CType(SelectableControls(focusIsOn), SubMenu).ReceiveFocus()
                CType(SelectableControls(focusIsOn), SubMenu).Focus()
            End If
        Else
            CType(SelectableControls(focusIsOn), SubMenu).InnerScanningNext()
        End If
    End Sub

    Private Sub MainForm_Click(sender As Object, e As EventArgs) Handles Me.ControlAdded
        If Not setup Then
            If ScreenHistory.Count > 0 Then
                BottomBar.BackButton.Enabled = True
            Else
                BottomBar.BackButton.Enabled = False
            End If

            If TypeOf Controls(1) Is HomeScreen Then
                BottomBar.HomeButton.Enabled = False
            Else
                BottomBar.HomeButton.Enabled = True
            End If

            InitializeScanning()
        End If
    End Sub

    ' When the user selects a submenu, start scanning within that submenu
    Private Sub Me_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If scanninglevel = 0 AndAlso TypeOf SelectableControls(focusIsOn) Is SubMenu Then
            scanninglevel = 1
            CType(SelectableControls(focusIsOn), SubMenu).StartInnerScanning()
        End If
    End Sub
End Class