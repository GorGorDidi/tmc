Public Class frmStaff
    Dim alhandler As frmTouchKeyboard.KeyboardHandler = AddressOf touchKeyPressed

    Private Sub frmStaff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmTouchKeyboard.TopLevel = False
        frmTouchKeyboard.Location = New Point(0, 0)
        frmTouchKeyboard.Parent = panelTouchKeyboard
        frmTouchKeyboard.Size = panelTouchKeyboard.Size


        AddHandler frmTouchKeyboard.UserKeyPressed, alhandler
        frmTouchKeyboard.Show()

    End Sub


    Private Sub touchKeyPressed(ByVal sender As Object, ByVal e As frmTouchKeyboard.KeyboardEventArgs)

        SendKeys.Send(e.KeyboardPressed)

    End Sub
End Class