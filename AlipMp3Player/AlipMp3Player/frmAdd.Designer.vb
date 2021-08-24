<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdd))
        Me.GRP_NEWS0NG = New System.Windows.Forms.GroupBox()
        Me.B_CLEAR = New System.Windows.Forms.Button()
        Me.D_LYRIC = New System.Windows.Forms.TextBox()
        Me.D_MP3 = New System.Windows.Forms.TextBox()
        Me.B_LYRIC = New System.Windows.Forms.Button()
        Me.B_MP3 = New System.Windows.Forms.Button()
        Me.B_BACK = New System.Windows.Forms.Button()
        Me.B_SUBMIT = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.I_ARTIST = New System.Windows.Forms.TextBox()
        Me.I_TITLE = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OFD_MP3 = New System.Windows.Forms.OpenFileDialog()
        Me.OFD_LYRIC = New System.Windows.Forms.OpenFileDialog()
        Me.GRP_NEWS0NG.SuspendLayout()
        Me.SuspendLayout()
        '
        'GRP_NEWS0NG
        '
        Me.GRP_NEWS0NG.Controls.Add(Me.B_CLEAR)
        Me.GRP_NEWS0NG.Controls.Add(Me.D_LYRIC)
        Me.GRP_NEWS0NG.Controls.Add(Me.D_MP3)
        Me.GRP_NEWS0NG.Controls.Add(Me.B_LYRIC)
        Me.GRP_NEWS0NG.Controls.Add(Me.B_MP3)
        Me.GRP_NEWS0NG.Controls.Add(Me.B_BACK)
        Me.GRP_NEWS0NG.Controls.Add(Me.B_SUBMIT)
        Me.GRP_NEWS0NG.Controls.Add(Me.Label4)
        Me.GRP_NEWS0NG.Controls.Add(Me.I_ARTIST)
        Me.GRP_NEWS0NG.Controls.Add(Me.I_TITLE)
        Me.GRP_NEWS0NG.Controls.Add(Me.Label3)
        Me.GRP_NEWS0NG.Controls.Add(Me.Label2)
        Me.GRP_NEWS0NG.Controls.Add(Me.Label1)
        Me.GRP_NEWS0NG.ForeColor = System.Drawing.Color.White
        Me.GRP_NEWS0NG.Location = New System.Drawing.Point(11, 13)
        Me.GRP_NEWS0NG.Name = "GRP_NEWS0NG"
        Me.GRP_NEWS0NG.Size = New System.Drawing.Size(312, 328)
        Me.GRP_NEWS0NG.TabIndex = 0
        Me.GRP_NEWS0NG.TabStop = False
        Me.GRP_NEWS0NG.Text = "Add New Song"
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
        'D_LYRIC
        '
        Me.D_LYRIC.Location = New System.Drawing.Point(118, 122)
        Me.D_LYRIC.Name = "D_LYRIC"
        Me.D_LYRIC.ReadOnly = True
        Me.D_LYRIC.Size = New System.Drawing.Size(123, 22)
        Me.D_LYRIC.TabIndex = 11
        '
        'D_MP3
        '
        Me.D_MP3.Location = New System.Drawing.Point(118, 90)
        Me.D_MP3.Name = "D_MP3"
        Me.D_MP3.ReadOnly = True
        Me.D_MP3.Size = New System.Drawing.Size(123, 22)
        Me.D_MP3.TabIndex = 10
        '
        'B_LYRIC
        '
        Me.B_LYRIC.ForeColor = System.Drawing.Color.Black
        Me.B_LYRIC.Location = New System.Drawing.Point(242, 122)
        Me.B_LYRIC.Name = "B_LYRIC"
        Me.B_LYRIC.Size = New System.Drawing.Size(66, 23)
        Me.B_LYRIC.TabIndex = 9
        Me.B_LYRIC.Text = "Browse"
        Me.B_LYRIC.UseVisualStyleBackColor = True
        '
        'B_MP3
        '
        Me.B_MP3.ForeColor = System.Drawing.Color.Black
        Me.B_MP3.Location = New System.Drawing.Point(242, 90)
        Me.B_MP3.Name = "B_MP3"
        Me.B_MP3.Size = New System.Drawing.Size(66, 23)
        Me.B_MP3.TabIndex = 8
        Me.B_MP3.Text = "Browse"
        Me.B_MP3.UseVisualStyleBackColor = True
        '
        'B_BACK
        '
        Me.B_BACK.BackColor = System.Drawing.Color.Red
        Me.B_BACK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_BACK.Location = New System.Drawing.Point(218, 272)
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
        Me.B_SUBMIT.Location = New System.Drawing.Point(124, 272)
        Me.B_SUBMIT.Name = "B_SUBMIT"
        Me.B_SUBMIT.Size = New System.Drawing.Size(88, 50)
        Me.B_SUBMIT.TabIndex = 6
        Me.B_SUBMIT.Text = "Submit"
        Me.B_SUBMIT.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Lyric Path (.txt) :"
        '
        'I_ARTIST
        '
        Me.I_ARTIST.Location = New System.Drawing.Point(118, 59)
        Me.I_ARTIST.Name = "I_ARTIST"
        Me.I_ARTIST.Size = New System.Drawing.Size(190, 22)
        Me.I_ARTIST.TabIndex = 4
        '
        'I_TITLE
        '
        Me.I_TITLE.Location = New System.Drawing.Point(118, 31)
        Me.I_TITLE.Name = "I_TITLE"
        Me.I_TITLE.Size = New System.Drawing.Size(190, 22)
        Me.I_TITLE.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Audio Path (.mp3) :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Artist :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 31)
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
        'frmAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(334, 353)
        Me.ControlBox = False
        Me.Controls.Add(Me.GRP_NEWS0NG)
        Me.Font = New System.Drawing.Font("Poor Richard", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADD NEW SONG"
        Me.GRP_NEWS0NG.ResumeLayout(False)
        Me.GRP_NEWS0NG.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GRP_NEWS0NG As GroupBox
    Friend WithEvents B_SUBMIT As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents I_ARTIST As TextBox
    Friend WithEvents I_TITLE As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents B_BACK As Button
    Friend WithEvents OFD_MP3 As OpenFileDialog
    Friend WithEvents OFD_LYRIC As OpenFileDialog
    Friend WithEvents B_LYRIC As Button
    Friend WithEvents B_MP3 As Button
    Friend WithEvents D_LYRIC As TextBox
    Friend WithEvents D_MP3 As TextBox
    Friend WithEvents B_CLEAR As Button
End Class
