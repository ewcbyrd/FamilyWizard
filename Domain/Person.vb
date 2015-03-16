<Serializable()> _
Public Class Person

    Private _id As Integer
    Private _surname As String
    Private _givenName As String
    Private _gender As Char
    Private _isLiving As Boolean
    Private _birthId As Integer
    Private _birth As PersonEvent
    Private _deathId As Integer
    Private _death As PersonEvent
    Private _fatherId As Integer
    Private _motherid As Integer


    Property Id() As Integer
        Get
            Return _id
        End Get

        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Property Surname() As String
        Get
            Return _surname
        End Get
        Set(ByVal value As String)
            _surname = value
        End Set
    End Property

    Property GivenName() As String
        Get
            Return _givenName
        End Get
        Set(value As String)
            _givenName = value
        End Set
    End Property

    Property Gender() As Char
        Get
            Return _gender
        End Get
        Set(value As Char)
            _gender = value
        End Set
    End Property

    Property IsLiving() As Boolean
        Get
            Return _isLiving
        End Get
        Set(value As Boolean)
            _isLiving = value
        End Set
    End Property

    Property BirthId() As Integer
        Get
            Return _birthId
        End Get
        Set(value As Integer)
            _birthId = value
        End Set
    End Property

    Property Birth() As PersonEvent
        Get
            Return _birth
        End Get
        Set(value As PersonEvent)
            _birth = value
        End Set
    End Property

    Property DeathId() As Integer
        Get
            Return _deathId
        End Get
        Set(value As Integer)
            _deathId = value
        End Set
    End Property

    Property Death() As PersonEvent
        Get
            Return _death
        End Get
        Set(value As PersonEvent)
            _death = value
        End Set
    End Property

    Property FatherId() As Integer
        Get
            Return _fatherId
        End Get
        Set(value As Integer)
            _fatherId = value
        End Set
    End Property

    Property MotherId() As Integer
        Get
            Return _motherid
        End Get
        Set(value As Integer)
            _motherid = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return _givenName & " " & _surname
    End Function

    Public Function ToStringLastFirst() As String
        Return _surname & ", " & _givenName
    End Function

    Public Sub New(ByVal value As Integer, ByVal lastName As String, ByVal givenName As String,
                   ByVal gender As Char, ByVal isLiving As Boolean)

        _id = value
        _surname = lastName
        _givenName = givenName
        _gender = gender
        _isLiving = isLiving

    End Sub

    Public Sub New()
        _id = 0
        _surname = ""
        _givenName = ""
        _gender = "?"
        _isLiving = True
        _fatherId = 0
        _motherid = 0
        _birthId = 0
        _birth = New PersonEvent
        _deathId = 0
        _death = New PersonEvent

    End Sub

End Class