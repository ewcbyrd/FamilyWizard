Public Class PersonReaderFile
    Implements IPersonDAO

    Private _personList As Hashtable

    Property PersonList() As Hashtable
        Get
            Return _personList
        End Get
        Set(value As Hashtable)
            _personList = value
        End Set
    End Property

    Public Sub New()

        _personList = New Hashtable

        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("C:\Users\Scott Byrd\OneDrive\Visual Basic\HelloWorld\persons.txt")

            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")

            Dim fields(6) As String
            Dim i As Integer

            i = 0

            Dim currentRow As String()
            While Not MyReader.EndOfData
                Try
                    currentRow = MyReader.ReadFields()
                    Dim currentField As String
                    For Each currentField In currentRow
                        fields(i) = currentField
                        i = i + 1
                    Next

                    Dim currentPerson As New Person With
                        {
                            .Id = fields(0),
                            .Surname = fields(1),
                            .GivenName = fields(2),
                            .Gender = fields(3),
                            .IsLiving = fields(4),
                            .FatherId = fields(5),
                            .MotherId = fields(6)
                        }

                    _personList.Add(currentPerson.Id, currentPerson)

                    i = 0



                Catch ex As Microsoft.VisualBasic.
                            FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message &
                    "is not valid and will be skipped.")
                End Try
            End While
        End Using
    End Sub

    Public Function GetPersonList() As Dictionary(Of Integer, Person) Implements IPersonDAO.GetPersonList

        Return _personList
    End Function

    Public Function GetPersonById(ByVal id As Integer) As Person Implements IPersonDAO.GetPersonById

        Return _personList(id)

    End Function

    Public Function GetSpouses(id As Integer) As ArrayList Implements IPersonDAO.GetSpouses
        Return New ArrayList
    End Function

    Public Function AddPerson(person As Person) As Integer Implements IPersonDAO.AddPerson
        Return 0
    End Function

    Sub UpdateBirthDeathId(personId As Integer, eventId As Integer, eventType As String) Implements IPersonDAO.UpdateBirthDeathId

    End Sub

    Public Sub AddParent(personId As Integer, parentId As Integer, parentType As String) Implements IPersonDAO.AddParent

    End Sub

    Public Function GetChildren(fatherId As Integer, motherId As Integer) As ArrayList Implements IPersonDAO.GetChildren
        Return New ArrayList
    End Function

    Sub LoadPersonList() Implements IPersonDAO.LoadPersonList

    End Sub
End Class
