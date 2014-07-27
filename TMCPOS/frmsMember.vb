Public Class frmsMember

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
        txtRemarks.Enabled = True

        ''Dim working_area As Rectangle = SystemInformation.WorkingArea
        ''Dim x As Integer = _
        ''    working_area.Left + working_area.Width - keyboard.Width
        ''Dim y As Integer = _
        ''    working_area.Bottom + working_area.Height - keyboard.Height

        ''keyboard.Location = New Point(x, 500)
        keyboard.ShowDialog()

    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        txtRemarks.Enabled = False
        keyboard.Close()
    End Sub
End Class