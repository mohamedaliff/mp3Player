Public Class frmAddInPlaylist

    Public playlistLogic As New PlaylistLogic
    Dim categoryLogic As New CategoryLogic
    Private Sub CB_PLAYLIST_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CB_PLAYLIST.SelectionChangeCommitted

        RefreshTable()
        Dim selCategory As Integer = CInt(Me.CB_PLAYLIST.SelectedValue)
        If (selCategory > 0) Then
            I_SEARCH_ALL.Enabled = True
            I_SEARCH_PLAY.Enabled = True
        End If

    End Sub

    Private Sub frmAddInPlaylist_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.categoryLogic.GetCategoryList(CB_PLAYLIST) 'Load categories into drop down list
        I_SEARCH_ALL.Enabled = False
        I_SEARCH_PLAY.Enabled = False

    End Sub

    Private Sub B_BACK_Click(sender As Object, e As EventArgs) Handles B_BACK.Click
        Me.Close()
    End Sub

    Private Sub RefreshTable()
        Dim selCategory As Integer = CInt(CB_PLAYLIST.SelectedValue)

        Dim dataset1 As New System.Data.DataSet
        Dim dataset2 As New System.Data.DataSet

        'Bind the value inside list of customer into gridview
        Dim source1 = New BindingSource(playlistLogic.GetAllSongNotInPlaylist(selCategory), Nothing)
        GRID_NOT_IN_SONG.DataSource = playlistLogic.GetAllSongNotInPlaylist(selCategory)
        'Bind the value inside list of customer into gridview
        Dim source2 = New BindingSource(playlistLogic.GetAllSongInPlaylist(selCategory), Nothing)
        GRID_IN_SONG.DataSource = playlistLogic.GetAllSongInPlaylist(selCategory)

        Dim block As Boolean = False

        dataset1.Clear()
        dataset2.Clear()

        dataset1 = playlistLogic.GetAllSongNotInPlaylist(selCategory)
        dataset2 = playlistLogic.GetAllSongInPlaylist(selCategory)

        GRID_NOT_IN_SONG.DataSource = dataset1.Tables(0)
        GRID_IN_SONG.DataSource = dataset2.Tables(0)
    End Sub

    Private Sub B_ADD_Click(sender As Object, e As EventArgs) Handles B_ADD.Click

        playlistLogic.playlists.SongID = CInt(GRID_NOT_IN_SONG.SelectedRows(0).Cells(0).Value)
        playlistLogic.playlists.CategoryID = CInt(CB_PLAYLIST.SelectedValue)

        If CBool((Me.playlistLogic.InsertPlaylist())) Then
            RefreshTable()
        Else
            MessageBox.Show("Insert failed")
        End If

    End Sub

    Private Sub B_REMOVE_Click(sender As Object, e As EventArgs) Handles B_REMOVE.Click

        Dim SongID As Integer = CInt(GRID_IN_SONG.SelectedRows(0).Cells(0).Value)
        Dim CategoryID As Integer = CInt(CB_PLAYLIST.SelectedValue)

        If CBool((Me.playlistLogic.DeleteSong(SongID, CategoryID))) Then
            RefreshTable()
        Else
            MessageBox.Show("Delete failed")
        End If

    End Sub

    Private Sub I_SEARCH_ALL_TextChanged(sender As Object, e As EventArgs) Handles I_SEARCH_ALL.TextChanged
        Try
            Dim dataset1 As New System.Data.DataSet

            Dim Keyword As String = I_SEARCH_ALL.Text.Trim
            Dim selCategory As Integer = CInt(Me.CB_PLAYLIST.SelectedValue)



            If (selCategory > 0) Then

                'Bind the value inside list of customer into gridview
                Dim source = New BindingSource(playlistLogic.GetAllSongNotInPlaylistByKeyword(selCategory, Keyword), Nothing)
                GRID_NOT_IN_SONG.DataSource = playlistLogic.GetAllSongNotInPlaylistByKeyword(selCategory, Keyword)

                Dim block As Boolean = False

                dataset1.Clear()

                dataset1 = playlistLogic.GetAllSongNotInPlaylistByKeyword(selCategory, Keyword)

                GRID_NOT_IN_SONG.DataSource = dataset1.Tables(0)

            Else
                I_SEARCH_ALL.Text = ""
                I_SEARCH_ALL.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Exception Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Return
        End Try
    End Sub

    Private Sub I_SEARCH_PLAY_TextChanged(sender As Object, e As EventArgs) Handles I_SEARCH_PLAY.TextChanged
        Try
            Dim dataset2 As New System.Data.DataSet

            Dim Keyword As String = I_SEARCH_PLAY.Text.Trim
            Dim selCategory As Integer = CInt(Me.CB_PLAYLIST.SelectedValue)

            If (selCategory > 0) Then

                'Bind the value inside list of customer into gridview
                Dim source = New BindingSource(playlistLogic.GetAllSongInPlaylistByKeyword(selCategory, Keyword), Nothing)
                GRID_IN_SONG.DataSource = playlistLogic.GetAllSongInPlaylistByKeyword(selCategory, Keyword)

                Dim block As Boolean = False

                dataset2.Clear()

                dataset2 = playlistLogic.GetAllSongInPlaylistByKeyword(selCategory, Keyword)

                GRID_IN_SONG.DataSource = dataset2.Tables(0)

            Else
                I_SEARCH_PLAY.Text = ""
                I_SEARCH_PLAY.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Exception Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        Return
        End Try
    End Sub
End Class