Public Interface IMarriageDAO

    Function AddMarriage(marriage As MarriageEvent) As Integer
    Function GetMarriage(person1 As Integer, person2 As Integer) As MarriageEvent
    Sub UpdateMarriageDate(eventDate As EventDate, marriageId As Integer)
    Sub UpdateMarriageLocation(location As String, marriageId As Integer)
    Function GetSpouses(person As Person) As ArrayList
    Function GetMarriage(id As Integer) As MarriageEvent
    Sub LoadMarriages()
    Sub WriteFile(filename As String)
    Sub DeleteMarriage(marriageId As Integer)
    Function GetMarriagesForIndividual(personId As Integer) As ArrayList

End Interface
