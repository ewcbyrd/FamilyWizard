<Serializable()>
Public Class EventFile

    Private _events As Dictionary(Of Integer, PersonEvent)

    Public ReadOnly Property Events()
        Get
            Return _events
        End Get
    End Property

    Public Sub New(events As Dictionary(Of Integer, PersonEvent))
        _events = events
    End Sub
End Class
