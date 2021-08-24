Imports System.Configuration
Imports System.Data.SqlClient

Public Class CategoryLogic

    Dim constr As String = ConfigurationManager.ConnectionStrings("ConnectionString").ToString()

    Public categories As New SongCategory


    ''' <summary>
    ''' This function is used to insert song category data into database during add new process
    ''' </summary>
    ''' <returns></returns>
    Public Function InsertSongCategory() As Boolean

        Dim InsertQuery = "INSERT INTO TBL_SONG_CATEGORY " _
            & "(CATEGORY_NAME) " _
            & "VALUES " _
            & "(@category_name)"

        Using con As SqlConnection = New SqlConnection(constr)
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand(InsertQuery, con)

            cmd.Parameters.Add("@category_name", SqlDbType.VarChar).Value = categories.CategoryName.ToString

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
    ''' This function is to get list of categories from database and set into dataset
    ''' </summary>
    Public Function GetAllCategory() As DataSet

        Dim da As New System.Data.SqlClient.SqlDataAdapter
        Dim ds As New DataSet

        Try
            Using con = New SqlConnection(constr)
                con.Open()

                Dim selQuery As String = "SELECT * FROM TBL_SONG_CATEGORY"

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

    ''' <summary>
    ''' This function is to get list of categories from database and set into combobox
    ''' </summary>
    ''' <param name="cb"></param>
    Public Sub GetCategoryList(ByVal cb As ComboBox)

        Dim selQuery As String = "SELECT * FROM TBL_SONG_CATEGORY"


        Using con As SqlConnection = New SqlConnection(constr) 'Declare new connection
            con.Open() 'Open connection

            Using da As New SqlDataAdapter(selQuery, con)

                Dim dt As DataTable = New DataTable()

                cb.ValueMember = "CATEGORY_ID"
                cb.DisplayMember = "CATEGORY_NAME"

                'Bind the value inside list of category into drop down list
                da.Fill(dt)
                cb.DataSource = dt

            End Using

            cb.Text = "All Song"
            cb.SelectedIndex = -1

            con.Close()

        End Using

    End Sub

    Public Function GetCategoryById(ByVal CategoryID As String) As List(Of SongCategory)

        Dim selQuery As String = "SELECT * FROM TBL_SONG_CATEGORY WHERE CATEGORY_ID = @category_id"

        Dim categorylist As New List(Of SongCategory)

        Using con As SqlConnection = New SqlConnection(constr)
            con.Open()

            Dim cmd As SqlCommand = New SqlCommand(selQuery, con)

            cmd.Parameters.Add("@category_id", SqlDbType.Int).Value = CInt(CategoryID)

            Using dr As SqlDataReader = cmd.ExecuteReader()
                If dr.Read() Then

                    'Set data from database into object property
                    Dim item As New SongCategory()
                    item.SongCategoryID = CInt(dr("CATEGORY_ID"))
                    item.CategoryName = CType(dr("CATEGORY_NAME"), String)
                    categorylist.Add(item) 'Add all the object property into list

                End If
            End Using

            con.Close()

        End Using

        Return categorylist

    End Function


    ''' <summary>
    ''' This function is to delete category by ID selected
    ''' </summary>
    ''' <param name="CategoryID"></param>
    ''' <returns></returns>
    Public Function DeleteCategory(ByVal CategoryID As Integer) As Boolean

        Dim delQuery = "DELETE FROM TBL_SONG_CATEGORY WHERE CATEGORY_ID=@category_id "

        Using con As SqlConnection = New SqlConnection(constr)
            con.Open()

            Dim cmd As SqlCommand = New SqlCommand(delQuery, con)

            cmd.Parameters.AddWithValue("@category_id", CategoryID)

            Dim recordsAffected As Integer = cmd.ExecuteNonQuery()

            If recordsAffected > 0 Then
                categories.SongCategoryID = 0 'Remove SONG_ID object property
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
    Public Function UpdateCategory(ByVal CategoryID As Integer) As Boolean

        Dim updateQuery = "UPDATE TBL_SONG_CATEGORY " _
            & "Set  CATEGORY_NAME= @category_name" _
            & " WHERE CATEGORY_ID= @category_id"

        Using con As SqlConnection = New SqlConnection(constr)
            con.Open()

            Dim cmd As SqlCommand = New SqlCommand(updateQuery, con)

            cmd.Parameters.Add("@category_name", SqlDbType.VarChar).Value = categories.CategoryName.ToString

            cmd.Parameters.AddWithValue("@category_id", CategoryID)

            Dim recordsAffected As Integer = cmd.ExecuteNonQuery()

            If recordsAffected > 0 Then
                Return True
            Else
                Return False
            End If

            con.Close()
        End Using

    End Function


End Class
