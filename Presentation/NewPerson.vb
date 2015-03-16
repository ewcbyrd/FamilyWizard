Public Class frmNewPerson

    Private _nameString As String
    Private _gender As Char

    ReadOnly Property NameString() As String
        Get
            Return _nameString
        End Get
    End Property

    ReadOnly Property Gender() As Char
        Get
            Return _gender
        End Get
    End Property

    Public Sub New(caption As String, gender As String)

        _nameString = ""
        _gender = ""

        InitializeComponent()
        Me.Text = caption
        cboGender.Text = gender
    End Sub

    Private Sub frmNewPerson_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        _gender = cboGender.Text
        _nameString = txtName.Text
    End Sub

    Public Function ProcessNewPerson() As Person
        Dim personName As PersonName = NameParser.ParseName(_nameString)
        Dim person As New Person
        person.GivenName = personName.GivenName
        person.Surname = personName.Surname

        Select Case _gender
            Case "Male"
                person.Gender = "M"
            Case "Female"
                person.Gender = "F"
            Case "Unknown"
                person.Gender = "?"
        End Select

        Return person
    End Function
End Class