<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTouchKeyboard
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
        Me.txtTest = New System.Windows.Forms.TextBox()
        Me.pictureBoxCapsLockDown = New System.Windows.Forms.PictureBox()
        Me.pictureBoxRightShiftDown = New System.Windows.Forms.PictureBox()
        Me.pictureBoxLeftShiftDown = New System.Windows.Forms.PictureBox()
        Me.imgKeyboard = New System.Windows.Forms.PictureBox()
        Me.txtTest2 = New System.Windows.Forms.TextBox()
        CType(Me.pictureBoxCapsLockDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBoxRightShiftDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBoxLeftShiftDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgKeyboard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTest
        '
        Me.txtTest.Location = New System.Drawing.Point(513, 360)
        Me.txtTest.Multiline = True
        Me.txtTest.Name = "txtTest"
        Me.txtTest.Size = New System.Drawing.Size(332, 20)
        Me.txtTest.TabIndex = 45
        '
        'pictureBoxCapsLockDown
        '
        Me.pictureBoxCapsLockDown.Image = Global.TMCPOS.My.Resources.Resources.caps_down_white
        Me.pictureBoxCapsLockDown.Location = New System.Drawing.Point(12, 150)
        Me.pictureBoxCapsLockDown.Name = "pictureBoxCapsLockDown"
        Me.pictureBoxCapsLockDown.Size = New System.Drawing.Size(142, 67)
        Me.pictureBoxCapsLockDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBoxCapsLockDown.TabIndex = 48
        Me.pictureBoxCapsLockDown.TabStop = False
        Me.pictureBoxCapsLockDown.Visible = False
        '
        'pictureBoxRightShiftDown
        '
        Me.pictureBoxRightShiftDown.Image = Global.TMCPOS.My.Resources.Resources.shift_down_white
        Me.pictureBoxRightShiftDown.Location = New System.Drawing.Point(867, 216)
        Me.pictureBoxRightShiftDown.Name = "pictureBoxRightShiftDown"
        Me.pictureBoxRightShiftDown.Size = New System.Drawing.Size(169, 67)
        Me.pictureBoxRightShiftDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBoxRightShiftDown.TabIndex = 47
        Me.pictureBoxRightShiftDown.TabStop = False
        Me.pictureBoxRightShiftDown.Visible = False
        '
        'pictureBoxLeftShiftDown
        '
        Me.pictureBoxLeftShiftDown.Image = Global.TMCPOS.My.Resources.Resources.shift_down_white
        Me.pictureBoxLeftShiftDown.Location = New System.Drawing.Point(12, 217)
        Me.pictureBoxLeftShiftDown.Name = "pictureBoxLeftShiftDown"
        Me.pictureBoxLeftShiftDown.Size = New System.Drawing.Size(177, 67)
        Me.pictureBoxLeftShiftDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBoxLeftShiftDown.TabIndex = 46
        Me.pictureBoxLeftShiftDown.TabStop = False
        Me.pictureBoxLeftShiftDown.Visible = False
        '
        'imgKeyboard
        '
        Me.imgKeyboard.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgKeyboard.Image = Global.TMCPOS.My.Resources.Resources.keyboard_white
        Me.imgKeyboard.Location = New System.Drawing.Point(12, 12)
        Me.imgKeyboard.Name = "imgKeyboard"
        Me.imgKeyboard.Size = New System.Drawing.Size(1248, 342)
        Me.imgKeyboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgKeyboard.TabIndex = 44
        Me.imgKeyboard.TabStop = False
        '
        'txtTest2
        '
        Me.txtTest2.Location = New System.Drawing.Point(12, 360)
        Me.txtTest2.Name = "txtTest2"
        Me.txtTest2.Size = New System.Drawing.Size(332, 20)
        Me.txtTest2.TabIndex = 49
        '
        'frmTouchKeyboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1272, 360)
        Me.Controls.Add(Me.txtTest2)
        Me.Controls.Add(Me.pictureBoxCapsLockDown)
        Me.Controls.Add(Me.pictureBoxRightShiftDown)
        Me.Controls.Add(Me.pictureBoxLeftShiftDown)
        Me.Controls.Add(Me.txtTest)
        Me.Controls.Add(Me.imgKeyboard)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(0, 100)
        Me.Name = "frmTouchKeyboard"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmTouchKeyboard"
        Me.TopMost = True
        CType(Me.pictureBoxCapsLockDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBoxRightShiftDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBoxLeftShiftDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgKeyboard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents imgKeyboard As System.Windows.Forms.PictureBox
    Friend WithEvents txtTest As System.Windows.Forms.TextBox
    Friend WithEvents pictureBoxLeftShiftDown As System.Windows.Forms.PictureBox
    Friend WithEvents pictureBoxRightShiftDown As System.Windows.Forms.PictureBox
    Friend WithEvents pictureBoxCapsLockDown As System.Windows.Forms.PictureBox
    Friend WithEvents txtTest2 As System.Windows.Forms.TextBox
End Class
