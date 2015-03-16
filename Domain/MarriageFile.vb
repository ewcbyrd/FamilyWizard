<Serializable()>
Public Class MarriageFile

    Private _marriages As Dictionary(Of Integer, MarriageEvent)

    Public ReadOnly Property Marriages()
        Get
            Return _marriages
        End Get
    End Property

    Public Sub New(marriages As Dictionary(Of Integer, MarriageEvent))
        _marriages = marriages
    End Sub
End Class
