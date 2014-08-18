<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesList
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
        Me.dgvSalesSummary = New System.Windows.Forms.DataGridView()
        Me.cItemDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnVoid = New System.Windows.Forms.Button()
        Me.btnFinishandPay = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTextTotal = New System.Windows.Forms.Label()
        CType(Me.dgvSalesSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvSalesSummary
        '
        Me.dgvSalesSummary.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvSalesSummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSalesSummary.BackgroundColor = System.Drawing.Color.White
        Me.dgvSalesSummary.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSalesSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSalesSummary.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cItemDescription})
        Me.dgvSalesSummary.Location = New System.Drawing.Point(7, 2)
        Me.dgvSalesSummary.MultiSelect = False
        Me.dgvSalesSummary.Name = "dgvSalesSummary"
        Me.dgvSalesSummary.ReadOnly = True
        Me.dgvSalesSummary.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvSalesSummary.Size = New System.Drawing.Size(333, 372)
        Me.dgvSalesSummary.TabIndex = 6
        '
        'cItemDescription
        '
        Me.cItemDescription.HeaderText = "Item Description"
        Me.cItemDescription.Name = "cItemDescription"
        Me.cItemDescription.ReadOnly = True
        '
        'btnVoid
        '
        Me.btnVoid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoid.AutoSize = True
        Me.btnVoid.BackColor = System.Drawing.Color.Red
        Me.btnVoid.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoid.Location = New System.Drawing.Point(3, 533)
        Me.btnVoid.Name = "btnVoid"
        Me.btnVoid.Size = New System.Drawing.Size(333, 84)
        Me.btnVoid.TabIndex = 10
        Me.btnVoid.Text = "Void"
        Me.btnVoid.UseVisualStyleBackColor = False
        '
        'btnFinishandPay
        '
        Me.btnFinishandPay.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFinishandPay.AutoSize = True
        Me.btnFinishandPay.BackColor = System.Drawing.Color.ForestGreen
        Me.btnFinishandPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinishandPay.Location = New System.Drawing.Point(3, 444)
        Me.btnFinishandPay.Name = "btnFinishandPay"
        Me.btnFinishandPay.Size = New System.Drawing.Size(333, 84)
        Me.btnFinishandPay.TabIndex = 9
        Me.btnFinishandPay.Text = "Finish and Pay"
        Me.btnFinishandPay.UseVisualStyleBackColor = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(284, 377)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(52, 55)
        Me.lblTotal.TabIndex = 8
        Me.lblTotal.Text = "0"
        '
        'lblTextTotal
        '
        Me.lblTextTotal.AutoSize = True
        Me.lblTextTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTextTotal.Location = New System.Drawing.Point(0, 377)
        Me.lblTextTotal.Name = "lblTextTotal"
        Me.lblTextTotal.Size = New System.Drawing.Size(135, 55)
        Me.lblTextTotal.TabIndex = 7
        Me.lblTextTotal.Text = "Total"
        '
        'frmSalesList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(345, 629)
        Me.Controls.Add(Me.btnVoid)
        Me.Controls.Add(Me.btnFinishandPay)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblTextTotal)
        Me.Controls.Add(Me.dgvSalesSummary)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSalesList"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmSalesList"
        Me.TopMost = True
        CType(Me.dgvSalesSummary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvSalesSummary As System.Windows.Forms.DataGridView
    Friend WithEvents cItemDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnVoid As System.Windows.Forms.Button
    Friend WithEvents btnFinishandPay As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblTextTotal As System.Windows.Forms.Label
End Class
