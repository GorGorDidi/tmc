Public Class frmsLocker
    Dim alhandler As frmTouchKeypad.KeypadHandler = AddressOf touchKeyPressed
    Public lockerNumber As Integer = 0

    Function RegisterLocker() As Boolean
        'Search locker number sqlquery
        lockerNumber += 1
        Return True
    End Function
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmsLocker_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Form Reset
        txtLockerNumber.Enabled = False
        ActiveControl = txtRFID
        txtLockerNumber.Text = ""
        txtRFID.Text = ""
        lockerNumber = 0
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        txtLockerNumber.Enabled = True
        'ActiveControl = txtLockerNumber

        Dim txtRemarksPos As Point = btnEdit.PointToScreen(New Point(0, 0))
        frmTouchKeypad.Location = New Point(btnEdit.Location.X + btnEdit.Width + 200, btnEdit.Location.Y)
        frmTouchKeypad.Target = txtLockerNumber
        AddHandler frmTouchKeypad.UserKeyPressed, alhandler

        frmTouchKeypad.Show()
    End Sub

    Private Sub txtLockerNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLockerNumber.TextChanged
        If Not txtLockerNumber.Enabled Then
            AssignLocker()
        End If

    End Sub

    Private Sub btnShareLocker_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShareLocker.Click
        lockerNumber = -1
        frmSales.LockerNumber = lockerNumber
        txtLockerNumber.Text = ""
        txtRFID.Text = ""
        Me.Close()
    End Sub

    Private Sub touchKeyPressed(ByVal sender As Object, ByVal e As frmTouchKeypad.KeypadEventArgs)

        If String.Compare(e.KeyboardPressed, "{ENTER}") = 0 Then
            AssignLocker()
        Else

            SendKeys.Send(e.KeyboardPressed)
        End If

    End Sub

    Private Sub frmsLocker_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        CloseForm()
    End Sub

    Private Sub CloseForm()
        If (frmTouchKeypad.IsHandleCreated) Then
            RemoveHandler frmTouchKeypad.UserKeyPressed, alhandler

            frmTouchKeypad.Close()
        End If
    End Sub

    Private Sub AssignLocker()
        If RegisterLocker() = False Then
            MsgBox("Invalid Token")
        Else
            frmSales.LockerNumber = lockerNumber
            txtLockerNumber.Text = ""
            txtRFID.Text = ""
            Me.Close()
        End If

    End Sub
End Class