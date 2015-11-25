Public Class BottomBar

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        If MainForm.scanninglevel = 0 Then
            Dim LastScreenName As String = MainForm.ScreenHistory.Pop()
            Dim NewScreen As Control

            Select Case LastScreenName
                Case "HomeScreen"
                    NewScreen = New HomeScreen
                Case "NavigationScreen"
                    NewScreen = New NavigationScreen
                Case "DoorsScreen"
                    NewScreen = New DoorsScreen
                Case "ElevatorScreen"
                    NewScreen = New ElevatorScreen
                Case "EnvironmentScreen"
                    NewScreen = New EnvironmentScreen
                Case "TemperatureAndFansScreen"
                    NewScreen = New TemperatureAndFansScreen
                Case "TemperatureSpecificRoomScreen"
                    NewScreen = New TemperatureSpecificRoomScreen
                Case "Heaters"
                    NewScreen = New Heaters
                Case "FansSpecificRoomScreen"
                    NewScreen = New FansSpecificRoomScreen
                Case "Fans"
                    NewScreen = New Fans
                Case "WindowsAndBlindsScreen"
                    NewScreen = New WindowsAndBlindsScreen
                Case "WindowsSpecificRoomScreen"
                    NewScreen = New WindowsSpecificRoomScreen
                Case "BlindsSpecificRoomScreen"
                    NewScreen = New BlindsSpecificRoomScreen
                Case "WindowBlindOpenCloseScreen"
                    NewScreen = New WindowBlindOpenCloseScreen
                Case "LightsScreen"
                    NewScreen = New LightsScreen
                Case "LightsSpecificRoomScreen"
                    NewScreen = New LightsSpecificRoomScreen
                Case "EntertainmentScreen"
                    NewScreen = New EntertainmentScreen
                Case "AudioScreen"
                    NewScreen = New AudioScreen
                Case "MusicScreen"
                    NewScreen = New MusicScreen
                Case "TVScreen"
                    NewScreen = New TVScreen
                Case "CommunicationsScreen"
                    NewScreen = New CommunicationsScreen
                Case "PhoneScreen"
                    NewScreen = New PhoneScreen
                Case "phonecall1"
                    NewScreen = New phonecall1
                Case "incomecall"
                    NewScreen = New incomecall
                Case "MessageScreen"
                    NewScreen = New MessageScreen
                Case "SettingsScreen"
                    NewScreen = New SettingsScreen
            End Select

            If IsNothing(NewScreen) Then
                MsgBox("No screen found with name " + LastScreenName)
            Else
                MainForm.ChangeScreen(Nothing, NewScreen)
            End If
        Else
            MainForm.SelectableControls(MainForm.focusIsOn).BackColor = DefaultBackColor
            MainForm.scanninglevel = 0
            MainForm.bottomBarActive = False
            MainForm.FocusLabel.Focus()
            MainForm.InitializeScanning()
        End If
    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        For Each C As Control In MainForm.Controls
            If Not (TypeOf C Is Label OrElse TypeOf C Is BottomBar) Then
                MainForm.ChangeScreen(C, New HomeScreen)
                Exit For
            End If
        Next
    End Sub

    Private Sub SettingsButton_Click(sender As Object, e As EventArgs) Handles SettingsButton.Click
        For Each C As Control In MainForm.Controls
            If Not (TypeOf C Is Label OrElse TypeOf C Is BottomBar) Then
                MainForm.ChangeScreen(C, New SettingsScreen)
                Exit For
            End If
        Next
    End Sub
End Class
