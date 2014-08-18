Public Class frmSalesSummary
    Public Sub ClearList()
        ListBoxSalesSummary.Items.Clear()


    End Sub

    Public Sub AddToList(ByRef item As String)
        ListBoxSalesSummary.Items.Add(item)
    End Sub

    Private Sub frmSalesSummary_SizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.SizeChanged
        ' position
        ListBoxSalesSummary.Left = Convert.ToInt16(Me.Width * 12 / 345)
        ListBoxSalesSummary.Top = Convert.ToInt16(Me.Height * 12 / 629)

        'size
        ListBoxSalesSummary.Width = Convert.ToInt16(Me.Width * 330 / 345)
        ListBoxSalesSummary.Height = Convert.ToInt16(Me.Height * 498 / 629)
    End Sub


End Class