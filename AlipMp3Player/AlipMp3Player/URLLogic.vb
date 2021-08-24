Imports System.Configuration
Imports System.Data.SqlClient

Public Class URLLogic

    Dim constr As String = ConfigurationManager.ConnectionStrings("ConnectionString").ToString()

    Public baseurl As New URL

    ''' <summary>
    ''' This function is used to insert url data into database during add new process
    ''' </summary>
    ''' <returns></returns>
    Public Function InsertBaseURL() As Boolean

        Dim selQuery As String = "SELECT * FROM TBL_URL"
        Dim InsertQuery = "INSERT INTO TBL_URL " _
            & "(BASE_URL_MP3, BASE_URL_LYRIC) " _
            & "VALUES " _
            & "(@base_url_mp3, @base_url_lyric)"
        Dim updateQuery = "UPDATE TBL_URL " _
            & "Set BASE_URL_MP3= @base_url_mp3, BASE_URL_LYRIC=@base_url_lyric"

        Using con As SqlConnection = New SqlConnection(constr)
            con.Open()

            Dim cmd As SqlCommand = New SqlCommand(selQuery, con)

            Using dr As SqlDataReader = cmd.ExecuteReader()
                If dr.Read() Then

                    Dim cmdUpdate As SqlCommand = New SqlCommand(updateQuery, con)

                    cmdUpdate.Parameters.Add("@base_url_mp3", SqlDbType.VarChar).Value = baseurl.BaseURLMP3.ToString
                    cmdUpdate.Parameters.Add("@base_url_lyric", SqlDbType.VarChar).Value = baseurl.BaseURLLyric.ToString

                    Dim recordsAffected As Integer = cmdUpdate.ExecuteNonQuery()

                    If recordsAffected > 0 Then
                        Return True
                    Else
                        Return False
                    End If

                Else

                    Dim cmdInsert As SqlCommand = New SqlCommand(InsertQuery, con)

                    cmdInsert.Parameters.Add("@base_url_mp3", SqlDbType.VarChar).Value = baseurl.BaseURLMP3.ToString
                    cmdInsert.Parameters.Add("@base_url_lyric", SqlDbType.VarChar).Value = baseurl.BaseURLLyric.ToString

                    Dim recordsAffected As Integer = cmdInsert.ExecuteNonQuery()

                    If recordsAffected > 0 Then
                        Return True
                    Else
                        Return False
                    End If

                End If
            End Using

            con.Close()

        End Using




    End Function


    ''' <summary>
    ''' This function is to get list of url from database and set into dataset
    ''' </summary>
    Public Function GetBaseURL() As List(Of URL)

        Dim selQuery As String = "SELECT * FROM TBL_URL"

        Dim urllist As New List(Of URL)

        Using con As SqlConnection = New SqlConnection(constr)
            con.Open()

            Dim cmd As SqlCommand = New SqlCommand(selQuery, con)

            Using dr As SqlDataReader = cmd.ExecuteReader()
                If dr.Read() Then

                    'Set data from database into object property
                    Dim item As New URL()
                    item.BaseURLMP3 = CType(dr("BASE_URL_MP3"), String)
                    item.BaseURLLyric = CType(dr("BASE_URL_LYRIC"), String)
                    urllist.Add(item) 'Add all the object property into list

                Else
                    'Set data from database into object property
                    Dim item As New URL()
                    item.BaseURLMP3 = ""
                    item.BaseURLLyric = ""
                    urllist.Add(item) 'Add all the object property into list
                End If
            End Using

            con.Close()

        End Using

        Return urllist

    End Function



End Class
