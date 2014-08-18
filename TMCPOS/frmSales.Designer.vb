<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSales
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PanelSalesContainer = New System.Windows.Forms.Panel()
        Me.PanelSalesItem = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'PanelSalesContainer
        '
        Me.PanelSalesContainer.Location = New System.Drawing.Point(673, 12)
        Me.PanelSalesContainer.Name = "PanelSalesContainer"
        Me.PanelSalesContainer.Size = New System.Drawing.Size(353, 580)
        Me.PanelSalesContainer.TabIndex = 7
        '
        'PanelSalesItem
        '
        Me.PanelSalesItem.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelSalesItem.AutoScroll = True
        Me.PanelSalesItem.Location = New System.Drawing.Point(12, 12)
        Me.PanelSalesItem.Name = "PanelSalesItem"
        Me.PanelSalesItem.Size = New System.Drawing.Size(543, 580)
        Me.PanelSalesItem.TabIndex = 8
        '
        'frmSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1038, 646)
        Me.Controls.Add(Me.PanelSalesItem)
        Me.Controls.Add(Me.PanelSalesContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSales"
        Me.Text = "TMCPOS"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelSalesContainer As System.Windows.Forms.Panel
    Friend WithEvents PanelSalesItem As System.Windows.Forms.Panel
End Class
