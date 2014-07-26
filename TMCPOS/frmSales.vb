Public Class frmSales
    Private vLockerNumber As Integer = 0
    Public Property LockerNumber As Integer
        Get
            Return vLockerNumber
        End Get
        Set(ByVal value As Integer)
            vLockerNumber = value
        End Set
    End Property

    Private vTotal As Decimal = 0.0
    Public Property Total As Decimal
        Get
            Return vTotal
        End Get
        Set(ByVal value As Decimal)
            vTotal = value
            lblTotal.Text = value.ToString()
        End Set
    End Property
    Private Sub btnMember_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMember.Click
        frmsMember.Show()
    End Sub

    Private Sub btnFinishandPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinishandPay.Click
        frmPayment.Show()
    End Sub

    Private Sub frmSales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
    Function DGVCount() As DataGridViewRow
        Dim i As Integer
        i = dgvSalesSummary.RowCount - 1
        Dim newrow As New DataGridViewRow
        Dim SOnewrow As New DataGridViewRow
        newrow.CreateCells(dgvSalesSummary)
        Return newrow
    End Function

    Private Sub AddItem(ByVal itemvalue As Decimal, ByVal itemtext As String)
        Dim row As DataGridViewRow
        row = DGVCount()
        row.SetValues(itemtext)
        dgvSalesSummary.Rows.Add(row)

        Total = vTotal + itemvalue
    End Sub

    Private Sub btnWalkin15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWalkin15.Click
        vLockerNumber = 0
        frmsLocker.ShowDialog()
        If vLockerNumber > 0 Then
            AddItem(15, "Walk-In Member $15 Locker No. " + vLockerNumber.ToString)
        ElseIf vLockerNumber < 0 Then
            AddItem(15, "Walk-In Member $15 (Share Locker)")
        End If
    End Sub

    Private Sub btnWalkin12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWalkin12.Click
        vLockerNumber = 0
        frmsLocker.ShowDialog()
        If vLockerNumber > 0 Then
            AddItem(12, "Walk-In Member $12 Locker No. " + vLockerNumber.ToString)
        ElseIf vLockerNumber < 0 Then
            AddItem(12, "Walk-In Member $12 (Share Locker)")
        End If
    End Sub

    Private Sub btn10DaysPass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn10DaysPass.Click
        AddItem(88, "10 Days Pass")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        AddItem(1.8, "Soda Drink")
    End Sub

    Private Sub btnVoid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoid.Click
        dgvSalesSummary.Rows.Remove(dgvSalesSummary.SelectedRows(0))
    End Sub
End Class