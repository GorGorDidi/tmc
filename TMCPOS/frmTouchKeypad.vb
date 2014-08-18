Public Class frmTouchKeypad
    Private pvtKeypadKeyPressed As String = ""
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

                'check if there is target and is a textbox control
                If Not vTarget Is Nothing Then
                    If TypeOf vTarget Is TextBox Then
                        Dim vTextbox As TextBox = DirectCast(vTarget, TextBox)
                        vTextbox.Text = value
                        vTextbox.SelectionStart = vTextbox.Text.Length
                        vTextbox.ScrollToCaret()
                    End If
                End If
            End If
        End Set
    End Property


    Public Delegate Sub KeypadHandler(ByVal sender As Object, ByVal e As KeypadEventArgs)
    Public Event UserKeyPressed As KeypadHandler

    Private Sub OnUserKeyPressed(ByVal e As KeypadEventArgs)
        RaiseEvent UserKeyPressed(Me, e)
    End Sub

    Public Class KeypadEventArgs
        Inherits System.EventArgs

        Private _pvtKeypadKeyPressed As String

        Sub New(ByVal pvtKeypadKeyPressed As String)
            ' TODO: Complete member initialization 
            _pvtKeypadKeyPressed = pvtKeypadKeyPressed
        End Sub

        Public Property KeyboardPressed() As String
            Get
                Return _pvtKeypadKeyPressed

            End Get
            Set(ByVal value As String)
                _pvtKeypadKeyPressed = value
            End Set
        End Property

    End Class

    Private Function HandleTheMouseClick(ByVal p As Point) As String
        Dim keypressed As String = ""
        'txtTest.Text = p.X.ToString() + " " + p.Y.ToString()
        If (p.X > 7 And p.X < 470 And p.Y > 5 And p.Y < 346) Then
            If (p.Y < 83) Then
                If (p.X >= 7 And p.X < 107) Then
                    keypressed = "1"
                ElseIf (p.X >= 115 And p.X < 217) Then
                    keypressed = "2"
                ElseIf (p.X >= 225 And p.X < 327) Then
                    keypressed = "3"
                ElseIf (p.X >= 369 And p.X < 470) Then
                    keypressed = "{BACKSPACE}"
                Else
                    keypressed = ""
                End If
            ElseIf (p.Y > 92 And p.Y < 170) Then
                If (p.X >= 7 And p.X < 107) Then
                    keypressed = "4"
                ElseIf (p.X >= 115 And p.X < 217) Then
                    keypressed = "5"
                ElseIf (p.X >= 225 And p.X < 327) Then
                    keypressed = "6"
                ElseIf (p.X >= 369 And p.X < 470) Then
                    keypressed = "{ENTER}"
                Else
                    keypressed = ""
                End If
            ElseIf (p.Y > 181 And p.Y < 258) Then
                If (p.X >= 7 And p.X < 107) Then
                    keypressed = "7"
                ElseIf (p.X >= 115 And p.X < 217) Then
                    keypressed = "8"
                ElseIf (p.X >= 225 And p.X < 327) Then
                    keypressed = "9"
                Else
                    keypressed = ""
                End If
            ElseIf (p.Y > 268 And p.Y < 346) Then
                If (p.X >= 7 And p.X < 217) Then
                    keypressed = "0"
                ElseIf (p.X >= 225 And p.X < 327) Then
                    keypressed = "."
                Else
                    keypressed = ""
                End If
            End If
        
        End If

        Return keypressed

    End Function

    Private Sub imgKeypad_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles imgKeypad.MouseClick
        Dim mousePos As Point = New Point(e.X, e.Y)
        mousePos.X = 480 * (mousePos.X / imgKeypad.Width)
        mousePos.Y = 373 * (mousePos.Y / imgKeypad.Height)

        pvtKeypadKeyPressed = HandleTheMouseClick(mousePos)
        'txtTest.Text = pvtKeypadKeyPressed
        If Not String.IsNullOrEmpty(pvtKeypadKeyPressed) Then
            
                Dim dea As KeypadEventArgs = New KeypadEventArgs(pvtKeypadKeyPressed)

                OnUserKeyPressed(dea)


        End If
    End Sub


    Private Sub txtTest_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTest.TextChanged
        Data = txtTest.Text
    End Sub
End Class