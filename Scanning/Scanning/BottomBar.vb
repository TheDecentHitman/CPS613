Public Class BottomBar

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        If MainForm.scanninglevel = 0 Then
            Dim LastScreenName As String = MainForm.ScreenHistory.Pop()
            Dim NewScreen As Control

            Select Case LastScreenName
                Case "HomeScreen"
                    NewScreen = New HomeScreen
                Case "NavegationScreen"
                    NewScreen = New NavigationScreen
                Case "EnvironmentScreen"
                    NewScreen = New EnvironmentScreen
                Case "TemperatureAndFansScreen"
                    NewScreen = New TemperatureAndFansScreen
                Case "TemperatureSpecificRoomScreen"
                    NewScreen = New TemperatureSpecificRoomScreen
                Case "FansSpecificRoomScreen"
                    NewScreen = New FansSpecificRoomScreen
                Case "WindowsAndBlindsScreen"
                    NewScreen = New WindowsAndBlindsScreen
                Case "WindowsSpecificRoomScreen"
                    NewScreen = New WindowsSpecificRoomScreen
                Case "BlindsSpecificRoomScreen"
                    NewScreen = New BlindsSpecificRoomScreen
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
                Case "MessageScreen"
                    NewScreen = New MessageScreen
                Case "SettingsScreen"
                    NewScreen = New SettingsScreen
            End Select

            MainForm.ChangeScreen(Nothing, NewScreen)
        Else
            MainForm.scanninglevel = 0
            MainForm.InitializeScanning()
        End If
    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        MainForm.ScreenHistory.Push(MainForm.Controls(1).Name)
        MainForm.Controls.RemoveAt(1)
        Dim NewScreen As HomeScreen = New HomeScreen
        NewScreen.Location = New Point(47, 87)
        MainForm.Controls.Add(NewScreen)
    End Sub

    Private Sub SettingsButton_Click(sender As Object, e As EventArgs) Handles SettingsButton.Click
        MainForm.ScreenHistory.Push(MainForm.Controls(1).Name)
        MainForm.Controls.RemoveAt(1)
        Dim NewScreen As SettingsScreen = New SettingsScreen
        NewScreen.Location = New Point(47, 87)
        MainForm.Controls.Add(NewScreen)
    End Sub
End Class
