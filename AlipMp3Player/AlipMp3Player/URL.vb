Public Class URL

    Private Base_URL_MP3 As String
    Private Base_URL_Lyric As String

    Public Property BaseURLMP3 As String
        Get
            Return Base_URL_MP3
        End Get
        Set(value As String)
            Base_URL_MP3 = value
        End Set
    End Property

    Public Property BaseURLLyric As String
        Get
            Return Base_URL_Lyric
        End Get
        Set(value As String)
            Base_URL_Lyric = value
        End Set
    End Property

End Class
