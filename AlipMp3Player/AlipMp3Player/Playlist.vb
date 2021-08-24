Public Class Playlist
    Private Playlist_ID As Integer
    Private Category_ID As Integer
    Private Song_ID As Integer


    Public Property PlaylistID As Integer
        Get
            Return Playlist_ID
        End Get
        Set(value As Integer)
            Playlist_ID = value
        End Set
    End Property
    Public Property CategoryID As Integer
        Get
            Return Category_ID
        End Get
        Set(value As Integer)
            Category_ID = value
        End Set
    End Property
    Public Property SongID As Integer
        Get
            Return Song_ID
        End Get
        Set(value As Integer)
            Song_ID = value
        End Set
    End Property
End Class
