Public Class frmMain

    Public songLogic As New SongLogic
    Dim categoryLogic As New CategoryLogic
    Dim players As New Player

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        RefreshForm()

    End Sub

    Private Sub CB_PLAYLIST_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CB_PLAYLIST.SelectionChangeCommitted
        Try
            Dim selCategory As Integer = CInt(CB_PLAYLIST.SelectedValue)

            Dim dataset1 As New System.Data.DataSet

            'Bind the value inside list of customer into gridview
            Dim source = New BindingSource(songLogic.GetAllSongByPlaylist(selCategory), Nothing)
            GRID_SONG.DataSource = songLogic.GetAllSongByPlaylist(selCategory)

            Dim block As Boolean = False

            dataset1.Clear()

            dataset1 = songLogic.GetAllSongByPlaylist(selCategory)

            GRID_SONG.DataSource = dataset1.Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Exception Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        Return
        End Try
    End Sub

    Private Sub GRID_SONG_SelectionChanged(sender As Object, e As EventArgs) Handles GRID_SONG.SelectionChanged

        Try

            Dim rowsCount As Integer = GRID_SONG.SelectedRows.Count

            If (rowsCount = 0) Then
                Return
            End If



            InitButton()
            PlayAudio()

            B_PAUSE.Enabled = True
            B_PAUSE.Visible = True

            B_STOP.Enabled = True
            B_LYRIC.Enabled = True


        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Exception Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Dim counter As Integer = GRID_SONG.CurrentRow.Index + 1

            If counter > GRID_SONG.RowCount Then

                If (players.RandomTrack) Then
                    ShuffleTrack()
                Else
                    GRID_SONG.Rows(0).Selected = True
                    GRID_SONG.CurrentCell = GRID_SONG.Rows(0).Cells(0)
                End If

            Else

                If (players.RandomTrack) Then
                    ShuffleTrack()
                Else

                    GRID_SONG.Rows(counter).Selected = True
                    GRID_SONG.CurrentCell = GRID_SONG.Rows(counter).Cells(0)

                End If
            End If

            For Each frm As Form In Application.OpenForms
                If frm.Name.Equals("frmLyric") Then
                    frm.Close()
                End If
            Next

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Exception Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Return
        End Try
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Try
            Dim audio As New AudioFile(songLogic.songs.SongMp3Path)

            songLogic.songs.SongCurDuration = CInt(audio.SecondsPlayed)

            If (songLogic.songs.SongCurDuration < songLogic.songs.SongLength) Then

                Timer2.Interval = 1000
                TR_DURATION.Value = (songLogic.songs.SongCurDuration / songLogic.songs.SongLength) * 1000


                Dim ts As TimeSpan = TimeSpan.FromMilliseconds(songLogic.songs.SongCurDuration)
                D_CUR_DURATION.Text = ts.Minutes.ToString & ":" & ts.Seconds.ToString
            Else
                Return
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Exception Error", MessageBoxButtons.OK)
            Return
        End Try
    End Sub



#Region "MENU STRIP"

    Private Sub AddCategoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddCategoryToolStripMenuItem.Click
        Dim frmAddCategory As New frmAddCategory
        frmAddCategory.ShowDialog()
    End Sub

    Private Sub ManageCategoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageCategoryToolStripMenuItem.Click
        Dim frmManageCategory As New frmManageCategory
        frmManageCategory.ShowDialog()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        RefreshForm()
    End Sub

    Private Sub NewPlaylistToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlaylistToolStripMenuItem.Click

        Dim frmAddInPlaylist As New frmAddInPlaylist
        frmAddInPlaylist.ShowDialog()

    End Sub

    Private Sub MinimizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinimizeToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BaseURLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BaseURLToolStripMenuItem.Click
        Dim frmBaseURL As New frmBaseURL
        frmBaseURL.ShowDialog()
    End Sub

    Private Sub ShuffleOnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShuffleOnToolStripMenuItem.Click
        players.RandomTrack = True
        ShuffleTrack()
        ShuffleOnToolStripMenuItem.Checked = True
        ShuffleOffToolStripMenuItem.Checked = False
    End Sub

    Private Sub ShuffleOffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShuffleOffToolStripMenuItem.Click
        players.RandomTrack = False
        ShuffleOffToolStripMenuItem.Checked = True
        ShuffleOnToolStripMenuItem.Checked = False
    End Sub
