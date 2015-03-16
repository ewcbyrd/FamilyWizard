Public Interface IEventDAO

    Function GetEvent(id As Integer) As PersonEvent
    Sub AddLocation(location As String, id As Integer)
    Sub UpdateDate(eventDate As EventDate, id As Integer)
    Function AddEvent(pe As PersonEvent) As Integer
    Sub LoadEventList()
    Sub WriteFile(filename As String)
    Sub DeleteEvent(eventId As Integer)
    Function GetEventsForIndividual(personId As Integer) As ArrayList

End Interface
