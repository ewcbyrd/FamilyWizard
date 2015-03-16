<Serializable()>
Public Class MarriageEvent

    Private _id As Integer
    Private _groomId As Integer
    Private _brideId As Integer
    Private _marriageDate As EventDate
    Private _marriageLocation As String

    Property Id() As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Property GroomId() As Integer
        Get
            Return _groomId
        End Get
        Set(value As Integer)
            _groomId = value
        End Set
    End Property

    Property BrideId() As Integer
        Get
            Return _brideId
        End Get
        Set(value As Integer)
            _brideId = value
        End Set
    End Property

    Property MarriageDate() As EventDate
        Get
            Return _marriageDate
        End Get
        Set(value As EventDate)
            _marriageDate = value
        End Set
    End Property

    Property MarriageLocation() As String
        Get
            Return _marriageLocation
        End Get
        Set(value As String)
            _marriageLocation = value
        End Set
    End Property

    Public Sub New()
        _groomId = 0
        _brideId = 0
        _marriageDate = New EventDate
        _marriageLocation = ""
    End Sub
End Class
