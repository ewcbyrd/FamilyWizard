<Serializable()>
Public Class PersonFile

    Private _persons As Dictionary(Of Integer, Person)

    Public ReadOnly Property Persons()
        Get
            Return _persons
        End Get
    End Property

    Public Sub New(persons As Dictionary(Of Integer, Person))
        _persons = persons
    End Sub

End Class
