Public Class frmsLocker
    Public LockerNumber As Integer = 0

    Function RegisterLocker() As Boolean
        'Search locker number sqlquery
        LockerNumber = 1
        Return True
    End Function
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmsLocker_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Form Reset
        txtLockerNumber.Enabled = False
        ActiveControl = txtRFID
        'txtLockerNumber.Text = ""
        'txtRFID.Text = ""
        LockerNumber = 0
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        txtLockerNumber.Enabled = True
        ActiveControl = txtLockerNumber
    End Sub

    Private Sub txtLockerNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLockerNumber.TextChanged
        If RegisterLocker() = False Then
            MsgBox("Invalid Token")
        Else
            frmSales.LockerNumber = LockerNumber
            txtLockerNumber.Text = ""
            txtRFID.Text = ""
            Me.Close()
        End If
    End Sub

    Private Sub btnShareLocker_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShareLocker.Click
        LockerNumber = -1
        frmSales.LockerNumber = LockerNumber
        txtLockerNumber.Text = ""
        txtRFID.Text = ""
        Me.Close()
    End Sub
End Class