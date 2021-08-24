Public Class frmLyric

    Private Sub B_CLOSE_Click(sender As Object, e As EventArgs) Handles B_CLOSE.Click
        Me.Close()
    End Sub

    Private Sub frmLyric_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Dim lyricPath As String = frmMain.songLogic.songs.SongLyricPath
            Dim title As String = frmMain.songLogic.songs.SongTitle
            Dim artist As String = frmMain.songLogic.songs.SongArtist

            D_TITLE.Text = title
            D_ARTIST.Text = artist

            For Each lyric As String In System.IO.File.ReadAllLines(lyricPath)
                D_LYRIC.AppendText(lyric + vbNewLine)
            Next

            B_EDIT.Visible = True
            B_UPDATE.Visible = False


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub B_UPDATE_Click(sender As Object, e As EventArgs) Handles B_UPDATE.Click
        UpdateLyric()
        B_EDIT.Visible = True
        B_UPDATE.Visible = False
        D_LYRIC.ReadOnly = True
    End Sub

    Private Sub B_EDIT_Click(sender As Object, e As EventArgs) Handles B_EDIT.Click
        D_LYRIC.ReadOnly = False
        D_LYRIC.Focus()
        B_UPDATE.Visible = True
        B_EDIT.Visible = False
    End Sub


    Private Sub UpdateLyric()
        Dim lyricPath As String = frmMain.songLogic.songs.SongLyricPath
        If System.IO.File.Exists(lyricPath) = True Then
            Dim objWriter As New System.IO.StreamWriter(lyricPath)
            objWriter.Write(D_LYRIC.Text)
            objWriter.Close()
        Else
            MsgBox("Update failed")
        End If
    End Sub

End Class