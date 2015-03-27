Public Class EventService

    Private er As IEventDAO

    Public Sub New()
        er = New EventDAO
    End Sub

    Public Function GetEvent(id As Integer) As PersonEvent
        Return er.GetEvent(id)
    End Function

    Public Sub AddLocation(location As String, id As Integer)
        er.AddLocation(location, id)
    End Sub

    Public Sub UpdateDate(eventDate As EventDate, id As Integer)
        er.UpdateDate(eventDate, id)
    End Sub

    Public Sub LoadEventList(fn As String)
        er.LoadEventList(fn)
    End Sub

    Public Sub WriteFile(filename As String)
        er.WriteFile(filename)
    End Sub
End Class
