﻿Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO

Public Class EventDAO
    Implements IEventDAO

    Private Shared _eventList As New Dictionary(Of Integer, PersonEvent)

    Public Property EventList() As Dictionary(Of Integer, PersonEvent)
        Get
            Return _eventList
        End Get
        Set(ByVal value As Dictionary(Of Integer, PersonEvent))
            _eventList = value
        End Set
    End Property

    Public Function GetEvent(id As Integer) As PersonEvent Implements IEventDAO.GetEvent

        Return DirectCast(_eventList(id), PersonEvent)

    End Function

    Public Sub AddLocation(location As String, id As Integer) Implements IEventDAO.AddLocation

        _eventList(id).EventLocation = location

        My.Application.Log.WriteEntry(Now & ": Location set to " & location & " for event # " & id)

    End Sub

    Public Sub UpdateDate(eventDate As EventDate, id As Integer) Implements IEventDAO.UpdateDate

        _eventList(id).EventDate = eventDate

        My.Application.Log.WriteEntry(Now & ": Date set to " & eventDate.ToString & " for event # " & id)

    End Sub

    Public Function AddEvent(pe As PersonEvent) As Integer Implements IEventDAO.AddEvent

        Dim id As Integer = My.Settings.CurrentEventIndex

        pe.Id = id

        _eventList.Add(id, pe)

        My.Application.Log.WriteEntry(Now & ": New " & pe.EventType & " added as ID # " & pe.Id)

        My.Settings.CurrentEventIndex += 1

        My.Settings.Save()

        My.Application.Log.WriteEntry(Now & ": CurrentEventIndex incremented to " & My.Settings.CurrentEventIndex)

        Return id

    End Function

    Public Sub LoadEventList(fn As String) Implements IEventDAO.LoadEventList

        Dim formatter As New BinaryFormatter()

        Dim ef As EventFile

        Using input As New FileStream(fn, FileMode.Open)
            ef = CType(formatter.Deserialize(input), EventFile)
        End Using

        _eventList = ef.Events

    End Sub

    Public Sub WriteFile(filename As String) Implements IEventDAO.WriteFile

        Dim formatter As New BinaryFormatter()
        Dim ef As New EventFile(_eventList)

        Using output As New FileStream(filename, FileMode.Create)
            formatter.Serialize(output, ef)
        End Using

        My.Application.Log.WriteEntry(Now & ": Event file saved")

    End Sub

    Public Sub DeleteEvent(eventId As Integer) Implements IEventDAO.DeleteEvent

        ' Deletes the designated event from the events library

        ' Remove the event from the event list
        _eventList.Remove(eventId)

        My.Application.Log.WriteEntry(Now & ": Event # " & eventId & " removed")

    End Sub
    Public Function GetEventsForIndividual(personId As Integer) As ArrayList Implements IEventDAO.GetEventsForIndividual

        Dim eventsList As New ArrayList

        Dim events = From item In _eventList _
                     Where item.Value.PersonID = personId

        For Each item In events
            eventsList.Add(item.Value)
        Next

        Return eventsList

    End Function
End Class