#End Region

#Region "BUTTON CLICK"

    Private Sub I_SEARCH_TextChanged(sender As Object, e As EventArgs) Handles I_SEARCH.TextChanged
        Try
            Dim dataset1 As New System.Data.DataSet

            Dim Keyword As String = I_SEARCH.Text.Trim
            Dim selCategory As Integer = CInt(CB_PLAYLIST.SelectedValue)

            If (selCategory > 0) Then

                'Bind the value inside list of customer into gridview
                Dim source = New BindingSource(songLogic.GetAllSongByKeywordAndCategory(Keyword, selCategory), Nothing)
                GRID_SONG.DataSource = songLogic.GetAllSongByKeywordAndCategory(Keyword, selCategory)

                Dim block As Boolean = False

                dataset1.Clear()

                dataset1 = songLogic.GetAllSongByKeywordAndCategory(Keyword, selCategory)

                GRID_SONG.DataSource = dataset1.Tables(0)

            Else
                'Bind the value inside list of customer into gridview
                Dim source = New BindingSource(songLogic.GetAllSongByKeyword(Keyword), Nothing)
                GRID_SONG.DataSource = songLogic.GetAllSongByKeyword(Keyword)

                Dim block As Boolean = False

                dataset1.Clear()

                dataset1 = songLogic.GetAllSongByKeyword(Keyword)

                GRID_SONG.DataSource = dataset1.Tables(0)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Exception Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Return
        End Try
    End Sub

    Private Sub B_PREVIOUS_Click(sender As Object, e As EventArgs) Handles B_PREVIOUS.Click

        Try

            Dim rowsCount As Integer = GRID_SONG.RowCount
            Dim rowsSelected As Integer = GRID_SONG.SelectedRows(0).Index

            If (players.RandomTrack = True) Then
                ShuffleTrack()
            Else

                If (rowsCount > 0 And rowsSelected > 0) Then
                    GRID_SONG.Rows(rowsSelected - 1).Selected = True
                    GRID_SONG.CurrentCell = GRID_SONG.Item(1, rowsSelected - 1)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("This is the first audio")
        End Try
    End Sub

    Private Sub B_NEXT_Click(sender As Object, e As EventArgs) Handles B_NEXT.Click
        Try
            Dim rowsCount As Integer = GRID_SONG.RowCount
            Dim rowsSelected As Integer = GRID_SONG.SelectedRows(0).Index

            If (players.RandomTrack = True) Then
                ShuffleTrack()
            Else
                If (rowsSelected < rowsCount) Then
                    GRID_SONG.Rows(rowsSelected + 1).Selected = True
                    GRID_SONG.CurrentCell = GRID_SONG.Item(1, rowsSelected + 1)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("This is the last audio")
        End Try
    End Sub

    Private Sub B_LYRIC_Click(sender As Object, e As EventArgs) Handles B_LYRIC.Click
        Dim frmLyric As New frmLyric
        frmLyric.ShowDialog()
    End Sub

    Private Sub MENU_MANAGE_Click(sender As Object, e As EventArgs) Handles MENU_MANAGE.Click
        Dim frmManageSong As New frmManageSong
        frmManageSong.ShowDialog()
    End Sub

    Private Sub MENU_ADD_Click(sender As Object, e As EventArgs) Handles MENU_ADD.Click
        Dim frmAdd As New frmAdd
        frmAdd.ShowDialog()
    End Sub

    Private Sub B_CLOSE_Click(sender As Object, e As EventArgs) Handles B_CLOSE.Click
        Me.Close()
    End Sub

    Private Sub B_PAUSE_Click(sender As Object, e As EventArgs) Handles B_PAUSE.Click
        Dim audio As New AudioFile(songLogic.songs.SongMp3Path)
        audio.Pause()
        Timer1.Enabled = False
        Timer2.Enabled = False

        B_RESUME.Enabled = True
        B_RESUME.Visible = True

        B_PAUSE.Enabled = False
        B_PAUSE.Visible = False

    End Sub

    Private Sub B_STOP_Click(sender As Object, e As EventArgs) Handles B_STOP.Click
        Dim audio As New AudioFile(songLogic.songs.SongMp3Path)
        audio.Stop()
        Timer1.Stop()

        TR_DURATION.Value = 0

        Timer2.Stop()

        B_PLAY.Enabled = True
        B_PLAY.Visible = True

        B_LYRIC.Enabled = False

        B_RESUME.Enabled = False
        B_RESUME.Visible = False

        B_PAUSE.Enabled = False
        B_PAUSE.Visible = True

        B_STOP.Enabled = False
        B_STOP.Visible = False



    End Sub

    Private Sub B_PLAY_Click(sender As Object, e As EventArgs) Handles B_PLAY.Click
        Dim audio As New AudioFile(songLogic.songs.SongMp3Path)
        audio.Close()
        audio.Play()

        Timer2.Start()

        InitButton()

    End Sub

    Private Sub B_RESUME_Click(sender As Object, e As EventArgs) Handles B_RESUME.Click
        Dim audio As New AudioFile(songLogic.songs.SongMp3Path)
        audio.Resume()
        Timer1.Enabled = True
        Timer2.Enabled = True

        B_RESUME.Enabled = False
        B_RESUME.Visible = False

        B_PAUSE.Enabled = True
        B_PAUSE.Visible = True

    End Sub


