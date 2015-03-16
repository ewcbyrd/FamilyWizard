Imports MySql.Data.MySqlClient
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO

Public Class MarriageDAO
    Implements IMarriageDAO

    Private Shared _marriageList As New Dictionary(Of Integer, MarriageEvent)

    Public Property MarriageList() As Dictionary(Of Integer, MarriageEvent)
        Get
            Return _marriageList
        End Get
        Set(value As Dictionary(Of Integer, MarriageEvent))
            _marriageList = value
        End Set
    End Property

    Public Function AddMarriage(marriage As MarriageEvent) As Integer Implements IMarriageDAO.AddMarriage

        Dim id As Integer = My.Settings.CurrentMarriageIndex

        marriage.Id = id

        _marriageList.Add(id, marriage)

        My.Settings.CurrentMarriageIndex += 1
        My.Settings.Save()

        Return id

    End Function

    Public Function GetMarriage(person1 As Integer, person2 As Integer) As MarriageEvent Implements IMarriageDAO.GetMarriage

        Dim marriages = From marriage In _marriageList _
                        Where (marriage.Value.GroomId = person1 And marriage.Value.BrideId = person2) Or _
                        (marriage.Value.GroomId = person2 And marriage.Value.BrideId = person1)

        If marriages.Count = 0 Then
            Return New MarriageEvent
        Else
            Return marriages.ElementAt(0).Value
        End If

    End Function

    Public Sub UpdateMarriageDate(eventDate As EventDate, marriageId As Integer) Implements IMarriageDAO.UpdateMarriageDate

        _marriageList(marriageId).MarriageDate = eventDate

    End Sub

    Public Sub UpdateMarriageLocation(location As String, marriageId As Integer) Implements IMarriageDAO.UpdateMarriageLocation

        _marriageList(marriageId).MarriageLocation = location

    End Sub

    Public Function GetSpouses(person As Person) As ArrayList Implements IMarriageDAO.GetSpouses

        Dim spouseIdList As New ArrayList

        Dim spouse

        If person.Gender = "M" Then
            spouse = From marriage In _marriageList _
                    Where marriage.Value.GroomId = person.Id _
                    Select marriage.Value.BrideId Distinct
        Else
            spouse = From marriage In _marriageList _
                    Where marriage.Value.BrideId = person.Id _
                    Select marriage.Value.GroomId Distinct
        End If

        For Each element In spouse
            spouseIdList.Add(element)
        Next

        Return spouseIdList

    End Function

    Public Function GetMarriage(id As Integer) As MarriageEvent Implements IMarriageDAO.GetMarriage

        Return _marriageList(id)

    End Function

    Public Sub LoadMarriages() Implements IMarriageDAO.LoadMarriages

        Dim formatter As New BinaryFormatter()

        Dim mf As MarriageFile

        Using input As New FileStream("C:\Users\Scott Byrd\OneDrive\Visual Basic\HelloWorld\marriages.dat", FileMode.Open)
            mf = CType(formatter.Deserialize(input), MarriageFile)
        End Using

        _marriageList = mf.Marriages

    End Sub

    Public Sub WriteFile(filename As String) Implements IMarriageDAO.WriteFile

        Dim formatter As New BinaryFormatter()
        Dim mf As New MarriageFile(_marriageList)

        Using output As New FileStream(filename, FileMode.Create)
            formatter.Serialize(output, mf)
        End Using

    End Sub

    Public Sub DeleteMarriage(marriageId As Integer) Implements IMarriageDAO.DeleteMarriage

        ' Deletes the designated marriage event from the marriage library

        ' Remove the marriage event from the library
        _marriageList.Remove(marriageId)

    End Sub

    Public Function GetMarriagesForIndividual(personId As Integer) As ArrayList Implements IMarriageDAO.GetMarriagesForIndividual

        Dim marriageList As New ArrayList

        Dim marriages = From item In _marriageList _
                        Where item.Value.GroomId = personId Or item.Value.BrideId = personId

        For Each item In marriages
            marriageList.Add(item.Value)
        Next

        Return marriageList

    End Function
End Class
