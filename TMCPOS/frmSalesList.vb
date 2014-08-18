Imports MySql.Data.MySqlClient
Public Class frmSalesList
    Dim MysqlConn As MySqlConnection
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

    Private Sub PostSales()
        MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=203.175.174.208; user id=tenmensc_admin; password=TMCadmin2014; database=tenmensc_tmcpos;"
        MysqlConn.Open()
        Dim myAdapter As New MySqlDataAdapter
        Dim sqlquerry = "INSERT INTO `sales`(`itemID`, `staffID`, `memberID`, `salesPaymentType`, `salesQuantity`) VALUES ([value-2],[value-3],[value-4],[value-5],[value-6])"
        Dim myCommand As New MySqlCommand()
        myCommand.Connection = MysqlConn
        myCommand.CommandText = sqlquerry
        'Starting The Query
        myCommand.ExecuteNonQuery()
    End Sub

    Public Sub AddItemToSales(ByVal itemvalue As Decimal, ByVal itemtext As String)
        AddItem(itemvalue, itemtext)
    End Sub

    Function DGVCount() As DataGridViewRow
        Dim i As Integer
        i = dgvSalesSummary.RowCount - 1
        Dim newrow As New DataGridViewRow
        Dim SOnewrow As New DataGridViewRow
        newrow.CreateCells(dgvSalesSummary)
        Return newrow
    End Function

    Private Sub btnFinishandPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinishandPay.Click
        btnVoid.Enabled = False
        frmPayment.ShowDialog()
        If frmSales.PaymentSucceed Then
            Dim i As Integer
            i = dgvSalesSummary.RowCount - 1
            frmSalesSummary.AddToList(dgvSalesSummary.Rows(0).Cells(0).ToString())

            MysqlConn = New MySqlConnection()
            MysqlConn.ConnectionString = "server=203.175.174.208; user id=tenmensc_admin; password=TMCadmin2014; database=tenmensc_tmcpos;"
            MysqlConn.Open()

            Dim itemID As Integer = 1
            Dim staffID As Integer = frmMain.Staff
            Dim memberID As Integer = vbNull
            Dim salesPaymentType As String = "Cash"
            Dim salesQuantity As Integer = 1


            Dim cmd As New MySqlCommand
            For i = 0 To dgvSalesSummary.RowCount - 1
                With dgvSalesSummary
                    'itemID = .Rows(i).Cells(0).Value
                    'staffID = .Rows(i).Cells(1).Value
                    'memberID = .Rows(i).Cells(3).Value
                    'salesPaymentType = .Rows(i).Cells(2).Value
                    'salesQuantity = .Rows(i).Cells(4).Value
                End With

                With cmd
                    .CommandType = CommandType.Text
                    .CommandText = "INSERT INTO `sales`(`itemID`, `staffID`, `memberID`, `salesPaymentType`, `salesQuantity`) VALUES  (" & itemID & ", " & staffID & ", " & memberID & ", '" + salesPaymentType + "', " & salesQuantity & ")"
                    .Connection = MysqlConn
                    cmd = New MySqlCommand(.CommandText, MysqlConn)
                End With
                cmd.ExecuteNonQuery()
            Next



            dgvSalesSummary.Rows.Clear()
            frmSales.SalesCompleted()
        End If
        btnVoid.Enabled = True
    End Sub

    Private Sub btnVoid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoid.Click
        If dgvSalesSummary.SelectedRows.Count > 0 Then
            dgvSalesSummary.Rows.Remove(dgvSalesSummary.SelectedRows(0))
        End If
    End Sub

    Private Sub AddItem(ByVal itemvalue As Decimal, ByVal itemtext As String)
        Dim row As DataGridViewRow
        row = DGVCount()
        row.SetValues(itemtext)
        dgvSalesSummary.Rows.Add(row)

        Total = vTotal + itemvalue
    End Sub


    Private Sub frmSalesList_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        Total = 0
    End Sub

    Private Sub frmSalesList_SizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.SizeChanged
        ' position
        dgvSalesSummary.Left = Convert.ToInt16(Me.Width * 7 / 345)
        dgvSalesSummary.Top = Convert.ToInt16(Me.Height * 2 / 629)
        lblTextTotal.Left = Convert.ToInt16(Me.Width * 0 / 345)
        lblTextTotal.Top = Convert.ToInt16(Me.Height * 377 / 629)
        lblTotal.Left = Convert.ToInt16(Me.Width * 284 / 345)
        lblTotal.Top = Convert.ToInt16(Me.Height * 377 / 629)
        btnFinishandPay.Left = Convert.ToInt16(Me.Width * 3 / 345)
        btnFinishandPay.Top = Convert.ToInt16(Me.Height * 444 / 629)
        btnVoid.Left = Convert.ToInt16(Me.Width * 3 / 345)
        btnVoid.Top = Convert.ToInt16(Me.Height * 533 / 629)

        'size
        dgvSalesSummary.Width = Convert.ToInt16(Me.Width * 333 / 345)
        dgvSalesSummary.Height = Convert.ToInt16(Me.Height * 372 / 629)
        lblTextTotal.Width = Convert.ToInt16(Me.Width * 135 / 345)
        lblTextTotal.Height = Convert.ToInt16(Me.Height * 55 / 629)
        lblTotal.Width = Convert.ToInt16(Me.Width * 52 / 345)
        lblTotal.Height = Convert.ToInt16(Me.Height * 55 / 629)
        btnFinishandPay.Width = Convert.ToInt16(Me.Width * 333 / 345)
        btnFinishandPay.Height = Convert.ToInt16(Me.Height * 84 / 629)
        btnVoid.Width = Convert.ToInt16(Me.Width * 333 / 345)
        btnVoid.Height = Convert.ToInt16(Me.Height * 84 / 629)
    End Sub
End Class