Imports System.Data.SqlClient
Imports System.IO

Public Class frmAdd

    Dim songLogic As New SongLogic

    Private Sub B_BACK_Click(sender As Object, e As EventArgs) Handles B_BACK.Click
        Me.Close()
    End Sub

    Private Sub B_MP3_Click(sender As Object, e As EventArgs) Handles B_MP3.Click

        Dim result As DialogResult = OFD_MP3.ShowDialog()

        If result = DialogResult.OK Then
            Dim mp3Path As String = OFD_MP3.FileName
            Try
                D_MP3.Text = mp3Path.ToString
                D_MP3.Focus()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub B_LYRIC_Click(sender As Object, e As EventArgs) Handles B_LYRIC.Click
        Dim result As DialogResult = OFD_LYRIC.ShowDialog()

        If result = DialogResult.OK Then
            Dim lyricPath As String = OFD_LYRIC.FileName
            Try
                D_LYRIC.Text = lyricPath.ToString
                D_LYRIC.Focus()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub B_SUBMIT_Click(sender As Object, e As EventArgs) Handles B_SUBMIT.Click

        If (I_TITLE.Text.Trim = "" Or I_ARTIST.Text.Trim = "" Or D_MP3.Text.Trim = "" Or D_LYRIC.Text.Trim = "") Then
            MessageBox.Show("Some textbox empty")
            I_TITLE.Focus()
        Else
            songLogic.songs.SongTitle = I_TITLE.Text
            songLogic.songs.SongArtist = I_ARTIST.Text
            songLogic.songs.SongMp3Path = D_MP3.Text
            songLogic.songs.SongLyricPath = D_LYRIC.Text

            If CBool((Me.songLogic.InsertSong())) Then
                MessageBox.Show("New Song inserted")
                Clear()
            Else
                MessageBox.Show("Insert failed")
            End If
        End If
    End Sub

    Private Sub Clear()
        'Clear textbox
        I_TITLE.Text = ""
        I_ARTIST.Text = ""
        D_MP3.Text = ""
        D_LYRIC.Text = ""

        'Clear object
        songLogic.songs.SongTitle = ""
        songLogic.songs.SongArtist = ""
        songLogic.songs.SongMp3Path = ""
        songLogic.songs.SongLyricPath = ""

        I_TITLE.Focus()
    End Sub

    Private Sub B_CLEAR_Click(sender As Object, e As EventArgs) Handles B_CLEAR.Click
        Clear()
    End Sub
End Class