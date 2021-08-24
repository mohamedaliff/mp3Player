<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLyric
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLyric))
        Me.D_LYRIC = New System.Windows.Forms.TextBox()
        Me.B_CLOSE = New System.Windows.Forms.Button()
        Me.D_TITLE = New System.Windows.Forms.Label()
        Me.D_ARTIST = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.B_UPDATE = New System.Windows.Forms.Button()
        Me.B_EDIT = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'D_LYRIC
        '
        Me.D_LYRIC.BackColor = System.Drawing.Color.Black
        Me.D_LYRIC.Font = New System.Drawing.Font("Poor Richard", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D_LYRIC.ForeColor = System.Drawing.Color.White
        Me.D_LYRIC.Location = New System.Drawing.Point(10, 60)
        Me.D_LYRIC.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.D_LYRIC.Multiline = True
        Me.D_LYRIC.Name = "D_LYRIC"
        Me.D_LYRIC.ReadOnly = True
        Me.D_LYRIC.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.D_LYRIC.Size = New System.Drawing.Size(377, 467)
        Me.D_LYRIC.TabIndex = 0
        Me.D_LYRIC.TabStop = False
        '
        'B_CLOSE
        '
        Me.B_CLOSE.BackColor = System.Drawing.Color.Red
        Me.B_CLOSE.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.B_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_CLOSE.Location = New System.Drawing.Point(320, 533)
        Me.B_CLOSE.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.B_CLOSE.Name = "B_CLOSE"
        Me.B_CLOSE.Size = New System.Drawing.Size(66, 23)
        Me.B_CLOSE.TabIndex = 15
        Me.B_CLOSE.Text = "Close"
        Me.B_CLOSE.UseVisualStyleBackColor = False
        '
        'D_TITLE
        '
        Me.D_TITLE.AutoSize = True
        Me.D_TITLE.Location = New System.Drawing.Point(10, 13)
        Me.D_TITLE.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.D_TITLE.Name = "D_TITLE"
        Me.D_TITLE.Size = New System.Drawing.Size(32, 17)
        Me.D_TITLE.TabIndex = 16
        Me.D_TITLE.Text = "Title"
        '
        'D_ARTIST
        '
        Me.D_ARTIST.AutoSize = True
        Me.D_ARTIST.Location = New System.Drawing.Point(10, 35)
        Me.D_ARTIST.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.D_ARTIST.Name = "D_ARTIST"
        Me.D_ARTIST.Size = New System.Drawing.Size(38, 17)
        Me.D_ARTIST.TabIndex = 17
        Me.D_ARTIST.Text = "Artist"
        '
        'B_UPDATE
        '
        Me.B_UPDATE.BackColor = System.Drawing.Color.Lavender
        Me.B_UPDATE.BackgroundImage = Global.AlipMp3Player.My.Resources.Resources.folder
        Me.B_UPDATE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.B_UPDATE.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.B_UPDATE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_UPDATE.Location = New System.Drawing.Point(354, 12)
        Me.B_UPDATE.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.B_UPDATE.Name = "B_UPDATE"
        Me.B_UPDATE.Size = New System.Drawing.Size(30, 30)
        Me.B_UPDATE.TabIndex = 19
        Me.ToolTip1.SetToolTip(Me.B_UPDATE, "Update Lyric")
        Me.B_UPDATE.UseVisualStyleBackColor = False
        '
        'B_EDIT
        '
        Me.B_EDIT.BackColor = System.Drawing.Color.Lavender
        Me.B_EDIT.BackgroundImage = Global.AlipMp3Player.My.Resources.Resources.pencil
        Me.B_EDIT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.B_EDIT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.B_EDIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_EDIT.Location = New System.Drawing.Point(354, 13)
        Me.B_EDIT.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.B_EDIT.Name = "B_EDIT"
        Me.B_EDIT.Size = New System.Drawing.Size(30, 30)
        Me.B_EDIT.TabIndex = 18
        Me.ToolTip1.SetToolTip(Me.B_EDIT, "Edit Lyric")
        Me.B_EDIT.UseVisualStyleBackColor = False
        '
        'frmLyric
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(397, 567)
        Me.ControlBox = False
        Me.Controls.Add(Me.B_UPDATE)
        Me.Controls.Add(Me.B_EDIT)
        Me.Controls.Add(Me.D_ARTIST)
        Me.Controls.Add(Me.D_TITLE)
        Me.Controls.Add(Me.B_CLOSE)
        Me.Controls.Add(Me.D_LYRIC)
        Me.Font = New System.Drawing.Font("Poor Richard", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmLyric"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lyric"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents D_LYRIC As TextBox
    Friend WithEvents B_CLOSE As Button
    Friend WithEvents D_TITLE As Label
    Friend WithEvents D_ARTIST As Label
    Friend WithEvents B_EDIT As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents B_UPDATE As Button
End Class
