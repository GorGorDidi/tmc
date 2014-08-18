<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesSummary
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
        Me.ListBoxSalesSummary = New System.Windows.Forms.ListBox()
        Me.DataSetSummary = New System.Data.DataSet()
        Me.DataTableSummary = New System.Data.DataTable()
        Me.DataColumnDesc = New System.Data.DataColumn()
        Me.DataColumnQty = New System.Data.DataColumn()
        CType(Me.DataSetSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTableSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBoxSalesSummary
        '
        Me.ListBoxSalesSummary.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBoxSalesSummary.DataSource = Me.DataSetSummary
        Me.ListBoxSalesSummary.DisplayMember = "TableSummary.Description"
        Me.ListBoxSalesSummary.FormattingEnabled = True
        Me.ListBoxSalesSummary.Location = New System.Drawing.Point(12, 12)
        Me.ListBoxSalesSummary.MultiColumn = True
        Me.ListBoxSalesSummary.Name = "ListBoxSalesSummary"
        Me.ListBoxSalesSummary.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.ListBoxSalesSummary.Size = New System.Drawing.Size(330, 498)
        Me.ListBoxSalesSummary.TabIndex = 0
        '
        'DataSetSummary
        '
        Me.DataSetSummary.DataSetName = "NewDataSet"
        Me.DataSetSummary.Tables.AddRange(New System.Data.DataTable() {Me.DataTableSummary})
        '
        'DataTableSummary
        '
        Me.DataTableSummary.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumnDesc, Me.DataColumnQty})
        Me.DataTableSummary.TableName = "TableSummary"
        '
        'DataColumnDesc
        '
        Me.DataColumnDesc.ColumnName = "Description"
        Me.DataColumnDesc.ReadOnly = True
        '
        'DataColumnQty
        '
        Me.DataColumnQty.ColumnName = "Qty"
        Me.DataColumnQty.DataType = GetType(Integer)
        Me.DataColumnQty.ReadOnly = True
        '
        'frmSalesSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 517)
        Me.Controls.Add(Me.ListBoxSalesSummary)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSalesSummary"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmSalesSummary"
        CType(Me.DataSetSummary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTableSummary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBoxSalesSummary As System.Windows.Forms.ListBox
    Friend WithEvents DataSetSummary As System.Data.DataSet
    Friend WithEvents DataTableSummary As System.Data.DataTable
    Friend WithEvents DataColumnDesc As System.Data.DataColumn
    Friend WithEvents DataColumnQty As System.Data.DataColumn
End Class
