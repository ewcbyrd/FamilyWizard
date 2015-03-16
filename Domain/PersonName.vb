Public Class PersonName

    Private _givenName As String
    Private _surname As String

    Property GivenName() As String
        Get
            Return _givenName
        End Get
        Set(value As String)
            _givenName = value
        End Set
    End Property

    Property Surname() As String
        Get
            Return _surname
        End Get
        Set(value As String)
            _surname = value
        End Set
    End Property

    Public Sub New(given As String, surname As String)
        _givenName = given
        _surname = surname
    End Sub

    Public Sub New()
        _givenName = ""
        _surname = ""
    End Sub


End Class
