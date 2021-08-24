<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManageSong
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManageSong))
        Me.GRP_NEWS0NG = New System.Windows.Forms.GroupBox()
        Me.D_ID = New System.Windows.Forms.Label()
        Me.B_CLEAR = New System.Windows.Forms.Button()
        Me.D_LYRIC = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.D_MP3 = New System.Windows.Forms.TextBox()
        Me.B_LYRIC = New System.Windows.Forms.Button()
        Me.B_MP3 = New System.Windows.Forms.Button()
        Me.B_DELETE = New System.Windows.Forms.Button()
        Me.B_SUBMIT = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.I_ARTIST = New System.Windows.Forms.TextBox()
        Me.I_TITLE = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OFD_MP3 = New System.Windows.Forms.OpenFileDialog()
        Me.OFD_LYRIC = New System.Windows.Forms.OpenFileDialog()
        Me.B_BACK = New System.Windows.Forms.Button()
        Me.I_SEARCH = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GRID_SONG = New System.Windows.Forms.DataGridView()
        Me.GRP_NEWS0NG.SuspendLayout()
        CType(Me.GRID_SONG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GRP_NEWS0NG
        '
        Me.GRP_NEWS0NG.Controls.Add(Me.D_ID)
        Me.GRP_NEWS0NG.Controls.Add(Me.B_CLEAR)
        Me.GRP_NEWS0NG.Controls.Add(Me.D_LYRIC)
        Me.GRP_NEWS0NG.Controls.Add(Me.Label5)
        Me.GRP_NEWS0NG.Controls.Add(Me.D_MP3)
        Me.GRP_NEWS0NG.Controls.Add(Me.B_LYRIC)
        Me.GRP_NEWS0NG.Controls.Add(Me.B_MP3)
        Me.GRP_NEWS0NG.Controls.Add(Me.B_DELETE)
        Me.GRP_NEWS0NG.Controls.Add(Me.B_SUBMIT)
        Me.GRP_NEWS0NG.Controls.Add(Me.Label4)
        Me.GRP_NEWS0NG.Controls.Add(Me.I_ARTIST)
        Me.GRP_NEWS0NG.Controls.Add(Me.I_TITLE)
        Me.GRP_NEWS0NG.Controls.Add(Me.Label3)
        Me.GRP_NEWS0NG.Controls.Add(Me.Label2)
        Me.GRP_NEWS0NG.Controls.Add(Me.Label1)
        Me.GRP_NEWS0NG.ForeColor = System.Drawing.Color.White
        Me.GRP_NEWS0NG.Location = New System.Drawing.Point(10, 293)
        Me.GRP_NEWS0NG.Name = "GRP_NEWS0NG"
        Me.GRP_NEWS0NG.Size = New System.Drawing.Size(320, 249)
        Me.GRP_NEWS0NG.TabIndex = 8
        Me.GRP_NEWS0NG.TabStop = False
        Me.GRP_NEWS0NG.Text = "Edit Song"
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
        Me.B_CLEAR.Location = New System.Drawing.Point(34, 193)
        Me.B_CLEAR.Name = "B_CLEAR"
        Me.B_CLEAR.Size = New System.Drawing.Size(88, 50)
        Me.B_CLEAR.TabIndex = 12
        Me.B_CLEAR.Text = "Clear"
        Me.B_CLEAR.UseVisualStyleBackColor = False
        '
        'D_LYRIC
        '
        Me.D_LYRIC.Location = New System.Drawing.Point(118, 155)
        Me.D_LYRIC.Name = "D_LYRIC"
        Me.D_LYRIC.ReadOnly = True
        Me.D_LYRIC.Size = New System.Drawing.Size(123, 22)
        Me.D_LYRIC.TabIndex = 11
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
        'D_MP3
        '
        Me.D_MP3.Location = New System.Drawing.Point(118, 123)
        Me.D_MP3.Name = "D_MP3"
        Me.D_MP3.ReadOnly = True
        Me.D_MP3.Size = New System.Drawing.Size(123, 22)
        Me.D_MP3.TabIndex = 10
        '
        'B_LYRIC
        '
        Me.B_LYRIC.ForeColor = System.Drawing.Color.Black
        Me.B_LYRIC.Location = New System.Drawing.Point(242, 155)
        Me.B_LYRIC.Name = "B_LYRIC"
        Me.B_LYRIC.Size = New System.Drawing.Size(66, 23)
        Me.B_LYRIC.TabIndex = 9
        Me.B_LYRIC.Text = "Browse"
        Me.B_LYRIC.UseVisualStyleBackColor = True
        '
        'B_MP3
        '
        Me.B_MP3.ForeColor = System.Drawing.Color.Black
        Me.B_MP3.Location = New System.Drawing.Point(242, 123)
        Me.B_MP3.Name = "B_MP3"
        Me.B_MP3.Size = New System.Drawing.Size(66, 23)
        Me.B_MP3.TabIndex = 8
        Me.B_MP3.Text = "Browse"
        Me.B_MP3.UseVisualStyleBackColor = True
        '
        'B_DELETE
        '
        Me.B_DELETE.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.B_DELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_DELETE.Location = New System.Drawing.Point(127, 193)
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
        Me.B_SUBMIT.Location = New System.Drawing.Point(220, 193)
        Me.B_SUBMIT.Name = "B_SUBMIT"
        Me.B_SUBMIT.Size = New System.Drawing.Size(88, 50)
        Me.B_SUBMIT.TabIndex = 6
        Me.B_SUBMIT.Text = "Update"
        Me.B_SUBMIT.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Lyric Path (.txt) :"
        '
        'I_ARTIST
        '
        Me.I_ARTIST.Location = New System.Drawing.Point(118, 92)
        Me.I_ARTIST.Name = "I_ARTIST"
        Me.I_ARTIST.Size = New System.Drawing.Size(190, 22)
        Me.I_ARTIST.TabIndex = 4
        '
        'I_TITLE
        '
        Me.I_TITLE.Location = New System.Drawing.Point(118, 64)
        Me.I_TITLE.Name = "I_TITLE"
        Me.I_TITLE.Size = New System.Drawing.Size(190, 22)
        Me.I_TITLE.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Audio Path (.mp3) :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Artist :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Title :"
        '
        'OFD_MP3
        '
        Me.OFD_MP3.FileName = "OpenFileDialog1"
        '
        'OFD_LYRIC
        '
        Me.OFD_LYRIC.FileName = "OpenFileDialog1"
        '
        'B_BACK
        '
        Me.B_BACK.BackColor = System.Drawing.Color.Red
        Me.B_BACK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_BACK.Location = New System.Drawing.Point(551, 486)
        Me.B_BACK.Name = "B_BACK"
        Me.B_BACK.Size = New System.Drawing.Size(88, 50)
        Me.B_BACK.TabIndex = 9
        Me.B_BACK.Text = "Close"
        Me.B_BACK.UseVisualStyleBackColor = False
        '
        'I_SEARCH
        '
        Me.I_SEARCH.Location = New System.Drawing.Point(13, 30)
        Me.I_SEARCH.Name = "I_SEARCH"
        Me.I_SEARCH.Size = New System.Drawing.Size(232, 22)
        Me.I_SEARCH.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 17)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Search by Title or Artist"
        '
        'GRID_SONG
        '
        Me.GRID_SONG.AllowUserToAddRows = False
        Me.GRID_SONG.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Poor Richard", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.GRID_SONG.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GRID_SONG.BackgroundColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Poor Richard", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GRID_SONG.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GRID_SONG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Poor Richard", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GRID_SONG.DefaultCellStyle = DataGridViewCellStyle3
        Me.GRID_SONG.Location = New System.Drawing.Point(13, 66)
        Me.GRID_SONG.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GRID_SONG.MultiSelect = False
        Me.GRID_SONG.Name = "GRID_SONG"
        Me.GRID_SONG.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Poor Richard", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GRID_SONG.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Poor Richard", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.GRID_SONG.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.GRID_SONG.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black
        Me.GRID_SONG.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Poor Richard", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRID_SONG.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.GRID_SONG.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.GRID_SONG.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.GRID_SONG.RowTemplate.Height = 24
        Me.GRID_SONG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GRID_SONG.ShowCellErrors = False
        Me.GRID_SONG.ShowCellToolTips = False
        Me.GRID_SONG.ShowEditingIcon = False
        Me.GRID_SONG.ShowRowErrors = False
        Me.GRID_SONG.Size = New System.Drawing.Size(636, 198)
        Me.GRID_SONG.TabIndex = 21
        '
        'frmManageSong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(668, 554)
        Me.ControlBox = False
        Me.Controls.Add(Me.GRID_SONG)
        Me.Controls.Add(Me.I_SEARCH)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.B_BACK)
        Me.Controls.Add(Me.GRP_NEWS0NG)
        Me.Font = New System.Drawing.Font("Poor Richard", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmManageSong"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Song"
        Me.GRP_NEWS0NG.ResumeLayout(False)
        Me.GRP_NEWS0NG.PerformLayout()
        CType(Me.GRID_SONG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GRP_NEWS0NG As GroupBox
    Friend WithEvents B_CLEAR As Button
    Friend WithEvents D_LYRIC As TextBox
    Friend WithEvents D_MP3 As TextBox
    Friend WithEvents B_LYRIC As Button
    Friend WithEvents B_MP3 As Button
    Friend WithEvents B_DELETE As Button
    Friend WithEvents B_SUBMIT As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents I_ARTIST As TextBox
    Friend WithEvents I_TITLE As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents OFD_MP3 As OpenFileDialog
    Friend WithEvents OFD_LYRIC As OpenFileDialog
    Friend WithEvents D_ID As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents B_BACK As Button
    Friend WithEvents I_SEARCH As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GRID_SONG As DataGridView
End Class
