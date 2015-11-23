Public Class SubMenu
    Inherits Panel

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)

        'Add your custom paint code here
    End Sub

#Region "Variables"

    Private totalbuttons As Integer
    Private Buttons As Button()
    Private activebutton As Integer

#End Region

#Region "Initialize"

    ' This routine orders all the Submenu's buttons into an array in the order dscribed by the tabindexes of all the buttons

    Public Sub Initialize()
        totalbuttons = 0
        Dim maxButtons As Integer = Me.Controls.Count + MainForm.BottomBar.Controls.Count
        ReDim Buttons(maxButtons)
        Dim index As Integer
        For Each b As Control In Me.Controls
            If TypeOf b Is Button Then
                index = CInt(b.TabIndex)
                If index >= maxButtons Then
                    MsgBox("The button labelled " & b.Text & " was not added to scanning menu because its tabindex is greater or equal to " & maxButtons)
                ElseIf Buttons(index) Is Nothing Then
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
                If index >= maxButtons Then
                    MsgBox("The button labelled " & b.Text & " was not added to scanning menu because its tabindex is greater or equal to " & maxButtons)
                ElseIf Buttons(index) Is Nothing Then
                    Buttons(index) = b
                Else
                    MsgBox("The button labelled " & b.Text & " was not added to scanning menu because it has the same tabindex as the button labelled " & Buttons(index).Text)
                End If
                totalbuttons += 1
            End If
        Next
        ReDim Preserve Buttons(totalbuttons - 1)
    End Sub

#End Region

#Region "Outer Scanning"

    ' You can customize the look and feel of the outer scanning in these routines

    Public Sub ReceiveFocus()
        BackColor = Color.CornflowerBlue
    End Sub

    Public Sub LoseFocus()
        TakeFocusFromButton(activebutton)
        BackColor = DefaultBackColor
    End Sub

#End Region

#Region "Inner Scanning"

    Public Sub StartInnerScanning()
        activebutton = 3

        Do Until Buttons(activebutton).Enabled
            activebutton = (activebutton + 1) Mod totalbuttons
        Loop

        GiveFocusToButton(activebutton)
    End Sub

    Public Sub InnerScanningNext()
        TakeFocusFromButton(activebutton)

        Do
            activebutton = (activebutton + 1) Mod totalbuttons
        Loop Until Buttons(activebutton).Enabled

        GiveFocusToButton(activebutton)
    End Sub

    ' You can customize the look and feel of the inner scanning in these two routines
    Private Sub TakeFocusFromButton(index As Integer)
        Buttons(index).FlatStyle = FlatStyle.System
    End Sub

    Private Sub GiveFocusToButton(index As Integer)
        Buttons(index).FlatStyle = FlatStyle.Standard
        Buttons(index).Focus()
    End Sub

#End Region

End Class
