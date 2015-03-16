<Serializable()>
Public Class EventDate

    Private _month As String
    Private _day As String
    Private _year As String
    Private _isEstimate As Boolean

    Property Month() As String
        Get
            Return _month
        End Get
        Set(value As String)
            _month = value
        End Set
    End Property

    Property Day() As String
        Get
            Return _day
        End Get
        Set(value As String)
            _day = value
        End Set
    End Property

    Property Year() As String
        Get
            Return _year
        End Get
        Set(value As String)
            _year = value
        End Set
    End Property

    Property IsEstimate() As Boolean
        Get
            Return _isEstimate
        End Get
        Set(value As Boolean)
            _isEstimate = value
        End Set
    End Property

    Public Sub New()
        _month = ""
        _day = ""
        _year = ""
        _isEstimate = False
    End Sub

    Public Sub New(ByVal month As String, ByVal day As String, ByVal year As String, ByVal isEstimate As Boolean)

        _month = month
        _day = day
        _year = year
        _isEstimate = isEstimate

    End Sub

    Public Overrides Function ToString() As String

        Dim eventDate As String = ""

        If _isEstimate Then
            eventDate = eventDate & "Abt. "
        End If

        If _month <> "" And _day <> "" And _year <> "" Then
            eventDate = eventDate & _month & " " & _day & ", " & _year
            Return eventDate
        End If

        If _month <> "" And _day <> "" And _year = "" Then
            eventDate = eventDate & _month & " " & _day
            Return eventDate
        End If

        If _month <> "" And _day = "" And _year <> "" Then
            eventDate = eventDate & _month & " " & _year
            Return eventDate
        End If

        If _month <> "" And _day = "" And _year = "" Then
            eventDate = eventDate & _month
            Return eventDate
        End If

        If _month = "" And _day = "" And _year <> "" Then
            eventDate = eventDate & _year
            Return eventDate
        End If

        Return eventDate
    End Function
End Class
