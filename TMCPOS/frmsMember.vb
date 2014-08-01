Public Class frmsMember
    Dim alhandler As frmTouchKeyboard.KeyboardHandler = AddressOf touchKeyPressed
    Dim textBoxBackColor As Color

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnUsePass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsePass.Click
        Me.Hide()
        frmsLocker.ShowDialog()
        Me.Close()
    End Sub

    Private Sub btnNoUsePass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoUsePass.Click
        Me.Hide()
        frmsLocker.ShowDialog()
        Me.Close()
    End Sub

    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click

        textBoxBackColor = txtRemarks.BackColor

        txtRemarks.BackColor = Color.White

        Dim txtRemarksPos As Point = txtRemarks.PointToScreen(New Point(0, 0))
        frmTouchKeyboard.Location = New Point(txtRemarksPos.X, txtRemarksPos.Y + txtRemarks.Height)
        frmTouchKeyboard.Target = txtRemarks

        AddHandler frmTouchKeyboard.UserKeyPressed, alhandler

        frmTouchKeyboard.Show()


    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click

        txtRemarks.BackColor = textBoxBackColor

        RemoveHandler frmTouchKeyboard.UserKeyPressed, alhandler

        frmTouchKeyboard.Close()


    End Sub

    Private Sub touchKeyPressed(ByVal sender As Object, ByVal e As frmTouchKeyboard.KeyboardEventArgs)

        SendKeys.Send(e.KeyboardPressed)

    End Sub

End Class