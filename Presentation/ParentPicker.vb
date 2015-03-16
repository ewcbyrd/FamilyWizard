Public Class frmParentPicker

    Private _selectedSpouseIndex As Integer
    Private _focusPerson As Person

    Public ReadOnly Property SelectedSpouseIndex()
        Get
            Return _selectedSpouseIndex
        End Get
    End Property


    Private Sub frmParentPicker_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ps As New PersonService
        Dim spouseList As ArrayList = ps.GetSpouses(_focusPerson)
        Dim li As ListViewItem

        For Each spouse As Integer In spouseList
            li = lvParents.Items.Add(_focusPerson.ToString & " and " & ps.GetPersonById(spouse).ToString)
            li.Tag = spouse
        Next

        li = lvParents.Items.Add(_focusPerson.ToString & " and Unknown Person")
        li.Tag = 0

        lvParents.Select()

        lvParents.Items(0).Selected = True

        _selectedSpouseIndex = lvParents.Items(0).Tag

    End Sub

    Public Sub New(focusPerson As Person)
        _focusPerson = focusPerson
        InitializeComponent()
    End Sub

    Private Sub lvParents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvParents.SelectedIndexChanged
        Dim items As ListView.SelectedListViewItemCollection = lvParents.SelectedItems

        For Each item As ListViewItem In items
            _selectedSpouseIndex = item.Tag
        Next
    End Sub
End Class