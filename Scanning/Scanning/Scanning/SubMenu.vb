Public Class SubMenu

#Region "Initialisations"
    Const MAXBUTTONS As Integer = 5
    Private Buttons(MAXBUTTONS) As Button
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Buttons(0) = Button1
        Buttons(1) = Button2
        Buttons(2) = Button3
        Buttons(3) = Button4
        Buttons(4) = Button5
    End Sub

    Dim main As MainForm
    Public Sub Initialise(callingform As MainForm)
        main = callingform
    End Sub

#End Region

#Region "MenuOffset Property"

    Private _menuOffset As Integer = 0   'This is the offset of the submenu in the bigger menu, i.e. the position of the first menu button
    'This offset is specified in the Designer with the user-defined property MenuOffset defined below

    Public Property MenuOffset As Integer
        Get
            Return _menuOffset
        End Get
        Set(value As Integer)
            _menuOffset = value
            For i = 0 To _totalButtons - 1
                Buttons(i).Text = "Button " & (_menuOffset + i)
            Next
        End Set
    End Property

#End Region

#Region "TotalButtons Property"

    Private _totalButtons As Integer = 5   'This is the number of buttons in this menu
    'This number is specified in the Designer with the user-defined property TotalButtons defined below
    Public Property TotalButtons As Integer
        Get
            Return _totalButtons
        End Get
        Set(value As Integer)
            _totalButtons = value
            For i = 0 To _totalButtons - 1
                Buttons(i).Visible = True
            Next
            For i = _totalButtons To MAXBUTTONS - 1
                Buttons(i).Visible = False
            Next
        End Set
    End Property

#End Region

#Region "Scanning"

    Public Sub ReceiveFocus()
        BackColor = Color.AntiqueWhite
    End Sub

    Public Sub LoseFocus()
        BackColor = DefaultBackColor
    End Sub

    ' The tag field of each button contains the position of the button in the submenu (starting at 0)
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click
        Dim selectedbutton As Button = sender
        main.ShowButtonPressed(_menuOffset + CInt(selectedbutton.TabIndex))
    End Sub

#End Region

End Class
