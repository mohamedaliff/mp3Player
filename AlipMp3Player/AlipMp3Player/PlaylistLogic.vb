Imports System.Configuration
Imports System.Data.SqlClient

Public Class PlaylistLogic
    Dim constr As String = ConfigurationManager.ConnectionStrings("ConnectionString").ToString()

    Public playlists As New Playlist

    ''' <summary>
    ''' This function is used to insert song data into database during add new process
    ''' </summary>
    ''' <returns></returns>
    Public Function InsertPlaylist() As Boolean

        Dim InsertQuery = "INSERT INTO TBL_SONG_PLAYLIST " _
            & "(SONG_ID,CATEGORY_ID) " _
            & "VALUES " _
            & "(@song_id,@category_id)"

        Using con As SqlConnection = New SqlConnection(constr)
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand(InsertQuery, con)

            cmd.Parameters.Add("@song_id", SqlDbType.Int).Value = playlists.SongID
            cmd.Parameters.Add("@category_id", SqlDbType.Int).Value = playlists.CategoryID

            Dim recordsAffected As Integer = cmd.ExecuteNonQuery()

            If recordsAffected > 0 Then
                Return True
            Else
                Return False
            End If

            con.Close()

        End Using
    End Function


    ''' <summary>
    ''' This function will list all of song fetched from playlist table into list
    ''' </summary>
    ''' <returns></returns>
    Public Function GetAllSongInPlaylist(ByVal CategoryID As Integer) As DataSet

        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New DataSet

        Try
            Using con = New SqlConnection(constr)
                con.Open()

                Dim selQuery As String = "SELECT B.SONG_ID,B.SONG_TITLE,B.SONG_ARTIST" _
            & " FROM TBL_SONG_PLAYLIST A" _
            & " INNER JOIN TBL_SONG B ON A.SONG_ID = B.SONG_ID" _
            & " INNER JOIN TBL_SONG_CATEGORY C ON A.CATEGORY_ID = C.CATEGORY_ID" _
            & " WHERE A.CATEGORY_ID = @category_id"

                Dim cmd As New SqlCommand(selQuery, con)

                cmd.Parameters.AddWithValue("@category_id", CategoryID)

                cmd.CommandTimeout = 0
                da.SelectCommand = cmd
                da.Fill(ds)

                Return ds
            End Using
        Catch ex As Exception
            Return ds
        Finally

        End Try

    End Function



    ''' <summary>
    ''' This function will list all of song not in playlist table into list
    ''' </summary>
    ''' <returns></returns>
    Public Function GetAllSongNotInPlaylist(ByVal CategoryID As Integer) As DataSet

        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New DataSet

        Try
            Using con = New SqlConnection(constr)
                con.Open()

                Dim selQuery As String = "SELECT SONG_ID,SONG_TITLE,SONG_ARTIST FROM TBL_SONG" _
            & " WHERE SONG_ID NOT IN" _
            & " (SELECT SONG_ID FROM TBL_SONG_PLAYLIST WHERE CATEGORY_ID =  @category_id)"

                Dim cmd As New SqlCommand(selQuery, con)

                cmd.Parameters.AddWithValue("@category_id", CategoryID)

                cmd.CommandTimeout = 0
                da.SelectCommand = cmd
                da.Fill(ds)

                Return ds
            End Using
        Catch ex As Exception
            Return ds
        Finally

        End Try

    End Function


    ''' <summary>
    ''' This function will list all of song fetched from playlist table into list
    ''' </summary>
    ''' <returns></returns>
    Public Function GetAllSongInPlaylistByKeyword(ByVal CategoryID As Integer, ByVal Keyword As String) As DataSet

        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New DataSet

        Try
            Using con = New SqlConnection(constr)
                con.Open()

                Dim selQuery As String = "SELECT B.SONG_ID,B.SONG_TITLE,B.SONG_ARTIST" _
            & " FROM TBL_SONG_PLAYLIST A" _
            & " INNER JOIN TBL_SONG B ON A.SONG_ID = B.SONG_ID" _
            & " INNER JOIN TBL_SONG_CATEGORY C ON A.CATEGORY_ID = C.CATEGORY_ID" _
            & " WHERE A.CATEGORY_ID = @category_id" _
            & " AND SONG_TITLE LIKE @keyword " _
            & " OR A.CATEGORY_ID = @category_id" _
            & " AND SONG_ARTIST LIKE @keyword "

                Dim cmd As New SqlCommand(selQuery, con)

                cmd.Parameters.AddWithValue("@category_id", CategoryID)
                cmd.Parameters.AddWithValue("@keyword", "%" + Keyword + "%")

                cmd.CommandTimeout = 0
                da.SelectCommand = cmd
                da.Fill(ds)

                Return ds
            End Using
        Catch ex As Exception
            Return ds
        Finally

        End Try

    End Function


    ''' <summary>
    ''' This function will list all of song not in playlist table into list
    ''' </summary>
    ''' <returns></returns>
    Public Function GetAllSongNotInPlaylistByKeyword(ByVal CategoryID As Integer, ByVal Keyword As String) As DataSet

        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New DataSet

        Try
            Using con = New SqlConnection(constr)
                con.Open()

                Dim selQuery As String = "SELECT SONG_ID,SONG_TITLE,SONG_ARTIST" _
                & " FROM TBL_SONG" _
                & " WHERE SONG_ID NOT IN" _
                & " (SELECT SONG_ID FROM TBL_SONG_PLAYLIST WHERE CATEGORY_ID =  @category_id)" _
                & " AND SONG_TITLE LIKE @keyword " _
                & " OR SONG_ID NOT IN" _
                & " (SELECT SONG_ID FROM TBL_SONG_PLAYLIST WHERE CATEGORY_ID =  @category_id)" _
                & " AND SONG_TITLE LIKE @keyword "

                Dim cmd As New SqlCommand(selQuery, con)

                cmd.Parameters.AddWithValue("@category_id", CategoryID)
                cmd.Parameters.AddWithValue("@keyword", "%" + Keyword + "%")

                cmd.CommandTimeout = 0
                da.SelectCommand = cmd
                da.Fill(ds)

                Return ds
            End Using
        Catch ex As Exception
            Return ds
        Finally

        End Try

    End Function


    ''' <summary>
    ''' This function is to delete customer by ID selected
    ''' </summary>
    ''' <param name="SongID"></param>
    ''' <returns></returns>
    Public Function DeleteSong(ByVal SongID As Integer, ByVal CategoryID As Integer) As Boolean

        Dim delQuery = "DELETE FROM TBL_SONG_PLAYLIST WHERE SONG_ID = @song_id AND CATEGORY_ID =  @category_id"

        Using con As SqlConnection = New SqlConnection(constr)
            con.Open()

            Dim cmd As SqlCommand = New SqlCommand(delQuery, con)

            cmd.Parameters.AddWithValue("@song_id", SongID)
            cmd.Parameters.AddWithValue("@category_id", CategoryID)

            Dim recordsAffected As Integer = cmd.ExecuteNonQuery()

            If recordsAffected > 0 Then
                playlists.SongID = 0 'Remove SONG_ID object property
                Return True
            Else
                Return False
            End If

            con.Close()

        End Using

    End Function

End Class
