''' <summary>
''' This service provides CRUD and specialized functionality for working with the in memory event list.
''' </summary>
''' <remarks></remarks>
Public Class EventService

    ''' <summary>
    ''' The object utilized for making calls to the data access layer for the purpose of managing the in memory event list.
    ''' </summary>
    ''' <remarks></remarks>
    Private er As IEventDAO

    ''' <summary>
    ''' The public default constructor for the EventService class.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        er = New EventDAO
    End Sub

    ''' <summary>
    ''' A method for retrieving an event based upon the event's key value.
    ''' </summary>
    ''' <param name="id">The key value for the event to be retrieved.</param>
    ''' <returns>A PersonEvent object containing the requested event.</returns>
    ''' <remarks></remarks>
    Public Function GetEvent(id As Integer) As PersonEvent
        Return er.GetEvent(id)
    End Function

    ''' <summary>
    ''' A method for adding or updating a location for an existing event.
    ''' </summary>
    ''' <param name="location">The location string to store as part of the designated event.</param>
    ''' <param name="id">The key value for the event for which the location is to be added or updated.</param>
    ''' <remarks></remarks>
    Public Sub AddLocation(location As String, id As Integer)
        er.AddLocation(location, id)
    End Sub

    ''' <summary>
    ''' A method for adding or updating a date for an existin event.
    ''' </summary>
    ''' <param name="eventDate">An EventDate object containing the date specifics to be added or updated.</param>
    ''' <param name="id">The key value for the event for which the date is to be added or updated.</param>
    ''' <remarks></remarks>
    Public Sub UpdateDate(eventDate As EventDate, id As Integer)
        er.UpdateDate(eventDate, id)
    End Sub

    ''' <summary>
    ''' A method for loading the in memory event list from a file.
    ''' </summary>
    ''' <param name="fn">The filename of the events file to load.</param>
    ''' <remarks></remarks>
    Public Sub LoadEventList(fn As String)
        er.LoadEventList(fn)
    End Sub

    ''' <summary>
    ''' A method for writing the in memory event list to a file.
    ''' </summary>
    ''' <param name="filename">The name of the file to which the event list is to be written.</param>
    ''' <remarks></remarks>
    Public Sub WriteFile(filename As String)
        er.WriteFile(filename)
    End Sub

    ''' <summary>
    ''' A method for adding a new event to the in memory event list.
    ''' </summary>
    ''' <param name="pe">A PersonEvent object containing the details of the event to be added.</param>
    ''' <returns>The key value for the new event.</returns>
    ''' <remarks></remarks>
    Public Function AddEvent(pe As PersonEvent)
        Return er.AddEvent(pe)
    End Function

    ''' <summary>
    ''' A method for retrieving a list of events for a designated person.
    ''' </summary>
    ''' <param name="id">The key value of the person for which events are to be retrieved.</param>
    ''' <returns>An array list containing the retrieved list of events.</returns>
    ''' <remarks></remarks>
    Public Function GetEventsByPersonId(id As Integer) As ArrayList
        Return er.GetEventsForIndividual(id)
    End Function
End Class
