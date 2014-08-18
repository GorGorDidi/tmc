Public Class frmMain

    Dim CurrentPanelForm As Form = Nothing
    Private vStaff As Integer
    Public Property Staff As Integer
        Get
            Return vStaff
        End Get
        Set(ByVal value As Integer)
            vStaff = value
            lblStaffID.Text = value.ToString()
        End Set
    End Property

    Public Sub Login(user_id As Integer)
        Staff = user_id
        ClearCurrentPanelForm()
        PanelSession.Visible = True
        PanelControl.Visible = True
        frmSales.TopLevel = False
        frmSales.Parent = PanelForm
        CurrentPanelForm = frmSales
        frmSales.Show()
    End Sub
    Private Sub LogoutSession()
        ClearCurrentPanelForm()
        PanelSession.Visible = False
        PanelControl.Visible = False
        frmLogin.TopLevel = False
        frmLogin.Parent = PanelForm
        CurrentPanelForm = frmLogin
        frmLogin.Show()
    End Sub
    Private Sub ClearCurrentPanelForm()
        If Not (CurrentPanelForm Is Nothing) Then
            CurrentPanelForm.Parent = Nothing
            CurrentPanelForm.Hide()
        End If
    End Sub

    Private Sub btnStaff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStaff.Click
        ClearCurrentPanelForm()
        frmStaff.TopLevel = False
        frmStaff.Parent = PanelForm
        CurrentPanelForm = frmStaff
        frmStaff.Show()
    End Sub

    Private Sub btnSales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSales.Click
        ClearCurrentPanelForm()
        frmSales.TopLevel = False
        frmSales.Parent = PanelForm
        CurrentPanelForm = frmSales
        frmSales.Show()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PanelForm.Location = New Point((Me.Width / 2) - (PanelForm.Width / 2), (Me.Height / 20) - (PanelForm.Height / 20))
        PanelControl.Location = New Point((Me.Width / 2) - (PanelControl.Width / 2), (Me.Height / 1.1) - (PanelControl.Height / 1.1))
        LogoutSession()
    End Sub

    Private Sub PanelForm_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles PanelForm.Paint

    End Sub

    Private Sub btnLogout_Click(sender As System.Object, e As System.EventArgs) Handles btnLogout.Click
        LogoutSession()
    End Sub
End Class