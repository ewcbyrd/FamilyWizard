Public Interface IPersonDAO

    Function GetPersonList() As Dictionary(Of Integer, Person)
    Function GetPersonById(ByVal id As Integer) As Person
    Function AddPerson(person As Person) As Integer
    Sub UpdateBirthDeathId(personId As Integer, eventId As Integer, eventType As String)
    Sub AddParent(personId As Integer, parentId As Integer, parentType As String)
    Function GetChildren(fatherId As Integer, motherId As Integer) As ArrayList
    Sub LoadPersonList()
    Sub UpdatePersonsBirth(eventDate As EventDate, personId As Integer)
    Sub UpdatePersonsDeath(eventDate As EventDate, personId As Integer)
    Sub UpdatePersonsBirthLocation(location As String, personId As Integer)
    Sub UpdatePersonsDeathLocation(location As String, personId As Integer)
    Sub UpdateParents(personId As Integer, fatherId As Integer, motherId As Integer)
    Sub UpdatePersonName(personId As Integer, nameString As String)
    Sub WriteFile(filename As String)
    Function GetFilteredPersons(filterString As String) As Dictionary(Of Integer, Person)
    Sub DeletePerson(personId As Integer)
    Function GetChildrenForIndividual(personId As Integer) As ArrayList
    Function GetPersonCount() As Integer

End Interface
