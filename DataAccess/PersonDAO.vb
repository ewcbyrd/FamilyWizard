Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO

Public Class PersonDAO
    Implements IPersonDAO

    Private Shared Property Persons As New Dictionary(Of Integer, Person)
    
    Public Function GetPersonById(id As Integer) As Person Implements IPersonDAO.GetPersonById

        Return Persons(id)

    End Function

    Public Function GetPersonList() As Dictionary(Of Integer, Person) Implements IPersonDAO.GetPersonList
        Return Persons
    End Function

    Public Function GetPersonList(fn As String) As Dictionary(Of Integer, Person) Implements IPersonDAO.GetPersonList

        Dim formatter As New BinaryFormatter()

        Dim pf As PersonFile

        Using input As New FileStream(fn, FileMode.Open)
            pf = CType(formatter.Deserialize(input), PersonFile)
        End Using

        Return pf.Persons

    End Function

    Public Function AddPerson(person As Person) As Integer Implements IPersonDAO.AddPerson

        ' Determine next available person index and assign it to id
        Dim id As Integer = My.Settings.CurrentPersonIndex

        ' Assign id to the id attribute of the person to add
        person.Id = id

        ' Add the person to the Persons dictionary
        Persons.Add(id, person)

        ' Log addition of new person
        My.Application.Log.WriteEntry(Now & ": Added " & person.ToString & " as ID # " & person.Id)

        ' Check to see if this is the first person in the Persons dictionary
        If Persons.Count = 1 Then ' First person added

            ' Set the default person to the newly added individual
            'frmMainForm.DataFile.DefaultPersonIndex = person.Id

        End If

        ' Increment the index that will be assigned to the next person added
        My.Settings.CurrentPersonIndex += 1

        My.Settings.Save()

        My.Application.Log.WriteEntry(Now & ":CurrentPersonIndex incremented to " & My.Settings.CurrentPersonIndex)

        ' Return the indentifier of the newly added person
        Return id

    End Function

    Sub UpdateBirthDeathId(personId As Integer, eventId As Integer, eventType As String) Implements IPersonDAO.UpdateBirthDeathId

        If eventType.ToLower = "birth" Then

            Persons(personId).BirthId = eventId

            My.Application.Log.WriteEntry(Now & ": BirthId set to " & eventId & " for person ID # " & personId)

        Else

            Persons(personId).DeathId = eventId

            My.Application.Log.WriteEntry(Now & ": DeathId set to " & eventId & " for person ID # " & personId)

        End If

    End Sub

    Public Sub AddParent(personId As Integer, parentId As Integer, parentType As String) Implements IPersonDAO.AddParent

        If parentType = "father" Then
            Persons(personId).FatherId = parentId

            My.Application.Log.WriteEntry(Now & ": FatherId set to " & parentId & " for person ID # " & personId)

        Else

            Persons(personId).MotherId = parentId

            My.Application.Log.WriteEntry(Now & ": MotherId set to " & parentId & " for person ID # " & personId)

        End If

    End Sub

    Public Function GetChildren(fatherId As Integer, motherId As Integer) As ArrayList Implements IPersonDAO.GetChildren

        Dim personList As New ArrayList

        Dim children = From individual In Persons _
                    Where individual.Value.FatherId = fatherId And individual.Value.MotherId = motherId
                    Order By individual.Value.Birth.EventDate.Year


        For Each child In children
            personList.Add(child.Value)
        Next

        Return personList

    End Function

    Public Sub LoadPersonList(fn As String) Implements IPersonDAO.LoadPersonList
        Persons = GetPersonList(fn)
    End Sub

    Public Sub UpdatePersonsBirth(eventDate As EventDate, personId As Integer) Implements IPersonDAO.UpdatePersonsBirth

        Persons(personId).Birth.EventDate = eventDate

        My.Application.Log.WriteEntry(Now & ": Birth set to " & eventDate.ToString & " for ID # " & personId)

    End Sub

    Public Sub UpdatePersonsDeath(eventDate As EventDate, personId As Integer) Implements IPersonDAO.UpdatePersonsDeath

        Persons(personId).Death.EventDate = eventDate

        My.Application.Log.WriteEntry(Now & ": Death set to " & eventDate.ToString & " for ID # " & personId)

    End Sub

    Public Sub UpdatePersonsBirthLocation(location As String, personId As Integer) Implements IPersonDAO.UpdatePersonsBirthLocation

        Persons(personId).Birth.EventLocation = location
        My.Application.Log.WriteEntry(Now & ": Birth location set to " & location & " for ID # " & personId)

    End Sub

    Public Sub UpdatePersonsDeathLocation(location As String, personId As Integer) Implements IPersonDAO.UpdatePersonsDeathLocation

        Persons(personId).Death.EventLocation = location
        My.Application.Log.WriteEntry(Now & ": Death location set to " & location & " for ID # " & personId)

    End Sub

    Sub UpdateParents(personId As Integer, fatherId As Integer, motherId As Integer) Implements IPersonDAO.UpdateParents

        Persons(personId).FatherId = fatherId
        Persons(personId).MotherId = motherId

        My.Application.Log.WriteEntry(Now & ": Father set to " & fatherId & " mother set to " & motherId & " for ID # " & personId)

    End Sub

    Public Sub WriteFile(filename As String) Implements IPersonDAO.WriteFile

        Dim formatter As New BinaryFormatter()
        Dim pf As New PersonFile(_Persons)

        Using output As New FileStream(filename, FileMode.Create)
            formatter.Serialize(output, pf)
        End Using

        My.Application.Log.WriteEntry(Now & ": Person file saved")

    End Sub

    Public Sub UpdatePersonName(personId As Integer, nameString As String) Implements IPersonDAO.UpdatePersonName

        Dim pn As PersonName = NameParser.ParseName(nameString)

        Persons(personId).GivenName = pn.GivenName
        Persons(personId).Surname = pn.Surname

        My.Application.Log.WriteEntry(Now & ": Name set to " & Persons(personId).ToString & " for ID # " & personId)

    End Sub

    Public Function GetFilteredPersons(filterString As String) As Dictionary(Of Integer, Person) Implements IPersonDAO.GetFilteredPersons

        Dim filteredPersons As New Dictionary(Of Integer, Person)

        Dim filteredList = From individual In Persons _
                           Where individual.Value.ToStringLastFirst.ToLower.StartsWith(filterString.ToLower)

        For Each individual In filteredList
            filteredPersons.Add(individual.Value.Id, individual.Value)
        Next

        Return filteredPersons

    End Function

    Public Sub DeletePerson(personId As Integer) Implements IPersonDAO.DeletePerson

        ' Deletes a person from the person list.  Person to be deleted is indentified by their ID.

        ' Remove designated person from list
        Persons.Remove(personId)

        My.Application.Log.WriteEntry(Now & ": Person ID # " & personId & " removed")

    End Sub

    Public Function GetChildrenForIndividual(personId As Integer) As ArrayList Implements IPersonDAO.GetChildrenForIndividual

        Dim childIdList As New ArrayList

        Dim children = From child In Persons _
                       Where child.Value.FatherId = personId Or child.Value.MotherId = personId

        For Each child In children
            childIdList.Add(child.Value)
        Next

        Return childIdList

    End Function

    Public Function GetPersonCount() As Integer Implements IPersonDAO.GetPersonCount
        Return Persons.Count
    End Function
End Class
