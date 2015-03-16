<Serializable()>
Public Class PersonEvent

    Private _id As Integer
    Private _eventType As String
    Private _eventDate As EventDate
    Private _eventLocation As String
    Private _personId As Integer

    Property Id() As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Property EventType() As String
        Get
            Return _eventType
        End Get
        Set(value As String)
            _eventType = value
        End Set
    End Property

    Property EventDate() As EventDate
        Get
            Return _eventDate
        End Get
        Set(value As EventDate)
            _eventDate = value
        End Set
    End Property

    Property EventLocation() As String
        Get
            Return _eventLocation
        End Get
        Set(value As String)
            _eventLocation = value
        End Set
    End Property

    Property PersonID() As Integer
        Get
            Return _personId
        End Get
        Set(value As Integer)
            _personId = value
        End Set
    End Property

    Public Sub New(ByVal id As Integer, ByVal eventType As String, ByVal eventDate As EventDate,
                   ByVal eventLocation As String, ByVal personId As Integer)

        _id = id
        _eventType = eventType
        _eventDate = eventDate
        _eventLocation = eventLocation
        _personId = personId

    End Sub

    Public Sub New()
        _id = 0
        _eventType = ""
        _eventDate = New EventDate
        _eventLocation = ""
        _personId = 0
    End Sub

End Class
