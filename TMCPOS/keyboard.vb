Public Class keyboard
    Private vData As String = ""
    Public Property Data As String
        Get
            Return vData
        End Get
        Set(ByVal value As String)
            vData = value
            If value = "" Then
                txtTest.Text = ""
            Else
                txtTest.Text = value
            End If
        End Set
    End Property

    Public Sub KeyboardMouseUp(ByVal sender As Object, ByVal e As EventArgs) Handles _
        btn0.MouseUp, btn1.MouseUp, btn2.MouseUp, btn3.MouseUp, btn4.MouseUp, btn5.MouseUp, btn6.MouseUp, btn7.MouseUp, btn8.MouseUp, btn9.MouseUp
        If sender Is btn0 And vData = "0" Then
            Exit Sub
        End If
        Data += sender.text
    End Sub
End Class