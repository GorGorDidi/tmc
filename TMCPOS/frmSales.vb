Public Class frmSales
    Dim CurrentSalesInformationPanelForm As Form = Nothing
    Dim CurrentSalesItemPanelForm As Form = Nothing
    Private vPaymentSucceed As Boolean = False
    Public Property PaymentSucceed As Boolean
        Get
            Return vPaymentSucceed
        End Get
        Set(ByVal value As Boolean)
            vPaymentSucceed = value
        End Set
    End Property

    Private vLockerNumber As Integer = 0
    Public Property LockerNumber As Integer
        Get
            Return vLockerNumber
        End Get
        Set(ByVal value As Integer)
            vLockerNumber = value
        End Set
    End Property

    'Private vTotal As Decimal = 0.0
    'Public Property Total As Decimal
    '    Get
    '        Return vTotal
    '    End Get
    '    Set(ByVal value As Decimal)
    '        vTotal = value
    '        lblTotal.Text = value.ToString()
    '    End Set
    'End Property
    'Private Sub btnMember_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMember.Click
    '    frmsMember.Show()
    'End Sub

    'Private Sub btnFinishandPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinishandPay.Click
    '    btnVoid.Enabled = False
    '    frmPayment.ShowDialog()
    '    If vPaymentSucceed Then
    '        dgvSalesSummary.Rows.Clear()

    '    End If
    '    btnVoid.Enabled = True

    'End Sub

    Private Sub ClearCurrentSalesInformationPanelForm()
        If Not (CurrentSalesInformationPanelForm Is Nothing) Then
            CurrentSalesInformationPanelForm.Parent = Nothing
            CurrentSalesInformationPanelForm.Hide()
        End If
    End Sub

    Private Sub ClearCurrentSalesItemPanelForm()
        If Not (CurrentSalesItemPanelForm Is Nothing) Then
            CurrentSalesItemPanelForm.Parent = Nothing
            CurrentSalesItemPanelForm.Hide()
        End If
    End Sub

    Private Sub frmSales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''Button Text & Alignment
        'Me.btnMember.Text = "Member" & Environment.NewLine & "$10"
        'Me.btnMember.TextAlign = ContentAlignment.MiddleCenter
        'Me.btnWalkin15.Text = "Walk-In" & Environment.NewLine & "$15"
        'Me.btnWalkin15.TextAlign = ContentAlignment.MiddleCenter
        'Me.btnWalkin12.Text = "Walk-In" & Environment.NewLine & "$12"
        'Me.btnWalkin12.TextAlign = ContentAlignment.MiddleCenter
        'Me.btn10DaysPass.Text = "10 Pass" & Environment.NewLine & "$88"
        'Me.btn10DaysPass.TextAlign = ContentAlignment.MiddleCenter
        'Me.btnMineralWater.Text = "Mineral Water" & Environment.NewLine & "$1"
        'Me.btnMineralWater.TextAlign = ContentAlignment.MiddleCenter
        LoadSalesItemForm()
        LoadSaleListForm()
    End Sub
    'Function DGVCount() As DataGridViewRow
    '    Dim i As Integer
    '    i = dgvSalesSummary.RowCount - 1
    '    Dim newrow As New DataGridViewRow
    '    Dim SOnewrow As New DataGridViewRow
    '    newrow.CreateCells(dgvSalesSummary)
    '    Return newrow
    'End Function

    'Private Sub AddItem(ByVal itemvalue As Decimal, ByVal itemtext As String)
    '    Dim row As DataGridViewRow
    '    row = DGVCount()
    '    row.SetValues(itemtext)
    '    dgvSalesSummary.Rows.Add(row)

    '    Total = vTotal + itemvalue
    'End Sub

    'Private Sub btnWalkin15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWalkin15.Click
    '    LoadSaleListForm()
    '    vLockerNumber = 0
    '    frmsLocker.ShowDialog()
    '    If vLockerNumber > 0 Then
    '        frmSalesList.AddItemToSales(15, "Walk-In Member $15 Locker No. " + vLockerNumber.ToString)
    '    ElseIf vLockerNumber < 0 Then
    '        frmSalesList.AddItemToSales(15, "Walk-In Member $15 (Share Locker)")
    '    End If
    'End Sub

    'Private Sub btnWalkin12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWalkin12.Click
    '    LoadSaleListForm()
    '    vLockerNumber = 0
    '    frmsLocker.ShowDialog()
    '    If vLockerNumber > 0 Then
    '        frmSalesList.AddItemToSales(12, "Walk-In Member $12 Locker No. " + vLockerNumber.ToString)
    '    ElseIf vLockerNumber < 0 Then
    '        frmSalesList.AddItemToSales(12, "Walk-In Member $12 (Share Locker)")
    '    End If
    'End Sub

    'Private Sub btn10DaysPass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn10DaysPass.Click
    '    LoadSaleListForm()
    '    frmSalesList.AddItemToSales(88, "10 Days Pass")
    'End Sub

    'Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
    '    LoadSaleListForm()
    '    frmSalesList.AddItemToSales(1.8, "Soda Drink")
    'End Sub

    'Private Sub btnVoid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoid.Click
    '    If dgvSalesSummary.SelectedRows.Count > 0 Then
    '        dgvSalesSummary.Rows.Remove(dgvSalesSummary.SelectedRows(0))
    '    End If

    'End Sub

    'Public Sub AddItemToSales(ByVal itemvalue As Decimal, ByVal itemtext As String)
    '    AddItem(itemvalue, itemtext)
    'End Sub
    Public Sub LoadSalesItemForm()
        If Not frmSalesItem1.Visible Then
            ClearCurrentSalesItemPanelForm()
            frmSalesItem1.TopLevel = False
            frmSalesItem1.Location = New Point(0, 0)
            frmSalesItem1.Parent = PanelSalesItem
            CurrentSalesItemPanelForm = frmSalesItem1

            frmSalesItem1.Show()

        End If
    End Sub

    Public Sub LoadSaleListForm()
        If Not frmSalesList.Visible Then
            ClearCurrentSalesInformationPanelForm()
            frmSalesList.TopLevel = False
            frmSalesList.Location = New Point(0, 0)
            frmSalesList.Parent = PanelSalesContainer
            CurrentSalesInformationPanelForm = frmSalesList

            frmSalesList.Show()

        End If

    End Sub

    Public Sub SalesCompleted()
        ClearCurrentSalesInformationPanelForm()
        frmSalesSummary.TopLevel = False
        frmSalesSummary.Location = New Point(0, 0)
        frmSalesSummary.Parent = PanelSalesContainer
        CurrentSalesInformationPanelForm = frmSalesSummary
        frmSalesSummary.Show()

    End Sub

End Class