<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManageCategory
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManageCategory))
        Me.GRP_CATEGORY = New System.Windows.Forms.GroupBox()
        Me.I_NAME = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.D_ID = New System.Windows.Forms.Label()
        Me.B_CLEAR = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.B_DELETE = New System.Windows.Forms.Button()
        Me.B_SUBMIT = New System.Windows.Forms.Button()
        Me.B_BACK = New System.Windows.Forms.Button()
        Me.GRID_CATEGORY = New System.Windows.Forms.DataGridView()
        Me.GRP_CATEGORY.SuspendLayout()
        CType(Me.GRID_CATEGORY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GRP_CATEGORY
        '
        Me.GRP_CATEGORY.Controls.Add(Me.I_NAME)
        Me.GRP_CATEGORY.Controls.Add(Me.Label1)
        Me.GRP_CATEGORY.Controls.Add(Me.D_ID)
        Me.GRP_CATEGORY.Controls.Add(Me.B_CLEAR)
        Me.GRP_CATEGORY.Controls.Add(Me.Label5)
        Me.GRP_CATEGORY.Controls.Add(Me.B_DELETE)
        Me.GRP_CATEGORY.Controls.Add(Me.B_SUBMIT)
        Me.GRP_CATEGORY.ForeColor = System.Drawing.Color.White
        Me.GRP_CATEGORY.Location = New System.Drawing.Point(12, 214)
        Me.GRP_CATEGORY.Name = "GRP_CATEGORY"
        Me.GRP_CATEGORY.Size = New System.Drawing.Size(320, 160)
        Me.GRP_CATEGORY.TabIndex = 9
        Me.GRP_CATEGORY.TabStop = False
        Me.GRP_CATEGORY.Text = "Edit Category"
        '
        'I_NAME
        '
        Me.I_NAME.Location = New System.Drawing.Point(122, 66)
        Me.I_NAME.Name = "I_NAME"
        Me.I_NAME.Size = New System.Drawing.Size(190, 22)
        Me.I_NAME.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 17)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Name :"
        '
        'D_ID
        '
        Me.D_ID.AutoSize = True
        Me.D_ID.Location = New System.Drawing.Point(119, 35)
        Me.D_ID.Name = "D_ID"
        Me.D_ID.Size = New System.Drawing.Size(0, 17)
        Me.D_ID.TabIndex = 14
        '
        'B_CLEAR
        '
        Me.B_CLEAR.BackColor = System.Drawing.Color.Turquoise
        Me.B_CLEAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_CLEAR.Location = New System.Drawing.Point(38, 104)
        Me.B_CLEAR.Name = "B_CLEAR"
        Me.B_CLEAR.Size = New System.Drawing.Size(88, 50)
        Me.B_CLEAR.TabIndex = 12
        Me.B_CLEAR.Text = "Clear"
        Me.B_CLEAR.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "ID :"
        '
        'B_DELETE
        '
        Me.B_DELETE.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.B_DELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_DELETE.Location = New System.Drawing.Point(130, 104)
        Me.B_DELETE.Name = "B_DELETE"
        Me.B_DELETE.Size = New System.Drawing.Size(88, 50)
        Me.B_DELETE.TabIndex = 7
        Me.B_DELETE.Text = "Delete"
        Me.B_DELETE.UseVisualStyleBackColor = False
        '
        'B_SUBMIT
        '
        Me.B_SUBMIT.BackColor = System.Drawing.Color.LimeGreen
        Me.B_SUBMIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_SUBMIT.Location = New System.Drawing.Point(223, 104)
        Me.B_SUBMIT.Name = "B_SUBMIT"
        Me.B_SUBMIT.Size = New System.Drawing.Size(88, 50)
        Me.B_SUBMIT.TabIndex = 6
        Me.B_SUBMIT.Text = "Update"
        Me.B_SUBMIT.UseVisualStyleBackColor = False
        '
        'B_BACK
        '
        Me.B_BACK.BackColor = System.Drawing.Color.Red
        Me.B_BACK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_BACK.Location = New System.Drawing.Point(352, 318)
        Me.B_BACK.Name = "B_BACK"
        Me.B_BACK.Size = New System.Drawing.Size(88, 50)
        Me.B_BACK.TabIndex = 10
        Me.B_BACK.Text = "Close"
        Me.B_BACK.UseVisualStyleBackColor = False
        '
        'GRID_CATEGORY
        '
        Me.GRID_CATEGORY.AllowUserToAddRows = False
        Me.GRID_CATEGORY.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Poor Richard", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.GRID_CATEGORY.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GRID_CATEGORY.BackgroundColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Poor Richard", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GRID_CATEGORY.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GRID_CATEGORY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Poor Richard", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GRID_CATEGORY.DefaultCellStyle = DataGridViewCellStyle3
        Me.GRID_CATEGORY.Location = New System.Drawing.Point(12, 11)
        Me.GRID_CATEGORY.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GRID_CATEGORY.MultiSelect = False
        Me.GRID_CATEGORY.Name = "GRID_CATEGORY"
        Me.GRID_CATEGORY.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Poor Richard", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GRID_CATEGORY.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Poor Richard", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.GRID_CATEGORY.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.GRID_CATEGORY.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black
        Me.GRID_CATEGORY.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Poor Richard", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRID_CATEGORY.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.GRID_CATEGORY.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.GRID_CATEGORY.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.GRID_CATEGORY.RowTemplate.Height = 24
        Me.GRID_CATEGORY.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GRID_CATEGORY.ShowCellErrors = False
        Me.GRID_CATEGORY.ShowCellToolTips = False
        Me.GRID_CATEGORY.ShowEditingIcon = False
        Me.GRID_CATEGORY.ShowRowErrors = False
        Me.GRID_CATEGORY.Size = New System.Drawing.Size(426, 198)
        Me.GRID_CATEGORY.TabIndex = 11
        '
        'frmManageCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(448, 379)
        Me.ControlBox = False
        Me.Controls.Add(Me.GRID_CATEGORY)
        Me.Controls.Add(Me.B_BACK)
        Me.Controls.Add(Me.GRP_CATEGORY)
        Me.Font = New System.Drawing.Font("Poor Richard", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmManageCategory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Category"
        Me.GRP_CATEGORY.ResumeLayout(False)
        Me.GRP_CATEGORY.PerformLayout()
        CType(Me.GRID_CATEGORY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GRP_CATEGORY As GroupBox
    Friend WithEvents D_ID As Label
    Friend WithEvents B_CLEAR As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents B_DELETE As Button
    Friend WithEvents B_SUBMIT As Button
    Friend WithEvents I_NAME As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents B_BACK As Button
    Friend WithEvents GRID_CATEGORY As DataGridView
End Class
