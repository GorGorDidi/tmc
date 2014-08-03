Public Class frmTouchKeyboard
    Private shiftIndicator As Boolean = False
    Private caplockIndicator As Boolean = False

    Private vTarget As Object = Nothing
    Private pvtKeyboardKeyPressed As String = ""

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


    Public Delegate Sub KeyboardHandler(ByVal sender As Object, ByVal e As KeyboardEventArgs)
    Public Event UserKeyPressed As KeyboardHandler

    Private Sub OnUserKeyPressed(ByVal e As KeyboardEventArgs)
        RaiseEvent UserKeyPressed(Me, e)
    End Sub

    Public Class KeyboardEventArgs
        Inherits System.EventArgs

        Private _pvtKeyboardKeyPressed As String

        Sub New(ByVal pvtKeyboardKeyPressed As String)
            ' TODO: Complete member initialization 
            _pvtKeyboardKeyPressed = pvtKeyboardKeyPressed
        End Sub

        Public Property KeyboardPressed() As String
            Get
                Return _pvtKeyboardKeyPressed

            End Get
            Set(ByVal value As String)
                _pvtKeyboardKeyPressed = value
            End Set
        End Property

    End Class

    Private Function HandleTheMouseClick(ByVal p As Point) As String
        Dim keypressed As String = ""
        txtTest2.Text = p.X.ToString() + " " + p.Y.ToString()
        If (p.X > 18 And p.X < 1009 And p.Y > 17 And p.Y < 328) Then

            If (p.Y < 58) Then
                If (p.X >= 18 And p.X < 60) Then
                    keypressed = HandleShiftableKey("`")
                ElseIf (p.X > 85 And p.X < 127) Then
                    keypressed = HandleShiftableKey("1")
                ElseIf (p.X > 152 And p.X < 194) Then
                    keypressed = HandleShiftableKey("2")
                ElseIf (p.X > 219 And p.X < 261) Then
                    keypressed = HandleShiftableKey("3")
                ElseIf (p.X > 286 And p.X < 328) Then
                    keypressed = HandleShiftableKey("4")
                ElseIf (p.X > 353 And p.X < 395) Then
                    keypressed = HandleShiftableKey("5")
                ElseIf (p.X > 420 And p.X < 462) Then
                    keypressed = HandleShiftableKey("6")
                ElseIf (p.X > 487 And p.X < 529) Then
                    keypressed = HandleShiftableKey("7")
                ElseIf (p.X > 554 And p.X < 596) Then
                    keypressed = HandleShiftableKey("8")
                ElseIf (p.X > 621 And p.X < 663) Then
                    keypressed = HandleShiftableKey("9")
                ElseIf (p.X > 688 And p.X < 730) Then
                    keypressed = HandleShiftableKey("0")
                ElseIf (p.X > 755 And p.X < 797) Then
                    keypressed = HandleShiftableKey("-")
                ElseIf (p.X > 822 And p.X < 864) Then
                    keypressed = HandleShiftableKey("=")
                ElseIf (p.X > 889 And p.X < 1011) Then
                    keypressed = "{BACKSPACE}"
                Else
                    keypressed = ""
                End If

            ElseIf (p.Y > 79 And p.Y < 127) Then
                If (p.X > 119 And p.X < 163) Then
                    keypressed = HandleShiftableCaplockableKey("q")
                ElseIf (p.X > 186 And p.X < 230) Then
                    keypressed = HandleShiftableCaplockableKey("w")
                ElseIf (p.X > 253 And p.X < 297) Then
                    keypressed = HandleShiftableCaplockableKey("e")
                ElseIf (p.X > 320 And p.X < 364) Then
                    keypressed = HandleShiftableCaplockableKey("r")
                ElseIf (p.X > 387 And p.X < 431) Then
                    keypressed = HandleShiftableCaplockableKey("t")
                ElseIf (p.X > 454 And p.X < 498) Then
                    keypressed = HandleShiftableCaplockableKey("y")
                ElseIf (p.X > 521 And p.X < 565) Then
                    keypressed = HandleShiftableCaplockableKey("u")
                ElseIf (p.X > 588 And p.X < 632) Then
                    keypressed = HandleShiftableCaplockableKey("i")
                ElseIf (p.X > 655 And p.X < 699) Then
                    keypressed = HandleShiftableCaplockableKey("o")
                ElseIf (p.X > 722 And p.X < 766) Then
                    keypressed = HandleShiftableCaplockableKey("p")
                ElseIf (p.X > 789 And p.X < 833) Then
                    keypressed = HandleShiftableKey("{[}")
                ElseIf (p.X > 856 And p.X < 900) Then
                    keypressed = HandleShiftableKey("{]}")
                Else
                    keypressed = ""
                End If
            ElseIf (p.Y > 147 And p.Y < 193) Then
                If (p.X >= 18 And p.X < 124) Then
                    HandleCapsLock()
                ElseIf (p.X > 154 And p.X < 199) Then
                    keypressed = HandleShiftableCaplockableKey("a")
                ElseIf (p.X > 221 And p.X < 266) Then
                    keypressed = HandleShiftableCaplockableKey("s")
                ElseIf (p.X > 288 And p.X < 333) Then
                    keypressed = HandleShiftableCaplockableKey("d")
                ElseIf (p.X > 355 And p.X < 400) Then
                    keypressed = HandleShiftableCaplockableKey("f")
                ElseIf (p.X > 422 And p.X < 467) Then
                    keypressed = HandleShiftableCaplockableKey("g")
                ElseIf (p.X > 489 And p.X < 534) Then
                    keypressed = HandleShiftableCaplockableKey("h")
                ElseIf (p.X > 556 And p.X < 601) Then
                    keypressed = HandleShiftableCaplockableKey("j")
                ElseIf (p.X > 623 And p.X < 668) Then
                    keypressed = HandleShiftableCaplockableKey("k")
                ElseIf (p.X > 690 And p.X < 735) Then
                    keypressed = HandleShiftableCaplockableKey("l")
                ElseIf (p.X > 757 And p.X < 802) Then
                    keypressed = HandleShiftableKey(";")
                ElseIf (p.X > 824 And p.X < 869) Then
                    keypressed = HandleShiftableKey("'")
                ElseIf (p.X > 891 And p.X < 1011) Then
                    keypressed = "{ENTER}"
                Else
                    keypressed = ""
                End If
            ElseIf (p.Y > 213 And p.Y < 260) Then
                If (p.X >= 18 And p.X < 163) Then
                    HandleShiftClick()
                ElseIf (p.X > 188 And p.X < 233) Then
                    keypressed = HandleShiftableCaplockableKey("z")
                ElseIf (p.X > 255 And p.X < 300) Then
                    keypressed = HandleShiftableCaplockableKey("x")
                ElseIf (p.X > 322 And p.X < 367) Then
                    keypressed = HandleShiftableCaplockableKey("c")
                ElseIf (p.X > 389 And p.X < 434) Then
                    keypressed = HandleShiftableCaplockableKey("v")
                ElseIf (p.X > 456 And p.X < 501) Then
                    keypressed = HandleShiftableCaplockableKey("b")
                ElseIf (p.X > 523 And p.X < 568) Then
                    keypressed = HandleShiftableCaplockableKey("n")
                ElseIf (p.X > 590 And p.X < 635) Then
                    keypressed = HandleShiftableCaplockableKey("m")
                ElseIf (p.X > 657 And p.X < 702) Then
                    keypressed = HandleShiftableCaplockableKey(",")
                ElseIf (p.X > 724 And p.X < 769) Then
                    keypressed = HandleShiftableCaplockableKey(".")
                ElseIf (p.X > 791 And p.X < 836) Then
                    keypressed = HandleShiftableCaplockableKey("/")
                ElseIf (p.X > 858 And p.X < 1011) Then
                    HandleShiftClick()
                Else
                    keypressed = ""
                End If
            ElseIf (p.Y > 280 And p.Y < 328) Then
                If (p.X >= 287 And p.X < 736) Then
                    keypressed = " "
                Else
                    keypressed = ""
                End If
            End If

        ElseIf (p.X > 1050 And p.X < 1228 And p.Y > 43 And p.Y < 224) Then
            If (p.Y < 90) Then
                If (p.X < 1094) Then
                    keypressed = "{INSERT}"
                ElseIf (p.X > 1117 And p.X < 1161) Then
                    keypressed = "{UP}"
                ElseIf (p.X > 1184 And p.X < 1228) Then
                    keypressed = HandleShiftableKey("{HOME}")
                Else
                    keypressed = ""
                End If
            ElseIf (p.Y > 109 And p.Y < 156) Then
                If (p.X < 1094) Then
                    keypressed = "{LEFT}"
                ElseIf (p.X > 1184 And p.X < 1228) Then
                    keypressed = "{RIGHT}"
                Else
                    keypressed = ""
                End If
            ElseIf (p.Y > 176 And p.Y < 224) Then
                If (p.X < 1094) Then
                    keypressed = "{DELETE}"
                ElseIf (p.X > 1117 And p.X < 1161) Then
                    keypressed = "{DOWN}"
                ElseIf (p.X > 1184 And p.X < 1228) Then
                    keypressed = HandleShiftableKey("{END}")
                Else
                    keypressed = ""
                End If
            Else
                keypressed = ""
            End If
        End If

        If String.IsNullOrEmpty(keypressed) Then
            Return keypressed
        Else

            If shiftIndicator Then
                HandleShiftClick()
            End If

            Return keypressed
        End If
        

    End Function

    Private Sub imgKeyboard_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles imgKeyboard.MouseClick
        Dim mousePos As Point = New Point(e.X, e.Y)
        mousePos.X = 1248 * (mousePos.X / imgKeyboard.Width)
        mousePos.Y = 342 * (mousePos.Y / imgKeyboard.Height)

        pvtKeyboardKeyPressed = HandleTheMouseClick(mousePos)
        txtTest.Text = pvtKeyboardKeyPressed
        If Not String.IsNullOrEmpty(pvtKeyboardKeyPressed) Then
            Dim dea As KeyboardEventArgs = New KeyboardEventArgs(pvtKeyboardKeyPressed)

            OnUserKeyPressed(dea)
        End If
    End Sub

    Private Sub HandleShiftClick()
        If shiftIndicator Then
            shiftIndicator = False
            pictureBoxLeftShiftDown.Visible = False
            pictureBoxRightShiftDown.Visible = False
        Else
            shiftIndicator = True
            pictureBoxLeftShiftDown.Visible = True
            pictureBoxRightShiftDown.Visible = True
        End If
    End Sub

    Private Sub HandleCapsLock()
        If caplockIndicator Then
            caplockIndicator = False
            pictureBoxCapsLockDown.Visible = False
        Else
            caplockIndicator = True
            pictureBoxCapsLockDown.Visible = True
        End If
    End Sub

    Private Function HandleShiftableCaplockableKey(ByVal theKey As String) As String
        If caplockIndicator Then
            Return "+" + theKey
        ElseIf shiftIndicator Then
            Return "+" + theKey
        Else
            Return theKey
        End If

    End Function

    Private Function HandleShiftableKey(ByVal theKey As String) As String
        If shiftIndicator Then
            Return "+" + theKey
        Else
            Return theKey

        End If
    End Function
    

    Private Sub pictureBoxCapsLockDown_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pictureBoxCapsLockDown.MouseClick
        HandleCapsLock()
    End Sub

    

    Private Sub txtTest_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTest.TextChanged
        Data = txtTest.Text
    End Sub

    Private Sub imgKeyboard_SizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgKeyboard.SizeChanged
        ' position the capslock and shift down overlays
        pictureBoxCapsLockDown.Left = Convert.ToInt16(imgKeyboard.Width * 12 / 1248) + 6
        pictureBoxCapsLockDown.Top = Convert.ToInt16(imgKeyboard.Height * 150 / 340) + 1
        pictureBoxLeftShiftDown.Left = Convert.ToInt16(imgKeyboard.Width * 12 / 1248) + 6
        pictureBoxLeftShiftDown.Top = Convert.ToInt16(imgKeyboard.Height * 217 / 340)
        pictureBoxRightShiftDown.Left = Convert.ToInt16(imgKeyboard.Width * 867 / 1248) + 3
        pictureBoxRightShiftDown.Top = pictureBoxLeftShiftDown.Top


        ' size the capslock and shift down overlays

        pictureBoxCapsLockDown.Width = Convert.ToInt16(imgKeyboard.Width * 142 / 1248) - 4
        pictureBoxCapsLockDown.Height = Convert.ToInt16(imgKeyboard.Height * 67 / 342)
        pictureBoxLeftShiftDown.Width = Convert.ToInt16(imgKeyboard.Width * 177 / 1248) - 4
        pictureBoxLeftShiftDown.Height = Convert.ToInt16(imgKeyboard.Height * 67 / 342)
        pictureBoxRightShiftDown.Width = Convert.ToInt16(imgKeyboard.Width * 169 / 1248) + 1
        pictureBoxRightShiftDown.Height = pictureBoxLeftShiftDown.Height
    End Sub
End Class