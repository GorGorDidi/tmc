Public Class frmSalesItem1

    Private Sub frmSalesItem1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Button Text & Alignment
        Me.btnMember.Text = "Member" & Environment.NewLine & "$10"
        Me.btnMember.TextAlign = ContentAlignment.MiddleCenter
        Me.btnWalkin15.Text = "Walk-In" & Environment.NewLine & "$15"
        Me.btnWalkin15.TextAlign = ContentAlignment.MiddleCenter
        Me.btnWalkin12.Text = "Walk-In" & Environment.NewLine & "$12"
        Me.btnWalkin12.TextAlign = ContentAlignment.MiddleCenter
        Me.btn10DaysPass.Text = "10 Pass" & Environment.NewLine & "$88"
        Me.btn10DaysPass.TextAlign = ContentAlignment.MiddleCenter
        Me.btnMineralWater.Text = "Mineral Water" & Environment.NewLine & "$1"
        Me.btnMineralWater.TextAlign = ContentAlignment.MiddleCenter

    End Sub

    Private Sub btnMember_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMember.Click
        frmsMember.Show()
    End Sub

    Private Sub btnWalkin15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWalkin15.Click
        frmSales.LoadSaleListForm()
        frmSales.LockerNumber = 0
        frmsLocker.ShowDialog()
        If frmSales.LockerNumber > 0 Then
            frmSalesList.AddItemToSales(15, "Walk-In Member $15 Locker No. " + frmSales.LockerNumber.ToString)
        ElseIf frmSales.LockerNumber < 0 Then
            frmSalesList.AddItemToSales(15, "Walk-In Member $15 (Share Locker)")
        End If
    End Sub

    Private Sub btnWalkin12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWalkin12.Click
        frmSales.LoadSaleListForm()
        frmSales.LockerNumber = 0
        frmsLocker.ShowDialog()
        If frmSales.LockerNumber > 0 Then
            frmSalesList.AddItemToSales(12, "Walk-In Member $12 Locker No. " + frmSales.LockerNumber.ToString)
        ElseIf frmSales.LockerNumber < 0 Then
            frmSalesList.AddItemToSales(12, "Walk-In Member $12 (Share Locker)")
        End If
    End Sub

    Private Sub btn10DaysPass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn10DaysPass.Click
        frmSales.LoadSaleListForm()
        frmSalesList.AddItemToSales(88, "10 Days Pass")
    End Sub

    Private Sub btnSoda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSoda.Click
        frmSales.LoadSaleListForm()
        frmSalesList.AddItemToSales(1.8, "Soda Drink")
    End Sub

    
    Private Sub frmSalesItem1_SizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.SizeChanged
        ' position
        btnMember.Left = Convert.ToInt16(Me.Width * 6 / 668)
        btnMember.Top = Convert.ToInt16(Me.Height * 10 / 633)
        btnWalkin15.Left = Convert.ToInt16(Me.Width * 148 / 668)
        btnWalkin15.Top = Convert.ToInt16(Me.Height * 10 / 633)
        btnWalkin12.Left = Convert.ToInt16(Me.Width * 290 / 668)
        btnWalkin12.Top = Convert.ToInt16(Me.Height * 10 / 633)
        btn10DaysPass.Left = Convert.ToInt16(Me.Width * 6 / 668)
        btn10DaysPass.Top = Convert.ToInt16(Me.Height * 134 / 633)
        btnSoda.Left = Convert.ToInt16(Me.Width * 6 / 668)
        btnSoda.Top = Convert.ToInt16(Me.Height * 237 / 633)
        btnNonSoda.Left = Convert.ToInt16(Me.Width * 148 / 668)
        btnNonSoda.Top = Convert.ToInt16(Me.Height * 237 / 633)
        btnBeer.Left = Convert.ToInt16(Me.Width * 290 / 668)
        btnBeer.Top = Convert.ToInt16(Me.Height * 237 / 633)
        btnMineralWater.Left = Convert.ToInt16(Me.Width * 432 / 668)
        btnMineralWater.Top = Convert.ToInt16(Me.Height * 237 / 633)

        'size
        btnMember.Width = Convert.ToInt16(Me.Width * 136 / 668)
        btnMember.Height = Convert.ToInt16(Me.Height * 97 / 633)
        btnWalkin15.Width = Convert.ToInt16(Me.Width * 136 / 668)
        btnWalkin15.Height = Convert.ToInt16(Me.Height * 97 / 633)
        btnWalkin12.Width = Convert.ToInt16(Me.Width * 136 / 668)
        btnWalkin12.Height = Convert.ToInt16(Me.Height * 97 / 633)
        btn10DaysPass.Width = Convert.ToInt16(Me.Width * 136 / 668)
        btn10DaysPass.Height = Convert.ToInt16(Me.Height * 97 / 633)
        btnSoda.Width = Convert.ToInt16(Me.Width * 136 / 668)
        btnSoda.Height = Convert.ToInt16(Me.Height * 97 / 633)
        btnNonSoda.Width = Convert.ToInt16(Me.Width * 136 / 668)
        btnNonSoda.Height = Convert.ToInt16(Me.Height * 97 / 633)
        btnBeer.Width = Convert.ToInt16(Me.Width * 136 / 668)
        btnBeer.Height = Convert.ToInt16(Me.Height * 97 / 633)
        btnMineralWater.Width = Convert.ToInt16(Me.Width * 136 / 668)
        btnMineralWater.Height = Convert.ToInt16(Me.Height * 97 / 633)

    End Sub
End Class