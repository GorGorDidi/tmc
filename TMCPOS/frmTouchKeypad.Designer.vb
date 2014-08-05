<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTouchKeypad
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
        Me.imgKeypad = New System.Windows.Forms.PictureBox()
        Me.txtTest = New System.Windows.Forms.TextBox()
        CType(Me.imgKeypad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgKeypad
        '
        Me.imgKeypad.Image = Global.TMCPOS.My.Resources.Resources.numericKeypad
        Me.imgKeypad.Location = New System.Drawing.Point(12, 12)
        Me.imgKeypad.Name = "imgKeypad"
        Me.imgKeypad.Size = New System.Drawing.Size(480, 373)
        Me.imgKeypad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgKeypad.TabIndex = 0
        Me.imgKeypad.TabStop = False
        '
        'txtTest
        '
        Me.txtTest.Location = New System.Drawing.Point(136, 395)
        Me.txtTest.Name = "txtTest"
        Me.txtTest.Size = New System.Drawing.Size(91, 20)
        Me.txtTest.TabIndex = 1
        '
        'frmTouchKeypad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 427)
        Me.Controls.Add(Me.txtTest)
        Me.Controls.Add(Me.imgKeypad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(0, 100)
        Me.Name = "frmTouchKeypad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmTouchKeypad"
        Me.TopMost = True
        CType(Me.imgKeypad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents imgKeypad As System.Windows.Forms.PictureBox
    Friend WithEvents txtTest As System.Windows.Forms.TextBox
End Class
