Public Class frmPayment
    Private vData As String = ""
    Public Property Data As String
        Get
            Return vData
        End Get
        Set(ByVal value As String)
            vData = value
            If value = "" Then
                txtPayment.Text = "0"
            Else
                txtPayment.Text = value
            End If
        End Set
    End Property
    Private vAllowNegatives As Boolean = False
    Public Property AllowNegatives As Boolean
        Get
            Return vAllowNegatives
        End Get
        Set(ByVal value As Boolean)
            vAllowNegatives = value
            btnNegative.Visible = value
            If Data.Substring(0, 1) = "-" And value = False Then
                Data = Data.Substring(1, Data.Length - 1)
            End If
        End Set
    End Property
    Private vAllowDecimals As Boolean = False
    Public Property AllowDecimals As Boolean
        Get
            Return vAllowDecimals
        End Get
        Set(ByVal value As Boolean)
            vAllowDecimals = value
            btnKeyDot.Visible = value
            If Data.Contains(".") And value = False Then
                Data = Math.Round(Val(Data), 0).ToString
            End If
        End Set
    End Property
    Public Sub NumericMouseUp(ByVal sender As Object, ByVal e As EventArgs) Handles btnKey0.MouseUp, btnBackspace.MouseUp, btnKey2.MouseUp, btnKey3.MouseUp, btnKey4.MouseUp, btnKey5.MouseUp, btnKey6.MouseUp, btnKey7.MouseUp, btnKey8.MouseUp, btnKey9.MouseUp
        If sender Is btnKey0 And vData = "0" Then
            Exit Sub
        End If
        Data += sender.text
    End Sub
    Private Sub frmPayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pKeypad.Hide()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Data = ""
    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnPass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPass.Click
        Me.Close()
    End Sub

    Private Sub btnCash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCash.Click
        pKeypad.Show()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnEzlink_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEzlink.Click
        Me.Close()
    End Sub
    Private Sub btnKeyDot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyDot.Click
        If Data.Contains(".") = False Then
            Data += "."
        End If
    End Sub

    Private Sub btnNegative_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNegative.Click
        If Data.Contains("-") = False Then
            Data = "-" + Data
        Else
            Data = Data.Substring(1, Data.Length - 1)
        End If
    End Sub

    Private Sub btnBackspace_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackspace.Click
        If Data.Length = 0 Then
            Data = ""
        Else
            Data = Data.Substring(0, Data.Length - 1)
        End If
    End Sub
End Class