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
End Class