<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.PanelForm = New System.Windows.Forms.Panel()
        Me.PanelControl = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnManagement = New System.Windows.Forms.Button()
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.btnStaff = New System.Windows.Forms.Button()
        Me.btnSales = New System.Windows.Forms.Button()
        Me.PanelControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelForm
        '
        Me.PanelForm.BackColor = System.Drawing.Color.Transparent
        Me.PanelForm.Location = New System.Drawing.Point(12, 12)
        Me.PanelForm.Name = "PanelForm"
        Me.PanelForm.Size = New System.Drawing.Size(1187, 654)
        Me.PanelForm.TabIndex = 0
        '
        'PanelControl
        '
        Me.PanelControl.BackColor = System.Drawing.Color.Transparent
        Me.PanelControl.Controls.Add(Me.btnClose)
        Me.PanelControl.Controls.Add(Me.btnManagement)
        Me.PanelControl.Controls.Add(Me.btnInventory)
        Me.PanelControl.Controls.Add(Me.btnStaff)
        Me.PanelControl.Controls.Add(Me.btnSales)
        Me.PanelControl.Location = New System.Drawing.Point(10, 672)
        Me.PanelControl.Name = "PanelControl"
        Me.PanelControl.Size = New System.Drawing.Size(1189, 106)
        Me.PanelControl.TabIndex = 7
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Black
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(795, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(192, 97)
        Me.btnClose.TabIndex = 16
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnManagement
        '
        Me.btnManagement.BackColor = System.Drawing.Color.Black
        Me.btnManagement.BackgroundImage = CType(resources.GetObject("btnManagement.BackgroundImage"), System.Drawing.Image)
        Me.btnManagement.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManagement.ForeColor = System.Drawing.Color.White
        Me.btnManagement.Location = New System.Drawing.Point(597, 3)
        Me.btnManagement.Name = "btnManagement"
        Me.btnManagement.Size = New System.Drawing.Size(192, 97)
        Me.btnManagement.TabIndex = 15
        Me.btnManagement.Text = "Management"
        Me.btnManagement.UseVisualStyleBackColor = False
        '
        'btnInventory
        '
        Me.btnInventory.BackColor = System.Drawing.Color.Black
        Me.btnInventory.BackgroundImage = CType(resources.GetObject("btnInventory.BackgroundImage"), System.Drawing.Image)
        Me.btnInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventory.ForeColor = System.Drawing.Color.White
        Me.btnInventory.Location = New System.Drawing.Point(399, 3)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(192, 97)
        Me.btnInventory.TabIndex = 14
        Me.btnInventory.Text = "Inventory"
        Me.btnInventory.UseVisualStyleBackColor = False
        '
        'btnStaff
        '
        Me.btnStaff.BackColor = System.Drawing.Color.Black
        Me.btnStaff.BackgroundImage = CType(resources.GetObject("btnStaff.BackgroundImage"), System.Drawing.Image)
        Me.btnStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStaff.ForeColor = System.Drawing.Color.White
        Me.btnStaff.Location = New System.Drawing.Point(201, 3)
        Me.btnStaff.Name = "btnStaff"
        Me.btnStaff.Size = New System.Drawing.Size(192, 97)
        Me.btnStaff.TabIndex = 13
        Me.btnStaff.Text = "Staff"
        Me.btnStaff.UseVisualStyleBackColor = False
        '
        'btnSales
        '
        Me.btnSales.BackColor = System.Drawing.Color.Black
        Me.btnSales.BackgroundImage = CType(resources.GetObject("btnSales.BackgroundImage"), System.Drawing.Image)
        Me.btnSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSales.ForeColor = System.Drawing.Color.White
        Me.btnSales.Location = New System.Drawing.Point(3, 3)
        Me.btnSales.Name = "btnSales"
        Me.btnSales.Size = New System.Drawing.Size(192, 97)
        Me.btnSales.TabIndex = 12
        Me.btnSales.Text = "Sales"
        Me.btnSales.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1207, 750)
        Me.Controls.Add(Me.PanelControl)
        Me.Controls.Add(Me.PanelForm)
        Me.Name = "frmMain"
        Me.Text = "TMCPOS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelControl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelForm As System.Windows.Forms.Panel
    Friend WithEvents PanelControl As System.Windows.Forms.Panel
    Friend WithEvents btnManagement As System.Windows.Forms.Button
    Friend WithEvents btnInventory As System.Windows.Forms.Button
    Friend WithEvents btnStaff As System.Windows.Forms.Button
    Friend WithEvents btnSales As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
