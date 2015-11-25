Public Class SubMenu
    Inherits Panel

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)

        'Add your custom paint code here
    End Sub

#Region "Variables"

    Private totalbuttons As Integer
    Private Buttons As Button()
    Public activebutton As Integer

#End Region

#Region "Initialize"

    ' This routine orders all the Submenu's buttons into an array in the order dscribed by the tabindexes of all the buttons

    Public Sub Initialize()
        totalbuttons = 0
        ReDim Buttons(2)
        Dim index As Integer
        For Each b As Control In Me.Controls
            If TypeOf b Is Button Then
                index = CInt(b.TabIndex)
                If index >= Buttons.Count Then
                    ReDim Preserve Buttons(index)
                End If

                If Buttons(index) Is Nothing Then
                    Buttons(index) = b
                Else
                    MsgBox("The button labelled " & b.Text & " was not added to scanning menu because it has the same tabindex as the button labelled " & Buttons(index).Text)
                End If
                totalbuttons += 1
            End If
        Next
        For Each b As Control In MainForm.BottomBar.Controls
            If TypeOf b Is Button Then
                index = CInt(b.TabIndex)
                If index >= Buttons.Count Then
                    ReDim Preserve Buttons(index)
                End If

                If Buttons(index) Is Nothing Then
                    Buttons(index) = b
                Else
                    MsgBox("The button labelled " & b.Text & " was not added to scanning menu because it has the same tabindex as the button labelled " & Buttons(index).Text)
                End If
                totalbuttons += 1
            End If
        Next
    End Sub

#End Region

#Region "Outer Scanning"

    ' You can customize the look and feel of the outer scanning in these routines

    Public Sub ReceiveFocus()
        BackColor = Color.LightBlue
    End Sub

    Public Sub LoseFocus()
        TakeFocusFromButton(activebutton)
        BackColor = DefaultBackColor
    End Sub

#End Region

#Region "Inner Scanning"

    Public Sub StartInnerScanning()
        activebutton = 3

        Do Until (MainForm.bottomBarActive OrElse (activebutton <> 0 AndAlso activebutton <> 1)) AndAlso Buttons(activebutton).Enabled
            activebutton = (activebutton + 1) Mod totalbuttons
        Loop

        GiveFocusToButton(activebutton)
    End Sub

    Public Sub InnerScanningNext()
        TakeFocusFromButton(activebutton)

        Do
            activebutton = (activebutton + 1) Mod totalbuttons
        Loop Until (MainForm.bottomBarActive OrElse (activebutton <> 0 AndAlso activebutton <> 1)) AndAlso Buttons(activebutton).Enabled

        GiveFocusToButton(activebutton)
    End Sub

    ' You can customize the look and feel of the inner scanning in these two routines
    Private Sub TakeFocusFromButton(index As Integer)
        MainForm.FocusLabel.Focus()

        If MainForm.bottomBarActive OrElse index <> 2 Then
            Buttons(index).FlatStyle = FlatStyle.System
        Else
            MainForm.BottomBar.BackColor = DefaultBackColor
        End If
    End Sub

    Private Sub GiveFocusToButton(index As Integer)
        If MainForm.bottomBarActive OrElse index <> 2 Then
            Buttons(index).FlatStyle = FlatStyle.Standard
            Buttons(index).Focus()
        Else
            MainForm.BottomBar.BackColor = Color.LightBlue
        End If
    End Sub

#End Region

    Public Sub ResetScanning()
        activebutton = totalbuttons - 1
    End Sub

End Class
