Public Class keyboard
    Private vTarget As Object = Nothing
    
    Private vData As String = ""
    Public Property Target As Object
        Get
            Return vTarget
        End Get
        Set(ByVal value As Object)
            vTarget = value
        End Set
    End Property
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

                'check if there is target and is a textbox control
                If Not vTarget Is Nothing Then
                    If TypeOf vTarget Is TextBox Then
                        Dim vTextbox As TextBox = DirectCast(vTarget, TextBox)
                        vTextbox.Text += value
                    End If
                End If
            End If
        End Set
    End Property

    Public Sub KeyboardMouseUp(ByVal sender As Object, ByVal e As EventArgs) Handles _
        btn0.MouseUp, btn1.MouseUp, btn2.MouseUp, btn3.MouseUp, btn4.MouseUp, btn5.MouseUp, _
        btn6.MouseUp, btn7.MouseUp, btn8.MouseUp, btn9.MouseUp
        If sender Is btn0 And vData = "0" Then
            Exit Sub
        End If
        Data += sender.text
    End Sub

    Private Sub keyboard_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        vTarget = Nothing

    End Sub

    Private Sub keyboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    

End Class