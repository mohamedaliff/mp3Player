<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBaseURL
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBaseURL))
        Me.GRP_NEWCATE = New System.Windows.Forms.GroupBox()
        Me.I_PATH_LYRIC = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.B_CLEAR = New System.Windows.Forms.Button()
        Me.B_BACK = New System.Windows.Forms.Button()
        Me.B_SUBMIT = New System.Windows.Forms.Button()
        Me.I_PATH_MP3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GRP_NEWCATE.SuspendLayout()
        Me.SuspendLayout()
        '
        'GRP_NEWCATE
        '
        Me.GRP_NEWCATE.Controls.Add(Me.I_PATH_LYRIC)
        Me.GRP_NEWCATE.Controls.Add(Me.Label2)
        Me.GRP_NEWCATE.Controls.Add(Me.B_CLEAR)
        Me.GRP_NEWCATE.Controls.Add(Me.B_BACK)
        Me.GRP_NEWCATE.Controls.Add(Me.B_SUBMIT)
        Me.GRP_NEWCATE.Controls.Add(Me.I_PATH_MP3)
        Me.GRP_NEWCATE.Controls.Add(Me.Label1)
        Me.GRP_NEWCATE.ForeColor = System.Drawing.Color.White
        Me.GRP_NEWCATE.Location = New System.Drawing.Point(10, 12)
        Me.GRP_NEWCATE.Name = "GRP_NEWCATE"
        Me.GRP_NEWCATE.Size = New System.Drawing.Size(312, 328)
        Me.GRP_NEWCATE.TabIndex = 2
        Me.GRP_NEWCATE.TabStop = False
        Me.GRP_NEWCATE.Text = "Base URL"
        '
        'I_PATH_LYRIC
        '
        Me.I_PATH_LYRIC.Cursor = System.Windows.Forms.Cursors.Default
        Me.I_PATH_LYRIC.Location = New System.Drawing.Point(118, 59)
        Me.I_PATH_LYRIC.Name = "I_PATH_LYRIC"
        Me.I_PATH_LYRIC.Size = New System.Drawing.Size(190, 22)
        Me.I_PATH_LYRIC.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Lyric Base Path :"
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
        Me.B_BACK.Location = New System.Drawing.Point(222, 272)
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
        Me.B_SUBMIT.Location = New System.Drawing.Point(128, 272)
        Me.B_SUBMIT.Name = "B_SUBMIT"
        Me.B_SUBMIT.Size = New System.Drawing.Size(88, 50)
        Me.B_SUBMIT.TabIndex = 6
        Me.B_SUBMIT.Text = "Submit"
        Me.B_SUBMIT.UseVisualStyleBackColor = False
        '
        'I_PATH_MP3
        '
        Me.I_PATH_MP3.Cursor = System.Windows.Forms.Cursors.Default
        Me.I_PATH_MP3.Location = New System.Drawing.Point(118, 31)
        Me.I_PATH_MP3.Name = "I_PATH_MP3"
        Me.I_PATH_MP3.Size = New System.Drawing.Size(190, 22)
        Me.I_PATH_MP3.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mp3 Base Path :"
        '
        'frmBaseURL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(329, 345)
        Me.ControlBox = False
        Me.Controls.Add(Me.GRP_NEWCATE)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBaseURL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Base URL"
        Me.GRP_NEWCATE.ResumeLayout(False)
        Me.GRP_NEWCATE.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GRP_NEWCATE As GroupBox
    Friend WithEvents B_CLEAR As Button
    Friend WithEvents B_BACK As Button
    Friend WithEvents B_SUBMIT As Button
    Friend WithEvents I_PATH_MP3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents I_PATH_LYRIC As TextBox
    Friend WithEvents Label2 As Label
End Class
