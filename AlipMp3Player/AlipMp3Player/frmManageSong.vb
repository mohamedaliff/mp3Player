Public Class frmManageSong

    Dim songLogic As New SongLogic
    Dim songs As New Song

    Private Sub frmManageSong_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RefreshTable()

    End Sub

    Private Sub RefreshTable()
        Dim dataset1 As New System.Data.DataSet

        'Bind the value inside list of customer into gridview
        Dim source = New BindingSource(songLogic.GetAllSong(), Nothing)
        GRID_SONG.DataSource = songLogic.GetAllSong()

        Dim block As Boolean = False

        dataset1.Clear()

        dataset1 = songLogic.GetAllSong()

        GRID_SONG.DataSource = dataset1.Tables(0)
    End Sub

    Private Sub GRID_SONG_SelectionChanged(sender As Object, e As EventArgs) Handles GRID_SONG.SelectionChanged
        Try

            Dim rowsCount As Integer = GRID_SONG.SelectedRows.Count

            If (rowsCount = 0 Or rowsCount > 1) Then
                Return
            End If

            Dim selSongID As Integer

            selSongID = GRID_SONG.SelectedRows(0).Cells(0).Value

            If (selSongID > 0) Then

                Me.songLogic.GetSongById(selSongID)
                Dim songs As List(Of Song) = Me.songLogic.GetSongById(selSongID)

                I_ARTIST.Text = songs(0).SongArtist
                I_TITLE.Text = songs(0).SongTitle
                D_MP3.Text = songs(0).SongMp3Path
                D_LYRIC.Text = songs(0).SongLyricPath
                D_ID.Text = songs(0).SongID

                songLogic.songs.SongMp3Path = songs(0).SongMp3Path
                songLogic.songs.SongID = songs(0).SongID

            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Exception Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
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

    Private Sub B_CLEAR_Click(sender As Object, e As EventArgs) Handles B_CLEAR.Click
        Clear()
    End Sub

    Private Sub Clear()
        'Clear textbox
        I_TITLE.Text = ""
        I_ARTIST.Text = ""
        D_MP3.Text = ""
        D_LYRIC.Text = ""
        D_ID.Text = ""

        'Clear object
        songLogic.songs.SongTitle = ""
        songLogic.songs.SongArtist = ""
        songLogic.songs.SongMp3Path = ""
        songLogic.songs.SongLyricPath = ""

        I_TITLE.Focus()
    End Sub

    Private Sub B_SUBMIT_Click(sender As Object, e As EventArgs) Handles B_SUBMIT.Click
        'Try

        If (I_TITLE.Text.Trim = "" Or I_ARTIST.Text.Trim = "" Or D_MP3.Text.Trim = "" Or D_LYRIC.Text.Trim = "") Then
            MessageBox.Show("Some textbox empty")
            I_TITLE.Focus()
        Else
            songLogic.songs.SongTitle = I_TITLE.Text
            songLogic.songs.SongArtist = I_ARTIST.Text
            songLogic.songs.SongMp3Path = D_MP3.Text
            songLogic.songs.SongLyricPath = D_LYRIC.Text

            If CBool((Me.songLogic.UpdateSong(CInt(D_ID.Text.Trim)))) Then
                MessageBox.Show("Song updated")
                Clear()
                RefreshTable()
            Else
                MessageBox.Show("Update failed")
            End If
        End If

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub

    Private Sub B_DELETE_Click(sender As Object, e As EventArgs) Handles B_DELETE.Click
        Try

            If (D_ID.Text.Trim = "") Then
                MessageBox.Show("No song selected")
                I_TITLE.Focus()
            Else

                If CBool((Me.songLogic.DeleteSong(CInt(D_ID.Text.Trim)))) Then
                    MessageBox.Show("Song deleted")
                    Clear()
                    RefreshTable()
                Else
                    MessageBox.Show("Delete failed")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub B_BACK_Click(sender As Object, e As EventArgs) Handles B_BACK.Click
        Me.Close()
    End Sub

    Private Sub I_SEARCH_TextChanged(sender As Object, e As EventArgs) Handles I_SEARCH.TextChanged
        Dim dataset1 As New System.Data.DataSet

        Dim Keyword As String = I_SEARCH.Text.Trim

        'Bind the value inside list of customer into gridview
        Dim source = New BindingSource(songLogic.GetAllSongByKeyword(Keyword), Nothing)
        GRID_SONG.DataSource = songLogic.GetAllSongByKeyword(Keyword)

        Dim block As Boolean = False

        dataset1.Clear()

        dataset1 = songLogic.GetAllSongByKeyword(Keyword)

        GRID_SONG.DataSource = dataset1.Tables(0)
    End Sub

End Class