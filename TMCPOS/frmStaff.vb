Public Class frmStaff
    Dim alhandler As frmTouchKeyboard.KeyboardHandler = AddressOf touchKeyPressed
    Dim noOfSeconds As Integer
    Dim startDate As New DateTime(1970, 1, 1)

    Private Sub frmStaff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        UpdateClockTime()
        txtUsername.Focus()

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


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        UpdateClockTime()


    End Sub

    Private Sub btnClock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClock.Click

        If ValidateLogin() Then
            TimerResetClockBtnColor.Interval = 500
            TimerResetClockBtnColor.Enabled = True
            btnClock.BackColor = Color.LimeGreen
            lblTimeInSeconds.Text = startDate.AddSeconds(noOfSeconds)
        End If

    End Sub

    Private Sub UpdateClockTime()
        Dim currentDate As Date = Now
        lblTimeNow.Text = Format(currentDate, "HH:mm:ss tt")


        noOfSeconds = (currentDate - startDate).TotalSeconds
    End Sub
    Private Function ValidateLogin()
        If (Not String.IsNullOrEmpty(txtUsername.Text)) And (Not String.IsNullOrEmpty(txtPassword.Text)) Then

            txtUsername.Text = ""
            txtPassword.Text = ""
            Return True

        End If

        Return False
    End Function

    Private Sub TimerResetClockBtnColor_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerResetClockBtnColor.Tick
        TimerResetClockBtnColor.Enabled = False
        btnClock.BackColor = Color.Red
    End Sub
End Class