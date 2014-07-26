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
        Me.btnFinishandPay = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnMineralWater = New System.Windows.Forms.Button()
        Me.btnWalkin15 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.btnMember = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnWalkin12 = New System.Windows.Forms.Button()
        Me.btn10DaysPass = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.dgvSalesSummary = New System.Windows.Forms.DataGridView()
        Me.cItemDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnVoid = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvSalesSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnFinishandPay
        '
        Me.btnFinishandPay.BackColor = System.Drawing.Color.ForestGreen
        Me.btnFinishandPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinishandPay.Location = New System.Drawing.Point(683, 455)
        Me.btnFinishandPay.Name = "btnFinishandPay"
        Me.btnFinishandPay.Size = New System.Drawing.Size(345, 84)
        Me.btnFinishandPay.TabIndex = 4
        Me.btnFinishandPay.Text = "Finish and Pay"
        Me.btnFinishandPay.UseVisualStyleBackColor = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(876, 397)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(52, 55)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(673, 397)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 55)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Total"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnMineralWater)
        Me.GroupBox1.Controls.Add(Me.btnWalkin15)
        Me.GroupBox1.Controls.Add(Me.Button11)
        Me.GroupBox1.Controls.Add(Me.btnMember)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.btnWalkin12)
        Me.GroupBox1.Controls.Add(Me.btn10DaysPass)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(660, 557)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'btnMineralWater
        '
        Me.btnMineralWater.Font = New System.Drawing.Font("Franklin Gothic Demi", 20.25!)
        Me.btnMineralWater.Location = New System.Drawing.Point(432, 237)
        Me.btnMineralWater.Name = "btnMineralWater"
        Me.btnMineralWater.Size = New System.Drawing.Size(136, 97)
        Me.btnMineralWater.TabIndex = 11
        Me.btnMineralWater.Text = "Mineral Water"
        Me.btnMineralWater.UseVisualStyleBackColor = True
        '
        'btnWalkin15
        '
        Me.btnWalkin15.Font = New System.Drawing.Font("Franklin Gothic Demi", 20.25!)
        Me.btnWalkin15.Location = New System.Drawing.Point(148, 10)
        Me.btnWalkin15.Name = "btnWalkin15"
        Me.btnWalkin15.Size = New System.Drawing.Size(136, 97)
        Me.btnWalkin15.TabIndex = 2
        Me.btnWalkin15.Text = "Walk-In"
        Me.btnWalkin15.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnWalkin15.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Font = New System.Drawing.Font("Franklin Gothic Demi", 20.25!)
        Me.Button11.Location = New System.Drawing.Point(290, 237)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(136, 97)
        Me.Button11.TabIndex = 10
        Me.Button11.Text = "Beer"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'btnMember
        '
        Me.btnMember.BackColor = System.Drawing.Color.Transparent
        Me.btnMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnMember.Font = New System.Drawing.Font("Franklin Gothic Demi", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMember.Location = New System.Drawing.Point(6, 10)
        Me.btnMember.Name = "btnMember"
        Me.btnMember.Size = New System.Drawing.Size(136, 97)
        Me.btnMember.TabIndex = 1
        Me.btnMember.Text = "Member"
        Me.btnMember.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMember.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Franklin Gothic Demi", 20.25!)
        Me.Button2.Location = New System.Drawing.Point(148, 237)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(136, 97)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Non Soda"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnWalkin12
        '
        Me.btnWalkin12.Font = New System.Drawing.Font("Franklin Gothic Demi", 20.25!)
        Me.btnWalkin12.Location = New System.Drawing.Point(290, 10)
        Me.btnWalkin12.Name = "btnWalkin12"
        Me.btnWalkin12.Size = New System.Drawing.Size(136, 97)
        Me.btnWalkin12.TabIndex = 0
        Me.btnWalkin12.Text = "Walk-In"
        Me.btnWalkin12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnWalkin12.UseVisualStyleBackColor = True
        '
        'btn10DaysPass
        '
        Me.btn10DaysPass.Font = New System.Drawing.Font("Franklin Gothic Demi", 20.25!)
        Me.btn10DaysPass.Location = New System.Drawing.Point(6, 134)
        Me.btn10DaysPass.Name = "btn10DaysPass"
        Me.btn10DaysPass.Size = New System.Drawing.Size(136, 97)
        Me.btn10DaysPass.TabIndex = 1
        Me.btn10DaysPass.Text = "10 Pass"
        Me.btn10DaysPass.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Franklin Gothic Demi", 20.25!)
        Me.Button5.Location = New System.Drawing.Point(6, 237)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(136, 97)
        Me.Button5.TabIndex = 2
        Me.Button5.Text = "Soda"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'dgvSalesSummary
        '
        Me.dgvSalesSummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSalesSummary.BackgroundColor = System.Drawing.Color.White
        Me.dgvSalesSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSalesSummary.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cItemDescription})
        Me.dgvSalesSummary.Location = New System.Drawing.Point(673, 22)
        Me.dgvSalesSummary.MultiSelect = False
        Me.dgvSalesSummary.Name = "dgvSalesSummary"
        Me.dgvSalesSummary.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvSalesSummary.Size = New System.Drawing.Size(353, 372)
        Me.dgvSalesSummary.TabIndex = 5
        '
        'cItemDescription
        '
        Me.cItemDescription.HeaderText = "Item Description"
        Me.cItemDescription.Name = "cItemDescription"
        '
        'btnVoid
        '
        Me.btnVoid.BackColor = System.Drawing.Color.Red
        Me.btnVoid.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoid.Location = New System.Drawing.Point(683, 545)
        Me.btnVoid.Name = "btnVoid"
        Me.btnVoid.Size = New System.Drawing.Size(343, 84)
        Me.btnVoid.TabIndex = 6
        Me.btnVoid.Text = "Void"
        Me.btnVoid.UseVisualStyleBackColor = False
        '
        'frmSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1038, 646)
        Me.Controls.Add(Me.btnVoid)
        Me.Controls.Add(Me.dgvSalesSummary)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnFinishandPay)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSales"
        Me.Text = "TMCPOS"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvSalesSummary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFinishandPay As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnMineralWater As System.Windows.Forms.Button
    Friend WithEvents btnWalkin15 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents btnMember As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnWalkin12 As System.Windows.Forms.Button
    Friend WithEvents btn10DaysPass As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents dgvSalesSummary As System.Windows.Forms.DataGridView
    Friend WithEvents cItemDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnVoid As System.Windows.Forms.Button
End Class
