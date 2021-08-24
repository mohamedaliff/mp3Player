Public Class SongCategory

    Private Song_Category_ID As Integer
    Private Category_Name As String

    Public Property SongCategoryID As Integer
        Get
            Return Song_Category_ID
        End Get
        Set(value As Integer)
            Song_Category_ID = value
        End Set
    End Property

    Public Property CategoryName As String
        Get
            Return Category_Name
        End Get
        Set(value As String)
            Category_Name = value
        End Set
    End Property

End Class
