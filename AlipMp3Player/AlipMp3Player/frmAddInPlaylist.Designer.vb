<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddInPlaylist
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddInPlaylist))
        Me.GRP_NEWS0NG = New System.Windows.Forms.GroupBox()
        Me.I_SEARCH_ALL = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GRID_NOT_IN_SONG = New System.Windows.Forms.DataGridView()
        Me.B_ADD = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.I_SEARCH_PLAY = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GRID_IN_SONG = New System.Windows.Forms.DataGridView()
        Me.B_REMOVE = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CB_PLAYLIST = New System.Windows.Forms.ComboBox()
        Me.B_BACK = New System.Windows.Forms.Button()
        Me.GRP_NEWS0NG.SuspendLayout()
        CType(Me.GRID_NOT_IN_SONG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GRID_IN_SONG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GRP_NEWS0NG
        '
        Me.GRP_NEWS0NG.Controls.Add(Me.I_SEARCH_ALL)
        Me.GRP_NEWS0NG.Controls.Add(Me.Label4)
        Me.GRP_NEWS0NG.Controls.Add(Me.GRID_NOT_IN_SONG)
        Me.GRP_NEWS0NG.Controls.Add(Me.B_ADD)
        Me.GRP_NEWS0NG.ForeColor = System.Drawing.Color.White
        Me.GRP_NEWS0NG.Location = New System.Drawing.Point(10, 64)
        Me.GRP_NEWS0NG.Name = "GRP_NEWS0NG"
        Me.GRP_NEWS0NG.Size = New System.Drawing.Size(411, 450)
        Me.GRP_NEWS0NG.TabIndex = 1
        Me.GRP_NEWS0NG.TabStop = False
        Me.GRP_NEWS0NG.Text = "All Song"
        '
        'I_SEARCH_ALL
        '
        Me.I_SEARCH_ALL.Location = New System.Drawing.Point(12, 47)
        Me.I_SEARCH_ALL.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.I_SEARCH_ALL.Name = "I_SEARCH_ALL"
        Me.I_SEARCH_ALL.Size = New System.Drawing.Size(232, 22)
        Me.I_SEARCH_ALL.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(9, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 17)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Search by Title or Artist"
        '
        'GRID_NOT_IN_SONG
        '
        Me.GRID_NOT_IN_SONG.AllowUserToAddRows = False
        Me.GRID_NOT_IN_SONG.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Poor Richard", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.GRID_NOT_IN_SONG.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GRID_NOT_IN_SONG.BackgroundColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Poor Richard", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GRID_NOT_IN_SONG.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GRID_NOT_IN_SONG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Poor Richard", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GRID_NOT_IN_SONG.DefaultCellStyle = DataGridViewCellStyle3
        Me.GRID_NOT_IN_SONG.Location = New System.Drawing.Point(12, 89)
        Me.GRID_NOT_IN_SONG.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GRID_NOT_IN_SONG.MultiSelect = False
        Me.GRID_NOT_IN_SONG.Name = "GRID_NOT_IN_SONG"
        Me.GRID_NOT_IN_SONG.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Poor Richard", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GRID_NOT_IN_SONG.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Poor Richard", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.GRID_NOT_IN_SONG.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.GRID_NOT_IN_SONG.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black
        Me.GRID_NOT_IN_SONG.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Poor Richard", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRID_NOT_IN_SONG.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.GRID_NOT_IN_SONG.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.GRID_NOT_IN_SONG.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.GRID_NOT_IN_SONG.RowTemplate.Height = 24
        Me.GRID_NOT_IN_SONG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GRID_NOT_IN_SONG.ShowCellErrors = False
        Me.GRID_NOT_IN_SONG.ShowCellToolTips = False
        Me.GRID_NOT_IN_SONG.ShowEditingIcon = False
        Me.GRID_NOT_IN_SONG.ShowRowErrors = False
        Me.GRID_NOT_IN_SONG.Size = New System.Drawing.Size(393, 300)
        Me.GRID_NOT_IN_SONG.TabIndex = 7
        '
        'B_ADD
        '
        Me.B_ADD.BackColor = System.Drawing.Color.Turquoise
        Me.B_ADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_ADD.Location = New System.Drawing.Point(317, 394)
        Me.B_ADD.Name = "B_ADD"
        Me.B_ADD.Size = New System.Drawing.Size(88, 50)
        Me.B_ADD.TabIndex = 6
        Me.B_ADD.Text = "Add"
        Me.B_ADD.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.I_SEARCH_PLAY)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.GRID_IN_SONG)
        Me.GroupBox1.Controls.Add(Me.B_REMOVE)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(427, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(411, 448)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Playlist Song"
        '
        'I_SEARCH_PLAY
        '
        Me.I_SEARCH_PLAY.Location = New System.Drawing.Point(6, 45)
        Me.I_SEARCH_PLAY.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.I_SEARCH_PLAY.Name = "I_SEARCH_PLAY"
        Me.I_SEARCH_PLAY.Size = New System.Drawing.Size(232, 22)
        Me.I_SEARCH_PLAY.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 17)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Search by Title or Artist"
        '
        'GRID_IN_SONG
        '
        Me.GRID_IN_SONG.AllowUserToAddRows = False
        Me.GRID_IN_SONG.AllowUserToDeleteRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Poor Richard", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        Me.GRID_IN_SONG.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.GRID_IN_SONG.BackgroundColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Poor Richard", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GRID_IN_SONG.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.GRID_IN_SONG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Poor Richard", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GRID_IN_SONG.DefaultCellStyle = DataGridViewCellStyle8
        Me.GRID_IN_SONG.Location = New System.Drawing.Point(6, 87)
        Me.GRID_IN_SONG.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GRID_IN_SONG.MultiSelect = False
        Me.GRID_IN_SONG.Name = "GRID_IN_SONG"
        Me.GRID_IN_SONG.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Poor Richard", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GRID_IN_SONG.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Poor Richard", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        Me.GRID_IN_SONG.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.GRID_IN_SONG.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black
        Me.GRID_IN_SONG.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Poor Richard", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRID_IN_SONG.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.GRID_IN_SONG.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.GRID_IN_SONG.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.GRID_IN_SONG.RowTemplate.Height = 24
        Me.GRID_IN_SONG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GRID_IN_SONG.ShowCellErrors = False
        Me.GRID_IN_SONG.ShowCellToolTips = False
        Me.GRID_IN_SONG.ShowEditingIcon = False
        Me.GRID_IN_SONG.ShowRowErrors = False
        Me.GRID_IN_SONG.Size = New System.Drawing.Size(399, 300)
        Me.GRID_IN_SONG.TabIndex = 7
        '
        'B_REMOVE
        '
        Me.B_REMOVE.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.B_REMOVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_REMOVE.Location = New System.Drawing.Point(317, 392)
        Me.B_REMOVE.Name = "B_REMOVE"
        Me.B_REMOVE.Size = New System.Drawing.Size(88, 50)
        Me.B_REMOVE.TabIndex = 6
        Me.B_REMOVE.Text = "Remove"
        Me.B_REMOVE.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Select Playlist"
        '
        'CB_PLAYLIST
        '
        Me.CB_PLAYLIST.FormattingEnabled = True
        Me.CB_PLAYLIST.Location = New System.Drawing.Point(12, 33)
        Me.CB_PLAYLIST.Name = "CB_PLAYLIST"
        Me.CB_PLAYLIST.Size = New System.Drawing.Size(232, 24)
        Me.CB_PLAYLIST.TabIndex = 8
        '
        'B_BACK
        '
        Me.B_BACK.BackColor = System.Drawing.Color.Red
        Me.B_BACK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_BACK.Location = New System.Drawing.Point(746, 520)
        Me.B_BACK.Name = "B_BACK"
        Me.B_BACK.Size = New System.Drawing.Size(88, 50)
        Me.B_BACK.TabIndex = 11
        Me.B_BACK.Text = "Close"
        Me.B_BACK.UseVisualStyleBackColor = False
        '
        'frmAddInPlaylist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(844, 582)
        Me.ControlBox = False
        Me.Controls.Add(Me.B_BACK)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CB_PLAYLIST)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GRP_NEWS0NG)
        Me.Font = New System.Drawing.Font("Poor Richard", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAddInPlaylist"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Playlist"
        Me.GRP_NEWS0NG.ResumeLayout(False)
        Me.GRP_NEWS0NG.PerformLayout()
        CType(Me.GRID_NOT_IN_SONG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GRID_IN_SONG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GRP_NEWS0NG As GroupBox
    Friend WithEvents B_ADD As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents B_REMOVE As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CB_PLAYLIST As ComboBox
    Friend WithEvents B_BACK As Button
    Friend WithEvents GRID_NOT_IN_SONG As DataGridView
    Friend WithEvents GRID_IN_SONG As DataGridView
    Friend WithEvents I_SEARCH_ALL As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents I_SEARCH_PLAY As TextBox
    Friend WithEvents Label2 As Label
End Class