#End Region

#Region "NORMAL METHOD"

    Public Sub RefreshForm()
        Try
            players.RandomTrack = False
            Dim dataset1 As New System.Data.DataSet

            Me.categoryLogic.GetCategoryList(CB_PLAYLIST) 'Load categories into drop down list

            'Bind the value inside list of customer into gridview
            Dim source = New BindingSource(songLogic.GetAllSong(), Nothing)
            GRID_SONG.DataSource = songLogic.GetAllSong()

            Dim block As Boolean = False

            dataset1.Clear()

            dataset1 = songLogic.GetAllSong()

            GRID_SONG.DataSource = dataset1.Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Exception Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Return
        End Try
    End Sub

    Private Sub ShuffleTrack()
        Try
            Dim random As New Random
            Dim rowsCount As Integer = GRID_SONG.RowCount
            Dim randomNumber As Integer
            randomNumber = random.Next(1, rowsCount)

            If (rowsCount > 1 And randomNumber <= rowsCount) Then

                GRID_SONG.Rows(randomNumber).Selected = True
                GRID_SONG.CurrentCell = GRID_SONG.Item(1, randomNumber)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Exception Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Return
        End Try
    End Sub

    Private Sub PlayAudio()

        Try

            Dim selSongID As Integer

            selSongID = CInt(GRID_SONG.SelectedRows(0).Cells(0).Value)

            If (selSongID <> 0) Then

                Me.songLogic.GetSongById(selSongID)
                Dim songs As List(Of Song) = Me.songLogic.GetSongById(selSongID)

                D_ARTIST.Text = songs(0).SongArtist
                D_TITLE.Text = songs(0).SongTitle

                songLogic.songs.SongTitle = songs(0).SongTitle
                songLogic.songs.SongArtist = songs(0).SongArtist
                songLogic.songs.SongMp3Path = songs(0).SongMp3Path
                songLogic.songs.SongID = songs(0).SongID
                songLogic.songs.SongLyricPath = songs(0).SongLyricPath


                Dim audio As New AudioFile(songLogic.songs.SongMp3Path)
                audio.Close()
                audio.Play()


                songLogic.songs.SongLength = audio.Milleseconds

                Dim ts As TimeSpan = TimeSpan.FromMilliseconds(songLogic.songs.SongLength)
                D_TOT_DURATION.Text = ts.Minutes.ToString & ":" & ts.Seconds.ToString

                Timer1.Interval = songLogic.songs.SongLength + 500
                Timer1.Start()
                Timer2.Start()


            Else
                MessageBox.Show("Playlist ended")
                Return
            End If

        Catch ex As Exception
            MessageBox.Show("Playlist ended. Restarting playlist..")
            Return
        End Try
    End Sub

    Private Sub InitButton()
        B_PLAY.Enabled = False
        B_PLAY.Visible = False

        B_PAUSE.Enabled = True
        B_PAUSE.Visible = True

        B_STOP.Enabled = True
        B_STOP.Visible = True

        B_RESUME.Enabled = False
        B_RESUME.Visible = False

        B_LYRIC.Enabled = False

        ShuffleOnToolStripMenuItem.Checked = False
        ShuffleOffToolStripMenuItem.Checked = True
    End Sub








#End Region

End Class
