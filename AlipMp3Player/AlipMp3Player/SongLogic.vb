Imports System.Configuration
Imports System.Data.SqlClient

Public Class SongLogic

    Dim constr As String = ConfigurationManager.ConnectionStrings("ConnectionString").ToString()

    Public songs As New Song


    ''' <summary>
    ''' This function is used to insert song data into database during add new process
    ''' </summary>
    ''' <returns></returns>
    Public Function InsertSong() As Boolean

        Dim InsertQuery = "INSERT INTO TBL_SONG " _
            & "(SONG_TITLE,SONG_ARTIST,MP3_PATH,LYRIC_PATH) " _
            & "VALUES " _
            & "(@song_title,@song_artist,@mp3_path,@lyric_path)"

        Using con As SqlConnection = New SqlConnection(constr)
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand(InsertQuery, con)

            cmd.Parameters.Add("@song_title", SqlDbType.VarChar).Value = songs.SongTitle.ToString
            cmd.Parameters.Add("@song_artist", SqlDbType.VarChar).Value = songs.SongArtist.ToString
            cmd.Parameters.Add("@mp3_path", SqlDbType.VarChar).Value = songs.SongMp3Path.ToString
            cmd.Parameters.Add("@lyric_path", SqlDbType.VarChar).Value = songs.SongLyricPath.ToString

            Dim recordsAffected As Integer = cmd.ExecuteNonQuery()

            If recordsAffected > 0 Then
                Return True
            Else
                Return False
            End If

            con.Close()

        End Using
    End Function


    Public Function GetAllSong() As DataSet
        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New DataSet

        Try
            Using con = New SqlConnection(constr)
                con.Open()

                Dim selQuery As String = "SELECT * FROM TBL_SONG"

                Dim sqlcmd As New SqlCommand(selQuery, con)
                sqlcmd.CommandTimeout = 0
                da.SelectCommand = sqlcmd
                da.Fill(ds)

                Return ds
            End Using
        Catch ex As Exception
            Return ds
        Finally

        End Try

    End Function


    Public Function GetSongById(ByVal SongID As Integer) As List(Of Song)

        Dim selQuery As String = "SELECT * FROM TBL_SONG WHERE SONG_ID = @song_id"

        Dim songlist As New List(Of Song)

        Using con As SqlConnection = New SqlConnection(constr)
            con.Open()

            Dim cmd As SqlCommand = New SqlCommand(selQuery, con)

            cmd.Parameters.Add("@song_id", SqlDbType.Int).Value = CInt(SongID)

            Using dr As SqlDataReader = cmd.ExecuteReader()
                If dr.Read() Then

                    'Set data from database into object property
                    Dim item As New Song()
                    item.SongID = CInt(dr("SONG_ID"))
                    item.SongTitle = CType(dr("SONG_TITLE"), String)
                    item.SongArtist = CType(dr("SONG_ARTIST"), String)
                    item.SongMp3Path = CType(dr("MP3_PATH"), String)
                    item.SongLyricPath = CType(dr("LYRIC_PATH"), String)
                    songlist.Add(item) 'Add all the object property into list

                End If
            End Using

            con.Close()

        End Using

        Return songlist

    End Function


    ''' <summary>
    ''' This function will list all of song fetched from playlist table into list
    ''' </summary>
    ''' <returns></returns>
    Public Function GetAllSongByPlaylist(ByVal CategoryID As Integer) As DataSet

        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New DataSet

        Try
            Using con = New SqlConnection(constr)
                con.Open()

                Dim selQuery As String = "SELECT B.SONG_ID,B.SONG_TITLE,B.SONG_ARTIST,B.MP3_PATH,B.LYRIC_PATH" _
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
    ''' This function is to delete customer by ID selected
    ''' </summary>
    ''' <param name="SongID"></param>
    ''' <returns></returns>
    Public Function DeleteSong(ByVal SongID As Integer) As Boolean

        Dim delQuery = "DELETE FROM TBL_SONG WHERE SONG_ID=@song_id "

        Using con As SqlConnection = New SqlConnection(constr)
            con.Open()

            Dim cmd As SqlCommand = New SqlCommand(delQuery, con)

            cmd.Parameters.AddWithValue("@song_id", SongID)

            Dim recordsAffected As Integer = cmd.ExecuteNonQuery()

            If recordsAffected > 0 Then
                songs.SongID = 0 'Remove SONG_ID object property
                Return True
            Else
                Return False
            End If

            con.Close()

        End Using

    End Function


    ''' <summary>
    ''' This function is used to update song data in the database during detail update process
    ''' </summary>
    ''' <returns></returns>
    Public Function UpdateSong(ByVal SongID As Integer) As Boolean

        Dim updateQuery = "UPDATE TBL_SONG " _
            & "Set  SONG_TITLE= @song_title, SONG_ARTIST= @song_artist, MP3_PATH= @mp3_path, LYRIC_PATH= @lyric_path" _
            & " WHERE SONG_ID= @song_id"

        Using con As SqlConnection = New SqlConnection(constr)
            con.Open()

            Dim cmd As SqlCommand = New SqlCommand(updateQuery, con)

            cmd.Parameters.Add("@song_title", SqlDbType.VarChar).Value = songs.SongTitle.ToString
            cmd.Parameters.Add("@song_artist", SqlDbType.VarChar).Value = songs.SongArtist.ToString
            cmd.Parameters.Add("@mp3_path", SqlDbType.VarChar).Value = songs.SongMp3Path.ToString
            cmd.Parameters.Add("@lyric_path", SqlDbType.VarChar).Value = songs.SongLyricPath.ToString

            cmd.Parameters.AddWithValue("@song_id", SongID)

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
    ''' This function will list all of song by artist fetched from playlist table into list
    ''' </summary>
    ''' <returns></returns>
    Public Function GetAllSongByKeyword(ByVal Keyword As String) As DataSet

        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New DataSet

        Try
            Using con = New SqlConnection(constr)
                con.Open()

                Dim selQuery As String = "SELECT SONG_ID,SONG_TITLE,SONG_ARTIST,MP3_PATH,LYRIC_PATH" _
            & " FROM TBL_SONG" _
            & " WHERE SONG_TITLE LIKE @keyword " _
            & " OR SONG_ARTIST LIKE @keyword "

                Dim cmd As New SqlCommand(selQuery, con)

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
    ''' This function will list all of song by artist fetched from playlist table into list
    ''' </summary>
    ''' <returns></returns>
    Public Function GetAllSongByKeywordAndCategory(ByVal Keyword As String, ByVal CategoryID As Integer) As DataSet

        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New DataSet

        Try
            Using con = New SqlConnection(constr)
                con.Open()

                Dim selQuery As String = "SELECT B.SONG_ID,B.SONG_TITLE,B.SONG_ARTIST,B.MP3_PATH,B.LYRIC_PATH" _
            & " FROM TBL_SONG_PLAYLIST A" _
            & " INNER JOIN TBL_SONG B ON A.SONG_ID = B.SONG_ID" _
            & " INNER JOIN TBL_SONG_CATEGORY C ON A.CATEGORY_ID = C.CATEGORY_ID" _
            & " WHERE A.CATEGORY_ID = @category_id" _
            & " AND B.SONG_TITLE LIKE @keyword " _
            & " OR A.CATEGORY_ID = @category_id" _
            & " AND B.SONG_ARTIST LIKE @keyword "

                Dim cmd As New SqlCommand(selQuery, con)

                cmd.Parameters.AddWithValue("@keyword", "%" + Keyword + "%")
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

End Class
