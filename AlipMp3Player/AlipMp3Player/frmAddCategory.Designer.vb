<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddCategory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddCategory))
        Me.GRP_NEWCATE = New System.Windows.Forms.GroupBox()
        Me.B_CLEAR = New System.Windows.Forms.Button()
        Me.B_BACK = New System.Windows.Forms.Button()
        Me.B_SUBMIT = New System.Windows.Forms.Button()
        Me.I_NAME = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GRP_NEWCATE.SuspendLayout()
        Me.SuspendLayout()
        '
        'GRP_NEWCATE
        '
        Me.GRP_NEWCATE.Controls.Add(Me.B_CLEAR)
        Me.GRP_NEWCATE.Controls.Add(Me.B_BACK)
        Me.GRP_NEWCATE.Controls.Add(Me.B_SUBMIT)
        Me.GRP_NEWCATE.Controls.Add(Me.I_NAME)
        Me.GRP_NEWCATE.Controls.Add(Me.Label1)
        Me.GRP_NEWCATE.ForeColor = System.Drawing.Color.White
        Me.GRP_NEWCATE.Location = New System.Drawing.Point(11, 12)
        Me.GRP_NEWCATE.Name = "GRP_NEWCATE"
        Me.GRP_NEWCATE.Size = New System.Drawing.Size(312, 328)
        Me.GRP_NEWCATE.TabIndex = 1
        Me.GRP_NEWCATE.TabStop = False
        Me.GRP_NEWCATE.Text = "Add New Category"
        '
        'B_CLEAR
        '
        Me.B_CLEAR.BackColor = System.Drawing.Color.Turquoise
        Me.B_CLEAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_CLEAR.Location = New System.Drawing.Point(34, 272)
        Me.B_CLEAR.Name = "B_CLEAR"
        Me.B_CLEAR.Size = New System.Drawing.Size(88, 50)
        Me.B_CLEAR.TabIndex = 12
        Me.B_CLEAR.Text = "Clear"
        Me.B_CLEAR.UseVisualStyleBackColor = False
        '
        'B_BACK
        '
        Me.B_BACK.BackColor = System.Drawing.Color.Red
        Me.B_BACK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_BACK.Location = New System.Drawing.Point(220, 272)
        Me.B_BACK.Name = "B_BACK"
        Me.B_BACK.Size = New System.Drawing.Size(88, 50)
        Me.B_BACK.TabIndex = 7
        Me.B_BACK.Text = "Close"
        Me.B_BACK.UseVisualStyleBackColor = False
        '
        'B_SUBMIT
        '
        Me.B_SUBMIT.BackColor = System.Drawing.Color.LimeGreen
        Me.B_SUBMIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_SUBMIT.Location = New System.Drawing.Point(128, 271)
        Me.B_SUBMIT.Name = "B_SUBMIT"
        Me.B_SUBMIT.Size = New System.Drawing.Size(88, 50)
        Me.B_SUBMIT.TabIndex = 6
        Me.B_SUBMIT.Text = "Submit"
        Me.B_SUBMIT.UseVisualStyleBackColor = False
        '
        'I_NAME
        '
        Me.I_NAME.Location = New System.Drawing.Point(118, 31)
        Me.I_NAME.Name = "I_NAME"
        Me.I_NAME.Size = New System.Drawing.Size(190, 22)
        Me.I_NAME.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name :"
        '
        'frmAddCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(334, 353)
        Me.ControlBox = False
        Me.Controls.Add(Me.GRP_NEWCATE)
        Me.Font = New System.Drawing.Font("Poor Richard", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAddCategory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Category"
        Me.GRP_NEWCATE.ResumeLayout(False)
        Me.GRP_NEWCATE.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GRP_NEWCATE As GroupBox
    Friend WithEvents B_CLEAR As Button
    Friend WithEvents B_BACK As Button
    Friend WithEvents B_SUBMIT As Button
    Friend WithEvents I_NAME As TextBox
    Friend WithEvents Label1 As Label
End Class
