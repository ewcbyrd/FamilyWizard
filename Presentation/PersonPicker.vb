Public Class frmPersonPicker

    Private _selectedPersonIndex As Integer

    ReadOnly Property SelectedPersonIndex() As Integer
        Get
            Return _selectedPersonIndex
        End Get
    End Property

    Public Sub New(caption As String)

        _selectedPersonIndex = -1

        InitializeComponent()
        Me.Text = caption


    End Sub

    Private Sub frmPersonPicker_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ps As New PersonService
        Dim es As New EventService

        Dim list As New Dictionary(Of Integer, Person)

        lvNames.Items.Clear()

        list = ps.GetPersonList

        Dim individual As New Person

        Dim personId As Integer

        For Each personId In list.Keys
            individual = list(personId)

            Dim li As ListViewItem

            li = lvNames.Items.Add(individual.ToStringLastFirst)
            li.SubItems.Add(individual.Gender)
            'li.SubItems.Add(individual.BirthDate.ToString)
            'li.SubItems.Add(individual.DeathDate.ToString)

            Dim pe As PersonEvent
            pe = es.GetEvent(individual.BirthId)

            li.SubItems.Add(pe.EventDate.ToString)

            pe = es.GetEvent(individual.DeathId)

            li.SubItems.Add(pe.EventDate.ToString)

            li.Tag = individual.Id

        Next
    End Sub

    Private Sub lvNames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvNames.SelectedIndexChanged
        Dim items As ListView.SelectedListViewItemCollection = lvNames.SelectedItems

        For Each item As ListViewItem In items
            _selectedPersonIndex = item.Tag
        Next
    End Sub
End Class