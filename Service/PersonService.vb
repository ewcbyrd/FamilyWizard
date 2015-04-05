Public Class PersonService

    Private pr As IPersonDAO
    Private er As IEventDAO
    Private mr As IMarriageDAO

    Public Sub New()
        pr = New PersonDAO
        er = New EventDAO
        mr = New MarriageDAO
    End Sub

    Public Function GetPersonList(fn As String) As Dictionary(Of Integer, Person)
        Return pr.GetPersonList(fn)
    End Function

    Public Function GetPersonList() As Dictionary(Of Integer, Person)
        Return pr.GetPersonList()
    End Function

    Public Function GetPersonById(id As Integer) As Person
        Return pr.GetPersonById(id)
    End Function

    Public Function GetFather(id As Integer) As Person
        Dim child As Person
        Dim father As Person

        child = GetPersonById(id)

        father = GetPersonById(child.FatherId)

        Return father
    End Function

    Public Function GetMother(id As Integer) As Person
        Dim child As Person
        Dim mother As Person

        child = GetPersonById(id)

        mother = GetPersonById(child.MotherId)

        Return mother
    End Function

    Public Function GetAncestors(id As Integer) As Dictionary(Of Integer, Person)

        Dim ancestors As New Dictionary(Of Integer, Person)

        ancestors.Add(1, pr.GetPersonById(id))

        For individual As Integer = 1 To 7

            Dim person As New Person
            person = ancestors(individual)

            If person IsNot Nothing Then

                Dim personId As Integer = person.Id

                If person.FatherId <> 0 Then
                    ancestors.Add(individual * 2, GetFather(personId))
                Else
                    ancestors.Add(individual * 2, New Person)
                End If

                If person.MotherId <> 0 Then
                    ancestors.Add(individual * 2 + 1, GetMother(personId))
                Else
                    ancestors.Add(individual * 2 + 1, New Person)
                End If
            Else
                ancestors.Add(individual * 2, New Person)
                ancestors.Add(individual * 2 + 1, New Person)
            End If


        Next

        Return ancestors

    End Function

    Public Function GetChildren(fatherId As Integer, motherId As Integer) As ArrayList

        Return pr.GetChildren(fatherId, motherId)

    End Function

    Public Function GetSpouses(person As Person) As ArrayList

        Return mr.GetSpouses(person)

    End Function

    Public Function AddPerson(person As Person) As Integer

        Dim personId As Integer = pr.AddPerson(person)

        Dim birthEvent As New PersonEvent With {.EventType = "BIRTH-PRI", .PersonID = personId}

        Dim birthId As Integer = er.AddEvent(birthEvent)

        pr.UpdateBirthDeathId(personId, birthId, "birth")

        Dim deathEvent As New PersonEvent With {.EventType = "DEATH-PRI", .PersonID = personId}

        Dim deathId As Integer = er.AddEvent(deathEvent)

        pr.UpdateBirthDeathId(personId, deathId, "death")

        Return personId

    End Function

    Public Function AddMarriage(groomId As Integer, brideId As Integer)

        Dim marriage As New MarriageEvent With {.GroomId = groomId, .BrideId = brideId}

        Return mr.AddMarriage(marriage)

    End Function

    Public Function GetMarriage(groomId As Integer, brideId As Integer) As MarriageEvent
        Return mr.GetMarriage(groomId, brideId)
    End Function

    Public Sub UpdateMarriageLocation(location As String, marriageId As Integer)
        mr.UpdateMarriageLocation(location, marriageId)
    End Sub

    Public Sub UpdateMarriageDate(marriageDate As EventDate, marriageId As Integer)
        mr.UpdateMarriageDate(marriageDate, marriageId)
    End Sub

    Public Sub AddParent(personId As Integer, parentId As Integer, parentType As String)
        pr.AddParent(personId, parentId, parentType)
    End Sub

    Public Function GetMarriage(id As Integer) As MarriageEvent
        Return mr.GetMarriage(id)
    End Function

    Public Sub LoadPersonList(fn As String)
        pr.LoadPersonList(fn)
    End Sub

    Public Sub LoadMarriageList(fn As String)
        mr.LoadMarriages(fn)
    End Sub

    Public Sub UpdatePersonsBirth(eventDate As EventDate, personId As Integer)
        pr.UpdatePersonsBirth(eventDate, personId)
    End Sub

    Public Sub UpdatePersonsDeath(eventDate As EventDate, personId As Integer)
        pr.UpdatePersonsDeath(eventDate, personId)
    End Sub

    Public Sub UpdatePersonsBirthLocation(location As String, personId As Integer)
        pr.UpdatePersonsBirthLocation(location, personId)
    End Sub

    Public Sub UpdatePersonsDeathLocation(location As String, personId As Integer)
        pr.UpdatePersonsDeathLocation(location, personId)
    End Sub

    Sub UpdateParents(personId As Integer, fatherId As Integer, motherId As Integer)
        pr.UpdateParents(personId, fatherId, motherId)
    End Sub

    Public Sub WritePersonFile(filename As String)
        pr.WriteFile(filename)
    End Sub

    Public Sub WriteMarriageFile(filename As String)
        mr.WriteFile(filename)
    End Sub

    Public Sub UpdatePersonName(personId As Integer, nameString As String)
        pr.UpdatePersonName(personId, nameString)
    End Sub

    Public Function GetFilteredPersons(filterString As String) As Dictionary(Of Integer, Person)
        Return pr.GetFilteredPersons(filterString)
    End Function

    Public Sub DeletePerson(person As Person)

        ' Delete events for person to be deleted
        Dim eventList As ArrayList = er.GetEventsForIndividual(person.Id)

        For Each item In eventList
            Dim currentEvent As PersonEvent = DirectCast(item, PersonEvent)
            er.DeleteEvent(currentEvent.Id)
        Next

        ' Remove reference to individual as parent
        Dim childList As ArrayList = pr.GetChildrenForIndividual(person.Id)

        For Each child In childList
            Dim currentChild As Person = DirectCast(child, Person)
            If person.Gender = "M" Then
                pr.UpdateParents(currentChild.Id, 0, currentChild.MotherId)
            Else
                pr.UpdateParents(currentChild.Id, currentChild.FatherId, 0)
            End If
        Next

        ' Remove marriages for individual
        Dim marriageList As ArrayList = mr.GetMarriagesForIndividual(person.Id)

        For Each marriage In marriageList
            Dim currentMarriage As MarriageEvent = DirectCast(marriage, MarriageEvent)
            mr.DeleteMarriage(currentMarriage.Id)
        Next

        ' Remove individual from person library
        pr.DeletePerson(person.Id)

    End Sub

    Public Function GetPersonCount() As Integer
        Return pr.GetPersonCount
    End Function

    Public Function GetMarriageList(person As Person) As ArrayList

        Dim marriageList As New ArrayList

        Dim spouseList As ArrayList = GetSpouses(person)

        If spouseList.Count > 0 Then
            For Each item As Integer In spouseList

                Dim marriage As New Marriage

                marriage.Spouse = GetPersonById(item)

                If person.Gender = "M" Then
                    marriage.Marriage = GetMarriage(person.Id, marriage.Spouse.Id)
                Else
                    marriage.Marriage = GetMarriage(marriage.Spouse.Id, person.Id)
                End If

                marriageList.Add(marriage)

            Next

            Return marriageList
        Else

            Return Nothing

        End If

    End Function
End Class
