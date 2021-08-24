Public Class Song

    Private Song_ID As Integer
    Private Song_Title As String
    Private Song_Artist As String
    Private Song_Mp3Path As String
    Private Song_LyricPath As String
    Private Song_Length As Integer
    Private Song_Cur_Duration As Integer

    Public Property SongID As Integer
        Get
            Return Song_ID
        End Get
        Set(value As Integer)
            Song_ID = value
        End Set
    End Property

    Public Property SongTitle As String
        Get
            Return Song_Title
        End Get
        Set(value As String)
            Song_Title = value
        End Set
    End Property

    Public Property SongArtist As String
        Get
            Return Song_Artist
        End Get
        Set(value As String)
            Song_Artist = value
        End Set
    End Property

    Public Property SongMp3Path As String
        Get
            Return Song_Mp3Path
        End Get
        Set(value As String)
            Song_Mp3Path = value
        End Set
    End Property

    Public Property SongLyricPath As String
        Get
            Return Song_LyricPath
        End Get
        Set(value As String)
            Song_LyricPath = value
        End Set
    End Property

    Public Property SongLength As Integer
        Get
            Return Song_Length
        End Get
        Set(value As Integer)
            Song_Length = value
        End Set
    End Property

    Public Property SongCurDuration As Integer
        Get
            Return Song_Cur_Duration
        End Get
        Set(value As Integer)
            Song_Cur_Duration = value
        End Set
    End Property


End Class
