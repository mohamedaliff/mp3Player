Public Class Player

    Private Random_Track As Boolean
    Private Repeat_Track As Boolean

    Public Property RandomTrack As Boolean
        Get
            Return Random_Track
        End Get
        Set(value As Boolean)
            Random_Track = value
        End Set
    End Property

    Public Property RepeatTrack As Boolean
        Get
            Return Repeat_Track
        End Get
        Set(value As Boolean)
            Repeat_Track = value
        End Set
    End Property

End Class
