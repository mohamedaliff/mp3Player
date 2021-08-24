<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MENU_ADD = New System.Windows.Forms.ToolStripMenuItem()
        Me.MENU_MANAGE = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlaylistToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddCategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageCategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigurationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BaseURLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShufflePlayerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShuffleOnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShuffleOffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinimizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CB_PLAYLIST = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GRID_SONG = New System.Windows.Forms.DataGridView()
        Me.D_ARTIST = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.D_TITLE = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.B_CLOSE = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.I_SEARCH = New System.Windows.Forms.TextBox()
        Me.TR_DURATION = New System.Windows.Forms.TrackBar()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.D_CUR_DURATION = New System.Windows.Forms.Label()
        Me.D_TOT_DURATION = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.B_NEXT = New System.Windows.Forms.Button()
        Me.B_PREVIOUS = New System.Windows.Forms.Button()
        Me.B_PAUSE = New System.Windows.Forms.Button()
        Me.B_STOP = New System.Windows.Forms.Button()
        Me.B_RESUME = New System.Windows.Forms.Button()
        Me.B_LYRIC = New System.Windows.Forms.Button()
        Me.B_PLAY = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.GRID_SONG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TR_DURATION, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Poor Richard", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.RefreshToolStripMenuItem, Me.ShufflePlayerToolStripMenuItem, Me.MinimizeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(668, 26)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MENU_ADD, Me.MENU_MANAGE, Me.PlaylistToolStripMenuItem, Me.AddCategoryToolStripMenuItem, Me.ManageCategoryToolStripMenuItem, Me.ConfigurationToolStripMenuItem})
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.Black
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(42, 24)
        Me.ToolStripMenuItem1.Text = "File"
        '
        'MENU_ADD
        '
        Me.MENU_ADD.Name = "MENU_ADD"
        Me.MENU_ADD.Size = New System.Drawing.Size(180, 26)
        Me.MENU_ADD.Text = "Add new song"
        '
        'MENU_MANAGE
        '
        Me.MENU_MANAGE.Name = "MENU_MANAGE"
        Me.MENU_MANAGE.Size = New System.Drawing.Size(180, 26)
        Me.MENU_MANAGE.Text = "Manage song"
        '
        'PlaylistToolStripMenuItem
        '
        Me.PlaylistToolStripMenuItem.Name = "PlaylistToolStripMenuItem"
        Me.PlaylistToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.PlaylistToolStripMenuItem.Text = "Playlist"
        '
        'AddCategoryToolStripMenuItem
        '
        Me.AddCategoryToolStripMenuItem.Name = "AddCategoryToolStripMenuItem"
        Me.AddCategoryToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.AddCategoryToolStripMenuItem.Text = "Add category"
        '
        'ManageCategoryToolStripMenuItem
        '
        Me.ManageCategoryToolStripMenuItem.Name = "ManageCategoryToolStripMenuItem"
        Me.ManageCategoryToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.ManageCategoryToolStripMenuItem.Text = "Manage category"
        '
        'ConfigurationToolStripMenuItem
        '
        Me.ConfigurationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BaseURLToolStripMenuItem})
        Me.ConfigurationToolStripMenuItem.Name = "ConfigurationToolStripMenuItem"
        Me.ConfigurationToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.ConfigurationToolStripMenuItem.Text = "Configuration"
        '
        'BaseURLToolStripMenuItem
        '
        Me.BaseURLToolStripMenuItem.Name = "BaseURLToolStripMenuItem"
        Me.BaseURLToolStripMenuItem.Size = New System.Drawing.Size(139, 26)
        Me.BaseURLToolStripMenuItem.Text = "Base URL"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(64, 24)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'ShufflePlayerToolStripMenuItem
        '
        Me.ShufflePlayerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShuffleOnToolStripMenuItem, Me.ShuffleOffToolStripMenuItem})
        Me.ShufflePlayerToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ShufflePlayerToolStripMenuItem.Name = "ShufflePlayerToolStripMenuItem"
        Me.ShufflePlayerToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.ShufflePlayerToolStripMenuItem.Text = "Shuffle Player"
        '
        'ShuffleOnToolStripMenuItem
        '
        Me.ShuffleOnToolStripMenuItem.Name = "ShuffleOnToolStripMenuItem"
        Me.ShuffleOnToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.ShuffleOnToolStripMenuItem.Text = "Shuffle On"
        '
        'ShuffleOffToolStripMenuItem
        '
        Me.ShuffleOffToolStripMenuItem.Name = "ShuffleOffToolStripMenuItem"
        Me.ShuffleOffToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.ShuffleOffToolStripMenuItem.Text = "Shuffle Off"
        '
        'MinimizeToolStripMenuItem
        '
        Me.MinimizeToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.MinimizeToolStripMenuItem.Name = "MinimizeToolStripMenuItem"
        Me.MinimizeToolStripMenuItem.Size = New System.Drawing.Size(71, 24)
        Me.MinimizeToolStripMenuItem.Text = "Minimize"
        '
        'CB_PLAYLIST
        '
        Me.CB_PLAYLIST.FormattingEnabled = True
        Me.CB_PLAYLIST.Location = New System.Drawing.Point(10, 57)
        Me.CB_PLAYLIST.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CB_PLAYLIST.Name = "CB_PLAYLIST"
        Me.CB_PLAYLIST.Size = New System.Drawing.Size(232, 24)
        Me.CB_PLAYLIST.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(11, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Select Playlist"
        '
        'GRID_SONG
        '
        Me.GRID_SONG.AllowUserToAddRows = False
        Me.GRID_SONG.AllowUserToDeleteRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Poor Richard", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        Me.GRID_SONG.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.GRID_SONG.BackgroundColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Poor Richard", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GRID_SONG.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.GRID_SONG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Poor Richard", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GRID_SONG.DefaultCellStyle = DataGridViewCellStyle8
        Me.GRID_SONG.Location = New System.Drawing.Point(10, 86)
        Me.GRID_SONG.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GRID_SONG.MultiSelect = False
        Me.GRID_SONG.Name = "GRID_SONG"
        Me.GRID_SONG.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Poor Richard", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GRID_SONG.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Poor Richard", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        Me.GRID_SONG.RowsDefaultCellStyle = DataGridViewCellStyle10
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
        Me.GRID_SONG.TabIndex = 6
        '
        'D_ARTIST
        '
        Me.D_ARTIST.AutoSize = True
        Me.D_ARTIST.ForeColor = System.Drawing.Color.White
        Me.D_ARTIST.Location = New System.Drawing.Point(55, 86)
        Me.D_ARTIST.Name = "D_ARTIST"
        Me.D_ARTIST.Size = New System.Drawing.Size(14, 17)
        Me.D_ARTIST.TabIndex = 7
        Me.D_ARTIST.Text = "-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(7, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Artist :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(7, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Title :"
        '
        'D_TITLE
        '
        Me.D_TITLE.AutoSize = True
        Me.D_TITLE.ForeColor = System.Drawing.Color.White
        Me.D_TITLE.Location = New System.Drawing.Point(55, 114)
        Me.D_TITLE.Name = "D_TITLE"
        Me.D_TITLE.Size = New System.Drawing.Size(14, 17)
        Me.D_TITLE.TabIndex = 10
        Me.D_TITLE.Text = "-"
        '
        'Timer1
        '
        '
        'B_CLOSE
        '
        Me.B_CLOSE.BackColor = System.Drawing.Color.Red
        Me.B_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_CLOSE.ForeColor = System.Drawing.Color.White
        Me.B_CLOSE.Location = New System.Drawing.Point(575, 435)
        Me.B_CLOSE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.B_CLOSE.Name = "B_CLOSE"
        Me.B_CLOSE.Size = New System.Drawing.Size(75, 30)
        Me.B_CLOSE.TabIndex = 16
        Me.B_CLOSE.Text = "Close"
        Me.B_CLOSE.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(262, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 17)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Search by Title or Artist"
        '
        'I_SEARCH
        '
        Me.I_SEARCH.Location = New System.Drawing.Point(265, 58)
        Me.I_SEARCH.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.I_SEARCH.Name = "I_SEARCH"
        Me.I_SEARCH.Size = New System.Drawing.Size(232, 22)
        Me.I_SEARCH.TabIndex = 18
        '
        'TR_DURATION
        '
        Me.TR_DURATION.Location = New System.Drawing.Point(6, 32)
        Me.TR_DURATION.Maximum = 1000
        Me.TR_DURATION.Name = "TR_DURATION"
        Me.TR_DURATION.Size = New System.Drawing.Size(545, 56)
        Me.TR_DURATION.TabIndex = 19
        Me.TR_DURATION.TabStop = False
        Me.TR_DURATION.TickFrequency = 500
        Me.TR_DURATION.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'Timer2
        '
        '
        'D_CUR_DURATION
        '
        Me.D_CUR_DURATION.AutoSize = True
        Me.D_CUR_DURATION.ForeColor = System.Drawing.Color.White
        Me.D_CUR_DURATION.Location = New System.Drawing.Point(557, 47)
        Me.D_CUR_DURATION.Name = "D_CUR_DURATION"
        Me.D_CUR_DURATION.Size = New System.Drawing.Size(32, 17)
        Me.D_CUR_DURATION.TabIndex = 20
        Me.D_CUR_DURATION.Text = "Curr"
        '
        'D_TOT_DURATION
        '
        Me.D_TOT_DURATION.AutoSize = True
        Me.D_TOT_DURATION.ForeColor = System.Drawing.Color.White
        Me.D_TOT_DURATION.Location = New System.Drawing.Point(597, 47)
        Me.D_TOT_DURATION.Name = "D_TOT_DURATION"
        Me.D_TOT_DURATION.Size = New System.Drawing.Size(34, 17)
        Me.D_TOT_DURATION.TabIndex = 21
        Me.D_TOT_DURATION.Text = "Total"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(584, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 17)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "/"
        '
        'B_NEXT
        '
        Me.B_NEXT.BackColor = System.Drawing.Color.Lavender
        Me.B_NEXT.BackgroundImage = Global.AlipMp3Player.My.Resources.Resources._next
        Me.B_NEXT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.B_NEXT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_NEXT.ForeColor = System.Drawing.Color.Silver
        Me.B_NEXT.Location = New System.Drawing.Point(497, 93)
        Me.B_NEXT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.B_NEXT.Name = "B_NEXT"
        Me.B_NEXT.Size = New System.Drawing.Size(30, 30)
        Me.B_NEXT.TabIndex = 24
        Me.ToolTip1.SetToolTip(Me.B_NEXT, "Next")
        Me.B_NEXT.UseVisualStyleBackColor = False
        '
        'B_PREVIOUS
        '
        Me.B_PREVIOUS.BackColor = System.Drawing.Color.Lavender
        Me.B_PREVIOUS.BackgroundImage = CType(resources.GetObject("B_PREVIOUS.BackgroundImage"), System.Drawing.Image)
        Me.B_PREVIOUS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.B_PREVIOUS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_PREVIOUS.ForeColor = System.Drawing.Color.Silver
        Me.B_PREVIOUS.Location = New System.Drawing.Point(461, 93)
        Me.B_PREVIOUS.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.B_PREVIOUS.Name = "B_PREVIOUS"
        Me.B_PREVIOUS.Size = New System.Drawing.Size(30, 30)
        Me.B_PREVIOUS.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.B_PREVIOUS, "Previous")
        Me.B_PREVIOUS.UseVisualStyleBackColor = False
        '
        'B_PAUSE
        '
        Me.B_PAUSE.BackColor = System.Drawing.Color.Lavender
        Me.B_PAUSE.BackgroundImage = Global.AlipMp3Player.My.Resources.Resources.pause
        Me.B_PAUSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.B_PAUSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_PAUSE.ForeColor = System.Drawing.Color.Silver
        Me.B_PAUSE.Location = New System.Drawing.Point(425, 93)
        Me.B_PAUSE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.B_PAUSE.Name = "B_PAUSE"
        Me.B_PAUSE.Size = New System.Drawing.Size(30, 30)
        Me.B_PAUSE.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.B_PAUSE, "Pause")
        Me.B_PAUSE.UseVisualStyleBackColor = False
        '
        'B_STOP
        '
        Me.B_STOP.BackColor = System.Drawing.Color.Lavender
        Me.B_STOP.BackgroundImage = Global.AlipMp3Player.My.Resources.Resources._stop
        Me.B_STOP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.B_STOP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_STOP.ForeColor = System.Drawing.Color.Silver
        Me.B_STOP.Location = New System.Drawing.Point(389, 93)
        Me.B_STOP.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.B_STOP.Name = "B_STOP"
        Me.B_STOP.Size = New System.Drawing.Size(30, 30)
        Me.B_STOP.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.B_STOP, "Stop")
        Me.B_STOP.UseVisualStyleBackColor = False
        '
        'B_RESUME
        '
        Me.B_RESUME.BackColor = System.Drawing.Color.Lavender
        Me.B_RESUME.BackgroundImage = Global.AlipMp3Player.My.Resources.Resources.play
        Me.B_RESUME.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.B_RESUME.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_RESUME.ForeColor = System.Drawing.Color.Silver
        Me.B_RESUME.Location = New System.Drawing.Point(425, 93)
        Me.B_RESUME.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.B_RESUME.Name = "B_RESUME"
        Me.B_RESUME.Size = New System.Drawing.Size(30, 30)
        Me.B_RESUME.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.B_RESUME, "Resume")
        Me.B_RESUME.UseVisualStyleBackColor = False
        '
        'B_LYRIC
        '
        Me.B_LYRIC.BackColor = System.Drawing.Color.Lavender
        Me.B_LYRIC.BackgroundImage = CType(resources.GetObject("B_LYRIC.BackgroundImage"), System.Drawing.Image)
        Me.B_LYRIC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.B_LYRIC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_LYRIC.ForeColor = System.Drawing.Color.Silver
        Me.B_LYRIC.Location = New System.Drawing.Point(533, 93)
        Me.B_LYRIC.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.B_LYRIC.Name = "B_LYRIC"
        Me.B_LYRIC.Size = New System.Drawing.Size(30, 30)
        Me.B_LYRIC.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.B_LYRIC, "View Lyric")
        Me.B_LYRIC.UseVisualStyleBackColor = False
        '
        'B_PLAY
        '
        Me.B_PLAY.BackColor = System.Drawing.Color.Lavender
        Me.B_PLAY.BackgroundImage = Global.AlipMp3Player.My.Resources.Resources.play
        Me.B_PLAY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.B_PLAY.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_PLAY.ForeColor = System.Drawing.Color.Silver
        Me.B_PLAY.Location = New System.Drawing.Point(389, 93)
        Me.B_PLAY.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.B_PLAY.Name = "B_PLAY"
        Me.B_PLAY.Size = New System.Drawing.Size(30, 30)
        Me.B_PLAY.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.B_PLAY, "Play")
        Me.B_PLAY.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.B_NEXT)
        Me.GroupBox1.Controls.Add(Me.B_PREVIOUS)
        Me.GroupBox1.Controls.Add(Me.TR_DURATION)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.D_ARTIST)
        Me.GroupBox1.Controls.Add(Me.D_TOT_DURATION)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.D_CUR_DURATION)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.D_TITLE)
        Me.GroupBox1.Controls.Add(Me.B_PAUSE)
        Me.GroupBox1.Controls.Add(Me.B_STOP)
        Me.GroupBox1.Controls.Add(Me.B_RESUME)
        Me.GroupBox1.Controls.Add(Me.B_LYRIC)
        Me.GroupBox1.Controls.Add(Me.B_PLAY)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(14, 289)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(636, 141)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Playing"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(668, 472)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.I_SEARCH)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.B_CLOSE)
        Me.Controls.Add(Me.GRID_SONG)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CB_PLAYLIST)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Poor Richard", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MP3 PLAYER ALEP"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.GRID_SONG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TR_DURATION, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MENU_ADD As ToolStripMenuItem
    Friend WithEvents MENU_MANAGE As ToolStripMenuItem
    Friend WithEvents CB_PLAYLIST As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GRID_SONG As DataGridView
    Friend WithEvents D_ARTIST As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents D_TITLE As Label
    Friend WithEvents B_PAUSE As Button
    Friend WithEvents B_STOP As Button
    Friend WithEvents B_RESUME As Button
    Friend WithEvents B_PLAY As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents B_LYRIC As Button
    Friend WithEvents PlaylistToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddCategoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageCategoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents B_CLOSE As Button
    Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label4 As Label
    Friend WithEvents I_SEARCH As TextBox
    Friend WithEvents MinimizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TR_DURATION As TrackBar
    Friend WithEvents Timer2 As Timer
    Friend WithEvents D_CUR_DURATION As Label
    Friend WithEvents D_TOT_DURATION As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ShufflePlayerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents B_NEXT As Button
    Friend WithEvents B_PREVIOUS As Button
    Friend WithEvents ConfigurationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BaseURLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShuffleOnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShuffleOffToolStripMenuItem As ToolStripMenuItem
End Class
